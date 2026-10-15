# Código de referencia

Material que **no forma parte de `RRHH.sln`** ni se compila con el proyecto.
Se conserva como apoyo para migrar pantallas a la arquitectura MVP
(ver [`../docs/ARQUITECTURA.md`](../docs/ARQUITECTURA.md)).

## AsistenciaImport

Refactor previo, en VB.NET para .NET Framework 4.0, de la importación de
asistencia desde los relojes de marcación (bases Access `Marcacion.mdb`) hacia
SQL Server. Aplica el principio abierto/cerrado (OCP) con una interfaz
`ISedeImportador`, una clase base común y una fábrica por sede. Así reemplaza
los cuatro formularios duplicados de `RecursosHumanos`:

- `FrmImportarAsistencia`
- `FrmImportarAsistenciaFueraSEDE`
- `FrmImportarAsistenciaPROIND`
- `FrmImportarAsistenciaCONSEJO`

El detalle está en [`AsistenciaImport/README_REFACTOR_OCP.md`](AsistenciaImport/README_REFACTOR_OCP.md).

### Cómo usarlo al migrar

- **Se reutiliza la idea:** una sola pantalla con selector de sede y un
  importador por sede. En la arquitectura actual, `ISedeImportador` y la
  fábrica van en `RRHH.Application`. Los importadores que leen Access y el
  repositorio PostgreSQL van en la infraestructura.
- **No se reutiliza tal cual:**
  - escribe en SQL Server mediante `SpRRHH_Asistencia_Import` y
    `SpRRHH_Marcacion_Import`, que no existen en PostgreSQL;
  - está en VB.NET 4.0, mientras la solución es C# para .NET Framework 4.8;
  - el formulario contiene lógica, así que no es una vista pasiva.
- `AsistenciaAccess_Original_Legacy.vb` es el código descompilado original y
  sirve para comparar el comportamiento antiguo con el migrado.

### Seguridad

Las claves de las bases Access se reemplazaron por `<CLAVE_ACCESS>`. Al
migrar, la clave debe leerse de configuración local o de una variable de
entorno, nunca escribirse en el código. El lanzador (`Launcher/`) espera un
`RecursosHumanos.exe.config` que no se versiona, porque el original contiene
credenciales.
