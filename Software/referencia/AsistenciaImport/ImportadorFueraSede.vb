' =====================================================================
' ImportadorFueraSede.vb
' ---------------------------------------------------------------------
' Implementación concreta para sedes externas ("Fuera de Sede").
' Reemplaza el método duplicado 'Access2SqlSEDE' y su formulario asociado.
' =====================================================================

Public Class ImportadorFueraSede
    Inherits ImportadorSedeBase

    Private _rutaArchivo As String = "FueraSede.mdb"

    Public Sub New()
    End Sub

    Public Sub New(rutaMdb As String)
        If Not String.IsNullOrWhiteSpace(rutaMdb) Then
            _rutaArchivo = rutaMdb
        End If
    End Sub

    Public Overrides ReadOnly Property NombreSede As String
        Get
            Return "Fuera de Sede"
        End Get
    End Property

    Public Overrides ReadOnly Property CadenaConexion As String
        Get
            Return $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={_rutaArchivo};Jet OLEDB:Database Password=<CLAVE_ACCESS>;"
        End Get
    End Property

End Class

