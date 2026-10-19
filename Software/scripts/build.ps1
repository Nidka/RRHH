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

# Genera una salida canónica. Aplicar BaseOutputPath a toda la solución puede
# duplicar la plataforma y crear accidentalmente bin\x86\x86\...
$application = Join-Path $root 'RecursosHumanos\RecursosHumanos.csproj'
dotnet build $application --configuration $Configuration --no-restore '-p:BaseOutputPath=bin\x86\'

if ($LASTEXITCODE -ne 0) {
    throw "La compilación de RecursosHumanos terminó con el código $LASTEXITCODE."
}
