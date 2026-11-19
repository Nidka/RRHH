-- Fixture y aserciones exclusivamente ficticios para el ensayo de grupos anuales.
DO $test$
BEGIN
    IF current_database() <> 'rrhh_integridad_qa' OR inet_server_addr() IS NULL
       OR inet_server_addr() NOT IN ('127.0.0.1'::inet, '::1'::inet) THEN
        RAISE EXCEPTION 'RF-06 QA: destino de grupos no autorizado';
    END IF;
    IF EXISTS (SELECT 1 FROM public."Motivo_Perm" WHERE "GrupoReglaAnual" IS NOT NULL) THEN
        RAISE EXCEPTION 'RF-06 QA: la migración no debe configurar grupos existentes';
    END IF;
    INSERT INTO public."Motivo_Perm"
        ("idMotivo", "Descrip_Motivo", "idTipoPermiso", "UnaVezPorAnio", "GrupoReglaAnual")
    VALUES (900, 'LICENCIA FICTICIA', 3, true, 'PILOTO-FAMILIAR'),
        (901, 'ALTERNATIVA FICTICIA', 3, true, 'PILOTO-FAMILIAR'),
        (902, 'OTRA LICENCIA FICTICIA', 3, true, 'PILOTO-OTRA');
    IF (SELECT count(*) FROM public."Motivo_Perm" WHERE "GrupoReglaAnual"='PILOTO-FAMILIAR') <> 2 THEN
        RAISE EXCEPTION 'RF-06 QA: no se crearon los dos motivos del grupo ficticio';
    END IF;
    BEGIN
        UPDATE public."Motivo_Perm" SET "UnaVezPorAnio"=false WHERE "idMotivo"=900;
        RAISE EXCEPTION 'RF-06 QA: se aceptó un grupo sin marca anual';
    EXCEPTION WHEN check_violation THEN NULL;
    END;
    BEGIN
        UPDATE public."Motivo_Perm" SET "GrupoReglaAnual"=' ' WHERE "idMotivo"=900;
        RAISE EXCEPTION 'RF-06 QA: se aceptó una clave vacía';
    EXCEPTION WHEN check_violation THEN NULL;
    END;
END
$test$;
