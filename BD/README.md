# Base de datos PostgreSQL

La base con datos reales **no debe guardarse en GitHub**: contiene información
personal de Recursos Humanos. En el repositorio sólo debe versionarse:

- `schema.sql`, generado sin datos, propietarios ni privilegios;
- funciones y procedimientos PostgreSQL;
- migraciones numeradas;
- datos de prueba completamente ficticios.

`CMI.sql`, `*.dump`, `*.backup` y `*.bak` están ignorados deliberadamente.
El equipo debe intercambiar el dump privado por un canal seguro y restaurarlo
localmente; GitHub no es un almacén adecuado para datos personales de RRHH.

## Exportar el esquema migrado

Con las herramientas cliente de PostgreSQL instaladas:

```powershell
.\BD\export-schema.cmd `
  -HostName localhost `
  -DatabaseName CMI `
  -UserName postgres
```

El script usa `pg_dump --schema-only` y crea `BD/schema.sql`. La
contraseña debe suministrarse mediante el mecanismo seguro de PostgreSQL
(`pgpass`) o su solicitud interactiva; nunca se escribe en el repositorio.
El exportador detecta automáticamente las instalaciones estándar de PostgreSQL
en Windows aunque `pg_dump` no esté agregado a `PATH`.

## Situación actual

`schema.sql` fue extraído del dump PostgreSQL 18.3 ubicado localmente en
`RRHH/BD/CMI.sql`. Contiene 101 tablas, pero el dump no contiene funciones,
procedimientos, claves ni restricciones. El archivo completo incluye datos
reales y queda excluido de Git por seguridad.

Antes de considerar terminada la migración deben reconstruirse los reemplazos
de los procedimientos `spRRHH_*` y las restricciones que utilizaba el sistema.

## Restaurar una copia local

`CMI.sql` es un dump PostgreSQL en formato personalizado, pese a su extensión.
Se restaura con `pg_restore`, no ejecutándolo como SQL de texto:

```powershell
createdb -h localhost -U postgres CMI
pg_restore -h localhost -U postgres -d CMI --no-owner --no-privileges .\BD\CMI.sql
```

Después configure `RRHH_POSTGRES_CONNECTION` y ejecute
`Software\scripts\check-postgresql.cmd`.
