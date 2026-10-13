using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ClsCtrls;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GRLL.Common;

[DesignerGenerated]
public class ucUbigeoCombito : UserControl
{
	private IContainer components;

	[AccessedThroughProperty("TXT_Dist")]
	private ucText _TXT_Dist;

	[AccessedThroughProperty("TXT_Prov")]
	private ucText _TXT_Prov;

	[AccessedThroughProperty("TXT_Dpto")]
	private ucText _TXT_Dpto;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("CMB_Dpto")]
	private Combito _CMB_Dpto;

	[AccessedThroughProperty("CMB_Prov")]
	private Combito _CMB_Prov;

	[AccessedThroughProperty("CMB_Dist")]
	private Combito _CMB_Dist;

	[AccessedThroughProperty("pError")]
	private ErrorProvider _pError;

	[AccessedThroughProperty("ToolTip1")]
	private ToolTip _ToolTip1;

	private string _Ubigeo;

	private SqlConnection sConnection;

	private DataSet oDs;

	private DataView _dv;

	private bool _ENCMB_DPTO;

	private bool _ENCMB_PROV;

	private bool _ENCMB_DTTO;

	internal ucText TXT_Dist
	{
		[DebuggerNonUserCode]
		get
		{
			return _TXT_Dist;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = TXT_Dist_Validated;
			KeyEventHandler value3 = TXT_Dist_KeyDown;
			if (_TXT_Dist != null)
			{
				_TXT_Dist.Validated -= value2;
				_TXT_Dist.KeyDown -= value3;
			}
			_TXT_Dist = value;
			if (_TXT_Dist != null)
			{
				_TXT_Dist.Validated += value2;
				_TXT_Dist.KeyDown += value3;
			}
		}
	}

	internal ucText TXT_Prov
	{
		[DebuggerNonUserCode]
		get
		{
			return _TXT_Prov;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = TXT_Prov_Validated;
			KeyEventHandler value3 = TXT_Prov_KeyDown;
			if (_TXT_Prov != null)
			{
				_TXT_Prov.Validated -= value2;
				_TXT_Prov.KeyDown -= value3;
			}
			_TXT_Prov = value;
			if (_TXT_Prov != null)
			{
				_TXT_Prov.Validated += value2;
				_TXT_Prov.KeyDown += value3;
			}
		}
	}

	internal ucText TXT_Dpto
	{
		[DebuggerNonUserCode]
		get
		{
			return _TXT_Dpto;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = TXT_Dpto_Validated;
			KeyEventHandler value3 = TXT_Dpto_KeyDown;
			if (_TXT_Dpto != null)
			{
				_TXT_Dpto.Validated -= value2;
				_TXT_Dpto.KeyDown -= value3;
			}
			_TXT_Dpto = value;
			if (_TXT_Dpto != null)
			{
				_TXT_Dpto.Validated += value2;
				_TXT_Dpto.KeyDown += value3;
			}
		}
	}

	internal Label Label1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label1 = value;
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

	internal Combito CMB_Dpto
	{
		[DebuggerNonUserCode]
		get
		{
			return _CMB_Dpto;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = CMB_Dpto_SelectedIndexChanged;
			KeyEventHandler value3 = CMB_Dpto_KeyDown;
			if (_CMB_Dpto != null)
			{
				_CMB_Dpto.SelectedIndexChanged -= value2;
				_CMB_Dpto.KeyDown -= value3;
			}
			_CMB_Dpto = value;
			if (_CMB_Dpto != null)
			{
				_CMB_Dpto.SelectedIndexChanged += value2;
				_CMB_Dpto.KeyDown += value3;
			}
		}
	}

	internal Combito CMB_Prov
	{
		[DebuggerNonUserCode]
		get
		{
			return _CMB_Prov;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = CMB_Prov_SelectedIndexChanged;
			KeyEventHandler value3 = CMB_Dpto_KeyDown;
			if (_CMB_Prov != null)
			{
				_CMB_Prov.SelectedIndexChanged -= value2;
				_CMB_Prov.KeyDown -= value3;
			}
			_CMB_Prov = value;
			if (_CMB_Prov != null)
			{
				_CMB_Prov.SelectedIndexChanged += value2;
				_CMB_Prov.KeyDown += value3;
			}
		}
	}

	internal Combito CMB_Dist
	{
		[DebuggerNonUserCode]
		get
		{
			return _CMB_Dist;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = CMB_Dist_SelectedIndexChanged;
			KeyEventHandler value3 = CMB_Dpto_KeyDown;
			if (_CMB_Dist != null)
			{
				_CMB_Dist.SelectedIndexChanged -= value2;
				_CMB_Dist.KeyDown -= value3;
			}
			_CMB_Dist = value;
			if (_CMB_Dist != null)
			{
				_CMB_Dist.SelectedIndexChanged += value2;
				_CMB_Dist.KeyDown += value3;
			}
		}
	}

	internal ErrorProvider pError
	{
		[DebuggerNonUserCode]
		get
		{
			return _pError;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_pError = value;
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

	public SqlConnection Conexion
	{
		get
		{
			return sConnection;
		}
		set
		{
			sConnection = value;
		}
	}

	public string Ubigeo
	{
		get
		{
			return _Ubigeo;
		}
		set
		{
			_Ubigeo = Strings.Left(value.Trim() + "0000", 6);
			if (sConnection != null)
			{
				Leer_Ubigeo(_Ubigeo);
			}
		}
	}

	public ucUbigeoCombito()
	{
		base.Load += ucUbigeoCmb_Load;
		base.Resize += ucUbigeoCmb_Resize;
		_Ubigeo = "";
		oDs = new DataSet();
		_dv = new DataView();
		_ENCMB_DPTO = false;
		_ENCMB_PROV = false;
		_ENCMB_DTTO = false;
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
		this.Label1 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.TXT_Dist = new GRLL.Common.ucText();
		this.TXT_Prov = new GRLL.Common.ucText();
		this.TXT_Dpto = new GRLL.Common.ucText();
		this.CMB_Dpto = new ClsCtrls.Combito();
		this.CMB_Prov = new ClsCtrls.Combito();
		this.CMB_Dist = new ClsCtrls.Combito();
		this.pError = new System.Windows.Forms.ErrorProvider(this.components);
		this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
		((System.ComponentModel.ISupportInitialize)this.pError).BeginInit();
		this.SuspendLayout();
		this.Label1.AutoSize = true;
		System.Windows.Forms.Label label = this.Label1;
		System.Drawing.Point location = new System.Drawing.Point(2, 7);
		label.Location = location;
		this.Label1.Name = "Label1";
		System.Windows.Forms.Label label2 = this.Label1;
		System.Drawing.Size size = new System.Drawing.Size(80, 13);
		label2.Size = size;
		this.Label1.TabIndex = 10;
		this.Label1.Text = "Departamento :";
		this.Label2.AutoSize = true;
		System.Windows.Forms.Label label3 = this.Label2;
		location = new System.Drawing.Point(25, 34);
		label3.Location = location;
		this.Label2.Name = "Label2";
		System.Windows.Forms.Label label4 = this.Label2;
		size = new System.Drawing.Size(57, 13);
		label4.Size = size;
		this.Label2.TabIndex = 10;
		this.Label2.Text = "Provincia :";
		this.Label3.AutoSize = true;
		System.Windows.Forms.Label label5 = this.Label3;
		location = new System.Drawing.Point(37, 58);
		label5.Location = location;
		this.Label3.Name = "Label3";
		System.Windows.Forms.Label label6 = this.Label3;
		size = new System.Drawing.Size(45, 13);
		label6.Size = size;
		this.Label3.TabIndex = 10;
		this.Label3.Text = "Distrito :";
		this.TXT_Dist.ActiveBorderColor = System.Drawing.SystemColors.ControlDarkDark;
		this.TXT_Dist.BackColorFocus = System.Drawing.Color.FromArgb(255, 192, 255);
		this.TXT_Dist.ExitOnEnter = true;
		this.TXT_Dist.ExitOnMaxLength = true;
		this.TXT_Dist.ForeColorFocus = System.Drawing.Color.Blue;
		this.TXT_Dist.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucText tXT_Dist = this.TXT_Dist;
		location = new System.Drawing.Point(85, 54);
		tXT_Dist.Location = location;
		this.TXT_Dist.MaxLength = 2;
		this.TXT_Dist.MsgError = "";
		this.TXT_Dist.Name = "TXT_Dist";
		this.TXT_Dist.SelectOnEnter = true;
		GRLL.Common.ucText tXT_Dist2 = this.TXT_Dist;
		size = new System.Drawing.Size(21, 20);
		tXT_Dist2.Size = size;
		this.TXT_Dist.TabIndex = 8;
		this.TXT_Dist.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.TXT_Dist.TipoDato = GRLL.Common.clsVariables.TipoDato.NumeroEntero;
		this.TXT_Dist.Valida = false;
		this.TXT_Prov.ActiveBorderColor = System.Drawing.SystemColors.ControlDarkDark;
		this.TXT_Prov.BackColorFocus = System.Drawing.Color.FromArgb(255, 192, 255);
		this.TXT_Prov.ExitOnEnter = true;
		this.TXT_Prov.ExitOnMaxLength = true;
		this.TXT_Prov.ForeColorFocus = System.Drawing.Color.Blue;
		this.TXT_Prov.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucText tXT_Prov = this.TXT_Prov;
		location = new System.Drawing.Point(84, 30);
		tXT_Prov.Location = location;
		this.TXT_Prov.MaxLength = 2;
		this.TXT_Prov.MsgError = "";
		this.TXT_Prov.Name = "TXT_Prov";
		this.TXT_Prov.SelectOnEnter = true;
		GRLL.Common.ucText tXT_Prov2 = this.TXT_Prov;
		size = new System.Drawing.Size(21, 20);
		tXT_Prov2.Size = size;
		this.TXT_Prov.TabIndex = 6;
		this.TXT_Prov.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.TXT_Prov.TipoDato = GRLL.Common.clsVariables.TipoDato.NumeroEntero;
		this.TXT_Prov.Valida = false;
		this.TXT_Dpto.ActiveBorderColor = System.Drawing.SystemColors.ControlDarkDark;
		this.TXT_Dpto.BackColorFocus = System.Drawing.Color.FromArgb(255, 192, 255);
		this.TXT_Dpto.ExitOnEnter = true;
		this.TXT_Dpto.ExitOnMaxLength = true;
		this.TXT_Dpto.ForeColorFocus = System.Drawing.Color.Blue;
		this.TXT_Dpto.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucText tXT_Dpto = this.TXT_Dpto;
		location = new System.Drawing.Point(84, 3);
		tXT_Dpto.Location = location;
		this.TXT_Dpto.MaxLength = 2;
		this.TXT_Dpto.MsgError = "";
		this.TXT_Dpto.Name = "TXT_Dpto";
		this.TXT_Dpto.SelectOnEnter = true;
		GRLL.Common.ucText tXT_Dpto2 = this.TXT_Dpto;
		size = new System.Drawing.Size(21, 20);
		tXT_Dpto2.Size = size;
		this.TXT_Dpto.TabIndex = 3;
		this.TXT_Dpto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.TXT_Dpto.TipoDato = GRLL.Common.clsVariables.TipoDato.NumeroEntero;
		this.TXT_Dpto.Valida = false;
		this.CMB_Dpto.BackColor = System.Drawing.Color.FromArgb(230, 255, 220);
		this.CMB_Dpto.BackColorDisabled = System.Drawing.Color.Gainsboro;
		this.CMB_Dpto.BackColorFocus = System.Drawing.Color.FromArgb(210, 250, 200);
		this.CMB_Dpto.BackColorNormal = System.Drawing.Color.FromArgb(230, 255, 220);
		this.CMB_Dpto.BdColDecimal = "";
		this.CMB_Dpto.BdColDescrip = "";
		this.CMB_Dpto.BdColInt = "";
		this.CMB_Dpto.BdColIntId = "";
		this.CMB_Dpto.BdColLong = "";
		this.CMB_Dpto.BdColSingle = "";
		this.CMB_Dpto.BdColTextId = "";
		this.CMB_Dpto.BdColTextShow = "";
		this.CMB_Dpto.BdColWhere = "";
		this.CMB_Dpto.BDOrderBy = "";
		this.CMB_Dpto.BDSelect = "";
		this.CMB_Dpto.BDTabla = "";
		this.CMB_Dpto.DividerFormat = "---";
		this.CMB_Dpto.ForeColor = System.Drawing.Color.MediumBlue;
		this.CMB_Dpto.ForeColorDisabled = System.Drawing.Color.DarkGreen;
		this.CMB_Dpto.ForeColorFocus = System.Drawing.Color.Blue;
		this.CMB_Dpto.ForeColorNormal = System.Drawing.Color.MediumBlue;
		this.CMB_Dpto.FormattingEnabled = true;
		this.CMB_Dpto.GroupColor = System.Drawing.Color.Red;
		this.CMB_Dpto.ListIndex = -1;
		ClsCtrls.Combito cMB_Dpto = this.CMB_Dpto;
		location = new System.Drawing.Point(106, 3);
		cMB_Dpto.Location = location;
		this.CMB_Dpto.Name = "CMB_Dpto";
		ClsCtrls.Combito cMB_Dpto2 = this.CMB_Dpto;
		size = new System.Drawing.Size(204, 21);
		cMB_Dpto2.Size = size;
		this.CMB_Dpto.SysCn = null;
		this.CMB_Dpto.TabIndex = 11;
		this.CMB_Prov.BackColor = System.Drawing.Color.FromArgb(230, 255, 220);
		this.CMB_Prov.BackColorDisabled = System.Drawing.Color.Gainsboro;
		this.CMB_Prov.BackColorFocus = System.Drawing.Color.FromArgb(210, 250, 200);
		this.CMB_Prov.BackColorNormal = System.Drawing.Color.FromArgb(230, 255, 220);
		this.CMB_Prov.BdColDecimal = "";
		this.CMB_Prov.BdColDescrip = "";
		this.CMB_Prov.BdColInt = "";
		this.CMB_Prov.BdColIntId = "";
		this.CMB_Prov.BdColLong = "";
		this.CMB_Prov.BdColSingle = "";
		this.CMB_Prov.BdColTextId = "";
		this.CMB_Prov.BdColTextShow = "";
		this.CMB_Prov.BdColWhere = "";
		this.CMB_Prov.BDOrderBy = "";
		this.CMB_Prov.BDSelect = "";
		this.CMB_Prov.BDTabla = "";
		this.CMB_Prov.DividerFormat = "---";
		this.CMB_Prov.ForeColor = System.Drawing.Color.MediumBlue;
		this.CMB_Prov.ForeColorDisabled = System.Drawing.Color.DarkGreen;
		this.CMB_Prov.ForeColorFocus = System.Drawing.Color.Blue;
		this.CMB_Prov.ForeColorNormal = System.Drawing.Color.MediumBlue;
		this.CMB_Prov.FormattingEnabled = true;
		this.CMB_Prov.GroupColor = System.Drawing.Color.Red;
		this.CMB_Prov.ListIndex = -1;
		ClsCtrls.Combito cMB_Prov = this.CMB_Prov;
		location = new System.Drawing.Point(106, 30);
		cMB_Prov.Location = location;
		this.CMB_Prov.Name = "CMB_Prov";
		ClsCtrls.Combito cMB_Prov2 = this.CMB_Prov;
		size = new System.Drawing.Size(204, 21);
		cMB_Prov2.Size = size;
		this.CMB_Prov.SysCn = null;
		this.CMB_Prov.TabIndex = 11;
		this.CMB_Dist.BackColor = System.Drawing.Color.FromArgb(230, 255, 220);
		this.CMB_Dist.BackColorDisabled = System.Drawing.Color.Gainsboro;
		this.CMB_Dist.BackColorFocus = System.Drawing.Color.FromArgb(210, 250, 200);
		this.CMB_Dist.BackColorNormal = System.Drawing.Color.FromArgb(230, 255, 220);
		this.CMB_Dist.BdColDecimal = "";
		this.CMB_Dist.BdColDescrip = "";
		this.CMB_Dist.BdColInt = "";
		this.CMB_Dist.BdColIntId = "";
		this.CMB_Dist.BdColLong = "";
		this.CMB_Dist.BdColSingle = "";
		this.CMB_Dist.BdColTextId = "";
		this.CMB_Dist.BdColTextShow = "";
		this.CMB_Dist.BdColWhere = "";
		this.CMB_Dist.BDOrderBy = "";
		this.CMB_Dist.BDSelect = "";
		this.CMB_Dist.BDTabla = "";
		this.CMB_Dist.DividerFormat = "---";
		this.CMB_Dist.ForeColor = System.Drawing.Color.MediumBlue;
		this.CMB_Dist.ForeColorDisabled = System.Drawing.Color.DarkGreen;
		this.CMB_Dist.ForeColorFocus = System.Drawing.Color.Blue;
		this.CMB_Dist.ForeColorNormal = System.Drawing.Color.MediumBlue;
		this.CMB_Dist.FormattingEnabled = true;
		this.CMB_Dist.GroupColor = System.Drawing.Color.Red;
		this.CMB_Dist.ListIndex = -1;
		ClsCtrls.Combito cMB_Dist = this.CMB_Dist;
		location = new System.Drawing.Point(107, 54);
		cMB_Dist.Location = location;
		this.CMB_Dist.Name = "CMB_Dist";
		ClsCtrls.Combito cMB_Dist2 = this.CMB_Dist;
		size = new System.Drawing.Size(204, 21);
		cMB_Dist2.Size = size;
		this.CMB_Dist.SysCn = null;
		this.CMB_Dist.TabIndex = 11;
		this.pError.ContainerControl = this;
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.White;
		this.Controls.Add(this.CMB_Dist);
		this.Controls.Add(this.CMB_Prov);
		this.Controls.Add(this.CMB_Dpto);
		this.Controls.Add(this.Label3);
		this.Controls.Add(this.Label2);
		this.Controls.Add(this.Label1);
		this.Controls.Add(this.TXT_Dist);
		this.Controls.Add(this.TXT_Prov);
		this.Controls.Add(this.TXT_Dpto);
		this.Name = "ucUbigeoCombito";
		size = new System.Drawing.Size(315, 78);
		this.Size = size;
		((System.ComponentModel.ISupportInitialize)this.pError).EndInit();
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	private void Leer_Ubigeo(string DPD)
	{
		CMB_Dpto.SelectByTextId(DPD.Substring(0, 2));
		CMB_Prov.SelectByTextId(DPD.Substring(2, 2));
		CMB_Dist.SelectByTextId(DPD.Substring(4, 2));
	}

	public void GetDpto()
	{
		SqlCommand oCmd = new SqlCommand();
		try
		{
			oCmd.Connection = sConnection;
			string sSql = "select IdUbigeo, Departamento, Provincia, Distrito, Descripcion from Ubigeo";
			oCmd.CommandText = sSql;
			SqlDataAdapter oDa = new SqlDataAdapter();
			oDa.SelectCommand = oCmd;
			oDs.Tables.Clear();
			oDa.Fill(oDs, "Ubigeo");
			_dv = new DataView(oDs.Tables["Ubigeo"], "Provincia = '00' AND Distrito = '00'", "Descripcion ASC", DataViewRowState.OriginalRows);
			TXT_Dpto.Clear();
			Combito cMB_Dpto = CMB_Dpto;
			cMB_Dpto.BeginUpdate();
			cMB_Dpto.DataSource = null;
			cMB_Dpto.Items.Clear();
			cMB_Dpto.DisplayMember = "Descripcion";
			cMB_Dpto.ValueMember = "Departamento";
			Clases.stListItem c = default(Clases.stListItem);
			foreach (DataRow r in _dv)
			{
				c.TextShow = r["Descripcion"].ToString();
				cMB_Dpto.Items.Add(c);
			}
			cMB_Dpto.EndUpdate();
			cMB_Dpto = null;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ClsFunciones.MuestraMsj(ex2);
			ProjectData.ClearProjectError();
		}
	}

	private void GetProv()
	{
		try
		{
			_dv = new DataView(oDs.Tables["Ubigeo"], Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Departamento = '", CMB_Dpto.SelectedValue), "' AND Provincia <> '00' AND Distrito = '00'")), "Descripcion ASC", DataViewRowState.OriginalRows);
			TXT_Prov.Clear();
			Combito cMB_Prov = CMB_Prov;
			cMB_Prov.BeginUpdate();
			cMB_Prov.DataSource = null;
			cMB_Prov.Items.Clear();
			cMB_Prov.DisplayMember = "Descripcion";
			cMB_Prov.ValueMember = "Provincia";
			Clases.stListItem c = default(Clases.stListItem);
			foreach (DataRow r in _dv)
			{
				c.TextShow = r["Descripcion"].ToString();
				cMB_Prov.Items.Add(c);
			}
			cMB_Prov.EndUpdate();
			cMB_Prov = null;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ClsFunciones.MuestraMsj(ex2);
			ProjectData.ClearProjectError();
		}
	}

	private void GetDist()
	{
		try
		{
			_dv = new DataView(oDs.Tables["Ubigeo"], Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Departamento = '", CMB_Dpto.SelectedValue), "' AND Provincia = '"), CMB_Prov.SelectedValue), "' AND Distrito <> '00'")), "Descripcion ASC", DataViewRowState.OriginalRows);
			TXT_Dist.Clear();
			Combito cMB_Dist = CMB_Dist;
			cMB_Dist.BeginUpdate();
			cMB_Dist.DataSource = null;
			cMB_Dist.Items.Clear();
			cMB_Dist.DisplayMember = "Descripcion";
			cMB_Dist.ValueMember = "Distrito";
			Clases.stListItem c = default(Clases.stListItem);
			foreach (DataRow r in _dv)
			{
				c.TextShow = r["Descripcion"].ToString();
				cMB_Dist.Items.Add(c);
			}
			cMB_Dist.EndUpdate();
			cMB_Dist = null;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ClsFunciones.MuestraMsj(ex2);
			ProjectData.ClearProjectError();
		}
	}

	private void ucUbigeoCmb_Load(object sender, EventArgs e)
	{
		CMB_Dpto.SysCn = sConnection;
		CMB_Prov.SysCn = sConnection;
		CMB_Dist.SysCn = sConnection;
	}

	private void ucUbigeoCmb_Resize(object sender, EventArgs e)
	{
		Height = 78;
		Width = 315;
	}

	private void TXT_Dpto_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			TXT_Dpto.Text = Strings.Right("00" + TXT_Dpto.Text.Trim(), 2);
		}
	}

	private void TXT_Prov_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			TXT_Prov.Text = Strings.Right("00" + TXT_Prov.Text.Trim(), 2);
		}
	}

	private void TXT_Dist_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			TXT_Dist.Text = Strings.Right("00" + TXT_Dist.Text.Trim(), 2);
		}
	}

	private void CMB_Dpto_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
		{
			ucComboBox b = (ucComboBox)sender;
			b.SelectedIndex = -1;
		}
	}

	private void CMB_Dpto_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (CMB_Dpto.SelectedIndex < 0)
		{
			TXT_Dpto.Clear();
			_Ubigeo = "000000";
			ToolTip1.SetToolTip(this, _Ubigeo);
			return;
		}
		_ENCMB_DPTO = true;
		TXT_Dpto.Text = Conversions.ToString(CMB_Dpto.SelectedValue);
		_Ubigeo = TXT_Dpto.Text.Trim() + "0000";
		ToolTip1.SetToolTip(this, _Ubigeo);
		GetProv();
		_ENCMB_DPTO = false;
	}

	private void CMB_Prov_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (CMB_Prov.SelectedIndex < 0)
		{
			TXT_Prov.Clear();
			_Ubigeo = TXT_Dpto.Text.Trim() + "0000";
			ToolTip1.SetToolTip(this, _Ubigeo);
			return;
		}
		_ENCMB_PROV = true;
		TXT_Prov.Text = Conversions.ToString(CMB_Prov.SelectedValue);
		_Ubigeo = TXT_Dpto.Text.Trim() + TXT_Prov.Text.Trim() + "00";
		ToolTip1.SetToolTip(this, _Ubigeo);
		GetDist();
		_ENCMB_PROV = false;
	}

	private void CMB_Dist_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (CMB_Dist.SelectedIndex < 0)
		{
			TXT_Dist.Clear();
			_Ubigeo = TXT_Dpto.Text.Trim() + TXT_Prov.Text.Trim() + "00";
			ToolTip1.SetToolTip(this, _Ubigeo);
		}
		else
		{
			_ENCMB_DTTO = true;
			TXT_Dist.Text = Conversions.ToString(CMB_Dist.SelectedValue);
			_Ubigeo = TXT_Dpto.Text.Trim() + TXT_Prov.Text.Trim() + TXT_Dist.Text.Trim();
			ToolTip1.SetToolTip(this, _Ubigeo);
			_ENCMB_DTTO = false;
		}
	}

	private void TXT_Dpto_Validated(object sender, EventArgs e)
	{
		pError.SetError(TXT_Dpto, null);
		TXT_Dpto.Text = Strings.Right("00" + TXT_Dpto.Text.Trim(), 2);
		if (TXT_Dpto.Text.Length != 2 || _ENCMB_DPTO)
		{
			return;
		}
		if (CMB_Dpto.DataSource == null)
		{
			GetDpto();
		}
		if (CMB_Dpto.DataSource != null && !Operators.ConditionalCompareObjectEqual(CMB_Dpto.SelectedValue, TXT_Dpto.Text, TextCompare: false))
		{
			CMB_Dpto.SelectedValue = Strings.Right("00" + TXT_Dpto.Text.Trim(), 2);
			if (CMB_Dpto.SelectedIndex < 0)
			{
				pError.SetError(TXT_Dpto, "No se encontró el registro : " + TXT_Dpto.Text);
				TXT_Dpto.Clear();
				CMB_Dpto.SelectedIndex = -1;
			}
		}
	}

	private void TXT_Prov_Validated(object sender, EventArgs e)
	{
		pError.SetError(TXT_Prov, null);
		TXT_Prov.Text = Strings.Right("00" + TXT_Prov.Text.Trim(), 2);
		if (TXT_Prov.Text.Length != 2 || _ENCMB_PROV)
		{
			return;
		}
		if (CMB_Prov.DataSource == null)
		{
			GetProv();
		}
		if (CMB_Prov.DataSource != null && !Operators.ConditionalCompareObjectEqual(CMB_Prov.SelectedValue, TXT_Prov.Text, TextCompare: false))
		{
			CMB_Prov.SelectedValue = Strings.Right("00" + TXT_Prov.Text.Trim(), 2);
			if (CMB_Prov.SelectedIndex < 0)
			{
				pError.SetError(TXT_Prov, "No se encontró el registro : " + TXT_Prov.Text);
				TXT_Prov.Clear();
				CMB_Prov.SelectedIndex = -1;
			}
		}
	}

	private void TXT_Dist_Validated(object sender, EventArgs e)
	{
		pError.SetError(TXT_Dist, null);
		TXT_Dist.Text = Strings.Right("00" + TXT_Dist.Text.Trim(), 2);
		if (TXT_Dist.Text.Length != 2 || _ENCMB_DTTO)
		{
			return;
		}
		if (CMB_Dist.DataSource == null)
		{
			GetDist();
		}
		if (CMB_Dist.DataSource != null && !Operators.ConditionalCompareObjectEqual(CMB_Dist.SelectedValue, TXT_Dist.Text, TextCompare: false))
		{
			CMB_Dist.SelectedValue = Strings.Right("00" + TXT_Dist.Text.Trim(), 2);
			if (CMB_Dist.SelectedIndex < 0)
			{
				pError.SetError(TXT_Dist, "No se encontró el registro : " + TXT_Dist.Text);
				TXT_Dist.Clear();
				CMB_Dist.SelectedIndex = -1;
			}
		}
	}
}
