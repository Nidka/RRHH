# CR-019: web por módulos y componentizada, selección de empleado por nombre

- Estado: Web implementada y verificada en la rama; escritorio pendiente (requiere Windows para compilar y probar).
- Tarea / RF / CR: CR-019 (transversal; afecta las pantallas de RF-01 a RF-18).
- Autor responsable / revisor: Evelyn Victoria Rodriguez Cardozo / pendiente de asignar (otro integrante).
- Versión/commit analizado: `9797b59` (main, después de v1.6.0 y del despliegue web de PR #74). Suite net8 en ese commit: 390 de 390 superadas (PostgreSQL 18 local desechable, datos ficticios, 23/11/2026). La rama parte de `7731ca2` (PR #75, que solo deja de registrar el mensaje de error de `/salud/lista`).
- Evidencias / PR: pendiente. Rama `feature/cr-019-ux-modulos`, label `semver:minor` (v1.7.0).

## Problema y comportamiento actual

Comportamiento observado en el código de `9797b59`, no en el ejecutable original.

**Web (frente principal de la demostración):**

1. **Una sola página con todo apilado.** `RRHH.Web/wwwroot/index.html` tiene 13 `<section>` seguidas (mis vacaciones, teletrabajo, ausencias, turnos, histórico, motivos, asistencia, permisos y vacaciones) sin navegación por módulo.
2. **Un solo script para todo.** `wwwroot/app.js` (392 líneas) mezcla sesión, cliente HTTP, tablas de resultados y la lógica de cada formulario (`nuevoPermiso`, `nuevoTurno`, `limpiarMotivos`…). Agregar un módulo obliga a editar ese archivo y el HTML.
3. **Todos los endpoints en `Program.cs`** (301 líneas, 29 `Map*`). Un cambio en vacaciones toca el mismo archivo que el inicio de sesión.
4. **Títulos de prototipo:** «Permisos y licencias del piloto», «Vacaciones generadas del piloto».
5. **El empleado se escribe por su número interno.** Pasa lo mismo en escritorio (punto 7).

**Escritorio (evidencia de que el sistema heredado también evolucionó):**

6. `MainMDI.cs` (aprox. líneas 2297-2378) cuelga vacaciones, teletrabajo, permisos y asistencia de «Mantenimientos», junto a catálogos, con títulos «… del piloto». Cada entrada repite el mismo bloque de apertura (`DropDownItems.Add` + `using … ShowDialog`).
7. Ocho formularios piden el `IdEmpleado` en un `NumericUpDown`: `FrmAsistenciaConsolidada`, `FrmPermisoPiloto`, `FrmReporteTeletrabajo`, `FrmSaldoVacaciones`, `FrmReporteAsistenciaPiloto`, `FrmTeletrabajo`, `FrmReporteVacaciones` y `FrmVacacionesGeneradas`.

Impacto: el enunciado de la evaluación final pide funcionalidades «integradas al sistema y que no sean pantallas aisladas sin conexión con el flujo principal», y una implementación «funcional, coherente y mantenible».

## Resultado esperado y alcance

**Cambia:**

- **Navegación por módulos** con los nombres del enunciado: Turnos, Permisos y licencias, Vacaciones, Teletrabajo, Reportes y Mi cuenta (autoconsulta). Aplica a la web y al menú de escritorio. Cada pantalla aparece una sola vez y en su módulo. Un módulo sin pantallas habilitadas para el rol no se muestra.
- **Web componentizada:**
  - Frontend: módulos ES nativos, sin herramientas de compilación nuevas.
  - Componentes compartidos: `navegacion`, `selector-empleado`, `tabla-resultados`, `cliente-api` y `mensajes`.
  - Una carpeta por módulo de negocio.
  - Backend: los endpoints se agrupan por módulo en clases de extensión (`MapTurnos`, `MapPermisos`, `MapVacaciones`, `MapTeletrabajo`, `MapReportes`, `MapCuenta`). `Program.cs` queda solo con la configuración y la composición.
- **Selección de empleado por apellidos, nombres o documento**, con un solo componente en la web y uno en escritorio. En escritorio las vistas conservan `int Empleado`, así que los presenters no cambian.
- Se retira «del piloto» de los títulos.

**Se conserva (refactorización sin cambio de reglas):**
- Rutas y contratos HTTP actuales: la prueba de humo `deploy/smoke.sh` debe pasar sin cambios.
- Permisos por rol (`RRHH_WEB_ROLES_*`, `PuedeConsultarVacaciones`, `PuedeGestionarPermisos`, `PuedeConsolidarAsistencia` y la condición de teletrabajo en `MainMDI`), la protección antifalsificación y la política de seguridad de contenido (CSP).
- Cálculos, validaciones y mensajes de cada RF.

**Fuera de alcance:** cambiar reglas de negocio o el esquema de BD, rediseñar formularios heredados de DevExpress y renombrar o mover `Frm*` y sus `.resx`.

**Por confirmar:**
- Qué periodo representa a un empleado. Hipótesis: el registro de `Empleado` con mayor `Year` por `IdEmpleado`.
- Si la búsqueda incluye cesados. Hipótesis: sí, marcados como tales, porque RF-09 calcula truncas al cese.

## Criterios de aceptación

- Dado un operador con todos los roles, cuando inicia sesión en la web, entonces ve la navegación Turnos, Permisos y licencias, Vacaciones, Teletrabajo y Reportes, y solo se muestra el módulo elegido.
- Dado un rol sin vacaciones, cuando inicia sesión, entonces el módulo Vacaciones no aparece ni en la web ni en escritorio.
- Dado un usuario de autoservicio, cuando inicia sesión, entonces solo ve «Mi cuenta» con sus vacaciones (RF-12 sin cambios).
- Ningún título, menú ni encabezado contiene «piloto».
- Dado «gar» en el selector, cuando el operador busca, entonces ve hasta 20 coincidencias «Apellidos, Nombres · documento», y al elegir una el formulario usa el `IdEmpleado` correcto.
- Dado un texto de menos de 2 caracteres, entonces no se consulta la base. Si no hay coincidencias, se muestra «No se encontraron empleados».
- Dado `' OR 1=1 --` como texto, entonces no hay error ni resultados inesperados (consulta parametrizada).
- Dado `GET /api/empleados` sin sesión, entonces responde 401.
- Regresión: la suite net8 sigue en 0 fallas y `deploy/smoke.sh` con la base de demostración pasa completo.
- Tras redesplegar, el navegador carga la interfaz nueva sin limpiar caché a mano (`VERSION` del service worker en `rrhh-web-v2` y lista `ESTRUCTURA` actualizada con los módulos JS).

## Impacto y diseño

- **Tipo principal: perfectivo** (usabilidad e integración en el flujo principal). **Secundario: preventivo**, porque baja el costo de agregar módulos y elimina duplicación.
- **Técnicas de refactorización:** *Extract Module/Class* (frontend por módulo, endpoints por módulo, menú de escritorio fuera de `MainMDI`), *Extract Component* (selector, tabla, navegación) y *Replace Conditional with Data* (catálogo declarativo de módulos). Se conservan rutas, contratos y permisos.
- **Capacidad nueva, con aceptación propia:** búsqueda de empleados por texto.
- **Patrones:** MVP de vista pasiva en escritorio, Repository (`IEmpleadoBusquedaRepository`), módulos ES con componentes en la web y composición en los `CompositionRoot` de escritorio y web.
- **Principios** (alimentan la ficha REF-005 de la evaluación final):
  - *Abierto/Cerrado:* un módulo nuevo es una carpeta y una entrada en el catálogo, sin editar `Program.cs`, `app.js` ni `MainMDI`.
  - *DRY:* un selector, una tabla y un cliente HTTP compartidos.
  - *Responsabilidad única:* `Program.cs` configura y cada clase de endpoints atiende un módulo.
  - *Inversión de dependencias:* `BuscarEmpleados` depende del contrato del repositorio.
- **Clave para la sustentación:** escritorio y web usan los mismos casos de uso de `RRHH.Application` y los mismos repositorios de `RRHH.PostgreSql`. Agregar la web no duplicó ninguna regla de negocio: es la prueba concreta de la separación de capas.

| Capa/archivo o dato | Cambio previsto | Riesgo y mitigación |
|---|---|---|
| `RRHH.Presentation/Navegacion/CatalogoModulos.cs` (nuevo) | Fuente única de módulos: clave, título, pantallas y clave de permiso; sin WinForms ni ASP.NET | Pantalla olvidada: prueba que exige que cada RF de pantalla tenga exactamente una entrada |
| `RRHH.Application/Personal/BuscarEmpleados.cs`, `IEmpleadoBusquedaRepository` (nuevos) | Valida el texto (mín. 2 caracteres, máx. 20 resultados) y delega | Lógica pura: pruebas unitarias con fakes |
| `RRHH.PostgreSql/Personal/PostgreSqlEmpleadoBusquedaRepository.cs` (nuevo) | `DISTINCT ON ("IdEmpleado")` sobre `Empleado`⋈`Persona`, `ILIKE` parametrizado, último `Year` | Periodo equivocado: prueba de integración con datos ficticios |
| `RRHH.Web/Endpoints/*.cs` (nuevos) y `Program.cs` | Mover cada grupo de `Map*` a su módulo sin cambiar rutas; agregar `GET /api/empleados` | Ruta o rol roto al mover: `smoke.sh` completo antes y después |
| `RRHH.Web/wwwroot/js/componentes/*`, `js/modulos/*`, `index.html`, `app.css` | Navegación, componentes y un archivo por módulo; `index.html` solo con la estructura | CSP que bloquee módulos: se cargan desde el mismo origen con `type="module"`, sin scripts en línea |
| `wwwroot/service-worker.js` | `VERSION = 'rrhh-web-v2'` y `ESTRUCTURA` con los nuevos JS | Caché vieja: verificación tras redesplegar |
| `RecursosHumanos/MenuModulos.cs` (nuevo) y `MainMDI.cs` | Menú desde `CatalogoModulos`; reemplaza las líneas 2297-2378 | Visibilidad por rol: QA Windows con dos roles |
| `RecursosHumanos/SelectorEmpleado.cs` (nuevo `UserControl`) y los 8 formularios | Reemplaza `NumericUpDown` y mantiene `int Empleado` | Sin selección: la vista valida antes de invocar al presenter |

## Pasos de implementación o refactorización

1. Caracterizar el estado actual: capturas de la web y del menú de escritorio y salida de `smoke.sh` con la base de demostración.
2. `CatalogoModulos`, con las pruebas escritas primero.
3. `BuscarEmpleados` y su repositorio, con pruebas (incluida la de inyección SQL).
4. Backend web: mover los endpoints por módulo (un commit por módulo, con `smoke.sh` en cada paso) y agregar `/api/empleados`.
5. Frontend web: `cliente-api`, `tabla-resultados`, `mensajes`, `navegacion` y `selector-empleado`; después, un commit por módulo de negocio.
6. Service worker y retiro de «piloto».
7. Escritorio: `MenuModulos` y `SelectorEmpleado` en los 8 formularios.
8. `CHANGELOG.md` (v1.7.0), fila CR-019 en la matriz de cambios, casos `CP-19-nn` y ficha REF-005.
9. Redespliegue, `smoke.sh` contra producción y capturas «después».

## Verificación

| Caso / comando | Resultado esperado | Resultado real / entorno / evidencia |
|---|---|---|
| Suite net8 (línea base `9797b59`) | 0 fallas | 390/390 superadas, macOS arm64, PostgreSQL 18 local desechable, 23/11/2026 |
| Suite net8 con los cambios | 0 fallas, más las pruebas nuevas | 419/419 superadas (29 nuevas), macOS arm64, PostgreSQL 18 local, 23/11/2026 |
| `deploy/smoke.sh` con la base de demostración | Prueba de humo correcta | Correcta, contra el host local con la base de demostración (sin Docker), 23/11/2026 |
| Caracterización de la API antes/después (`qa/evidencias/cr-019/caracterizar.sh`) | Rutas existentes sin cambios | 61 de 61 respuestas idénticas; 6 diferencias solo en las rutas nuevas |
| Recorrido en Chrome (`qa/evidencias/cr-019/recorrido-web.mjs`) | Navegación, reglas, roles y celular | 44 de 44 verificaciones, sin errores de JavaScript; casos CP-19-01 a CP-19-09 |
| `deploy/smoke.sh https://rrhh-web-ate6.onrender.com --solo-salud` (línea base) | Prueba de humo correcta | Correcta, 9 de 9: salud, base de datos, PWA, 401 sin sesión y encabezados CSP/nosniff. Despliegue de `9797b59` en Render, 23/11/2026 |
| La misma prueba tras redesplegar con los cambios | Prueba de humo correcta | Pendiente |
| `Software\scripts\build.cmd` y QA de escritorio con dos roles | 0 errores; menús por rol | Pendiente: requiere Windows |

## Reversión

No hay cambios de esquema ni de datos. Para volver atrás basta revertir el merge (`git revert -m 1 <merge>`) y redesplegar. La versión nueva del service worker reemplaza la caché al activarse, y al revertir se vuelve a subir `VERSION`.

## Uso de IA y decisiones humanas

Claude Code (Opus 5.5) caracterizó la web, el menú, los formularios y el esquema en `9797b59`, ejecutó la suite de línea base y redactó este borrador. Evelyn revisa el alcance, confirma las hipótesis de periodo y cesados, ejecuta el QA y lo sustenta. La revisión del PR la hace otro integrante.
