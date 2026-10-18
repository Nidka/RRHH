-- TEC-002: perfilado de integridad sin datos personales.
-- Uso: psql "$CONNECTION" -X -v ON_ERROR_STOP=1 -f BD/diagnostics/tec002_profile.sql
-- El script solo lee metadatos y conteos; no lista IDs ni valores de negocio.

BEGIN READ ONLY;

SELECT current_database() AS database_name,
       current_user AS login_role,
       current_setting('server_version') AS server_version;

WITH resumen AS (
    SELECT 'Horario'::text AS tabla,
           'idHorario'::text AS columna,
           COUNT(*) AS filas,
           COUNT(*) FILTER (WHERE "idHorario" IS NULL) AS nulos,
           COUNT(DISTINCT "idHorario") AS ids_distintos,
           MAX("idHorario") AS id_maximo,
           COUNT(*) - COUNT(DISTINCT "idHorario") AS filas_repetidas
    FROM public."Horario"
    UNION ALL
    SELECT 'RRHH_Feriado', 'idFeriado', COUNT(*),
           COUNT(*) FILTER (WHERE "idFeriado" IS NULL),
           COUNT(DISTINCT "idFeriado"), MAX("idFeriado"),
           COUNT(*) - COUNT(DISTINCT "idFeriado")
    FROM public."RRHH_Feriado"
    UNION ALL
    SELECT 'Motivo_Perm', 'idMotivo', COUNT(*),
           COUNT(*) FILTER (WHERE "idMotivo" IS NULL),
           COUNT(DISTINCT "idMotivo"), MAX("idMotivo"),
           COUNT(*) - COUNT(DISTINCT "idMotivo")
    FROM public."Motivo_Perm"
    UNION ALL
    SELECT 'TipoPermiso', 'idTipoPermiso', COUNT(*),
           COUNT(*) FILTER (WHERE "idTipoPermiso" IS NULL),
           COUNT(DISTINCT "idTipoPermiso"), MAX("idTipoPermiso"),
           COUNT(*) - COUNT(DISTINCT "idTipoPermiso")
    FROM public."TipoPermiso"
)
SELECT * FROM resumen ORDER BY tabla;

WITH duplicados AS (
    SELECT 'Horario'::text AS tabla, COUNT(*) AS ids_repetidos,
           COALESCE(SUM(copias - 1), 0) AS filas_sobrantes,
           COUNT(*) FILTER (WHERE variantes > 1) AS ids_con_conflicto,
           MIN(copias) AS min_copias, MAX(copias) AS max_copias
    FROM (
        SELECT "idHorario", COUNT(*) AS copias,
               COUNT(DISTINCT to_jsonb(t)) AS variantes
        FROM public."Horario" AS t GROUP BY "idHorario" HAVING COUNT(*) > 1
    ) AS d
    UNION ALL
    SELECT 'RRHH_Feriado', COUNT(*), COALESCE(SUM(copias - 1), 0),
           COUNT(*) FILTER (WHERE variantes > 1), MIN(copias), MAX(copias)
    FROM (
        SELECT "idFeriado", COUNT(*) AS copias,
               COUNT(DISTINCT to_jsonb(t)) AS variantes
        FROM public."RRHH_Feriado" AS t GROUP BY "idFeriado" HAVING COUNT(*) > 1
    ) AS d
    UNION ALL
    SELECT 'Motivo_Perm', COUNT(*), COALESCE(SUM(copias - 1), 0),
           COUNT(*) FILTER (WHERE variantes > 1), MIN(copias), MAX(copias)
    FROM (
        SELECT "idMotivo", COUNT(*) AS copias,
               COUNT(DISTINCT to_jsonb(t)) AS variantes
        FROM public."Motivo_Perm" AS t GROUP BY "idMotivo" HAVING COUNT(*) > 1
    ) AS d
    UNION ALL
    SELECT 'TipoPermiso', COUNT(*), COALESCE(SUM(copias - 1), 0),
           COUNT(*) FILTER (WHERE variantes > 1), MIN(copias), MAX(copias)
    FROM (
        SELECT "idTipoPermiso", COUNT(*) AS copias,
               COUNT(DISTINCT to_jsonb(t)) AS variantes
        FROM public."TipoPermiso" AS t GROUP BY "idTipoPermiso" HAVING COUNT(*) > 1
    ) AS d
)
SELECT * FROM duplicados ORDER BY tabla;

SELECT 'Asistencia.idHorario' AS referencia, COUNT(*) AS huerfanas
FROM public."Asistencia" AS c
WHERE c."idHorario" IS NOT NULL
  AND NOT EXISTS (SELECT 1 FROM public."Horario" AS p WHERE p."idHorario" = c."idHorario")
UNION ALL
SELECT 'Empleado.idHorario', COUNT(*) FROM public."Empleado" AS c
WHERE c."idHorario" IS NOT NULL
  AND NOT EXISTS (SELECT 1 FROM public."Horario" AS p WHERE p."idHorario" = c."idHorario")
UNION ALL
SELECT 'Marcacion.idHorario', COUNT(*) FROM public."Marcacion" AS c
WHERE c."idHorario" IS NOT NULL
  AND NOT EXISTS (SELECT 1 FROM public."Horario" AS p WHERE p."idHorario" = c."idHorario")
UNION ALL
SELECT 'HorarioTemporal.HorarioAsignado', COUNT(*) FROM public."HorarioTemporal" AS c
WHERE c."HorarioAsignado" IS NOT NULL
  AND NOT EXISTS (SELECT 1 FROM public."Horario" AS p WHERE p."idHorario" = c."HorarioAsignado")
UNION ALL
SELECT 'Motivo_Perm.idTipoPermiso', COUNT(*) FROM public."Motivo_Perm" AS c
WHERE c."idTipoPermiso" IS NOT NULL
  AND NOT EXISTS (SELECT 1 FROM public."TipoPermiso" AS p WHERE p."idTipoPermiso" = c."idTipoPermiso")
UNION ALL
SELECT 'Permiso.idMotivo', COUNT(*) FROM public."Permiso" AS c
WHERE c."idMotivo" IS NOT NULL
  AND NOT EXISTS (SELECT 1 FROM public."Motivo_Perm" AS p WHERE p."idMotivo" = c."idMotivo")
UNION ALL
SELECT 'Permiso_Aud.idMotivo_Ant', COUNT(*) FROM public."Permiso_Aud" AS c
WHERE c."idMotivo_Ant" IS NOT NULL
  AND NOT EXISTS (SELECT 1 FROM public."Motivo_Perm" AS p WHERE p."idMotivo" = c."idMotivo_Ant")
UNION ALL
SELECT 'Permiso_Aud.idMotivo_Act', COUNT(*) FROM public."Permiso_Aud" AS c
WHERE c."idMotivo_Act" IS NOT NULL
  AND NOT EXISTS (SELECT 1 FROM public."Motivo_Perm" AS p WHERE p."idMotivo" = c."idMotivo_Act")
ORDER BY 1;

SELECT COUNT(*) AS fechas_repetidas,
       COALESCE(SUM(copias - 1), 0) AS filas_sobrantes,
       COUNT(*) FILTER (WHERE ids_distintos > 1) AS fechas_con_ids_distintos
FROM (
    SELECT "Fecha"::date, COUNT(*) AS copias,
           COUNT(DISTINCT "idFeriado") AS ids_distintos
    FROM public."RRHH_Feriado"
    WHERE "Fecha" IS NOT NULL
    GROUP BY "Fecha"::date
    HAVING COUNT(*) > 1
) AS d;

SELECT c.relname AS tabla, con.conname, con.contype,
       pg_get_constraintdef(con.oid) AS definicion
FROM pg_constraint AS con
JOIN pg_class AS c ON c.oid = con.conrelid
JOIN pg_namespace AS n ON n.oid = c.relnamespace
WHERE n.nspname = 'public'
  AND c.relname IN ('Horario', 'RRHH_Feriado', 'Motivo_Perm', 'TipoPermiso')
ORDER BY c.relname, con.conname;

SELECT table_name, column_name, is_identity, identity_generation, column_default
FROM information_schema.columns
WHERE table_schema = 'public'
  AND (table_name, column_name) IN (
      ('Horario', 'idHorario'),
      ('RRHH_Feriado', 'idFeriado'),
      ('Motivo_Perm', 'idMotivo'),
      ('TipoPermiso', 'idTipoPermiso'))
ORDER BY table_name;

-- Comprueba si hay una cuenta técnicamente apta, sin revelar el login.
SELECT COUNT(DISTINCT lower(btrim(u."Login"))) FILTER (
           WHERE COALESCE(u."Estado", false)
             AND u."PasswordHash" IS NOT NULL
             AND u."PasswordSalt" IS NOT NULL
             AND COALESCE(u."PasswordIterations", 0) > 0
             AND EXISTS (
                 SELECT 1
                 FROM public."Usuario_Rol" AS ur
                 JOIN public."Rol" AS r ON r."IdRol" = ur."IdRol"
                 WHERE ur."IdUsuario" = u."IdUsuario"
                   AND r."IdSistema" = '0500000')) AS logins_rrhh_elegibles
FROM public."Usuario" AS u;

ROLLBACK;
