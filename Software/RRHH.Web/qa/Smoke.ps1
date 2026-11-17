param(
    [Parameter(Mandatory)][string]$PostgreSqlBin,
    [string]$Dotnet = 'dotnet',
    [int]$DatabasePort = 55414,
    [int]$WebPort = 5080,
    [switch]$Demo,
    [switch]$RegresionEscritorio
)
$ErrorActionPreference = 'Stop'
$hostProject = Split-Path $PSScriptRoot
$repo = Split-Path (Split-Path $hostProject)
$workspace = Join-Path ([IO.Path]::GetTempPath()) ('rrhh-web-qa-' + [Guid]::NewGuid())
New-Item -ItemType Directory $workspace | Out-Null
$dbStarted = $false
$server = $null
$password = [Guid]::NewGuid().ToString('N')
$dbPassword = [Guid]::NewGuid().ToString('N')
$salt = [Security.Cryptography.RandomNumberGenerator]::GetBytes(16)
$hash = [Convert]::ToBase64String([Security.Cryptography.Rfc2898DeriveBytes]::Pbkdf2(
    $password, $salt, 210000, [Security.Cryptography.HashAlgorithmName]::SHA256, 32))
$saltText = [Convert]::ToBase64String($salt)
$url = "http://127.0.0.1:$WebPort"
function Invoke-Checked($executable, [string[]]$arguments) {
    & $executable @arguments
    if ($LASTEXITCODE) { throw "Falló $executable con código $LASTEXITCODE." }
}
function Assert-Http($expected, $response) {
    if ([int]$response.StatusCode -ne $expected) { throw "HTTP esperado $expected, obtenido $($response.StatusCode)." }
}
function Post($route, $body, $session) {
    $token = (Invoke-RestMethod "$url/api/token" -WebSession $session).token
    Invoke-WebRequest "$url/api/$route" -WebSession $session -Method Post -SkipHttpErrorCheck `
        -ContentType 'application/json' -Headers @{'X-RRHH-CSRF' = $token} -Body ($body | ConvertTo-Json -Compress)
}
try {
    $data = Join-Path $workspace 'data'
    $passwordFile = Join-Path $workspace 'pg-password'
    [IO.File]::WriteAllText($passwordFile, $dbPassword)
    $pgctl = Join-Path $PostgreSqlBin 'pg_ctl.exe'
    Invoke-Checked (Join-Path $PostgreSqlBin 'initdb.exe') @('-D', $data, '-U', 'qa', '-A', 'scram-sha-256',
        "--pwfile=$passwordFile", '--encoding=UTF8', '--no-locale')
    Remove-Item -LiteralPath $passwordFile
    Invoke-Checked $pgctl @('-D', $data, '-l', (Join-Path $workspace 'postgres.log'), '-o', "-h 127.0.0.1 -p $DatabasePort", '-w', 'start')
    $dbStarted = $true
    $env:PGPASSWORD = $dbPassword
    $psql = Join-Path $PostgreSqlBin 'psql.exe'
    $argsDb = @('-X', '-v', 'ON_ERROR_STOP=1', '-h', '127.0.0.1', '-p', "$DatabasePort", '-U', 'qa', '-d', 'postgres')
    $fixture = @"
CREATE TABLE "Empleado" ("IdEmpleado" integer, "IdPersona" integer, "idAreaOrganiz" integer);
CREATE TABLE "Persona" ("IdPersona" integer, "Apellido_Paterno" text, "Apellido_Materno" text, "Nombres" text);
CREATE TABLE "Usuario" ("IdUsuario" integer, "Login" text, "IdEmpleado" integer, "Estado" boolean,
  "PasswordHash" text, "PasswordSalt" text, "PasswordIterations" integer);
CREATE TABLE "Rol" ("IdRol" integer, "IdSistema" text);
CREATE TABLE "Usuario_Rol" ("IdUsuario" integer, "IdRol" integer);
CREATE TABLE "RRHH_Feriado" ("idFeriado" integer, "Fecha" timestamp, "Motivo" text);
CREATE TABLE "Motivo_Perm" ("idMotivo" integer, "Descrip_Motivo" text);
CREATE TABLE "Permiso" ("IdEmpleado" integer, "FechaInicio" timestamp, "FechaFin" timestamp, "idMotivo" integer);
CREATE TABLE "Horario" ("idHorario" integer, "Descrip_Horario" text, "Ingreso1" text, "Salida1" text, "Ingreso2" text, "Salida2" text, "Estado" boolean);
CREATE TABLE "HorarioTemporal" ("idEmpleado" integer, "N" integer, "FechaInicio" timestamp, "FechaFin" timestamp,
  "HorarioAsignado" integer, "NroDocumento" varchar(50), "Sisgedo" varchar(50), "FechaRegistro" timestamp);
INSERT INTO "Empleado" VALUES (101, 1, 1), (102, 1, 1);
INSERT INTO "Persona" VALUES (1, 'Ficticio', '', 'Operador');
INSERT INTO "Usuario" VALUES (1, 'operador', 101, true, '$hash', '$saltText', 210000),
  (2, 'sin_permiso', 101, true, '$hash', '$saltText', 210000),
  (3, 'solo_teletrabajo', 102, true, '$hash', '$saltText', 210000);
INSERT INTO "Rol" VALUES (1, '0500000'), (2, '0500000'), (3, '0500000');
INSERT INTO "Usuario_Rol" VALUES (1, 1), (2, 2), (3, 3);
INSERT INTO "RRHH_Feriado" VALUES (1, '2026-11-11', 'Feriado ficticio');
INSERT INTO "Motivo_Perm" VALUES (10, 'Vacaciones ficticias'), (20, 'Licencia ficticia');
INSERT INTO "Permiso" VALUES (101, '2026-11-01', '2026-11-30', 10),
  (102, '2026-11-10', '2026-11-10', 20), (102, '2026-11-13', '2026-11-15', 20);
INSERT INTO "Horario" VALUES (1, 'Turno ficticio', '08:00:00', NULL, NULL, '17:00:00', true);
"@
    $fixture | & $psql @argsDb
    if ($LASTEXITCODE) { throw 'Falló la preparación de datos ficticios.' }
    Invoke-Checked $psql ($argsDb + @('-f', (Join-Path $repo 'BD/migrations/20261112_03_teletrabajo.sql')))
    if ($RegresionEscritorio) {
        Invoke-Checked $psql ($argsDb + @('-c', 'CREATE DATABASE rrhh_tec004_tests'))
        $env:RRHH_TEST_POSTGRES_CONNECTION = "Host=127.0.0.1;Port=$DatabasePort;Username=qa;Password=$dbPassword;Database=rrhh_tec004_tests;SSL Mode=Disable"
        Invoke-Checked $Dotnet @('test', (Join-Path $repo 'Software/RRHH.Tests/RRHH.Tests.csproj'))
    }
    Invoke-Checked $Dotnet @('build', (Join-Path $hostProject 'RRHH.Web.csproj'))
    $env:RRHH_WEB_POSTGRES = "Host=127.0.0.1;Port=$DatabasePort;Username=qa;Password=$dbPassword;Database=postgres;SSL Mode=Disable"
    $env:RRHH_WEB_ROLES = '1,3'
    $env:RRHH_WEB_ROLES_AUSENCIAS = '1'
    $env:RRHH_WEB_ROLES_HORARIOS = '1'
    $env:ASPNETCORE_ENVIRONMENT = 'Development'
    $server = Start-Process -FilePath $Dotnet -ArgumentList @('bin/Debug/net8.0/RRHH.Web.dll', '--urls', $url) `
        -WorkingDirectory $hostProject -WindowStyle Hidden -PassThru `
        -RedirectStandardOutput (Join-Path $workspace 'web-out.txt') -RedirectStandardError (Join-Path $workspace 'web-err.txt')
    $ready = $false
    for ($i = 0; $i -lt 20 -and !$server.HasExited; $i++) {
        try { $ready = (Invoke-WebRequest $url -TimeoutSec 2).StatusCode -eq 200 } catch { Start-Sleep -Milliseconds 250 }
        if ($ready) { break }
    }
    if (!$ready) { throw "El host no arrancó. Revisar $workspace." }
    if ($Demo) {
        Write-Host "Página local: $url"
        Write-Host 'Usuario ficticio: operador'
        Write-Host "Contraseña de esta sesión: $password"
        Write-Host 'Empleados ficticios: 101 y 102. El 11/11/2026 es feriado.'
        $null = Read-Host 'Presiona Enter al terminar la demostración'
        return
    }
    $session = [Microsoft.PowerShell.Commands.WebRequestSession]::new()
    Assert-Http 401 (Invoke-WebRequest "$url/api/periodos?empleado=101" -SkipHttpErrorCheck)
    Assert-Http 401 (Post 'login' @{login='sin_permiso'; password=$password} $session)
    Assert-Http 204 (Post 'login' @{login='operador'; password=$password} $session)
    Assert-Http 400 (Invoke-WebRequest "$url/api/periodos" -WebSession $session -Method Post -Body '{}' -ContentType 'application/json' -SkipHttpErrorCheck)
    $periodo = @{empleado=101; desde='2026-11-09'; hasta='2026-11-13'; modalidad='T'; diasRemotos=31}
    Assert-Http 201 (Post 'periodos' $periodo $session)
    Assert-Http 400 (Post 'periodos' $periodo $session)
    $filas = Invoke-RestMethod "$url/api/periodos?empleado=101" -WebSession $session
    if ($filas.Count -ne 1 -or $filas[0].diasRemotos -ne 31) { throw 'El listado no coincide con el alta.' }
    $reporte = Invoke-RestMethod "$url/api/reporte?empleado=101&desde=2026-11-09&hasta=2026-11-15" -WebSession $session
    if ($reporte.Count -ne 1 -or $reporte[0].dias -ne 4) { throw 'El reporte debía excluir el feriado ficticio.' }
    $parcial = @{empleado=102; desde='2026-11-09'; hasta='2026-11-13'; modalidad='P'; diasRemotos=21}
    Assert-Http 201 (Post 'periodos' $parcial $session)
    $reporteParcial = Invoke-RestMethod "$url/api/reporte?empleado=102&desde=2026-11-09&hasta=2026-11-15" -WebSession $session
    if ($reporteParcial.Count -ne 1 -or $reporteParcial[0].dias -ne 2) { throw 'El patrón lunes, miércoles y viernes debía dar dos días por el feriado.' }

    $clasificacionUrl = "$url/api/clasificacion-teletrabajo?desde=2026-11-09&hasta=2026-11-15"
    Assert-Http 401 (Invoke-WebRequest $clasificacionUrl -SkipHttpErrorCheck)
    $clasificacion = Invoke-RestMethod $clasificacionUrl -WebSession $session
    if ($clasificacion.Count -ne 2 -or $clasificacion[0].idEmpleado -ne 101 -or
        $clasificacion[0].clasificacion -ne 0 -or $clasificacion[0].diasLaborables -ne 4 -or
        $clasificacion[1].idEmpleado -ne 102 -or $clasificacion[1].clasificacion -ne 1 -or
        $clasificacion[1].diasRemotos -ne 2) { throw 'Clasificación Total/Parcial incorrecta.' }
    $totales = Invoke-RestMethod "$clasificacionUrl&clase=T" -WebSession $session
    $parciales = Invoke-RestMethod "$clasificacionUrl&clase=P" -WebSession $session
    if ($totales.Count -ne 1 -or $totales[0].idEmpleado -ne 101 -or
        $parciales.Count -ne 1 -or $parciales[0].idEmpleado -ne 102) { throw 'Filtro de clasificación incorrecto.' }
    Assert-Http 400 (Invoke-WebRequest "$clasificacionUrl&clase=X" -WebSession $session -SkipHttpErrorCheck)
    Assert-Http 400 (Invoke-WebRequest "$url/api/clasificacion-teletrabajo?desde=2026-11-15&hasta=2026-11-09" -WebSession $session -SkipHttpErrorCheck)

    $ausenciasUrl = "$url/api/ausencias?desde=2026-11-10&hasta=2026-11-12"
    Assert-Http 401 (Invoke-WebRequest $ausenciasUrl -SkipHttpErrorCheck)
    $soloTeletrabajo = [Microsoft.PowerShell.Commands.WebRequestSession]::new()
    Assert-Http 204 (Post 'login' @{login='solo_teletrabajo'; password=$password} $soloTeletrabajo)
    Assert-Http 403 (Invoke-WebRequest $ausenciasUrl -WebSession $soloTeletrabajo -SkipHttpErrorCheck)
    Assert-Http 403 (Invoke-WebRequest "$url/api/ausencias/motivos" -WebSession $soloTeletrabajo -SkipHttpErrorCheck)
    if ((Invoke-RestMethod "$url/api/sesion" -WebSession $soloTeletrabajo).ausencias) { throw 'El rol de teletrabajo obtuvo acceso a ausencias.' }
    if (-not (Invoke-RestMethod "$url/api/sesion" -WebSession $session).ausencias) { throw 'La sesión autorizada perdió acceso a ausencias.' }
    $motivos = Invoke-RestMethod "$url/api/ausencias/motivos" -WebSession $session
    if ($motivos.Count -ne 2) { throw 'El catálogo de motivos debía incluir los dos motivos ficticios.' }
    $ausencias = Invoke-RestMethod $ausenciasUrl -WebSession $session
    if ($ausencias.Count -ne 2 -or $ausencias[0].idEmpleado -ne 101 -or
        $ausencias[0].diasEnPeriodo -ne 3 -or $ausencias[1].diasEnPeriodo -ne 1) { throw 'El reporte RF-18 no respetó el solapamiento inclusivo.' }
    $licencias = Invoke-RestMethod "$ausenciasUrl&motivo=20" -WebSession $session
    if ($licencias.Count -ne 1 -or $licencias[0].idMotivo -ne 20) { throw 'No se aplicó el filtro por motivo.' }
    Assert-Http 400 (Invoke-WebRequest "$url/api/ausencias?desde=2026-11-12&hasta=2026-11-10" -WebSession $session -SkipHttpErrorCheck)

    $horariosUrl = "$url/api/horarios/asignaciones"
    Assert-Http 401 (Invoke-WebRequest "$url/api/horarios/catalogo" -SkipHttpErrorCheck)
    Assert-Http 403 (Invoke-WebRequest "$url/api/horarios/catalogo" -WebSession $soloTeletrabajo -SkipHttpErrorCheck)
    Assert-Http 400 (Invoke-WebRequest $horariosUrl -WebSession $session -Method Post -Body '{}' -ContentType 'application/json' -SkipHttpErrorCheck)
    $catalogo = Invoke-RestMethod "$url/api/horarios/catalogo" -WebSession $session
    if ($catalogo.Count -ne 1 -or $catalogo[0].id -ne 1) { throw 'El catálogo de horarios no coincide con los datos ficticios.' }
    $turno = @{empleado=101; numero=0; horario=1; desde='2026-11-09'; hasta='2026-11-13'; documento='QA'; sisgedo=''}
    Assert-Http 201 (Post 'horarios/asignaciones' $turno $session)
    Assert-Http 400 (Post 'horarios/asignaciones' $turno $session)
    $asignacion = Invoke-RestMethod "$horariosUrl/101/1" -WebSession $session
    if ($asignacion.documento -ne 'QA') { throw 'La asignación no pudo consultarse para editar.' }
    $turno.numero = 1
    $turno.documento = 'QA edición'
    Assert-Http 200 (Post 'horarios/asignaciones' $turno $session)
    $editada = Invoke-RestMethod "$horariosUrl/101/1" -WebSession $session
    if ($editada.documento -ne 'QA edición' -or $editada.fechaRegistro -ne $asignacion.fechaRegistro) {
        throw 'La edición debe conservar la fecha de registro y actualizar el documento.'
    }
    Assert-Http 204 (Post 'salir' @{} $session)
    Assert-Http 401 (Invoke-WebRequest "$url/api/periodos?empleado=101" -WebSession $session -SkipHttpErrorCheck)
    Write-Output 'QA correcta: sesión, roles, CSRF, teletrabajo, ausencias y asignación de turnos.'
} finally {
    if ($server -and !$server.HasExited) { Stop-Process -Id $server.Id }
    if ($dbStarted) { & $pgctl -D $data -m fast -w stop }
    Remove-Item Env:PGPASSWORD, Env:RRHH_WEB_POSTGRES, Env:RRHH_WEB_ROLES, Env:RRHH_WEB_ROLES_AUSENCIAS, Env:RRHH_WEB_ROLES_HORARIOS, Env:ASPNETCORE_ENVIRONMENT, Env:RRHH_TEST_POSTGRES_CONNECTION -ErrorAction SilentlyContinue
    Write-Output "Clúster de QA detenido. Diagnósticos ficticios en $workspace."
}
