DO $test$
DECLARE t record;
DECLARE filas bigint;
DECLARE respaldo bigint;
BEGIN
    FOR t IN SELECT * FROM (VALUES ('Usuario'), ('Motivo_Perm'),
        ('TipoPermiso'), ('Horario'), ('RRHH_Feriado')) v(tabla)
    LOOP
        EXECUTE format('SELECT count(*) FROM public.%I', t.tabla) INTO filas;
        EXECUTE format('SELECT count(*) FROM rrhh_qa_respaldo.%I', t.tabla) INTO respaldo;
        IF filas <> 1 OR respaldo <> 2 THEN
            RAISE EXCEPTION 'TEC-002 QA: cantidad inesperada en %', t.tabla;
        END IF;
        EXECUTE format('SELECT count(*) FROM (
            SELECT * FROM rrhh_qa_respaldo.%I EXCEPT SELECT * FROM public.%I) diferencias',
            t.tabla, t.tabla) INTO filas;
        IF filas <> 0 THEN RAISE EXCEPTION 'TEC-002 QA: se perdió contenido en %', t.tabla; END IF;
    END LOOP;
    IF (SELECT count(*) FROM public."Usuario_Rol" WHERE "IdUsuario" = 1) <> 1
       OR (SELECT count(*) FROM public."Permiso" WHERE "idMotivo" = 10) <> 1
       OR (SELECT count(*) FROM public."Permiso_Aud" WHERE "idMotivo_Ant" = 10 AND "idMotivo_Act" = 10) <> 1 THEN
        RAISE EXCEPTION 'TEC-002 QA: cambiaron las referencias';
    END IF;
    IF (SELECT count(*) FROM pg_constraint WHERE contype = 'p'
        AND conrelid IN ('public."Usuario"'::regclass, 'public."Motivo_Perm"'::regclass,
            'public."TipoPermiso"'::regclass, 'public."Horario"'::regclass, 'public."RRHH_Feriado"'::regclass)) <> 5
       OR (SELECT count(*) FROM pg_constraint WHERE contype = 'f' AND convalidated
           AND connamespace = 'public'::regnamespace) <> 9 THEN
        RAISE EXCEPTION 'TEC-002 QA: se esperaban cinco PK y nueve FK validadas en el fixture';
    END IF;
    BEGIN
        INSERT INTO public."Usuario" SELECT * FROM public."Usuario";
        RAISE EXCEPTION 'TEC-002 QA: Usuario permitió repetir el ID';
    EXCEPTION WHEN unique_violation THEN NULL;
    END;
    BEGIN
        INSERT INTO public."Usuario_Rol" VALUES (999, 10);
        RAISE EXCEPTION 'TEC-002 QA: se aceptó usuario huérfano';
    EXCEPTION WHEN foreign_key_violation THEN NULL;
    END;
    BEGIN
        INSERT INTO public."Permiso" VALUES (999);
        RAISE EXCEPTION 'TEC-002 QA: se aceptó motivo huérfano';
    EXCEPTION WHEN foreign_key_violation THEN NULL;
    END;
END
$test$;
