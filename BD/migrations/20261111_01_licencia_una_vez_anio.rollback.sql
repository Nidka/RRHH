-- Reversión estructural de RF-06 (20261111_01_licencia_una_vez_anio.sql).
-- Elimina la columna "UnaVezPorAnio" y, con ella, las marcas que se hubieran activado.
-- No toca ninguna otra columna ni fila de public."Motivo_Perm". Para conservar las
-- marcas antes de revertir, respáldelas con:
--   SELECT "idMotivo" FROM public."Motivo_Perm" WHERE "UnaVezPorAnio";

BEGIN;

SET LOCAL lock_timeout = '15s';

ALTER TABLE IF EXISTS public."Motivo_Perm" DROP COLUMN IF EXISTS "UnaVezPorAnio";

COMMIT;
