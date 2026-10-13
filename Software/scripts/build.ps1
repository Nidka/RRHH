[CmdletBinding()]
param(
    [ValidateSet('Debug', 'Release')]
    [string] $Configuration = 'Debug'
)

$ErrorActionPreference = 'Stop'
$root = Split-Path -Parent $PSScriptRoot
$solution = Join-Path $root 'RRHH.sln'

dotnet restore $solution --ignore-failed-sources
if ($LASTEXITCODE -ne 0) {
    throw "La restauración terminó con el código $LASTEXITCODE."
}

dotnet build $solution --configuration $Configuration --no-restore

if ($LASTEXITCODE -ne 0) {
    throw "La compilación terminó con el código $LASTEXITCODE."
}
