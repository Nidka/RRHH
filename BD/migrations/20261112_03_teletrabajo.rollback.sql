-- Reversión estructural de RF-13 (20261112_03_teletrabajo.sql).
-- ELIMINA la tabla public."Teletrabajo" completa, con su índice y sus restricciones.
-- Por eso se niega a continuar si la tabla tiene filas: un rollback que borra datos de
-- producción no debe ser accidental. Para revertir con datos, respáldelos primero:
--   \copy (SELECT * FROM public."Teletrabajo") TO 'teletrabajo_respaldo.csv' CSV HEADER
-- y vacíe la tabla de forma deliberada (DELETE) antes de repetir este script.

BEGIN;

SET LOCAL lock_timeout = '15s';

DO $verificacion$
DECLARE
    filas bigint;
BEGIN
    IF to_regclass('public."Teletrabajo"') IS NOT NULL THEN
        EXECUTE 'SELECT count(*) FROM public."Teletrabajo"' INTO filas;
        IF filas > 0 THEN
            RAISE EXCEPTION 'RF-13: public."Teletrabajo" tiene % fila(s); respalde y vacíe la tabla antes de revertir', filas;
        END IF;
    END IF;
END
$verificacion$;

DROP TABLE IF EXISTS public."Teletrabajo";

COMMIT;
