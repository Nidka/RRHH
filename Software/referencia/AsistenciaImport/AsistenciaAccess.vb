' =====================================================================
' AsistenciaAccess.vb  (VERSIÓN REFACTORIZADA - OCP)
' ---------------------------------------------------------------------
' Estado anterior:
'   - 3 variables públicas hardcodeadas (BD, BDProind, BDConsejo).
'   - 4 métodos casi idénticos (Access2Sql, Access2SqlSEDE, Access2SqlPROIND, Access2SqlCONSEJO).
'   - Violaba OCP: cualquier sede nueva obligaba a modificar esta clase.
'
' Estado actual (Refactor OCP):
'   - Esta clase queda CERRADA para modificación.
'   - Delega la lógica de negocio en la abstracción ISedeImportador.
'   - Conserva métodos de retrocompatibilidad marcados como [Obsolete]
'     para no quebrar clientes legacy, delegando internamente a la fábrica.
' =====================================================================

Imports System
Imports System.Data.SqlClient

Public Class AsistenciaAccess
    Implements IAsistenciaService

    ''' <summary>
    ''' Método principal bajo el principio OCP.
    ''' Recibe cualquier implementación de ISedeImportador sin conocer sus detalles internos.
    ''' </summary>
    Public Function Access2Sql(importador As ISedeImportador,
                               fechaInicial As Date,
                               fechaFinal As Date,
                               forzar As Boolean,
                               Optional cnSql As SqlConnection = Nothing) As Boolean Implements IAsistenciaService.Access2Sql

        If importador Is Nothing Then
            Throw New ArgumentNullException(NameOf(importador), "Debe suministrarse una instancia válida de ISedeImportador.")
        End If

        Return importador.ImportarAsistencia(fechaInicial, fechaFinal, forzar, cnSql)

    End Function

    ' =================================================================
    ' CAPA DE COMPATIBILIDAD HACIA ATRÁS (LEGACY OVERLOADS)
    ' Permite que cualquier módulo existente continúe funcionando sin fallas
    ' =================================================================

    <Obsolete("Utilice la sobrecarga que recibe ISedeImportador o SedeImportadorFactory.")>
    Public Function Access2Sql(fechaInicial As Date, fechaFinal As Date, forzar As Boolean) As Boolean
        Dim importador As ISedeImportador = SedeImportadorFactory.Crear(TipoSede.Principal)
        Return Access2Sql(importador, fechaInicial, fechaFinal, forzar)
    End Function

    <Obsolete("Utilice la sobrecarga que recibe ISedeImportador o SedeImportadorFactory.")>
    Public Function Access2SqlSEDE(fechaInicial As Date, fechaFinal As Date, forzar As Boolean) As Boolean
        Dim importador As ISedeImportador = SedeImportadorFactory.Crear(TipoSede.FueraSede)
        Return Access2Sql(importador, fechaInicial, fechaFinal, forzar)
    End Function

    <Obsolete("Utilice la sobrecarga que recibe ISedeImportador o SedeImportadorFactory.")>
    Public Function Access2SqlPROIND(fechaInicial As Date, fechaFinal As Date, forzar As Boolean) As Boolean
        Dim importador As ISedeImportador = SedeImportadorFactory.Crear(TipoSede.Proind)
        Return Access2Sql(importador, fechaInicial, fechaFinal, forzar)
    End Function

    <Obsolete("Utilice la sobrecarga que recibe ISedeImportador o SedeImportadorFactory.")>
    Public Function Access2SqlCONSEJO(fechaInicial As Date, fechaFinal As Date, forzar As Boolean) As Boolean
        Dim importador As ISedeImportador = SedeImportadorFactory.Crear(TipoSede.Consejo)
        Return Access2Sql(importador, fechaInicial, fechaFinal, forzar)
    End Function

End Class
