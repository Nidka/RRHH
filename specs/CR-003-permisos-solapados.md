# CR-003: validar conflictos de permisos

- Estado: Implementado en la rama `fix/rf-03-permisos-solapados` (T3); en pruebas: faltan QA en la aplicación con datos ficticios, la prueba contra PostgreSQL local y la revisión de Jorge. Ver «Implementación T3 y ficha del RF».
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


## Implementación T3 y ficha del RF

### Comportamiento heredado observado (lectura de código, sin ejecutar el original)

- `RRHHClass.ExistePermiso(idEmpleado, "yyyyMMdd", "yyyyMMdd")` (línea ~282) cuenta los permisos del empleado en los que `FechaInicio` o `FechaFin` del rango nuevo caen entre `FechaInicio` y `FechaFin` de uno existente. Con existente 10–12 y nuevo 9–13 devuelve 0: **el rango nuevo que contiene a uno existente se acepta**. Las fechas viajan como texto `yyyyMMdd` armado en el formulario.
- `FrmPermiso.cs` (guard en `BtnGrabar`, ~línea 1538) lo invoca **solo cuando `Npermiso == 0` (alta)**; al editar no se valida. Mensaje: «El Empleado se Encuentra de Permiso, No se puede agregar Otro Permiso». Después escribe con `PermisoMapper` (legado) y `SgtIdPermiso`.
- `FrmMarcacionesAutorizadas.cs` (~línea 1177) usa el mismo guard con **un solo día** (`DEFecha`, inicio = fin). Para un rango de un día la condición heredada sí es correcta (el día nuevo cae o no dentro del existente), por lo que no tiene el defecto de contención.

### Decisiones

| Tema | Decisión |
|---|---|
| Regla | Dos permisos del mismo empleado se solapan si comparten al menos un día: `inicioExistente <= finNuevo && finExistente >= inicioNuevo` (`RangoFechas.Solapa`). |
| Hipótesis: día completo | Se compara por día calendario completo; un permiso por horas también ocupa el día. No se implementa excepción por franja horaria. |
| Hipótesis: anulados | `public."Permiso"` no tiene columna de anulación ni estado (`Autorizado` es otra cosa): todo permiso registrado cuenta. |
| Hipótesis: fechas nulas | Un permiso con `FechaInicio` o `FechaFin` nula no se compara (igual que la consulta original). |
| Edición | `FrmPermiso` valida también al editar, excluyendo el propio `NPermiso`. Riesgo: un permiso histórico que ya choca con otro ahora no podrá guardarse ni para cambiar solo observaciones hasta corregir las fechas. |
| `FrmMarcacionesAutorizadas` | **No se migra en este PR**: es un día y el guard heredado es correcto para ese caso. Queda pendiente retirarlo cuando se migre el formulario. |
| `FrmPermiso` completo | Fuera de alcance de T3. Solo se reemplazó el guard; la escritura sigue en `PermisoMapper`. |
| Concurrencia | **No resuelta por este cambio.** La validación y el `Insert` del mapper son dos operaciones separadas (la escritura es heredada), así que dos solicitudes simultáneas pueden pasar la comprobación a la vez. Un bloqueo advisory dentro de la validación no ayudaría porque no cubre la escritura. Opciones a evaluar con Kadin: (a) migrar la escritura de permisos a un repositorio y comprobar + insertar en una transacción con `pg_advisory_xact_lock(idEmpleado)`, o (b) una restricción de exclusión (`EXCLUDE USING gist` con `btree_gist` sobre `IdEmpleado` y `daterange(FechaInicio::date, FechaFin::date, '[]')`), que exige antes sanear los solapamientos que ya existan en los datos. Decisión pendiente. |

### Capas

| Capa/archivo | Cambio |
|---|---|
| `RRHH.Application/Permisos/IPermisoRepository.cs` | `ExisteSolapamiento(idEmpleado, RangoFechas, excluirNPermiso)`; 0 = alta. |
| `RRHH.Application/Permisos/ValidarPermisoSinSolapamiento.cs` | Caso de uso: valida el rango (`RangoFechas.Crear`) y consulta el repositorio; devuelve `ResultadoOperacion` con mensaje. |
| `RRHH.PostgreSql/Permisos/PostgreSqlPermisoRepository.cs` | SQL parametrizado con fechas tipadas (`DbType.Date`); reemplaza `RRHHClass.ExistePermiso`. |
| `RecursosHumanos/CompositionRoot.cs` | `CrearValidarPermiso()`. |
| `RecursosHumanos/FrmPermiso.cs` | El guard heredado se sustituye por `CompositionRoot.CrearValidarPermiso().Ejecutar(...)`, en alta y en edición. |
| Dependencia | Usa `RangoFechas` de la rama `feature/base-calendario-laboral` (aún sin integrar en `main`); esta rama parte de ella. |

### Ficha del RF

| Campo | Valor |
|---|---|
| Código | RF-03 |
| Descripción | No permitir dos permisos el mismo día para una persona |
| Módulo | Permisos |
| Pantalla / clase | `FrmPermiso` (guard), `ValidarPermisoSinSolapamiento`, `PostgreSqlPermisoRepository` |
| Regla aplicada | Solapamiento inclusivo por día calendario; ver «Decisiones» |
| Evidencia | `dotnet test`: 196 correctas, 0 con error, 28 omitidas (integración PostgreSQL); `build.cmd`: 0 errores. QA en la aplicación: **pendiente** |
| Estado | En pruebas |
| Commits | Ver `git log fix/rf-03-permisos-solapados` (pie `Refs: RF-03, CR-003`) |
| Casos de prueba | CP-03-01 a CP-03-10 en `docs/t3/casos_prueba/frank.csv` |

### Verificación pendiente

- Probar `PostgreSqlPermisoRepository.ExisteSolapamiento` contra una BD local desechable con datos ficticios (el SQL no está cubierto por ninguna prueba ejecutada).
- Ejecutar los casos en `FrmPermiso` con datos ficticios y guardar capturas en `docs/t3/evidencias/RF-03/`.
- Reproducir el defecto original (existente 10–12, nuevo 9–13) en la versión anterior para tener evidencia antes/después.