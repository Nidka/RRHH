-- Aserciones posteriores a 20261018_02_integrity_ids.sql.

DO $test$
DECLARE
    new_horario integer;
    new_feriado integer;
    new_tipo integer;
    new_motivo integer;
    rejected boolean;
BEGIN
    IF (SELECT COUNT(*) FROM pg_constraint
        WHERE contype = 'p'
          AND conrelid IN ('public."Horario"'::regclass,
                           'public."RRHH_Feriado"'::regclass,
                           'public."Motivo_Perm"'::regclass,
                           'public."TipoPermiso"'::regclass)) <> 4 THEN
        RAISE EXCEPTION 'TEST TEC-002: faltan PK';
    END IF;

    IF (SELECT COUNT(*) FROM information_schema.columns
        WHERE table_schema = 'public'
          AND is_identity = 'YES'
          AND identity_generation = 'BY DEFAULT'
          AND (table_name, column_name) IN (
              ('Horario', 'idHorario'), ('RRHH_Feriado', 'idFeriado'),
              ('Motivo_Perm', 'idMotivo'), ('TipoPermiso', 'idTipoPermiso'))) <> 4 THEN
        RAISE EXCEPTION 'TEST TEC-002: el contrato IDENTITY BY DEFAULT no está completo';
    END IF;

    IF (SELECT COUNT(*) FROM pg_constraint
        WHERE contype = 'f' AND convalidated
          AND conname LIKE 'FK_%') <> 8 THEN
        RAISE EXCEPTION 'TEST TEC-002: faltan FK validadas';
    END IF;

    INSERT INTO public."Horario" ("Descrip_Horario") VALUES ('NUEVO FICTICIO') RETURNING "idHorario" INTO new_horario;
    INSERT INTO public."RRHH_Feriado" ("Fecha", "Motivo") VALUES ('2099-01-02', 'NUEVO FICTICIO') RETURNING "idFeriado" INTO new_feriado;
    INSERT INTO public."TipoPermiso" ("DescripTipoPermiso") VALUES ('NUEVO FICTICIO') RETURNING "idTipoPermiso" INTO new_tipo;
    INSERT INTO public."Motivo_Perm" ("Descrip_Motivo", "idTipoPermiso") VALUES ('NUEVO FICTICIO', new_tipo) RETURNING "idMotivo" INTO new_motivo;

    IF new_horario <> 6 OR new_feriado <> 13 OR new_tipo <> 4 OR new_motivo <> 11 THEN
        RAISE EXCEPTION 'TEST TEC-002: secuencias desalineadas: %, %, %, %',
                        new_horario, new_feriado, new_tipo, new_motivo;
    END IF;

    rejected := false;
    BEGIN
        INSERT INTO public."Permiso" VALUES (999999);
    EXCEPTION WHEN foreign_key_violation THEN
        rejected := true;
    END;
    IF NOT rejected THEN
        RAISE EXCEPTION 'TEST TEC-002: se aceptó una referencia de motivo inválida';
    END IF;

    rejected := false;
    BEGIN
        INSERT INTO public."RRHH_Feriado" ("Fecha", "Motivo")
        VALUES ('2099-01-02 18:00:00', 'FECHA DUPLICADA');
    EXCEPTION WHEN unique_violation THEN
        rejected := true;
    END;
    IF NOT rejected THEN
        RAISE EXCEPTION 'TEST TEC-002: se aceptó una fecha de feriado repetida';
    END IF;

    RAISE NOTICE 'TEST TEC-002 OK: IDs %, %, %, %; PK/FK/fecha verificadas',
                 new_horario, new_feriado, new_tipo, new_motivo;
END
$test$;
