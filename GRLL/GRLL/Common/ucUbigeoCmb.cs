using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GRLL.Common;

[DesignerGenerated]
public class ucUbigeoCmb : UserControl
{
	private IContainer components;

	[AccessedThroughProperty("UcLabel1")]
	private ucLabel _UcLabel1;

	[AccessedThroughProperty("UcLabel2")]
	private ucLabel _UcLabel2;

	[AccessedThroughProperty("UcLabel3")]
	private ucLabel _UcLabel3;

	[AccessedThroughProperty("TXT_Dpto")]
	private ucText _TXT_Dpto;

	[AccessedThroughProperty("CMB_Dpto")]
	private ucComboBox _CMB_Dpto;

	[AccessedThroughProperty("TXT_Prov")]
	private ucText _TXT_Prov;

	[AccessedThroughProperty("CMB_Prov")]
	private ucComboBox _CMB_Prov;

	[AccessedThroughProperty("TXT_Dist")]
	private ucText _TXT_Dist;

	[AccessedThroughProperty("CMB_Dist")]
	private ucComboBox _CMB_Dist;

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

	internal ucLabel UcLabel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcLabel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcLabel1 = value;
		}
	}

	internal ucLabel UcLabel2
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcLabel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcLabel2 = value;
		}
	}

	internal ucLabel UcLabel3
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcLabel3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcLabel3 = value;
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

	internal ucComboBox CMB_Dpto
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

	internal ucComboBox CMB_Prov
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

	internal ucComboBox CMB_Dist
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

	public ucUbigeoCmb()
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
		this.pError = new System.Windows.Forms.ErrorProvider(this.components);
		this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
		this.CMB_Dist = new GRLL.Common.ucComboBox();
		this.TXT_Dist = new GRLL.Common.ucText();
		this.CMB_Prov = new GRLL.Common.ucComboBox();
		this.TXT_Prov = new GRLL.Common.ucText();
		this.CMB_Dpto = new GRLL.Common.ucComboBox();
		this.TXT_Dpto = new GRLL.Common.ucText();
		this.UcLabel3 = new GRLL.Common.ucLabel();
		this.UcLabel2 = new GRLL.Common.ucLabel();
		this.UcLabel1 = new GRLL.Common.ucLabel();
		((System.ComponentModel.ISupportInitialize)this.pError).BeginInit();
		this.SuspendLayout();
		this.pError.ContainerControl = this;
		this.CMB_Dist.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.CMB_Dist.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.CMB_Dist.DropDownWidth = 250;
		this.CMB_Dist.FormattingEnabled = true;
		GRLL.Common.ucComboBox cMB_Dist = this.CMB_Dist;
		System.Drawing.Point location = new System.Drawing.Point(106, 58);
		cMB_Dist.Location = location;
		this.CMB_Dist.Name = "CMB_Dist";
		GRLL.Common.ucComboBox cMB_Dist2 = this.CMB_Dist;
		System.Drawing.Size size = new System.Drawing.Size(195, 21);
		cMB_Dist2.Size = size;
		this.CMB_Dist.TabIndex = 5;
		this.TXT_Dist.ActiveBorderColor = System.Drawing.SystemColors.ControlDarkDark;
		this.TXT_Dist.BackColorFocus = System.Drawing.Color.FromArgb(255, 192, 255);
		this.TXT_Dist.ExitOnEnter = true;
		this.TXT_Dist.ExitOnMaxLength = true;
		this.TXT_Dist.ForeColorFocus = System.Drawing.Color.Blue;
		this.TXT_Dist.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucText tXT_Dist = this.TXT_Dist;
		location = new System.Drawing.Point(85, 58);
		tXT_Dist.Location = location;
		this.TXT_Dist.MaxLength = 2;
		this.TXT_Dist.MsgError = "";
		this.TXT_Dist.Name = "TXT_Dist";
		this.TXT_Dist.SelectOnEnter = true;
		GRLL.Common.ucText tXT_Dist2 = this.TXT_Dist;
		size = new System.Drawing.Size(21, 20);
		tXT_Dist2.Size = size;
		this.TXT_Dist.TabIndex = 2;
		this.TXT_Dist.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.TXT_Dist.TipoDato = GRLL.Common.clsVariables.TipoDato.NumeroEntero;
		this.TXT_Dist.Valida = false;
		this.CMB_Prov.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.CMB_Prov.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.CMB_Prov.DropDownWidth = 250;
		this.CMB_Prov.FormattingEnabled = true;
		GRLL.Common.ucComboBox cMB_Prov = this.CMB_Prov;
		location = new System.Drawing.Point(105, 34);
		cMB_Prov.Location = location;
		this.CMB_Prov.Name = "CMB_Prov";
		GRLL.Common.ucComboBox cMB_Prov2 = this.CMB_Prov;
		size = new System.Drawing.Size(195, 21);
		cMB_Prov2.Size = size;
		this.CMB_Prov.TabIndex = 4;
		this.TXT_Prov.ActiveBorderColor = System.Drawing.SystemColors.ControlDarkDark;
		this.TXT_Prov.BackColorFocus = System.Drawing.Color.FromArgb(255, 192, 255);
		this.TXT_Prov.ExitOnEnter = true;
		this.TXT_Prov.ExitOnMaxLength = true;
		this.TXT_Prov.ForeColorFocus = System.Drawing.Color.Blue;
		this.TXT_Prov.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucText tXT_Prov = this.TXT_Prov;
		location = new System.Drawing.Point(84, 34);
		tXT_Prov.Location = location;
		this.TXT_Prov.MaxLength = 2;
		this.TXT_Prov.MsgError = "";
		this.TXT_Prov.Name = "TXT_Prov";
		this.TXT_Prov.SelectOnEnter = true;
		GRLL.Common.ucText tXT_Prov2 = this.TXT_Prov;
		size = new System.Drawing.Size(21, 20);
		tXT_Prov2.Size = size;
		this.TXT_Prov.TabIndex = 1;
		this.TXT_Prov.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.TXT_Prov.TipoDato = GRLL.Common.clsVariables.TipoDato.NumeroEntero;
		this.TXT_Prov.Valida = false;
		this.CMB_Dpto.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.CMB_Dpto.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.CMB_Dpto.DropDownWidth = 250;
		this.CMB_Dpto.FormattingEnabled = true;
		GRLL.Common.ucComboBox cMB_Dpto = this.CMB_Dpto;
		location = new System.Drawing.Point(105, 7);
		cMB_Dpto.Location = location;
		this.CMB_Dpto.Name = "CMB_Dpto";
		GRLL.Common.ucComboBox cMB_Dpto2 = this.CMB_Dpto;
		size = new System.Drawing.Size(195, 21);
		cMB_Dpto2.Size = size;
		this.CMB_Dpto.TabIndex = 3;
		this.TXT_Dpto.ActiveBorderColor = System.Drawing.SystemColors.ControlDarkDark;
		this.TXT_Dpto.BackColorFocus = System.Drawing.Color.FromArgb(255, 192, 255);
		this.TXT_Dpto.ExitOnEnter = true;
		this.TXT_Dpto.ExitOnMaxLength = true;
		this.TXT_Dpto.ForeColorFocus = System.Drawing.Color.Blue;
		this.TXT_Dpto.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucText tXT_Dpto = this.TXT_Dpto;
		location = new System.Drawing.Point(84, 7);
		tXT_Dpto.Location = location;
		this.TXT_Dpto.MaxLength = 2;
		this.TXT_Dpto.MsgError = "";
		this.TXT_Dpto.Name = "TXT_Dpto";
		this.TXT_Dpto.SelectOnEnter = true;
		GRLL.Common.ucText tXT_Dpto2 = this.TXT_Dpto;
		size = new System.Drawing.Size(21, 20);
		tXT_Dpto2.Size = size;
		this.TXT_Dpto.TabIndex = 0;
		this.TXT_Dpto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.TXT_Dpto.TipoDato = GRLL.Common.clsVariables.TipoDato.NumeroEntero;
		this.TXT_Dpto.Valida = false;
		GRLL.Common.ucLabel ucLabel2 = this.UcLabel3;
		location = new System.Drawing.Point(44, 61);
		ucLabel2.Location = location;
		this.UcLabel3.Name = "UcLabel3";
		GRLL.Common.ucLabel ucLabel3 = this.UcLabel3;
		size = new System.Drawing.Size(46, 15);
		ucLabel3.Size = size;
		this.UcLabel3.TabIndex = 1;
		this.UcLabel3.TabStop = false;
		this.UcLabel3.Text = "Distrito :";
		GRLL.Common.ucLabel ucLabel4 = this.UcLabel2;
		location = new System.Drawing.Point(32, 37);
		ucLabel4.Location = location;
		this.UcLabel2.Name = "UcLabel2";
		GRLL.Common.ucLabel ucLabel5 = this.UcLabel2;
		size = new System.Drawing.Size(58, 15);
		ucLabel5.Size = size;
		this.UcLabel2.TabIndex = 1;
		this.UcLabel2.TabStop = false;
		this.UcLabel2.Text = "Provincia :";
		GRLL.Common.ucLabel ucLabel6 = this.UcLabel1;
		location = new System.Drawing.Point(7, 10);
		ucLabel6.Location = location;
		this.UcLabel1.Name = "UcLabel1";
		GRLL.Common.ucLabel ucLabel7 = this.UcLabel1;
		size = new System.Drawing.Size(83, 15);
		ucLabel7.Size = size;
		this.UcLabel1.TabIndex = 1;
		this.UcLabel1.TabStop = false;
		this.UcLabel1.Text = "Departamento :";
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.Transparent;
		this.Controls.Add(this.CMB_Dist);
		this.Controls.Add(this.TXT_Dist);
		this.Controls.Add(this.CMB_Prov);
		this.Controls.Add(this.TXT_Prov);
		this.Controls.Add(this.CMB_Dpto);
		this.Controls.Add(this.TXT_Dpto);
		this.Controls.Add(this.UcLabel3);
		this.Controls.Add(this.UcLabel2);
		this.Controls.Add(this.UcLabel1);
		this.Name = "ucUbigeoCmb";
		size = new System.Drawing.Size(304, 89);
		this.Size = size;
		((System.ComponentModel.ISupportInitialize)this.pError).EndInit();
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	private void Leer_Ubigeo(string DPD)
	{
		CMB_Dpto.SelectedValue = DPD.Substring(0, 2);
		CMB_Prov.SelectedValue = DPD.Substring(2, 2);
		CMB_Dist.SelectedValue = DPD.Substring(4, 2);
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
			ucComboBox cMB_Dpto = CMB_Dpto;
			cMB_Dpto.BeginUpdate();
			cMB_Dpto.DataSource = null;
			cMB_Dpto.Items.Clear();
			cMB_Dpto.DisplayMember = "Descripcion";
			cMB_Dpto.ValueMember = "Departamento";
			cMB_Dpto.DataSource = _dv;
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
			ucComboBox cMB_Prov = CMB_Prov;
			cMB_Prov.BeginUpdate();
			cMB_Prov.DataSource = null;
			cMB_Prov.Items.Clear();
			cMB_Prov.DisplayMember = "Descripcion";
			cMB_Prov.ValueMember = "Provincia";
			cMB_Prov.DataSource = _dv;
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
			ucComboBox cMB_Dist = CMB_Dist;
			cMB_Dist.BeginUpdate();
			cMB_Dist.DataSource = null;
			cMB_Dist.Items.Clear();
			cMB_Dist.DisplayMember = "Descripcion";
			cMB_Dist.ValueMember = "Distrito";
			cMB_Dist.DataSource = _dv;
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
	}

	private void ucUbigeoCmb_Resize(object sender, EventArgs e)
	{
		Height = 86;
		Width = 304;
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
