using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ClassRRHH;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using GRLL.Common;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using RecursosHumanos.My;
using RecursosHumanos.My.Resources;

namespace RecursosHumanos;

[DesignerGenerated]
public class FrmConsultaHorarioEsp : FrmConsulta
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

	[AccessedThroughProperty("GridControl1")]
	private GridControl _GridControl1;

	[AccessedThroughProperty("GridView1")]
	private GridView _GridView1;

	[AccessedThroughProperty("GridColumn3")]
	private GridColumn _GridColumn3;

	[AccessedThroughProperty("GridColumn4")]
	private GridColumn _GridColumn4;

	[AccessedThroughProperty("GridColumn5")]
	private GridColumn _GridColumn5;

	[AccessedThroughProperty("GridColumn10")]
	private GridColumn _GridColumn10;

	[AccessedThroughProperty("GridColumn11")]
	private GridColumn _GridColumn11;

	[AccessedThroughProperty("GridColumn12")]
	private GridColumn _GridColumn12;

	[AccessedThroughProperty("GridColumn13")]
	private GridColumn _GridColumn13;

	[AccessedThroughProperty("BtnEliminar")]
	private Button _BtnEliminar;

	[AccessedThroughProperty("BtnModificar")]
	private Button _BtnModificar;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("DefaultLookAndFeel1")]
	private DefaultLookAndFeel _DefaultLookAndFeel1;

	[AccessedThroughProperty("GridColumn2")]
	private GridColumn _GridColumn2;

	[AccessedThroughProperty("GridColumn1")]
	private GridColumn _GridColumn1;

	public int idEmpleado;

	private byte[] img;

	private RRHHClass objClassRRHH;

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

	internal GridControl GridControl1
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridControl1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridControl1 = value;
		}
	}

	internal GridView GridView1
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridView1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridView1 = value;
		}
	}

	internal GridColumn GridColumn3
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn3 = value;
		}
	}

	internal GridColumn GridColumn4
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn4 = value;
		}
	}

	internal GridColumn GridColumn5
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn5 = value;
		}
	}

	internal GridColumn GridColumn10
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn10 = value;
		}
	}

	internal GridColumn GridColumn11
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn11 = value;
		}
	}

	internal GridColumn GridColumn12
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn12 = value;
		}
	}

	internal GridColumn GridColumn13
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn13 = value;
		}
	}

	internal Button BtnEliminar
	{
		[DebuggerNonUserCode]
		get
		{
			return _BtnEliminar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = BtnEliminar_Click;
			if (_BtnEliminar != null)
			{
				_BtnEliminar.Click -= value2;
			}
			_BtnEliminar = value;
			if (_BtnEliminar != null)
			{
				_BtnEliminar.Click += value2;
			}
		}
	}

	internal Button BtnModificar
	{
		[DebuggerNonUserCode]
		get
		{
			return _BtnModificar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = BtnModificar_Click;
			if (_BtnModificar != null)
			{
				_BtnModificar.Click -= value2;
			}
			_BtnModificar = value;
			if (_BtnModificar != null)
			{
				_BtnModificar.Click += value2;
			}
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

	internal Button Button2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = Button2_Click;
			if (_Button2 != null)
			{
				_Button2.Click -= value2;
			}
			_Button2 = value;
			if (_Button2 != null)
			{
				_Button2.Click += value2;
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

	internal GridColumn GridColumn2
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn2 = value;
		}
	}

	internal GridColumn GridColumn1
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn1 = value;
		}
	}

	public FrmConsultaHorarioEsp()
	{
		base.Load += FrmConsultaHorarioEsp_Load;
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
		this.GridControl1 = new DevExpress.XtraGrid.GridControl();
		this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.GridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.BtnEliminar = new System.Windows.Forms.Button();
		this.BtnModificar = new System.Windows.Forms.Button();
		this.Button1 = new System.Windows.Forms.Button();
		this.Button2 = new System.Windows.Forms.Button();
		this.DefaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
		((System.ComponentModel.ISupportInitialize)this.GroupControl1).BeginInit();
		this.GroupControl1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.GridControl1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GridView1).BeginInit();
		this.SuspendLayout();
		this.cmdCerrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.cmdCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cmdCerrar.FlatAppearance.BorderSize = 0;
		this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.cmdCerrar.Image = RecursosHumanos.My.Resources.Resources._exit;
		System.Windows.Forms.Button button = this.cmdCerrar;
		System.Drawing.Point location = new System.Drawing.Point(710, 424);
		button.Location = location;
		this.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		System.Windows.Forms.Panel panelSup = this.PanelSup;
		System.Drawing.Size size = new System.Drawing.Size(785, 29);
		panelSup.Size = size;
		System.Windows.Forms.Panel panelInf = this.PanelInf;
		location = new System.Drawing.Point(0, 468);
		panelInf.Location = location;
		System.Windows.Forms.Panel panelInf2 = this.PanelInf;
		size = new System.Drawing.Size(785, 27);
		panelInf2.Size = size;
		this.GroupControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
		location = new System.Drawing.Point(121, 35);
		groupControl.Location = location;
		this.GroupControl1.Name = "GroupControl1";
		DevExpress.XtraEditors.GroupControl groupControl2 = this.GroupControl1;
		size = new System.Drawing.Size(543, 166);
		groupControl2.Size = size;
		this.GroupControl1.TabIndex = 3;
		this.GroupControl1.Text = "Datos Empleado";
		this.UcTxtNDoc.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtNDoc.Formato = null;
		this.UcTxtNDoc.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtNDoc = this.UcTxtNDoc;
		location = new System.Drawing.Point(105, 41);
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
		location = new System.Drawing.Point(47, 118);
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
		location = new System.Drawing.Point(105, 67);
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
		location = new System.Drawing.Point(105, 115);
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
		size = new System.Drawing.Size(279, 20);
		ucTxtNombres2.Size = size;
		this.UcTxtNombres.TabIndex = 4;
		this.UcTxtNombres.TabNextControl = false;
		this.UcTxtNombres.Tipo = GRLL.Common.ucTextBox.TipoDato.SoloLetras;
		this.UcTxtApeMater.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtApeMater.Formato = null;
		this.UcTxtApeMater.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtApeMater = this.UcTxtApeMater;
		location = new System.Drawing.Point(105, 91);
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
		location = new System.Drawing.Point(53, 44);
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
		location = new System.Drawing.Point(390, 23);
		ucFoto.Location = location;
		this.UcFoto.Name = "UcFoto";
		GRLL.Common.ucFoto ucFoto2 = this.UcFoto;
		size = new System.Drawing.Size(134, 132);
		ucFoto2.Size = size;
		this.UcFoto.TabIndex = 5;
		this.UcFoto.VerAjuste = false;
		this.UcFoto.VerControles = false;
		this.Label4.AutoSize = true;
		System.Windows.Forms.Label label5 = this.Label4;
		location = new System.Drawing.Point(12, 94);
		label5.Location = location;
		this.Label4.Name = "Label4";
		System.Windows.Forms.Label label6 = this.Label4;
		size = new System.Drawing.Size(89, 13);
		label6.Size = size;
		this.Label4.TabIndex = 45;
		this.Label4.Text = "Apellido Materno:";
		this.Label3.AutoSize = true;
		System.Windows.Forms.Label label7 = this.Label3;
		location = new System.Drawing.Point(12, 70);
		label7.Location = location;
		this.Label3.Name = "Label3";
		System.Windows.Forms.Label label8 = this.Label3;
		size = new System.Drawing.Size(87, 13);
		label8.Size = size;
		this.Label3.TabIndex = 44;
		this.Label3.Text = "Apellido Paterno:";
		this.GridControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		DevExpress.XtraGrid.GridControl gridControl = this.GridControl1;
		location = new System.Drawing.Point(12, 207);
		gridControl.Location = location;
		this.GridControl1.MainView = this.GridView1;
		this.GridControl1.Name = "GridControl1";
		DevExpress.XtraGrid.GridControl gridControl2 = this.GridControl1;
		size = new System.Drawing.Size(761, 202);
		gridControl2.Size = size;
		this.GridControl1.TabIndex = 4;
		this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[1] { this.GridView1 });
		this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[9] { this.GridColumn3, this.GridColumn4, this.GridColumn5, this.GridColumn10, this.GridColumn2, this.GridColumn1, this.GridColumn11, this.GridColumn12, this.GridColumn13 });
		this.GridView1.GridControl = this.GridControl1;
		this.GridView1.Name = "GridView1";
		this.GridView1.OptionsBehavior.Editable = false;
		this.GridView1.OptionsCustomization.AllowColumnMoving = false;
		this.GridView1.OptionsCustomization.AllowFilter = false;
		this.GridView1.OptionsCustomization.AllowGroup = false;
		this.GridView1.OptionsPrint.AutoWidth = false;
		this.GridView1.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem;
		this.GridView1.OptionsView.ColumnAutoWidth = false;
		this.GridView1.OptionsView.EnableAppearanceEvenRow = true;
		this.GridView1.OptionsView.ShowGroupPanel = false;
		this.GridColumn3.Caption = "Nro";
		this.GridColumn3.FieldName = "N";
		this.GridColumn3.Name = "GridColumn3";
		this.GridColumn4.Caption = "Fecha Inicio";
		this.GridColumn4.FieldName = "FechaInicio";
		this.GridColumn4.Name = "GridColumn4";
		this.GridColumn4.Visible = true;
		this.GridColumn4.VisibleIndex = 0;
		this.GridColumn5.Caption = "Fecha Fin";
		this.GridColumn5.FieldName = "FechaFin";
		this.GridColumn5.Name = "GridColumn5";
		this.GridColumn5.Visible = true;
		this.GridColumn5.VisibleIndex = 1;
		this.GridColumn10.Caption = "Horario";
		this.GridColumn10.FieldName = "Descrip_Horario";
		this.GridColumn10.Name = "GridColumn10";
		this.GridColumn10.Visible = true;
		this.GridColumn10.VisibleIndex = 2;
		this.GridColumn10.Width = 120;
		this.GridColumn2.Caption = "Ingreso";
		this.GridColumn2.FieldName = "Ingreso1";
		this.GridColumn2.Name = "GridColumn2";
		this.GridColumn2.Visible = true;
		this.GridColumn2.VisibleIndex = 3;
		this.GridColumn1.Caption = "Salida";
		this.GridColumn1.FieldName = "Salida2";
		this.GridColumn1.Name = "GridColumn1";
		this.GridColumn1.Visible = true;
		this.GridColumn1.VisibleIndex = 4;
		this.GridColumn11.Caption = "Nro Documento";
		this.GridColumn11.FieldName = "NroDocumento";
		this.GridColumn11.Name = "GridColumn11";
		this.GridColumn11.Visible = true;
		this.GridColumn11.VisibleIndex = 5;
		this.GridColumn11.Width = 150;
		this.GridColumn12.Caption = "SISGEDO";
		this.GridColumn12.FieldName = "Sisgedo";
		this.GridColumn12.Name = "GridColumn12";
		this.GridColumn12.Visible = true;
		this.GridColumn12.VisibleIndex = 6;
		this.GridColumn13.Caption = "IdEmpleado";
		this.GridColumn13.FieldName = "IdEmpleado";
		this.GridColumn13.Name = "GridColumn13";
		this.BtnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.BtnEliminar.AutoSize = true;
		this.BtnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BtnEliminar.FlatAppearance.BorderSize = 0;
		this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BtnEliminar.Image = RecursosHumanos.My.Resources.Resources.delete2;
		System.Windows.Forms.Button btnEliminar = this.BtnEliminar;
		location = new System.Drawing.Point(169, 425);
		btnEliminar.Location = location;
		this.BtnEliminar.Name = "BtnEliminar";
		System.Windows.Forms.Button btnEliminar2 = this.BtnEliminar;
		size = new System.Drawing.Size(69, 23);
		btnEliminar2.Size = size;
		this.BtnEliminar.TabIndex = 10;
		this.BtnEliminar.Text = "Eliminar";
		this.BtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.BtnEliminar.UseVisualStyleBackColor = true;
		this.BtnModificar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.BtnModificar.AutoSize = true;
		this.BtnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BtnModificar.FlatAppearance.BorderSize = 0;
		this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BtnModificar.Image = RecursosHumanos.My.Resources.Resources.document_edit;
		System.Windows.Forms.Button btnModificar = this.BtnModificar;
		location = new System.Drawing.Point(88, 424);
		btnModificar.Location = location;
		this.BtnModificar.Name = "BtnModificar";
		System.Windows.Forms.Button btnModificar2 = this.BtnModificar;
		size = new System.Drawing.Size(78, 25);
		btnModificar2.Size = size;
		this.BtnModificar.TabIndex = 9;
		this.BtnModificar.Text = "Modificar";
		this.BtnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.BtnModificar.UseVisualStyleBackColor = true;
		this.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.Button1.AutoSize = true;
		this.Button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.Button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.Button1.FlatAppearance.BorderSize = 0;
		this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button1.Image = RecursosHumanos.My.Resources.Resources.add2;
		System.Windows.Forms.Button button2 = this.Button1;
		location = new System.Drawing.Point(12, 425);
		button2.Location = location;
		this.Button1.Name = "Button1";
		System.Windows.Forms.Button button3 = this.Button1;
		size = new System.Drawing.Size(70, 23);
		button3.Size = size;
		this.Button1.TabIndex = 8;
		this.Button1.Text = "Agregar";
		this.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.Button1.UseVisualStyleBackColor = true;
		this.Button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.Button2.AutoSize = true;
		this.Button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.Button2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.Button2.FlatAppearance.BorderSize = 0;
		this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button2.Image = RecursosHumanos.My.Resources.Resources.document_out;
		System.Windows.Forms.Button button4 = this.Button2;
		location = new System.Drawing.Point(580, 425);
		button4.Location = location;
		this.Button2.Name = "Button2";
		System.Windows.Forms.Button button5 = this.Button2;
		size = new System.Drawing.Size(110, 23);
		button5.Size = size;
		this.Button2.TabIndex = 11;
		this.Button2.Text = "Exportar a Excel";
		this.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.Button2.UseVisualStyleBackColor = true;
		this.DefaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins";
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		size = new System.Drawing.Size(785, 495);
		this.ClientSize = size;
		this.Controls.Add(this.Button2);
		this.Controls.Add(this.BtnEliminar);
		this.Controls.Add(this.BtnModificar);
		this.Controls.Add(this.Button1);
		this.Controls.Add(this.GridControl1);
		this.Controls.Add(this.GroupControl1);
		this.MessageShow = true;
		this.Name = "FrmConsultaHorarioEsp";
		this.TitleMsg = "FrmConsulta";
		this.Titulo = "Horarios Especiales";
		this.TituloFrm = "Horarios Especiales";
		this.VerCmdCerrar = true;
		this.Controls.SetChildIndex(this.PanelSup, 0);
		this.Controls.SetChildIndex(this.PanelInf, 0);
		this.Controls.SetChildIndex(this.cmdCerrar, 0);
		this.Controls.SetChildIndex(this.GroupControl1, 0);
		this.Controls.SetChildIndex(this.GridControl1, 0);
		this.Controls.SetChildIndex(this.Button1, 0);
		this.Controls.SetChildIndex(this.BtnModificar, 0);
		this.Controls.SetChildIndex(this.BtnEliminar, 0);
		this.Controls.SetChildIndex(this.Button2, 0);
		((System.ComponentModel.ISupportInitialize)this.GroupControl1).EndInit();
		this.GroupControl1.ResumeLayout(false);
		this.GroupControl1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.GridControl1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GridView1).EndInit();
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	private void FrmConsultaHorarioEsp_Load(object sender, EventArgs e)
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
		GridControl1.DataSource = RuntimeHelpers.GetObjectValue(objClassRRHH.llena_HorariosTemporales(idEmpleado));
	}

	private void cmdCerrar_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		FrmHorarioEsp frmHorarioEsp = new FrmHorarioEsp();
		frmHorarioEsp.idEmpleado = idEmpleado;
		frmHorarioEsp.Npermiso = 0;
		frmHorarioEsp.ShowDialog();
		if (frmHorarioEsp.DialogResult == DialogResult.OK)
		{
			GridControl1.DataSource = RuntimeHelpers.GetObjectValue(objClassRRHH.llena_HorariosTemporales(idEmpleado));
		}
	}

	private void BtnModificar_Click(object sender, EventArgs e)
	{
		int focusedRowHandle = GridView1.FocusedRowHandle;
		if (Operators.ConditionalCompareObjectEqual(GridView1.GetRowCellValue(focusedRowHandle, "N"), null, TextCompare: false))
		{
			MessageBox.Show("Seleccione un Permiso", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		FrmHorarioEsp frmHorarioEsp = new FrmHorarioEsp();
		frmHorarioEsp.idEmpleado = idEmpleado;
		frmHorarioEsp.Npermiso = Conversions.ToInteger(GridView1.GetRowCellValue(focusedRowHandle, "N"));
		frmHorarioEsp.ShowDialog();
		if (frmHorarioEsp.DialogResult == DialogResult.OK)
		{
			GridControl1.DataSource = RuntimeHelpers.GetObjectValue(objClassRRHH.llena_HorariosTemporales(idEmpleado));
		}
	}

	private void BtnEliminar_Click(object sender, EventArgs e)
	{
		int focusedRowHandle = GridView1.FocusedRowHandle;
		if (Operators.ConditionalCompareObjectEqual(GridView1.GetRowCellValue(focusedRowHandle, "N"), null, TextCompare: false))
		{
			MessageBox.Show("Seleccione un Permiso", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
		else if (MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Desea eliminar el permiso de la fecha: ", GridView1.GetRowCellValue(focusedRowHandle, "FechaInicio")), " al "), GridView1.GetRowCellValue(focusedRowHandle, "FechaFin"))), "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
		{
			if (objClassRRHH.eliminarHorarioTemporal(idEmpleado, Conversions.ToInteger(GridView1.GetRowCellValue(focusedRowHandle, "N"))))
			{
				MessageBox.Show("Se eliminó exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				FrmConsultaHorarioEsp_Load(RuntimeHelpers.GetObjectValue(sender), e);
			}
			else
			{
				MessageBox.Show("Se generó un error durante la operacion, por favor intételo nuevamente mas tarde", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		if (GridView1.RowCount == 0)
		{
			MessageBox.Show("Debe existir como minimo, un registro para exportar", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		XlsExportOptions xlsExportOptions = new XlsExportOptions();
		string text = MyProject.Computer.FileSystem.SpecialDirectories.MyDocuments.ToString();
		string text2 = text + "\\Reporte_AutoGenerado_HorariosTemporales" + Conversions.ToString(DateAndTime.Today.Date.Day) + Conversions.ToString(DateAndTime.Today.Date.Month) + Conversions.ToString(DateAndTime.Today.Date.Year) + DateAndTime.Now.Hour + Conversions.ToString(DateAndTime.Now.Minute) + DateAndTime.Now.Second + Conversions.ToString(DateAndTime.Now.Millisecond) + ".xls";
		xlsExportOptions.SheetName = "Reporte_AutoGenerado_HorariosTemporales_";
		GridControl1.ExportToXls(text2, xlsExportOptions);
		object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Excel.Application"));
		object instance = NewLateBinding.LateGet(objectValue, null, "Workbooks", new object[0], null, null, null);
		object[] array = new object[1] { text2 };
		object[] arguments = array;
		bool[] array2 = new bool[1] { true };
		object obj = NewLateBinding.LateGet(instance, null, "Open", arguments, null, null, array2);
		if (array2[0])
		{
			text2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
		}
		object objectValue2 = RuntimeHelpers.GetObjectValue(obj);
		object objectValue3 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue2, null, "Worksheets", new object[1] { 1 }, null, null, null));
		NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue3, null, "Rows", new object[1] { "1:5" }, null, null, null), null, "insert", new object[0], null, null, null, IgnoreReturn: true);
		NewLateBinding.LateCall(objectValue3, null, "Select", new object[0], null, null, null, IgnoreReturn: true);
		object[] array3 = new object[2] { "A2", null };
		object[] array4 = array3;
		object obj2 = objectValue3;
		object instance2 = obj2;
		array = new object[2];
		object[] array5 = array;
		int num = 2;
		array5[0] = num;
		object[] array6 = array;
		checked
		{
			int num2 = GridView1.Columns.Count - 1;
			array6[1] = num2;
			array4[1] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(instance2, null, "Cells", array, null, null, null));
			object[] array7 = array3;
			object[] arguments2 = array7;
			array2 = new bool[2] { false, true };
			object instance3 = NewLateBinding.LateGet(objectValue3, null, "Range", arguments2, null, null, array2);
			if (array2[1])
			{
				NewLateBinding.LateSetComplex(obj2, null, "Cells", new object[3]
				{
					num,
					num2,
					RuntimeHelpers.GetObjectValue(array7[1])
				}, null, null, OptimisticSet: true, RValueBase: false);
			}
			NewLateBinding.LateCall(instance3, null, "Merge", new object[0], null, null, null, IgnoreReturn: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue3, null, "Cells", new object[2] { 2, 1 }, null, null, null), null, "FormulaR1C1", new object[1] { "Reporte de Horarios Temporales" }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue3, null, "Cells", new object[2] { 2, 1 }, null, null, null), null, "HorizontalAlignment", new object[1] { -4108 }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, null, "Rows", new object[1] { "2:2" }, null, null, null), null, "Font", new object[0], null, null, null), null, "Size", new object[1] { 16 }, null, null, OptimisticSet: false, RValueBase: true);
			array7 = new object[2] { "A3", null };
			object[] array8 = array7;
			obj2 = objectValue3;
			object instance4 = obj2;
			object[] array9 = new object[2];
			object[] array10 = array9;
			num = 3;
			array10[0] = num;
			object[] array11 = array9;
			num2 = GridView1.Columns.Count - 1;
			array11[1] = num2;
			array8[1] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(instance4, null, "Cells", array9, null, null, null));
			array = array7;
			object[] arguments3 = array;
			array2 = new bool[2] { false, true };
			object instance5 = NewLateBinding.LateGet(objectValue3, null, "Range", arguments3, null, null, array2);
			if (array2[1])
			{
				NewLateBinding.LateSetComplex(obj2, null, "Cells", new object[3]
				{
					num,
					num2,
					RuntimeHelpers.GetObjectValue(array[1])
				}, null, null, OptimisticSet: true, RValueBase: false);
			}
			NewLateBinding.LateCall(instance5, null, "Merge", new object[0], null, null, null, IgnoreReturn: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue3, null, "Cells", new object[2] { 3, 1 }, null, null, null), null, "FormulaR1C1", new object[1] { "De: " + UcTxtApePater.Text + " " + UcTxtApeMater.Text + " " + UcTxtNombres.Text }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue3, null, "Cells", new object[2] { 3, 1 }, null, null, null), null, "HorizontalAlignment", new object[1] { -4108 }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateCall(objectValue3, null, "Protect", new object[16]
			{
				"sgti2009", false, true, false, false, true, true, true, false, false,
				false, false, false, true, true, true
			}, null, null, null, IgnoreReturn: true);
			NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, null, "Columns", new object[1] { "A:Z" }, null, null, null), null, "EntireColumn", new object[0], null, null, null), null, "AutoFit", new object[0], null, null, null, IgnoreReturn: true);
			NewLateBinding.LateSet(objectValue, null, "Visible", new object[1] { true }, null, null);
		}
	}
}
