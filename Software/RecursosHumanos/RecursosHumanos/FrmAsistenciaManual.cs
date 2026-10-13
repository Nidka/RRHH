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
public class FrmAsistenciaManual : FrmConsulta
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("BtnGrabar")]
	private Button _BtnGrabar;

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

	[AccessedThroughProperty("DEHoraIngreso")]
	private DateEdit _DEHoraIngreso;

	[AccessedThroughProperty("DEFecha")]
	private DateEdit _DEFecha;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("DefaultLookAndFeel1")]
	private DefaultLookAndFeel _DefaultLookAndFeel1;

	[AccessedThroughProperty("CheckIngreso")]
	private CheckEdit _CheckIngreso;

	[AccessedThroughProperty("DEHoraSalida")]
	private DateEdit _DEHoraSalida;

	[AccessedThroughProperty("CheckSalida")]
	private CheckEdit _CheckSalida;

	public int idEmpleado;

	private byte[] img;

	private RRHHClass objClassRRHH;

	private int idHorario;

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

	public FrmAsistenciaManual()
	{
		base.Load += FrmAsistenciaManual_Load;
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
		DevExpress.Utils.SerializableAppearanceObject appearance = new DevExpress.Utils.SerializableAppearanceObject();
		DevExpress.Utils.SuperToolTip superToolTip = new DevExpress.Utils.SuperToolTip();
		DevExpress.Utils.ToolTipTitleItem toolTipTitleItem = new DevExpress.Utils.ToolTipTitleItem();
		DevExpress.Utils.ToolTipItem toolTipItem = new DevExpress.Utils.ToolTipItem();
		DevExpress.Utils.SerializableAppearanceObject appearance2 = new DevExpress.Utils.SerializableAppearanceObject();
		DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
		DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
		DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
		DevExpress.Utils.SerializableAppearanceObject appearance3 = new DevExpress.Utils.SerializableAppearanceObject();
		this.BtnGrabar = new System.Windows.Forms.Button();
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
		this.CheckSalida = new DevExpress.XtraEditors.CheckEdit();
		this.CheckIngreso = new DevExpress.XtraEditors.CheckEdit();
		this.DEHoraSalida = new DevExpress.XtraEditors.DateEdit();
		this.DEHoraIngreso = new DevExpress.XtraEditors.DateEdit();
		this.DEFecha = new DevExpress.XtraEditors.DateEdit();
		this.Label2 = new System.Windows.Forms.Label();
		this.DefaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
		((System.ComponentModel.ISupportInitialize)this.GroupControl1).BeginInit();
		this.GroupControl1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.GroupControl2).BeginInit();
		this.GroupControl2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.CheckSalida.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.CheckIngreso.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.DEHoraSalida.Properties.VistaTimeProperties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.DEHoraSalida.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.DEHoraIngreso.Properties.VistaTimeProperties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.DEHoraIngreso.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.DEFecha.Properties.VistaTimeProperties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.DEFecha.Properties).BeginInit();
		this.SuspendLayout();
		this.cmdCerrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.cmdCerrar.AutoSize = true;
		this.cmdCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cmdCerrar.FlatAppearance.BorderSize = 0;
		this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.cmdCerrar.Image = RecursosHumanos.My.Resources.Resources._exit;
		System.Windows.Forms.Button button = this.cmdCerrar;
		System.Drawing.Point location = new System.Drawing.Point(427, 305);
		button.Location = location;
		this.cmdCerrar.TabIndex = 4;
		this.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		System.Windows.Forms.Panel panelSup = this.PanelSup;
		System.Drawing.Size size = new System.Drawing.Size(502, 29);
		panelSup.Size = size;
		System.Windows.Forms.Panel panelInf = this.PanelInf;
		location = new System.Drawing.Point(0, 335);
		panelInf.Location = location;
		System.Windows.Forms.Panel panelInf2 = this.PanelInf;
		size = new System.Drawing.Size(502, 27);
		panelInf2.Size = size;
		this.BtnGrabar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.BtnGrabar.AutoSize = true;
		this.BtnGrabar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.BtnGrabar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BtnGrabar.FlatAppearance.BorderSize = 0;
		this.BtnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BtnGrabar.Image = RecursosHumanos.My.Resources.Resources.disk_blue1;
		System.Windows.Forms.Button btnGrabar = this.BtnGrabar;
		location = new System.Drawing.Point(12, 306);
		btnGrabar.Location = location;
		this.BtnGrabar.Name = "BtnGrabar";
		System.Windows.Forms.Button btnGrabar2 = this.BtnGrabar;
		size = new System.Drawing.Size(71, 23);
		btnGrabar2.Size = size;
		this.BtnGrabar.TabIndex = 3;
		this.BtnGrabar.Text = "Guardar";
		this.BtnGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.BtnGrabar.UseVisualStyleBackColor = true;
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
		location = new System.Drawing.Point(12, 45);
		groupControl.Location = location;
		this.GroupControl1.Name = "GroupControl1";
		DevExpress.XtraEditors.GroupControl groupControl2 = this.GroupControl1;
		size = new System.Drawing.Size(474, 133);
		groupControl2.Size = size;
		this.GroupControl1.TabIndex = 0;
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
		this.GroupControl2.Controls.Add(this.CheckSalida);
		this.GroupControl2.Controls.Add(this.CheckIngreso);
		this.GroupControl2.Controls.Add(this.DEHoraSalida);
		this.GroupControl2.Controls.Add(this.DEHoraIngreso);
		this.GroupControl2.Controls.Add(this.DEFecha);
		this.GroupControl2.Controls.Add(this.Label2);
		DevExpress.XtraEditors.GroupControl groupControl3 = this.GroupControl2;
		location = new System.Drawing.Point(12, 184);
		groupControl3.Location = location;
		this.GroupControl2.Name = "GroupControl2";
		DevExpress.XtraEditors.GroupControl groupControl4 = this.GroupControl2;
		size = new System.Drawing.Size(474, 104);
		groupControl4.Size = size;
		this.GroupControl2.TabIndex = 1;
		this.GroupControl2.Text = "Datos Marcacion";
		DevExpress.XtraEditors.CheckEdit checkSalida = this.CheckSalida;
		location = new System.Drawing.Point(234, 59);
		checkSalida.Location = location;
		this.CheckSalida.Name = "CheckSalida";
		this.CheckSalida.Properties.Caption = "Hora de Salida:";
		DevExpress.XtraEditors.CheckEdit checkSalida2 = this.CheckSalida;
		size = new System.Drawing.Size(101, 18);
		checkSalida2.Size = size;
		this.CheckSalida.TabIndex = 3;
		this.CheckIngreso.AutoSizeInLayoutControl = true;
		DevExpress.XtraEditors.CheckEdit checkIngreso = this.CheckIngreso;
		location = new System.Drawing.Point(28, 59);
		checkIngreso.Location = location;
		this.CheckIngreso.Name = "CheckIngreso";
		this.CheckIngreso.Properties.Caption = "Hora de Ingreso :";
		DevExpress.XtraEditors.CheckEdit checkIngreso2 = this.CheckIngreso;
		size = new System.Drawing.Size(111, 18);
		checkIngreso2.Size = size;
		this.CheckIngreso.TabIndex = 1;
		this.DEHoraSalida.EditValue = null;
		this.DEHoraSalida.Enabled = false;
		DevExpress.XtraEditors.DateEdit dEHoraSalida = this.DEHoraSalida;
		location = new System.Drawing.Point(336, 58);
		dEHoraSalida.Location = location;
		this.DEHoraSalida.Name = "DEHoraSalida";
		this.DEHoraSalida.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), appearance, "", null, null, false)
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
		toolTipTitleItem.Appearance.Image = RecursosHumanos.My.Resources.Resources.help2;
		toolTipTitleItem.Appearance.Options.UseImage = true;
		toolTipTitleItem.Image = RecursosHumanos.My.Resources.Resources.help2;
		toolTipTitleItem.Text = "Ayuda";
		toolTipItem.LeftIndent = 6;
		toolTipItem.Text = "Ingrese la Hora de Ingreso del Empleado";
		superToolTip.Items.Add(toolTipTitleItem);
		superToolTip.Items.Add(toolTipItem);
		this.DEHoraSalida.SuperTip = superToolTip;
		this.DEHoraSalida.TabIndex = 4;
		this.DEHoraIngreso.EditValue = null;
		this.DEHoraIngreso.Enabled = false;
		DevExpress.XtraEditors.DateEdit dEHoraIngreso = this.DEHoraIngreso;
		location = new System.Drawing.Point(139, 58);
		dEHoraIngreso.Location = location;
		this.DEHoraIngreso.Name = "DEHoraIngreso";
		this.DEHoraIngreso.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), appearance2, "", null, null, false)
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
		toolTipTitleItem2.Appearance.Image = RecursosHumanos.My.Resources.Resources.help2;
		toolTipTitleItem2.Appearance.Options.UseImage = true;
		toolTipTitleItem2.Image = RecursosHumanos.My.Resources.Resources.help2;
		toolTipTitleItem2.Text = "Ayuda";
		toolTipItem2.LeftIndent = 6;
		toolTipItem2.Text = "Ingrese la Hora de Ingreso del Empleado";
		superToolTip2.Items.Add(toolTipTitleItem2);
		superToolTip2.Items.Add(toolTipItem2);
		this.DEHoraIngreso.SuperTip = superToolTip2;
		this.DEHoraIngreso.TabIndex = 2;
		DevExpress.XtraEditors.DateEdit dEFecha = this.DEFecha;
		System.DateTime dateTime = new System.DateTime(0L);
		dEFecha.EditValue = dateTime;
		DevExpress.XtraEditors.DateEdit dEFecha2 = this.DEFecha;
		location = new System.Drawing.Point(65, 30);
		dEFecha2.Location = location;
		this.DEFecha.Name = "DEFecha";
		this.DEFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, true, true, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), appearance3, "", null, null, false)
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
		size = new System.Drawing.Size(189, 20);
		dEFecha3.Size = size;
		this.DEFecha.TabIndex = 0;
		this.Label2.AutoSize = true;
		System.Windows.Forms.Label label9 = this.Label2;
		location = new System.Drawing.Point(19, 33);
		label9.Location = location;
		this.Label2.Name = "Label2";
		System.Windows.Forms.Label label10 = this.Label2;
		size = new System.Drawing.Size(40, 13);
		label10.Size = size;
		this.Label2.TabIndex = 0;
		this.Label2.Text = "Fecha:";
		this.DefaultLookAndFeel1.LookAndFeel.UseWindowsXPTheme = true;
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		size = new System.Drawing.Size(502, 362);
		this.ClientSize = size;
		this.Controls.Add(this.GroupControl2);
		this.Controls.Add(this.GroupControl1);
		this.Controls.Add(this.BtnGrabar);
		this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
		this.MessageShow = true;
		this.Name = "FrmAsistenciaManual";
		this.TitleMsg = "FrmConsulta";
		this.Titulo = "Ingresar Asistencia Manual";
		this.VerCmdCerrar = true;
		this.Controls.SetChildIndex(this.cmdCerrar, 0);
		this.Controls.SetChildIndex(this.PanelSup, 0);
		this.Controls.SetChildIndex(this.PanelInf, 0);
		this.Controls.SetChildIndex(this.BtnGrabar, 0);
		this.Controls.SetChildIndex(this.GroupControl1, 0);
		this.Controls.SetChildIndex(this.GroupControl2, 0);
		((System.ComponentModel.ISupportInitialize)this.GroupControl1).EndInit();
		this.GroupControl1.ResumeLayout(false);
		this.GroupControl1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.GroupControl2).EndInit();
		this.GroupControl2.ResumeLayout(false);
		this.GroupControl2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.CheckSalida.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.CheckIngreso.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.DEHoraSalida.Properties.VistaTimeProperties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.DEHoraSalida.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.DEHoraIngreso.Properties.VistaTimeProperties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.DEHoraIngreso.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.DEFecha.Properties.VistaTimeProperties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.DEFecha.Properties).EndInit();
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	private void FrmAsistenciaManual_Load(object sender, EventArgs e)
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
		DEFecha.DateTime = DateAndTime.Today;
	}

	private void CheckIngreso_CheckedChanged(object sender, EventArgs e)
	{
		if (CheckIngreso.CheckState == CheckState.Checked)
		{
			DEHoraIngreso.Enabled = true;
			DEHoraIngreso.Focus();
		}
		else
		{
			DEHoraIngreso.Enabled = false;
		}
	}

	private void CheckSalida_CheckedChanged(object sender, EventArgs e)
	{
		if (CheckSalida.CheckState == CheckState.Checked)
		{
			DEHoraSalida.Enabled = true;
			DEHoraSalida.Focus();
		}
		else
		{
			DEHoraSalida.Enabled = false;
		}
	}

	private void BtnGrabar_Click(object sender, EventArgs e)
	{
		if ((CheckIngreso.CheckState == CheckState.Unchecked) & (CheckSalida.CheckState == CheckState.Unchecked))
		{
			MessageBox.Show("Debe Ingresar una hora de Entrada o Salida", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		string fecha = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(DEFecha.DateTime.Year.ToString(), Interaction.IIf(DEFecha.DateTime.Month.ToString().Length == 1, "0" + DEFecha.DateTime.Month, DEFecha.DateTime.Month.ToString())), Interaction.IIf(DEFecha.DateTime.Day.ToString().Length == 1, "0" + DEFecha.DateTime.Day, DEFecha.DateTime.Day.ToString())));
		DataTable dataTable = objClassRRHH.spRRHH_GetAsistenciaDia(idEmpleado, fecha);
		Horario horario = HorarioMapper.Instance().SelectBy([SpecialName] (Horario v) => v.idHorario == idHorario).Single();
		if (CheckIngreso.CheckState == CheckState.Checked && DateTime.Compare(Conversions.ToDate(DEHoraIngreso.Text), Conversions.ToDate(horario.Ingreso1).AddMinutes(15.0)) > 0)
		{
			MessageBox.Show("La hora de ingreso no puede ser mayor, a la del horario asignado", "Error!");
			return;
		}
		Asistencia asistencia = new Asistencia();
		asistencia.IdEmpleado = idEmpleado;
		asistencia.Fecha = Conversions.ToDate(DEFecha.DateTime.ToShortDateString());
		if (CheckIngreso.CheckState == CheckState.Checked)
		{
			asistencia.Hor_Ent = DEHoraIngreso.Text.ToString();
			asistencia.Flag_Ent = true;
			DEFecha.Properties.EditMask = "dd/MM/yyyy";
			Marcacion marcacion = new Marcacion();
			marcacion.IdEmpleado = idEmpleado;
			string value = DEFecha.Text + " " + DEHoraIngreso.Text.ToString();
			marcacion.Fecha = Convert.ToDateTime(value);
			marcacion.Estado = "1M";
			if (dataTable.Rows.Count == 0)
			{
				MarcacionMapper.Instance().Insert(marcacion);
			}
			DEFecha.Properties.EditMask = "D";
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
			asistencia.Flag_Ent = false;
		}
		if (CheckSalida.CheckState == CheckState.Checked)
		{
			asistencia.Hor_Sal = DEHoraSalida.Text.ToString();
			asistencia.Flag_Sal = true;
			DEFecha.Properties.EditMask = "dd/MM/yyyy";
			Marcacion marcacion2 = new Marcacion();
			marcacion2.IdEmpleado = idEmpleado;
			string value2 = DEFecha.Text + " " + DEHoraSalida.Text.ToString();
			marcacion2.Fecha = Convert.ToDateTime(value2);
			marcacion2.Estado = "4M";
			if (dataTable.Rows.Count == 0)
			{
				MarcacionMapper.Instance().Insert(marcacion2);
			}
			DEFecha.Properties.EditMask = "D";
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
			asistencia.Flag_Sal = false;
		}
		asistencia.Alm_Ent = "00:00:00";
		asistencia.Alm_Sal = "00:00:00";
		asistencia.idHorario = idHorario;
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

	private void DEFecha_EditValueChanged(object sender, EventArgs e)
	{
		if (Operators.CompareString(DEFecha.DateTime.ToShortDateString(), "01/01/0001", TextCompare: false) != 0)
		{
			string fecha = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(DEFecha.DateTime.Year.ToString(), Interaction.IIf(DEFecha.DateTime.Month.ToString().Length == 1, "0" + DEFecha.DateTime.Month, DEFecha.DateTime.Month.ToString())), Interaction.IIf(DEFecha.DateTime.Day.ToString().Length == 1, "0" + DEFecha.DateTime.Day, DEFecha.DateTime.Day.ToString())));
			DataTable dataTable = objClassRRHH.spRRHH_GetAsistenciaDia(idEmpleado, fecha);
			if (dataTable.Rows.Count == 1)
			{
				DEHoraIngreso.Text = dataTable.Rows[0]["Hor_Ent"].ToString();
				DEHoraSalida.Text = dataTable.Rows[0]["Hor_Sal"].ToString();
			}
			else
			{
				DEHoraIngreso.Text = "";
				DEHoraSalida.Text = "";
			}
		}
	}
}
