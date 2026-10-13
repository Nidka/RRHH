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
using DevExpress.XtraEditors.Controls;
using GRLL.Common;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using RecursosHumanos.My.Resources;

namespace RecursosHumanos;

[DesignerGenerated]
public class FrmMarcacionesAutorizadas : FrmConsulta
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("GroupControl1")]
	private GroupControl _GroupControl1;

	[AccessedThroughProperty("UcTxtNDoc")]
	private ucTextBox _UcTxtNDoc;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("UcTxtApePater")]
	private ucTextBox _UcTxtApePater;

	[AccessedThroughProperty("UcTxtNombres")]
	private ucTextBox _UcTxtNombres;

	[AccessedThroughProperty("UcTxtApeMater")]
	private ucTextBox _UcTxtApeMater;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("UcFoto")]
	private ucFoto _UcFoto;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("BtnGrabar")]
	private Button _BtnGrabar;

	[AccessedThroughProperty("GroupControl2")]
	private GroupControl _GroupControl2;

	[AccessedThroughProperty("CheckSalida")]
	private CheckEdit _CheckSalida;

	[AccessedThroughProperty("CheckIngreso")]
	private CheckEdit _CheckIngreso;

	[AccessedThroughProperty("DEHoraSalida")]
	private DateEdit _DEHoraSalida;

	[AccessedThroughProperty("DEHoraIngreso")]
	private DateEdit _DEHoraIngreso;

	[AccessedThroughProperty("DEFecha")]
	private DateEdit _DEFecha;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("UcTxtRef")]
	private ucTextBox _UcTxtRef;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("UcCmbMotivo")]
	private ucComboBox _UcCmbMotivo;

	[AccessedThroughProperty("DefaultLookAndFeel1")]
	private DefaultLookAndFeel _DefaultLookAndFeel1;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("GroupBox2")]
	private GroupBox _GroupBox2;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	public int idEmpleado;

	private int idHorario;

	private byte[] img;

	private RRHHClass objClassRRHH;

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

	internal Button BtnGrabar
	{
		[DebuggerNonUserCode]
		get
		{
			return _BtnGrabar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = BtnGrabar_Click;
			if (_BtnGrabar != null)
			{
				_BtnGrabar.Click -= value2;
			}
			_BtnGrabar = value;
			if (_BtnGrabar != null)
			{
				_BtnGrabar.Click += value2;
			}
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

	internal CheckEdit CheckSalida
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckSalida;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = CheckSalida_CheckedChanged;
			if (_CheckSalida != null)
			{
				_CheckSalida.CheckedChanged -= value2;
			}
			_CheckSalida = value;
			if (_CheckSalida != null)
			{
				_CheckSalida.CheckedChanged += value2;
			}
		}
	}

	internal CheckEdit CheckIngreso
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckIngreso;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = CheckIngreso_CheckedChanged;
			if (_CheckIngreso != null)
			{
				_CheckIngreso.CheckedChanged -= value2;
			}
			_CheckIngreso = value;
			if (_CheckIngreso != null)
			{
				_CheckIngreso.CheckedChanged += value2;
			}
		}
	}

	internal DateEdit DEHoraSalida
	{
		[DebuggerNonUserCode]
		get
		{
			return _DEHoraSalida;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DEHoraSalida = value;
		}
	}

	internal DateEdit DEHoraIngreso
	{
		[DebuggerNonUserCode]
		get
		{
			return _DEHoraIngreso;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DEHoraIngreso = value;
		}
	}

	internal DateEdit DEFecha
	{
		[DebuggerNonUserCode]
		get
		{
			return _DEFecha;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = DEFecha_EditValueChanged;
			if (_DEFecha != null)
			{
				_DEFecha.EditValueChanged -= value2;
			}
			_DEFecha = value;
			if (_DEFecha != null)
			{
				_DEFecha.EditValueChanged += value2;
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
			_UcCmbMotivo = value;
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

	internal GroupBox GroupBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox2 = value;
		}
	}

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

	public FrmMarcacionesAutorizadas()
	{
		base.Load += FrmMarcacionesAutorizadas_Load;
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
		DevExpress.Utils.SuperToolTip superToolTip = new DevExpress.Utils.SuperToolTip();
		DevExpress.Utils.ToolTipTitleItem toolTipTitleItem = new DevExpress.Utils.ToolTipTitleItem();
		DevExpress.Utils.ToolTipItem toolTipItem = new DevExpress.Utils.ToolTipItem();
		DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
		DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
		DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
		DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
		DevExpress.Utils.ToolTipTitleItem toolTipTitleItem3 = new DevExpress.Utils.ToolTipTitleItem();
		DevExpress.Utils.ToolTipItem toolTipItem3 = new DevExpress.Utils.ToolTipItem();
		DevExpress.Utils.SuperToolTip superToolTip4 = new DevExpress.Utils.SuperToolTip();
		DevExpress.Utils.ToolTipTitleItem toolTipTitleItem4 = new DevExpress.Utils.ToolTipTitleItem();
		DevExpress.Utils.ToolTipItem toolTipItem4 = new DevExpress.Utils.ToolTipItem();
		this.GroupControl1 = new DevExpress.XtraEditors.GroupControl();
		this.UcTxtNDoc = new GRLL.Common.ucTextBox(this.components);
		this.Label5 = new System.Windows.Forms.Label();
		this.UcTxtApePater = new GRLL.Common.ucTextBox(this.components);
		this.UcTxtNombres = new GRLL.Common.ucTextBox(this.components);
		this.UcTxtApeMater = new GRLL.Common.ucTextBox(this.components);
		this.Label1 = new System.Windows.Forms.Label();
		this.UcFoto = new GRLL.Common.ucFoto();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.BtnGrabar = new System.Windows.Forms.Button();
		this.GroupControl2 = new DevExpress.XtraEditors.GroupControl();
		this.GroupBox2 = new System.Windows.Forms.GroupBox();
		this.CheckSalida = new DevExpress.XtraEditors.CheckEdit();
		this.DEHoraSalida = new DevExpress.XtraEditors.DateEdit();
		this.Label9 = new System.Windows.Forms.Label();
		this.GroupBox1 = new System.Windows.Forms.GroupBox();
		this.CheckIngreso = new DevExpress.XtraEditors.CheckEdit();
		this.DEHoraIngreso = new DevExpress.XtraEditors.DateEdit();
		this.Label6 = new System.Windows.Forms.Label();
		this.Label7 = new System.Windows.Forms.Label();
		this.UcCmbMotivo = new GRLL.Common.ucComboBox();
		this.UcTxtRef = new GRLL.Common.ucTextBox(this.components);
		this.Label8 = new System.Windows.Forms.Label();
		this.DEFecha = new DevExpress.XtraEditors.DateEdit();
		this.Label2 = new System.Windows.Forms.Label();
		this.DefaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
		((System.ComponentModel.ISupportInitialize)this.GroupControl1).BeginInit();
		this.GroupControl1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.GroupControl2).BeginInit();
		this.GroupControl2.SuspendLayout();
		this.GroupBox2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.CheckSalida.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.DEHoraSalida.Properties.VistaTimeProperties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.DEHoraSalida.Properties).BeginInit();
		this.GroupBox1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.CheckIngreso.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.DEHoraIngreso.Properties.VistaTimeProperties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.DEHoraIngreso.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.DEFecha.Properties.VistaTimeProperties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.DEFecha.Properties).BeginInit();
		this.SuspendLayout();
		this.cmdCerrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.cmdCerrar.AutoSize = true;
		this.cmdCerrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.cmdCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cmdCerrar.FlatAppearance.BorderSize = 0;
		this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.cmdCerrar.Image = RecursosHumanos.My.Resources.Resources._exit;
		System.Windows.Forms.Button button = this.cmdCerrar;
		System.Drawing.Point location = new System.Drawing.Point(424, 376);
		button.Location = location;
		System.Windows.Forms.Button button2 = this.cmdCerrar;
		System.Drawing.Size size = new System.Drawing.Size(61, 23);
		button2.Size = size;
		this.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		System.Windows.Forms.Panel panelSup = this.PanelSup;
		size = new System.Drawing.Size(497, 29);
		panelSup.Size = size;
		System.Windows.Forms.Panel panelInf = this.PanelInf;
		location = new System.Drawing.Point(0, 405);
		panelInf.Location = location;
		System.Windows.Forms.Panel panelInf2 = this.PanelInf;
		size = new System.Drawing.Size(497, 27);
		panelInf2.Size = size;
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
		this.GroupControl1.TabIndex = 3;
		this.GroupControl1.Text = "Datos Empleado";
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
		this.UcTxtNDoc.TabIndex = 34;
		this.UcTxtNDoc.TabNextControl = false;
		this.UcTxtNDoc.Tipo = GRLL.Common.ucTextBox.TipoDato.Todos;
		this.Label5.AutoSize = true;
		System.Windows.Forms.Label label = this.Label5;
		location = new System.Drawing.Point(45, 106);
		label.Location = location;
		this.Label5.Name = "Label5";
		System.Windows.Forms.Label label2 = this.Label5;
		size = new System.Drawing.Size(52, 13);
		label2.Size = size;
		this.Label5.TabIndex = 39;
		this.Label5.Text = "Nombres:";
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
		this.UcTxtApePater.TabIndex = 35;
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
		this.UcTxtNombres.TabIndex = 37;
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
		this.UcTxtApeMater.TabIndex = 36;
		this.UcTxtApeMater.TabNextControl = false;
		this.UcTxtApeMater.Tipo = GRLL.Common.ucTextBox.TipoDato.SoloLetras;
		this.Label1.AutoSize = true;
		System.Windows.Forms.Label label3 = this.Label1;
		location = new System.Drawing.Point(51, 32);
		label3.Location = location;
		this.Label1.Name = "Label1";
		System.Windows.Forms.Label label4 = this.Label1;
		size = new System.Drawing.Size(48, 13);
		label4.Size = size;
		this.Label1.TabIndex = 41;
		this.Label1.Text = "Nº Doc.:";
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
		this.UcFoto.TabIndex = 40;
		this.UcFoto.VerAjuste = false;
		this.UcFoto.VerControles = false;
		this.Label4.AutoSize = true;
		System.Windows.Forms.Label label5 = this.Label4;
		location = new System.Drawing.Point(10, 82);
		label5.Location = location;
		this.Label4.Name = "Label4";
		System.Windows.Forms.Label label6 = this.Label4;
		size = new System.Drawing.Size(89, 13);
		label6.Size = size;
		this.Label4.TabIndex = 45;
		this.Label4.Text = "Apellido Materno:";
		this.Label3.AutoSize = true;
		System.Windows.Forms.Label label7 = this.Label3;
		location = new System.Drawing.Point(10, 58);
		label7.Location = location;
		this.Label3.Name = "Label3";
		System.Windows.Forms.Label label8 = this.Label3;
		size = new System.Drawing.Size(87, 13);
		label8.Size = size;
		this.Label3.TabIndex = 44;
		this.Label3.Text = "Apellido Paterno:";
		this.BtnGrabar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.BtnGrabar.AutoSize = true;
		this.BtnGrabar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.BtnGrabar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BtnGrabar.FlatAppearance.BorderSize = 0;
		this.BtnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BtnGrabar.Image = RecursosHumanos.My.Resources.Resources.disk_blue1;
		System.Windows.Forms.Button btnGrabar = this.BtnGrabar;
		location = new System.Drawing.Point(3, 376);
		btnGrabar.Location = location;
		this.BtnGrabar.Name = "BtnGrabar";
		System.Windows.Forms.Button btnGrabar2 = this.BtnGrabar;
		size = new System.Drawing.Size(71, 23);
		btnGrabar2.Size = size;
		this.BtnGrabar.TabIndex = 4;
		this.BtnGrabar.Text = "Guardar";
		this.BtnGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.BtnGrabar.UseVisualStyleBackColor = true;
		this.GroupControl2.Controls.Add(this.GroupBox2);
		this.GroupControl2.Controls.Add(this.GroupBox1);
		this.GroupControl2.Controls.Add(this.Label7);
		this.GroupControl2.Controls.Add(this.UcCmbMotivo);
		this.GroupControl2.Controls.Add(this.UcTxtRef);
		this.GroupControl2.Controls.Add(this.Label8);
		this.GroupControl2.Controls.Add(this.DEFecha);
		this.GroupControl2.Controls.Add(this.Label2);
		DevExpress.XtraEditors.GroupControl groupControl3 = this.GroupControl2;
		location = new System.Drawing.Point(12, 174);
		groupControl3.Location = location;
		this.GroupControl2.Name = "GroupControl2";
		DevExpress.XtraEditors.GroupControl groupControl4 = this.GroupControl2;
		size = new System.Drawing.Size(474, 196);
		groupControl4.Size = size;
		this.GroupControl2.TabIndex = 5;
		this.GroupControl2.Text = "Datos Marcacion";
		this.GroupBox2.Controls.Add(this.CheckSalida);
		this.GroupBox2.Controls.Add(this.DEHoraSalida);
		this.GroupBox2.Controls.Add(this.Label9);
		System.Windows.Forms.GroupBox groupBox = this.GroupBox2;
		location = new System.Drawing.Point(224, 82);
		groupBox.Location = location;
		this.GroupBox2.Name = "GroupBox2";
		System.Windows.Forms.GroupBox groupBox2 = this.GroupBox2;
		size = new System.Drawing.Size(169, 78);
		groupBox2.Size = size;
		this.GroupBox2.TabIndex = 17;
		this.GroupBox2.TabStop = false;
		this.GroupBox2.Text = "Salida";
		DevExpress.XtraEditors.CheckEdit checkSalida = this.CheckSalida;
		location = new System.Drawing.Point(6, 23);
		checkSalida.Location = location;
		this.CheckSalida.Name = "CheckSalida";
		this.CheckSalida.Properties.Caption = "Autorizado?";
		DevExpress.XtraEditors.CheckEdit checkSalida2 = this.CheckSalida;
		size = new System.Drawing.Size(101, 18);
		checkSalida2.Size = size;
		toolTipTitleItem.Text = "Ayuda";
		toolTipItem.LeftIndent = 6;
		toolTipItem.Text = "Seleccione esta opcion para Autorizar la Salida";
		superToolTip.Items.Add(toolTipTitleItem);
		superToolTip.Items.Add(toolTipItem);
		this.CheckSalida.SuperTip = superToolTip;
		this.CheckSalida.TabIndex = 3;
		this.DEHoraSalida.EditValue = null;
		DevExpress.XtraEditors.DateEdit dEHoraSalida = this.DEHoraSalida;
		location = new System.Drawing.Point(90, 46);
		dEHoraSalida.Location = location;
		this.DEHoraSalida.Name = "DEHoraSalida";
		this.DEHoraSalida.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null)
		});
		this.DEHoraSalida.Properties.Mask.BeepOnError = true;
		this.DEHoraSalida.Properties.Mask.EditMask = "HH:mm:00";
		this.DEHoraSalida.Properties.Mask.UseMaskAsDisplayFormat = true;
		this.DEHoraSalida.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton()
		});
		DevExpress.XtraEditors.DateEdit dEHoraSalida2 = this.DEHoraSalida;
		size = new System.Drawing.Size(69, 20);
		dEHoraSalida2.Size = size;
		toolTipTitleItem2.Appearance.Image = RecursosHumanos.My.Resources.Resources.help2;
		toolTipTitleItem2.Appearance.Options.UseImage = true;
		toolTipTitleItem2.Image = RecursosHumanos.My.Resources.Resources.help2;
		toolTipTitleItem2.Text = "Ayuda";
		toolTipItem2.LeftIndent = 6;
		toolTipItem2.Text = "Ingrese la Hora de Salida del Empleado";
		superToolTip2.Items.Add(toolTipTitleItem2);
		superToolTip2.Items.Add(toolTipItem2);
		this.DEHoraSalida.SuperTip = superToolTip2;
		this.DEHoraSalida.TabIndex = 4;
		this.Label9.AutoSize = true;
		System.Windows.Forms.Label label9 = this.Label9;
		location = new System.Drawing.Point(6, 50);
		label9.Location = location;
		this.Label9.Name = "Label9";
		System.Windows.Forms.Label label10 = this.Label9;
		size = new System.Drawing.Size(80, 13);
		label10.Size = size;
		this.Label9.TabIndex = 15;
		this.Label9.Text = "Hora de Salida:";
		this.GroupBox1.Controls.Add(this.CheckIngreso);
		this.GroupBox1.Controls.Add(this.DEHoraIngreso);
		this.GroupBox1.Controls.Add(this.Label6);
		System.Windows.Forms.GroupBox groupBox3 = this.GroupBox1;
		location = new System.Drawing.Point(48, 82);
		groupBox3.Location = location;
		this.GroupBox1.Name = "GroupBox1";
		System.Windows.Forms.GroupBox groupBox4 = this.GroupBox1;
		size = new System.Drawing.Size(170, 78);
		groupBox4.Size = size;
		this.GroupBox1.TabIndex = 16;
		this.GroupBox1.TabStop = false;
		this.GroupBox1.Text = "Ingreso";
		this.CheckIngreso.AutoSizeInLayoutControl = true;
		DevExpress.XtraEditors.CheckEdit checkIngreso = this.CheckIngreso;
		location = new System.Drawing.Point(6, 23);
		checkIngreso.Location = location;
		this.CheckIngreso.Name = "CheckIngreso";
		this.CheckIngreso.Properties.Caption = "Autorizado?";
		DevExpress.XtraEditors.CheckEdit checkIngreso2 = this.CheckIngreso;
		size = new System.Drawing.Size(111, 18);
		checkIngreso2.Size = size;
		toolTipTitleItem3.Text = "Ayuda";
		toolTipItem3.LeftIndent = 6;
		toolTipItem3.Text = "Seleccione esta opcion,para autorizar el ingreso";
		superToolTip3.Items.Add(toolTipTitleItem3);
		superToolTip3.Items.Add(toolTipItem3);
		this.CheckIngreso.SuperTip = superToolTip3;
		this.CheckIngreso.TabIndex = 1;
		this.DEHoraIngreso.EditValue = null;
		DevExpress.XtraEditors.DateEdit dEHoraIngreso = this.DEHoraIngreso;
		location = new System.Drawing.Point(95, 46);
		dEHoraIngreso.Location = location;
		this.DEHoraIngreso.Name = "DEHoraIngreso";
		this.DEHoraIngreso.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null)
		});
		this.DEHoraIngreso.Properties.Mask.BeepOnError = true;
		this.DEHoraIngreso.Properties.Mask.EditMask = "HH:mm:00";
		this.DEHoraIngreso.Properties.Mask.UseMaskAsDisplayFormat = true;
		this.DEHoraIngreso.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
		this.DEHoraIngreso.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.False;
		this.DEHoraIngreso.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton()
		});
		DevExpress.XtraEditors.DateEdit dEHoraIngreso2 = this.DEHoraIngreso;
		size = new System.Drawing.Size(68, 20);
		dEHoraIngreso2.Size = size;
		toolTipTitleItem4.Appearance.Image = RecursosHumanos.My.Resources.Resources.help2;
		toolTipTitleItem4.Appearance.Options.UseImage = true;
		toolTipTitleItem4.Image = RecursosHumanos.My.Resources.Resources.help2;
		toolTipTitleItem4.Text = "Ayuda";
		toolTipItem4.LeftIndent = 6;
		toolTipItem4.Text = "Ingrese la Hora de Ingreso del Empleado";
		superToolTip4.Items.Add(toolTipTitleItem4);
		superToolTip4.Items.Add(toolTipItem4);
		this.DEHoraIngreso.SuperTip = superToolTip4;
		this.DEHoraIngreso.TabIndex = 2;
		this.Label6.AutoSize = true;
		System.Windows.Forms.Label label11 = this.Label6;
		location = new System.Drawing.Point(6, 50);
		label11.Location = location;
		this.Label6.Name = "Label6";
		System.Windows.Forms.Label label12 = this.Label6;
		size = new System.Drawing.Size(86, 13);
		label12.Size = size;
		this.Label6.TabIndex = 14;
		this.Label6.Text = "Hora de Ingreso:";
		this.Label7.AutoSize = true;
		System.Windows.Forms.Label label13 = this.Label7;
		location = new System.Drawing.Point(28, 32);
		label13.Location = location;
		this.Label7.Name = "Label7";
		System.Windows.Forms.Label label14 = this.Label7;
		size = new System.Drawing.Size(42, 13);
		label14.Size = size;
		this.Label7.TabIndex = 13;
		this.Label7.Text = "Motivo:";
		this.UcCmbMotivo.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCmbMotivo.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCmbMotivo.FormattingEnabled = true;
		this.UcCmbMotivo.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucCmbMotivo = this.UcCmbMotivo;
		location = new System.Drawing.Point(76, 29);
		ucCmbMotivo.Location = location;
		this.UcCmbMotivo.Name = "UcCmbMotivo";
		GRLL.Common.ucComboBox ucCmbMotivo2 = this.UcCmbMotivo;
		size = new System.Drawing.Size(215, 21);
		ucCmbMotivo2.Size = size;
		this.UcCmbMotivo.TabIndex = 12;
		this.UcTxtRef.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtRef.Formato = null;
		this.UcTxtRef.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtRef = this.UcTxtRef;
		location = new System.Drawing.Point(95, 166);
		ucTxtRef.Location = location;
		this.UcTxtRef.MaxLength = 50;
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
		this.UcTxtRef.TabIndex = 11;
		this.UcTxtRef.TabNextControl = false;
		this.UcTxtRef.Tipo = GRLL.Common.ucTextBox.TipoDato.Todos;
		this.Label8.AutoSize = true;
		System.Windows.Forms.Label label15 = this.Label8;
		location = new System.Drawing.Point(33, 169);
		label15.Location = location;
		this.Label8.Name = "Label8";
		System.Windows.Forms.Label label16 = this.Label8;
		size = new System.Drawing.Size(56, 13);
		label16.Size = size;
		this.Label8.TabIndex = 10;
		this.Label8.Text = "Doc. Ref.:";
		DevExpress.XtraEditors.DateEdit dEFecha = this.DEFecha;
		System.DateTime dateTime = new System.DateTime(2010, 3, 18, 12, 19, 46, 0);
		dEFecha.EditValue = dateTime;
		DevExpress.XtraEditors.DateEdit dEFecha2 = this.DEFecha;
		location = new System.Drawing.Point(76, 56);
		dEFecha2.Location = location;
		this.DEFecha.Name = "DEFecha";
		this.DEFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, true, true, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null)
		});
		this.DEFecha.Properties.Mask.EditMask = "D";
		this.DEFecha.Properties.Mask.UseMaskAsDisplayFormat = true;
		this.DEFecha.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
		this.DEFecha.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.True;
		this.DEFecha.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton()
		});
		DevExpress.XtraEditors.DateEdit dEFecha3 = this.DEFecha;
		size = new System.Drawing.Size(215, 20);
		dEFecha3.Size = size;
		this.DEFecha.TabIndex = 0;
		this.Label2.AutoSize = true;
		System.Windows.Forms.Label label17 = this.Label2;
		location = new System.Drawing.Point(30, 59);
		label17.Location = location;
		this.Label2.Name = "Label2";
		System.Windows.Forms.Label label18 = this.Label2;
		size = new System.Drawing.Size(40, 13);
		label18.Size = size;
		this.Label2.TabIndex = 0;
		this.Label2.Text = "Fecha:";
		this.DefaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins";
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		size = new System.Drawing.Size(497, 432);
		this.ClientSize = size;
		this.Controls.Add(this.GroupControl2);
		this.Controls.Add(this.BtnGrabar);
		this.Controls.Add(this.GroupControl1);
		this.MessageShow = true;
		this.Name = "FrmMarcacionesAutorizadas";
		this.TitleMsg = "FrmConsulta";
		this.Titulo = "Marcaciones Autorizadas";
		this.VerCmdCerrar = true;
		this.Controls.SetChildIndex(this.PanelSup, 0);
		this.Controls.SetChildIndex(this.PanelInf, 0);
		this.Controls.SetChildIndex(this.cmdCerrar, 0);
		this.Controls.SetChildIndex(this.GroupControl1, 0);
		this.Controls.SetChildIndex(this.BtnGrabar, 0);
		this.Controls.SetChildIndex(this.GroupControl2, 0);
		((System.ComponentModel.ISupportInitialize)this.GroupControl1).EndInit();
		this.GroupControl1.ResumeLayout(false);
		this.GroupControl1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.GroupControl2).EndInit();
		this.GroupControl2.ResumeLayout(false);
		this.GroupControl2.PerformLayout();
		this.GroupBox2.ResumeLayout(false);
		this.GroupBox2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.CheckSalida.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.DEHoraSalida.Properties.VistaTimeProperties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.DEHoraSalida.Properties).EndInit();
		this.GroupBox1.ResumeLayout(false);
		this.GroupBox1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.CheckIngreso.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.DEHoraIngreso.Properties.VistaTimeProperties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.DEHoraIngreso.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.DEFecha.Properties.VistaTimeProperties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.DEFecha.Properties).EndInit();
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	private void BtnGrabar_Click(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(UcCmbMotivo.SelectedValue, 0, TextCompare: false))
		{
			MessageBox.Show("Debe Seleccionar un Motivo Válido", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		if ((CheckIngreso.CheckState == CheckState.Unchecked) & (CheckSalida.CheckState == CheckState.Unchecked))
		{
			MessageBox.Show("Debe Autorizar, la Entrada o Salida", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		if (UcTxtRef.TextLength == 0)
		{
			MessageBox.Show("Debe Ingresar un Documento de Referencia", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		if (objClassRRHH.ExistePermiso(idEmpleado, Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(DEFecha.DateTime.Year, Interaction.IIf(DEFecha.DateTime.Month.ToString().Length == 1, "0" + Conversions.ToString(DEFecha.DateTime.Month), DEFecha.DateTime.Month)), Interaction.IIf(DEFecha.DateTime.Day.ToString().Length == 1, "0" + Conversions.ToString(DEFecha.DateTime.Day), DEFecha.DateTime.Day))), Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(DEFecha.DateTime.Year, Interaction.IIf(DEFecha.DateTime.Month.ToString().Length == 1, "0" + Conversions.ToString(DEFecha.DateTime.Month), DEFecha.DateTime.Month)), Interaction.IIf(DEFecha.DateTime.Day.ToString().Length == 1, "0" + Conversions.ToString(DEFecha.DateTime.Day), DEFecha.DateTime.Day)))) >= 1)
		{
			MessageBox.Show("El Empleado se Encuentra de Permiso, No se puede agregar Otro Permiso", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		Permiso permiso = new Permiso();
		permiso.FechaFin = Conversions.ToDate(DEFecha.DateTime.ToShortDateString());
		permiso.FechaInicio = Conversions.ToDate(DEFecha.DateTime.ToShortDateString());
		object selectedValue = UcCmbMotivo.SelectedValue;
		int? num = default(int?);
		permiso.idMotivo = ((selectedValue != null) ? ((int?)selectedValue) : num);
		permiso.Referencia = UcTxtRef.Text.Trim();
		permiso.Dia = true;
		permiso.Retorno = false;
		permiso.IdEmpleado = idEmpleado;
		int nPermiso = ((PermisoMapper.Instance().SelectBy([SpecialName] (Permiso v) => v.IdEmpleado == idEmpleado).Count == 0) ? 1 : objClassRRHH.SgtIdPermiso(idEmpleado));
		permiso.NPermiso = nPermiso;
		PermisoMapper.Instance().Insert(permiso);
		Horario horario = HorarioMapper.Instance().SelectBy([SpecialName] (Horario v) => v.idHorario == idHorario).Single();
		string fecha = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(DEFecha.DateTime.Year.ToString(), Interaction.IIf(DEFecha.DateTime.Month.ToString().Length == 1, "0" + DEFecha.DateTime.Month, DEFecha.DateTime.Month.ToString())), Interaction.IIf(DEFecha.DateTime.Day.ToString().Length == 1, "0" + DEFecha.DateTime.Day, DEFecha.DateTime.Day.ToString())));
		DataTable dataTable = objClassRRHH.spRRHH_GetAsistenciaDia(idEmpleado, fecha);
		Asistencia asistencia = new Asistencia();
		asistencia.Fecha = Conversions.ToDate(DEFecha.DateTime.ToShortDateString());
		asistencia.IdEmpleado = idEmpleado;
		if (CheckIngreso.CheckState == CheckState.Checked)
		{
			asistencia.Hor_Ent = DEHoraIngreso.Text;
			asistencia.Flag_Ent = false;
			if (dataTable.Rows.Count == 0)
			{
				Marcacion marcacion = new Marcacion();
				marcacion.Fecha = Conversions.ToDate(DEFecha.DateTime.ToShortDateString() + " " + DEHoraIngreso.Text);
				marcacion.Estado = "1M";
				marcacion.IdEmpleado = idEmpleado;
				MarcacionMapper.Instance().Insert(marcacion);
			}
		}
		else
		{
			if (dataTable.Rows.Count == 1)
			{
				asistencia.Hor_Ent = dataTable.Rows[0]["Hor_Ent"].ToString();
			}
			else
			{
				asistencia.Hor_Ent = "00:00:00";
			}
			asistencia.Flag_Ent = true;
		}
		if (CheckSalida.CheckState == CheckState.Checked)
		{
			asistencia.Hor_Sal = DEHoraSalida.Text;
			asistencia.Flag_Sal = false;
			if (dataTable.Rows.Count == 0)
			{
				Marcacion marcacion2 = new Marcacion();
				marcacion2.Fecha = Conversions.ToDate(DEFecha.DateTime.ToShortDateString() + " " + DEHoraSalida.Text);
				marcacion2.Estado = "4M";
				marcacion2.IdEmpleado = idEmpleado;
				MarcacionMapper.Instance().Insert(marcacion2);
			}
		}
		else
		{
			if (dataTable.Rows.Count == 1)
			{
				asistencia.Hor_Sal = dataTable.Rows[0]["Hor_Sal"].ToString();
			}
			else
			{
				asistencia.Hor_Sal = "00:00:00";
			}
			asistencia.Flag_Sal = true;
		}
		asistencia.Estado = true;
		if (dataTable.Rows.Count == 0)
		{
			AsistenciaMapper.Instance().Insert(asistencia);
		}
		else
		{
			AsistenciaMapper.Instance().Update(asistencia);
		}
		MessageBox.Show("Se Grabo Correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
	}

	private void FrmMarcacionesAutorizadas_Load(object sender, EventArgs e)
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
				if (NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "idHorario" }, null, null, null) == null)
				{
					MessageBox.Show("Primero debe asignar un Horario al trabajador", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				idHorario = Conversions.ToInteger(NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "idHorario" }, null, null, null));
			}
		}
		ucComboBox ucCmbMotivo = UcCmbMotivo;
		ucCmbMotivo.DisplayMember = "Descrip_Motivo";
		ucCmbMotivo.ValueMember = "idMotivo";
		if (Conversions.ToDouble(RRHH.IdROl) == 10.0)
		{
			List<Motivo_Perm> list = Motivo_PermMapper.Instance().SelectBy([SpecialName] (Motivo_Perm p) =>
			{
				int num = 1;
				int? idTipoPermiso = p.idTipoPermiso;
				bool? obj;
				if (!idTipoPermiso.HasValue)
				{
					obj = null;
				}
				else
				{
					bool? flag = idTipoPermiso.GetValueOrDefault() == num;
					obj = flag;
				}
				bool? flag2 = obj;
				bool? flag4;
				if (Operators.CompareString(Conversions.ToString((char)p.TipoModalidad), "P", TextCompare: false) != 0)
				{
					bool? flag3 = false;
					flag4 = flag3;
				}
				else
				{
					flag4 = flag2;
				}
				return (bool)flag4;
			});
			list.Insert(0, new Motivo_Perm
			{
				idMotivo = 0,
				Descrip_Motivo = "--SELECCIONAR--"
			});
			ucCmbMotivo.DataSource = list;
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 14.0)
		{
			List<Motivo_Perm> list2 = Motivo_PermMapper.Instance().SelectBy([SpecialName] (Motivo_Perm p) =>
			{
				int num2 = 1;
				int? idTipoPermiso2 = p.idTipoPermiso;
				bool? obj2;
				if (!idTipoPermiso2.HasValue)
				{
					obj2 = null;
				}
				else
				{
					bool? flag5 = idTipoPermiso2.GetValueOrDefault() == num2;
					obj2 = flag5;
				}
				bool? flag6 = obj2;
				bool? flag8;
				if (Operators.CompareString(Conversions.ToString((char)p.TipoModalidad), "C", TextCompare: false) != 0)
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
			list2.Insert(0, new Motivo_Perm
			{
				idMotivo = 0,
				Descrip_Motivo = "--SELECCIONAR--"
			});
			ucCmbMotivo.DataSource = list2;
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 13.0)
		{
			List<Motivo_Perm> list3 = Motivo_PermMapper.Instance().SelectBy([SpecialName] (Motivo_Perm p) =>
			{
				int num3 = 1;
				int? idTipoPermiso3 = p.idTipoPermiso;
				bool? obj3;
				if (!idTipoPermiso3.HasValue)
				{
					obj3 = null;
				}
				else
				{
					bool? flag9 = idTipoPermiso3.GetValueOrDefault() == num3;
					obj3 = flag9;
				}
				return (bool)obj3;
			});
			list3.Insert(0, new Motivo_Perm
			{
				idMotivo = 0,
				Descrip_Motivo = "--SELECCIONAR--"
			});
			ucCmbMotivo.DataSource = list3;
		}
		ucCmbMotivo = null;
		DEFecha.EditValue = DateAndTime.Today;
	}

	private void DEFecha_EditValueChanged(object sender, EventArgs e)
	{
		if (Operators.CompareString(DEFecha.DateTime.ToShortDateString(), "01/01/0001", TextCompare: false) == 0)
		{
			return;
		}
		string fecha = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(DEFecha.DateTime.Year.ToString(), Interaction.IIf(DEFecha.DateTime.Month.ToString().Length == 1, "0" + DEFecha.DateTime.Month, DEFecha.DateTime.Month.ToString())), Interaction.IIf(DEFecha.DateTime.Day.ToString().Length == 1, "0" + DEFecha.DateTime.Day, DEFecha.DateTime.Day.ToString())));
		DataTable dataTable = objClassRRHH.spRRHH_GetAsistenciaDia(idEmpleado, fecha);
		if (dataTable.Rows.Count == 1)
		{
			DEHoraIngreso.Text = dataTable.Rows[0]["Hor_Ent"].ToString();
			DEHoraSalida.Text = dataTable.Rows[0]["Hor_Sal"].ToString();
			if (dataTable.Rows[0]["Estado"] == DBNull.Value || (Operators.ConditionalCompareObjectEqual(dataTable.Rows[0]["Estado"], true, TextCompare: false) ? true : false))
			{
				if (dataTable.Rows[0]["Flag_Ent"] == DBNull.Value || (Operators.ConditionalCompareObjectEqual(dataTable.Rows[0]["Flag_Ent"], true, TextCompare: false) ? true : false))
				{
					CheckIngreso.Checked = false;
				}
				else
				{
					CheckIngreso.Checked = true;
				}
				if (dataTable.Rows[0]["Flag_Sal"] == DBNull.Value || (Operators.ConditionalCompareObjectEqual(dataTable.Rows[0]["Flag_Sal"], true, TextCompare: false) ? true : false))
				{
					CheckSalida.Checked = false;
				}
				else
				{
					CheckSalida.Checked = true;
				}
			}
			else
			{
				CheckIngreso.Checked = false;
				CheckSalida.Checked = false;
			}
		}
		else
		{
			DEHoraIngreso.Text = "";
			DEHoraSalida.Text = "";
			CheckIngreso.Checked = false;
			CheckSalida.Checked = false;
		}
	}

	private void CheckIngreso_CheckedChanged(object sender, EventArgs e)
	{
		if (CheckSalida.CheckState == CheckState.Checked)
		{
			MessageBox.Show("En caso de justificar Entrada y Salida, al mismo tiempo, por favor utilice la interfaz de PERMISOS", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		else if (CheckIngreso.CheckState == CheckState.Checked)
		{
			DEHoraIngreso.Enabled = false;
			DEHoraIngreso.Focus();
		}
		else
		{
			DEHoraIngreso.Enabled = true;
		}
	}

	private void CheckSalida_CheckedChanged(object sender, EventArgs e)
	{
		if (CheckIngreso.CheckState == CheckState.Checked)
		{
			MessageBox.Show("En caso de justificar Entrada y Salida, al mismo tiempo, por favor utilice la interfaz de PERMISOS", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		else if (CheckSalida.CheckState == CheckState.Checked)
		{
			DEHoraSalida.Enabled = false;
			DEHoraSalida.Focus();
		}
		else
		{
			DEHoraSalida.Enabled = true;
		}
	}
}
