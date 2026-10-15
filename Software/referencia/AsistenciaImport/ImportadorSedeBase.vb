' =====================================================================
' ImportadorSedeBase.vb
' ---------------------------------------------------------------------
' Clase base abstracta que centraliza la lógica de negocio real
' extraída y unificada de los 4 métodos originales (Access2Sql,
' Access2SqlSEDE, Access2SqlPROIND, Access2SqlCONSEJO).
'
' Cumple OCP: La lógica de extracción (OleDb/Access) y carga (SQL Server)
' vive en un único punto cerrado para modificación. Las nuevas sedes
' solo aportan su nombre y cadena de conexión sin alterar este algoritmo.
' =====================================================================

Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient

Public MustInherit Class ImportadorSedeBase
    Implements ISedeImportador

    Public MustOverride ReadOnly Property NombreSede As String Implements ISedeImportador.NombreSede
    Public MustOverride ReadOnly Property CadenaConexion As String Implements ISedeImportador.CadenaConexion

    ''' <summary>
    ''' Ejecuta el flujo completo de importación para la sede actual.
    ''' </summary>
    Public Overridable Function ImportarAsistencia(fechaInicial As Date,
                                                  fechaFinal As Date,
                                                  forzar As Boolean,
                                                  Optional cnSql As SqlConnection = Nothing) As Boolean _
        Implements ISedeImportador.ImportarAsistencia

        If fechaInicial.Date > fechaFinal.Date Then
            Throw New ArgumentException("La fecha inicial no puede ser posterior a la fecha final.")
        End If

        ' 1. Conexión de lectura hacia la base de datos local en Access (.mdb)
        Using oCnAccess As New OleDbConnection(CadenaConexion)
            Try
                If oCnAccess.State <> ConnectionState.Open Then
                    oCnAccess.Open()
                End If

                ' Si no se suministró una conexión activa a SQL Server, se crea una
                ' utilizando la configuración estándar de la aplicación
                Dim gestionarCnSql As Boolean = (cnSql Is Nothing)
                Dim sqlConnection As SqlConnection = If(cnSql, ObtenerConexionSqlPorDefecto())

                Try
                    If sqlConnection.State <> ConnectionState.Open Then
                        sqlConnection.Open()
                    End If

                    ' ---------------------------------------------------------
                    ' PASO 1: Importación de Asistencias (asis_norm + empleado)
                    ' ---------------------------------------------------------
                    Dim queryAsistencia As String =
                        "select e.pers_DNI, a.fec_asi, a.hor_ent, a.hor_sal, a.alm_ent, a.alm_sal, a.idhorario, a.estado " &
                        "from empleado e inner join asis_norm a on e.pers_cod=a.pers_cod " &
                        "where a.fec_asi >= ? and a.fec_asi < ?"

                    ' ---------------------------------------------------------
                    ' PASO 2: Importación de Marcaciones (marcacion)
                    ' ---------------------------------------------------------
                    Dim queryMarcacion As String =
                        "select Valor, Fecha, Estado, Lugar from marcacion " &
                        "where Fecha >= ? and Fecha < ? order by Fecha"

                    ' Una transacción cubre las dos fases de la importación.
                    Using tx As SqlTransaction = sqlConnection.BeginTransaction()
                        Try
                            EjecutarComandosLote(oCnAccess, queryAsistencia, "SpRRHH_Asistencia_Import", 8,
                                                 fechaInicial.Date, fechaFinal.Date.AddDays(1), forzar, sqlConnection, tx)
                            EjecutarComandosLote(oCnAccess, queryMarcacion, "SpRRHH_Marcacion_Import", 4,
                                                 fechaInicial.Date, fechaFinal.Date.AddDays(1), forzar, sqlConnection, tx)
                            tx.Commit()
                        Catch
                            tx.Rollback()
                            Throw
                        End Try
                    End Using

                    Return True

                Finally
                    If gestionarCnSql AndAlso sqlConnection IsNot Nothing Then
                        If sqlConnection.State = ConnectionState.Open Then
                            sqlConnection.Close()
                        End If
                        sqlConnection.Dispose()
                    End If
                End Try

            Catch ex As Exception
                Throw New ApplicationException($"[OCP] Error al importar asistencia de la sede '{NombreSede}': {ex.Message}", ex)
            Finally
                If oCnAccess.State = ConnectionState.Open Then
                    oCnAccess.Close()
                End If
            End Try
        End Using

    End Function

    ''' <summary>
    ''' Lee datos de Access y llama al procedimiento SQL con valores parametrizados.
    ''' </summary>
    Private Sub EjecutarComandosLote(oCnAccess As OleDbConnection, queryOleDb As String,
                                    procedimiento As String, cantidadCampos As Integer,
                                    fechaInicial As Date, fechaFinalExclusiva As Date,
                                    forzar As Boolean, cnSql As SqlConnection, tx As SqlTransaction)
        Using consulta As New OleDbCommand(queryOleDb, oCnAccess)
            consulta.Parameters.Add("@inicio", OleDbType.Date).Value = fechaInicial
            consulta.Parameters.Add("@fin", OleDbType.Date).Value = fechaFinalExclusiva

            Using lector As OleDbDataReader = consulta.ExecuteReader()
                Dim nombres As New List(Of String)()
                For i As Integer = 0 To cantidadCampos
                    nombres.Add("@p" & i.ToString())
                Next

                Using cmd As New SqlCommand("EXEC " & procedimiento & " " & String.Join(", ", nombres.ToArray()), cnSql, tx)
                    While lector.Read()
                        cmd.Parameters.Clear()
                        For i As Integer = 0 To cantidadCampos - 1
                            Dim valor As Object = If(lector.IsDBNull(i), CType(DBNull.Value, Object), lector.GetValue(i))
                            cmd.Parameters.AddWithValue(nombres(i), valor)
                        Next
                        cmd.Parameters.Add(nombres(cantidadCampos), SqlDbType.Int).Value = If(forzar, 1, 0)
                        cmd.ExecuteNonQuery()
                    End While
                End Using
            End Using
        End Using
    End Sub

    ''' <summary>
    ''' Proveedor de conexión SQL por defecto para escenarios donde no se inyecta
    ''' externamente.
    ''' </summary>
    Protected Overridable Function ObtenerConexionSqlPorDefecto() As SqlConnection
        ' Se puede tomar del archivo de configuración App.config / RecursosHumanos.exe.config
        Dim configuracion = System.Configuration.ConfigurationManager.ConnectionStrings("RecursosHumanos.My.MySettings.CMIConnectionString")
        If configuracion Is Nothing OrElse String.IsNullOrWhiteSpace(configuracion.ConnectionString) Then
            Throw New InvalidOperationException("Falta la conexión RecursosHumanos.My.MySettings.CMIConnectionString en la configuración.")
        End If
        Return New SqlConnection(configuracion.ConnectionString)
    End Function

End Class
