using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using RRHH.PostgreSql;

namespace GRLL.Common;

/// <summary>
/// Selector compatible con el control heredado que carga los ubigeos desde PostgreSQL.
/// </summary>
public class ucUbigeoCmb : UserControl
{
	private readonly ComboBox _departamento;
	private readonly ComboBox _provincia;
	private readonly ComboBox _distrito;
	private readonly PostgreSqlExecutor _database;
	private DataTable _ubigeos;
	private string _ubigeo = "000000";
	private bool _loading;

	// Compatibilidad con el diseñador heredado; PostgreSQL se configura desde .env.
	public object Conexion { get; set; }

	public string Ubigeo
	{
		get => _ubigeo;
		set
		{
			_ubigeo = Normalize(value);
			if (_ubigeos != null)
			{
				SelectUbigeo(_ubigeo);
			}
		}
	}

	public ucUbigeoCmb()
	{
		_database = new PostgreSqlExecutor();
		Size = new Size(304, 89);
		BackColor = Color.Transparent;

		_departamento = CreateComboBox(105, 7, 195);
		_provincia = CreateComboBox(105, 34, 195);
		_distrito = CreateComboBox(105, 61, 195);

		Controls.Add(CreateLabel("Departamento:", 7, 10, 95));
		Controls.Add(CreateLabel("Provincia:", 32, 37, 70));
		Controls.Add(CreateLabel("Distrito:", 44, 64, 58));
		Controls.Add(_departamento);
		Controls.Add(_provincia);
		Controls.Add(_distrito);

		_departamento.SelectedIndexChanged += DepartamentoChanged;
		_provincia.SelectedIndexChanged += ProvinciaChanged;
		_distrito.SelectedIndexChanged += DistritoChanged;
	}

	public void GetDpto()
	{
		_ubigeos = _database.Query(@"
SELECT ""IdUbigeo"", ""Departamento"", ""Provincia"", ""Distrito"", ""Descripcion""
FROM public.""Ubigeo""
ORDER BY ""Descripcion"";");

		_loading = true;
		try
		{
			Bind(_departamento, "Provincia = '00' AND Distrito = '00'", "Departamento");
		}
		finally
		{
			_loading = false;
		}

		SelectUbigeo(_ubigeo);
	}

	private static ComboBox CreateComboBox(int x, int y, int width) => new ComboBox
	{
		DropDownStyle = ComboBoxStyle.DropDownList,
		Location = new Point(x, y),
		Size = new Size(width, 21),
		DisplayMember = "Descripcion"
	};

	private static Label CreateLabel(string text, int x, int y, int width) => new Label
	{
		AutoSize = false,
		Location = new Point(x, y),
		Size = new Size(width, 18),
		Text = text,
		TextAlign = ContentAlignment.MiddleRight
	};

	private void DepartamentoChanged(object sender, EventArgs e)
	{
		if (_loading || _departamento.SelectedValue == null)
		{
			return;
		}

		string departamento = Convert.ToString(_departamento.SelectedValue);
		_loading = true;
		try
		{
			Bind(_provincia, $"Departamento = '{Escape(departamento)}' AND Provincia <> '00' AND Distrito = '00'", "Provincia");
			Bind(_distrito, "1 = 0", "Distrito");
			_ubigeo = departamento + "0000";
		}
		finally
		{
			_loading = false;
		}
	}

	private void ProvinciaChanged(object sender, EventArgs e)
	{
		if (_loading || _departamento.SelectedValue == null || _provincia.SelectedValue == null)
		{
			return;
		}

		string departamento = Convert.ToString(_departamento.SelectedValue);
		string provincia = Convert.ToString(_provincia.SelectedValue);
		_loading = true;
		try
		{
			Bind(_distrito, $"Departamento = '{Escape(departamento)}' AND Provincia = '{Escape(provincia)}' AND Distrito <> '00'", "Distrito");
			_ubigeo = departamento + provincia + "00";
		}
		finally
		{
			_loading = false;
		}
	}

	private void DistritoChanged(object sender, EventArgs e)
	{
		if (_loading || _departamento.SelectedValue == null || _provincia.SelectedValue == null || _distrito.SelectedValue == null)
		{
			return;
		}

		_ubigeo = Convert.ToString(_departamento.SelectedValue)
			+ Convert.ToString(_provincia.SelectedValue)
			+ Convert.ToString(_distrito.SelectedValue);
	}

	private void SelectUbigeo(string value)
	{
		if (_ubigeos == null)
		{
			return;
		}

		string normalized = Normalize(value);
		_loading = true;
		try
		{
			_departamento.SelectedValue = normalized.Substring(0, 2);
			Bind(_provincia, $"Departamento = '{Escape(normalized.Substring(0, 2))}' AND Provincia <> '00' AND Distrito = '00'", "Provincia");
			_provincia.SelectedValue = normalized.Substring(2, 2);
			Bind(_distrito, $"Departamento = '{Escape(normalized.Substring(0, 2))}' AND Provincia = '{Escape(normalized.Substring(2, 2))}' AND Distrito <> '00'", "Distrito");
			_distrito.SelectedValue = normalized.Substring(4, 2);
			_ubigeo = normalized;
		}
		finally
		{
			_loading = false;
		}
	}

	private void Bind(ComboBox comboBox, string filter, string valueMember)
	{
		DataView view = new DataView(_ubigeos, filter, "Descripcion ASC", DataViewRowState.CurrentRows);
		comboBox.DataSource = null;
		comboBox.DisplayMember = "Descripcion";
		comboBox.ValueMember = valueMember;
		comboBox.DataSource = view;
		comboBox.SelectedIndex = -1;
	}

	private static string Normalize(string value)
	{
		string result = (value ?? string.Empty).Trim();
		if (result.Length > 6)
		{
			result = result.Substring(0, 6);
		}

		return result.PadRight(6, '0');
	}

	private static string Escape(string value) => (value ?? string.Empty).Replace("'", "''");
}
