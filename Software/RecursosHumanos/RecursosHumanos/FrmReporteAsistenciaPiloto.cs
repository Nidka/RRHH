using System;
using System.Windows.Forms;
using RRHH.Application.Asistencia;
using RRHH.Presentation.Asistencia;

namespace RecursosHumanos;

/// <summary>Consulta RF-17 desde MVP; mantiene visible cada marcación en días no laborables.</summary>
public sealed class FrmReporteAsistenciaPiloto:Form,IReporteAsistenciaPilotoView
{
    private readonly NumericUpDown _empleado=new NumericUpDown{Minimum=1,Maximum=int.MaxValue};
    private readonly DateTimePicker _desde=new DateTimePicker{Format=DateTimePickerFormat.Short},_hasta=new DateTimePicker{Format=DateTimePickerFormat.Short};
    private readonly CheckBox _productividad=new CheckBox{Text="Productividad",AutoSize=true};
    private readonly Label _total=new Label{Dock=DockStyle.Top,Height=40,Padding=new Padding(8)};
    private readonly DataGridView _tabla=new DataGridView{Dock=DockStyle.Fill,ReadOnly=true,AllowUserToAddRows=false,AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill};
    public int Empleado=>(int)_empleado.Value;
    public DateTime Desde=>_desde.Value.Date;
    public DateTime Hasta=>_hasta.Value.Date;
    public bool Productividad=>_productividad.Checked;
    public event EventHandler ConsultarSolicitado;
    public FrmReporteAsistenciaPiloto()
    {
        Text="Asistencias y días no laborables del piloto";Width=950;Height=450;
        var filtros=new FlowLayoutPanel{Dock=DockStyle.Top,AutoSize=true,Padding=new Padding(8)};
        filtros.Controls.AddRange(new Control[]{new Label{Text="Empleado",AutoSize=true},_empleado,new Label{Text="Desde",AutoSize=true},_desde,new Label{Text="Hasta",AutoSize=true},_hasta,_productividad});
        var boton=new Button{Text="Consultar",AutoSize=true};boton.Click+=(_,_)=>ConsultarSolicitado?.Invoke(this,EventArgs.Empty);filtros.Controls.Add(boton);
        Controls.Add(_tabla);Controls.Add(_total);Controls.Add(filtros);AcceptButton=boton;
    }
    /// <inheritdoc/>
    public void Mostrar(ResumenAsistenciaDto resultado){_tabla.DataSource=resultado?.Dias;_total.Text=resultado==null ? "" : "Total de días computados: "+resultado.Total;}
    /// <inheritdoc/>
    public void MostrarError(string mensaje)=>MessageBox.Show(this,mensaje,Text,MessageBoxButtons.OK,MessageBoxIcon.Warning);
}
