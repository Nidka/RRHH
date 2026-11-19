-- TEC-002. Solo lectura. No imprime valores personales ni credenciales.
-- Ejecutar con psql -X -v ON_ERROR_STOP=1 -f BD/tests/diagnostico_integridad.sql
BEGIN TRANSACTION ISOLATION LEVEL REPEATABLE READ READ ONLY;
SET LOCAL statement_timeout = '2min';
SET LOCAL lock_timeout = '5s';

DO $diagnostico$
DECLARE
    t record;
    filas bigint;
    ids bigint;
    nulos bigint;
    repetidos bigint;
    conflictivos bigint;
BEGIN
    FOR t IN SELECT * FROM (VALUES
        ('Usuario', 'IdUsuario'), ('Motivo_Perm', 'idMotivo'),
        ('TipoPermiso', 'idTipoPermiso'), ('Horario', 'idHorario'),
        ('RRHH_Feriado', 'idFeriado')) v(tabla, columna)
    LOOP
        IF to_regclass(format('public.%I', t.tabla)) IS NULL THEN
            RAISE NOTICE 'Tabla % ausente', t.tabla;
            CONTINUE;
        END IF;
        EXECUTE format('SELECT count(*), count(DISTINCT %I), count(*) FILTER (WHERE %I IS NULL)
            FROM public.%I', t.columna, t.columna, t.tabla) INTO filas, ids, nulos;
        EXECUTE format('SELECT count(*), count(*) FILTER (WHERE variantes > 1)
            FROM (SELECT %I, count(DISTINCT to_jsonb(r)) variantes FROM public.%I r
            GROUP BY %I HAVING count(*) > 1) g', t.columna, t.tabla, t.columna)
            INTO repetidos, conflictivos;
        RAISE NOTICE 'Tabla % filas % IDs distintos % IDs nulos % grupos repetidos % grupos con contenido distinto %',
            t.tabla, filas, ids, nulos, repetidos, conflictivos;
    END LOOP;
END
$diagnostico$;

SELECT c.table_name, c.column_name, c.data_type, c.is_nullable, c.is_identity
FROM information_schema.columns c
WHERE c.table_schema = 'public' AND (
    c.table_name IN ('Usuario', 'Motivo_Perm', 'TipoPermiso', 'Horario', 'RRHH_Feriado')
    OR lower(c.column_name) IN ('idusuario', 'idmotivo', 'idmotivo_ant', 'idmotivo_act'))
ORDER BY c.table_name, c.ordinal_position;

SELECT conrelid::regclass AS tabla, conname AS restriccion, contype AS tipo,
    pg_get_constraintdef(oid) AS definicion
FROM pg_constraint
WHERE conrelid IN (to_regclass('public."Usuario"'), to_regclass('public."Motivo_Perm"'),
    to_regclass('public."TipoPermiso"'), to_regclass('public."Horario"'), to_regclass('public."RRHH_Feriado"'))
   OR confrelid IN (to_regclass('public."Usuario"'), to_regclass('public."Motivo_Perm"'),
    to_regclass('public."TipoPermiso"'), to_regclass('public."Horario"'), to_regclass('public."RRHH_Feriado"'))
ORDER BY conrelid::regclass::text, conname;

SELECT tgrelid::regclass AS tabla, tgname AS trigger
FROM pg_trigger WHERE NOT tgisinternal AND tgrelid IN (
    to_regclass('public."Usuario"'), to_regclass('public."Motivo_Perm"'),
    to_regclass('public."TipoPermiso"'), to_regclass('public."Horario"'), to_regclass('public."RRHH_Feriado"'));

SELECT c.relname AS tabla, c.relkind AS tipo, c.relrowsecurity AS seguridad_por_fila,
    c.relforcerowsecurity AS seguridad_por_fila_forzada
FROM pg_class c JOIN pg_namespace n ON n.oid = c.relnamespace
WHERE n.nspname = 'public' AND c.relname IN ('Usuario', 'Motivo_Perm', 'TipoPermiso', 'Horario', 'RRHH_Feriado');

SELECT tablename AS tabla, indexname AS indice, indexdef AS definicion
FROM pg_indexes WHERE schemaname = 'public'
AND tablename IN ('Usuario', 'Motivo_Perm', 'TipoPermiso', 'Horario', 'RRHH_Feriado');
COMMIT;
