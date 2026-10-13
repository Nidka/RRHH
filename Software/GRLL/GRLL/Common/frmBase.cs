using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GRLL.Common;

[DesignerGenerated]
public class frmBase : Form
{
	public delegate void CloseFormEventHandler(ref bool Cancelar);

	public delegate void ReubicaCtrlsEventHandler();

	private IContainer components;

	[AccessedThroughProperty("lblTitle")]
	private Label _lblTitle;

	[AccessedThroughProperty("lblMessage")]
	private Label _lblMessage;

	[AccessedThroughProperty("cmdCerrar")]
	private Button _cmdCerrar;

	[AccessedThroughProperty("cmdCalc")]
	private Button _cmdCalc;

	[AccessedThroughProperty("PanelSup")]
	private Panel _PanelSup;

	[AccessedThroughProperty("PanelInf")]
	private Panel _PanelInf;

	[AccessedThroughProperty("LBL_TITULO_1")]
	private ucLabel _LBL_TITULO_1;

	[AccessedThroughProperty("LBL_TITULO_0")]
	private Label _LBL_TITULO_0;

	private bool bGradientShow;

	private Color nGradColor1;

	private Color nGradColor2;

	private LinearGradientMode nGradModo;

	private Color nGradColor1PanelSup;

	private Color nGradColor2PanelSup;

	private Color nGradColor1PanelInf;

	private Color nGradColor2PanelInf;

	private LinearGradientMode nGradModoPanelSup;

	private LinearGradientMode nGradModoPanelInf;

	private bool bSalirConfirmar;

	public bool GuardarySalir;

	private string sTextFrm;

	private bool bVerCal;

	private Point iubicaCalc;

	private DockStyle sDock;

	private bool bVerPanelInf;

	private bool bVerPanelSup;

	private bool bVerTituloFrm;

	private string sTituloFrm;

	private Point iTituloFrmubica;

	private int iPoscmdCerrarY;

	private bool bVerCmdCerrar;

	internal Label lblTitle
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTitle;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTitle = value;
		}
	}

	internal Label lblMessage
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMessage;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMessage = value;
		}
	}

	protected virtual Button cmdCerrar
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdCerrar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = cmdCerrar_Click;
			if (_cmdCerrar != null)
			{
				_cmdCerrar.Click -= value2;
			}
			_cmdCerrar = value;
			if (_cmdCerrar != null)
			{
				_cmdCerrar.Click += value2;
			}
		}
	}

	internal Button cmdCalc
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdCalc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = cmdCalc_Click;
			if (_cmdCalc != null)
			{
				_cmdCalc.Click -= value2;
			}
			_cmdCalc = value;
			if (_cmdCalc != null)
			{
				_cmdCalc.Click += value2;
			}
		}
	}

	public virtual Panel PanelSup
	{
		[DebuggerNonUserCode]
		get
		{
			return _PanelSup;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PanelSup = value;
		}
	}

	public virtual Panel PanelInf
	{
		[DebuggerNonUserCode]
		get
		{
			return _PanelInf;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PanelInf = value;
		}
	}

	private ucLabel LBL_TITULO_1
	{
		[DebuggerNonUserCode]
		get
		{
			return _LBL_TITULO_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LBL_TITULO_1 = value;
		}
	}

	private Label LBL_TITULO_0
	{
		[DebuggerNonUserCode]
		get
		{
			return _LBL_TITULO_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LBL_TITULO_0 = value;
		}
	}

	public Point TituloFrmUbica
	{
		get
		{
			return iTituloFrmubica;
		}
		set
		{
			iTituloFrmubica = value;
			LBL_TITULO_1.Location = iTituloFrmubica;
			Label lBL_TITULO_ = LBL_TITULO_0;
			Point location = checked(new Point(iTituloFrmubica.X + 1, iTituloFrmubica.Y - 2));
			lBL_TITULO_.Location = location;
		}
	}

	public string TituloFrm
	{
		get
		{
			return sTituloFrm;
		}
		set
		{
			sTituloFrm = value;
			LBL_TITULO_0.Text = sTituloFrm;
			LBL_TITULO_1.Text = sTituloFrm;
		}
	}

	public bool TituloFrmVer
	{
		get
		{
			return bVerTituloFrm;
		}
		set
		{
			bVerTituloFrm = value;
			LBL_TITULO_0.Visible = bVerTituloFrm;
			LBL_TITULO_1.Visible = bVerTituloFrm;
			checked
			{
				if (bVerTituloFrm)
				{
					LBL_TITULO_1.Location = iTituloFrmubica;
					Label lBL_TITULO_ = LBL_TITULO_0;
					Point location = new Point(iTituloFrmubica.X + 1, iTituloFrmubica.Y - 2);
					lBL_TITULO_.Location = location;
				}
				else
				{
					Label lBL_TITULO_2 = LBL_TITULO_0;
					Point location = new Point(iTituloFrmubica.X, iTituloFrmubica.Y - 200);
					lBL_TITULO_2.Location = location;
					Label lBL_TITULO_3 = LBL_TITULO_0;
					location = new Point(iTituloFrmubica.X + 1, iTituloFrmubica.Y - 2 - 200);
					lBL_TITULO_3.Location = location;
				}
			}
		}
	}

	public bool VerPanelSup
	{
		get
		{
			return bVerPanelSup;
		}
		set
		{
			bVerPanelSup = value;
			PanelSup.Visible = bVerPanelSup;
			if (bVerPanelSup)
			{
				PanelSup.Dock = DockStyle.Top;
			}
			else
			{
				PanelSup.Dock = DockStyle.None;
				PanelSup.Top = checked(-(PanelSup.Height * 2));
			}
			ReubicaCtrls?.Invoke();
		}
	}

	public bool VerPanelInf
	{
		get
		{
			return bVerPanelInf;
		}
		set
		{
			bVerPanelInf = value;
			PanelInf.Visible = bVerPanelInf;
			if (bVerPanelInf)
			{
				PanelInf.Dock = DockStyle.Bottom;
			}
			else
			{
				PanelInf.Dock = DockStyle.None;
				PanelInf.Top = checked(-(PanelInf.Height * 2));
			}
			ReubicaCtrls?.Invoke();
		}
	}

	public DockStyle CalcDock
	{
		get
		{
			return sDock;
		}
		set
		{
			sDock = value;
			cmdCalc.Dock = sDock;
		}
	}

	public bool Calculadora
	{
		get
		{
			return bVerCal;
		}
		set
		{
			bVerCal = value;
			cmdCalc.Visible = bVerCal;
		}
	}

	public bool VerCmdCerrar
	{
		get
		{
			return cmdCerrar.Visible;
		}
		set
		{
			bVerCmdCerrar = value;
			cmdCerrar.Visible = value;
		}
	}

	public Point CalcUbicac
	{
		get
		{
			return iubicaCalc;
		}
		set
		{
			iubicaCalc = value;
			cmdCalc.Location = iubicaCalc;
		}
	}

	public string TextFrm
	{
		get
		{
			return sTextFrm;
		}
		set
		{
			sTextFrm = value;
			Text = sTextFrm;
		}
	}

	public bool SalirConfirmar
	{
		get
		{
			return bSalirConfirmar;
		}
		set
		{
			bSalirConfirmar = value;
		}
	}

	public LinearGradientMode GradModo
	{
		get
		{
			return nGradModo;
		}
		set
		{
			nGradModo = value;
			Pintar();
		}
	}

	public LinearGradientMode GradModoPanelSup
	{
		get
		{
			return nGradModoPanelSup;
		}
		set
		{
			nGradModoPanelSup = value;
			Pintar();
		}
	}

	public LinearGradientMode GradModoPanelInf
	{
		get
		{
			return nGradModoPanelInf;
		}
		set
		{
			nGradModoPanelInf = value;
			Pintar();
		}
	}

	public bool GradienteShow
	{
		get
		{
			return bGradientShow;
		}
		set
		{
			bGradientShow = value;
			Pintar();
		}
	}

	public Color GradColor1
	{
		get
		{
			return nGradColor1;
		}
		set
		{
			nGradColor1 = value;
			Pintar();
		}
	}

	public Color GradColor2
	{
		get
		{
			return nGradColor2;
		}
		set
		{
			nGradColor2 = value;
			Pintar();
		}
	}

	public string TitleMsg
	{
		get
		{
			return lblTitle.Text;
		}
		set
		{
			lblTitle.Text = value;
		}
	}

	public bool MessageShow
	{
		get
		{
			return lblMessage.Visible;
		}
		set
		{
			lblMessage.Visible = value;
		}
	}

	public string MessageText
	{
		get
		{
			return lblMessage.Text;
		}
		set
		{
			lblMessage.Text = value.Trim();
		}
	}

	public Color GradColorSup1
	{
		get
		{
			return nGradColor1PanelSup;
		}
		set
		{
			nGradColor1PanelSup = value;
			Pintar();
		}
	}

	public Color GradColorSup2
	{
		get
		{
			return nGradColor2PanelSup;
		}
		set
		{
			nGradColor2PanelSup = value;
			Pintar();
		}
	}

	public Color GradColorInf1
	{
		get
		{
			return nGradColor1PanelInf;
		}
		set
		{
			nGradColor1PanelInf = value;
			Pintar();
		}
	}

	public Color GradColorInf2
	{
		get
		{
			return nGradColor2PanelInf;
		}
		set
		{
			nGradColor2PanelInf = value;
			Pintar();
		}
	}

	[method: DebuggerNonUserCode]
	public event CloseFormEventHandler CloseForm;

	[method: DebuggerNonUserCode]
	public event ReubicaCtrlsEventHandler ReubicaCtrls;

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	[System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GRLL.Common.frmBase));
		this.PanelSup = new System.Windows.Forms.Panel();
		this.LBL_TITULO_1 = new GRLL.Common.ucLabel();
		this.LBL_TITULO_0 = new System.Windows.Forms.Label();
		this.cmdCalc = new System.Windows.Forms.Button();
		this.lblTitle = new System.Windows.Forms.Label();
		this.PanelInf = new System.Windows.Forms.Panel();
		this.lblMessage = new System.Windows.Forms.Label();
		this.cmdCerrar = new System.Windows.Forms.Button();
		this.PanelSup.SuspendLayout();
		this.PanelInf.SuspendLayout();
		this.SuspendLayout();
		this.PanelSup.BackColor = System.Drawing.Color.FromArgb(199, 223, 250);
		this.PanelSup.Controls.Add(this.LBL_TITULO_1);
		this.PanelSup.Controls.Add(this.LBL_TITULO_0);
		this.PanelSup.Controls.Add(this.cmdCalc);
		this.PanelSup.Controls.Add(this.lblTitle);
		this.PanelSup.Dock = System.Windows.Forms.DockStyle.Top;
		System.Windows.Forms.Panel panelSup = this.PanelSup;
		System.Drawing.Point location = new System.Drawing.Point(0, 0);
		panelSup.Location = location;
		this.PanelSup.Name = "PanelSup";
		System.Windows.Forms.Panel panelSup2 = this.PanelSup;
		System.Drawing.Size size = new System.Drawing.Size(793, 24);
		panelSup2.Size = size;
		this.PanelSup.TabIndex = 0;
		this.LBL_TITULO_1.Font = new System.Drawing.Font("Arial Narrow", 15.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.LBL_TITULO_1.ForeColor = System.Drawing.Color.CornflowerBlue;
		GRLL.Common.ucLabel lBL_TITULO_ = this.LBL_TITULO_1;
		location = new System.Drawing.Point(325, -201);
		lBL_TITULO_.Location = location;
		this.LBL_TITULO_1.Name = "LBL_TITULO_1";
		GRLL.Common.ucLabel lBL_TITULO_2 = this.LBL_TITULO_1;
		size = new System.Drawing.Size(135, 28);
		lBL_TITULO_2.Size = size;
		this.LBL_TITULO_1.TabIndex = 29;
		this.LBL_TITULO_1.Text = "Título principal";
		this.LBL_TITULO_1.Visible = false;
		this.LBL_TITULO_0.AutoSize = true;
		this.LBL_TITULO_0.Font = new System.Drawing.Font("Arial Narrow", 15.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.LBL_TITULO_0.ForeColor = System.Drawing.Color.Navy;
		System.Windows.Forms.Label lBL_TITULO_3 = this.LBL_TITULO_0;
		location = new System.Drawing.Point(326, -203);
		lBL_TITULO_3.Location = location;
		this.LBL_TITULO_0.Name = "LBL_TITULO_0";
		System.Windows.Forms.Label lBL_TITULO_4 = this.LBL_TITULO_0;
		size = new System.Drawing.Size(141, 25);
		lBL_TITULO_4.Size = size;
		this.LBL_TITULO_0.TabIndex = 28;
		this.LBL_TITULO_0.Text = "Título principal";
		this.LBL_TITULO_0.Visible = false;
		this.cmdCalc.BackgroundImage = (System.Drawing.Image)resources.GetObject("cmdCalc.BackgroundImage");
		this.cmdCalc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.cmdCalc.FlatAppearance.BorderColor = System.Drawing.Color.White;
		this.cmdCalc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		System.Windows.Forms.Button button = this.cmdCalc;
		location = new System.Drawing.Point(3, 2);
		button.Location = location;
		this.cmdCalc.Name = "cmdCalc";
		System.Windows.Forms.Button button2 = this.cmdCalc;
		size = new System.Drawing.Size(20, 20);
		button2.Size = size;
		this.cmdCalc.TabIndex = 3;
		this.cmdCalc.TabStop = false;
		this.cmdCalc.UseVisualStyleBackColor = true;
		this.lblTitle.AutoSize = true;
		this.lblTitle.BackColor = System.Drawing.Color.Transparent;
		this.lblTitle.Dock = System.Windows.Forms.DockStyle.Right;
		this.lblTitle.Enabled = false;
		System.Windows.Forms.Label label = this.lblTitle;
		location = new System.Drawing.Point(793, 0);
		label.Location = location;
		this.lblTitle.Name = "lblTitle";
		System.Windows.Forms.Label label2 = this.lblTitle;
		size = new System.Drawing.Size(0, 13);
		label2.Size = size;
		this.lblTitle.TabIndex = 0;
		this.PanelInf.BackColor = System.Drawing.Color.FromArgb(130, 165, 210);
		this.PanelInf.Controls.Add(this.lblMessage);
		this.PanelInf.Dock = System.Windows.Forms.DockStyle.Bottom;
		System.Windows.Forms.Panel panelInf = this.PanelInf;
		location = new System.Drawing.Point(0, 475);
		panelInf.Location = location;
		this.PanelInf.Name = "PanelInf";
		System.Windows.Forms.Panel panelInf2 = this.PanelInf;
		size = new System.Drawing.Size(793, 27);
		panelInf2.Size = size;
		this.PanelInf.TabIndex = 1;
		this.lblMessage.AutoSize = true;
		this.lblMessage.BackColor = System.Drawing.Color.Transparent;
		this.lblMessage.Dock = System.Windows.Forms.DockStyle.Top;
		this.lblMessage.ForeColor = System.Drawing.Color.White;
		System.Windows.Forms.Label label3 = this.lblMessage;
		location = new System.Drawing.Point(0, 0);
		label3.Location = location;
		this.lblMessage.Name = "lblMessage";
		System.Windows.Forms.Label label4 = this.lblMessage;
		size = new System.Drawing.Size(0, 13);
		label4.Size = size;
		this.lblMessage.TabIndex = 0;
		this.cmdCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		System.Windows.Forms.Button button3 = this.cmdCerrar;
		location = new System.Drawing.Point(700, -50);
		button3.Location = location;
		this.cmdCerrar.Name = "cmdCerrar";
		System.Windows.Forms.Button button4 = this.cmdCerrar;
		size = new System.Drawing.Size(63, 24);
		button4.Size = size;
		this.cmdCerrar.TabIndex = 2;
		this.cmdCerrar.Text = "Cerrar";
		this.cmdCerrar.UseVisualStyleBackColor = true;
		this.cmdCerrar.Visible = false;
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(224, 233, 244);
		this.CancelButton = this.cmdCerrar;
		size = new System.Drawing.Size(793, 502);
		this.ClientSize = size;
		this.Controls.Add(this.cmdCerrar);
		this.Controls.Add(this.PanelInf);
		this.Controls.Add(this.PanelSup);
		this.MaximizeBox = false;
		this.MinimizeBox = false;
		this.Name = "frmBase";
		this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Form1";
		this.PanelSup.ResumeLayout(false);
		this.PanelSup.PerformLayout();
		this.PanelInf.ResumeLayout(false);
		this.PanelInf.PerformLayout();
		this.ResumeLayout(false);
	}

	[DllImport("USER32.DLL", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr FindWindow([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpClassName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpWindowName);

	[DllImport("USER32.DLL", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool SetForegroundWindow(IntPtr hWnd);

	private void cmdCerrar_Click(object sender, EventArgs e)
	{
		Salir();
	}

	public void Salir()
	{
		bool bCancelar = false;
		CloseForm?.Invoke(ref bCancelar);
		if (bCancelar)
		{
			return;
		}
		try
		{
			Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void frmBase_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (bSalirConfirmar && MessageBox.Show("Esta seguro de Cerrar el Formulario?", "Cerrar Formulario " + Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
		{
			e.Cancel = true;
		}
	}

	private void frmBase_Load(object sender, EventArgs e)
	{
		lblTitle.Text = Name;
		Text = sTextFrm;
		CentrarForm(this);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		base.OnPaint(e);
		Pintar();
	}

	protected override void OnParentBackColorChanged(EventArgs e)
	{
		base.OnParentBackColorChanged(e);
		Pintar();
	}

	private void frmBase_Shown(object sender, EventArgs e)
	{
		lblTitle.Text = Conversions.ToString(NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null));
		Text = sTextFrm;
	}

	private void Pintar()
	{
		GradForm();
		GradPanelSup();
		GradPanelInf();
		cmdCerrar.Visible = bVerCmdCerrar;
	}

	private void GradForm()
	{
		lblMessage.BackColor = Color.FromName("Transparent");
		if (bGradientShow)
		{
			Rectangle rec = new Rectangle(0, 0, Width, Height);
			Brush LinearBrush = new LinearGradientBrush(rec, nGradColor1, nGradColor2, nGradModo);
			CreateGraphics().FillRectangle(LinearBrush, rec);
		}
		else
		{
			BackColor = nGradColor1;
		}
	}

	private void GradPanelSup()
	{
		if (!bVerPanelSup || !bGradientShow)
		{
			return;
		}
		if (nGradColor1PanelSup != nGradColor2PanelSup)
		{
			try
			{
				Rectangle rec = new Rectangle(0, 0, PanelSup.Width, PanelSup.Height);
				Brush LinearBrush = new LinearGradientBrush(rec, nGradColor1PanelSup, nGradColor2PanelSup, nGradModoPanelSup);
				PanelSup.CreateGraphics().FillRectangle(LinearBrush, rec);
				return;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
				return;
			}
		}
		PanelSup.BackColor = nGradColor1PanelSup;
	}

	private void GradPanelInf()
	{
		if (!bVerPanelInf)
		{
			return;
		}
		if (bGradientShow)
		{
			try
			{
				Rectangle rec = new Rectangle(0, 0, PanelInf.Width, PanelInf.Height);
				Brush LinearBrush = new LinearGradientBrush(rec, nGradColor1PanelInf, nGradColor2PanelInf, nGradModoPanelInf);
				PanelInf.CreateGraphics().FillRectangle(LinearBrush, rec);
				return;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
				return;
			}
		}
		PanelInf.BackColor = nGradColor1PanelInf;
	}

	public void PintarGradiente(object oArea, Color nColor1, Color nColor2, LinearGradientMode oMode)
	{
		lblMessage.BackColor = Color.FromName("Transparent");
		if (!bGradientShow)
		{
			return;
		}
		try
		{
			Rectangle rec = new Rectangle(0, 0, Conversions.ToInteger(NewLateBinding.LateGet(oArea, null, "Width", new object[0], null, null, null)), Conversions.ToInteger(NewLateBinding.LateGet(oArea, null, "Height", new object[0], null, null, null)));
			Brush LinearBrush = new LinearGradientBrush(rec, nColor1, nColor1, oMode);
			object instance = NewLateBinding.LateGet(oArea, null, "CreateGraphics", new object[0], null, null, null);
			object[] array = new object[2] { LinearBrush, rec };
			bool[] array2 = new bool[2] { true, true };
			NewLateBinding.LateCall(instance, null, "FillRectangle", array, null, null, array2, IgnoreReturn: true);
			if (array2[0])
			{
				LinearBrush = (Brush)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(Brush));
			}
			if (array2[1])
			{
				rec = (Rectangle)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(Rectangle));
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public frmBase()
	{
		base.FormClosing += frmBase_FormClosing;
		base.Load += frmBase_Load;
		base.Shown += frmBase_Shown;
		bGradientShow = true;
		nGradColor1 = Color.FromArgb(224, 233, 244);
		nGradColor2 = Color.FromArgb(224, 233, 244);
		nGradModo = LinearGradientMode.Vertical;
		nGradColor1PanelSup = Color.FromArgb(199, 223, 250);
		nGradColor2PanelSup = Color.FromArgb(199, 223, 250);
		nGradColor1PanelInf = Color.FromArgb(130, 165, 210);
		nGradColor2PanelInf = Color.FromArgb(130, 165, 210);
		nGradModoPanelSup = LinearGradientMode.Vertical;
		nGradModoPanelInf = LinearGradientMode.Vertical;
		bSalirConfirmar = false;
		GuardarySalir = false;
		sTextFrm = "";
		bVerCal = true;
		bVerPanelInf = true;
		bVerPanelSup = true;
		bVerTituloFrm = false;
		sTituloFrm = "Título principal";
		ref Point reference = ref iTituloFrmubica;
		reference = new Point(325, -1);
		bVerCmdCerrar = false;
		InitializeComponent();
		FormBorderStyle = FormBorderStyle.FixedSingle;
		ShowInTaskbar = false;
		KeyPreview = true;
	}

	private void cmdCalc_Click(object sender, EventArgs e)
	{
		string lpClassName = null;
		string lpWindowName = "Calculadora";
		IntPtr calculatorHandle = FindWindow(ref lpClassName, ref lpWindowName);
		if (calculatorHandle == IntPtr.Zero)
		{
			Process.Start("CALC.EXE");
		}
		else
		{
			SetForegroundWindow(calculatorHandle);
		}
	}

	private void CentrarForm(Form oForm)
	{
		if (oForm.MdiParent != null)
		{
			oForm.Top = Conversions.ToInteger(Interaction.IIf(oForm.IsMdiChild, 0, (double)checked(Screen.PrimaryScreen.WorkingArea.Height - oForm.Height) / 2.0));
			oForm.Left = Conversions.ToInteger(Operators.DivideObject(Operators.SubtractObject(Interaction.IIf(oForm.IsMdiChild, oForm.MdiParent.Size.Width, Screen.PrimaryScreen.WorkingArea.Width), oForm.Width), 2));
		}
	}
}
