# Plan de refactorización

Orden en que se migran las pantallas a la arquitectura MVP por capas
([ARQUITECTURA.md](ARQUITECTURA.md)) y a PostgreSQL. Se basa en un
inventario del código hecho el 2026-10-13: 73 formularios,
`ClassRRHH` y `BD/schema.sql`.

## Estado

| # | Etapa | Estado |
|---|---|---|
| 1 | Catálogos simples | ✔ Hecho |
| 1b | Claves y secuencias en PostgreSQL | Pendiente |
| 2 | Empleados | Pendiente |
| 3 | Permisos | Pendiente |
| 4 | Asistencia | Pendiente |
| 5 | Legajo | Pendiente |
| 6 | Ficha social | Pendiente |
| 7 | Reportes | Pendiente |
| — | Seguridad del login | Pendiente (obligatorio antes de producción) |

## Diagnóstico

- **Catálogos compartidos.** `TipoTrabajador` se usa 28 veces en los
  formularios, `Motivo_Perm` 22 y `Horario` 11, casi siempre para llenar
  combos. Mientras sigan en LINQ-to-SQL, las pantallas que los usan no pueden
  dejar SQL Server.
- **`RRHHClass` está migrada a medias.** Las consultas simples ya usan
  PostgreSQL. Siguen en SQL Server 29 procedimientos `spRRHH_*` que **no
  existen en PostgreSQL**: fichas, reportes, consultas de asistencia,
  planilla, estadística de permisos y horas extras.
- **El esquema PostgreSQL no tiene claves.** No hay claves primarias,
  foráneas ni secuencias. Los códigos se generan como "máximo + 1" y hay filas
  duplicadas. En los catálogos migrados, el repositorio revisa las
  referencias antes de borrar; en el resto del sistema, el borrado de
  registros en uso no se detecta.
- **Columnas inexistentes.** `TipoDocID`, `TipoEstudio` y `TipoInstitucion`
  mostraban una columna "Abreviatura" que no existe en PostgreSQL. Desde la
  etapa 1 se oculta.

## Etapas

### 1. Catálogos simples ✔

Los 10 mantenimientos de código + descripción usan un componente genérico
(`CatalogoPresenter`, `PostgreSqlCatalogoRepository`, `VistaCatalogoGrid`):
`FrmMantEstCivil`, `FrmMantCargos`, `FrmMantGrupoSanguineo`,
`FrmMantNacionalidades`, `FrmMantRegimen`, `FrmMantTipoDocIdent`,
`FrmMantTipoEstudio`, `FrmMantTipoInst`, `FrmMantTipoPerm` y
`FrmMantTipoTrab`.

**Pendiente de esta etapa:**

- Exponer una consulta de solo lectura para los combos y reemplazar los
  `TipoTrabajadorMapper`, `TipoPermisoMapper` y demás usos en otras pantallas.
- Migrar los catálogos con reglas propias, cada uno con su propio presenter:
  `FrmMantHorarios`, `FrmMantMotivo`, `FrmMotivoPermiso` y `FrmFeriado`.

### 1b. Claves y secuencias en PostgreSQL (en paralelo)

Restaurar claves primarias, secuencias (`GENERATED ... AS IDENTITY`) y claves
foráneas, empezando por los catálogos. Antes hay que limpiar los duplicados
existentes. Al terminar, los repositorios dejan de usar "máximo + 1" con
bloqueo de tabla, y la revisión de referencias de `MapeosCatalogo` queda
como respaldo (la revisión en código no evita que otra sesión inserte una
referencia al mismo tiempo; la clave foránea sí).

### 2. Empleados

`FrmMantEmpleado_Basico` y `FrmBuscarPersona`. Es la entidad central. Su
acceso a datos ya está casi todo en PostgreSQL, a través de `RRHHClass`
(22 y 14 llamadas).

### 3. Permisos

`FrmPermiso`, `FrmConsultaPermisos` y los motivos. Dependen de los catálogos
y de los empleados.

### 4. Asistencia (riesgo alto)

Horarios, asignación de horarios, asistencia manual, importación y
consultas. Para la importación hay un refactor previo en
[`../referencia/AsistenciaImport`](../referencia/README.md). Antes hay que
reescribir en SQL parametrizado los procedimientos de asistencia
(`spRRHH_GetAsistencias`, `spRRHH_RepAsisdiarria`,
`spRRHH_RepPlanillaAsistencias`, `spRRHH_ObtenerHorasExtras`, …) y validarlos
contra resultados conocidos del sistema original.

### 5. Legajo

Estudios, experiencia laboral, capacitaciones, títulos, familiares,
documentos, resoluciones y rotaciones. Son pantallas pequeñas (450 a 1.900
líneas) que dependen de los empleados.

### 6. Ficha social (riesgo alto)

`FrmFichaSocial` tiene 14.370 líneas y usa 37 mappers. Se divide en varias
vistas (vivienda, salud, dinámica familiar, aspectos socioeconómicos), cada
una con su propio presenter.

### 7. Reportes (riesgo alto)

`DataSet1`, `Report_*` y `XtraReport*`. Dependen de 15 procedimientos
`spRRHH_Report*` y `spRRHH_Ficha_*`. Se migran a clases `XxxReportQuery`
cuando sus datos de origen ya están migrados.

### Seguridad del login

El login actual no verifica la contraseña del usuario final: selecciona el
perfil de un usuario activo. Antes de producción hay que implementar una
identidad verificable (Active Directory/OIDC o credenciales con hash
moderno). Ver [POSTGRESQL_MIGRATION.md](POSTGRESQL_MIGRATION.md).

## Cómo medir el avance

```powershell
graphify update Software
```

En `Software/graphify-out/GRAPH_REPORT.md`, las conexiones de
`dcGRLLDataContext` y `GenericMapper` deben bajar con cada etapa. La etapa
termina cuando sus pantallas cumplen la definición de terminado de
ARQUITECTURA.md (sección 9).
