# Verificación del piloto web y móvil

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
- Pendiente de Jorge y el revisor: compilación completa de WinForms con la distribución autorizada que incluye GRLL y DevExpress. La verificación móvil queda fuera del alcance de esta revisión.
