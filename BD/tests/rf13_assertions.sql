-- Aserciones posteriores a 20261112_03_teletrabajo.sql, sobre una BD local desechable vacía
-- (basta una BD nueva: la migración no depende de otras tablas). Todos los datos son ficticios.
--   createdb rrhh_rf13_tests
--   psql -X -v ON_ERROR_STOP=1 -d rrhh_rf13_tests -f BD/migrations/20261112_03_teletrabajo.sql
--   psql -X -v ON_ERROR_STOP=1 -d rrhh_rf13_tests -f BD/tests/rf13_assertions.sql
--   psql -X -v ON_ERROR_STOP=1 -d rrhh_rf13_tests -f BD/migrations/20261112_03_teletrabajo.sql   -- idempotente

DO $test$
DECLARE
    id1 integer;
    id2 integer;
    rechazado boolean;
BEGIN
    -- Estructura: PK identidad, columnas y tipos del contrato, índice del reporte.
    IF NOT EXISTS (SELECT 1 FROM information_schema.columns
                   WHERE table_schema = 'public' AND table_name = 'Teletrabajo'
                     AND column_name = 'Id' AND is_identity = 'YES' AND identity_generation = 'BY DEFAULT') THEN
        RAISE EXCEPTION 'TEST RF-13: "Id" debe ser identidad BY DEFAULT';
    END IF;
    IF (SELECT count(*) FROM information_schema.columns
        WHERE table_schema = 'public' AND table_name = 'Teletrabajo') <> 9 THEN
        RAISE EXCEPTION 'TEST RF-13: la tabla debe tener exactamente 9 columnas';
    END IF;
    IF NOT EXISTS (SELECT 1 FROM pg_indexes WHERE schemaname = 'public' AND tablename = 'Teletrabajo'
                   AND indexname = 'IX_Teletrabajo_Empleado_Periodo') THEN
        RAISE EXCEPTION 'TEST RF-13: falta el índice por (IdEmpleado, FechaInicio, FechaFin)';
    END IF;

    -- Altas válidas con el mismo INSERT que el repositorio (sin Id, sin Estado, sin FechaRegistro).
    INSERT INTO public."Teletrabajo" ("IdEmpleado", "FechaInicio", "FechaFin", "Modalidad", "DiasRemotos", "Autorizacion")
    VALUES (1, '2026-11-10', '2026-11-12', 'T', 31, 'MEMO-FICTICIO-1') RETURNING "Id" INTO id1;
    INSERT INTO public."Teletrabajo" ("IdEmpleado", "FechaInicio", "FechaFin", "Modalidad", "DiasRemotos", "Autorizacion")
    VALUES (1, '2026-11-13', '2026-11-13', 'P', 5, NULL) RETURNING "Id" INTO id2;   -- un solo día; lunes y miércoles
    IF id1 IS NULL OR id2 IS NULL OR id1 = id2 THEN
        RAISE EXCEPTION 'TEST RF-13: cada alta debe recibir un Id distinto por RETURNING';
    END IF;
    IF (SELECT count(*) FROM public."Teletrabajo" WHERE "Estado" AND "FechaRegistro" IS NOT NULL) <> 2 THEN
        RAISE EXCEPTION 'TEST RF-13: Estado y FechaRegistro deben tomar su valor por defecto';
    END IF;

    -- Altas inválidas: cada una debe violar exactamente la restricción esperada.
    rechazado := false;
    BEGIN
        INSERT INTO public."Teletrabajo" ("IdEmpleado", "FechaInicio", "FechaFin", "Modalidad", "DiasRemotos")
        VALUES (2, '2026-11-12', '2026-11-10', 'T', 31);
    EXCEPTION WHEN check_violation THEN rechazado := true; END;
    IF NOT rechazado THEN RAISE EXCEPTION 'TEST RF-13: un rango invertido debe rechazarse'; END IF;

    rechazado := false;
    BEGIN
        INSERT INTO public."Teletrabajo" ("IdEmpleado", "FechaInicio", "FechaFin", "Modalidad", "DiasRemotos")
        VALUES (2, '2026-11-10', '2026-11-12', 'X', 31);
    EXCEPTION WHEN check_violation THEN rechazado := true; END;
    IF NOT rechazado THEN RAISE EXCEPTION 'TEST RF-13: una modalidad distinta de T/P debe rechazarse'; END IF;

    rechazado := false;
    BEGIN
        INSERT INTO public."Teletrabajo" ("IdEmpleado", "FechaInicio", "FechaFin", "Modalidad", "DiasRemotos")
        VALUES (2, '2026-11-10', '2026-11-12', 'T', 30);
    EXCEPTION WHEN check_violation THEN rechazado := true; END;
    IF NOT rechazado THEN RAISE EXCEPTION 'TEST RF-13: total con máscara distinta de 31 debe rechazarse'; END IF;

    rechazado := false;
    BEGIN
        INSERT INTO public."Teletrabajo" ("IdEmpleado", "FechaInicio", "FechaFin", "Modalidad", "DiasRemotos")
        VALUES (2, '2026-11-10', '2026-11-12', 'P', 31);
    EXCEPTION WHEN check_violation THEN rechazado := true; END;
    IF NOT rechazado THEN RAISE EXCEPTION 'TEST RF-13: parcial con los cinco días (31) debe rechazarse'; END IF;

    rechazado := false;
    BEGIN
        INSERT INTO public."Teletrabajo" ("IdEmpleado", "FechaInicio", "FechaFin", "Modalidad", "DiasRemotos")
        VALUES (2, '2026-11-10', '2026-11-12', 'P', 0);
    EXCEPTION WHEN check_violation THEN rechazado := true; END;
    IF NOT rechazado THEN RAISE EXCEPTION 'TEST RF-13: parcial sin ningún día remoto (0) debe rechazarse'; END IF;

    rechazado := false;
    BEGIN
        INSERT INTO public."Teletrabajo" ("IdEmpleado", "FechaInicio", "FechaFin", "Modalidad", "DiasRemotos")
        VALUES (NULL, '2026-11-10', '2026-11-12', 'T', 31);
    EXCEPTION WHEN not_null_violation THEN rechazado := true; END;
    IF NOT rechazado THEN RAISE EXCEPTION 'TEST RF-13: IdEmpleado nulo debe rechazarse'; END IF;

    -- Limpieza: deja la tabla vacía para poder probar la reversión.
    DELETE FROM public."Teletrabajo" WHERE "Id" IN (id1, id2);
END
$test$;
