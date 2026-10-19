BEGIN;

-- El respaldo original no contiene filas en EstructOrganiz, aunque
-- Empleado y Empleado_Area conservan las claves de año y área. Se crean
-- entradas provisionales para que las consultas y reportes heredados no
-- descarten todo el personal mediante sus INNER JOIN.
WITH areas AS (
    SELECT DISTINCT "Year", "idAreaOrganiz"
    FROM public."Empleado_Area"
    UNION
    SELECT DISTINCT "Year", "idAreaOrganiz"
    FROM public."Empleado"
), missing AS (
    SELECT a."Year", a."idAreaOrganiz"
    FROM areas a
    WHERE a."Year" IS NOT NULL
      AND a."idAreaOrganiz" IS NOT NULL
      AND NOT EXISTS (
          SELECT 1
          FROM public."EstructOrganiz" eo
          WHERE eo."Year" = a."Year"
            AND eo."idAreaOrganiz" = a."idAreaOrganiz"
      )
)
INSERT INTO public."EstructOrganiz" (
    "Year", "idAreaOrganiz", "AreaOrganizacional", "Abrev", "Sigla"
)
SELECT
    "Year",
    "idAreaOrganiz",
    'Area ' || "idAreaOrganiz"::text,
    left('AREA-' || "idAreaOrganiz"::text, 10),
    left('A' || "idAreaOrganiz"::text, 6)
FROM missing;

COMMIT;
