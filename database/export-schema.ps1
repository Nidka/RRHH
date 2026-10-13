[CmdletBinding()]
param(
    [Parameter(Mandatory = $true)]
    [string] $HostName,

    [Parameter(Mandatory = $true)]
    [string] $DatabaseName,

    [Parameter(Mandatory = $true)]
    [string] $UserName,

    [ValidateRange(1, 65535)]
    [int] $Port = 5432,

    [string] $Schema,

    [string] $OutputPath = (Join-Path $PSScriptRoot 'schema.sql')
)

$ErrorActionPreference = 'Stop'
$pgDump = Get-Command pg_dump -ErrorAction SilentlyContinue
if (-not $pgDump) {
    throw 'No se encontró pg_dump. Instala las herramientas cliente de PostgreSQL y vuelve a ejecutar el script.'
}

$arguments = @(
    '--schema-only',
    '--no-owner',
    '--no-privileges',
    '--host', $HostName,
    '--port', $Port.ToString(),
    '--username', $UserName,
    '--dbname', $DatabaseName,
    '--file', $OutputPath
)

if ($Schema) {
    $arguments += @('--schema', $Schema)
}

& $pgDump.Source @arguments
if ($LASTEXITCODE -ne 0) {
    throw "pg_dump terminó con el código $LASTEXITCODE."
}

Write-Host "Esquema PostgreSQL exportado en: $OutputPath"
