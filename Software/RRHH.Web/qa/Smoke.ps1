param(
    [Parameter(Mandatory)][string]$PostgreSqlBin,
    [string]$Dotnet = 'dotnet',
    [int]$DatabasePort = 55414,
    [int]$WebPort = 5080
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
INSERT INTO "Empleado" VALUES (101, 1, 1);
INSERT INTO "Persona" VALUES (1, 'Ficticio', '', 'Operador');
INSERT INTO "Usuario" VALUES (1, 'operador', 101, true, '$hash', '$saltText', 210000),
  (2, 'sin_permiso', 101, true, '$hash', '$saltText', 210000);
INSERT INTO "Rol" VALUES (1, '0500000'), (2, '0500000');
INSERT INTO "Usuario_Rol" VALUES (1, 1), (2, 2);
INSERT INTO "RRHH_Feriado" VALUES (1, '2026-11-11', 'Feriado ficticio');
"@
    $fixture | & $psql @argsDb
    if ($LASTEXITCODE) { throw 'Falló la preparación de datos ficticios.' }
    Invoke-Checked $psql ($argsDb + @('-f', (Join-Path $repo 'BD/migrations/20261112_03_teletrabajo.sql')))
    Invoke-Checked $Dotnet @('build', (Join-Path $hostProject 'RRHH.Web.csproj'))
    $env:RRHH_WEB_POSTGRES = "Host=127.0.0.1;Port=$DatabasePort;Username=qa;Password=$dbPassword;Database=postgres;SSL Mode=Disable"
    $env:RRHH_WEB_ROLES = '1'
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
    Assert-Http 204 (Post 'salir' @{} $session)
    Assert-Http 401 (Invoke-WebRequest "$url/api/periodos?empleado=101" -WebSession $session -SkipHttpErrorCheck)
    $manifest = Invoke-RestMethod "$url/manifest.webmanifest"
    if ($manifest.display -ne 'standalone') { throw 'Configuración de la PWA inválida.' }
    foreach ($icon in $manifest.icons) { Assert-Http 200 (Invoke-WebRequest ($url + $icon.src)) }
    Assert-Http 200 (Invoke-WebRequest "$url/sw.js")
    Write-Output 'QA correcta: sesión, acceso por rol, CSRF, alta, rechazo de solape, listado, reporte con feriado, cierre de sesión y recursos PWA.'
} finally {
    if ($server -and !$server.HasExited) { Stop-Process -Id $server.Id }
    if ($dbStarted) { & $pgctl -D $data -m fast -w stop }
    Remove-Item Env:PGPASSWORD, Env:RRHH_WEB_POSTGRES, Env:RRHH_WEB_ROLES, Env:ASPNETCORE_ENVIRONMENT -ErrorAction SilentlyContinue
    Write-Output "Clúster de QA detenido. Diagnósticos ficticios en $workspace."
}
