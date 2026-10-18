# Contrato de IDs TEC-002

Destinatarios: Jorge (TEC-001), Frank (TEC-003) y Evelyn (TEC-004).
Responsable: Kadin. Revisor: Jorge. Fecha: 18/10/2026.

## Contrato acordado para integración

| Tabla | Clave | Generación | Alta recomendada | Referencias protegidas |
|---|---|---|---|---|
| `Horario` | `idHorario integer PK` | `IDENTITY BY DEFAULT` | Omitir ID y usar `RETURNING "idHorario"` | Asistencia, Empleado, Marcacion y HorarioTemporal |
| `RRHH_Feriado` | `idFeriado integer PK` | `IDENTITY BY DEFAULT` | Omitir ID y usar `RETURNING "idFeriado"` | Sin FK entrante identificada; fecha calendario única |
| `TipoPermiso` | `idTipoPermiso integer PK` | `IDENTITY BY DEFAULT` | Omitir ID y usar `RETURNING "idTipoPermiso"` | Motivo_Perm |
| `Motivo_Perm` | `idMotivo integer PK` | `IDENTITY BY DEFAULT` | Omitir ID y usar `RETURNING "idMotivo"` | Permiso y ambos valores de Permiso_Aud |

`BY DEFAULT` conserva compatibilidad con restauraciones o cargas que traigan
IDs explícitos. Después de una carga explícita debe repetirse la migración o
alinearse la secuencia antes de habilitar escrituras; PostgreSQL no avanza una
secuencia automáticamente cuando se inserta un ID explícito.

Las bajas se restringen cuando existen referencias. No hay cascadas. La
auditoría también conserva sus referencias, por lo que borrar un motivo usado
requiere una decisión de negocio distinta y no forma parte de TEC-002.

## Instrucciones por paquete

- Jorge: el repositorio nuevo de horarios debe omitir `idHorario` en altas y
  obtenerlo con `RETURNING`. No usar `MAX+1`.
- Frank: el código integrado de feriados sigue siendo compatible porque la
  identidad es `BY DEFAULT`, pero la siguiente modificación del repositorio
  debe omitir `idFeriado`; el índice único rechaza dos feriados el mismo día.
- Evelyn: el repositorio de motivos ya detecta default/identidad, omite el ID y
  usa `RETURNING`. El alta exige exactamente un `TipoPermiso` válido.

## Condición de integración

La instancia compartida todavía no cumple este contrato: todas las claves del
alcance están duplicadas por pares. Primero se restaura una copia QA, se revisa
la procedencia de la duplicación, se aprueba el saneamiento y se ejecuta
`20261018_02_integrity_ids.sql`. La migración aborta sin cambios si encuentra
duplicados o huérfanos; no deduplica datos reales.

Fuente reproducible: `BD/diagnostics/tec002_profile.sql`. Migración y reversión:
`BD/migrations/20261018_02_integrity_ids*.sql`.
