using System;
using System.Drawing;
using System.Windows.Forms;
using RRHH.Application.Asistencia;
using RRHH.Presentation.Asistencia;

namespace RecursosHumanos;

/// <summary>Vista pasiva del saldo académico acumulado y sus consumos aprobados.</summary>
public sealed class FrmSaldoVacaciones : Form, ISaldoVacacionesView,ITruncasVacacionesView
{
    private readonly NumericUpDown _empleado=new NumericUpDown {Minimum=1,Maximum=int.MaxValue};
    private readonly DateTimePicker _corte=new DateTimePicker {Format=DateTimePickerFormat.Short};
    private readonly Label _resumen=new Label {Dock=DockStyle.Top,Height=85,Padding=new Padding(8),Font=new Font("Arial",12)};
    private readonly Label _truncas=new Label {Dock=DockStyle.Top,Height=45,Padding=new Padding(8)};
    private readonly DataGridView _detalle=new DataGridView {Dock=DockStyle.Fill,ReadOnly=true,AllowUserToAddRows=false,AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill};
    public int Empleado => (int)_empleado.Value;
    public DateTime Corte => _corte.Value.Date;
    public event EventHandler ConsultarSolicitado;
    public DateTime Cese => Corte;
    public event EventHandler TruncasSolicitadas;

    public FrmSaldoVacaciones()
    {
        Text="Saldo de vacaciones del piloto"; Width=850; Height=450; StartPosition=FormStartPosition.CenterParent;
        var consultar=new Button {Text="Consultar saldo",AutoSize=true};
        consultar.Click+=(_,_) => ConsultarSolicitado?.Invoke(this,EventArgs.Empty);
        var calcular=new Button {Text="Truncas al cese indicado",AutoSize=true};
        calcular.Click+=(_,_)=>TruncasSolicitadas?.Invoke(this,EventArgs.Empty);
        var filtros=new FlowLayoutPanel {Dock=DockStyle.Top,AutoSize=true,Padding=new Padding(8)};
        filtros.Controls.AddRange(new Control[] {new Label {Text="Empleado",AutoSize=true},_empleado,new Label {Text="Corte/cese",AutoSize=true},_corte,consultar,calcular});
        Controls.Add(_detalle);Controls.Add(_truncas); Controls.Add(_resumen); Controls.Add(filtros); AcceptButton=consultar;
    }

    /// <inheritdoc/>
    public void Mostrar(SaldoVacacionesDto resultado)
    {
        _detalle.DataSource=resultado?.Consumos;
        _resumen.Text=resultado==null ? "" : $"Corte {resultado.Corte:dd/MM/yyyy} · ingreso {resultado.Ingreso:dd/MM/yyyy}\r\n"+
            $"Generadas: {resultado.Generadas:0.##} · usadas: {resultado.Usadas:0.##} · pendientes: {resultado.Pendientes:0.##} días";
    }
    /// <inheritdoc/>
    public void MostrarError(string mensaje) => MessageBox.Show(this,mensaje,Text,MessageBoxButtons.OK,MessageBoxIcon.Warning);
    /// <inheritdoc/>
    public void MostrarTruncas(VacacionesTruncasDto resultado) => _truncas.Text=resultado==null ? "" :
        $"Simulación al cese {resultado.Cese:dd/MM/yyyy} (día incluido): {resultado.Truncas:0.00} días truncos";
}
