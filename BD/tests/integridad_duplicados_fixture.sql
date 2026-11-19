-- Solo lo invoca el ejecutor que crea una base vacía con el nombre de QA.
DO $destino$
BEGIN
    IF current_database() <> 'rrhh_integridad_qa' OR inet_server_addr() IS NULL
       OR inet_server_addr() NOT IN ('127.0.0.1'::inet, '::1'::inet) THEN
        RAISE EXCEPTION 'TEC-002 QA: fixture fuera de la base local dedicada';
    END IF;
END
$destino$;
\ir tec002_fixture.sql
CREATE TABLE public."Usuario" ("IdUsuario" integer, "Login" text,
    "PasswordHash" text, "PasswordSalt" text);
CREATE TABLE public."Usuario_Rol" ("IdUsuario" integer, "IdRol" integer);
INSERT INTO public."Usuario" VALUES (1, 'ficticio', 'hash-ficticio', 'salt-ficticio');
INSERT INTO public."Usuario_Rol" VALUES (1, 10);
INSERT INTO public."Usuario" SELECT * FROM public."Usuario";
INSERT INTO public."Motivo_Perm" SELECT * FROM public."Motivo_Perm";
INSERT INTO public."TipoPermiso" SELECT * FROM public."TipoPermiso";
INSERT INTO public."Horario" SELECT * FROM public."Horario";
INSERT INTO public."RRHH_Feriado" SELECT * FROM public."RRHH_Feriado";
