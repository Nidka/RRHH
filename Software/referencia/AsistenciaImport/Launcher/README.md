# Ejecutable independiente de importación

`AsistenciaImportLauncher.vbproj` compila una aplicación Windows Forms que abre
`FrmImportarAsistencia` y referencia el proyecto `AsistenciaImport.vbproj`.
El proyecto enlaza `../../RecursosHumanos.exe.config` como `App.config`, de modo
que el ejecutable use la misma clave de conexión configurada para RRHH.

En Windows con Visual Studio o MSBuild que admitan la sintaxis VB.NET del
proyecto y el paquete de destino de .NET Framework 4.0:

```text
msbuild AsistenciaImportLauncher.vbproj /p:Configuration=Release
```

El resultado esperado es `bin/Release/RRHH.AsistenciaImport.Launcher.exe`,
acompañado de `RRHH.AsistenciaImport.dll` y su archivo `.exe.config`.
Se selecciona `x86` porque el proveedor Jet OLE DB 4.0 es de 32 bits.

Este ejecutable abre el módulo de asistencia de forma independiente. No
reemplaza ni modifica el binario original `RecursosHumanos.exe`.
