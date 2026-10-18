# Diagrama de despliegue TEC-002

```mermaid
flowchart LR
    WIN[Equipo Windows x86<br/>WinForms .NET 4.8] -->|TLS / credencial externa| QA[(PostgreSQL QA<br/>datos ficticios)]
    ENV[.env local ignorado<br/>o almacén de secretos] -. configura .-> WIN

    ADM[Operador autorizado<br/>psql / pg_dump / pg_restore] --> BAK[(Respaldo cifrado<br/>fuera de Git)]
    ADM --> CLONE[(Restauración aislada)]
    CLONE --> PROFILE[Perfilado TEC-002<br/>solo conteos]
    PROFILE --> APPROVE{Datos limpios<br/>y aprobación}
    APPROVE -->|sí| MIG[20261018_02<br/>PK + identity + FK]
    APPROVE -->|no| STOP[Abortar sin cambios<br/>resolver datos/origen]
    MIG --> SQLTEST[Pruebas SQL<br/>concurrencia y rechazo]
    SQLTEST --> APPQA[Pruebas WinForms<br/>Jorge / Frank / Evelyn]
    APPQA --> EXPORT[Exportar schema.sql<br/>sin datos ni propietarios]
```

La instancia compartida observada no se identifica como QA ficticia y utiliza
un rol propietario. Ninguna contraseña, host ni cadena de conexión forma parte
del diagrama o del repositorio.
