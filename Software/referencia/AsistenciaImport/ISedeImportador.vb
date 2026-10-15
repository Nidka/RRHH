' =====================================================================
' ISedeImportador.vb
' ---------------------------------------------------------------------
' Abstracción central del refactor bajo el Principio Abierto/Cerrado (OCP).
' Todo proceso que requiera importar asistencia desde una sede externa
' depende EXCLUSIVAMENTE de este contrato, sin acoplarse a ninguna
' implementación concreta ni a rutas hardcodeadas.
' =====================================================================

Imports System.Data.SqlClient

Public Interface ISedeImportador

    ''' <summary>
    ''' Nombre representativo de la sede para visualización en la UI.
    ''' </summary>
    ReadOnly Property NombreSede As String

    ''' <summary>
    ''' Cadena de conexión OLEDB propia hacia la base de datos local (Access/Marcacion.mdb).
    ''' Cada sede concreta encapsula sus credenciales y ubicación.
    ''' </summary>
    ReadOnly Property CadenaConexion As String

    ''' <summary>
    ''' Ejecuta el flujo completo de importación de asistencia y marcación
    ''' hacia la base de datos central de SQL Server para el rango de fechas especificado.
    ''' </summary>
    ''' <param name="fechaInicial">Fecha inicial del rango.</param>
    ''' <param name="fechaFinal">Fecha final del rango.</param>
    ''' <param name="forzar">Indica si se sobreescriben registros existentes.</param>
    ''' <param name="cnSql">Conexión activa a SQL Server (opcional; si es Nothing se usa la conexión por defecto).</param>
    ''' <returns>True si la importación finalizó correctamente; False en caso contrario.</returns>
    Function ImportarAsistencia(fechaInicial As Date,
                                fechaFinal As Date,
                                forzar As Boolean,
                                Optional cnSql As SqlConnection = Nothing) As Boolean

End Interface

