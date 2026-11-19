-- CR-003 / CR-006. Propuesta del piloto; aplicar en destino revisado por Kadin.
-- No clasifica como rechazados los registros históricos no autorizados.
BEGIN;
LOCK TABLE public."Permiso" IN ACCESS EXCLUSIVE MODE;
ALTER TABLE public."Permiso" ADD COLUMN IF NOT EXISTS "EstadoSolicitud" varchar(10);
DO $preflight$
BEGIN
    IF NOT EXISTS (SELECT 1 FROM information_schema.columns
        WHERE table_schema='public' AND table_name='Permiso'
        AND column_name='Autorizado' AND data_type='boolean') THEN
        RAISE EXCEPTION 'Se requiere Permiso.Autorizado boolean antes de migrar estados';
    END IF;
    IF EXISTS (SELECT 1 FROM public."Permiso" WHERE "EstadoSolicitud" IS NOT NULL
        AND "EstadoSolicitud" NOT IN ('Solicitado','Aprobado','Rechazado','Anulado')) THEN
        RAISE EXCEPTION 'Existen estados desconocidos: revisar antes de migrar';
    END IF;
END $preflight$;
UPDATE public."Permiso" SET "EstadoSolicitud" =
    CASE WHEN "Autorizado" IS TRUE THEN 'Aprobado' ELSE 'Solicitado' END
WHERE "EstadoSolicitud" IS NULL;
UPDATE public."Permiso" SET "Autorizado" = ("EstadoSolicitud" = 'Aprobado')
WHERE "Autorizado" IS DISTINCT FROM ("EstadoSolicitud" = 'Aprobado');
ALTER TABLE public."Permiso" ALTER COLUMN "EstadoSolicitud" SET NOT NULL;
-- Sin DEFAULT: un INSERT heredado debe inferir el estado desde Autorizado.
CREATE OR REPLACE FUNCTION public.rrhh_permiso_sincronizar_estado()
RETURNS trigger LANGUAGE plpgsql AS $body$
BEGIN
    IF TG_OP = 'INSERT' THEN
        IF NEW."EstadoSolicitud" IS NULL THEN
            NEW."EstadoSolicitud" := CASE WHEN NEW."Autorizado" IS TRUE
                THEN 'Aprobado' ELSE 'Solicitado' END;
        END IF;
    ELSE
        IF NEW."EstadoSolicitud" IS NOT DISTINCT FROM OLD."EstadoSolicitud"
           AND NEW."Autorizado" IS DISTINCT FROM OLD."Autorizado" THEN
            NEW."EstadoSolicitud" := CASE WHEN NEW."Autorizado" IS TRUE
                THEN 'Aprobado' ELSE 'Solicitado' END;
        END IF;
    END IF;
    IF NEW."EstadoSolicitud" IS NULL OR NEW."EstadoSolicitud" NOT IN
        ('Solicitado','Aprobado','Rechazado','Anulado') THEN
        RAISE EXCEPTION 'Estado de permiso inválido' USING ERRCODE = '23514';
    END IF;
    NEW."Autorizado" := (NEW."EstadoSolicitud" = 'Aprobado');
    RETURN NEW;
END $body$;
DROP TRIGGER IF EXISTS rrhh_permiso_estado ON public."Permiso";
CREATE TRIGGER rrhh_permiso_estado BEFORE INSERT OR UPDATE ON public."Permiso"
FOR EACH ROW EXECUTE FUNCTION public.rrhh_permiso_sincronizar_estado();
COMMENT ON COLUMN public."Permiso"."EstadoSolicitud" IS
'Piloto RF-03/06: Solicitado y Aprobado ocupan fechas/cupo; Rechazado y Anulado no.';
COMMIT;
