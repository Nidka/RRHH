# T2: organización y evidencias

Base compartida revisada: main `6f7feb8` (18/10/2026), con la organización y TEC-003 integrados; TEC-004 publicado en [PR #2 en borrador](https://github.com/Nidka/RRHH/pull/2). La T2 evalúa diagnóstico, ingeniería inversa y planificación; los 18 RF se analizan aunque su implementación completa se evalúe progresivamente en T3/final.

**Primero probar la aplicación:** [PRIMERA_PRUEBA.md](PRIMERA_PRUEBA.md) documenta `.env`, ejecutable x86, login RRHH, recorrido inicial y evidencia de conexión. Kadin ya desplegó la BD según informó Evelyn; las pruebas de cada módulo y la integridad aún deben registrarse.

## Equipo

- Jorge Enrique Cano Asto: refactor de horarios; arquitectura y propuestas.
- Francisco Kadin Valera Lizarraga: integridad/IDs de BD y validación del entorno ya desplegado.
- Frank Piero Mantilla Arqueros: refactor de feriados; exploración y caracterización.
- Evelyn Victoria Rodriguez Cardozo: refactor de motivos de permiso; coordinación y matrices.

Evelyn confirmó su identidad y, el 16/10/2026, informó que Kadin completó el despliegue de BD. El reparto nuevo por módulo está en el plan de equipo y sus cuatro specs; no acredita aceptación individual ni trabajo ya realizado. Cada responsable produce sus evidencias y cada revisor valida una contribución ajena.

**Para empezar a programar:** leer primero la tabla de paquetes y el orden de arranque en [PLAN_EQUIPO.md](PLAN_EQUIPO.md), y luego la spec personal. Las tareas de documentación complementan esos paquetes.

**Para pasar instrucciones a la IA de cada integrante:** copiar su bloque
completo de [PROMPTS_POR_INTEGRANTE.md](PROMPTS_POR_INTEGRANTE.md). Incluye
rol, rama, spec, alcance de código, diagramas, evidencias y revisor. Los
archivos deben compartirse en el repositorio antes de usarlos en otro IDE.

**Procedimiento común para cualquier refactor:** [PROMPT_GENERAL_REFACTORIZACION.md](PROMPT_GENERAL_REFACTORIZACION.md).
Incluye arquitectura, principios, patrones, mantenimiento y clasificación
de nuestros paquetes. Los prompts personales y las specs se ejecutan con
ese procedimiento, sin cambiar el reparto de módulos.

## Ruta de lectura

1. [Plan de equipo y orden de trabajo](PLAN_EQUIPO.md).
2. [Primera prueba y estado actual](PRIMERA_PRUEBA.md); [estado anterior de arquitectura](ESTADO_0a4b6a8.md) como referencia histórica.
3. [Matriz de requerimientos](MATRIZ_REQUERIMIENTOS.csv) y [control inicial de cambios](CONTROL_CAMBIOS.csv).
4. [Plan de evidencias e informe](ENTREGA_Y_EVIDENCIAS.md).
5. [Especificaciones](../../specs/README.md), [reglas de colaboración](../../CONTRIBUTING.md) e [instrucciones de IA](../../AGENTS.md).
6. [Análisis anterior](ANALISIS_Y_PREPARACION_T2.md): referencia histórica de `e725cd6`, con actualización introductoria; sus conteos/arquitectura no describen la base nueva.
7. [Avance de código y sustentación](AVANCE_CODIGO_Y_SUSTENTACION.md): qué cambió, dónde, principio, mantenimiento, verificación y continuación técnica propuesta para los cuatro.

Las matrices son propuestas iniciales, sin aprobación del docente ni ejecución de cambios. Completar evidencias y enlaces de PR durante el trabajo; las carpetas de evidencias se crearán al incorporar material real.

Las pautas provienen de los PDF facilitados: `Evaluación PrácticaT2.pdf` (pp. 1–6 actividades/estructura, pp. 7–9 rúbricas) y `226434ISOF1521A.pdf` (p. 2 calendario/pesos). Los PDF permanecen fuera del repositorio. Duración de exposición: 20 minutos, confirmada por Evelyn según la indicación del docente. Fecha de entrega pendiente.

## Base compartida para empezar

La organización ya está incorporada en `main` mediante PR #1, junto con
TEC-003. Actualizar referencias y crear las nuevas ramas desde `origin/main`.
Si la rama personal ya tiene trabajo, conservarlo e incorporar los cambios
compartidos resolviendo conflictos sin sobrescribir otros paquetes. Los PR
se revisan contra `main`; cada paquete conserva su aceptación y revisión.
Las diapositivas se prepararán al final, cuando estén incorporados los
aportes de todos, según indicó Evelyn.
