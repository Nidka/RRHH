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
using DevExpress.XtraEditors;
using GRLL.Common;
using Microsoft.VisualBasic.CompilerServices;
using RecursosHumanos.My.Resources;

namespace RecursosHumanos;

[DesignerGenerated]
public class FrmHorarioEsp : FrmConsulta
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

	[AccessedThroughProperty("GroupControl2")]
	private GroupControl _GroupControl2;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("UcFechas")]
	private ucFechas _UcFechas;

	[AccessedThroughProperty("UcCmbTipoPermiso")]
	private ucComboBox _UcCmbTipoPermiso;

	[AccessedThroughProperty("UcTxtSisgedo")]
	private ucTextBox _UcTxtSisgedo;

	[AccessedThroughProperty("UcTxtRef")]
	private ucTextBox _UcTxtRef;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("btnGuardar")]
	private Button _btnGuardar;

	[AccessedThroughProperty("DefaultLookAndFeel1")]
	private DefaultLookAndFeel _DefaultLookAndFeel1;

	[AccessedThroughProperty("lblHorario")]
	private Label _lblHorario;

	public int idEmpleado;

	public int Npermiso;

	private byte[] img;

	private RRHHClass objClassRRHH;

	private List<Horario> dt;

	protected override Button cmdCerrar
	{
		[DebuggerNonUserCode]
		get
		{
			return base.cmdCerrar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = cmdCerrar_Click;
			if (base.cmdCerrar != null)
			{
				base.cmdCerrar.Click -= value2;
			}
			base.cmdCerrar = value;
			if (base.cmdCerrar != null)
			{
				base.cmdCerrar.Click += value2;
			}
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

	internal ucTextBox UcTxtSisgedo
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtSisgedo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtSisgedo = value;
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

	internal Button btnGuardar
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnGuardar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = btnGuardar_Click;
			if (_btnGuardar != null)
			{
				_btnGuardar.Click -= value2;
			}
			_btnGuardar = value;
			if (_btnGuardar != null)
			{
				_btnGuardar.Click += value2;
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

	internal Label lblHorario
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblHorario;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblHorario = value;
		}
	}

	public FrmHorarioEsp()
	{
		base.Load += FrmHorarioEsp_Load;
		__ENCAddToList(this);
		img = null;
		objClassRRHH = new RRHHClass();
		dt = new List<Horario>();
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
		this.GroupControl2 = new DevExpress.XtraEditors.GroupControl();
		this.lblHorario = new System.Windows.Forms.Label();
		this.UcTxtSisgedo = new GRLL.Common.ucTextBox(this.components);
		this.UcTxtRef = new GRLL.Common.ucTextBox(this.components);
		this.Label7 = new System.Windows.Forms.Label();
		this.Label8 = new System.Windows.Forms.Label();
		this.UcCmbTipoPermiso = new GRLL.Common.ucComboBox();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label6 = new System.Windows.Forms.Label();
		this.UcFechas = new GRLL.Common.ucFechas();
		this.btnGuardar = new System.Windows.Forms.Button();
		this.DefaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
		((System.ComponentModel.ISupportInitialize)this.GroupControl1).BeginInit();
		this.GroupControl1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.GroupControl2).BeginInit();
		this.GroupControl2.SuspendLayout();
		this.SuspendLayout();
		this.cmdCerrar.AutoSize = true;
		this.cmdCerrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.cmdCerrar.FlatAppearance.BorderSize = 0;
		this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.cmdCerrar.Image = RecursosHumanos.My.Resources.Resources._exit;
		System.Windows.Forms.Button button = this.cmdCerrar;
		System.Drawing.Point location = new System.Drawing.Point(423, 342);
		button.Location = location;
		System.Windows.Forms.Button button2 = this.cmdCerrar;
		System.Drawing.Size size = new System.Drawing.Size(61, 23);
		button2.Size = size;
		this.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		System.Windows.Forms.Panel panelSup = this.PanelSup;
		size = new System.Drawing.Size(500, 29);
		panelSup.Size = size;
		System.Windows.Forms.Panel panelInf = this.PanelInf;
		location = new System.Drawing.Point(0, 381);
		panelInf.Location = location;
		System.Windows.Forms.Panel panelInf2 = this.PanelInf;
		size = new System.Drawing.Size(500, 27);
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
		this.UcTxtNDoc.TabIndex = 1;
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
		this.UcFoto.TabIndex = 5;
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
		this.GroupControl2.Controls.Add(this.lblHorario);
		this.GroupControl2.Controls.Add(this.UcTxtSisgedo);
		this.GroupControl2.Controls.Add(this.UcTxtRef);
		this.GroupControl2.Controls.Add(this.Label7);
		this.GroupControl2.Controls.Add(this.Label8);
		this.GroupControl2.Controls.Add(this.UcCmbTipoPermiso);
		this.GroupControl2.Controls.Add(this.Label2);
		this.GroupControl2.Controls.Add(this.Label6);
		this.GroupControl2.Controls.Add(this.UcFechas);
		DevExpress.XtraEditors.GroupControl groupControl3 = this.GroupControl2;
		location = new System.Drawing.Point(12, 174);
		groupControl3.Location = location;
		this.GroupControl2.Name = "GroupControl2";
		DevExpress.XtraEditors.GroupControl groupControl4 = this.GroupControl2;
		size = new System.Drawing.Size(474, 162);
		groupControl4.Size = size;
		this.GroupControl2.TabIndex = 4;
		this.GroupControl2.Text = "Datos Horario Marcacion";
		this.lblHorario.AutoSize = true;
		this.lblHorario.ForeColor = System.Drawing.Color.DarkRed;
		System.Windows.Forms.Label label9 = this.lblHorario;
		location = new System.Drawing.Point(230, 75);
		label9.Location = location;
		this.lblHorario.Name = "lblHorario";
		System.Windows.Forms.Label label10 = this.lblHorario;
		size = new System.Drawing.Size(0, 13);
		label10.Size = size;
		this.lblHorario.TabIndex = 12;
		this.UcTxtSisgedo.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtSisgedo.Formato = null;
		this.UcTxtSisgedo.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtSisgedo = this.UcTxtSisgedo;
		location = new System.Drawing.Point(77, 127);
		ucTxtSisgedo.Location = location;
		this.UcTxtSisgedo.MaxLength = 100;
		this.UcTxtSisgedo.Name = "UcTxtSisgedo";
		this.UcTxtSisgedo.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtSisgedo.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtSisgedo.OnErrorBlankText = "";
		this.UcTxtSisgedo.PadLeftLenght = 0;
		this.UcTxtSisgedo.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtSisgedo.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtSisgedo2 = this.UcTxtSisgedo;
		size = new System.Drawing.Size(215, 20);
		ucTxtSisgedo2.Size = size;
		this.UcTxtSisgedo.TabIndex = 11;
		this.UcTxtSisgedo.TabNextControl = false;
		this.UcTxtSisgedo.Tipo = GRLL.Common.ucTextBox.TipoDato.Todos;
		this.UcTxtRef.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtRef.Formato = null;
		this.UcTxtRef.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtRef = this.UcTxtRef;
		location = new System.Drawing.Point(77, 99);
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
		this.UcTxtRef.TabIndex = 11;
		this.UcTxtRef.TabNextControl = false;
		this.UcTxtRef.Tipo = GRLL.Common.ucTextBox.TipoDato.Todos;
		this.Label7.AutoSize = true;
		System.Windows.Forms.Label label11 = this.Label7;
		location = new System.Drawing.Point(11, 130);
		label11.Location = location;
		this.Label7.Name = "Label7";
		System.Windows.Forms.Label label12 = this.Label7;
		size = new System.Drawing.Size(58, 13);
		label12.Size = size;
		this.Label7.TabIndex = 10;
		this.Label7.Text = "SISGEDO:";
		this.Label8.AutoSize = true;
		System.Windows.Forms.Label label13 = this.Label8;
		location = new System.Drawing.Point(14, 102);
		label13.Location = location;
		this.Label8.Name = "Label8";
		System.Windows.Forms.Label label14 = this.Label8;
		size = new System.Drawing.Size(56, 13);
		label14.Size = size;
		this.Label8.TabIndex = 10;
		this.Label8.Text = "Doc. Ref.:";
		this.UcCmbTipoPermiso.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCmbTipoPermiso.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCmbTipoPermiso.FormattingEnabled = true;
		this.UcCmbTipoPermiso.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucCmbTipoPermiso = this.UcCmbTipoPermiso;
		location = new System.Drawing.Point(77, 72);
		ucCmbTipoPermiso.Location = location;
		this.UcCmbTipoPermiso.Name = "UcCmbTipoPermiso";
		GRLL.Common.ucComboBox ucCmbTipoPermiso2 = this.UcCmbTipoPermiso;
		size = new System.Drawing.Size(147, 21);
		ucCmbTipoPermiso2.Size = size;
		this.UcCmbTipoPermiso.TabIndex = 7;
		this.Label2.AutoSize = true;
		System.Windows.Forms.Label label15 = this.Label2;
		location = new System.Drawing.Point(27, 75);
		label15.Location = location;
		this.Label2.Name = "Label2";
		System.Windows.Forms.Label label16 = this.Label2;
		size = new System.Drawing.Size(44, 13);
		label16.Size = size;
		this.Label2.TabIndex = 5;
		this.Label2.Text = "Horario:";
		this.Label6.AutoSize = true;
		System.Windows.Forms.Label label17 = this.Label6;
		location = new System.Drawing.Point(27, 43);
		label17.Location = location;
		this.Label6.Name = "Label6";
		System.Windows.Forms.Label label18 = this.Label6;
		size = new System.Drawing.Size(40, 13);
		label18.Size = size;
		this.Label6.TabIndex = 5;
		this.Label6.Text = "Fecha:";
		GRLL.Common.ucFechas ucFechas = this.UcFechas;
		location = new System.Drawing.Point(77, 38);
		ucFechas.Location = location;
		this.UcFechas.Name = "UcFechas";
		GRLL.Common.ucFechas ucFechas2 = this.UcFechas;
		size = new System.Drawing.Size(302, 22);
		ucFechas2.Size = size;
		this.UcFechas.TabIndex = 6;
		this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.btnGuardar.AutoSize = true;
		this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnGuardar.FlatAppearance.BorderSize = 0;
		this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnGuardar.Image = RecursosHumanos.My.Resources.Resources.disk_blue1;
		System.Windows.Forms.Button button3 = this.btnGuardar;
		location = new System.Drawing.Point(12, 342);
		button3.Location = location;
		this.btnGuardar.Name = "btnGuardar";
		System.Windows.Forms.Button button4 = this.btnGuardar;
		size = new System.Drawing.Size(71, 23);
		button4.Size = size;
		this.btnGuardar.TabIndex = 5;
		this.btnGuardar.Text = "Guardar";
		this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.btnGuardar.UseVisualStyleBackColor = true;
		this.DefaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins";
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		size = new System.Drawing.Size(500, 408);
		this.ClientSize = size;
		this.Controls.Add(this.btnGuardar);
		this.Controls.Add(this.GroupControl2);
		this.Controls.Add(this.GroupControl1);
		this.MessageShow = true;
		this.Name = "FrmHorarioEsp";
		this.TitleMsg = "FrmConsulta";
		this.Titulo = "Horarios Especiales";
		this.VerCmdCerrar = true;
		this.Controls.SetChildIndex(this.PanelSup, 0);
		this.Controls.SetChildIndex(this.PanelInf, 0);
		this.Controls.SetChildIndex(this.cmdCerrar, 0);
		this.Controls.SetChildIndex(this.GroupControl1, 0);
		this.Controls.SetChildIndex(this.GroupControl2, 0);
		this.Controls.SetChildIndex(this.btnGuardar, 0);
		((System.ComponentModel.ISupportInitialize)this.GroupControl1).EndInit();
		this.GroupControl1.ResumeLayout(false);
		this.GroupControl1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.GroupControl2).EndInit();
		this.GroupControl2.ResumeLayout(false);
		this.GroupControl2.PerformLayout();
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	private void FrmHorarioEsp_Load(object sender, EventArgs e)
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
		dt = HorarioMapper.Instance().SelectAll();
		dt.Insert(0, new Horario
		{
			idHorario = 0,
			Descrip_Horario = "--SELECCIONAR--"
		});
		UcCmbTipoPermiso.DataSource = dt;
		UcCmbTipoPermiso.DisplayMember = "Descrip_Horario";
		UcCmbTipoPermiso.ValueMember = "idHorario";
		if (Npermiso != 0)
		{
			HorarioTemporal horarioTemporal = HorarioTemporalMapper.Instance().SelectBy([SpecialName] (HorarioTemporal v) => (v.idEmpleado == idEmpleado) & (v.N == Npermiso)).Single();
			UcCmbTipoPermiso.SelectedValue = horarioTemporal.HorarioAsignado;
			UcTxtRef.Text = horarioTemporal.NroDocumento.ToString();
			UcTxtSisgedo.Text = horarioTemporal.Sisgedo.ToString();
			RangoFecha rango = new RangoFecha(horarioTemporal.FechaInicio.Value, horarioTemporal.FechaFin.Value);
			UcFechas.Rango = rango;
		}
	}

	private void UcCmbTipoPermiso_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (UcCmbTipoPermiso.SelectedIndex == 0)
		{
			lblHorario.Text = "";
			return;
		}
		Horario horario = dt[UcCmbTipoPermiso.SelectedIndex];
		lblHorario.Text = "Ingreso: " + horario.Ingreso1 + " | Salida:" + horario.Salida2;
	}

	private void btnGuardar_Click(object sender, EventArgs e)
	{
		if (DateTime.Compare(UcFechas.Rango.Desde, UcFechas.Rango.Hasta) > 0)
		{
			MessageBox.Show("La Fecha de Inicio no puede ser mayor a la de Término", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		if (Operators.ConditionalCompareObjectEqual(UcCmbTipoPermiso.SelectedValue, 0, TextCompare: false))
		{
			MessageBox.Show("Debe Seleccionar un Horario Válido", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		if (Npermiso == 0)
		{
			List<HorarioTemporal> list = HorarioTemporalMapper.Instance().SelectBy([SpecialName] (HorarioTemporal p) => (p.idEmpleado == idEmpleado) & (Operators.CompareString(p.FechaInicio.Value.ToShortDateString(), UcFechas.Rango.Desde.ToShortDateString(), TextCompare: false) <= 0) & (Operators.CompareString(p.FechaFin.Value.ToShortDateString(), UcFechas.Rango.Desde.ToShortDateString(), TextCompare: false) >= 0));
			if (list.Count >= 1)
			{
				MessageBox.Show("El Empleado ya Registra este Horario", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
		}
		HorarioTemporal horarioTemporal = new HorarioTemporal();
		horarioTemporal.idEmpleado = idEmpleado;
		horarioTemporal.FechaFin = Conversions.ToDate(UcFechas.Rango.Hasta.ToShortDateString());
		horarioTemporal.FechaInicio = Conversions.ToDate(UcFechas.Rango.Desde.ToShortDateString());
		object selectedValue = UcCmbTipoPermiso.SelectedValue;
		int? num = default(int?);
		horarioTemporal.HorarioAsignado = ((selectedValue != null) ? ((int?)selectedValue) : num);
		horarioTemporal.NroDocumento = UcTxtRef.Text.Trim();
		horarioTemporal.Sisgedo = UcTxtSisgedo.Text.Trim();
		if (Npermiso == 0)
		{
			horarioTemporal.N = objClassRRHH.SgtIdHorarioTemporal(idEmpleado);
			HorarioTemporalMapper.Instance().Insert(horarioTemporal);
		}
		else
		{
			horarioTemporal.N = Npermiso;
			HorarioTemporalMapper.Instance().Update(horarioTemporal);
		}
		DialogResult = DialogResult.OK;
	}

	private void cmdCerrar_Click(object sender, EventArgs e)
	{
		Close();
	}
}
