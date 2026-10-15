<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmImportarAsistencia
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    Friend WithEvents grpParametros As System.Windows.Forms.GroupBox
    Friend WithEvents lblSede As System.Windows.Forms.Label
    Friend WithEvents cboSede As System.Windows.Forms.ComboBox
    Friend WithEvents lblFechaInicial As System.Windows.Forms.Label
    Friend WithEvents dtpFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaFinal As System.Windows.Forms.Label
    Friend WithEvents dtpFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkForzar As System.Windows.Forms.CheckBox
    Friend WithEvents lblRuta As System.Windows.Forms.Label
    Friend WithEvents txtRuta As System.Windows.Forms.TextBox
    Friend WithEvents btnExaminar As System.Windows.Forms.Button
    Friend WithEvents btnImportar As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents prgProgreso As System.Windows.Forms.ProgressBar
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents bgwImportador As System.ComponentModel.BackgroundWorker

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.grpParametros = New System.Windows.Forms.GroupBox()
        Me.lblSede = New System.Windows.Forms.Label()
        Me.cboSede = New System.Windows.Forms.ComboBox()
        Me.lblFechaInicial = New System.Windows.Forms.Label()
        Me.dtpFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaFinal = New System.Windows.Forms.Label()
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.lblRuta = New System.Windows.Forms.Label()
        Me.txtRuta = New System.Windows.Forms.TextBox()
        Me.btnExaminar = New System.Windows.Forms.Button()
        Me.chkForzar = New System.Windows.Forms.CheckBox()
        Me.btnImportar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.prgProgreso = New System.Windows.Forms.ProgressBar()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.bgwImportador = New System.ComponentModel.BackgroundWorker()
        Me.grpParametros.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpParametros
        '
        Me.grpParametros.Controls.Add(Me.lblSede)
        Me.grpParametros.Controls.Add(Me.cboSede)
        Me.grpParametros.Controls.Add(Me.lblFechaInicial)
        Me.grpParametros.Controls.Add(Me.dtpFechaInicial)
        Me.grpParametros.Controls.Add(Me.lblFechaFinal)
        Me.grpParametros.Controls.Add(Me.dtpFechaFinal)
        Me.grpParametros.Controls.Add(Me.lblRuta)
        Me.grpParametros.Controls.Add(Me.txtRuta)
        Me.grpParametros.Controls.Add(Me.btnExaminar)
        Me.grpParametros.Controls.Add(Me.chkForzar)
        Me.grpParametros.Location = New System.Drawing.Point(12, 12)
        Me.grpParametros.Name = "grpParametros"
        Me.grpParametros.Size = New System.Drawing.Size(460, 185)
        Me.grpParametros.TabIndex = 0
        Me.grpParametros.TabStop = False
        Me.grpParametros.Text = "Parámetros de Importación (Unificado OCP)"
        '
        'lblSede
        '
        Me.lblSede.AutoSize = True
        Me.lblSede.Location = New System.Drawing.Point(15, 30)
        Me.lblSede.Name = "lblSede"
        Me.lblSede.Size = New System.Drawing.Size(100, 13)
        Me.lblSede.TabIndex = 0
        Me.lblSede.Text = "Sede de Asistencia:"
        '
        'cboSede
        '
        Me.cboSede.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSede.FormattingEnabled = True
        Me.cboSede.Location = New System.Drawing.Point(130, 27)
        Me.cboSede.Name = "cboSede"
        Me.cboSede.Size = New System.Drawing.Size(315, 21)
        Me.cboSede.TabIndex = 1
        '
        'lblFechaInicial
        '
        Me.lblFechaInicial.AutoSize = True
        Me.lblFechaInicial.Location = New System.Drawing.Point(15, 65)
        Me.lblFechaInicial.Name = "lblFechaInicial"
        Me.lblFechaInicial.Size = New System.Drawing.Size(70, 13)
        Me.lblFechaInicial.TabIndex = 2
        Me.lblFechaInicial.Text = "Fecha Inicial:"
        '
        'dtpFechaInicial
        '
        Me.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpFechaInicial.Location = New System.Drawing.Point(130, 61)
        Me.dtpFechaInicial.Name = "dtpFechaInicial"
        Me.dtpFechaInicial.Size = New System.Drawing.Size(120, 20)
        Me.dtpFechaInicial.TabIndex = 3
        '
        'lblFechaFinal
        '
        Me.lblFechaFinal.AutoSize = True
        Me.lblFechaFinal.Location = New System.Drawing.Point(265, 65)
        Me.lblFechaFinal.Name = "lblFechaFinal"
        Me.lblFechaFinal.Size = New System.Drawing.Size(65, 13)
        Me.lblFechaFinal.TabIndex = 4
        Me.lblFechaFinal.Text = "Fecha Final:"
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpFechaFinal.Location = New System.Drawing.Point(335, 61)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(110, 20)
        Me.dtpFechaFinal.TabIndex = 5
        '
        'lblRuta
        '
        Me.lblRuta.AutoSize = True
        Me.lblRuta.Location = New System.Drawing.Point(15, 100)
        Me.lblRuta.Name = "lblRuta"
        Me.lblRuta.Size = New System.Drawing.Size(107, 13)
        Me.lblRuta.TabIndex = 6
        Me.lblRuta.Text = "Ruta Base / Archivo:"
        '
        'txtRuta
        '
        Me.txtRuta.Location = New System.Drawing.Point(130, 97)
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.Size = New System.Drawing.Size(235, 20)
        Me.txtRuta.TabIndex = 7
        '
        'btnExaminar
        '
        Me.btnExaminar.Location = New System.Drawing.Point(371, 95)
        Me.btnExaminar.Name = "btnExaminar"
        Me.btnExaminar.Size = New System.Drawing.Size(74, 23)
        Me.btnExaminar.TabIndex = 8
        Me.btnExaminar.Text = "Examinar..."
        Me.btnExaminar.UseVisualStyleBackColor = True
        '
        'chkForzar
        '
        Me.chkForzar.AutoSize = True
        Me.chkForzar.Location = New System.Drawing.Point(130, 135)
        Me.chkForzar.Name = "chkForzar"
        Me.chkForzar.Size = New System.Drawing.Size(193, 17)
        Me.chkForzar.TabIndex = 9
        Me.chkForzar.Text = "Forzar sobreescritura de asistencias"
        Me.chkForzar.UseVisualStyleBackColor = True
        '
        'btnImportar
        '
        Me.btnImportar.Location = New System.Drawing.Point(260, 240)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(100, 30)
        Me.btnImportar.TabIndex = 1
        Me.btnImportar.Text = "Importar"
        Me.btnImportar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(372, 240)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(100, 30)
        Me.btnCerrar.TabIndex = 2
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'prgProgreso
        '
        Me.prgProgreso.Location = New System.Drawing.Point(12, 205)
        Me.prgProgreso.Name = "prgProgreso"
        Me.prgProgreso.Size = New System.Drawing.Size(460, 20)
        Me.prgProgreso.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.prgProgreso.TabIndex = 3
        Me.prgProgreso.Visible = False
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(15, 249)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(41, 13)
        Me.lblEstado.TabIndex = 4
        Me.lblEstado.Text = "Listo."
        '
        'bgwImportador
        '
        Me.bgwImportador.WorkerReportsProgress = False
        Me.bgwImportador.WorkerSupportsCancellation = False
        '
        'FrmImportarAsistencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 282)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.prgProgreso)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnImportar)
        Me.Controls.Add(Me.grpParametros)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmImportarAsistencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Importación de Asistencia — Módulo Refactorizado (OCP)"
        Me.grpParametros.ResumeLayout(False)
        Me.grpParametros.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

End Class

