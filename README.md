# RRHH — código fuente recuperado

La carpeta `Software/` contiene una reconstrucción editable en C# de la aplicación
WinForms `RecursosHumanos.exe` y de sus bibliotecas propias. La distribución
original fue compilada en Visual Basic .NET para .NET Framework 2.0/3.5; el
código recuperado se normalizó a proyectos SDK de **.NET Framework 4.8** para
poder abrirlo y compilarlo con Visual Studio 2022.

## Estado actual

- `Software/RRHH.sln` compila con **0 errores**.
- El arranque y la autorización inicial ya se conectan a PostgreSQL mediante
  Npgsql. Se validan el esquema, el usuario, su empleado y su rol sin usar el
  procedimiento SQL Server `GRLL_Usuario_Acceso`.
- Se recuperaron formularios, reportes, recursos `.resx`, clases de negocio y
  metadatos de ensamblado.
- El ejecutable principal se genera en
  `Software/RecursosHumanos/bin/Debug/net48/RecursosHumanos.exe`.
- Se eliminaron del código recuperado las contraseñas SQL Server que estaban
  escritas en texto plano y los valores cifrados heredados para bases Access.
  La configuración de desarrollo usa autenticación integrada y `localhost`
  como valores no secretos.
- `GRLL/` conserva el código de `GRLL.dll`, pero ese proyecto no está incluido
  en la solución compilable. Siete controles antiguos con árboles de expresión
  generados por VB no tienen una traducción C# válida producida por ILSpy. Por
  ahora la aplicación compilable enlaza el `GRLL.dll` original instalado
  localmente en `Software/lib/legacy`. El código de GRLL queda disponible como referencia
  y para su refactorización gradual.

## Abrir y compilar

Requisitos:

- Windows y Visual Studio 2022 con desarrollo de escritorio .NET.
- .NET Framework 4.8 Developer Pack.
- Las DLL DevExpress 11.2 y demás dependencias incluidas en el directorio
  original. Son antiguas y no deben sustituirse sin probar los formularios y
  reportes.

Desde PowerShell:

```powershell
cd .\Software
.\scripts\setup-dependencies.cmd "C:\ruta\a\la\distribucion-original"
dotnet restore .\RRHH.sln
dotnet build .\RRHH.sln --no-restore
```

También se puede ejecutar `scripts\build.cmd`. Ese lanzador evita el bloqueo
habitual de PowerShell cuando la política local no permite ejecutar archivos
`.ps1` directamente.

Las cinco bibliotecas de soporte necesarias para leer los recursos WinForms
recuperados están versionadas en `lib/resource-runtime`. La primera compilación
también restaura Npgsql 4.1.14 y sus dependencias desde NuGet.

Las DLL heredadas y licenciadas no se publican en GitHub. Cada integrante las
prepara una sola vez con `scripts\setup-dependencies.cmd`; consulta
`lib/legacy/README.md`.

## Flujo de GitHub

Después de clonar y preparar las dependencias:

```powershell
git switch -c feature/mi-cambio
.\scripts\build.cmd
git add .
git commit -m "Describe el cambio"
git push -u origin feature/mi-cambio
```

Las reglas mínimas del equipo están en `CONTRIBUTING.md`.

## Qué significa «código recuperado»

La reconstrucción proviene del IL de los ensamblados, con ayuda de los PDB
existentes. El comportamiento ejecutable se conserva, pero no es posible
recuperar los comentarios originales, el historial, todos los nombres locales
ni la organización exacta del repositorio de 2013. Las consultas que el
decompilador dejó como árboles de expresión inválidos se reescribieron como
LINQ legible.

## Conexión PostgreSQL

La configuración no guarda contraseñas. Cada desarrollador define localmente
la variable `RRHH_POSTGRES_CONNECTION` antes de ejecutar o depurar:

```powershell
$env:RRHH_POSTGRES_CONNECTION = 'Host=localhost;Port=5432;Database=CMI;Username=rrhh_app;Password=SU_CLAVE'
.\Software\scripts\check-postgresql.cmd -Login USUARIO_RRHH
```

El comprobador ejecuta la misma capa de datos del programa y devuelve error si
no puede conectar, faltan las tablas requeridas o el usuario no tiene un rol
para el sistema `0500000`. En servidores y CI use el almacén de secretos de la
plataforma en lugar de escribir la clave en archivos del repositorio.

El nuevo login ya usa PostgreSQL. Sin embargo, la aplicación recuperada aún
contiene pantallas cliente de SQL Server: `System.Data.SqlClient`, LINQ-to-SQL,
T-SQL y procedimientos almacenados. Esos módulos deben portarse por caso de
uso; no se presenta este avance como una migración funcional completa.

Se encontró el dump PostgreSQL 18.3 `RRHH/BD/CMI.sql` y se extrajo su esquema
sin datos a `BD/schema.sql`. La migración contiene 101 tablas, pero no incluye
los 303 procedimientos, 90 vistas, 47 funciones ni las restricciones de la
base SQL Server original. La evaluación detallada está en
`Software/docs/POSTGRESQL_MIGRATION.md`. El dump con datos reales permanece
fuera de GitHub.

## Advertencias conocidas

- La solución genera advertencias propias de la decompilación (campos de
  componentes que permanecen nulos y código legado no usado), pero no errores.
- El código heredado concatena valores en algunas sentencias SQL. Debe
  parametrizarse durante la migración para evitar inyección SQL y problemas de
  formato regional.
- Los binarios originales pueden conservar cadenas históricas aunque las copias
  de código y configuración recuperadas ya fueron saneadas.
