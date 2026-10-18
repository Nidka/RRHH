# TEC-003: refactorizar gestión de feriados

- Estado: Plan inicial; implementación no iniciada.
- Responsable: Frank Piero Mantilla Arqueros.
- Revisor: Francisco Kadin Valera Lizarraga.
- Rama: `refactor/tec-003-feriados`.
- Base actual: `eeeb817` (16/10/2026); el diagnóstico inicial se preparó con `0a4b6a8`. Caracterizar la versión nueva según [primera prueba](../docs/t2/PRIMERA_PRUEBA.md) y actualizar el diagnóstico antes de programar.
- Trazabilidad: paquete técnico del [plan de equipo](../docs/t2/PLAN_EQUIPO.md); enlazar issue/PR y RF/CR aplicables al iniciar.

## Actualización operativa del 16/10/2026

La BD ya fue desplegada por Kadin según informó Evelyn. Conexión y metadatos se comprobaron por psql; la prueba WinForms sigue pendiente. `eeeb817` añade `.env`, contraseña de usuario RRHH y puentes PostgreSqlLegacyMapper/PostgreSqlLegacyContext. Los nombres XxxMapper del diagnóstico inicial ya no prueban uso de SQL Server: revisar su resolución y proveedor actual. El objetivo del paquete es refactorizar hacia responsabilidades/casos de uso específicos sobre la ruta nueva, conservando su comportamiento caracterizado.

## Problema y evidencia inicial (base anterior; revalidar)

`FrmFeriado.cs`: BtnAgregar_Click consulta `RRHHClass.GetFeriado` y luego escribe con RRHH_FeriadoMapper; llena_leriado y btnEliminar_Click también usan el mapper. La consulta y la escritura pertenecen a caminos de datos distintos. Se compara la fecha a través de texto local en el acceso legado.

Es lectura estática del código recuperado. El responsable registra el comportamiento real y distingue original/reconstrucción antes de atribuir un defecto al producto recibido.

## Alcance

Listar, registrar y eliminar feriados en un flujo PostgreSQL completo; mantener confirmación y rechazo de fecha duplicada según el día calendario confirmado. Preparar RF-17; no afirmar que el reporte general suma correctamente los feriados, porque ese reporte no se modifica aquí.

## Procedimiento común y justificación del diseño

Aplicar [prompt general de refactorización](../docs/t2/PROMPT_GENERAL_REFACTORIZACION.md).
Antes de implementar, completar aquí o en los apartados de diseño/principios:

- Mantenimiento principal y secundarios, con justificación del cambio real.
- Comportamiento que se conserva; defectos/capacidades nuevos y su aceptación separada.
- Patrones aplicados: propósito y clases participantes, conforme a la arquitectura vigente.
- Principios sustentados: archivo/método antes/después, beneficio y prueba.

Para horarios/feriados/motivos, el cambio estructural pendiente es principalmente
preventivo; la adaptación PostgreSQL ya incorporada no se atribuye como
nuevo trabajo del paquete. Para BD, distinguir migración/integridad del refactor
de código. No introducir patrones ni jerarquías solo para mencionarlos.

## Diseño y archivos previstos

- Vista existente: `Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs`.
- Domain/Asistencia: entidad Feriado y regla confirmada sobre día/fecha y longitud de motivo (esquema: 200).
- Application/Asistencia: IFeriadoRepository, DTO y casos Listar/Registrar/EliminarFeriado.
- PostgreSql/Asistencia: repositorio sobre RRHH_Feriado, fechas tipadas, IDs según TEC-002. Validación y escritura con control de concurrencia coordinado con Kadin.
- Presentation/Asistencia: IFeriadoView y FeriadoPresenter; mensajes/confirmación a través de la vista.
- CompositionRoot y todas las entradas de MainMDI para feriados; RRHH.Tests/Asistencia para reglas y casos.

Nombres nuevos propuestos: adaptarlos a las convenciones existentes sin duplicar servicios. Todo archivo nuevo debe cumplir [arquitectura](../Software/docs/ARQUITECTURA.md). No cambiar proyectos congelados salvo retirada del código ya reemplazado.

## Plan de trabajo

1. Caracterizar listado, alta, duplicación de fecha, motivo vacío/largo, borrado sin selección/cancelado y formatos regionales.
2. Coordinar con Kadin representación del día en timestamp y estrategia de unicidad/concurrencia; no añadir una restricción arbitraria sin contrastar datos/regla.
3. Extraer reglas, contratos, casos y pruebas con fakes; implementar consultas y escrituras parametrizadas en el mismo motor.
4. Convertir FrmFeriado en vista pasiva y conectar mediante CompositionRoot; retirar RRHHClass/mappers de esta pantalla.
5. Validar recorrido en QA y dos altas simultáneas; dejar el reporte general RF-17 como pendiente separado.

## Aceptación y pruebas

- Listado refleja los cambios persistidos exclusivamente en PostgreSQL.
- Segundo alta del mismo día se rechaza según regla confirmada; no depende del formato dd/MM o MM/dd.
- Eliminar sin selección o cancelar no borra datos; confirmar elimina solo el elegido.
- Dos altas simultáneas respetan la regla de unicidad; especificar cómo antes de implementar.
- Build, pruebas y QA registrados; ninguna entrada de menú abre la ruta heredada de esta pantalla.

Registrar casos, entorno, comando, esperado/obtenido y evidencia. Cuando aplique: `Software\scripts\build.cmd` y `dotnet test Software\RRHH.Tests\RRHH.Tests.csproj` en Windows; QA con datos ficticios. No declarar éxito de lo que no se ejecutó.

## Principios, mantenimiento y exposición

SRP y eliminación del acoplamiento al puente de compatibilidad: preventivo. La adaptación PostgreSQL ya incorporada se distingue del refactor nuevo. Solo clasificar como correctivo un defecto reproducido en la base actual.

Entregar diff antes/después y una demostración breve del resultado del paquete. Explicar beneficio concreto para modificar/probar el módulo y un límite pendiente. La autoría se acredita con los commits reales del responsable; revisión del integrante asignado.

## Reversión y coordinación

Conservar referencia del commit anterior. Separar scripts de datos de vistas/casos de uso. Antes de migrar, comprobar compatibilidad de aplicación y esquema previo/nuevo; no revertir un cambio de datos solo revirtiendo C#. Kadin coordina copia/restauración y aplicación de migraciones; cada autor prepara su plan específico de reversión antes del PR final. No ejecutar contra un servidor sin destino/alcance autorizados.

## Ingeniería inversa y control de este cambio

- Solicitud técnica: **CR-TEC-003**, registrada en el [plan de equipo](../docs/t2/PLAN_EQUIPO.md).
- Línea base de ejecución: pendiente de registrar por el responsable (ejecutable original/reconstruido, entorno y versión de BD). El hash de código revisado no sustituye la versión del original.
- Antes de editar: registrar entradas, proceso, salidas, reglas y un flujo; inventariar métodos, llamadas y tablas; enlazar capturas/pruebas y limitaciones.
- Diagnóstico: completar evidencia → problema → impacto → recomendación. Distinguir observación de hipótesis y defecto del original de regresión de reconstrucción.
- Al implementar: enlazar commits, PR y revisiones reales; actualizar estado de CR-TEC-003 y RF asociados sin declarar completo un RF parcial.
- Al cerrar: entregar comparación antes/después, principio y mantenimiento justificados, resultados de pruebas y versión integrada para el informe/exposición.
- Feedback: el revisor señala archivo/caso, impacto, cambio sugerido y comprobación; el autor enlaza su respuesta/corrección y el revisor verifica lo afectado.

## Seguimiento

- Caracterización: pendiente.
- Decisiones y supuestos: los indicados arriba, pendientes de resolver.
- Código/pruebas/QA: pendientes.
- PR, commits y evidencias: pendientes.
- IA: plan inicial preparado con asistencia de IA; implementación y verificaciones deberán registrar su uso real y revisión humana.
