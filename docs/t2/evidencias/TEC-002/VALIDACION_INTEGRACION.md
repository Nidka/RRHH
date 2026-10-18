# TEC-002: validación para integrar PR #8

- Fecha: 18/10/2026, America/Lima.
- Aporte de Kadin: `c7b2c084ae9ee8a32d4bac58f3150c26ebbea489`.
- Base `main` incorporada: `138dbce6951d8472cfcbf1a8434d97d33c51234a`.
- Integración solicitada por Evelyn; resolución y comprobación técnica
  asistidas por Codex. No acredita aprobación humana del revisor asignado.
- Entorno ejecutado: macOS arm64, PostgreSQL **14.20 (Homebrew)**, clúster
  temporal propio, sólo socket Unix y bases desechables con datos ficticios.
- No se leyó `.env`, no se conectó a Neon ni se aplicaron cambios compartidos.

## Conflicto resuelto

Únicamente `docs/t2/PLAN_EQUIPO.md`: conservar la continuación TEC-001 por
Evelyn y el encargo global de diagramas a Kadin que ya estaban en main;
incorporar perfilado, avances y pendientes de TEC-002. Los borradores locales
del informe no forman parte de este PR.

Se actualiza el destinatario del contrato de horarios y se delimita la
reversión estructural: no es una inversa diferencial de objetos preexistentes.

## Comprobaciones ejecutadas

Se usaron los scripts del PR en este orden lógico, sobre destino local propio:

```text
BD/tests/tec002_fixture.sql
BD/migrations/20261018_02_integrity_ids.sql
BD/tests/tec002_assertions.sql
repetición de la migración
casos independientes de concurrencia, reversión y precondiciones
schema.sql completo en otra base vacía + migración + repetición
```

| Comprobación | Resultado |
|---|---|
| Fixture y aserciones de Kadin: 4 PK, 4 identidades BY DEFAULT, 8 FK validadas, IDs 6/13/4/11 y rechazo FK/fecha | Correcto |
| Repetición de migración | Correcto |
| Dos inserts simultáneos de motivo | IDs diferentes, 11 y 12 |
| Reversión sobre fixture conserva filas | Correcto |
| Reversión retira PK/FK/identidades creadas en ese ensayo | Correcto |
| Duplicado previo aborta | SQLSTATE 23505 |
| Duplicado no deja PK/identidades parciales | Correcto |
| Huérfano previo aborta | SQLSTATE 23503 |
| Huérfano no deja PK/identidades parciales | Correcto |
| Fecha de feriado repetida en distinta hora aborta | SQLSTATE 23505 |
| Fecha repetida no deja PK/identidades parciales | Correcto |
| Migración y repetición sobre las 105 tablas del schema completo vacío | Correcto |
| Esquema completo conserva 8 FK validadas | Correcto |
| ID explícito 500, alineación y siguiente ID automático | 501 |

**14 comprobaciones correctas.** Para cargar el dump PostgreSQL 18 con servidor
14 se omitieron únicamente `\restrict`, `\unrestrict` y
`SET transaction_timeout`; no se cambiaron tablas/columnas ni los scripts del PR.
El clúster temporal fue detenido al finalizar.

## Límites y pendientes

- No se repitió build/test C# ni WinForms: el PR no introduce cambios C# propios;
  la comprobación ejecutada corresponde a SQL y documentación de integración.
- La evidencia original de Kadin se conserva con su entorno declarado;
  PostgreSQL 14.20 es el entorno de esta comprobación, no un cambio de su registro.
- La instancia compartida todavía requiere confirmación de QA, respaldo,
  saneamiento autorizado, ensayo de restauración y despliegue programado.
- Quedan QA Windows de la versión conjunta y revisión humana asignada. Integrar
  estos archivos no completa TEC-002 ni demuestra aplicada la migración en Neon.
