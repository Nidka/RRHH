# Pruebas SQL de TEC-002

Estas pruebas usan únicamente datos ficticios y deben ejecutarse en una base
local desechable. Nunca apunte estos comandos a `.env` ni a la instancia
compartida, porque el fixture elimina tablas del esquema `public`.

## Camino válido

```powershell
$env:PGDATABASE = 'rrhh_tec002_tests'
psql -X -v ON_ERROR_STOP=1 -f BD/tests/tec002_fixture.sql
psql -X -v ON_ERROR_STOP=1 -f BD/migrations/20261018_02_integrity_ids.sql
psql -X -v ON_ERROR_STOP=1 -f BD/tests/tec002_assertions.sql
psql -X -v ON_ERROR_STOP=1 -f BD/migrations/20261018_02_integrity_ids.sql
```

La última repetición debe completar sin cambios ni colisiones. Para probar
reversión estructural, aplique `20261018_02_integrity_ids.rollback.sql` y
compruebe que las filas ficticias siguen presentes; la reversión no borra datos.

## Precondiciones abortivas

Después de recargar el fixture, agregue una copia exacta y espere SQLSTATE
`23505`, sin PK ni identidad creada:

```sql
INSERT INTO public."Motivo_Perm"
SELECT * FROM public."Motivo_Perm" WHERE "idMotivo" = 10;
```

Para comprobar huérfanos, recargue el fixture, inserte
`INSERT INTO public."Permiso" VALUES (999999);` y espere SQLSTATE `23503`.
En ambos casos `psql` debe terminar con error y la transacción debe revertirse.

## Concurrencia

Tras aplicar la migración, abra dos sesiones y ejecute al mismo tiempo inserts
sin ID. Cada una debe recibir un ID diferente por `RETURNING`:

```sql
INSERT INTO public."Motivo_Perm" ("Descrip_Motivo", "idTipoPermiso")
VALUES ('CONCURRENCIA FICTICIA', 3)
RETURNING "idMotivo";
```

Use descripciones distintas si necesita identificar la sesión y elimine la BD
desechable completa al terminar.

## RF-06: marca `UnaVezPorAnio`

Misma regla: BD local desechable, nunca `.env` ni la instancia compartida. La
migración parte del fixture de TEC-002 y de su migración 02, que da identidad a
`"idMotivo"` y usan las aserciones.

```powershell
$env:PGDATABASE = 'rrhh_rf06_tests'
psql -X -v ON_ERROR_STOP=1 -f BD/tests/tec002_fixture.sql
psql -X -v ON_ERROR_STOP=1 -f BD/migrations/20261018_02_integrity_ids.sql
psql -X -v ON_ERROR_STOP=1 -f BD/migrations/20261111_01_licencia_una_vez_anio.sql
psql -X -v ON_ERROR_STOP=1 -f BD/tests/rf06_assertions.sql
psql -X -v ON_ERROR_STOP=1 -f BD/migrations/20261111_01_licencia_una_vez_anio.sql
```

La repetición final debe completar sin cambios. Para revertir, aplique
`20261111_01_licencia_una_vez_anio.rollback.sql`: elimina solo la columna y las
filas ficticias siguen presentes. Si la columna existe con un tipo distinto de
`boolean`, la migración debe abortar.

La migración no activa la marca en ningún motivo. Activarla para la licencia 30012
es un paso aparte, con el `"idMotivo"` confirmado en la base real.

`BD/schema.sql` no se regenera con esta migración: es la línea base del volcado
inicial y tampoco refleja la migración 02. El esquema vigente es esa línea base
más las migraciones de `BD/migrations/`, en orden.
