using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using RRHH.Application.Permisos;
using RRHH.Presentation.Permisos;

namespace RecursosHumanos;

/// <summary>
/// RF-18: reporte de personas ausentes (vacaciones, licencia, enfermedad u otros motivos) entre dos fechas.
/// Vista pasiva de <see cref="RepAusenciasPresenter"/>: no consulta datos ni aplica reglas, solo captura el
/// periodo y el motivo y muestra el resultado. Se crea con <c>CompositionRoot.CrearRepAusencias</c>.
/// </summary>
/// <remarks>
/// Formulario nuevo escrito a mano (sin base heredada ni DevExpress): no reemplaza a <c>FrmRepPermisos</c>, que
/// sigue siendo el reporte imprimible de permisos por fecha de inicio.
/// </remarks>
public sealed class FrmRepAusencias : Form, IRepAusenciasView
{
	private const string TextoTodosLosMotivos = "(Todos los motivos)";

	private readonly DateTimePicker _dtpDesde = new DateTimePicker();
	private readonly DateTimePicker _dtpHasta = new DateTimePicker();
	private readonly ComboBox _cboMotivo = new ComboBox();
	private readonly Button _btnConsultar = new Button();
	private readonly DataGridView _grid = new DataGridView();
	private readonly Label _lblResumen = new Label();

	public event EventHandler CargarSolicitado;

	public event EventHandler ConsultarSolicitado;

	public FrmRepAusencias()
	{
		Text = "Ausencias por periodo";
		ClientSize = new Size(760, 460);
		MinimumSize = new Size(640, 360);
		StartPosition = FormStartPosition.CenterParent;
		Font = new Font("Microsoft Sans Serif", 8.25f);

		DateTime hoy = DateTime.Today;
		_dtpDesde.Format = DateTimePickerFormat.Short;
		_dtpHasta.Format = DateTimePickerFormat.Short;
		_dtpDesde.Value = new DateTime(hoy.Year, hoy.Month, 1);
		_dtpHasta.Value = new DateTime(hoy.Year, hoy.Month, DateTime.DaysInMonth(hoy.Year, hoy.Month));
		_cboMotivo.DropDownStyle = ComboBoxStyle.DropDownList;
		_cboMotivo.DisplayMember = nameof(MotivoAusenciaDto.Descripcion);
		_cboMotivo.ValueMember = nameof(MotivoAusenciaDto.Id);
		_btnConsultar.Text = "Consultar";
		_btnConsultar.Click += (_, _) => ConsultarSolicitado?.Invoke(this, EventArgs.Empty);

		Panel filtros = new Panel { Dock = DockStyle.Top, Height = 64 };
		filtros.Controls.Add(CrearEtiqueta("Desde:", 12, 10));
		filtros.Controls.Add(Ubicar(_dtpDesde, 12, 28, 110));
		filtros.Controls.Add(CrearEtiqueta("Hasta:", 134, 10));
		filtros.Controls.Add(Ubicar(_dtpHasta, 134, 28, 110));
		filtros.Controls.Add(CrearEtiqueta("Motivo:", 256, 10));
		filtros.Controls.Add(Ubicar(_cboMotivo, 256, 28, 260));
		filtros.Controls.Add(Ubicar(_btnConsultar, 530, 26, 90));

		_lblResumen.Dock = DockStyle.Bottom;
		_lblResumen.Height = 24;
		_lblResumen.TextAlign = ContentAlignment.MiddleLeft;
		_lblResumen.Padding = new Padding(12, 0, 0, 0);

		ConfigurarGrid();

		Controls.Add(_grid);
		Controls.Add(_lblResumen);
		Controls.Add(filtros);
		AcceptButton = _btnConsultar;

		Load += (_, _) => CargarSolicitado?.Invoke(this, EventArgs.Empty);
	}

	public DateTime Desde => _dtpDesde.Value.Date;

	public DateTime Hasta => _dtpHasta.Value.Date;

	public int? MotivoSeleccionado
	{
		get
		{
			MotivoAusenciaDto motivo = _cboMotivo.SelectedItem as MotivoAusenciaDto;
			return motivo != null && motivo.Id > 0 ? motivo.Id : (int?)null;
		}
	}

	public void MostrarMotivos(IReadOnlyList<MotivoAusenciaDto> motivos)
	{
		List<MotivoAusenciaDto> opciones = new List<MotivoAusenciaDto>
		{
			new MotivoAusenciaDto { Id = 0, Descripcion = TextoTodosLosMotivos }
		};
		opciones.AddRange(motivos);
		_cboMotivo.DataSource = opciones;
		_cboMotivo.SelectedIndex = 0;
	}

	public void MostrarAusencias(IReadOnlyList<AusenciaPorPeriodoDto> ausencias)
	{
		_grid.DataSource = ausencias.ToList();
	}

	public void MostrarResumen(string resumen)
	{
		_lblResumen.Text = resumen;
	}

	public void HabilitarConsulta(bool habilitada)
	{
		_btnConsultar.Enabled = habilitada;
	}

	public void MostrarError(string mensaje)
	{
		MessageBox.Show(this, mensaje, "Ausencias por periodo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
	}

	private void ConfigurarGrid()
	{
		_grid.Dock = DockStyle.Fill;
		_grid.AutoGenerateColumns = false;
		_grid.ReadOnly = true;
		_grid.AllowUserToAddRows = false;
		_grid.AllowUserToDeleteRows = false;
		_grid.RowHeadersVisible = false;
		_grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		_grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		_grid.Columns.Add(CrearColumna("Persona", nameof(AusenciaPorPeriodoDto.Empleado), 35, null));
		_grid.Columns.Add(CrearColumna("Motivo", nameof(AusenciaPorPeriodoDto.Motivo), 25, null));
		_grid.Columns.Add(CrearColumna("Inicio", nameof(AusenciaPorPeriodoDto.Inicio), 14, "dd/MM/yyyy"));
		_grid.Columns.Add(CrearColumna("Fin", nameof(AusenciaPorPeriodoDto.Fin), 14, "dd/MM/yyyy"));
		_grid.Columns.Add(CrearColumna("Días en el periodo", nameof(AusenciaPorPeriodoDto.DiasEnPeriodo), 12, null));
	}

	private static DataGridViewTextBoxColumn CrearColumna(string titulo, string propiedad, float peso, string formato)
	{
		DataGridViewTextBoxColumn columna = new DataGridViewTextBoxColumn
		{
			HeaderText = titulo,
			DataPropertyName = propiedad,
			FillWeight = peso
		};
		if (formato != null)
		{
			columna.DefaultCellStyle.Format = formato;
		}

		return columna;
	}

	private static Label CrearEtiqueta(string texto, int x, int y)
	{
		return new Label { Text = texto, Left = x, Top = y, AutoSize = true };
	}

	private static Control Ubicar(Control control, int x, int y, int ancho)
	{
		control.Left = x;
		control.Top = y;
		control.Width = ancho;
		return control;
	}
}
