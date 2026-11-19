param(
    [Parameter(Mandatory)][string]$PostgreSqlBin,
    [int]$Port = 55449
)
$ErrorActionPreference = 'Stop'
$repo = Split-Path (Split-Path $PSScriptRoot)
$workspace = Join-Path ([IO.Path]::GetTempPath()) ('rrhh-integridad-qa-' + [Guid]::NewGuid())
$data = Join-Path $workspace 'data'
$pgctl = Join-Path $PostgreSqlBin 'pg_ctl.exe'
$psql = Join-Path $PostgreSqlBin 'psql.exe'
$previousPassword = $env:PGPASSWORD
$previousPager = $env:PSQL_PAGER
$dbStarted = $false

function Checked([string]$Exe, [string[]]$Arguments) {
    & $Exe @Arguments
    if ($LASTEXITCODE -ne 0) { throw "Comando de QA falló con código $LASTEXITCODE." }
}
function Sql([string]$Statement) {
    Checked $psql ($qaArgs + @('-c', $Statement))
}
function File([string]$Relative) {
    Checked $psql ($qaArgs + @('-f', (Join-Path $repo $Relative)))
}
function Reset-Fixture {
    Sql 'DROP SCHEMA IF EXISTS rrhh_qa_respaldo CASCADE; DROP SCHEMA public CASCADE; CREATE SCHEMA public;'
    File 'BD/tests/integridad_duplicados_fixture.sql'
}
function Reject-Sanitation {
    & $psql @qaArgs -f (Join-Path $repo 'BD/tests/sanear_copias_exactas_qa.sql')
    if ($LASTEXITCODE -eq 0) { throw 'El ensayo debía rechazar el fixture inconsistente.' }
    Sql @'
DO $test$
BEGIN
    IF (SELECT count(*) FROM public."Usuario") <> 2
       OR (SELECT count(*) FROM public."Motivo_Perm") <> 2
       OR to_regnamespace('rrhh_qa_respaldo') IS NOT NULL THEN
        RAISE EXCEPTION 'El rechazo debe conservar las filas y no crear respaldo';
    END IF;
END $test$;
'@
}

try {
    New-Item -ItemType Directory -Path $workspace | Out-Null
    $env:PGPASSWORD = [Guid]::NewGuid().ToString('N')
    $env:PSQL_PAGER = ''
    $passwordFile = Join-Path $workspace 'pg-password'
    [IO.File]::WriteAllText($passwordFile, $env:PGPASSWORD)
    Checked (Join-Path $PostgreSqlBin 'initdb.exe') @('-D', $data, '-U', 'qa', '-A',
        'scram-sha-256', "--pwfile=$passwordFile", '--encoding=UTF8', '--no-locale')
    Remove-Item -LiteralPath $passwordFile
    Checked $pgctl @('-D', $data, '-l', (Join-Path $workspace 'postgres.log'),
        '-o', "-h 127.0.0.1 -p $Port", '-w', 'start')
    $dbStarted = $true
    $serverArgs = @('-X', '-P', 'pager=off', '-v', 'ON_ERROR_STOP=1',
        '-h', '127.0.0.1', '-p', "$Port", '-U', 'qa')
    Checked $psql ($serverArgs + @('-d', 'postgres', '-c', 'CREATE DATABASE rrhh_integridad_qa'))
    $qaArgs = $serverArgs + @('-d', 'rrhh_integridad_qa')
    File 'BD/tests/integridad_duplicados_fixture.sql'
    $backupFile = Join-Path $workspace 'fixture-original.sql'
    Checked (Join-Path $PostgreSqlBin 'pg_dump.exe') @('-h', '127.0.0.1', '-p', "$Port",
        '-U', 'qa', '-d', 'rrhh_integridad_qa', '--no-owner', '--no-acl', '-f', $backupFile)
    File 'BD/tests/diagnostico_integridad.sql'
    File 'BD/tests/sanear_copias_exactas_qa.sql'
    File 'BD/migrations/20261018_02_integrity_ids.sql'
    File 'BD/tests/integridad_duplicados_assertions.sql'
    File 'BD/tests/sanear_copias_exactas_qa.sql'
    File 'BD/migrations/20261018_02_integrity_ids.sql'
    File 'BD/migrations/20261111_01_licencia_una_vez_anio.sql'
    File 'BD/tests/rf06_assertions.sql'
    File 'BD/migrations/20261111_01_licencia_una_vez_anio.sql'

    Checked $psql ($serverArgs + @('-d', 'postgres', '-c', 'CREATE DATABASE rrhh_integridad_restore_qa'))
    Checked $psql ($serverArgs + @('-d', 'rrhh_integridad_restore_qa', '-f', $backupFile))
    Checked $psql ($serverArgs + @('-d', 'rrhh_integridad_restore_qa',
        '-f', (Join-Path $repo 'BD/tests/integridad_restore_assertions.sql')))

    Reset-Fixture
    Sql 'UPDATE public."Usuario" SET "Login" = ''otro-ficticio'' WHERE ctid = (SELECT ctid FROM public."Usuario" ORDER BY ctid DESC LIMIT 1);'
    Reject-Sanitation
    Reset-Fixture
    Sql 'UPDATE public."Motivo_Perm" SET "Descrip_Motivo" = ''VARIANTE FICTICIA'' WHERE ctid = (SELECT ctid FROM public."Motivo_Perm" ORDER BY ctid DESC LIMIT 1);'
    Reject-Sanitation
    Reset-Fixture
    Sql 'UPDATE public."Usuario" SET "IdUsuario" = NULL WHERE ctid = (SELECT ctid FROM public."Usuario" ORDER BY ctid DESC LIMIT 1);'
    Reject-Sanitation
    Reset-Fixture
    Sql 'UPDATE public."Usuario_Rol" SET "IdUsuario" = 999;'
    Reject-Sanitation
    Write-Output 'QA correcta: copias exactas, backup/restore, IDs, referencias, claves, repetición, RF-06 y cuatro rechazos sin cambios.'
} finally {
    if ($dbStarted) { & $pgctl -D $data -m fast -w stop }
    $env:PGPASSWORD = $previousPassword
    $env:PSQL_PAGER = $previousPager
    Write-Output "Diagnósticos ficticios locales en $workspace"
}
