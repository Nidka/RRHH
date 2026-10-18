# Evidencia TEC-002 — diagnóstico y pruebas

- Fecha: 18/10/2026 (America/Lima).
- Código: `06ca7f6`, rama `infra/tec-002-integridad-bd`.
- Responsable: Kadin; revisión pendiente de Jorge.
- Datos: perfilado agregado de la instancia configurada; pruebas de escritura
  solo en PostgreSQL local temporal con datos ficticios.
- Secretos y datos personales: no se imprimieron ni guardaron.

## Entorno configurado y acceso

La conexión de `.env` llega a Neon/PostgreSQL 18.6 y usa el rol propietario
`neondb_owner`. Se trató como instancia compartida no autorizada para
escrituras: únicamente se ejecutaron transacciones `READ ONLY`.

La aplicación distingue la cuenta PostgreSQL de la cuenta del formulario. El
perfilado encontró **una** cuenta técnicamente elegible para el sistema RRHH
`0500000` (activa, con hash y rol), sin revelar su login. No se dispone de una
confirmación humana de identidad/contraseña ni de que sus registros asociados
sean ficticios. Por ello, el usuario RRHH de prueba y la QA de WinForms quedan
pendientes; no se cambió ninguna contraseña.

## Perfil de integridad observado

| Tabla | Filas | IDs distintos | IDs repetidos | Copias por ID | Conflictos de contenido |
|---|---:|---:|---:|---:|---:|
| Horario | 140 | 70 | 70 | 2 | 0 |
| RRHH_Feriado | 442 | 221 | 221 | 2 | 0 |
| TipoPermiso | 6 | 3 | 3 | 2 | 0 |
| Motivo_Perm | 280 | 140 | 140 | 2 | 0 |

Las cuatro tablas solo tenían restricciones `NOT NULL`; no tenían PK, FK ni
identidad/default. Las 221 fechas de feriado también aparecen dos veces con el
mismo ID. Cada grupo duplicado contiene dos filas byte-lógicamente iguales al
comparar su representación JSON; no se observaron variantes conflictivas.

Se contaron cero huérfanos en:

- Asistencia, Empleado, Marcacion y HorarioTemporal hacia Horario.
- Motivo_Perm hacia TipoPermiso.
- Permiso y `Permiso_Aud.idMotivo_Ant/idMotivo_Act` hacia Motivo_Perm.

Esto es evidencia de una carga duplicada, no autorización para borrar una
copia. Debe confirmarse contra el origen y un respaldo en QA antes de sanear.

## Diagnóstico

**Evidencia:** IDs duplicados al 100 %, ausencia de claves y generación manual
histórica. **Problema:** una fila no puede identificarse de forma unívoca y un
JOIN multiplica resultados; `MAX+1` permite colisiones entre escritores.
**Impacto:** consultas ambiguas, altas rechazadas por las capas nuevas y riesgo
de corrupción/referencias inválidas. **Recomendación:** sanear una copia con
aprobación, aplicar PK/identidad/FK, validar consumidores y recién después
programar el despliegue compartido.

Clasificación: mantenimiento preventivo por integridad y concurrencia. La
configuración/despliegue PostgreSQL anterior es adaptación y no se atribuye a
esta implementación.

## Pruebas ejecutadas

PostgreSQL local 14.23, clúster temporal en `/tmp`, base desechable y fixture
ficticio de `BD/tests/tec002_fixture.sql`:

| Caso | Esperado | Obtenido |
|---|---|---|
| Migración limpia | 4 PK, 4 identidades, 8 FK validadas | Aprobado |
| Secuencias sobre máximos 5/12/3/10 | Nuevos 6/13/4/11 | Aprobado |
| Referencia inexistente | Rechazo FK | Aprobado |
| Mismo día con distinta hora | Rechazo único | Aprobado |
| Repetición de migración | Sin cambio ni colisión | Aprobado |
| Dos inserts simultáneos de motivo | IDs diferentes | Aprobado: 11 y 12 |
| Duplicado previo | SQLSTATE 23505 y cero PK creadas | Aprobado |
| Huérfano previo | SQLSTATE 23503 y cero PK creadas | Aprobado |
| Reversión estructural | Conserva filas y retira objetos TEC-002 | Aprobado: 2 filas, 0 restricciones TEC-002 |

No se ejecutó `dotnet test` ni WinForms porque este equipo macOS no tiene SDK
`dotnet` ni el ejecutable/dependencias Windows. No se aplicó la migración ni se
hicieron escrituras en Neon. `BD/schema.sql` no se actualiza hasta exportar el
esquema de una QA realmente saneada.

## Recuperación

La reversión SQL solo retira PK/FK/identidades/índice. Si el despliegue recibe
escrituras, la recuperación recomendada es restaurar el dump previo en un
destino nuevo, validar conteos y cambiar la configuración; no se debe intentar
recuperar datos revirtiendo código ni eliminando filas nuevas.
