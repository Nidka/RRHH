# RRHH — código fuente recuperado

Este directorio contiene una reconstrucción editable en C# de la aplicación
WinForms `RecursosHumanos.exe` y de sus bibliotecas propias. La distribución
original fue compilada en Visual Basic .NET para .NET Framework 2.0/3.5; el
código recuperado se normalizó a proyectos SDK de **.NET Framework 4.8** para
poder abrirlo y compilarlo con Visual Studio 2022.

## Estado actual

- `RRHH.Recovered.sln` compila con **0 errores**.
- Se recuperaron formularios, reportes, recursos `.resx`, clases de negocio y
  metadatos de ensamblado.
- El ejecutable principal se genera en
  `RecursosHumanos/bin/Debug/net48/RecursosHumanos.exe`.
- Se eliminaron del código recuperado las contraseñas SQL Server que estaban
  escritas en texto plano y los valores cifrados heredados para bases Access.
  La configuración de desarrollo usa autenticación integrada y `localhost`
  como valores no secretos.
- `GRLL/` conserva el código de `GRLL.dll`, pero ese proyecto no está incluido
  en la solución compilable. Siete controles antiguos con árboles de expresión
  generados por VB no tienen una traducción C# válida producida por ILSpy. Por
  ahora la aplicación compilable enlaza el `GRLL.dll` original instalado
  localmente en `lib/legacy`. El código de GRLL queda disponible como referencia
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
.\scripts\setup-dependencies.cmd "C:\ruta\a\la\distribucion-original"
dotnet restore .\RRHH.Recovered.sln
dotnet build .\RRHH.Recovered.sln --no-restore
```

También se puede ejecutar `scripts\build.cmd`. Ese lanzador evita el bloqueo
habitual de PowerShell cuando la política local no permite ejecutar archivos
`.ps1` directamente.

Las cinco bibliotecas de soporte necesarias para leer los recursos WinForms
recuperados están versionadas en `lib/resource-runtime`. Por eso la solución no
necesita descargar paquetes NuGet para compilarse.

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

## Base de datos

La aplicación recuperada **todavía es cliente de SQL Server**. Usa
`System.Data.SqlClient`, LINQ-to-SQL, SQL con dialecto T-SQL y procedimientos
almacenados. Cambiar sólo la cadena a PostgreSQL/Npgsql no es suficiente y
rompería la aplicación.

En el workspace únicamente se encontró `CMI_Backup_QA.bak`, que es un respaldo
de SQL Server. No se encontró un `pg_dump`, DDL PostgreSQL ni configuración de
la base ya migrada. La evaluación y el plan de migración están en
`docs/POSTGRESQL_MIGRATION.md`. La carpeta `database/` contiene el procedimiento
seguro para exportar y versionar únicamente el esquema PostgreSQL, nunca datos
reales de empleados.

## Advertencias conocidas

- La solución genera advertencias propias de la decompilación (campos de
  componentes que permanecen nulos y código legado no usado), pero no errores.
- El código heredado concatena valores en algunas sentencias SQL. Debe
  parametrizarse durante la migración para evitar inyección SQL y problemas de
  formato regional.
- Los binarios originales pueden conservar cadenas históricas aunque las copias
  de código y configuración recuperadas ya fueron saneadas.
