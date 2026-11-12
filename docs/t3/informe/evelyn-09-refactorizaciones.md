# §9. Refactorizaciones aplicadas — aporte de Evelyn

Responsable: Evelyn Victoria Rodriguez Cardozo. Revisión humana pendiente. Se describe código reconstruido/versionado, sin afirmar comportamiento observado del ejecutable original.

- [REF-003](../refactorizaciones/REF-003.md): motivos de permiso por capas, commit histórico 01db40b (TEC-004). Separación vista/presenter/casos/repositorio; carga sin escritura y edición que preserva campos.
- [REF-004](../refactorizaciones/REF-004.md): catálogo de horarios MVP, commit histórico 138dbce (TEC-001). No confundirlo con periodos temporales.
- Avance nuevo RF-01: commit local 5e91030, rama feature/rf-01-turnos-por-periodo; editor existente migrado, validación tipada y guardado atómico con conflicto por empleado.
- Avance nuevo RF-02: commit local 45752cb, rama dependiente feature/rf-02-historico-turnos; consulta de asignaciones por empleado/intersección sin ocultar horarios faltantes. No se detectó borrado automático al reasignar en la base; no se inventó esa corrección.

Las fichas contienen código antes/después extraído de Git, principios y beneficio verificable. La evidencia automatizada local no sustituye QA Windows ni revisión del integrante asignado. Ayuda material de Codex en análisis, implementación, pruebas y redacción; Evelyn debe comprobar y sustentar.
