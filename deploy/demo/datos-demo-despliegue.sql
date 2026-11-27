-- Datos FICTICIOS para la web desplegada (Render + Neon). Ninguna persona, documento ni registro es real.
-- Se aplican sobre el esquema completo (BD/schema.sql + BD/migrations) con deploy/cargar-datos-demo.sh.
--
-- Reglas:
--   * Todo lo propio usa códigos del 9101 al 9112 y documentos "DEMO-…". Los empleados que luego se registren en la web
--     reciben 9113 o más (MAX + 1) y este script nunca los toca.
--   * Es idempotente: borra y vuelve a crear solo sus propias filas (rango 9101-9112). No toca usuarios ni claves.
--   * Los feriados se insertan solo si la fecha no existe; nunca se borran.
--   * El tipo de permiso 2 significa «salida autorizada» en el código: aquí no se usa.
--   * Modalidad "P" en todos los motivos: el rol de operador del despliegue (10) solo ve esa modalidad (AccesoMotivosPermiso).
-- Fecha de referencia de la demostración: noviembre de 2026.

BEGIN;

-- 1. Limpieza de la propia demostración (solo el rango 9101-9112).
DELETE FROM public."Asistencia"      WHERE "IdEmpleado" BETWEEN 9101 AND 9112;
DELETE FROM public."Teletrabajo"     WHERE "IdEmpleado" BETWEEN 9101 AND 9112;
DELETE FROM public."Permiso"         WHERE "IdEmpleado" BETWEEN 9101 AND 9112;
DELETE FROM public."HorarioTemporal" WHERE "idEmpleado" BETWEEN 9101 AND 9112;
DELETE FROM public."Empleado_Area"   WHERE "IdEmpleado" BETWEEN 9101 AND 9112;
DELETE FROM public."Empleado"        WHERE "IdEmpleado" BETWEEN 9101 AND 9112;
DELETE FROM public."Persona"         WHERE "IdPersona"  BETWEEN 9101 AND 9112;
DELETE FROM public."Motivo_Perm"     WHERE "idMotivo"   BETWEEN 9101 AND 9112
  AND NOT EXISTS (SELECT 1 FROM public."Permiso" p WHERE p."idMotivo" = "Motivo_Perm"."idMotivo");
DELETE FROM public."TipoPermiso"     WHERE "idTipoPermiso" BETWEEN 9101 AND 9112
  AND NOT EXISTS (SELECT 1 FROM public."Motivo_Perm" m WHERE m."idTipoPermiso" = "TipoPermiso"."idTipoPermiso");
DELETE FROM public."Horario"         WHERE "idHorario"  BETWEEN 9101 AND 9112
  AND NOT EXISTS (SELECT 1 FROM public."Empleado" e WHERE e."idHorario" = "Horario"."idHorario")
  AND NOT EXISTS (SELECT 1 FROM public."HorarioTemporal" h WHERE h."HorarioAsignado" = "Horario"."idHorario")
  AND NOT EXISTS (SELECT 1 FROM public."Asistencia" a WHERE a."idHorario" = "Horario"."idHorario");
DELETE FROM public."EstructOrganiz"  WHERE "idAreaOrganiz" BETWEEN 9101 AND 9112;

-- 1.1. Tipos de documento (CR-020): solo si el catálogo no los tiene.
INSERT INTO public."TipoDocID" ("TipoDocID", "Descripcion")
SELECT (SELECT COALESCE(MAX("TipoDocID"), 0) FROM public."TipoDocID") + row_number() OVER (ORDER BY n.orden), n.descripcion
FROM (VALUES (1, 'DNI'), (2, 'Carné de extranjería'), (3, 'Pasaporte')) AS n(orden, descripcion)
WHERE NOT EXISTS (SELECT 1 FROM public."TipoDocID" t WHERE upper(btrim(t."Descripcion")) = upper(n.descripcion));

-- 2. Áreas.
INSERT INTO public."EstructOrganiz" ("Year", "idAreaOrganiz", "AreaOrganizacional", "Abrev", "Sigla") VALUES
  (2026, 9101, 'Recursos Humanos', 'RRHH', 'RRHH'),
  (2026, 9102, 'Sistemas', 'SIS', 'SIS'),
  (2026, 9103, 'Administración', 'ADM', 'ADM'),
  (2026, 9104, 'Logística', 'LOG', 'LOG');

-- 3. Horarios (catálogo TEC-001).
INSERT INTO public."Horario" ("idHorario", "Descrip_Horario", "Ingreso1", "Salida1", "Ingreso2", "Salida2", "Estado", "SgtDia")
SELECT * FROM (VALUES
  (9101, 'Administrativo 08-17', '08:00', '13:00', '14:00', '17:00', true, false),
  (9102, 'Mañana 07:00-15:00', '07:00', '15:00', NULL, NULL, true, false),
  (9103, 'Tarde 13:00-21:00', '13:00', '21:00', NULL, NULL, true, false)
) AS h(id, d, i1, s1, i2, s2, e, sd)
WHERE NOT EXISTS (SELECT 1 FROM public."Horario" x WHERE x."idHorario" = h.id);

-- 4. Personas y empleados ficticios.
INSERT INTO public."Persona" ("IdPersona", "Nombres", "Apellido_Paterno", "Apellido_Materno", "NumDocID", "FechaRegistro") VALUES
  (9101, 'Lucía',  'Paredes',   'Quispe',   'DEMO-9101', '2026-11-20'),
  (9102, 'Diego',  'Huamán',    'Torres',   'DEMO-9102', '2026-11-20'),
  (9103, 'Carla',  'Rojas',     'Mendoza',  'DEMO-9103', '2026-11-20'),
  (9104, 'Miguel', 'Chávez',    'Salazar',  'DEMO-9104', '2026-11-20'),
  (9105, 'Ana',    'Flores',    'Castillo', 'DEMO-9105', '2026-11-20'),
  (9106, 'Jorge',  'Vargas',    'Ríos',     'DEMO-9106', '2026-11-20'),
  (9107, 'Rosa',   'Mendoza',   'Silva',    'DEMO-9107', '2026-11-20'),
  (9108, 'Luis',   'Gutiérrez', 'Ramos',    'DEMO-9108', '2026-11-20'),
  (9109, 'Sofía',  'Castro',    'Díaz',     'DEMO-9109', '2026-11-20'),
  (9110, 'Pedro',  'Ramírez',   'Vega',     'DEMO-9110', '2026-11-20'),
  (9111, 'Elena',  'Torres',    'León',     'DEMO-9111', '2026-11-20'),
  (9112, 'Raúl',   'Salinas',   'Poma',     'DEMO-9112', '2026-11-20');

-- Estado '1' = activo (regla heredada de RRHHClass.buscar_empleado). 9112 cesó en 2010: sirve para la consulta desde 2008.
INSERT INTO public."Empleado" ("IdEmpleado", "Year", "idAreaOrganiz", "IdPersona", "FechaIngreso", "Estado", "idHorario", "Profesion") VALUES
  (9101, 2026, 9101, 9101, '2019-04-01', '1', 9101, 'Administradora'),
  (9102, 2026, 9102, 9102, '2021-08-16', '1', 9101, 'Ingeniero de sistemas'),
  (9103, 2026, 9102, 9103, '2023-02-01', '1', 9101, 'Analista de datos'),
  (9104, 2026, 9103, 9104, '2020-01-15', '1', 9101, 'Contador'),
  (9105, 2026, 9101, 9105, '2018-06-04', '1', 9101, 'Psicóloga'),
  (9106, 2026, 9103, 9106, '2022-09-01', '1', 9101, 'Economista'),
  (9107, 2026, 9104, 9107, '2024-03-01', '1', 9102, 'Técnica en logística'),
  (9108, 2026, 9104, 9108, '2025-01-06', '1', 9102, 'Almacenero'),
  (9109, 2026, 9102, 9109, '2024-10-01', '1', 9101, 'Desarrolladora'),
  (9110, 2026, 9101, 9110, '2025-07-01', '1', 9101, 'Asistente administrativo'),
  (9111, 2026, 9103, 9111, '2016-11-02', '1', 9101, 'Abogada'),
  (9112, 2010, 9103, 9112, '2006-05-02', '0', 9101, 'Técnico administrativo');

UPDATE public."Persona" SET "TipoPersona" = 'N',
  "TipoDocID" = (SELECT "TipoDocID" FROM public."TipoDocID" WHERE upper(btrim("Descripcion")) = 'DNI' ORDER BY 1 LIMIT 1)
WHERE "IdPersona" BETWEEN 9101 AND 9112;

INSERT INTO public."Empleado_Area" ("Year", "idAreaOrganiz", "IdEmpleado")
SELECT "Year", "idAreaOrganiz", "IdEmpleado" FROM public."Empleado" WHERE "IdEmpleado" BETWEEN 9101 AND 9112;

-- 5. Turnos por periodo (RF-01) con histórico (RF-02).
INSERT INTO public."HorarioTemporal" ("idEmpleado", "N", "FechaInicio", "FechaFin", "HorarioAsignado", "NroDocumento", "Sisgedo", "FechaRegistro") VALUES
  (9101, 1, '2026-01-01', '2026-06-30', 9101, 'MEMO-DEMO-001', 'SG-DEMO-001', '2025-12-20'),
  (9101, 2, '2026-07-01', '2026-12-31', 9102, 'MEMO-DEMO-014', 'SG-DEMO-014', '2026-06-25'),
  (9104, 1, '2026-11-01', '2026-11-30', 9103, 'MEMO-DEMO-031', 'SG-DEMO-031', '2026-10-28'),
  (9107, 1, '2026-10-01', '2026-12-31', 9102, 'MEMO-DEMO-027', 'SG-DEMO-027', '2026-09-25'),
  (9109, 1, '2026-12-01', '2027-02-28', 9103, 'MEMO-DEMO-040', 'SG-DEMO-040', '2026-11-18');

-- 6. Tipos y motivos de permiso (RF-04, RF-05, RF-06, RF-10).
INSERT INTO public."TipoPermiso" ("idTipoPermiso", "DescripTipoPermiso")
SELECT * FROM (VALUES (9101, 'Licencias'), (9102, 'Permisos'), (9103, 'Vacaciones')) AS t(id, d)
WHERE NOT EXISTS (SELECT 1 FROM public."TipoPermiso" x WHERE x."idTipoPermiso" = t.id);

INSERT INTO public."Motivo_Perm" ("idMotivo", "Descrip_Motivo", "Abrev", "Salario", "idTipoPermiso", "TipoModalidad", "Activo",
                                  "UnaVezPorAnio", "GrupoReglaAnual", "EsVacacionesPiloto")
SELECT * FROM (VALUES
  (9101, 'Vacaciones',                          'VAC', true,  9103, 'P', true, false, NULL,       true),
  (9102, 'Licencia por enfermedad',             'ENF', true,  9101, 'P', true, false, NULL,       false),
  (9103, 'Licencia por familiar grave (anual)', 'FAM', true,  9101, 'P', true, true,  'FAMILIAR', false),
  (9104, 'Comisión de servicio',                'COM', true,  9102, 'P', true, false, NULL,       false),
  (9105, 'Permiso personal',                    'PER', false, 9102, 'P', true, false, NULL,       false),
  (9106, 'Capacitación',                        'CAP', true,  9102, 'P', true, false, NULL,       false)
) AS m(id, d, a, s, t, mo, ac, anual, grupo, vac)
WHERE NOT EXISTS (SELECT 1 FROM public."Motivo_Perm" x WHERE x."idMotivo" = m.id);

-- 7. Permisos, licencias y vacaciones (RF-03, RF-06, RF-08, RF-10, RF-18). Sin solapamientos por empleado.
INSERT INTO public."Permiso" ("IdEmpleado", "NPermiso", "FechaInicio", "FechaFin", "Dia", "Retorno", "idMotivo", "Lugar",
                              "Referencia", "Autorizacion", "Obs", "EstadoSolicitud", "MediaJornadaVacaciones") VALUES
  (9101, 1, '2026-02-09', '2026-02-13', true, false, 9101, NULL, 'DEMO', 'Jefatura RRHH', 'Dato ficticio', 'Aprobado', false),
  (9101, 2, '2026-12-28', '2026-12-31', true, false, 9101, NULL, 'DEMO', 'Jefatura RRHH', 'Vacaciones programadas', 'Aprobado', false),
  (9103, 1, '2026-11-13', '2026-11-13', true, false, 9101, NULL, 'DEMO', 'Jefatura SIS',  'Media jornada (RF-10)', 'Aprobado', true),
  (9104, 1, '2026-11-10', '2026-11-12', true, false, 9102, NULL, 'DEMO', 'Certificado médico', 'Dato ficticio', 'Aprobado', false),
  (9105, 1, '2026-11-16', '2026-11-20', true, false, 9101, NULL, 'DEMO', 'Jefatura RRHH', 'Dato ficticio', 'Aprobado', false),
  (9105, 2, '2026-12-21', '2026-12-24', true, false, 9101, NULL, 'DEMO', 'Jefatura RRHH', 'Reserva futura aprobada', 'Aprobado', false),
  (9106, 1, '2026-03-09', '2026-03-11', true, false, 9103, NULL, 'DEMO', 'Jefatura ADM',  'Licencia anual ya usada en 2026 (RF-06)', 'Aprobado', false),
  (9107, 1, '2026-11-18', '2026-11-19', true, false, 9104, 'Sede norte', 'DEMO', 'Jefatura LOG', 'Comisión ficticia', 'Aprobado', false),
  (9108, 1, '2026-11-05', '2026-11-05', true, false, 9105, NULL, 'DEMO', NULL, 'Anulado por el solicitante', 'Anulado', false),
  (9108, 2, '2026-11-24', '2026-11-24', true, false, 9105, NULL, 'DEMO', NULL, 'Pendiente de aprobación', 'Solicitado', false),
  (9109, 1, '2026-11-25', '2026-11-27', true, false, 9106, 'Lima', 'DEMO', 'Jefatura SIS', 'Curso ficticio', 'Aprobado', false),
  (9111, 1, '2026-02-02', '2026-02-11', true, false, 9101, NULL, 'DEMO', 'Jefatura ADM',  'Dato ficticio', 'Aprobado', false),
  (9111, 2, '2026-11-09', '2026-11-13', true, false, 9101, NULL, 'DEMO', NULL, 'Rechazado por necesidad de servicio', 'Rechazado', false);

-- 8. Teletrabajo (RF-13 a RF-16). Máscara de días: lunes=1, martes=2, miércoles=4, jueves=8, viernes=16; total=31.
INSERT INTO public."Teletrabajo" ("IdEmpleado", "FechaInicio", "FechaFin", "Modalidad", "DiasRemotos", "Autorizacion") VALUES
  (9102, '2026-11-01', '2026-11-30', 'T', 31, 'RES-DEMO-101'),
  (9103, '2026-10-01', '2026-12-31', 'P', 5,  'RES-DEMO-102'),
  (9106, '2026-11-01', '2026-11-30', 'P', 10, 'RES-DEMO-103'),
  (9110, '2026-11-01', '2026-12-31', 'P', 16, 'RES-DEMO-104');

-- 9. Feriados nacionales de 2008 y 2026 (solo si la fecha no existe).
WITH nuevos(fecha, motivo) AS (VALUES
  (DATE '2008-01-01', 'Año Nuevo'), (DATE '2008-03-20', 'Jueves Santo'), (DATE '2008-03-21', 'Viernes Santo'),
  (DATE '2008-05-01', 'Día del Trabajo'), (DATE '2008-06-29', 'San Pedro y San Pablo'), (DATE '2008-07-28', 'Fiestas Patrias'),
  (DATE '2008-07-29', 'Fiestas Patrias'), (DATE '2008-08-30', 'Santa Rosa de Lima'), (DATE '2008-10-08', 'Combate de Angamos'),
  (DATE '2008-11-01', 'Todos los Santos'), (DATE '2008-12-08', 'Inmaculada Concepción'), (DATE '2008-12-25', 'Navidad'),
  (DATE '2026-01-01', 'Año Nuevo'), (DATE '2026-04-02', 'Jueves Santo'), (DATE '2026-04-03', 'Viernes Santo'),
  (DATE '2026-05-01', 'Día del Trabajo'), (DATE '2026-06-29', 'San Pedro y San Pablo'), (DATE '2026-07-28', 'Fiestas Patrias'),
  (DATE '2026-07-29', 'Fiestas Patrias'), (DATE '2026-08-30', 'Santa Rosa de Lima'), (DATE '2026-10-08', 'Combate de Angamos'),
  (DATE '2026-11-01', 'Todos los Santos'), (DATE '2026-12-08', 'Inmaculada Concepción'), (DATE '2026-12-25', 'Navidad')),
faltan AS (
  SELECT n.* FROM nuevos n
  WHERE NOT EXISTS (SELECT 1 FROM public."RRHH_Feriado" f WHERE f."Fecha"::date = n.fecha))
INSERT INTO public."RRHH_Feriado" ("idFeriado", "Fecha", "Motivo")
SELECT (SELECT COALESCE(MAX("idFeriado"), 0) FROM public."RRHH_Feriado") + row_number() OVER (ORDER BY fecha), fecha, motivo
FROM faltan;

-- 10. Marcaciones presenciales (RF-15, RF-17) de lunes a viernes, del 01/10 al 20/11/2026.
--     No marca en feriados, ni en días con permiso aprobado, ni en días de teletrabajo.
INSERT INTO public."Asistencia" ("Fecha", "IdEmpleado", "Hor_Ent", "Alm_Sal", "Alm_Ent", "Hor_Sal", "Flag_Ent", "Flag_Sal",
                                 "Estado", "idHorario", "Usuario", "PC")
SELECT d::timestamp, e."IdEmpleado",
       '08:0' || ((e."IdEmpleado" + EXTRACT(DAY FROM d)::int) % 10), '13:00', '14:00',
       '17:0' || ((e."IdEmpleado" * 3 + EXTRACT(DAY FROM d)::int) % 10), true, true, true, 9101, 'DEMO', 'DEMO'
FROM public."Empleado" e
CROSS JOIN generate_series(DATE '2026-10-01', DATE '2026-11-20', INTERVAL '1 day') AS d
WHERE e."IdEmpleado" BETWEEN 9101 AND 9111
  AND EXTRACT(ISODOW FROM d) BETWEEN 1 AND 5
  AND NOT EXISTS (SELECT 1 FROM public."RRHH_Feriado" f WHERE f."Fecha"::date = d::date)
  AND NOT EXISTS (SELECT 1 FROM public."Permiso" p WHERE p."IdEmpleado" = e."IdEmpleado" AND p."EstadoSolicitud" = 'Aprobado'
                  AND d::date BETWEEN p."FechaInicio"::date AND p."FechaFin"::date)
  AND NOT EXISTS (SELECT 1 FROM public."Teletrabajo" t WHERE t."IdEmpleado" = e."IdEmpleado" AND t."Estado"
                  AND d::date BETWEEN t."FechaInicio" AND t."FechaFin"
                  AND (t."Modalidad" = 'T' OR (t."DiasRemotos" & (1 << (EXTRACT(ISODOW FROM d)::int - 1))) <> 0));

-- Inconsistencia a propósito para RF-15: 9107 marcó presencia el 18/11 aunque estaba en comisión.
INSERT INTO public."Asistencia" ("Fecha", "IdEmpleado", "Hor_Ent", "Hor_Sal", "Flag_Ent", "Flag_Sal", "Estado", "idHorario", "Usuario", "PC")
VALUES ('2026-11-18', 9107, '08:12', '12:30', true, true, true, 9102, 'DEMO', 'DEMO');

-- 11. Consulta histórica desde 2008 (RF-17): Raúl Salinas, febrero y marzo de 2008.
INSERT INTO public."Asistencia" ("Fecha", "IdEmpleado", "Hor_Ent", "Hor_Sal", "Flag_Ent", "Flag_Sal", "Estado", "idHorario", "Usuario", "PC")
SELECT d::timestamp, 9112, '08:0' || (EXTRACT(DAY FROM d)::int % 10), '17:00', true, true, true, 9101, 'DEMO', 'DEMO'
FROM generate_series(DATE '2008-02-04', DATE '2008-03-31', INTERVAL '1 day') AS d
WHERE EXTRACT(ISODOW FROM d) BETWEEN 1 AND 5
  AND NOT EXISTS (SELECT 1 FROM public."RRHH_Feriado" f WHERE f."Fecha"::date = d::date);

COMMIT;
