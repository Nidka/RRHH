DO $test$
DECLARE t record;
DECLARE filas bigint;
BEGIN
    FOR t IN SELECT * FROM (VALUES ('Usuario'), ('Motivo_Perm'),
        ('TipoPermiso'), ('Horario'), ('RRHH_Feriado')) v(tabla)
    LOOP
        EXECUTE format('SELECT count(*) FROM public.%I', t.tabla) INTO filas;
        IF filas <> 2 THEN RAISE EXCEPTION 'TEC-002 QA: restore perdió filas de %', t.tabla; END IF;
    END LOOP;
    IF (SELECT count(*) FROM public."Usuario" WHERE "IdUsuario" = 1 AND "Login" = 'ficticio') <> 2
       OR (SELECT count(*) FROM public."Motivo_Perm" WHERE "idMotivo" = 10) <> 2
       OR (SELECT count(*) FROM public."Usuario_Rol" WHERE "IdUsuario" = 1) <> 1
       OR (SELECT count(*) FROM public."Permiso" WHERE "idMotivo" = 10) <> 1
       OR (SELECT count(*) FROM public."Permiso_Aud" WHERE "idMotivo_Ant" = 10 AND "idMotivo_Act" = 10) <> 1 THEN
        RAISE EXCEPTION 'TEC-002 QA: restore no reprodujo los datos y referencias del fixture inicial';
    END IF;
END
$test$;
