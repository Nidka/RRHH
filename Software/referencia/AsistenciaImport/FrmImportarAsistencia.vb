' =====================================================================
' FrmImportarAsistencia.vb  (FORMULARIO UNIFICADO - REFACTOR OCP)
' ---------------------------------------------------------------------
' Reemplaza los 3 a 4 formularios legacy:
'   - FrmImportarAsistencia
'   - FrmImportarAsistenciaFueraSEDE
'   - FrmImportarAsistenciaPROIND
'   - FrmImportarAsistenciaCONSEJO
'
' Cumple OCP:
' El formulario no conoce cadenas de conexión, consultas SQL ni rutas
' específicas. Solo interactúa con TipoSede, SedeImportadorFactory y
' la abstracción ISedeImportador.
' =====================================================================

Imports System
Imports System.Windows.Forms

Public Class FrmImportarAsistencia

    Private ReadOnly _asistenciaService As IAsistenciaService

    Public Sub New()
        Me.New(New AsistenciaAccess())
    End Sub

    Public Sub New(asistenciaService As IAsistenciaService)
        If asistenciaService Is Nothing Then Throw New ArgumentNullException(NameOf(asistenciaService))
        InitializeComponent()
        _asistenciaService = asistenciaService
    End Sub

    Private Class ItemSede
        Public Property Tipo As TipoSede
        Public Property Descripcion As String

        Public Overrides Function ToString() As String
            Return Descripcion
        End Function
    End Class

    Private Sub FrmImportarAsistencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarSedes()
        dtpFechaInicial.Value = DateTime.Today.AddDays(-7)
        dtpFechaFinal.Value = DateTime.Today
    End Sub

    Private Sub CargarSedes()
        Dim listaSedes As New List(Of ItemSede) From {
            New ItemSede With {.Tipo = TipoSede.Principal, .Descripcion = "Sede Principal"},
            New ItemSede With {.Tipo = TipoSede.FueraSede, .Descripcion = "Fuera de Sede"},
            New ItemSede With {.Tipo = TipoSede.Proind, .Descripcion = "PROIND"},
            New ItemSede With {.Tipo = TipoSede.Consejo, .Descripcion = "Consejo Regional"}
        }

        cboSede.DataSource = listaSedes
        cboSede.SelectedIndex = 0
    End Sub

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

    Private Sub btnExaminar_Click(sender As Object, e As EventArgs) Handles btnExaminar.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Base de datos Access (*.mdb)|*.mdb|Todos los archivos (*.*)|*.*"
            ofd.Title = "Seleccionar archivo de Marcación / Asistencia"
            If ofd.ShowDialog() = DialogResult.OK Then
                txtRuta.Text = ofd.FileName
            End If
        End Using
    End Sub

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click
        If dtpFechaInicial.Value > dtpFechaFinal.Value Then
            MessageBox.Show("La fecha inicial no puede ser posterior a la fecha final.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim item As ItemSede = TryCast(cboSede.SelectedItem, ItemSede)
        If item Is Nothing Then Return

        btnImportar.Enabled = False
        btnCerrar.Enabled = False
        prgProgreso.Visible = True
        lblEstado.Text = $"Importando asistencia de '{item.Descripcion}'..."

        ' Parámetros para el BackgroundWorker
        Dim parametros As New ArgumentosImportacion With {
            .Tipo = item.Tipo,
            .Ruta = txtRuta.Text.Trim(),
            .FechaInicial = dtpFechaInicial.Value,
            .FechaFinal = dtpFechaFinal.Value,
            .Forzar = chkForzar.Checked
        }

        bgwImportador.RunWorkerAsync(parametros)
    End Sub

    Private Sub bgwImportador_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwImportador.DoWork
        Dim args As ArgumentosImportacion = CType(e.Argument, ArgumentosImportacion)
        Dim importador As ISedeImportador = SedeImportadorFactory.Crear(args.Tipo, args.Ruta)

        Dim resultado As Boolean = _asistenciaService.Access2Sql(importador, args.FechaInicial, args.FechaFinal, args.Forzar)
        e.Result = New ResultadoImportacion With {
            .Exitoso = resultado,
            .NombreSede = importador.NombreSede
        }
    End Sub

    Private Sub bgwImportador_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwImportador.RunWorkerCompleted
        prgProgreso.Visible = False
        btnImportar.Enabled = True
        btnCerrar.Enabled = True

        If e.Error IsNot Nothing Then
            lblEstado.Text = "Error en el proceso."
            MessageBox.Show($"Ocurrió un error durante la importación:{Environment.NewLine}{e.Error.Message}", "Error de Importación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim res As ResultadoImportacion = CType(e.Result, ResultadoImportacion)
            If res.Exitoso Then
                lblEstado.Text = "Importación finalizada con éxito."
                MessageBox.Show($"La asistencia de '{res.NombreSede}' fue importada exitosamente en SQL Server.", "Proceso Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                lblEstado.Text = "Proceso no completado."
                MessageBox.Show($"No se pudo importar la asistencia de '{res.NombreSede}'.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Class ArgumentosImportacion
        Public Property Tipo As TipoSede
        Public Property Ruta As String
        Public Property FechaInicial As Date
        Public Property FechaFinal As Date
        Public Property Forzar As Boolean
    End Class

    Private Class ResultadoImportacion
        Public Property Exitoso As Boolean
        Public Property NombreSede As String
    End Class

End Class
