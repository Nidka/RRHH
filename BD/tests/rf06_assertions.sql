-- Aserciones posteriores a 20261111_01_licencia_una_vez_anio.sql.
-- Ejecutar en la BD desechable, en este orden: tec002_fixture.sql, 20261018_02_integrity_ids.sql
-- (da IDENTITY a "idMotivo", que usa el alta sin ID de abajo) y 20261111_01_licencia_una_vez_anio.sql.

DO $test$
BEGIN
    IF NOT EXISTS (
        SELECT 1 FROM information_schema.columns
        WHERE table_schema = 'public' AND table_name = 'Motivo_Perm'
          AND column_name = 'UnaVezPorAnio'
          AND data_type = 'boolean' AND is_nullable = 'NO'
          AND column_default = 'false') THEN
        RAISE EXCEPTION 'TEST RF-06: "UnaVezPorAnio" debe ser boolean NOT NULL DEFAULT false';
    END IF;

    IF EXISTS (SELECT 1 FROM public."Motivo_Perm" WHERE "UnaVezPorAnio") THEN
        RAISE EXCEPTION 'TEST RF-06: la migración no debe marcar ningún motivo';
    END IF;

    IF (SELECT COUNT(*) FROM public."Motivo_Perm" WHERE "idMotivo" = 10) <> 1 THEN
        RAISE EXCEPTION 'TEST RF-06: la fila ficticia previa debe conservarse';
    END IF;

    -- Una fila nueva sin la columna toma false: el repositorio actual inserta con lista explícita de columnas.
    INSERT INTO public."Motivo_Perm" ("Descrip_Motivo", "idTipoPermiso")
    VALUES ('SIN MARCA FICTICIA', 3);
    IF (SELECT "UnaVezPorAnio" FROM public."Motivo_Perm" WHERE "Descrip_Motivo" = 'SIN MARCA FICTICIA') IS DISTINCT FROM false THEN
        RAISE EXCEPTION 'TEST RF-06: un alta sin la columna debe quedar en false';
    END IF;
    DELETE FROM public."Motivo_Perm" WHERE "Descrip_Motivo" = 'SIN MARCA FICTICIA';
END
$test$;
