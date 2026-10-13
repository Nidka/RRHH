using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace GRLL.Common;

[DesignerGenerated]
public class LoginForm : Form
{
	public delegate void ClickOkEventHandler(ref bool Cancel);

	public delegate void ClickCancelEventHandler(ref bool Cancel);

	[AccessedThroughProperty("lblUserName")]
	private Label _lblUserName;

	[AccessedThroughProperty("lblPassword")]
	private Label _lblPassword;

	private IContainer components;

	[AccessedThroughProperty("txtUsername")]
	private TextBox _txtUsername;

	[AccessedThroughProperty("txtPassword")]
	private TextBox _txtPassword;

	[AccessedThroughProperty("cmdOk")]
	private Button _cmdOk;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("LogoPictureBox")]
	private PictureBox _LogoPictureBox;

	private string cServidor;

	private string cBaseDatos;

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
			_lblUserName = value;
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

	protected internal Button cmdOk
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

	protected internal Button cmdCancel
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

	public virtual PictureBox LogoPictureBox
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

	public string BaseDatos
	{
		get
		{
			return cBaseDatos;
		}
		set
		{
			cBaseDatos = value.Trim();
		}
	}

	public string Servidor
	{
		get
		{
			return cServidor;
		}
		set
		{
			cServidor = value.Trim();
		}
	}

	public string Usuario => txtUsername.Text;

	public string Password => txtPassword.Text;

	[method: DebuggerNonUserCode]
	public event ClickOkEventHandler ClickOk;

	[method: DebuggerNonUserCode]
	public event ClickCancelEventHandler ClickCancel;

	[DebuggerNonUserCode]
	public LoginForm()
	{
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GRLL.Common.LoginForm));
		this.LogoPictureBox = new System.Windows.Forms.PictureBox();
		this.lblUserName = new System.Windows.Forms.Label();
		this.lblPassword = new System.Windows.Forms.Label();
		this.txtUsername = new System.Windows.Forms.TextBox();
		this.txtPassword = new System.Windows.Forms.TextBox();
		this.cmdOk = new System.Windows.Forms.Button();
		this.cmdCancel = new System.Windows.Forms.Button();
		((System.ComponentModel.ISupportInitialize)this.LogoPictureBox).BeginInit();
		this.SuspendLayout();
		this.LogoPictureBox.Image = (System.Drawing.Image)resources.GetObject("LogoPictureBox.Image");
		System.Windows.Forms.PictureBox logoPictureBox = this.LogoPictureBox;
		System.Drawing.Point location = new System.Drawing.Point(0, 0);
		logoPictureBox.Location = location;
		this.LogoPictureBox.Name = "LogoPictureBox";
		System.Windows.Forms.PictureBox logoPictureBox2 = this.LogoPictureBox;
		System.Drawing.Size size = new System.Drawing.Size(168, 197);
		logoPictureBox2.Size = size;
		this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.LogoPictureBox.TabIndex = 0;
		this.LogoPictureBox.TabStop = false;
		System.Windows.Forms.Label label = this.lblUserName;
		location = new System.Drawing.Point(172, 24);
		label.Location = location;
		this.lblUserName.Name = "lblUserName";
		System.Windows.Forms.Label label2 = this.lblUserName;
		size = new System.Drawing.Size(220, 23);
		label2.Size = size;
		this.lblUserName.TabIndex = 0;
		this.lblUserName.Text = "&Nombre de Usuario";
		this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		System.Windows.Forms.Label label3 = this.lblPassword;
		location = new System.Drawing.Point(172, 81);
		label3.Location = location;
		this.lblPassword.Name = "lblPassword";
		System.Windows.Forms.Label label4 = this.lblPassword;
		size = new System.Drawing.Size(220, 23);
		label4.Size = size;
		this.lblPassword.TabIndex = 2;
		this.lblPassword.Text = "&Contraseña";
		this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		System.Windows.Forms.TextBox textBox = this.txtUsername;
		location = new System.Drawing.Point(174, 44);
		textBox.Location = location;
		this.txtUsername.Name = "txtUsername";
		System.Windows.Forms.TextBox textBox2 = this.txtUsername;
		size = new System.Drawing.Size(220, 20);
		textBox2.Size = size;
		this.txtUsername.TabIndex = 1;
		System.Windows.Forms.TextBox textBox3 = this.txtPassword;
		location = new System.Drawing.Point(174, 101);
		textBox3.Location = location;
		this.txtPassword.Name = "txtPassword";
		this.txtPassword.PasswordChar = '*';
		System.Windows.Forms.TextBox textBox4 = this.txtPassword;
		size = new System.Drawing.Size(220, 20);
		textBox4.Size = size;
		this.txtPassword.TabIndex = 3;
		this.cmdOk.BackColor = System.Drawing.SystemColors.Control;
		this.cmdOk.Enabled = false;
		System.Windows.Forms.Button button = this.cmdOk;
		location = new System.Drawing.Point(197, 161);
		button.Location = location;
		this.cmdOk.Name = "cmdOk";
		System.Windows.Forms.Button button2 = this.cmdOk;
		size = new System.Drawing.Size(94, 23);
		button2.Size = size;
		this.cmdOk.TabIndex = 4;
		this.cmdOk.Text = "&Aceptar";
		this.cmdOk.UseVisualStyleBackColor = false;
		this.cmdCancel.BackColor = System.Drawing.SystemColors.Control;
		this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		System.Windows.Forms.Button button3 = this.cmdCancel;
		location = new System.Drawing.Point(300, 161);
		button3.Location = location;
		this.cmdCancel.Name = "cmdCancel";
		System.Windows.Forms.Button button4 = this.cmdCancel;
		size = new System.Drawing.Size(94, 23);
		button4.Size = size;
		this.cmdCancel.TabIndex = 5;
		this.cmdCancel.Text = "&Cancelar";
		this.cmdCancel.UseVisualStyleBackColor = false;
		this.AcceptButton = this.cmdOk;
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(224, 233, 244);
		this.CancelButton = this.cmdCancel;
		size = new System.Drawing.Size(401, 192);
		this.ClientSize = size;
		this.ControlBox = false;
		this.Controls.Add(this.cmdCancel);
		this.Controls.Add(this.cmdOk);
		this.Controls.Add(this.txtPassword);
		this.Controls.Add(this.txtUsername);
		this.Controls.Add(this.lblPassword);
		this.Controls.Add(this.lblUserName);
		this.Controls.Add(this.LogoPictureBox);
		this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
		this.MaximizeBox = false;
		this.MinimizeBox = false;
		this.Name = "LoginForm";
		this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
		this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Acceso";
		((System.ComponentModel.ISupportInitialize)this.LogoPictureBox).EndInit();
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	private void cmdOk_Click(object sender, EventArgs e)
	{
		bool bCancel = true;
		ClickOk?.Invoke(ref bCancel);
		if (bCancel)
		{
			DialogResult = DialogResult.No;
			Close();
		}
		Close();
	}

	private void cmdCancel_Click(object sender, EventArgs e)
	{
		bool bCancel = false;
		ClickCancel?.Invoke(ref bCancel);
		if (!bCancel)
		{
			DialogResult = DialogResult.Cancel;
		}
	}

	private void txtUsername_TextChanged(object sender, EventArgs e)
	{
		cmdOk.Enabled = txtUsername.Text.Length > 0;
	}
}
