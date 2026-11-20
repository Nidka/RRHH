# CR-QA-018: aceptación local de los 18 RF y cierre de evidencia

- Línea base de consolidación: `b2150ca`, sobre PR #60 a #66.
- Responsable: Jorge Enrique Cano Asto. Revisión ajena pendiente.
- Destino: PostgreSQL 18 local desechable; sin base compartida ni reloj físico.

## Diagnóstico durante aceptación y correcciones

| Hallazgo real de revisión | Cambio y razón | Comprobación |
|---|---|---|
| Un motivo inactivo impedía anular un permiso histórico y devolver saldo | PermisoEscritura permite retirar el histórico sin cambiar su motivo; sigue prohibiendo nuevas altas con motivo inactivo | SQL RF08MotivoInactivoNoImpideDevolverSaldoDelHistorico |
| Empleado tiene clave IdEmpleado/Year; contar filas bloqueaba un empleado con historial anual | HorarioTemporal y Teletrabajo comprueban existencia del ID; encabezado de horario toma el año más reciente y rechaza duplicados de ese año | SQL RF01YRF13AceptanHistorialAnualSinElegirEncabezadoAmbiguo |
| RF-17 solo estaba expuesto dentro del reporte heredado de escritorio | Vista pasiva adicional con el caso RF-17 compartido, sin modificar su cálculo | UI A=4 y P=3 del 09 al 15/11/2026; marcaciones en feriado/sábado visibles |
| Demo anterior no preparaba datos de vacaciones ni cuentas de empleado | -Demo integrado y -Escritorio opcional con conexiones y roles limitados al proceso; contraseña opcional solo para demo | Ejecución real de demos y recorridos documentados |

Mantenimiento principal correctivo en los dos primeros casos; capacidad
perfectiva de presentación en RF-17. No se declara refactorización pura.
Se preservan Domain/Application/Presentation sin dependencias de interfaz o
Npgsql, MVP y composición existentes. El ajuste de consultas no sanea datos
reales ni reemplaza TEC-002. Sin nueva arquitectura ni aprobación humana simulada.

## Evidencia ejecutada

- 390/390 pruebas net48, sin omisiones, con SQL real en clúster local ficticio.
- Smoke HTTP de los flujos operativos y RF-08 a RF-12/RF-15/salidas.
- Build web net8: 0 errores/0 advertencias. WinForms net48 x86 completo:
  0 errores/26 advertencias heredadas.
- UI WinForms: saldo 60/12,5/47,5; truncas 21,00 al 12/11; reporte filtrado;
  aprobación y anulación de media jornada; consolidado; A=4/P=3 en RF-17.
- Comprobación cruzada: guardar media jornada en WinForms se refleja en web
  como 13 usadas/47 pendientes; anular restaura 12,5/47,5.
- UI web: saldo, reporte y truncas, consolidado con prioridad y dos cuentas
  de autoconsulta que reciben datos propios. Sesiones cerradas tras el recorrido.
- Autoconsulta WinForms: empleado_a abrió su vista propia y consultó al empleado 101 (60 generadas, 12,5 usadas, 47,5 pendientes). Sin selector de empleado ni menús operativos. La tabla permaneció en solo lectura. Ver [registro RF-12](../qa/evidencias/20261119-final/RF12-VERIFICACION.md).

Capturas reales ficticias en [evidencias](../qa/evidencias/20261119-final/).
La entrada de credenciales nativa fue realizada por el usuario. No se guardan
credenciales reales ni capturas de contraseñas en los entregables.

## Reversión, revisión y límites

### Ajuste de arranque tras la comprobación visual de RF-12

La comprobación no produjo la pantalla propia y la cabecera no permitía
distinguir qué login estaba conectado (las cuentas ficticias comparten nombre
de persona). No se atribuye esa observación a una credencial concreta.
Se retira la selección de host mediante Hide/ShowDialog dentro de MainMDI.Load:
el login se resuelve en OnStartup y OnCreateMainForm elige la ventana propia
o la instancia MDI existente. Se conserva el registro de instancia MyProject
para no romper los formularios heredados. El login se mostrará en la cabecera.
La demo puede arrancar en modo de empleado exclusivo, rechazando cuentas de
operador con un mensaje claro, sin introducir credenciales automáticamente.

Referencias de ciclo de vida: [OnStartup](https://learn.microsoft.com/en-us/dotnet/api/microsoft.visualbasic.applicationservices.windowsformsapplicationbase.onstartup)
y [OnCreateMainForm](https://learn.microsoft.com/en-us/dotnet/api/microsoft.visualbasic.applicationservices.windowsformsapplicationbase.oncreatemainform).
Se repitieron el build, la regresión y el acceso nativo de empleado con datos ficticios. La evidencia está enlazada arriba.

Revertir commits de esta rama antes que las dependencias; conservar esquema
y datos fraccionarios hasta aplicar los rollbacks protegidos con respaldo.
El usuario revisa los PR y decide los merges. Publicación, aprobación del área,
configuración de motivos/roles reales, saneamiento y despliegue compartido
permanecen separados de la aceptación local. No se publica una versión ni tag.
Asistencia material de IA en implementación, pruebas, recorrido y documentos;
revisión humana ajena pendiente.
