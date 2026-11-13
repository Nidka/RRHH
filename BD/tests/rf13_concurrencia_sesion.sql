-- CP-13-09: dos altas simultáneas del mismo empleado sobre public."Teletrabajo" (RF-13).
-- Reproduce la secuencia de PostgreSqlTeletrabajoRepository.Registrar: bloqueo de Empleado, comprobación
-- de existencia, bloqueo de Teletrabajo, comprobación de solapamiento y alta, todo en una transacción.
-- BD local desechable con public."Teletrabajo" creada por 20261112_03_teletrabajo.sql y una tabla
-- public."Empleado" mínima con el empleado ficticio 101. Ejecutar en DOS sesiones casi a la vez:
--   sesión A: psql -d <bd> -v SESION=A -v espera=3 -f BD/tests/rf13_concurrencia_sesion.sql
--   sesión B (1 s después): psql -d <bd> -v SESION=B -v espera=0 -f BD/tests/rf13_concurrencia_sesion.sql
-- Resultado esperado: A queda CONFIRMADA, B queda RECHAZADA y la tabla termina con una sola fila.
BEGIN;
LOCK TABLE public."Empleado" IN SHARE MODE;
SELECT COUNT(*) FROM public."Empleado" WHERE "IdEmpleado" = 101 \gset emp_
LOCK TABLE public."Teletrabajo" IN SHARE ROW EXCLUSIVE MODE;
SELECT COUNT(*) AS solapados FROM public."Teletrabajo"
 WHERE "IdEmpleado" = 101 AND "Estado" AND "FechaInicio" <= '2026-11-12' AND "FechaFin" >= '2026-11-10' \gset
\if :solapados
  \echo :SESION ': RECHAZADA (solapamiento detectado bajo el bloqueo)'
  ROLLBACK;
\else
  SELECT pg_sleep(:espera);
  INSERT INTO public."Teletrabajo" ("IdEmpleado","FechaInicio","FechaFin","Modalidad","DiasRemotos")
  VALUES (101,'2026-11-10','2026-11-12','T',31);
  \echo :SESION ': CONFIRMADA'
  COMMIT;
\endif
