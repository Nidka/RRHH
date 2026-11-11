# T3: lista de cambios por integrante

Guía de orden para la semana. Cada persona marca solo lo suyo y lo respalda con un commit o una evidencia real.
Los detalles de cada tarea están en su prompt de [PROMPTS_POR_INTEGRANTE.md](PROMPTS_POR_INTEGRANTE.md)
(reglas comunes en la sección 1, versionado en la sección 2).

Convención de commits: `tipo(ALCANCE): descripción` y pie `Refs: RF-NN, CR-0NN, CP-NN-nn`.
**Sin `Co-Authored-By` ni líneas de atribución a una IA en commits o PR.** El uso de IA se declara en el apartado «Uso de IA» del PR.

## Antes de empezar (todos, 10 minutos)

- [ ] `git config user.name` y `git config user.email` con tu **nombre real** (no «Nidka», «Piero», «Kike» ni «helcorp»).
- [ ] Esperar el aviso de Kadin de que `main` tiene los documentos de T3. Luego `git fetch origin`, `git switch main`, `git pull --ff-only origin main`.
- [ ] Probar la conexión según `docs/t2/PRIMERA_PRUEBA.md` (Windows, `.env` local, nunca se sube).
- [ ] Crear tu rama desde `main` con el prefijo que corresponda (`feature/`, `fix/`, `refactor/`, `infra/`, `docs/`).

## Evelyn Victoria Rodriguez Cardozo: RF-01, RF-02, RF-04, RF-05

| Día | Tarea | Hecho cuando |
|---|---|---|
| 1 | ☐ Caracterizar `FrmHorarioEsp`, `FrmConsultaHorarioEsp`, `FrmAsignarHorario` y `HorarioTemporal` | Spec `CR-001`/`CR-002` con comportamiento actual, política de conflictos como hipótesis |
| 2 | ☐ RF-01: caso de uso, repositorio, presenter, `CompositionRoot`, pruebas | PR `feature/rf-01-turnos-por-periodo`, label `semver:minor` |
| 3 | ☐ RF-02: histórico por empleado y rango | PR `feature/rf-02-historico-turnos`, label `semver:minor` |
| 4 | ☐ Cierre RF-04/05 en Windows: alta, duplicado, baja con y sin uso; casos `CP-04-nn`, `CP-05-nn` | PR `fix/rf-04-05-cierre-motivos`, capturas reales |
| 4 | ☐ `REF-003` (motivos) y `REF-004` (horarios) con código antes/después de `git show` | Dos archivos en `docs/t3/refactorizaciones/` |
| 5 | ☐ Informe §9 y §12; casos de prueba en `docs/t3/casos_prueba/evelyn.csv`; fila de sus CR en `CONTROL_CAMBIOS.csv` | Todo enlazado a commit y evidencia |
| Revisa | ☐ Revisar el RF-18 de Kadin | Comentarios con archivo y caso concreto |

## Jorge Enrique Cano Asto: RF-13, RF-14, RF-16

| Día | Tarea | Hecho cuando |
|---|---|---|
| 1 | ☐ Spec `CR-013`; proponer a Kadin la tabla `Teletrabajo`; anotar hipótesis (qué es «parcial», autorización, anulación) | Propuesta enviada a Kadin |
| 1 | ☐ Revisar el PR de la base `RangoFechas`/`CalendarioLaboral` de Frank | Aprobado o con observaciones el mismo día |
| 2 | ☐ RF-13: dominio, casos de uso, repositorio, `ITeletrabajoView`, `FrmTeletrabajo`, menú, pruebas | PR `feature/rf-13-registro-teletrabajo`, `semver:minor` |
| 3 | ☐ RF-14: reporte de días de teletrabajo con feriados vía `CalendarioLaboral` | PR `feature/rf-14-reporte-dias-teletrabajo`, `semver:minor` |
| 4 | ☐ RF-16: clasificación total/parcial (tras integrar RF-13) | PR `feature/rf-16-teletrabajo-total-parcial`, `semver:minor` |
| 4 | ☐ Informe §4, §5 y §6 con datos del repositorio, marcando lo observado frente a lo inferido | Documentos en `docs/t3/informe/` |
| 5 | ☐ Casos `CP-13-nn`, `CP-14-nn`, `CP-16-nn` ejecutados con evidencia; parte de la exposición | CSV y capturas reales |
| Revisa | ☐ Revisar los PR de Frank (base, RF-03, RF-06, RF-17) | Comentarios con archivo y caso concreto |

## Frank Piero Mantilla Arqueros: RF-03, RF-06, RF-17

| Día | Tarea | Hecho cuando |
|---|---|---|
| 1 | ☐ **Base compartida** `RangoFechas` y `CalendarioLaboral` con la firma exacta de la sección 1 y pruebas | PR `feature/base-calendario-laboral` abierto el día 1; Jorge lo revisa |
| 1 | ☐ Caracterizar RF-03: `ExistePermiso`, `FrmPermiso` (~línea 1538) y `FrmMarcacionesAutorizadas` (~línea 1177) | Spec `CR-003` actualizada |
| 2 | ☐ RF-03: caso de uso, repositorio, reemplazo del guard heredado, validar también al editar, decisión de concurrencia | PR `fix/rf-03-permisos-solapados`, `semver:patch` |
| 3 | ☐ RF-06 con la marca `UnaVezPorAnio` (migración de Kadin) y punto de validación compartido con RF-03 | PR `feature/rf-06-licencia-anual`, `semver:minor` |
| 4 | ☐ RF-17: identificar el «reporte general», fórmula actual, corrección con `CalendarioLaboral`, evidencia antes/después | PR `fix/rf-17-feriados-reporte`, `semver:patch` |
| 4 | ☐ `REF-001` (catálogos) y `REF-002` (feriados) con código antes/después de `git show` | Dos archivos en `docs/t3/refactorizaciones/` |
| 5 | ☐ Informe §13 a §17; casos `CP-03-nn`, `CP-06-nn`, `CP-17-nn` con evidencia | CSV y capturas reales |
| Revisa | ☐ Revisar RF-04/05 de Evelyn | Comentarios con archivo y caso concreto |

## Francisco Kadin Valera Lizarraga: RF-18, BD, versiones, consolidación

| Día | Tarea | Hecho cuando |
|---|---|---|
| 1 | ☐ **Desbloqueo:** llevar a `main` los documentos de T3 y el contenido de `docs/sem12-gestion-versiones`; añadir `fix/` y el formato de commit a `CONTRIBUTING.md` | PR `docs/t3-versionado` integrado y aviso al equipo |
| 1 | ☐ Crear las labels `semver:major/minor/patch/none` y revisar la protección de `main` | Labels visibles en GitHub |
| 1 | ☐ Comprobar el estado real de los PR abiertos (#10 a #13 según el registro) | Lista de PR con estado y qué falta |
| 1-2 | ☐ Migración `Teletrabajo` y migración `UnaVezPorAnio` (con rollback, probadas en copia local); datos ficticios en `BD/tests/` | PR `infra/…`, `semver:none` |
| 2 | ☐ Regenerar `BD/schema.sql` y avisar a Evelyn para repetir `MotivoPermisoPostgreSqlTests` | Pruebas de motivos pasan |
| 2-3 | ☐ RF-18: ausencias por periodo, repositorio, presenter, `FrmRepAusencias`, menú, pruebas | PR `feature/rf-18-ausencias-por-periodo`, `semver:minor` |
| 1-4 | ☐ Revisar RF-01/02 de Evelyn y RF-13/14/16 de Jorge | Aprobaciones o comentarios por PR |
| 3-4 | ☐ Releases en orden de integración: `v1.0.1`, `v1.1.0`, `v1.1.1`, `v1.2.0`, `v1.2.1`, `v1.3.0`, `v1.4.0` (rc para QA) | Tag anotado y Release en GitHub por cada una |
| 4 | ☐ Cerrar TEC-002: saneamiento, QA y evidencias; corregir inconsistencias del registro (TEC-001 figura «en revisión» y ya está en `main`; el CHANGELOG cita 65 pruebas) | Spec TEC-002 con evidencia o con el motivo de lo pendiente |
| 5 | ☐ `CONTROL_CAMBIOS.csv` final, `CASOS_DE_PRUEBA.csv` unificado, informe con las 18 secciones | Cada RF con commit, caso y evidencia |
| 5 | ☐ Evidencia de versionado real: `git log --graph --oneline --decorate`, `git tag -n`, capturas de Releases y ramas | Archivos en `docs/t3/evidencias/versionado/` |

## Cierre de la semana (revisa Kadin, firma cada responsable)

Mapa a la rúbrica de T3:

**Implementación funcional (8 + 3)**
- [ ] RF-01, RF-02, RF-03, RF-04, RF-05, RF-06, RF-13, RF-14 funcionan en la aplicación real
- [ ] Tres complementarios demostrables (RF-16, RF-17, RF-18)
- [ ] `Software\scripts\build.cmd` con 0 errores; `dotnet test Software\RRHH.Tests` sin fallas, con la salida adjunta

**Refactorización (mínimo 3)**
- [ ] REF-001, REF-002, REF-003, REF-004 con los siete campos y código antes/después real
- [ ] Mejora observable: capas, menor acoplamiento, menos duplicidad

**Gestión del cambio, pruebas y trazabilidad**
- [ ] 18 solicitudes de cambio con estado real; trazabilidad requerimiento → solicitud → implementación → commit → prueba → evidencia
- [ ] Casos de prueba con código, RF, datos, resultado esperado, resultado obtenido, estado y evidencia
- [ ] Ninguna cifra ni captura inventada; lo no ejecutado figura como pendiente

**Versionado y repositorio**
- [ ] `CHANGELOG.md` sin `[Sin publicar]` pendiente, versión intermedia `v1.4.0` y Releases publicados
- [ ] Commits con `tipo(ALCANCE)` y pie `Refs:`; sin `Co-Authored-By` de IA; autoría con nombres reales de los cuatro
- [ ] Ramas por tarea, PR revisados por otra persona, sin push directo ni force push a `main`

**Informe T3 (18 secciones) y exposición**
- [ ] §1–3, 7, 8, 10, 11, 18: Kadin · §4–6: Jorge · §9 y 12: Evelyn · §13–17: Frank
- [ ] Diapositivas coherentes con la aplicación; cada integrante puede explicar lo que implementó
