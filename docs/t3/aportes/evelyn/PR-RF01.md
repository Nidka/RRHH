# Borrador local de PR — RF-01 / CR-001

Rama `feature/rf-01-turnos-por-periodo`. Proponer etiqueta **semver:minor**; el revisor confirma. No publicado.

## Cambio y propósito

Tarea: RF-01 / CR-001. [Spec](../../../../specs/CR-001-turnos-por-periodo.md). Responsable: Evelyn Victoria Rodriguez Cardozo; revisor propuesto: Kadin. Base: 03ab748. Ejecutable original no observado; DDL versionado, instancia compartida no consultada.

Asignación temporal de horarios por MVP, rangos tipados y validación/escritura en una transacción. Conserva formulario, catálogo TEC-001 y FechaRegistro al editar.

Mantenimiento, técnicas, patrones y comportamiento conservado/corregido se detallan en la spec con archivos/métodos. No se atribuye un RF terminado a la sola existencia del código.

## Ingeniería inversa y diagnóstico

Caracterización estática de la reconstrucción en la spec; antes/después de motivos y catálogo horarios en REF-003/004. No se reescribe el diseñador ni se renombran Frm*. No se implementan RF ajenos.

## Validación y evidencia

En su rama: **314 pruebas complementarias net8 correctas**, ninguna omitida, con PostgreSQL temporal local y datos ficticios. [Casos](../../casos_prueba/evelyn.csv). La verificación conjunta se documenta por separado y no se suma a estos totales.

- [x] Arquitectura por capas y XML revisados cuando corresponde.
- [x] Pruebas automáticas complementarias y SQL ficticio local registrados.
- [x] Spec y filas propias del control actualizadas.
- [x] Sin secretos, datos reales ni DLL licenciadas añadidas.
- [ ] Aceptación de pantalla y build.cmd/suite net48 ejecutados en Windows.
- [ ] Revisión y aprobación humana de Kadin.

La compilación real de capas/pruebas net48 fue posible en macOS para RF-01/RF-02 y la rama conjunta; la ejecución net48 no inició por falta de mono. WinForms/Excel requieren entorno Windows y DLL heredadas ausentes de este checkout. Evelyn ejecuta QA y el revisor contrasta evidencia.

## Riesgos y reversión

No hay DDL productivo ni acceso al servidor compartido. Las hipótesis de negocio/alcance de concurrencia están delimitadas en la spec. Revertir el commit de la tarea conserva datos existentes; RF-02 depende de RF-01. Mantener respaldos/QA según procedimiento del equipo.

## Asistencia de IA

Codex asistió análisis, implementación cuando aplica, pruebas y documentos. Se ejecutaron comandos locales reales y revisión técnica de IA; comprobación/sustentación de Evelyn y aprobación del revisor humano pendientes. No se simula revisión cruzada.

## Línea propuesta para coordinación de CHANGELOG

Agregado: asignación de horarios por periodos con validación de solapamiento (RF-01).
