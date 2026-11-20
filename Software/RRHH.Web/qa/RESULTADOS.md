# Verificación del piloto web y móvil

## Verificación de main del 20 de noviembre de 2026

El commit 7b90c45 integra el PR #67. PostgreSQL 18 local y datos ficticios.
La regresión registró 390 pruebas aprobadas, cero fallidas y cero omitidas.
El smoke HTTP pasó. WinForms compiló con 0 errores y 26 advertencias.
Las capturas previas corresponden al candidato con el mismo contenido.
Ver la [matriz de aceptación](../../../docs/final/MATRIZ_ACEPTACION_RF.md).


## Continuación local RF-03 / RF-06 — 19/11/2026

Rama `codex/rf-03-permisos-web`, sobre `f496a90` (PR #57).
Solo datos ficticios en PostgreSQL 18 local. No modifica el despliegue compartido.

| Comprobación ejecutada | Resultado |
|---|---|
| Regresión net48 con PostgreSQL local | 362/362 aprobadas, ninguna omitida |
| Compilación del host web | 0 errores y 0 advertencias |
| GET/POST de permisos sin sesión/rol, y POST sin CSRF | 401 / 403 / 400 según el caso |
| Alta y carga con observación | Número confirmado y datos recuperados |
| Segundo permiso en la misma fecha | Rechazado sin alta |
| Anulación y reutilización de la fecha | Admitidas; reactivar el permiso anterior se rechaza y conserva Anulado |
| Dos códigos de motivo del mismo grupo anual | Segundo rechazado aunque las fechas sean diferentes |
| Recorrido real en navegador local | Login, alta del permiso 2 para empleado ficticio 101, rechazo de solapamiento, carga y anulación; mensajes observados en pantalla |

El recorrido en navegador usó otra instancia de demo desechable. No se
guardaron capturas de este recorrido; no se presentan resultados de WinForms
visual ni del servidor compartido. La evidencia del guardado común está en
[RF-03](../../../qa/RF-03-ESTADOS-RESULTADOS.md).

## Evidencia histórica del primer corte

Base T3: `bb5add4`. Entorno de verificación: Windows, SDK .NET 8.0.428, PostgreSQL 18 local desechable y datos ficticios. La migración de teletrabajo se ejecutó en un clúster separado limitado a loopback.

| Comprobación | Resultado obtenido |
|---|---|
| Compilación de RRHH.Web | Correcta, 0 advertencias y 0 errores. |
| Sesión HTTP | Sin sesión, 401. Rol ficticio no habilitado, 401. Operador habilitado, 204. |
| Protección de escritura | Solicitud autenticada sin token, 400. |
| Registro y listado | Alta de cinco días, 201. Segunda alta igual, 400. El listado devolvió una sola fila. |
| Reporte | Cuatro días con un feriado ficticio entre semana. |
| Cierre de sesión | 204. Consulta posterior, 401. |
| PWA | Manifiesto standalone, iconos y service worker disponibles por HTTP. Sintaxis de ambos scripts comprobada con Node. |
| RRHH.Tests net48 | 306 aprobadas, 36 omitidas, 0 fallidas. No se configuró el destino de integración de la suite de escritorio. |
| Build completo WinForms | Falló al resolver la dependencia GRLL ausente en la copia aislada. |

Comando reproducible en PowerShell 7 con puertos locales libres:

```powershell
pwsh -NoProfile -File Software/RRHH.Web/qa/Smoke.ps1 -PostgreSqlBin '<ruta a bin de PostgreSQL>'
```

## Verificación del 17 de noviembre de 2026

- `Smoke.ps1 -RegresionEscritorio` compiló la web con 0 errores y 0 advertencias. En net48 pasaron **342 de 342**, con 0 omitidas y 0 fallidas. Las 36 pruebas anteriormente omitidas usaron `rrhh_tec004_tests` dentro de un clúster PostgreSQL 18 desechable.
- El chequeo HTTP registró un periodo parcial de lunes, miércoles y viernes y obtuvo dos días remotos porque el miércoles 11/11/2026 era feriado ficticio.
- En el navegador de escritorio, el operador inició sesión y registró ese patrón para el empleado ficticio 101 del 9 al 13 de noviembre. El listado mostró el periodo 1, modalidad Parcial y patrón Lun, Mié, Vie. El reporte del 9 al 15 mostró dos días. Repetir el registro mostró el error de solapamiento.
- Para repetir el recorrido interactivo, ejecutar la [guía de demo local](../README.md#demostración-y-qa). Queda por confirmar con el equipo el alcance académico y con Kadin la selección de roles y datos para la demostración grupal.
- Build WinForms en af0df7c: se preparó la distribución local con GRLL y DevExpress, build.cmd terminó con 0 errores y 26 advertencias en el aplicativo, y generó RecursosHumanos.exe x86. Las 342 pruebas de escritorio pasaron con PostgreSQL ficticio. La sesión móvil queda fuera del alcance actual.

## Revalidación del corte web

- Después de retirar la instalación PWA del diff, el host volvió a compilar con 0 errores y 0 advertencias. Pasó la prueba de sesión, rol, CSRF, alta total y parcial, solapamiento, listado, calendario y cierre de sesión contra PostgreSQL 18 ficticio.
- La suite de escritorio volvió a registrar 342 aprobadas, 0 fallos y 0 omitidas. Queda pendiente el recorrido visual de WinForms. El intento adicional de ejecutar el diagnóstico del binario no produjo un resultado verificable y no se contabiliza como aprobado.
