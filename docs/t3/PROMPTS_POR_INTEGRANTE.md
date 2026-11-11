# T3: prompts por integrante

Copiar **un bloque personal** (sección 3) en la IA del IDE con el repositorio abierto. Cada bloque remite a las
«Reglas comunes» (sección 1) y al «Control de versiones» (sección 2) de este mismo archivo, así que **este archivo
debe estar en la rama base de todos** antes de empezar (ver sección 4, paso 0).

Guías relacionadas: [CHECKLIST_T3.md](CHECKLIST_T3.md) (orden y cierre de la semana) y
[PROMPTS_KADIN_CLAUDE.md](PROMPTS_KADIN_CLAUDE.md) (preparar y subir a GitHub, sin coautoría de IA en commits ni PR).

Estado de partida (leído de `origin/main` y `origin/docs/sem12-gestion-versiones`, 11/11/2026):

- RF mínimos con código y pruebas: RF-04 y RF-05 (TEC-004). RF-03 solo existe como validación heredada
  incompleta (`RRHHClass.ExistePermiso` no detecta un rango nuevo que contiene a uno existente).
- Sin código: RF-01, RF-02, RF-06, RF-13, RF-14 y los tres complementarios. TEC-001 migró solo el mantenimiento de horarios.
- Sin versionado de T3: solo existe el tag `v1.0.0`; el CHANGELOG y la política SemVer están en
  `docs/sem12-gestion-versiones`, sin integrar en `main`.
- No se pudo comprobar el estado de los PR, issues ni Releases en GitHub (no hay `gh` en la máquina que generó esto).
  Quien tenga acceso debe verificarlo.

## 0. Reparto de la semana

La rúbrica pide **8 obligatorios + 3 complementarios = 11 RF**. No hay holgura: si un RF falla, el reemplazo es RF-15.

| Persona | Obligatorios | Complementario | Además |
|---|---|---|---|
| Evelyn Victoria Rodriguez Cardozo | RF-01, RF-02, RF-04, RF-05 (cierre) | — | Refactorizaciones REF-003/004, informe §9 |
| Jorge Enrique Cano Asto | RF-13, RF-14 | RF-16 | Informe §4, §5, §6; exposición de arquitectura |
| Frank Piero Mantilla Arqueros | RF-03, RF-06 | RF-17 | Base compartida `RangoFechas` y `CalendarioLaboral`; REF-001/002; informe §13–17 |
| Francisco Kadin Valera Lizarraga | — | RF-18 | Migraciones BD, versionado/releases, matrices, casos de prueba y armado del informe |

Revisión cruzada (distinta del autor, como en `CONTRIBUTING.md`):

| Autor | Revisor |
|---|---|
| Evelyn (RF-01/02) | Kadin |
| Evelyn (RF-04/05) | Frank |
| Jorge | Kadin |
| Frank | Jorge |
| Kadin (RF-18 y migraciones) | Evelyn |

---

## 1. Reglas comunes

### Alcance y honestidad
- Implementar solo los RF de tu bloque. No abrir otros módulos. No marcar un RF «implementado» hasta tener evidencia.
- No inventar capturas, resultados de pruebas, reglas de negocio ni revisiones. Una prueba escrita no es una prueba ejecutada.
- Si una regla de negocio no está definida (la matriz dice «por confirmar»), registrarla en la spec como **hipótesis**,
  implementar la más simple y reversible, y avisar al equipo. No bloquearse esperando respuesta.
- Si no puedes ejecutar `build.cmd` o `dotnet test` (requiere Windows), dilo en el PR. No afirmes que pasaron.
- No marques tu propio PR como aprobado ni simules la revisión de otro. No integres a `main` sin la aprobación del revisor.

### Arquitectura (obligatoria, ver `Software/docs/ARQUITECTURA.md` y `CLAUDE.md`)
- MVP de vista pasiva: `IXxxView` y `XxxPresenter` en `RRHH.Presentation`; casos de uso e interfaces de repositorio en
  `RRHH.Application`; reglas puras en `RRHH.Domain`; repositorios con SQL parametrizado en `RRHH.PostgreSql`.
- Dependencias creadas solo en `RecursosHumanos/RecursosHumanos/CompositionRoot.cs` (añadir un método `Crear...`; no
  reescribir los existentes).
- Nada nuevo con `dcGRLLDataContext`, `XxxMapper.Instance()`, `RRHHClass`, `SqlConnection`, TableAdapters ni `Module1`.
- Fechas como `DateTime`/`DateOnly` tipado, nunca texto `yyyyMMdd`. Escrituras de varias tablas dentro de una transacción.
- Formularios nuevos `Frm*` están permitidos; **no renombrar ni mover** los existentes ni sus `.resx`.
- Comentarios XML `///` en español en el código nuevo o modificado. Indicar qué `spRRHH_*`, método de `RRHHClass` o consulta reemplaza.
- No tocar proyectos heredados salvo para retirar código ya migrado.

### Contrato compartido (lo crea Frank el día 1; los demás programan contra esta firma)
```csharp
// RRHH.Domain/Comun/RangoFechas.cs   (inmutable; fechas inclusivas, solo la parte fecha)
public sealed class RangoFechas
{
    public static RangoFechas Crear(DateTime desde, DateTime hasta); // ReglaNegocioException si hasta < desde
    public DateTime Desde { get; }
    public DateTime Hasta { get; }
    public int Dias { get; }                       // calendario, inclusivo
    public bool Contiene(DateTime fecha);
    public bool Solapa(RangoFechas otro);          // Desde <= otro.Hasta && Hasta >= otro.Desde (igualdad, parcial y contención)
}

// RRHH.Domain/Asistencia/CalendarioLaboral.cs
public sealed class CalendarioLaboral
{
    public CalendarioLaboral(IEnumerable<DateTime> feriados);
    public bool EsLaborable(DateTime fecha);       // hipótesis inicial: lunes a viernes y no feriado
    public int DiasLaborables(RangoFechas rango);
}
```
Hasta que el PR de Frank esté en `main`, usa un duplicado local temporal con la misma firma y bórralo al rebasar.
La definición de «día laborable» (¿sábado?) se confirma contra la regla de horarios y se registra como hipótesis.

### Entregables por cada RF (ficha de la rúbrica)
En la spec `specs/CR-0NN-...md` (copiar `specs/PLANTILLA.md`), añadir al final la **ficha del RF**:
código, descripción, módulo, pantalla/clase, regla aplicada, evidencia, estado (implementado / en pruebas / pendiente),
commits, casos de prueba. Además:
- **Casos de prueba** en `docs/t3/casos_prueba/<tu-nombre>.csv` con columnas:
  `Código,RF,Datos de prueba,Resultado esperado,Resultado obtenido,Estado,Evidencia`. Códigos `CP-<RF>-<nn>`, por ejemplo `CP-03-01`.
  Datos de prueba **ficticios**. Mínimo: un caso feliz, un caso de borde y un caso de error por RF.
- **Pruebas automáticas** xUnit en `Software/RRHH.Tests/<Módulo>/`, con repositorios y vistas falsos, que cubran los mismos casos.
- **Evidencia** en `docs/t3/evidencias/RF-NN/` (capturas reales de la aplicación en Windows, salida de pruebas).
- **Fila del CR en `docs/t2/CONTROL_CAMBIOS.csv`**: actualizar solo las de tus RF (estado, rama/PR, commits, pruebas, evidencia).
  No reordenar el archivo ni tocar filas ajenas.
- **No editar** `CHANGELOG.md`, `docs/versionado/*` ni la matriz de requisitos: lo consolida Kadin. En su lugar, pon en la
  descripción del PR la línea exacta para el CHANGELOG, por ejemplo `Agregado: registro de periodos de teletrabajo (RF-13)`.
- Si haces una refactorización, documentarla en `docs/t3/refactorizaciones/REF-NNN.md`: problema inicial, evidencia antes,
  solución aplicada, evidencia después, principio aplicado, beneficio, commit.

### Definición de terminado de un RF
1. La spec está completa y los PR enlazan RF, CR, CP y commits.
2. `Software\scripts\build.cmd` compila con 0 errores y `dotnet test Software\RRHH.Tests` pasa (en Windows).
3. La pantalla o el reporte se ejecuta en la aplicación real y hay evidencia propia.
4. Un revisor distinto aprobó el PR.
5. El PR indica el tipo `semver:` y el uso material de IA y cómo se verificó.

### Ritmo y conflictos
- Un PR por RF (o por RF + su prueba). PR pequeños, hacia `main`, sin push directo ni force push.
- Archivos compartidos (`CompositionRoot.cs`, `MainMDI`, `schema.sql`): cambios mínimos y aditivos; hacer `git fetch` y rebasar o
  fusionar `main` antes de abrir el PR. Resolver conflictos conservando lo ajeno.
- **Congelamiento:** 24 horas antes de la entrega no se abren funcionalidades nuevas; solo correcciones y evidencia.
- Antes de la primera confirmación, comprobar `git config user.name` y `git config user.email`: deben ser tu **nombre real**.
  Hoy el historial mezcla los alias «Nidka», «Piero», «Kike» y «helcorp», y la rúbrica pide evidenciar la participación de cada integrante.

---

## 2. Control de versiones (MAJOR.MINOR.PATCH)

Base: `docs/versionado/POLITICA_VERSIONADO.md` (rama `docs/sem12-gestion-versiones`). Esta sección la concreta para T3.

### Cómo se decide el número
| Sube | Cuándo | En RRHH |
|---|---|---|
| **MAJOR** | Rompe compatibilidad: deja de soportar algo, cambia el esquema sin migración compatible o reemplaza pantallas completas | Retiro de SQL Server/TableAdapters. **Nadie lo usa en T3.** |
| **MINOR** | Agrega o mejora una función sin romper lo existente | RF-01, RF-06, RF-13, RF-18 |
| **PATCH** | Corrige un error o refactoriza sin cambiar el comportamiento | RF-03, RF-17, cierre de RF-04/05 |

Los de la derecha vuelven a 0 al subir uno. Docs, tests y chores **no** cambian la versión.
La versión se asigna **al publicar el release**, no en cada commit. Pre-versiones de QA: `v1.3.0-rc.1`.

### Ramas
| Prefijo | Uso | Versión |
|---|---|---|
| `feature/rf-NN-descripcion` | Función nueva | MINOR |
| `fix/rf-NN-descripcion` | Corrección de comportamiento | PATCH |
| `refactor/ref-NNN-descripcion` | Reestructurar sin cambiar comportamiento | PATCH |
| `infra/…`, `docs/…`, `test/…` | BD, documentación, pruebas | ninguna |
| `release/x.y.z` | Congelar versión (solo Kadin) | — |

`fix/` es nuevo: Kadin lo añade a `CONTRIBUTING.md`. Todas se crean desde `main` actualizado.

### Mensajes de commit
```
tipo(ALCANCE): descripción en imperativo, minúscula, sin punto final

Cuerpo opcional: qué y por qué, no cómo.

Refs: RF-13, CR-013, CP-13-01
```
- **tipo** → efecto en la versión: `feat` → MINOR · `fix` → PATCH · `refactor`, `perf` → PATCH · `docs`, `test`, `chore`, `build` → ninguno.
- **ALCANCE**: `RF-NN`, `TEC-NNN`, `REF-NNN` o `BASE` (infraestructura compartida). Varios RF: `RF-13,RF-14`.
- **Cambio incompatible**: `feat(RF-NN)!: …` más el pie `BREAKING CHANGE: motivo` → MAJOR.
- **Pie `Refs:`** obligatorio en commits de código: enlaza RF, CR y casos de prueba (esa es la trazabilidad que pide la rúbrica).
- **Sin coautoría de IA:** ni commits ni PR llevan `Co-Authored-By`, «Generated with Claude Code» u otra línea de atribución a una IA.
  Si tu asistente la añade por defecto, indícale que no lo haga o edita el mensaje antes de subir. El uso de IA se declara en el apartado «Uso de IA» del PR.
- Commits pequeños y atómicos. Ejemplo de secuencia de un RF: `docs(RF-13): caracterizar…` → `test(RF-13): …` → `feat(RF-13): …` → `docs(RF-13): ficha y evidencias`.
- Ejemplos válidos:
  - `feat(RF-13): registrar periodos de teletrabajo sin solapamiento`
  - `fix(RF-03): detectar permisos que contienen a otro existente`
  - `refactor(REF-004): extraer asignación de horarios a caso de uso`

### Pull requests
- Título = el commit principal (`feat(RF-13): …`). Label `semver:minor|patch|major|none`: lo propone el autor y lo confirma el revisor.
- Descripción: RF, CR, spec, CP, verificaciones reales, riesgos/reversión, uso de IA, línea para el CHANGELOG.

### Plan de versiones propuesto (se confirma al integrar; el número sigue al orden real de merge)
| Versión | Tipo | Contenido | Responsable del release |
|---|---|---|---|
| v1.0.1 | PATCH | TEC-001 (horarios a capas, ya en main), TEC-002 (integridad/IDs, ya en main) + cierre de RF-04/05 | Kadin |
| v1.1.0 | MINOR | RF-01, RF-02 (turnos por periodos e histórico) | Kadin |
| v1.1.1 | PATCH | RF-03 (permisos solapados) | Kadin |
| v1.2.0 | MINOR | RF-06 (licencia una vez al año) | Kadin |
| v1.2.1 | PATCH | RF-17 (feriados en reporte general) | Kadin |
| v1.3.0 | MINOR | RF-13, RF-14, RF-16 (teletrabajo) | Kadin |
| v1.4.0 | MINOR | RF-18 (ausencias por periodo) → **versión intermedia T3** | Kadin |

Reglas: etiquetas anotadas `vX.Y.Z` (nunca mover ni reutilizar una publicada); un Release de GitHub por etiqueta con las notas del CHANGELOG;
si cambia el orden de integración se renumera **antes** de crear la etiqueta.

---

## 3. Prompts personales

### Prompt de Evelyn

```text
Soy Evelyn Victoria Rodriguez Cardozo. Trabajo en el repositorio RRHH (WinForms .NET Framework 4.8, PostgreSQL, MVP por capas) para la entrega T3.
Mi alcance: RF-01 (turnos por periodos de fechas), RF-02 (histórico de turnos) y el cierre verificable de RF-04/RF-05 (agregar y eliminar motivos de permiso).
Mi revisor: Kadin para RF-01/02; Frank para RF-04/05.

Antes de editar lee, en este orden: CLAUDE.md, AGENTS.md, Software/docs/ARQUITECTURA.md, specs/TEC-001-horarios.md, specs/TEC-004-motivos-permiso.md,
y las secciones 1 (Reglas comunes) y 2 (Control de versiones) de docs/t3/PROMPTS_POR_INTEGRANTE.md. Aplícalas tal cual, incluido el formato de commits con pie Refs.

Tareas, en este orden:

1. RF-01 y RF-02 (ramas feature/rf-01-turnos-por-periodo y feature/rf-02-historico-turnos).
   - Caracteriza primero lo heredado: FrmHorarioEsp.cs (línea ~977), FrmConsultaHorarioEsp.cs (línea ~1036), FrmAsignarHorario.cs y RRHHClass.cs (línea ~714).
     Tabla public."HorarioTemporal" (idEmpleado, N, FechaInicio, FechaFin, HorarioAsignado, NroDocumento, Sisgedo, FechaRegistro). Registra qué hace hoy, qué mensajes muestra y qué consultas usa.
   - Define en la spec la política de conflictos como hipótesis (¿puede un empleado tener dos turnos que se solapan?). Usa RangoFechas.Solapa del contrato compartido.
   - Migra a capas: caso de uso AsignarHorarioPorPeriodo (valida rango y solapamiento), ConsultarHistoricoHorarios (por empleado y rango, ordenado por vigencia),
     IHorarioTemporalRepository en Application, PostgreSqlHorarioTemporalRepository con SQL parametrizado (indica qué método de RRHHClass reemplaza), IxxxView + Presenter,
     y un método CrearAsignacionHorario / CrearHistoricoHorarios en CompositionRoot. Conserva el nombre de los formularios existentes; no los renombres.
   - RF-02 debe permitir ver los turnos pasados y vigentes de una persona; el histórico no se borra al reasignar. Si hoy se sobrescribe, anótalo como hallazgo y corrígelo con commit fix separado.
   - Tests xUnit: rango inválido, solapamiento (igualdad, parcial, contención), empleado distinto, edición sin conflicto consigo mismo, histórico ordenado.
   - Reutiliza el repositorio y los DTO de TEC-001 (Horario*), no los dupliques.

2. Cierre de RF-04/RF-05 (rama fix/rf-04-05-cierre-motivos). TEC-004 ya está integrado por capas; falta lo verificable.
   - Ejecuta en Windows y con datos ficticios: alta, duplicado, edición, baja de un motivo sin uso y baja de un motivo con permisos asociados (debe protegerse).
   - Escribe los casos CP-04-nn y CP-05-nn con resultado obtenido real y capturas en docs/t3/evidencias/RF-04 y RF-05.
   - Si hallas un defecto, commit fix(RF-04) o fix(RF-05) separado del refactor. Coordina con Kadin: su migración puede añadir una columna a Motivo_Perm (RF-06);
     comprueba que MotivoPermisoPostgreSqlTests sigue pasando.

3. Refactorizaciones documentadas (tú las escribiste): REF-003 (motivos de permiso por capas, TEC-004) y REF-004 (horarios a MVP/repositorio, commit 138dbce).
   Un archivo por REF en docs/t3/refactorizaciones/ con los siete campos de la sección 1. Usa código antes/después real (git show de los commits), no reescrito de memoria.
   Principios solo si se pueden justificar con el código (SRP, DIP, DRY).

4. Informe T3: redacta en docs/t3/informe/ las secciones §9 (refactorizaciones aplicadas) y §12 (casos de prueba que ejecutaste). Kadin consolida.

Orden y ritmo: día 1 caracterización y spec de RF-01/02; días 2-3 implementación RF-01 y RF-02; día 4 cierre RF-04/05 y REF; día 5 evidencias y correcciones.
Entrega por cada PR: lo exigido en la sección 1 y el label semver (RF-01 y RF-02: minor; cierre RF-04/05: patch).
No toques FrmFeriado, teletrabajo, permisos solapados ni licencias. Si un cambio exige tocar un archivo de otra persona, pídeselo por el canal del equipo.
```

### Prompt de Jorge

```text
Soy Jorge Enrique Cano Asto. Trabajo en el repositorio RRHH (WinForms .NET Framework 4.8, PostgreSQL, MVP por capas) para la entrega T3.
Mi alcance: RF-13 (registrar periodos de teletrabajo), RF-14 (reportar días de teletrabajo) y, como complementario, RF-16 (reportar quiénes hacen teletrabajo total o parcial).
Mi revisor: Kadin. Soy revisor de Frank.

Antes de editar lee, en este orden: CLAUDE.md, AGENTS.md, Software/docs/ARQUITECTURA.md, specs/PLANTILLA.md, docs/t2/MATRIZ_REQUERIMIENTOS.csv (filas RF-13, RF-14, RF-16),
y las secciones 1 (Reglas comunes) y 2 (Control de versiones) de docs/t3/PROMPTS_POR_INTEGRANTE.md. Aplícalas tal cual, incluido el formato de commits con pie Refs.

Contexto importante: el repositorio no tiene nada de teletrabajo (ni tabla, ni código). Es un módulo nuevo. Hasta hoy mis commits en el repo son solo de documentación;
estos RF deben ser mis commits de código reales, con mi nombre en git config.

Tareas, en este orden:

1. Spec y modelo (día 1). Crea specs/CR-013-registro-teletrabajo.md desde la plantilla y propón a Kadin la tabla public."Teletrabajo" antes de que él escriba la migración:
   propuesta inicial (ajústala): Id, IdEmpleado, FechaInicio, FechaFin, Modalidad ('T' total / 'P' parcial), DiasPresenciales o patrón semanal para 'P', Autorizacion, Estado, FechaRegistro.
   Escribe como HIPÓTESIS lo que no está definido: qué es teletrabajo parcial, si hay autorización obligatoria, si se pueden anular periodos. Pregunta por el canal del equipo y sigue con la hipótesis más simple.

2. RF-13 (rama feature/rf-13-registro-teletrabajo).
   - Domain: PeriodoTeletrabajo (usa RangoFechas del contrato compartido), regla: un empleado no puede tener dos periodos de teletrabajo que se solapen (RangoFechas.Solapa). Modalidad como enum.
   - Application: RegistrarPeriodoTeletrabajo, ListarPeriodosTeletrabajo, AnularPeriodoTeletrabajo si aplica; ITeletrabajoRepository.
   - PostgreSql: PostgreSqlTeletrabajoRepository con SQL parametrizado; el alta valida solapamiento y escribe dentro de una transacción.
   - Presentation: ITeletrabajoView + TeletrabajoPresenter. Formulario nuevo FrmTeletrabajo (permitido: es nuevo) que solo implementa la vista. Método CrearTeletrabajo en CompositionRoot y entrada en el menú de MainMDI.
   - Tests xUnit: rango inválido, solapamiento (igual, parcial, contención), otro empleado no bloquea, modalidad inválida, empleado inexistente.

3. RF-14 (rama feature/rf-14-reporte-dias-teletrabajo).
   - Caso de uso ReportarDiasTeletrabajo(empleado o todos, RangoFechas): cuenta días de teletrabajo dentro del rango pedido, recortando periodos que lo cruzan.
   - Usa CalendarioLaboral.DiasLaborables del contrato compartido (excluye feriados y no laborables) y registra como hipótesis si el reporte cuenta días calendario o laborables.
   - Reporte como lista tipada de DTO enlazada a una grilla (no DataTable). Tests con periodos que cruzan el rango, feriado dentro del periodo y rango sin periodos.

4. RF-16 (rama feature/rf-16-teletrabajo-total-parcial), solo cuando RF-13 esté integrado.
   - Clasifica a cada persona en un rango como total, parcial o sin teletrabajo según su(s) periodo(s) y Modalidad. Reutiliza la consulta de RF-14.

5. Informe T3: redacta en docs/t3/informe/ las secciones §4 (actualización del diagnóstico T2: qué se confirmó, cambió o amplió, módulos mejor comprendidos, reglas confirmadas,
   problemas nuevos, riesgos, partes difíciles), §5 (base técnica reconstruida: estructura, componentes, BD, scripts, limitaciones, decisiones, evidencia de ejecución) y §6 (arquitectura actual con el diagrama de capas).
   Todo con datos del repositorio y commits reales; marca lo observado frente a lo inferido.
   Prepara también tu parte de la exposición: arquitectura y decisiones técnicas.

Orden y ritmo: día 1 spec y propuesta de tabla; día 2 RF-13; día 3 RF-14; día 4 RF-16 y informe; día 5 evidencias. Mientras el PR de Frank con RangoFechas y CalendarioLaboral no esté en main,
usa un duplicado local con la misma firma y bórralo al rebasar. La tabla depende de la migración de Kadin (infra/rf-13-tabla-teletrabajo): no ejecutes DDL propio contra la base compartida.
Labels semver: los tres son minor. No toques permisos, horarios, feriados ni vacaciones.
```

### Prompt de Frank

```text
Soy Frank Piero Mantilla Arqueros. Trabajo en el repositorio RRHH (WinForms .NET Framework 4.8, PostgreSQL, MVP por capas) para la entrega T3.
Mi alcance: RF-03 (no dos permisos el mismo día por persona), RF-06 (licencia de una sola vez al año, p. ej. 30012) y, como complementario, RF-17 (feriados sumados correctamente en el reporte general).
Además creo la base compartida RangoFechas y CalendarioLaboral que usan los demás. Mi revisor: Jorge. Soy revisor de Evelyn (RF-04/05).

Antes de editar lee, en este orden: CLAUDE.md, AGENTS.md, Software/docs/ARQUITECTURA.md, specs/CR-003-permisos-solapados.md, specs/TEC-003-feriados.md,
y las secciones 1 (Reglas comunes) y 2 (Control de versiones) de docs/t3/PROMPTS_POR_INTEGRANTE.md. Aplícalas tal cual, incluido el formato de commits con pie Refs.
Nota: mis commits anteriores aparecen como «Piero»; comprueba git config user.name y user.email antes de empezar.

Tareas, en este orden:

0. Base compartida (día 1, PR pequeño y rápido; rama feature/base-calendario-laboral; commit feat(BASE): …).
   Crea RangoFechas (Domain/Comun) y CalendarioLaboral (Domain/Asistencia) con exactamente la firma de la sección 1, con pruebas xUnit (igualdad, solapamiento parcial, contención en ambos sentidos,
   rango invertido, rangos de un día, feriado en fin de semana). Jorge los usa para RF-14; Evelyn para RF-01. Pídele a Jorge la revisión de inmediato.

1. RF-03 (rama fix/rf-03-permisos-solapados). La spec CR-003 ya tiene análisis. Hallazgo confirmado: RRHHClass.ExistePermiso solo comprueba si un extremo cae dentro del permiso existente
   y no detecta un rango nuevo que contiene a uno existente (ej. existente 10–12, nuevo 9–13). Además FrmPermiso.cs (línea ~1538) solo valida al crear, no al editar.
   - Application: IPermisoRepository.ExisteSolapamiento(idEmpleado, RangoFechas, excluirNPermiso) y el caso de uso ValidarPermisoSinSolapamiento (con ResultadoOperacion y mensaje claro).
   - PostgreSql: PostgreSqlPermisoRepository con SQL parametrizado; indica en el comentario XML que reemplaza RRHHClass.ExistePermiso.
   - Reemplaza en el formulario el guard heredado por el caso de uso creado en CompositionRoot (CrearValidarPermiso). Hay otro llamador en FrmMarcacionesAutorizadas.cs (línea ~1177): contrástalo y decide
     en la spec si se migra también. No migres FrmPermiso completo: déjalo documentado como fuera de alcance.
   - Valida también al editar (excluyendo el propio permiso). Estado/anulados y permisos por horas: hipótesis en la spec.
   - Concurrencia: comprobación e inserción dentro de una transacción; evalúa con Kadin un bloqueo por empleado (advisory lock) o restricción de exclusión. Documenta la decisión.
   - Tests: igualdad, parcial por ambos lados, contención en ambos sentidos, otra persona no bloquea, edición sin conflicto consigo mismo, rango inválido.

2. RF-06 (rama feature/rf-06-licencia-anual).
   - Regla: ciertas licencias (ej. 30012) solo se otorgan una vez por año; si ya existe una de ese tipo para la persona en el año, impedir el registro con mensaje claro
     (el RF permite también advertir: decide una opción y regístrala en la spec).
   - Diseño recomendado: marca configurable en el catálogo de motivos (columna "UnaVezPorAnio" boolean default false en Motivo_Perm; Kadin hace la migración en infra/rf-06-flag-licencia-anual)
     y sembrar 30012 con ella. Evita escribir 30012 fijo en el código. Registra como hipótesis que 30012 es Motivo_Perm.idMotivo y confírmalo con datos ficticios.
     Hipótesis a anotar: el año se toma de FechaInicio; se excluye el propio permiso al editar.
   - Comparte el punto de validación con RF-03 (mismo flujo de alta/edición de FrmPermiso): una sola colaboración que llama a ambas reglas, sin duplicar código.
   - Tests: primera licencia pasa, segunda en el mismo año se rechaza, mismo tipo en otro año pasa, otra persona no bloquea, motivo sin la marca no se restringe, edición propia.

3. RF-17 (rama fix/rf-17-feriados-reporte), complementario.
   - Primero caracteriza: ¿qué es el «reporte general» donde los feriados deben sumarse? Busca dónde se usa RRHH_Feriado y los días feriados en los reportes (FrmReportCuadro, FrmConsultaAsistencias, FrmHorasTrabajadas,
     RRHHClass). Anota el hallazgo y la fórmula actual. Si no hay un reporte único, acota a uno y regístralo.
   - Corrige con CalendarioLaboral (consumidor de IFeriadoRepository de TEC-003). Demuestra con datos ficticios un caso que fallaba antes y pasa ahora (evidencia antes/después).

4. Refactorizaciones documentadas (las hiciste tú): REF-001 (catálogos genéricos, commit 0a4b6a8) y REF-002 (feriados por capas, TEC-003). Un archivo por REF en docs/t3/refactorizaciones/ con los siete campos de la sección 1
   y código antes/después tomado de git show, no de memoria.

5. Informe T3: redacta en docs/t3/informe/ las secciones §13 (problemas técnicos encontrados), §14 (riesgos pendientes), §15 (plan de cierre hacia la evaluación final), §16 (conclusiones) y §17 (recomendaciones).

Orden y ritmo: día 1 base compartida + caracterización RF-03; día 2 RF-03; día 3 RF-06; día 4 RF-17 y REF; día 5 evidencias.
Labels semver: base y RF-03 y RF-17 son patch o none según lo que haga el commit; RF-06 es minor. No toques teletrabajo, horarios ni vacaciones.
```

### Prompt de Kadin

```text
Soy Francisco Kadin Valera Lizarraga. Trabajo en el repositorio RRHH (WinForms .NET Framework 4.8, PostgreSQL/Neon, MVP por capas) para la entrega T3.
Mi alcance: coordinar la base de datos y el control de versiones, implementar RF-18 (reportar personas en vacaciones, licencia, enfermedad u otros motivos entre fechas) como complementario,
y consolidar matrices, casos de prueba y el informe. Mi revisor: Evelyn. Soy revisor de Evelyn (RF-01/02) y de Jorge.

Antes de editar lee, en este orden: CLAUDE.md, AGENTS.md, Software/docs/ARQUITECTURA.md, specs/TEC-002-integridad-bd.md, BD/README.md, docs/versionado/POLITICA_VERSIONADO.md (rama docs/sem12-gestion-versiones),
y las secciones 1 (Reglas comunes) y 2 (Control de versiones) de docs/t3/PROMPTS_POR_INTEGRANTE.md. Aplícalas tal cual, incluido el formato de commits con pie Refs.

Tareas, en este orden:

0. Desbloquear al equipo (primeras horas del día 1).
   - Crear rama docs/t3-versionado desde main y llevar a main: este archivo docs/t3/PROMPTS_POR_INTEGRANTE.md y el contenido de origin/docs/sem12-gestion-versiones (CHANGELOG, política SemVer, registro de versiones, CONTRIBUTING).
     Resolver conflictos conservando lo ajeno. Añadir a CONTRIBUTING el prefijo fix/ y el formato de commit tipo(ALCANCE) con pie Refs (sección 2).
   - Avisar al equipo cuando main esté listo: todos crean sus ramas desde ahí. Comprobar el estado real de los PR abiertos (#10 a #13 según el registro) y qué falta para integrarlos; hoy no hay evidencia de su estado.
   - Crear en GitHub las labels semver:major, semver:minor, semver:patch, semver:none (requiere permisos de administración) y comprobar la protección de main descrita en CONTRIBUTING.

1. Migraciones de BD (días 1-2). Archivos numerados e idempotentes en BD/migrations/, cada uno con su .rollback.sql y probado en una copia local, nunca contra la base compartida sin acordarlo:
   - 20261112_03_teletrabajo.sql: tabla public."Teletrabajo" según la propuesta de Jorge (rama infra/rf-13-tabla-teletrabajo), con clave primaria e índice por (IdEmpleado, FechaInicio, FechaFin). Sin claves foráneas hasta verificar datos.
   - 20261112_04_licencia_una_vez_anio.sql: columna "UnaVezPorAnio" boolean NOT NULL DEFAULT false en public."Motivo_Perm" y marca de la licencia 30012 (rama infra/rf-06-flag-licencia-anual).
     Avisar a Evelyn: sus MotivoPermisoPostgreSqlTests comparan contra BD/schema.sql; regenerar el esquema con BD/export-schema.cmd y comprobar que las pruebas siguen pasando.
   - Datos de prueba completamente ficticios en BD/tests/ para permisos, turnos y teletrabajo, que los demás usen en sus casos de prueba. Cero datos personales.
   - Cerrar TEC-002: documentar en su spec el saneamiento de duplicados y las evidencias que faltan (QA, revisión de Jorge). No marcarlo validado si no hay evidencia.

2. RF-18 (rama feature/rf-18-ausencias-por-periodo).
   - Regla: dado un rango de fechas, listar las personas con ausencia por vacaciones, licencia, enfermedad u otros motivos que se solapen con ese rango (RangoFechas.Solapa), con filtro por motivo o tipo.
     Fuente: public."Permiso" unido a public."Motivo_Perm" (y tipo de permiso). Limitación a registrar: no existe modelo de vacaciones, solo motivos de permiso.
   - Application: ReportarAusenciasPorPeriodo + IAusenciasRepository; PostgreSql: PostgreSqlAusenciasRepository con SQL parametrizado; Presentation: IRepAusenciasView + presenter;
     formulario nuevo FrmRepAusencias y entrada en el menú; método Crear... en CompositionRoot. Lista tipada de DTO, no DataTable.
   - Tests: persona con permiso que cruza el rango, que lo contiene, fuera del rango, filtro por motivo, rango inválido y sin resultados. Spec CR-018 con la ficha del RF.

3. Versionado y releases (continuo; se publica por cada integración).
   - Mantener CHANGELOG.md (formato Keep a Changelog, sección [Sin publicar]) con las líneas que cada autor deja en su PR, y docs/versionado/REGISTRO_VERSIONES.md alineado con el plan de la sección 2
     (v1.0.1 … v1.4.0). Corregir las inconsistencias detectadas: TEC-001 figura «en revisión» aunque su commit ya está en main; el CHANGELOG habla de 65 pruebas y hoy hay más.
   - Para cada versión: rama release/x.y.z desde main, pasar [Sin publicar] a la versión con fecha, PR, merge, git tag -a vx.y.z -m "RRHH x.y.z", git push origin vx.y.z y Release en GitHub con las notas.
     Pre-versión v1.4.0-rc.1 para la QA final. La versión intermedia de T3 es v1.4.0.
   - Evidencia de versionado para el informe: salida de git log --graph --oneline --decorate, git tag -n, capturas de la pestaña de Releases y de la estructura de ramas (reales, no armadas).

4. Consolidación (días 4-5).
   - docs/t2/CONTROL_CAMBIOS.csv: dejarlo con el estado real de las 18 solicitudes y la trazabilidad requerimiento → solicitud de cambio → implementación → commit → prueba → evidencia.
     Los 11 RF comprometidos con commit y caso de prueba; los otros 7 en estado pendiente, con motivo. Sin dejar columnas vacías ni inventar commits.
   - Unir los CSV de docs/t3/casos_prueba/ en docs/t3/CASOS_DE_PRUEBA.csv y comprobar que cada RF implementado tiene al menos un caso ejecutado.
   - Armar docs/t3/informe/ con las 18 secciones del enunciado. Tuyas: §1 carátula, §2 resumen ejecutivo, §3 avances desde T2, §7 requerimientos implementados (tabla con RF, estado, evidencia, commit, CP),
     §8 pendientes, §10 matriz de control de cambios, §11 versionado y repositorio, §18 anexos. Integra §4–6 (Jorge), §9 y §12 (Evelyn), §13–17 (Frank). Revisar coherencia: toda cifra debe salir del repositorio.
   - Lista de cierre antes de entregar: build 0 errores, dotnet test sin fallas (adjuntar salida), 8 mínimos + 3 complementarios demostrables en la aplicación, tag v1.4.0 y Release publicados,
     CHANGELOG sin [Sin publicar] pendiente, evidencia de participación de los cuatro con nombre real.

Orden y ritmo: día 1 desbloqueo (paso 0) y migraciones; día 2 RF-18 y revisiones; días 3-4 releases y revisiones; día 5 consolidación y lista de cierre.
Labels semver: RF-18 es minor; migraciones infra: none. No edito el código de RF ajenos: reviso y comento con archivo y caso concretos.
```

---

## 4. Orden de arranque

0. **Kadin**, antes que nadie: sube este archivo y la documentación de versionado a `main` (rama `docs/t3-versionado`).
1. **Todos**: `git fetch origin`, `git switch main`, `git pull --ff-only origin main` y configurar su nombre real en `git config`.
2. **Frank**: PR de la base compartida (`RangoFechas`, `CalendarioLaboral`) el día 1; **Jorge** lo revisa el mismo día.
3. **Kadin**: migraciones de teletrabajo y de la marca de licencia anual el día 1-2; **Jorge** y **Frank** las necesitan para RF-13 y RF-06.
4. Resto de RF en paralelo, según la sección 0.

## 5. Riesgos conocidos

- **Sin holgura:** 8 + 3 = 11 es el mínimo exacto. Si RF-16, RF-17 o RF-18 falla, el reemplazo es RF-15, y depende de RF-13/14.
- **Teletrabajo sin definición de negocio:** «parcial», autorización y anulación están por confirmar; todo queda como hipótesis hasta que el docente o el área responda.
- **Base compartida:** RF-01, RF-03, RF-13 y RF-14 dependen de `RangoFechas` y `CalendarioLaboral`. Si Frank se retrasa, el duplicado local temporal evita el bloqueo.
- **Migración de `Motivo_Perm`:** toca una tabla que Evelyn migró en TEC-004; hay que regenerar `BD/schema.sql` y repetir sus pruebas.
- **Windows obligatorio:** compilar, ejecutar pruebas y la QA de pantallas requieren Windows y las DLL de DevExpress/GRLL. Quien no pueda hacerlo debe pedirlo antes del día 3.
- **`FrmPermiso` (1610 líneas):** RF-03 y RF-06 modifican su guard, no el formulario entero. Migrarlo completo queda fuera de T3.
