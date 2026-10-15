# Arquitectura de RRHH

Este documento es la especificación de arquitectura del sistema RRHH. Todo
código nuevo y todo código heredado que se migre debe cumplirla. La decisión y
sus alternativas están en [adr/0001-mvp-sobre-capas.md](adr/0001-mvp-sobre-capas.md).

## 1. Resumen

- **Patrón de presentación:** MVP (Model–View–Presenter) con vista pasiva.
- **Organización del código:** capas con dependencias solo hacia adentro
  (Dominio ← Aplicación ← Infraestructura / Presentación).
- **Estrategia de migración:** reemplazo gradual por caso de uso
  (*strangler fig*). No se reescribe todo de una vez; cada formulario se
  migra completo y el código heredado se elimina al final.
- **Plataforma:** WinForms, .NET Framework 4.8, C# 12, DevExpress 11.2,
  PostgreSQL mediante Npgsql 4.1.

## 2. Situación de partida

El código fue recuperado por ingeniería inversa de un sistema VB.NET de 2013.
Su estructura actual:

| Elemento | Situación | Destino |
|---|---|---|
| Formularios `Frm*` | Mezclan interfaz, reglas de negocio y SQL. Algunos superan las 3.000 líneas (`FrmFichaSocial` tiene 14.370). | Vista pasiva + Presenter |
| `GRLL.dll` / `dcGRLLDataContext` | LINQ-to-SQL, solo SQL Server. Es el nodo más acoplado del sistema (unas 1.500 dependencias). Incluye módulos ajenos a RRHH (`Aba_*`, `CJR*`). | Se retira |
| `GenericMapper` / `XxxMapper.Instance()` | `DataContext` estático compartido. Lo usan unos 50 formularios. | Repositorios |
| `ClassRRHH` (`RRHHClass`, `FamiliaresClass`, …) | Clases que mezclan SQL Server y PostgreSQL y devuelven `object`/`DataTable`. | Repositorios + casos de uso |
| `DataSet1` y TableAdapters | Procedimientos `spRRHH_*` de SQL Server para reportes. | Consultas de reporte en Infraestructura |
| `RRHH.PostgreSql` | Fábrica de conexiones y ejecutor parametrizado. Es la base correcta. | Capa de Infraestructura |
| Login (`FrmLogin`) | Acceso migrado a capas: `ObtenerAccesoUsuario` + `PostgreSqlAccesoUsuarioRepository`. El formulario aún no es MVP. | Vista pasiva + Presenter |

No hay ciclos de dependencias entre proyectos, lo que permite separar capas sin
romper la compilación.

## 3. Capas y proyectos

```
            ┌──────────────────────────────┐
            │  RecursosHumanos (WinForms)  │  Formularios (vistas) + CompositionRoot
            └───────┬──────────────┬───────┘
                    │              │
                    ▼              ▼
┌──────────────────────┐   ┌───────────────────┐
│ RRHH.PostgreSql      │   │ RRHH.Presentation │  Presenters + interfaces de vista
│ Repositorios Npgsql  │   └─────────┬─────────┘
│ (Infraestructura)    │             ▼
└──────────┬───────────┘   ┌───────────────────┐
           └──────────────▶│ RRHH.Application  │  Casos de uso, interfaces
                           └─────────┬─────────┘  de repositorio, DTO
                                     ▼
                           ┌───────────────────┐
                           │   RRHH.Domain     │  Entidades y reglas puras
                           └───────────────────┘
```

| Proyecto | Responsabilidad | Puede referenciar | Nunca referencia |
|---|---|---|---|
| `RRHH.Domain` | Entidades simples (POCO), objetos de valor y reglas de negocio puras: cálculo de días de permiso, validación de rangos de fechas, etc. | Nada (solo BCL) | WinForms, DevExpress, Npgsql, `System.Data`, GRLL |
| `RRHH.Application` | Casos de uso (`RegistrarPermiso`, `ListarEstadosCiviles`), interfaces de repositorio (`IPermisoRepository`) y DTO de entrada/salida. | `RRHH.Domain` | WinForms, DevExpress, Npgsql, GRLL |
| `RRHH.Presentation` | Presenters e interfaces de vista (`IXxxView`). | `RRHH.Application`, `RRHH.Domain` | WinForms, DevExpress, Npgsql, GRLL |
| `RRHH.PostgreSql` | Implementación de los repositorios con SQL parametrizado, transacciones y conexión. | `RRHH.Application`, `RRHH.Domain`, Npgsql | WinForms, DevExpress, GRLL |
| `RecursosHumanos` | Formularios (vistas), reportes y la *composition root*. | Todos los anteriores | — |
| `RRHH.Tests` | Pruebas (xUnit) de dominio, casos de uso y presenters con repositorios y vistas falsos; mapeos de infraestructura contra `BD/schema.sql`; reglas de dependencias. | Domain, Application, Presentation, PostgreSql (por eso corre en x86) | WinForms, DevExpress |

Los presenters están en un proyecto propio para que el compilador impida que
usen WinForms o DevExpress, y para poder probarlos sin las DLL heredadas.
Los proyectos SDK para net48 referencian por defecto `System.Data` y
`System.Drawing`, así que el compilador no basta:
`RRHH.Tests/Arquitectura/DependenciasEntreCapasTests` revisa los ensamblados
compilados y falla si una capa referencia algo prohibido en esta tabla.
`RRHH.Domain`, `RRHH.Application`, `RRHH.Presentation` y `RRHH.Tests` compilan
sin las DLL de `lib/legacy`. Los proyectos heredados (`GRLL`, `ClassRRHH`, `ClsCtrls`,
`Seguridad`, `GRLL.Common.Rutinas`) quedan **congelados**: solo se tocan para
retirar código ya migrado.

## 4. MVP: contrato de cada pantalla

Cada pantalla migrada tiene tres piezas:

| Pieza | Proyecto | Qué hace | Qué no hace |
|---|---|---|---|
| Interfaz de vista (`IPermisoView`) | `RRHH.Presentation` | Expone los datos que el usuario ve o escribe y los eventos que dispara. | No contiene lógica. |
| Vista (`FrmPermiso`) | `RecursosHumanos` | Implementa `IPermisoView`, configura controles DevExpress y reenvía eventos. | No consulta la base de datos, no decide reglas y no crea repositorios. |
| Presenter (`PermisoPresenter`) | `RRHH.Presentation` | Reacciona a eventos de la vista, llama casos de uso y le dice a la vista qué mostrar. | No referencia tipos de WinForms ni DevExpress (`Form`, `Control`, `MessageBox`, `GridControl`). |

**Implementación de referencia (ya migrada): catálogos simples.** Los 10
mantenimientos con código, descripción y, a veces, un campo adicional
(estado civil, cargos, grupo sanguíneo, nacionalidades, régimen de pensión,
tipos de documento, estudio, institución, permiso y trabajador) usan un solo
componente genérico:

| Capa | Archivos |
|---|---|
| Dominio | `RRHH.Domain/Catalogos/` (`TipoCatalogo`, `DefinicionCatalogo`, `DefinicionesCatalogo`, `ItemCatalogo`) |
| Aplicación | `RRHH.Application/Catalogos/` (`ICatalogoRepository`, `ItemCatalogoDto`, `ListarCatalogo`, `GuardarItemCatalogo`, `EliminarItemCatalogo`) |
| Infraestructura | `RRHH.PostgreSql/Catalogos/` (`MapeoCatalogo`, `ReferenciaCatalogo`, `MapeosCatalogo`, `PostgreSqlCatalogoRepository`) |
| Presentación | `RRHH.Presentation/Catalogos/` (`ICatalogoView`, `CatalogoPresenter`, `CatalogoFilaEventArgs`) |
| Vista | `RecursosHumanos/RecursosHumanos/VistaCatalogoGrid.cs` (lógica de grilla compartida) y los `FrmMant*`, que solo reenvían eventos |
| Composición | `CompositionRoot.CrearCatalogo<TForm>(TipoCatalogo)` |
| Pruebas | `RRHH.Tests/Catalogos/`; `MapeosCatalogoTests` compara cada mapeo con `BD/schema.sql` |

**Agregar otro catálogo simple:** un valor nuevo en `TipoCatalogo`, su
definición en `DefinicionesCatalogo`, su mapeo en `MapeosCatalogo` (con las
columnas de otras tablas que usan su código), y un formulario que implemente
`IFormularioCatalogo` con columnas `Id`, `Descripcion` y, si aplica, `Extra`.
Las pruebas fallan si falta la definición o el mapeo, si no coincide con el
esquema o si falta alguna referencia.

**Borrado de registros en uso.** El esquema PostgreSQL no tiene claves
foráneas (etapa 1b del plan). Mientras tanto, el repositorio revisa las
referencias declaradas en el mapeo antes de eliminar, igual que lo impedían
las claves foráneas del SQL Server original.

**Cuándo NO usar el componente genérico:** cuando el catálogo tiene más de
un campo adicional o reglas propias (por ejemplo `Motivo_Perm`, `Horario` o
`RRHH_Feriado`). Esos se migran con su propio presenter y caso de uso.

Ejemplo de una pantalla transaccional:

```csharp
// Presentación: contrato de la vista
public interface IPermisoView
{
    int? IdEmpleado { get; }
    DateTime Desde { get; }
    DateTime Hasta { get; }
    string Motivo { get; }

    event EventHandler GuardarSolicitado;

    void MostrarError(string mensaje);
    void MostrarExito(string mensaje);
    void Cerrar();
}

// Presentación: presenter sin dependencias de WinForms
public sealed class PermisoPresenter
{
    private readonly IPermisoView _view;
    private readonly RegistrarPermiso _registrarPermiso;

    public PermisoPresenter(IPermisoView view, RegistrarPermiso registrarPermiso)
    {
        _view = view ?? throw new ArgumentNullException(nameof(view));
        _registrarPermiso = registrarPermiso ?? throw new ArgumentNullException(nameof(registrarPermiso));
        _view.GuardarSolicitado += (_, _) => Guardar();
    }

    private void Guardar()
    {
        if (_view.IdEmpleado is not int idEmpleado)
        {
            _view.MostrarError("Seleccione un empleado.");
            return;
        }

        ResultadoOperacion resultado = _registrarPermiso.Ejecutar(
            new RegistrarPermisoDto(idEmpleado, _view.Desde, _view.Hasta, _view.Motivo));

        if (resultado.Exitoso) { _view.MostrarExito("Permiso registrado."); _view.Cerrar(); }
        else { _view.MostrarError(resultado.Mensaje); }
    }
}

// Aplicación: caso de uso
public sealed class RegistrarPermiso
{
    private readonly IPermisoRepository _permisos;

    public RegistrarPermiso(IPermisoRepository permisos) => _permisos = permisos;

    public ResultadoOperacion Ejecutar(RegistrarPermisoDto dto)
    {
        RangoFechas rango = RangoFechas.Crear(dto.Desde, dto.Hasta); // regla de dominio
        if (_permisos.ExisteEnRango(dto.IdEmpleado, rango))
            return ResultadoOperacion.Error("El empleado ya tiene un permiso en ese rango.");

        _permisos.Registrar(new Permiso(dto.IdEmpleado, rango, dto.Motivo));
        return ResultadoOperacion.Ok();
    }
}
```

## 5. Acceso a datos

1. **Solo PostgreSQL y solo mediante repositorios.** Cada repositorio
   implementa una interfaz definida en `RRHH.Application`.
2. **SQL siempre parametrizado.** Prohibido concatenar valores en SQL.
   Las fechas se pasan como `DateTime`, nunca como texto `yyyyMMdd`.
3. **Identificadores entre comillas dobles** tal como están en
   `BD/schema.sql` (`public."Empleado"`, `"IdEmpleado"`).
4. **Una conexión por operación** (`using`), obtenida de
   `PostgreSqlConnectionFactory`. Nada de conexiones o `DataContext`
   estáticos.
5. **Escrituras de varias tablas dentro de una transacción**
   (`PostgreSqlExecutor.InTransaction`).
6. **Los repositorios devuelven entidades o DTO tipados**, no `object`,
   `DataTable` ni `DataSet`. Excepción: consultas de reportes DevExpress,
   que pueden devolver `DataTable` desde una clase `XxxReportQuery`.
7. Al portar un procedimiento `spRRHH_*` o una consulta LINQ-to-SQL, el
   comentario XML del método indica qué reemplaza:
   `/// Reemplaza spRRHH_Faltas (SQL Server).`
8. La cadena de conexión solo viene de `RRHH_POSTGRES_CONNECTION`
   (o del almacén de secretos en servidores). Nunca en `app.config` ni en Git;
   `PostgreSqlConnectionFactory` no lee `app.config`.

## 6. Composition root

Las dependencias se crean a mano en un único lugar:
`RecursosHumanos/RecursosHumanos/CompositionRoot.cs`. No se usa contenedor de
inyección de dependencias mientras el sistema sea de este tamaño.

```csharp
internal static class CompositionRoot
{
    // Diferidas: si falta RRHH_POSTGRES_CONNECTION, el error real llega al
    // usuario y se puede reintentar.
    private static readonly Lazy<PostgreSqlConnectionFactory> Conexiones = ...;
    private static readonly Lazy<PostgreSqlExecutor> Database = ...;

    public static ObtenerAccesoUsuario CrearObtenerAccesoUsuario() =>
        new ObtenerAccesoUsuario(new PostgreSqlAccesoUsuarioRepository(Database.Value));

    public static TForm CrearCatalogo<TForm>(TipoCatalogo tipo)
        where TForm : Form, IFormularioCatalogo, new()
    {
        TForm form = new TForm();
        DefinicionCatalogo definicion = DefinicionesCatalogo.Definicion(tipo);
        ICatalogoRepository repository = new PostgreSqlCatalogoRepository(Database.Value, MapeosCatalogo.Para(tipo));
        _ = new CatalogoPresenter(form.Vista, definicion,
            new ListarCatalogo(repository),
            new GuardarItemCatalogo(definicion, repository),
            new EliminarItemCatalogo(repository));
        return form;
    }
}

// MainMDI
ObjMantCargo = CompositionRoot.CrearCatalogo<FrmMantCargos>(TipoCatalogo.Cargo);
```

El presenter queda vivo mientras viva el formulario, porque la vista guarda sus
manejadores de eventos. `MainMDI` abre las pantallas migradas solo a través de
`CompositionRoot`. No se agregan campos estáticos nuevos a `Module1`; solo
conserva `DcGrll` para el código heredado.

## 7. Estructura de carpetas y nombres

```
Software/
├─ RRHH.Domain/
│  └─ <Modulo>/            Permiso.cs, RangoFechas.cs
├─ RRHH.Application/
│  └─ <Modulo>/            RegistrarPermiso.cs, IPermisoRepository.cs, RegistrarPermisoDto.cs
├─ RRHH.PostgreSql/
│  └─ <Modulo>/            PostgreSqlPermisoRepository.cs
├─ RRHH.Presentation/
│  └─ <Modulo>/            IPermisoView.cs, PermisoPresenter.cs
├─ RecursosHumanos/RecursosHumanos/
│  ├─ CompositionRoot.cs
│  └─ Frm*.cs              Formularios (se quedan donde están)
└─ RRHH.Tests/
   ├─ <Modulo>/            RegistrarPermisoTests.cs, PermisoPresenterTests.cs
   └─ Fakes/               Repositorios y vistas falsos
```

Módulos: `Catalogos`, `Empleados`, `Asistencia`, `Permisos`, `FichaSocial`,
`Legajo` (estudios, experiencia, capacitaciones, documentos), `Reportes`,
`Seguridad`.

| Tipo | Convención | Ejemplo |
|---|---|---|
| Entidad | Sustantivo singular | `Permiso`, `Empleado` |
| Caso de uso | Verbo + sustantivo | `RegistrarPermiso`, `ListarCargos` |
| Interfaz de repositorio | `I` + entidad + `Repository` | `IPermisoRepository` |
| Repositorio | `PostgreSql` + entidad + `Repository` | `PostgreSqlPermisoRepository` |
| Vista | `I` + pantalla + `View` | `IPermisoView` |
| Presenter | Pantalla + `Presenter` | `PermisoPresenter` |
| Consulta de reporte | Reporte + `ReportQuery` | `FaltasReportQuery` |

El dominio se nombra en español, igual que la base de datos y la interfaz.
Los sufijos técnicos (`Repository`, `Presenter`, `View`, `Dto`) se mantienen
en inglés.

Los formularios heredados **no se renombran ni se mueven** al migrarlos: sus
`.resx` dependen del nombre del tipo. Si fuera imprescindible hacerlo, se
compila y se abre el formulario en el diseñador antes de integrar.

## 8. Procedimiento para migrar una pantalla

1. **Caracterizar:** registrar qué hace hoy (consultas, procedimientos,
   validaciones, mensajes) y, si es posible, capturar resultados conocidos
   del sistema original.
2. **Dominio:** extraer las reglas puras a `RRHH.Domain` con pruebas
   unitarias.
3. **Aplicación:** crear el caso de uso y la interfaz de repositorio.
4. **Infraestructura:** implementar el repositorio PostgreSQL parametrizado e
   indicar qué procedimiento o consulta reemplaza.
5. **Presentación:** crear `IXxxView` y `XxxPresenter`; vaciar el formulario
   hasta que solo implemente la vista.
6. **Conectar** la pantalla en `CompositionRoot` y abrirla desde `MainMDI`.
7. **Retirar** del formulario todo uso de `XxxMapper.Instance()`,
   `dcGRLLDataContext`, `RRHHClass`, `SqlConnection` y TableAdapters.
8. **Probar** contra PostgreSQL QA con datos ficticios o anonimizados.

Orden sugerido, de menor a mayor riesgo:

1. Catálogos simples ✔ (los 10 `FrmMant*` de código + descripción). Quedan los
   catálogos con reglas propias (`FrmMantHorarios`, `FrmMantMotivo`,
   `FrmMotivoPermiso`, `FrmFeriado`). El plan detallado está en
   [PLAN_REFACTORIZACION.md](PLAN_REFACTORIZACION.md).
2. Empleados (`FrmMantEmpleado_Basico`, `FrmBuscarPersona`).
3. Permisos y asistencia (`FrmPermiso`, `FrmHorarios`,
   `FrmImportarAsistencia*`). Para la importación de asistencia hay un refactor
   previo en [`../referencia/AsistenciaImport`](../referencia/README.md).
4. Legajo (estudios, experiencia, familiares, documentos).
5. Ficha social (`FrmFichaSocial`; se divide en varias vistas).
6. Reportes (`DataSet1`, `Report_*`, `XtraReport*`).

## 9. Definición de terminado (por pantalla)

- [ ] El formulario implementa `IXxxView` y no contiene SQL ni reglas.
- [ ] El presenter no referencia WinForms ni DevExpress.
- [ ] Las reglas de negocio están en `RRHH.Domain` y tienen pruebas.
- [ ] El repositorio usa solo SQL parametrizado sobre PostgreSQL.
- [ ] No quedan referencias a `GRLL.Common` (salvo controles visuales aún no
      reemplazados), `dcGRLLDataContext`, `RRHHClass`, `SqlClient` ni
      TableAdapters en esa pantalla.
- [ ] `scripts\build.cmd` compila con 0 errores y
      `dotnet test RRHH.Tests` pasa.
- [ ] Se probó contra PostgreSQL QA y el PR indica qué consulta o
      procedimiento reemplaza.

## 10. Fin de la migración

La arquitectura objetivo se alcanza cuando:

- `GRLL`, `ClassRRHH`, `DataSet1` y `System.Data.Linq` se eliminan de la
  solución;
- no queda ninguna referencia a `System.Data.SqlClient`;
- todos los formularios implementan una vista con su presenter;
- se cumplen los criterios de [POSTGRESQL_MIGRATION.md](POSTGRESQL_MIGRATION.md).

## 11. Herramientas de apoyo

El grafo de dependencias se genera localmente con
[graphify](https://github.com/safishamsi/graphify):

```powershell
graphify update Software
```

El resultado queda en `Software/graphify-out/` (está en `.gitignore`).
`GRAPH_REPORT.md` muestra los nodos más acoplados y sirve para medir el avance:
las conexiones de `dcGRLLDataContext` y `GenericMapper` deben bajar con cada
pantalla migrada.
