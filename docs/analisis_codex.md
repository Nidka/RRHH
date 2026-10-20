# Análisis de ingeniería inversa de RRHH

Fecha del análisis: **18/10/2026 (America/Lima)**. Corte de código: **138dbce**.

Informe de la solución completa, dividido en capítulos por su extensión. No se modificó código ni se accedió a la BD. Las evidencias enlazan archivo y número de línea del corte local; los IDs de commit identifican las fuentes históricas. Las inferencias y ausencias se acotan a las fuentes disponibles. La inspección de código no equivale a observar el ejecutable original ni a aprobar una prueba Windows.

## 1. ORIGEN Y ENTORNO

[Leer capítulo](analisis_codex/01_origen_entorno.md): procedencia recuperada, señales VB/C#, versiones de proyectos, dependencias, DLL físicas, NuGet, configuraciones y conexiones saneadas.

[Árbol completo y manifiesto de fuentes](analisis_codex/01_arbol.md).

## 2. FORMULARIOS Y PANTALLAS

[Fichas de las 87 clases de formulario](analisis_codex/02_formularios.md): herencia, título configurado, propósito, controles/textos, eventos/acciones, entradas y mensajes con condición.

[Mapa de navegación](analisis_codex/02_navegacion.md), [mensajes de toda la solución](analisis_codex/02_mensajes.md) y [cuerpos de eventos y métodos operativos](analisis_codex/02_eventos_fuente.md). Los formularios base/utilitarios y los que no tienen entrada resuelta se identifican; no se presentan todos como pantallas alcanzables.

## 3. ACCESO A DATOS

[Leer capítulo](analisis_codex/03_acceso_datos.md): rutas actuales y heredadas, parametrización, riesgos SQL y esquema probable.

- [Catálogo de SQL, plantillas y APIs de ejecución](analisis_codex/03_catalogo_sql.md).
- [441 contratos Function, invocaciones, CommandText y filtros LINQ](analisis_codex/03_procedimientos_linq.md).
- [Scripts SQL completos, tablas, columnas y asociaciones recuperadas](analisis_codex/03_modelo_datos.md).
- [SQL en referencias Visual Basic no integradas](analisis_codex/03_referencia_vb.md).

Los cuerpos T-SQL de los procedimientos originales no están disponibles. No se inventan a partir del nombre de un wrapper ni se afirma que todos los contratos se ejecuten en la aplicación actual.

## 4. REGLAS DE NEGOCIO Y VALIDACIONES

[Leer capítulo](analisis_codex/04_reglas_negocio.md): reglas interpretadas, duplicidades y cobertura de horarios, asistencia, permisos, licencias, vacaciones, teletrabajo, feriados y reportes.

[Inventario íntegro de condiciones, excepciones y catch](analisis_codex/04_condiciones_excepciones.md), diferenciando guardas técnicas/generadas de reglas funcionales. Se documentan búsquedas negativas y sus límites.

## 5. REPORTES

[Leer capítulo](analisis_codex/05_reportes.md): 12 clases XtraReport, campos enlazados, encabezados, origen, invocantes, filtros y exportaciones de grilla. No se encontraron diseños .rpt/.rdlc en el inventario analizado.

## 6. MALAS PRÁCTICAS Y PROBLEMAS DE MANTENIBILIDAD

[Leer capítulo](analisis_codex/06_mantenibilidad.md): 23 hallazgos con evidencia e impacto. Se distinguen defectos/riesgos actuales, fuentes auxiliares y correcciones existentes. No se afirma ausencia de capas, logs, seguridad de contraseñas o Git cuando hay evidencia de ellos.

## 7. IMPACTO DEL BACKLOG

[Leer capítulo: RF-01 a RF-18](analisis_codex/07_impacto_backlog.md). Cada RF indica base existente, formularios/clases/tablas/consultas afectadas y trabajo restante.

**Hallazgo que cambia el diagnóstico anterior:** ya existe una ruta de horarios temporales con fechas y consulta. No corresponde describir RF-01/RF-02 como carentes de toda base funcional. La implementación del catálogo TEC-001 es distinta de esa ruta. Evidencia: [FrmHorarioEsp.cs:977](../Software/RecursosHumanos/RecursosHumanos/FrmHorarioEsp.cs#L977) y [RRHHClass.cs:714](../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L714). Las matrices anteriores no se modificaron en esta solicitud.

## 8. CHECKLIST DE CAPTURAS

[Leer capítulo](analisis_codex/08_checklist_capturas.md): 27 casos de exploración con precondiciones, pasos, mensajes exactos o expresión variable, y cobertura de pantallas/reportes. Es un plan de ejecución, no resultados ni capturas ya obtenidas.

## 9. CAMBIOS YA HECHOS

[Leer capítulo](analisis_codex/09_cambios.md): historial local, refactorizaciones, límites de la comparación con el original y cambios documentales de esta solicitud.

## Cobertura y límites de la revisión

- Se parsearon estructuralmente **1.135 archivos C#**, sin errores del parser, y se inspeccionaron proyectos/configuraciones, 14 VB de referencia y tres scripts SQL. El árbol incluye también artefactos locales y fuentes auxiliares; el manifiesto identifica cada C# por SHA-256.
- Las fichas cubren las 87 clases de formulario detectadas por herencia y los 12 reportes XtraReport. La tabla de navegación conserva las referencias estáticas; requiere contraste por rol/Windows para acreditar acceso y comportamiento.
- SQL y validaciones se inventarían desde las fuentes, con ámbito explícito de pruebas/referencia/legado. No se dispone de las consultas internas de procedimientos originales, código de DLL ajenas ni configuración privada/servidor real inspeccionados.
- No se ejecutó WinForms en macOS, no se consultó la BD y no se escribieron datos. Los comentarios de arquitectura se contrastan con código; no se presentan ejemplos ilustrativos como clases implementadas.
