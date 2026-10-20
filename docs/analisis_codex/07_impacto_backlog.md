# 7. IMPACTO DEL BACKLOG

[Volver al índice](../analisis_codex.md). Evaluación estática independiente de los estados de las matrices previas. “Existe base” no equivale a requisito aceptado; “no localizado” se acota a las fuentes disponibles. Las entidades nuevas mencionadas son propuestas, no tablas ya implementadas.


## RF-01 · Registrar turnos por periodos de fechas

| Aspecto | Análisis |
|---|---|
| Qué existe hoy | BASE EXISTENTE: el editor HorarioEsp guarda FechaInicio, FechaFin y HorarioAsignado en HorarioTemporal. La asignación principal se hace por FrmAsignarHorario. TEC-001 refactoriza el catálogo, no creó esta capacidad temporal. |
| Formularios / clases afectados | FrmBuscarPersona → FrmConsultaHorarioEsp → FrmHorarioEsp; FrmAsignarHorario; RRHHClass; HorarioTemporalMapper/puente. Separar estos flujos del presenter del catálogo FrmHorarios. |
| Tablas / datos | Empleado.IdEmpleado/idHorario; Horario; HorarioTemporal.idEmpleado/N/FechaInicio/FechaFin/HorarioAsignado/NroDocumento/Sisgedo. |
| Consultas / persistencia | llena_HorariosTemporales; SgtIdHorarioTemporal; mapper Insert/Update; puente sp_Update_Empleado_idHorario_By_idEmpleado. |
| Qué falta y cómo contrastarlo | Confirmar si “turno por periodo” coincide con horario temporal; caracterizar prioridad sobre horario principal, bordes, solapamientos, edición, concurrencia e integración en asistencia. No declarar que el sistema carece por completo de periodos. |
| Evidencia de la base actual | [Software/RecursosHumanos/RecursosHumanos/FrmHorarioEsp.cs:977](../../Software/RecursosHumanos/RecursosHumanos/FrmHorarioEsp.cs#L977); [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:714](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L714); [Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs:25](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs#L25) |

## RF-02 · Consultar histórico de turnos

| Aspecto | Análisis |
|---|---|
| Qué existe hoy | BASE EXISTENTE: consulta de horarios temporales por empleado con fechas y exportación XLS; editar/borrar puede alterar el registro anterior. |
| Formularios / clases afectados | FrmConsultaHorarioEsp y su entrada desde FrmBuscarPersona; RRHHClass.llena_HorariosTemporales. |
| Tablas / datos | HorarioTemporal y Horario, vinculados a Empleado. No se encontró una tabla dedicada a auditoría de cada revisión de horario. |
| Consultas / persistencia | SELECT de llena_HorariosTemporales; filtros/orden de consulta; eliminarHorarioTemporal. |
| Qué falta y cómo contrastarlo | Acordar definición de histórico (asignaciones previas o versiones inmutables), filtros por periodo, orden, conservación tras edición/baja y alcance por rol. |
| Evidencia de la base actual | [Software/RecursosHumanos/RecursosHumanos/FrmBuscarPersona.cs:1780](../../Software/RecursosHumanos/RecursosHumanos/FrmBuscarPersona.cs#L1780); [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:714](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L714); [Software/RecursosHumanos/RecursosHumanos/FrmConsultaHorarioEsp.cs:1095](../../Software/RecursosHumanos/RecursosHumanos/FrmConsultaHorarioEsp.cs#L1095) |

## RF-03 · Validar que no se registren dos permisos el mismo día para una misma persona

| Aspecto | Análisis |
|---|---|
| Qué existe hoy | PARCIAL: existen comprobaciones UI y ExistePermiso. Sus condiciones no equivalen a una exclusión completa por persona/día. |
| Formularios / clases afectados | FrmPermiso.Button1_Click, FrmConsultaPermisos, RRHHClass.ExistePermiso, persistencia de Permiso. Conviene extraer regla/caso dedicado según arquitectura vigente. |
| Tablas / datos | Permiso.IdEmpleado/NPermiso/FechaInicio/FechaFin/Retorno/Hora_Ret; Motivo_Perm si la política distingue causas. |
| Consultas / persistencia | ExistePermiso; SelectBy de permiso pendiente de retorno; Insert/Update del mapper. |
| Qué falta y cómo contrastarlo | Definir día y estado/anulación, excluir la propia edición, comparar fechas tipadas y cubrir contención/igualdad. Validar e insertar de forma coherente ante concurrencia. |
| Evidencia de la base actual | [Software/RecursosHumanos/RecursosHumanos/FrmPermiso.cs:1416](../../Software/RecursosHumanos/RecursosHumanos/FrmPermiso.cs#L1416); [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:262](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L262) |

## RF-04 · Agregar motivos de permiso

| Aspecto | Análisis |
|---|---|
| Qué existe hoy | IMPLEMENTACIÓN EXISTENTE migrada: listado/editor, caso GuardarMotivoPermiso, dominio y repositorio. El alta está integrada; aceptación visual y política final no se acreditan aquí. |
| Formularios / clases afectados | FrmMotivoPermiso/FrmMantMotivo; MotivosPermisoPresenter/MotivoPermisoEditorPresenter; GuardarMotivoPermiso; MotivoPermiso; PostgreSqlMotivoPermisoRepository; CompositionRoot. |
| Tablas / datos | TipoPermiso.idTipoPermiso; Motivo_Perm.idMotivo/Descrip_Motivo/Abrev/Salario/TipoModalidad/Activo. |
| Consultas / persistencia | Listar, Insertar; verificación de tipo único; identidad/default o MAX+1 bajo bloqueo; parámetros tipados. |
| Qué falta y cómo contrastarlo | Confirmar datos del catálogo de QA, unicidad por descripción si se exige, accesos por rol y aparición del motivo en registro de permisos. Probar alta válida e inválida en Windows. |
| Evidencia de la base actual | [Software/RRHH.Application/Permisos/GuardarMotivoPermiso.cs:9](../../Software/RRHH.Application/Permisos/GuardarMotivoPermiso.cs#L9); [Software/RRHH.PostgreSql/Permisos/PostgreSqlMotivoPermisoRepository.cs:57](../../Software/RRHH.PostgreSql/Permisos/PostgreSqlMotivoPermisoRepository.cs#L57); [Software/RRHH.Domain/Permisos/MotivoPermiso.cs:31](../../Software/RRHH.Domain/Permisos/MotivoPermiso.cs#L31) |

## RF-05 · Eliminar motivos de permiso

| Aspecto | Análisis |
|---|---|
| Qué existe hoy | IMPLEMENTACIÓN EXISTENTE migrada: eliminar con acceso/modalidad y protección de referencias. No se da por aceptada sin QA de versión y política de baja. |
| Formularios / clases afectados | FrmMotivoPermiso, MotivosPermisoPresenter, EliminarMotivoPermiso y repositorio; formularios de permisos como consumidores. |
| Tablas / datos | Motivo_Perm; Permiso.idMotivo; Permiso_Aud.idMotivo_Ant/idMotivo_Act; TipoPermiso. |
| Consultas / persistencia | Eliminar del repositorio: contar código, comprobar modalidad/referencias y borrar en transacción; manejo de FK si existe. |
| Qué falta y cómo contrastarlo | Acordar borrado físico frente a desactivación, probar motivo libre/en uso/histórico/ajeno al rol, y resolver integridad/IDs de TEC-002. |
| Evidencia de la base actual | [Software/RRHH.Application/Permisos/EliminarMotivoPermiso.cs:9](../../Software/RRHH.Application/Permisos/EliminarMotivoPermiso.cs#L9); [Software/RRHH.PostgreSql/Permisos/PostgreSqlMotivoPermisoRepository.cs:112](../../Software/RRHH.PostgreSql/Permisos/PostgreSqlMotivoPermisoRepository.cs#L112) |

## RF-06 · Validar licencias que se otorgan una vez al año, por ejemplo licencia 30012

| Aspecto | Análisis |
|---|---|
| Qué existe hoy | PARCIAL en registro: existe permiso por tipo/motivo. NO LOCALIZADO un control anual 30012 ni política anual parametrizada en el código/SQL. |
| Formularios / clases afectados | FrmPermiso y FrmConsultaPermisos; futura regla/caso de licencia anual; catálogo de motivos/tipos y persistencia de permisos. |
| Tablas / datos | Permiso.IdEmpleado/FechaInicio/FechaFin/idMotivo; Motivo_Perm/TipoPermiso. Configuración de elegibilidad anual a diseñar tras confirmar regla. |
| Consultas / persistencia | Consultas de permiso actuales no cuentan por persona/tipo/año para esta regla. Se necesita consulta parametrizada y escritura protegida. |
| Qué falta y cómo contrastarlo | Acordar año computable, agrupación de motivos, estados que cuentan y si bloquea o advierte; probar primer/segundo registro y concurrencia. No inventar interpretación legal. |
| Evidencia de la base actual | [Software/RecursosHumanos/RecursosHumanos/FrmPermiso.cs:1416](../../Software/RecursosHumanos/RecursosHumanos/FrmPermiso.cs#L1416); [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:262](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L262); [docs/t2/evidencias/TEC-004/catalogos-solo-lectura.txt:10](../../docs/t2/evidencias/TEC-004/catalogos-solo-lectura.txt#L10) |

## RF-07 · Reportar cálculo de vacaciones generadas

| Aspecto | Análisis |
|---|---|
| Qué existe hoy | NO LOCALIZADO motor de devengos. Hay datos de empleado y motivos VACACIONES en un catálogo registrado; no un cálculo acreditado. |
| Formularios / clases afectados | RRHHClass y consultas de empleado/periodos como fuentes; futuro dominio/caso/reporte de vacaciones. El formulario nuevo todavía no existe. |
| Tablas / datos | Empleado.FechaIngreso, PeriodoLaboral y régimen laboral como datos candidatos; fuente de devengos/saldos a diseñar. |
| Consultas / persistencia | Consultar datos laborales y reglas aprobadas; las consultas actuales de Permiso no calculan vacaciones generadas. |
| Qué falta y cómo contrastarlo | Obtener fórmula, periodos computables, regímenes, ajustes y ejemplos esperados; separar cálculo de UI y contrastar contra casos del usuario. |
| Evidencia de la base actual | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:228](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L228); [Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs:122](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs#L122); [docs/t2/evidencias/TEC-004/catalogos-solo-lectura.txt:16](../../docs/t2/evidencias/TEC-004/catalogos-solo-lectura.txt#L16) |

## RF-08 · Reportar vacaciones pendientes de goce

| Aspecto | Análisis |
|---|---|
| Qué existe hoy | NO LOCALIZADO cálculo de saldo. El registro genérico de permisos no demuestra reconciliación de generadas, usadas y ajustes. |
| Formularios / clases afectados | Futuro caso de saldo/reporte; FrmConsultaPermisos y RRHHClass como fuentes de consumos candidatos. |
| Tablas / datos | Empleado, Permiso y motivos de vacaciones; movimientos/ajustes y devengos a definir, sin asumir tabla ya creada. |
| Consultas / persistencia | llena_Permisos como consulta de base; nueva agregación por periodo/unidad compartida con RF-07/RF-10. |
| Qué falta y cómo contrastarlo | Definir saldo inicial, consumos aprobados/anulados, fracciones y trazabilidad. Probar saldo con múltiples periodos y ajustes. |
| Evidencia de la base actual | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:695](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L695); [docs/t2/evidencias/TEC-004/catalogos-solo-lectura.txt:16](../../docs/t2/evidencias/TEC-004/catalogos-solo-lectura.txt#L16) |

## RF-09 · Reportar vacaciones truncas

| Aspecto | Análisis |
|---|---|
| Qué existe hoy | NO LOCALIZADO motor de truncas ni reporte específico; tener fecha de ingreso/periodos no equivale a implementarlo. |
| Formularios / clases afectados | Consultas laborales y futuro caso/reporte de truncas; no existe formulario dedicado identificado. |
| Tablas / datos | Empleado, PeriodoLaboral y datos de cese/tiempo computable que deben confirmarse; régimen y fórmula por acordar. |
| Consultas / persistencia | Lectura laboral actual; nuevo cálculo tipado con criterios aprobados, sin inferir fórmula de una descripción. |
| Qué falta y cómo contrastarlo | Confirmar fecha de corte/cese y fracciones computables; casos de periodos incompletos y nulos con resultados aprobados. |
| Evidencia de la base actual | [Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs:122](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs#L122); [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:228](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L228) |

## RF-10 · Contabilizar vacaciones desde media jornada laboral

| Aspecto | Análisis |
|---|---|
| Qué existe hoy | EXISTE categoría de catálogo 1/2 JORNADA VACACIONES en evidencia fechada; NO LOCALIZADO contador numérico de 0,5 ni motor de consumos. |
| Formularios / clases afectados | FrmPermiso/FrmConsultaPermisos; futura regla de unidad de vacaciones y casos de saldo/reportes. |
| Tablas / datos | Permiso.FechaInicio/FechaFin/Dia/Hora_Sal/Hora_Ret y motivo; unidad fraccionaria a diseñar. Dia es booleano y no acredita cantidad decimal. |
| Consultas / persistencia | Insert/Update y lectura de permiso actuales; nueva suma de unidades compatible con RF-07/RF-08. |
| Qué falta y cómo contrastarlo | Acordar jornada, cómo representar media jornada y redondeos; probar 0,5, 1 y acumulaciones sin doble consumo. |
| Evidencia de la base actual | [docs/t2/evidencias/TEC-004/catalogos-solo-lectura.txt:38](../../docs/t2/evidencias/TEC-004/catalogos-solo-lectura.txt#L38); [Software/RecursosHumanos/RecursosHumanos/FrmPermiso.cs:1416](../../Software/RecursosHumanos/RecursosHumanos/FrmPermiso.cs#L1416) |

## RF-11 · Generar reporte de vacaciones

| Aspecto | Análisis |
|---|---|
| Qué existe hoy | PARCIAL como listado genérico filtrable por motivo; NO LOCALIZADO reporte que combine generadas, pendientes, usadas y truncas. |
| Formularios / clases afectados | FrmRepPermisos/XtraRepPermiso como referencias de presentación, futuro caso de reporte vacacional y diseño específico. |
| Tablas / datos | Permiso/Motivo_Perm más resultados de RF-07/08/09/10 y datos de empleado. |
| Consultas / persistencia | spRRHH_RepPermisos no calcula saldos; nueva consulta/reporte sobre resultados aprobados. |
| Qué falta y cómo contrastarlo | Acordar columnas, corte, unidad, filtros, totales y acceso; validar consistencia con el cálculo y exportación. |
| Evidencia de la base actual | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:835](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L835); [Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs:17](../../Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs#L17) |

## RF-12 · Módulo para consultar vacaciones pendientes y usadas del usuario

| Aspecto | Análisis |
|---|---|
| Qué existe hoy | EXISTE login con vínculo de empleado, pero NO LOCALIZADO módulo de autoservicio vacacional ni restricción propia de ese caso. |
| Formularios / clases afectados | FrmLogin/ApplyAccess, RRHH.codEmple y futuro formulario/presenter/caso de consulta propia. |
| Tablas / datos | Usuario.IdEmpleado, Empleado y resultados/consumos de vacaciones; autorización de identidad por operación. |
| Consultas / persistencia | Autenticar ya devuelve empleado/rol; nueva consulta de saldo/consumo limitada al empleado autenticado. |
| Qué falta y cómo contrastarlo | Definir perfil de usuario final y prohibir consulta de otra persona; no confiar sólo en ocultar controles o pasar un ID desde UI. |
| Evidencia de la base actual | [Software/RecursosHumanos/RecursosHumanos/FrmLogin.cs:164](../../Software/RecursosHumanos/RecursosHumanos/FrmLogin.cs#L164); [Software/RRHH.PostgreSql/Seguridad/PostgreSqlAccesoUsuarioRepository.cs:60](../../Software/RRHH.PostgreSql/Seguridad/PostgreSqlAccesoUsuarioRepository.cs#L60) |

## RF-13 · Registrar periodos de teletrabajo

| Aspecto | Análisis |
|---|---|
| Qué existe hoy | NO LOCALIZADO módulo, entidad o regla específica. HorarioTemporal representa horarios y no demuestra modalidad de teletrabajo. |
| Formularios / clases afectados | Nuevo flujo según arquitectura vigente; Empleado y asignaciones/calendario como integraciones candidatas. |
| Tablas / datos | Entidad de periodo/modalidad por diseñar, vinculada a Empleado; no se presupone una tabla ya existente. |
| Consultas / persistencia | No hay consulta específica de teletrabajo; crear altas/cambios/consulta y reglas de solapamiento aprobadas. |
| Qué falta y cómo contrastarlo | Definir modalidad total/parcial, vigencias, autorización, conflicto y reversión; coordinar con RF-01 sin reutilizar su significado indebidamente. |
| Evidencia de la base actual | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:714](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L714); [BD/schema.sql:1](../../BD/schema.sql#L1) |

## RF-14 · Reportar días de teletrabajo

| Aspecto | Análisis |
|---|---|
| Qué existe hoy | NO LOCALIZADO conteo de teletrabajo. Hay asistencia/horas/calendario como fuentes candidatas, sin clasificación remota. |
| Formularios / clases afectados | Futuro caso/reporte; RRHHClass y consultas de asistencia para conciliación. |
| Tablas / datos | Periodos/modalidad nuevos de RF-13; Empleado, calendario laboral y RRHH_Feriado según regla aprobada. |
| Consultas / persistencia | Ninguna consulta actual cuenta teletrabajo; nueva agregación de días efectivos por periodo. |
| Qué falta y cómo contrastarlo | Acordar fines de semana, feriados, permisos, fracciones y qué evidencia hace efectivo el día remoto. |
| Evidencia de la base actual | [Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs:60](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs#L60); [Software/RRHH.Domain/Asistencia/Feriado.cs:9](../../Software/RRHH.Domain/Asistencia/Feriado.cs#L9) |

## RF-15 · Reportar labores presenciales y teletrabajo por persona

| Aspecto | Análisis |
|---|---|
| Qué existe hoy | NO LOCALIZADA conciliación presencial/remoto. Asistencia y Local no bastan para clasificar cada jornada. |
| Formularios / clases afectados | FrmConsultaAsistencias/FrmHorasTrabajadas como referencias; futuro caso/reporte de conciliación. |
| Tablas / datos | Empleado, Asistencia/Marcacion, periodos de teletrabajo nuevos, permisos y calendario. |
| Consultas / persistencia | LlenarPlanillaAsistencia y récord semanal como bases; nueva consulta/regla de clasificación evitando doble conteo. |
| Qué falta y cómo contrastarlo | Definir precedencia remoto/presencial/ausencia, días mixtos y errores; probar totales por persona/periodo. |
| Evidencia de la base actual | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:786](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L786); [Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs:68](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs#L68) |

## RF-16 · Reportar teletrabajo total o parcial

| Aspecto | Análisis |
|---|---|
| Qué existe hoy | NO LOCALIZADA clasificación total/parcial específica en el sistema. |
| Formularios / clases afectados | Futuro reporte sobre periodos y modalidad RF-13; consultas de empleado/área para filtros. |
| Tablas / datos | Entidad nueva de periodos/modalidad, Empleado, área; regla de clasificación por periodo por acordar. |
| Consultas / persistencia | Nueva consulta de modalidad; no inferirla sólo del número de marcaciones. |
| Qué falta y cómo contrastarlo | Definir si la clasificación es contractual o deriva de días efectivos, periodo de corte y acceso. |
| Evidencia de la base actual | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:228](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L228); [BD/schema.sql:1](../../BD/schema.sql#L1) |

## RF-17 · Validar suma correcta de feriados en reporte general

| Aspecto | Análisis |
|---|---|
| Qué existe hoy | EXISTE catálogo RRHH_Feriado migrado y reportes de asistencia. NO ACREDITADO el cómputo general; puente preparador es stub. |
| Formularios / clases afectados | FrmFeriado/FeriadoPresenter/casos/repositorio como fuente; FrmConsultaAsistencias, RRHHClass.LlenarPlanillaAsistencia y PostgreSqlLegacyContext. |
| Tablas / datos | RRHH_Feriado.Id/Fecha/Motivo; Horario/turnos, Asistencia, Empleado, y permisos/calendario según definición de total. |
| Consultas / persistencia | Listar de repositorio feriados; GetReporteAsistencia=&gt;0; planilla actual no consume RRHH_Feriado. |
| Qué falta y cómo contrastarlo | Definir qué suma el reporte, feriado laborado/no laborado, fin de semana, repetición y tramo nocturno; probar totales por ejemplos aceptados. |
| Evidencia de la base actual | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:786](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L786); [Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs:82](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs#L82); [Software/RRHH.PostgreSql/Asistencia/PostgreSqlFeriadoRepository.cs:15](../../Software/RRHH.PostgreSql/Asistencia/PostgreSqlFeriadoRepository.cs#L15) |

## RF-18 · Reportar vacaciones, licencia, enfermedad u otros motivos entre fechas

| Aspecto | Análisis |
|---|---|
| Qué existe hoy | BASE EXISTENTE: reporte de permisos con tipo/motivo/periodo. Filtra inicio dentro del rango; no cubre todas las ausencias solapadas. |
| Formularios / clases afectados | FrmRepPermisos/FrmRepPermisoDispl/XtraRepPermiso, RRHHClass.spRRHH_RepPermisos; fuentes adicionales de ausencia si las hubiera. |
| Tablas / datos | Permiso, Motivo_Perm, TipoPermiso, Empleado/Persona, Cargo, Empleado_Area/EstructOrganiz. |
| Consultas / persistencia | spRRHH_RepPermisos y estadísticas; reemplazar filtro sólo por inicio por solapamiento conforme al criterio aprobado y parametrizar corte histórico. |
| Qué falta y cómo contrastarlo | Acordar inclusividad, estados, categorías y alcance; probar ausencia que inicia antes y termina durante/después, y rangos sin filas. |
| Evidencia de la base actual | [Software/RecursosHumanos/RecursosHumanos/FrmRepPermisos.cs:758](../../Software/RecursosHumanos/RecursosHumanos/FrmRepPermisos.cs#L758); [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:835](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L835) |

## Efecto sobre los documentos previos

El hallazgo de horarios temporales y su consulta obliga a revisar cualquier redacción anterior que diga que RF-01/RF-02 carecen totalmente de base funcional. El refactor TEC-001 no implementó esas capacidades, pero el legado ya contiene una ruta que debe caracterizarse. No se modificaron las matrices CSV ni el Word durante este análisis. [Software/RecursosHumanos/RecursosHumanos/FrmHorarioEsp.cs:977](../../Software/RecursosHumanos/RecursosHumanos/FrmHorarioEsp.cs#L977); [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:714](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L714).
