BEGIN;
LOCK TABLE public."Permiso" IN ACCESS EXCLUSIVE MODE;
DO $check$
BEGIN
    IF EXISTS (SELECT 1 FROM public."Permiso"
        WHERE "EstadoSolicitud" IN ('Rechazado','Anulado')) THEN
        RAISE EXCEPTION 'Rollback bloqueado: Autorizado no representa rechazos/anulaciones. Exportar y resolver esos estados antes de retirar la columna.';
    END IF;
END $check$;
DROP TRIGGER IF EXISTS rrhh_permiso_estado ON public."Permiso";
DROP FUNCTION IF EXISTS public.rrhh_permiso_sincronizar_estado();
ALTER TABLE public."Permiso" DROP COLUMN IF EXISTS "EstadoSolicitud";
COMMIT;
