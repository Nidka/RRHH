using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using RRHH.Application.Teletrabajo;
using RRHH.Presentation.Teletrabajo;

namespace RecursosHumanos;

/// <summary>Vista pasiva del reporte de días de teletrabajo por empleado.</summary>
public sealed class FrmReporteTeletrabajo : Form, IReporteTeletrabajoView
{
    private readonly CheckBox _todos = new CheckBox { Text = "Todos los empleados", AutoSize = true, Checked = true };
    private readonly NumericUpDown _empleado = new NumericUpDown { Minimum = 1, Maximum = int.MaxValue, Enabled = false };
    private readonly DateTimePicker _desde = new DateTimePicker { Format = DateTimePickerFormat.Short };
    private readonly DateTimePicker _hasta = new DateTimePicker { Format = DateTimePickerFormat.Short };
    private readonly DataGridView _grilla = new DataGridView
        { Dock = DockStyle.Fill, ReadOnly = true, AllowUserToAddRows = false, AutoGenerateColumns = false };

    public int? IdEmpleado => _todos.Checked ? (int?)null : (int)_empleado.Value;
    public DateTime Desde => _desde.Value.Date;
    public DateTime Hasta => _hasta.Value.Date;
    public event EventHandler ConsultarSolicitado;

    public FrmReporteTeletrabajo()
    {
        Text = "Días de teletrabajo";
        Width = 800;
        Height = 480;
        StartPosition = FormStartPosition.CenterParent;
        _todos.CheckedChanged += (_, _) => _empleado.Enabled = !_todos.Checked;
        var consultar = new Button { Text = "Consultar", AutoSize = true };
        consultar.Click += (_, _) => ConsultarSolicitado?.Invoke(this, EventArgs.Empty);
        var campos = new FlowLayoutPanel { Dock = DockStyle.Top, AutoSize = true, Padding = new Padding(8) };
        campos.Controls.AddRange(new Control[] { _todos, _empleado, new Label { Text = "Desde", AutoSize = true },
            _desde, new Label { Text = "Hasta", AutoSize = true }, _hasta, consultar });
        _grilla.Columns.Add(new DataGridViewTextBoxColumn
            { HeaderText = "Código de empleado", DataPropertyName = nameof(DiasTeletrabajoDto.IdEmpleado), Width = 150 });
        _grilla.Columns.Add(new DataGridViewTextBoxColumn
            { HeaderText = "Días de teletrabajo", DataPropertyName = nameof(DiasTeletrabajoDto.Dias), Width = 150 });
        Controls.Add(_grilla);
        Controls.Add(campos);
    }

    /// <inheritdoc/>
    public void MostrarFilas(IReadOnlyList<DiasTeletrabajoDto> filas) => _grilla.DataSource = filas.ToList();

    /// <inheritdoc/>
    public void MostrarError(string mensaje)
    {
        _grilla.DataSource = null;
        MessageBox.Show(this, mensaje, Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
}
