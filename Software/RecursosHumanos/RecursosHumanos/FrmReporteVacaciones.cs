using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RRHH.Application.Asistencia;
using RRHH.Presentation.Asistencia;

namespace RecursosHumanos;

/// <summary>Vista pasiva del reporte acumulado; cero en área/empleado significa todos.</summary>
public sealed class FrmReporteVacaciones : Form,IReporteVacacionesView
{
    private readonly NumericUpDown _anio=new NumericUpDown {Minimum=1900,Maximum=9998,Value=DateTime.Today.Year};
    private readonly NumericUpDown _area=new NumericUpDown {Maximum=int.MaxValue},_empleado=new NumericUpDown {Maximum=int.MaxValue};
    private readonly DateTimePicker _corte=new DateTimePicker {Format=DateTimePickerFormat.Short};
    private readonly DataGridView _tabla=new DataGridView {Dock=DockStyle.Fill,ReadOnly=true,AllowUserToAddRows=false,AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill};
    public int Anio=>(int)_anio.Value;
    public DateTime Corte=>_corte.Value.Date;
    public int? Area=>_area.Value==0 ? (int?)null : (int)_area.Value;
    public int? Empleado=>_empleado.Value==0 ? (int?)null : (int)_empleado.Value;
    public event EventHandler ConsultarSolicitado;
    public FrmReporteVacaciones()
    {
        Text="Reporte de vacaciones · truncas simuladas al corte";Width=1100;Height=500;
        var panel=new FlowLayoutPanel {Dock=DockStyle.Top,AutoSize=true,Padding=new Padding(8)};
        void Campo(string texto,Control control){panel.Controls.Add(new Label {Text=texto,AutoSize=true});panel.Controls.Add(control);}
        Campo("Año",_anio);Campo("Corte",_corte);Campo("Área (0=todas)",_area);Campo("Empleado (0=todos)",_empleado);
        var boton=new Button {Text="Consultar",AutoSize=true};boton.Click+=(_,_)=>ConsultarSolicitado?.Invoke(this,EventArgs.Empty);panel.Controls.Add(boton);
        Controls.Add(_tabla);Controls.Add(panel);AcceptButton=boton;
    }
    /// <inheritdoc/>
    public void Mostrar(IReadOnlyList<ReporteVacacionesDto> filas)=>_tabla.DataSource=filas;
    /// <inheritdoc/>
    public void MostrarError(string mensaje)=>MessageBox.Show(this,mensaje,Text,MessageBoxButtons.OK,MessageBoxIcon.Warning);
}
