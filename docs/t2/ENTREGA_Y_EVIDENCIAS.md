# Evidencias, informe y exposición

Estado operativo actual: [primera prueba](PRIMERA_PRUEBA.md). Kadin ya
desplegó según el equipo y hay evidencia de conexión/esquema por psql; aún
faltan las pruebas propias de Windows, escrituras y demás flujos. Registrar
esa distinción en el informe y en la exposición.

## Registro de evidencia

Guardar material real en `docs/t2/evidencias/<ID>/` al producirlo; no crear capturas o resultados de ejemplo que parezcan reales. Cada evidencia incluye autor, fecha, entorno, versión/commit, origen (original o reconstrucción), pasos, datos ficticios usados, resultado esperado/observado y conclusión o limitación.

Usar IDs `EV-FUN-001`, `EV-TEC-001`, `EV-BD-001`, `EV-QA-001` según procedencia. Un hallazgo `D-NNN` debe apuntar a evidencia o archivo/versión; un RF/CR enlaza el hallazgo, la spec y las pruebas cuando existan.

| Cobertura | Responsable | Material mínimo |
|---|---|---|
| Exploración | Frank | Pantallas, menús, botones, entradas/salidas, restricciones, mensajes y comportamientos inesperados |
| Flujos funcionales | Kadin elabora; Evelyn coordina y revisa | Asistencia, permisos, licencias, vacaciones y reportes en Bizagi; módulos en Modelio; si no es accesible, documentar búsqueda y limitación |
| Ingeniería técnica | Jorge | Archivos originales, dependencias, configuración saneada, herramientas/pasos, entidades y arquitectura |
| Base de datos | Kadin | Esquema real disponible, relaciones, riesgos y runbook/despliegue cuando ocurra |
| Reconstrucción | Frank, revisión Kadin | Build/test en Windows, QA de catálogos y resultados; no confundir pruebas unitarias con integración |
| Colaboración y trazabilidad | Evelyn | Tareas, ramas, PR y revisiones reales vinculados a entregables |

El reparto de autoría de diagramas y los prompts completos para cada IDE
están en [PROMPTS_POR_INTEGRANTE.md](PROMPTS_POR_INTEGRANTE.md). Evelyn
coordina los diagramas globales y los encarga a Kadin por texto, según el
[plan T2-04](PLAN_EQUIPO.md#responsables-y-revisión-cruzada). Kadin puede
entregarle los editables y exportaciones directamente: Evelyn los revisa e
incorpora al informe y al repositorio. No se requieren borradores auxiliares.
Los archivos de refactor se guardan en `docs/t2/diagramas/TEC-NNN/`; cada uno
identifica fuente, versión y certeza (observado/inferido/propuesto). Las
evidencias se guardan por paquete para evitar colisiones de nombres entre
ramas. No crear diagramas de supuestos como si fueran capturas del sistema.

## Índice del informe

Evelyn integra; cada responsable entrega su sección y evidencia, y revisa la versión final de su contenido.

| Apartado exigido | Autor principal | Cierre verificable |
|---|---|---|
| 1. Carátula | Evelyn | Curso, docente, evaluación, cuatro nombres, fecha y título correctos |
| 2. Resumen ejecutivo | Evelyn | Hallazgos reales y alcance T2 |
| 3. Sistema recibido | Jorge | Propósito, entorno y distinción original/reconstrucción |
| 4. Exploración funcional | Frank | Capturas y descripciones vinculadas |
| 5. Ingeniería inversa funcional | Evelyn, con exploración de Frank | Mapa, módulos, cinco flujos, reglas y entradas/procesos/salidas |
| 6. Ingeniería inversa técnica | Jorge y Kadin | Inventario, BD, componentes, método y limitaciones |
| 7. Diagnóstico | Jorge | Cada problema con evidencia, impacto y recomendación |
| 8. Requerimientos del usuario | Evelyn | Los 18 RF clasificados por módulo |
| 9. Análisis técnico de RF | Evelyn | Matriz completa con todos los campos |
| 10. Plan de mantenimiento | Evelyn con equipo | Estrategias, responsables, riesgos, cronograma y aceptación |
| 11. Control de cambios | Evelyn | 18 CR relacionados, con estado y responsable |
| 12. Refactorización/reconstrucción | Jorge | ≥4 propuestas y principios aplicados |
| 13. Repositorio | Evelyn | Enlace, estructura y colaboración demostrable |
| 14. Conclusiones | Los cuatro | Conclusiones sustentadas y límites |
| 15. Recomendaciones | Los cuatro | Continuidad coherente hacia T3/final |
| 16. Anexos | Cada autor; integra Evelyn | Evidencias, diagramas y pruebas con referencias válidas |

## Repositorio y revisión final

- Comprobar que el repositorio es privado y que el docente tiene acceso según la pauta: `evilchez@outlook.com` y `edgard.vilchez@upn.pe`. Pendiente de un integrante con permisos; este documento no envía invitaciones.
- Publicar documentación y capturas saneadas, no datos reales, dumps ni DLL licenciadas.
- Verificar que los cuatro aportaron trabajo y revisiones reales. Un número de commits no demuestra por sí solo calidad ni participación equilibrada.
- Cada enlace del informe conduce a evidencia existente; los pendientes están explícitos.

## Exposición

Duración confirmada por Evelyn: **20 minutos**, con diapositivas y código según indicó el profesor. Fecha pendiente. Guion con tiempo para demostración y transiciones:

1. Evelyn: problema, objetivo y límites de T2.
2. Frank: mapa funcional, recorrido con capturas y hallazgo reproducible.
3. Jorge: ingeniería inversa, arquitectura MVP, diagnóstico y ≥4 propuestas.
4. Kadin: entidades, riesgos, situación real de BD y plan/despliegue si se completó.
5. Evelyn: 18 RF agrupados, prioridades, CR, plan y colaboración; conclusiones compartidas.

Preparar unas 10 diapositivas visuales y anexos para el detalle de matrices. No leer el informe ni mostrar claves/datos personales. Todos ensayan el caso RF-03 completo: pantalla → evidencia → diagnóstico → spec → CR → propuesta → prueba/aceptación.

Incluir una demostración del avance real de código según
[avance y sustentación](AVANCE_CODIGO_Y_SUSTENTACION.md): diff de Estado
Civil, separación en capas, reutilización en dos catálogos, inyección de
dependencias, clasificación preventiva/adaptativa y resultados de pruebas
cuando se ejecuten. Diferenciar ese avance del RF-03, cuya corrección sigue
propuesta; mostrar el ejemplo de importación OCP como referencia separada.

Rúbrica incluida en T2: informe 4 bloques de 5 puntos (ingeniería inversa, diagnóstico, análisis/plan/cambios, informe/repositorio/evidencias); exposición 15 por dominio/claridad y 5 por comunicación. Se menciona descuento de hasta 5 por desorganización/presentación personal. Confirmar aplicación de la rúbrica, cuyos encabezados dicen «final» aunque acompaña la pauta T2.

## Plantilla para el runbook de Kadin

Registrar destino y alcance acordados, versión PostgreSQL, origen/versión del esquema, prerrequisitos, creación de usuario de aplicación, mecanismo externo de secretos, restauración con datos ficticios, comandos reproducibles, comprobación de tablas/claves, conexión desde cliente, copia/restauración y reversión. Host/puerto/SSL y credenciales se comparten por configuración privada según necesidad; nunca incluir contraseñas.

Separar despliegue de reconstrucción de integridad (etapa 1b). Una BD que acepta conexiones no prueba la migración funcional completa ni corrige por sí sola duplicados, reglas o procedimientos faltantes.
