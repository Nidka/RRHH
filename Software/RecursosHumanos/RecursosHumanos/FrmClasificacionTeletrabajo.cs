using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using RRHH.Application.Teletrabajo;
using RRHH.Domain.Teletrabajo;
using RRHH.Presentation.Teletrabajo;

namespace RecursosHumanos;

/// <summary>
/// RF-16: personal en teletrabajo total o parcial en un periodo. Vista pasiva de
/// <see cref="ClasificacionTeletrabajoPresenter"/>: captura periodo y filtro y muestra el resultado; no aplica reglas.
/// Se crea con <c>CompositionRoot.CrearClasificacionTeletrabajo</c>.
/// </summary>
public sealed class FrmClasificacionTeletrabajo : Form, IClasificacionTeletrabajoView
{
    private readonly DateTimePicker _desde = new DateTimePicker { Format = DateTimePickerFormat.Short };
    private readonly DateTimePicker _hasta = new DateTimePicker { Format = DateTimePickerFormat.Short };
    private readonly ComboBox _filtro = new ComboBox { DropDownStyle = ComboBoxStyle.DropDownList, Width = 150 };
    private readonly Label _resumen = new Label { Dock = DockStyle.Bottom, Height = 26, TextAlign = ContentAlignment.MiddleLeft };
    private readonly DataGridView _grilla = new DataGridView
        { Dock = DockStyle.Fill, ReadOnly = true, AllowUserToAddRows = false, AutoGenerateColumns = false, RowHeadersVisible = false };

    public DateTime Desde => _desde.Value.Date;
    public DateTime Hasta => _hasta.Value.Date;

    public ModalidadTeletrabajo? Filtro =>
        _filtro.SelectedIndex == 1 ? ModalidadTeletrabajo.Total
        : _filtro.SelectedIndex == 2 ? ModalidadTeletrabajo.Parcial
        : (ModalidadTeletrabajo?)null;

    public event EventHandler ConsultarSolicitado;

    public FrmClasificacionTeletrabajo()
    {
        Text = "Personal en teletrabajo (total o parcial)";
        Width = 820;
        Height = 480;
        StartPosition = FormStartPosition.CenterParent;
        DateTime hoy = DateTime.Today;
        _desde.Value = new DateTime(hoy.Year, hoy.Month, 1);
        _hasta.Value = new DateTime(hoy.Year, hoy.Month, DateTime.DaysInMonth(hoy.Year, hoy.Month));
        _filtro.Items.AddRange(new object[] { "(Total y parcial)", "Solo total", "Solo parcial" });
        _filtro.SelectedIndex = 0;
        var consultar = new Button { Text = "Consultar", AutoSize = true };
        consultar.Click += (_, _) => ConsultarSolicitado?.Invoke(this, EventArgs.Empty);
        var campos = new FlowLayoutPanel { Dock = DockStyle.Top, AutoSize = true, Padding = new Padding(8) };
        campos.Controls.AddRange(new Control[] { new Label { Text = "Desde", AutoSize = true }, _desde,
            new Label { Text = "Hasta", AutoSize = true }, _hasta, new Label { Text = "Mostrar", AutoSize = true }, _filtro, consultar });
        _grilla.Columns.Add(new DataGridViewTextBoxColumn
            { HeaderText = "Código de empleado", DataPropertyName = nameof(FilaGrilla.IdEmpleado), Width = 150 });
        _grilla.Columns.Add(new DataGridViewTextBoxColumn
            { HeaderText = "Teletrabajo", DataPropertyName = nameof(FilaGrilla.Clasificacion), Width = 130 });
        _grilla.Columns.Add(new DataGridViewTextBoxColumn
            { HeaderText = "Días remotos", DataPropertyName = nameof(FilaGrilla.DiasRemotos), Width = 120 });
        _grilla.Columns.Add(new DataGridViewTextBoxColumn
            { HeaderText = "Días laborables del periodo", DataPropertyName = nameof(FilaGrilla.DiasLaborables), Width = 190 });
        Controls.Add(_grilla);
        Controls.Add(_resumen);
        Controls.Add(campos);
        AcceptButton = consultar;
    }

    /// <inheritdoc/>
    public void MostrarFilas(IReadOnlyList<ClasificacionTeletrabajoDto> filas) =>
        _grilla.DataSource = filas.Select(f => new FilaGrilla
        {
            IdEmpleado = f.IdEmpleado,
            Clasificacion = f.Clasificacion == ModalidadTeletrabajo.Total ? "Total" : "Parcial",
            DiasRemotos = f.DiasRemotos,
            DiasLaborables = f.DiasLaborables
        }).ToList();

    /// <inheritdoc/>
    public void MostrarResumen(string resumen) => _resumen.Text = resumen;

    /// <inheritdoc/>
    public void MostrarError(string mensaje)
    {
        _grilla.DataSource = null;
        _resumen.Text = string.Empty;
        MessageBox.Show(this, mensaje, Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    private sealed class FilaGrilla
    {
        public int IdEmpleado { get; set; }
        public string Clasificacion { get; set; }
        public int DiasRemotos { get; set; }
        public int DiasLaborables { get; set; }
    }
}
