# TEC-004: refactorizar consulta y mantenimiento de motivos

- Estado: Preparado para PR en borrador; pendientes QA WinForms, revisión de Frank e integración de TEC-004. Base inicial `f713383`; main `6f7feb8` incorporado mediante `9a00a4a`.
- Responsable: Evelyn Victoria Rodriguez Cardozo.
- Revisor: Frank Piero Mantilla Arqueros.
- Rama: `refactor/tec-004-motivos-permiso`.
- Línea base de trabajo: `f713383` (organización), sobre código `eeeb817`; diagnóstico inicial `0a4b6a8`. Caracterización estática de la versión nueva registrada en [aporte TEC-004](../docs/t2/aportes/TEC-004/CARACTERIZACION.md); ejecución de la [primera prueba](../docs/t2/PRIMERA_PRUEBA.md) WinForms pendiente.
- Trazabilidad: paquete técnico del [plan de equipo](../docs/t2/PLAN_EQUIPO.md); enlazar issue/PR y RF/CR aplicables al iniciar.

## Actualización operativa del 16/10/2026

La BD ya fue desplegada por Kadin según informó Evelyn. Conexión y metadatos se comprobaron por psql; la prueba WinForms sigue pendiente. `eeeb817` añade `.env`, contraseña de usuario RRHH y puentes PostgreSqlLegacyMapper/PostgreSqlLegacyContext. Los nombres XxxMapper del diagnóstico inicial ya no prueban uso de SQL Server: revisar su resolución y proveedor actual. El objetivo del paquete es refactorizar hacia responsabilidades/casos de uso específicos sobre la ruta nueva, conservando su comportamiento caracterizado.

## Problema y evidencia inicial (base anterior; revalidar)

`FrmMotivoPermiso.cs` repite la recarga por rol tras selección, alta, edición y borrado; usa TipoPermisoMapper, Motivo_PermMapper y spRRHH_getMotivo_perm. `FrmMantMotivo.cs` usa el mapper en alta/edición y llama Update durante Load, antes de guardar; usa MAX+1 al insertar. Los roles 10/14 filtran P/C y el 13 pasa modalidad nula al procedimiento: la semántica exacta debe caracterizarse.

Es lectura estática del código recuperado. El responsable registra el comportamiento real y distingue original/reconstrucción antes de atribuir un defecto al producto recibido.

## Alcance

Migrar listado por tipo/modalidad, editor alta/edición y borrado seguro de motivos como un módulo completo. Relación RF-04/05 y apoyo a RF-03/06/18. No migrar registro de permisos/licencias ni inventar la lógica del procedimiento sin resultados de referencia; si su semántica no se obtiene, registrar el bloqueo concreto.

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

- Vistas existentes: `Software/RecursosHumanos/RecursosHumanos/FrmMotivoPermiso.cs` y `FrmMantMotivo.cs`.
- Domain/Permisos: MotivoPermiso y reglas verificadas de descripción, abreviatura, salario, modalidad, activo y referencias.
- Application/Permisos: DTO, IMotivoPermisoRepository y casos Listar/Obtener/Guardar/EliminarMotivoPermiso; consulta tipada de tipos de permiso reutilizando ListarCatalogo existente si basta, sin duplicar el componente genérico.
- PostgreSql/Permisos: consultas a Motivo_Perm, TipoPermiso y referencias de Permiso identificadas; indicar reemplazo de spRRHH_getMotivo_perm, con límites si no se recupera su contrato.
- Presentation/Permisos: contratos y presenters de listado/editor. Centralizar recarga y política de selección de modalidad, sin SQL ni tipos de UI.
- CompositionRoot: conexión y navegación entre ambas vistas; MainMDI: todas las entradas; RRHH.Tests/Permisos: reglas, casos, presenters.

Nombres nuevos propuestos: adaptarlos a las convenciones existentes sin duplicar servicios. Todo archivo nuevo debe cumplir [arquitectura](../Software/docs/ARQUITECTURA.md). No cambiar proyectos congelados salvo retirada del código ya reemplazado.

## Plan de trabajo

1. Capturar comportamiento por tipo/rol, carga sin guardar, alta/edición, cancelación y borrado de motivo en uso. Obtener contrato/resultados del procedimiento antes de reemplazarlo.
2. Acordar con Kadin ID y referencias de Motivo_Perm. Confirmar política de eliminación frente a histórico: bloquear o baja lógica solo según decisión documentada.
3. Extraer reglas, contratos y casos; conservar campos no editados y nulabilidad; eliminar la escritura durante Load del editor.
4. Implementar repositorio parametrizado y recarga única desde presenter; adaptar ambas vistas preservando nombres/.resx.
5. Conectar desde CompositionRoot/MainMDI, retirar mapper/DataContext/procedimiento legado de este módulo y probar extremo a extremo en QA.

## Aceptación y pruebas

- Abrir/cancelar un editor no actualiza la BD; guardar sí, conservando ID y campos que no se editan.
- Lista y combo se cargan de PostgreSQL con resultados equivalentes por tipo/rol/modalidad confirmados; sin duplicar recarga en cada botón.
- Alta en tabla vacía y edición funcionan con IDs coordinados; longitudes y valores ausentes se tratan según reglas verificadas.
- Borrado respeta la política del histórico y referencias; cancelar no modifica datos.
- Pruebas de dominio/caso/presenter, build Windows y QA registradas. RF-04/05 solo se cierran con sus criterios y evidencia, no al crear clases.

Registrar casos, entorno, comando, esperado/obtenido y evidencia. Cuando aplique: `Software\scripts\build.cmd` y `dotnet test Software\RRHH.Tests\RRHH.Tests.csproj` en Windows; QA con datos ficticios. No declarar éxito de lo que no se ejecutó.

## Principios, mantenimiento y exposición

SRP y DRY al extraer y centralizar recarga: mantenimiento preventivo. La adaptación PostgreSQL ya incorporada corresponde al avance previo. Eliminar una escritura involuntaria al abrir es candidato correctivo sujeto a caracterización, con aceptación y prueba separadas.

Entregar diff antes/después y una demostración breve del resultado del paquete. Explicar beneficio concreto para modificar/probar el módulo y un límite pendiente. La autoría se acredita con los commits reales del responsable; revisión del integrante asignado.

## Reversión y coordinación

Conservar referencia del commit anterior. Separar scripts de datos de vistas/casos de uso. Antes de migrar, comprobar compatibilidad de aplicación y esquema previo/nuevo; no revertir un cambio de datos solo revirtiendo C#. Kadin coordina copia/restauración y aplicación de migraciones; cada autor prepara su plan específico de reversión antes del PR final. No ejecutar contra un servidor sin destino/alcance autorizados.

## Ingeniería inversa y control de este cambio

- Solicitud técnica: **CR-TEC-004**, registrada en el [plan de equipo](../docs/t2/PLAN_EQUIPO.md).
- Línea base de ejecución: pendiente de registrar por el responsable (ejecutable original/reconstruido, entorno y versión de BD). El hash de código revisado no sustituye la versión del original.
- Antes de editar: registrar entradas, proceso, salidas, reglas y un flujo; inventariar métodos, llamadas y tablas; enlazar capturas/pruebas y limitaciones.
- Diagnóstico: completar evidencia → problema → impacto → recomendación. Distinguir observación de hipótesis y defecto del original de regresión de reconstrucción.
- Al implementar: enlazar commits, PR y revisiones reales; actualizar estado de CR-TEC-004 y RF asociados sin declarar completo un RF parcial.
- Al cerrar: entregar comparación antes/después, principio y mantenimiento justificados, resultados de pruebas y versión integrada para el informe/exposición.
- Feedback: el revisor señala archivo/caso, impacto, cambio sugerido y comprobación; el autor enlaza su respuesta/corrección y el revisor verifica lo afectado.

## Seguimiento

- Caracterización: inspección estática de formularios, puente y esquema en `f713383`; observación WinForms pendiente.
- Decisiones, código y trazabilidad: [aporte consolidado](../docs/t2/aportes/TEC-004/README.md), con archivos, técnicas, principios/patrones, límites, QA y reversión. Extraer clases/métodos, introducir interfaz e inyección por constructor, trasladar lógica fuera de formularios y centralizar recarga.
- Código: módulo completo por capas, ambas entradas de MainMDI conectadas; no se cambió el esquema compartido.
- Pruebas: 130/130 aprobadas tras combinar con TEC-003 en arnés .NET 8, incluidas 14 contra PostgreSQL local ficticio; capas y tests también compilan net48, 0 advertencias/errores. QA/compilación del ejecutable Windows pendientes. Evidencias enlazadas en el aporte.
- Diagramas: antes/después/dependencias y flujos funcionales; seis SVG renderizados. Diferenciar fuente inferida, catálogo observado y propuesta futura.
- RF-04/05: avance parcial; falta acordar duplicados por descripción, validar política de borrado y comprobar QA. No se cierran.
- Commits: implementación `01db40b`, XML `fe1a00a`, incorporación de main `9a00a4a`. PR en preparación, publicación autorizada por Evelyn el 18/10/2026; revisión humana pendiente. Base documental y TEC-003 ya integrados en main mediante PR #1.
- IA: análisis, implementación, pruebas, diagramas y documentación asistidos por Codex; resultados automáticos reales. Validación humana de Evelyn y revisión de Frank pendientes.

## Decisiones de implementación de esta iteración

- Mantenimiento principal preventivo: MVP, casos de uso y Repository; SRP, DRY y DIP/IoC. Se separan correcciones: no escribir en Load, alta en tabla vacía, conservar campos no editados y tratar selección ausente.
- Contrato actual comprobado en código: rol 10 filtra modalidad P, 14 filtra C, 13 consulta sin filtro de modalidad; no se añade filtro Activo que no existe en la consulta vigente. Otros roles no reciben una autorización nueva por este refactor.
- Edición modifica descripción/abreviatura/salario; tipo, modalidad y Activo se conservan. Cargar el editor es solo lectura.
- Eliminación: impedir borrado de motivos referenciados en Permiso o Permiso_Aud para conservar histórico. Decisión técnica conservadora a validar en revisión; no se inventa baja lógica.
- IDs: utilizar default/identidad si Kadin ya lo incorporó. Mientras no exista, MAX+1 dentro de bloqueo transaccional de tabla; el bloqueo serializa las altas de este repositorio, no sustituye PK/UNIQUE ni coordina todos los escritores legados.
- Concurrencia de borrado: bloqueo de escrituras relacionadas durante comprobación/borrado. No impide referencias huérfanas creadas después del commit por otros escritores sin validación. Es transitorio; FK e integridad global dependen de TEC-002.
- Catálogo desplegado: consulta READ ONLY confirma IDs duplicados en TipoPermiso/Motivo_Perm; rechazar mutaciones ambiguas y coordinar saneamiento con Kadin. No se modificó ni deduplicó la instancia. Secuencias desalineadas que generarían ID repetido revierten la fila insertada.
- Proveedor observado: PostgreSqlLegacyMapper/PostgreSqlLegacyContext actuales; no atribuir al original SQL Server las regresiones del puente.
