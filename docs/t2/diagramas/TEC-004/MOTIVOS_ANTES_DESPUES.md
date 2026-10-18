# TEC-004: motivos de permiso antes y después

Responsable: Evelyn Victoria Rodriguez Cardozo. Diagramas elaborados con asistencia de IA el 17/10/2026. Antes: f713383. Después: commit 01db40b en refactor/tec-004-motivos-permiso.

Fuentes: [listado](../../../../Software/RecursosHumanos/RecursosHumanos/FrmMotivoPermiso.cs), [editor](../../../../Software/RecursosHumanos/RecursosHumanos/FrmMantMotivo.cs), [composición](../../../../Software/RecursosHumanos/RecursosHumanos/CompositionRoot.cs). El estado anterior se consulta con `git show f713383:<ruta>`. Inferidos del código; pendientes de contrastar visualmente en Windows. No son capturas del ejecutable original.

## Flujo anterior: inferido de f713383

```mermaid
flowchart TD
    A[Menú de motivos] --> B[Formulario carga TipoPermisoMapper]
    B --> C[Seleccionar tipo]
    C --> D{Rol de sesión}
    D -->|10| P[Consulta modalidad P]
    D -->|14| Q[Consulta modalidad C]
    D -->|13| R[Consulta sin filtro de modalidad]
    P --> L[Listado]
    Q --> L
    R --> L
    L --> E[Abrir editor de motivo existente]
    E --> F[Leer motivo con mapper]
    F --> G[UPDATE durante Load]
    G --> H{Acción del usuario}
    H -->|Cancelar| I[Cierra después de una escritura]
    H -->|Guardar| J[Reconstruir entidad y actualizar]
    L --> N[Alta: calcular MAX más uno]
    N --> O[Insertar con mapper]
    O --> S[Recarga repetida por rol]
    J --> S
    L --> X[Borrado directo con mapper]
    X --> S
```

## Flujo implementado: pendiente de validación visual

```mermaid
flowchart TD
    A[CompositionRoot ensambla vista y presenter] --> B[Cargar tipos reutilizando ListarCatalogo]
    B --> C[Seleccionar tipo]
    C --> D[Presenter usa una única recarga]
    D --> E[Consulta parametrizada por tipo y modalidad]
    E --> F[Listado tipado]
    F --> G{Acción}
    G -->|Alta o edición| H[Composición abre editor]
    H --> I[Consulta sin escribir en Load]
    I --> J{Guardar o cancelar}
    J -->|Cancelar| K[Cierra sin escribir]
    J -->|Guardar| L[Validar regla y alcance del rol]
    L --> M{Válido}
    M -->|No| N[Mensaje y editor permanece abierto]
    M -->|Sí| O[Repositorio guarda campos editables]
    O --> P[Cierra y recarga listado]
    G -->|Eliminar| Q{Selección y confirmación}
    Q -->|No| R[Sin cambios]
    Q -->|Sí| S[Comprobar permisos y auditoría]
    S --> T{Referenciado}
    T -->|Sí| U[Rechazo claro y conserva historial]
    T -->|No| V[Borrar dentro de transacción]
    V --> P
    P --> D
```

## Dependencias implementadas

```mermaid
flowchart TD
    ROOT[CompositionRoot] --> VIEW[FrmMotivoPermiso y FrmMantMotivo]
    ROOT --> PRES[Presenters de listado y editor]
    ROOT --> REPO[PostgreSqlMotivoPermisoRepository]
    VIEW -->|Eventos y datos de vista| PRES
    PRES --> APP[Listar, Obtener, Guardar y EliminarMotivoPermiso]
    PRES --> TIPOS[ListarCatalogo existente]
    APP --> DOM[MotivoPermiso y AccesoMotivosPermiso]
    APP --> I[IMotivoPermisoRepository]
    REPO -. implementa .-> I
    REPO --> PG[(PostgreSQL)]
```

Los formularios conservan controles GRLL/DevExpress por compatibilidad visual; los presenters no los referencian. Las flechas muestran responsabilidades/llamadas, no un supuesto acceso directo del caso de uso a la implementación concreta. MVP y Repository son patrones; SRP/DRY/DIP son principios; la provisión por constructor desde composición aplica IoC.

## Entradas, procesos y salidas

- Entrada: tipo, selección, descripción, abreviatura, salario y rol proporcionado desde composición.
- Proceso: filtrado por tipo/modalidad, validación, conservación de campos ocultos, transacciones y comprobación de referencias.
- Salida: listado, editor cargado, confirmación, error o persistencia comprobable.
- Cambios de comportamiento deliberados: no UPDATE al abrir; rechazo de entradas inválidas; protección de selección/historial; alta válida en tabla vacía.

SVG exportados para diapositivas: [diagrama 1](svg/motivos-antes-despues-1.svg), [diagrama 2](svg/motivos-antes-despues-2.svg), [diagrama 3](svg/motivos-antes-despues-3.svg).
