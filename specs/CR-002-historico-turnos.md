# CR-002: histórico de horarios por empleado y periodo (RF-02)

- Estado: código preparado localmente; QA Windows y revisión pendientes.
- Responsable: Evelyn Victoria Rodriguez Cardozo; revisor: Francisco Kadin Valera Lizarraga.
- Base: `03ab748` más RF-01 local `5e91030`. Rama dependiente `feature/rf-02-historico-turnos`.
- Fuentes: FrmConsultaHorarioEsp:1014–1093, RRHHClass.llena_HorariosTemporales/eliminarHorarioTemporal, FrmAsignarHorario y DDL HorarioTemporal.

## Caracterización y diagnóstico

La reconstrucción consulta todas las asignaciones de un empleado, ordenadas por inicio descendente, con INNER JOIN a Horario. Sin filtro por fechas. Carga perfil mediante RRHHClass; editar abre por N; baja explícita confirma y elimina; exportación XLS usa grilla y Excel COM. Un horario faltante oculta su asignación por INNER JOIN. El alta temporal inserta otra fila; no se observó que reasignar automáticamente borrase las anteriores. No inventar ese defecto ni un commit de corrección por sobrescritura que no ocurre. Edición y baja deliberadas no constituyen auditoría inmutable.

## Resultado y alcance

Migrar consulta completa y baja explícita a casos/repositorio/presenter, manteniendo nombre, controles y exportación. Añadir «Todos los periodos» (predeterminado) o rango inclusivo de intersección, con ambos extremos requeridos. Conservar filas pasadas/vigentes al crear nuevas; orden por inicio descendente y N descendente. LEFT JOIN al catálogo permite ver periodos cuyo horario ya no existe. Datos sin fechas se muestran al consultar todos, sin inventar vigencia; se excluyen de filtro temporal.

**Hipótesis:** histórico significa asignaciones conservadas, no versiones inmutables de cada edición. Mantener edición y baja explícitas tras selección/confirmación; no borrar ni sobrescribir al reasignar. No modificar horario principal ni informes de asistencia. Reutilizar DTO/catálogo/identificación y repositorio RF-01.

## Diseño y mantenimiento

Principal perfectivo: filtro por periodo e histórico más completo. Preventivo: Extract Class para ConsultarHistoricoHorarios/HistoricoHorariosPresenter; Repository tipado sustituye llena_HorariosTemporales y eliminarHorarioTemporal. Corrección delimitada: no ocultar asignaciones sin catálogo. SRP separa controles/consulta; DIP permite probar errores con falsos; DRY reutiliza RangoFechas y contratos RF-01.

FrmBuscarPersona → CompositionRoot.CrearHistoricoHorarios → FrmConsultaHorarioEsp/IHistoricoHorariosView → HistoricoHorariosPresenter → ConsultarHistoricoHorarios/EliminarAsignacionHorario → IHorarioTemporalRepository/PostgreSqlHorarioTemporalRepository. Editor se abre mediante CrearAsignacionHorario, sin SQL/mappers en la vista. SQL parametrizado; baja por clave única en transacción con bloqueo; no DDL.

## Plan y aceptación

- [x] Tests primero: empleado/rango, contención/extremos, filtro omitido, orden, catálogo faltante, conservación tras nueva alta, consulta sin escrituras.
- [x] Implementar DTO histórico y casos; extender repositorio con listado/baja sin duplicar horario.
- [x] Probar SQL real en fixture local y selección/cancelación/errores del presenter.
- [x] Migrar vista, fábrica y entrada desde personal; conservar exportación.
- [ ] Windows: build.cmd, suite net48 y QA ficticia de pantalla/exportación; revisión de Kadin.

## Riesgos, verificación y reversión

Datos duplicados: preservar lo visible al leer, rechazar mutación de clave ambigua; sin saneamiento automático. Consulta sin asignaciones devuelve lista vacía; error limpia filas para evitar actuar sobre resultados viejos. FechaRegistro no editable; no se modifica al consultar. Riesgo de layout del filtro: requiere Windows. Rollback del commit RF-02 conserva filas y RF-01; no hay migración que revertir. No se accede al servidor compartido.

Codex ayuda materialmente con análisis/código/pruebas/docs; Evelyn verifica y explica. PR y aprobación humana pendientes. Versión propuesta MINOR; CHANGELOG y releases los coordina Kadin.

## Ficha RF

RF-02 / CR-002, asistencia. Pantalla FrmConsultaHorarioEsp; ConsultarHistoricoHorarios. Estado en desarrollo local. Casos CP-02-01…CP-02-07 en evelyn.csv; evidencia local y Windows diferenciadas. Commit/PR se completan con referencias reales, no anticipadas.

## Resultado local

323/323 pruebas net8 correctas con PostgreSQL ficticio local; proyecto real net48 de capas/pruebas compila con cero errores/advertencias. QA Windows pendiente. [Evidencia](../docs/t3/evidencias/RF-02/validacion-local.txt).

## Trazabilidad local consolidada

Commit de tarea `45752cb`; revisión local combinada en `revision/evelyn-t3-local`. [Resultado conjunto](../docs/t3/evidencias/EVELYN_VALIDACION_CONJUNTA.md). PR y aprobación humana pendientes. Los apartados «en curso/pendiente de creación» anteriores describen el inicio de la tarea, no anticipan aprobaciones.
