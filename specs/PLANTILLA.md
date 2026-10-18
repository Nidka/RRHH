# <ID>: <resultado esperado>

- Estado: Borrador.
- Tarea / RF / CR: <identificadores; sin RF si es transversal>.
- Autor responsable / revisor: <personas diferentes>.
- Versión/commit analizado: <hash>.
- Evidencias / PR: <rutas o enlaces; pendiente si aún no existen>.

## Problema y comportamiento actual

<Disparador, pasos, entrada y resultado observado. Distinguir original/reconstruido/hipótesis.>

## Resultado esperado y alcance

<Qué cambia; límites; reglas por confirmar; dependencias con BD, otras tareas o decisiones.>

## Criterios de aceptación

- Dado <estado inicial>, cuando <acción>, entonces <resultado verificable>.
- <Caso límite y error relevante.>

## Impacto y diseño

Seguir el [prompt general de refactorización](../docs/t2/PROMPT_GENERAL_REFACTORIZACION.md)
y la arquitectura vigente. Registrar explícitamente:

- Tipo principal de mantenimiento y secundarios justificados.
- Técnica de refactorización: qué estructura se cambia y qué comportamiento se conserva.
- Correcciones o capacidades nuevas: separadas del refactor, con aceptación propia.
- Patrones: propósito, clases participantes y razón de elección; MVP/Repository según arquitectura.
- Principios: archivo/método anterior y nuevo, beneficio y prueba que lo sustenta.
- Diagramas actuales/propuestos y fuentes; no atribuir al original inferencias sin contraste.

| Capa/archivo o dato | Cambio previsto | Riesgo y mitigación |
|---|---|---|
| <ruta> | <responsabilidad> | <riesgo concreto> |

<Contrato del caso de uso y repositorio, restricciones, compatibilidad y decisión arquitectónica si corresponde. No inventar tablas ni procedimientos sin inspección.>

## Pasos de implementación o refactorización

1. Caracterizar el flujo y guardar evidencia.
2. <Extraer regla, caso de uso, repositorio, presenter/vista y composición según el alcance.>
3. <Retirar ruta heredada solo al completar su reemplazo.>
4. <Pruebas y actualización documental.>

## Verificación

| Caso / comando | Resultado esperado | Resultado real / entorno / evidencia |
|---|---|---|
| <caso> | <resultado> | Pendiente |

<Para código: compilación, pruebas y QA que correspondan. Para esquema: precondiciones, duplicados/huérfanos, migración, concurrencia y restauración.>

## Reversión

<Cómo volver a la versión anterior sin perder datos; compatibilidad con esquema previo; copia y restauración probada si hay cambios de datos.>

## Uso de IA y decisiones humanas

<Herramienta y tarea material, archivos revisados por la persona, comprobaciones y decisiones pendientes.>
