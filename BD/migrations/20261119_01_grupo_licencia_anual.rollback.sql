-- Retira la agrupación. Conservar previamente la configuración de grupos del destino.
BEGIN;
SET LOCAL lock_timeout = '15s';
SELECT pg_advisory_xact_lock(hashtext('RRHH:RF-06:20261119_01'));
ALTER TABLE public."Motivo_Perm" DROP CONSTRAINT IF EXISTS "CK_Motivo_GrupoReglaAnual";
ALTER TABLE public."Motivo_Perm" DROP COLUMN IF EXISTS "GrupoReglaAnual";
COMMIT;
