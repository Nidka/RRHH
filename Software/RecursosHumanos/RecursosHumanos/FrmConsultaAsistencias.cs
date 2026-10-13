using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ClassRRHH;
using DevExpress.Data;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using GRLL.Common;
using Microsoft.Office.Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using RecursosHumanos.My;
using RecursosHumanos.My.Resources;

namespace RecursosHumanos;

[DesignerGenerated]
public class FrmConsultaAsistencias : FrmConsulta
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("GroupControl1")]
	private GroupControl _GroupControl1;

	[AccessedThroughProperty("UcFechas1")]
	private ucFechas _UcFechas1;

	[AccessedThroughProperty("BtnGenerar")]
	private Button _BtnGenerar;

	[AccessedThroughProperty("DefaultLookAndFeel1")]
	private DefaultLookAndFeel _DefaultLookAndFeel1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("UcCBPartidaPresupuestal")]
	private ucComboBox _UcCBPartidaPresupuestal;

	[AccessedThroughProperty("BtnExportarExcel")]
	private Button _BtnExportarExcel;

	[AccessedThroughProperty("SaveFileDialog1")]
	private SaveFileDialog _SaveFileDialog1;

	[AccessedThroughProperty("GridControl1")]
	private GridControl _GridControl1;

	[AccessedThroughProperty("GridView1")]
	private GridView _GridView1;

	[AccessedThroughProperty("GridControl2")]
	private GridControl _GridControl2;

	[AccessedThroughProperty("GridView2")]
	private GridView _GridView2;

	[AccessedThroughProperty("GridControl3")]
	private GridControl _GridControl3;

	[AccessedThroughProperty("GridView3")]
	private GridView _GridView3;

	[AccessedThroughProperty("ToolTipController1")]
	private ToolTipController _ToolTipController1;

	[AccessedThroughProperty("RadioGroupTipo")]
	private RadioGroup _RadioGroupTipo;

	[AccessedThroughProperty("ChckListLocal")]
	private CheckedListBoxControl _ChckListLocal;

	private RRHHClass obj;

	private string fi;

	private string ff;

	private object m_Excel;

	private object objLibroExcel;

	private object objHojaExcel;

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

	internal Button BtnGenerar
	{
		[DebuggerNonUserCode]
		get
		{
			return _BtnGenerar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = BtnGenerar_Click;
			if (_BtnGenerar != null)
			{
				_BtnGenerar.Click -= value2;
			}
			_BtnGenerar = value;
			if (_BtnGenerar != null)
			{
				_BtnGenerar.Click += value2;
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
			_UcCBPartidaPresupuestal = value;
		}
	}

	internal Button BtnExportarExcel
	{
		[DebuggerNonUserCode]
		get
		{
			return _BtnExportarExcel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = Button1_Click;
			if (_BtnExportarExcel != null)
			{
				_BtnExportarExcel.Click -= value2;
			}
			_BtnExportarExcel = value;
			if (_BtnExportarExcel != null)
			{
				_BtnExportarExcel.Click += value2;
			}
		}
	}

	internal SaveFileDialog SaveFileDialog1
	{
		[DebuggerNonUserCode]
		get
		{
			return _SaveFileDialog1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SaveFileDialog1 = value;
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
			_GridControl1 = value;
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

	private GridControl GridControl2
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridControl2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridControl2 = value;
		}
	}

	private GridView GridView2
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridView2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridView2 = value;
		}
	}

	internal GridControl GridControl3
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridControl3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridControl3 = value;
		}
	}

	internal GridView GridView3
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridView3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridView3 = value;
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

	internal RadioGroup RadioGroupTipo
	{
		[DebuggerNonUserCode]
		get
		{
			return _RadioGroupTipo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RadioGroupTipo = value;
		}
	}

	internal CheckedListBoxControl ChckListLocal
	{
		[DebuggerNonUserCode]
		get
		{
			return _ChckListLocal;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = ChckListLocal_SelectedIndexChanged;
			DevExpress.XtraEditors.Controls.ItemCheckEventHandler value3 = ChckListLocal_ItemCheck;
			if (_ChckListLocal != null)
			{
				_ChckListLocal.SelectedIndexChanged -= value2;
				_ChckListLocal.ItemCheck -= value3;
			}
			_ChckListLocal = value;
			if (_ChckListLocal != null)
			{
				_ChckListLocal.SelectedIndexChanged += value2;
				_ChckListLocal.ItemCheck += value3;
			}
		}
	}

	public FrmConsultaAsistencias()
	{
		base.FormClosing += FrmConsultaAsistencias_FormClosing;
		base.Load += FrmConsultaAsistencias_Load;
		__ENCAddToList(this);
		obj = new RRHHClass();
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
		this.GroupControl1 = new DevExpress.XtraEditors.GroupControl();
		this.ChckListLocal = new DevExpress.XtraEditors.CheckedListBoxControl();
		this.RadioGroupTipo = new DevExpress.XtraEditors.RadioGroup();
		this.UcCBPartidaPresupuestal = new GRLL.Common.ucComboBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.BtnGenerar = new System.Windows.Forms.Button();
		this.UcFechas1 = new GRLL.Common.ucFechas();
		this.GridControl1 = new DevExpress.XtraGrid.GridControl();
		this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.DefaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
		this.BtnExportarExcel = new System.Windows.Forms.Button();
		this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
		this.GridControl2 = new DevExpress.XtraGrid.GridControl();
		this.GridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.GridControl3 = new DevExpress.XtraGrid.GridControl();
		this.GridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.ToolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
		((System.ComponentModel.ISupportInitialize)this.GroupControl1).BeginInit();
		this.GroupControl1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.ChckListLocal).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.RadioGroupTipo.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GridControl1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GridView1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GridControl2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GridView2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GridControl3).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GridView3).BeginInit();
		this.SuspendLayout();
		this.cmdCerrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.cmdCerrar.AutoSize = true;
		this.cmdCerrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.cmdCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cmdCerrar.FlatAppearance.BorderSize = 0;
		this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.cmdCerrar.Image = RecursosHumanos.My.Resources.Resources._exit;
		System.Windows.Forms.Button button = this.cmdCerrar;
		System.Drawing.Point location = new System.Drawing.Point(864, 506);
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
		size = new System.Drawing.Size(937, 29);
		panelSup.Size = size;
		System.Windows.Forms.Panel panelInf = this.PanelInf;
		location = new System.Drawing.Point(0, 535);
		panelInf.Location = location;
		System.Windows.Forms.Panel panelInf2 = this.PanelInf;
		size = new System.Drawing.Size(937, 27);
		panelInf2.Size = size;
		this.GroupControl1.Controls.Add(this.ChckListLocal);
		this.GroupControl1.Controls.Add(this.RadioGroupTipo);
		this.GroupControl1.Controls.Add(this.UcCBPartidaPresupuestal);
		this.GroupControl1.Controls.Add(this.Label1);
		this.GroupControl1.Controls.Add(this.BtnGenerar);
		this.GroupControl1.Controls.Add(this.UcFechas1);
		DevExpress.XtraEditors.GroupControl groupControl = this.GroupControl1;
		location = new System.Drawing.Point(12, 35);
		groupControl.Location = location;
		this.GroupControl1.Name = "GroupControl1";
		DevExpress.XtraEditors.GroupControl groupControl2 = this.GroupControl1;
		size = new System.Drawing.Size(404, 140);
		groupControl2.Size = size;
		this.GroupControl1.TabIndex = 0;
		this.GroupControl1.Text = "Parámetros";
		DevExpress.XtraEditors.CheckedListBoxControl chckListLocal = this.ChckListLocal;
		location = new System.Drawing.Point(16, 96);
		chckListLocal.Location = location;
		this.ChckListLocal.MultiColumn = true;
		this.ChckListLocal.Name = "ChckListLocal";
		DevExpress.XtraEditors.CheckedListBoxControl chckListLocal2 = this.ChckListLocal;
		size = new System.Drawing.Size(298, 38);
		chckListLocal2.Size = size;
		this.ChckListLocal.TabIndex = 16;
		this.RadioGroupTipo.AutoSizeInLayoutControl = true;
		this.RadioGroupTipo.EditValue = "A";
		DevExpress.XtraEditors.RadioGroup radioGroupTipo = this.RadioGroupTipo;
		location = new System.Drawing.Point(219, 33);
		radioGroupTipo.Location = location;
		this.RadioGroupTipo.Name = "RadioGroupTipo";
		this.RadioGroupTipo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
		this.RadioGroupTipo.Properties.Appearance.Options.UseBackColor = true;
		this.RadioGroupTipo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
		this.RadioGroupTipo.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[2]
		{
			new DevExpress.XtraEditors.Controls.RadioGroupItem("A", "Asistencias"),
			new DevExpress.XtraEditors.Controls.RadioGroupItem("P", "Productividad")
		});
		DevExpress.XtraEditors.RadioGroup radioGroupTipo2 = this.RadioGroupTipo;
		size = new System.Drawing.Size(173, 28);
		radioGroupTipo2.Size = size;
		this.RadioGroupTipo.TabIndex = 9;
		this.UcCBPartidaPresupuestal.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCBPartidaPresupuestal.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCBPartidaPresupuestal.FormattingEnabled = true;
		this.UcCBPartidaPresupuestal.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucCBPartidaPresupuestal = this.UcCBPartidaPresupuestal;
		location = new System.Drawing.Point(56, 35);
		ucCBPartidaPresupuestal.Location = location;
		this.UcCBPartidaPresupuestal.Name = "UcCBPartidaPresupuestal";
		GRLL.Common.ucComboBox ucCBPartidaPresupuestal2 = this.UcCBPartidaPresupuestal;
		size = new System.Drawing.Size(150, 21);
		ucCBPartidaPresupuestal2.Size = size;
		this.UcCBPartidaPresupuestal.TabIndex = 1;
		this.Label1.AutoSize = true;
		System.Windows.Forms.Label label = this.Label1;
		location = new System.Drawing.Point(19, 38);
		label.Location = location;
		this.Label1.Name = "Label1";
		System.Windows.Forms.Label label2 = this.Label1;
		size = new System.Drawing.Size(31, 13);
		label2.Size = size;
		this.Label1.TabIndex = 8;
		this.Label1.Text = "Tipo:";
		this.BtnGenerar.AutoSize = true;
		this.BtnGenerar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.BtnGenerar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BtnGenerar.FlatAppearance.BorderSize = 0;
		this.BtnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BtnGenerar.Image = RecursosHumanos.My.Resources.Resources.document_out;
		System.Windows.Forms.Button btnGenerar = this.BtnGenerar;
		location = new System.Drawing.Point(321, 96);
		btnGenerar.Location = location;
		this.BtnGenerar.Name = "BtnGenerar";
		System.Windows.Forms.Button btnGenerar2 = this.BtnGenerar;
		size = new System.Drawing.Size(71, 23);
		btnGenerar2.Size = size;
		this.BtnGenerar.TabIndex = 3;
		this.BtnGenerar.Text = "Generar";
		this.BtnGenerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.BtnGenerar.UseVisualStyleBackColor = true;
		GRLL.Common.ucFechas ucFechas = this.UcFechas1;
		location = new System.Drawing.Point(12, 68);
		ucFechas.Location = location;
		this.UcFechas1.Name = "UcFechas1";
		GRLL.Common.ucFechas ucFechas2 = this.UcFechas1;
		size = new System.Drawing.Size(302, 22);
		ucFechas2.Size = size;
		this.UcFechas1.TabIndex = 2;
		this.GridControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		DevExpress.XtraGrid.GridControl gridControl = this.GridControl1;
		location = new System.Drawing.Point(12, 181);
		gridControl.Location = location;
		this.GridControl1.LookAndFeel.SkinName = "Blue";
		this.GridControl1.LookAndFeel.UseDefaultLookAndFeel = false;
		this.GridControl1.MainView = this.GridView1;
		this.GridControl1.Name = "GridControl1";
		DevExpress.XtraGrid.GridControl gridControl2 = this.GridControl1;
		size = new System.Drawing.Size(913, 314);
		gridControl2.Size = size;
		this.GridControl1.TabIndex = 1;
		this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[1] { this.GridView1 });
		this.GridView1.GridControl = this.GridControl1;
		this.GridView1.Name = "GridView1";
		this.GridView1.OptionsBehavior.Editable = false;
		this.GridView1.OptionsCustomization.AllowColumnMoving = false;
		this.GridView1.OptionsCustomization.AllowColumnResizing = false;
		this.GridView1.OptionsCustomization.AllowFilter = false;
		this.GridView1.OptionsCustomization.AllowGroup = false;
		this.GridView1.OptionsView.ColumnAutoWidth = false;
		this.GridView1.OptionsView.ShowGroupPanel = false;
		this.DefaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins";
		this.BtnExportarExcel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.BtnExportarExcel.AutoSize = true;
		this.BtnExportarExcel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BtnExportarExcel.FlatAppearance.BorderSize = 0;
		this.BtnExportarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BtnExportarExcel.Image = RecursosHumanos.My.Resources.Resources.document_out;
		System.Windows.Forms.Button btnExportarExcel = this.BtnExportarExcel;
		location = new System.Drawing.Point(12, 501);
		btnExportarExcel.Location = location;
		this.BtnExportarExcel.Name = "BtnExportarExcel";
		System.Windows.Forms.Button btnExportarExcel2 = this.BtnExportarExcel;
		size = new System.Drawing.Size(112, 23);
		btnExportarExcel2.Size = size;
		toolTipTitleItem2.Appearance.Image = RecursosHumanos.My.Resources.Resources.help2;
		toolTipTitleItem2.Appearance.Options.UseImage = true;
		toolTipTitleItem2.Image = RecursosHumanos.My.Resources.Resources.help2;
		toolTipTitleItem2.Text = "Ayuda";
		toolTipItem2.LeftIndent = 6;
		toolTipItem2.Text = "Envia la Informacion generada a una Hoja Excel.";
		superToolTip2.Items.Add(toolTipTitleItem2);
		superToolTip2.Items.Add(toolTipItem2);
		this.ToolTipController1.SetSuperTip(this.BtnExportarExcel, superToolTip2);
		this.BtnExportarExcel.TabIndex = 2;
		this.BtnExportarExcel.Text = "Exportar a Excel";
		this.BtnExportarExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.BtnExportarExcel.UseVisualStyleBackColor = true;
		DevExpress.XtraGrid.GridControl gridControl3 = this.GridControl2;
		location = new System.Drawing.Point(715, 66);
		gridControl3.Location = location;
		this.GridControl2.MainView = this.GridView2;
		this.GridControl2.Name = "GridControl2";
		DevExpress.XtraGrid.GridControl gridControl4 = this.GridControl2;
		size = new System.Drawing.Size(210, 135);
		gridControl4.Size = size;
		this.GridControl2.TabIndex = 14;
		this.GridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[1] { this.GridView2 });
		this.GridControl2.Visible = false;
		this.GridView2.GridControl = this.GridControl2;
		this.GridView2.Name = "GridView2";
		this.GridView2.OptionsView.ShowGroupPanel = false;
		DevExpress.XtraGrid.GridControl gridControl5 = this.GridControl3;
		location = new System.Drawing.Point(738, 48);
		gridControl5.Location = location;
		this.GridControl3.MainView = this.GridView3;
		this.GridControl3.Name = "GridControl3";
		DevExpress.XtraGrid.GridControl gridControl6 = this.GridControl3;
		size = new System.Drawing.Size(187, 178);
		gridControl6.Size = size;
		this.GridControl3.TabIndex = 15;
		this.GridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[1] { this.GridView3 });
		this.GridControl3.Visible = false;
		this.GridView3.GridControl = this.GridControl3;
		this.GridView3.Name = "GridView3";
		this.GridView3.OptionsCustomization.AllowGroup = false;
		this.GridView3.OptionsView.ShowGroupPanel = false;
		this.ToolTipController1.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip;
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		size = new System.Drawing.Size(937, 562);
		this.ClientSize = size;
		this.Controls.Add(this.BtnExportarExcel);
		this.Controls.Add(this.GroupControl1);
		this.Controls.Add(this.GridControl1);
		this.Controls.Add(this.GridControl2);
		this.Controls.Add(this.GridControl3);
		this.MessageShow = true;
		this.Name = "FrmConsultaAsistencias";
		this.TitleMsg = "FrmConsulta";
		this.Titulo = "Reporte Asistencias";
		this.VerCmdCerrar = true;
		this.Controls.SetChildIndex(this.GridControl3, 0);
		this.Controls.SetChildIndex(this.GridControl2, 0);
		this.Controls.SetChildIndex(this.GridControl1, 0);
		this.Controls.SetChildIndex(this.GroupControl1, 0);
		this.Controls.SetChildIndex(this.cmdCerrar, 0);
		this.Controls.SetChildIndex(this.PanelSup, 0);
		this.Controls.SetChildIndex(this.PanelInf, 0);
		this.Controls.SetChildIndex(this.BtnExportarExcel, 0);
		((System.ComponentModel.ISupportInitialize)this.GroupControl1).EndInit();
		this.GroupControl1.ResumeLayout(false);
		this.GroupControl1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.ChckListLocal).EndInit();
		((System.ComponentModel.ISupportInitialize)this.RadioGroupTipo.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GridControl1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GridView1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GridControl2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GridView2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GridControl3).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GridView3).EndInit();
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	private void BtnGenerar_Click(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(UcCBPartidaPresupuestal.SelectedValue, 0, TextCompare: false))
		{
			MessageBox.Show("Debe Seleccionar un Tipo de Trabajador", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		if (DateTime.Compare(UcFechas1.Rango.Desde, UcFechas1.Rango.Hasta) > 0)
		{
			MessageBox.Show("La Fecha de Inicio no puede ser Mayor a la de Término", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		WindowState = FormWindowState.Maximized;
		GridView1.Columns.Clear();
		fi = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(UcFechas1.Rango.Desde.Year.ToString(), Interaction.IIf(UcFechas1.Rango.Desde.Month.ToString().Length == 1, "0" + UcFechas1.Rango.Desde.Month, UcFechas1.Rango.Desde.Month.ToString())), Interaction.IIf(UcFechas1.Rango.Desde.Day.ToString().Length == 1, "0" + UcFechas1.Rango.Desde.Day, UcFechas1.Rango.Desde.Day.ToString())));
		ff = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(UcFechas1.Rango.Hasta.Year.ToString(), Interaction.IIf(UcFechas1.Rango.Hasta.Month.ToString().Length == 1, "0" + UcFechas1.Rango.Hasta.Month, UcFechas1.Rango.Hasta.Month.ToString())), Interaction.IIf(UcFechas1.Rango.Hasta.Day.ToString().Length == 1, "0" + UcFechas1.Rango.Hasta.Day, UcFechas1.Rango.Hasta.Day.ToString())));
		string text = "[";
		int num = 0;
		TimeSpan timeSpan = UcFechas1.Rango.Hasta - UcFechas1.Rango.Desde;
		double totalDays = timeSpan.TotalDays;
		double num2 = 0.0;
		checked
		{
			while (true)
			{
				double num3 = num2;
				double num4 = totalDays;
				if (!(num3 <= num4))
				{
					break;
				}
				RRHH_TempFecha rRHH_TempFecha = new RRHH_TempFecha();
				rRHH_TempFecha.Fecha = UcFechas1.Rango.Desde.AddDays(num2);
				RRHH_TempFechaMapper.Instance().Insert(rRHH_TempFecha);
				text = text + Conversions.ToString(UcFechas1.Rango.Desde.AddDays(num2)) + "] , [";
				if ((UcFechas1.Rango.Desde.AddDays(num2).DayOfWeek == DayOfWeek.Saturday) | (UcFechas1.Rango.Desde.AddDays(num2).DayOfWeek == DayOfWeek.Sunday))
				{
					num++;
				}
				num2 += 1.0;
			}
			string text2 = "";
			int num5 = ChckListLocal.ItemCount - 1;
			int num6 = 1;
			while (true)
			{
				int num7 = num6;
				int num8 = num5;
				if (num7 > num8)
				{
					break;
				}
				if (ChckListLocal.GetItemCheckState(num6) == CheckState.Checked)
				{
					text2 = Conversions.ToString(Operators.AddObject(text2, Operators.ConcatenateObject(ChckListLocal.GetItemValue(num6), ",")));
				}
				num6++;
			}
			if (text2.Length > 0)
			{
				text2 = text2.Substring(0, text2.Length - 1);
				dcGRLLDataContext dcGrll = Module1.DcGrll;
				string fI = fi;
				string obj = ff;
				int? anio = 2011;
				object selectedValue = UcCBPartidaPresupuestal.SelectedValue;
				int? num9 = default(int?);
				dcGrll.spRRHH_GetReporteAsistencia(fI, obj, anio, (selectedValue != null) ? ((int?)selectedValue) : num9);
				GridControl1.DataSource = RuntimeHelpers.GetObjectValue(this.obj.LlenarPlanillaAsistencia(text.Substring(0, text.Length - 3), Conversions.ToString(UcCBPartidaPresupuestal.SelectedValue), text2));
				double totalDays2 = timeSpan.TotalDays;
				double num10 = 0.0;
				while (true)
				{
					double num11 = num10;
					double num4 = totalDays2;
					if (!(num11 <= num4))
					{
						break;
					}
					int num12 = GridView1.Columns.Count - 1;
					int num13 = 0;
					while (true)
					{
						int num14 = num13;
						int num8 = num12;
						if (num14 > num8)
						{
							break;
						}
						GridView1.Columns[Conversions.ToString(UcFechas1.Rango.Desde.AddDays(num10))].Caption = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Interaction.IIf(UcFechas1.Rango.Desde.AddDays(num10).Day.ToString().Length == 1, "0" + UcFechas1.Rango.Desde.AddDays(num10).Day, UcFechas1.Rango.Desde.AddDays(num10).Day.ToString()), "/"), Interaction.IIf(UcFechas1.Rango.Desde.AddDays(num10).Month.ToString().Length == 1, "0" + UcFechas1.Rango.Desde.AddDays(num10).Month, UcFechas1.Rango.Desde.AddDays(num10).Month.ToString())));
						GridView1.Columns[Conversions.ToString(UcFechas1.Rango.Desde.AddDays(num10))].BestFit();
						num13++;
					}
					num10 += 1.0;
				}
				GridView1.Columns["IdEmpleado"].Visible = false;
				GridView1.Columns["MinTardeT"].UnboundType = UnboundColumnType.String;
				GridView1.Columns["MinTardeT"].VisibleIndex = GridView1.Columns.Count;
				GridView1.Columns["MinTardeT"].Caption = "Minutos Tarde";
				GridView1.Columns["DiasTardeT"].UnboundType = UnboundColumnType.String;
				GridView1.Columns["DiasTardeT"].VisibleIndex = GridView1.Columns.Count;
				GridView1.Columns["DiasTardeT"].Caption = "Total Dias Tarde";
				GridView1.Columns["DiasAsistidos"].UnboundType = UnboundColumnType.String;
				GridView1.Columns["DiasAsistidos"].VisibleIndex = GridView1.Columns.Count;
				GridView1.Columns["DiasAsistidos"].Caption = "Total Dias Asistidos";
				GridView1.Columns["NombresC"].Width = 220;
				GridView1.Columns["NombresC"].Caption = "Nombres Completos";
				GridControl2.DataSource = Module1.DcGrll.spRRHH_GetMinTarde(fi, ff, Conversions.ToChar(UcCBPartidaPresupuestal.SelectedValue.ToString()));
				int num15 = GridView2.RowCount - 1;
				int num16 = 0;
				while (true)
				{
					int num17 = num16;
					int num8 = num15;
					if (num17 > num8)
					{
						break;
					}
					int num18 = GridView1.RowCount - 1;
					int num19 = 0;
					while (true)
					{
						int num20 = num19;
						num8 = num18;
						if (num20 > num8)
						{
							break;
						}
						if (Operators.ConditionalCompareObjectEqual(GridView2.GetRowCellValue(num16, "IdEmpleado"), GridView1.GetRowCellValue(num19, "IdEmpleado"), TextCompare: false))
						{
							object objectValue = RuntimeHelpers.GetObjectValue(GridView2.GetRowCellValue(num16, "Tarde"));
							object objectValue2 = RuntimeHelpers.GetObjectValue(GridView2.GetRowCellValue(num16, "DiasTarde"));
							GridView1.SetRowCellValue(num19, "MinTardeT", RuntimeHelpers.GetObjectValue(objectValue));
							GridView1.SetRowCellValue(num19, "DiasTardeT", RuntimeHelpers.GetObjectValue(objectValue2));
							break;
						}
						num19++;
					}
					num16++;
				}
				if (Operators.ConditionalCompareObjectEqual(RadioGroupTipo.EditValue, "A", TextCompare: false))
				{
					GridControl3.DataSource = Module1.DcGrll.spRRHH_GetDiasAsistidos(fi, ff, Conversions.ToChar(UcCBPartidaPresupuestal.SelectedValue.ToString()));
					int num21 = GridView3.RowCount - 1;
					int num22 = 0;
					while (true)
					{
						int num23 = num22;
						int num8 = num21;
						if (num23 > num8)
						{
							break;
						}
						int num24 = GridView1.RowCount - 1;
						int num25 = 0;
						while (true)
						{
							int num26 = num25;
							num8 = num24;
							if (num26 > num8)
							{
								break;
							}
							if (Operators.ConditionalCompareObjectEqual(GridView3.GetRowCellValue(num22, "IdEmpleado"), GridView1.GetRowCellValue(num25, "IdEmpleado"), TextCompare: false))
							{
								object obj2 = Operators.AddObject(num, GridView3.GetRowCellValue(num22, "Dias_Asistidos"));
								GridView1.SetRowCellValue(num25, "DiasAsistidos", RuntimeHelpers.GetObjectValue(obj2));
								break;
							}
							num25++;
						}
						num22++;
					}
				}
				else if (Operators.ConditionalCompareObjectEqual(RadioGroupTipo.EditValue, "P", TextCompare: false))
				{
					GridControl3.DataSource = Module1.DcGrll.spRRHH_GetDiasAsistidos(fi, ff, Conversions.ToChar(UcCBPartidaPresupuestal.SelectedValue.ToString()));
					int num27 = GridView3.RowCount - 1;
					int num28 = 0;
					while (true)
					{
						int num29 = num28;
						int num8 = num27;
						if (num29 > num8)
						{
							break;
						}
						int num30 = GridView1.RowCount - 1;
						int num31 = 0;
						while (true)
						{
							int num32 = num31;
							num8 = num30;
							if (num32 > num8)
							{
								break;
							}
							if (Operators.ConditionalCompareObjectEqual(GridView3.GetRowCellValue(num28, "IdEmpleado"), GridView1.GetRowCellValue(num31, "IdEmpleado"), TextCompare: false))
							{
								object objectValue3 = RuntimeHelpers.GetObjectValue(GridView3.GetRowCellValue(num28, "Dias_Asistidos"));
								GridView1.SetRowCellValue(num31, "DiasAsistidos", RuntimeHelpers.GetObjectValue(objectValue3));
								break;
							}
							num31++;
						}
						num28++;
					}
				}
				else
				{
					MessageBox.Show("Debe Seleccionar un Tipo de Reporte para Continuar", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
			else
			{
				MessageBox.Show("Debe Seleccionar un Lugar de Marcado", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
	}

	private void FrmConsultaAsistencias_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (objLibroExcel != null)
		{
			EiminaReferencias(ref objHojaExcel);
			EiminaReferencias(ref objLibroExcel);
			EiminaReferencias(ref m_Excel);
		}
		GC.WaitForPendingFinalizers();
		GC.Collect();
	}

	private void FrmConsultaAsistencias_Load(object sender, EventArgs e)
	{
		UcCBPartidaPresupuestal.ValueMember = "IdTipoTrabajador";
		UcCBPartidaPresupuestal.DisplayMember = "Descripcion";
		List<TipoTrabajador> list = TipoTrabajadorMapper.Instance().SelectAll();
		list.Insert(0, new TipoTrabajador
		{
			IdTipoTrabajador = 0,
			Descripcion = "--SELECCIONAR--"
		});
		UcCBPartidaPresupuestal.DataSource = list;
		List<Local> list2 = LocalMapper.Instance().SelectAll();
		list2.Insert(0, new Local
		{
			idLocal = 0,
			NombreLocal = "TODOS"
		});
		ChckListLocal.ValueMember = "idLocal";
		ChckListLocal.DisplayMember = "NombreLocal";
		ChckListLocal.DataSource = list2;
		if (Conversions.ToDouble(RRHH.IdROl) == 10.0)
		{
			UcCBPartidaPresupuestal.SelectedValue = 1;
			UcCBPartidaPresupuestal.Enabled = false;
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 14.0)
		{
			UcCBPartidaPresupuestal.SelectedValue = 2;
			UcCBPartidaPresupuestal.Enabled = false;
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 13.0)
		{
			UcCBPartidaPresupuestal.Enabled = true;
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		if (GridView1.RowCount == 0)
		{
			MessageBox.Show("Debe existir como minimo, un registro para exportar", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		XlsExportOptions xlsExportOptions = new XlsExportOptions();
		string text = MyProject.Computer.FileSystem.SpecialDirectories.MyDocuments.ToString();
		string text2 = text + "\\Reporte_AutoGenerado_Asistencias" + Conversions.ToString(DateAndTime.Today.Date.Day) + Conversions.ToString(DateAndTime.Today.Date.Month) + Conversions.ToString(DateAndTime.Today.Date.Year) + DateAndTime.Now.Hour + Conversions.ToString(DateAndTime.Now.Minute) + DateAndTime.Now.Second + Conversions.ToString(DateAndTime.Now.Millisecond) + ".xls";
		xlsExportOptions.SheetName = "Reporte_AutoGenerado_Asistencias_" + fi + "_" + ff;
		GridControl1.ExportToXls(text2, xlsExportOptions);
		if (!MyProject.Computer.FileSystem.FileExists(text2))
		{
			Interaction.MsgBox(text2 + " No Existe");
			return;
		}
		m_Excel = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Excel.Application"));
		object instance = NewLateBinding.LateGet(m_Excel, null, "Workbooks", new object[0], null, null, null);
		object[] array = new object[1] { text2 };
		object[] arguments = array;
		bool[] array2 = new bool[1] { true };
		object obj = NewLateBinding.LateGet(instance, null, "Open", arguments, null, null, array2);
		if (array2[0])
		{
			text2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
		}
		objLibroExcel = RuntimeHelpers.GetObjectValue(obj);
		objHojaExcel = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objLibroExcel, null, "Worksheets", new object[1] { 1 }, null, null, null));
		NewLateBinding.LateCall(NewLateBinding.LateGet(objHojaExcel, null, "Rows", new object[1] { "1:5" }, null, null, null), null, "insert", new object[0], null, null, null, IgnoreReturn: true);
		NewLateBinding.LateCall(objHojaExcel, null, "Select", new object[0], null, null, null, IgnoreReturn: true);
		if (MyProject.Computer.FileSystem.FileExists(MySettingsProperty.Settings.RutaLogo))
		{
			object instance2 = NewLateBinding.LateGet(objHojaExcel, null, "Shapes", new object[0], null, null, null);
			array = new object[7];
			object[] array3 = array;
			MySettings settings = MySettingsProperty.Settings;
			array3[0] = settings.RutaLogo;
			array[1] = MsoTriState.msoFalse;
			array[2] = MsoTriState.msoCTrue;
			array[3] = 5;
			array[4] = 5;
			array[5] = 50;
			array[6] = 50;
			object[] array4 = array;
			object[] arguments2 = array4;
			array2 = new bool[7] { true, false, false, false, false, false, false };
			NewLateBinding.LateCall(instance2, null, "AddPicture", arguments2, null, null, array2, IgnoreReturn: true);
			if (array2[0])
			{
				settings.RutaLogo = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string));
			}
		}
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Rows", new object[1] { "6:6" }, null, null, null), null, "RowHeight", new object[1] { 48 }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Rows", new object[1] { "6:6" }, null, null, null), null, "Orientation", new object[1] { 90 }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2] { 6, 1 }, null, null, null), null, "Orientation", new object[1] { 0 }, null, null, OptimisticSet: false, RValueBase: true);
		checked
		{
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2]
			{
				6,
				GridView1.Columns.Count - 1
			}, null, null, null), null, "Orientation", new object[1] { 0 }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2]
			{
				6,
				GridView1.Columns.Count - 1
			}, null, null, null), null, "VerticalAlignment", new object[1] { -4108 }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2] { 6, 1 }, null, null, null), null, "VerticalAlignment", new object[1] { -4108 }, null, null, OptimisticSet: false, RValueBase: true);
			object instance3 = objHojaExcel;
			object[] array4 = new object[2] { "A2", null };
			object[] array5 = array4;
			object obj2 = objHojaExcel;
			object instance4 = obj2;
			array = new object[2];
			object[] array6 = array;
			int num = 2;
			array6[0] = num;
			object[] array7 = array;
			int num2 = GridView1.Columns.Count - 1;
			array7[1] = num2;
			array5[1] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(instance4, null, "Cells", array, null, null, null));
			object[] array8 = array4;
			object[] arguments3 = array8;
			array2 = new bool[2] { false, true };
			object instance5 = NewLateBinding.LateGet(instance3, null, "Range", arguments3, null, null, array2);
			if (array2[1])
			{
				NewLateBinding.LateSetComplex(obj2, null, "Cells", new object[3]
				{
					num,
					num2,
					RuntimeHelpers.GetObjectValue(array8[1])
				}, null, null, OptimisticSet: true, RValueBase: false);
			}
			NewLateBinding.LateCall(instance5, null, "Merge", new object[0], null, null, null, IgnoreReturn: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2] { 2, 1 }, null, null, null), null, "FormulaR1C1", new object[1] { "Reporte de Asistencias" }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2] { 2, 1 }, null, null, null), null, "HorizontalAlignment", new object[1] { -4108 }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objHojaExcel, null, "Rows", new object[1] { "2:2" }, null, null, null), null, "Font", new object[0], null, null, null), null, "Size", new object[1] { 16 }, null, null, OptimisticSet: false, RValueBase: true);
			object instance6 = objHojaExcel;
			array8 = new object[2] { "A3", null };
			object[] array9 = array8;
			obj2 = objHojaExcel;
			object instance7 = obj2;
			object[] array10 = new object[2];
			object[] array11 = array10;
			num = 3;
			array11[0] = num;
			object[] array12 = array10;
			num2 = GridView1.Columns.Count - 1;
			array12[1] = num2;
			array9[1] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(instance7, null, "Cells", array10, null, null, null));
			array = array8;
			object[] arguments4 = array;
			array2 = new bool[2] { false, true };
			object instance8 = NewLateBinding.LateGet(instance6, null, "Range", arguments4, null, null, array2);
			if (array2[1])
			{
				NewLateBinding.LateSetComplex(obj2, null, "Cells", new object[3]
				{
					num,
					num2,
					RuntimeHelpers.GetObjectValue(array[1])
				}, null, null, OptimisticSet: true, RValueBase: false);
			}
			NewLateBinding.LateCall(instance8, null, "Merge", new object[0], null, null, null, IgnoreReturn: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2] { 3, 1 }, null, null, null), null, "FormulaR1C1", new object[1] { "Del: " + Conversions.ToString(UcFechas1.Rango.Desde) + " al " + Conversions.ToString(UcFechas1.Rango.Hasta) }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2] { 3, 1 }, null, null, null), null, "HorizontalAlignment", new object[1] { -4108 }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(objHojaExcel, null, "Columns", new object[1] { "A:Z" }, null, null, null), null, "EntireColumn", new object[0], null, null, null), null, "AutoFit", new object[0], null, null, null, IgnoreReturn: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "PageSetup", new object[0], null, null, null), null, "Orientation", new object[1] { 2 }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "PageSetup", new object[0], null, null, null), null, "PrintTitleRows", new object[1] { "$1:$6" }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2]
			{
				GridView1.RowCount + 7,
				1
			}, null, null, null), null, "FormulaR1C1", new object[1] { "Leyenda:" }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2]
			{
				GridView1.RowCount + 7,
				2
			}, null, null, null), null, "FormulaR1C1", new object[1] { "Abrev" }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2]
			{
				GridView1.RowCount + 7,
				3
			}, null, null, null), null, "FormulaR1C1", new object[1] { "Descripción" }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2]
			{
				GridView1.RowCount + 7,
				1
			}, null, null, null), null, "Font", new object[0], null, null, null), null, "Bold", new object[1] { true }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2]
			{
				GridView1.RowCount + 7,
				2
			}, null, null, null), null, "Font", new object[0], null, null, null), null, "Bold", new object[1] { true }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2]
			{
				GridView1.RowCount + 7,
				3
			}, null, null, null), null, "Font", new object[0], null, null, null), null, "Bold", new object[1] { true }, null, null, OptimisticSet: false, RValueBase: true);
			DataTable dataTable = new DataTable();
			dataTable = this.obj.spRRHH_ListarMotivos_byTipo("P");
			int num3 = dataTable.Rows.Count - 1;
			int num4 = 0;
			while (true)
			{
				int num5 = num4;
				int num6 = num3;
				if (num5 > num6)
				{
					break;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2]
				{
					GridView1.RowCount + 8 + num4,
					2
				}, null, null, null), null, "FormulaR1C1", new object[1] { dataTable.Rows[num4]["Abrev"].ToString() }, null, null, OptimisticSet: false, RValueBase: true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2]
				{
					GridView1.RowCount + 8 + num4,
					2
				}, null, null, null), null, "Font", new object[0], null, null, null), null, "Size", new object[1] { 8 }, null, null, OptimisticSet: false, RValueBase: true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2]
				{
					GridView1.RowCount + 8 + num4,
					2
				}, null, null, null), null, "Font", new object[0], null, null, null), null, "Name", new object[1] { "Tahoma" }, null, null, OptimisticSet: false, RValueBase: true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2]
				{
					GridView1.RowCount + 8 + num4,
					2
				}, null, null, null), null, "Font", new object[0], null, null, null), null, "Italic", new object[1] { true }, null, null, OptimisticSet: false, RValueBase: true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2]
				{
					GridView1.RowCount + 8 + num4,
					3
				}, null, null, null), null, "FormulaR1C1", new object[1] { dataTable.Rows[num4][1].ToString() }, null, null, OptimisticSet: false, RValueBase: true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2]
				{
					GridView1.RowCount + 8 + num4,
					3
				}, null, null, null), null, "Font", new object[0], null, null, null), null, "Size", new object[1] { 8 }, null, null, OptimisticSet: false, RValueBase: true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2]
				{
					GridView1.RowCount + 8 + num4,
					3
				}, null, null, null), null, "Font", new object[0], null, null, null), null, "Name", new object[1] { "Tahoma" }, null, null, OptimisticSet: false, RValueBase: true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2]
				{
					GridView1.RowCount + 8 + num4,
					3
				}, null, null, null), null, "Font", new object[0], null, null, null), null, "Italic", new object[1] { true }, null, null, OptimisticSet: false, RValueBase: true);
				num4++;
			}
			NewLateBinding.LateSet(m_Excel, null, "Visible", new object[1] { true }, null, null);
		}
	}

	private void EiminaReferencias(ref object Referencias)
	{
		try
		{
			Marshal.ReleaseComObject(RuntimeHelpers.GetObjectValue(Referencias));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		finally
		{
			Referencias = null;
		}
	}

	private void ChckListLocal_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
	{
		if (e.Index != 0)
		{
			return;
		}
		checked
		{
			if (ChckListLocal.GetItemCheckState(0) == CheckState.Checked)
			{
				int num = ChckListLocal.ItemCount - 1;
				int num2 = 1;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 <= num4)
					{
						ChckListLocal.SetItemChecked(num2, value: true);
						num2++;
						continue;
					}
					break;
				}
			}
			else
			{
				if (ChckListLocal.GetItemCheckState(0) != 0)
				{
					return;
				}
				int num5 = ChckListLocal.ItemCount - 1;
				int num6 = 1;
				while (true)
				{
					int num7 = num6;
					int num4 = num5;
					if (num7 <= num4)
					{
						ChckListLocal.SetItemChecked(num6, value: false);
						num6++;
						continue;
					}
					break;
				}
			}
		}
	}

	private void ChckListLocal_SelectedIndexChanged(object sender, EventArgs e)
	{
	}
}
