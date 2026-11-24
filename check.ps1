# Runs the tests for one or more problems.
#   .\check.ps1 206          -> LeetCode 206 (src/LeetCode/0206-*)
#   .\check.ps1 1 206 1299   -> several problems
#   .\check.ps1 StaticArrays -> a NeetCode exercise by project name (src/NeetCode/<Name>)
#   .\check.ps1 all          -> whole solution
param([Parameter(ValueFromRemainingArguments = $true)][string[]]$Problems)

$ErrorActionPreference = 'Stop'
if (-not (Get-Command dotnet -ErrorAction SilentlyContinue)) {
    $env:Path = [Environment]::GetEnvironmentVariable('Path', 'Machine') + ';' + [Environment]::GetEnvironmentVariable('Path', 'User')
}
if (-not $Problems -or $Problems.Count -eq 0) { Write-Host 'Usage: .\check.ps1 <leetcode number | NeetCode exercise name> [...] | all'; exit 1 }

if ($Problems[0] -eq 'all') {
    dotnet test (Join-Path $PSScriptRoot 'DSA.slnx') --nologo
    exit $LASTEXITCODE
}

$failed = 0
foreach ($n in $Problems) {
    if ($n -match '^\d+$') {
        $num = '{0:0000}' -f [int]$n
        $dir = Get-ChildItem (Join-Path $PSScriptRoot 'src/LeetCode') -Directory -Filter "$num-*" -ErrorAction SilentlyContinue | Select-Object -First 1
        $proj = if ($dir) { Get-ChildItem $dir.FullName -Filter '*.csproj' | Select-Object -First 1 }
        $label = "LeetCode $n"
    } else {
        $proj = Get-ChildItem (Join-Path $PSScriptRoot 'src/NeetCode') -Recurse -Filter "$n.csproj" -ErrorAction SilentlyContinue | Select-Object -First 1
        $label = "NeetCode exercise $n"
    }
    if (-not $proj) { Write-Host "No project for $label" -ForegroundColor Red; $failed++; continue }
    Write-Host "=== $($proj.BaseName) ===" -ForegroundColor Cyan
    dotnet test $proj.FullName --nologo --logger "console;verbosity=normal"
    if ($LASTEXITCODE -ne 0) { $failed++ }
}
exit $failed
