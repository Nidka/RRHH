[CmdletBinding()]
param(
    [Parameter(Mandatory = $true)]
    [string] $Login,
    [ValidateSet('Debug', 'Release')]
    [string] $Configuration = 'Debug'
)

$ErrorActionPreference = 'Stop'
$softwareRoot = Split-Path -Parent $PSScriptRoot
$executableCandidates = @(
    (Join-Path $softwareRoot "RecursosHumanos\bin\$Configuration\net48\RecursosHumanos.exe"),
    (Join-Path $softwareRoot "RecursosHumanos\bin\x86\$Configuration\net48\RecursosHumanos.exe")
)
$executable = $executableCandidates | Where-Object { Test-Path -LiteralPath $_ } | Select-Object -First 1
if ([string]::IsNullOrWhiteSpace($executable)) {
    throw 'No existe el ejecutable. Compile primero Software\RRHH.sln.'
}

$first = Read-Host "Nueva contraseña para $Login" -AsSecureString
$second = Read-Host 'Repita la contraseña' -AsSecureString
$firstPointer = [Runtime.InteropServices.Marshal]::SecureStringToBSTR($first)
$secondPointer = [Runtime.InteropServices.Marshal]::SecureStringToBSTR($second)
$resultPath = Join-Path ([IO.Path]::GetTempPath()) (
    'rrhh-password-' + [Guid]::NewGuid().ToString('N') + '.txt')

try {
    $firstPlain = [Runtime.InteropServices.Marshal]::PtrToStringBSTR($firstPointer)
    $secondPlain = [Runtime.InteropServices.Marshal]::PtrToStringBSTR($secondPointer)
    if ($firstPlain.Length -lt 12) {
        throw 'La contraseña debe tener al menos 12 caracteres.'
    }
    if ($firstPlain -cne $secondPlain) {
        throw 'Las contraseñas no coinciden.'
    }

    $env:RRHH_NEW_PASSWORD = $firstPlain
    $env:RRHH_POSTGRES_CHECK_RESULT = $resultPath
    $process = Start-Process -FilePath $executable `
        -ArgumentList @('--set-password', '--login', $Login) `
        -Wait -PassThru -WindowStyle Hidden

    if (Test-Path -LiteralPath $resultPath) {
        Get-Content -LiteralPath $resultPath
    }
    if ($process.ExitCode -ne 0) {
        throw "La actualización terminó con el código $($process.ExitCode)."
    }
}
finally {
    [Runtime.InteropServices.Marshal]::ZeroFreeBSTR($firstPointer)
    [Runtime.InteropServices.Marshal]::ZeroFreeBSTR($secondPointer)
    Remove-Variable firstPlain, secondPlain -ErrorAction SilentlyContinue
    Remove-Item Env:\RRHH_NEW_PASSWORD -ErrorAction SilentlyContinue
    Remove-Item Env:\RRHH_POSTGRES_CHECK_RESULT -ErrorAction SilentlyContinue
    if (Test-Path -LiteralPath $resultPath) {
        Remove-Item -LiteralPath $resultPath -Force
    }
}
