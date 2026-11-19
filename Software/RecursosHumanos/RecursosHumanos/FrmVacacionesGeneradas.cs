using System;
using System.Drawing;
using System.Windows.Forms;
using RRHH.Application.Asistencia;
using RRHH.Presentation.Asistencia;

namespace RecursosHumanos;

/// <summary>Vista pasiva WinForms de RF-07 con el régimen académico indicado en el resultado.</summary>
public sealed class FrmVacacionesGeneradas : Form, IVacacionesGeneradasView
{
    private readonly NumericUpDown _empleado = new NumericUpDown { Minimum = 1, Maximum = int.MaxValue };
    private readonly DateTimePicker _corte = new DateTimePicker { Format = DateTimePickerFormat.Short };
    private readonly Label _resultado = new Label { Dock = DockStyle.Fill, Padding = new Padding(12), Font = new Font("Arial", 12) };

    public int Empleado => (int)_empleado.Value;
    public DateTime Corte => _corte.Value.Date;
    public event EventHandler ConsultarSolicitado;

    /// <summary>Construye los controles de consulta sin acceso a datos.</summary>
    public FrmVacacionesGeneradas()
    {
        Text = "Vacaciones generadas del piloto";
        Width = 640;
        Height = 300;
        StartPosition = FormStartPosition.CenterParent;
        var boton = new Button { Text = "Consultar", AutoSize = true };
        boton.Click += (_, _) => ConsultarSolicitado?.Invoke(this, EventArgs.Empty);
        var filtros = new FlowLayoutPanel { Dock = DockStyle.Top, AutoSize = true, Padding = new Padding(8) };
        filtros.Controls.AddRange(new Control[] { new Label { Text = "Empleado", AutoSize = true }, _empleado,
            new Label { Text = "Corte", AutoSize = true }, _corte, boton });
        Controls.Add(_resultado);
        Controls.Add(filtros);
        AcceptButton = boton;
    }

    /// <inheritdoc/>
    public void Mostrar(VacacionesGeneradasDto resultado) =>
        _resultado.Text = resultado == null ? "" :
            $"Ingreso {resultado.Ingreso:dd/MM/yyyy}\r\nCorte {resultado.Corte:dd/MM/yyyy}\r\n" +
            $"Años cumplidos {resultado.AniosCumplidos}\r\nDías por año {resultado.DiasAnuales:0.##}\r\n" +
            $"Vacaciones generadas {resultado.Generadas:0.##} días calendario";

    /// <inheritdoc/>
    public void MostrarError(string mensaje) => MessageBox.Show(this, mensaje, Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
}
