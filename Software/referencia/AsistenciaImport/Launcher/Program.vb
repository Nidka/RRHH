Imports System
Imports System.Windows.Forms
Imports RRHH.AsistenciaImport

Module Program
    <STAThread()>
    Public Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New FrmImportarAsistencia())
    End Sub
End Module
