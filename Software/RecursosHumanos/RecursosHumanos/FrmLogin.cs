using System;
using System.Drawing;
using System.Windows.Forms;
using RecursosHumanos.Data;

namespace RecursosHumanos;

/// <summary>
/// Acceso inicial conectado a PostgreSQL. La contraseña de base de datos se
/// configura fuera de la interfaz mediante RRHH_POSTGRES_CONNECTION.
/// </summary>
public sealed class FrmLogin : Form
{
	private readonly TextBox _userName = new TextBox();
	private readonly Label _status = new Label();
	private readonly Button _accept = new Button();
	private readonly Button _cancel = new Button();

	public string EmployeeDisplayName { get; private set; }

	public FrmLogin()
	{
		InitializeComponent();
	}

	private void InitializeComponent()
	{
		Text = "Acceso al Sistema - PostgreSQL";
		StartPosition = FormStartPosition.CenterParent;
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MaximizeBox = false;
		MinimizeBox = false;
		ShowInTaskbar = false;
		ClientSize = new Size(390, 175);
		BackColor = Color.FromArgb(199, 223, 250);

		Label title = new Label
		{
			AutoSize = true,
			Font = new Font(Font, FontStyle.Bold),
			Location = new Point(22, 18),
			Text = "Ingrese su usuario del sistema RRHH"
		};

		Label userLabel = new Label
		{
			AutoSize = true,
			Location = new Point(22, 56),
			Text = "Usuario:"
		};

		_userName.Location = new Point(100, 52);
		_userName.Size = new Size(260, 23);
		_userName.MaxLength = 20;
		_userName.KeyDown += UserName_KeyDown;

		_status.AutoEllipsis = true;
		_status.ForeColor = Color.DarkSlateGray;
		_status.Location = new Point(22, 87);
		_status.Size = new Size(338, 35);
		_status.Text = "La conexión se validará contra PostgreSQL.";

		_accept.Location = new Point(196, 132);
		_accept.Size = new Size(78, 27);
		_accept.Text = "Aceptar";
		_accept.Click += Accept_Click;

		_cancel.DialogResult = DialogResult.Cancel;
		_cancel.Location = new Point(282, 132);
		_cancel.Size = new Size(78, 27);
		_cancel.Text = "Salir";

		AcceptButton = _accept;
		CancelButton = _cancel;
		Controls.Add(title);
		Controls.Add(userLabel);
		Controls.Add(_userName);
		Controls.Add(_status);
		Controls.Add(_accept);
		Controls.Add(_cancel);
	}

	private void UserName_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Enter)
		{
			Accept_Click(sender, EventArgs.Empty);
			e.SuppressKeyPress = true;
		}
	}

	private void Accept_Click(object sender, EventArgs e)
	{
		string login = _userName.Text.Trim();
		if (login.Length == 0)
		{
			_status.Text = "Escriba un usuario.";
			_userName.Focus();
			return;
		}

		_accept.Enabled = false;
		_status.Text = "Conectando con PostgreSQL...";
		Cursor = Cursors.WaitCursor;

		try
		{
			Module1.PostgreSql.VerifySchema();
			UserAccess access = Module1.Users.FindAccess(RRHH.Codsys, login);
			if (access == null || !access.EmployeeId.HasValue)
			{
				_status.Text = "El usuario no está activo o no tiene acceso a RRHH.";
				return;
			}

			ApplyAccess(access);
			DialogResult = DialogResult.OK;
			Close();
		}
		catch (Exception exception)
		{
			_status.Text = "No fue posible conectar con PostgreSQL.";
			MessageBox.Show(
				"Revise RRHH_POSTGRES_CONNECTION y que la base CMI esté disponible.\r\n\r\n" +
				exception.Message,
				"Conexión PostgreSQL",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error);
		}
		finally
		{
			Cursor = Cursors.Default;
			_accept.Enabled = true;
		}
	}

	private void ApplyAccess(UserAccess access)
	{
		RRHH.LogUser = access.Login;
		RRHH.codEmple = access.EmployeeId.Value.ToString();
		RRHH.IdROl = access.RoleId.ToString();
		RRHH.Partida = 0;
		RRHH.Bienestar = false;
		RRHH.Asistencias = false;
		EmployeeDisplayName = string.IsNullOrWhiteSpace(access.EmployeeName)
			? access.Login
			: access.EmployeeName;

		switch (access.RoleId)
		{
			case 3:
				RRHH.Partida = 2;
				break;
			case 4:
				RRHH.Partida = 1;
				break;
			case 5:
				RRHH.Bienestar = true;
				break;
			case 10:
			case 14:
				RRHH.Asistencias = true;
				break;
		}
	}
}
