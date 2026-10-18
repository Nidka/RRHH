-- Fixture mínimo y completamente ficticio para TEC-002.
-- Ejecutar únicamente en una BD desechable dedicada.

DROP TABLE IF EXISTS public."Permiso_Aud", public."Permiso", public."Motivo_Perm",
    public."TipoPermiso", public."HorarioTemporal", public."Marcacion",
    public."Empleado", public."Asistencia", public."Horario", public."RRHH_Feriado" CASCADE;

CREATE TABLE public."Horario" (
    "idHorario" integer NOT NULL,
    "Descrip_Horario" varchar(20)
);
CREATE TABLE public."RRHH_Feriado" (
    "idFeriado" integer NOT NULL,
    "Fecha" timestamp without time zone,
    "Motivo" varchar(200)
);
CREATE TABLE public."TipoPermiso" (
    "idTipoPermiso" integer NOT NULL,
    "DescripTipoPermiso" varchar(50)
);
CREATE TABLE public."Motivo_Perm" (
    "idMotivo" integer NOT NULL,
    "Descrip_Motivo" varchar(50),
    "idTipoPermiso" integer
);
CREATE TABLE public."Asistencia" ("idHorario" integer);
CREATE TABLE public."Empleado" ("idHorario" integer);
CREATE TABLE public."Marcacion" ("idHorario" integer);
CREATE TABLE public."HorarioTemporal" ("HorarioAsignado" integer);
CREATE TABLE public."Permiso" ("idMotivo" integer);
CREATE TABLE public."Permiso_Aud" ("idMotivo_Ant" integer, "idMotivo_Act" integer);

INSERT INTO public."Horario" VALUES (5, 'TURNO FICTICIO');
INSERT INTO public."RRHH_Feriado" VALUES (12, '2099-01-01', 'FERIADO FICTICIO');
INSERT INTO public."TipoPermiso" VALUES (3, 'TIPO FICTICIO');
INSERT INTO public."Motivo_Perm" VALUES (10, 'MOTIVO FICTICIO', 3);
INSERT INTO public."Asistencia" VALUES (5);
INSERT INTO public."Empleado" VALUES (5);
INSERT INTO public."Marcacion" VALUES (5);
INSERT INTO public."HorarioTemporal" VALUES (5);
INSERT INTO public."Permiso" VALUES (10);
INSERT INTO public."Permiso_Aud" VALUES (10, 10);
