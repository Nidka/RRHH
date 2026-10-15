' =====================================================================
' SedeImportadorFactory.vb
' ---------------------------------------------------------------------
' Patrón Factory Method: Punto único y centralizado responsable de
' instanciar el importador correspondiente según la sede solicitada.
' Esto aísla la UI y el resto de la aplicación de la instanciación directa
' de clases concretas.
' =====================================================================

Imports System

Public Class SedeImportadorFactory

    ''' <summary>
    ''' Fabrica e inicializa la instancia adecuada de ISedeImportador.
    ''' </summary>
    ''' <param name="tipoSede">Tipo de sede requerida.</param>
    ''' <param name="rutaPersonalizada">Ruta opcional al archivo .mdb o directorio base.</param>
    Public Shared Function Crear(tipoSede As TipoSede, Optional rutaPersonalizada As String = Nothing) As ISedeImportador
        Select Case tipoSede
            Case TipoSede.Principal
                If Not String.IsNullOrWhiteSpace(rutaPersonalizada) Then
                    Return New ImportadorSedePrincipal(rutaPersonalizada)
                End If
                Return New ImportadorSedePrincipal()

            Case TipoSede.FueraSede
                If Not String.IsNullOrWhiteSpace(rutaPersonalizada) Then
                    Return New ImportadorFueraSede(rutaPersonalizada)
                End If
                Return New ImportadorFueraSede()

            Case TipoSede.Proind
                If Not String.IsNullOrWhiteSpace(rutaPersonalizada) Then
                    Return New ImportadorProind(rutaPersonalizada)
                End If
                Return New ImportadorProind()

            Case TipoSede.Consejo
                If Not String.IsNullOrWhiteSpace(rutaPersonalizada) Then
                    Return New ImportadorConsejo(rutaPersonalizada)
                End If
                Return New ImportadorConsejo()

            Case Else
                Throw New NotSupportedException($"La sede '{tipoSede}' no se encuentra registrada en la fábrica de importadores.")
        End Select
    End Function

End Class

