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
