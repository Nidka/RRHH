# Especificaciones de cambios

Una spec hace explícito qué se quiere cambiar, por qué y cómo se verificará. Complementa el plan técnico existente; no lo reemplaza.

Ejecutar cada cambio con el [prompt general de refactorización](../docs/t2/PROMPT_GENERAL_REFACTORIZACION.md).
La spec debe concretar mantenimiento, patrones, principios, comportamiento
conservado y correcciones separadas, además de alcance/pruebas/reversión.

1. Buscar la tarea en [plan de equipo](../docs/t2/PLAN_EQUIPO.md) y el RF/CR en las matrices de T2.
2. Copiar [PLANTILLA.md](PLANTILLA.md) como `CR-NNN-descripcion.md` para una implementación/refactorización. Para cambios técnicos transversales usar `TEC-NNN-descripcion.md`.
3. Registrar comportamiento observado y propuesto, aceptación, impacto, plan y pruebas. En T2 el estado puede permanecer «Propuesto para T3».
4. Relacionar tarea, spec, rama, PR y evidencias. Si el alcance cambia, actualizar esos vínculos.

Estados: Borrador → En análisis → Listo para implementar → En implementación → En revisión → Validado. «Listo» significa requisitos y dependencias resueltos; no equivale a orden de implementar ni aprobación del docente. Un cambio suspendido conserva motivo y siguiente acción.

Ejemplo trabajado: [CR-003-permisos-solapados.md](CR-003-permisos-solapados.md). Describe una propuesta; no certifica una corrección implementada.

## Paquetes actuales de implementación

Cada integrante parte de su plan ya delimitado, completa la caracterización
y registra sus commits/PR. No copiar otro plan para reiniciar el mismo trabajo.

| ID | Responsable | Plan |
|---|---|---|
| TEC-001 | Jorge | [Horarios](TEC-001-horarios.md) |
| TEC-002 | Kadin | [Integridad y despliegue BD](TEC-002-integridad-bd.md) |
| TEC-003 | Frank | [Feriados](TEC-003-feriados.md) |
| TEC-004 | Evelyn | [Motivos de permiso](TEC-004-motivos-permiso.md) |

El orden de integración, revisión y archivos compartidos se establece en el
[plan de equipo](../docs/t2/PLAN_EQUIPO.md). Estados iniciales: planes preparados,
implementaciones pendientes. Las specs CR del backlog mantienen sus estados
propios; un paquete técnico no completa automáticamente un RF.
