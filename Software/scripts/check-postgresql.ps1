[CmdletBinding()]
param(
    [string] $ConnectionString = $env:RRHH_POSTGRES_CONNECTION,
    [string] $Login,
	[Security.SecureString] $Password,
    [switch] $Modules,
    [ValidateSet('Debug', 'Release')]
    [string] $Configuration = 'Debug'
)

$ErrorActionPreference = 'Stop'

if (-not [string]::IsNullOrWhiteSpace($ConnectionString)) {
    $env:RRHH_POSTGRES_CONNECTION = $ConnectionString
}
$softwareRoot = Split-Path -Parent $PSScriptRoot
$executableCandidates = @(
    (Join-Path $softwareRoot "RecursosHumanos\bin\x86\$Configuration\net48\RecursosHumanos.exe"),
    (Join-Path $softwareRoot "RecursosHumanos\bin\$Configuration\net48\RecursosHumanos.exe")
)
$executable = $executableCandidates | Where-Object { Test-Path -LiteralPath $_ } | Select-Object -First 1

if ([string]::IsNullOrWhiteSpace($executable)) {
    throw "No existe el ejecutable. Compile primero Software\RRHH.sln."
}

$resultPath = Join-Path ([IO.Path]::GetTempPath()) (
    'rrhh-postgres-check-' + [Guid]::NewGuid().ToString('N') + '.txt')
$env:RRHH_POSTGRES_CHECK_RESULT = $resultPath

try {
    $arguments = if ($Modules) { @('--check-modules') } else { @('--check-postgresql') }
    if (-not [string]::IsNullOrWhiteSpace($Login)) {
		if ($null -eq $Password) {
			$Password = Read-Host 'Contraseña del usuario RRHH' -AsSecureString
		}
		$credentialPointer = [Runtime.InteropServices.Marshal]::SecureStringToBSTR($Password)
		try {
			$env:RRHH_LOGIN_PASSWORD = [Runtime.InteropServices.Marshal]::PtrToStringBSTR($credentialPointer)
		}
		finally {
			[Runtime.InteropServices.Marshal]::ZeroFreeBSTR($credentialPointer)
		}
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
	Remove-Item Env:\RRHH_LOGIN_PASSWORD -ErrorAction SilentlyContinue
    Remove-Item Env:\RRHH_POSTGRES_CHECK_RESULT -ErrorAction SilentlyContinue
    if (Test-Path -LiteralPath $resultPath) {
        Remove-Item -LiteralPath $resultPath -Force
    }
}
