using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using GRLL.Common.My.Resources;
using Microsoft.VisualBasic.CompilerServices;

namespace GRLL.Common;

[DesignerGenerated]
public class ucFill : UserControl
{
	public delegate void ClickBuscarEventHandler(string Campo, string CampoFill, string Condicion, string Valor1, string Valor2);

	private IContainer components;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("CMD_FILL")]
	private Button _CMD_FILL;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("CMB_CAMPO")]
	private ComboBox _CMB_CAMPO;

	[AccessedThroughProperty("TXT_CONDIC")]
	private ucText _TXT_CONDIC;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("CMB_COND")]
	private ComboBox _CMB_COND;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("DTP_FIN")]
	private DateTimePicker _DTP_FIN;

	[AccessedThroughProperty("DTP_INI")]
	private DateTimePicker _DTP_INI;

	[AccessedThroughProperty("LBL_Y")]
	private Label _LBL_Y;

	[AccessedThroughProperty("CHK_ITERACTIVO")]
	private CheckBox _CHK_ITERACTIVO;

	[AccessedThroughProperty("ToolTip1")]
	private ToolTip _ToolTip1;

	private ClsTipoDatos oCls;

	private bool EnLoad;

	internal GroupBox GroupBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox1 = value;
		}
	}

	internal Button CMD_FILL
	{
		[DebuggerNonUserCode]
		get
		{
			return _CMD_FILL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = CMD_FILL_Click;
			if (_CMD_FILL != null)
			{
				_CMD_FILL.Click -= value2;
			}
			_CMD_FILL = value;
			if (_CMD_FILL != null)
			{
				_CMD_FILL.Click += value2;
			}
		}
	}

	internal Label Label2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label2 = value;
		}
	}

	internal ComboBox CMB_CAMPO
	{
		[DebuggerNonUserCode]
		get
		{
			return _CMB_CAMPO;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = CMB_CAMPO_SelectedIndexChanged;
			if (_CMB_CAMPO != null)
			{
				_CMB_CAMPO.SelectedIndexChanged -= value2;
			}
			_CMB_CAMPO = value;
			if (_CMB_CAMPO != null)
			{
				_CMB_CAMPO.SelectedIndexChanged += value2;
			}
		}
	}

	internal ucText TXT_CONDIC
	{
		[DebuggerNonUserCode]
		get
		{
			return _TXT_CONDIC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = TXT_CONDIC_TextChanged;
			if (_TXT_CONDIC != null)
			{
				_TXT_CONDIC.TextChanged -= value2;
			}
			_TXT_CONDIC = value;
			if (_TXT_CONDIC != null)
			{
				_TXT_CONDIC.TextChanged += value2;
			}
		}
	}

	internal Label Label3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label3 = value;
		}
	}

	internal ComboBox CMB_COND
	{
		[DebuggerNonUserCode]
		get
		{
			return _CMB_COND;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = CMB_COND_SelectedIndexChanged;
			if (_CMB_COND != null)
			{
				_CMB_COND.SelectedIndexChanged -= value2;
			}
			_CMB_COND = value;
			if (_CMB_COND != null)
			{
				_CMB_COND.SelectedIndexChanged += value2;
			}
		}
	}

	internal Label Label4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label4 = value;
		}
	}

	internal DateTimePicker DTP_FIN
	{
		[DebuggerNonUserCode]
		get
		{
			return _DTP_FIN;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DTP_FIN = value;
		}
	}

	internal DateTimePicker DTP_INI
	{
		[DebuggerNonUserCode]
		get
		{
			return _DTP_INI;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DTP_INI = value;
		}
	}

	internal Label LBL_Y
	{
		[DebuggerNonUserCode]
		get
		{
			return _LBL_Y;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LBL_Y = value;
		}
	}

	internal CheckBox CHK_ITERACTIVO
	{
		[DebuggerNonUserCode]
		get
		{
			return _CHK_ITERACTIVO;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CHK_ITERACTIVO = value;
		}
	}

	internal ToolTip ToolTip1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolTip1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolTip1 = value;
		}
	}

	public ClsTipoDatos SelectedItem
	{
		get
		{
			if (CMB_CAMPO.SelectedItem == null)
			{
				return null;
			}
			return (ClsTipoDatos)CMB_CAMPO.SelectedItem;
		}
	}

	[method: DebuggerNonUserCode]
	public event ClickBuscarEventHandler ClickBuscar;

	public ucFill()
	{
		base.Load += ucFill_Load;
		base.Resize += ucFill_Resize;
		EnLoad = false;
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
		this.components = new System.ComponentModel.Container();
		this.GroupBox1 = new System.Windows.Forms.GroupBox();
		this.TXT_CONDIC = new GRLL.Common.ucText();
		this.DTP_INI = new System.Windows.Forms.DateTimePicker();
		this.CMB_COND = new System.Windows.Forms.ComboBox();
		this.CMB_CAMPO = new System.Windows.Forms.ComboBox();
		this.CHK_ITERACTIVO = new System.Windows.Forms.CheckBox();
		this.DTP_FIN = new System.Windows.Forms.DateTimePicker();
		this.CMD_FILL = new System.Windows.Forms.Button();
		this.LBL_Y = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
		this.GroupBox1.SuspendLayout();
		this.SuspendLayout();
		this.GroupBox1.Controls.Add(this.TXT_CONDIC);
		this.GroupBox1.Controls.Add(this.DTP_INI);
		this.GroupBox1.Controls.Add(this.CMB_COND);
		this.GroupBox1.Controls.Add(this.CMB_CAMPO);
		this.GroupBox1.Controls.Add(this.CHK_ITERACTIVO);
		this.GroupBox1.Controls.Add(this.DTP_FIN);
		this.GroupBox1.Controls.Add(this.CMD_FILL);
		this.GroupBox1.Controls.Add(this.LBL_Y);
		this.GroupBox1.Controls.Add(this.Label2);
		this.GroupBox1.Controls.Add(this.Label3);
		this.GroupBox1.Controls.Add(this.Label4);
		System.Windows.Forms.GroupBox groupBox = this.GroupBox1;
		System.Drawing.Point location = new System.Drawing.Point(0, -1);
		groupBox.Location = location;
		this.GroupBox1.Name = "GroupBox1";
		System.Windows.Forms.GroupBox groupBox2 = this.GroupBox1;
		System.Drawing.Size size = new System.Drawing.Size(487, 59);
		groupBox2.Size = size;
		this.GroupBox1.TabIndex = 44;
		this.GroupBox1.TabStop = false;
		this.GroupBox1.Text = "Filtro";
		this.TXT_CONDIC.ActiveBorderColor = System.Drawing.SystemColors.ControlDarkDark;
		this.TXT_CONDIC.BackColorFocus = System.Drawing.Color.FromArgb(255, 192, 255);
		this.TXT_CONDIC.ExitOnEnter = true;
		this.TXT_CONDIC.ExitOnMaxLength = true;
		this.TXT_CONDIC.ForeColorFocus = System.Drawing.Color.Blue;
		this.TXT_CONDIC.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucText tXT_CONDIC = this.TXT_CONDIC;
		location = new System.Drawing.Point(196, 29);
		tXT_CONDIC.Location = location;
		this.TXT_CONDIC.MaxLength = 10;
		this.TXT_CONDIC.MsgError = "";
		this.TXT_CONDIC.Name = "TXT_CONDIC";
		this.TXT_CONDIC.SelectOnEnter = true;
		GRLL.Common.ucText tXT_CONDIC2 = this.TXT_CONDIC;
		size = new System.Drawing.Size(234, 20);
		tXT_CONDIC2.Size = size;
		this.TXT_CONDIC.TabIndex = 37;
		this.TXT_CONDIC.TipoDato = GRLL.Common.clsVariables.TipoDato.Todo;
		this.TXT_CONDIC.Valida = true;
		this.DTP_INI.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		System.Windows.Forms.DateTimePicker dTP_INI = this.DTP_INI;
		location = new System.Drawing.Point(210, 29);
		dTP_INI.Location = location;
		this.DTP_INI.Name = "DTP_INI";
		System.Windows.Forms.DateTimePicker dTP_INI2 = this.DTP_INI;
		size = new System.Drawing.Size(85, 20);
		dTP_INI2.Size = size;
		this.DTP_INI.TabIndex = 43;
		this.CMB_COND.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.CMB_COND.DropDownWidth = 150;
		this.CMB_COND.FormattingEnabled = true;
		this.CMB_COND.IntegralHeight = false;
		System.Windows.Forms.ComboBox cMB_COND = this.CMB_COND;
		location = new System.Drawing.Point(129, 29);
		cMB_COND.Location = location;
		this.CMB_COND.Name = "CMB_COND";
		System.Windows.Forms.ComboBox cMB_COND2 = this.CMB_COND;
		size = new System.Drawing.Size(61, 21);
		cMB_COND2.Size = size;
		this.CMB_COND.TabIndex = 41;
		this.CMB_CAMPO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.CMB_CAMPO.DropDownWidth = 200;
		this.CMB_CAMPO.FormattingEnabled = true;
		this.CMB_CAMPO.IntegralHeight = false;
		System.Windows.Forms.ComboBox cMB_CAMPO = this.CMB_CAMPO;
		location = new System.Drawing.Point(17, 29);
		cMB_CAMPO.Location = location;
		this.CMB_CAMPO.Name = "CMB_CAMPO";
		System.Windows.Forms.ComboBox cMB_CAMPO2 = this.CMB_CAMPO;
		size = new System.Drawing.Size(101, 21);
		cMB_CAMPO2.Size = size;
		this.CMB_CAMPO.TabIndex = 41;
		this.CHK_ITERACTIVO.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.CHK_ITERACTIVO.AutoSize = true;
		System.Windows.Forms.CheckBox cHK_ITERACTIVO = this.CHK_ITERACTIVO;
		location = new System.Drawing.Point(433, 32);
		cHK_ITERACTIVO.Location = location;
		this.CHK_ITERACTIVO.Name = "CHK_ITERACTIVO";
		System.Windows.Forms.CheckBox cHK_ITERACTIVO2 = this.CHK_ITERACTIVO;
		size = new System.Drawing.Size(15, 14);
		cHK_ITERACTIVO2.Size = size;
		this.CHK_ITERACTIVO.TabIndex = 44;
		this.ToolTip1.SetToolTip(this.CHK_ITERACTIVO, "Busqueda Iteractiva");
		this.CHK_ITERACTIVO.UseVisualStyleBackColor = true;
		this.DTP_FIN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		System.Windows.Forms.DateTimePicker dTP_FIN = this.DTP_FIN;
		location = new System.Drawing.Point(341, 29);
		dTP_FIN.Location = location;
		this.DTP_FIN.Name = "DTP_FIN";
		System.Windows.Forms.DateTimePicker dTP_FIN2 = this.DTP_FIN;
		size = new System.Drawing.Size(85, 20);
		dTP_FIN2.Size = size;
		this.DTP_FIN.TabIndex = 43;
		this.CMD_FILL.Image = GRLL.Common.My.Resources.Resources.filefind;
		System.Windows.Forms.Button cMD_FILL = this.CMD_FILL;
		location = new System.Drawing.Point(448, 24);
		cMD_FILL.Location = location;
		this.CMD_FILL.Name = "CMD_FILL";
		System.Windows.Forms.Button cMD_FILL2 = this.CMD_FILL;
		size = new System.Drawing.Size(33, 26);
		cMD_FILL2.Size = size;
		this.CMD_FILL.TabIndex = 42;
		this.CMD_FILL.UseVisualStyleBackColor = true;
		this.LBL_Y.AutoSize = true;
		this.LBL_Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.LBL_Y.ForeColor = System.Drawing.Color.Red;
		System.Windows.Forms.Label lBL_Y = this.LBL_Y;
		location = new System.Drawing.Point(312, 33);
		lBL_Y.Location = location;
		this.LBL_Y.Name = "LBL_Y";
		System.Windows.Forms.Label lBL_Y2 = this.LBL_Y;
		size = new System.Drawing.Size(15, 13);
		lBL_Y2.Size = size;
		this.LBL_Y.TabIndex = 34;
		this.LBL_Y.Text = "Y";
		this.Label2.AutoSize = true;
		System.Windows.Forms.Label label = this.Label2;
		location = new System.Drawing.Point(41, 13);
		label.Location = location;
		this.Label2.Name = "Label2";
		System.Windows.Forms.Label label2 = this.Label2;
		size = new System.Drawing.Size(40, 13);
		label2.Size = size;
		this.Label2.TabIndex = 34;
		this.Label2.Text = "Campo";
		this.Label3.AutoSize = true;
		System.Windows.Forms.Label label3 = this.Label3;
		location = new System.Drawing.Point(131, 13);
		label3.Location = location;
		this.Label3.Name = "Label3";
		System.Windows.Forms.Label label4 = this.Label3;
		size = new System.Drawing.Size(54, 13);
		label4.Size = size;
		this.Label3.TabIndex = 34;
		this.Label3.Text = "Condicion";
		this.Label4.AutoSize = true;
		System.Windows.Forms.Label label5 = this.Label4;
		location = new System.Drawing.Point(200, 13);
		label5.Location = location;
		this.Label4.Name = "Label4";
		System.Windows.Forms.Label label6 = this.Label4;
		size = new System.Drawing.Size(31, 13);
		label6.Size = size;
		this.Label4.TabIndex = 34;
		this.Label4.Text = "Valor";
		this.BackColor = System.Drawing.Color.Transparent;
		this.Controls.Add(this.GroupBox1);
		this.Name = "ucFill";
		size = new System.Drawing.Size(487, 58);
		this.Size = size;
		this.GroupBox1.ResumeLayout(false);
		this.GroupBox1.PerformLayout();
		this.ResumeLayout(false);
	}

	public string Campo(int Index)
	{
		string Campo = "";
		if (Index >= 0 && Index < CMB_CAMPO.Items.Count)
		{
			Campo = ((ClsTipoDatos)CMB_CAMPO.Items[Index]).Campo;
		}
		return Campo;
	}

	public string Campo()
	{
		if (CMB_CAMPO.SelectedIndex < 0)
		{
			return "";
		}
		return ((ClsTipoDatos)CMB_CAMPO.SelectedItem).Campo;
	}

	public string CampoFill(int Index)
	{
		string CampoFill = "";
		if (Index >= 0 && Index < CMB_CAMPO.Items.Count)
		{
			CampoFill = ((ClsTipoDatos)CMB_CAMPO.Items[Index]).CampoFill;
		}
		return CampoFill;
	}

	public string CampoFill()
	{
		if (CMB_CAMPO.SelectedIndex < 0)
		{
			return "";
		}
		return ((ClsTipoDatos)CMB_CAMPO.SelectedItem).CampoFill;
	}

	public ClsTipoDatos.TipoDatosSql TipoDato(int Index)
	{
		ClsTipoDatos.TipoDatosSql TipoDato = ClsTipoDatos.TipoDatosSql.Texto;
		if (Index >= 0 && Index < CMB_CAMPO.Items.Count)
		{
			TipoDato = ((ClsTipoDatos)CMB_CAMPO.Items[Index]).TipoDato;
		}
		return TipoDato;
	}

	public ClsTipoDatos.TipoDatosSql TipoDato()
	{
		if (CMB_CAMPO.SelectedIndex < 0)
		{
			return ClsTipoDatos.TipoDatosSql.Texto;
		}
		return ((ClsTipoDatos)CMB_CAMPO.SelectedItem).TipoDato;
	}

	public int MaxLeng(int Index)
	{
		int MaxLeng = 0;
		if (Index >= 0 && Index < CMB_CAMPO.Items.Count)
		{
			MaxLeng = ((ClsTipoDatos)CMB_CAMPO.Items[Index]).MaxLeng;
		}
		return MaxLeng;
	}

	public int MaxLeng()
	{
		if (CMB_CAMPO.SelectedIndex < 0)
		{
			return 0;
		}
		return ((ClsTipoDatos)CMB_CAMPO.SelectedItem).MaxLeng;
	}

	public clsVariables.TipoDato TipoText(int Index)
	{
		clsVariables.TipoDato TipoText = (clsVariables.TipoDato)0;
		if (Index >= 0 && Index < CMB_CAMPO.Items.Count)
		{
			TipoText = ((ClsTipoDatos)CMB_CAMPO.Items[Index]).TipoText;
		}
		return TipoText;
	}

	public clsVariables.TipoDato TipoText()
	{
		if (CMB_CAMPO.SelectedIndex < 0)
		{
			return (clsVariables.TipoDato)0;
		}
		return ((ClsTipoDatos)CMB_CAMPO.SelectedItem).TipoText;
	}

	public ClsTipoDatos ClsTipoDato(int Index)
	{
		ClsTipoDatos ClsTipoDato = null;
		if (Index >= 0 && Index < CMB_CAMPO.Items.Count)
		{
			ClsTipoDato = (ClsTipoDatos)CMB_CAMPO.Items[Index];
		}
		return ClsTipoDato;
	}

	public ClsTipoDatos ClsTipoDato()
	{
		if (CMB_CAMPO.SelectedIndex < 0)
		{
			return null;
		}
		return (ClsTipoDatos)CMB_CAMPO.SelectedItem;
	}

	public string Condicion()
	{
		string Condicion = "";
		if (CMB_COND.SelectedIndex >= 0)
		{
			Condicion = Conversions.ToString(CMB_COND.Items[CMB_COND.SelectedIndex]);
		}
		return Condicion;
	}

	private void CMB_CAMPO_SelectedIndexChanged(object sender, EventArgs e)
	{
		CMB_COND.Items.Clear();
		TXT_CONDIC.Clear();
		TXT_CONDIC.Visible = true;
		CHK_ITERACTIVO.Visible = true;
		CHK_ITERACTIVO.Checked = false;
		DTP_INI.Visible = false;
		LBL_Y.Visible = false;
		DTP_FIN.Visible = false;
		if (!EnLoad && CMB_CAMPO.SelectedIndex >= 0)
		{
			oCls = (ClsTipoDatos)CMB_CAMPO.SelectedItem;
			TXT_CONDIC.MaxLength = oCls.MaxLeng;
			TXT_CONDIC.TipoDato = oCls.TipoText;
			switch (oCls.TipoDato)
			{
			case ClsTipoDatos.TipoDatosSql.Fecha:
				CMB_COND.Items.Add("=");
				CMB_COND.Items.Add("ENTRE");
				CMB_COND.Items.Add(">");
				CMB_COND.Items.Add(">=");
				CMB_COND.Items.Add("<");
				CMB_COND.Items.Add("<=");
				CMB_COND.Items.Add("<>");
				CMB_COND.Items.Add("TODOS");
				TXT_CONDIC.Visible = false;
				CHK_ITERACTIVO.Visible = false;
				DTP_INI.Visible = true;
				break;
			case ClsTipoDatos.TipoDatosSql.Numerico:
				CMB_COND.Items.Add("=");
				CMB_COND.Items.Add(">");
				CMB_COND.Items.Add(">=");
				CMB_COND.Items.Add("<");
				CMB_COND.Items.Add("<=");
				CMB_COND.Items.Add("<>");
				CMB_COND.Items.Add("TODOS");
				break;
			case ClsTipoDatos.TipoDatosSql.Texto:
				CMB_COND.Items.Add("QUE CONTENGA");
				CMB_COND.Items.Add("QUE NO CONTENGA");
				CMB_COND.Items.Add("TODOS");
				break;
			}
			if (CMB_COND.Items.Count > 0)
			{
				CMB_COND.SelectedIndex = 0;
			}
		}
	}

	public void Add(List<ClsTipoDatos> ocls)
	{
		EnLoad = true;
		CMB_CAMPO.DataSource = null;
		CMB_CAMPO.Items.Clear();
		CMB_CAMPO.DisplayMember = "Campo";
		CMB_CAMPO.ValueMember = "CampoFill";
		CMB_CAMPO.DataSource = ocls;
		CMB_CAMPO.SelectedIndex = -1;
		EnLoad = false;
	}

	private void CMD_FILL_Click(object sender, EventArgs e)
	{
		if (CMB_CAMPO.Items.Count >= 1)
		{
			ClickBuscar?.Invoke((CMB_CAMPO.SelectedIndex < 0) ? "" : CMB_CAMPO.Text, (CMB_CAMPO.SelectedIndex < 0) ? "" : CMB_CAMPO.SelectedValue.ToString(), (CMB_COND.SelectedIndex < 0) ? "" : CMB_COND.SelectedItem.ToString(), TXT_CONDIC.Visible ? TXT_CONDIC.Text.Trim() : ModFunciones.Date112(DTP_INI.Value), DTP_FIN.Visible ? ModFunciones.Date112(DTP_FIN.Value) : "");
		}
	}

	private void ucFill_Load(object sender, EventArgs e)
	{
		TXT_CONDIC.Visible = true;
		DTP_INI.Visible = false;
		LBL_Y.Visible = false;
		DTP_FIN.Visible = false;
	}

	private void ucFill_Resize(object sender, EventArgs e)
	{
		Width = 487;
		Height = 58;
	}

	private void CMB_COND_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (CMB_COND.SelectedIndex >= 0 && CMB_CAMPO.SelectedIndex >= 0)
		{
			if (Operators.CompareString(CMB_COND.SelectedItem.ToString(), "ENTRE", TextCompare: false) == 0)
			{
				DTP_INI.Visible = true;
				LBL_Y.Visible = true;
				DTP_FIN.Visible = true;
			}
			else
			{
				LBL_Y.Visible = false;
				DTP_FIN.Visible = false;
			}
		}
	}

	private void TXT_CONDIC_TextChanged(object sender, EventArgs e)
	{
		if (CMB_CAMPO.Items.Count >= 1 && CHK_ITERACTIVO.Checked)
		{
			ClickBuscar?.Invoke((CMB_CAMPO.SelectedIndex < 0) ? "" : CMB_CAMPO.Text, (CMB_CAMPO.SelectedIndex < 0) ? "" : CMB_CAMPO.SelectedValue.ToString(), (CMB_COND.SelectedIndex < 0) ? "" : CMB_COND.SelectedItem.ToString(), TXT_CONDIC.Visible ? TXT_CONDIC.Text.Trim() : ModFunciones.Date112(DTP_INI.Value), DTP_FIN.Visible ? ModFunciones.Date112(DTP_FIN.Value) : "");
		}
	}
}
