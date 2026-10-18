# Revisión del cambio de arquitectura

> Referencia de versiones anteriores. El estado de conexión, login y proveedores cambió en `eeeb817`; leer [primera prueba y actualización](PRIMERA_PRUEBA.md). No usar los diagnósticos históricos como defectos actuales sin revalidarlos.

Base anterior: `e725cd6`. Base incorporada: `0a4b6a8`, «Adoptar arquitectura MVP por capas y migrar los catálogos simples». Integración local por fast-forward; el borrador local de T2 se conservó.

## Qué cambió

- Se agregaron Domain, Application, Presentation y Tests; PostgreSql implementa contratos de Application.
- Diez mantenimientos de catálogos usan CatalogoPresenter, VistaCatalogoGrid y CompositionRoot.
- El acceso inicial se movió a ObtenerAccesoUsuario y PostgreSqlAccesoUsuarioRepository. El formulario de login aún no es MVP completo y sigue sin verificar identidad del usuario final, según el plan existente.
- Hay pruebas de arquitectura, dominio, presenters, mapeos y acceso. Se inspeccionaron 26 métodos Fact y 5 Theory; no es un conteo de casos ejecutados.
- Se incorporaron arquitectura, ADR, plan técnico y reglas CLAUDE.md.
- El refactor VB de importación en `Software/referencia/` queda fuera de RRHH.sln y sirve de referencia; no demuestra migración integrada de importaciones.

## Qué no puede darse por terminado

| Aspecto | Evidencia y siguiente comprobación |
|---|---|
| Diez catálogos migrados en código | Recorrer alta, consulta, edición y borrado en Windows/PostgreSQL QA; contrastar con original |
| Persistencia de catálogos | El repositorio usa bloqueo de tabla y MAX+1; claves, identidad y concurrencia siguen en etapa 1b |
| Borrado en uso | Hay comprobación de referencias y traducción de FK; sin FK efectiva permanece el riesgo de inserción concurrente de referencias |
| Resto de formularios | Persisten mappers, SQL Server y ClassRRHH; no extrapolar migración de catálogos a todo el sistema |
| Despliegue BD | Kadin lo realizará después; destino, fecha y resultados pendientes |
| Pruebas y compilación | Existen archivos de pruebas; no se ejecutaron en este macOS sin dotnet/msbuild ni runtime Windows |
| Evidencia académica | Faltan capturas del original, informe final y revisión humana de matrices/diagramas |

## Consecuencias para T2

La arquitectura y el ADR existentes son fuentes para explicar decisiones y alternativas. El trabajo del equipo debe complementar con evidencias funcionales, diagnóstico trazable y planificación; evitar otra reestructuración global antes de la entrega.

Mantener dos líneas base: sistema recibido y reconstrucción actual. Clasificar hallazgos por origen para no presentar una regresión de migración como defecto probado del original.

El orden de implementación se conserva en [plan técnico](../../Software/docs/PLAN_REFACTORIZACION.md): catálogos pendientes y etapa 1b → empleados → permisos → asistencia → legajo → ficha social → reportes. Analizar vacaciones y teletrabajo en T2 aunque sus implementaciones aún no estén ubicadas en esas etapas; definir sus contratos y dependencias antes de incorporarlas a T3.
