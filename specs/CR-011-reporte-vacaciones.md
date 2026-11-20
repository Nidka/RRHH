# CR-011: reporte conciliado de vacaciones

- RF-11, depende de RF-08/09/10. Responsable: Jorge Enrique Cano Asto;
  revisión ajena pendiente. Mantenimiento perfectivo, sin cambios de datos.
- Esquema inspeccionado: Empleado se identifica por IdEmpleado y Year;
  el área se toma de la fila del año seleccionado, sin elegir entre duplicados.

## Diseño previo

Filtros año, área opcional y empleado opcional; corte explícito dentro del año.
Saldos acumulados (no solo consumos del año) para conservar arrastre. Truncas
simuladas al corte, claramente distintas del cese real no acreditado.
Se reutiliza la fuente RF-08 dentro de una transacción REPEATABLE READ READ
ONLY para que todos los empleados procedan de una misma instantánea.
No se ejecuta una consulta por empleado fuera de esa transacción.

Application usa contrato de reporte y régimen puro; Repository PostgreSQL;
MVP en escritorio y política Vacaciones en web. Un empleado con datos
incompletos conserva una fila con diagnóstico y cifras nulas, no saldo cero.
Límite 1000 empleados por consulta, con error para refinar filtros.

Aceptación: ejemplo 60/12,5/47,5/21,00; mismo resultado que historial;
filtros independientes/combinados; dato incompleto visible; año/corte
incoherentes rechazados; rol no autorizado sin acceso.

Pruebas locales SQL/HTTP y build completo; reversión retira consultas y UI,
sin borrar datos. Ayuda material de IA, revisión y recorrido visual pendientes.

Ejecutado: 372/372 pruebas net48 sin omisiones, SQL/HTTP de conciliación,
filtros y datos incompletos visibles; 401/403 y corte/año incoherentes.
Build web 0 errores/0 advertencias; WinForms x86 completo 0 errores y 26
advertencias heredadas. Solo PostgreSQL 18 local con datos ficticios.
