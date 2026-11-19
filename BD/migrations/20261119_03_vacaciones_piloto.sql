-- RF-08/RF-10. Sin activación de motivos reales. Revisar destino con Kadin.
BEGIN;
SET LOCAL lock_timeout='15s';
LOCK TABLE public."Permiso", public."Motivo_Perm" IN SHARE ROW EXCLUSIVE MODE;
ALTER TABLE public."Motivo_Perm" ADD COLUMN IF NOT EXISTS "EsVacacionesPiloto" boolean NOT NULL DEFAULT false;
ALTER TABLE public."Permiso" ADD COLUMN IF NOT EXISTS "MediaJornadaVacaciones" boolean NOT NULL DEFAULT false;
COMMENT ON COLUMN public."Motivo_Perm"."EsVacacionesPiloto" IS 'Marca explícita del régimen académico; no identifica legislación oficial.';
COMMENT ON COLUMN public."Permiso"."MediaJornadaVacaciones" IS 'Consumo académico de 0,5 día en una única fecha laborable.';
COMMIT;
