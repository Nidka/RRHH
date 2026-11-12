# §12. Casos de prueba — aporte de Evelyn

Fecha: 12/11/2026, America/Lima. Datos ficticios; macOS arm64 y PostgreSQL temporal local. Nunca se usó .env ni BD compartida.

| Rama / alcance | Resultado realmente ejecutado | Pendiente |
|---|---|---|
| RF-01, commit 5e91030 | 314/314 pruebas complementarias net8, incluye SQL temporal; compilación real de capas/tests net48 0 errores/advertencias | WinForms, build.cmd y ejecución net48 Windows; revisión Kadin |
| RF-02, commit 45752cb | 323/323 pruebas complementarias net8, incluye histórico sin catálogo/filtro/conservación; compilación real de capas/tests net48 0 errores/advertencias | Windows y exportación Excel COM; revisión Kadin |
| RF-04/RF-05, cierre local | 293/293 en rama independiente; conserva marca anual RF-06, alta, baja libre/referenciada y cancelación | Cierre visual con capturas Windows; revisión Frank |

Los totales son suites completas de ramas distintas: **no se suman**. Son arneses net8 temporales con fuentes de las cuatro capas y tests, sin cambiar proyectos productivos net48. La suite net48 no pudo iniciarse en macOS por falta de mono; no se presenta como aprobada. La aplicación requiere DLL heredadas/licenciadas no presentes en el checkout.

[Casos propios](../casos_prueba/evelyn.csv), [salida de motivos](../evidencias/RF-04/suite-net8.txt) y [límites de validación](../evidencias/RF-04/validacion-local.txt). Los CP de RF-01/RF-02 y sus salidas se conservan en las ramas/commits indicados y deben consolidarse con el resto del aporte. Los casos Windows permanecen vacíos/Pendiente; no se aportan capturas fabricadas ni se registra aprobación propia.
