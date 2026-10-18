# Registro de Evidencias Reales — Paquete `TEC-003` (Feriados)

- **Paquete / Solicitud:** `TEC-003` / `CR-TEC-003`.
- **Responsable:** Frank Piero Mantilla Arqueros.
- **Revisor asignado:** Francisco Kadin Valera Lizarraga.
- **Fecha:** 17/10/2026.
- **Entorno de ejecución:** Windows 10/11 (x64), MSBuild 17 / .NET SDK, .NET Framework 4.8 (`x86` en `RecursosHumanos.exe`), PostgreSQL 16 (Neon `neondb`, conexión SSL verificada mediante `.env` local ignorado en Git).

---

## 1. `EV-TEC-001` — Verificación de línea base (`eeeb817` / `PRIMERA_PRUEBA.md`)

- **Autor:** Frank Piero Mantilla Arqueros.
- **Fecha:** 17/10/2026.
- **Versión / Commit base:** `eeeb817` (sobre rama organizativa `f713383`).
- **Origen:** Código reconstruido del repositorio antes de editar `TEC-003`.
- **Comandos ejecutados y resultados reales obtenidos:**

### 1.1. Compilación de la solución (`Software\scripts\build.cmd`)

```text
> .\Software\scripts\build.cmd
Compilación correcta.
    13 Advertencia(s)
    0 Errores
```

### 1.2. Comprobación de conexión y módulos PostgreSQL (`check-postgresql.cmd`)

```text
> .\Software\scripts\check-postgresql.cmd
PostgreSQL: conexión y esquema RRHH verificados.

> .\Software\scripts\check-postgresql.cmd -Modules
PostgreSQL: conexión y esquema RRHH verificados.
Modulos PostgreSQL: tipos=14/6; motivos=280; ubigeos=6596; horarios=11028; locales=11028; semanal=2757; detalle=57712; cumples=1664; ficha=11 tablas; documentos=0.
```

### 1.3. Suite de pruebas unitarias y de arquitectura en línea base

```text
> dotnet test .\Software\RRHH.Tests\RRHH.Tests.csproj --no-restore -c Debug
Correctas! - Con error: 0, Superado: 65, Omitido: 0, Total: 65, Duración: 121 ms - RRHH.Tests.dll (net48)
```

---

## 2. `EV-BD-001` — Perfilado de solo lectura de `public."RRHH_Feriado"` en PostgreSQL

- **Autor:** Frank Piero Mantilla Arqueros.
- **Fecha:** 17/10/2026.
- **Origen:** Instancia PostgreSQL desplegada por Kadin (`neondb`), consultada en modo de solo lectura mediante `PostgreSqlExecutor` sin alterar filas ni exponer credenciales.
- **Consulta ejecutada:**

```sql
SELECT COUNT(*) AS total,
       COALESCE(MIN("idFeriado"), 0) AS min_id,
       COALESCE(MAX("idFeriado"), 0) AS max_id,
       COUNT(DISTINCT "Fecha"::date) AS distinct_dates,
       COUNT(*) FILTER (WHERE "Motivo" IS NULL OR BTRIM("Motivo") = '') AS empty_motivos,
       COALESCE(MAX(CHAR_LENGTH("Motivo")), 0) AS max_len
FROM public."RRHH_Feriado";
```

- **Resultado real observado:**

```text
METRICS: total=442, min_id=5, max_id=272, distinct_dates=221, empty_motivos=6, max_len=70
CONSTRAINTS count=1
CONSTRAINT: RRHH_Feriado_idFeriado_not_null (n) -> NOT NULL "idFeriado"
```

- **Muestra de registros observados (datos de catálogo no personales):**
  - `id=5 | fecha=2010-07-28 07:57:05 | motivo=FIESTAS PATRIAS` (aparece 2 veces)
  - `id=219 | fecha=2023-05-01 10:27:27 | motivo=` (motivo vacío y con hora distinta de `00:00:00`, aparece 2 veces)
  - `id=271 | fecha=2026-01-01 11:39:43 | motivo=AÑO NUEVO` (aparece 2 veces)
  - `id=272 | fecha=2026-01-02 00:00:00 | motivo=FERIADO LARGO` (aparece 2 veces)
- **Conclusiones técnicas del perfilado (`EV-BD-001`):**
  1. La tabla no posee aún `PRIMARY KEY` ni restricción `UNIQUE` (solo `NOT NULL "idFeriado"`), y cada uno de los 221 feriados históricos está duplicado dos veces (`442` filas).
  2. Existen 6 filas con `Motivo` vacío (`idFeriado` 187, 198 y 219), por lo que `Feriado.Reconstituir` debe aceptar motivos vacíos al leer desde BD para que el listado no falle, mientras `Feriado.Crear` impide registrar nuevos feriados sin motivo.
  3. Existen registros con hora distinta de `00:00:00` (`07:57:05`, `10:27:27`, `11:39:43`), por lo que la validación de fecha duplicada en PostgreSQL debe seguir comparando por día calendario (`"Fecha"::date = @fecha`) y las nuevas altas deben guardar `Fecha.Date` (`00:00:00`).

---

## 3. `EV-TEC-002` — Verificación posterior al refactor de `TEC-003`

- **Autor:** Frank Piero Mantilla Arqueros.
- **Fecha:** 17/10/2026.
- **Rama:** `refactor/tec-003-feriados`.
- **Resultados obtenidos tras implementar las capas de `TEC-003`:**

### 3.1. Compilación de la solución completa (`build.cmd`)

```text
> .\Software\scripts\build.cmd
    35 Warning(s)
    0 Error(s)
Time Elapsed 00:00:04.30
```

*(Sin errores ni advertencias nuevas en `RRHH.Domain`, `RRHH.Application`, `RRHH.Presentation`, `RRHH.PostgreSql`, `FrmFeriado.cs` ni `RRHH.Tests`).*

### 3.2. Ejecución de pruebas unitarias, de arquitectura y de esquema (`dotnet test`)

Se agregaron **22 nuevas pruebas** en `Software/RRHH.Tests/Asistencia/` (`FeriadoTests`, `RegistrarFeriadoTests`, `FeriadoPresenterTests`), pasando de 65 a **87 pruebas superadas**:

```text
> dotnet test .\Software\RRHH.Tests\RRHH.Tests.csproj --no-restore -c Debug
  RRHH.Domain -> C:\Users\Piero\Downloads\RRHH\RRHH\Software\RRHH.Domain\bin\Debug\net48\RRHH.Domain.dll
  RRHH.Application -> C:\Users\Piero\Downloads\RRHH\RRHH\Software\RRHH.Application\bin\Debug\net48\RRHH.Application.dll
  RRHH.Presentation -> C:\Users\Piero\Downloads\RRHH\RRHH\Software\RRHH.Presentation\bin\Debug\net48\RRHH.Presentation.dll
  RRHH.PostgreSql -> C:\Users\Piero\Downloads\RRHH\RRHH\Software\RRHH.PostgreSql\bin\Debug\net48\RRHH.PostgreSql.dll
  RRHH.Tests -> C:\Users\Piero\Downloads\RRHH\RRHH\Software\RRHH.Tests\bin\Debug\net48\RRHH.Tests.dll
Test run for C:\Users\Piero\Downloads\RRHH\RRHH\Software\RRHH.Tests\bin\Debug\net48\RRHH.Tests.dll (.NETFramework,Version=v4.8)
VSTest version 17.11.1 (x64)

Passed!  - Failed:     0, Passed:    87, Skipped:     0, Total:    87, Duration: 2 s - RRHH.Tests.dll (net48)
```

### 3.3. Casos cubiertos por las nuevas pruebas automatizadas

| Clase de prueba | Caso verificado | Resultado esperado / obtenido |
|---|---|---|
| `FeriadoTests` | `Crear_TruncaHoraDeLaFechaYNormalizaMotivo` | `Fecha` queda en `00:00:00` y `Motivo` sin espacios laterales (`Passed`). |
| `FeriadoTests` | `Validar_SinMotivo_DevuelveError` (`null`, `""`, `"   "`) | Devuelve `"Debe ingresar motivo."` (`Passed`). |
| `FeriadoTests` | `Validar_FechaPorDefecto_DevuelveError` | Devuelve `"Debe seleccionar una fecha válida."` (`Passed`). |
| `FeriadoTests` | `Validar_RespetaLongitudMaximaDelEsquema` (200 vs 201) | Acepta 200 caracteres y rechaza 201 con `"Motivo: no puede superar 200 caracteres."` (`Passed`). |
| `FeriadoTests` | `Reconstituir_PermiteRegistrosHistoricosSinMotivoOConHora` | Reconstruye registro histórico `id=219` sin lanzar excepción (`Passed`). |
| `RegistrarFeriadoTests` | `Ejecutar_FechaLibre_InsertaYNormalizaDatos` | Inserta feriado, asigna `Id=1` y normaliza `Fecha.Date` y `Motivo` (`Passed`). |
| `RegistrarFeriadoTests` | `Ejecutar_MismoDiaConDistintaHora_RechazaDuplicado` | Rechaza segundo registro del mismo día aunque difiera la hora con `"Ya a Agregado esa Fecha"` (`Passed`). |
| `RegistrarFeriadoTests` | `Ejecutar_DeteccionDeDuplicadoNoDependeDelFormatoRegional` (`es-PE`, `en-US`) | Rechaza duplicado con independencia de `dd/MM/yyyy` o `MM/dd/yyyy` (`Passed`). |
| `RegistrarFeriadoTests` | `Ejecutar_DosAltasSimultaneasDelMismoDia_SoloPermiteUnRegistro` | Dos hilos simultáneos con barrera: 1 inserta con éxito y 1 recibe `"Ya a Agregado esa Fecha"` (`Passed`). |
| `RegistrarFeriadoTests` | `ElMapeoDeFeriadoCoincideConElEsquema` | Verifica contra `BD/schema.sql` que `public."RRHH_Feriado"` tiene `"idFeriado" integer`, `"Fecha" timestamp` y `"Motivo" character varying(200)` (`Passed`). |
| `FeriadoPresenterTests` | `Cargar`, `Agregar` (nuevo, duplicado, vacío, error BD) y `Eliminar` (sin selección, cancelado, confirmado) | Verifica el contrato completo `IFeriadoView` y los mensajes de alerta/confirmación (`Passed`). |
| `DependenciasEntreCapasTests` | Reglas arquitectónicas de `Software/docs/ARQUITECTURA.md` | `Domain`, `Application`, `Presentation` e `Infraestructura` cumplen todas las restricciones de referencias (`Passed`). |

### 3.4. Comprobación de módulos PostgreSQL y actualización de Graphify

```text
> .\Software\scripts\check-postgresql.cmd -Modules
PostgreSQL: conexión y esquema RRHH verificados.
Modulos PostgreSQL: tipos=14/6; motivos=280; ubigeos=6596; horarios=11028; locales=11028; semanal=2757; detalle=57712; cumples=1664; ficha=11 tablas; documentos=0.

> graphify update Software
[graphify watch] Rebuilt: 18111 nodes, 35366 edges, 565 communities
```

---

## 4. Protocolo de exploración WinForms y QA con el revisor (`EV-QA-001` / Pendientes de entorno compartido)

Siguiendo las reglas de `AGENTS.md` (*"El despliegue de BD lo coordina Francisco Kadin Valera Lizarraga. No ejecutar cambios contra su servidor sin un destino y alcance autorizados"*), no se ejecutaron escrituras destructivas ni altas de prueba no autorizadas sobre la instancia compartida durante las pruebas automatizadas.

Para cerrar la revisión cruzada con **Kadin (`TEC-002`)** y adjuntar las capturas visuales de usuario:

1. Abrir `.\Software\RecursosHumanos\bin\x86\Debug\net48\RecursosHumanos.exe` e iniciar sesión.
2. Abrir **Feriados** desde el botón de barra (`ToolStripButton10`) y desde el menú **Feriados** (`FeriadosToolStripMenuItem1`), comprobando que ambos abren la vista conectada por `CompositionRoot.CrearFeriado()`.
3. Con destino QA autorizado por Kadin:
   - Intentar registrar una fecha ya existente (`01/01/2026`) → comprobar alerta `"Ya a Agregado esa Fecha"`.
   - Intentar registrar con motivo en blanco → comprobar alerta `"Debe ingresar motivo."`.
   - Pulsar **Eliminar** sin fila seleccionada → comprobar mensaje `"Primero debe Seleccionar un Feriado No Laborable."`.
   - Registrar un feriado ficticio (`31/12/2099`, `"PRUEBA QA TEC-003"`), verificar que se persiste con hora `00:00:00` en `public."RRHH_Feriado"`, cancelar una primera eliminación y luego confirmar la eliminación para dejar la tabla sin registros ficticios residuales.
