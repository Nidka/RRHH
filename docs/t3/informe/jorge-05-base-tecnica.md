# 5 Base técnica reconstruida

La reconstrucción RRHH usa WinForms, .NET Framework 4.8, DevExpress 11.2 y PostgreSQL. `Software/RRHH.sln` contiene proyectos de interfaz, capas y componentes heredados. La solución conserva pantallas recuperadas y flujos migrados de manera incremental.

| Componente | Evidencia y función |
|---|---|
| Arranque | [README del proyecto](../../../README.md) y [primera prueba](../../t2/PRIMERA_PRUEBA.md) describen dependencias, configuración local y login. |
| PostgreSQL | [Esquema versionado](../../../BD/schema.sql), migraciones de integridad y marca anual. La existencia de archivos no acredita su aplicación a una instancia. |
| Construcción | `Software/scripts/build.cmd` restaura y construye la solución y la salida WinForms x86. Las DLL licenciadas se instalan localmente. |
| Pruebas | `dotnet test Software/RRHH.Tests/RRHH.Tests.csproj`. Las pruebas de negocio usan dobles. Los casos de integración requieren un destino ficticio compatible. |
| Teletrabajo | RF-13 propone la tabla a Kadin y añade un flujo separado. RF-14 lee periodos y feriados sin escribir. |

Antecedentes comprobables: `eeeb817` incorporó la ruta de compatibilidad PostgreSQL. La integración de TEC-002 se identifica en `daba5e0` y sus resultados históricos en [validación de integración](../../t2/evidencias/TEC-002/VALIDACION_INTEGRACION.md). El [registro de horarios](../../t2/evidencias/TEC-001/validacion-local.txt) corresponde al entorno histórico, no a una ejecución nueva.

En la preparación de RF-13, build y suite se intentaron en Windows y se detuvieron por ausencia de .NET SDK. El proceso alternativo con el compilador de Visual Studio recibió acceso denegado. Compilación, ejecución de xUnit, recorrido WinForms y validación de la migración continúan pendientes.
