using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using RRHH.Application.Teletrabajo;
using RRHH.Domain.Teletrabajo;
using RRHH.Presentation.Teletrabajo;

namespace RecursosHumanos;

/// <summary>Vista de consulta y registro de periodos de teletrabajo.</summary>
public sealed class FrmTeletrabajo : Form, ITeletrabajoView
{
    private readonly NumericUpDown _empleado = new NumericUpDown { Minimum = 1, Maximum = int.MaxValue };
    private readonly DateTimePicker _desde = new DateTimePicker { Format = DateTimePickerFormat.Short };
    private readonly DateTimePicker _hasta = new DateTimePicker { Format = DateTimePickerFormat.Short };
    private readonly ComboBox _modalidad = new ComboBox { DropDownStyle = ComboBoxStyle.DropDownList };
    private readonly CheckedListBox _dias = new CheckedListBox { Height = 90, CheckOnClick = true };
    private readonly TextBox _autorizacion = new TextBox { MaxLength = 200, Width = 220 };
    private readonly DataGridView _grilla = new DataGridView
        { Dock = DockStyle.Fill, ReadOnly = true, AllowUserToAddRows = false, AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill };

    public int IdEmpleado => (int)_empleado.Value;
    public DateTime Desde => _desde.Value.Date;
    public DateTime Hasta => _hasta.Value.Date;
    public ModalidadTeletrabajo Modalidad => (ModalidadTeletrabajo)_modalidad.SelectedItem;
    public int DiasRemotos => Modalidad == ModalidadTeletrabajo.Total ? PeriodoTeletrabajo.SemanaCompleta :
        _dias.CheckedIndices.Cast<int>().Aggregate(0, (mascara, indice) => mascara | (1 << indice));
    public string Autorizacion => _autorizacion.Text;
    public event EventHandler RegistrarSolicitado;
    public event EventHandler ListarSolicitado;

    public FrmTeletrabajo()
    {
        Text = "Periodos de teletrabajo";
        Width = 850;
        Height = 550;
        StartPosition = FormStartPosition.CenterParent;
        _modalidad.DataSource = Enum.GetValues(typeof(ModalidadTeletrabajo));
        _dias.Items.AddRange(new object[] { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes" });
        _dias.Enabled = false;
        _modalidad.SelectedValueChanged += (_, _) => _dias.Enabled = Modalidad == ModalidadTeletrabajo.Parcial;

        var campos = new TableLayoutPanel { Dock = DockStyle.Top, AutoSize = true, ColumnCount = 4, Padding = new Padding(8) };
        campos.Controls.Add(new Label { Text = "Código de empleado", AutoSize = true }, 0, 0);
        campos.Controls.Add(_empleado, 1, 0);
        campos.Controls.Add(new Label { Text = "Modalidad", AutoSize = true }, 2, 0);
        campos.Controls.Add(_modalidad, 3, 0);
        campos.Controls.Add(new Label { Text = "Desde", AutoSize = true }, 0, 1);
        campos.Controls.Add(_desde, 1, 1);
        campos.Controls.Add(new Label { Text = "Hasta", AutoSize = true }, 2, 1);
        campos.Controls.Add(_hasta, 3, 1);
        campos.Controls.Add(new Label { Text = "Autorización", AutoSize = true }, 0, 2);
        campos.Controls.Add(_autorizacion, 1, 2);
        campos.Controls.Add(new Label { Text = "Días remotos", AutoSize = true }, 2, 2);
        campos.Controls.Add(_dias, 3, 2);
        var registrar = new Button { Text = "Registrar", AutoSize = true };
        var listar = new Button { Text = "Consultar periodos", AutoSize = true };
        registrar.Click += (_, _) => RegistrarSolicitado?.Invoke(this, EventArgs.Empty);
        listar.Click += (_, _) => ListarSolicitado?.Invoke(this, EventArgs.Empty);
        campos.Controls.Add(registrar, 0, 3);
        campos.Controls.Add(listar, 1, 3);
        Controls.Add(_grilla);
        Controls.Add(campos);
    }

    /// <inheritdoc/>
    public void MostrarPeriodos(IReadOnlyList<PeriodoTeletrabajoDto> periodos) => _grilla.DataSource = periodos.ToList();

    /// <inheritdoc/>
    public void MostrarRegistro(int id) => MessageBox.Show(this, $"Periodo registrado con código {id}.", Text);

    /// <inheritdoc/>
    public void MostrarError(string mensaje) => MessageBox.Show(this, mensaje, Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
}
