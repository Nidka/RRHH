# Anexo 3D. Referencia Visual Basic fuera de la solución principal

[Volver a acceso a datos](03_acceso_datos.md). Estos 14 VB y dos vbproj están en Software/referencia/AsistenciaImport; no constituyen funcionalidad integrada en RRHH.sln. Se inspeccionaron como referencia y no sustituyen AsistenciaAccess.cs actual.


## Software/referencia/AsistenciaImport/TipoSede.vb

[Software/referencia/AsistenciaImport/TipoSede.vb:1](../../Software/referencia/AsistenciaImport/TipoSede.vb#L1)

No se encontró SQL literal dentro de rutinas en este archivo; las responsabilidades y referencias se observan en su fuente. [Software/referencia/AsistenciaImport/TipoSede.vb:1](../../Software/referencia/AsistenciaImport/TipoSede.vb#L1)

## Software/referencia/AsistenciaImport/ImportadorProind.vb

[Software/referencia/AsistenciaImport/ImportadorProind.vb:1](../../Software/referencia/AsistenciaImport/ImportadorProind.vb#L1)

No se encontró SQL literal dentro de rutinas en este archivo; las responsabilidades y referencias se observan en su fuente. [Software/referencia/AsistenciaImport/ImportadorProind.vb:1](../../Software/referencia/AsistenciaImport/ImportadorProind.vb#L1)

## Software/referencia/AsistenciaImport/FrmImportarAsistencia.vb

[Software/referencia/AsistenciaImport/FrmImportarAsistencia.vb:1](../../Software/referencia/AsistenciaImport/FrmImportarAsistencia.vb#L1)


### Rutina con SQL

[Software/referencia/AsistenciaImport/FrmImportarAsistencia.vb:59](../../Software/referencia/AsistenciaImport/FrmImportarAsistencia.vb#L59)
```vb

    Private Sub cboSede_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSede.SelectedIndexChanged
        Dim item As ItemSede = TryCast(cboSede.SelectedItem, ItemSede)
        If item IsNot Nothing Then
            Select Case item.Tipo
                Case TipoSede.Principal
                    txtRuta.Text = "Principal.mdb"
                Case TipoSede.FueraSede
                    txtRuta.Text = "FueraSede.mdb"
                Case TipoSede.Proind
                    txtRuta.Text = "C:\PROIND"
                Case TipoSede.Consejo
                    txtRuta.Text = "C:\CONSEJO"
            End Select
        End If
    End Sub
```

## Software/referencia/AsistenciaImport/ImportadorSedeBase.vb

[Software/referencia/AsistenciaImport/ImportadorSedeBase.vb:1](../../Software/referencia/AsistenciaImport/ImportadorSedeBase.vb#L1)

No se encontró SQL literal dentro de rutinas en este archivo; las responsabilidades y referencias se observan en su fuente. [Software/referencia/AsistenciaImport/ImportadorSedeBase.vb:1](../../Software/referencia/AsistenciaImport/ImportadorSedeBase.vb#L1)

## Software/referencia/AsistenciaImport/ISedeImportador.vb

[Software/referencia/AsistenciaImport/ISedeImportador.vb:1](../../Software/referencia/AsistenciaImport/ISedeImportador.vb#L1)

No se encontró SQL literal dentro de rutinas en este archivo; las responsabilidades y referencias se observan en su fuente. [Software/referencia/AsistenciaImport/ISedeImportador.vb:1](../../Software/referencia/AsistenciaImport/ISedeImportador.vb#L1)

## Software/referencia/AsistenciaImport/ImportadorSedePrincipal.vb

[Software/referencia/AsistenciaImport/ImportadorSedePrincipal.vb:1](../../Software/referencia/AsistenciaImport/ImportadorSedePrincipal.vb#L1)

No se encontró SQL literal dentro de rutinas en este archivo; las responsabilidades y referencias se observan en su fuente. [Software/referencia/AsistenciaImport/ImportadorSedePrincipal.vb:1](../../Software/referencia/AsistenciaImport/ImportadorSedePrincipal.vb#L1)

## Software/referencia/AsistenciaImport/ImportadorFueraSede.vb

[Software/referencia/AsistenciaImport/ImportadorFueraSede.vb:1](../../Software/referencia/AsistenciaImport/ImportadorFueraSede.vb#L1)

No se encontró SQL literal dentro de rutinas en este archivo; las responsabilidades y referencias se observan en su fuente. [Software/referencia/AsistenciaImport/ImportadorFueraSede.vb:1](../../Software/referencia/AsistenciaImport/ImportadorFueraSede.vb#L1)

## Software/referencia/AsistenciaImport/IAsistenciaService.vb

[Software/referencia/AsistenciaImport/IAsistenciaService.vb:1](../../Software/referencia/AsistenciaImport/IAsistenciaService.vb#L1)

No se encontró SQL literal dentro de rutinas en este archivo; las responsabilidades y referencias se observan en su fuente. [Software/referencia/AsistenciaImport/IAsistenciaService.vb:1](../../Software/referencia/AsistenciaImport/IAsistenciaService.vb#L1)

## Software/referencia/AsistenciaImport/AsistenciaAccess.vb

[Software/referencia/AsistenciaImport/AsistenciaAccess.vb:1](../../Software/referencia/AsistenciaImport/AsistenciaAccess.vb#L1)

No se encontró SQL literal dentro de rutinas en este archivo; las responsabilidades y referencias se observan en su fuente. [Software/referencia/AsistenciaImport/AsistenciaAccess.vb:1](../../Software/referencia/AsistenciaImport/AsistenciaAccess.vb#L1)

## Software/referencia/AsistenciaImport/AsistenciaAccess_Original_Legacy.vb

[Software/referencia/AsistenciaImport/AsistenciaAccess_Original_Legacy.vb:1](../../Software/referencia/AsistenciaImport/AsistenciaAccess_Original_Legacy.vb#L1)


### Rutina con SQL

[Software/referencia/AsistenciaImport/AsistenciaAccess_Original_Legacy.vb:47](../../Software/referencia/AsistenciaImport/AsistenciaAccess_Original_Legacy.vb#L47)
```vb
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
```

### Rutina con SQL

[Software/referencia/AsistenciaImport/AsistenciaAccess_Original_Legacy.vb:89](../../Software/referencia/AsistenciaImport/AsistenciaAccess_Original_Legacy.vb#L89)
```vb
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
```

### Rutina con SQL

[Software/referencia/AsistenciaImport/AsistenciaAccess_Original_Legacy.vb:131](../../Software/referencia/AsistenciaImport/AsistenciaAccess_Original_Legacy.vb#L131)
```vb
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
```

### Rutina con SQL

[Software/referencia/AsistenciaImport/AsistenciaAccess_Original_Legacy.vb:173](../../Software/referencia/AsistenciaImport/AsistenciaAccess_Original_Legacy.vb#L173)
```vb
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
```

## Software/referencia/AsistenciaImport/Launcher/Program.vb

[Software/referencia/AsistenciaImport/Launcher/Program.vb:1](../../Software/referencia/AsistenciaImport/Launcher/Program.vb#L1)

No se encontró SQL literal dentro de rutinas en este archivo; las responsabilidades y referencias se observan en su fuente. [Software/referencia/AsistenciaImport/Launcher/Program.vb:1](../../Software/referencia/AsistenciaImport/Launcher/Program.vb#L1)

## Software/referencia/AsistenciaImport/ImportadorConsejo.vb

[Software/referencia/AsistenciaImport/ImportadorConsejo.vb:1](../../Software/referencia/AsistenciaImport/ImportadorConsejo.vb#L1)

No se encontró SQL literal dentro de rutinas en este archivo; las responsabilidades y referencias se observan en su fuente. [Software/referencia/AsistenciaImport/ImportadorConsejo.vb:1](../../Software/referencia/AsistenciaImport/ImportadorConsejo.vb#L1)

## Software/referencia/AsistenciaImport/FrmImportarAsistencia.Designer.vb

[Software/referencia/AsistenciaImport/FrmImportarAsistencia.Designer.vb:1](../../Software/referencia/AsistenciaImport/FrmImportarAsistencia.Designer.vb#L1)

No se encontró SQL literal dentro de rutinas en este archivo; las responsabilidades y referencias se observan en su fuente. [Software/referencia/AsistenciaImport/FrmImportarAsistencia.Designer.vb:1](../../Software/referencia/AsistenciaImport/FrmImportarAsistencia.Designer.vb#L1)

## Software/referencia/AsistenciaImport/SedeImportadorFactory.vb

[Software/referencia/AsistenciaImport/SedeImportadorFactory.vb:1](../../Software/referencia/AsistenciaImport/SedeImportadorFactory.vb#L1)


### Rutina con SQL

[Software/referencia/AsistenciaImport/SedeImportadorFactory.vb:19](../../Software/referencia/AsistenciaImport/SedeImportadorFactory.vb#L19)
```vb
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
```
