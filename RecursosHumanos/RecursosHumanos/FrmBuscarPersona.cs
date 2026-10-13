using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ClassRRHH;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using GRLL.Common;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using RecursosHumanos.My;
using RecursosHumanos.My.Resources;

namespace RecursosHumanos;

[DesignerGenerated]
public class FrmBuscarPersona : FrmConsulta
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("dgvEmpleado")]
	private GridControl _dgvEmpleado;

	[AccessedThroughProperty("GridView1")]
	private GridView _GridView1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("UcTxtCodigo")]
	private ucTextBox _UcTxtCodigo;

	[AccessedThroughProperty("UcTxtDni")]
	private ucTextBox _UcTxtDni;

	[AccessedThroughProperty("UcTxtApellido")]
	private ucTextBox _UcTxtApellido;

	[AccessedThroughProperty("CbxActivo")]
	private CheckBox _CbxActivo;

	[AccessedThroughProperty("BtnBuscar")]
	private Button _BtnBuscar;

	[AccessedThroughProperty("DataNavigator1")]
	private DataNavigator _DataNavigator1;

	[AccessedThroughProperty("ImageCollection1")]
	private ImageCollection _ImageCollection1;

	[AccessedThroughProperty("GridColumn2")]
	private GridColumn _GridColumn2;

	[AccessedThroughProperty("GridColumn3")]
	private GridColumn _GridColumn3;

	[AccessedThroughProperty("GridColumn4")]
	private GridColumn _GridColumn4;

	[AccessedThroughProperty("GridColumn5")]
	private GridColumn _GridColumn5;

	[AccessedThroughProperty("GridColumn6")]
	private GridColumn _GridColumn6;

	[AccessedThroughProperty("GridColumn1")]
	private GridColumn _GridColumn1;

	[AccessedThroughProperty("RepositoryItemImageComboBox1")]
	private RepositoryItemImageComboBox _RepositoryItemImageComboBox1;

	[AccessedThroughProperty("BtnImprimir")]
	private Button _BtnImprimir;

	[AccessedThroughProperty("btn_eliminar")]
	private Button _btn_eliminar;

	[AccessedThroughProperty("btn_editar")]
	private Button _btn_editar;

	[AccessedThroughProperty("btn_nuevo")]
	private Button _btn_nuevo;

	[AccessedThroughProperty("btn_FichaSocial")]
	private Button _btn_FichaSocial;

	[AccessedThroughProperty("BtnArchivo")]
	private Button _BtnArchivo;

	[AccessedThroughProperty("BtnPermiso")]
	private Button _BtnPermiso;

	[AccessedThroughProperty("BtnAsistenciaManual")]
	private Button _BtnAsistenciaManual;

	[AccessedThroughProperty("btnMarcacionAutorizada")]
	private Button _btnMarcacionAutorizada;

	[AccessedThroughProperty("BtnSuspender")]
	private Button _BtnSuspender;

	[AccessedThroughProperty("btnHorarios")]
	private Button _btnHorarios;

	private RRHHClass objClassRRHH;

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

	internal GridControl dgvEmpleado
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvEmpleado;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = dgvEmpleado_Click;
			EventHandler value3 = dgvEmpleado_DoubleClick;
			if (_dgvEmpleado != null)
			{
				_dgvEmpleado.Click -= value2;
				_dgvEmpleado.DoubleClick -= value3;
			}
			_dgvEmpleado = value;
			if (_dgvEmpleado != null)
			{
				_dgvEmpleado.Click += value2;
				_dgvEmpleado.DoubleClick += value3;
			}
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

	internal ucTextBox UcTxtCodigo
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtCodigo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			KeyPressEventHandler value2 = UcTxtApellido_KeyPress;
			if (_UcTxtCodigo != null)
			{
				_UcTxtCodigo.KeyPress -= value2;
			}
			_UcTxtCodigo = value;
			if (_UcTxtCodigo != null)
			{
				_UcTxtCodigo.KeyPress += value2;
			}
		}
	}

	internal ucTextBox UcTxtDni
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtDni;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			KeyPressEventHandler value2 = UcTxtApellido_KeyPress;
			if (_UcTxtDni != null)
			{
				_UcTxtDni.KeyPress -= value2;
			}
			_UcTxtDni = value;
			if (_UcTxtDni != null)
			{
				_UcTxtDni.KeyPress += value2;
			}
		}
	}

	internal ucTextBox UcTxtApellido
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtApellido;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = UcTxtApellido_TextChanged;
			KeyPressEventHandler value3 = UcTxtApellido_KeyPress;
			if (_UcTxtApellido != null)
			{
				_UcTxtApellido.TextChanged -= value2;
				_UcTxtApellido.KeyPress -= value3;
			}
			_UcTxtApellido = value;
			if (_UcTxtApellido != null)
			{
				_UcTxtApellido.TextChanged += value2;
				_UcTxtApellido.KeyPress += value3;
			}
		}
	}

	internal CheckBox CbxActivo
	{
		[DebuggerNonUserCode]
		get
		{
			return _CbxActivo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CbxActivo = value;
		}
	}

	internal Button BtnBuscar
	{
		[DebuggerNonUserCode]
		get
		{
			return _BtnBuscar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = Button1_Click;
			if (_BtnBuscar != null)
			{
				_BtnBuscar.Click -= value2;
			}
			_BtnBuscar = value;
			if (_BtnBuscar != null)
			{
				_BtnBuscar.Click += value2;
			}
		}
	}

	internal DataNavigator DataNavigator1
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataNavigator1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataNavigator1 = value;
		}
	}

	internal ImageCollection ImageCollection1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ImageCollection1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ImageCollection1 = value;
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

	internal GridColumn GridColumn6
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn6 = value;
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

	internal RepositoryItemImageComboBox RepositoryItemImageComboBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _RepositoryItemImageComboBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RepositoryItemImageComboBox1 = value;
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
			EventHandler value2 = Button1_Click_1;
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
			EventHandler value2 = BtnAsistenciaManual_Click;
			if (_BtnAsistenciaManual != null)
			{
				_BtnAsistenciaManual.Click -= value2;
			}
			_BtnAsistenciaManual = value;
			if (_BtnAsistenciaManual != null)
			{
				_BtnAsistenciaManual.Click += value2;
			}
		}
	}

	internal Button btnMarcacionAutorizada
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnMarcacionAutorizada;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = btnMarcacionAutorizada_Click;
			if (_btnMarcacionAutorizada != null)
			{
				_btnMarcacionAutorizada.Click -= value2;
			}
			_btnMarcacionAutorizada = value;
			if (_btnMarcacionAutorizada != null)
			{
				_btnMarcacionAutorizada.Click += value2;
			}
		}
	}

	internal Button BtnSuspender
	{
		[DebuggerNonUserCode]
		get
		{
			return _BtnSuspender;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = BtnSuspender_Click;
			if (_BtnSuspender != null)
			{
				_BtnSuspender.Click -= value2;
			}
			_BtnSuspender = value;
			if (_BtnSuspender != null)
			{
				_BtnSuspender.Click += value2;
			}
		}
	}

	internal Button btnHorarios
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnHorarios;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = btnHorarios_Click;
			if (_btnHorarios != null)
			{
				_btnHorarios.Click -= value2;
			}
			_btnHorarios = value;
			if (_btnHorarios != null)
			{
				_btnHorarios.Click += value2;
			}
		}
	}

	public FrmBuscarPersona()
	{
		base.Load += FrmBuscarPersona_Load;
		__ENCAddToList(this);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecursosHumanos.FrmBuscarPersona));
		this.dgvEmpleado = new DevExpress.XtraGrid.GridControl();
		this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.GridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.RepositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
		this.ImageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
		this.GridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.Label1 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.UcTxtCodigo = new GRLL.Common.ucTextBox(this.components);
		this.UcTxtDni = new GRLL.Common.ucTextBox(this.components);
		this.UcTxtApellido = new GRLL.Common.ucTextBox(this.components);
		this.CbxActivo = new System.Windows.Forms.CheckBox();
		this.BtnBuscar = new System.Windows.Forms.Button();
		this.DataNavigator1 = new DevExpress.XtraEditors.DataNavigator();
		this.BtnImprimir = new System.Windows.Forms.Button();
		this.btn_eliminar = new System.Windows.Forms.Button();
		this.btn_editar = new System.Windows.Forms.Button();
		this.btn_nuevo = new System.Windows.Forms.Button();
		this.btn_FichaSocial = new System.Windows.Forms.Button();
		this.BtnArchivo = new System.Windows.Forms.Button();
		this.BtnPermiso = new System.Windows.Forms.Button();
		this.BtnAsistenciaManual = new System.Windows.Forms.Button();
		this.btnMarcacionAutorizada = new System.Windows.Forms.Button();
		this.BtnSuspender = new System.Windows.Forms.Button();
		this.btnHorarios = new System.Windows.Forms.Button();
		((System.ComponentModel.ISupportInitialize)this.dgvEmpleado).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GridView1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.RepositoryItemImageComboBox1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ImageCollection1).BeginInit();
		this.SuspendLayout();
		this.cmdCerrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.cmdCerrar.AutoSize = true;
		this.cmdCerrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.cmdCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.cmdCerrar.FlatAppearance.BorderSize = 0;
		this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.cmdCerrar.Image = (System.Drawing.Image)resources.GetObject("cmdCerrar.Image");
		System.Windows.Forms.Button button = this.cmdCerrar;
		System.Drawing.Point location = new System.Drawing.Point(855, 389);
		button.Location = location;
		System.Windows.Forms.Button button2 = this.cmdCerrar;
		System.Drawing.Size size = new System.Drawing.Size(61, 23);
		button2.Size = size;
		this.cmdCerrar.TabIndex = 13;
		this.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		System.Windows.Forms.Panel panelSup = this.PanelSup;
		size = new System.Drawing.Size(928, 24);
		panelSup.Size = size;
		System.Windows.Forms.Panel panelInf = this.PanelInf;
		location = new System.Drawing.Point(0, 426);
		panelInf.Location = location;
		System.Windows.Forms.Panel panelInf2 = this.PanelInf;
		size = new System.Drawing.Size(928, 27);
		panelInf2.Size = size;
		this.dgvEmpleado.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		DevExpress.XtraGrid.GridControl gridControl = this.dgvEmpleado;
		location = new System.Drawing.Point(12, 67);
		gridControl.Location = location;
		this.dgvEmpleado.LookAndFeel.SkinName = "Blue";
		this.dgvEmpleado.LookAndFeel.UseDefaultLookAndFeel = false;
		this.dgvEmpleado.MainView = this.GridView1;
		this.dgvEmpleado.Name = "dgvEmpleado";
		this.dgvEmpleado.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[1] { this.RepositoryItemImageComboBox1 });
		DevExpress.XtraGrid.GridControl gridControl2 = this.dgvEmpleado;
		size = new System.Drawing.Size(904, 284);
		gridControl2.Size = size;
		this.dgvEmpleado.TabIndex = 6;
		this.dgvEmpleado.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[1] { this.GridView1 });
		this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[6] { this.GridColumn1, this.GridColumn2, this.GridColumn3, this.GridColumn4, this.GridColumn5, this.GridColumn6 });
		this.GridView1.GridControl = this.dgvEmpleado;
		this.GridView1.Name = "GridView1";
		this.GridView1.OptionsBehavior.Editable = false;
		this.GridView1.OptionsCustomization.AllowColumnMoving = false;
		this.GridView1.OptionsCustomization.AllowFilter = false;
		this.GridView1.OptionsCustomization.AllowGroup = false;
		this.GridView1.OptionsDetail.EnableMasterViewMode = false;
		this.GridView1.OptionsFilter.AllowColumnMRUFilterList = false;
		this.GridView1.OptionsFilter.AllowFilterEditor = false;
		this.GridView1.OptionsFilter.AllowMRUFilterList = false;
		this.GridView1.OptionsFilter.UseNewCustomFilterDialog = true;
		this.GridView1.OptionsMenu.EnableGroupPanelMenu = false;
		this.GridView1.OptionsNavigation.EnterMoveNextColumn = true;
		this.GridView1.OptionsView.ShowFooter = true;
		this.GridView1.OptionsView.ShowGroupPanel = false;
		this.GridColumn1.Caption = " ";
		this.GridColumn1.ColumnEdit = this.RepositoryItemImageComboBox1;
		this.GridColumn1.FieldName = "IdTipoTrabajador";
		this.GridColumn1.ImageAlignment = System.Drawing.StringAlignment.Center;
		this.GridColumn1.Name = "GridColumn1";
		this.GridColumn1.Visible = true;
		this.GridColumn1.VisibleIndex = 0;
		this.GridColumn1.Width = 60;
		this.RepositoryItemImageComboBox1.AutoHeight = false;
		this.RepositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
		});
		this.RepositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[5]
		{
			new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 4, -1),
			new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 1, 1),
			new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 2, 0),
			new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 3, 3),
			new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 5, 2)
		});
		this.RepositoryItemImageComboBox1.Name = "RepositoryItemImageComboBox1";
		this.RepositoryItemImageComboBox1.SmallImages = this.ImageCollection1;
		this.ImageCollection1.ImageStream = (DevExpress.Utils.ImageCollectionStreamer)resources.GetObject("ImageCollection1.ImageStream");
		this.ImageCollection1.Images.SetKeyName(0, "user1.png");
		this.ImageCollection1.Images.SetKeyName(1, "businessman.png");
		this.ImageCollection1.Images.SetKeyName(2, "user1_earth.png");
		this.GridColumn2.Caption = "Codigo";
		this.GridColumn2.FieldName = "Codigo";
		this.GridColumn2.Name = "GridColumn2";
		this.GridColumn2.Visible = true;
		this.GridColumn2.VisibleIndex = 1;
		this.GridColumn2.Width = 136;
		this.GridColumn3.Caption = "DNI";
		this.GridColumn3.FieldName = "DNI";
		this.GridColumn3.Name = "GridColumn3";
		this.GridColumn3.Visible = true;
		this.GridColumn3.VisibleIndex = 2;
		this.GridColumn3.Width = 136;
		this.GridColumn4.Caption = "Nombres Completos";
		this.GridColumn4.FieldName = "NombresCompletos";
		this.GridColumn4.Name = "GridColumn4";
		this.GridColumn4.Visible = true;
		this.GridColumn4.VisibleIndex = 3;
		this.GridColumn4.Width = 136;
		this.GridColumn5.Caption = "Area Organizacional";
		this.GridColumn5.FieldName = "AreaOrganizacional";
		this.GridColumn5.Name = "GridColumn5";
		this.GridColumn5.Visible = true;
		this.GridColumn5.VisibleIndex = 4;
		this.GridColumn5.Width = 138;
		this.GridColumn6.Caption = "Cargo";
		this.GridColumn6.FieldName = "cargo";
		this.GridColumn6.Name = "GridColumn6";
		this.Label1.AutoSize = true;
		System.Windows.Forms.Label label = this.Label1;
		location = new System.Drawing.Point(8, 33);
		label.Location = location;
		this.Label1.Name = "Label1";
		System.Windows.Forms.Label label2 = this.Label1;
		size = new System.Drawing.Size(43, 13);
		label2.Size = size;
		this.Label1.TabIndex = 4;
		this.Label1.Text = "Codigo:";
		this.Label2.AutoSize = true;
		System.Windows.Forms.Label label3 = this.Label2;
		location = new System.Drawing.Point(138, 33);
		label3.Location = location;
		this.Label2.Name = "Label2";
		System.Windows.Forms.Label label4 = this.Label2;
		size = new System.Drawing.Size(29, 13);
		label4.Size = size;
		this.Label2.TabIndex = 4;
		this.Label2.Text = "DNI:";
		this.Label3.AutoSize = true;
		System.Windows.Forms.Label label5 = this.Label3;
		location = new System.Drawing.Point(269, 33);
		label5.Location = location;
		this.Label3.Name = "Label3";
		System.Windows.Forms.Label label6 = this.Label3;
		size = new System.Drawing.Size(47, 13);
		label6.Size = size;
		this.Label3.TabIndex = 4;
		this.Label3.Text = "Apellido:";
		this.UcTxtCodigo.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtCodigo.Formato = null;
		this.UcTxtCodigo.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtCodigo = this.UcTxtCodigo;
		location = new System.Drawing.Point(57, 30);
		ucTxtCodigo.Location = location;
		this.UcTxtCodigo.Name = "UcTxtCodigo";
		this.UcTxtCodigo.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtCodigo.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtCodigo.OnErrorBlankText = "";
		this.UcTxtCodigo.PadLeftLenght = 0;
		this.UcTxtCodigo.RegularExpression = "^[0-9]*$";
		this.UcTxtCodigo.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtCodigo.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtCodigo2 = this.UcTxtCodigo;
		size = new System.Drawing.Size(75, 20);
		ucTxtCodigo2.Size = size;
		this.UcTxtCodigo.TabIndex = 1;
		this.UcTxtCodigo.TabNextControl = false;
		this.UcTxtCodigo.Tipo = GRLL.Common.ucTextBox.TipoDato.Enteros;
		this.UcTxtDni.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtDni.Formato = null;
		this.UcTxtDni.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtDni = this.UcTxtDni;
		location = new System.Drawing.Point(173, 30);
		ucTxtDni.Location = location;
		this.UcTxtDni.Name = "UcTxtDni";
		this.UcTxtDni.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtDni.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtDni.OnErrorBlankText = "";
		this.UcTxtDni.PadLeftLenght = 0;
		this.UcTxtDni.RegularExpression = "^[0-9]*$";
		this.UcTxtDni.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtDni.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtDni2 = this.UcTxtDni;
		size = new System.Drawing.Size(90, 20);
		ucTxtDni2.Size = size;
		this.UcTxtDni.TabIndex = 2;
		this.UcTxtDni.TabNextControl = false;
		this.UcTxtDni.Tipo = GRLL.Common.ucTextBox.TipoDato.Enteros;
		this.UcTxtApellido.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtApellido.Formato = null;
		this.UcTxtApellido.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtApellido = this.UcTxtApellido;
		location = new System.Drawing.Point(322, 30);
		ucTxtApellido.Location = location;
		this.UcTxtApellido.Name = "UcTxtApellido";
		this.UcTxtApellido.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtApellido.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtApellido.OnErrorBlankText = "";
		this.UcTxtApellido.PadLeftLenght = 0;
		this.UcTxtApellido.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtApellido.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtApellido2 = this.UcTxtApellido;
		size = new System.Drawing.Size(174, 20);
		ucTxtApellido2.Size = size;
		this.UcTxtApellido.TabIndex = 3;
		this.UcTxtApellido.TabNextControl = false;
		this.UcTxtApellido.Tipo = GRLL.Common.ucTextBox.TipoDato.Todos;
		this.CbxActivo.AutoSize = true;
		this.CbxActivo.Checked = true;
		this.CbxActivo.CheckState = System.Windows.Forms.CheckState.Checked;
		System.Windows.Forms.CheckBox cbxActivo = this.CbxActivo;
		location = new System.Drawing.Point(502, 32);
		cbxActivo.Location = location;
		this.CbxActivo.Name = "CbxActivo";
		System.Windows.Forms.CheckBox cbxActivo2 = this.CbxActivo;
		size = new System.Drawing.Size(56, 17);
		cbxActivo2.Size = size;
		this.CbxActivo.TabIndex = 4;
		this.CbxActivo.Text = "Activo";
		this.CbxActivo.UseVisualStyleBackColor = false;
		this.BtnBuscar.AutoSize = true;
		this.BtnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.BtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BtnBuscar.FlatAppearance.BorderSize = 0;
		this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BtnBuscar.Image = RecursosHumanos.My.Resources.Resources.view;
		System.Windows.Forms.Button btnBuscar = this.BtnBuscar;
		location = new System.Drawing.Point(560, 27);
		btnBuscar.Location = location;
		this.BtnBuscar.Name = "BtnBuscar";
		System.Windows.Forms.Button btnBuscar2 = this.BtnBuscar;
		size = new System.Drawing.Size(74, 30);
		btnBuscar2.Size = size;
		this.BtnBuscar.TabIndex = 5;
		this.BtnBuscar.Text = "Buscar";
		this.BtnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.BtnBuscar.UseVisualStyleBackColor = true;
		this.DataNavigator1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.DataNavigator1.Buttons.Append.Enabled = false;
		this.DataNavigator1.Buttons.CancelEdit.Enabled = false;
		this.DataNavigator1.Buttons.EndEdit.Enabled = false;
		this.DataNavigator1.Buttons.Remove.Enabled = false;
		DevExpress.XtraEditors.DataNavigator dataNavigator = this.DataNavigator1;
		location = new System.Drawing.Point(12, 350);
		dataNavigator.Location = location;
		this.DataNavigator1.LookAndFeel.SkinName = "Blue";
		this.DataNavigator1.LookAndFeel.UseDefaultLookAndFeel = false;
		this.DataNavigator1.Name = "DataNavigator1";
		DevExpress.XtraEditors.DataNavigator dataNavigator2 = this.DataNavigator1;
		size = new System.Drawing.Size(627, 27);
		dataNavigator2.Size = size;
		this.DataNavigator1.TabIndex = 9;
		this.DataNavigator1.Text = "DataNavigator1";
		this.DataNavigator1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center;
		this.DataNavigator1.TextStringFormat = "Registro {0} de {1}";
		this.DataNavigator1.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
		this.BtnImprimir.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.BtnImprimir.AutoSize = true;
		this.BtnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.BtnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BtnImprimir.FlatAppearance.BorderSize = 0;
		this.BtnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BtnImprimir.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.BtnImprimir.Image = (System.Drawing.Image)resources.GetObject("BtnImprimir.Image");
		System.Windows.Forms.Button btnImprimir = this.BtnImprimir;
		location = new System.Drawing.Point(786, 381);
		btnImprimir.Location = location;
		this.BtnImprimir.Name = "BtnImprimir";
		System.Windows.Forms.Button btnImprimir2 = this.BtnImprimir;
		size = new System.Drawing.Size(55, 39);
		btnImprimir2.Size = size;
		this.BtnImprimir.TabIndex = 12;
		this.BtnImprimir.Text = "Imprimir";
		this.BtnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.BtnImprimir.UseVisualStyleBackColor = true;
		this.btn_eliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.btn_eliminar.AutoSize = true;
		this.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btn_eliminar.FlatAppearance.BorderSize = 0;
		this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btn_eliminar.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btn_eliminar.Image = (System.Drawing.Image)resources.GetObject("btn_eliminar.Image");
		System.Windows.Forms.Button button3 = this.btn_eliminar;
		location = new System.Drawing.Point(120, 381);
		button3.Location = location;
		this.btn_eliminar.Name = "btn_eliminar";
		System.Windows.Forms.Button button4 = this.btn_eliminar;
		size = new System.Drawing.Size(53, 39);
		button4.Size = size;
		this.btn_eliminar.TabIndex = 9;
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
		System.Windows.Forms.Button button5 = this.btn_editar;
		location = new System.Drawing.Point(69, 381);
		button5.Location = location;
		this.btn_editar.Name = "btn_editar";
		System.Windows.Forms.Button button6 = this.btn_editar;
		size = new System.Drawing.Size(45, 39);
		button6.Size = size;
		this.btn_editar.TabIndex = 8;
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
		System.Windows.Forms.Button button7 = this.btn_nuevo;
		location = new System.Drawing.Point(15, 381);
		button7.Location = location;
		this.btn_nuevo.Name = "btn_nuevo";
		System.Windows.Forms.Button button8 = this.btn_nuevo;
		size = new System.Drawing.Size(48, 39);
		button8.Size = size;
		this.btn_nuevo.TabIndex = 7;
		this.btn_nuevo.Text = "Nuevo";
		this.btn_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.btn_nuevo.UseVisualStyleBackColor = true;
		this.btn_FichaSocial.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.btn_FichaSocial.AutoSize = true;
		this.btn_FichaSocial.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btn_FichaSocial.FlatAppearance.BorderSize = 0;
		this.btn_FichaSocial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btn_FichaSocial.Image = RecursosHumanos.My.Resources.Resources.document_certificate1;
		System.Windows.Forms.Button button9 = this.btn_FichaSocial;
		location = new System.Drawing.Point(173, 381);
		button9.Location = location;
		this.btn_FichaSocial.Name = "btn_FichaSocial";
		System.Windows.Forms.Button button10 = this.btn_FichaSocial;
		size = new System.Drawing.Size(84, 39);
		button10.Size = size;
		this.btn_FichaSocial.TabIndex = 10;
		this.btn_FichaSocial.Text = "Ficha Escalaf.";
		this.btn_FichaSocial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.btn_FichaSocial.UseVisualStyleBackColor = true;
		this.BtnArchivo.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.BtnArchivo.AutoSize = true;
		this.BtnArchivo.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BtnArchivo.FlatAppearance.BorderSize = 0;
		this.BtnArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BtnArchivo.Image = RecursosHumanos.My.Resources.Resources.folder_important;
		System.Windows.Forms.Button btnArchivo = this.BtnArchivo;
		location = new System.Drawing.Point(254, 381);
		btnArchivo.Location = location;
		this.BtnArchivo.Name = "BtnArchivo";
		System.Windows.Forms.Button btnArchivo2 = this.BtnArchivo;
		size = new System.Drawing.Size(77, 39);
		btnArchivo2.Size = size;
		this.BtnArchivo.TabIndex = 11;
		this.BtnArchivo.Text = "File Personal";
		this.BtnArchivo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.BtnArchivo.UseVisualStyleBackColor = true;
		this.BtnPermiso.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.BtnPermiso.AutoSize = true;
		this.BtnPermiso.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.BtnPermiso.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BtnPermiso.FlatAppearance.BorderSize = 0;
		this.BtnPermiso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BtnPermiso.Image = RecursosHumanos.My.Resources.Resources.form_yellow;
		System.Windows.Forms.Button btnPermiso = this.BtnPermiso;
		location = new System.Drawing.Point(337, 381);
		btnPermiso.Location = location;
		this.BtnPermiso.Name = "BtnPermiso";
		System.Windows.Forms.Button btnPermiso2 = this.BtnPermiso;
		size = new System.Drawing.Size(54, 39);
		btnPermiso2.Size = size;
		this.BtnPermiso.TabIndex = 14;
		this.BtnPermiso.Text = "Permiso";
		this.BtnPermiso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.BtnPermiso.UseVisualStyleBackColor = true;
		this.BtnAsistenciaManual.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.BtnAsistenciaManual.AutoSize = true;
		this.BtnAsistenciaManual.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.BtnAsistenciaManual.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BtnAsistenciaManual.FlatAppearance.BorderSize = 0;
		this.BtnAsistenciaManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BtnAsistenciaManual.Image = RecursosHumanos.My.Resources.Resources.graphics_tablet;
		System.Windows.Forms.Button btnAsistenciaManual = this.BtnAsistenciaManual;
		location = new System.Drawing.Point(392, 381);
		btnAsistenciaManual.Location = location;
		this.BtnAsistenciaManual.Name = "BtnAsistenciaManual";
		System.Windows.Forms.Button btnAsistenciaManual2 = this.BtnAsistenciaManual;
		size = new System.Drawing.Size(103, 39);
		btnAsistenciaManual2.Size = size;
		this.BtnAsistenciaManual.TabIndex = 15;
		this.BtnAsistenciaManual.Text = "Asistencia Manual";
		this.BtnAsistenciaManual.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.BtnAsistenciaManual.UseVisualStyleBackColor = true;
		this.btnMarcacionAutorizada.AutoSize = true;
		this.btnMarcacionAutorizada.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.btnMarcacionAutorizada.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnMarcacionAutorizada.FlatAppearance.BorderSize = 0;
		this.btnMarcacionAutorizada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnMarcacionAutorizada.Image = RecursosHumanos.My.Resources.Resources.document_ok;
		System.Windows.Forms.Button button11 = this.btnMarcacionAutorizada;
		location = new System.Drawing.Point(501, 381);
		button11.Location = location;
		this.btnMarcacionAutorizada.Name = "btnMarcacionAutorizada";
		System.Windows.Forms.Button button12 = this.btnMarcacionAutorizada;
		size = new System.Drawing.Size(120, 39);
		button12.Size = size;
		this.btnMarcacionAutorizada.TabIndex = 16;
		this.btnMarcacionAutorizada.Text = "Marcacion Autorizada";
		this.btnMarcacionAutorizada.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.btnMarcacionAutorizada.UseVisualStyleBackColor = true;
		this.BtnSuspender.AutoSize = true;
		this.BtnSuspender.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.BtnSuspender.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BtnSuspender.FlatAppearance.BorderSize = 0;
		this.BtnSuspender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BtnSuspender.Image = RecursosHumanos.My.Resources.Resources.document_delete;
		System.Windows.Forms.Button btnSuspender = this.BtnSuspender;
		location = new System.Drawing.Point(627, 381);
		btnSuspender.Location = location;
		this.BtnSuspender.Name = "BtnSuspender";
		System.Windows.Forms.Button btnSuspender2 = this.BtnSuspender;
		size = new System.Drawing.Size(68, 39);
		btnSuspender2.Size = size;
		this.BtnSuspender.TabIndex = 17;
		this.BtnSuspender.Text = "Suspender";
		this.BtnSuspender.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.BtnSuspender.UseVisualStyleBackColor = true;
		this.btnHorarios.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnHorarios.FlatAppearance.BorderSize = 0;
		this.btnHorarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnHorarios.Image = RecursosHumanos.My.Resources.Resources.clock;
		System.Windows.Forms.Button button13 = this.btnHorarios;
		location = new System.Drawing.Point(701, 375);
		button13.Location = location;
		this.btnHorarios.Name = "btnHorarios";
		System.Windows.Forms.Button button14 = this.btnHorarios;
		size = new System.Drawing.Size(75, 51);
		button14.Size = size;
		this.btnHorarios.TabIndex = 18;
		this.btnHorarios.Text = "Horarios Especiales";
		this.btnHorarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.btnHorarios.UseVisualStyleBackColor = true;
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.AutoSize = true;
		this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.CausesValidation = false;
		size = new System.Drawing.Size(928, 453);
		this.ClientSize = size;
		this.Controls.Add(this.btnHorarios);
		this.Controls.Add(this.BtnSuspender);
		this.Controls.Add(this.btnMarcacionAutorizada);
		this.Controls.Add(this.BtnAsistenciaManual);
		this.Controls.Add(this.BtnPermiso);
		this.Controls.Add(this.BtnArchivo);
		this.Controls.Add(this.btn_FichaSocial);
		this.Controls.Add(this.BtnImprimir);
		this.Controls.Add(this.btn_eliminar);
		this.Controls.Add(this.btn_editar);
		this.Controls.Add(this.btn_nuevo);
		this.Controls.Add(this.Label1);
		this.Controls.Add(this.UcTxtCodigo);
		this.Controls.Add(this.Label2);
		this.Controls.Add(this.dgvEmpleado);
		this.Controls.Add(this.DataNavigator1);
		this.Controls.Add(this.BtnBuscar);
		this.Controls.Add(this.Label3);
		this.Controls.Add(this.CbxActivo);
		this.Controls.Add(this.UcTxtApellido);
		this.Controls.Add(this.UcTxtDni);
		this.MessageShow = true;
		this.Name = "FrmBuscarPersona";
		this.Text = "Busqueda de Empleados";
		this.TextFrm = "Busqueda de Empleados";
		this.TitleMsg = "FrmConsulta";
		this.Titulo = "Búsqueda de Personal";
		this.VerCmdCerrar = true;
		this.Controls.SetChildIndex(this.UcTxtDni, 0);
		this.Controls.SetChildIndex(this.UcTxtApellido, 0);
		this.Controls.SetChildIndex(this.cmdCerrar, 0);
		this.Controls.SetChildIndex(this.CbxActivo, 0);
		this.Controls.SetChildIndex(this.Label3, 0);
		this.Controls.SetChildIndex(this.BtnBuscar, 0);
		this.Controls.SetChildIndex(this.DataNavigator1, 0);
		this.Controls.SetChildIndex(this.dgvEmpleado, 0);
		this.Controls.SetChildIndex(this.Label2, 0);
		this.Controls.SetChildIndex(this.UcTxtCodigo, 0);
		this.Controls.SetChildIndex(this.Label1, 0);
		this.Controls.SetChildIndex(this.PanelSup, 0);
		this.Controls.SetChildIndex(this.PanelInf, 0);
		this.Controls.SetChildIndex(this.btn_nuevo, 0);
		this.Controls.SetChildIndex(this.btn_editar, 0);
		this.Controls.SetChildIndex(this.btn_eliminar, 0);
		this.Controls.SetChildIndex(this.BtnImprimir, 0);
		this.Controls.SetChildIndex(this.btn_FichaSocial, 0);
		this.Controls.SetChildIndex(this.BtnArchivo, 0);
		this.Controls.SetChildIndex(this.BtnPermiso, 0);
		this.Controls.SetChildIndex(this.BtnAsistenciaManual, 0);
		this.Controls.SetChildIndex(this.btnMarcacionAutorizada, 0);
		this.Controls.SetChildIndex(this.BtnSuspender, 0);
		this.Controls.SetChildIndex(this.btnHorarios, 0);
		((System.ComponentModel.ISupportInitialize)this.dgvEmpleado).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GridView1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.RepositoryItemImageComboBox1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ImageCollection1).EndInit();
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	private void llenarGrid()
	{
		int? codigo = ((UcTxtCodigo.Text.Trim().Length != 0) ? ((int?)int.Parse(UcTxtCodigo.Text)) : ((int?)null));
		if (Conversions.ToDouble(RRHH.IdROl) == 10.0)
		{
			dgvEmpleado.DataSource = objClassRRHH.buscar_empleado(codigo, UcTxtDni.Text, UcTxtApellido.Text, 1, (int)CbxActivo.CheckState);
			return;
		}
		if (Conversions.ToDouble(RRHH.IdROl) == 14.0)
		{
			dgvEmpleado.DataSource = objClassRRHH.buscar_empleado(codigo, UcTxtDni.Text, UcTxtApellido.Text, 2, (int)CbxActivo.CheckState);
			return;
		}
		int? num = default(int?);
		if (Conversions.ToDouble(RRHH.IdROl) == 13.0)
		{
			dgvEmpleado.DataSource = objClassRRHH.buscar_empleado(codigo, UcTxtDni.Text, UcTxtApellido.Text, num, (int)CbxActivo.CheckState);
			return;
		}
		if ((Conversions.ToDouble(RRHH.IdROl) == 4.0) | (Conversions.ToDouble(RRHH.IdROl) == 3.0))
		{
			dgvEmpleado.DataSource = objClassRRHH.buscar_empleado(codigo, UcTxtDni.Text, UcTxtApellido.Text, num, (int)CbxActivo.CheckState, Conversions.ToInteger(RRHH.IdROl));
			return;
		}
		GridControl gridControl = dgvEmpleado;
		RRHHClass rRHHClass = objClassRRHH;
		string numdoc = UcTxtDni.Text;
		string apellido = UcTxtApellido.Text;
		object obj = Interaction.IIf(RRHH.Partida == 0, null, RRHH.Partida);
		gridControl.DataSource = rRHHClass.buscar_empleado(codigo, numdoc, apellido, (obj != null) ? ((int?)obj) : num, (int)CbxActivo.CheckState);
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		try
		{
			llenarGrid();
			GridView1.BestFitColumns();
			DataNavigator1.DataSource = RuntimeHelpers.GetObjectValue(dgvEmpleado.DataSource);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void btn_nuevo_Click(object sender, EventArgs e)
	{
		FrmMantEmpleado_Basico frmMantEmpleado_Basico = new FrmMantEmpleado_Basico();
		frmMantEmpleado_Basico.ShowDialog();
		if (frmMantEmpleado_Basico.DialogResult == DialogResult.OK)
		{
			try
			{
				llenarGrid();
				GridView1.BestFitColumns();
				DataNavigator1.DataSource = RuntimeHelpers.GetObjectValue(dgvEmpleado.DataSource);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox(ex2.Message);
				ProjectData.ClearProjectError();
			}
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
			MessageBox.Show("Seleccione un Empleado", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		if (Conversions.ToDouble(RRHH.IdROl) == 4.0)
		{
			if (Operators.ConditionalCompareObjectEqual(GridView1.GetRowCellValue(focusedRowHandle, "IdTipoTrabajador"), 2, TextCompare: false))
			{
				MessageBox.Show("Usted No Tiene Permiso para Acceder a esta Información", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			frmMantEmpleado_Basico.Titulo = "Edición Datos Basicos del Empleado";
			frmMantEmpleado_Basico.ShowDialog();
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 3.0)
		{
			if (Operators.ConditionalCompareObjectNotEqual(GridView1.GetRowCellValue(focusedRowHandle, "IdTipoTrabajador"), 2, TextCompare: false))
			{
				MessageBox.Show("Usted No Tiene Permiso para Acceder a esta Información", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			frmMantEmpleado_Basico.Titulo = "Edición Datos Basicos del Empleado";
			frmMantEmpleado_Basico.ShowDialog();
		}
		else
		{
			if ((Conversions.ToDouble(RRHH.IdROl) == 10.0) | (Conversions.ToDouble(RRHH.IdROl) == 14.0))
			{
				MessageBox.Show("Usted No Tiene Permiso para Acceder a esta Información", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			frmMantEmpleado_Basico.Titulo = "Edición Datos Basicos del Empleado";
			frmMantEmpleado_Basico.ShowDialog();
		}
		if (frmMantEmpleado_Basico.DialogResult != DialogResult.OK)
		{
			return;
		}
		try
		{
			llenarGrid();
			GridView1.BestFitColumns();
			DataNavigator1.DataSource = RuntimeHelpers.GetObjectValue(dgvEmpleado.DataSource);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void btn_eliminar_Click(object sender, EventArgs e)
	{
		int focusedRowHandle = GridView1.FocusedRowHandle;
		if (MessageBox.Show("Esta seguro de eliminar al Empleado: " + GridView1.GetRowCellValue(focusedRowHandle, "Codigo").ToString(), "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
		{
			objClassRRHH.Actualiza_Empleado(Conversions.ToInteger(GridView1.GetRowCellValue(focusedRowHandle, "Codigo")));
			Button1_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}
	}

	private void btn_FichaSocial_Click(object sender, EventArgs e)
	{
		FrmFichaSocial frmFichaSocial = new FrmFichaSocial();
		int focusedRowHandle = GridView1.FocusedRowHandle;
		if (Operators.ConditionalCompareObjectEqual(GridView1.GetRowCellValue(focusedRowHandle, "Codigo"), null, TextCompare: false))
		{
			MessageBox.Show("Seleccione un Empleado", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
		else if (!RRHH.Bienestar)
		{
			if (Conversions.ToDouble(RRHH.IdROl) == 4.0)
			{
				if (Operators.ConditionalCompareObjectEqual(GridView1.GetRowCellValue(focusedRowHandle, "IdTipoTrabajador"), 2, TextCompare: false))
				{
					MessageBox.Show("Usted No Tiene Permiso para Acceder a esta Información", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				frmFichaSocial.CodEmple = Conversions.ToInteger(GridView1.GetRowCellValue(focusedRowHandle, "Codigo"));
				frmFichaSocial.ShowDialog();
			}
			else if (Conversions.ToDouble(RRHH.IdROl) == 3.0)
			{
				if (Operators.ConditionalCompareObjectNotEqual(GridView1.GetRowCellValue(focusedRowHandle, "IdTipoTrabajador"), 2, TextCompare: false))
				{
					MessageBox.Show("Usted No Tiene Permiso para Acceder a esta Información", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				frmFichaSocial.CodEmple = Conversions.ToInteger(GridView1.GetRowCellValue(focusedRowHandle, "Codigo"));
				frmFichaSocial.ShowDialog();
			}
			else if ((Conversions.ToDouble(RRHH.IdROl) == 10.0) | (Conversions.ToDouble(RRHH.IdROl) == 14.0))
			{
				MessageBox.Show("Usted No Tiene Permiso para Acceder a esta Información", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				frmFichaSocial.CodEmple = Conversions.ToInteger(GridView1.GetRowCellValue(focusedRowHandle, "Codigo"));
				frmFichaSocial.ShowDialog();
			}
		}
		else
		{
			frmFichaSocial.CodEmple = Conversions.ToInteger(GridView1.GetRowCellValue(focusedRowHandle, "Codigo"));
			frmFichaSocial.ShowDialog();
		}
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

	private void dgvEmpleado_DoubleClick(object sender, EventArgs e)
	{
		FrmMantEmpleado_Basico frmMantEmpleado_Basico = new FrmMantEmpleado_Basico();
		int focusedRowHandle = GridView1.FocusedRowHandle;
		objClassRRHH.CodigoEmpleado = Conversions.ToInteger(GridView1.GetRowCellValue(focusedRowHandle, "Codigo"));
		frmMantEmpleado_Basico.MantEmpleado_Basico_Cod = objClassRRHH.CodigoEmpleado;
		if (objClassRRHH.CodigoEmpleado == 0)
		{
			Interaction.MsgBox("Seleccione un Empleado");
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 4.0)
		{
			if (Operators.ConditionalCompareObjectEqual(GridView1.GetRowCellValue(focusedRowHandle, "IdTipoTrabajador"), 2, TextCompare: false))
			{
				MessageBox.Show("Usted No Tiene Permiso para Acceder a esta Información", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			frmMantEmpleado_Basico.Titulo = "Edición Datos Basicos del Empleado";
			frmMantEmpleado_Basico.ShowDialog();
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 3.0)
		{
			if (Operators.ConditionalCompareObjectNotEqual(GridView1.GetRowCellValue(focusedRowHandle, "IdTipoTrabajador"), 2, TextCompare: false))
			{
				MessageBox.Show("Usted No Tiene Permiso para Acceder a esta Información", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			frmMantEmpleado_Basico.Titulo = "Edición Datos Basicos del Empleado";
			frmMantEmpleado_Basico.ShowDialog();
		}
		else if ((Conversions.ToDouble(RRHH.IdROl) == 10.0) | (Conversions.ToDouble(RRHH.IdROl) == 14.0) | (Conversions.ToDouble(RRHH.IdROl) == 5.0))
		{
			MessageBox.Show("Usted No Tiene Permiso para Acceder a esta Información", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		else
		{
			frmMantEmpleado_Basico.Titulo = "Edición Datos Basicos del Empleado";
			frmMantEmpleado_Basico.ShowDialog();
		}
	}

	private void BtnArchivo_Click(object sender, EventArgs e)
	{
		FrmListaArchivos frmListaArchivos = new FrmListaArchivos();
		int focusedRowHandle = GridView1.FocusedRowHandle;
		if (Operators.ConditionalCompareObjectEqual(GridView1.GetRowCellValue(focusedRowHandle, "Codigo"), null, TextCompare: false))
		{
			Interaction.MsgBox("Seleccione un Empleado");
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 4.0)
		{
			if (Operators.ConditionalCompareObjectEqual(GridView1.GetRowCellValue(focusedRowHandle, "IdTipoTrabajador"), 2, TextCompare: false))
			{
				MessageBox.Show("Usted No Tiene Permiso para Acceder a esta Información", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			frmListaArchivos.CodEmple = Conversions.ToInteger(GridView1.GetRowCellValue(focusedRowHandle, "Codigo"));
			frmListaArchivos.ShowDialog();
		}
		else if (Operators.ConditionalCompareObjectNotEqual(GridView1.GetRowCellValue(focusedRowHandle, "IdTipoTrabajador"), RRHH.Partida, TextCompare: false))
		{
			MessageBox.Show("Usted No Tiene Permiso para Acceder a esta Información", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		else
		{
			frmListaArchivos.CodEmple = Conversions.ToInteger(GridView1.GetRowCellValue(focusedRowHandle, "Codigo"));
			frmListaArchivos.ShowDialog();
		}
	}

	private void UcTxtApellido_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (e.KeyChar == '\r')
		{
			Button1_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}
	}

	private void FrmBuscarPersona_Load(object sender, EventArgs e)
	{
		checked
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
				Button button = btn_FichaSocial;
				Point location = new Point(15, Height - 113);
				button.Location = location;
				BtnAsistenciaManual.Visible = false;
				BtnPermiso.Visible = false;
				BtnSuspender.Visible = false;
				btnMarcacionAutorizada.Visible = false;
			}
			if (RRHH.Asistencias)
			{
				BtnArchivo.Enabled = false;
				BtnArchivo.Visible = false;
				btn_nuevo.Enabled = false;
				btn_nuevo.Visible = false;
				btn_editar.Enabled = false;
				btn_editar.Visible = false;
				btn_eliminar.Enabled = false;
				btn_eliminar.Visible = false;
				btn_FichaSocial.Enabled = false;
				btn_FichaSocial.Visible = false;
				BtnImprimir.Enabled = false;
				BtnImprimir.Visible = false;
				BtnAsistenciaManual.Enabled = true;
				Button btnPermiso = BtnPermiso;
				Point location = new Point(15, Height - 113);
				btnPermiso.Location = location;
				Button btnAsistenciaManual = BtnAsistenciaManual;
				location = new Point(78, Height - 113);
				btnAsistenciaManual.Location = location;
				Button button2 = btnMarcacionAutorizada;
				location = new Point(178, Height - 113);
				button2.Location = location;
				BtnSuspender.Visible = true;
				Button btnSuspender = BtnSuspender;
				location = new Point(298, Height - 113);
				btnSuspender.Location = location;
			}
			else if ((Conversions.ToDouble(RRHH.IdROl) == 4.0) | (Conversions.ToDouble(RRHH.IdROl) == 3.0))
			{
				BtnSuspender.Visible = false;
				BtnAsistenciaManual.Enabled = false;
				BtnPermiso.Enabled = false;
				btnMarcacionAutorizada.Enabled = false;
			}
			else if (Conversions.ToDouble(RRHH.IdROl) == 15.0)
			{
				BtnPermiso.Visible = false;
				BtnAsistenciaManual.Visible = false;
				btnMarcacionAutorizada.Visible = false;
				BtnSuspender.Visible = false;
			}
		}
	}

	private void Button1_Click_1(object sender, EventArgs e)
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

	private void UcTxtApellido_TextChanged(object sender, EventArgs e)
	{
	}

	private void BtnAsistenciaManual_Click(object sender, EventArgs e)
	{
		FrmAsistenciaManual frmAsistenciaManual = new FrmAsistenciaManual();
		int focusedRowHandle = GridView1.FocusedRowHandle;
		if (Operators.ConditionalCompareObjectEqual(GridView1.GetRowCellValue(focusedRowHandle, "Codigo"), null, TextCompare: false))
		{
			MessageBox.Show("Seleccione un Empleado", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		frmAsistenciaManual.idEmpleado = Conversions.ToInteger(GridView1.GetRowCellValue(focusedRowHandle, "Codigo"));
		frmAsistenciaManual.Show();
	}

	private void btnMarcacionAutorizada_Click(object sender, EventArgs e)
	{
		FrmMarcacionesAutorizadas frmMarcacionesAutorizadas = new FrmMarcacionesAutorizadas();
		int focusedRowHandle = GridView1.FocusedRowHandle;
		if (Operators.ConditionalCompareObjectEqual(GridView1.GetRowCellValue(focusedRowHandle, "Codigo"), null, TextCompare: false))
		{
			MessageBox.Show("Seleccione un Empleado", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		frmMarcacionesAutorizadas.idEmpleado = Conversions.ToInteger(GridView1.GetRowCellValue(focusedRowHandle, "Codigo"));
		frmMarcacionesAutorizadas.Show();
	}

	private void dgvEmpleado_Click(object sender, EventArgs e)
	{
	}

	private void BtnSuspender_Click(object sender, EventArgs e)
	{
		FrmSuspenderAsistencia frmSuspenderAsistencia = new FrmSuspenderAsistencia();
		int focusedRowHandle = GridView1.FocusedRowHandle;
		if (Operators.ConditionalCompareObjectEqual(GridView1.GetRowCellValue(focusedRowHandle, "Codigo"), null, TextCompare: false))
		{
			MessageBox.Show("Seleccione un Empleado", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		frmSuspenderAsistencia.idEmpleado = Conversions.ToInteger(GridView1.GetRowCellValue(focusedRowHandle, "Codigo"));
		frmSuspenderAsistencia.Show();
	}

	private void btnAsegurado_Click(object sender, EventArgs e)
	{
	}

	private void PanelSup_Paint(object sender, PaintEventArgs e)
	{
	}

	private void btnHorarios_Click(object sender, EventArgs e)
	{
		FrmConsultaHorarioEsp frmConsultaHorarioEsp = new FrmConsultaHorarioEsp();
		int focusedRowHandle = GridView1.FocusedRowHandle;
		if (Operators.ConditionalCompareObjectEqual(GridView1.GetRowCellValue(focusedRowHandle, "Codigo"), null, TextCompare: false))
		{
			MessageBox.Show("Seleccione un Empleado", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		frmConsultaHorarioEsp.idEmpleado = Conversions.ToInteger(GridView1.GetRowCellValue(focusedRowHandle, "Codigo"));
		frmConsultaHorarioEsp.Show();
	}
}
