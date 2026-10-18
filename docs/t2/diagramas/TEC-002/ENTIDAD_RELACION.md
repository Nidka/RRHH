# Diagrama entidad-relación TEC-002

```mermaid
erDiagram
    HORARIO ||--o{ ASISTENCIA : "idHorario"
    HORARIO ||--o{ EMPLEADO : "idHorario"
    HORARIO ||--o{ MARCACION : "idHorario"
    HORARIO ||--o{ HORARIO_TEMPORAL : "HorarioAsignado"

    TIPO_PERMISO ||--o{ MOTIVO_PERM : "idTipoPermiso"
    MOTIVO_PERM ||--o{ PERMISO : "idMotivo"
    MOTIVO_PERM ||--o{ PERMISO_AUD : "idMotivo_Ant"
    MOTIVO_PERM ||--o{ PERMISO_AUD : "idMotivo_Act"

    HORARIO {
        int idHorario PK
    }
    RRHH_FERIADO {
        int idFeriado PK
        timestamp Fecha UK
        varchar Motivo
    }
    TIPO_PERMISO {
        int idTipoPermiso PK
    }
    MOTIVO_PERM {
        int idMotivo PK
        int idTipoPermiso FK
    }
```

Las referencias son opcionales donde la columna existente admite `NULL`. Todas
las FK usan restricción de borrado (sin cascada). `RRHH_Feriado` no tiene una
relación entrante identificada en `schema.sql`; la unicidad es por
`Fecha::date`, no por timestamp completo.
