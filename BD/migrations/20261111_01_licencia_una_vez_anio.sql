-- RF-06 / CR-006: marca de los motivos de permiso que solo se otorgan una vez al año.
-- PostgreSQL 14+.
--
-- Contrato:
--   * agrega public."Motivo_Perm"."UnaVezPorAnio" boolean NOT NULL DEFAULT false;
--   * no modifica filas existentes y no marca ningún motivo (todos quedan en false);
--   * es idempotente: repetirla no cambia nada;
--   * aborta si falta la tabla o si "UnaVezPorAnio" ya existe con otro tipo;
--   * no agrega índices ni claves.
--
-- Datos: esta migración no activa la marca en ningún motivo. Tras confirmar en la
-- base real qué fila es la licencia 30012 (hipótesis: "idMotivo" = 30012), se
-- activa por separado, con alcance explícito:
--   UPDATE public."Motivo_Perm" SET "UnaVezPorAnio" = true WHERE "idMotivo" = <id confirmado>;

BEGIN;

SET LOCAL lock_timeout = '15s';
SET LOCAL statement_timeout = '1min';
SELECT pg_advisory_xact_lock(hashtext('RRHH:RF-06:20261111_01'));

DO $preflight$
DECLARE
    tipo_actual text;
BEGIN
    IF to_regclass('public."Motivo_Perm"') IS NULL THEN
        RAISE EXCEPTION 'RF-06: falta la tabla public."Motivo_Perm"';
    END IF;

    SELECT format_type(a.atttypid, a.atttypmod)
    INTO tipo_actual
    FROM pg_attribute AS a
    WHERE a.attrelid = 'public."Motivo_Perm"'::regclass
      AND a.attname = 'UnaVezPorAnio'
      AND NOT a.attisdropped;

    IF tipo_actual IS NOT NULL AND tipo_actual <> 'boolean' THEN
        RAISE EXCEPTION 'RF-06: "UnaVezPorAnio" ya existe con tipo %, se esperaba boolean', tipo_actual;
    END IF;
END
$preflight$;

ALTER TABLE public."Motivo_Perm"
    ADD COLUMN IF NOT EXISTS "UnaVezPorAnio" boolean NOT NULL DEFAULT false;

COMMENT ON COLUMN public."Motivo_Perm"."UnaVezPorAnio" IS
    'RF-06: true si el motivo (p. ej. licencia 30012) solo puede otorgarse una vez por persona y año.';

COMMIT;
