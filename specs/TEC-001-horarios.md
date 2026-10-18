# TEC-001: refactorizar listado y mantenimiento de horarios

- Estado: Plan inicial; implementación no iniciada.
- Responsable: Jorge Enrique Cano Asto.
- Revisor: Evelyn Victoria Rodriguez Cardozo.
- Rama: `refactor/tec-001-horarios`.
- Base actual: `eeeb817` (16/10/2026); el diagnóstico inicial se preparó con `0a4b6a8`. Caracterizar la versión nueva según [primera prueba](../docs/t2/PRIMERA_PRUEBA.md) y actualizar el diagnóstico antes de programar.
- Trazabilidad: paquete técnico del [plan de equipo](../docs/t2/PLAN_EQUIPO.md); enlazar issue/PR y RF/CR aplicables al iniciar.

## Actualización operativa del 16/10/2026

La BD ya fue desplegada por Kadin según informó Evelyn. Conexión y metadatos se comprobaron por psql; la prueba WinForms sigue pendiente. `eeeb817` añade `.env`, contraseña de usuario RRHH y puentes PostgreSqlLegacyMapper/PostgreSqlLegacyContext. Los nombres XxxMapper del diagnóstico inicial ya no prueban uso de SQL Server: revisar su resolución y proveedor actual. El objetivo del paquete es refactorizar hacia responsabilidades/casos de uso específicos sobre la ruta nueva, conservando su comportamiento caracterizado.

## Problema y evidencia inicial (base anterior; revalidar)

`FrmHorarios.cs` usa HorarioMapper para listado/borrado y EmpleadoMapper para revisar referencias. Abre directamente `FrmMantHorarios`, que usa HorarioMapper para cargar/insertar/actualizar y calcula MAX+1. Ver métodos LlenaHorario, BtnAgregar_Click, BtnMod_Click, BtnEliminar_Click y btnGrabar_Click.

La opción «Actualizar Equipo Marcación» crea AsistenciaAccess sin una operación posterior visible en ese evento. Registrar el comportamiento real; no afirmar sincronización del dispositivo ni inventar su contrato.

Es lectura estática del código recuperado. El responsable registra el comportamiento real y distingue original/reconstrucción antes de atribuir un defecto al producto recibido.

## Alcance

Migrar el flujo listado → alta/edición → retorno al listado y borrado con protección de referencias. No implementar asignación de turnos por periodos, histórico ni importaciones. Es base para RF-01/02, no su cierre. No cambiar reglas de jornada/nocturnidad sin caracterizar `SgtDia` y sus consumidores.

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

- Formas existentes: `Software/RecursosHumanos/RecursosHumanos/FrmHorarios.cs` y `FrmMantHorarios.cs`.
- Domain/Asistencia: entidad Horario y validaciones confirmadas; horas tipadas internamente, adaptadas a varchar(8) del esquema en infraestructura.
- Application/Asistencia: DTO, IHorarioRepository y casos Listar/Obtener/Guardar/EliminarHorario.
- PostgreSql/Asistencia: consultas parametrizadas a Horario y revisión de referencias reales (Empleado, HorarioTemporal y demás que se identifiquen).
- Presentation/Asistencia: contratos de vista y presenters de listado/editor; sin tipos UI/datos.
- CompositionRoot y entradas de MainMDI: ensamblar ambas vistas; abrir editor mediante un contrato de navegación o evento de vista cuya implementación quede en WinForms. No crear repositorios/presenters dentro de formularios.
- RRHH.Tests/Asistencia: dominio, caso de uso, presenter y errores de persistencia.

Nombres nuevos propuestos: adaptarlos a las convenciones existentes sin duplicar servicios. Todo archivo nuevo debe cumplir [arquitectura](../Software/docs/ARQUITECTURA.md). No cambiar proyectos congelados salvo retirada del código ya reemplazado.

## Plan de trabajo

1. Capturar consulta/alta/edición/borrado, horas vacías, selección ausente y horario referenciado; confirmar Estado y SgtDia.
2. Acordar con Kadin IDs y restricciones sin modificar otras tablas de su paquete.
3. Extraer entidad, casos, contratos y pruebas; implementar repositorio y adaptación de horas sin añadir reglas inventadas.
4. Migrar juntos listado y editor a MVP; preservar controles y .resx; retirar mappers de ambas pantallas.
5. Conectar todas las entradas desde MainMDI y validar recorrido completo en QA.

## Aceptación y pruebas

- Alta persiste en PostgreSQL y aparece en listado; edición conserva el ID y los campos no editados.
- Horas inválidas y falta de selección se tratan de forma definida por la spec caracterizada; no fallan por formato regional.
- Borrado de horario en uso no deja referencias huérfanas; caso sin uso funciona con confirmación.
- Entradas de menú abren la versión compuesta; ambas pantallas carecen de mappers/SqlClient/RRHHClass.
- Build Windows, suite y QA real con tablas/IDs de TEC-002. Si sincronización de equipo no está implementada, documentar y acordar tratamiento visible sin prometer éxito.

Registrar casos, entorno, comando, esperado/obtenido y evidencia. Cuando aplique: `Software\scripts\build.cmd` y `dotnet test Software\RRHH.Tests\RRHH.Tests.csproj` en Windows; QA con datos ficticios. No declarar éxito de lo que no se ejecutó.

## Principios, mantenimiento y exposición

SRP, inyección/inversión de dependencias y DRY en reglas compartidas: mantenimiento preventivo para el refactor pendiente. La adaptación PostgreSQL ya incorporada corresponde al avance previo. Una corrección adicional se documenta y prueba por separado.

Entregar diff antes/después y una demostración breve del resultado del paquete. Explicar beneficio concreto para modificar/probar el módulo y un límite pendiente. La autoría se acredita con los commits reales del responsable; revisión del integrante asignado.

## Reversión y coordinación

Conservar referencia del commit anterior. Separar scripts de datos de vistas/casos de uso. Antes de migrar, comprobar compatibilidad de aplicación y esquema previo/nuevo; no revertir un cambio de datos solo revirtiendo C#. Kadin coordina copia/restauración y aplicación de migraciones; cada autor prepara su plan específico de reversión antes del PR final. No ejecutar contra un servidor sin destino/alcance autorizados.

## Ingeniería inversa y control de este cambio

- Solicitud técnica: **CR-TEC-001**, registrada en el [plan de equipo](../docs/t2/PLAN_EQUIPO.md).
- Línea base de ejecución: pendiente de registrar por el responsable (ejecutable original/reconstruido, entorno y versión de BD). El hash de código revisado no sustituye la versión del original.
- Antes de editar: registrar entradas, proceso, salidas, reglas y un flujo; inventariar métodos, llamadas y tablas; enlazar capturas/pruebas y limitaciones.
- Diagnóstico: completar evidencia → problema → impacto → recomendación. Distinguir observación de hipótesis y defecto del original de regresión de reconstrucción.
- Al implementar: enlazar commits, PR y revisiones reales; actualizar estado de CR-TEC-001 y RF asociados sin declarar completo un RF parcial.
- Al cerrar: entregar comparación antes/después, principio y mantenimiento justificados, resultados de pruebas y versión integrada para el informe/exposición.
- Feedback: el revisor señala archivo/caso, impacto, cambio sugerido y comprobación; el autor enlaza su respuesta/corrección y el revisor verifica lo afectado.

## Seguimiento

- Caracterización: pendiente.
- Decisiones y supuestos: los indicados arriba, pendientes de resolver.
- Código/pruebas/QA: pendientes.
- PR, commits y evidencias: pendientes.
- IA: plan inicial preparado con asistencia de IA; implementación y verificaciones deberán registrar su uso real y revisión humana.
