# Aplicación del Refactor OCP en el Proyecto Original (RRHH)

Este módulo contiene la refactorización arquitectónica aplicada al sistema de **Recursos Humanos (RRHH)**, específicamente sobre el componente de **Importación de Asistencia**, en cumplimiento del **Principio Abierto/Cerrado (OCP - Open/Closed Principle)** de SOLID.

---

## 1. Diagnóstico del Código Original

A partir de la decompilación CIL de los ensamblados originales (`ClassRRHH.dll` y `RecursosHumanos.exe`), se identificaron las siguientes violaciones de diseño:

| Aspecto | Implementación Original (Legacy) | Problema de Diseño |
|---|---|---|
| **Cadenas de Conexión** | Variables públicas en la clase: `BD`, `BDProind`, `BDConsejo`. | Acoplamiento rígido de rutas y credenciales en una clase general. |
| **Métodos de Importación** | 4 métodos duplicados: `Access2Sql`, `Access2SqlSEDE`, `Access2SqlPROIND`, `Access2SqlCONSEJO`. | Mismo algoritmo duplicado 4 veces (lectura de `asis_norm` y `marcacion`, ejecución de `SpRRHH_Asistencia_Import` y `SpRRHH_Marcacion_Import`). |
| **Interfaz de Usuario** | 4 formularios casi idénticos: `FrmImportarAsistencia`, `FrmImportarAsistenciaFueraSEDE`, `FrmImportarAsistenciaPROIND`, `FrmImportarAsistenciaCONSEJO`. | Duplicación masiva de código de interfaz y eventos. |
| **Extensibilidad (OCP)** | Para agregar una nueva sede (ej. *Filial Norte*), era obligatorio: 1) modificar `AsistenciaAccess`, 2) crear un nuevo campo, 3) copiar y pegar un método de 780 bytes, 4) crear un nuevo formulario. | **Viola OCP**: La clase no estaba cerrada para modificación. |

---

## 2. Solución Aplicada (Refactor OCP)

Se implementó una arquitectura basada en **abstracción**, **herencia controlada** y **Factory Method**:

```
RRHH_extracted/RRHH/AsistenciaImport/
├── ISedeImportador.vb                   <-- Contrato abstracto (Cerrado)
├── ImportadorSedeBase.vb                <-- Lógica común y real de importación (Cerrada)
├── ImportadorSedePrincipal.vb           <-- Extensión: Sede Principal
├── ImportadorFueraSede.vb               <-- Extensión: Fuera de Sede
├── ImportadorProind.vb                  <-- Extensión: Sede PROIND
├── ImportadorConsejo.vb                 <-- Extensión: Sede CONSEJO
├── TipoSede.vb                          <-- Enumeración de sedes
├── SedeImportadorFactory.vb             <-- Patrón Factory Method
├── AsistenciaAccess.vb                  <-- Clase fachada cerrada + compatibilidad legacy
├── AsistenciaAccess_Original_Legacy.vb  <-- Archivo testigo del código decompilado original
├── FrmImportarAsistencia.vb             <-- Formulario unificado con BackgroundWorker
├── FrmImportarAsistencia.Designer.vb    <-- Diseño visual del formulario
└── AsistenciaImport.vbproj              <-- Proyecto .NET listo para compilar
```

---

## 3. Matriz de Transformación

| Componente | Antes (Original) | Después (Refactor OCP) |
|---|---|---|
| Contrato | Ninguno. Llamadas directas acopladas a la clase concreta. | Interfaz `ISedeImportador`. |
| Lógica de Importación | Copiada en 4 métodos dentro de `AsistenciaAccess`. | Unificada en `ImportadorSedeBase.vb` ejecutando las consultas reales a Access y SQL Server. |
| Configuración de Sede | Hardcodeada en atributos públicos. | Encapsulada en cada clase hija (`Importador*`). |
| Creación de Instancias | `New AsistenciaAccess()` + seteo manual de variables. | `SedeImportadorFactory.Crear(TipoSede)`. |
| Formularios UI | 4 formularios redundantes en `RecursosHumanos.exe`. | 1 formulario dinámico (`FrmImportarAsistencia`) con selector de sede. |
| Agregar Sede Nueva | Modificar código probado existente. | Crear una nueva clase heredando de `ImportadorSedeBase` sin alterar lo anterior. |

---

## 4. Guía de Extensión: ¿Cómo agregar una nueva sede? (Ej. "Filial Norte")

1. **Paso 1**: Registrar la sede en el enum [TipoSede.vb](TipoSede.vb):
   ```vb
   Public Enum TipoSede
       Principal = 1
       FueraSede = 2
       Proind = 3
       Consejo = 4
       FilialNorte = 5  ' <-- Nueva adición
   End Enum
   ```

2. **Paso 2**: Crear la clase concreta `ImportadorFilialNorte.vb`:
   ```vb
   Public Class ImportadorFilialNorte
       Inherits ImportadorSedeBase

       Public Overrides ReadOnly Property NombreSede As String = "Filial Norte"
       Public Overrides ReadOnly Property CadenaConexion As String =
           "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\FilialNorte\Marcacion.mdb;Jet OLEDB:Database Password=<CLAVE_ACCESS>;"
   End Class
   ```

3. **Paso 3**: Registrar en [SedeImportadorFactory.vb](SedeImportadorFactory.vb):
   ```vb
   Case TipoSede.FilialNorte
       Return New ImportadorFilialNorte()
   ```

**Resultado:** Ningún archivo que contenga la lógica de extracción o inserción (`ImportadorSedeBase`, `AsistenciaAccess`, `FrmImportarAsistencia`) necesita ser modificado ni recompilado. El sistema es **Abierto a la extensión, Cerrado a la modificación**.

