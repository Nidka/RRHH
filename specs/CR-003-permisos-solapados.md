# CR-003: validar conflictos de permisos

- Estado: En análisis para T2; implementación propuesta para T3, sin iniciar.
- RF: RF-03. Tareas: T2-02, T2-05 y T2-06.
- Responsable: Frank Piero Mantilla Arqueros. Revisor: Jorge Enrique Cano Asto.
- Base: `0a4b6a8`; no se ejecutó el original en esta revisión.
- Evidencias funcionales y PR: pendientes.

> Actualización: `eeeb817` incorpora un mapper PostgreSQL local. La inferencia anterior sobre motores distintos requiere revalidación; el ejemplo de solapamiento también debe contrastarse con el código actual antes de implementar. Ver [primera prueba](../docs/t2/PRIMERA_PRUEBA.md).

## Hallazgo estático

`Software/ClassRRHH/ClassRRHH/RRHHClass.cs`, método `ExistePermiso`, cuenta permisos si un extremo del intervalo nuevo está dentro del existente. Si el existente abarca del 10 al 12 y el nuevo del 9 al 13, ninguno de los extremos nuevos queda dentro: la condición no representa todos los solapamientos.

`Software/RecursosHumanos/RecursosHumanos/FrmPermiso.cs` utiliza esa consulta y escribe con `PermisoMapper`. La infraestructura del mapper pertenece al legado SQL Server. Contrastar ambos caminos en ejecución antes de atribuir el defecto al ejecutable recibido.

## Regla por confirmar

El RF pide impedir dos permisos el mismo día para una persona. Confirmar si se aplica al día calendario completo, a intervalos horarios, a permisos anulados y a la edición del propio permiso. No implementar una excepción por franja horaria sin validar el requisito.

Para fechas inclusivas, el solapamiento se expresa como `inicioNuevo <= finExistente && finNuevo >= inicioExistente`. Esta expresión es una propuesta técnica; falta resolver estado, exclusión del propio registro y concurrencia.

## Aceptación propuesta

- Si un permiso válido ocupa un día, el segundo registro para la misma persona en ese día se rechaza según la regla confirmada.
- Detectar igualdad, solapamiento parcial y contención en ambos sentidos.
- Un permiso de otra persona no bloquea; los rangos inválidos producen un mensaje claro.
- Editar el propio permiso no genera un conflicto consigo mismo.
- Dos solicitudes concurrentes no pueden dejar un estado contrario a la regla.
- Cada ruta migrada consulta y escribe en PostgreSQL dentro de una estrategia transaccional consistente.

## Plan propuesto

1. Frank reproduce casos en el original con datos ficticios y registra resultados.
2. Jorge y Frank especifican la regla y los contratos según MVP. Kadin revisa datos, restricciones y concurrencia.
3. Extraer regla temporal a Domain, caso de uso y contrato a Application; repositorio a PostgreSql; presenter y contrato a Presentation.
4. Conectar la vista existente mediante CompositionRoot. Retirar el uso legado del flujo completo; no agregar parches a ClassRRHH, congelado por arquitectura.
5. Verificar pruebas de dominio/caso de uso/presenter, compilación Windows y QA de escritura/concurrencia. Documentar diferencias con el original.

## Reversión y límites

Implementar en un PR separado cuando corresponda. Documentar compatibilidad y migración de BD antes de ejecutar cambios de esquema. Conservar referencia del original. Esta spec no autoriza modificar una base desplegada.

## Verificación actual y uso de IA

Hallazgo obtenido por lectura de código con asistencia de IA. Los casos de ejecución, la corrección, compilación, pruebas automatizadas y QA de esta propuesta están pendientes. La spec debe ser revisada por sus responsables antes de marcarla lista para implementar.
