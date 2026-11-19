-- TEC-002. Ensayo exclusivo en PostgreSQL local y BD rrhh_integridad_qa.
-- Respalda las filas iniciales y conserva una copia por ID solo si son idénticas.
-- No usar este script para desplegar en la base compartida.
BEGIN;
SET LOCAL lock_timeout = '10s';
SET LOCAL statement_timeout = '2min';

DO $destino$
BEGIN
    IF current_database() <> 'rrhh_integridad_qa'
       OR inet_server_addr() IS NULL
       OR inet_server_addr() NOT IN ('127.0.0.1'::inet, '::1'::inet) THEN
        RAISE EXCEPTION 'TEC-002 QA: destino no autorizado para este ensayo';
    END IF;
END
$destino$;

LOCK TABLE public."Usuario", public."Usuario_Rol", public."Motivo_Perm",
    public."TipoPermiso", public."Horario", public."RRHH_Feriado" IN ACCESS EXCLUSIVE MODE;

DO $precondiciones$
DECLARE t record;
DECLARE invalido boolean;
BEGIN
    FOR t IN SELECT * FROM (VALUES
        ('Usuario', 'IdUsuario'), ('Motivo_Perm', 'idMotivo'),
        ('TipoPermiso', 'idTipoPermiso'), ('Horario', 'idHorario'),
        ('RRHH_Feriado', 'idFeriado')) v(tabla, columna)
    LOOP
        IF EXISTS (SELECT 1 FROM pg_trigger WHERE tgrelid = to_regclass(format('public.%I', t.tabla))
            AND NOT tgisinternal)
           OR EXISTS (SELECT 1 FROM pg_inherits WHERE
               inhparent = to_regclass(format('public.%I', t.tabla))
               OR inhrelid = to_regclass(format('public.%I', t.tabla))) THEN
            RAISE EXCEPTION 'TEC-002 QA: % requiere revisión de triggers o herencia', t.tabla;
        END IF;
        EXECUTE format('SELECT EXISTS(SELECT 1 FROM public.%I WHERE %I IS NULL)',
            t.tabla, t.columna) INTO invalido;
        IF invalido THEN RAISE EXCEPTION 'TEC-002 QA: % tiene IDs nulos', t.tabla; END IF;
        EXECUTE format('SELECT EXISTS(SELECT 1 FROM public.%I r GROUP BY %I
            HAVING count(DISTINCT to_jsonb(r)) > 1)', t.tabla, t.columna) INTO invalido;
        IF invalido THEN
            RAISE EXCEPTION 'TEC-002 QA: % tiene contenido distinto para el mismo ID; sin saneamiento', t.tabla;
        END IF;
    END LOOP;
    IF EXISTS (SELECT 1 FROM public."Usuario_Rol" r WHERE r."IdUsuario" IS NOT NULL
        AND NOT EXISTS (SELECT 1 FROM public."Usuario" u WHERE u."IdUsuario" = r."IdUsuario")) THEN
        RAISE EXCEPTION 'TEC-002 QA: Usuario_Rol tiene referencias huérfanas';
    END IF;
END
$precondiciones$;

CREATE SCHEMA IF NOT EXISTS rrhh_qa_respaldo;
REVOKE ALL ON SCHEMA rrhh_qa_respaldo FROM PUBLIC;

DO $consolidacion$
DECLARE t record;
DECLARE hay_duplicados boolean;
DECLARE borradas bigint;
BEGIN
    FOR t IN SELECT * FROM (VALUES
        ('Usuario', 'IdUsuario'), ('Motivo_Perm', 'idMotivo'),
        ('TipoPermiso', 'idTipoPermiso'), ('Horario', 'idHorario'),
        ('RRHH_Feriado', 'idFeriado')) v(tabla, columna)
    LOOP
        EXECUTE format('SELECT EXISTS(SELECT 1 FROM public.%I GROUP BY %I HAVING count(*) > 1)',
            t.tabla, t.columna) INTO hay_duplicados;
        IF NOT hay_duplicados THEN CONTINUE; END IF;
        IF to_regclass(format('rrhh_qa_respaldo.%I', t.tabla)) IS NOT NULL THEN
            RAISE EXCEPTION 'TEC-002 QA: ya existe respaldo de %; revisar antes de una nueva limpieza', t.tabla;
        END IF;
        EXECUTE format('CREATE TABLE rrhh_qa_respaldo.%I AS TABLE public.%I', t.tabla, t.tabla);
        EXECUTE format('REVOKE ALL ON rrhh_qa_respaldo.%I FROM PUBLIC', t.tabla);
        EXECUTE format('DELETE FROM public.%I a USING public.%I b
            WHERE a.%I = b.%I AND a.ctid > b.ctid', t.tabla, t.tabla, t.columna, t.columna);
        GET DIAGNOSTICS borradas = ROW_COUNT;
        RAISE NOTICE 'TEC-002 QA: % copias exactas retiradas %; IDs conservados', t.tabla, borradas;
    END LOOP;
END
$consolidacion$;

-- La migración de catálogos se aplica después en otra transacción por el ejecutor.
-- Aquí se prepara la clave de Usuario y se preserva su relación con Usuario_Rol.
DO $clave_usuario$
DECLARE atributo smallint;
BEGIN
    SELECT attnum INTO atributo FROM pg_attribute
        WHERE attrelid = 'public."Usuario"'::regclass AND attname = 'IdUsuario';
    IF EXISTS (SELECT 1 FROM pg_constraint WHERE conrelid = 'public."Usuario"'::regclass
        AND contype = 'p' AND conkey <> ARRAY[atributo]) THEN
        RAISE EXCEPTION 'TEC-002 QA: Usuario tiene una PK diferente; revisar contrato';
    END IF;
    IF NOT EXISTS (SELECT 1 FROM pg_constraint WHERE conrelid = 'public."Usuario"'::regclass AND contype = 'p') THEN
        ALTER TABLE public."Usuario" ADD CONSTRAINT "PK_Usuario_QA" PRIMARY KEY ("IdUsuario");
    END IF;
    IF NOT EXISTS (SELECT 1 FROM pg_constraint
        WHERE conrelid = 'public."Usuario_Rol"'::regclass AND conname = 'FK_UsuarioRol_Usuario_QA') THEN
        ALTER TABLE public."Usuario_Rol" ADD CONSTRAINT "FK_UsuarioRol_Usuario_QA"
            FOREIGN KEY ("IdUsuario") REFERENCES public."Usuario" ("IdUsuario");
    END IF;
END
$clave_usuario$;
COMMIT;
