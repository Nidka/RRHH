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

## TEC-002: integridad de horarios, feriados y motivos

El perfilador reproducible está en `diagnostics/tec002_profile.sql`. Solo
muestra metadatos y conteos; aun así debe ejecutarse con acceso autorizado:

```powershell
psql $env:RRHH_POSTGRES_CONNECTION -X -v ON_ERROR_STOP=1 `
  -f .\BD\diagnostics\tec002_profile.sql
```

La migración `20261018_02_integrity_ids.sql` agrega PK, identidades
`BY DEFAULT`, FK validadas y unicidad por fecha de feriado. No limpia datos:
si hay duplicados o huérfanos, toda la transacción aborta.

### Runbook sin secretos

1. Confirmar por escrito destino, ventana, responsable, revisor y autorización
   de escritura. La cuenta de aplicación y la administrativa deben ser
   distintas; no usar normalmente el rol propietario desde WinForms.
2. Registrar commit, versión PostgreSQL y resultado del perfilador. Confirmar
   que los datos sean ficticios/anonimizados y que el usuario RRHH de prueba
   tenga hash, rol y empleado válidos, sin publicar su contraseña.
3. Crear un respaldo privado antes del cambio:

   ```powershell
   pg_dump $env:RRHH_POSTGRES_CONNECTION --format=custom `
     --no-owner --no-privileges --file <ruta-privada-pre-TEC002.dump>
   ```

4. Restaurar el respaldo en una BD QA nueva y aislada. Ejecutar allí el
   perfilador. Si aparecen duplicados, conservar una tabla/copia de respaldo,
   comparar cada variante y obtener aprobación antes de corregirlos. No usar
   una sentencia genérica de deduplicación sobre la instancia compartida.
5. Cuando todos los conteos de duplicados, nulos y huérfanos sean cero, aplicar:

   ```powershell
   psql $env:RRHH_POSTGRES_CONNECTION -X -v ON_ERROR_STOP=1 `
     -f .\BD\migrations\20261018_02_integrity_ids.sql
   ```

6. Repetir el perfilador y las pruebas de `BD/tests/README.md`. Después ejecutar
   `check-postgresql.cmd`, la suite .NET y los recorridos WinForms de horarios,
   feriados y motivos con registros ficticios.
7. Exportar `schema.sql` únicamente desde la QA saneada y revisada. Guardar la
   evidencia sin filas, cadenas de conexión, capturas personales ni secretos.

### Recuperación

Ante un fallo antes de `COMMIT`, PostgreSQL revierte la migración completa. Si
se requiere retirar solo su estructura antes de recibir nuevas escrituras, use
`20261018_02_integrity_ids.rollback.sql`; conserva todas las filas.

Después de habilitar escrituras, la recuperación segura es restaurar el dump
previo en otra BD, validar conteos y cambiar la configuración durante una
ventana controlada. La reversión SQL no elimina filas nuevas ni reconstruye el
estado anterior. Ensaye `pg_restore --clean --if-exists --no-owner
--no-privileges` solo sobre una BD desechable, nunca sobre el único destino.
