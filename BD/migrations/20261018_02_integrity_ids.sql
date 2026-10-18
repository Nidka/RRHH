-- TEC-002 / CR-TEC-002: integridad e IDs de horarios, feriados y motivos.
-- PostgreSQL 14+.
--
-- Contrato:
--   * conserva todos los IDs y filas existentes;
--   * aborta ante nulos, duplicados, fechas de feriado repetidas o huérfanos;
--   * usa IDENTITY BY DEFAULT para admitir INSERT sin ID y cargas con ID explícito;
--   * alinea cada secuencia al máximo existente;
--   * no elimina, fusiona ni corrige datos automáticamente.

BEGIN;

SET LOCAL lock_timeout = '15s';
SET LOCAL statement_timeout = '5min';
SELECT pg_advisory_xact_lock(hashtext('RRHH:TEC-002:20261018_02'));

DO $preflight$
DECLARE
    target record;
    missing text[] := ARRAY[]::text[];
BEGIN
    FOR target IN
        SELECT * FROM (VALUES
            ('Horario', 'idHorario'),
            ('RRHH_Feriado', 'idFeriado'),
            ('Motivo_Perm', 'idMotivo'),
            ('TipoPermiso', 'idTipoPermiso')) AS v(tabla, columna)
    LOOP
        IF to_regclass(format('public.%I', target.tabla)) IS NULL THEN
            missing := array_append(missing, format('public.%I', target.tabla));
        ELSIF NOT EXISTS (
            SELECT 1
            FROM pg_attribute
            WHERE attrelid = to_regclass(format('public.%I', target.tabla))
              AND attname = target.columna
              AND NOT attisdropped) THEN
            missing := array_append(missing, format('public.%I.%I', target.tabla, target.columna));
        END IF;
    END LOOP;

    IF cardinality(missing) > 0 THEN
        RAISE EXCEPTION 'TEC-002: faltan tablas/columnas requeridas: %', array_to_string(missing, ', ');
    END IF;

    FOR target IN
        SELECT * FROM (VALUES
            ('Horario', 'idHorario'),
            ('RRHH_Feriado', 'idFeriado'),
            ('Motivo_Perm', 'idMotivo'),
            ('TipoPermiso', 'idTipoPermiso')) AS v(tabla, columna)
    LOOP
        IF NOT EXISTS (
            SELECT 1
            FROM pg_attribute
            WHERE attrelid = to_regclass(format('public.%I', target.tabla))
              AND attname = target.columna
              AND atttypid = 'integer'::regtype
              AND attnotnull
              AND NOT attisdropped) THEN
            RAISE EXCEPTION 'TEC-002: %.% debe ser integer NOT NULL', target.tabla, target.columna;
        END IF;
    END LOOP;

    IF EXISTS (SELECT 1 FROM public."Horario" GROUP BY "idHorario" HAVING COUNT(*) > 1) THEN
        RAISE EXCEPTION 'TEC-002: Horario.idHorario contiene duplicados; no se modificó el esquema' USING ERRCODE = '23505';
    END IF;
    IF EXISTS (SELECT 1 FROM public."RRHH_Feriado" GROUP BY "idFeriado" HAVING COUNT(*) > 1) THEN
        RAISE EXCEPTION 'TEC-002: RRHH_Feriado.idFeriado contiene duplicados; no se modificó el esquema' USING ERRCODE = '23505';
    END IF;
    IF EXISTS (SELECT 1 FROM public."Motivo_Perm" GROUP BY "idMotivo" HAVING COUNT(*) > 1) THEN
        RAISE EXCEPTION 'TEC-002: Motivo_Perm.idMotivo contiene duplicados; no se modificó el esquema' USING ERRCODE = '23505';
    END IF;
    IF EXISTS (SELECT 1 FROM public."TipoPermiso" GROUP BY "idTipoPermiso" HAVING COUNT(*) > 1) THEN
        RAISE EXCEPTION 'TEC-002: TipoPermiso.idTipoPermiso contiene duplicados; no se modificó el esquema' USING ERRCODE = '23505';
    END IF;
    IF EXISTS (
        SELECT 1 FROM public."RRHH_Feriado"
        WHERE "Fecha" IS NOT NULL
        GROUP BY "Fecha"::date HAVING COUNT(*) > 1) THEN
        RAISE EXCEPTION 'TEC-002: RRHH_Feriado contiene fechas calendario repetidas; no se modificó el esquema' USING ERRCODE = '23505';
    END IF;

    IF EXISTS (SELECT 1 FROM public."Asistencia" AS c WHERE c."idHorario" IS NOT NULL
               AND NOT EXISTS (SELECT 1 FROM public."Horario" AS p WHERE p."idHorario" = c."idHorario")) THEN
        RAISE EXCEPTION 'TEC-002: existen referencias huérfanas en Asistencia.idHorario' USING ERRCODE = '23503';
    END IF;
    IF EXISTS (SELECT 1 FROM public."Empleado" AS c WHERE c."idHorario" IS NOT NULL
               AND NOT EXISTS (SELECT 1 FROM public."Horario" AS p WHERE p."idHorario" = c."idHorario")) THEN
        RAISE EXCEPTION 'TEC-002: existen referencias huérfanas en Empleado.idHorario' USING ERRCODE = '23503';
    END IF;
    IF EXISTS (SELECT 1 FROM public."Marcacion" AS c WHERE c."idHorario" IS NOT NULL
               AND NOT EXISTS (SELECT 1 FROM public."Horario" AS p WHERE p."idHorario" = c."idHorario")) THEN
        RAISE EXCEPTION 'TEC-002: existen referencias huérfanas en Marcacion.idHorario' USING ERRCODE = '23503';
    END IF;
    IF EXISTS (SELECT 1 FROM public."HorarioTemporal" AS c WHERE c."HorarioAsignado" IS NOT NULL
               AND NOT EXISTS (SELECT 1 FROM public."Horario" AS p WHERE p."idHorario" = c."HorarioAsignado")) THEN
        RAISE EXCEPTION 'TEC-002: existen referencias huérfanas en HorarioTemporal.HorarioAsignado' USING ERRCODE = '23503';
    END IF;
    IF EXISTS (SELECT 1 FROM public."Motivo_Perm" AS c WHERE c."idTipoPermiso" IS NOT NULL
               AND NOT EXISTS (SELECT 1 FROM public."TipoPermiso" AS p WHERE p."idTipoPermiso" = c."idTipoPermiso")) THEN
        RAISE EXCEPTION 'TEC-002: existen referencias huérfanas en Motivo_Perm.idTipoPermiso' USING ERRCODE = '23503';
    END IF;
    IF EXISTS (SELECT 1 FROM public."Permiso" AS c WHERE c."idMotivo" IS NOT NULL
               AND NOT EXISTS (SELECT 1 FROM public."Motivo_Perm" AS p WHERE p."idMotivo" = c."idMotivo")) THEN
        RAISE EXCEPTION 'TEC-002: existen referencias huérfanas en Permiso.idMotivo' USING ERRCODE = '23503';
    END IF;
    IF EXISTS (SELECT 1 FROM public."Permiso_Aud" AS c WHERE c."idMotivo_Ant" IS NOT NULL
               AND NOT EXISTS (SELECT 1 FROM public."Motivo_Perm" AS p WHERE p."idMotivo" = c."idMotivo_Ant")) THEN
        RAISE EXCEPTION 'TEC-002: existen referencias huérfanas en Permiso_Aud.idMotivo_Ant' USING ERRCODE = '23503';
    END IF;
    IF EXISTS (SELECT 1 FROM public."Permiso_Aud" AS c WHERE c."idMotivo_Act" IS NOT NULL
               AND NOT EXISTS (SELECT 1 FROM public."Motivo_Perm" AS p WHERE p."idMotivo" = c."idMotivo_Act")) THEN
        RAISE EXCEPTION 'TEC-002: existen referencias huérfanas en Permiso_Aud.idMotivo_Act' USING ERRCODE = '23503';
    END IF;
END
$preflight$;

DO $primary_keys$
DECLARE
    target record;
BEGIN
    FOR target IN
        SELECT * FROM (VALUES
            ('Horario', 'idHorario', 'PK_Horario'),
            ('RRHH_Feriado', 'idFeriado', 'PK_RRHH_Feriado'),
            ('Motivo_Perm', 'idMotivo', 'PK_Motivo_Perm'),
            ('TipoPermiso', 'idTipoPermiso', 'PK_TipoPermiso')) AS v(tabla, columna, restriccion)
    LOOP
        IF EXISTS (
            SELECT 1 FROM pg_constraint
            WHERE conrelid = to_regclass(format('public.%I', target.tabla))
              AND contype = 'p'
              AND NOT (
                  array_length(conkey, 1) = 1
                  AND conkey[1] = (
                      SELECT attnum FROM pg_attribute
                      WHERE attrelid = to_regclass(format('public.%I', target.tabla))
                        AND attname = target.columna))) THEN
            RAISE EXCEPTION 'TEC-002: %.% ya tiene una PK incompatible', target.tabla, target.columna;
        END IF;

        IF NOT EXISTS (
            SELECT 1 FROM pg_constraint
            WHERE conrelid = to_regclass(format('public.%I', target.tabla))
              AND contype = 'p') THEN
            EXECUTE format('ALTER TABLE public.%I ADD CONSTRAINT %I PRIMARY KEY (%I)',
                           target.tabla, target.restriccion, target.columna);
        END IF;
    END LOOP;
END
$primary_keys$;

DO $identities$
DECLARE
    target record;
    identity_kind "char";
    default_expression text;
    sequence_name text;
    max_id bigint;
BEGIN
    FOR target IN
        SELECT * FROM (VALUES
            ('Horario', 'idHorario'),
            ('RRHH_Feriado', 'idFeriado'),
            ('Motivo_Perm', 'idMotivo'),
            ('TipoPermiso', 'idTipoPermiso')) AS v(tabla, columna)
    LOOP
        SELECT a.attidentity, pg_get_expr(d.adbin, d.adrelid)
        INTO identity_kind, default_expression
        FROM pg_attribute AS a
        LEFT JOIN pg_attrdef AS d ON d.adrelid = a.attrelid AND d.adnum = a.attnum
        WHERE a.attrelid = to_regclass(format('public.%I', target.tabla))
          AND a.attname = target.columna
          AND NOT a.attisdropped;

        IF identity_kind = '' AND default_expression IS NULL THEN
            EXECUTE format('ALTER TABLE public.%I ALTER COLUMN %I ADD GENERATED BY DEFAULT AS IDENTITY',
                           target.tabla, target.columna);
        ELSIF identity_kind = 'a' THEN
            EXECUTE format('ALTER TABLE public.%I ALTER COLUMN %I SET GENERATED BY DEFAULT',
                           target.tabla, target.columna);
        ELSIF identity_kind = '' THEN
            RAISE EXCEPTION 'TEC-002: %.% ya tiene un default no administrado (%); revisar antes de migrar',
                            target.tabla, target.columna, default_expression;
        END IF;

        sequence_name := pg_get_serial_sequence(format('public.%I', target.tabla), target.columna);
        IF sequence_name IS NULL THEN
            RAISE EXCEPTION 'TEC-002: no se encontró la secuencia de identidad para %.%', target.tabla, target.columna;
        END IF;

        EXECUTE format('SELECT max(%I)::bigint FROM public.%I', target.columna, target.tabla) INTO max_id;
        IF max_id >= 2147483647 THEN
            RAISE EXCEPTION 'TEC-002: %.% agotó el rango integer', target.tabla, target.columna;
        END IF;
        PERFORM setval(sequence_name::regclass, COALESCE(max_id, 1), max_id IS NOT NULL);
    END LOOP;
END
$identities$;

CREATE UNIQUE INDEX IF NOT EXISTS "UX_RRHH_Feriado_Fecha"
    ON public."RRHH_Feriado" (("Fecha"::date))
    WHERE "Fecha" IS NOT NULL;

DO $foreign_keys$
BEGIN
    IF NOT EXISTS (SELECT 1 FROM pg_constraint WHERE conrelid = 'public."Asistencia"'::regclass AND conname = 'FK_Asistencia_Horario') THEN
        ALTER TABLE public."Asistencia" ADD CONSTRAINT "FK_Asistencia_Horario"
            FOREIGN KEY ("idHorario") REFERENCES public."Horario" ("idHorario") NOT VALID;
    END IF;
    IF NOT EXISTS (SELECT 1 FROM pg_constraint WHERE conrelid = 'public."Empleado"'::regclass AND conname = 'FK_Empleado_Horario') THEN
        ALTER TABLE public."Empleado" ADD CONSTRAINT "FK_Empleado_Horario"
            FOREIGN KEY ("idHorario") REFERENCES public."Horario" ("idHorario") NOT VALID;
    END IF;
    IF NOT EXISTS (SELECT 1 FROM pg_constraint WHERE conrelid = 'public."Marcacion"'::regclass AND conname = 'FK_Marcacion_Horario') THEN
        ALTER TABLE public."Marcacion" ADD CONSTRAINT "FK_Marcacion_Horario"
            FOREIGN KEY ("idHorario") REFERENCES public."Horario" ("idHorario") NOT VALID;
    END IF;
    IF NOT EXISTS (SELECT 1 FROM pg_constraint WHERE conrelid = 'public."HorarioTemporal"'::regclass AND conname = 'FK_HorarioTemporal_Horario') THEN
        ALTER TABLE public."HorarioTemporal" ADD CONSTRAINT "FK_HorarioTemporal_Horario"
            FOREIGN KEY ("HorarioAsignado") REFERENCES public."Horario" ("idHorario") NOT VALID;
    END IF;
    IF NOT EXISTS (SELECT 1 FROM pg_constraint WHERE conrelid = 'public."Motivo_Perm"'::regclass AND conname = 'FK_MotivoPerm_TipoPermiso') THEN
        ALTER TABLE public."Motivo_Perm" ADD CONSTRAINT "FK_MotivoPerm_TipoPermiso"
            FOREIGN KEY ("idTipoPermiso") REFERENCES public."TipoPermiso" ("idTipoPermiso") NOT VALID;
    END IF;
    IF NOT EXISTS (SELECT 1 FROM pg_constraint WHERE conrelid = 'public."Permiso"'::regclass AND conname = 'FK_Permiso_MotivoPerm') THEN
        ALTER TABLE public."Permiso" ADD CONSTRAINT "FK_Permiso_MotivoPerm"
            FOREIGN KEY ("idMotivo") REFERENCES public."Motivo_Perm" ("idMotivo") NOT VALID;
    END IF;
    IF NOT EXISTS (SELECT 1 FROM pg_constraint WHERE conrelid = 'public."Permiso_Aud"'::regclass AND conname = 'FK_PermisoAud_MotivoAnt') THEN
        ALTER TABLE public."Permiso_Aud" ADD CONSTRAINT "FK_PermisoAud_MotivoAnt"
            FOREIGN KEY ("idMotivo_Ant") REFERENCES public."Motivo_Perm" ("idMotivo") NOT VALID;
    END IF;
    IF NOT EXISTS (SELECT 1 FROM pg_constraint WHERE conrelid = 'public."Permiso_Aud"'::regclass AND conname = 'FK_PermisoAud_MotivoAct') THEN
        ALTER TABLE public."Permiso_Aud" ADD CONSTRAINT "FK_PermisoAud_MotivoAct"
            FOREIGN KEY ("idMotivo_Act") REFERENCES public."Motivo_Perm" ("idMotivo") NOT VALID;
    END IF;
END
$foreign_keys$;

ALTER TABLE public."Asistencia" VALIDATE CONSTRAINT "FK_Asistencia_Horario";
ALTER TABLE public."Empleado" VALIDATE CONSTRAINT "FK_Empleado_Horario";
ALTER TABLE public."Marcacion" VALIDATE CONSTRAINT "FK_Marcacion_Horario";
ALTER TABLE public."HorarioTemporal" VALIDATE CONSTRAINT "FK_HorarioTemporal_Horario";
ALTER TABLE public."Motivo_Perm" VALIDATE CONSTRAINT "FK_MotivoPerm_TipoPermiso";
ALTER TABLE public."Permiso" VALIDATE CONSTRAINT "FK_Permiso_MotivoPerm";
ALTER TABLE public."Permiso_Aud" VALIDATE CONSTRAINT "FK_PermisoAud_MotivoAnt";
ALTER TABLE public."Permiso_Aud" VALIDATE CONSTRAINT "FK_PermisoAud_MotivoAct";

COMMIT;
