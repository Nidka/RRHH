using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using GRLL.Common;
using Microsoft.VisualBasic.CompilerServices;
using RecursosHumanos.My;

namespace RecursosHumanos;

[DesignerGenerated]
public class FrmLogin : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Login")]
	private ucLogin _Login;

	private bool Ban;

	internal ucLogin Login
	{
		[DebuggerNonUserCode]
		get
		{
			return _Login;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = Login_Load;
			ucLogin.onAceptarEventHandler obj = Login_onAceptar;
			ucLogin.onSalirIntentosEventHandler obj2 = Login_onSalirIntentos;
			ucLogin.onSalirEventHandler obj3 = Login_onCancelar;
			if (_Login != null)
			{
				_Login.Load -= value2;
				_Login.onAceptar -= obj;
				_Login.onSalirIntentos -= obj2;
				_Login.onSalir -= obj3;
			}
			_Login = value;
			if (_Login != null)
			{
				_Login.Load += value2;
				_Login.onAceptar += obj;
				_Login.onSalirIntentos += obj2;
				_Login.onSalir += obj3;
			}
		}
	}

	[DebuggerNonUserCode]
	public FrmLogin()
	{
		base.FormClosing += FrmLogin_FormClosing;
		base.Load += Form1_Load;
		__ENCAddToList(this);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
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
		GRLL.Common.SQLConfiguracion sQLConfiguracion = new GRLL.Common.SQLConfiguracion();
		this.Login = new GRLL.Common.ucLogin();
		this.SuspendLayout();
		this.Login.BackColor = System.Drawing.SystemColors.ButtonHighlight;
		this.Login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		sQLConfiguracion.AutenticacionIntegrada = false;
		sQLConfiguracion.BaseDatos = null;
		sQLConfiguracion.Password = null;
		sQLConfiguracion.Servidor = null;
		sQLConfiguracion.TiempoConexion = 0;
		sQLConfiguracion.Usuario = null;
		this.Login.Configuracion = sQLConfiguracion;
		GRLL.Common.ucLogin login = this.Login;
		System.Drawing.Point location = new System.Drawing.Point(0, 0);
		login.Location = location;
		this.Login.Name = "Login";
		GRLL.Common.ucLogin login2 = this.Login;
		System.Drawing.Size size = new System.Drawing.Size(309, 140);
		login2.Size = size;
		this.Login.TabIndex = 0;
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
		size = new System.Drawing.Size(310, 140);
		this.ClientSize = size;
		this.Controls.Add(this.Login);
		this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		this.MaximizeBox = false;
		this.MinimizeBox = false;
		this.Name = "FrmLogin";
		this.ShowIcon = false;
		this.ShowInTaskbar = false;
		this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Acceso al Sistema";
		this.ResumeLayout(false);
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (!Ban)
		{
			ProjectData.EndApp();
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		SQLConfiguracion sQLConfiguracion = new SQLConfiguracion();
		SQLConfiguracion sQLConfiguracion2 = sQLConfiguracion;
		sQLConfiguracion2.AutenticacionIntegrada = MySettingsProperty.Settings.AutenticacionIntegrada;
		sQLConfiguracion2.BaseDatos = MySettingsProperty.Settings.BaseDatos;
		sQLConfiguracion2.Password = "";
		sQLConfiguracion2.Servidor = MySettingsProperty.Settings.Servidor;
		sQLConfiguracion2.TiempoConexion = MySettingsProperty.Settings.TiempoConexion;
		sQLConfiguracion2.Usuario = MySettingsProperty.Settings.Usuario;
		sQLConfiguracion2 = null;
		Login.BackColor = Color.FromArgb(199, 223, 250);
		Login.MsgColor = Color.FromArgb(199, 223, 250);
		ucLogin login = Login;
		Size msgTamaño = new Size(35, 18);
		login.MsgTamaño = msgTamaño;
		Login.MsgFuente = new Font("TimesNewRoman", 8f, FontStyle.Regular);
		clsConexion.AddConfiguracion(sQLConfiguracion);
	}

	private void Login_onAceptar()
	{
		Ban = true;
		RRHH.LogUser = Login.Configuracion.Usuario;
		List<GRLL_Usuario_AccesoResult> list = Module1.DcGrll.GRLL_Usuario_Acceso(RRHH.Codsys, RRHH.LogUser).ToList();
		if ((list != null && list.Count > 0) ? true : false)
		{
			RRHH.codEmple = Conversions.ToString((int)list[0].idempleado);
			RRHH.IdROl = Conversions.ToString(list[0].idrol);
			if (Conversions.ToDouble(RRHH.IdROl) == 3.0)
			{
				RRHH.Partida = 2;
				RRHH.Bienestar = false;
				RRHH.Asistencias = false;
			}
			else if (Conversions.ToDouble(RRHH.IdROl) == 4.0)
			{
				RRHH.Partida = 1;
				RRHH.Bienestar = false;
				RRHH.Asistencias = false;
			}
			else if (Conversions.ToDouble(RRHH.IdROl) == 5.0)
			{
				RRHH.Bienestar = true;
				RRHH.Asistencias = false;
			}
			else if (Conversions.ToDouble(RRHH.IdROl) == 10.0)
			{
				RRHH.Bienestar = false;
				RRHH.Asistencias = true;
			}
			else if (Conversions.ToDouble(RRHH.IdROl) == 14.0)
			{
				RRHH.Bienestar = false;
				RRHH.Asistencias = true;
			}
			DialogResult = DialogResult.OK;
		}
		else
		{
			MessageBox.Show("No tiene Acceso al Sistema", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	private void Login_onCancelar()
	{
		ProjectData.EndApp();
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	private void Login_onSalirIntentos()
	{
		MessageBox.Show("Nº intentos = 3.\r\nHa superado el número de intentos permitidos.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		ProjectData.EndApp();
	}

	private void Login_Load(object sender, EventArgs e)
	{
	}
}
