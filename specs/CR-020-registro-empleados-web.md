# CR-020: registrar y editar empleados desde la web

- Estado: Implementado en la rama `feature/cr-020-registro-empleados-web`.
- Tarea / RF / CR: CR-020 (transversal; habilita usar la web sin el escritorio). Sin RF del enunciado.
- Autor responsable / revisor: Evelyn Victoria Rodriguez Cardozo / sin revisor asignado.
- Versión/commit analizado: `f83a678` (main, 24/11/2026).
- Evidencias / PR: pruebas en `Software/RRHH.Tests/Personal/`; PR pendiente.

## Problema y comportamiento actual

La web solo **busca** empleados (`GET /api/empleados`, CR-019). Para dar de alta a una persona hay que usar el escritorio:
**Personal → Nuevo Personal** (`MainMDI.RegistroNuevoToolStripMenuItem_Click`) abre `FrmMantEmpleado_Basico`, cuyo
`btnGuardar_Click` llama a `RRHHClass.Ingresa_Empleado`. Ese método (código reconstruido, `RRHHClass.cs:306`):

1. toma el bloqueo `pg_advisory_xact_lock(721104)`;
2. calcula `IdPersona` e `IdEmpleado` con `MAX + 1`;
3. inserta `Persona` (`TipoPersona = 'N'`, `FechaRegistro` = fecha de ingreso), `Empleado` (`Estado = '1'`, `Year` = año del
   sistema) y `Empleado_Area`.

Al salir del campo de documento, `buscarxDNI` solo **advierte** si el número ya existe; no impide guardar.
`RRHHClass.Actualiza_Empleado` actualiza **todas** las filas del empleado (todos sus años), les asigna el año actual y
`Estado = '1'`: pierde el área histórica y no permite registrar un cese.

Una base nueva (Neon) queda sin forma de cargar personal desde la web.

## Resultado esperado y alcance

Pantalla web **Personal → Registro de empleados** para operadores con la política `RRHH_WEB_ROLES_PERSONAL`:

- Alta con datos básicos: tipo y número de documento, apellido paterno, apellido materno (opcional), nombres, área y
  fecha de ingreso. Queda activo.
- Edición de un empleado elegido con el buscador de CR-019: los mismos datos y el estado (activo o cesado).
- Fuera de alcance: ficha social completa (`FrmFichaSocial`), foto, ubigeo, datos familiares y de salud, horario base,
  usuarios. Siguen en el escritorio.

Reglas:

| Regla | Origen |
|---|---|
| Nombres y apellido paterno obligatorios; longitudes del esquema (100 y 30). | Esquema `Persona` |
| Documento obligatorio, hasta 12 caracteres, letras, dígitos o guion; se guarda sin espacios y en mayúsculas. | Esquema (`NumDocID varchar(12)`) |
| El tipo de documento existe en `TipoDocID`; el área existe en `EstructOrganiz` del año del registro. | Integridad |
| **No se repite** el mismo tipo y número de documento en otra persona (sin distinguir mayúsculas ni espacios). | Cambio respecto al heredado, que solo advertía. **Hipótesis** a confirmar con RRHH. |
| Fecha de ingreso entre el 01/01/1950 y un año después de hoy. | Hipótesis: admite ingresos programados. |
| Alta: `Year` = año actual; `Estado = '1'`; `TipoPersona = 'N'`; `FechaRegistro` = fecha de ingreso, igual que el heredado. | `RRHHClass.Ingresa_Empleado` |
| Códigos con `MAX + 1` bajo el **mismo** bloqueo `721104`, para que escritorio y web no repitan códigos. | `RRHHClass.Ingresa_Empleado` |
| Edición: cambia `Persona` y **solo la fila del año más reciente** del empleado (área, ingreso, estado) y su `Empleado_Area`. | Corrige la pérdida de historial del heredado |

## Criterios de aceptación

- Dado un operador con permiso de personal, cuando registra datos válidos, entonces recibe el código nuevo y el empleado aparece en el buscador como activo.
- Dado un documento ya registrado (con otras mayúsculas o espacios), cuando se intenta registrar otra persona con él, entonces se rechaza con «Ya existe un empleado con ese documento».
- Dado un área inexistente para el año, cuando se registra, entonces se rechaza sin escribir nada.
- Dado un empleado con filas de 2025 y 2026, cuando se edita su área, entonces cambia solo la fila 2026.
- Dado un empleado editado como cesado, cuando se busca, entonces aparece como cesado.
- Dado un operador sin la política de personal, cuando abre la web, entonces no ve el módulo y la API responde 403.

## Impacto y diseño

- **Mantenimiento principal:** perfectivo (capacidad nueva en la web). Secundario: preventivo (regla de documento único y edición sin perder historial).
- **Patrones:** Repository (`IEmpleadoRegistroRepository`), objeto de valor con validación en el dominio (`DatosEmpleado`), caso de uso por operación, composición por inyección de dependencias en la web.
- **Principios:** responsabilidad única (validar en `DatosEmpleado`, coordinar en el caso de uso, persistir en el repositorio) e inversión de dependencias (las pruebas usan un repositorio falso). Abierto/Cerrado: la pantalla se agrega con una entrada en `CatalogoModulos` y su archivo JS.

| Capa/archivo | Cambio | Riesgo y mitigación |
|---|---|---|
| `RRHH.Domain/Personal/DatosEmpleado.cs` | Valida y normaliza los datos básicos | Reglas por confirmar: documentadas como hipótesis |
| `RRHH.Application/Personal/RegistroEmpleados.cs` | Contrato del repositorio, DTO y casos de uso de alta, edición, ficha y catálogos | — |
| `RRHH.PostgreSql/Personal/PostgreSqlEmpleadoRegistroRepository.cs` | SQL parametrizado, transacción y bloqueo `721104` | Concurrencia con escritorio: mismo bloqueo |
| `RRHH.Application/Navegacion/CatalogoModulos.cs` | Módulo «Personal» y permiso `Personal` | Pruebas del catálogo actualizadas |
| `RRHH.Web` | Política `GestionarPersonal`, rutas `/api/personal/…`, pantalla `personal/registro-empleados.js` | Lista vacía = módulo deshabilitado |

## Verificación

| Caso / comando | Resultado esperado | Resultado real |
|---|---|---|
| `DatosEmpleadoTests`, `RegistroEmpleadosTests` | Reglas y casos de uso sin base | Superadas (net8, 27/11/2026) |
| `EmpleadoRegistroPostgreSqlTests` | Alta, duplicado, edición del último año, concurrencia | Superadas en PostgreSQL 18 local |
| `CatalogoModulosTests` | Módulo nuevo y su archivo JS | Superadas; suite completa 455/455 |
| Recorrido en Chrome | Alta, duplicado, búsqueda, edición, cese, celular y rol sin permiso | 11/11 con datos ficticios |

Hallazgo durante la verificación: las pruebas usan Npgsql 4.1 y la web Npgsql 8. Con Npgsql 8, `DbType.DateTime` se envía como
`timestamptz` y PostgreSQL rechaza la fecha; el repositorio usa `DbType.Date`, igual que los demás repositorios de la web.
El recorrido en Chrome lo detectó; las pruebas de integración no podían.

## Reversión

Revertir el merge. No hay migración de esquema. Los empleados creados quedan como filas válidas de `Persona`, `Empleado` y
`Empleado_Area`, iguales a las del escritorio.

## Uso de IA y decisiones humanas

Diseño, código y pruebas preparados con asistencia de Claude Code. La responsable decide el alcance (alta y edición
básicas) y debe validar con el área de RRHH la regla de documento único y el rango de la fecha de ingreso.
