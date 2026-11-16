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

Pendientes para Jorge y el revisor: recorrido visual en navegador de escritorio, alta parcial en la interfaz e instalación y recorrido en teléfono sobre HTTPS. Validar con Kadin los roles y la base ficticia que se usarán en la demostración.
