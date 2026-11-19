# Pruebas SQL de TEC-002

## Diagnóstico de duplicados y ensayo de saneamiento

`diagnostico_integridad.sql` ejecuta una transacción de solo lectura y reporta cantidades y estructura. Omite valores personales, logins y credenciales. Kadin puede usarlo para aportar el diagnóstico anonimizado del destino. La ausencia de FK declaradas no acredita ausencia de dependencias lógicas.

Para el ensayo local con PostgreSQL 18 y PowerShell 7:

```powershell
pwsh -NoProfile -File BD/tests/Invoke-IntegridadQa.ps1 -PostgreSqlBin 'C:\Program Files\PostgreSQL\18\bin'
```

El ejecutor crea un clúster temporal dedicado y usa únicamente datos ficticios. `sanear_copias_exactas_qa.sql` solo admite loopback y la base `rrhh_integridad_qa`. Respalda las filas en un esquema restringido dentro de esa misma base antes de retirar copias exactas, conserva IDs y añade la clave de Usuario. Después se aplican las migraciones existentes de TEC-002 y RF-06. Se prueban referencias, repetición, variantes de contenido, IDs nulos y huérfanos.

El saneamiento y las migraciones son transacciones separadas. Un fallo de migración conserva el estado saneado y el respaldo del ensayo. La base temporal se detiene al terminar. Estos archivos preparan la revisión del grupo y no constituyen un despliegue en la base compartida. Antes de ese despliegue Kadin debe contrastar las referencias reales y preparar respaldo y restauración del destino.

Resultado del 19/11/2026 en PostgreSQL 18 local. El ejecutor aprobó conservación de IDs y referencias, cinco PK y nueve FK, repetición, migración RF-06, backup con pg_dump y restore en una segunda base ficticia. Los cuatro rechazos deliberados aparecen como ERROR en la salida de psql y el ejecutor comprueba después que no hubo cambios.

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

La migración `20261119_01_grupo_licencia_anual.sql` agrega `GrupoReglaAnual` después de TEC-002 y de la marca anual. Una clave común permite validar códigos distintos como una misma restricción. La migración no decide qué motivos reales se agrupan. El ejecutor `Invoke-IntegridadQa.ps1` crea los motivos ficticios 900 y 901 bajo `PILOTO-FAMILIAR` y 902 bajo otra clave, prueba las restricciones, repetición y rollback. Las pruebas C# del repositorio verifican la detección cruzada entre 900 y 901.

Antes de configurar motivos reales, Kadin debe confirmar los IDs únicos y la regla del grupo. La validación anual sigue separada de la escritura heredada, por lo que la concurrencia requiere la migración transaccional del flujo RF-03.

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

## RF-18: consulta de ausencias por periodo

Base local desechable y **vacía** (no usa el fixture de TEC-002): el script crea sus
propias tablas ficticias y aborta si ya existe `public."Permiso"` o `public."Empleado"`.

```powershell
createdb rrhh_rf18_tests
$env:PGDATABASE = 'rrhh_rf18_tests'
psql -X -v ON_ERROR_STOP=1 -f BD/tests/rf18_ausencias.sql
```

Debe terminar con «RF-18: aserciones SQL correctas». Reproduce la consulta de
`PostgreSqlAusenciasRepository.ListarSolapadas` (permisos que empiezan antes, terminan
después, contienen el periodo o están dentro; excluye los contiguos sin día en común).
Elimine la base desechable al terminar.

## RF-13: tabla `Teletrabajo`

Base local desechable; la migración no depende de otras tablas, basta una base vacía.

```powershell
createdb rrhh_rf13_tests
$env:PGDATABASE = 'rrhh_rf13_tests'
psql -X -v ON_ERROR_STOP=1 -f BD/migrations/20261112_03_teletrabajo.sql
psql -X -v ON_ERROR_STOP=1 -f BD/tests/rf13_assertions.sql
psql -X -v ON_ERROR_STOP=1 -f BD/migrations/20261112_03_teletrabajo.sql
```

La repetición final debe completar sin cambios (ni segundo índice). Las aserciones dejan la
tabla vacía. `20261112_03_teletrabajo.rollback.sql` **elimina la tabla**, por eso se niega
(SQLSTATE `P0001`) si tiene filas: respalde y vacíe antes de revertir. Si la tabla ya existe sin
alguna columna del contrato, la migración aborta sin modificar nada. Las aserciones comprueban cada
restricción (rango invertido, modalidad, máscara de días remotos, empleado nulo) con el mismo
`INSERT` que usa `PostgreSqlTeletrabajoRepository`.

## RF-13: alta concurrente (CP-13-09)

`BD/tests/rf13_concurrencia_sesion.sql` reproduce en SQL la secuencia de bloqueo y comprobación del
repositorio. En una BD desechable con la tabla `Teletrabajo` y una tabla `Empleado` mínima (empleado 101),
ejecútelo en dos sesiones con un segundo de diferencia (instrucciones en la cabecera del script). Resultado
verificado el 12/11/2026 en PostgreSQL 16: la sesión A queda confirmada, la B rechazada y la tabla termina
con una fila.
