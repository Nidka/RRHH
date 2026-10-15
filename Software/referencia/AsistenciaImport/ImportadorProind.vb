' =====================================================================
' ImportadorProind.vb
' ---------------------------------------------------------------------
' Implementación concreta para la sede PROIND.
' Reemplaza la variable hardcodeada 'BDProind' y el método 'Access2SqlPROIND'.
' =====================================================================

Public Class ImportadorProind
    Inherits ImportadorSedeBase

    Private _directorioBase As String = "C:\PROIND"

    Public Sub New()
    End Sub

    Public Sub New(directorioBase As String)
        If Not String.IsNullOrWhiteSpace(directorioBase) Then
            _directorioBase = directorioBase.TrimEnd("\"c)
        End If
    End Sub

    Public Overrides ReadOnly Property NombreSede As String
        Get
            Return "PROIND"
        End Get
    End Property

    Public Overrides ReadOnly Property CadenaConexion As String
        Get
            Return $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={_directorioBase}\Marcacion.mdb;Jet OLEDB:Database Password=<CLAVE_ACCESS>;"
        End Get
    End Property

End Class

