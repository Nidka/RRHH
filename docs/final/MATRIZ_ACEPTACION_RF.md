# Matriz de aceptación de RRHH

Corte de código validado en main: 0be0ee6 (PR #67 a #70). PostgreSQL 18 local con datos ficticios.
El registro distingue recorridos de pantalla y regresión automatizada.
Los casos sin recorrido visual nuevo y las verificaciones de entorno compartido quedan por confirmar.

| RF | Caso de aceptación | Escritorio | Web |
|---|---|---|---|
| RF-01 | Guardar horario por periodo para empleado con historial anual | Regresión SQL del repositorio | Smoke HTTP de horarios |
| RF-02 | Consultar histórico por empleado y controlar encabezados ambiguos | Regresión SQL del repositorio | Smoke HTTP de histórico |
| RF-03 | Impedir solapamientos bloqueantes y salida inválida; anular permiso | Pantalla de permisos y regresión SQL; reloj físico pendiente | Smoke HTTP de estados y salida |
| RF-04 | Crear motivo válido | Alta QAT observada en catálogo | Smoke HTTP del catálogo |
| RF-05 | Dar de baja un motivo | QAT eliminado y catálogo actualizado | Smoke HTTP del catálogo |
| RF-06 | Rechazar segunda licencia anual de un mismo grupo | Regresión SQL local | Smoke HTTP local |
| RF-07 | Generar 60 días por dos aniversarios | Pantalla de saldo | Smoke HTTP |
| RF-08 | Obtener 47,5 pendientes tras consumir 12,5 | Pantalla de saldo | Pantalla y smoke HTTP |
| RF-09 | Obtener 21,00 días en el ejemplo de cese | Pantalla de truncas | Pantalla y smoke HTTP |
| RF-10 | Descontar 0,5 y devolverlo al anular; rechazar saldo insuficiente | Pantalla de edición y regresión SQL | Smoke HTTP y comprobación cruzada |
| RF-11 | Filtrar por año, área y empleado | Pantalla del reporte | Pantalla y smoke HTTP |
| RF-12 | Consultar solo los datos vinculados a una cuenta activa | Pantalla de empleado_a y prueba SQL con dos identidades | Pantalla con dos cuentas y smoke HTTP |
| RF-13 | Registrar periodo y rechazar solapamiento | Regresión SQL; alta y consulta visual del periodo 2 | Smoke HTTP |
| RF-14 | Consultar periodos y días computados | Reporte visual: un día remoto para 101 y 102 el 20/11/2026 | Smoke HTTP |
| RF-15 | Contar una sola categoría y señalar fuentes en conflicto | Pantalla del consolidado | Pantalla y smoke HTTP |
| RF-16 | Distinguir teletrabajo total y parcial según patrón | WinForms: Parcial en noviembre y Total el 20/11/2026, con 1 de 1 día remoto para 101 y 102 | Smoke HTTP |
| RF-17 | Contar la fecha una sola vez y comprobar Productividad | Pantalla nueva, casos A=4 y P=3 | Smoke HTTP |
| RF-18 | Consultar ausencias con los filtros y roles admitidos | Pantalla y filtro verificados antes del PR #70; el repositorio compartido ya excluye anulados | Smoke HTTP en 0be0ee6: excluye anulados con y sin filtro y conserva historial |

[Evidencias de pantalla](../../qa/evidencias/20261119-final/) ·
[Registro de RF-12](../../qa/evidencias/20261119-final/RF12-VERIFICACION.md) ·
[Especificación y alcance](../../specs/CR-QA-018-aceptacion-local.md)

[Capturas de WinForms del 20/11](../../qa/evidencias/20261120-winforms/).
