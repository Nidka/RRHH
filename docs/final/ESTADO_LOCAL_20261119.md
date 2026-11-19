# Estado local del piloto — 19/11/2026

Línea base de esta continuación: main `3eb62af`. Primer incremento
`f496a90`, PR [#57](https://github.com/Nidka/RRHH/pull/57), sin merge por
el asistente. El adaptador web se revisa en otra rama dependiente:
`codex/rf-03-permisos-web`. Este documento describe la continuación local,
no un despliegue nuevo ni una certificación de todos los RF.

## Cobertura y pendientes

| RF | Escritorio | Web |
|---|---|---|
| RF-01 / RF-02 | Implementación de horarios existente | Alta/edición e histórico existentes; regresión HTTP correcta |
| RF-03 | Guardado transaccional nuevo y consultas por estado; falta recorrido visual y gestión explícita de estados en UI | Alta, carga, edición y cuatro estados; smoke y recorrido local correctos para permisos del piloto. Salidas por horas pendientes |
| RF-04 / RF-05 | Catálogo de motivos existente | Alta/baja existentes; regresión HTTP correcta |
| RF-06 | Guardado transaccional nuevo comprueba motivo/grupo anual; despliegue y configuración reales pendientes | Reutiliza la misma regla y transacción; segundo motivo del grupo rechazado en QA local |
| RF-07 | Consulta de días generados existente | Consulta de días generados existente, ejemplo 60 días comprobado |
| RF-08 | Pendiente saldo conciliado con consumos aprobados y anulaciones | Pendiente |
| RF-09 | Pendiente truncas con ejemplo de cese inclusivo | Pendiente |
| RF-10 | Pendiente consumo de media jornada y control de saldo | Pendiente |
| RF-11 | Pendiente reporte conciliado por año, área y empleado | Pendiente |
| RF-12 | Pendiente autoservicio con vínculo usuario-empleado y aislamiento entre cuentas | Pendiente |
| RF-13 / RF-14 / RF-16 | Teletrabajo existente | Registro/consulta, días y clasificación existentes; regresión HTTP correcta |
| RF-15 | Pendiente consolidación diaria de ausencia, presencial, remoto y sin registro | Pendiente |
| RF-17 | Total y detalle existentes, sin duplicar fechas | Total/detalle y Productividad comprobados en regresión HTTP |
| RF-18 | Reporte de ausencias existente | Reporte existente con roles y filtros comprobados en regresión HTTP |

“Existente” describe cobertura de código; no sustituye aceptación funcional
completa ni acredita un recorrido visual nuevo de todos los módulos.

## Evidencia ejecutada en esta continuación

- PostgreSQL 18 local con datos ficticios; 362/362 pruebas net48 aprobadas,
  ninguna omitida. Conflictos concurrentes por fechas y por grupo anual.
- Host web net8: 0 errores y 0 advertencias. Regresión HTTP de sesión, roles,
  CSRF, teletrabajo, ausencias, horarios, motivos, asistencia, días generados
  y permisos con estados.
- WinForms net48 x86: build completo, 0 errores y 26 advertencias heredadas.
- Navegador local: login, alta, rechazo de solapamiento, carga y anulación.
  No se capturaron imágenes de este recorrido ni se probó un reloj físico.

Detalles: [evidencia del guardado](../../qa/RF-03-ESTADOS-RESULTADOS.md),
[QA web](../../Software/RRHH.Web/qa/RESULTADOS.md) y
[spec del adaptador](../../specs/CR-003-permisos-web.md).

## Orden de continuación

1. Completar gestión de estados en la UI de escritorio y el caso de salidas
   por horas en web, con sus pruebas de marcación y autorización.
2. Implementar conjuntamente RF-08/RF-10: consumo decimal, saldo insuficiente,
   aprobación/anulación y transacciones sin doble descuento.
3. Añadir RF-09, RF-11 y RF-12 reutilizando ese saldo conciliado. Probar dos
   cuentas de empleado que no puedan consultar consumos ajenos.
4. RF-15 con prioridad ausencia aprobada > presencial > remoto > sin registro;
   mostrar inconsistencia cuando coincidan fuentes sin contar dos veces el día.
5. Recorrido visual de ambas aplicaciones y matriz de aceptación de los 18 RF.
6. Revisar documentación y proponer `v1.6.0-beta.1` solo cuando su alcance y
   verificaciones estén cerrados; no se creó tag ni release en esta continuación.

El usuario indicó trabajar solo localmente por ahora. Por tanto, no se aplican
migraciones ni saneamiento en la base compartida, ni se activan motivos reales.
El despliegue futuro se coordina con Kadin y requiere el destino revisado.
La versión móvil permanece fuera de este avance. Los merges corresponden al grupo.
