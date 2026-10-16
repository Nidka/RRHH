# RRHH - codigo fuente recuperado

Aplicacion WinForms de Recursos Humanos reconstruida desde los ensamblados
originales y preparada como solucion editable de .NET Framework 4.8. La base
operativa es PostgreSQL y puede ejecutarse contra Neon mediante variables de
entorno o un archivo `.env` local.

## Estado verificado

- `Software/RRHH.sln` compila con 0 errores.
- La suite automatica tiene 65 pruebas aprobadas.
- Login, empleados, catalogos, permisos, horarios, locales, asistencia, ficha
  social, documentos y reportes consultan PostgreSQL.
- La prueba integral `--check-modules` paso contra la instancia Neon
  configurada el 2026-10-15.
- La importacion biometrica conserva `Marcacion.mdb` como fuente del reloj,
  pero escribe asistencia y marcaciones en PostgreSQL dentro de una
  transaccion.
- El ejecutable x86 queda en
  `Software/RecursosHumanos/bin/x86/Debug/net48/RecursosHumanos.exe`.

La interfaz proviene de una aplicacion antigua y todavia conserva artefactos
de diseno generados por Visual Studio, como `TableAdapter` de SQL Server. Los
formularios en ejecucion reciben los `DataSet` construidos por consultas
PostgreSQL; esos artefactos se mantienen por compatibilidad con los reportes
DevExpress y pueden retirarse gradualmente.

## Estructura

- `Software/RRHH.sln`: solucion principal.
- `Software/RecursosHumanos`: aplicacion WinForms.
- `Software/ClassRRHH`: consultas y procesos funcionales de RR. HH.
- `Software/RRHH.Domain`, `RRHH.Application`, `RRHH.PostgreSql` y
  `RRHH.Presentation`: capas nuevas usadas por el login y los componentes que
  se siguen refactorizando.
- `BD/schema.sql`: esquema PostgreSQL versionable sin datos personales.
- `BD/migrations`: cambios incrementales e idempotentes del esquema.
- `Software/docs`: arquitectura y notas de migracion.

El dump real `BD/CMI.sql`, `.env`, binarios compilados y respaldos estan
excluidos de Git.

## Requisitos

- Windows y Visual Studio 2022 con desarrollo de escritorio .NET.
- .NET Framework 4.8 Developer Pack.
- Dependencias antiguas de DevExpress 11.2 y `GRLL.dll`. No se publican en
  GitHub; cada desarrollador las prepara desde la distribucion autorizada.
- Para importar relojes antiguos: proveedor Microsoft Jet OLE DB de 32 bits y
  acceso a los archivos `Marcacion.mdb` de las sedes.

## Preparar y compilar

```powershell
cd .\Software
.\scripts\setup-dependencies.cmd "C:\ruta\a\la\distribucion-original"
dotnet restore .\RRHH.sln
.\scripts\build.cmd
```

Para ejecutar pruebas:

```powershell
dotnet test .\RRHH.Tests\RRHH.Tests.csproj --no-restore -c Debug
```

## Configurar PostgreSQL o Neon

Copie la plantilla y complete solo el archivo local:

```powershell
Copy-Item .env.example .env
```

Variables admitidas:

```text
DB_HOST=servidor
DB_PORT=5432
DB_USER=usuario
DB_PASSWORD=clave
DB_NAME=base
DB_SSLMODE=require
DB_CHANNEL_BINDING=require
```

`.env` esta ignorado por Git. Tambien puede definir
`RRHH_POSTGRES_CONNECTION`; esa variable tiene prioridad. En produccion y CI
use el almacen de secretos de la plataforma.

Compruebe la conexion y luego los modulos:

```powershell
.\Software\scripts\check-postgresql.cmd
.\Software\scripts\check-postgresql.cmd -Modules
```

La segunda prueba recorre consultas representativas de empleados, permisos,
ubigeo, horarios, locales, asistencia, cumpleanos, ficha social y documentos.

Para asignar o cambiar la clave de acceso de un usuario RRHH:

```powershell
.\Software\scripts\set-user-password.cmd -Login USUARIO_RRHH
```

La clave se solicita de forma oculta y PostgreSQL guarda un hash
PBKDF2-SHA256 con salt aleatorio, no la contrasena en texto plano.

## Ejecutar la aplicacion

Abra `Software/RRHH.sln`, establezca `RecursosHumanos` como proyecto de inicio
y seleccione plataforma x86. Desde PowerShell tambien puede ejecutar:

```powershell
.\Software\RecursosHumanos\bin\x86\Debug\net48\RecursosHumanos.exe
```

## Flujo de equipo en GitHub

```powershell
git switch -c feature/mi-cambio
.\Software\scripts\build.cmd
dotnet test .\Software\RRHH.Tests\RRHH.Tests.csproj --no-restore -c Debug
git add .
git commit -m "Describe el cambio"
git push -u origin feature/mi-cambio
```

Consulte `CONTRIBUTING.md`, `Software/docs/ARQUITECTURA.md` y
`Software/docs/POSTGRESQL_MIGRATION.md` antes de cambiar acceso a datos o
formularios compartidos.

## Alcance de la recuperacion

El codigo proviene del IL de los ensamblados y de los PDB disponibles. Se
recupero el comportamiento, pero no los comentarios originales, el historial
ni todos los nombres locales de 2013. `GRLL/` conserva codigo de referencia;
la solucion compilable enlaza temporalmente `Software/lib/legacy/GRLL.dll`
porque varios controles decompilados no producen C# valido sin reescritura.
