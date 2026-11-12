# Registro de solicitudes y control del cambio — integrante 4

Preparado el 27/10/2026 para Jorge Enrique Cano Asto. Tarea documental: T2-06.
Pendiente de comprobación del expositor y revisión de otro integrante.
Asistencia material de Codex: inspección local, análisis y redacción.

## Recomendación

Seleccionar **SC-001: horarios** como caso principal. Tiene alcance concreto,
spec, código y evidencia local; permite demostrar control con referencias reales.
La selección académica no cambia la prioridad de los otros paquetes ni autoriza
su despliegue. No se necesita volver a implementar el refactor ya integrado.

Los códigos SC identifican esta presentación. Se vinculan a los CR-TEC existentes;
no los sustituyen ni reemplazan las 18 CR funcionales del proyecto.
Este documento registra propuestas y antecedentes; no acredita aprobación humana.

Fuentes: [plan vigente](../../PLAN_EQUIPO.md),
[contribución](../../../../CONTRIBUTING.md),
[arquitectura](../../../../Software/docs/ARQUITECTURA.md),
[avance de código](../../AVANCE_CODIGO_Y_SUSTENTACION.md) y specs enlazadas.
Base inspeccionada: `694a658`. No se consultó el estado remoto actual de GitHub
ni se ejecutó la aplicación en esta preparación.

## 1. Sustento del integrante 1: tres solicitudes

| Código académico | Solicitud y equivalencia | Tipo principal | Prioridad propuesta | Justificación y situación |
|---|---|---|---|---|
| SC-001 | Refactorizar y completar aceptación de horarios; CR-TEC-001 / [TEC-001](../../../../specs/TEC-001-horarios.md) | Preventivo | Alta | Separar interfaz, reglas y persistencia reduce acoplamiento y facilita pruebas. Código integrado; QA Windows y revisión ajena pendientes. Las correcciones específicas se separan del refactor. |
| SC-002 | Consolidar integridad e IDs de BD; CR-TEC-002 / [TEC-002](../../../../specs/TEC-002-integridad-bd.md) | Preventivo | Alta | Garantizar IDs y referencias también en BD. Scripts y pruebas locales existentes; saneamiento autorizado, aplicación al destino y QA pendientes. El despliegue previo adaptativo no se atribuye nuevamente. |
| SC-003 | Refactorizar y completar aceptación de motivos de permiso; CR-TEC-004 / [TEC-004](../../../../specs/TEC-004-motivos-permiso.md) | Preventivo | Media | Separación de responsabilidades y recarga centralizada. Código integrado; falta aceptación Windows. Evitar escritura al abrir se clasifica aparte como corrección con evidencia. |

La prioridad media de SC-003 es una propuesta relativa a esta presentación;
no sustituye la prioridad alta de CR-TEC-004 en el plan técnico.
No es necesario usar las cuatro categorías: se clasifica el cambio concreto.

**Selección principal propuesta:** SC-001, por su alcance delimitado y cadena de
evidencia disponible. SC-002 sigue siendo dependencia técnica crítica para
integridad y compatibilidad; no puede omitirse por elegir horarios para exponer.
Las tres solicitudes representan trabajo existente con pendientes de aceptación,
no tres implementaciones nuevas iniciadas hoy.

## 2. Sustento del integrante 2: solicitud principal e impacto

**Descripción:** separar listado y mantenimiento de horarios mediante MVP con
vista pasiva, casos de uso y repositorio PostgreSQL; completar la verificación
consulta/alta/edición/cancelación/borrado, según la spec.

**Quién solicita y necesidad:** el plan registra un encargo técnico del equipo,
inicialmente asignado a Jorge y continuado por Evelyn. No identifica un
solicitante formal del área usuaria: confirmar ese nombre y la necesidad de
negocio antes de atribuir la solicitud a un cliente. La necesidad técnica
comprobable es reducir acoplamiento y hacer verificables reglas y operaciones.

**Beneficios esperados:** modificar reglas sin mezclar controles y SQL, probar
casos y presenters con dobles, centralizar validaciones y proteger referencias.
No se afirman porcentajes sin medición. Sin completar la aceptación permanecen
riesgos de regresión visual, incompatibilidad de esquema y cierre sin evidencia.

| Área | Impacto y límite |
|---|---|
| Funcionalidad | Conservar cuatro horas, descripción, Estado nullable, navegación y cancelación. No inventar reglas nocturnas ni sincronización del reloj. RF-01/02 quedan parcialmente preparados. |
| Código | Formularios delegan en presenters; casos dependen de IHorarioRepository; CompositionRoot conecta dependencias. Archivos concretos en el punto 6. |
| BD | Horario y referencias en Empleado, HorarioTemporal, Asistencia y Marcacion. TEC-001 no aplicó migración; PK/FK e identidades corresponden a TEC-002. |
| Pruebas | Regresión de horas, selección, cancelación, errores, campos conservados, referencias e IDs; falta aceptación del ejecutable Windows. |
| Tiempo | Estimar trabajo restante; no volver a estimar la implementación integrada como trabajo nuevo. |
| Mantenibilidad | Responsabilidades y contratos separados facilitan cambios aislados; mantener documentación XML y pruebas al modificar contratos. |

Riesgos técnicos: controles/máscaras DevExpress sin QA visual; DLL licenciadas
para compilar; IDs duplicados/secuencias; escritores externos sin FK; diferencia
entre arnés .NET 8 y ejecutable net48; conflictos en CompositionRoot/MainMDI.
La compatibilidad de datos se coordina con Kadin.

## 3. Sustento del integrante 3: decisión y planificación

**Recomendación: aprobar con condiciones la continuación y aceptación de SC-001.**
Decisión humana real: pendiente de registrar. El diseño coincide con la
arquitectura y existe evidencia local, pero faltan QA Windows y revisión ajena.
No aprobar retroactivamente etapas ni afirmar una liberación aceptada.

| Actividad restante | Responsable propuesto según plan | Esfuerzo estimado | Evidencia esperada |
|---|---|---|---|
| Confirmar alcance, versión y revisor | Evelyn y equipo | 1 h | Spec y revisor distinto de la autora |
| Confirmar QA ficticia y compatibilidad TEC-002 | Kadin | 2–4 h | Destino autorizado y esquema, sin secretos |
| Ejecutar build, suite y QA de horarios | Evelyn; apoyo de Kadin para datos | 3–5 h | Logs y casos esperado/obtenido; capturas saneadas |
| Revisar código y aceptación | Otro integrante por designar | 1–2 h | Revisión real sobre un SHA concreto |
| Consolidar trazabilidad | Jorge, propuesto para esta entrega | 1–2 h | Registro y conclusiones con enlaces |

Total orientativo: **8–14 horas-persona**, sin fecha comprometida. Correcciones
halladas, saneamiento/migraciones TEC-002 y recuperación de dependencias se
estiman aparte. La tabla no acredita aceptación del reparto por los integrantes.

Condiciones: QA confirmada, verificaciones Windows registradas, recorrido
funcional comprobado, compatibilidad de BD, revisión ajena y reversión preparada.

## 4. Mi parte: mecanismo de control del cambio

Mi responsabilidad propuesta es conservar la relación entre solicitud,
decisión, código y evidencia. Controlar y exponer no acredita autoría del refactor.

### 4.1 Registro y estados

Este documento es el registro académico SC; las specs y el plan conservan el
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

### 4.2 Cómo se documentaría la aprobación

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

### 4.3 Cómo se demostraría la implementación

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

### 4.4 Relación con ramas, commits, PR y versiones

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

### 4.5 Cierre y reversión

Cerrar solo con alcance aceptado, código identificado, verificaciones
Windows/QA, compatibilidad de datos, revisión ajena y aceptación registrada.
Si aparece regresión, registrar caso, impacto y commit corrector; repetir
verificaciones afectadas y pedir nueva revisión.

Preparar una reversión revisable de los commits afectados, conservando el
historial. TEC-001 no aplicó migraciones. Si TEC-002 cambió el esquema,
Kadin coordina compatibilidad/restauración: revertir C# no restaura datos.

## 5. Conclusiones y evidencias de trazabilidad

1. SC-001 se relaciona con CR-TEC-001, la spec y el commit real de Evelyn;
   permite identificar qué cambió y quién lo realizó, sin atribuirlo al expositor.
2. Hay código integrado y evidencia local histórica. QA Windows y revisión
   humana permanecen pendientes según las fuentes inspeccionadas.
3. Se recomienda aprobar con condiciones la continuación y aceptación;
   la decisión formal y el cierre deben registrarse por personas reales.
4. El control facilita revisar regresiones y reproducir una versión demostrable.
   No acredita cierre de RF-01/02 ni elimina la dependencia SC-002.

## 6. Archivos y componentes afectados por la solicitud principal

Rutas relativas a Software/. No representan cambios nuevos realizados hoy.

| Responsabilidad | Archivos concretos |
|---|---|
| Vistas | RecursosHumanos/RecursosHumanos/FrmHorarios.cs y FrmMantHorarios.cs |
| Presentación | RRHH.Presentation/Asistencia/HorariosPresenter.cs, HorarioEditorPresenter.cs, IHorariosView.cs, IHorarioEditorView.cs |
| Aplicación | RRHH.Application/Asistencia/IHorarioRepository.cs, ListarHorarios.cs, ObtenerHorario.cs, GuardarHorario.cs, EliminarHorario.cs, HorarioDto.cs |
| Dominio | RRHH.Domain/Asistencia/Horario.cs |
| Persistencia | RRHH.PostgreSql/Asistencia/PostgreSqlHorarioRepository.cs |
| Composición/menú | RecursosHumanos/RecursosHumanos/CompositionRoot.cs y MainMDI.cs |
| Pruebas | RRHH.Tests/Asistencia/HorarioTests.cs, HorariosPresenterTests.cs, HorarioPostgreSqlTests.cs; RRHH.Tests/Fakes/FakeHorarioRepository.cs |

## 7. Guion del integrante 4 (aproximadamente 3 minutos)

“Mi parte consiste en controlar el cambio y demostrar su trazabilidad.
Propongo identificar horarios como SC-001 y relacionarlo con CR-TEC-001
y su especificación, conservando los códigos del proyecto.

El registro incluye alcance, prioridad, responsable, estado, decisión y
evidencias. Distingo aprobación del alcance, revisión del código y aceptación
final. La aprobación debe indicar quién decidió, cuándo, sobre qué versión
y bajo qué condiciones. La ficha presentada es una plantilla; no afirmamos
una aprobación que todavía no está registrada.

Para demostrar la implementación mostraría el diff entre fd12b80 y 138dbce.
El commit pertenece a Evelyn. Los formularios delegan en presenters y casos
de uso y la persistencia pasa por un repositorio PostgreSQL. Mi aporte es
el control y su explicación, no atribuirme el código de otra integrante.

Existe un resultado local registrado de 167 pruebas en un arnés .NET 8 y
compilación de capas para net48. Eso no demuestra que WinForms haya pasado
QA Windows. Por eso mantengo esa validación pendiente, junto con la revisión
ajena y la compatibilidad de base de datos.

En Git, la rama organiza el trabajo y el commit identifica contenido.
Para nuevos cambios se utiliza PR y revisión. En este antecedente hubo una
integración directa documentada como excepción; no inventamos un PR.

Concluyo que solo debemos cerrar cuando las condiciones y pruebas de la
versión revisada estén respaldadas. El código integrado es un avance
comprobable y su aceptación requiere completar el control”.

Para la exposición: abrir registro, spec, diff y validación local con sus
límites. Añadir después QA/revisión reales. No simular una demostración pendiente.

## 8. Aceptación de este entregable documental

- Incluye tres SC, sustento de puntos 1–5 y desarrollo del punto 6.
- Enlaza SC con CR-TEC, specs y autoría; distingue propuesta de hecho documentado.
- Revisar enlaces locales, IDs, archivos y hashes antes de entregar.
- Jorge comprueba/adapta el guion; otro integrante revisa coherencia con aportes 1–3.
- No modifica código, configuración, datos ni estados de cierre técnicos.
- No requiere compilar por ser solo documentación.

Limitación de preparación: la creación de docs/t2-06-control-sc-001 fue impedida
por la restricción de escritura en .git. Se preparó este aporte como archivo local
revisable. Posteriormente se creó RamaKike desde main mediante GitHub para publicar los documentos y solicitar revisión, sin merge.
