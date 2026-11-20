BEGIN;
LOCK TABLE public."Permiso", public."Motivo_Perm" IN ACCESS EXCLUSIVE MODE;
DO $check$ BEGIN
IF EXISTS (SELECT 1 FROM public."Permiso" WHERE "MediaJornadaVacaciones") THEN
 RAISE EXCEPTION 'Rollback bloqueado: existen medias jornadas; exportar y resolver sus consumos antes de retirar la columna';
END IF;
IF EXISTS (SELECT 1 FROM public."Motivo_Perm" WHERE "EsVacacionesPiloto") THEN
 RAISE EXCEPTION 'Rollback bloqueado: conservar configuración de motivos de vacaciones antes de retirar su marca';
END IF;
END $check$;
ALTER TABLE public."Permiso" DROP COLUMN "MediaJornadaVacaciones";
ALTER TABLE public."Motivo_Perm" DROP COLUMN "EsVacacionesPiloto";
COMMIT;
