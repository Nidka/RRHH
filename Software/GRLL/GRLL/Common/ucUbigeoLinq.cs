using System;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ClsCtrls;
using GRLL.Common.Conversiones.Rutinas;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GRLL.Common;

[DesignerGenerated]
public class ucUbigeoLinq : UserControl
{
	private IContainer components;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("TXT_Dist")]
	private ucText _TXT_Dist;

	[AccessedThroughProperty("TXT_Prov")]
	private ucText _TXT_Prov;

	[AccessedThroughProperty("TXT_Dpto")]
	private ucText _TXT_Dpto;

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

	private Table<ClsTUbigeo> Ubigeos;

	private bool bEspacioMin;

	private bool bVerTxt;

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
			if (_CMB_Dpto != null)
			{
				_CMB_Dpto.SelectedIndexChanged -= value2;
			}
			_CMB_Dpto = value;
			if (_CMB_Dpto != null)
			{
				_CMB_Dpto.SelectedIndexChanged += value2;
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
			if (_CMB_Prov != null)
			{
				_CMB_Prov.SelectedIndexChanged -= value2;
			}
			_CMB_Prov = value;
			if (_CMB_Prov != null)
			{
				_CMB_Prov.SelectedIndexChanged += value2;
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
			if (_CMB_Dist != null)
			{
				_CMB_Dist.SelectedIndexChanged -= value2;
			}
			_CMB_Dist = value;
			if (_CMB_Dist != null)
			{
				_CMB_Dist.SelectedIndexChanged += value2;
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

	public bool VerTxt
	{
		get
		{
			return bVerTxt;
		}
		set
		{
			bVerTxt = value;
			Redimensionar();
		}
	}

	public bool EspacioMinimo
	{
		get
		{
			return bEspacioMin;
		}
		set
		{
			bEspacioMin = value;
			Redimensionar();
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
			_Ubigeo = Strings.Left(value.Trim() + "000000", 6);
			if (sConnection != null)
			{
				Leer_Ubigeo(_Ubigeo);
			}
		}
	}

	public string IdDepartemento
	{
		get
		{
			if (CMB_Dpto.SelectedIndex < 0)
			{
				return "00";
			}
			return CMB_Dpto.ValorText1;
		}
	}

	public string IdProvincia
	{
		get
		{
			if (CMB_Prov.SelectedIndex < 0)
			{
				return "00";
			}
			return CMB_Prov.ValorText2;
		}
	}

	public string IdDistrito
	{
		get
		{
			if (CMB_Dist.SelectedIndex < 0)
			{
				return "00";
			}
			return CMB_Dist.ValorText3;
		}
	}

	public ucUbigeoLinq()
	{
		base.Load += ucUbigeoLinq_Load;
		base.Resize += ucUbigeoLinq_Resize;
		_Ubigeo = "";
		bEspacioMin = false;
		bVerTxt = true;
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
		this.Label3 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label1 = new System.Windows.Forms.Label();
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
		this.Label3.AutoSize = true;
		System.Windows.Forms.Label label = this.Label3;
		System.Drawing.Point location = new System.Drawing.Point(32, 53);
		label.Location = location;
		this.Label3.Name = "Label3";
		System.Windows.Forms.Label label2 = this.Label3;
		System.Drawing.Size size = new System.Drawing.Size(45, 13);
		label2.Size = size;
		this.Label3.TabIndex = 8;
		this.Label3.Text = "Distrito :";
		this.Label2.AutoSize = true;
		System.Windows.Forms.Label label3 = this.Label2;
		location = new System.Drawing.Point(20, 28);
		label3.Location = location;
		this.Label2.Name = "Label2";
		System.Windows.Forms.Label label4 = this.Label2;
		size = new System.Drawing.Size(57, 13);
		label4.Size = size;
		this.Label2.TabIndex = 7;
		this.Label2.Text = "Provincia :";
		this.Label1.AutoSize = true;
		System.Windows.Forms.Label label5 = this.Label1;
		location = new System.Drawing.Point(-3, 3);
		label5.Location = location;
		this.Label1.Name = "Label1";
		System.Windows.Forms.Label label6 = this.Label1;
		size = new System.Drawing.Size(80, 13);
		label6.Size = size;
		this.Label1.TabIndex = 6;
		this.Label1.Text = "Departamento :";
		this.TXT_Dist.ActiveBorderColor = System.Drawing.SystemColors.ControlDarkDark;
		this.TXT_Dist.BackColorFocus = System.Drawing.Color.FromArgb(255, 192, 255);
		this.TXT_Dist.ExitOnEnter = true;
		this.TXT_Dist.ExitOnMaxLength = true;
		this.TXT_Dist.ForeColorFocus = System.Drawing.Color.Blue;
		this.TXT_Dist.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucText tXT_Dist = this.TXT_Dist;
		location = new System.Drawing.Point(83, 50);
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
		this.TXT_Prov.ActiveBorderColor = System.Drawing.SystemColors.ControlDarkDark;
		this.TXT_Prov.BackColorFocus = System.Drawing.Color.FromArgb(255, 192, 255);
		this.TXT_Prov.ExitOnEnter = true;
		this.TXT_Prov.ExitOnMaxLength = true;
		this.TXT_Prov.ForeColorFocus = System.Drawing.Color.Blue;
		this.TXT_Prov.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucText tXT_Prov = this.TXT_Prov;
		location = new System.Drawing.Point(83, 25);
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
		this.TXT_Dpto.ActiveBorderColor = System.Drawing.SystemColors.ControlDarkDark;
		this.TXT_Dpto.BackColorFocus = System.Drawing.Color.FromArgb(255, 192, 255);
		this.TXT_Dpto.ExitOnEnter = true;
		this.TXT_Dpto.ExitOnMaxLength = true;
		this.TXT_Dpto.ForeColorFocus = System.Drawing.Color.Blue;
		this.TXT_Dpto.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucText tXT_Dpto = this.TXT_Dpto;
		location = new System.Drawing.Point(83, 0);
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
		this.CMB_Dpto.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
		this.CMB_Dpto.BackColorDisabled = System.Drawing.Color.Gainsboro;
		this.CMB_Dpto.BackColorFocus = System.Drawing.Color.FromArgb(255, 255, 255);
		this.CMB_Dpto.BackColorNormal = System.Drawing.Color.FromArgb(255, 255, 255);
		this.CMB_Dpto.BdColDecimal = "";
		this.CMB_Dpto.BdColDescrip = "";
		this.CMB_Dpto.BdColInt = "";
		this.CMB_Dpto.BdColInt1 = "";
		this.CMB_Dpto.BdColInt2 = "";
		this.CMB_Dpto.BdColInt3 = "";
		this.CMB_Dpto.BdColIntId = "";
		this.CMB_Dpto.BdColLong = "";
		this.CMB_Dpto.BdColSingle = "";
		this.CMB_Dpto.BdColText1 = "";
		this.CMB_Dpto.BdColText2 = "";
		this.CMB_Dpto.BdColText3 = "";
		this.CMB_Dpto.BdColTextId = "";
		this.CMB_Dpto.BdColTextShow = "";
		this.CMB_Dpto.BdColWhere = "";
		this.CMB_Dpto.BDOrderBy = "";
		this.CMB_Dpto.BDSelect = "";
		this.CMB_Dpto.BDTabla = "";
		this.CMB_Dpto.Clase = null;
		this.CMB_Dpto.DividerFormat = "---";
		this.CMB_Dpto.ForeColor = System.Drawing.Color.MediumBlue;
		this.CMB_Dpto.ForeColorDisabled = System.Drawing.Color.DarkGreen;
		this.CMB_Dpto.ForeColorFocus = System.Drawing.Color.Blue;
		this.CMB_Dpto.ForeColorNormal = System.Drawing.Color.MediumBlue;
		this.CMB_Dpto.FormattingEnabled = true;
		this.CMB_Dpto.GroupColor = System.Drawing.Color.Red;
		this.CMB_Dpto.ListIndex = -1;
		ClsCtrls.Combito cMB_Dpto = this.CMB_Dpto;
		location = new System.Drawing.Point(110, 0);
		cMB_Dpto.Location = location;
		this.CMB_Dpto.Name = "CMB_Dpto";
		ClsCtrls.Combito cMB_Dpto2 = this.CMB_Dpto;
		size = new System.Drawing.Size(180, 21);
		cMB_Dpto2.Size = size;
		this.CMB_Dpto.SysCn = null;
		this.CMB_Dpto.TabIndex = 3;
		this.CMB_Prov.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
		this.CMB_Prov.BackColorDisabled = System.Drawing.Color.Gainsboro;
		this.CMB_Prov.BackColorFocus = System.Drawing.Color.FromArgb(255, 255, 255);
		this.CMB_Prov.BackColorNormal = System.Drawing.Color.FromArgb(255, 255, 255);
		this.CMB_Prov.BdColDecimal = "";
		this.CMB_Prov.BdColDescrip = "";
		this.CMB_Prov.BdColInt = "";
		this.CMB_Prov.BdColInt1 = "";
		this.CMB_Prov.BdColInt2 = "";
		this.CMB_Prov.BdColInt3 = "";
		this.CMB_Prov.BdColIntId = "";
		this.CMB_Prov.BdColLong = "";
		this.CMB_Prov.BdColSingle = "";
		this.CMB_Prov.BdColText1 = "";
		this.CMB_Prov.BdColText2 = "";
		this.CMB_Prov.BdColText3 = "";
		this.CMB_Prov.BdColTextId = "";
		this.CMB_Prov.BdColTextShow = "";
		this.CMB_Prov.BdColWhere = "";
		this.CMB_Prov.BDOrderBy = "";
		this.CMB_Prov.BDSelect = "";
		this.CMB_Prov.BDTabla = "";
		this.CMB_Prov.Clase = null;
		this.CMB_Prov.DividerFormat = "---";
		this.CMB_Prov.ForeColor = System.Drawing.Color.MediumBlue;
		this.CMB_Prov.ForeColorDisabled = System.Drawing.Color.DarkGreen;
		this.CMB_Prov.ForeColorFocus = System.Drawing.Color.Blue;
		this.CMB_Prov.ForeColorNormal = System.Drawing.Color.MediumBlue;
		this.CMB_Prov.FormattingEnabled = true;
		this.CMB_Prov.GroupColor = System.Drawing.Color.Red;
		this.CMB_Prov.ListIndex = -1;
		ClsCtrls.Combito cMB_Prov = this.CMB_Prov;
		location = new System.Drawing.Point(110, 25);
		cMB_Prov.Location = location;
		this.CMB_Prov.Name = "CMB_Prov";
		ClsCtrls.Combito cMB_Prov2 = this.CMB_Prov;
		size = new System.Drawing.Size(180, 21);
		cMB_Prov2.Size = size;
		this.CMB_Prov.SysCn = null;
		this.CMB_Prov.TabIndex = 4;
		this.CMB_Dist.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
		this.CMB_Dist.BackColorDisabled = System.Drawing.Color.Gainsboro;
		this.CMB_Dist.BackColorFocus = System.Drawing.Color.FromArgb(255, 255, 255);
		this.CMB_Dist.BackColorNormal = System.Drawing.Color.FromArgb(255, 255, 255);
		this.CMB_Dist.BdColDecimal = "";
		this.CMB_Dist.BdColDescrip = "";
		this.CMB_Dist.BdColInt = "";
		this.CMB_Dist.BdColInt1 = "";
		this.CMB_Dist.BdColInt2 = "";
		this.CMB_Dist.BdColInt3 = "";
		this.CMB_Dist.BdColIntId = "";
		this.CMB_Dist.BdColLong = "";
		this.CMB_Dist.BdColSingle = "";
		this.CMB_Dist.BdColText1 = "";
		this.CMB_Dist.BdColText2 = "";
		this.CMB_Dist.BdColText3 = "";
		this.CMB_Dist.BdColTextId = "";
		this.CMB_Dist.BdColTextShow = "";
		this.CMB_Dist.BdColWhere = "";
		this.CMB_Dist.BDOrderBy = "";
		this.CMB_Dist.BDSelect = "";
		this.CMB_Dist.BDTabla = "";
		this.CMB_Dist.Clase = null;
		this.CMB_Dist.DividerFormat = "---";
		this.CMB_Dist.ForeColor = System.Drawing.Color.MediumBlue;
		this.CMB_Dist.ForeColorDisabled = System.Drawing.Color.DarkGreen;
		this.CMB_Dist.ForeColorFocus = System.Drawing.Color.Blue;
		this.CMB_Dist.ForeColorNormal = System.Drawing.Color.MediumBlue;
		this.CMB_Dist.FormattingEnabled = true;
		this.CMB_Dist.GroupColor = System.Drawing.Color.Red;
		this.CMB_Dist.ListIndex = -1;
		ClsCtrls.Combito cMB_Dist = this.CMB_Dist;
		location = new System.Drawing.Point(110, 50);
		cMB_Dist.Location = location;
		this.CMB_Dist.Name = "CMB_Dist";
		ClsCtrls.Combito cMB_Dist2 = this.CMB_Dist;
		size = new System.Drawing.Size(180, 21);
		cMB_Dist2.Size = size;
		this.CMB_Dist.SysCn = null;
		this.CMB_Dist.TabIndex = 5;
		this.pError.ContainerControl = this;
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.Transparent;
		this.Controls.Add(this.TXT_Dist);
		this.Controls.Add(this.TXT_Prov);
		this.Controls.Add(this.TXT_Dpto);
		this.Controls.Add(this.CMB_Dist);
		this.Controls.Add(this.CMB_Prov);
		this.Controls.Add(this.CMB_Dpto);
		this.Controls.Add(this.Label3);
		this.Controls.Add(this.Label2);
		this.Controls.Add(this.Label1);
		this.Name = "ucUbigeoLinq";
		size = new System.Drawing.Size(290, 71);
		this.Size = size;
		((System.ComponentModel.ISupportInitialize)this.pError).EndInit();
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	private void Leer_Ubigeo(string DPD)
	{
		pError.SetError(TXT_Dpto, null);
		pError.SetError(TXT_Prov, null);
		pError.SetError(TXT_Dist, null);
		DPD = (DPD + "000000").Substring(0, 6);
		CMB_Dpto.SelectByText1(DPD.Substring(0, 2));
		CMB_Prov.SelectByText2(DPD.Substring(2, 2));
		CMB_Dist.SelectByText3(DPD.Substring(4, 2));
	}

	public void GetDpto()
	{
		DataContext dc = new DataContext(sConnection);
		Ubigeos = dc.GetTable<ClsTUbigeo>();
		Table<ClsTUbigeo> ubigeos = Ubigeos;
		ParameterExpression parameterExpression = Expression.Parameter(typeof(ClsTUbigeo), "ee");
		IOrderedQueryable<ClsTUbigeo> source = ubigeos.OrderBy(Expression.Lambda<Func<ClsTUbigeo, string>>(Expression.Field(parameterExpression, FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
		ParameterExpression parameterExpression2 = Expression.Parameter(typeof(ClsTUbigeo), "ee");
		IQueryable<ClsTUbigeo> source2 = source.Where(Expression.Lambda<Func<ClsTUbigeo, bool>>(Expression.Equal(Expression.Call(null, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), Expression.Field(parameterExpression2, FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Constant("00", typeof(string)), Expression.Constant(false, typeof(bool))), Expression.Constant(0, typeof(int))), new ParameterExpression[1] { parameterExpression2 }));
		ParameterExpression parameterExpression3 = Expression.Parameter(typeof(ClsTUbigeo), "ee");
		DataTable Departamento = source2.Select(Expression.Lambda<Func<ClsTUbigeo, VB_0024AnonymousType_0<string, string, string, string, string>>>(Expression.New((ConstructorInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(VB_0024AnonymousType_0<string, string, string, string, string>).TypeHandle), new Expression[5]
		{
			Expression.Field(parameterExpression3, FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)),
			Expression.Field(parameterExpression3, FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)),
			Expression.Field(parameterExpression3, FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)),
			Expression.Field(parameterExpression3, FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)),
			Expression.Field(parameterExpression3, FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))
		}, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(VB_0024AnonymousType_0<string, string, string, string, string>).TypeHandle), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(VB_0024AnonymousType_0<string, string, string, string, string>).TypeHandle), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(VB_0024AnonymousType_0<string, string, string, string, string>).TypeHandle), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(VB_0024AnonymousType_0<string, string, string, string, string>).TypeHandle), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(VB_0024AnonymousType_0<string, string, string, string, string>).TypeHandle)), new ParameterExpression[1] { parameterExpression3 })).ToDataTable();
		Combito cMB_Dpto = CMB_Dpto;
		cMB_Dpto.BdColText1 = "CodigoD";
		cMB_Dpto.BdColText2 = "CodigoP";
		cMB_Dpto.BdColText3 = "Codigo";
		cMB_Dpto.BdColTextId = "Ubigeo";
		cMB_Dpto.BdColTextShow = "Descripcion";
		cMB_Dpto.GetData(Departamento);
		cMB_Dpto = null;
	}

	public void Clear()
	{
		CMB_Dpto.SelectedIndex = -1;
		CMB_Dist.Items.Clear();
		CMB_Dist.Clear();
		TXT_Dpto.Clear();
		TXT_Prov.Clear();
		TXT_Dist.Clear();
	}

	private void ucUbigeoLinq_Load(object sender, EventArgs e)
	{
	}

	private void Redimensionar()
	{
		if (bVerTxt)
		{
			if (Width < 155)
			{
				Width = 155;
			}
			CMB_Dpto.Left = 110;
			CMB_Prov.Left = 110;
			CMB_Dist.Left = 110;
			TXT_Dpto.Visible = true;
			TXT_Prov.Visible = true;
			TXT_Dist.Visible = true;
		}
		else
		{
			if (Width < 128)
			{
				Width = 128;
			}
			CMB_Dpto.Left = TXT_Dpto.Left;
			CMB_Prov.Left = TXT_Prov.Left;
			CMB_Dist.Left = TXT_Dist.Left;
			TXT_Dpto.Visible = false;
			TXT_Prov.Visible = false;
			TXT_Dist.Visible = false;
		}
		checked
		{
			int iWidth = Width - CMB_Dpto.Location.X - 1;
			CMB_Dpto.Width = iWidth;
			CMB_Prov.Width = iWidth;
			CMB_Dist.Width = iWidth;
			if (CMB_Dpto.Width < 250)
			{
				CMB_Dpto.DropDownWidth = 250;
			}
			if (CMB_Prov.Width < 250)
			{
				CMB_Prov.DropDownWidth = 250;
			}
			if (CMB_Dist.Width < 250)
			{
				CMB_Dist.DropDownWidth = 250;
			}
			int iIncrem = 25;
			if (bEspacioMin)
			{
				iIncrem = 19;
				Height = 59;
			}
			else
			{
				Height = 71;
			}
			CMB_Prov.Top = CMB_Dpto.Top + iIncrem;
			TXT_Prov.Top = TXT_Dpto.Top + iIncrem;
			Label2.Top = Label1.Top + iIncrem;
			CMB_Dist.Top = CMB_Prov.Top + iIncrem;
			TXT_Dist.Top = TXT_Prov.Top + iIncrem;
			Label3.Top = Label2.Top + iIncrem;
		}
	}

	private void ucUbigeoLinq_Resize(object sender, EventArgs e)
	{
		Redimensionar();
	}

	private void CMB_Dpto_SelectedIndexChanged(object sender, EventArgs e)
	{
		CMB_Prov.Items.Clear();
		CMB_Prov.Clear();
		TXT_Prov.Clear();
		CMB_Dist.Items.Clear();
		CMB_Dist.Clear();
		TXT_Dist.Clear();
		if (CMB_Dpto.SelectedIndex < 0)
		{
			_Ubigeo = "000000";
			TXT_Dpto.Text = "";
		}
		else
		{
			pError.SetError(TXT_Dpto, null);
			TXT_Dpto.Text = CMB_Dpto.ValorText1;
			_Ubigeo = TXT_Dpto.Text.Trim() + "0000";
			Table<ClsTUbigeo> ubigeos = Ubigeos;
			ParameterExpression parameterExpression = Expression.Parameter(typeof(ClsTUbigeo), "ee");
			IOrderedQueryable<ClsTUbigeo> source = ubigeos.OrderBy(Expression.Lambda<Func<ClsTUbigeo, string>>(Expression.Field(parameterExpression, FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
			ParameterExpression parameterExpression2 = Expression.Parameter(typeof(ClsTUbigeo), "ee");
			IQueryable<ClsTUbigeo> source2 = source.Where(Expression.Lambda<Func<ClsTUbigeo, bool>>(Expression.AndAlso(Expression.AndAlso(Expression.Equal(Expression.Call(null, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), Expression.Field(parameterExpression2, FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Property(Expression.Property(Expression.Constant(this, typeof(ucUbigeoLinq)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Constant(false, typeof(bool))), Expression.Constant(0, typeof(int))), Expression.NotEqual(Expression.Call(null, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), Expression.Field(parameterExpression2, FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Constant("00", typeof(string)), Expression.Constant(false, typeof(bool))), Expression.Constant(0, typeof(int)))), Expression.Equal(Expression.Call(null, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), Expression.Field(parameterExpression2, FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Constant("00", typeof(string)), Expression.Constant(false, typeof(bool))), Expression.Constant(0, typeof(int)))), new ParameterExpression[1] { parameterExpression2 }));
			ParameterExpression parameterExpression3 = Expression.Parameter(typeof(ClsTUbigeo), "ee");
			DataTable Provincia = source2.Select(Expression.Lambda<Func<ClsTUbigeo, VB_0024AnonymousType_0<string, string, string, string, string>>>(Expression.New((ConstructorInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(VB_0024AnonymousType_0<string, string, string, string, string>).TypeHandle), new Expression[5]
			{
				Expression.Field(parameterExpression3, FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)),
				Expression.Field(parameterExpression3, FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)),
				Expression.Field(parameterExpression3, FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)),
				Expression.Field(parameterExpression3, FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)),
				Expression.Field(parameterExpression3, FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))
			}, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(VB_0024AnonymousType_0<string, string, string, string, string>).TypeHandle), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(VB_0024AnonymousType_0<string, string, string, string, string>).TypeHandle), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(VB_0024AnonymousType_0<string, string, string, string, string>).TypeHandle), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(VB_0024AnonymousType_0<string, string, string, string, string>).TypeHandle), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(VB_0024AnonymousType_0<string, string, string, string, string>).TypeHandle)), new ParameterExpression[1] { parameterExpression3 })).ToDataTable();
			Combito cMB_Prov = CMB_Prov;
			cMB_Prov.BdColText1 = "CodigoD";
			cMB_Prov.BdColText2 = "CodigoP";
			cMB_Prov.BdColText3 = "Codigo";
			cMB_Prov.BdColTextId = "Ubigeo";
			cMB_Prov.BdColTextShow = "Descripcion";
			cMB_Prov.GetData(Provincia);
			cMB_Prov = null;
			if (CMB_Prov.ListCount == 1)
			{
				CMB_Prov.SelectedIndex = 0;
			}
		}
		CMB_Dist.SelectedIndex = -1;
	}

	private void CMB_Prov_SelectedIndexChanged(object sender, EventArgs e)
	{
		CMB_Dist.Items.Clear();
		CMB_Dist.Clear();
		TXT_Dist.Clear();
		if (CMB_Prov.SelectedIndex < 0)
		{
			_Ubigeo = TXT_Dpto.Text.Trim() + "0000";
			TXT_Prov.Text = "";
			return;
		}
		pError.SetError(TXT_Prov, null);
		TXT_Prov.Text = CMB_Prov.ValorText2;
		_Ubigeo = TXT_Dpto.Text.Trim() + TXT_Prov.Text.Trim() + "00";
		Table<ClsTUbigeo> ubigeos = Ubigeos;
		ParameterExpression parameterExpression = Expression.Parameter(typeof(ClsTUbigeo), "ee");
		IOrderedQueryable<ClsTUbigeo> source = ubigeos.OrderBy(Expression.Lambda<Func<ClsTUbigeo, string>>(Expression.Field(parameterExpression, FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
		ParameterExpression parameterExpression2 = Expression.Parameter(typeof(ClsTUbigeo), "ee");
		IQueryable<ClsTUbigeo> source2 = source.Where(Expression.Lambda<Func<ClsTUbigeo, bool>>(Expression.AndAlso(Expression.AndAlso(Expression.Equal(Expression.Call(null, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), Expression.Field(parameterExpression2, FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Property(Expression.Property(Expression.Constant(this, typeof(ucUbigeoLinq)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Constant(false, typeof(bool))), Expression.Constant(0, typeof(int))), Expression.Equal(Expression.Call(null, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), Expression.Field(parameterExpression2, FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Property(Expression.Property(Expression.Constant(this, typeof(ucUbigeoLinq)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Constant(false, typeof(bool))), Expression.Constant(0, typeof(int)))), Expression.NotEqual(Expression.Call(null, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), Expression.Field(parameterExpression2, FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Constant("00", typeof(string)), Expression.Constant(false, typeof(bool))), Expression.Constant(0, typeof(int)))), new ParameterExpression[1] { parameterExpression2 }));
		ParameterExpression parameterExpression3 = Expression.Parameter(typeof(ClsTUbigeo), "ee");
		DataTable Distrito = source2.Select(Expression.Lambda<Func<ClsTUbigeo, VB_0024AnonymousType_0<string, string, string, string, string>>>(Expression.New((ConstructorInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(VB_0024AnonymousType_0<string, string, string, string, string>).TypeHandle), new Expression[5]
		{
			Expression.Field(parameterExpression3, FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)),
			Expression.Field(parameterExpression3, FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)),
			Expression.Field(parameterExpression3, FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)),
			Expression.Field(parameterExpression3, FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)),
			Expression.Field(parameterExpression3, FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))
		}, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(VB_0024AnonymousType_0<string, string, string, string, string>).TypeHandle), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(VB_0024AnonymousType_0<string, string, string, string, string>).TypeHandle), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(VB_0024AnonymousType_0<string, string, string, string, string>).TypeHandle), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(VB_0024AnonymousType_0<string, string, string, string, string>).TypeHandle), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(VB_0024AnonymousType_0<string, string, string, string, string>).TypeHandle)), new ParameterExpression[1] { parameterExpression3 })).ToDataTable();
		Combito cMB_Dist = CMB_Dist;
		cMB_Dist.BdColText1 = "CodigoD";
		cMB_Dist.BdColText2 = "CodigoP";
		cMB_Dist.BdColText3 = "Codigo";
		cMB_Dist.BdColTextId = "Ubigeo";
		cMB_Dist.BdColTextShow = "Descripcion";
		cMB_Dist.GetData(Distrito);
		cMB_Dist = null;
		if (CMB_Dist.ListCount == 1)
		{
			CMB_Dist.SelectedIndex = 0;
		}
	}

	private void CMB_Dist_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (CMB_Dist.SelectedIndex < 0)
		{
			_Ubigeo = TXT_Dpto.Text.Trim() + TXT_Prov.Text.Trim() + "00";
			TXT_Dist.Text = "";
		}
		else
		{
			pError.SetError(TXT_Dist, null);
			TXT_Dist.Text = CMB_Dist.ValorText3;
			_Ubigeo = TXT_Dpto.Text.Trim() + TXT_Prov.Text.Trim() + TXT_Dist.Text.Trim();
		}
	}

	private void TXT_Dist_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return && Versioned.IsNumeric(TXT_Dist.Text) && Conversions.ToInteger(TXT_Dist.Text) >= 1)
		{
			TXT_Dist.Text = Strings.Right("00" + TXT_Dist.Text.Trim(), 2);
		}
	}

	private void TXT_Dist_Validated(object sender, EventArgs e)
	{
		pError.SetError(TXT_Dist, null);
		TXT_Dist.Text = Strings.Right("00" + TXT_Dist.Text.Trim(), 2);
		if (TXT_Dist.Text.Length == 2 && Operators.CompareString(CMB_Dist.ValorText3, TXT_Dist.Text, TextCompare: false) != 0)
		{
			CMB_Dist.SelectByText3(TXT_Dist.Text);
			if (Operators.CompareString(CMB_Dist.Text, "", TextCompare: false) == 0)
			{
				CMB_Dist.SelectedIndex = -1;
			}
			if (CMB_Dist.SelectedIndex < 0)
			{
				pError.SetError(TXT_Dist, "No se encontró el registro : " + TXT_Dist.Text);
				TXT_Dist.Clear();
				CMB_Dist.SelectedIndex = -1;
			}
		}
	}

	private void TXT_Dpto_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return && Versioned.IsNumeric(TXT_Dpto.Text) && Conversions.ToInteger(TXT_Dpto.Text) >= 1)
		{
			TXT_Dpto.Text = Strings.Right("00" + TXT_Dpto.Text.Trim(), 2);
		}
	}

	private void TXT_Dpto_Validated(object sender, EventArgs e)
	{
		pError.SetError(TXT_Dpto, null);
		TXT_Dpto.Text = Strings.Right("00" + TXT_Dpto.Text.Trim(), 2);
		if (TXT_Dpto.Text.Length == 2 && Operators.CompareString(CMB_Dpto.ValorText1, TXT_Dpto.Text, TextCompare: false) != 0)
		{
			CMB_Dpto.SelectByText1(TXT_Dpto.Text);
			if (Operators.CompareString(CMB_Dpto.Text, "", TextCompare: false) == 0)
			{
				CMB_Dpto.SelectedIndex = -1;
			}
			if (CMB_Dpto.SelectedIndex < 0)
			{
				pError.SetError(TXT_Dpto, "No se encontró el registro : " + TXT_Dpto.Text);
				TXT_Dpto.Clear();
				CMB_Dpto.SelectedIndex = -1;
			}
		}
	}

	private void TXT_Prov_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return && Versioned.IsNumeric(TXT_Prov.Text) && Conversions.ToInteger(TXT_Prov.Text) >= 1)
		{
			TXT_Prov.Text = Strings.Right("00" + TXT_Prov.Text.Trim(), 2);
		}
	}

	private void TXT_Prov_Validated(object sender, EventArgs e)
	{
		pError.SetError(TXT_Prov, null);
		TXT_Prov.Text = Strings.Right("00" + TXT_Prov.Text.Trim(), 2);
		if (TXT_Prov.Text.Length == 2 && Operators.CompareString(CMB_Prov.ValorText2, TXT_Prov.Text, TextCompare: false) != 0)
		{
			CMB_Prov.SelectByText2(TXT_Prov.Text);
			if (Operators.CompareString(CMB_Prov.Text, "", TextCompare: false) == 0)
			{
				CMB_Prov.SelectedIndex = -1;
			}
			if (CMB_Prov.SelectedIndex < 0)
			{
				pError.SetError(TXT_Prov, "No se encontró el registro : " + TXT_Prov.Text);
				TXT_Prov.Clear();
				CMB_Prov.SelectedIndex = -1;
			}
		}
	}
}
