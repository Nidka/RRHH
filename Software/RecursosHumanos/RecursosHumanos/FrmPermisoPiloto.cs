using System;
using System.Drawing;
using System.Windows.Forms;
using RRHH.Application.Permisos;
using RRHH.Presentation.Permisos;

namespace RecursosHumanos;

/// <summary>Editor pasivo de permisos, estados, vacaciones y salidas autorizadas del piloto.</summary>
public sealed class FrmPermisoPiloto : Form,IPermisoEditorView
{
    private readonly NumericUpDown _empleado=new NumericUpDown {Minimum=1,Maximum=int.MaxValue};
    private readonly NumericUpDown _numeroCarga=new NumericUpDown {Minimum=1,Maximum=int.MaxValue};
    private readonly NumericUpDown _motivo=new NumericUpDown {Minimum=1,Maximum=int.MaxValue};
    private readonly DateTimePicker _desde=new DateTimePicker {Format=DateTimePickerFormat.Short};
    private readonly DateTimePicker _hasta=new DateTimePicker {Format=DateTimePickerFormat.Short};
    private readonly ComboBox _estado=new ComboBox {DropDownStyle=ComboBoxStyle.DropDownList};
    private readonly TextBox _lugar=new TextBox {MaxLength=20},_referencia=new TextBox {MaxLength=100},
        _autorizacion=new TextBox {MaxLength=50},_observacion=new TextBox {MaxLength=200,Width=350};
    private readonly CheckBox _dia=new CheckBox {Text="Día completo",AutoSize=true},_retorno=new CheckBox {Text="Con retorno",AutoSize=true},
        _media=new CheckBox {Text="Media jornada vacacional (0,5 días)",AutoSize=true};
    private readonly Label _mensaje=new Label {AutoSize=true,MaximumSize=new Size(650,0)};
    private int _numero;
    public int EmpleadoConsulta => (int)_empleado.Value;
    public int NumeroConsulta => (int)_numeroCarga.Value;
    public event EventHandler CargarSolicitado;
    public event EventHandler GuardarSolicitado;
    public PermisoGuardarDto Entrada => new PermisoGuardarDto {IdEmpleado=EmpleadoConsulta,Numero=_numero,IdMotivo=(int)_motivo.Value,
        Desde=_desde.Value.Date,Hasta=_hasta.Value.Date,Estado=(string)_estado.SelectedItem,Lugar=_lugar.Text,Referencia=_referencia.Text,
        Autorizacion=_autorizacion.Text,Observacion=_observacion.Text,Dia=_dia.Checked,Retorno=_retorno.Checked,MediaJornadaVacaciones=_media.Checked};

    public FrmPermisoPiloto()
    {
        Text="Permisos y vacaciones del piloto"; Width=750; Height=630; StartPosition=FormStartPosition.CenterParent;
        var panel=new FlowLayoutPanel {Dock=DockStyle.Fill,FlowDirection=FlowDirection.TopDown,WrapContents=false,AutoScroll=true,Padding=new Padding(15)};
        void Campo(string texto,Control control) {var fila=new FlowLayoutPanel {AutoSize=true,Width=680}; fila.Controls.Add(new Label {Text=texto,Width=180});fila.Controls.Add(control);panel.Controls.Add(fila);}
        _estado.Items.AddRange(new object[] {"Solicitado","Aprobado","Rechazado","Anulado"});_estado.SelectedIndex=0;
        Campo("Empleado",_empleado);Campo("Número para cargar",_numeroCarga);
        var cargar=new Button {Text="Cargar existente",AutoSize=true};cargar.Click+=(_,_)=>CargarSolicitado?.Invoke(this,EventArgs.Empty);panel.Controls.Add(cargar);
        Campo("Motivo activo",_motivo);Campo("Desde",_desde);Campo("Hasta",_hasta);Campo("Estado",_estado);
        Campo("Lugar",_lugar);Campo("Referencia",_referencia);Campo("Autorización",_autorizacion);Campo("Observación",_observacion);
        panel.Controls.Add(_dia);panel.Controls.Add(_retorno);panel.Controls.Add(_media);
        var guardar=new Button {Text="Guardar",AutoSize=true};guardar.Click+=(_,_)=>GuardarSolicitado?.Invoke(this,EventArgs.Empty);panel.Controls.Add(guardar);
        var nuevo=new Button {Text="Nuevo permiso",AutoSize=true};nuevo.Click+=(_,_)=>Mostrar(null);panel.Controls.Add(nuevo);panel.Controls.Add(_mensaje);
        Controls.Add(panel);
    }
    /// <inheritdoc/>
    public void Mostrar(PermisoGuardarDto permiso)
    {
        _numero=permiso?.Numero ?? 0;_empleado.Enabled=_numero==0;
        if (permiso!=null) {_empleado.Value=permiso.IdEmpleado;_numeroCarga.Value=permiso.Numero;_motivo.Value=permiso.IdMotivo;}
        _desde.Value=permiso?.Desde ?? DateTime.Today;_hasta.Value=permiso?.Hasta ?? DateTime.Today;
        _estado.SelectedItem=permiso?.Estado ?? "Solicitado";_lugar.Text=permiso?.Lugar ?? "";_referencia.Text=permiso?.Referencia ?? "";
        _autorizacion.Text=permiso?.Autorizacion ?? "";_observacion.Text=permiso?.Observacion ?? "";
        _dia.Checked=permiso?.Dia==true;_retorno.Checked=permiso?.Retorno==true;_media.Checked=permiso?.MediaJornadaVacaciones==true;
        _mensaje.Text=_numero==0 ? "Nuevo permiso" : "Editando permiso "+_numero;
    }
    /// <inheritdoc/>
    public void MostrarMensaje(string mensaje,bool error) {_mensaje.ForeColor=error ? Color.DarkRed : Color.DarkGreen;_mensaje.Text=mensaje;}
}
