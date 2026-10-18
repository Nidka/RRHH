# Plan del equipo para cubrir T2

Estado: propuesta de asignación, pendiente de revisión de los cuatro integrantes. Evelyn informó el 16/10/2026 que Kadin completó el despliegue. Se comprobó conexión/esquema por psql; WinForms, escrituras e integridad aún deben validarse. Fechas calendario y usuarios GitHub pendientes; no se crean issues ni se asignan cuentas desde este documento.

## Objetivo y límites

Entregar diagnóstico sustentado del ejecutable recibido, ingeniería inversa funcional/técnica, análisis de 18 RF, 18 solicitudes de cambio, plan de mantenimiento y al menos cuatro propuestas de mejora. Integrar evidencias de trabajo real y preparar exposición conjunta. Conservar la arquitectura vigente y separar implementación futura de entregables de T2.

La programación hacia T3 sigue [PLAN_REFACTORIZACION.md](../../Software/docs/PLAN_REFACTORIZACION.md). El orden siguiente es el de preparación académica: no obliga a implementar esas etapas para T2.

## Empezar aquí: trabajo nuevo y commits por integrante

Esta es la distribución vigente de implementación hacia T2, solicitada por
Evelyn. Reemplaza las propuestas anteriores de asignar solo pruebas/combos.
TEC-003 está integrado en main; TEC-004 está preparado para revisión en borrador. Los estados de cada paquete se registran en la tabla CR-TEC; TEC-002 tiene el despliegue informado y mantiene pendientes integridad/IDs y QA. Cada integrante implementa
su parte y hace sus propios commits; no se redistribuye la autoría del cambio
`0a4b6a8` ni del avance de conexión `eeeb817`. La fecha de entrega aún debe confirmarse.

**Primer paso ahora:** los cuatro siguen [PRIMERA_PRUEBA.md](PRIMERA_PRUEBA.md) para caracterizar `eeeb817`. La autenticación y el puente PostgreSQL cambiaron; no iniciar refactors suponiendo que XxxMapper sigue siendo SQL Server.

| Paquete / responsable | Parte concreta que va a modificar | Plan propio | Rama / revisor |
|---|---|---|---|
| TEC-001 · Jorge Enrique Cano Asto | Listado y mantenimiento de horarios: `FrmHorarios.cs` y `FrmMantHorarios.cs`; extraer lógica a capas y repositorio PostgreSQL | [Plan de horarios](../../specs/TEC-001-horarios.md) | `refactor/tec-001-horarios` / Evelyn |
| TEC-002 · Francisco Kadin Valera Lizarraga | Perfilado, migraciones de IDs/claves de Horario, RRHH_Feriado y Motivo_Perm, más despliegue QA. FK solo con datos y dependencias verificadas | [Plan de BD](../../specs/TEC-002-integridad-bd.md) | `infra/tec-002-integridad-bd` / Jorge |
| TEC-003 · Frank Piero Mantilla Arqueros | `FrmFeriado.cs`: listar/agregar/eliminar; sustituir acoplamiento al puente PostgreSQL por capas específicas | [Plan de feriados](../../specs/TEC-003-feriados.md) | `refactor/tec-003-feriados` / Kadin |
| TEC-004 · Evelyn Victoria Rodriguez Cardozo | `FrmMotivoPermiso.cs` y `FrmMantMotivo.cs`: consulta/alta/edición/borrado por capas, sin actualización al abrir el editor | [Plan de motivos](../../specs/TEC-004-motivos-permiso.md) | `refactor/tec-004-motivos-permiso` / Frank |

Son tres módulos y un paquete de datos delimitados; no se abordará todo
asistencia, permisos, vacaciones o reportes en esta ronda. Horarios prepara
RF-01/02 pero no los completa; feriados prepara RF-17 pero no corrige aún su
reporte general; motivos atiende las acciones de RF-04/05 cuando pasen sus
criterios. No marcar un RF completo solo por migrar su catálogo.

## Control de cambios de los cuatro paquetes

Estas solicitudes técnicas complementan las 18 solicitudes RF del backlog;
no las sustituyen ni cuentan como cuatro requerimientos funcionales nuevos.
Prioridad y riesgo son estimaciones iniciales que se revisan al caracterizar.
Los responsables y revisores son los de la tabla de paquetes anterior.

| Solicitud | Paquete / resultado | RF relacionado | Mantenimiento inicial | Prioridad | Riesgo | Estado |
|---|---|---|---|---|---|---|
| CR-TEC-001 | TEC-001, horarios por capas/PostgreSQL | RF-01/02, preparación | Preventivo; correcciones separadas si se demuestran | Alta | Medio | En planificación; implementación no iniciada |
| CR-TEC-002 | TEC-002, integridad/IDs y QA | Transversal a los tres módulos | Preventivo en integridad; adaptativo en el despliegue informado | Alta | Alto | Despliegue informado y conexión verificada; integridad/IDs y QA pendientes |
| CR-TEC-003 | TEC-003, feriados por capas/PostgreSQL | RF-17, preparación | Preventivo; correctivo separado si se reproduce defecto | Alta | Medio | Integrado mediante PR #1 en main (`6f7feb8`); evidencias y límites en TEC-003 |
| CR-TEC-004 | TEC-004, motivos por capas/PostgreSQL | RF-04/05; apoyo a 03/06/18 | Preventivo; correcciones del código base separadas | Alta | Alto | [PR #2 en borrador](https://github.com/Nidka/RRHH/pull/2); 130 pruebas combinadas. QA Windows, integridad BD y revisión de Frank pendientes |

Cadena de trazabilidad de cada trabajo:

`Evidencia anterior → diagnóstico → RF (si aplica) → CR-TEC → spec TEC → rama → commits → PR/revisión → pruebas → evidencia posterior → informe/exposición`

El responsable actualiza en su spec enlaces de evidencias, issue/registro,
PR, commits y resultado. Estados de la solicitud: En planificación → En
implementación → En revisión → Validado e integrado. Si hay bloqueo,
registrar causa, responsable y siguiente acción. Actualizar las matrices RF
solo cuando cambie realmente su análisis o se cumpla su aceptación.

## Cómo encaja cada paquete con la pauta de T2

Cada autor completa estas evidencias dentro de su módulo y las entrega a
los responsables del informe. El análisis global de los 18 RF y los otros
flujos del sistema sigue siendo obligatorio aunque no se programe en esta ronda.

| Actividad T2 | Evidencia del paquete |
|---|---|
| 1. Exploración | Capturas/pasos/errores anteriores, con versión y datos ficticios; Kadin registra inspección del entorno y apoya la exploración de las pantallas consumidoras |
| 2. Ingeniería inversa funcional | Flujo antes del cambio, entradas, reglas y salidas; paquete BD explica su relación con los flujos consumidores |
| 3. Ingeniería inversa técnica | Archivos, llamadas, dependencias y tablas reales, método de inspección y limitaciones |
| 4. Diagnóstico | Problema identificado, evidencia, impacto y recomendación, distinguiendo original/reconstrucción |
| 5. Análisis de RF | Relación con RF, alcance cubierto y pendiente; sin inventar reglas ni marcar RF completo por una mejora parcial |
| 6. Plan de mantenimiento | Spec con pasos, riesgo, responsable/revisor, pruebas y reversión; actualizar cronograma con avances reales |
| 7. Control de cambios | Solicitud CR-TEC, estado, rama, commits y PR vinculados; mantener además las 18 CR funcionales |
| 8. Refactorización/reconstrucción | Propuesta con principio/beneficio y comparación antes/después; indicar qué se implementó y qué sigue propuesto |
| 9. Repositorio | Archivos/evidencias saneados, contribuciones y revisión ajena, incorporados al informe de 16 apartados |

### Línea base y configuración

Antes de editar, anotar commit base, versión del ejecutable observado,
Windows/.NET/dependencias y versión de esquema/migraciones. Si el ejecutable
original no tiene versión identificable, registrar su hash local sin subirlo
si contiene recursos privados. Registrar cambios de configuración sin secretos.
`eeeb817` es la referencia técnica actual (`0a4b6a8` fue la anterior), no el identificador automático del
ejecutable original. Al integrar, registrar el commit resultante y esquema
compatible para reproducir la demostración de T2.

### Feedback del revisor

La revisión se centra en el resultado y su evidencia. Para cada observación,
indicar **archivo/método o caso → problema → impacto → cambio sugerido → cómo
comprobarlo**. Distinguir corrección necesaria de sugerencia opcional.
El autor responde con el commit/caso que la resuelve o una justificación;
el revisor vuelve a comprobar lo afectado. Si no hay objeciones, justificar
qué aceptación y evidencia se revisaron; no inventar defectos ni comentarios
para simular participación.

Ejemplo de feedback útil: «En RegistrarFeriado, comprobar existencia y luego
insertar sin protección concurrente puede permitir dos altas del mismo día.
Coordina la garantía con TEC-002 y adjunta una prueba de dos sesiones que
demuestre un único registro». No es un defecto probado hasta inspeccionar
la implementación concreta; es un ejemplo de cómo fundamentar una revisión.

La revisión final confirma alcance, arquitectura, equivalencia o diferencias
intencionales, pruebas/QA, compatibilidad de BD, reversión y trazabilidad T2.
La aprobación la emite el integrante revisor, no la IA ni el autor del PR.

## Patrón común por pantalla o parte del código

El procedimiento completo está en [prompt general de refactorización](PROMPT_GENERAL_REFACTORIZACION.md):
arquitectura, patrones, principios, mantenimiento, ingeniería inversa,
implementación, pruebas, diagramas y control. Es la instrucción común que
acompaña a los cuatro roles; no hay que reconstruirla a partir del chat.

Los refactors nuevos de horarios/feriados/motivos son principalmente
preventivos. La conexión PostgreSQL ya incorporada y el despliegue se
clasifican por separado como adaptación. Cada defecto reproducido que se
corrija requiere su aceptación y prueba correctiva. TEC-002 conserva el
despliegue informado y aborda integridad preventiva, sin presentarla como
refactorización pura ni nueva migración de motor.

Cada integrante puede iniciar su sesión de IA copiando su bloque completo de
[prompts por integrante](PROMPTS_POR_INTEGRANTE.md). La IA lee las reglas y
su spec local; la coordinación entre sesiones se conserva en Git y documentos,
no en una supuesta memoria compartida. El mismo archivo contiene prompts de
continuidad y revisión del PR real.

Cada spec identifica: problema actual, métodos/archivos, alcance, diseño por
capas, pasos, pruebas, criterio de aceptación y reversión. Antes de programar,
el integrante contrasta la caracterización y resuelve sus supuestos con el
revisor. Puede avanzar en análisis y código independiente de la BD mientras
Kadin valida el entorno desplegado; las escrituras necesitan QA/datos ficticios confirmados.

Para las tres pantallas, seguir siempre este recorrido:

`Formulario (vista) → Presenter → Caso de uso → Contrato de repositorio → PostgreSQL`

Reglas puras en Domain, casos de uso y contratos en Application, interfaces
View/presenters en Presentation. CompositionRoot ensambla dependencias. Las
pruebas pertenecen al mismo paquete; no quedan como trabajo separado al final.
Conservar nombres/recursos de formularios. Los catálogos con reglas propias
no se fuerzan dentro del componente genérico de catálogos simples.

## Orden de arranque e integración

1. **Publicar primero estas reglas/planes mediante revisión de esta rama.**
   La base compartida es `origin/docs/t2-organizacion-specs` mientras estas
   reglas no estén integradas en main. Publicar esa rama y crear las ramas de
   tarea desde ella. Antes de integrar los paquetes, integrar mediante revisión
   el PR de organización; así los PR de implementación no duplican su contenido.
2. **Arranque paralelo:** cada uno registra el antes y completa su spec.
   Kadin publica primero en su spec el contrato de tablas/columnas/IDs y el
   procedimiento de QA. Los demás preparan dominio, casos de uso, presenters
   y pruebas con fakes sin esperar al despliegue.
3. **Implementar cada paquete:** responsable edita sus archivos; una migración
   de pantalla cubre todas las lecturas y escrituras de ese flujo. No mezclar
   motores ni introducir de nuevo mappers en código nuevo.
4. **Integración propuesta:** TEC-002 (contrato/migraciones compatibles) →
   TEC-001 → TEC-003 → TEC-004. Se trabaja en paralelo, se integra en serie.
   Antes de cada PR final actualizar la rama desde main y volver a verificar.
   Si un paquete se bloquea, registrar causa y adaptar el orden sin integrar
   un flujo incompleto ni omitir QA.
5. **Cerrar evidencia:** el autor adjunta diff, pruebas, capturas, clasificación
   de mantenimiento y explicación del principio. El revisor comprueba; luego
   se integra y se registra el commit/PR real en el avance T2.

Kadin administra migraciones y esquema. Cada responsable modifica únicamente
sus métodos de composición/entrada en `CompositionRoot.cs` y `MainMDI.cs`.
Nadie reordena esos archivos completos. Coordinar la integración para conservar
los métodos añadidos por otros y comprobar todas las entradas del menú.

## Commits y entrega de cada paquete

Hacer commits por unidades coherentes, por ejemplo:

- `docs(TEC-003): caracterizar feriados y completar plan`
- `refactor(TEC-003): extraer casos de uso y persistencia de feriados`
- `refactor(TEC-003): conectar vista y presenter de feriados`
- `test(TEC-003): cubrir duplicados y documentar QA`

No imponer un número de commits ni dejar main con pasos incompletos. Ajustar
la secuencia al trabajo real; usar prefijos fix/feat si corresponde a una
corrección o funcionalidad nueva. Cada PR debe quedar compilable, probado y
revisado; no hacer commits vacíos ni usar identidad de otro integrante.

Lo que cada uno expone al cerrar su paquete: problema y evidencia anterior →
código que cambió → principio aplicado → mantenimiento preventivo/adaptativo/
correctivo justificado → prueba y resultado → limitaciones. El informe,
matrices y exposición siguen siendo tareas obligatorias, con el reparto
académico de abajo; se alimentan de estos cambios reales.

## Responsables y revisión cruzada

| Orden / tarea | Responsable | Revisor | Dependencia | Entregable y criterio de aceptación | Estado inicial |
|---|---|---|---|---|---|
| 0 · T2-00 Organización | Evelyn | Jorge | Ninguna | Leer reglas, confirmar reparto/fecha, identificar cuentas GitHub y disponibilidad; registrar tareas y ramas | Propuesto; borradores locales preparados |
| 1 · T2-01 Línea base y recuperación técnica | Jorge | Kadin | T2-00 | Inventario de original y reconstruido, herramientas/pasos reales, dependencias y límites; commit y archivos de origen identificados | Pendiente |
| 1 · T2-02 Exploración funcional | Frank | Evelyn | Acceso al ejecutable original | Capturas y casos de menús, asistencia, permisos, licencias, vacaciones y reportes; registrar flujos inaccesibles sin inventarlos | Pendiente |
| 1 · T2-03 Diagnóstico BD | Kadin | Jorge | Esquema disponible; T2-01 para contraste | Entidades/relaciones, claves faltantes y riesgos; distinguir schema.sql de instancia activa y SQL Server original | Pendiente |
| 2 · T2-04 Mapas y flujos | Frank | Jorge | T2-02; puede iniciar con hipótesis | Mapa, diagrama de módulos, cinco flujos requeridos y entradas/procesos/salidas; referencias a evidencias | Pendiente |
| 2 · T2-05 Diagnóstico y refactorización | Jorge | Kadin | T2-01/02/03 | Problemas con evidencia/impacto/recomendación y ≥4 propuestas con principio/beneficio/RF; distinguir original y migración | Pendiente |
| 2 · T2-06 Matrices RF y CR | Evelyn | Frank | Puede iniciar con enunciado; cerrar con T2-04/05 | 18 RF y 18 CR sin omisiones; todos los campos requeridos, responsable y estado; revisar criterios con equipo | Borrador preparado; revisión pendiente |
| 3 · T2-07 Plan de mantenimiento | Evelyn | Jorge | T2-03/05/06 | Objetivo, alcance, estado, cuatro tipos de mantenimiento, riesgos, estrategias, responsables, cronograma y aceptación | Borrador preparado; revisión pendiente |
| Paralelo · T2-08 Despliegue BD | Kadin | Frank | Entorno desplegado; confirmar aislamiento/datos de prueba | Runbook sin secretos, versión, esquema, acceso y restauración documentados | Desplegado según equipo; conexión por psql verificada; QA de aplicación/restauración pendientes |
| 3 · T2-09 Verificación de reconstrucción | Frank | Kadin | Windows + dependencias; para QA requiere T2-08 o BD local ficticia | Resultados reales de build/test y recorrido de los diez catálogos; diferencias y fallos registrados | Pendiente |
| 4 · T2-10 Informe y repositorio | Evelyn | Frank | T2-01…07; incorporar resultados 08/09 disponibles | Informe de 16 apartados, enlaces/evidencias, integrantes y colaboración; comprobar privacidad y acceso docente | Pendiente |
| 5 · T2-11 Exposición y ensayo | Los cuatro; coordina Evelyn | Revisión cruzada del equipo | T2-10; duración de 20 minutos confirmada | Diapositivas visuales, demostración ensayada y preguntas cruzadas; todos explican decisiones y límites | Pendiente |

Nombres completos en [README](README.md). Cada responsable puede pedir ayuda, pero conserva la responsabilidad de validar y explicar su entregable. No se atribuye al responsable un cambio generado localmente hasta que lo revise y lo incorpore mediante su trabajo real.

Para T2-04, Frank coordina la cobertura y los enlaces. Jorge produce mapa,
módulos y arquitectura; Kadin, ER y despliegue; Frank, feriados/asistencia/
reportes; Evelyn, motivos/permisos/licencias/vacaciones. Cada uno prepara
también el flujo antes/después de su paquete y lo acompaña de fuentes y
entradas/procesos/salidas. El reparto detallado está en los prompts y no
autoriza ampliar la implementación a todos esos módulos. Si un flujo no se
puede reconstruir, documentar búsqueda y limitación; una propuesta no se
presenta como funcionamiento observado.

## Tareas complementarias del informe

Crear un issue o registro equivalente con: ID, resultado esperado, responsable/revisor, dependencia, aceptación y ruta de evidencia. Enlazarlo en el PR. Ramas sugeridas:

| Integrante | Ramas de trabajo sugeridas | Primer paso concreto |
|---|---|---|
| Jorge | `docs/t2-01-ingenieria-tecnica`, `docs/t2-05-diagnostico` | Documentar la recuperación y la arquitectura existente; seleccionar cuatro mejoras con evidencia |
| Kadin | `docs/t2-03-diagnostico-bd`, `infra/t2-08-bd-qa` | Revisar schema.sql, definir destino y redactar runbook antes del despliegue |
| Frank | `docs/t2-02-exploracion`, `docs/t2-04-flujos`, `test/t2-09-verificacion` | Recorrer el ejecutable original y registrar versión, pasos, capturas y resultados |
| Evelyn | `docs/t2-06-matrices`, `docs/t2-07-plan`, `docs/t2-10-informe` | Revisar matrices, abrir tareas y coordinar aceptación, integración y exposición |

Cambios de código funcional requieren una spec y rama propia `feature/cr-NNN-descripcion` o `refactor/tec-NNN-descripcion`. No mezclar el despliegue, una nueva regla de negocio y la redacción del informe en el mismo PR.

## Cronograma documental, coordinado con los paquetes técnicos

- Sesión 1: T2-00 y arranque paralelo de T2-01/02/03. Evelyn inicia matrices con el enunciado.
- Sesión 2: T2-04 y T2-05 con revisión de evidencias; Kadin prepara/ejecuta T2-08 cuando disponga de destino autorizado.
- Sesión 3: cerrar T2-06/07, realizar T2-09 y registrar pendientes con impacto.
- Sesión 4: T2-10 y revisión conjunta de rúbrica.
- Sesión 5, antes de entregar: T2-11, prueba de acceso docente y ensayo.

No son fechas comprometidas. Evelyn las convierte en calendario cuando se confirme entrega y disponibilidad. Si la BD se retrasa, avanzar inventario, exploración disponible, diagramas con supuestos explícitos, matrices, plan y diapositivas. No marcar QA completa ni inventar resultados; registrar limitación y siguiente acción.

## Mantenimiento y riesgos

- Correctivo: RF-03 y RF-17; RF-04/05 si se comprueba falla de una función existente.
- Adaptativo: plataforma PostgreSQL y reglas nuevas de turnos, licencias, media jornada y teletrabajo.
- Perfectivo: consultas, reportes y autoservicio según matrices.
- Preventivo: separar responsabilidades, centralizar reglas, pruebas de caracterización, integridad de datos y documentación.

| Riesgo | Responsable de seguimiento | Mitigación y evidencia esperada |
|---|---|---|
| BD disponible tarde o distinta del esquema versionado | Kadin | Plan local ficticio, inventario real y diferencia de esquema; no sustituir despliegue por una afirmación |
| Diferencia entre original y reconstrucción | Frank | Casos comparables etiquetados por versión y origen |
| Cambio de arquitectura/archivos compartidos simultáneo | Jorge | Respetar ADR; coordinar CompositionRoot, mapeos y esquema antes de editar; PR pequeños |
| Falta de cobertura de RF o participación | Evelyn | Revisar 18 RF/CR y evidencias individuales; revisión de otro integrante |
| Reglas de vacaciones/licencia sin confirmar | Evelyn con Frank | Supuestos explícitos y consulta docente/área usuaria antes de implementación |

## Relación con las propuestas técnicas existentes

Jorge documenta al menos cuatro propuestas siguiendo la pauta: problema, evidencia, propuesta, principio, beneficio y RF. Reutilizar como base: separación MVP/SRP ya adoptada; repositorios y dependencias invertidas; calendario/intervalos DRY; claves/secuencias e integridad; importación OCP. Diferenciar «ya incorporado en código», «validado en ejecución» y «propuesto».

No abrir otra iniciativa de arquitectura general para T2. Para continuar una
pantalla, aplicar caracterización, spec, responsabilidades por capa, pruebas,
QA y revisión en el orden técnico vigente. El avance existente debe
demostrarse con código, clasificación de mantenimiento y pruebas, siguiendo
la guía enlazada arriba.
