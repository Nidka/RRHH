-- RF-18 / CR-018: comprueba la consulta de PostgreSqlAusenciasRepository.ListarSolapadas con datos ficticios.
-- SOLO para una base local desechable: crea tablas en public. Aborta si ya existe public."Permiso"
-- (señal de que apunta a una base con datos), antes de crear nada.
--   createdb rrhh_rf18_tests && psql -X -v ON_ERROR_STOP=1 -d rrhh_rf18_tests -f BD/tests/rf18_ausencias.sql

DO $guarda$
BEGIN
    IF to_regclass('public."Permiso"') IS NOT NULL OR to_regclass('public."Empleado"') IS NOT NULL THEN
        RAISE EXCEPTION 'RF-18: la base ya tiene public."Permiso"/"Empleado"; use una base desechable vacía';
    END IF;
END
$guarda$;

CREATE TABLE public."Persona" ("IdPersona" integer, "Nombres" varchar(100), "Apellido_Paterno" varchar(30), "Apellido_Materno" varchar(30));
CREATE TABLE public."Empleado" ("IdEmpleado" integer, "IdPersona" integer);
CREATE TABLE public."Motivo_Perm" ("idMotivo" integer, "Descrip_Motivo" varchar(50));
CREATE TABLE public."Permiso" ("IdEmpleado" integer, "NPermiso" integer, "FechaInicio" timestamp, "FechaFin" timestamp, "idMotivo" integer);

INSERT INTO public."Persona" VALUES (1, 'ANA', 'LOPEZ', 'RUIZ'), (2, 'BETO', 'DIAZ', NULL), (3, 'CARLA', 'MESA', 'SOL');
INSERT INTO public."Empleado" VALUES (1, 1), (2, 2), (3, 3);
INSERT INTO public."Motivo_Perm" VALUES (10, 'VACACIONES'), (20, 'ENFERMEDAD'), (30, 'LICENCIA');

-- Periodo de referencia de las aserciones: 10 al 12 de noviembre de 2026.
INSERT INTO public."Permiso" VALUES
    (1, 1, '2026-11-05 08:00', '2026-11-10 17:00', 10),  -- empieza antes, termina el primer día
    (1, 2, '2026-11-12 00:00', '2026-11-20 00:00', 20),  -- empieza el último día
    (2, 1, '2026-11-01',       '2026-11-30',       30),  -- contiene todo el periodo
    (2, 2, '2026-11-11',       '2026-11-11',       10),  -- dentro del periodo
    (3, 1, '2026-11-01',       '2026-11-09',       10),  -- termina el día previo: fuera
    (3, 2, '2026-11-13',       '2026-11-14',       10),  -- empieza el día siguiente: fuera
    (3, 3, NULL,               '2026-11-11',       10),  -- fecha inicial nula: se omite
    (3, 4, '2026-11-10',       '2026-11-10',       NULL);-- sin motivo: se informa con motivo vacío

-- Misma consulta que el repositorio (parámetros @desde, @hasta, @motivoId).
CREATE FUNCTION pg_temp.ausencias(desde date, hasta date, motivo integer)
RETURNS TABLE (idempleado integer, empleado text, idmotivo integer, descripcion text, inicio date, fin date) AS $f$
    SELECT p."IdEmpleado",
           btrim(concat_ws(' ', pe."Apellido_Paterno", pe."Apellido_Materno", pe."Nombres")),
           COALESCE(p."idMotivo", 0),
           COALESCE(m."Descrip_Motivo", '')::text,
           p."FechaInicio"::date, p."FechaFin"::date
    FROM public."Permiso" AS p
    INNER JOIN public."Empleado" AS e ON e."IdEmpleado" = p."IdEmpleado"
    INNER JOIN public."Persona" AS pe ON pe."IdPersona" = e."IdPersona"
    LEFT JOIN public."Motivo_Perm" AS m ON m."idMotivo" = p."idMotivo"
    WHERE p."FechaInicio" IS NOT NULL AND p."FechaFin" IS NOT NULL
      AND p."FechaInicio"::date <= hasta AND p."FechaFin"::date >= desde
      AND (motivo IS NULL OR p."idMotivo" = motivo)
    ORDER BY 2, 5;
$f$ LANGUAGE sql;

DO $test$
DECLARE
    n integer;
BEGIN
    -- Todos los motivos: incluye empieza antes, termina después, contención, dentro y sin motivo (5 filas).
    SELECT count(*) INTO n FROM pg_temp.ausencias('2026-11-10', '2026-11-12', NULL);
    IF n <> 5 THEN RAISE EXCEPTION 'TEST RF-18: se esperaban 5 ausencias y hubo %', n; END IF;

    -- Los permisos que terminan el día previo o empiezan el día siguiente, y el de fecha nula, no aparecen.
    SELECT count(*) INTO n FROM pg_temp.ausencias('2026-11-10', '2026-11-12', NULL) WHERE idempleado = 3 AND idmotivo = 10;
    IF n <> 0 THEN RAISE EXCEPTION 'TEST RF-18: no deben aparecer los permisos contiguos ni el de fecha nula'; END IF;

    -- El permiso que contiene todo el periodo (que el criterio heredado omitía) sí aparece.
    SELECT count(*) INTO n FROM pg_temp.ausencias('2026-11-10', '2026-11-12', NULL) WHERE idempleado = 2 AND idmotivo = 30;
    IF n <> 1 THEN RAISE EXCEPTION 'TEST RF-18: debe aparecer el permiso que contiene el periodo'; END IF;

    -- Filtro por motivo.
    SELECT count(*) INTO n FROM pg_temp.ausencias('2026-11-10', '2026-11-12', 10);
    IF n <> 2 THEN RAISE EXCEPTION 'TEST RF-18: el motivo 10 debe dar 2 ausencias y dio %', n; END IF;

    -- Periodo de un solo día (13/11): solo los permisos que lo cubren.
    SELECT count(*) INTO n FROM pg_temp.ausencias('2026-11-13', '2026-11-13', NULL);
    IF n <> 3 THEN RAISE EXCEPTION 'TEST RF-18: el 13/11 debe dar 3 ausencias y dio %', n; END IF;

    -- Periodo sin ausencias.
    SELECT count(*) INTO n FROM pg_temp.ausencias('2027-01-01', '2027-01-31', NULL);
    IF n <> 0 THEN RAISE EXCEPTION 'TEST RF-18: enero de 2027 no debe tener ausencias'; END IF;

    -- Nombre completo: apellidos y nombres, sin espacios sobrantes cuando falta el apellido materno.
    SELECT count(*) INTO n FROM pg_temp.ausencias('2026-11-10', '2026-11-12', NULL) WHERE empleado = 'DIAZ BETO';
    IF n <> 2 THEN RAISE EXCEPTION 'TEST RF-18: el nombre sin apellido materno debe quedar «DIAZ BETO»'; END IF;
END
$test$;

\echo 'RF-18: aserciones SQL correctas'
