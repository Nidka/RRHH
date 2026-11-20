using System;
using System.Windows.Forms;
using RRHH.Application.Asistencia;
using RRHH.Presentation.Asistencia;

namespace RecursosHumanos;

/// <summary>Detalle de fuentes y categoría única por día, sin sumar dos asistencias.</summary>
public sealed class FrmAsistenciaConsolidada:Form,IAsistenciaConsolidadaView
{
    private readonly NumericUpDown _empleado=new NumericUpDown {Minimum=1,Maximum=int.MaxValue};
    private readonly DateTimePicker _desde=new DateTimePicker {Format=DateTimePickerFormat.Short},_hasta=new DateTimePicker {Format=DateTimePickerFormat.Short};
    private readonly Label _resumen=new Label {Dock=DockStyle.Top,Height=70,Padding=new Padding(8)};
    private readonly DataGridView _tabla=new DataGridView {Dock=DockStyle.Fill,ReadOnly=true,AllowUserToAddRows=false,AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill};
    public int Empleado=>(int)_empleado.Value;
    public DateTime Desde=>_desde.Value.Date;
    public DateTime Hasta=>_hasta.Value.Date;
    public event EventHandler ConsultarSolicitado;
    public FrmAsistenciaConsolidada()
    {
        Text="Asistencia consolidada del piloto";Width=1100;Height=500;
        var panel=new FlowLayoutPanel {Dock=DockStyle.Top,AutoSize=true,Padding=new Padding(8)};
        panel.Controls.AddRange(new Control[]{new Label{Text="Empleado",AutoSize=true},_empleado,new Label{Text="Desde",AutoSize=true},_desde,new Label{Text="Hasta",AutoSize=true},_hasta});
        var consultar=new Button{Text="Consolidar",AutoSize=true};consultar.Click+=(_,_)=>ConsultarSolicitado?.Invoke(this,EventArgs.Empty);panel.Controls.Add(consultar);
        Controls.Add(_tabla);Controls.Add(_resumen);Controls.Add(panel);AcceptButton=consultar;
    }
    /// <inheritdoc/>
    public void Mostrar(AsistenciaConsolidadaDto resultado)
    {
        _tabla.DataSource=resultado?.Dias;
        _resumen.Text=resultado==null ? "" : $"Laborables {resultado.Laborables} · ausencias {resultado.Ausencias} · presenciales {resultado.Presenciales} · remotos {resultado.Remotos}\r\n"+
            $"Sin registro {resultado.SinRegistro} · inconsistencias para revisar {resultado.Inconsistencias}";
    }
    /// <inheritdoc/>
    public void MostrarError(string mensaje)=>MessageBox.Show(this,mensaje,Text,MessageBoxButtons.OK,MessageBoxIcon.Warning);
}
