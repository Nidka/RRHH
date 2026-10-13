# Base de datos PostgreSQL

La base con datos reales **no debe guardarse en GitHub**: contiene información
personal de Recursos Humanos. En el repositorio sólo debe versionarse:

- `schema.sql`, generado sin datos, propietarios ni privilegios;
- funciones y procedimientos PostgreSQL;
- migraciones numeradas;
- datos de prueba completamente ficticios.

## Exportar el esquema migrado

Con las herramientas cliente de PostgreSQL instaladas:

```powershell
.\database\export-schema.ps1 `
  -HostName localhost `
  -DatabaseName CMI `
  -UserName postgres
```

El script usa `pg_dump --schema-only` y crea `database/schema.sql`. La
contraseña debe suministrarse mediante el mecanismo seguro de PostgreSQL
(`pgpass`) o su solicitud interactiva; nunca se escribe en el repositorio.

## Situación actual

En el workspace no existe un dump ni DDL PostgreSQL. Sólo está el respaldo
SQL Server `CMI_Backup_QA.bak`, fuera de este repositorio. No se incluye porque
pesa aproximadamente 199 MB y puede contener información sensible.

Cuando se genere `schema.sql`, debe revisarse para confirmar que contiene los
reemplazos de los procedimientos `spRRHH_*` antes de integrarlo a `main`.
