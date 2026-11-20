using System;
using System.Windows.Forms;
using RRHH.Application.Asistencia;
using RRHH.Presentation.Asistencia;

namespace RecursosHumanos;

/// <summary>Vista pasiva de autoconsulta sin campos de identidad editables.</summary>
public sealed class FrmMisVacaciones:Form,IMisVacacionesView
{
    private readonly DateTimePicker _corte=new DateTimePicker {Format=DateTimePickerFormat.Short};
    private readonly Label _resumen=new Label {Dock=DockStyle.Top,Height=65,Padding=new Padding(10)};
    private readonly DataGridView _tabla=new DataGridView {Dock=DockStyle.Fill,ReadOnly=true,AllowUserToAddRows=false,AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill};
    public DateTime Corte=>_corte.Value.Date;
    public event EventHandler ConsultarSolicitado;
    public FrmMisVacaciones()
    {
        Text="Mis vacaciones · consulta del empleado";Width=800;Height=450;StartPosition=FormStartPosition.CenterScreen;
        var filtros=new FlowLayoutPanel {Dock=DockStyle.Top,AutoSize=true,Padding=new Padding(8)};
        var consultar=new Button {Text="Consultar mi saldo",AutoSize=true};consultar.Click+=(_,_)=>ConsultarSolicitado?.Invoke(this,EventArgs.Empty);
        filtros.Controls.AddRange(new Control[] {new Label {Text="Corte",AutoSize=true},_corte,consultar});
        Controls.Add(_tabla);Controls.Add(_resumen);Controls.Add(filtros);AcceptButton=consultar;
    }
    /// <inheritdoc/>
    public void Mostrar(SaldoVacacionesDto saldo)
    {
        _tabla.DataSource=saldo?.Consumos;
        _resumen.Text=saldo==null ? "" : $"Empleado {saldo.Empleado} · corte {saldo.Corte:dd/MM/yyyy}\r\nGeneradas {saldo.Generadas:0.##} · usadas {saldo.Usadas:0.##} · pendientes {saldo.Pendientes:0.##} días";
    }
    /// <inheritdoc/>
    public void MostrarError(string mensaje)=>MessageBox.Show(this,mensaje,Text,MessageBoxButtons.OK,MessageBoxIcon.Warning);
}
