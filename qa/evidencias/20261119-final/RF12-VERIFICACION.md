# RF-12: verificación local de WinForms

Verificación del 19/11/2026, datos ficticios. Código base b2150ca más
correcciones locales de arranque de codex/qa-18-rf-local, aún sin publicar.
SHA256 del ejecutable observado:
E9886FD08D0087C4AB755041C5EE1B976BB7F132ED365301960BFAF8D1944006.

El usuario realizó el login; el asistente observó la sesión y ejecutó la consulta.

| Comprobación | Evidencia y resultado |
|---|---|
| Identidad | Título «Mis vacaciones · consulta del empleado (empleado_a)» |
| Consulta propia | Empleado 101, corte 19/11/2026: generadas 60, usadas 12,5, pendientes 47,5 |
| Detalle | Permiso 100: 12 días; permiso 101: 0,5 días |
| Funciones operativas | No hay MDI, menús de RRHH, botones de escritura ni selector de empleado en esta ventana |
| Solo lectura | F2 y escritura de 999 en la celda seleccionada no modifican el número 100 ni el saldo |
| Aislamiento por identidad | El presenter conserva el IdUsuario autenticado; ConsultarMisVacaciones resuelve el vínculo en cada consulta y no acepta un empleado desde la vista |
| Prueba de repositorio/caso de uso | RF12IdentidadSoloConsultaSuEmpleadoYRechazaVinculosAmbiguos verifica dos identidades/empleados distintos y rechaza vínculo nulo, cuenta inactiva y usuario duplicado |

Capturas: [consulta](escritorio-rf12-empleado-a.jpg) y
[solo lectura](escritorio-rf12-solo-lectura.jpg). Los archivos UI.txt conservan
el árbol accesible observado; su etiqueta genérica «editar» en celdas no
significa que la tabla permita escritura.

Se repitió Smoke.ps1 -RegresionEscritorio con PostgreSQL 18 desechable en
puerto 55479 y web 5119. También confirmó autoconsulta HTTP aislada entre dos
cuentas. El segundo usuario no tuvo un nuevo recorrido visual nativo en esta
sesión; esa separación se contrastó mediante las pruebas y el contrato común.
Resultado de la suite: 390 aprobadas, 0 fallidas y 0 omitidas.

Resultado: recorrido solicitado aprobado en el piloto local observado.
No certifica el main sin las correcciones locales, un despliegue compartido,
restricciones de acceso directo a PostgreSQL ni resistencia a un binario
modificado. No se hicieron merges, publicaciones ni cambios nuevos de código.
