# TEC-004 · Aporte de Evelyn: motivos de permiso

Estado al 18/10/2026: código implementado en `refactor/tec-004-motivos-permiso`, pendiente de compilación/QA visual en Windows y revisión de Frank. Base de trabajo `f713383` (organización), código PostgreSQL previo `eeeb817`; implementación/pruebas en commit `01db40b`. Publicado en [PR #2 en borrador](https://github.com/Nidka/RRHH/pull/2); QA Windows y revisión de Frank pendientes, sin integrar TEC-004 a main. Main actualizado `6f7feb8` incorporado en la rama mediante `9a00a4a`, conservando TEC-003. Este archivo reúne el avance; no reemplaza el informe final de T2.

## Qué se hizo y por qué

Antes, los dos formularios consultaban y guardaban con mappers, repetían el listado por rol y el editor ejecutaba un UPDATE durante Load. Ahora los formularios muestran datos y emiten eventos; los presenters coordinan, los casos de uso validan y un repositorio PostgreSQL persiste. Se mantienen formularios/recursos, roles 10→P, 14→C, 13→sin filtro y consulta de inactivos, conforme al puente actual.

Correcciones separadas de la reorganización: abrir/cancelar no escribe; guardar conserva tipo/modalidad/Activo; el alta funciona en tabla vacía; modificar sin selección muestra mensaje; borrar comprueba referencias de permisos y auditoría. Descripción obligatoria y longitudes 50/3 se validan antes de SQL. Las reglas nuevas y la protección del histórico requieren aceptación humana; no se atribuyen como defectos observados del ejecutable original.

## Código que puedes explicar al profesor

| Concepto | Dónde mostrarlo | Explicación concreta | Comprobación |
|---|---|---|---|
| SRP | [formularios](../../../../Software/RecursosHumanos/RecursosHumanos/FrmMotivoPermiso.cs), [presenter](../../../../Software/RRHH.Presentation/Permisos/MotivosPermisoPresenter.cs), [casos](../../../../Software/RRHH.Application/Permisos/GuardarMotivoPermiso.cs), [repositorio](../../../../Software/RRHH.PostgreSql/Permisos/PostgreSqlMotivoPermisoRepository.cs) | Se separan controles, coordinación, operación y SQL | Pruebas de arquitectura y casos sin UI/BD |
| DRY | `MotivosPermisoPresenter.Recargar` y [AccesoMotivosPermiso](../../../../Software/RRHH.Domain/Permisos/AccesoMotivosPermiso.cs) | Una recarga para selección y operaciones; una política de modalidad, en vez de repetir bloques por rol en cada botón | Selección, guardado/cancelación y filtrado |
| DIP / IoC | [IMotivoPermisoRepository](../../../../Software/RRHH.Application/Permisos/IMotivoPermisoRepository.cs), contratos de vista y [CompositionRoot](../../../../Software/RecursosHumanos/RecursosHumanos/CompositionRoot.cs) | Los casos reciben una interfaz y la composición suministra la implementación; los presenters reciben vistas reemplazables | Fakes en pruebas y dependencias compiladas |
| Patrón MVP de vista pasiva | [contratos y presenters](../../../../Software/RRHH.Presentation/Permisos) | El formulario delega eventos; el presenter decide cuándo consultar, abrir editor o recargar | Load solo lectura, errores y cancelación |
| Patrón Repository | `IMotivoPermisoRepository` / `PostgreSqlMotivoPermisoRepository` | El caso de uso expresa la operación sin Npgsql ni SQL | 14 pruebas reales contra PostgreSQL local |
| Transacciones y parametrización | `Insertar`, `Actualizar`, `Eliminar` del repositorio | Operaciones atómicas, valores tipados y control de referencias/IDs | Concurrencia de 8 altas, rollback y texto con SQL guardado como dato |

No afirmar que se implementó todo SOLID ni agregar Strategy/Factory/Singleton para llenar la exposición. La clase CompositionRoot ensambla dependencias; no necesita presentarse como otro patrón de negocio.

Mantenimiento principal **preventivo**: separación de responsabilidades, eliminación de repetición y pruebas para reducir regresiones. Mantenimiento **correctivo separado** respecto del código base inspeccionado: escritura al abrir, tabla vacía, campos ocultos y selección ausente. La adaptación SQL Server→PostgreSQL ya estaba en `eeeb817`; no se cuenta de nuevo como aporte de Evelyn. No se implementan cálculos de vacaciones ni la regla anual de licencia.

## Diagramas y evidencias para integrar

- [Diagnóstico y caracterización](CARACTERIZACION.md): evidencia → problema → impacto → recomendación.
- [Antes/después y dependencias](../../diagramas/TEC-004/MOTIVOS_ANTES_DESPUES.md): tres diagramas del paquete.
- [Permisos/licencias/vacaciones](../../diagramas/TEC-004/FLUJOS_FUNCIONALES.md): código inferido, catálogos observados y propuesta futura diferenciados.
- [SVG listos para diapositivas](../../diagramas/TEC-004/svg): seis diagramas exportados con Mermaid CLI 11; todos renderizados correctamente. Son diagramas, no capturas de aplicación.
- [Salida de pruebas](../../evidencias/TEC-004/resultado-portable.txt) y [resumen](../../evidencias/TEC-004/resumen-portable.json): **130 aprobadas, 0 fallos, 0 omitidas** el 18/10/2026 sobre código combinado `9a00a4a`. Incluyen la suite previa, feriados de Frank y 14 pruebas de PostgreSQL local ficticio. Ejecutadas en macOS ARM, SDK 8.0.132, PostgreSQL 14.20, con fuentes reales enlazadas en cinco ensamblados .NET 8 separados. No prueban la ejecución net48 ni WinForms.
- [Compilación net48](../../evidencias/TEC-004/compilacion-net48.txt): Domain, Application, Presentation, PostgreSql y Tests compilan con 0 advertencias/errores. No incluye el ejecutable WinForms: aquí faltan las DLL licenciadas y Windows.
- [Consulta desplegada de solo lectura](../../evidencias/TEC-004/catalogos-solo-lectura.txt): tipos/motivos con IDs repetidos y categorías de licencias/vacaciones. No contiene personas ni credenciales. No se modificó la instancia compartida.

Para repetir la verificación portable: SDK .NET 8 y Python 3; ejecutar `python3 docs/t2/evidencias/TEC-004/ejecutar_pruebas_portables.py`. Sin variable de integración se omiten los casos PostgreSQL. Para ejecutarlos, crear primero una BD **local desechable** `rrhh_tec004_tests` y definir `RRHH_TEST_POSTGRES_CONNECTION` con host `127.0.0.1`/`localhost`, usuario local y esa BD. Las pruebas eliminan/recrean cuatro tablas dentro de esa BD; nunca usar la BD compartida ni `.env`. El servidor temporal utilizado en esta sesión quedó detenido tras verificar los resultados.

## Riesgos que deben resolverse con Kadin y Frank

1. La instancia compartida tiene IDs repetidos en TipoPermiso y Motivo_Perm. La consulta con JOIN puede multiplicar filas; obtener/editar/borrar un ID ambiguo se rechaza y el alta rechaza tipos ambiguos. Kadin debe diagnosticar y sanear mediante su TEC-002, con copia/plan de reversión; este paquete no deduplica ni cambia el esquema. Hasta entonces, demostración de escritura en QA ficticia limpia.
2. Identidad/default se respeta si existe. Sin ello, MAX+1 se serializa con bloqueo de tabla y se verifica unicidad del ID insertado; una secuencia desalineada revierte la fila. Las secuencias PostgreSQL pueden avanzar aunque haya rollback. Los escritores legados externos aún requieren PK/UNIQUE y coordinación de secuencias en TEC-002.
3. Borrado bloquea escrituras de tablas relacionadas durante la comprobación y DELETE. Es transitorio y puede bloquear otras sesiones. **No sustituye las FK**: tras el commit, otro escritor sin validación puede crear una referencia huérfana. Kadin debe completar integridad declarativa. No afirmar garantía global de integridad.
4. Confirmar política funcional de baja/borrado y duplicados por descripción con el equipo/área usuaria. Se bloquea borrado con histórico como decisión conservadora; no se implementó unicidad de descripción sin una regla acordada. Por eso RF-04/05 siguen parciales.
5. Dos entradas de MainMDI pasan por CompositionRoot. Coordinar ese archivo compartido con Jorge/Frank antes de integrar sus ramas. La base documental ya está en main mediante PR #1. Main se incorporó a nuestra rama y los conflictos de composición/plan se resolvieron conservando ambos paquetes.

## QA Windows y revisión: siguiente paso verificable

Evelyn ejecuta; Frank revisa resultados. Usar equipo Windows con dependencias legítimas y QA aislada ficticia preparada con Kadin, sin los IDs ambiguos. Registrar commit exacto, Windows/.NET, versión de esquema, autor/fecha, esperado, observado y captura por caso. Las filas de abajo están pendientes; las pruebas automáticas anteriores no sustituyen estas capturas.

```powershell
.\Software\scripts\build.cmd
dotnet test .\Software\RRHH.Tests\RRHH.Tests.csproj --logger "trx;LogFileName=tec004-windows.trx"
```

| Caso manual | Preparación y acción | Esperado | Estado |
|---|---|---|---|
| QA-004-01 | Abrir motivos por ambas entradas de MainMDI; cambiar tipo con roles 10, 14 y 13 | P, C y todas las modalidades respectivamente; inactivos conservados | Pendiente |
| QA-004-02 | Abrir un editor existente y cancelar, comparando fila antes/después en QA | Cero escrituras; no cambios | Pendiente |
| QA-004-03 | Alta válida con descripción/abreviatura; repetir con Motivo_Perm vacía en QA | Guarda y aparece una vez; ID válido | Pendiente |
| QA-004-04 | Editar un motivo C inactivo con rol 13 y salario nulo | Cambian solo campos editados; conserva tipo/C/inactivo y nulabilidad no alterada | Pendiente |
| QA-004-05 | Probar descripción vacía y límites 50/3; forzar error de conexión en QA | Mensaje; editor permanece abierto; sin persistencia parcial | Pendiente |
| QA-004-06 | Modificar/eliminar sin fila; cancelar confirmación | Mensaje o cancelación; cero escrituras | Pendiente |
| QA-004-07 | Borrar un motivo con Permiso, con auditoría anterior/actual y sin referencias | Conserva los referenciados; borra únicamente el libre | Pendiente |
| QA-004-08 | Sesión con rol no autorizado; motivo con código duplicado en QA | Acceso denegado / diagnóstico de integridad; no modifica | Pendiente |

Añadir observado/evidencia al ejecutar; no rellenar “aprobado” por anticipado. Frank registra archivo/caso, impacto, sugerencia y cómo lo comprobó; Evelyn responde y corrige. No se simula su aprobación ni se publica/integran cambios sin la instrucción correspondiente.

## Guion breve para tu exposición

“Mi paquete es TEC-004: motivos de permiso. En la base f713383, el formulario mezclaba consultas y guardado y el editor actualizaba al abrir. Separé vista, presenter, casos y repositorio siguiendo la arquitectura del equipo. DRY se ve en Recargar; SRP en esas responsabilidades; DIP en IMotivoPermisoRepository y su inyección desde CompositionRoot. El mantenimiento principal es preventivo y las correcciones están separadas. Las pruebas comprueban carga sin escritura, conservación de campos, filtros, referencias y concurrencia. Debemos completar QA Windows y resolver la integridad de la BD con Kadin antes de integrar.”

Mostrar el diff del Load anterior, luego `MotivoPermisoEditorPresenter.Cargar`, `Recargar`, la interfaz del repositorio y la evidencia. Para la diapositiva del equipo, resumir problema → cambio → principio/patrón → prueba → límite. Ajustar tiempos con el ensayo global de 20 minutos.

Reversión: no hay migraciones ni escrituras sobre la BD compartida en este paquete. Antes de integrar, volver a la base de código si se rechaza el cambio; después, revertir el commit de integración con revisión del equipo. No borrar datos nuevos ni restaurar un dump para revertir solamente este refactor.

IA: análisis, código, pruebas, diagramas y borrador de evidencias asistidos por Codex. Los resultados automáticos son reales; comprensión de Evelyn, recorrido Windows y revisión de Frank siguen pendientes de su participación humana.
