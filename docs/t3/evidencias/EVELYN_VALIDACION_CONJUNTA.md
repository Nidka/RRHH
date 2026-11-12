# Verificación conjunta del aporte local de Evelyn

12/11/2026, America/Lima. Rama `revision/evelyn-t3-local`, base remota revisada `03ab748`; combina RF-01 `5e91030`, RF-02 `45752cb` y cierre automatizado RF-04/RF-05 `f1796af`. No modifica main ni publica ramas/PR. La resolución del conflicto conservó los 30 casos de Evelyn con IDs únicos; solo se actualizaron filas propias CR-001/002/004/005.

| Comprobación ejecutada | Resultado | Evidencia |
|---|---|---|
| Arnés reproducible net8 con fuentes reales de Domain/Application/Presentation/PostgreSql y todos los tests | **325 correctas, 0 fallos, 0 omitidas** | [Salida completa](evelyn-suite-conjunta-net8.txt) |
| Proyecto real RRHH.Tests net48: dotnet build con caché NuGet | **0 errores, 0 advertencias**; compila capas/tests | [Salida](evelyn-build-net48.txt) |
| Parser Roslyn C#12 de FrmHorarioEsp, FrmConsultaHorarioEsp, FrmBuscarPersona y CompositionRoot | 4 archivos, 0 errores sintácticos | No valida tipos/licencias/diseño WinForms |
| Ejecución real net48 en macOS | Anulada: FileNotFoundException, falta host mono | Sigue pendiente ejecución Windows; no es una suite aprobada |
| WinForms, build.cmd, selección/filtros, Excel COM, capturas | **No ejecutados**: macOS y DLL heredadas/licenciadas ausentes | Evelyn ejecuta en Windows/QA ficticia; Kadin/Frank revisan según RF |

El fixture SQL corrió en un clúster PostgreSQL 14 temporal propio, loopback puerto 55439, base desechable rrhh_tec004_tests; no se leyó .env ni se conectó a servidor compartido. Los tests verifican el contrato en fixture, no equivalencia de datos del servidor de Kadin. La compilación net48 de capas/pruebas no compila ni ejecuta la aplicación WinForms.

La revisión técnica de IA señaló un orden de bloqueos incompatible con la baja del catálogo. Se añadió una regresión SQL determinista: antes del arreglo falló con 55P03 sobre Empleado; al ordenar Horario → Empleado → HorarioTemporal pasa junto con la suite. Esta revisión no sustituye aprobación humana de Kadin/Frank.

## Reproducir la comprobación complementaria

Con Python 3, SDK .NET 8 y paquetes NuGet disponibles:

```sh
python3 docs/t3/evidencias/arnes_net8.py
```

Se construyen proyectos net8 temporales con las fuentes exactas; no se cambia ningún csproj productivo. Opcionalmente pasar `--source <cache-o-origen-nuget>`. Sin RRHH_TEST_POSTGRES_CONNECTION se omiten las pruebas SQL (no presentar esa ejecución como 325 casos con SQL). Para habilitarlas usar exclusivamente un PostgreSQL local desechable con nombre rrhh_tec004_tests, según los guardas de los tests; sus fixtures borran/recrean tablas de esa BD. Nunca usar la cadena compartida.

El script no carga .env ni inicia/selecciona un servidor. El entorno de esta sesión fue temporal y se detuvo al finalizar. El resultado complementario no cierra los RF que requieren Windows, capturas y revisión humana.
