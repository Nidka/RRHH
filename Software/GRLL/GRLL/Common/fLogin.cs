using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace GRLL.Common;

[DesignerGenerated]
public class fLogin : Form
{
	public enum Origen
	{
		ArchivoINI,
		AppSettings
	}

	private IContainer components;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("cmdOk")]
	private Button _cmdOk;

	[AccessedThroughProperty("txtPassword")]
	private TextBox _txtPassword;

	[AccessedThroughProperty("txtUsername")]
	private TextBox _txtUsername;

	[AccessedThroughProperty("lblPassword")]
	private Label _lblPassword;

	[AccessedThroughProperty("lblUserName")]
	private Label _lblUserName;

	[AccessedThroughProperty("LogoPictureBox")]
	private PictureBox _LogoPictureBox;

	private string _RutaIni;

	private clsLogin oLogin;

	private SettingLogin _Settings;

	private Origen _tipoorigen;

	protected virtual Button cmdCancel
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdCancel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = cmdCancel_Click;
			if (_cmdCancel != null)
			{
				_cmdCancel.Click -= value2;
			}
			_cmdCancel = value;
			if (_cmdCancel != null)
			{
				_cmdCancel.Click += value2;
			}
		}
	}

	protected virtual Button cmdOk
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdOk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = cmdOk_Click;
			if (_cmdOk != null)
			{
				_cmdOk.Click -= value2;
			}
			_cmdOk = value;
			if (_cmdOk != null)
			{
				_cmdOk.Click += value2;
			}
		}
	}

	protected virtual TextBox txtPassword
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtPassword;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtPassword = value;
		}
	}

	protected virtual TextBox txtUsername
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtUsername;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = txtUsername_TextChanged;
			if (_txtUsername != null)
			{
				_txtUsername.TextChanged -= value2;
			}
			_txtUsername = value;
			if (_txtUsername != null)
			{
				_txtUsername.TextChanged += value2;
			}
		}
	}

	internal Label lblPassword
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblPassword;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblPassword = value;
		}
	}

	internal Label lblUserName
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblUserName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = lblUserName_Click;
			if (_lblUserName != null)
			{
				_lblUserName.Click -= value2;
			}
			_lblUserName = value;
			if (_lblUserName != null)
			{
				_lblUserName.Click += value2;
			}
		}
	}

	internal PictureBox LogoPictureBox
	{
		[DebuggerNonUserCode]
		get
		{
			return _LogoPictureBox;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LogoPictureBox = value;
		}
	}

	public Origen TipoOrigen
	{
		get
		{
			return _tipoorigen;
		}
		set
		{
			_tipoorigen = value;
		}
	}

	public SettingLogin Settings
	{
		get
		{
			return _Settings;
		}
		set
		{
			_Settings = value;
		}
	}

	public string PathIniFile
	{
		get
		{
			return _RutaIni;
		}
		set
		{
			_RutaIni = value;
		}
	}

	public object Login => oLogin;

	public fLogin()
	{
		base.Load += fLogin_Load;
		oLogin = new clsLogin();
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	[System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GRLL.Common.fLogin));
		this.cmdCancel = new System.Windows.Forms.Button();
		this.cmdOk = new System.Windows.Forms.Button();
		this.txtPassword = new System.Windows.Forms.TextBox();
		this.txtUsername = new System.Windows.Forms.TextBox();
		this.lblPassword = new System.Windows.Forms.Label();
		this.lblUserName = new System.Windows.Forms.Label();
		this.LogoPictureBox = new System.Windows.Forms.PictureBox();
		((System.ComponentModel.ISupportInitialize)this.LogoPictureBox).BeginInit();
		this.SuspendLayout();
		this.cmdCancel.BackColor = System.Drawing.SystemColors.Control;
		this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		System.Windows.Forms.Button button = this.cmdCancel;
		System.Drawing.Point location = new System.Drawing.Point(258, 160);
		button.Location = location;
		this.cmdCancel.Name = "cmdCancel";
		System.Windows.Forms.Button button2 = this.cmdCancel;
		System.Drawing.Size size = new System.Drawing.Size(77, 23);
		button2.Size = size;
		this.cmdCancel.TabIndex = 12;
		this.cmdCancel.Text = "&Cancelar";
		this.cmdCancel.UseVisualStyleBackColor = false;
		this.cmdOk.BackColor = System.Drawing.SystemColors.Control;
		this.cmdOk.Enabled = false;
		System.Windows.Forms.Button button3 = this.cmdOk;
		location = new System.Drawing.Point(175, 160);
		button3.Location = location;
		this.cmdOk.Name = "cmdOk";
		System.Windows.Forms.Button button4 = this.cmdOk;
		size = new System.Drawing.Size(77, 23);
		button4.Size = size;
		this.cmdOk.TabIndex = 11;
		this.cmdOk.Text = "&Aceptar";
		this.cmdOk.UseVisualStyleBackColor = false;
		System.Windows.Forms.TextBox textBox = this.txtPassword;
		location = new System.Drawing.Point(174, 100);
		textBox.Location = location;
		this.txtPassword.Name = "txtPassword";
		this.txtPassword.PasswordChar = '*';
		System.Windows.Forms.TextBox textBox2 = this.txtPassword;
		size = new System.Drawing.Size(178, 20);
		textBox2.Size = size;
		this.txtPassword.TabIndex = 10;
		System.Windows.Forms.TextBox textBox3 = this.txtUsername;
		location = new System.Drawing.Point(174, 43);
		textBox3.Location = location;
		this.txtUsername.Name = "txtUsername";
		System.Windows.Forms.TextBox textBox4 = this.txtUsername;
		size = new System.Drawing.Size(178, 20);
		textBox4.Size = size;
		this.txtUsername.TabIndex = 8;
		System.Windows.Forms.Label label = this.lblPassword;
		location = new System.Drawing.Point(172, 80);
		label.Location = location;
		this.lblPassword.Name = "lblPassword";
		System.Windows.Forms.Label label2 = this.lblPassword;
		size = new System.Drawing.Size(220, 23);
		label2.Size = size;
		this.lblPassword.TabIndex = 9;
		this.lblPassword.Text = "&Contraseña";
		this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		System.Windows.Forms.Label label3 = this.lblUserName;
		location = new System.Drawing.Point(172, 23);
		label3.Location = location;
		this.lblUserName.Name = "lblUserName";
		System.Windows.Forms.Label label4 = this.lblUserName;
		size = new System.Drawing.Size(220, 23);
		label4.Size = size;
		this.lblUserName.TabIndex = 6;
		this.lblUserName.Text = "&Nombre de Usuario";
		this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.LogoPictureBox.Image = (System.Drawing.Image)resources.GetObject("LogoPictureBox.Image");
		System.Windows.Forms.PictureBox logoPictureBox = this.LogoPictureBox;
		location = new System.Drawing.Point(0, -1);
		logoPictureBox.Location = location;
		this.LogoPictureBox.Name = "LogoPictureBox";
		System.Windows.Forms.PictureBox logoPictureBox2 = this.LogoPictureBox;
		size = new System.Drawing.Size(168, 197);
		logoPictureBox2.Size = size;
		this.LogoPictureBox.TabIndex = 7;
		this.LogoPictureBox.TabStop = false;
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		size = new System.Drawing.Size(356, 195);
		this.ClientSize = size;
		this.Controls.Add(this.cmdCancel);
		this.Controls.Add(this.cmdOk);
		this.Controls.Add(this.txtPassword);
		this.Controls.Add(this.txtUsername);
		this.Controls.Add(this.lblPassword);
		this.Controls.Add(this.lblUserName);
		this.Controls.Add(this.LogoPictureBox);
		this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		this.MaximizeBox = false;
		this.MinimizeBox = false;
		this.Name = "fLogin";
		this.ShowIcon = false;
		this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Acceso...";
		((System.ComponentModel.ISupportInitialize)this.LogoPictureBox).EndInit();
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	private void fLogin_Load(object sender, EventArgs e)
	{
		if (TipoOrigen == Origen.ArchivoINI)
		{
			clsLogin clsLogin2 = oLogin;
			clsLogin2.LoadFromIni(_RutaIni);
			clsLogin2 = null;
		}
		else if (TipoOrigen == Origen.AppSettings)
		{
			if (_Settings == null)
			{
				throw new Exception("Error: no se ha asignado los parametros de Conexión");
			}
			clsLogin clsLogin3 = oLogin;
			clsLogin3.Servidor = _Settings.Servidor;
			clsLogin3.BaseDatos = _Settings.BaseDatos;
			clsLogin3.Usuario = _Settings.Usuario;
			clsLogin3.AutenticacionIntegrada = _Settings.SeguridadIntegrada;
			clsLogin3 = null;
		}
		txtUsername.Text = oLogin.Usuario;
	}

	private void cmdOk_Click(object sender, EventArgs e)
	{
		clsLogin clsLogin2 = oLogin;
		clsLogin2.Usuario = txtUsername.Text.Trim();
		clsLogin2.Password = txtPassword.Text.Trim();
		if (clsLogin2.ConectarSql(clsLogin2.AutenticacionIntegrada))
		{
			DialogResult = DialogResult.OK;
			if (clsLogin2.Connection != null)
			{
				clsLogin2.Connection.Close();
				clsLogin2.Connection.Dispose();
			}
			if (_tipoorigen == Origen.ArchivoINI)
			{
				clsLogin2.WriteToIni();
			}
		}
		clsLogin2 = null;
	}

	private void cmdCancel_Click(object sender, EventArgs e)
	{
		DialogResult = DialogResult.Cancel;
	}

	private void txtUsername_TextChanged(object sender, EventArgs e)
	{
		if (txtUsername.Text.Trim().Length == 0)
		{
			cmdOk.Enabled = false;
		}
		else
		{
			cmdOk.Enabled = true;
		}
	}

	private void lblUserName_Click(object sender, EventArgs e)
	{
	}
}
