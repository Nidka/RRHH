using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ClassRRHH;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using GRLL.Common;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using RecursosHumanos.My.Resources;

namespace RecursosHumanos;

[DesignerGenerated]
public class FrmPermiso : FrmConsulta
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("UcTxtApePater")]
	private ucTextBox _UcTxtApePater;

	[AccessedThroughProperty("UcTxtNombres")]
	private ucTextBox _UcTxtNombres;

	[AccessedThroughProperty("UcTxtApeMater")]
	private ucTextBox _UcTxtApeMater;

	[AccessedThroughProperty("UcFoto")]
	private ucFoto _UcFoto;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("UcTxtNDoc")]
	private ucTextBox _UcTxtNDoc;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("GroupControl1")]
	private GroupControl _GroupControl1;

	[AccessedThroughProperty("GroupControl2")]
	private GroupControl _GroupControl2;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("UcCmbMotivo")]
	private ucComboBox _UcCmbMotivo;

	[AccessedThroughProperty("UcFechas")]
	private ucFechas _UcFechas;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("DefaultLookAndFeel1")]
	private DefaultLookAndFeel _DefaultLookAndFeel1;

	[AccessedThroughProperty("UcTxtRef")]
	private ucTextBox _UcTxtRef;

	[AccessedThroughProperty("CheckEditDia")]
	private CheckEdit _CheckEditDia;

	[AccessedThroughProperty("UcCmbTipoPermiso")]
	private ucComboBox _UcCmbTipoPermiso;

	[AccessedThroughProperty("UcTxtLugar")]
	private ucTextBox _UcTxtLugar;

	[AccessedThroughProperty("UcTxtAutorizacion")]
	private ucTextBox _UcTxtAutorizacion;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("CheckEditRetorno")]
	private CheckEdit _CheckEditRetorno;

	[AccessedThroughProperty("Lbl_Tipo")]
	private Label _Lbl_Tipo;

	[AccessedThroughProperty("UcTxtObs")]
	private ucTextBox _UcTxtObs;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("ToolTipController1")]
	private ToolTipController _ToolTipController1;

	[AccessedThroughProperty("CheckEquipoMarcacion")]
	private CheckEdit _CheckEquipoMarcacion;

	public int idEmpleado;

	public int Npermiso;

	private byte[] img;

	private RRHHClass objClassRRHH;

	internal ucTextBox UcTxtApePater
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtApePater;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtApePater = value;
		}
	}

	internal ucTextBox UcTxtNombres
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtNombres;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtNombres = value;
		}
	}

	internal ucTextBox UcTxtApeMater
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtApeMater;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtApeMater = value;
		}
	}

	internal ucFoto UcFoto
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcFoto;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcFoto = value;
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

	internal ucTextBox UcTxtNDoc
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtNDoc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtNDoc = value;
		}
	}

	internal Label Label5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label5 = value;
		}
	}

	internal GroupControl GroupControl1
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupControl1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupControl1 = value;
		}
	}

	internal GroupControl GroupControl2
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupControl2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupControl2 = value;
		}
	}

	internal Label Label7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label7 = value;
		}
	}

	internal Label Label6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label6 = value;
		}
	}

	internal ucComboBox UcCmbMotivo
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcCmbMotivo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = UcCmbMotivo_SelectedIndexChanged;
			if (_UcCmbMotivo != null)
			{
				_UcCmbMotivo.SelectedIndexChanged -= value2;
			}
			_UcCmbMotivo = value;
			if (_UcCmbMotivo != null)
			{
				_UcCmbMotivo.SelectedIndexChanged += value2;
			}
		}
	}

	internal ucFechas UcFechas
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcFechas;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcFechas = value;
		}
	}

	internal Label Label8
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label8 = value;
		}
	}

	internal Button Button1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = Button1_Click;
			if (_Button1 != null)
			{
				_Button1.Click -= value2;
			}
			_Button1 = value;
			if (_Button1 != null)
			{
				_Button1.Click += value2;
			}
		}
	}

	internal DefaultLookAndFeel DefaultLookAndFeel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _DefaultLookAndFeel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DefaultLookAndFeel1 = value;
		}
	}

	internal ucTextBox UcTxtRef
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtRef;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtRef = value;
		}
	}

	internal CheckEdit CheckEditDia
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckEditDia;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = CheckEditDia_Click;
			if (_CheckEditDia != null)
			{
				_CheckEditDia.Click -= value2;
			}
			_CheckEditDia = value;
			if (_CheckEditDia != null)
			{
				_CheckEditDia.Click += value2;
			}
		}
	}

	internal ucComboBox UcCmbTipoPermiso
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcCmbTipoPermiso;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = UcCmbTipoPermiso_SelectedIndexChanged;
			if (_UcCmbTipoPermiso != null)
			{
				_UcCmbTipoPermiso.SelectedIndexChanged -= value2;
			}
			_UcCmbTipoPermiso = value;
			if (_UcCmbTipoPermiso != null)
			{
				_UcCmbTipoPermiso.SelectedIndexChanged += value2;
			}
		}
	}

	internal ucTextBox UcTxtLugar
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtLugar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtLugar = value;
		}
	}

	internal ucTextBox UcTxtAutorizacion
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtAutorizacion;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtAutorizacion = value;
		}
	}

	internal Label Label9
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label9 = value;
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

	internal Label Label10
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label10 = value;
		}
	}

	internal CheckEdit CheckEditRetorno
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckEditRetorno;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = CheckEditRetorno_Click;
			if (_CheckEditRetorno != null)
			{
				_CheckEditRetorno.Click -= value2;
			}
			_CheckEditRetorno = value;
			if (_CheckEditRetorno != null)
			{
				_CheckEditRetorno.Click += value2;
			}
		}
	}

	internal Label Lbl_Tipo
	{
		[DebuggerNonUserCode]
		get
		{
			return _Lbl_Tipo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Lbl_Tipo = value;
		}
	}

	internal ucTextBox UcTxtObs
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtObs;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtObs = value;
		}
	}

	internal Label Label11
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label11 = value;
		}
	}

	internal ToolTipController ToolTipController1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolTipController1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolTipController1 = value;
		}
	}

	internal CheckEdit CheckEquipoMarcacion
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckEquipoMarcacion;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CheckEquipoMarcacion = value;
		}
	}

	public FrmPermiso()
	{
		base.Load += FrmPermiso_Load;
		__ENCAddToList(this);
		img = null;
		objClassRRHH = new RRHHClass();
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
		this.components = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecursosHumanos.FrmPermiso));
		DevExpress.Utils.SuperToolTip superToolTip = new DevExpress.Utils.SuperToolTip();
		DevExpress.Utils.ToolTipTitleItem toolTipTitleItem = new DevExpress.Utils.ToolTipTitleItem();
		DevExpress.Utils.ToolTipItem toolTipItem = new DevExpress.Utils.ToolTipItem();
		this.UcTxtApePater = new GRLL.Common.ucTextBox(this.components);
		this.UcTxtNombres = new GRLL.Common.ucTextBox(this.components);
		this.UcTxtApeMater = new GRLL.Common.ucTextBox(this.components);
		this.UcFoto = new GRLL.Common.ucFoto();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label1 = new System.Windows.Forms.Label();
		this.UcTxtNDoc = new GRLL.Common.ucTextBox(this.components);
		this.Label5 = new System.Windows.Forms.Label();
		this.GroupControl1 = new DevExpress.XtraEditors.GroupControl();
		this.GroupControl2 = new DevExpress.XtraEditors.GroupControl();
		this.Lbl_Tipo = new System.Windows.Forms.Label();
		this.UcCmbTipoPermiso = new GRLL.Common.ucComboBox();
		this.UcTxtObs = new GRLL.Common.ucTextBox(this.components);
		this.UcTxtLugar = new GRLL.Common.ucTextBox(this.components);
		this.UcTxtAutorizacion = new GRLL.Common.ucTextBox(this.components);
		this.UcTxtRef = new GRLL.Common.ucTextBox(this.components);
		this.Label11 = new System.Windows.Forms.Label();
		this.Label9 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label8 = new System.Windows.Forms.Label();
		this.Label7 = new System.Windows.Forms.Label();
		this.Label10 = new System.Windows.Forms.Label();
		this.Label6 = new System.Windows.Forms.Label();
		this.UcCmbMotivo = new GRLL.Common.ucComboBox();
		this.UcFechas = new GRLL.Common.ucFechas();
		this.CheckEditRetorno = new DevExpress.XtraEditors.CheckEdit();
		this.CheckEditDia = new DevExpress.XtraEditors.CheckEdit();
		this.Button1 = new System.Windows.Forms.Button();
		this.DefaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
		this.ToolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
		this.CheckEquipoMarcacion = new DevExpress.XtraEditors.CheckEdit();
		((System.ComponentModel.ISupportInitialize)this.GroupControl1).BeginInit();
		this.GroupControl1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.GroupControl2).BeginInit();
		this.GroupControl2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.CheckEditRetorno.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.CheckEditDia.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.CheckEquipoMarcacion.Properties).BeginInit();
		this.SuspendLayout();
		this.cmdCerrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.cmdCerrar.AutoSize = true;
		this.cmdCerrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.cmdCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cmdCerrar.FlatAppearance.BorderSize = 0;
		this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.cmdCerrar.Image = (System.Drawing.Image)resources.GetObject("cmdCerrar.Image");
		System.Windows.Forms.Button button = this.cmdCerrar;
		System.Drawing.Point location = new System.Drawing.Point(427, 454);
		button.Location = location;
		System.Windows.Forms.Button button2 = this.cmdCerrar;
		System.Drawing.Size size = new System.Drawing.Size(61, 23);
		button2.Size = size;
		toolTipTitleItem.Appearance.Image = RecursosHumanos.My.Resources.Resources.help2;
		toolTipTitleItem.Appearance.Options.UseImage = true;
		toolTipTitleItem.Image = RecursosHumanos.My.Resources.Resources.help2;
		toolTipTitleItem.Text = "Ayuda";
		toolTipItem.LeftIndent = 6;
		toolTipItem.Text = "Cierra la Ventana Actual, descartando todos los cambios realizados antes de guardarlos.";
		superToolTip.Items.Add(toolTipTitleItem);
		superToolTip.Items.Add(toolTipItem);
		this.ToolTipController1.SetSuperTip(this.cmdCerrar, superToolTip);
		this.cmdCerrar.TabIndex = 3;
		this.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		System.Windows.Forms.Panel panelSup = this.PanelSup;
		size = new System.Drawing.Size(500, 29);
		panelSup.Size = size;
		System.Windows.Forms.Panel panelInf = this.PanelInf;
		location = new System.Drawing.Point(0, 487);
		panelInf.Location = location;
		System.Windows.Forms.Panel panelInf2 = this.PanelInf;
		size = new System.Drawing.Size(500, 27);
		panelInf2.Size = size;
		this.UcTxtApePater.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtApePater.Formato = null;
		this.UcTxtApePater.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtApePater = this.UcTxtApePater;
		location = new System.Drawing.Point(103, 55);
		ucTxtApePater.Location = location;
		this.UcTxtApePater.Name = "UcTxtApePater";
		this.UcTxtApePater.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtApePater.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtApePater.OnErrorBlankText = "";
		this.UcTxtApePater.PadLeftLenght = 0;
		this.UcTxtApePater.ReadOnly = true;
		this.UcTxtApePater.RegularExpression = "^[A-Z,a-z,\\s]+$";
		this.UcTxtApePater.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtApePater.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtApePater2 = this.UcTxtApePater;
		size = new System.Drawing.Size(217, 20);
		ucTxtApePater2.Size = size;
		this.UcTxtApePater.TabIndex = 2;
		this.UcTxtApePater.TabNextControl = false;
		this.UcTxtApePater.Tipo = GRLL.Common.ucTextBox.TipoDato.SoloLetras;
		this.UcTxtNombres.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtNombres.Formato = null;
		this.UcTxtNombres.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtNombres = this.UcTxtNombres;
		location = new System.Drawing.Point(103, 103);
		ucTxtNombres.Location = location;
		this.UcTxtNombres.Name = "UcTxtNombres";
		this.UcTxtNombres.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtNombres.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtNombres.OnErrorBlankText = "";
		this.UcTxtNombres.PadLeftLenght = 0;
		this.UcTxtNombres.ReadOnly = true;
		this.UcTxtNombres.RegularExpression = "^[A-Z,a-z,\\s]+$";
		this.UcTxtNombres.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtNombres.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtNombres2 = this.UcTxtNombres;
		size = new System.Drawing.Size(217, 20);
		ucTxtNombres2.Size = size;
		this.UcTxtNombres.TabIndex = 4;
		this.UcTxtNombres.TabNextControl = false;
		this.UcTxtNombres.Tipo = GRLL.Common.ucTextBox.TipoDato.SoloLetras;
		this.UcTxtApeMater.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtApeMater.Formato = null;
		this.UcTxtApeMater.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtApeMater = this.UcTxtApeMater;
		location = new System.Drawing.Point(103, 79);
		ucTxtApeMater.Location = location;
		this.UcTxtApeMater.Name = "UcTxtApeMater";
		this.UcTxtApeMater.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtApeMater.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtApeMater.OnErrorBlankText = "";
		this.UcTxtApeMater.PadLeftLenght = 0;
		this.UcTxtApeMater.ReadOnly = true;
		this.UcTxtApeMater.RegularExpression = "^[A-Z,a-z,\\s]+$";
		this.UcTxtApeMater.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtApeMater.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtApeMater2 = this.UcTxtApeMater;
		size = new System.Drawing.Size(217, 20);
		ucTxtApeMater2.Size = size;
		this.UcTxtApeMater.TabIndex = 3;
		this.UcTxtApeMater.TabNextControl = false;
		this.UcTxtApeMater.Tipo = GRLL.Common.ucTextBox.TipoDato.SoloLetras;
		this.UcFoto.AjustarImagen = true;
		this.UcFoto.Borde = true;
		this.UcFoto.FileName = "";
		this.UcFoto.Image = null;
		this.UcFoto.ImageChanged = false;
		GRLL.Common.ucFoto ucFoto = this.UcFoto;
		location = new System.Drawing.Point(336, 29);
		ucFoto.Location = location;
		this.UcFoto.Name = "UcFoto";
		GRLL.Common.ucFoto ucFoto2 = this.UcFoto;
		size = new System.Drawing.Size(117, 94);
		ucFoto2.Size = size;
		this.UcFoto.TabIndex = 5;
		this.UcFoto.VerAjuste = false;
		this.UcFoto.VerControles = false;
		this.Label3.AutoSize = true;
		System.Windows.Forms.Label label = this.Label3;
		location = new System.Drawing.Point(10, 58);
		label.Location = location;
		this.Label3.Name = "Label3";
		System.Windows.Forms.Label label2 = this.Label3;
		size = new System.Drawing.Size(87, 13);
		label2.Size = size;
		this.Label3.TabIndex = 44;
		this.Label3.Text = "Apellido Paterno:";
		this.Label4.AutoSize = true;
		System.Windows.Forms.Label label3 = this.Label4;
		location = new System.Drawing.Point(10, 82);
		label3.Location = location;
		this.Label4.Name = "Label4";
		System.Windows.Forms.Label label4 = this.Label4;
		size = new System.Drawing.Size(89, 13);
		label4.Size = size;
		this.Label4.TabIndex = 45;
		this.Label4.Text = "Apellido Materno:";
		this.Label1.AutoSize = true;
		System.Windows.Forms.Label label5 = this.Label1;
		location = new System.Drawing.Point(51, 32);
		label5.Location = location;
		this.Label1.Name = "Label1";
		System.Windows.Forms.Label label6 = this.Label1;
		size = new System.Drawing.Size(48, 13);
		label6.Size = size;
		this.Label1.TabIndex = 41;
		this.Label1.Text = "Nº Doc.:";
		this.UcTxtNDoc.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtNDoc.Formato = null;
		this.UcTxtNDoc.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtNDoc = this.UcTxtNDoc;
		location = new System.Drawing.Point(103, 29);
		ucTxtNDoc.Location = location;
		this.UcTxtNDoc.Name = "UcTxtNDoc";
		this.UcTxtNDoc.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtNDoc.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtNDoc.OnErrorBlankText = "";
		this.UcTxtNDoc.PadLeftLenght = 0;
		this.UcTxtNDoc.ReadOnly = true;
		this.UcTxtNDoc.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtNDoc.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtNDoc2 = this.UcTxtNDoc;
		size = new System.Drawing.Size(121, 20);
		ucTxtNDoc2.Size = size;
		this.UcTxtNDoc.TabIndex = 1;
		this.UcTxtNDoc.TabNextControl = false;
		this.UcTxtNDoc.Tipo = GRLL.Common.ucTextBox.TipoDato.Todos;
		this.Label5.AutoSize = true;
		System.Windows.Forms.Label label7 = this.Label5;
		location = new System.Drawing.Point(45, 106);
		label7.Location = location;
		this.Label5.Name = "Label5";
		System.Windows.Forms.Label label8 = this.Label5;
		size = new System.Drawing.Size(52, 13);
		label8.Size = size;
		this.Label5.TabIndex = 39;
		this.Label5.Text = "Nombres:";
		this.GroupControl1.Controls.Add(this.UcTxtNDoc);
		this.GroupControl1.Controls.Add(this.Label5);
		this.GroupControl1.Controls.Add(this.UcTxtApePater);
		this.GroupControl1.Controls.Add(this.UcTxtNombres);
		this.GroupControl1.Controls.Add(this.UcTxtApeMater);
		this.GroupControl1.Controls.Add(this.Label1);
		this.GroupControl1.Controls.Add(this.UcFoto);
		this.GroupControl1.Controls.Add(this.Label4);
		this.GroupControl1.Controls.Add(this.Label3);
		DevExpress.XtraEditors.GroupControl groupControl = this.GroupControl1;
		location = new System.Drawing.Point(12, 35);
		groupControl.Location = location;
		this.GroupControl1.Name = "GroupControl1";
		DevExpress.XtraEditors.GroupControl groupControl2 = this.GroupControl1;
		size = new System.Drawing.Size(474, 133);
		groupControl2.Size = size;
		this.GroupControl1.TabIndex = 0;
		this.GroupControl1.Text = "Datos Empleado";
		this.GroupControl2.Controls.Add(this.Lbl_Tipo);
		this.GroupControl2.Controls.Add(this.UcCmbTipoPermiso);
		this.GroupControl2.Controls.Add(this.UcTxtObs);
		this.GroupControl2.Controls.Add(this.UcTxtLugar);
		this.GroupControl2.Controls.Add(this.UcTxtAutorizacion);
		this.GroupControl2.Controls.Add(this.UcTxtRef);
		this.GroupControl2.Controls.Add(this.Label11);
		this.GroupControl2.Controls.Add(this.Label9);
		this.GroupControl2.Controls.Add(this.Label2);
		this.GroupControl2.Controls.Add(this.Label8);
		this.GroupControl2.Controls.Add(this.Label7);
		this.GroupControl2.Controls.Add(this.Label10);
		this.GroupControl2.Controls.Add(this.Label6);
		this.GroupControl2.Controls.Add(this.UcCmbMotivo);
		this.GroupControl2.Controls.Add(this.UcFechas);
		this.GroupControl2.Controls.Add(this.CheckEditRetorno);
		this.GroupControl2.Controls.Add(this.CheckEditDia);
		DevExpress.XtraEditors.GroupControl groupControl3 = this.GroupControl2;
		location = new System.Drawing.Point(12, 174);
		groupControl3.Location = location;
		this.GroupControl2.Name = "GroupControl2";
		DevExpress.XtraEditors.GroupControl groupControl4 = this.GroupControl2;
		size = new System.Drawing.Size(474, 247);
		groupControl4.Size = size;
		this.GroupControl2.TabIndex = 1;
		this.GroupControl2.Text = "Datos del Permiso";
		this.Lbl_Tipo.AutoSize = true;
		this.Lbl_Tipo.ForeColor = System.Drawing.Color.Maroon;
		System.Windows.Forms.Label lbl_Tipo = this.Lbl_Tipo;
		location = new System.Drawing.Point(324, 67);
		lbl_Tipo.Location = location;
		this.Lbl_Tipo.Name = "Lbl_Tipo";
		System.Windows.Forms.Label lbl_Tipo2 = this.Lbl_Tipo;
		size = new System.Drawing.Size(103, 13);
		lbl_Tipo2.Size = size;
		this.Lbl_Tipo.TabIndex = 3;
		this.Lbl_Tipo.Text = "                                ";
		this.UcCmbTipoPermiso.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCmbTipoPermiso.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCmbTipoPermiso.FormattingEnabled = true;
		this.UcCmbTipoPermiso.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucCmbTipoPermiso = this.UcCmbTipoPermiso;
		location = new System.Drawing.Point(88, 37);
		ucCmbTipoPermiso.Location = location;
		this.UcCmbTipoPermiso.Name = "UcCmbTipoPermiso";
		GRLL.Common.ucComboBox ucCmbTipoPermiso2 = this.UcCmbTipoPermiso;
		size = new System.Drawing.Size(147, 21);
		ucCmbTipoPermiso2.Size = size;
		this.UcCmbTipoPermiso.TabIndex = 1;
		this.UcTxtObs.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtObs.Formato = null;
		this.UcTxtObs.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtObs = this.UcTxtObs;
		location = new System.Drawing.Point(88, 203);
		ucTxtObs.Location = location;
		this.UcTxtObs.MaxLength = 200;
		this.UcTxtObs.Multiline = true;
		this.UcTxtObs.Name = "UcTxtObs";
		this.UcTxtObs.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtObs.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtObs.OnErrorBlankText = "";
		this.UcTxtObs.PadLeftLenght = 0;
		this.UcTxtObs.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtObs.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtObs2 = this.UcTxtObs;
		size = new System.Drawing.Size(321, 31);
		ucTxtObs2.Size = size;
		this.UcTxtObs.TabIndex = 10;
		this.UcTxtObs.TabNextControl = false;
		this.UcTxtObs.Tipo = GRLL.Common.ucTextBox.TipoDato.Todos;
		this.UcTxtLugar.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtLugar.Formato = null;
		this.UcTxtLugar.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtLugar = this.UcTxtLugar;
		location = new System.Drawing.Point(88, 125);
		ucTxtLugar.Location = location;
		this.UcTxtLugar.MaxLength = 20;
		this.UcTxtLugar.Name = "UcTxtLugar";
		this.UcTxtLugar.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtLugar.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtLugar.OnErrorBlankText = "";
		this.UcTxtLugar.PadLeftLenght = 0;
		this.UcTxtLugar.RegularExpression = "^[A-Z,a-z,0-9,\\s]+$";
		this.UcTxtLugar.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtLugar.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtLugar2 = this.UcTxtLugar;
		size = new System.Drawing.Size(215, 20);
		ucTxtLugar2.Size = size;
		this.UcTxtLugar.TabIndex = 5;
		this.UcTxtLugar.TabNextControl = false;
		this.UcTxtLugar.Tipo = GRLL.Common.ucTextBox.TipoDato.LetrasNumeros;
		this.UcTxtAutorizacion.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtAutorizacion.Formato = null;
		this.UcTxtAutorizacion.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtAutorizacion = this.UcTxtAutorizacion;
		location = new System.Drawing.Point(88, 151);
		ucTxtAutorizacion.Location = location;
		this.UcTxtAutorizacion.MaxLength = 50;
		this.UcTxtAutorizacion.Name = "UcTxtAutorizacion";
		this.UcTxtAutorizacion.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtAutorizacion.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtAutorizacion.OnErrorBlankText = "";
		this.UcTxtAutorizacion.PadLeftLenght = 0;
		this.UcTxtAutorizacion.RegularExpression = "^[A-Z,a-z,\\s]+$";
		this.UcTxtAutorizacion.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtAutorizacion.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtAutorizacion2 = this.UcTxtAutorizacion;
		size = new System.Drawing.Size(215, 20);
		ucTxtAutorizacion2.Size = size;
		this.UcTxtAutorizacion.TabIndex = 7;
		this.UcTxtAutorizacion.TabNextControl = false;
		this.UcTxtAutorizacion.Tipo = GRLL.Common.ucTextBox.TipoDato.SoloLetras;
		this.UcTxtRef.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtRef.Formato = null;
		this.UcTxtRef.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtRef = this.UcTxtRef;
		location = new System.Drawing.Point(88, 177);
		ucTxtRef.Location = location;
		this.UcTxtRef.MaxLength = 100;
		this.UcTxtRef.Name = "UcTxtRef";
		this.UcTxtRef.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtRef.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtRef.OnErrorBlankText = "";
		this.UcTxtRef.PadLeftLenght = 0;
		this.UcTxtRef.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtRef.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtRef2 = this.UcTxtRef;
		size = new System.Drawing.Size(215, 20);
		ucTxtRef2.Size = size;
		this.UcTxtRef.TabIndex = 9;
		this.UcTxtRef.TabNextControl = false;
		this.UcTxtRef.Tipo = GRLL.Common.ucTextBox.TipoDato.Todos;
		this.Label11.AutoSize = true;
		System.Windows.Forms.Label label9 = this.Label11;
		location = new System.Drawing.Point(50, 206);
		label9.Location = location;
		this.Label11.Name = "Label11";
		System.Windows.Forms.Label label10 = this.Label11;
		size = new System.Drawing.Size(32, 13);
		label10.Size = size;
		this.Label11.TabIndex = 2;
		this.Label11.Text = "Obs.:";
		this.Label9.AutoSize = true;
		System.Windows.Forms.Label label11 = this.Label9;
		location = new System.Drawing.Point(45, 128);
		label11.Location = location;
		this.Label9.Name = "Label9";
		System.Windows.Forms.Label label12 = this.Label9;
		size = new System.Drawing.Size(37, 13);
		label12.Size = size;
		this.Label9.TabIndex = 2;
		this.Label9.Text = "Lugar:";
		this.Label2.AutoSize = true;
		System.Windows.Forms.Label label13 = this.Label2;
		location = new System.Drawing.Point(14, 154);
		label13.Location = location;
		this.Label2.Name = "Label2";
		System.Windows.Forms.Label label14 = this.Label2;
		size = new System.Drawing.Size(68, 13);
		label14.Size = size;
		this.Label2.TabIndex = 2;
		this.Label2.Text = "Autorización:";
		this.Label8.AutoSize = true;
		System.Windows.Forms.Label label15 = this.Label8;
		location = new System.Drawing.Point(26, 180);
		label15.Location = location;
		this.Label8.Name = "Label8";
		System.Windows.Forms.Label label16 = this.Label8;
		size = new System.Drawing.Size(56, 13);
		label16.Size = size;
		this.Label8.TabIndex = 2;
		this.Label8.Text = "Doc. Ref.:";
		this.Label7.AutoSize = true;
		System.Windows.Forms.Label label17 = this.Label7;
		location = new System.Drawing.Point(40, 67);
		label17.Location = location;
		this.Label7.Name = "Label7";
		System.Windows.Forms.Label label18 = this.Label7;
		size = new System.Drawing.Size(42, 13);
		label18.Size = size;
		this.Label7.TabIndex = 2;
		this.Label7.Text = "Motivo:";
		this.Label10.AutoSize = true;
		System.Windows.Forms.Label label19 = this.Label10;
		location = new System.Drawing.Point(11, 40);
		label19.Location = location;
		this.Label10.Name = "Label10";
		System.Windows.Forms.Label label20 = this.Label10;
		size = new System.Drawing.Size(71, 13);
		label20.Size = size;
		this.Label10.TabIndex = 2;
		this.Label10.Text = "Tipo Permiso:";
		this.Label6.AutoSize = true;
		System.Windows.Forms.Label label21 = this.Label6;
		location = new System.Drawing.Point(42, 99);
		label21.Location = location;
		this.Label6.Name = "Label6";
		System.Windows.Forms.Label label22 = this.Label6;
		size = new System.Drawing.Size(40, 13);
		label22.Size = size;
		this.Label6.TabIndex = 2;
		this.Label6.Text = "Fecha:";
		this.UcCmbMotivo.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCmbMotivo.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCmbMotivo.FormattingEnabled = true;
		this.UcCmbMotivo.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucCmbMotivo = this.UcCmbMotivo;
		location = new System.Drawing.Point(88, 64);
		ucCmbMotivo.Location = location;
		this.UcCmbMotivo.Name = "UcCmbMotivo";
		GRLL.Common.ucComboBox ucCmbMotivo2 = this.UcCmbMotivo;
		size = new System.Drawing.Size(215, 21);
		ucCmbMotivo2.Size = size;
		this.UcCmbMotivo.TabIndex = 2;
		GRLL.Common.ucFechas ucFechas = this.UcFechas;
		location = new System.Drawing.Point(88, 94);
		ucFechas.Location = location;
		this.UcFechas.Name = "UcFechas";
		GRLL.Common.ucFechas ucFechas2 = this.UcFechas;
		size = new System.Drawing.Size(302, 22);
		ucFechas2.Size = size;
		this.UcFechas.TabIndex = 4;
		DevExpress.XtraEditors.CheckEdit checkEditRetorno = this.CheckEditRetorno;
		location = new System.Drawing.Point(325, 153);
		checkEditRetorno.Location = location;
		this.CheckEditRetorno.Name = "CheckEditRetorno";
		this.CheckEditRetorno.Properties.Caption = "Retorno";
		DevExpress.XtraEditors.CheckEdit checkEditRetorno2 = this.CheckEditRetorno;
		size = new System.Drawing.Size(75, 18);
		checkEditRetorno2.Size = size;
		this.CheckEditRetorno.TabIndex = 8;
		DevExpress.XtraEditors.CheckEdit checkEditDia = this.CheckEditDia;
		location = new System.Drawing.Point(325, 127);
		checkEditDia.Location = location;
		this.CheckEditDia.Name = "CheckEditDia";
		this.CheckEditDia.Properties.Caption = "Todo el Día";
		DevExpress.XtraEditors.CheckEdit checkEditDia2 = this.CheckEditDia;
		size = new System.Drawing.Size(75, 18);
		checkEditDia2.Size = size;
		this.CheckEditDia.TabIndex = 6;
		this.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.Button1.AutoSize = true;
		this.Button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.Button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.Button1.FlatAppearance.BorderSize = 0;
		this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button1.Image = RecursosHumanos.My.Resources.Resources.disk_blue1;
		System.Windows.Forms.Button button3 = this.Button1;
		location = new System.Drawing.Point(12, 454);
		button3.Location = location;
		this.Button1.Name = "Button1";
		System.Windows.Forms.Button button4 = this.Button1;
		size = new System.Drawing.Size(71, 23);
		button4.Size = size;
		this.Button1.TabIndex = 2;
		this.Button1.Text = "Guardar";
		this.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.Button1.UseVisualStyleBackColor = true;
		this.DefaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins";
		this.ToolTipController1.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip;
		DevExpress.XtraEditors.CheckEdit checkEquipoMarcacion = this.CheckEquipoMarcacion;
		location = new System.Drawing.Point(11, 430);
		checkEquipoMarcacion.Location = location;
		this.CheckEquipoMarcacion.Name = "CheckEquipoMarcacion";
		this.CheckEquipoMarcacion.Properties.Caption = "Actualizar Equipo Marcacion";
		DevExpress.XtraEditors.CheckEdit checkEquipoMarcacion2 = this.CheckEquipoMarcacion;
		size = new System.Drawing.Size(169, 18);
		checkEquipoMarcacion2.Size = size;
		this.CheckEquipoMarcacion.TabIndex = 4;
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		size = new System.Drawing.Size(500, 514);
		this.ClientSize = size;
		this.Controls.Add(this.CheckEquipoMarcacion);
		this.Controls.Add(this.Button1);
		this.Controls.Add(this.GroupControl2);
		this.Controls.Add(this.GroupControl1);
		this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
		this.MessageShow = true;
		this.Name = "FrmPermiso";
		this.TitleMsg = "FrmConsulta";
		this.Titulo = "Agregar Permiso";
		this.TituloFrm = "Permiso";
		this.VerCmdCerrar = true;
		this.Controls.SetChildIndex(this.cmdCerrar, 0);
		this.Controls.SetChildIndex(this.PanelSup, 0);
		this.Controls.SetChildIndex(this.PanelInf, 0);
		this.Controls.SetChildIndex(this.GroupControl1, 0);
		this.Controls.SetChildIndex(this.GroupControl2, 0);
		this.Controls.SetChildIndex(this.Button1, 0);
		this.Controls.SetChildIndex(this.CheckEquipoMarcacion, 0);
		((System.ComponentModel.ISupportInitialize)this.GroupControl1).EndInit();
		this.GroupControl1.ResumeLayout(false);
		this.GroupControl1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.GroupControl2).EndInit();
		this.GroupControl2.ResumeLayout(false);
		this.GroupControl2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.CheckEditRetorno.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.CheckEditDia.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.CheckEquipoMarcacion.Properties).EndInit();
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	private void FrmPermiso_Load(object sender, EventArgs e)
	{
		DataTable dataTable = objClassRRHH.BuscarEmpleado_Codigo(idEmpleado);
		if (dataTable.Rows.Count == 1)
		{
			foreach (object row in dataTable.Rows)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(row);
				if (NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "Foto" }, null, null, null).ToString().Length > 0)
				{
					img = (byte[])NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "Foto" }, null, null, null);
					MemoryStream memoryStream = new MemoryStream();
					memoryStream.Write(img, 0, checked(img.GetUpperBound(0) + 1));
					UcFoto.Image = Image.FromStream(memoryStream);
					memoryStream.Close();
				}
				UcTxtNombres.Text = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "Nombres" }, null, null, null).ToString();
				UcTxtApePater.Text = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "Apellido_Paterno" }, null, null, null).ToString();
				UcTxtApeMater.Text = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "Apellido_Materno" }, null, null, null).ToString();
				UcTxtNDoc.Text = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "NumDocID" }, null, null, null).ToString();
			}
		}
		List<TipoPermiso> list = TipoPermisoMapper.Instance().SelectAll();
		list.Insert(0, new TipoPermiso
		{
			idTipoPermiso = 0,
			DescripTipoPermiso = "--SELECCIONAR--"
		});
		UcCmbTipoPermiso.DataSource = list;
		UcCmbTipoPermiso.DisplayMember = "DescripTipoPermiso";
		UcCmbTipoPermiso.ValueMember = "idTipoPermiso";
		if (Npermiso == 0)
		{
			return;
		}
		Permiso permiso = PermisoMapper.Instance().SelectBy([SpecialName] (Permiso v) => (v.IdEmpleado == idEmpleado) & (v.NPermiso == Npermiso)).Single();
		List<Motivo_Perm> source = Motivo_PermMapper.Instance().SelectBy([SpecialName] (Motivo_Perm v) =>
		{
			int idMotivo = v.idMotivo;
			int? idMotivo2 = permiso.idMotivo;
			bool? obj;
			if (!idMotivo2.HasValue)
			{
				obj = null;
			}
			else
			{
				bool? flag = idMotivo == idMotivo2.GetValueOrDefault();
				obj = flag;
			}
			return (bool)obj;
		});
		UcCmbTipoPermiso.SelectedValue = source.Single().idTipoPermiso.Value;
		UcCmbMotivo.SelectedValue = permiso.idMotivo.Value;
		UcTxtRef.Text = permiso.Referencia.ToString();
		RangoFecha rango = new RangoFecha(permiso.FechaInicio.Value, permiso.FechaFin.Value);
		UcFechas.Rango = rango;
		UcTxtObs.Text = permiso.Obs.ToString();
	}

	private void UcCmbTipoPermiso_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (UcCmbTipoPermiso.SelectedIndex == 0)
		{
			UcCmbMotivo.Enabled = false;
		}
		else
		{
			UcCmbMotivo.Enabled = true;
			ucComboBox ucCmbMotivo = UcCmbMotivo;
			ucCmbMotivo.DisplayMember = "Descrip_Motivo";
			ucCmbMotivo.ValueMember = "idMotivo";
			if (Conversions.ToDouble(RRHH.IdROl) == 10.0)
			{
				List<Motivo_Perm> list = Motivo_PermMapper.Instance().SelectBy([SpecialName] (Motivo_Perm p) => Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(p.idTipoPermiso, UcCmbTipoPermiso.SelectedValue, TextCompare: false), Operators.CompareString(Conversions.ToString((char)p.TipoModalidad), "P", TextCompare: false) == 0)));
				list.Insert(0, new Motivo_Perm
				{
					idMotivo = 0,
					Descrip_Motivo = "--SELECCIONAR--"
				});
				ucCmbMotivo.DataSource = list;
			}
			else if (Conversions.ToDouble(RRHH.IdROl) == 14.0)
			{
				List<Motivo_Perm> list2 = Motivo_PermMapper.Instance().SelectBy([SpecialName] (Motivo_Perm p) => Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(p.idTipoPermiso, UcCmbTipoPermiso.SelectedValue, TextCompare: false), Operators.CompareString(Conversions.ToString((char)p.TipoModalidad), "C", TextCompare: false) == 0)));
				list2.Insert(0, new Motivo_Perm
				{
					idMotivo = 0,
					Descrip_Motivo = "--SELECCIONAR--"
				});
				ucCmbMotivo.DataSource = list2;
			}
			else if (Conversions.ToDouble(RRHH.IdROl) == 13.0)
			{
				List<Motivo_Perm> list3 = Motivo_PermMapper.Instance().SelectBy([SpecialName] (Motivo_Perm p) => Operators.ConditionalCompareObjectEqual(p.idTipoPermiso, UcCmbTipoPermiso.SelectedValue, TextCompare: false));
				list3.Insert(0, new Motivo_Perm
				{
					idMotivo = 0,
					Descrip_Motivo = "--SELECCIONAR--"
				});
				ucCmbMotivo.DataSource = list3;
			}
			ucCmbMotivo = null;
		}
		if (UcCmbTipoPermiso.SelectedIndex == 1)
		{
			Label9.Visible = false;
			UcTxtLugar.Visible = false;
			Label2.Visible = false;
			UcTxtAutorizacion.Visible = false;
			ucTextBox ucTxtRef = UcTxtRef;
			Point location = new Point(88, 125);
			ucTxtRef.Location = location;
			Label label = Label8;
			location = new Point(26, 128);
			label.Location = location;
			ucTextBox ucTxtObs = UcTxtObs;
			location = new Point(88, 151);
			ucTxtObs.Location = location;
			Label label2 = Label11;
			location = new Point(50, 154);
			label2.Location = location;
			CheckEditDia.Visible = true;
			CheckEditDia.EditValue = true;
			CheckEditRetorno.EditValue = false;
			CheckEditRetorno.Visible = false;
		}
		if (UcCmbTipoPermiso.SelectedIndex == 2)
		{
			Label9.Visible = true;
			UcTxtLugar.Visible = true;
			Label2.Visible = true;
			UcTxtAutorizacion.Visible = true;
			ucTextBox ucTxtRef2 = UcTxtRef;
			Point location = new Point(88, 177);
			ucTxtRef2.Location = location;
			Label label3 = Label8;
			location = new Point(26, 180);
			label3.Location = location;
			ucTextBox ucTxtObs2 = UcTxtObs;
			location = new Point(88, 203);
			ucTxtObs2.Location = location;
			Label label4 = Label11;
			location = new Point(50, 206);
			label4.Location = location;
			CheckEditDia.Visible = false;
			CheckEditRetorno.Visible = true;
			CheckEditDia.EditValue = false;
			CheckEditRetorno.EditValue = true;
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		if (DateTime.Compare(UcFechas.Rango.Desde, UcFechas.Rango.Hasta) > 0)
		{
			MessageBox.Show("La Fecha de Inicio no puede ser mayor a la de Término", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		if (!UcCmbMotivo.Enabled)
		{
			MessageBox.Show("Debe Seleccionar un Motivo Válido", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		if (Operators.ConditionalCompareObjectEqual(UcCmbMotivo.SelectedValue, 0, TextCompare: false))
		{
			MessageBox.Show("Debe Seleccionar un Motivo Válido", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		List<Permiso> list = PermisoMapper.Instance().SelectBy([SpecialName] (Permiso p) =>
		{
			bool flag = true;
			bool? retorno = p.Retorno;
			bool? obj;
			if (!retorno.HasValue)
			{
				obj = null;
			}
			else
			{
				bool? flag2 = retorno == true == flag;
				obj = flag2;
			}
			bool? flag3 = obj;
			bool? flag5;
			if (!((p.IdEmpleado == idEmpleado) & (Operators.CompareString(p.FechaInicio.Value.ToShortDateString(), UcFechas.Rango.Desde.ToShortDateString(), TextCompare: false) <= 0) & (Operators.CompareString(p.FechaFin.Value.ToShortDateString(), UcFechas.Rango.Desde.ToShortDateString(), TextCompare: false) >= 0)))
			{
				bool? flag4 = false;
				flag5 = flag4;
			}
			else
			{
				flag5 = flag3;
			}
			bool? flag6 = flag5;
			bool? flag8;
			if (p.Hora_Ret != null)
			{
				bool? flag7 = false;
				flag8 = flag7;
			}
			else
			{
				flag8 = flag6;
			}
			return (bool)flag8;
		});
		if (list.Count >= 1)
		{
			MessageBox.Show("El Empleado se Encuentra de Permiso, No se puede agregar Otro Permiso", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		if (Operators.ConditionalCompareObjectEqual(UcCmbTipoPermiso.SelectedValue, 1, TextCompare: false))
		{
		}
		if (Operators.ConditionalCompareObjectEqual(UcCmbTipoPermiso.SelectedValue, 2, TextCompare: false))
		{
			if (AsistenciaMapper.Instance().SelectBy([SpecialName] (Asistencia a) => (a.IdEmpleado == idEmpleado) & (DateTime.Compare(a.Fecha, DateTime.Today) == 0)).Count == 0)
			{
				MessageBox.Show("El Empleado, no ah asistido hoy al Centro Laboral", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			int count = AsistenciaMapper.Instance().SelectBy([SpecialName] (Asistencia s) => (s.IdEmpleado == idEmpleado) & (DateTime.Compare(s.Fecha, DateTime.Today) == 0) & (Operators.CompareString(s.Hor_Sal, "00:00:00", TextCompare: false) != 0)).Count;
			if (count == 1)
			{
				MessageBox.Show("El Empleado ya se retiro del Centro Laboral", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			if (DateTime.Compare(UcFechas.Rango.Desde, DateTime.Today) < 0)
			{
				MessageBox.Show("La Fecha de Inicio no Puede ser Menor a la Fecha Actual", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			if (DateTime.Compare(UcFechas.Rango.Desde, UcFechas.Rango.Hasta) != 0)
			{
				MessageBox.Show("Solo se puede Asignar una Salida autoriza a un dia", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
		}
		if (Operators.ConditionalCompareObjectEqual(CheckEditDia.EditValue, true, TextCompare: false) && DateTime.Compare(UcFechas.Rango.Desde, UcFechas.Rango.Hasta) != 0)
		{
			TimeSpan timeSpan = UcFechas.Rango.Hasta - UcFechas.Rango.Desde;
			int num = Conversions.ToInteger(timeSpan.TotalDays.ToString());
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				string text = Conversions.ToString(UcFechas.Rango.Desde.Date.AddDays(num2));
				num2 = checked(num2 + 1);
			}
		}
		Permiso permiso = new Permiso();
		permiso.FechaFin = Conversions.ToDate(UcFechas.Rango.Hasta.ToShortDateString());
		permiso.FechaInicio = Conversions.ToDate(UcFechas.Rango.Desde.ToShortDateString());
		object selectedValue = UcCmbMotivo.SelectedValue;
		int? num5 = default(int?);
		permiso.idMotivo = ((selectedValue != null) ? ((int?)selectedValue) : num5);
		permiso.Autorizacion = UcTxtAutorizacion.Text.Trim();
		permiso.Lugar = UcTxtLugar.Text.Trim();
		permiso.Referencia = UcTxtRef.Text.Trim();
		object editValue = CheckEditDia.EditValue;
		bool? flag9 = default(bool?);
		permiso.Dia = ((editValue != null) ? ((bool?)editValue) : flag9);
		object editValue2 = CheckEditRetorno.EditValue;
		permiso.Retorno = ((editValue2 != null) ? ((bool?)editValue2) : flag9);
		permiso.IdEmpleado = idEmpleado;
		permiso.Obs = UcTxtObs.Text.Trim();
		if (Npermiso == 0)
		{
			if (objClassRRHH.ExistePermiso(idEmpleado, Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(UcFechas.Rango.Desde.Year, Interaction.IIf(UcFechas.Rango.Desde.Month.ToString().Length == 1, "0" + Conversions.ToString(UcFechas.Rango.Desde.Month), UcFechas.Rango.Desde.Month)), Interaction.IIf(UcFechas.Rango.Desde.Day.ToString().Length == 1, "0" + Conversions.ToString(UcFechas.Rango.Desde.Day), UcFechas.Rango.Desde.Day))), Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(UcFechas.Rango.Hasta.Year, Interaction.IIf(UcFechas.Rango.Hasta.Month.ToString().Length == 1, "0" + Conversions.ToString(UcFechas.Rango.Hasta.Month), UcFechas.Rango.Hasta.Month)), Interaction.IIf(UcFechas.Rango.Hasta.Day.ToString().Length == 1, "0" + Conversions.ToString(UcFechas.Rango.Hasta.Day), UcFechas.Rango.Hasta.Day)))) >= 1)
			{
				MessageBox.Show("El Empleado se Encuentra de Permiso, No se puede agregar Otro Permiso", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			permiso.NPermiso = objClassRRHH.SgtIdPermiso(idEmpleado);
			PermisoMapper.Instance().Insert(permiso);
		}
		else
		{
			permiso.NPermiso = Npermiso;
			PermisoMapper.Instance().Update(permiso);
		}
		if (CheckEquipoMarcacion.CheckState == CheckState.Checked)
		{
			AsistenciaAccess asistenciaAccess = new AsistenciaAccess();
			if (!asistenciaAccess.Grabar_SalidaAutorizada(UcTxtNDoc.Text, Npermiso, UcFechas.Rango.Desde.ToShortDateString(), UcFechas.Rango.Hasta.ToShortDateString(), Conversions.ToBoolean(CheckEditDia.EditValue), Conversions.ToBoolean(CheckEditRetorno.EditValue), UcTxtLugar.Text.Trim()))
			{
				MessageBox.Show("No se pudo completar la operación", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}
		DialogResult = DialogResult.OK;
	}

	private void UcCmbMotivo_SelectedIndexChanged(object sender, EventArgs e)
	{
		Label lbl_Tipo = Lbl_Tipo;
		List<Motivo_Perm> list = Motivo_PermMapper.Instance().SelectBy([SpecialName] (Motivo_Perm m) => Operators.ConditionalCompareObjectEqual(m.idMotivo, UcCmbMotivo.SelectedValue, TextCompare: false));
		if (list.Count >= 1)
		{
			bool flag = true;
			bool? salario = list.First().Salario;
			bool? obj;
			if (!salario.HasValue)
			{
				obj = null;
			}
			else
			{
				bool? flag2 = salario == true == flag;
				obj = flag2;
			}
			bool? flag3 = obj;
			if (flag3 == true)
			{
				lbl_Tipo.Text = "Asalariado";
			}
			else
			{
				lbl_Tipo.Text = "NO Asalariado";
			}
		}
		lbl_Tipo = null;
	}

	private void CheckEditDia_Click(object sender, EventArgs e)
	{
		if (CheckEditRetorno.Checked)
		{
			CheckEditDia.Checked = false;
			MessageBox.Show("No puedo Marcar Día, si marca Retorno", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}

	private void CheckEditRetorno_Click(object sender, EventArgs e)
	{
		if (CheckEditDia.Checked)
		{
			CheckEditRetorno.Checked = false;
			MessageBox.Show("No puedo Marcar Retorno, si marca Día", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}
}
