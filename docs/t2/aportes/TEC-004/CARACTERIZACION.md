# TEC-004: caracterización estática y diagnóstico inicial

Responsable del paquete: Evelyn Victoria Rodriguez Cardozo. Inspección asistida por IA, 17/10/2026. Base: f713383. No se ejecutó la interfaz Windows: los siguientes hallazgos se deducen del código recuperado/puente actual, no de capturas del ejecutable original.

## Entradas, procesos y salidas

- Entrada: tipo de permiso seleccionado, rol de sesión, selección de motivo, descripción, abreviatura y salario.
- Consulta: FrmMotivoPermiso carga TipoPermiso y usa PostgreSqlLegacyContext.spRRHH_getMotivo_perm con modalidad P (rol 10), C (14) o null (13).
- Alta/edición: FrmMantMotivo construye Motivo_Perm y utiliza el mapper PostgreSQL local.
- Salida: grilla por tipo/modalidad, confirmación de borrado y cierre del editor con DialogResult.OK.
- Tablas inspeccionadas: TipoPermiso, Motivo_Perm, Permiso y Permiso_Aud. Las columnas de auditoría guardan motivos anteriores/actuales.

## Diagnóstico

| ID | Evidencia en base f713383 | Impacto | Recomendación |
|---|---|---|---|
| D-004-01 | FrmMantMotivo_Load llama Update después de leer | Abrir/cancelar editor ejecuta una escritura innecesaria | Carga solo por consulta; probar que no se llama al guardado |
| D-004-02 | Button1_Click construye entidad nueva, Activo=true y modalidad según rol | Editar puede alterar campos no editados; rol 13 no repone modalidad previa | Actualizar únicamente campos del editor y conservar el resto |
| D-004-03 | Alta usa SelectAll().Max sin caso tabla vacía ni coordinación | Excepción en tabla vacía y carrera de ID | Identidad/default cuando exista, respaldo transaccional coordinado |
| D-004-04 | Misma recarga por rol en selección, alta, edición y borrado | Correcciones repetidas y divergencia | Presenter con una sola recarga |
| D-004-05 | Modificar usa GetRowCellValue sin comprobar fila válida | Conversión/error sin selección | Selección tipada opcional y mensaje de validación |
| D-004-06 | Borrado directo del mapper; esquema sin FK de motivos | Riesgo para permisos/auditoría que referencian motivo | Verificar referencias y proteger la operación mientras se reconstruyen FK |

## Verificación pendiente en Windows

Identificar exe/commit y usuario/rol de prueba; capturar listado por tipo, edición/cancelación, alta válida/tabla vacía, borrado con referencias y sin selección. Usar QA aislada ficticia y registrar esperado/observado, fecha y autor. No abrir el editor legado en datos reales para demostrar la escritura de Load.

## Contraste con instancia desplegada (17/10/2026)

Consulta de catálogos dentro de transacción READ ONLY, sin datos de personas ni escrituras. [Resultado](../../evidencias/TEC-004/catalogos-solo-lectura.txt): TipoPermiso contiene los IDs 1, 2 y 3 repetidos; la muestra de Motivo_Perm también repite IDs. Hay motivos de licencias y vacaciones; no atribuirles cálculos o reglas anuales que no se observaron. D-004-07: IDs ambiguos → edición/borrado pueden afectar más de una fila y un JOIN multiplica resultados → rechazar cambios ambiguos y coordinar saneamiento, PK/UNIQUE/FK con Kadin. No se deduplicó la instancia.

[Avance implementado, pruebas, límites y protocolo de QA](README.md).
