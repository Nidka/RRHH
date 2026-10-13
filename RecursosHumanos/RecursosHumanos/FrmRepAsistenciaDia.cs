using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ClassRRHH;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
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
public class FrmRepAsistenciaDia : FrmConsulta
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("ListTrabajadores")]
	private ListBoxControl _ListTrabajadores;

	[AccessedThroughProperty("ListTrabajadoresRep")]
	private ListBoxControl _ListTrabajadoresRep;

	[AccessedThroughProperty("btnAgregarLista")]
	private Button _btnAgregarLista;

	[AccessedThroughProperty("btnQuitarLista")]
	private Button _btnQuitarLista;

	[AccessedThroughProperty("GroupControl1")]
	private GroupControl _GroupControl1;

	[AccessedThroughProperty("UcFechas1")]
	private ucFechas _UcFechas1;

	[AccessedThroughProperty("UcCBPartidaPresupuestal")]
	private ucComboBox _UcCBPartidaPresupuestal;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("BtnConsultar")]
	private Button _BtnConsultar;

	[AccessedThroughProperty("DefaultLookAndFeel1")]
	private DefaultLookAndFeel _DefaultLookAndFeel1;

	[AccessedThroughProperty("GridControl1")]
	private GridControl _GridControl1;

	[AccessedThroughProperty("GridView1")]
	private GridView _GridView1;

	[AccessedThroughProperty("GridColumn1")]
	private GridColumn _GridColumn1;

	[AccessedThroughProperty("GridColumn5")]
	private GridColumn _GridColumn5;

	[AccessedThroughProperty("GridColumn4")]
	private GridColumn _GridColumn4;

	[AccessedThroughProperty("GridColumn2")]
	private GridColumn _GridColumn2;

	[AccessedThroughProperty("GridColumn3")]
	private GridColumn _GridColumn3;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("GroupControl2")]
	private GroupControl _GroupControl2;

	[AccessedThroughProperty("GridColumn6")]
	private GridColumn _GridColumn6;

	[AccessedThroughProperty("GridColumn7")]
	private GridColumn _GridColumn7;

	[AccessedThroughProperty("GridColumn8")]
	private GridColumn _GridColumn8;

	private RRHHClass objRRHHClass;

	private string fechaI;

	private string fechaF;

	internal ListBoxControl ListTrabajadores
	{
		[DebuggerNonUserCode]
		get
		{
			return _ListTrabajadores;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ListTrabajadores = value;
		}
	}

	internal ListBoxControl ListTrabajadoresRep
	{
		[DebuggerNonUserCode]
		get
		{
			return _ListTrabajadoresRep;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ListTrabajadoresRep = value;
		}
	}

	internal Button btnAgregarLista
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnAgregarLista;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = btnAgregarLista_Click;
			if (_btnAgregarLista != null)
			{
				_btnAgregarLista.Click -= value2;
			}
			_btnAgregarLista = value;
			if (_btnAgregarLista != null)
			{
				_btnAgregarLista.Click += value2;
			}
		}
	}

	internal Button btnQuitarLista
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnQuitarLista;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = btnQuitarLista_Click;
			if (_btnQuitarLista != null)
			{
				_btnQuitarLista.Click -= value2;
			}
			_btnQuitarLista = value;
			if (_btnQuitarLista != null)
			{
				_btnQuitarLista.Click += value2;
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

	internal ucFechas UcFechas1
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcFechas1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcFechas1 = value;
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

	internal Button BtnConsultar
	{
		[DebuggerNonUserCode]
		get
		{
			return _BtnConsultar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = BtnConsultar_Click;
			if (_BtnConsultar != null)
			{
				_BtnConsultar.Click -= value2;
			}
			_BtnConsultar = value;
			if (_BtnConsultar != null)
			{
				_BtnConsultar.Click += value2;
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

	internal GridColumn GridColumn7
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn7 = value;
		}
	}

	internal GridColumn GridColumn8
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn8 = value;
		}
	}

	public FrmRepAsistenciaDia()
	{
		base.Load += FrmRepAsistenciaDia_Load;
		__ENCAddToList(this);
		objRRHHClass = new RRHHClass();
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
		DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition = new DevExpress.XtraGrid.StyleFormatCondition();
		this.GridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.ListTrabajadores = new DevExpress.XtraEditors.ListBoxControl();
		this.ListTrabajadoresRep = new DevExpress.XtraEditors.ListBoxControl();
		this.btnQuitarLista = new System.Windows.Forms.Button();
		this.btnAgregarLista = new System.Windows.Forms.Button();
		this.GroupControl1 = new DevExpress.XtraEditors.GroupControl();
		this.UcFechas1 = new GRLL.Common.ucFechas();
		this.UcCBPartidaPresupuestal = new GRLL.Common.ucComboBox();
		this.Label3 = new System.Windows.Forms.Label();
		this.BtnConsultar = new System.Windows.Forms.Button();
		this.DefaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
		this.GridControl1 = new DevExpress.XtraGrid.GridControl();
		this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.GridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.Button2 = new System.Windows.Forms.Button();
		this.GroupControl2 = new DevExpress.XtraEditors.GroupControl();
		((System.ComponentModel.ISupportInitialize)this.ListTrabajadores).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ListTrabajadoresRep).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GroupControl1).BeginInit();
		this.GroupControl1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.GridControl1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GridView1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GroupControl2).BeginInit();
		this.GroupControl2.SuspendLayout();
		this.SuspendLayout();
		this.cmdCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cmdCerrar.FlatAppearance.BorderSize = 0;
		this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.cmdCerrar.Image = RecursosHumanos.My.Resources.Resources._exit;
		System.Windows.Forms.Button button = this.cmdCerrar;
		System.Drawing.Point location = new System.Drawing.Point(614, 619);
		button.Location = location;
		this.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		System.Windows.Forms.Panel panelSup = this.PanelSup;
		System.Drawing.Size size = new System.Drawing.Size(689, 29);
		panelSup.Size = size;
		System.Windows.Forms.Panel panelInf = this.PanelInf;
		location = new System.Drawing.Point(0, 649);
		panelInf.Location = location;
		System.Windows.Forms.Panel panelInf2 = this.PanelInf;
		size = new System.Drawing.Size(689, 27);
		panelInf2.Size = size;
		this.GridColumn5.Caption = "NombreDia";
		this.GridColumn5.FieldName = "NombreDia";
		this.GridColumn5.Name = "GridColumn5";
		this.GridColumn5.Visible = true;
		this.GridColumn5.VisibleIndex = 2;
		DevExpress.XtraEditors.ListBoxControl listTrabajadores = this.ListTrabajadores;
		location = new System.Drawing.Point(12, 129);
		listTrabajadores.Location = location;
		this.ListTrabajadores.Name = "ListTrabajadores";
		DevExpress.XtraEditors.ListBoxControl listTrabajadores2 = this.ListTrabajadores;
		size = new System.Drawing.Size(305, 297);
		listTrabajadores2.Size = size;
		this.ListTrabajadores.TabIndex = 0;
		this.ListTrabajadoresRep.Dock = System.Windows.Forms.DockStyle.Fill;
		DevExpress.XtraEditors.ListBoxControl listTrabajadoresRep = this.ListTrabajadoresRep;
		location = new System.Drawing.Point(2, 20);
		listTrabajadoresRep.Location = location;
		this.ListTrabajadoresRep.Name = "ListTrabajadoresRep";
		DevExpress.XtraEditors.ListBoxControl listTrabajadoresRep2 = this.ListTrabajadoresRep;
		size = new System.Drawing.Size(269, 275);
		listTrabajadoresRep2.Size = size;
		this.ListTrabajadoresRep.TabIndex = 1;
		this.btnQuitarLista.FlatAppearance.BorderSize = 0;
		this.btnQuitarLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnQuitarLista.Image = RecursosHumanos.My.Resources.Resources.arrow_left_green;
		System.Windows.Forms.Button button2 = this.btnQuitarLista;
		location = new System.Drawing.Point(323, 320);
		button2.Location = location;
		this.btnQuitarLista.Name = "btnQuitarLista";
		System.Windows.Forms.Button button3 = this.btnQuitarLista;
		size = new System.Drawing.Size(75, 23);
		button3.Size = size;
		this.btnQuitarLista.TabIndex = 3;
		this.btnQuitarLista.UseVisualStyleBackColor = true;
		this.btnAgregarLista.AutoSize = true;
		this.btnAgregarLista.FlatAppearance.BorderSize = 0;
		this.btnAgregarLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAgregarLista.Image = RecursosHumanos.My.Resources.Resources.arrow_right_green;
		System.Windows.Forms.Button button4 = this.btnAgregarLista;
		location = new System.Drawing.Point(323, 212);
		button4.Location = location;
		this.btnAgregarLista.Name = "btnAgregarLista";
		System.Windows.Forms.Button button5 = this.btnAgregarLista;
		size = new System.Drawing.Size(75, 23);
		button5.Size = size;
		this.btnAgregarLista.TabIndex = 2;
		this.btnAgregarLista.UseVisualStyleBackColor = true;
		this.GroupControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
		this.GroupControl1.Controls.Add(this.UcFechas1);
		this.GroupControl1.Controls.Add(this.UcCBPartidaPresupuestal);
		this.GroupControl1.Controls.Add(this.Label3);
		this.GroupControl1.Controls.Add(this.BtnConsultar);
		DevExpress.XtraEditors.GroupControl groupControl = this.GroupControl1;
		location = new System.Drawing.Point(12, 36);
		groupControl.Location = location;
		this.GroupControl1.Name = "GroupControl1";
		DevExpress.XtraEditors.GroupControl groupControl2 = this.GroupControl1;
		size = new System.Drawing.Size(452, 87);
		groupControl2.Size = size;
		this.GroupControl1.TabIndex = 4;
		this.GroupControl1.Text = "Parámetros";
		GRLL.Common.ucFechas ucFechas = this.UcFechas1;
		location = new System.Drawing.Point(9, 30);
		ucFechas.Location = location;
		this.UcFechas1.Name = "UcFechas1";
		GRLL.Common.ucFechas ucFechas2 = this.UcFechas1;
		size = new System.Drawing.Size(302, 22);
		ucFechas2.Size = size;
		this.UcFechas1.TabIndex = 2;
		this.UcCBPartidaPresupuestal.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCBPartidaPresupuestal.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCBPartidaPresupuestal.FormattingEnabled = true;
		this.UcCBPartidaPresupuestal.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucCBPartidaPresupuestal = this.UcCBPartidaPresupuestal;
		location = new System.Drawing.Point(49, 58);
		ucCBPartidaPresupuestal.Location = location;
		this.UcCBPartidaPresupuestal.Name = "UcCBPartidaPresupuestal";
		GRLL.Common.ucComboBox ucCBPartidaPresupuestal2 = this.UcCBPartidaPresupuestal;
		size = new System.Drawing.Size(133, 21);
		ucCBPartidaPresupuestal2.Size = size;
		this.UcCBPartidaPresupuestal.TabIndex = 6;
		this.Label3.AutoSize = true;
		System.Windows.Forms.Label label = this.Label3;
		location = new System.Drawing.Point(12, 61);
		label.Location = location;
		this.Label3.Name = "Label3";
		System.Windows.Forms.Label label2 = this.Label3;
		size = new System.Drawing.Size(31, 13);
		label2.Size = size;
		this.Label3.TabIndex = 6;
		this.Label3.Text = "Tipo:";
		this.BtnConsultar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.BtnConsultar.AutoSize = true;
		this.BtnConsultar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.BtnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BtnConsultar.FlatAppearance.BorderSize = 0;
		this.BtnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BtnConsultar.Image = RecursosHumanos.My.Resources.Resources.view1;
		System.Windows.Forms.Button btnConsultar = this.BtnConsultar;
		location = new System.Drawing.Point(370, 56);
		btnConsultar.Location = location;
		this.BtnConsultar.Name = "BtnConsultar";
		System.Windows.Forms.Button btnConsultar2 = this.BtnConsultar;
		size = new System.Drawing.Size(77, 23);
		btnConsultar2.Size = size;
		this.BtnConsultar.TabIndex = 7;
		this.BtnConsultar.Text = "&Consultar";
		this.BtnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.BtnConsultar.UseVisualStyleBackColor = true;
		this.DefaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins";
		this.GridControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.GridControl1.Cursor = System.Windows.Forms.Cursors.Default;
		DevExpress.XtraGrid.GridControl gridControl = this.GridControl1;
		location = new System.Drawing.Point(12, 432);
		gridControl.Location = location;
		this.GridControl1.MainView = this.GridView1;
		this.GridControl1.Name = "GridControl1";
		DevExpress.XtraGrid.GridControl gridControl2 = this.GridControl1;
		size = new System.Drawing.Size(665, 181);
		gridControl2.Size = size;
		this.GridControl1.TabIndex = 5;
		this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[1] { this.GridView1 });
		this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[8] { this.GridColumn1, this.GridColumn8, this.GridColumn5, this.GridColumn4, this.GridColumn2, this.GridColumn3, this.GridColumn6, this.GridColumn7 });
		styleFormatCondition.Appearance.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
		styleFormatCondition.Appearance.Options.UseBackColor = true;
		styleFormatCondition.ApplyToRow = true;
		styleFormatCondition.Column = this.GridColumn5;
		styleFormatCondition.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
		styleFormatCondition.Tag = "Sábado";
		styleFormatCondition.Value1 = "Sábado";
		styleFormatCondition.Value2 = "Domingo";
		this.GridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[1] { styleFormatCondition });
		this.GridView1.GridControl = this.GridControl1;
		this.GridView1.Name = "GridView1";
		this.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
		this.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
		this.GridView1.OptionsBehavior.Editable = false;
		this.GridView1.OptionsView.AllowCellMerge = true;
		this.GridView1.OptionsView.RowAutoHeight = true;
		this.GridView1.OptionsView.ShowGroupPanel = false;
		this.GridColumn1.Caption = "Nombres Completos";
		this.GridColumn1.FieldName = "NombreCompletos";
		this.GridColumn1.Name = "GridColumn1";
		this.GridColumn1.Visible = true;
		this.GridColumn1.VisibleIndex = 0;
		this.GridColumn4.Caption = "Fecha";
		this.GridColumn4.FieldName = "Fecha";
		this.GridColumn4.GroupFormat.FormatString = "dd/MM/yyyy";
		this.GridColumn4.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
		this.GridColumn4.Name = "GridColumn4";
		this.GridColumn4.Visible = true;
		this.GridColumn4.VisibleIndex = 3;
		this.GridColumn2.Caption = "Hora Entrada";
		this.GridColumn2.FieldName = "Entrada";
		this.GridColumn2.Name = "GridColumn2";
		this.GridColumn2.Visible = true;
		this.GridColumn2.VisibleIndex = 4;
		this.GridColumn3.Caption = "Hora Salida";
		this.GridColumn3.FieldName = "Salida";
		this.GridColumn3.Name = "GridColumn3";
		this.GridColumn3.Visible = true;
		this.GridColumn3.VisibleIndex = 5;
		this.GridColumn6.Caption = "Motivo";
		this.GridColumn6.FieldName = "Motivo";
		this.GridColumn6.Name = "GridColumn6";
		this.GridColumn6.Visible = true;
		this.GridColumn6.VisibleIndex = 6;
		this.GridColumn7.Caption = "Documento";
		this.GridColumn7.FieldName = "Documento";
		this.GridColumn7.Name = "GridColumn7";
		this.GridColumn7.Visible = true;
		this.GridColumn7.VisibleIndex = 7;
		this.GridColumn8.Caption = "Area";
		this.GridColumn8.FieldName = "AreaOrganizacional";
		this.GridColumn8.Name = "GridColumn8";
		this.GridColumn8.Visible = true;
		this.GridColumn8.VisibleIndex = 1;
		this.Button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.Button2.AutoSize = true;
		this.Button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.Button2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.Button2.FlatAppearance.BorderSize = 0;
		this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button2.Image = RecursosHumanos.My.Resources.Resources.document_out;
		System.Windows.Forms.Button button6 = this.Button2;
		location = new System.Drawing.Point(12, 620);
		button6.Location = location;
		this.Button2.Name = "Button2";
		System.Windows.Forms.Button button7 = this.Button2;
		size = new System.Drawing.Size(110, 23);
		button7.Size = size;
		this.Button2.TabIndex = 6;
		this.Button2.Text = "Exportar a Excel";
		this.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.Button2.UseVisualStyleBackColor = true;
		this.GroupControl2.Controls.Add(this.ListTrabajadoresRep);
		DevExpress.XtraEditors.GroupControl groupControl3 = this.GroupControl2;
		location = new System.Drawing.Point(404, 129);
		groupControl3.Location = location;
		this.GroupControl2.Name = "GroupControl2";
		DevExpress.XtraEditors.GroupControl groupControl4 = this.GroupControl2;
		size = new System.Drawing.Size(273, 297);
		groupControl4.Size = size;
		this.GroupControl2.TabIndex = 7;
		this.GroupControl2.Text = "Trabajadores Reporte";
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		size = new System.Drawing.Size(689, 676);
		this.ClientSize = size;
		this.Controls.Add(this.GroupControl2);
		this.Controls.Add(this.Button2);
		this.Controls.Add(this.ListTrabajadores);
		this.Controls.Add(this.GridControl1);
		this.Controls.Add(this.GroupControl1);
		this.Controls.Add(this.btnAgregarLista);
		this.Controls.Add(this.btnQuitarLista);
		this.MessageShow = true;
		this.Name = "FrmRepAsistenciaDia";
		this.TitleMsg = "FrmConsulta";
		this.VerCmdCerrar = true;
		this.Controls.SetChildIndex(this.btnQuitarLista, 0);
		this.Controls.SetChildIndex(this.btnAgregarLista, 0);
		this.Controls.SetChildIndex(this.GroupControl1, 0);
		this.Controls.SetChildIndex(this.GridControl1, 0);
		this.Controls.SetChildIndex(this.cmdCerrar, 0);
		this.Controls.SetChildIndex(this.ListTrabajadores, 0);
		this.Controls.SetChildIndex(this.PanelSup, 0);
		this.Controls.SetChildIndex(this.PanelInf, 0);
		this.Controls.SetChildIndex(this.Button2, 0);
		this.Controls.SetChildIndex(this.GroupControl2, 0);
		((System.ComponentModel.ISupportInitialize)this.ListTrabajadores).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ListTrabajadoresRep).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GroupControl1).EndInit();
		this.GroupControl1.ResumeLayout(false);
		this.GroupControl1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.GridControl1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GridView1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GroupControl2).EndInit();
		this.GroupControl2.ResumeLayout(false);
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	private void FrmRepAsistenciaDia_Load(object sender, EventArgs e)
	{
		UcCBPartidaPresupuestal.ValueMember = "IdTipoTrabajador";
		UcCBPartidaPresupuestal.DisplayMember = "Descripcion";
		List<TipoTrabajador> list = TipoTrabajadorMapper.Instance().SelectAll();
		list.Insert(0, new TipoTrabajador
		{
			IdTipoTrabajador = 0,
			Descripcion = "--TODOS--"
		});
		UcCBPartidaPresupuestal.DataSource = list;
	}

	private void btnAgregarLista_Click(object sender, EventArgs e)
	{
		objRRHHClass.spRRHH_AgregarReporte(Conversions.ToInteger(ListTrabajadores.SelectedValue), 1);
		CargarListas();
	}

	private void CargarListas()
	{
		ListTrabajadores.DataSource = objRRHHClass.spRRHH_ListarTrabajadores(Conversions.ToInteger(UcCBPartidaPresupuestal.SelectedValue));
		ListTrabajadores.ValueMember = "IdEmpleado";
		ListTrabajadores.DisplayMember = "NombresCompletos";
		ListTrabajadoresRep.DataSource = objRRHHClass.spRRHH_ListarTrabajadoresRep(Conversions.ToInteger(UcCBPartidaPresupuestal.SelectedValue));
		ListTrabajadoresRep.ValueMember = "IdEmpleado";
		ListTrabajadoresRep.DisplayMember = "NombresCompletos";
	}

	private void btnQuitarLista_Click(object sender, EventArgs e)
	{
		objRRHHClass.spRRHH_AgregarReporte(Conversions.ToInteger(ListTrabajadoresRep.SelectedValue), 2);
		CargarListas();
	}

	private void UcCBPartidaPresupuestal_SelectedIndexChanged(object sender, EventArgs e)
	{
		CargarListas();
	}

	private void BtnConsultar_Click(object sender, EventArgs e)
	{
		fechaI = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(UcFechas1.Rango.Desde.Year.ToString(), Interaction.IIf(UcFechas1.Rango.Desde.Month.ToString().Length == 1, "0" + UcFechas1.Rango.Desde.Month, UcFechas1.Rango.Desde.Month.ToString())), Interaction.IIf(UcFechas1.Rango.Desde.Day.ToString().Length == 1, "0" + UcFechas1.Rango.Desde.Day, UcFechas1.Rango.Desde.Day.ToString())));
		fechaF = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(UcFechas1.Rango.Hasta.Year.ToString(), Interaction.IIf(UcFechas1.Rango.Hasta.Month.ToString().Length == 1, "0" + UcFechas1.Rango.Hasta.Month, UcFechas1.Rango.Hasta.Month.ToString())), Interaction.IIf(UcFechas1.Rango.Hasta.Day.ToString().Length == 1, "0" + UcFechas1.Rango.Hasta.Day, UcFechas1.Rango.Hasta.Day.ToString())));
		GridControl gridControl = GridControl1;
		RRHHClass rRHHClass = objRRHHClass;
		string obj = fechaI;
		string obj2 = fechaF;
		object selectedValue = UcCBPartidaPresupuestal.SelectedValue;
		int? num = default(int?);
		gridControl.DataSource = rRHHClass.spRRHH_RepAsisdiarria(obj, obj2, null, num, (selectedValue != null) ? ((int?)selectedValue) : num, MySettingsProperty.Settings.AnioActual.ToString().Trim(), Conversions.ToString(0), 1);
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
		string text2 = text + "\\Export_Asitencias_diaria_" + Conversions.ToString(DateAndTime.Today.Date.Day) + Conversions.ToString(DateAndTime.Today.Date.Month) + Conversions.ToString(DateAndTime.Today.Date.Year) + DateAndTime.Now.Hour + Conversions.ToString(DateAndTime.Now.Minute) + DateAndTime.Now.Second + Conversions.ToString(DateAndTime.Now.Millisecond) + ".xls";
		xlsExportOptions.SheetName = "Export_Asitencias_diaria";
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
		GridColumnCollection columns = GridView1.Columns;
		array6[1] = columns.Count;
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
				columns.Count,
				RuntimeHelpers.GetObjectValue(array7[1])
			}, null, null, OptimisticSet: true, RValueBase: false);
		}
		NewLateBinding.LateCall(instance3, null, "Merge", new object[0], null, null, null, IgnoreReturn: true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue3, null, "Cells", new object[2] { 2, 1 }, null, null, null), null, "FormulaR1C1", new object[1] { "Reporte de Asistencia" }, null, null, OptimisticSet: false, RValueBase: true);
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
		columns = GridView1.Columns;
		array11[1] = columns.Count;
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
				columns.Count,
				RuntimeHelpers.GetObjectValue(array[1])
			}, null, null, OptimisticSet: true, RValueBase: false);
		}
		NewLateBinding.LateCall(instance5, null, "Merge", new object[0], null, null, null, IgnoreReturn: true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue3, null, "Cells", new object[2] { 3, 1 }, null, null, null), null, "FormulaR1C1", new object[1] { "Del: " + UcFechas1.Rango.Desde.ToLongDateString() + " Al: " + UcFechas1.Rango.Hasta.ToLongDateString() }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue3, null, "Cells", new object[2] { 3, 1 }, null, null, null), null, "HorizontalAlignment", new object[1] { -4108 }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, null, "Columns", new object[1] { "A:Z" }, null, null, null), null, "EntireColumn", new object[0], null, null, null), null, "AutoFit", new object[0], null, null, null, IgnoreReturn: true);
		NewLateBinding.LateSet(objectValue, null, "Visible", new object[1] { true }, null, null);
	}
}
