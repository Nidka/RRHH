# Punto 6. Control del cambio y conclusiones

> Actualización SC-001 del 29/10/2026: el registro y los puntos 1–5 se desarrollan en [Registro de solicitudes](../../../cambios/REGISTRO_SOLICITUDES.md) y [Análisis y planificación de horarios](../../../cambios/SC-001.md). El punto 6 actualizado para las tres SC está en [Control y trazabilidad](../../../cambios/CONTROL_Y_TRAZABILIDAD.md). Esas fichas prevalecen sobre los estados de este antecedente del 27/10. SC-003 mantiene prioridad alta. El PR #10 se comprobó abierto y sin merge el 29/10; no se modifica ni acredita aceptación de código. Las ramas y PR nuevos conservan su revisión humana pendiente.


**Responsable del control documental: Jorge Enrique Cano Asto**
Proyecto: RRHH. Fecha de preparación: 27/10/2026. Entregable asociado a T2-06.

Este aporte desarrolla exclusivamente el control de la solicitud **SC-001:
refactorización y aceptación del módulo de horarios**, vinculada a
**CR-TEC-001 / TEC-001**. SC-001 es el identificador académico propuesto en
esta entrega; conserva la equivalencia con el registro técnico del proyecto.
La selección definitiva debe ser coherente con los aportes de los integrantes
1, 2 y 3. No reemplaza las 18 CR funcionales.

El código del módulo está integrado según el historial y la documentación
local. La aceptación final conserva pendientes de QA Windows y revisión
humana. Las decisiones y firmas pendientes se identifican expresamente.

Fuentes: [plan de equipo](../../PLAN_EQUIPO.md),
[spec de horarios](../../../../specs/TEC-001-horarios.md),
[reglas de contribución](../../../../CONTRIBUTING.md) y
[evidencia histórica de pruebas](../../evidencias/TEC-001/validacion-local.txt).

## 1. Mecanismo propuesto de control del cambio

Se propone controlar SC-001 mediante un registro versionado en el repositorio,
la especificación técnica y la revisión de evidencias. Este documento constituye
el registro académico; la spec conserva el detalle de implementación y el plan
mantiene la asignación del paquete. Cada actualización debe relacionar solicitud,
versión revisada, responsable, decisión y resultado verificable.

El procedimiento comprende:

1. Registrar identificador, alcance, responsable y estado.
2. Vincular la evaluación y decisión de los integrantes 2 y 3, identificando
   quién tiene autoridad para aprobar el alcance y sus condiciones.
3. Mantener rama, commits y revisión vinculados a SC-001 / CR-TEC-001.
4. Comprobar implementación y pruebas de una misma versión; registrar pendientes.
5. Registrar aceptación y cierre cuando se cumplan las condiciones.
6. Ante fallos, conservar el historial y documentar corrección o reversión.

La responsabilidad de este aporte es organizar y explicar la trazabilidad.
La autoría del refactor de horarios corresponde a Evelyn según el commit;
la coordinación de esquema y QA de datos corresponde a Kadin según el plan.
No se reasigna implementación por preparar este registro.

## 2. Registro del identificador de la solicitud

Este documento es el registro académico de SC-001; las specs y el plan conservan el
detalle técnico y estados CR-TEC. No duplicar sus pruebas. Si se usa GitHub
Issues/Projects, añadir aquí la URL real. No se creó un tablero remoto hoy.

| Campo SC-001 al 27/10/2026 | Valor o pendiente |
|---|---|
| Equivalencia | CR-TEC-001 / TEC-001; RF-01/02 parcialmente preparados |
| Responsable del código | Evelyn Victoria Rodriguez Cardozo |
| Responsable propuesto de este registro | Jorge Enrique Cano Asto; comprobación personal pendiente |
| Estado según fuentes locales | Código integrado y validación local documentada; QA Windows y revisión humana pendientes |
| Decisión académica | Se recomienda aprobar con condiciones; decisión del equipo pendiente |
| Revisor de horarios | Pendiente de designar; distinto de la autora |
| Issue/tablero remoto | No creado en esta preparación |
| Próximo paso | Confirmar revisor y QA; registrar verificaciones faltantes |

Para cambios nuevos, proponer: Registrada → En análisis → Pendiente de decisión.
La decisión puede ser Rechazada, Postergada, Aprobada o Aprobada con condiciones.
Tras autorizar: En implementación → En revisión → Validada e integrada → Cerrada.
Cada transición indica fecha, persona, versión y evidencia. Ante bloqueo,
conservar estado e indicar causa, responsable y siguiente acción.

SC-001 ya tiene código integrado: registrar ese antecedente y sus pendientes,
sin recrear aprobaciones pasadas. Un merge acredita integración; por sí solo
no acredita revisión ajena, QA ni aceptación final.

## 3. Documentación de la aprobación

**Plantilla sin aprobación emitida.** Completar tras una decisión humana real:

| Campo | Contenido que debe registrar la persona responsable |
|---|---|
| Solicitud y alcance | SC-001 / CR-TEC-001; revisión concreta de spec |
| Decisión | Aprobada, rechazada, postergada o aprobada con condiciones |
| Justificación | Razón técnica y necesidad de negocio contrastada |
| Persona y autoridad | Nombre real y rol autorizado para decidir |
| Fecha y respaldo | Fecha real y enlace a acta, issue o comentario |
| Condiciones | QA Windows, compatibilidad BD y revisión ajena; responsables y plazo acordado |
| Revisión técnica | Persona distinta de la autora; SHA y criterios comprobados |
| Cumplimiento | Evidencia real por condición; pendientes explícitos |
| Aceptación y cierre | Persona que acepta, fecha, commit integrado, versión y resultados |

Confirmar con el equipo quién decide alcance y quién acepta el resultado.
Decisión de alcance, revisión técnica y aceptación final son actos distintos.
Una recomendación de IA o autoaprobación del autor no sustituye revisión ajena.
**Modelo de asiento para SC-001 — pendiente de decisión humana:**

> Solicitud: SC-001 / CR-TEC-001. Alcance: listado y mantenimiento de horarios
> según TEC-001. Decisión: pendiente. Recomendación previa: aprobación con
> condiciones, sujeta a la evaluación del integrante 3. Condiciones propuestas:
> build y pruebas Windows, QA con datos ficticios, compatibilidad con TEC-002
> y revisión por una persona distinta de la autora. Persona que decide: pendiente.
> Fecha de decisión: pendiente. SHA evaluado y respaldo de la decisión: pendientes.

El asiento muestra cómo se documentaría la aprobación; no declara una decisión
emitida. La integración directa histórica registrada en el plan no equivale
a revisión ajena ni aprobación de aceptación.

## 4. Demostración de la implementación

Mostrar diff, archivos resultantes y pruebas de la misma versión. Cada caso QA
registra entorno, SHA, datos ficticios, pasos, esperado, obtenido y evidencia.

| Evidencia | Qué acredita | Situación |
|---|---|---|
| Diff fd12b80 → 138dbce | Estructura y correcciones delimitadas | Commit comprobado en historial local |
| [Spec TEC-001](../../../../specs/TEC-001-horarios.md) | Alcance, antes/después, principios, pruebas y reversión | Existente, con pendientes |
| [Validación local del 18/10](../../evidencias/TEC-001/validacion-local.txt) | 167 pruebas registradas en arnés net8; build de capas/tests net48 | Evidencia histórica leída, no repetida hoy; no equivale a QA WinForms |
| Logs Windows de build y suite | Verificación de la plataforma del proyecto | Pendientes, Evelyn con apoyo de Kadin |
| Casos y capturas QA | Comportamiento del ejecutable y persistencia | Pendientes; no fabricar capturas |
| Revisión y aceptación | Cumplimiento revisado y cierre autorizado | Pendientes |

Inspección reproducible desde la raíz, sin modificar código:

```powershell
git status --short
git rev-parse HEAD
git show --format=fuller --stat 138dbce
git diff fd12b80 138dbce -- Software/RecursosHumanos/RecursosHumanos/FrmHorarios.cs Software/RecursosHumanos/RecursosHumanos/FrmMantHorarios.cs
git log --oneline --all --grep=TEC-001
```

Para completar verificación Windows, registrar comandos y resultados reales
en [evidencias TEC-001](../../evidencias/TEC-001/):

```powershell
Software\scripts\build.cmd
dotnet test Software\RRHH.Tests\RRHH.Tests.csproj
Software\scripts\check-postgresql.cmd -Modules
```

Confirmar antes destino QA para conexión/escritura. El chequeo de módulos hace
lecturas y no sustituye QA funcional. Estos comandos no se ejecutaron en esta
preparación documental.

Demostrar: alta visible tras recargar; edición conserva ID/SgtDia; cancelación
sin escritura; horas inválidas rechazadas; selección ausente controlada;
borrado bloqueado en uso y permitido sin referencias; acceso desde ambos menús.
Coordinar IDs/concurrencia con TEC-002 y registrar límites de escritores sin FK.

## 5. Relación con ramas, commits, pull requests y versiones de Git

| Elemento | Referencia comprobable y límite |
|---|---|
| Base del refactor | fd12b80 según spec; eeeb817 es antecedente de conexión, no versión del ejecutable original |
| Rama registrada | refactor/tec-001-horarios-evelyn según plan/spec; existencia remota actual no comprobada |
| Implementación | 138dbce6951d8472cfcbf1a8434d97d33c51234a; git show confirma autoría de Evelyn |
| PR de horarios | No consta para esa integración: el plan registra integración directa solicitada por Evelyn como excepción. No inventar número ni aprobación. |
| Código inspeccionado hoy | 694a658; no equivale a release ni ejecutable validado |
| Cambios futuros | Rama con ID, por ejemplo fix/tec-001-sc-001-qa si aparece un defecto autorizado; commits con SC-001/TEC-001, PR y revisión ajena |
| Versión final | Registrar tag/release real, SHA, esquema compatible y evidencias tras aceptación; no se creó versión hoy |

Reutilizar la [plantilla de PR](../../../../.github/pull_request_template.md)
con SC-001 / CR-TEC-001 / TEC-001, spec, antes/después, pruebas, riesgos,
reversión y ayuda material de IA. Para revisar código ya integrado puede
registrarse revisión sobre un SHA concreto; un PR posterior documental no
prueba revisión retrospectiva del refactor.

Un commit identifica contenido, una rama organiza trabajo y el PR registra
revisión/discusión. Una versión aceptada debe vincular código, esquema,
ejecutable y resultados; no basta escribir un número en el informe.

## 6. Conclusiones y evidencias de trazabilidad

### Matriz de evidencias de trazabilidad

| Evidencia | Relación con SC-001 | Resultado y límite |
|---|---|---|
| [Spec TEC-001](../../../../specs/TEC-001-horarios.md) | SC-001 / CR-TEC-001 → alcance y aceptación | Documento existente; revisar sus pendientes |
| [Plan del equipo](../../PLAN_EQUIPO.md) | CR-TEC-001 → responsable y estado | Identifica a Evelyn como responsable de la continuación |
| [Inspección Git local del 27/10](EVIDENCIA_GIT_SC-001.txt) | Solicitud → base → commit → archivos y autoría | Inspección ejecutada en esta preparación; no prueba ejecución funcional |
| [Validación local del 18/10](../../evidencias/TEC-001/validacion-local.txt) | Commit/paquete → pruebas históricas | 167 pruebas registradas en arnés net8 y build de capas/tests net48; no repetidas hoy |
| Registro de aprobación y revisión | Versión revisada → decisión humana | Pendiente; usar la ficha del apartado 3 |
| QA y aceptación Windows | Código + esquema + ejecutable → resultado final | Pendientes; aportar casos y capturas saneadas |
| Versión de entrega | Commit aceptado → tag/release y esquema compatible | Pendiente; no se creó release |

Cadena verificable: SC-001 → CR-TEC-001 → spec TEC-001 → base fd12b80 →
commit 138dbce → archivos/pruebas → revisión y QA pendientes → aceptación y
versión final pendientes. La rama registrada se toma del plan; el PR original
no consta porque se documentó integración directa como excepción.

### Conclusiones
1. SC-001 se relaciona con CR-TEC-001, la spec y el commit real de Evelyn;
   permite identificar qué cambió y quién lo realizó, sin atribuirlo al expositor.
2. Hay código integrado y evidencia local histórica. QA Windows y revisión
   humana permanecen pendientes según las fuentes inspeccionadas.
3. Se recomienda aprobar con condiciones la continuación y aceptación;
   la decisión formal y el cierre deben registrarse por personas reales.
4. El control facilita revisar regresiones y reproducir una versión demostrable.
   No acredita cierre de RF-01/02 ni elimina la dependencia SC-002.

### Condiciones de cierre y reversión

Cerrar solo con alcance aceptado, código identificado, verificaciones
Windows/QA, compatibilidad de datos, revisión ajena y aceptación registrada.
Si aparece regresión, registrar caso, impacto y commit corrector; repetir
verificaciones afectadas y pedir nueva revisión.

Preparar una reversión revisable de los commits afectados, conservando el
historial. TEC-001 no aplicó migraciones. Si TEC-002 cambió el esquema,
Kadin coordina compatibilidad/restauración: revertir C# no restaura datos.
### Comprobación y aceptación de este aporte

Se comprobaron enlaces locales y referencias Git. Al ser un cambio documental,
no requiere compilar; no se ejecutaron nuevas pruebas funcionales ni se accedió
a la BD. Jorge debe comprobar el contenido y otro integrante debe revisar
coherencia con la solicitud elegida y la decisión del equipo antes de entregar.
Preparación asistida por Codex: inspección, extracción y redacción; no sustituye
revisión humana. La creación local de la
rama fue impedida por la restricción de escritura en .git. Se creó RamaKike desde main mediante GitHub para publicar esta entrega documental y someterla a revisión, sin merge.
