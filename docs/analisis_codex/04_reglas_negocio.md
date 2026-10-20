# 4. REGLAS DE NEGOCIO Y VALIDACIONES

[Volver al índice](../analisis_codex.md). Se describe comportamiento localizado en código, no observado en ejecución. El [anexo de condiciones y excepciones](04_condiciones_excepciones.md) conserva todos los if/throw/catch de los C#; incluye guardas técnicas y generadas que no son reglas del negocio. Las restricciones SQL están en [DDL](03_modelo_datos.md).

| ID | Área | Regla localizada | Duplicidad / límite | Evidencia |
|---|---|---|---|---|
| R-01 | Acceso | Usuario y contraseña obligatorios; usuario se recorta; contraseña no vacía. Error de autenticación se muestra como estado. | Validación de UI y caso; cotejar límites 20/128 con la BD. | [Software/RecursosHumanos/RecursosHumanos/FrmLogin.cs:108](../../Software/RecursosHumanos/RecursosHumanos/FrmLogin.cs#L108) |
| R-02 | Autenticación | Usuario activo, rol asociado al sistema y hash/salt/iteraciones válidos; se elige el primer IdRol ordenado. | Un usuario multirrol no elige rol en esta pantalla; no es ausencia de seguridad. | [Software/RRHH.PostgreSql/Seguridad/PostgreSqlAccesoUsuarioRepository.cs:60](../../Software/RRHH.PostgreSql/Seguridad/PostgreSqlAccesoUsuarioRepository.cs#L60) |
| R-03 | Sesión | ApplyAccess asigna RRHH.LogUser/codEmple/IdROl y banderas; MainMDI oculta opciones por rol. | Roles numéricos en varias capas/UI; visibilidad no demuestra autorización de cada operación. | [Software/RecursosHumanos/RecursosHumanos/FrmLogin.cs:164](../../Software/RecursosHumanos/RecursosHumanos/FrmLogin.cs#L164); [Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2207](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2207) |
| R-04 | Personal | Selección obligatoria y restricciones de acceso a edición/ficha según rol/tipo. | Mensajes y decisiones repetidos entre clic y doble clic; revisar consistencia. | [Software/RecursosHumanos/RecursosHumanos/FrmBuscarPersona.cs:1432](../../Software/RecursosHumanos/RecursosHumanos/FrmBuscarPersona.cs#L1432); [Software/RecursosHumanos/RecursosHumanos/FrmBuscarPersona.cs:1565](../../Software/RecursosHumanos/RecursosHumanos/FrmBuscarPersona.cs#L1565) |
| R-05 | Horario: catálogo | Id no negativo, descripción recortada máximo 20; las cuatro horas deben ser válidas dentro del día. Permite descripción vacía y no impone orden diurno. | Regla centralizada en Horario; SgtDia no se edita; no inventar requisito de orden de horas. | [Software/RRHH.Domain/Asistencia/Horario.cs:34](../../Software/RRHH.Domain/Asistencia/Horario.cs#L34); [Software/RRHH.Domain/Asistencia/Horario.cs:47](../../Software/RRHH.Domain/Asistencia/Horario.cs#L47) |
| R-06 | Horario: eliminación | No borrar si referido por Empleado, HorarioTemporal, Asistencia o Marcacion; abortar códigos ambiguos. | Chequeo de repositorio y bloqueo no sustituyen FK para escritores externos. | [Software/RRHH.PostgreSql/Asistencia/PostgreSqlHorarioRepository.cs:91](../../Software/RRHH.PostgreSql/Asistencia/PostgreSqlHorarioRepository.cs#L91) |
| R-07 | Horario principal | FrmAsignarHorario aplica idHorario a empleados seleccionados mediante puente. | Distinto del catálogo y de asignaciones temporales con vigencia. | [Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs:25](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs#L25) |
| R-08 | Horario temporal | Fecha inicial no mayor a final; horario seleccionado no cero. | La misma comprobación temporal se repite en FrmPermiso y asistencia. | [Software/RecursosHumanos/RecursosHumanos/FrmHorarioEsp.cs:977](../../Software/RecursosHumanos/RecursosHumanos/FrmHorarioEsp.cs#L977) |
| R-09 | Conflicto de horario temporal | Al crear, busca un horario que contenga el inicio nuevo; compara ToShortDateString como texto. | No cubre todos los solapamientos ni valida al editar de igual modo; no afirmar RF-01 terminado. | [Software/RecursosHumanos/RecursosHumanos/FrmHorarioEsp.cs:977](../../Software/RecursosHumanos/RecursosHumanos/FrmHorarioEsp.cs#L977) |
| R-10 | Histórico temporal | Guarda FechaInicio/FechaFin y consulta asignaciones por empleado; permite editar/borrar/exportar. | Existe una base RF-02; no hay garantía de histórico inmutable ni auditoría por el simple listado. | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:714](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L714); [Software/RecursosHumanos/RecursosHumanos/FrmConsultaHorarioEsp.cs:1074](../../Software/RecursosHumanos/RecursosHumanos/FrmConsultaHorarioEsp.cs#L1074) |
| R-11 | Permiso: fechas y motivo | Inicio no posterior al fin, combo de motivo habilitado y valor no cero. | Mensajes literales y doble comprobación de motivo en el formulario. | [Software/RecursosHumanos/RecursosHumanos/FrmPermiso.cs:1416](../../Software/RecursosHumanos/RecursosHumanos/FrmPermiso.cs#L1416) |
| R-12 | Permiso vigente/retorno | Se bloquea si un permiso del empleado cubre el inicio y tiene Retorno=true y Hora_Ret nula. | La expresión usa fechas formateadas como texto y nulables; distinta de prohibir cualquier par de permisos del mismo día. | [Software/RecursosHumanos/RecursosHumanos/FrmPermiso.cs:1416](../../Software/RecursosHumanos/RecursosHumanos/FrmPermiso.cs#L1416) |
| R-13 | Salida autorizada tipo 2 | Requiere asistencia de hoy, sin salida registrada; fecha no anterior a hoy y un único día. | El tipo se trata por valor 2 y en otros sitios por SelectedIndex; depende del catálogo. | [Software/RecursosHumanos/RecursosHumanos/FrmPermiso.cs:1416](../../Software/RecursosHumanos/RecursosHumanos/FrmPermiso.cs#L1416) |
| R-14 | Día/retorno | No permite marcar Día si Retorno está marcado ni viceversa. | Son opciones booleanas; no representan por sí solas consumo de media jornada vacacional. | [Software/RecursosHumanos/RecursosHumanos/FrmPermiso.cs:1593](../../Software/RecursosHumanos/RecursosHumanos/FrmPermiso.cs#L1593); [Software/RecursosHumanos/RecursosHumanos/FrmPermiso.cs:1602](../../Software/RecursosHumanos/RecursosHumanos/FrmPermiso.cs#L1602) |
| R-15 | Conflicto SQL de permisos | ExistePermiso cuenta si cualquiera de los extremos nuevos cae dentro del intervalo existente. | No detecta cuando el intervalo nuevo contiene completamente al anterior; no hay exclusión por NPermiso en esa consulta. | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:262](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L262) |
| R-16 | Permiso: persistencia | Alta usa MAX(NPermiso)+1 por empleado; edición hace Update de entidad nueva. Envío Access opcional después de escribir RRHH. | Carrera posible al alta; revisar columnas omitidas en actualización; falla de envío no revierte el permiso. | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:89](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L89); [Software/RecursosHumanos/RecursosHumanos/FrmPermiso.cs:1416](../../Software/RecursosHumanos/RecursosHumanos/FrmPermiso.cs#L1416); [Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyMapper.cs:111](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyMapper.cs#L111) |
| R-17 | Motivos por modalidad | Rol 10→P, 14→C y 13→sin filtro de modalidad; selección depende además de tipo. | La política centralizada actual convive con lógica equivalente en formularios de permisos. | [Software/RRHH.Domain/Permisos/AccesoMotivosPermiso.cs:7](../../Software/RRHH.Domain/Permisos/AccesoMotivosPermiso.cs#L7); [Software/RecursosHumanos/RecursosHumanos/FrmPermiso.cs:1324](../../Software/RecursosHumanos/RecursosHumanos/FrmPermiso.cs#L1324) |
| R-18 | Nuevo motivo | Tipo válido, descripción no vacía y hasta 50; abreviatura hasta 3; recorta textos y crea activo. | Regla pura; no valida unicidad semántica por descripción si no existe política acordada. | [Software/RRHH.Domain/Permisos/MotivoPermiso.cs:31](../../Software/RRHH.Domain/Permisos/MotivoPermiso.cs#L31); [Software/RRHH.Domain/Permisos/MotivoPermiso.cs:46](../../Software/RRHH.Domain/Permisos/MotivoPermiso.cs#L46) |
| R-19 | Edición de motivo | Conserva tipo, modalidad y Activo que el editor no modifica. | Carga no debe escribir; separación Cargar/Guardar en presenter. | [Software/RRHH.Domain/Permisos/MotivoPermiso.cs:39](../../Software/RRHH.Domain/Permisos/MotivoPermiso.cs#L39); [Software/RRHH.Presentation/Permisos/MotivoPermisoEditorPresenter.cs:24](../../Software/RRHH.Presentation/Permisos/MotivoPermisoEditorPresenter.cs#L24) |
| R-20 | Baja de motivo | Protege referencias Permiso y Permiso_Aud y restringe modalidad; códigos duplicados/tipo ambiguo abortan. | No sustituye la limpieza acordada ni PK/FK de TEC-002. | [Software/RRHH.PostgreSql/Permisos/PostgreSqlMotivoPermisoRepository.cs:57](../../Software/RRHH.PostgreSql/Permisos/PostgreSqlMotivoPermisoRepository.cs#L57); [Software/RRHH.PostgreSql/Permisos/PostgreSqlMotivoPermisoRepository.cs:112](../../Software/RRHH.PostgreSql/Permisos/PostgreSqlMotivoPermisoRepository.cs#L112) |
| R-21 | Asistencia manual | Valida datos/fechas en la pantalla antes de registrar; puede remitir a Access. | Inventario de mensajes, condiciones y efectos completo en la ficha de FrmAsistenciaManual. | [Software/RecursosHumanos/RecursosHumanos/FrmAsistenciaManual.cs:909](../../Software/RecursosHumanos/RecursosHumanos/FrmAsistenciaManual.cs#L909) |
| R-22 | Importación | Intervalo de Access se transforma a inicio inclusivo y fin exclusivo+1 día; forzar controla sustituciones. Importación RRHH usa transacción. | Dependencia de proveedor Access y ficheros/rutas; errores se transforman en false. | [Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs:133](../../Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs#L133) |
| R-23 | Asistencia duplicada | ExistAsistencia comprueba persona/fecha; ExistMarcacion y consultas actuales revisan sus claves. | Un COUNT previo no garantiza unicidad concurrente sin restricción. | [Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs:51](../../Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs#L51); [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:131](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L131) |
| R-24 | Consulta asistencia | Tipo de trabajador no cero, rango válido y locales seleccionados; otras validaciones se intercalan con preparación/escritura de datos. | No describir todo el flujo como sólo SELECT. | [Software/RecursosHumanos/RecursosHumanos/FrmConsultaAsistencias.cs:725](../../Software/RecursosHumanos/RecursosHumanos/FrmConsultaAsistencias.cs#L725); [Software/RecursosHumanos/RecursosHumanos/FrmConsultaAsistencias.cs:990](../../Software/RecursosHumanos/RecursosHumanos/FrmConsultaAsistencias.cs#L990) |
| R-25 | Feriado | Fecha distinta de default, motivo obligatorio hasta 200; altas normalizan fecha a Date. | Reconstituir permite datos históricos sin revalidarlos; repository limita duplicados de fecha/Id según operación. | [Software/RRHH.Domain/Asistencia/Feriado.cs:30](../../Software/RRHH.Domain/Asistencia/Feriado.cs#L30); [Software/RRHH.Domain/Asistencia/Feriado.cs:70](../../Software/RRHH.Domain/Asistencia/Feriado.cs#L70) |
| R-26 | Reporte semanal | COUNT(DISTINCT fecha) para días; horas usa diferencia salida-entrada limitada a cero. | Turnos nocturnos pueden computar cero si salida menor a entrada; es un riesgo matemático a contrastar. | [Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs:68](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs#L68) |
| R-27 | Tardanza | Minutos de entrada respecto de Ingreso1 usando GREATEST(0, diferencia) y regex de hora. | Regla localizada; requiere validar tolerancia, segundos, jornada y datos inválidos con el usuario. | [Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs:47](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs#L47) |
| R-28 | Reporte de ausencias | spRRHH_RepPermisos filtra FechaInicio BETWEEN rango y año actual de área. | Puede omitir una ausencia iniciada antes del rango y aún vigente; falta solapamiento general RF-18. | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:835](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L835) |
| R-29 | Exportación | Varias grillas exigen al menos una fila antes de exportar XLS y abrir Excel COM. | Regla duplicada, dependencia Excel y claves de protección incrustadas; no implica autorización de datos. | [Software/RecursosHumanos/RecursosHumanos/FrmConsultaHorarioEsp.cs:1095](../../Software/RecursosHumanos/RecursosHumanos/FrmConsultaHorarioEsp.cs#L1095); [Software/RecursosHumanos/RecursosHumanos/FrmRepPermisos.cs:846](../../Software/RecursosHumanos/RecursosHumanos/FrmRepPermisos.cs#L846) |
| R-30 | Catálogos simples | Definiciones con longitudes y campo extra, ItemCatalogo valida y presenter coordina guardado/borrado. | No aplicar estas definiciones automáticamente a Motivo, Horario o Feriado, que tienen reglas propias. | [Software/RRHH.Domain/Catalogos/DefinicionesCatalogo.cs:8](../../Software/RRHH.Domain/Catalogos/DefinicionesCatalogo.cs#L8); [Software/RRHH.Domain/Catalogos/ItemCatalogo.cs:7](../../Software/RRHH.Domain/Catalogos/ItemCatalogo.cs#L7) |

## Licencias, vacaciones y teletrabajo: existencia y ausencias

**Licencias:** hay tipo/motivos y una ruta genérica de permisos. El catálogo registrado incluye LICENCIA y motivos específicos; no se halló un control anual implementado para 30012 ni un literal 30012 en código/SQL. La ausencia de literal no excluye configuración en datos no inspeccionados; lo que falta en las rutas revisadas es una regla anual por persona/tipo y manejo de concurrencia. [docs/t2/evidencias/TEC-004/catalogos-solo-lectura.txt:10](../../docs/t2/evidencias/TEC-004/catalogos-solo-lectura.txt#L10); [Software/RecursosHumanos/RecursosHumanos/FrmPermiso.cs:1416](../../Software/RecursosHumanos/RecursosHumanos/FrmPermiso.cs#L1416).

**Vacaciones:** el registro de catálogo contiene VACACIONES, adelanto, permiso a cuenta y 1/2 JORNADA VACACIONES. Eso acredita categorías en esa consulta fechada, no un motor de devengos/saldos/truncas. No se encontró cálculo específico, libro de movimientos vacacionales, reporte dedicado ni autoservicio individual en las clases y scripts revisados. El flujo candidato es el de Permiso; su ejecución visual sigue pendiente. [docs/t2/evidencias/TEC-004/catalogos-solo-lectura.txt:38](../../docs/t2/evidencias/TEC-004/catalogos-solo-lectura.txt#L38); [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:695](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L695).

**Teletrabajo:** no se encontraron clases, tablas, consultas ni campos funcionales específicos de teletrabajo en C#/VB/SQL del inventario. HorarioTemporal y Local no deben renombrarse conceptualmente a teletrabajo sin una regla y modelo explícitos. La falta está acotada al código y esquema disponibles, no a un servidor desconocido. [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:714](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L714); [BD/schema.sql:1](../../BD/schema.sql#L1).

**Feriados:** existe mantenimiento y tabla RRHH_Feriado. No se halló consumo de ese calendario en LlenarPlanillaAsistencia; el puente preparador devuelve 0. No hay evidencia suficiente para dar por corregido RF-17. [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:786](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L786); [Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs:82](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs#L82).

## Búsquedas negativas reproducibles


### Licencia 30012

Sin coincidencias en los 1152 archivos C#/VB/SQL inspeccionados. Evidencia de alcance: [manifiesto de fuentes](01_arbol.md) y [scripts completos](03_modelo_datos.md). Se contrastó además el flujo genérico de permisos para evitar inferir ausencia sólo por nombre. [Software/RecursosHumanos/RecursosHumanos/FrmPermiso.cs:1416](../../Software/RecursosHumanos/RecursosHumanos/FrmPermiso.cs#L1416).

### Vacaciones / truncas

| Coincidencia textual | Evidencia |
|---|---|
| /// Crea un feriado válido con fecha truncada al día calendario (&lt;see cref="DateTime.Date"/&gt;) | [Software/RRHH.Domain/Asistencia/Feriado.cs:52](../../Software/RRHH.Domain/Asistencia/Feriado.cs#L52) |
| _db.Execute("TRUNCATE public.\"Empleado\", public.\"HorarioTemporal\", public.\"Asistencia\", public.\"Marcacion\";"); | [Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs:127](../../Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs#L127) |
| public void Crear_TruncaHoraDeLaFechaYNormalizaMotivo() | [Software/RRHH.Tests/Asistencia/FeriadoTests.cs:11](../../Software/RRHH.Tests/Asistencia/FeriadoTests.cs#L11) |

### Teletrabajo

Sin coincidencias en los 1152 archivos C#/VB/SQL inspeccionados. Evidencia de alcance: [manifiesto de fuentes](01_arbol.md) y [scripts completos](03_modelo_datos.md). Se contrastó además el flujo genérico de permisos para evitar inferir ausencia sólo por nombre. [Software/RecursosHumanos/RecursosHumanos/FrmPermiso.cs:1416](../../Software/RecursosHumanos/RecursosHumanos/FrmPermiso.cs#L1416).

### Feriados

| Coincidencia textual | Evidencia |
|---|---|
| -- Name: RRHH_Feriado; Type: TABLE; Schema: public; Owner: - | [BD/schema.sql:691](../../BD/schema.sql#L691) |
| CREATE TABLE public."RRHH_Feriado" ( | [BD/schema.sql:694](../../BD/schema.sql#L694) |
| "idFeriado" integer NOT NULL, | [BD/schema.sql:695](../../BD/schema.sql#L695) |
| /// Repositorio PostgreSQL de días feriados no laborables sobre &lt;c&gt;public."RRHH_Feriado"&lt;/c&gt;. | [Software/RRHH.PostgreSql/Asistencia/PostgreSqlFeriadoRepository.cs:12](../../Software/RRHH.PostgreSql/Asistencia/PostgreSqlFeriadoRepository.cs#L12) |
| /// Sustituye las llamadas combinadas a &lt;c&gt;RRHHClass.GetFeriado&lt;/c&gt; y &lt;c&gt;RRHH_FeriadoMapper&lt;/c&gt;. | [Software/RRHH.PostgreSql/Asistencia/PostgreSqlFeriadoRepository.cs:13](../../Software/RRHH.PostgreSql/Asistencia/PostgreSqlFeriadoRepository.cs#L13) |
| public sealed class PostgreSqlFeriadoRepository : IFeriadoRepository | [Software/RRHH.PostgreSql/Asistencia/PostgreSqlFeriadoRepository.cs:15](../../Software/RRHH.PostgreSql/Asistencia/PostgreSqlFeriadoRepository.cs#L15) |
| public const string Tabla = "RRHH_Feriado"; | [Software/RRHH.PostgreSql/Asistencia/PostgreSqlFeriadoRepository.cs:17](../../Software/RRHH.PostgreSql/Asistencia/PostgreSqlFeriadoRepository.cs#L17) |
| public const string ColumnaId = "idFeriado"; | [Software/RRHH.PostgreSql/Asistencia/PostgreSqlFeriadoRepository.cs:18](../../Software/RRHH.PostgreSql/Asistencia/PostgreSqlFeriadoRepository.cs#L18) |
| public PostgreSqlFeriadoRepository(PostgreSqlExecutor database) | [Software/RRHH.PostgreSql/Asistencia/PostgreSqlFeriadoRepository.cs:29](../../Software/RRHH.PostgreSql/Asistencia/PostgreSqlFeriadoRepository.cs#L29) |
| public IReadOnlyList&lt;Feriado&gt; Listar() | [Software/RRHH.PostgreSql/Asistencia/PostgreSqlFeriadoRepository.cs:34](../../Software/RRHH.PostgreSql/Asistencia/PostgreSqlFeriadoRepository.cs#L34) |
| .Select(row =&gt; Feriado.Reconstituir( | [Software/RRHH.PostgreSql/Asistencia/PostgreSqlFeriadoRepository.cs:42](../../Software/RRHH.PostgreSql/Asistencia/PostgreSqlFeriadoRepository.cs#L42) |
| public bool InsertarSiNoExisteFecha(Feriado feriado, out int idAsignado) | [Software/RRHH.PostgreSql/Asistencia/PostgreSqlFeriadoRepository.cs:61](../../Software/RRHH.PostgreSql/Asistencia/PostgreSqlFeriadoRepository.cs#L61) |
| if (feriado == null) | [Software/RRHH.PostgreSql/Asistencia/PostgreSqlFeriadoRepository.cs:63](../../Software/RRHH.PostgreSql/Asistencia/PostgreSqlFeriadoRepository.cs#L63) |
| throw new ArgumentNullException(nameof(feriado)); | [Software/RRHH.PostgreSql/Asistencia/PostgreSqlFeriadoRepository.cs:65](../../Software/RRHH.PostgreSql/Asistencia/PostgreSqlFeriadoRepository.cs#L65) |
| var parametroFecha = new PostgreSqlParameterValue("fecha", feriado.Fecha.Date, DbType.Date); | [Software/RRHH.PostgreSql/Asistencia/PostgreSqlFeriadoRepository.cs:68](../../Software/RRHH.PostgreSql/Asistencia/PostgreSqlFeriadoRepository.cs#L68) |
| var parametroMotivo = new PostgreSqlParameterValue("motivo", feriado.Motivo, DbType.String); | [Software/RRHH.PostgreSql/Asistencia/PostgreSqlFeriadoRepository.cs:69](../../Software/RRHH.PostgreSql/Asistencia/PostgreSqlFeriadoRepository.cs#L69) |
| /// Día feriado no laborable registrado en &lt;c&gt;public."RRHH_Feriado"&lt;/c&gt;. | [Software/RRHH.Domain/Asistencia/Feriado.cs:7](../../Software/RRHH.Domain/Asistencia/Feriado.cs#L7) |
| public sealed class Feriado | [Software/RRHH.Domain/Asistencia/Feriado.cs:9](../../Software/RRHH.Domain/Asistencia/Feriado.cs#L9) |
| private Feriado(int id, DateTime fecha, string motivo) | [Software/RRHH.Domain/Asistencia/Feriado.cs:13](../../Software/RRHH.Domain/Asistencia/Feriado.cs#L13) |
| /// &lt;summary&gt;Fecha del feriado normalizada al día calendario en altas nuevas.&lt;/summary&gt; | [Software/RRHH.Domain/Asistencia/Feriado.cs:23](../../Software/RRHH.Domain/Asistencia/Feriado.cs#L23) |
| /// Crea un feriado válido con fecha truncada al día calendario (&lt;see cref="DateTime.Date"/&gt;) | [Software/RRHH.Domain/Asistencia/Feriado.cs:52](../../Software/RRHH.Domain/Asistencia/Feriado.cs#L52) |
| public static Feriado Crear(int id, DateTime fecha, string motivo) | [Software/RRHH.Domain/Asistencia/Feriado.cs:55](../../Software/RRHH.Domain/Asistencia/Feriado.cs#L55) |
| return new Feriado(id, fecha.Date, motivo.Trim()); | [Software/RRHH.Domain/Asistencia/Feriado.cs:63](../../Software/RRHH.Domain/Asistencia/Feriado.cs#L63) |
| /// Reconstruye un feriado ya persistido sin volver a validarlo. | [Software/RRHH.Domain/Asistencia/Feriado.cs:67](../../Software/RRHH.Domain/Asistencia/Feriado.cs#L67) |
| public static Feriado Reconstituir(int id, DateTime fecha, string motivo) | [Software/RRHH.Domain/Asistencia/Feriado.cs:70](../../Software/RRHH.Domain/Asistencia/Feriado.cs#L70) |
| return new Feriado(id, fecha, motivo ?? string.Empty); | [Software/RRHH.Domain/Asistencia/Feriado.cs:72](../../Software/RRHH.Domain/Asistencia/Feriado.cs#L72) |
| public class FeriadoPresenterTests | [Software/RRHH.Tests/Asistencia/FeriadoPresenterTests.cs:10](../../Software/RRHH.Tests/Asistencia/FeriadoPresenterTests.cs#L10) |
| private readonly FakeFeriadoRepository _repository = new FakeFeriadoRepository(); | [Software/RRHH.Tests/Asistencia/FeriadoPresenterTests.cs:14](../../Software/RRHH.Tests/Asistencia/FeriadoPresenterTests.cs#L14) |
| private readonly FakeFeriadoView _view = new FakeFeriadoView(); | [Software/RRHH.Tests/Asistencia/FeriadoPresenterTests.cs:15](../../Software/RRHH.Tests/Asistencia/FeriadoPresenterTests.cs#L15) |
| _repository.Registros.Add(Feriado.Reconstituir(1, new DateTime(2026, 1, 1), "AÑO NUEVO")); | [Software/RRHH.Tests/Asistencia/FeriadoPresenterTests.cs:19](../../Software/RRHH.Tests/Asistencia/FeriadoPresenterTests.cs#L19) |
| _repository.Registros.Add(Feriado.Reconstituir(2, new DateTime(2026, 5, 1), "DIA DEL TRABAJO")); | [Software/RRHH.Tests/Asistencia/FeriadoPresenterTests.cs:20](../../Software/RRHH.Tests/Asistencia/FeriadoPresenterTests.cs#L20) |
| _ = new FeriadoPresenter( | [Software/RRHH.Tests/Asistencia/FeriadoPresenterTests.cs:22](../../Software/RRHH.Tests/Asistencia/FeriadoPresenterTests.cs#L22) |
| new ListarFeriados(_repository), | [Software/RRHH.Tests/Asistencia/FeriadoPresenterTests.cs:24](../../Software/RRHH.Tests/Asistencia/FeriadoPresenterTests.cs#L24) |
| new RegistrarFeriado(_repository), | [Software/RRHH.Tests/Asistencia/FeriadoPresenterTests.cs:25](../../Software/RRHH.Tests/Asistencia/FeriadoPresenterTests.cs#L25) |
| new EliminarFeriado(_repository), | [Software/RRHH.Tests/Asistencia/FeriadoPresenterTests.cs:26](../../Software/RRHH.Tests/Asistencia/FeriadoPresenterTests.cs#L26) |
| public void Cargar_MuestraLosFeriadosDelRepositorio() | [Software/RRHH.Tests/Asistencia/FeriadoPresenterTests.cs:31](../../Software/RRHH.Tests/Asistencia/FeriadoPresenterTests.cs#L31) |
| public void Agregar_FeriadoNuevo_InsertaRecargaYReiniciaControles() | [Software/RRHH.Tests/Asistencia/FeriadoPresenterTests.cs:43](../../Software/RRHH.Tests/Asistencia/FeriadoPresenterTests.cs#L43) |
| _view.FeriadoSeleccionado = null; | [Software/RRHH.Tests/Asistencia/FeriadoPresenterTests.cs:91](../../Software/RRHH.Tests/Asistencia/FeriadoPresenterTests.cs#L91) |
| "Primero debe Seleccionar un Feriado No Laborable.", | [Software/RRHH.Tests/Asistencia/FeriadoPresenterTests.cs:96](../../Software/RRHH.Tests/Asistencia/FeriadoPresenterTests.cs#L96) |
| _view.FeriadoSeleccionado = new FeriadoDto | [Software/RRHH.Tests/Asistencia/FeriadoPresenterTests.cs:106](../../Software/RRHH.Tests/Asistencia/FeriadoPresenterTests.cs#L106) |
| _view.FeriadoSeleccionado = new FeriadoDto | [Software/RRHH.Tests/Asistencia/FeriadoPresenterTests.cs:124](../../Software/RRHH.Tests/Asistencia/FeriadoPresenterTests.cs#L124) |
| FeriadoDto restante = Assert.Single(_view.Mostrados); | [Software/RRHH.Tests/Asistencia/FeriadoPresenterTests.cs:134](../../Software/RRHH.Tests/Asistencia/FeriadoPresenterTests.cs#L134) |
| Assert.Equal("No se pudo registrar el feriado: Conexión perdida", Assert.Single(_view.Alertas)); | [Software/RRHH.Tests/Asistencia/FeriadoPresenterTests.cs:149](../../Software/RRHH.Tests/Asistencia/FeriadoPresenterTests.cs#L149) |
| public class FeriadoTests | [Software/RRHH.Tests/Asistencia/FeriadoTests.cs:8](../../Software/RRHH.Tests/Asistencia/FeriadoTests.cs#L8) |
| Feriado feriado = Feriado.Crear(0, fechaConHora, "  FIESTAS PATRIAS  "); | [Software/RRHH.Tests/Asistencia/FeriadoTests.cs:15](../../Software/RRHH.Tests/Asistencia/FeriadoTests.cs#L15) |
| Assert.True(feriado.EsNuevo); | [Software/RRHH.Tests/Asistencia/FeriadoTests.cs:17](../../Software/RRHH.Tests/Asistencia/FeriadoTests.cs#L17) |
| Assert.Equal(new DateTime(2026, 7, 28), feriado.Fecha); | [Software/RRHH.Tests/Asistencia/FeriadoTests.cs:18](../../Software/RRHH.Tests/Asistencia/FeriadoTests.cs#L18) |
| Assert.Equal(TimeSpan.Zero, feriado.Fecha.TimeOfDay); | [Software/RRHH.Tests/Asistencia/FeriadoTests.cs:19](../../Software/RRHH.Tests/Asistencia/FeriadoTests.cs#L19) |
| Assert.Equal("FIESTAS PATRIAS", feriado.Motivo); | [Software/RRHH.Tests/Asistencia/FeriadoTests.cs:20](../../Software/RRHH.Tests/Asistencia/FeriadoTests.cs#L20) |
| string error = Feriado.Validar(new DateTime(2026, 7, 28), motivo); | [Software/RRHH.Tests/Asistencia/FeriadoTests.cs:29](../../Software/RRHH.Tests/Asistencia/FeriadoTests.cs#L29) |
| string error = Feriado.Validar(default, "AÑO NUEVO"); | [Software/RRHH.Tests/Asistencia/FeriadoTests.cs:37](../../Software/RRHH.Tests/Asistencia/FeriadoTests.cs#L37) |
| Assert.Null(Feriado.Validar(fecha, new string('A', 200))); | [Software/RRHH.Tests/Asistencia/FeriadoTests.cs:47](../../Software/RRHH.Tests/Asistencia/FeriadoTests.cs#L47) |
| Feriado.Validar(fecha, new string('A', 201))); | [Software/RRHH.Tests/Asistencia/FeriadoTests.cs:50](../../Software/RRHH.Tests/Asistencia/FeriadoTests.cs#L50) |
| Feriado.Crear(0, new DateTime(2026, 5, 1), new string('X', 201))); | [Software/RRHH.Tests/Asistencia/FeriadoTests.cs:57](../../Software/RRHH.Tests/Asistencia/FeriadoTests.cs#L57) |
| Feriado reconstituido = Feriado.Reconstituir(219, fechaHistorica, null); | [Software/RRHH.Tests/Asistencia/FeriadoTests.cs:67](../../Software/RRHH.Tests/Asistencia/FeriadoTests.cs#L67) |
| public class RegistrarFeriadoTests | [Software/RRHH.Tests/Asistencia/RegistrarFeriadoTests.cs:18](../../Software/RRHH.Tests/Asistencia/RegistrarFeriadoTests.cs#L18) |
| private readonly FakeFeriadoRepository _repository = new FakeFeriadoRepository(); | [Software/RRHH.Tests/Asistencia/RegistrarFeriadoTests.cs:20](../../Software/RRHH.Tests/Asistencia/RegistrarFeriadoTests.cs#L20) |
| var casoUso = new RegistrarFeriado(_repository); | [Software/RRHH.Tests/Asistencia/RegistrarFeriadoTests.cs:25](../../Software/RRHH.Tests/Asistencia/RegistrarFeriadoTests.cs#L25) |
| var dto = new RegistrarFeriadoDto | [Software/RRHH.Tests/Asistencia/RegistrarFeriadoTests.cs:26](../../Software/RRHH.Tests/Asistencia/RegistrarFeriadoTests.cs#L26) |
| Feriado.Reconstituir(271, new DateTime(2026, 1, 1, 11, 39, 43), "AÑO NUEVO")); | [Software/RRHH.Tests/Asistencia/RegistrarFeriadoTests.cs:45](../../Software/RRHH.Tests/Asistencia/RegistrarFeriadoTests.cs#L45) |
| var casoUso = new RegistrarFeriado(_repository); | [Software/RRHH.Tests/Asistencia/RegistrarFeriadoTests.cs:46](../../Software/RRHH.Tests/Asistencia/RegistrarFeriadoTests.cs#L46) |
| ResultadoOperacion resultado = casoUso.Ejecutar(new RegistrarFeriadoDto | [Software/RRHH.Tests/Asistencia/RegistrarFeriadoTests.cs:48](../../Software/RRHH.Tests/Asistencia/RegistrarFeriadoTests.cs#L48) |
| Feriado.Reconstituir(10, new DateTime(2026, 8, 6), "BATALLA DE JUNIN")); | [Software/RRHH.Tests/Asistencia/RegistrarFeriadoTests.cs:69](../../Software/RRHH.Tests/Asistencia/RegistrarFeriadoTests.cs#L69) |
| var casoUso = new RegistrarFeriado(_repository); | [Software/RRHH.Tests/Asistencia/RegistrarFeriadoTests.cs:70](../../Software/RRHH.Tests/Asistencia/RegistrarFeriadoTests.cs#L70) |
| ResultadoOperacion resultado = casoUso.Ejecutar(new RegistrarFeriadoDto | [Software/RRHH.Tests/Asistencia/RegistrarFeriadoTests.cs:72](../../Software/RRHH.Tests/Asistencia/RegistrarFeriadoTests.cs#L72) |
| var casoUso = new RegistrarFeriado(_repository); | [Software/RRHH.Tests/Asistencia/RegistrarFeriadoTests.cs:90](../../Software/RRHH.Tests/Asistencia/RegistrarFeriadoTests.cs#L90) |
| return casoUso.Ejecutar(new RegistrarFeriadoDto | [Software/RRHH.Tests/Asistencia/RegistrarFeriadoTests.cs:96](../../Software/RRHH.Tests/Asistencia/RegistrarFeriadoTests.cs#L96) |
| return casoUso.Ejecutar(new RegistrarFeriadoDto | [Software/RRHH.Tests/Asistencia/RegistrarFeriadoTests.cs:106](../../Software/RRHH.Tests/Asistencia/RegistrarFeriadoTests.cs#L106) |
| public void ElMapeoDeFeriadoCoincideConElEsquema() | [Software/RRHH.Tests/Asistencia/RegistrarFeriadoTests.cs:122](../../Software/RRHH.Tests/Asistencia/RegistrarFeriadoTests.cs#L122) |
| Dictionary&lt;string, string&gt; columnas = LeerColumnasTabla(PostgreSqlFeriadoRepository.Tabla); | [Software/RRHH.Tests/Asistencia/RegistrarFeriadoTests.cs:124](../../Software/RRHH.Tests/Asistencia/RegistrarFeriadoTests.cs#L124) |
| Assert.True(columnas.ContainsKey(PostgreSqlFeriadoRepository.ColumnaId)); | [Software/RRHH.Tests/Asistencia/RegistrarFeriadoTests.cs:126](../../Software/RRHH.Tests/Asistencia/RegistrarFeriadoTests.cs#L126) |
| Assert.StartsWith("integer", columnas[PostgreSqlFeriadoRepository.ColumnaId]); | [Software/RRHH.Tests/Asistencia/RegistrarFeriadoTests.cs:127](../../Software/RRHH.Tests/Asistencia/RegistrarFeriadoTests.cs#L127) |
| Assert.True(columnas.ContainsKey(PostgreSqlFeriadoRepository.ColumnaFecha)); | [Software/RRHH.Tests/Asistencia/RegistrarFeriadoTests.cs:129](../../Software/RRHH.Tests/Asistencia/RegistrarFeriadoTests.cs#L129) |
| Assert.StartsWith("timestamp", columnas[PostgreSqlFeriadoRepository.ColumnaFecha]); | [Software/RRHH.Tests/Asistencia/RegistrarFeriadoTests.cs:130](../../Software/RRHH.Tests/Asistencia/RegistrarFeriadoTests.cs#L130) |
| Assert.True(columnas.ContainsKey(PostgreSqlFeriadoRepository.ColumnaMotivo)); | [Software/RRHH.Tests/Asistencia/RegistrarFeriadoTests.cs:132](../../Software/RRHH.Tests/Asistencia/RegistrarFeriadoTests.cs#L132) |
| $"character varying({Feriado.LongitudMaximaMotivo})", | [Software/RRHH.Tests/Asistencia/RegistrarFeriadoTests.cs:134](../../Software/RRHH.Tests/Asistencia/RegistrarFeriadoTests.cs#L134) |
| columnas[PostgreSqlFeriadoRepository.ColumnaMotivo]); | [Software/RRHH.Tests/Asistencia/RegistrarFeriadoTests.cs:135](../../Software/RRHH.Tests/Asistencia/RegistrarFeriadoTests.cs#L135) |
| internal sealed class FakeFeriadoView : IFeriadoView | [Software/RRHH.Tests/Fakes/FakeFeriadoView.cs:8](../../Software/RRHH.Tests/Fakes/FakeFeriadoView.cs#L8) |
| public FeriadoDto FeriadoSeleccionado { get; set; } | [Software/RRHH.Tests/Fakes/FakeFeriadoView.cs:14](../../Software/RRHH.Tests/Fakes/FakeFeriadoView.cs#L14) |
| public IList&lt;FeriadoDto&gt; Mostrados { get; private set; } = new List&lt;FeriadoDto&gt;(); | [Software/RRHH.Tests/Fakes/FakeFeriadoView.cs:18](../../Software/RRHH.Tests/Fakes/FakeFeriadoView.cs#L18) |
| public void MostrarFeriados(IList&lt;FeriadoDto&gt; feriados) | [Software/RRHH.Tests/Fakes/FakeFeriadoView.cs:40](../../Software/RRHH.Tests/Fakes/FakeFeriadoView.cs#L40) |
| Mostrados = feriados; | [Software/RRHH.Tests/Fakes/FakeFeriadoView.cs:42](../../Software/RRHH.Tests/Fakes/FakeFeriadoView.cs#L42) |
| internal sealed class FakeFeriadoRepository : IFeriadoRepository | [Software/RRHH.Tests/Fakes/FakeFeriadoRepository.cs:9](../../Software/RRHH.Tests/Fakes/FakeFeriadoRepository.cs#L9) |
| public List&lt;Feriado&gt; Registros { get; } = new List&lt;Feriado&gt;(); | [Software/RRHH.Tests/Fakes/FakeFeriadoRepository.cs:13](../../Software/RRHH.Tests/Fakes/FakeFeriadoRepository.cs#L13) |
| public IReadOnlyList&lt;Feriado&gt; Listar() | [Software/RRHH.Tests/Fakes/FakeFeriadoRepository.cs:21](../../Software/RRHH.Tests/Fakes/FakeFeriadoRepository.cs#L21) |
| public bool InsertarSiNoExisteFecha(Feriado feriado, out int idAsignado) | [Software/RRHH.Tests/Fakes/FakeFeriadoRepository.cs:43](../../Software/RRHH.Tests/Fakes/FakeFeriadoRepository.cs#L43) |
| DateTime dia = feriado.Fecha.Date; | [Software/RRHH.Tests/Fakes/FakeFeriadoRepository.cs:52](../../Software/RRHH.Tests/Fakes/FakeFeriadoRepository.cs#L52) |
| Registros.Add(Feriado.Reconstituir(idAsignado, feriado.Fecha, feriado.Motivo)); | [Software/RRHH.Tests/Fakes/FakeFeriadoRepository.cs:60](../../Software/RRHH.Tests/Fakes/FakeFeriadoRepository.cs#L60) |
| /// Contrato de persistencia para los días feriados no laborables. | [Software/RRHH.Application/Asistencia/IFeriadoRepository.cs:8](../../Software/RRHH.Application/Asistencia/IFeriadoRepository.cs#L8) |
| public interface IFeriadoRepository | [Software/RRHH.Application/Asistencia/IFeriadoRepository.cs:10](../../Software/RRHH.Application/Asistencia/IFeriadoRepository.cs#L10) |
| IReadOnlyList&lt;Feriado&gt; Listar(); | [Software/RRHH.Application/Asistencia/IFeriadoRepository.cs:12](../../Software/RRHH.Application/Asistencia/IFeriadoRepository.cs#L12) |
| /// Verifica la unicidad por día calendario e inserta el feriado de forma atómica. | [Software/RRHH.Application/Asistencia/IFeriadoRepository.cs:17](../../Software/RRHH.Application/Asistencia/IFeriadoRepository.cs#L17) |
| /// Devuelve &lt;c&gt;false&lt;/c&gt; cuando ya existe un feriado para ese día calendario. | [Software/RRHH.Application/Asistencia/IFeriadoRepository.cs:18](../../Software/RRHH.Application/Asistencia/IFeriadoRepository.cs#L18) |
| bool InsertarSiNoExisteFecha(Feriado feriado, out int idAsignado); | [Software/RRHH.Application/Asistencia/IFeriadoRepository.cs:20](../../Software/RRHH.Application/Asistencia/IFeriadoRepository.cs#L20) |
| /// Datos de entrada y salida al registrar un feriado nuevo. | [Software/RRHH.Application/Asistencia/RegistrarFeriadoDto.cs:6](../../Software/RRHH.Application/Asistencia/RegistrarFeriadoDto.cs#L6) |
| public sealed class RegistrarFeriadoDto | [Software/RRHH.Application/Asistencia/RegistrarFeriadoDto.cs:8](../../Software/RRHH.Application/Asistencia/RegistrarFeriadoDto.cs#L8) |
| /// Obtiene el listado completo de feriados registrados. | [Software/RRHH.Application/Asistencia/ListarFeriados.cs:8](../../Software/RRHH.Application/Asistencia/ListarFeriados.cs#L8) |
| public sealed class ListarFeriados | [Software/RRHH.Application/Asistencia/ListarFeriados.cs:10](../../Software/RRHH.Application/Asistencia/ListarFeriados.cs#L10) |
| private readonly IFeriadoRepository _repository; | [Software/RRHH.Application/Asistencia/ListarFeriados.cs:12](../../Software/RRHH.Application/Asistencia/ListarFeriados.cs#L12) |
| public ListarFeriados(IFeriadoRepository repository) | [Software/RRHH.Application/Asistencia/ListarFeriados.cs:14](../../Software/RRHH.Application/Asistencia/ListarFeriados.cs#L14) |
| public IList&lt;FeriadoDto&gt; Ejecutar() | [Software/RRHH.Application/Asistencia/ListarFeriados.cs:19](../../Software/RRHH.Application/Asistencia/ListarFeriados.cs#L19) |
| .Select(feriado =&gt; new FeriadoDto | [Software/RRHH.Application/Asistencia/ListarFeriados.cs:22](../../Software/RRHH.Application/Asistencia/ListarFeriados.cs#L22) |
| Id = feriado.Id, | [Software/RRHH.Application/Asistencia/ListarFeriados.cs:24](../../Software/RRHH.Application/Asistencia/ListarFeriados.cs#L24) |
| Fecha = feriado.Fecha, | [Software/RRHH.Application/Asistencia/ListarFeriados.cs:25](../../Software/RRHH.Application/Asistencia/ListarFeriados.cs#L25) |
| Motivo = feriado.Motivo | [Software/RRHH.Application/Asistencia/ListarFeriados.cs:26](../../Software/RRHH.Application/Asistencia/ListarFeriados.cs#L26) |
| /// Registro de feriado expuesto a la capa de presentación. | [Software/RRHH.Application/Asistencia/FeriadoDto.cs:6](../../Software/RRHH.Application/Asistencia/FeriadoDto.cs#L6) |
| public sealed class FeriadoDto | [Software/RRHH.Application/Asistencia/FeriadoDto.cs:8](../../Software/RRHH.Application/Asistencia/FeriadoDto.cs#L8) |
| /// Elimina un feriado registrado por su identificador. | [Software/RRHH.Application/Asistencia/EliminarFeriado.cs:7](../../Software/RRHH.Application/Asistencia/EliminarFeriado.cs#L7) |
| public sealed class EliminarFeriado | [Software/RRHH.Application/Asistencia/EliminarFeriado.cs:9](../../Software/RRHH.Application/Asistencia/EliminarFeriado.cs#L9) |
| private readonly IFeriadoRepository _repository; | [Software/RRHH.Application/Asistencia/EliminarFeriado.cs:11](../../Software/RRHH.Application/Asistencia/EliminarFeriado.cs#L11) |
| public EliminarFeriado(IFeriadoRepository repository) | [Software/RRHH.Application/Asistencia/EliminarFeriado.cs:13](../../Software/RRHH.Application/Asistencia/EliminarFeriado.cs#L13) |
| return ResultadoOperacion.Error("Primero debe Seleccionar un Feriado No Laborable."); | [Software/RRHH.Application/Asistencia/EliminarFeriado.cs:22](../../Software/RRHH.Application/Asistencia/EliminarFeriado.cs#L22) |
| /// Valida y registra un día feriado nuevo garantizando unicidad por día calendario. | [Software/RRHH.Application/Asistencia/RegistrarFeriado.cs:9](../../Software/RRHH.Application/Asistencia/RegistrarFeriado.cs#L9) |
| public sealed class RegistrarFeriado | [Software/RRHH.Application/Asistencia/RegistrarFeriado.cs:11](../../Software/RRHH.Application/Asistencia/RegistrarFeriado.cs#L11) |
| private readonly IFeriadoRepository _repository; | [Software/RRHH.Application/Asistencia/RegistrarFeriado.cs:15](../../Software/RRHH.Application/Asistencia/RegistrarFeriado.cs#L15) |
| public RegistrarFeriado(IFeriadoRepository repository) | [Software/RRHH.Application/Asistencia/RegistrarFeriado.cs:17](../../Software/RRHH.Application/Asistencia/RegistrarFeriado.cs#L17) |
| public ResultadoOperacion Ejecutar(RegistrarFeriadoDto dto) | [Software/RRHH.Application/Asistencia/RegistrarFeriado.cs:22](../../Software/RRHH.Application/Asistencia/RegistrarFeriado.cs#L22) |
| Feriado feriado; | [Software/RRHH.Application/Asistencia/RegistrarFeriado.cs:29](../../Software/RRHH.Application/Asistencia/RegistrarFeriado.cs#L29) |
| feriado = Feriado.Crear(0, dto.Fecha, dto.Motivo); | [Software/RRHH.Application/Asistencia/RegistrarFeriado.cs:32](../../Software/RRHH.Application/Asistencia/RegistrarFeriado.cs#L32) |
| if (!_repository.InsertarSiNoExisteFecha(feriado, out int idAsignado)) | [Software/RRHH.Application/Asistencia/RegistrarFeriado.cs:39](../../Software/RRHH.Application/Asistencia/RegistrarFeriado.cs#L39) |
| dto.Fecha = feriado.Fecha; | [Software/RRHH.Application/Asistencia/RegistrarFeriado.cs:45](../../Software/RRHH.Application/Asistencia/RegistrarFeriado.cs#L45) |
| dto.Motivo = feriado.Motivo; | [Software/RRHH.Application/Asistencia/RegistrarFeriado.cs:46](../../Software/RRHH.Application/Asistencia/RegistrarFeriado.cs#L46) |
| public class FrmFeriado : FrmConsulta, IFeriadoView | [Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs:25](../../Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs#L25) |
| [AccessedThroughProperty("GridControlFeriado")] | [Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs:40](../../Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs#L40) |
| private GridControl _GridControlFeriado; | [Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs:41](../../Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs#L41) |
| internal GridControl GridControlFeriado | [Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs:127](../../Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs#L127) |
| return _GridControlFeriado; | [Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs:132](../../Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs#L132) |
| _GridControlFeriado = value; | [Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs:138](../../Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs#L138) |
| public FrmFeriado() | [Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs:271](../../Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs#L271) |
| base.Load += FrmFeriado_Load; | [Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs:273](../../Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs#L273) |
| this.GridControlFeriado = new DevExpress.XtraGrid.GridControl(); | [Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs:340](../../Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs#L340) |
| ((System.ComponentModel.ISupportInitialize)this.GridControlFeriado).BeginInit(); | [Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs:349](../../Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs#L349) |
| this.GridControlFeriado.Anchor = System.Windows.Forms.AnchorStyles.Top \| System.Windows.Forms.AnchorStyles.Left \| System.Windows.Forms.AnchorStyles.Right; | [Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs:417](../../Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs#L417) |
| DevExpress.XtraGrid.GridControl gridControlFeriado = this.GridControlFeriado; | [Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs:418](../../Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs#L418) |
| gridControlFeriado.Location = location; | [Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs:420](../../Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs#L420) |
| this.GridControlFeriado.MainView = this.GridView1; | [Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs:421](../../Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs#L421) |
| this.GridControlFeriado.Name = "GridControlFeriado"; | [Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs:422](../../Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs#L422) |
| DevExpress.XtraGrid.GridControl gridControlFeriado2 = this.GridControlFeriado; | [Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs:423](../../Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs#L423) |
| gridControlFeriado2.Size = size; | [Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs:425](../../Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs#L425) |
| this.GridControlFeriado.TabIndex = 1; | [Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs:426](../../Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs#L426) |
| this.GridControlFeriado.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[1] { this.GridView1 }); | [Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs:427](../../Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs#L427) |
| this.GridView1.GridControl = this.GridControlFeriado; | [Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs:428](../../Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs#L428) |
| this.GroupControl1.Controls.Add(this.GridControlFeriado); | [Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs:438](../../Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs#L438) |
| this.GroupControl1.Text = "Detalle Feriados"; | [Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs:448](../../Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs#L448) |
| this.GroupControl2.Text = "Datos Feriado"; | [Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs:489](../../Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs#L489) |
| this.Name = "FrmFeriado"; | [Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs:530](../../Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs#L530) |
| this.Titulo = "Feriados"; | [Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs:532](../../Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs#L532) |
| this.TituloFrm = "Feriados"; | [Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs:533](../../Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs#L533) |
| ((System.ComponentModel.ISupportInitialize)this.GridControlFeriado).EndInit(); | [Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs:540](../../Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs#L540) |
| public FeriadoDto FeriadoSeleccionado =&gt; | [Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs:557](../../Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs#L557) |
| : GridView1.GetRow(GridView1.FocusedRowHandle) as FeriadoDto; | [Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs:560](../../Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs#L560) |
| public void MostrarFeriados(IList&lt;FeriadoDto&gt; feriados) | [Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs:562](../../Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs#L562) |
| GridControlFeriado.DataSource = feriados; | [Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs:564](../../Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs#L564) |
| GridColumn columnaId = GridView1.Columns.ColumnByFieldName(nameof(FeriadoDto.Id)); | [Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs:569](../../Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs#L569) |
| "Desea eliminar el Feriado con Fecha: " + Strings.FormatDateTime(fecha, DateFormat.ShortDate), | [Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs:585](../../Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs#L585) |
| private void FrmFeriado_Load(object sender, EventArgs e) | [Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs:606](../../Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs#L606) |
| [AccessedThroughProperty("FeriadosToolStripMenuItem1")] | [Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:152](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L152) |
| private ToolStripMenuItem _FeriadosToolStripMenuItem1; | [Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:153](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L153) |
| private FrmFeriado ObjFrmFeriado; | [Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:244](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L244) |
| internal ToolStripMenuItem FeriadosToolStripMenuItem1 | [Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:1187](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L1187) |
| return _FeriadosToolStripMenuItem1; | [Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:1192](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L1192) |
| EventHandler value2 = FeriadosToolStripMenuItem1_Click; | [Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:1198](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L1198) |
| if (_FeriadosToolStripMenuItem1 != null) | [Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:1199](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L1199) |
| _FeriadosToolStripMenuItem1.Click -= value2; | [Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:1201](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L1201) |
| _FeriadosToolStripMenuItem1 = value; | [Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:1203](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L1203) |
| if (_FeriadosToolStripMenuItem1 != null) | [Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:1204](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L1204) |
| _FeriadosToolStripMenuItem1.Click += value2; | [Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:1206](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L1206) |
| this.FeriadosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem(); | [Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:1738](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L1738) |
| this.MotivoDePermisoToolStripMenuItem, this.TipoDePermisoToolStripMenuItem, this.FeriadosToolStripMenuItem1, this.HorariosToolStripMenuItem | [Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:1832](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L1832) |
| this.FeriadosToolStripMenuItem1.Name = "FeriadosToolStripMenuItem1"; | [Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:1899](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L1899) |
| System.Windows.Forms.ToolStripMenuItem feriadosToolStripMenuItem = this.FeriadosToolStripMenuItem1; | [Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:1900](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L1900) |
| feriadosToolStripMenuItem.Size = size; | [Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:1902](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L1902) |
| this.FeriadosToolStripMenuItem1.Text = "Feriados"; | [Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:1903](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L1903) |
| this.ToolStripButton10.Text = "Agregar Feriados"; | [Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2127](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2127) |
| FeriadosToolStripMenuItem1.Visible = false; | [Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2244](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2244) |
| if (ObjFrmFeriado == null \|\| (ObjFrmFeriado.IsDisposed ? true : false)) | [Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2638](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2638) |
| ObjFrmFeriado = CompositionRoot.CrearFeriado(); | [Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2640](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2640) |
| ObjFrmFeriado.BringToFront(); | [Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2644](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2644) |
| ObjFrmFeriado.MdiParent = this; | [Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2646](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2646) |
| ObjFrmFeriado.Show(); | [Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2647](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2647) |
| private void FeriadosToolStripMenuItem1_Click(object sender, EventArgs e) | [Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2678](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2678) |
| if (ObjFrmFeriado == null \|\| (ObjFrmFeriado.IsDisposed ? true : false)) | [Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2680](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2680) |
| ObjFrmFeriado = CompositionRoot.CrearFeriado(); | [Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2682](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2682) |
| ObjFrmFeriado.BringToFront(); | [Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2686](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2686) |
| ObjFrmFeriado.MdiParent = this; | [Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2688](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2688) |
| ObjFrmFeriado.Show(); | [Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2689](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2689) |
| /// &lt;summary&gt;Crea el formulario de gestión de feriados con su presenter conectado.&lt;/summary&gt; | [Software/RecursosHumanos/RecursosHumanos/CompositionRoot.cs:116](../../Software/RecursosHumanos/RecursosHumanos/CompositionRoot.cs#L116) |
| public static FrmFeriado CrearFeriado() | [Software/RecursosHumanos/RecursosHumanos/CompositionRoot.cs:117](../../Software/RecursosHumanos/RecursosHumanos/CompositionRoot.cs#L117) |
| FrmFeriado form = new FrmFeriado(); | [Software/RecursosHumanos/RecursosHumanos/CompositionRoot.cs:119](../../Software/RecursosHumanos/RecursosHumanos/CompositionRoot.cs#L119) |
| IFeriadoRepository repository = new PostgreSqlFeriadoRepository(Database.Value); | [Software/RecursosHumanos/RecursosHumanos/CompositionRoot.cs:120](../../Software/RecursosHumanos/RecursosHumanos/CompositionRoot.cs#L120) |
| _ = new FeriadoPresenter( | [Software/RecursosHumanos/RecursosHumanos/CompositionRoot.cs:121](../../Software/RecursosHumanos/RecursosHumanos/CompositionRoot.cs#L121) |
| new ListarFeriados(repository), | [Software/RecursosHumanos/RecursosHumanos/CompositionRoot.cs:123](../../Software/RecursosHumanos/RecursosHumanos/CompositionRoot.cs#L123) |
| new RegistrarFeriado(repository), | [Software/RecursosHumanos/RecursosHumanos/CompositionRoot.cs:124](../../Software/RecursosHumanos/RecursosHumanos/CompositionRoot.cs#L124) |
| new EliminarFeriado(repository)); | [Software/RecursosHumanos/RecursosHumanos/CompositionRoot.cs:125](../../Software/RecursosHumanos/RecursosHumanos/CompositionRoot.cs#L125) |
| public FrmFeriado m_FrmFeriado; | [Software/RecursosHumanos/RecursosHumanos/My/MyProject.cs:60](../../Software/RecursosHumanos/RecursosHumanos/My/MyProject.cs#L60) |
| public FrmFeriado FrmFeriado | [Software/RecursosHumanos/RecursosHumanos/My/MyProject.cs:553](../../Software/RecursosHumanos/RecursosHumanos/My/MyProject.cs#L553) |
| m_FrmFeriado = Create__Instance__(m_FrmFeriado); | [Software/RecursosHumanos/RecursosHumanos/My/MyProject.cs:558](../../Software/RecursosHumanos/RecursosHumanos/My/MyProject.cs#L558) |
| return m_FrmFeriado; | [Software/RecursosHumanos/RecursosHumanos/My/MyProject.cs:559](../../Software/RecursosHumanos/RecursosHumanos/My/MyProject.cs#L559) |
| if (value != m_FrmFeriado) | [Software/RecursosHumanos/RecursosHumanos/My/MyProject.cs:564](../../Software/RecursosHumanos/RecursosHumanos/My/MyProject.cs#L564) |
| Dispose__Instance__(ref m_FrmFeriado); | [Software/RecursosHumanos/RecursosHumanos/My/MyProject.cs:570](../../Software/RecursosHumanos/RecursosHumanos/My/MyProject.cs#L570) |
| /// Contrato de vista pasiva para la pantalla de gestión de feriados (&lt;c&gt;FrmFeriado&lt;/c&gt;). | [Software/RRHH.Presentation/Asistencia/IFeriadoView.cs:8](../../Software/RRHH.Presentation/Asistencia/IFeriadoView.cs#L8) |
| public interface IFeriadoView | [Software/RRHH.Presentation/Asistencia/IFeriadoView.cs:10](../../Software/RRHH.Presentation/Asistencia/IFeriadoView.cs#L10) |
| FeriadoDto FeriadoSeleccionado { get; } | [Software/RRHH.Presentation/Asistencia/IFeriadoView.cs:22](../../Software/RRHH.Presentation/Asistencia/IFeriadoView.cs#L22) |
| void MostrarFeriados(IList&lt;FeriadoDto&gt; feriados); | [Software/RRHH.Presentation/Asistencia/IFeriadoView.cs:24](../../Software/RRHH.Presentation/Asistencia/IFeriadoView.cs#L24) |
| /// Coordina el listado, registro y eliminación de feriados sobre &lt;see cref="IFeriadoView"/&gt;. | [Software/RRHH.Presentation/Asistencia/FeriadoPresenter.cs:8](../../Software/RRHH.Presentation/Asistencia/FeriadoPresenter.cs#L8) |
| public sealed class FeriadoPresenter | [Software/RRHH.Presentation/Asistencia/FeriadoPresenter.cs:10](../../Software/RRHH.Presentation/Asistencia/FeriadoPresenter.cs#L10) |
| public const string MensajeSeleccionRequerida = "Primero debe Seleccionar un Feriado No Laborable."; | [Software/RRHH.Presentation/Asistencia/FeriadoPresenter.cs:12](../../Software/RRHH.Presentation/Asistencia/FeriadoPresenter.cs#L12) |
| private readonly IFeriadoView _view; | [Software/RRHH.Presentation/Asistencia/FeriadoPresenter.cs:14](../../Software/RRHH.Presentation/Asistencia/FeriadoPresenter.cs#L14) |
| private readonly ListarFeriados _listar; | [Software/RRHH.Presentation/Asistencia/FeriadoPresenter.cs:15](../../Software/RRHH.Presentation/Asistencia/FeriadoPresenter.cs#L15) |
| private readonly RegistrarFeriado _registrar; | [Software/RRHH.Presentation/Asistencia/FeriadoPresenter.cs:16](../../Software/RRHH.Presentation/Asistencia/FeriadoPresenter.cs#L16) |
| private readonly EliminarFeriado _eliminar; | [Software/RRHH.Presentation/Asistencia/FeriadoPresenter.cs:17](../../Software/RRHH.Presentation/Asistencia/FeriadoPresenter.cs#L17) |
| public FeriadoPresenter( | [Software/RRHH.Presentation/Asistencia/FeriadoPresenter.cs:20](../../Software/RRHH.Presentation/Asistencia/FeriadoPresenter.cs#L20) |
| IFeriadoView view, | [Software/RRHH.Presentation/Asistencia/FeriadoPresenter.cs:21](../../Software/RRHH.Presentation/Asistencia/FeriadoPresenter.cs#L21) |
| ListarFeriados listar, | [Software/RRHH.Presentation/Asistencia/FeriadoPresenter.cs:22](../../Software/RRHH.Presentation/Asistencia/FeriadoPresenter.cs#L22) |
| RegistrarFeriado registrar, | [Software/RRHH.Presentation/Asistencia/FeriadoPresenter.cs:23](../../Software/RRHH.Presentation/Asistencia/FeriadoPresenter.cs#L23) |
| EliminarFeriado eliminar, | [Software/RRHH.Presentation/Asistencia/FeriadoPresenter.cs:24](../../Software/RRHH.Presentation/Asistencia/FeriadoPresenter.cs#L24) |
| _view.MostrarFeriados(_listar.Ejecutar()); | [Software/RRHH.Presentation/Asistencia/FeriadoPresenter.cs:42](../../Software/RRHH.Presentation/Asistencia/FeriadoPresenter.cs#L42) |
| _view.MostrarAlerta("No se pudieron cargar los feriados: " + ex.Message); | [Software/RRHH.Presentation/Asistencia/FeriadoPresenter.cs:46](../../Software/RRHH.Presentation/Asistencia/FeriadoPresenter.cs#L46) |
| var dto = new RegistrarFeriadoDto | [Software/RRHH.Presentation/Asistencia/FeriadoPresenter.cs:52](../../Software/RRHH.Presentation/Asistencia/FeriadoPresenter.cs#L52) |
| _view.MostrarAlerta("No se pudo registrar el feriado: " + ex.Message); | [Software/RRHH.Presentation/Asistencia/FeriadoPresenter.cs:65](../../Software/RRHH.Presentation/Asistencia/FeriadoPresenter.cs#L65) |
| FeriadoDto seleccionado = _view.FeriadoSeleccionado; | [Software/RRHH.Presentation/Asistencia/FeriadoPresenter.cs:81](../../Software/RRHH.Presentation/Asistencia/FeriadoPresenter.cs#L81) |
| _view.MostrarAlerta("No se pudo eliminar el feriado: " + ex.Message); | [Software/RRHH.Presentation/Asistencia/FeriadoPresenter.cs:100](../../Software/RRHH.Presentation/Asistencia/FeriadoPresenter.cs#L100) |
| public class RRHH_FeriadoMapper : GenericMapper&lt;RRHH_Feriado, dcGRLLDataContext&gt; | [Software/GRLL/GRLL/Common/RRHH_FeriadoMapper.cs:5](../../Software/GRLL/GRLL/Common/RRHH_FeriadoMapper.cs#L5) |
| public RRHH_FeriadoMapper() | [Software/GRLL/GRLL/Common/RRHH_FeriadoMapper.cs:8](../../Software/GRLL/GRLL/Common/RRHH_FeriadoMapper.cs#L8) |
| public static GenericMapper&lt;RRHH_Feriado, dcGRLLDataContext&gt; Instance() | [Software/GRLL/GRLL/Common/RRHH_FeriadoMapper.cs:12](../../Software/GRLL/GRLL/Common/RRHH_FeriadoMapper.cs#L12) |
| GenericMapper&lt;RRHH_Feriado, dcGRLLDataContext&gt;.DataContext = new dcGRLLDataContext(clsConexion.Conexion); | [Software/GRLL/GRLL/Common/RRHH_FeriadoMapper.cs:14](../../Software/GRLL/GRLL/Common/RRHH_FeriadoMapper.cs#L14) |
| return GenericMapper&lt;RRHH_Feriado, dcGRLLDataContext&gt;.InstanceBase(); | [Software/GRLL/GRLL/Common/RRHH_FeriadoMapper.cs:15](../../Software/GRLL/GRLL/Common/RRHH_FeriadoMapper.cs#L15) |
| public Table&lt;RRHH_Feriado&gt; RRHH_Feriado =&gt; GetTable&lt;RRHH_Feriado&gt;(); | [Software/GRLL/GRLL/Common/dcGRLLDataContext.cs:322](../../Software/GRLL/GRLL/Common/dcGRLLDataContext.cs#L322) |
| [Table(Name = "dbo.RRHH_Feriado")] | [Software/GRLL/GRLL/Common/RRHH_Feriado.cs:8](../../Software/GRLL/GRLL/Common/RRHH_Feriado.cs#L8) |
| public class RRHH_Feriado : INotifyPropertyChanging, INotifyPropertyChanged | [Software/GRLL/GRLL/Common/RRHH_Feriado.cs:9](../../Software/GRLL/GRLL/Common/RRHH_Feriado.cs#L9) |
| private int _idFeriado; | [Software/GRLL/GRLL/Common/RRHH_Feriado.cs:13](../../Software/GRLL/GRLL/Common/RRHH_Feriado.cs#L13) |
| [Column(Storage = "_idFeriado", DbType = "Int NOT NULL", IsPrimaryKey = true)] | [Software/GRLL/GRLL/Common/RRHH_Feriado.cs:19](../../Software/GRLL/GRLL/Common/RRHH_Feriado.cs#L19) |
| public int idFeriado | [Software/GRLL/GRLL/Common/RRHH_Feriado.cs:20](../../Software/GRLL/GRLL/Common/RRHH_Feriado.cs#L20) |
| return _idFeriado; | [Software/GRLL/GRLL/Common/RRHH_Feriado.cs:24](../../Software/GRLL/GRLL/Common/RRHH_Feriado.cs#L24) |
| if (_idFeriado != value) | [Software/GRLL/GRLL/Common/RRHH_Feriado.cs:28](../../Software/GRLL/GRLL/Common/RRHH_Feriado.cs#L28) |
| _idFeriado = value; | [Software/GRLL/GRLL/Common/RRHH_Feriado.cs:31](../../Software/GRLL/GRLL/Common/RRHH_Feriado.cs#L31) |
| SendPropertyChanged("idFeriado"); | [Software/GRLL/GRLL/Common/RRHH_Feriado.cs:32](../../Software/GRLL/GRLL/Common/RRHH_Feriado.cs#L32) |
