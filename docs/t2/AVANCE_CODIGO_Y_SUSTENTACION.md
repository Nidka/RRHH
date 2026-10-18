# Avance de código y cómo sustentarlo en T2

> Referencia de versiones anteriores. El estado de conexión, login y proveedores cambió en `eeeb817`; leer [primera prueba y actualización](PRIMERA_PRUEBA.md). No usar los diagnósticos históricos como defectos actuales sin revalidarlos.

## Qué podemos afirmar hoy

Hay cambios de código en `0a4b6a8` respecto de `e725cd6`, además de documentación. Esta comparación acredita diferencias en Git; falta incorporar resultados de ejecución en Windows/QA. Los responsables de explicar o continuar un cambio no son necesariamente quienes lo escribieron: registrar autoría real según commits, PR y revisión humana.

La pauta T2 no obliga a implementar los 18 RF. El sílabo también contempla mantenimiento preventivo, refactorización, SRP/DRY, abierto/cerrado e inversión de control antes de T2. Por ello presentaremos el avance técnico existente con antes/después, principio, tipo de mantenimiento, beneficio, pruebas y pendientes, además de las nueve actividades de la pauta. No sustituir esa explicación por definiciones teóricas.

## Cambios concretos incorporados

Las rutas de la tabla son relativas a `Software/`.

| Cambio | Antes (`e725cd6`) | Después (`0a4b6a8`) y dónde verlo | Principio / tipo de mantenimiento | Qué mejora y cómo verificarlo |
|---|---|---|---|---|
| Separación de responsabilidades en catálogos | `RecursosHumanos/RecursosHumanos/FrmMantEstCivil.cs` mantenía un DataContext, consultaba y llamaba a EstadoCivilMapper para insertar/actualizar/eliminar | Ese formulario reenvía eventos a VistaCatalogoGrid; `RRHH.Presentation/Catalogos/CatalogoPresenter.cs` coordina; `RRHH.Application/Catalogos/GuardarItemCatalogo.cs` ejecuta guardado; PostgreSqlCatalogoRepository persiste | SRP y separación de responsabilidades; preventivo. El cambio de motor asociado es adaptativo | La vista deja de decidir persistencia; mostrar el diff y ejecutar consulta/alta/edición/borrado. No afirmar equivalencia sin caracterización |
| Reducción de duplicación | Mantenimientos similares repetían búsqueda, guardado, borrado y mensajes en cada formulario | CatalogoPresenter, VistaCatalogoGrid, DefinicionesCatalogo y MapeosCatalogo se reutilizan en diez catálogos | DRY; preventivo | Una corrección común puede atender varias pantallas. Mostrar dos formularios que comparten componentes y regresión en ambos |
| Dependencias explícitas | El formulario creaba el contexto y accedía directamente a mappers concretos | `RRHH.Application/Catalogos/ICatalogoRepository.cs`; GuardarItemCatalogo recibe ese contrato; `RecursosHumanos/RecursosHumanos/CompositionRoot.cs`, CrearCatalogo, construye e inyecta dependencias | Inversión de dependencias y de control mediante inyección por constructor; preventivo | Caso de uso comprobable con FakeCatalogoRepository sin abrir WinForms. Mostrar contrato, constructor, composición y prueba; los términos no son sinónimos |
| Acceso PostgreSQL en catálogos | LINQ-to-SQL/mappers generaban operaciones SQL Server | `RRHH.PostgreSql/Catalogos/PostgreSqlCatalogoRepository.cs` utiliza consultas PostgreSQL con valores parametrizados, transacciones y mapeos de identificadores controlados | Adaptativo por cambio de plataforma; prevención de errores de acceso a datos | Demostrar persistencia y rollback/errores en QA. La adaptación de motor debe distinguirse de una refactorización que conserva comportamiento |
| Validaciones centralizadas y lógica comprobable | Validación vinculada a eventos de controles y repetida en pantallas | `RRHH.Domain/Catalogos/DefinicionCatalogo.cs`, ItemCatalogo.Crear y GuardarItemCatalogo; pruebas en `RRHH.Tests/Catalogos/DefinicionCatalogoTests.cs` y CatalogoPresenterTests | SRP/DRY; preventivo. Solo clasificar como correctivo un defecto específico reproducido | Verificar descripción vacía, longitudes, normalización y que una fila inválida no se guarda |
| Pruebas de arquitectura y comportamiento | No había proyecto RRHH.Tests en esa referencia | `RRHH.Tests/Arquitectura/DependenciasEntreCapasTests.cs`; pruebas de catálogos y acceso con fakes | Preventivo | Detectar referencias prohibidas y regresiones. Adjuntar comando/entorno/resultados reales; la existencia de pruebas no acredita que pasaron |

Las referencias a «antes» corresponden al código recuperado de `e725cd6`; no certifican por sí mismas el comportamiento del ejecutable original recibido.

## Abierto/cerrado: ejemplo y límites

En catálogos simples, las definiciones y mapeos permiten agregar una variante compatible reutilizando el flujo común del presenter/caso de uso. Hay que registrar enum, definición, mapeo y formulario: no afirmar que nunca cambia ningún archivo. Los catálogos con reglas propias requieren un diseño específico según la arquitectura vigente.

El ejemplo más explícito de importadores por sede está en `Software/referencia/AsistenciaImport/`: ISedeImportador, ImportadorSedeBase y clases por sede. Es un refactor separado, fuera de la solución principal y aún ligado a SQL Server. Puede explicarse como trabajo de referencia y propuesta de integración; no como importación productiva migrada a MVP/PostgreSQL.

## Cómo presentar cada avance

1. Problema concreto y archivo/método anterior.
2. Diff o fragmento breve del antes y después, con commit y autoría verificable.
3. Principio aplicado y motivo: qué responsabilidad se separó, duplicación se retiró o dependencia se invirtió.
4. Tipo de mantenimiento: preventivo, adaptativo, correctivo o perfectivo, justificado para ese cambio.
5. Efecto en mantenibilidad: facilidad para comprender, cambiar, reutilizar o probar; no inventar porcentajes.
6. Demostración y prueba: datos ficticios, resultado esperado/real y evidencia.
7. Alcance y pendientes: qué pantalla está migrada, qué sigue usando legado y qué falta verificar.

Ejemplo para exposición: «En Estado Civil, el formulario realizaba las operaciones con el mapper. Separamos la coordinación en CatalogoPresenter, el guardado en un caso de uso y la persistencia en un repositorio. Es mantenimiento preventivo por SRP; portar las consultas a PostgreSQL es mantenimiento adaptativo. Mostramos el diff y las pruebas; la validación contra QA se acredita con su resultado real».

## Trabajo nuevo asignado para los siguientes commits

El reparto vigente está al principio de [PLAN_EQUIPO.md](PLAN_EQUIPO.md).
Reemplaza la propuesta anterior de combos/pruebas como trabajo principal.
Esta sección inicial describe el avance recibido; no es el reparto de nueva
implementación ni acredita autoría individual de ese avance.

- Jorge: [TEC-001, horarios](../../specs/TEC-001-horarios.md), listado y editor completos.
- Kadin: [TEC-002, BD](../../specs/TEC-002-integridad-bd.md), integridad/IDs de tablas acordadas y despliegue QA.
- Frank: [TEC-003, feriados](../../specs/TEC-003-feriados.md), listado, alta y borrado por capas.
- Evelyn: [TEC-004, motivos](../../specs/TEC-004-motivos-permiso.md), listado y editor por capas.

Cada paquete incluye caracterización, código, pruebas, revisión y evidencia
para exponer. El responsable completa su spec y hace commits propios. Los
cuatro planes están preparados; sus implementaciones no han comenzado aquí.

## Situación de verificaciones

- Comparación estática `git diff e725cd6 0a4b6a8`: realizada para Estado Civil y login, junto a lectura de las capas/pruebas.
- Compilación y ejecución de pruebas en este entorno: pendientes; macOS sin dotnet/msbuild y sin runtime Windows de la aplicación.
- QA y capturas antes/después: pendientes de los responsables.
- Implementación TEC-001…004: no iniciada.

## Avance local de TEC-004 (17/10/2026)

[Aporte de Evelyn](aportes/TEC-004/README.md): motivos migrados a MVP/casos/Repository, correcciones separadas, antes/después y seis diagramas SVG. 108 pruebas aprobadas en .NET 8 portable, incluidas 14 con PostgreSQL local; capas/tests compilan net48. Ejecutable/QA Windows y revisión de Frank pendientes. IDs duplicados observados en el catálogo desplegado requieren coordinación con Kadin. RF-04/05 permanecen parciales; sin integración a main.
