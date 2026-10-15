' =====================================================================
' ImportadorConsejo.vb
' ---------------------------------------------------------------------
' Implementación concreta para la sede CONSEJO.
' Reemplaza la variable hardcodeada 'BDConsejo' y el método 'Access2SqlCONSEJO'.
' =====================================================================

Public Class ImportadorConsejo
    Inherits ImportadorSedeBase

    Private _directorioBase As String = "C:\CONSEJO"

    Public Sub New()
    End Sub

    Public Sub New(directorioBase As String)
        If Not String.IsNullOrWhiteSpace(directorioBase) Then
            _directorioBase = directorioBase.TrimEnd("\"c)
        End If
    End Sub

    Public Overrides ReadOnly Property NombreSede As String
        Get
            Return "Consejo"
        End Get
    End Property

    Public Overrides ReadOnly Property CadenaConexion As String
        Get
            Return $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={_directorioBase}\Marcacion.mdb;Jet OLEDB:Database Password=<CLAVE_ACCESS>;"
        End Get
    End Property

End Class

