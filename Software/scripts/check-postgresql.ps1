[CmdletBinding()]
param(
    [string] $ConnectionString = $env:RRHH_POSTGRES_CONNECTION,
    [string] $Login,
    [ValidateSet('Debug', 'Release')]
    [string] $Configuration = 'Debug'
)

$ErrorActionPreference = 'Stop'

if ([string]::IsNullOrWhiteSpace($ConnectionString)) {
    throw 'Defina RRHH_POSTGRES_CONNECTION o use -ConnectionString.'
}

$env:RRHH_POSTGRES_CONNECTION = $ConnectionString
$softwareRoot = Split-Path -Parent $PSScriptRoot
$executable = Join-Path $softwareRoot (
    "RecursosHumanos\bin\$Configuration\net48\RecursosHumanos.exe")

if (-not (Test-Path -LiteralPath $executable)) {
    throw "No existe $executable. Compile primero Software\RRHH.sln."
}

$resultPath = Join-Path ([IO.Path]::GetTempPath()) (
    'rrhh-postgres-check-' + [Guid]::NewGuid().ToString('N') + '.txt')
$env:RRHH_POSTGRES_CHECK_RESULT = $resultPath

try {
    $arguments = @('--check-postgresql')
    if (-not [string]::IsNullOrWhiteSpace($Login)) {
        $arguments += @('--login', $Login)
    }

    $process = Start-Process -FilePath $executable `
        -ArgumentList $arguments -Wait -PassThru -WindowStyle Hidden

    if (Test-Path -LiteralPath $resultPath) {
        Get-Content -LiteralPath $resultPath
    }

    if ($process.ExitCode -ne 0) {
        throw "La comprobación PostgreSQL terminó con el código $($process.ExitCode)."
    }
}
finally {
    Remove-Item Env:\RRHH_POSTGRES_CHECK_RESULT -ErrorAction SilentlyContinue
    if (Test-Path -LiteralPath $resultPath) {
        Remove-Item -LiteralPath $resultPath -Force
    }
}
