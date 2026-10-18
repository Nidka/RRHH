-- Reversión estructural de TEC-002.
-- No elimina filas creadas después de la migración ni restaura datos. Para una
-- recuperación completa se debe restaurar el respaldo previo en otro destino.

BEGIN;

ALTER TABLE IF EXISTS public."Permiso_Aud" DROP CONSTRAINT IF EXISTS "FK_PermisoAud_MotivoAct";
ALTER TABLE IF EXISTS public."Permiso_Aud" DROP CONSTRAINT IF EXISTS "FK_PermisoAud_MotivoAnt";
ALTER TABLE IF EXISTS public."Permiso" DROP CONSTRAINT IF EXISTS "FK_Permiso_MotivoPerm";
ALTER TABLE IF EXISTS public."Motivo_Perm" DROP CONSTRAINT IF EXISTS "FK_MotivoPerm_TipoPermiso";
ALTER TABLE IF EXISTS public."HorarioTemporal" DROP CONSTRAINT IF EXISTS "FK_HorarioTemporal_Horario";
ALTER TABLE IF EXISTS public."Marcacion" DROP CONSTRAINT IF EXISTS "FK_Marcacion_Horario";
ALTER TABLE IF EXISTS public."Empleado" DROP CONSTRAINT IF EXISTS "FK_Empleado_Horario";
ALTER TABLE IF EXISTS public."Asistencia" DROP CONSTRAINT IF EXISTS "FK_Asistencia_Horario";

DROP INDEX IF EXISTS public."UX_RRHH_Feriado_Fecha";

ALTER TABLE IF EXISTS public."TipoPermiso" ALTER COLUMN "idTipoPermiso" DROP IDENTITY IF EXISTS;
ALTER TABLE IF EXISTS public."Motivo_Perm" ALTER COLUMN "idMotivo" DROP IDENTITY IF EXISTS;
ALTER TABLE IF EXISTS public."RRHH_Feriado" ALTER COLUMN "idFeriado" DROP IDENTITY IF EXISTS;
ALTER TABLE IF EXISTS public."Horario" ALTER COLUMN "idHorario" DROP IDENTITY IF EXISTS;

ALTER TABLE IF EXISTS public."TipoPermiso" DROP CONSTRAINT IF EXISTS "PK_TipoPermiso";
ALTER TABLE IF EXISTS public."Motivo_Perm" DROP CONSTRAINT IF EXISTS "PK_Motivo_Perm";
ALTER TABLE IF EXISTS public."RRHH_Feriado" DROP CONSTRAINT IF EXISTS "PK_RRHH_Feriado";
ALTER TABLE IF EXISTS public."Horario" DROP CONSTRAINT IF EXISTS "PK_Horario";

COMMIT;
