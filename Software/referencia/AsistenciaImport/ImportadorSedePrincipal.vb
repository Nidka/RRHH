' =====================================================================
' ImportadorSedePrincipal.vb
' ---------------------------------------------------------------------
' Implementación concreta para la Sede Principal.
' Reemplaza la variable hardcodeada 'BD' y el método 'Access2Sql' de la
' clase original AsistenciaAccess.
' =====================================================================

Public Class ImportadorSedePrincipal
    Inherits ImportadorSedeBase

    Private _rutaArchivo As String = "Principal.mdb"

    Public Sub New()
    End Sub

    Public Sub New(rutaMdb As String)
        If Not String.IsNullOrWhiteSpace(rutaMdb) Then
            _rutaArchivo = rutaMdb
        End If
    End Sub

    Public Overrides ReadOnly Property NombreSede As String
        Get
            Return "Sede Principal"
        End Get
    End Property

    Public Overrides ReadOnly Property CadenaConexion As String
        Get
            Return $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={_rutaArchivo};Jet OLEDB:Database Password=<CLAVE_ACCESS>;"
        End Get
    End Property

End Class

