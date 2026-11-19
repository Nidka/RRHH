-- RF-06. Clave común opcional para motivos de una misma restricción anual.
-- Requiere integridad TEC-002 y migración de UnaVezPorAnio.
-- No activa ni agrupa motivos existentes.
BEGIN;
SET LOCAL lock_timeout = '15s';
SET LOCAL statement_timeout = '1min';
SELECT pg_advisory_xact_lock(hashtext('RRHH:RF-06:20261119_01'));
LOCK TABLE public."Motivo_Perm" IN SHARE ROW EXCLUSIVE MODE;

DO $preflight$
DECLARE atributo smallint;
BEGIN
    IF NOT EXISTS (SELECT 1 FROM information_schema.columns WHERE table_schema = 'public'
        AND table_name = 'Motivo_Perm' AND column_name = 'UnaVezPorAnio' AND data_type = 'boolean') THEN
        RAISE EXCEPTION 'RF-06: aplicar primero 20261111_01_licencia_una_vez_anio.sql';
    END IF;
    SELECT attnum INTO atributo FROM pg_attribute
        WHERE attrelid = 'public."Motivo_Perm"'::regclass AND attname = 'idMotivo';
    IF NOT EXISTS (SELECT 1 FROM pg_constraint WHERE conrelid = 'public."Motivo_Perm"'::regclass
        AND contype = 'p' AND conkey = ARRAY[atributo]) THEN
        RAISE EXCEPTION 'RF-06: se requiere la PK de idMotivo; revisar TEC-002 antes de agrupar motivos';
    END IF;
    IF EXISTS (SELECT 1 FROM information_schema.columns WHERE table_schema = 'public'
        AND table_name = 'Motivo_Perm' AND column_name = 'GrupoReglaAnual'
        AND (data_type <> 'character varying' OR character_maximum_length IS DISTINCT FROM 64)) THEN
        RAISE EXCEPTION 'RF-06: GrupoReglaAnual existe con un tipo incompatible';
    END IF;
END
$preflight$;

ALTER TABLE public."Motivo_Perm" ADD COLUMN IF NOT EXISTS "GrupoReglaAnual" varchar(64);
DO $constraint$
BEGIN
    IF NOT EXISTS (SELECT 1 FROM pg_constraint WHERE conrelid = 'public."Motivo_Perm"'::regclass
        AND conname = 'CK_Motivo_GrupoReglaAnual') THEN
        ALTER TABLE public."Motivo_Perm" ADD CONSTRAINT "CK_Motivo_GrupoReglaAnual"
        CHECK ("GrupoReglaAnual" IS NULL OR
            (COALESCE("UnaVezPorAnio", false) AND length(btrim("GrupoReglaAnual")) > 0
             AND "GrupoReglaAnual" = btrim("GrupoReglaAnual")));
    END IF;
END
$constraint$;
COMMENT ON COLUMN public."Motivo_Perm"."GrupoReglaAnual" IS
    'RF-06: motivos marcados con la misma clave comparten restricción anual; NULL conserva restricción por idMotivo.';
COMMIT;
