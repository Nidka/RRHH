' =====================================================================
' AsistenciaAccess_Original_Legacy.vb  (CÓDIGO ORIGINAL DECOMPILADO)
' ---------------------------------------------------------------------
' Este archivo es una transcripción fiel del código original extraído
' del desensamblado CIL de ClassRRHH.dll.
' Muestra con claridad las violaciones al Principio Abierto/Cerrado (OCP):
'   1. Campos hardcodeados por sede (BD, BDProind, BDConsejo).
'   2. 4 métodos duplicados con exactamente el mismo algoritmo.
'   3. Alta rigidez y fragilidad ante nuevos requerimientos.
' =====================================================================

Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient

Namespace Legacy

    Public Class AsistenciaAccess_Original

        ' Campos originales extraídos del binario
        Public BD As String
        Public BDProind As String
        Public BDConsejo As String
        Public oCnAccess As OleDbConnection
        Public oCnAccessAlt As OleDbConnection
        Private _SEDE As String
        Protected oCn As SqlConnection

        Public Property SEDE As String
            Get
                Return _SEDE
            End Get
            Set(value As String)
                _SEDE = value
            End Set
        End Property

        Public Sub New()
            oCnAccess = New OleDbConnection()
            oCnAccessAlt = New OleDbConnection()
        End Sub

        ' -----------------------------------------------------------------
        ' MÉTODO 1: Sede Principal (Original)
        ' -----------------------------------------------------------------
        Public Function Access2Sql(fechaInicial As Date, fechaFinal As Date, forzar As Boolean) As Boolean
            oCnAccess.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & BD & ";Jet OLEDB:Database Password=<CLAVE_ACCESS>;"
            If oCnAccess.State = ConnectionState.Closed Then
                oCnAccess.Open()
            End If

            Dim sqlQuery As String = "select 'Exec SpRRHH_Asistencia_Import '&''''&e.pers_DNI&''', '''&a.fec_asi&''', '''&a.hor_ent&''', '''&a.hor_sal&''', '''&a.alm_ent&''', '''&a.alm_sal&''','''&a.idhorario& ''' ,  '''&a.estado& ''' , " &
                If(forzar, "1", "0") & "' from empleado e inner join asis_norm a on e.pers_cod=a.pers_cod where a.fec_asi >= '" &
                fechaInicial.ToString("yyyy-MM-dd") & "' and a.fec_asi <= '" & fechaFinal.ToString("yyyy-MM-dd") & "'"

            Dim da As New OleDbDataAdapter(sqlQuery, oCnAccess)
            Dim ds As New DataSet()
            da.Fill(ds)

            If oCn.State = ConnectionState.Closed Then
                oCn.Open()
            End If

            For Each dr As DataRow In ds.Tables(0).Rows
                Dim cmd As New SqlCommand(dr(0).ToString(), oCn)
                cmd.ExecuteNonQuery()
            Next

            Dim sqlMarcacion As String = "select 'Exec SpRRHH_Marcacion_Import '''&Valor&''', '''&Fecha&''', '''&Estado&''', '''&Lugar&''' , " &
                If(forzar, "1", "0") & "' from marcacion where Fecha >= '" &
                fechaInicial.ToString("yyyy-MM-dd") & " 00:00:00' and Fecha < '" & fechaFinal.ToString("yyyy-MM-dd") & " 23:59:59' order by Fecha"

            Dim da2 As New OleDbDataAdapter(sqlMarcacion, oCnAccess)
            Dim ds2 As New DataSet()
            da2.Fill(ds2)

            For Each dr2 As DataRow In ds2.Tables(0).Rows
                Dim cmd2 As New SqlCommand(dr2(0).ToString(), oCn)
                cmd2.ExecuteNonQuery()
            Next

            Return True
        End Function

        ' -----------------------------------------------------------------
        ' MÉTODO 2: Fuera de Sede (Duplicado)
        ' -----------------------------------------------------------------
        Public Function Access2SqlSEDE(fechaInicial As Date, fechaFinal As Date, forzar As Boolean) As Boolean
            ' Idéntica lógica que Access2Sql utilizando oCnAccessAlt
            If oCnAccessAlt.State = ConnectionState.Closed Then
                oCnAccessAlt.Open()
            End If

            Dim sqlQuery As String = "select 'Exec SpRRHH_Asistencia_Import '&''''&e.pers_DNI&''', '''&a.fec_asi&''', '''&a.hor_ent&''', '''&a.hor_sal&''', '''&a.alm_ent&''', '''&a.alm_sal&''', '''&a.idhorario& ''' , '''&a.estado& ''' , " &
                If(forzar, "1", "0") & "' from empleado e inner join asis_norm a on e.pers_cod=a.pers_cod where a.fec_asi >= '" &
                fechaInicial.ToString("yyyy-MM-dd") & "' and a.fec_asi <= '" & fechaFinal.ToString("yyyy-MM-dd") & "'"

            Dim da As New OleDbDataAdapter(sqlQuery, oCnAccessAlt)
            Dim ds As New DataSet()
            da.Fill(ds)

            If oCn.State = ConnectionState.Closed Then
                oCn.Open()
            End If

            For Each dr As DataRow In ds.Tables(0).Rows
                Dim cmd As New SqlCommand(dr(0).ToString(), oCn)
                cmd.ExecuteNonQuery()
            Next

            Dim sqlMarcacion As String = "select 'Exec SpRRHH_Marcacion_Import '''&Valor&''', '''&Fecha&''', '''&Estado&''', '''&Lugar&''' , " &
                If(forzar, "1", "0") & "' from marcacion where Fecha >= '" &
                fechaInicial.ToString("yyyy-MM-dd") & " 00:00:00' and Fecha < '" & fechaFinal.ToString("yyyy-MM-dd") & " 23:59:59' order by Fecha"

            Dim da2 As New OleDbDataAdapter(sqlMarcacion, oCnAccessAlt)
            Dim ds2 As New DataSet()
            da2.Fill(ds2)

            For Each dr2 As DataRow In ds2.Tables(0).Rows
                Dim cmd2 As New SqlCommand(dr2(0).ToString(), oCn)
                cmd2.ExecuteNonQuery()
            Next

            Return True
        End Function

        ' -----------------------------------------------------------------
        ' MÉTODO 3: PROIND (Duplicado)
        ' -----------------------------------------------------------------
        Public Function Access2SqlPROIND(fechaInicial As Date, fechaFinal As Date, forzar As Boolean) As Boolean
            oCnAccess.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & BDProind & "\Marcacion.mdb;Jet OLEDB:Database Password=<CLAVE_ACCESS>;"
            If oCnAccess.State = ConnectionState.Closed Then
                oCnAccess.Open()
            End If

            Dim sqlQuery As String = "select 'Exec SpRRHH_Asistencia_Import '&''''&e.pers_DNI&''', '''&a.fec_asi&''', '''&a.hor_ent&''', '''&a.hor_sal&''', '''&a.alm_ent&''', '''&a.alm_sal&''','''&a.idhorario& ''' , '''&a.estado& ''' , " &
                If(forzar, "1", "0") & "' from empleado e inner join asis_norm a on e.pers_cod=a.pers_cod where a.fec_asi >= '" &
                fechaInicial.ToString("yyyy-MM-dd") & "' and a.fec_asi <= '" & fechaFinal.ToString("yyyy-MM-dd") & "'"

            Dim da As New OleDbDataAdapter(sqlQuery, oCnAccess)
            Dim ds As New DataSet()
            da.Fill(ds)

            If oCn.State = ConnectionState.Closed Then
                oCn.Open()
            End If

            For Each dr As DataRow In ds.Tables(0).Rows
                Dim cmd As New SqlCommand(dr(0).ToString(), oCn)
                cmd.ExecuteNonQuery()
            Next

            Dim sqlMarcacion As String = "select 'Exec SpRRHH_Marcacion_Import '''&Valor&''', '''&Fecha&''', '''&Estado&''', '''&Lugar&''' , " &
                If(forzar, "1", "0") & "' from marcacion where Fecha >= '" &
                fechaInicial.ToString("yyyy-MM-dd") & " 00:00:00' and Fecha < '" & fechaFinal.ToString("yyyy-MM-dd") & " 23:59:59' order by Fecha"

            Dim da2 As New OleDbDataAdapter(sqlMarcacion, oCnAccess)
            Dim ds2 As New DataSet()
            da2.Fill(ds2)

            For Each dr2 As DataRow In ds2.Tables(0).Rows
                Dim cmd2 As New SqlCommand(dr2(0).ToString(), oCn)
                cmd2.ExecuteNonQuery()
            Next

            Return True
        End Function

        ' -----------------------------------------------------------------
        ' MÉTODO 4: CONSEJO (Duplicado)
        ' -----------------------------------------------------------------
        Public Function Access2SqlCONSEJO(fechaInicial As Date, fechaFinal As Date, forzar As Boolean) As Boolean
            oCnAccess.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & BDConsejo & "\Marcacion.mdb;Jet OLEDB:Database Password=<CLAVE_ACCESS>;"
            If oCnAccess.State = ConnectionState.Closed Then
                oCnAccess.Open()
            End If

            Dim sqlQuery As String = "select 'Exec SpRRHH_Asistencia_Import '&''''&e.pers_DNI&''', '''&a.fec_asi&''', '''&a.hor_ent&''', '''&a.hor_sal&''', '''&a.alm_ent&''', '''&a.alm_sal&''','''&a.idhorario& ''' , '''&a.estado& ''' , " &
                If(forzar, "1", "0") & "' from empleado e inner join asis_norm a on e.pers_cod=a.pers_cod where a.fec_asi >= '" &
                fechaInicial.ToString("yyyy-MM-dd") & "' and a.fec_asi <= '" & fechaFinal.ToString("yyyy-MM-dd") & "'"

            Dim da As New OleDbDataAdapter(sqlQuery, oCnAccess)
            Dim ds As New DataSet()
            da.Fill(ds)

            If oCn.State = ConnectionState.Closed Then
                oCn.Open()
            End If

            For Each dr As DataRow In ds.Tables(0).Rows
                Dim cmd As New SqlCommand(dr(0).ToString(), oCn)
                cmd.ExecuteNonQuery()
            Next

            Dim sqlMarcacion As String = "select 'Exec SpRRHH_Marcacion_Import '''&Valor&''', '''&Fecha&''', '''&Estado&''', '''&Lugar&''' , " &
                If(forzar, "1", "0") & "' from marcacion where Fecha >= '" &
                fechaInicial.ToString("yyyy-MM-dd") & " 00:00:00' and Fecha < '" & fechaFinal.ToString("yyyy-MM-dd") & " 23:59:59' order by Fecha"

            Dim da2 As New OleDbDataAdapter(sqlMarcacion, oCnAccess)
            Dim ds2 As New DataSet()
            da2.Fill(ds2)

            For Each dr2 As DataRow In ds2.Tables(0).Rows
                Dim cmd2 As New SqlCommand(dr2(0).ToString(), oCn)
                cmd2.ExecuteNonQuery()
            Next

            Return True
        End Function

    End Class

End Namespace

