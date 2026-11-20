param(
    [Parameter(Mandatory)][string]$PostgreSqlBin,
    [string]$Dotnet = 'dotnet',
    [int]$DatabasePort = 55414,
    [int]$WebPort = 5080,
    [switch]$Demo,
    [switch]$Escritorio,
    [switch]$SoloEmpleado,
    [string]$DemoPassword,
    [switch]$RegresionEscritorio
)
$ErrorActionPreference = 'Stop'
if(($Escritorio -or $DemoPassword) -and !$Demo){throw 'Escritorio y DemoPassword solo se admiten con -Demo local.'}
if($SoloEmpleado -and (!$Demo -or !$Escritorio)){throw 'SoloEmpleado requiere -Demo -Escritorio.'}
$hostProject = Split-Path $PSScriptRoot
$repo = Split-Path (Split-Path $hostProject)
$workspace = Join-Path ([IO.Path]::GetTempPath()) ('rrhh-web-qa-' + [Guid]::NewGuid())
New-Item -ItemType Directory $workspace | Out-Null
$dbStarted = $false
$server = $null
$desktop=$null
$password = if($Demo -and $DemoPassword){$DemoPassword}else{[Guid]::NewGuid().ToString('N')}
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
    if ([int]$response.StatusCode -ne $expected) {
        $request = $response.BaseResponse.RequestMessage
        throw "HTTP esperado $expected, obtenido $($response.StatusCode) para $($request.Method) $($request.RequestUri)."
    }
}
function Post($route, $body, $session) {
    $token = (Invoke-RestMethod "$url/api/token" -WebSession $session).token
    try {
        Invoke-WebRequest "$url/api/$route" -WebSession $session -Method Post -SkipHttpErrorCheck `
            -ContentType 'application/json' -Headers @{'X-RRHH-CSRF' = $token} -Body ($body | ConvertTo-Json -Compress)
    } finally {
        $null = $session.Headers.Remove('X-RRHH-CSRF')
    }
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
    $argsDb = @('-X', '-P','pager=off','-v', 'ON_ERROR_STOP=1', '-h', '127.0.0.1', '-p', "$DatabasePort", '-U', 'qa', '-d', 'postgres')
    $fixture = @"
CREATE TABLE "Empleado" ("IdEmpleado" integer, "IdPersona" integer, "idAreaOrganiz" integer);
ALTER TABLE "Empleado" ADD "FechaIngreso" timestamp;
CREATE TABLE "Persona" ("IdPersona" integer, "Apellido_Paterno" text, "Apellido_Materno" text, "Nombres" text);
CREATE TABLE "Usuario" ("IdUsuario" integer, "Login" text, "IdEmpleado" integer, "Estado" boolean,
  "PasswordHash" text, "PasswordSalt" text, "PasswordIterations" integer);
CREATE TABLE "Rol" ("IdRol" integer, "IdSistema" text);
CREATE TABLE "Usuario_Rol" ("IdUsuario" integer, "IdRol" integer);
CREATE TABLE "RRHH_Feriado" ("idFeriado" integer, "Fecha" timestamp, "Motivo" text);
CREATE TABLE "TipoPermiso" ("idTipoPermiso" integer, "DescripTipoPermiso" text);
CREATE TABLE "Motivo_Perm" ("idMotivo" integer, "Descrip_Motivo" text, "Abrev" text,
  "Salario" boolean, "idTipoPermiso" integer, "TipoModalidad" text, "Activo" boolean);
CREATE TABLE "Permiso" ("IdEmpleado" integer, "FechaInicio" timestamp, "FechaFin" timestamp, "idMotivo" integer);
CREATE TABLE "Permiso_Aud" ("idMotivo_Ant" integer, "idMotivo_Act" integer);
CREATE TABLE "Asistencia" ("IdEmpleado" integer, "Fecha" timestamp);
CREATE TABLE "Horario" ("idHorario" integer, "Descrip_Horario" text, "Ingreso1" text, "Salida1" text, "Ingreso2" text, "Salida2" text, "Estado" boolean);
CREATE TABLE "HorarioTemporal" ("idEmpleado" integer, "N" integer, "FechaInicio" timestamp, "FechaFin" timestamp,
  "HorarioAsignado" integer, "NroDocumento" varchar(50), "Sisgedo" varchar(50), "FechaRegistro" timestamp);
INSERT INTO "Empleado" VALUES (101, 1, 1, '2024-03-01'), (102, 1, 1, NULL);
ALTER TABLE "Empleado" ADD "Year" integer NOT NULL DEFAULT 2026;
INSERT INTO "Persona" VALUES (1, 'Ficticio', '', 'Operador');
INSERT INTO "Usuario" VALUES (1, 'operador', 101, true, '$hash', '$saltText', 210000),
  (2, 'sin_permiso', 101, true, '$hash', '$saltText', 210000),
  (3, 'solo_teletrabajo', 102, true, '$hash', '$saltText', 210000);
INSERT INTO "Rol" VALUES (10, '0500000'), (2, '0500000'), (3, '0500000');
INSERT INTO "Usuario_Rol" VALUES (1, 10), (2, 2), (3, 3);
INSERT INTO "RRHH_Feriado" VALUES (1, '2026-11-11', 'Feriado ficticio');
INSERT INTO "TipoPermiso" VALUES (1, 'Tipo ficticio');
INSERT INTO "Motivo_Perm" VALUES (10, 'Vacaciones ficticias', 'VAC', true, 1, 'P', true),
  (20, 'Licencia ficticia', 'LIC', true, 1, 'C', true),
  (30, 'Motivo auditado', 'AUD', true, 1, 'P', true),
  (40, 'Motivo de otra modalidad', 'OTR', true, 1, 'C', true);
INSERT INTO "Permiso_Aud" VALUES (30, NULL);
INSERT INTO "Permiso" VALUES (101, '2026-11-01', '2026-11-30', 10),
  (102, '2026-11-10', '2026-11-10', 20), (102, '2026-11-13', '2026-11-15', 20);
INSERT INTO "Horario" VALUES (1, 'Turno ficticio', '08:00:00', NULL, NULL, '17:00:00', true);
INSERT INTO "Asistencia" VALUES (101, '2026-11-09'), (101, '2026-11-11'),
  (101, '2026-11-14'), (101, '2026-11-14 16:00'), (102, '2026-11-10');
ALTER TABLE "Asistencia" ADD "Hor_Sal" varchar(8) DEFAULT '00:00:00';
ALTER TABLE "Motivo_Perm" ADD PRIMARY KEY ("idMotivo");
ALTER TABLE "Permiso" ADD "NPermiso" integer GENERATED BY DEFAULT AS IDENTITY;
ALTER TABLE "Permiso" ADD "Autorizado" boolean;
ALTER TABLE "Permiso" ADD "Lugar" varchar(20);
ALTER TABLE "Permiso" ADD "Referencia" varchar(100);
ALTER TABLE "Permiso" ADD "Autorizacion" varchar(50);
ALTER TABLE "Permiso" ADD "Obs" varchar(200);
ALTER TABLE "Permiso" ADD "Dia" boolean;
ALTER TABLE "Permiso" ADD "Retorno" boolean;
"@
    $fixture | & $psql @argsDb
    if ($LASTEXITCODE) { throw 'Falló la preparación de datos ficticios.' }
    Invoke-Checked $psql ($argsDb + @('-f', (Join-Path $repo 'BD/migrations/20261112_03_teletrabajo.sql')))
    foreach ($migracion in @('20261111_01_licencia_una_vez_anio.sql', '20261119_01_grupo_licencia_anual.sql', '20261119_02_estados_permiso.sql','20261119_03_vacaciones_piloto.sql')) {
        Invoke-Checked $psql ($argsDb + @('-f', (Join-Path $repo ('BD/migrations/' + $migracion))))
    }
    if ($RegresionEscritorio) {
        Invoke-Checked $psql ($argsDb + @('-c', 'CREATE DATABASE rrhh_tec004_tests'))
        $env:RRHH_TEST_POSTGRES_CONNECTION = "Host=127.0.0.1;Port=$DatabasePort;Username=qa;Password=$dbPassword;Database=rrhh_tec004_tests;SSL Mode=Disable"
        Invoke-Checked $Dotnet @('test', (Join-Path $repo 'Software/RRHH.Tests/RRHH.Tests.csproj'))
    }
    Invoke-Checked $Dotnet @('build', (Join-Path $hostProject 'RRHH.Web.csproj'))
    $env:RRHH_WEB_POSTGRES = "Host=127.0.0.1;Port=$DatabasePort;Username=qa;Password=$dbPassword;Database=postgres;SSL Mode=Disable"
    $env:RRHH_WEB_ROLES = '10,3'
    $env:RRHH_WEB_ROLES_AUTOCONSULTA='20'
    $env:RRHH_WEB_ROLES_AUSENCIAS = '10'
    $env:RRHH_WEB_ROLES_HORARIOS = '10'
    $env:RRHH_WEB_ROLES_MOTIVOS = '10'
    $env:RRHH_WEB_ROLES_ASISTENCIA = '10'
    $env:RRHH_WEB_ROLES_VACACIONES = '10'
    $env:RRHH_WEB_ROLES_PERMISOS = '10'
    $env:RRHH_VACACIONES_DIAS_ANUALES = '30'
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
        $datosDemo=@"
ALTER TABLE "Persona" ADD COLUMN "NumDocID" varchar(20) DEFAULT 'FICTICIO';
ALTER TABLE "Empleado" ADD COLUMN "Foto" text;
UPDATE "Empleado" SET "FechaIngreso"='2024-03-01' WHERE "IdEmpleado"=102;
UPDATE "Permiso" SET "EstadoSolicitud"='Anulado' WHERE "IdEmpleado"=101;
UPDATE "Motivo_Perm" SET "EsVacacionesPiloto"=true WHERE "idMotivo"=10;
INSERT INTO "TipoPermiso" VALUES (2,'Salida autorizada ficticia');
INSERT INTO "Motivo_Perm" ("idMotivo","Descrip_Motivo","Abrev","idTipoPermiso","TipoModalidad","Activo","UnaVezPorAnio","GrupoReglaAnual") VALUES
(900,'Licencia académica A','LAA',1,'P',true,true,'PILOTO-FAMILIAR'),
(901,'Licencia académica B','LAB',1,'P',true,true,'PILOTO-FAMILIAR'),
(902,'Salida autorizada ficticia','SAL',2,'P',true,false,NULL);
INSERT INTO "Permiso" ("IdEmpleado","NPermiso","idMotivo","FechaInicio","FechaFin","EstadoSolicitud","MediaJornadaVacaciones") VALUES
(101,100,10,'2026-05-01','2026-05-12','Aprobado',false),(101,101,10,'2026-05-13','2026-05-13','Aprobado',true),
(101,102,20,'2026-11-18','2026-11-18','Aprobado',false);
INSERT INTO "Teletrabajo" ("IdEmpleado","FechaInicio","FechaFin","Modalidad","DiasRemotos") VALUES (101,'2026-11-16','2026-11-20','T',31);
INSERT INTO "Asistencia" ("IdEmpleado","Fecha") VALUES (101,'2026-11-18'),(101,'2026-11-18 16:00'),(102,CURRENT_DATE);
INSERT INTO "Rol" VALUES (20,'0500000');
INSERT INTO "Usuario" VALUES (4,'empleado_a',101,true,'$hash','$saltText',210000),(5,'empleado_b',102,true,'$hash','$saltText',210000);
INSERT INTO "Usuario_Rol" VALUES (4,20),(5,20);
"@
        $datosDemo | & $psql @argsDb
        if($LASTEXITCODE){throw 'Falló la preparación de la demo integrada local.'}
        if($Escritorio){
            $ejecutable=Join-Path $repo 'Software/RecursosHumanos/bin/Debug/net48/RecursosHumanos.exe'
            if(!(Test-Path -LiteralPath $ejecutable)){throw 'Ejecute Software/scripts/build.cmd antes de abrir la demo de escritorio.'}
            $env:RRHH_POSTGRES_CONNECTION=$env:RRHH_WEB_POSTGRES
            $env:RRHH_VACACIONES_ROLES='10'
            $env:RRHH_PERMISOS_ROLES='10'
            $env:RRHH_ASISTENCIA_ROLES='10'
            $env:RRHH_AUTOCONSULTA_ROLES='20'
            $env:RRHH_SOLO_AUTOCONSULTA=if($SoloEmpleado){'1'}else{'0'}
            $env:RRHH_ENV_FILE=Join-Path $workspace 'demo.env'
            [IO.File]::WriteAllText($env:RRHH_ENV_FILE,'# Demo local ficticia; conexión proporcionada solo al proceso.')
            # Ventana interactiva solicitada para QA visual, no servicio auxiliar.
            $desktop=Start-Process -FilePath $ejecutable -WorkingDirectory (Split-Path $ejecutable) -WindowStyle Normal -PassThru
        }
        Write-Host "Página local: $url"
        if($SoloEmpleado){Write-Host 'Usuario para esta demo de empleado: empleado_a'}else{Write-Host 'Usuario ficticio: operador'}
        Write-Host "Contraseña de esta sesión: $password"
        Write-Host 'Empleados ficticios: 101 y 102. El 11/11/2026 es feriado.'
        Write-Host 'Autoconsulta ficticia: empleado_a (101), empleado_b (102); misma contraseña de esta sesión.'
        Write-Host 'Ejemplos: saldo 101 al 12/11/2026 = 47,5; truncas = 21,00; consolidado 16–23/11/2026.'
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
    if ($motivos.Count -ne 4) { throw 'El catálogo de motivos debía incluir los cuatro motivos ficticios.' }
    $ausencias = Invoke-RestMethod $ausenciasUrl -WebSession $session
    if ($ausencias.Count -ne 2 -or $ausencias[0].idEmpleado -ne 101 -or
        $ausencias[0].diasEnPeriodo -ne 3 -or $ausencias[1].diasEnPeriodo -ne 1) { throw 'El reporte RF-18 no respetó el solapamiento inclusivo.' }
    $permisoAnuladoRf18 = @'
INSERT INTO public."Permiso" ("IdEmpleado", "FechaInicio", "FechaFin", "idMotivo", "EstadoSolicitud")
VALUES (101, '2026-11-11', '2026-11-11', 40, 'Anulado');
'@
    $permisoAnuladoRf18 | & $psql @argsDb
    if ($LASTEXITCODE) { throw 'No se pudo preparar el permiso anulado de RF-18.' }
    $ausenciasConAnulado = Invoke-RestMethod $ausenciasUrl -WebSession $session
    $ausenciasMotivoAnulado = Invoke-RestMethod "$ausenciasUrl&motivo=40" -WebSession $session
    if ($ausenciasConAnulado.Count -ne 2 -or $ausenciasMotivoAnulado.Count -ne 0) {
        throw "RF-18 debía devolver 2 filas generales y 0 para el motivo anulado. Obtuvo $($ausenciasConAnulado.Count) y $($ausenciasMotivoAnulado.Count)."
    }
    $historialRf18 = 'SELECT count(*) FROM public."Permiso" WHERE "IdEmpleado"=101 AND "idMotivo"=40 AND "EstadoSolicitud"=''Anulado'';' | & $psql @argsDb -At
    if ($LASTEXITCODE -or $historialRf18 -ne '1') { throw 'RF-18 no conservó el permiso anulado en el historial.' }
    Write-Output 'RF-18: anulado excluido con y sin filtro y conservado en el historial.'
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

    $turno.numero = 0
    $turno.desde = '2026-11-16'
    $turno.hasta = '2026-11-20'
    Assert-Http 201 (Post 'horarios/asignaciones' $turno $session)
    $historicoUrl = "$url/api/horarios/historico?empleado=101"
    Assert-Http 403 (Invoke-WebRequest $historicoUrl -WebSession $soloTeletrabajo -SkipHttpErrorCheck)
    $historico = Invoke-RestMethod $historicoUrl -WebSession $session
    if ($historico.Count -ne 2 -or $historico[0].n -ne 2 -or $historico[1].n -ne 1 -or
        $historico[1].descrip_Horario -ne 'Turno ficticio') { throw 'El histórico no conservó ambas asignaciones en orden.' }
    $interseccion = Invoke-RestMethod "$historicoUrl&desde=2026-11-10&hasta=2026-11-12" -WebSession $session
    if ($interseccion.Count -ne 1 -or $interseccion[0].n -ne 1) { throw 'El histórico no encontró el turno que contiene el rango.' }
    $vacio = Invoke-RestMethod "$historicoUrl&desde=2026-11-21&hasta=2026-11-22" -WebSession $session
    if ($vacio.Count -ne 0) { throw 'El histórico incluyó una asignación fuera del rango.' }
    Assert-Http 400 (Invoke-WebRequest "$historicoUrl&desde=2026-11-10" -WebSession $session -SkipHttpErrorCheck)
    Assert-Http 400 (Invoke-WebRequest "$historicoUrl&desde=2026-11-12&hasta=2026-11-10" -WebSession $session -SkipHttpErrorCheck)

    $motivosPermisoUrl = "$url/api/motivos-permiso"
    Assert-Http 403 (Invoke-WebRequest "$motivosPermisoUrl/tipos" -WebSession $soloTeletrabajo -SkipHttpErrorCheck)
    Assert-Http 400 (Invoke-WebRequest $motivosPermisoUrl -WebSession $session -Method Post -Body '{}' -ContentType 'application/json' -SkipHttpErrorCheck)
    $tipos = Invoke-RestMethod "$motivosPermisoUrl/tipos" -WebSession $session
    if ($tipos.Count -ne 1 -or $tipos[0].id -ne 1) { throw 'El catálogo de tipos debe ofrecer el tipo ficticio.' }
    $nuevoMotivo = @{tipo=1; descripcion='Motivo QA'; abreviatura='QA'; salario=$null}
    $creado = Post 'motivos-permiso' $nuevoMotivo $session
    Assert-Http 201 $creado
    $motivoId = ($creado.Content | ConvertFrom-Json).id
    $motivosDelTipo = Invoke-RestMethod "$motivosPermisoUrl`?tipo=1" -WebSession $session
    if ($motivosDelTipo.Count -ne 3 -or @($motivosDelTipo | Where-Object { $_.id -eq $motivoId -and $_.modalidad -eq 'P' }).Count -ne 1) {
        throw 'El alta debe conservar la modalidad P y excluir motivos de otra modalidad.'
    }
    $nuevoMotivo.descripcion = ' '
    Assert-Http 400 (Post 'motivos-permiso' $nuevoMotivo $session)
    Assert-Http 400 (Invoke-WebRequest "$motivosPermisoUrl/$motivoId/eliminar" -WebSession $session -Method Post -SkipHttpErrorCheck)
    Assert-Http 403 (Post "motivos-permiso/$motivoId/eliminar" @{} $soloTeletrabajo)
    Assert-Http 400 (Post 'motivos-permiso/10/eliminar' @{} $session)
    Assert-Http 400 (Post 'motivos-permiso/30/eliminar' @{} $session)
    Assert-Http 400 (Post 'motivos-permiso/40/eliminar' @{} $session)
    Assert-Http 204 (Post "motivos-permiso/$motivoId/eliminar" @{} $session)
    Assert-Http 400 (Post "motivos-permiso/$motivoId/eliminar" @{} $session)
    $despuesDeBaja = Invoke-RestMethod "$motivosPermisoUrl`?tipo=1" -WebSession $session
    if ($despuesDeBaja.Count -ne 2 -or $despuesDeBaja.id -contains $motivoId) {
        throw 'La baja eliminó un motivo incorrecto o no quitó el seleccionado.'
    }
    Assert-Http 204 (Post 'salir' @{} $session)
    $asistenciaUrl = "$url/api/asistencia?empleado=101&desde=2026-11-09&hasta=2026-11-15"
    Assert-Http 401 (Invoke-WebRequest "$asistenciaUrl&modo=A" -SkipHttpErrorCheck)
    Assert-Http 403 (Invoke-WebRequest "$asistenciaUrl&modo=A" -WebSession $soloTeletrabajo -SkipHttpErrorCheck)
    Assert-Http 204 (Post 'login' @{login='operador'; password=$password} $session)
    $asistencia = Invoke-RestMethod "$asistenciaUrl&modo=A" -WebSession $session
    $productividad = Invoke-RestMethod "$asistenciaUrl&modo=P" -WebSession $session
    if ($asistencia.total -ne 4 -or $productividad.total -ne 3 -or $asistencia.dias.Count -ne 7) {
        throw 'RF-17: se duplicaron marcaciones en feriado o sábado o cambió Productividad.'
    }
    if (@($asistencia.dias | Where-Object { $_.asistio -and $_.noLaborable }).Count -ne 2) {
        throw 'RF-17: el detalle debe conservar marcación en feriado y sábado.'
    }
    Assert-Http 400 (Invoke-WebRequest "$asistenciaUrl&modo=X" -WebSession $session -SkipHttpErrorCheck)
    $vacacionesUrl = "$url/api/vacaciones/generadas?empleado=101&corte=2026-11-12"
    Assert-Http 403 (Invoke-WebRequest $vacacionesUrl -WebSession $soloTeletrabajo -SkipHttpErrorCheck)
    $vacaciones = Invoke-RestMethod $vacacionesUrl -WebSession $session
    if ($vacaciones.generadas -ne 60 -or $vacaciones.aniosCumplidos -ne 2) {
        throw 'RF-07: dos aniversarios completos deben generar 60 días.'
    }
    Assert-Http 400 (Invoke-WebRequest "$url/api/vacaciones/generadas?empleado=102&corte=2026-11-12" -WebSession $session -SkipHttpErrorCheck)
    Assert-Http 400 (Invoke-WebRequest "$url/api/vacaciones/generadas?empleado=101&corte=2024-02-29" -WebSession $session -SkipHttpErrorCheck)
    $permisosUrl = "$url/api/permisos?empleado=101&numero=1"
    Assert-Http 401 (Invoke-WebRequest $permisosUrl -SkipHttpErrorCheck)
    Assert-Http 403 (Invoke-WebRequest $permisosUrl -WebSession $soloTeletrabajo -SkipHttpErrorCheck)
    $permiso = @{idEmpleado=101;numero=0;idMotivo=10;desde='2026-03-01';hasta='2026-03-01';estado='Solicitado';observacion='Permiso ficticio'}
    Assert-Http 403 (Post 'permisos' $permiso $soloTeletrabajo)
    Assert-Http 400 (Invoke-WebRequest "$url/api/permisos" -Method Post -WebSession $session -ContentType 'application/json' -Body ($permiso | ConvertTo-Json) -SkipHttpErrorCheck)
    $altaPermiso = Post 'permisos' $permiso $session
    Assert-Http 200 $altaPermiso
    $numeroPermiso = ($altaPermiso.Content | ConvertFrom-Json).numero
    Assert-Http 400 (Post 'permisos' $permiso $session)
    # RF-15: prepara una triple fuente real del piloto sin dejar una solicitud previa ocupando el mes.
    $anterior=Invoke-RestMethod "$url/api/permisos?empleado=101&numero=1" -WebSession $session
    $anterior.estado='Anulado'
    Assert-Http 200 (Post 'permisos' $anterior $session)
    Assert-Http 201 (Post 'periodos' @{empleado=101;desde='2026-11-16';hasta='2026-11-20';modalidad='T';diasRemotos=31} $session)
    Assert-Http 200 (Post 'permisos' @{idEmpleado=101;numero=0;idMotivo=20;desde='2026-11-18';hasta='2026-11-18';estado='Aprobado'} $session)
    'INSERT INTO "Asistencia" ("IdEmpleado","Fecha") VALUES (101,''2026-11-18''),(101,''2026-11-18 16:00'');' | & $psql @argsDb
    if($LASTEXITCODE){throw 'No se pudieron crear marcaciones ficticias RF-15.'}
    $consolidadoUrl="$url/api/asistencia/consolidada?empleado=101&desde=2026-11-16&hasta=2026-11-23"
    Assert-Http 401 (Invoke-WebRequest $consolidadoUrl -SkipHttpErrorCheck)
    Assert-Http 403 (Invoke-WebRequest $consolidadoUrl -WebSession $soloTeletrabajo -SkipHttpErrorCheck)
    $consolidado=Invoke-RestMethod $consolidadoUrl -WebSession $session
    if($consolidado.ausencias -ne 1 -or $consolidado.presenciales -ne 0 -or $consolidado.remotos -ne 4 -or $consolidado.sinRegistro -ne 1 -or $consolidado.inconsistencias -ne 1){throw 'RF-15: no aplica prioridad y categoría única.'}
    Assert-Http 400 (Invoke-WebRequest "$url/api/asistencia/consolidada?empleado=101&desde=2025-01-01&hasta=2026-11-23" -WebSession $session -SkipHttpErrorCheck)
    $cargado = Invoke-RestMethod "$url/api/permisos?empleado=101&numero=$numeroPermiso" -WebSession $session
    if ($cargado.estado -ne 'Solicitado' -or $cargado.observacion -ne 'Permiso ficticio') { throw 'RF-03: carga incorrecta.' }
    $permiso.numero=$numeroPermiso
    $permiso.estado='Anulado'
    Assert-Http 200 (Post 'permisos' $permiso $session)
    $permiso.numero=0
    $permiso.estado='Solicitado'
    Assert-Http 200 (Post 'permisos' $permiso $session)
    $permiso.numero=$numeroPermiso
    $permiso.estado='Aprobado'
    Assert-Http 400 (Post 'permisos' $permiso $session)
    $rechazado = Invoke-RestMethod "$url/api/permisos?empleado=101&numero=$numeroPermiso" -WebSession $session
    if ($rechazado.estado -ne 'Anulado') { throw 'RF-03: una reactivación inválida modificó el estado.' }
    Assert-Http 400 (Invoke-WebRequest "$url/api/permisos?empleado=101&numero=2147483647" -WebSession $session -SkipHttpErrorCheck)
    $sqlLicencias = @'
UPDATE "Motivo_Perm" SET "EsVacacionesPiloto"=true WHERE "idMotivo"=10;
INSERT INTO "Permiso" ("IdEmpleado","NPermiso","idMotivo","FechaInicio","FechaFin","EstadoSolicitud","MediaJornadaVacaciones") VALUES
(101,100,10,'2026-05-01','2026-05-12','Aprobado',false),(101,101,10,'2026-05-13','2026-05-13','Aprobado',true);
INSERT INTO "TipoPermiso" VALUES (2,'Salida autorizada ficticia');
INSERT INTO "Motivo_Perm" ("idMotivo","Descrip_Motivo","idTipoPermiso","Activo","UnaVezPorAnio","GrupoReglaAnual")
VALUES (900,'Licencia ficticia A',1,true,true,'PILOTO-FAMILIAR'),(901,'Licencia ficticia B',1,true,true,'PILOTO-FAMILIAR'),
(902,'Salida autorizada ficticia',2,true,false,NULL);
'@
    $sqlLicencias | & $psql @argsDb
    if ($LASTEXITCODE) { throw 'Falló la preparación del grupo anual ficticio.' }
    $saldoUrl="$url/api/vacaciones/saldo?empleado=101&corte=2026-11-12"
    Assert-Http 401 (Invoke-WebRequest $saldoUrl -SkipHttpErrorCheck)
    Assert-Http 403 (Invoke-WebRequest $saldoUrl -WebSession $soloTeletrabajo -SkipHttpErrorCheck)
    $saldo=Invoke-RestMethod $saldoUrl -WebSession $session
    if ($saldo.generadas -ne 60 -or $saldo.usadas -ne 12.5 -or $saldo.pendientes -ne 47.5 -or $saldo.consumos.Count -ne 2) { throw 'RF-08: saldo 60 - 12,5 debe dar 47,5.' }
    $reporteVacUrl="$url/api/vacaciones/reporte?anio=2026&corte=2026-11-12"
    Assert-Http 401 (Invoke-WebRequest $reporteVacUrl -SkipHttpErrorCheck)
    Assert-Http 403 (Invoke-WebRequest $reporteVacUrl -WebSession $soloTeletrabajo -SkipHttpErrorCheck)
    $reporteVac=Invoke-RestMethod $reporteVacUrl -WebSession $session
    if($reporteVac.Count -ne 2 -or $reporteVac[0].pendientes -ne 47.5 -or $reporteVac[0].truncasAlCorte -ne 21 -or !$reporteVac[1].error -or $null -ne $reporteVac[1].pendientes){throw 'RF-11: reporte no concilia o encubre datos incompletos.'}
    if(@(Invoke-RestMethod "$reporteVacUrl&empleado=101&area=1" -WebSession $session).Count -ne 1){throw 'RF-11: filtros no aplicados.'}
    Assert-Http 400 (Invoke-WebRequest "$url/api/vacaciones/reporte?anio=2025&corte=2026-11-12" -WebSession $session -SkipHttpErrorCheck)
    $truncasUrl="$url/api/vacaciones/truncas?empleado=101&cese=2026-11-12"
    Assert-Http 401 (Invoke-WebRequest $truncasUrl -SkipHttpErrorCheck)
    Assert-Http 403 (Invoke-WebRequest $truncasUrl -WebSession $soloTeletrabajo -SkipHttpErrorCheck)
    if ((Invoke-RestMethod $truncasUrl -WebSession $session).truncas -ne 21) { throw 'RF-09: ejemplo del grupo debe generar 21,00.' }
    Assert-Http 400 (Invoke-WebRequest "$url/api/vacaciones/truncas?empleado=101&cese=2024-02-29" -WebSession $session -SkipHttpErrorCheck)
    $media=@{idEmpleado=101;numero=0;idMotivo=10;desde='2026-06-15';hasta='2026-06-15';estado='Aprobado';mediaJornadaVacaciones=$true}
    $altaMedia=Post 'permisos' $media $session
    Assert-Http 200 $altaMedia
    $media.numero=($altaMedia.Content | ConvertFrom-Json).numero
    $saldo=Invoke-RestMethod $saldoUrl -WebSession $session
    if ($saldo.usadas -ne 13 -or $saldo.pendientes -ne 47) { throw 'RF-10: media jornada no descontó 0,5.' }
    $media.estado='Anulado'
    Assert-Http 200 (Post 'permisos' $media $session)
    if ((Invoke-RestMethod $saldoUrl -WebSession $session).usadas -ne 12.5) { throw 'RF-10: anular no devolvió 0,5.' }
    $media.numero=0
    $media.estado='Aprobado'
    $media.desde=$media.hasta='2026-06-13'
    Assert-Http 400 (Post 'permisos' $media $session)
    $permiso.numero=0
    $permiso.idMotivo=900
    $permiso.desde='2026-03-10'
    $permiso.hasta='2026-03-10'
    $permiso.estado='Aprobado'
    $permiso.idMotivo=902
    Assert-Http 400 (Post 'permisos' $permiso $session)
    $permiso.idMotivo=900
    $permiso.dia=$true
    $permiso.retorno=$true
    Assert-Http 400 (Post 'permisos' $permiso $session)
    $permiso.retorno=$false
    Assert-Http 200 (Post 'permisos' $permiso $session)
    $permiso.idMotivo=901
    $permiso.desde='2026-03-20'
    $permiso.hasta='2026-03-20'
    Assert-Http 400 (Post 'permisos' $permiso $session)
    'UPDATE "Permiso" SET "EstadoSolicitud"=''Anulado'' WHERE "IdEmpleado"=102; DELETE FROM "Asistencia" WHERE "IdEmpleado"=102 AND "Fecha"::date=CURRENT_DATE;' | & $psql @argsDb
    if($LASTEXITCODE){throw 'No se preparó el escenario local de salidas.'}
    $hoySalida=[DateTime]::Today.ToString('yyyy-MM-dd')
    $salida=@{idEmpleado=102;numero=0;idMotivo=902;desde=$hoySalida;hasta=$hoySalida;estado='Solicitado'}
    Assert-Http 400 (Post 'permisos' $salida $session)
    'INSERT INTO "Asistencia" ("IdEmpleado","Fecha","Hor_Sal") VALUES (102,CURRENT_DATE,''00:00:00'');' | & $psql @argsDb
    if($LASTEXITCODE){throw 'No se creó la marcación ficticia de hoy.'}
    $altaSalida=Post 'permisos' $salida $session
    Assert-Http 200 $altaSalida
    'UPDATE "Asistencia" SET "Hor_Sal"=''17:00:00'' WHERE "IdEmpleado"=102 AND "Fecha"::date=CURRENT_DATE;' | & $psql @argsDb
    if($LASTEXITCODE){throw 'No se simuló salida ya registrada.'}
    $segundaSalida=Post 'permisos' $salida $session
    Assert-Http 400 $segundaSalida
    if(($segundaSalida.Content | ConvertFrom-Json).error -notmatch 'salida registrada'){throw 'No se validó la salida previa dentro de la transacción.'}
    $salida.numero=($altaSalida.Content | ConvertFrom-Json).numero
    $salida.estado='Anulado'
    Assert-Http 200 (Post 'permisos' $salida $session)
    Assert-Http 204 (Post 'salir' @{} $session)
    Assert-Http 401 (Invoke-WebRequest "$url/api/periodos?empleado=101" -WebSession $session -SkipHttpErrorCheck)
    $cuentas=@"
UPDATE "Empleado" SET "FechaIngreso"='2024-03-01' WHERE "IdEmpleado"=102;
INSERT INTO "Rol" VALUES (20,'0500000');
INSERT INTO "Usuario" VALUES (4,'empleado_a',101,true,'$hash','$saltText',210000),(5,'empleado_b',102,true,'$hash','$saltText',210000);
INSERT INTO "Usuario_Rol" VALUES (4,20),(5,20);
"@
    $cuentas | & $psql @argsDb
    if($LASTEXITCODE){throw 'No se pudieron crear las cuentas ficticias de autoconsulta.'}
    $cuentaA=[Microsoft.PowerShell.Commands.WebRequestSession]::new()
    $cuentaB=[Microsoft.PowerShell.Commands.WebRequestSession]::new()
    Assert-Http 204 (Post 'login' @{login='empleado_a';password=$password} $cuentaA)
    Assert-Http 204 (Post 'login' @{login='empleado_b';password=$password} $cuentaB)
    $propiaUrl="$url/api/mi/vacaciones?corte=2026-11-12"
    Assert-Http 401 (Invoke-WebRequest $propiaUrl -SkipHttpErrorCheck)
    $propiaA=Invoke-RestMethod "$propiaUrl&empleado=102" -WebSession $cuentaA
    $propiaB=Invoke-RestMethod "$propiaUrl&empleado=101" -WebSession $cuentaB
    if($propiaA.empleado -ne 101 -or $propiaB.empleado -ne 102 -or $propiaB.usadas -ne 0){throw 'RF-12: se consultó otro empleado.'}
    if((Invoke-RestMethod "$url/api/sesion" -WebSession $cuentaA).operador){throw 'RF-12: empleado recibió rol operador.'}
    Assert-Http 403 (Invoke-WebRequest "$url/api/periodos?empleado=102" -WebSession $cuentaA -SkipHttpErrorCheck)
    Assert-Http 403 (Invoke-WebRequest $saldoUrl -WebSession $cuentaA -SkipHttpErrorCheck)
    Assert-Http 403 (Post 'permisos' $permiso $cuentaA)
    Assert-Http 204 (Post 'salir' @{} $cuentaA)
    Assert-Http 401 (Invoke-WebRequest $propiaUrl -WebSession $cuentaA -SkipHttpErrorCheck)
    Write-Output 'QA correcta: módulos operativos, vacaciones RF-08/09/10/11 y autoconsulta RF-12 aislada entre dos cuentas.'
} finally {
    if($desktop -and !$desktop.HasExited){Stop-Process -Id $desktop.Id}
    if ($server -and !$server.HasExited) { Stop-Process -Id $server.Id }
    if ($dbStarted) { & $pgctl -D $data -m fast -w stop }
    Remove-Item Env:PGPASSWORD, Env:RRHH_WEB_POSTGRES, Env:RRHH_WEB_ROLES, Env:RRHH_WEB_ROLES_AUSENCIAS, Env:RRHH_WEB_ROLES_HORARIOS, Env:RRHH_WEB_ROLES_MOTIVOS, Env:RRHH_WEB_ROLES_ASISTENCIA, Env:RRHH_WEB_ROLES_VACACIONES, Env:RRHH_WEB_ROLES_PERMISOS, Env:RRHH_VACACIONES_DIAS_ANUALES, Env:ASPNETCORE_ENVIRONMENT, Env:RRHH_TEST_POSTGRES_CONNECTION -ErrorAction SilentlyContinue
    Write-Output "Clúster de QA detenido. Diagnósticos ficticios en $workspace."
    Remove-Item Env:RRHH_WEB_ROLES_AUTOCONSULTA -ErrorAction SilentlyContinue
    Remove-Item Env:RRHH_POSTGRES_CONNECTION,Env:RRHH_VACACIONES_ROLES,Env:RRHH_PERMISOS_ROLES,Env:RRHH_ASISTENCIA_ROLES,Env:RRHH_AUTOCONSULTA_ROLES,Env:RRHH_ENV_FILE -ErrorAction SilentlyContinue
    Remove-Item Env:RRHH_SOLO_AUTOCONSULTA -ErrorAction SilentlyContinue
}
