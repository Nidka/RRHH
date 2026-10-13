using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ClassRRHH;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTreeList;
using GRLL.Common;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using RecursosHumanos.My;

namespace RecursosHumanos;

[DesignerGenerated]
public class FrmListaOrganica : FrmConsulta
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("PanelControl1")]
	private PanelControl _PanelControl1;

	[AccessedThroughProperty("SplitterControl1")]
	private SplitterControl _SplitterControl1;

	[AccessedThroughProperty("btn_FichaSocial")]
	private Button _btn_FichaSocial;

	[AccessedThroughProperty("btn_eliminar")]
	private Button _btn_eliminar;

	[AccessedThroughProperty("btn_editar")]
	private Button _btn_editar;

	[AccessedThroughProperty("btn_nuevo")]
	private Button _btn_nuevo;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("lbl_Area")]
	private Label _lbl_Area;

	[AccessedThroughProperty("UcCBPartidaPresupuestal")]
	private ucComboBox _UcCBPartidaPresupuestal;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("BtnImprimir")]
	private Button _BtnImprimir;

	[AccessedThroughProperty("BtnArchivo")]
	private Button _BtnArchivo;

	[AccessedThroughProperty("BtnPermiso")]
	private Button _BtnPermiso;

	[AccessedThroughProperty("TreeList1")]
	private TreeList _TreeList1;

	[AccessedThroughProperty("GridControl1")]
	private GridControl _GridControl1;

	[AccessedThroughProperty("GridView1")]
	private GridView _GridView1;

	[AccessedThroughProperty("GridColumn1")]
	private GridColumn _GridColumn1;

	[AccessedThroughProperty("GridColumn2")]
	private GridColumn _GridColumn2;

	[AccessedThroughProperty("GridColumn3")]
	private GridColumn _GridColumn3;

	[AccessedThroughProperty("GridColumn4")]
	private GridColumn _GridColumn4;

	[AccessedThroughProperty("BtnAsistenciaManual")]
	private Button _BtnAsistenciaManual;

	private RRHHClass objClassRRHH;

	private DataSet ds_structura;

	private bool ban;

	public override Panel PanelSup
	{
		[DebuggerNonUserCode]
		get
		{
			return base.PanelSup;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			PaintEventHandler value2 = PanelSup_Paint;
			if (base.PanelSup != null)
			{
				base.PanelSup.Paint -= value2;
			}
			base.PanelSup = value;
			if (base.PanelSup != null)
			{
				base.PanelSup.Paint += value2;
			}
		}
	}

	internal PanelControl PanelControl1
	{
		[DebuggerNonUserCode]
		get
		{
			return _PanelControl1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PanelControl1 = value;
		}
	}

	internal SplitterControl SplitterControl1
	{
		[DebuggerNonUserCode]
		get
		{
			return _SplitterControl1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SplitterControl1 = value;
		}
	}

	internal Button btn_FichaSocial
	{
		[DebuggerNonUserCode]
		get
		{
			return _btn_FichaSocial;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = btn_FichaSocial_Click;
			if (_btn_FichaSocial != null)
			{
				_btn_FichaSocial.Click -= value2;
			}
			_btn_FichaSocial = value;
			if (_btn_FichaSocial != null)
			{
				_btn_FichaSocial.Click += value2;
			}
		}
	}

	internal Button btn_eliminar
	{
		[DebuggerNonUserCode]
		get
		{
			return _btn_eliminar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = btn_eliminar_Click;
			if (_btn_eliminar != null)
			{
				_btn_eliminar.Click -= value2;
			}
			_btn_eliminar = value;
			if (_btn_eliminar != null)
			{
				_btn_eliminar.Click += value2;
			}
		}
	}

	internal Button btn_editar
	{
		[DebuggerNonUserCode]
		get
		{
			return _btn_editar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = btn_editar_Click;
			if (_btn_editar != null)
			{
				_btn_editar.Click -= value2;
			}
			_btn_editar = value;
			if (_btn_editar != null)
			{
				_btn_editar.Click += value2;
			}
		}
	}

	internal Button btn_nuevo
	{
		[DebuggerNonUserCode]
		get
		{
			return _btn_nuevo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = btn_nuevo_Click;
			if (_btn_nuevo != null)
			{
				_btn_nuevo.Click -= value2;
			}
			_btn_nuevo = value;
			if (_btn_nuevo != null)
			{
				_btn_nuevo.Click += value2;
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

	internal Label lbl_Area
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbl_Area;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbl_Area = value;
		}
	}

	internal ucComboBox UcCBPartidaPresupuestal
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcCBPartidaPresupuestal;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = UcCBPartidaPresupuestal_SelectedIndexChanged;
			if (_UcCBPartidaPresupuestal != null)
			{
				_UcCBPartidaPresupuestal.SelectedIndexChanged -= value2;
			}
			_UcCBPartidaPresupuestal = value;
			if (_UcCBPartidaPresupuestal != null)
			{
				_UcCBPartidaPresupuestal.SelectedIndexChanged += value2;
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

	internal Button BtnImprimir
	{
		[DebuggerNonUserCode]
		get
		{
			return _BtnImprimir;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = BtnImprimir_Click;
			if (_BtnImprimir != null)
			{
				_BtnImprimir.Click -= value2;
			}
			_BtnImprimir = value;
			if (_BtnImprimir != null)
			{
				_BtnImprimir.Click += value2;
			}
		}
	}

	internal Button BtnArchivo
	{
		[DebuggerNonUserCode]
		get
		{
			return _BtnArchivo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = BtnArchivo_Click;
			if (_BtnArchivo != null)
			{
				_BtnArchivo.Click -= value2;
			}
			_BtnArchivo = value;
			if (_BtnArchivo != null)
			{
				_BtnArchivo.Click += value2;
			}
		}
	}

	internal Button BtnPermiso
	{
		[DebuggerNonUserCode]
		get
		{
			return _BtnPermiso;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = Button1_Click;
			if (_BtnPermiso != null)
			{
				_BtnPermiso.Click -= value2;
			}
			_BtnPermiso = value;
			if (_BtnPermiso != null)
			{
				_BtnPermiso.Click += value2;
			}
		}
	}

	private TreeList TreeList1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TreeList1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			FocusedNodeChangedEventHandler value2 = TreeList1_FocusedNodeChanged;
			if (_TreeList1 != null)
			{
				_TreeList1.FocusedNodeChanged -= value2;
			}
			_TreeList1 = value;
			if (_TreeList1 != null)
			{
				_TreeList1.FocusedNodeChanged += value2;
			}
		}
	}

	private GridControl GridControl1
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
			EventHandler value2 = GridControl1_DoubleClick;
			if (_GridControl1 != null)
			{
				_GridControl1.DoubleClick -= value2;
			}
			_GridControl1 = value;
			if (_GridControl1 != null)
			{
				_GridControl1.DoubleClick += value2;
			}
		}
	}

	private GridView GridView1
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

	private GridColumn GridColumn1
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

	private GridColumn GridColumn2
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

	private GridColumn GridColumn3
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

	private GridColumn GridColumn4
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

	internal Button BtnAsistenciaManual
	{
		[DebuggerNonUserCode]
		get
		{
			return _BtnAsistenciaManual;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BtnAsistenciaManual = value;
		}
	}

	public FrmListaOrganica()
	{
		base.Load += FrmListaOrganica_Load;
		__ENCAddToList(this);
		objClassRRHH = new RRHHClass();
		ds_structura = new DataSet();
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecursosHumanos.FrmListaOrganica));
		this.TreeList1 = new DevExpress.XtraTreeList.TreeList();
		this.GridControl1 = new DevExpress.XtraGrid.GridControl();
		this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.GridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.PanelControl1 = new DevExpress.XtraEditors.PanelControl();
		this.SplitterControl1 = new DevExpress.XtraEditors.SplitterControl();
		this.btn_FichaSocial = new System.Windows.Forms.Button();
		this.btn_eliminar = new System.Windows.Forms.Button();
		this.btn_editar = new System.Windows.Forms.Button();
		this.btn_nuevo = new System.Windows.Forms.Button();
		this.Label1 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.lbl_Area = new System.Windows.Forms.Label();
		this.UcCBPartidaPresupuestal = new GRLL.Common.ucComboBox();
		this.Label3 = new System.Windows.Forms.Label();
		this.BtnImprimir = new System.Windows.Forms.Button();
		this.BtnArchivo = new System.Windows.Forms.Button();
		this.BtnPermiso = new System.Windows.Forms.Button();
		this.BtnAsistenciaManual = new System.Windows.Forms.Button();
		((System.ComponentModel.ISupportInitialize)this.TreeList1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GridControl1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GridView1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.PanelControl1).BeginInit();
		this.PanelControl1.SuspendLayout();
		this.SuspendLayout();
		this.cmdCerrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.cmdCerrar.AutoSize = true;
		this.cmdCerrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.cmdCerrar.FlatAppearance.BorderSize = 0;
		this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.cmdCerrar.Image = (System.Drawing.Image)resources.GetObject("cmdCerrar.Image");
		System.Windows.Forms.Button button = this.cmdCerrar;
		System.Drawing.Point location = new System.Drawing.Point(714, 389);
		button.Location = location;
		System.Windows.Forms.Button button2 = this.cmdCerrar;
		System.Drawing.Size size = new System.Drawing.Size(61, 23);
		button2.Size = size;
		this.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.cmdCerrar.Visible = true;
		System.Windows.Forms.Panel panelSup = this.PanelSup;
		size = new System.Drawing.Size(787, 24);
		panelSup.Size = size;
		System.Windows.Forms.Panel panelInf = this.PanelInf;
		location = new System.Drawing.Point(0, 433);
		panelInf.Location = location;
		System.Windows.Forms.Panel panelInf2 = this.PanelInf;
		size = new System.Drawing.Size(787, 27);
		panelInf2.Size = size;
		this.TreeList1.Dock = System.Windows.Forms.DockStyle.Left;
		DevExpress.XtraTreeList.TreeList treeList = this.TreeList1;
		location = new System.Drawing.Point(3, 3);
		treeList.Location = location;
		this.TreeList1.LookAndFeel.SkinName = "Blue";
		this.TreeList1.LookAndFeel.UseDefaultLookAndFeel = false;
		this.TreeList1.Name = "TreeList1";
		this.TreeList1.OptionsBehavior.Editable = false;
		this.TreeList1.OptionsSelection.UseIndicatorForSelection = true;
		this.TreeList1.ParentFieldName = "";
		DevExpress.XtraTreeList.TreeList treeList2 = this.TreeList1;
		size = new System.Drawing.Size(401, 319);
		treeList2.Size = size;
		this.TreeList1.TabIndex = 0;
		this.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
		DevExpress.XtraGrid.GridControl gridControl = this.GridControl1;
		location = new System.Drawing.Point(410, 3);
		gridControl.Location = location;
		this.GridControl1.LookAndFeel.SkinName = "Blue";
		this.GridControl1.LookAndFeel.UseDefaultLookAndFeel = false;
		this.GridControl1.MainView = this.GridView1;
		this.GridControl1.Name = "GridControl1";
		DevExpress.XtraGrid.GridControl gridControl2 = this.GridControl1;
		size = new System.Drawing.Size(352, 319);
		gridControl2.Size = size;
		this.GridControl1.TabIndex = 2;
		this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[1] { this.GridView1 });
		this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[4] { this.GridColumn1, this.GridColumn2, this.GridColumn3, this.GridColumn4 });
		this.GridView1.GridControl = this.GridControl1;
		this.GridView1.Name = "GridView1";
		this.GridView1.OptionsBehavior.Editable = false;
		this.GridView1.OptionsView.ShowGroupPanel = false;
		this.GridColumn1.Caption = "Codigo";
		this.GridColumn1.FieldName = "Codigo";
		this.GridColumn1.Name = "GridColumn1";
		this.GridColumn1.Visible = true;
		this.GridColumn1.VisibleIndex = 0;
		this.GridColumn1.Width = 40;
		this.GridColumn2.Caption = "DNI";
		this.GridColumn2.FieldName = "DNI";
		this.GridColumn2.Name = "GridColumn2";
		this.GridColumn2.Visible = true;
		this.GridColumn2.VisibleIndex = 1;
		this.GridColumn2.Width = 40;
		this.GridColumn3.Caption = "Nombres Completos";
		this.GridColumn3.FieldName = "NombresCompletos";
		this.GridColumn3.Name = "GridColumn3";
		this.GridColumn3.Visible = true;
		this.GridColumn3.VisibleIndex = 2;
		this.GridColumn3.Width = 200;
		this.GridColumn4.Caption = "Cargo";
		this.GridColumn4.FieldName = "Cargo";
		this.GridColumn4.Name = "GridColumn4";
		this.GridColumn4.Width = 162;
		this.PanelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.PanelControl1.Controls.Add(this.GridControl1);
		this.PanelControl1.Controls.Add(this.SplitterControl1);
		this.PanelControl1.Controls.Add(this.TreeList1);
		DevExpress.XtraEditors.PanelControl panelControl = this.PanelControl1;
		location = new System.Drawing.Point(10, 50);
		panelControl.Location = location;
		this.PanelControl1.Name = "PanelControl1";
		DevExpress.XtraEditors.PanelControl panelControl2 = this.PanelControl1;
		size = new System.Drawing.Size(765, 325);
		panelControl2.Size = size;
		this.PanelControl1.TabIndex = 4;
		DevExpress.XtraEditors.SplitterControl splitterControl = this.SplitterControl1;
		location = new System.Drawing.Point(404, 3);
		splitterControl.Location = location;
		this.SplitterControl1.LookAndFeel.SkinName = "Blue";
		this.SplitterControl1.LookAndFeel.UseDefaultLookAndFeel = false;
		this.SplitterControl1.Name = "SplitterControl1";
		DevExpress.XtraEditors.SplitterControl splitterControl2 = this.SplitterControl1;
		size = new System.Drawing.Size(6, 319);
		splitterControl2.Size = size;
		this.SplitterControl1.TabIndex = 3;
		this.SplitterControl1.TabStop = false;
		this.btn_FichaSocial.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.btn_FichaSocial.AutoSize = true;
		this.btn_FichaSocial.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btn_FichaSocial.FlatAppearance.BorderSize = 0;
		this.btn_FichaSocial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btn_FichaSocial.Image = (System.Drawing.Image)resources.GetObject("btn_FichaSocial.Image");
		System.Windows.Forms.Button button3 = this.btn_FichaSocial;
		location = new System.Drawing.Point(154, 381);
		button3.Location = location;
		this.btn_FichaSocial.Name = "btn_FichaSocial";
		System.Windows.Forms.Button button4 = this.btn_FichaSocial;
		size = new System.Drawing.Size(84, 39);
		button4.Size = size;
		this.btn_FichaSocial.TabIndex = 51;
		this.btn_FichaSocial.Text = "Ficha Escalaf.";
		this.btn_FichaSocial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.btn_FichaSocial.UseVisualStyleBackColor = true;
		this.btn_eliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.btn_eliminar.AutoSize = true;
		this.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btn_eliminar.FlatAppearance.BorderSize = 0;
		this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btn_eliminar.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btn_eliminar.Image = (System.Drawing.Image)resources.GetObject("btn_eliminar.Image");
		System.Windows.Forms.Button button5 = this.btn_eliminar;
		location = new System.Drawing.Point(107, 381);
		button5.Location = location;
		this.btn_eliminar.Name = "btn_eliminar";
		System.Windows.Forms.Button button6 = this.btn_eliminar;
		size = new System.Drawing.Size(53, 39);
		button6.Size = size;
		this.btn_eliminar.TabIndex = 50;
		this.btn_eliminar.Text = "Eliminar";
		this.btn_eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.btn_eliminar.UseVisualStyleBackColor = true;
		this.btn_editar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.btn_editar.AutoSize = true;
		this.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.btn_editar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btn_editar.FlatAppearance.BorderSize = 0;
		this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btn_editar.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btn_editar.Image = (System.Drawing.Image)resources.GetObject("btn_editar.Image");
		System.Windows.Forms.Button button7 = this.btn_editar;
		location = new System.Drawing.Point(63, 381);
		button7.Location = location;
		this.btn_editar.Name = "btn_editar";
		System.Windows.Forms.Button button8 = this.btn_editar;
		size = new System.Drawing.Size(45, 39);
		button8.Size = size;
		this.btn_editar.TabIndex = 49;
		this.btn_editar.Text = "Editar";
		this.btn_editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.btn_editar.UseVisualStyleBackColor = true;
		this.btn_nuevo.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.btn_nuevo.AutoSize = true;
		this.btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.btn_nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btn_nuevo.FlatAppearance.BorderSize = 0;
		this.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btn_nuevo.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btn_nuevo.Image = (System.Drawing.Image)resources.GetObject("btn_nuevo.Image");
		System.Windows.Forms.Button button9 = this.btn_nuevo;
		location = new System.Drawing.Point(15, 381);
		button9.Location = location;
		this.btn_nuevo.Name = "btn_nuevo";
		System.Windows.Forms.Button button10 = this.btn_nuevo;
		size = new System.Drawing.Size(48, 39);
		button10.Size = size;
		this.btn_nuevo.TabIndex = 48;
		this.btn_nuevo.Text = "Nuevo";
		this.btn_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.btn_nuevo.UseVisualStyleBackColor = true;
		this.Label1.AutoSize = true;
		System.Windows.Forms.Label label = this.Label1;
		location = new System.Drawing.Point(61, 34);
		label.Location = location;
		this.Label1.Name = "Label1";
		System.Windows.Forms.Label label2 = this.Label1;
		size = new System.Drawing.Size(129, 13);
		label2.Size = size;
		this.Label1.TabIndex = 52;
		this.Label1.Text = "UNIDADES ORGANICAS";
		this.Label2.AutoSize = true;
		System.Windows.Forms.Label label3 = this.Label2;
		location = new System.Drawing.Point(327, 35);
		label3.Location = location;
		this.Label2.Name = "Label2";
		System.Windows.Forms.Label label4 = this.Label2;
		size = new System.Drawing.Size(86, 13);
		label4.Size = size;
		this.Label2.TabIndex = 53;
		this.Label2.Text = "PERSONAL DE:";
		this.lbl_Area.AutoSize = true;
		this.lbl_Area.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.lbl_Area.ForeColor = System.Drawing.Color.Maroon;
		System.Windows.Forms.Label label5 = this.lbl_Area;
		location = new System.Drawing.Point(419, 34);
		label5.Location = location;
		this.lbl_Area.Name = "lbl_Area";
		System.Windows.Forms.Label label6 = this.lbl_Area;
		size = new System.Drawing.Size(13, 13);
		label6.Size = size;
		this.lbl_Area.TabIndex = 54;
		this.lbl_Area.Text = "z";
		this.UcCBPartidaPresupuestal.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.UcCBPartidaPresupuestal.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCBPartidaPresupuestal.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCBPartidaPresupuestal.FormattingEnabled = true;
		this.UcCBPartidaPresupuestal.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucCBPartidaPresupuestal = this.UcCBPartidaPresupuestal;
		location = new System.Drawing.Point(652, 27);
		ucCBPartidaPresupuestal.Location = location;
		this.UcCBPartidaPresupuestal.Name = "UcCBPartidaPresupuestal";
		GRLL.Common.ucComboBox ucCBPartidaPresupuestal2 = this.UcCBPartidaPresupuestal;
		size = new System.Drawing.Size(121, 21);
		ucCBPartidaPresupuestal2.Size = size;
		this.UcCBPartidaPresupuestal.TabIndex = 55;
		this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.Label3.AutoSize = true;
		System.Windows.Forms.Label label7 = this.Label3;
		location = new System.Drawing.Point(539, 34);
		label7.Location = location;
		this.Label3.Name = "Label3";
		System.Windows.Forms.Label label8 = this.Label3;
		size = new System.Drawing.Size(107, 13);
		label8.Size = size;
		this.Label3.TabIndex = 56;
		this.Label3.Text = "Partida Presupuestal:";
		this.BtnImprimir.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.BtnImprimir.AutoSize = true;
		this.BtnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.BtnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BtnImprimir.FlatAppearance.BorderSize = 0;
		this.BtnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BtnImprimir.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.BtnImprimir.Image = (System.Drawing.Image)resources.GetObject("BtnImprimir.Image");
		System.Windows.Forms.Button btnImprimir = this.BtnImprimir;
		location = new System.Drawing.Point(641, 381);
		btnImprimir.Location = location;
		this.BtnImprimir.Name = "BtnImprimir";
		System.Windows.Forms.Button btnImprimir2 = this.BtnImprimir;
		size = new System.Drawing.Size(57, 39);
		btnImprimir2.Size = size;
		this.BtnImprimir.TabIndex = 57;
		this.BtnImprimir.Text = "Imprimir";
		this.BtnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.BtnImprimir.UseVisualStyleBackColor = true;
		this.BtnArchivo.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.BtnArchivo.AutoSize = true;
		this.BtnArchivo.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BtnArchivo.FlatAppearance.BorderSize = 0;
		this.BtnArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BtnArchivo.Image = (System.Drawing.Image)resources.GetObject("BtnArchivo.Image");
		System.Windows.Forms.Button btnArchivo = this.BtnArchivo;
		location = new System.Drawing.Point(232, 381);
		btnArchivo.Location = location;
		this.BtnArchivo.Name = "BtnArchivo";
		System.Windows.Forms.Button btnArchivo2 = this.BtnArchivo;
		size = new System.Drawing.Size(77, 39);
		btnArchivo2.Size = size;
		this.BtnArchivo.TabIndex = 58;
		this.BtnArchivo.Text = "File Personal";
		this.BtnArchivo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.BtnArchivo.UseVisualStyleBackColor = true;
		this.BtnPermiso.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.BtnPermiso.AutoSize = true;
		this.BtnPermiso.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.BtnPermiso.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BtnPermiso.FlatAppearance.BorderSize = 0;
		this.BtnPermiso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BtnPermiso.Image = (System.Drawing.Image)resources.GetObject("BtnPermiso.Image");
		System.Windows.Forms.Button btnPermiso = this.BtnPermiso;
		location = new System.Drawing.Point(315, 381);
		btnPermiso.Location = location;
		this.BtnPermiso.Name = "BtnPermiso";
		System.Windows.Forms.Button btnPermiso2 = this.BtnPermiso;
		size = new System.Drawing.Size(54, 39);
		btnPermiso2.Size = size;
		this.BtnPermiso.TabIndex = 59;
		this.BtnPermiso.Text = "Permiso";
		this.BtnPermiso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.BtnPermiso.UseVisualStyleBackColor = true;
		this.BtnAsistenciaManual.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.BtnAsistenciaManual.AutoSize = true;
		this.BtnAsistenciaManual.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.BtnAsistenciaManual.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BtnAsistenciaManual.FlatAppearance.BorderSize = 0;
		this.BtnAsistenciaManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BtnAsistenciaManual.Image = (System.Drawing.Image)resources.GetObject("BtnAsistenciaManual.Image");
		System.Windows.Forms.Button btnAsistenciaManual = this.BtnAsistenciaManual;
		location = new System.Drawing.Point(366, 381);
		btnAsistenciaManual.Location = location;
		this.BtnAsistenciaManual.Name = "BtnAsistenciaManual";
		System.Windows.Forms.Button btnAsistenciaManual2 = this.BtnAsistenciaManual;
		size = new System.Drawing.Size(103, 39);
		btnAsistenciaManual2.Size = size;
		this.BtnAsistenciaManual.TabIndex = 60;
		this.BtnAsistenciaManual.Text = "Asistencia Manual";
		this.BtnAsistenciaManual.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.BtnAsistenciaManual.UseVisualStyleBackColor = true;
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.Calculadora = false;
		size = new System.Drawing.Size(787, 460);
		this.ClientSize = size;
		this.Controls.Add(this.BtnAsistenciaManual);
		this.Controls.Add(this.BtnPermiso);
		this.Controls.Add(this.BtnArchivo);
		this.Controls.Add(this.BtnImprimir);
		this.Controls.Add(this.Label3);
		this.Controls.Add(this.UcCBPartidaPresupuestal);
		this.Controls.Add(this.lbl_Area);
		this.Controls.Add(this.Label2);
		this.Controls.Add(this.Label1);
		this.Controls.Add(this.btn_FichaSocial);
		this.Controls.Add(this.btn_eliminar);
		this.Controls.Add(this.btn_editar);
		this.Controls.Add(this.btn_nuevo);
		this.Controls.Add(this.PanelControl1);
		this.MessageShow = true;
		this.Name = "FrmListaOrganica";
		this.TitleMsg = "FrmConsulta";
		this.Titulo = "Relación de Personal";
		this.VerCmdCerrar = true;
		this.Controls.SetChildIndex(this.cmdCerrar, 0);
		this.Controls.SetChildIndex(this.PanelControl1, 0);
		this.Controls.SetChildIndex(this.PanelSup, 0);
		this.Controls.SetChildIndex(this.PanelInf, 0);
		this.Controls.SetChildIndex(this.btn_nuevo, 0);
		this.Controls.SetChildIndex(this.btn_editar, 0);
		this.Controls.SetChildIndex(this.btn_eliminar, 0);
		this.Controls.SetChildIndex(this.btn_FichaSocial, 0);
		this.Controls.SetChildIndex(this.Label1, 0);
		this.Controls.SetChildIndex(this.Label2, 0);
		this.Controls.SetChildIndex(this.lbl_Area, 0);
		this.Controls.SetChildIndex(this.UcCBPartidaPresupuestal, 0);
		this.Controls.SetChildIndex(this.Label3, 0);
		this.Controls.SetChildIndex(this.BtnImprimir, 0);
		this.Controls.SetChildIndex(this.BtnArchivo, 0);
		this.Controls.SetChildIndex(this.BtnPermiso, 0);
		this.Controls.SetChildIndex(this.BtnAsistenciaManual, 0);
		((System.ComponentModel.ISupportInitialize)this.TreeList1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GridControl1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GridView1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.PanelControl1).EndInit();
		this.PanelControl1.ResumeLayout(false);
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	private void FrmListaOrganica_Load(object sender, EventArgs e)
	{
		if (RRHH.Bienestar)
		{
			btn_FichaSocial.Text = "Ficha Social";
			BtnArchivo.Visible = false;
			btn_nuevo.Visible = false;
			btn_editar.Visible = false;
			btn_eliminar.Visible = false;
			BtnArchivo.Enabled = false;
			btn_nuevo.Enabled = false;
			btn_editar.Enabled = false;
			btn_eliminar.Enabled = false;
			BtnAsistenciaManual.Visible = false;
			BtnPermiso.Visible = false;
			Button button = btn_FichaSocial;
			Point location = new Point(15, checked(Height - 113));
			button.Location = location;
		}
		else if (RRHH.Asistencias)
		{
			BtnArchivo.Enabled = false;
			btn_nuevo.Enabled = false;
			btn_editar.Enabled = false;
			btn_eliminar.Enabled = false;
			btn_FichaSocial.Enabled = false;
			BtnImprimir.Enabled = false;
		}
		else if ((Conversions.ToDouble(RRHH.IdROl) == 4.0) | (Conversions.ToDouble(RRHH.IdROl) == 3.0))
		{
			BtnAsistenciaManual.Enabled = false;
			BtnPermiso.Enabled = false;
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 15.0)
		{
			BtnPermiso.Visible = false;
			BtnAsistenciaManual.Visible = false;
		}
		ban = false;
		WindowState = FormWindowState.Maximized;
		TreeList1.DataSource = RuntimeHelpers.GetObjectValue(objClassRRHH.llena_tree());
		TreeList1.ParentFieldName = "Hijo";
		TreeList1.KeyFieldName = "Padre";
		UcCBPartidaPresupuestal.ValueMember = "IdTipoTrabajador";
		UcCBPartidaPresupuestal.DisplayMember = "Descripcion";
		if (Conversions.ToDouble(RRHH.IdROl) == 10.0)
		{
			List<TipoTrabajador> dataSource = TipoTrabajadorMapper.Instance().SelectAll();
			UcCBPartidaPresupuestal.DataSource = dataSource;
			UcCBPartidaPresupuestal.SelectedValue = 1;
			UcCBPartidaPresupuestal.Enabled = false;
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 14.0)
		{
			List<TipoTrabajador> dataSource2 = TipoTrabajadorMapper.Instance().SelectAll();
			UcCBPartidaPresupuestal.DataSource = dataSource2;
			UcCBPartidaPresupuestal.SelectedValue = 2;
			UcCBPartidaPresupuestal.Enabled = false;
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 13.0)
		{
			List<TipoTrabajador> list = TipoTrabajadorMapper.Instance().SelectAll();
			list.Insert(0, new TipoTrabajador
			{
				IdTipoTrabajador = 0,
				Descripcion = "Todos"
			});
			UcCBPartidaPresupuestal.DataSource = list;
			UcCBPartidaPresupuestal.Enabled = true;
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 4.0)
		{
			List<TipoTrabajador> dataSource3 = TipoTrabajadorMapper.Instance().SelectBy([SpecialName] (TipoTrabajador C) => (C.IdTipoTrabajador == 1) | (C.IdTipoTrabajador == 3) | (C.IdTipoTrabajador == 4) | (C.IdTipoTrabajador == 5));
			UcCBPartidaPresupuestal.DataSource = dataSource3;
			UcCBPartidaPresupuestal.Enabled = true;
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 3.0)
		{
			List<TipoTrabajador> dataSource4 = TipoTrabajadorMapper.Instance().SelectBy([SpecialName] (TipoTrabajador C) => C.IdTipoTrabajador == 2);
			UcCBPartidaPresupuestal.DataSource = dataSource4;
			UcCBPartidaPresupuestal.SelectedValue = RRHH.Partida;
		}
		TreeListOperationCollapseExpandToLevel operation = new TreeListOperationCollapseExpandToLevel(expand: true, 0);
		TreeList1.NodesIterator.DoOperation(operation);
		TreeListOperationCollapseExpandToLevel operation2 = new TreeListOperationCollapseExpandToLevel(expand: true, 1);
		TreeList1.NodesIterator.DoOperation(operation2);
		TreeListOperationCollapseExpandToLevel operation3 = new TreeListOperationCollapseExpandToLevel(expand: true, 2);
		TreeList1.NodesIterator.DoOperation(operation3);
	}

	private void TreeList1_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
	{
		llenar_grid();
	}

	private void GridControl1_DoubleClick(object sender, EventArgs e)
	{
		if (!(RRHH.Bienestar | RRHH.Asistencias))
		{
			FrmMantEmpleado_Basico frmMantEmpleado_Basico = new FrmMantEmpleado_Basico();
			int focusedRowHandle = GridView1.FocusedRowHandle;
			objClassRRHH.CodigoEmpleado = Conversions.ToInteger(GridView1.GetRowCellValue(focusedRowHandle, "Codigo"));
			frmMantEmpleado_Basico.MantEmpleado_Basico_Cod = objClassRRHH.CodigoEmpleado;
			if (objClassRRHH.CodigoEmpleado == 0)
			{
				MessageBox.Show("Seleccione un Empleado", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			frmMantEmpleado_Basico.Titulo = "Edición Datos Basicos del Empleado";
			frmMantEmpleado_Basico.ShowDialog();
		}
	}

	private void btn_nuevo_Click(object sender, EventArgs e)
	{
		FrmMantEmpleado_Basico frmMantEmpleado_Basico = new FrmMantEmpleado_Basico();
		frmMantEmpleado_Basico.ShowDialog();
		if (frmMantEmpleado_Basico.DialogResult == DialogResult.OK)
		{
			llenar_grid();
		}
	}

	private void btn_editar_Click(object sender, EventArgs e)
	{
		FrmMantEmpleado_Basico frmMantEmpleado_Basico = new FrmMantEmpleado_Basico();
		int focusedRowHandle = GridView1.FocusedRowHandle;
		objClassRRHH.CodigoEmpleado = Conversions.ToInteger(GridView1.GetRowCellValue(focusedRowHandle, "Codigo"));
		frmMantEmpleado_Basico.MantEmpleado_Basico_Cod = objClassRRHH.CodigoEmpleado;
		if (objClassRRHH.CodigoEmpleado == 0)
		{
			Interaction.MsgBox("Seleccione un Empleado");
		}
		else
		{
			frmMantEmpleado_Basico.Titulo = "Edición Datos Basicos del Empleado";
			frmMantEmpleado_Basico.ShowDialog();
		}
		if (frmMantEmpleado_Basico.DialogResult == DialogResult.OK)
		{
			llenar_grid();
		}
	}

	private void btn_eliminar_Click(object sender, EventArgs e)
	{
		int focusedRowHandle = GridView1.FocusedRowHandle;
		if (MessageBox.Show("Esta seguro de eliminar al Empleado: " + GridView1.GetRowCellValue(focusedRowHandle, "Codigo").ToString(), "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
		{
			objClassRRHH.Actualiza_Empleado(Conversions.ToInteger(GridView1.GetRowCellValue(focusedRowHandle, "Codigo")));
			llenar_grid();
		}
	}

	private void btn_FichaSocial_Click(object sender, EventArgs e)
	{
		FrmFichaSocial frmFichaSocial = new FrmFichaSocial();
		int focusedRowHandle = GridView1.FocusedRowHandle;
		if (Operators.ConditionalCompareObjectEqual(GridView1.GetRowCellValue(focusedRowHandle, "Codigo"), null, TextCompare: false))
		{
			Interaction.MsgBox("Seleccione un Empleado");
			return;
		}
		frmFichaSocial.CodEmple = Conversions.ToInteger(GridView1.GetRowCellValue(focusedRowHandle, "Codigo"));
		frmFichaSocial.ShowDialog();
	}

	public void llenar_grid()
	{
		if (TreeList1.FocusedNode != null)
		{
			lbl_Area.Text = TreeList1.FocusedNode.GetValue("AreaOrganizacional").ToString();
			string value = Conversions.ToString(TreeList1.FocusedNode.GetValue("Padre"));
			GridControl1.DataSource = objClassRRHH.buscar_empleado_tree(Conversions.ToInteger(value), Conversions.ToInteger(UcCBPartidaPresupuestal.SelectedValue));
		}
	}

	private void UcCBPartidaPresupuestal_SelectedIndexChanged(object sender, EventArgs e)
	{
		llenar_grid();
	}

	private void BtnImprimir_Click(object sender, EventArgs e)
	{
		FrmReportFicha frmReportFicha = new FrmReportFicha();
		int focusedRowHandle = GridView1.FocusedRowHandle;
		if (Operators.ConditionalCompareObjectEqual(GridView1.GetRowCellValue(focusedRowHandle, "Codigo"), null, TextCompare: false))
		{
			MessageBox.Show("Primero debe Seleccionar un Empleado", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		int codempleado = Conversions.ToInteger(GridView1.GetRowCellValue(focusedRowHandle, "Codigo"));
		frmReportFicha.Codempleado = codempleado;
		frmReportFicha.WindowState = FormWindowState.Maximized;
		frmReportFicha.MdiParent = MyProject.Forms.MainMDI;
		frmReportFicha.Show();
	}

	private void BtnArchivo_Click(object sender, EventArgs e)
	{
		FrmListaArchivos frmListaArchivos = new FrmListaArchivos();
		int focusedRowHandle = GridView1.FocusedRowHandle;
		if (Operators.ConditionalCompareObjectEqual(GridView1.GetRowCellValue(focusedRowHandle, "Codigo"), null, TextCompare: false))
		{
			MessageBox.Show("Primero debe Seleccionar un Empleado", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		frmListaArchivos.CodEmple = Conversions.ToInteger(GridView1.GetRowCellValue(focusedRowHandle, "Codigo"));
		frmListaArchivos.ShowDialog();
	}

	private void BtnCerrar_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		FrmConsultaPermisos frmConsultaPermisos = new FrmConsultaPermisos();
		int focusedRowHandle = GridView1.FocusedRowHandle;
		if (Operators.ConditionalCompareObjectEqual(GridView1.GetRowCellValue(focusedRowHandle, "Codigo"), null, TextCompare: false))
		{
			MessageBox.Show("Seleccione un Empleado", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		frmConsultaPermisos.idEmpleado = Conversions.ToInteger(GridView1.GetRowCellValue(focusedRowHandle, "Codigo"));
		frmConsultaPermisos.ShowDialog();
	}

	private void PanelSup_Paint(object sender, PaintEventArgs e)
	{
	}
}
