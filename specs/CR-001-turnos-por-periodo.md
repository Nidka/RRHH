# CR-001: asignación de horarios por periodo (RF-01)

- Estado: código preparado localmente; QA Windows y revisión pendientes.
- Responsable: Evelyn Victoria Rodriguez Cardozo. Revisor: Francisco Kadin Valera Lizarraga.
- Base: `03ab748`, reconstrucción; rama `feature/rf-01-turnos-por-periodo`.
- Original ejecutable no observado. No se consultó BD compartida ni `.env`.

## Caracterización e ingeniería inversa

Entrada: búsqueda de personal → FrmConsultaHorarioEsp → FrmHorarioEsp; empleado, horario, fechas, documento y Sisgedo. El editor carga empleado mediante BuscarEmpleado_Codigo y horarios mediante mapper; al editar obtiene HorarioTemporal por (idEmpleado,N). Alta: compara fechas como texto y solo comprueba si inicio nuevo está dentro del existente; asigna MAX(N)+1 fuera de una transacción. Edición omite conflictos y usa actualización genérica, con riesgo de perder FechaRegistro. Mensajes: «La Fecha de Inicio no puede ser mayor a la de Término», «Debe Seleccionar un Horario Válido», «El Empleado ya Registra este Horario».

Fuentes al corte: FrmHorarioEsp.cs:924–1021; FrmConsultaHorarioEsp.cs:1036–1093; RRHHClass.SgtIdHorarioTemporal/llena_HorariosTemporales; BD/schema.sql:417–426. FrmAsignarHorario cambia el horario principal del empleado; no guarda periodos y no se modifica en este RF. No se afirma que la asignación temporal ya se aplique al cálculo de asistencia.

Diagnóstico: validación parcial, acoplamiento UI/persistencia e ID no atómico. Impacto: contención/edición pueden solaparse y dos altas competir por N. La prueba visual de este diagnóstico está pendiente; lo anterior procede del código reconstruido.

## Alcance y decisiones

Conservar formulario, campos, clave compuesta (idEmpleado,N), selección del catálogo TEC-001 y alta/edición explícita. No cambiar horario principal, asistencia, esquema ni permisos. **Hipótesis técnica reversible:** rechazar cualquier día compartido por dos periodos del mismo empleado; extremos inclusivos, hora descartada, exclusión del propio N al editar. Otro empleado no bloquea. Documento y Sisgedo opcionales, máximo 50 según DDL. Reasignar mediante alta crea otra fila; no reemplaza asignaciones anteriores. Edición corrige únicamente la fila elegida y conserva FechaRegistro.

## Mantenimiento, técnica y diseño

Principal adaptativo: completar RF-01 sobre la ruta PostgreSQL actual. Secundario preventivo: Extract Class/Extract Method y sustitución de acceso heredado por Repository; corrección separada: comparación tipada, solapamiento completo también al editar e ID atómico.

MVP: FrmHorarioEsp implementa IAsignacionHorarioView; AsignacionHorarioPresenter coordina carga/guardado; AsignarHorarioPorPeriodo usa IHorarioTemporalRepository y AsignacionHorario/RangoFechas; PostgreSqlHorarioTemporalRepository ejecuta SQL. ObtenerDatosAsignacion carga perfil/edición sin escribir. CompositionRoot.CrearAsignacionHorario compone; FrmConsultaHorarioEsp abre editor mediante esa fábrica. No se duplica HorarioDto/ListarHorarios/IHorarioRepository.

SRP: btnGuardar_Click deja validación/persistencia al caso/repositorio. DIP: caso/presenter dependen de contratos, demostrable con repositorio/vista falsos. DRY: RangoFechas.Solapa y catálogo TEC-001. No se altera la arquitectura.

## Contrato y concurrencia

Guardar comprueba empleado y horario únicos/existentes, clave propia única en edición y solapamiento dentro de la misma transacción que INSERT/UPDATE. Orden de bloqueos Horario → Empleado → HorarioTemporal compatible con baja de catálogo. Bloqueos de tablas protegen comprobación, MAX(N)+1 y escritura de esta ruta. No se crea PK/DDL ni se garantiza integridad ante escritores externos posteriores. Se rechazan IDs ambiguos y fechas nulas/invertidas del empleado antes de guardar; el historial no se sanea automáticamente. FechaRegistro se establece al insertar y se conserva al editar. Consulta parametrizada y fechas DbType.Date; lectura de metadatos por DTO. Riesgo: bloqueos amplios transitorios; FK/índices/datos duplicados se coordinan con Kadin.

## Aceptación y plan de ejecución

- [x] Test primero (símbolos inicialmente ausentes): rango invertido/un día, igualdad/cruce/contención, distinto empleado, edición propia, texto de 50/51, no escritura al cargar.
- [x] Implementar dominio/contrato/casos; comprobar pruebas.
- [x] Implementar repositorio y pruebas PostgreSQL local ficticio: alta, preservación histórica, edición, referencias ambiguas, concurrencia y rollback.
- [x] Conectar vista/presenter/composición sin modificar diseñador ni renombrar formularios; probar errores y cancelación.
- [ ] Build Windows, suite net48, QA real ficticia y revisión de Kadin.

Pruebas en macOS mediante arnés temporal net8 de fuentes exactas: evidencia complementaria, no sustituye net48/WinForms. La ejecución no se afirmará hasta registrar su salida. Casos en docs/t3/casos_prueba/evelyn.csv.

## Reversión y trazabilidad

Revertir el commit de aplicación restaura ruta anterior sin borrar filas; no hay DDL que revertir. No borrar periodos de prueba en servidor compartido. PR/commit pendientes de creación; no hay aprobación humana. Uso material de Codex: caracterización, diseño, código, pruebas y documentos. Evelyn debe comprobar y poder explicar el resultado.

## Ficha RF

RF-01 / CR-001, asistencia, FrmHorarioEsp/AsignarHorarioPorPeriodo. Regla: periodo inclusivo, conflictos por empleado. Estado: en desarrollo local. CP-01-01…CP-01-10 y pruebas de integración. Versión propuesta MINOR; no se publica release. Revisor Kadin.

## Resultado local

314 pruebas complementarias net8 correctas, ninguna omitida; incluye 5 pruebas SQL nuevas y la suite existente. Compilación del proyecto real RRHH.Tests net48: 0 errores/advertencias. Su ejecución en macOS se anuló por falta de mono. QA WinForms/build.cmd Windows y revisión de Kadin pendientes. Evidencia: [validación](../docs/t3/evidencias/RF-01/validacion-local.txt).
