# Generates one xUnit project per LeetCode problem from tools/problems/*.txt, plus DSA.slnx and README.md.
# Projects go to src/LeetCode/<0000>-<Name>/ (number first, so they sort).
# NeetCode-only exercises are hand-written in src/NeetCode/<Name>/ and only listed in DSA.slnx.
# Safe to re-run: an existing Solution.cs (your work) is never overwritten.
# Tests, csproj, README and helper files are regenerated each time.
#
# Data format (per topic file):
#   %% <topicNo> | <Topic Name>
#   @@ <leetcodeNo> | <Title> | <Easy|Medium|Hard> | <lc|nc> | <leetcode-slug> | <neetcode-slug> [| <ShortName>]
#   ## Solution
#   ...C# stub...
#   ## Tests
#   ...xUnit test members...
#
# ShortName is optional; it names the project when the full title is too long.
# Helper classes (ListNode, TreeNode, AssertEx, Lc) are copied from tools/templates into each
# project that uses them - there is no shared project.

$ErrorActionPreference = 'Stop'
$root = Split-Path -Parent $PSScriptRoot
$templates = Join-Path $PSScriptRoot 'templates'
$utf8 = New-Object System.Text.UTF8Encoding($false)

function ConvertTo-Pascal([string]$s) {
    $parts = ($s -replace "[^A-Za-z0-9]+", ' ').Trim().Split(' ', [StringSplitOptions]::RemoveEmptyEntries)
    ($parts | ForEach-Object { $_.Substring(0, 1).ToUpper() + $_.Substring(1) }) -join ''
}

function Write-Utf8([string]$path, [string]$text) {
    $dir = Split-Path -Parent $path
    if (-not (Test-Path $dir)) { New-Item -ItemType Directory -Force $dir | Out-Null }
    [IO.File]::WriteAllText($path, ($text -replace "`r?`n", "`r`n"), $utf8)
}

function Get-Template([string]$name, [string]$ns) {
    [IO.File]::ReadAllText((Join-Path $templates "$name.cs.txt")).Replace('__NS__', $ns)
}

# ---------- parse ----------
$problems = New-Object System.Collections.Generic.List[object]
$files = Get-ChildItem (Join-Path $PSScriptRoot 'problems') -Filter *.txt | Sort-Object Name
foreach ($f in $files) {
    $topicNo = $null; $topic = $null; $cur = $null; $section = $null
    foreach ($line in [IO.File]::ReadAllLines($f.FullName)) {
        if ($line.StartsWith('%% ')) {
            $p = $line.Substring(3).Split('|') | ForEach-Object { $_.Trim() }
            $topicNo = $p[0]; $topic = $p[1]; continue
        }
        if ($line.StartsWith('@@ ')) {
            $p = @($line.Substring(3).Split('|') | ForEach-Object { $_.Trim() })
            $cur = [pscustomobject]@{
                TopicNo = $topicNo; Topic = $topic; Lc = [int]$p[0]; Title = $p[1]; Difficulty = $p[2]
                Source = $p[3]; LcSlug = $p[4]; NcSlug = $p[5]
                Short = $(if ($p.Count -gt 6 -and $p[6]) { $p[6] } else { $null })
                Solution = New-Object System.Text.StringBuilder
                Tests = New-Object System.Text.StringBuilder
            }
            $problems.Add($cur); $section = $null; continue
        }
        if ($line -eq '## Solution') { $section = 'S'; continue }
        if ($line -eq '## Tests') { $section = 'T'; continue }
        if ($null -eq $cur -or $null -eq $section) { continue }
        if ($section -eq 'S') { [void]$cur.Solution.AppendLine($line) } else { [void]$cur.Tests.AppendLine($line) }
    }
}

$dupes = $problems | Group-Object Lc | Where-Object Count -gt 1
if ($dupes) { throw "Duplicate LeetCode numbers: $(($dupes | ForEach-Object Name) -join ', ')" }

# ---------- generate ----------
$byTopic = [ordered]@{}
foreach ($p in $problems) {
    $num = '{0:0000}' -f $p.Lc
    $name = if ($p.Short) { $p.Short } else { ConvertTo-Pascal $p.Title }
    $projName = "$num-$name"
    $ns = "LC${num}_$name"
    $relDir = "src/LeetCode/$projName"
    $dir = Join-Path $root $relDir
    $lcUrl = "https://leetcode.com/problems/$($p.LcSlug)/"
    $ncUrl = if ($p.NcSlug) { "https://neetcode.io/problems/$($p.NcSlug)/question" } else { $null }
    $solveUrl = if ($p.Source -eq 'nc') { $ncUrl } else { $lcUrl }
    $where = if ($p.Source -eq 'nc') { 'NeetCode (LeetCode Premium on LeetCode)' } else { 'LeetCode' }

    $p | Add-Member Num $num; $p | Add-Member ProjName $projName; $p | Add-Member RelDir $relDir
    $p | Add-Member SolveUrl $solveUrl
    $topicKey = "$($p.TopicNo)|$($p.Topic)"
    if (-not $byTopic.Contains($topicKey)) { $byTopic[$topicKey] = New-Object System.Collections.Generic.List[object] }
    $byTopic[$topicKey].Add($p)

    Write-Utf8 (Join-Path $dir "$projName.csproj") @"
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <RootNamespace>$ns</RootNamespace>
  </PropertyGroup>
</Project>
"@

    $ncRow = if ($ncUrl) { "`n| NeetCode | <$ncUrl> |" } else { '' }
    Write-Utf8 (Join-Path $dir 'README.md') @"
# $($p.Lc). $($p.Title)

| | |
|---|---|
| Topic | $($p.Topic) |
| Difficulty | $($p.Difficulty) |
| Solve on | $where |
| Problem | <$solveUrl> |$ncRow

Read the statement at the link above, write your answer in ``Solution.cs`` and run:

``````powershell
.\check.ps1 $($p.Lc)
``````
"@

    $solPath = Join-Path $dir 'Solution.cs'
    if (-not (Test-Path $solPath)) {
        Write-Utf8 $solPath (@"
// $($p.Lc). $($p.Title) ($($p.Difficulty))
// $solveUrl
// Run the tests: .\check.ps1 $($p.Lc)
namespace $ns;
"@ + "`n`n" + $p.Solution.ToString().TrimEnd() + "`n")
    }

    $testBody = ($p.Tests.ToString().TrimEnd() -split "`r?`n" | ForEach-Object { if ($_ -ne '') { '    ' + $_ } else { '' } }) -join "`n"
    Write-Utf8 (Join-Path $dir 'SolutionTests.cs') @"
// Generated by tools/gen.ps1 - do not edit (changes are overwritten on regeneration).
namespace $ns;

public class SolutionTests
{
$testBody
}
"@

    # Helper classes, only where this problem uses them.
    $all = $p.Solution.ToString() + "`n" + $p.Tests.ToString()
    foreach ($node in 'ListNode', 'TreeNode') {
        if ($all -match "\b$node\b") {
            # The node definition is the user's file (like Solution.cs): created once, never overwritten.
            $defPath = Join-Path $dir "$node.cs"
            if (-not (Test-Path $defPath)) { Write-Utf8 $defPath (Get-Template $node $ns) }
            Write-Utf8 (Join-Path $dir "$node.Helpers.cs") (Get-Template "$node.Helpers" $ns)
        }
    }
    if ($all -match '\bAssertEx\.') { Write-Utf8 (Join-Path $dir 'AssertEx.cs') (Get-Template 'AssertEx' $ns) }
    if ($all -match '\bLc\.') { Write-Utf8 (Join-Path $dir 'Lc.cs') (Get-Template 'Lc' $ns) }
}

# ---------- solution file ----------
function Get-RelPath([string]$full) {
    # Substring, not [IO.Path]::GetRelativePath: that method is missing in Windows PowerShell 5.1
    $full.Substring($root.TrimEnd('\', '/').Length + 1).Replace('\', '/')
}
$sb = New-Object System.Text.StringBuilder
[void]$sb.AppendLine('<Solution>')
[void]$sb.AppendLine('  <Folder Name="/LeetCode/">')
foreach ($p in ($problems | Sort-Object Lc)) {
    [void]$sb.AppendLine("    <Project Path=""$($p.RelDir)/$($p.ProjName).csproj"" />")
}
[void]$sb.AppendLine('  </Folder>')
[void]$sb.AppendLine('  <Folder Name="/NeetCode/">')
# Hand-written NeetCode-only exercises (not generated) live in src/NeetCode/<Name>/
foreach ($c in Get-ChildItem (Join-Path $root 'src/NeetCode') -Recurse -Filter '*.csproj' -ErrorAction SilentlyContinue | Sort-Object FullName) {
    [void]$sb.AppendLine("    <Project Path=""$(Get-RelPath $c.FullName)"" />")
}
[void]$sb.AppendLine('  </Folder>')
[void]$sb.AppendLine('</Solution>')
Write-Utf8 (Join-Path $root 'DSA.slnx') $sb.ToString()

# ---------- root README ----------
$rb = New-Object System.Text.StringBuilder
[void]$rb.AppendLine((Get-Content (Join-Path $PSScriptRoot 'README.header.md') -Raw).TrimEnd())
[void]$rb.AppendLine()
foreach ($t in $byTopic.Keys) {
    $first = $byTopic[$t][0]
    [void]$rb.AppendLine("### $($first.Topic)")
    [void]$rb.AppendLine()
    [void]$rb.AppendLine('| LC # | Problem | Difficulty | Project |')
    [void]$rb.AppendLine('|---|---|---|---|')
    foreach ($p in $byTopic[$t]) {
        $tag = if ($p.Source -eq 'nc') { ' (NeetCode)' } else { '' }
        [void]$rb.AppendLine("| $($p.Lc) | [$($p.Title)]($($p.SolveUrl))$tag | $($p.Difficulty) | [$($p.ProjName)]($($p.RelDir)/Solution.cs) |")
    }
    [void]$rb.AppendLine()
}
Write-Utf8 (Join-Path $root 'README.md') $rb.ToString()

Write-Host "Generated $($problems.Count) problems in $($byTopic.Count) topics."
