# Runs the tests for one or more problems by their NeetCode 250 number.
#   .\check.ps1 1          -> problem 001
#   .\check.ps1 1 2 15     -> several problems
#   .\check.ps1 all        -> whole solution
param([Parameter(ValueFromRemainingArguments = $true)][string[]]$Problems)

$ErrorActionPreference = 'Stop'
if (-not (Get-Command dotnet -ErrorAction SilentlyContinue)) {
    $env:Path = [Environment]::GetEnvironmentVariable('Path', 'Machine') + ';' + [Environment]::GetEnvironmentVariable('Path', 'User')
}
if (-not $Problems -or $Problems.Count -eq 0) { Write-Host 'Usage: .\check.ps1 <number> [number...] | all'; exit 1 }

if ($Problems[0] -eq 'all') {
    dotnet test (Join-Path $PSScriptRoot 'DSA.slnx') --nologo
    exit $LASTEXITCODE
}

$failed = 0
foreach ($n in $Problems) {
    if ($n -match '^\d+$') {
        $num = '{0:000}' -f [int]$n
        $proj = Get-ChildItem (Join-Path $PSScriptRoot 'src') -Recurse -Filter "NC${num}_*.csproj" | Select-Object -First 1
    } else {
        # Course exercises by project name, e.g. .\check.ps1 StaticArrays
        $num = $n
        $proj = Get-ChildItem (Join-Path $PSScriptRoot 'src/00-Common') -Recurse -Filter "$n.csproj" -ErrorAction SilentlyContinue | Select-Object -First 1
    }
    if (-not $proj) { Write-Host "No project for problem $num" -ForegroundColor Red; $failed++; continue }
    Write-Host "=== $($proj.BaseName) ===" -ForegroundColor Cyan
    dotnet test $proj.FullName --nologo --logger "console;verbosity=normal"
    if ($LASTEXITCODE -ne 0) { $failed++ }
}
exit $failed
