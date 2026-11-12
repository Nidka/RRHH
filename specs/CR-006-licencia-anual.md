# CR-006: licencia que se otorga una sola vez al año

- Estado: Implementado en la rama `feature/rf-06-licencia-anual` (T3); en pruebas. **Bloqueado para integrar** hasta que exista la migración de BD que crea `Motivo_Perm."UnaVezPorAnio"` (rama `infra/rf-06-flag-licencia-anual`, a cargo de Kadin). Faltan QA en la aplicación y la revisión de Jorge.
- Tarea / RF / CR: RF-06 (obligatorio) / CR-006.
- Autor responsable / revisor: Frank Piero Mantilla Arqueros / Jorge Enrique Cano Asto.
- Versión/commit analizado: `d4f9345` (`origin/main` con el PR #16).
- Evidencias / PR: pruebas automáticas en `Software/RRHH.Tests/Permisos/`; capturas de la aplicación y PR pendientes.
- Versión propuesta: MINOR (función nueva).
- Dependencias: RF-03 (rama `fix/rf-03-permisos-solapados`, comparten el punto de validación y `IPermisoRepository`) y la migración de Kadin.

## Problema y comportamiento actual

**Hallazgo (lectura de código, sin ejecutar el original).** `FrmPermiso` guarda cualquier permiso sin consultar si el motivo es una licencia de una vez por año. No hay ninguna regla anual en el código ni en el SQL. Las búsquedas anteriores ([análisis](../docs/analisis_codex/04_reglas_negocio.md), sección «Licencia 30012») no encontraron el literal `30012`.

**Sobre el número 30012.** No aparece como `idMotivo` en la evidencia de catálogos de TEC-004 (`docs/t2/evidencias/TEC-004/catalogos-solo-lectura.txt`, que lista ids 1, 5, 7, 8, 12, 53, 72, 78, 105, 109, 112, 119, 132, 134, 135…). Es más probable que sea un número de norma (el motivo 132 se describe como «LICENCIA POR PATERNIDAD - LEY N° 30807», lo que sugiere esa convención) que un identificador de la tabla. **Hipótesis sin confirmar:** 30012 corresponde a uno de los motivos del catálogo. Por eso el código no contiene ningún número: la regla se activa con una marca en el catálogo.

## Resultado esperado y alcance

Si un motivo está marcado como «una vez por año» y el empleado ya tiene otro permiso del mismo motivo que empieza en el mismo año, no se permite registrar (ni editar hacia ese año) otro. El mensaje indica el año.

**Decisiones e hipótesis**

| Tema | Decisión |
|---|---|
| Bloqueo o advertencia | **Bloqueo** (la opción más simple y reversible; el RF también admite advertir). |
| Año | Se toma de la fecha de inicio del permiso. Un permiso que cruza de año solo ocupa el año en que empieza. |
| Edición | El propio permiso no cuenta contra sí mismo. |
| Qué motivos | Los que tengan `Motivo_Perm."UnaVezPorAnio" = true`. Nulo o motivo inexistente: sin restricción. |
| Punto de validación | `ValidarPermiso` aplica RF-03 y luego RF-06; el formulario solo conoce esa clase. Si ambas fallan, se muestra el solapamiento. |
| Permisos anulados | `public."Permiso"` no tiene columna de anulación: todo permiso registrado cuenta. |
| Concurrencia | Igual que RF-03: la validación y la escritura (`PermisoMapper`) son pasos separados y dos solicitudes simultáneas pueden pasar. Pendiente con Kadin (ver CR-003). |

**Fuera de alcance:** migrar `FrmPermiso` completo; el mantenimiento del catálogo de motivos (`FrmMotivoPermiso`) no muestra todavía la marca nueva: hoy se activa directamente en la base. Añadirla a esa pantalla pertenece a TEC-004 / Evelyn.

## Contrato con la migración de Kadin

El código asume exactamente esto (a entregar en `BD/migrations/20261112_04_licencia_una_vez_anio.sql` con su `.rollback.sql`):

```sql
ALTER TABLE public."Motivo_Perm" ADD COLUMN IF NOT EXISTS "UnaVezPorAnio" boolean NOT NULL DEFAULT false;
-- Marcar el motivo que corresponda a la licencia 30012 una vez confirmado su idMotivo real.
```

- **Orden de integración:** la migración debe estar aplicada antes de desplegar este código. Sin la columna, `MotivoSeOtorgaUnaVezPorAnio` lanza un error de PostgreSQL (columna inexistente) y `FrmPermiso` no podrá guardar ningún permiso. No se captura el error a propósito para no ocultar una base sin migrar.
- Avisar a Evelyn: `BD/schema.sql` cambia y sus `MotivoPermisoPostgreSqlTests` comparan contra él; hay que regenerar el esquema (`BD/export-schema.cmd`) y repetir esas pruebas.
- Confirmar con datos ficticios o de QA qué `idMotivo` corresponde a 30012 antes de marcarlo.

## Criterios de aceptación

- Primera licencia del año para la persona: se acepta.
- Segunda del mismo motivo en el mismo año: se rechaza con mensaje claro.
- Mismo motivo en otro año: se acepta.
- Otra persona con la licencia del año: no bloquea.
- Motivo sin la marca: no se restringe.
- Editar la propia licencia: se acepta.
- Sin motivo seleccionado: no se restringe y no se consulta.

## Impacto y diseño

- Tipo de mantenimiento: adaptativo (nueva restricción del área usuaria). Patrones: Repository (`IPermisoRepository`) y un punto único de validación (`ValidarPermiso`) que agrupa las reglas por composición. Principios: OCP/SRP (una regla nueva se agrega como colaborador sin tocar el formulario), DRY (un solo guard para RF-03 y RF-06).

| Capa/archivo | Cambio | Riesgo y mitigación |
|---|---|---|
| `RRHH.Application/Permisos/IPermisoRepository.cs` | `MotivoSeOtorgaUnaVezPorAnio`, `ExistePermisoDelMotivoEnAnio`. | Aditivo sobre RF-03. |
| `RRHH.Application/Permisos/ValidarLicenciaUnaVezPorAnio.cs` | Regla RF-06. | Solo valida; no escribe. |
| `RRHH.Application/Permisos/ValidarPermiso.cs` | Punto único RF-03 + RF-06. | — |
| `RRHH.PostgreSql/Permisos/PostgreSqlPermisoRepository.cs` | SQL parametrizado; el año se compara como rango de fechas tipadas. | Depende de la columna nueva (ver arriba). |
| `RecursosHumanos/CompositionRoot.cs` | `CrearValidarPermiso()` ahora devuelve `ValidarPermiso`. | Cambia el tipo devuelto del RF-03; su único llamador es `FrmPermiso`. |
| `RecursosHumanos/FrmPermiso.cs` | Pasa el motivo seleccionado al punto de validación. | Si no hay motivo (0) la regla no se aplica. |

## Verificación

| Caso / comando | Resultado esperado | Resultado real / entorno / evidencia |
|---|---|---|
| `Software\scripts\build.cmd` | 0 errores | 0 errores (Windows) |
| `dotnet test Software\RRHH.Tests\RRHH.Tests.csproj` | Sin fallas | 212 correctas, 0 con error, 28 omitidas (integración PostgreSQL). Incluye la base, RF-03 y RF-06 |
| `ValidarLicenciaUnaVezPorAnioTests` y `ValidarPermisoTests` (CP-06-01 a CP-06-08) | Ver criterios de aceptación | Correctas |
| SQL de `MotivoSeOtorgaUnaVezPorAnio` y `ExistePermisoDelMotivoEnAnio` contra una BD con la columna | Detecta la segunda licencia del año | **Pendiente**: no se ejecutó; requiere la migración |
| Registrar dos licencias marcadas del mismo año en `FrmPermiso` con datos ficticios | La segunda se rechaza con el mensaje | **Pendiente** (capturas en `docs/t3/evidencias/RF-06/`) |

## Ficha del RF

| Campo | Valor |
|---|---|
| Código | RF-06 |
| Descripción | Impedir (o advertir) una segunda licencia de una vez por año, por ejemplo 30012, en el mismo año |
| Módulo | Permisos |
| Pantalla / clase | `FrmPermiso` (guard), `ValidarPermiso`, `ValidarLicenciaUnaVezPorAnio`, `PostgreSqlPermisoRepository` |
| Regla aplicada | Marca configurable `UnaVezPorAnio` en el motivo; año de la fecha de inicio; bloqueo |
| Evidencia | Pruebas automáticas ejecutadas; SQL y pantalla pendientes |
| Estado | En pruebas (bloqueado por la migración) |
| Commits | Ver `git log feature/rf-06-licencia-anual` (pie `Refs: RF-06, CR-006`) |
| Casos de prueba | CP-06-01 a CP-06-08 en `docs/t3/casos_prueba/frank.csv` |

## Reversión

Revertir el commit `feat(RF-06)`; el formulario vuelve a llamar solo a la regla del RF-03. La columna `UnaVezPorAnio` es inocua si queda en la base.

## Uso de IA y decisiones humanas

El diseño, el código y las pruebas se prepararon con un asistente de IA a partir de la lectura del repositorio. La decisión bloqueo/advertencia, el año de referencia y qué motivo es «30012» las debe confirmar el responsable con el área usuaria.
