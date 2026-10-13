using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
using Microsoft.Office.Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using RecursosHumanos.My;
using RecursosHumanos.My.Resources;

namespace RecursosHumanos;

[DesignerGenerated]
public class FrmConsultaFaltas : FrmConsulta
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("UcDateTime1")]
	private ucDateTime _UcDateTime1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("BtnConsultar")]
	private Button _BtnConsultar;

	[AccessedThroughProperty("GridControl1")]
	private GridControl _GridControl1;

	[AccessedThroughProperty("GridView1")]
	private GridView _GridView1;

	[AccessedThroughProperty("GroupControl1")]
	private GroupControl _GroupControl1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("UcCBArea")]
	private ucComboBox _UcCBArea;

	[AccessedThroughProperty("UcCBPartidaPresupuestal")]
	private ucComboBox _UcCBPartidaPresupuestal;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("DefaultLookAndFeel1")]
	private DefaultLookAndFeel _DefaultLookAndFeel1;

	[AccessedThroughProperty("GridColumn1")]
	private GridColumn _GridColumn1;

	[AccessedThroughProperty("GridColumn2")]
	private GridColumn _GridColumn2;

	[AccessedThroughProperty("GridColumn3")]
	private GridColumn _GridColumn3;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Lbl_Faltas")]
	private Label _Lbl_Faltas;

	[AccessedThroughProperty("BtnExportar")]
	private Button _BtnExportar;

	[AccessedThroughProperty("ToolTipController1")]
	private ToolTipController _ToolTipController1;

	private RRHHClass objClassRRHH;

	private int? tipo;

	private int? area;

	private string fecha;

	internal ucDateTime UcDateTime1
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcDateTime1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcDateTime1 = value;
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

	internal ucComboBox UcCBArea
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcCBArea;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcCBArea = value;
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

	internal Label Lbl_Faltas
	{
		[DebuggerNonUserCode]
		get
		{
			return _Lbl_Faltas;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Lbl_Faltas = value;
		}
	}

	internal Button BtnExportar
	{
		[DebuggerNonUserCode]
		get
		{
			return _BtnExportar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = BtnExportar_Click;
			if (_BtnExportar != null)
			{
				_BtnExportar.Click -= value2;
			}
			_BtnExportar = value;
			if (_BtnExportar != null)
			{
				_BtnExportar.Click += value2;
			}
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

	public FrmConsultaFaltas()
	{
		base.Load += FrmConsultaFaltas_Load;
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
		DevExpress.Utils.SuperToolTip superToolTip = new DevExpress.Utils.SuperToolTip();
		DevExpress.Utils.ToolTipTitleItem toolTipTitleItem = new DevExpress.Utils.ToolTipTitleItem();
		DevExpress.Utils.ToolTipItem toolTipItem = new DevExpress.Utils.ToolTipItem();
		DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
		DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
		DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
		this.UcDateTime1 = new GRLL.Common.ucDateTime();
		this.Label1 = new System.Windows.Forms.Label();
		this.BtnConsultar = new System.Windows.Forms.Button();
		this.GridControl1 = new DevExpress.XtraGrid.GridControl();
		this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.GridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GroupControl1 = new DevExpress.XtraEditors.GroupControl();
		this.UcCBPartidaPresupuestal = new GRLL.Common.ucComboBox();
		this.UcCBArea = new GRLL.Common.ucComboBox();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.DefaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
		this.Label4 = new System.Windows.Forms.Label();
		this.Lbl_Faltas = new System.Windows.Forms.Label();
		this.BtnExportar = new System.Windows.Forms.Button();
		this.ToolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
		((System.ComponentModel.ISupportInitialize)this.GridControl1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GridView1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GroupControl1).BeginInit();
		this.GroupControl1.SuspendLayout();
		this.SuspendLayout();
		this.cmdCerrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.cmdCerrar.AutoSize = true;
		this.cmdCerrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.cmdCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cmdCerrar.FlatAppearance.BorderSize = 0;
		this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.cmdCerrar.Image = RecursosHumanos.My.Resources.Resources._exit;
		System.Windows.Forms.Button button = this.cmdCerrar;
		System.Drawing.Point location = new System.Drawing.Point(542, 651);
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
		this.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		System.Windows.Forms.Panel panelSup = this.PanelSup;
		size = new System.Drawing.Size(615, 29);
		panelSup.Size = size;
		System.Windows.Forms.Panel panelInf = this.PanelInf;
		location = new System.Drawing.Point(0, 680);
		panelInf.Location = location;
		System.Windows.Forms.Panel panelInf2 = this.PanelInf;
		size = new System.Drawing.Size(615, 27);
		panelInf2.Size = size;
		this.UcDateTime1.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcDateTime1.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucDateTime ucDateTime = this.UcDateTime1;
		location = new System.Drawing.Point(53, 85);
		ucDateTime.Location = location;
		this.UcDateTime1.Name = "UcDateTime1";
		GRLL.Common.ucDateTime ucDateTime2 = this.UcDateTime1;
		size = new System.Drawing.Size(200, 20);
		ucDateTime2.Size = size;
		this.UcDateTime1.TabIndex = 3;
		this.Label1.AutoSize = true;
		System.Windows.Forms.Label label = this.Label1;
		location = new System.Drawing.Point(7, 89);
		label.Location = location;
		this.Label1.Name = "Label1";
		System.Windows.Forms.Label label2 = this.Label1;
		size = new System.Drawing.Size(40, 13);
		label2.Size = size;
		this.Label1.TabIndex = 4;
		this.Label1.Text = "Fecha:";
		this.BtnConsultar.AutoSize = true;
		this.BtnConsultar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.BtnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BtnConsultar.FlatAppearance.BorderSize = 0;
		this.BtnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BtnConsultar.Image = RecursosHumanos.My.Resources.Resources.view1;
		System.Windows.Forms.Button btnConsultar = this.BtnConsultar;
		location = new System.Drawing.Point(259, 84);
		btnConsultar.Location = location;
		this.BtnConsultar.Name = "BtnConsultar";
		System.Windows.Forms.Button btnConsultar2 = this.BtnConsultar;
		size = new System.Drawing.Size(77, 23);
		btnConsultar2.Size = size;
		this.BtnConsultar.TabIndex = 5;
		this.BtnConsultar.Text = "&Consultar";
		this.BtnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.BtnConsultar.UseVisualStyleBackColor = true;
		this.GridControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		DevExpress.XtraGrid.GridControl gridControl = this.GridControl1;
		location = new System.Drawing.Point(12, 164);
		gridControl.Location = location;
		this.GridControl1.MainView = this.GridView1;
		this.GridControl1.Name = "GridControl1";
		DevExpress.XtraGrid.GridControl gridControl2 = this.GridControl1;
		size = new System.Drawing.Size(591, 439);
		gridControl2.Size = size;
		this.GridControl1.TabIndex = 6;
		this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[1] { this.GridView1 });
		this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[3] { this.GridColumn1, this.GridColumn2, this.GridColumn3 });
		this.GridView1.GridControl = this.GridControl1;
		this.GridView1.Name = "GridView1";
		this.GridView1.OptionsBehavior.Editable = false;
		this.GridView1.OptionsCustomization.AllowColumnMoving = false;
		this.GridView1.OptionsCustomization.AllowColumnResizing = false;
		this.GridView1.OptionsCustomization.AllowFilter = false;
		this.GridView1.OptionsCustomization.AllowGroup = false;
		this.GridView1.OptionsView.AllowCellMerge = true;
		this.GridView1.OptionsView.ShowGroupPanel = false;
		this.GridColumn1.Caption = "Nombres Completos";
		this.GridColumn1.FieldName = "NombresC";
		this.GridColumn1.Name = "GridColumn1";
		this.GridColumn1.Visible = true;
		this.GridColumn1.VisibleIndex = 0;
		this.GridColumn1.Width = 250;
		this.GridColumn2.Caption = "Area Organizacional";
		this.GridColumn2.FieldName = "AreaOrganizacional";
		this.GridColumn2.Name = "GridColumn2";
		this.GridColumn2.Visible = true;
		this.GridColumn2.VisibleIndex = 1;
		this.GridColumn2.Width = 250;
		this.GridColumn3.Caption = "Tipo Trabajador";
		this.GridColumn3.FieldName = "Descripcion";
		this.GridColumn3.Name = "GridColumn3";
		this.GridColumn3.Visible = true;
		this.GridColumn3.VisibleIndex = 2;
		this.GridColumn3.Width = 80;
		this.GroupControl1.Controls.Add(this.UcCBPartidaPresupuestal);
		this.GroupControl1.Controls.Add(this.UcCBArea);
		this.GroupControl1.Controls.Add(this.Label3);
		this.GroupControl1.Controls.Add(this.Label2);
		this.GroupControl1.Controls.Add(this.BtnConsultar);
		this.GroupControl1.Controls.Add(this.Label1);
		this.GroupControl1.Controls.Add(this.UcDateTime1);
		DevExpress.XtraEditors.GroupControl groupControl = this.GroupControl1;
		location = new System.Drawing.Point(12, 35);
		groupControl.Location = location;
		this.GroupControl1.Name = "GroupControl1";
		DevExpress.XtraEditors.GroupControl groupControl2 = this.GroupControl1;
		size = new System.Drawing.Size(350, 123);
		groupControl2.Size = size;
		this.GroupControl1.TabIndex = 7;
		this.GroupControl1.Text = "Parámetros";
		this.UcCBPartidaPresupuestal.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCBPartidaPresupuestal.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCBPartidaPresupuestal.FormattingEnabled = true;
		this.UcCBPartidaPresupuestal.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucCBPartidaPresupuestal = this.UcCBPartidaPresupuestal;
		location = new System.Drawing.Point(53, 58);
		ucCBPartidaPresupuestal.Location = location;
		this.UcCBPartidaPresupuestal.Name = "UcCBPartidaPresupuestal";
		GRLL.Common.ucComboBox ucCBPartidaPresupuestal2 = this.UcCBPartidaPresupuestal;
		size = new System.Drawing.Size(133, 21);
		ucCBPartidaPresupuestal2.Size = size;
		this.UcCBPartidaPresupuestal.TabIndex = 18;
		this.UcCBArea.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCBArea.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCBArea.FormattingEnabled = true;
		this.UcCBArea.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucCBArea = this.UcCBArea;
		location = new System.Drawing.Point(53, 31);
		ucCBArea.Location = location;
		this.UcCBArea.Name = "UcCBArea";
		GRLL.Common.ucComboBox ucCBArea2 = this.UcCBArea;
		size = new System.Drawing.Size(281, 21);
		ucCBArea2.Size = size;
		this.UcCBArea.TabIndex = 18;
		this.Label3.AutoSize = true;
		System.Windows.Forms.Label label3 = this.Label3;
		location = new System.Drawing.Point(16, 61);
		label3.Location = location;
		this.Label3.Name = "Label3";
		System.Windows.Forms.Label label4 = this.Label3;
		size = new System.Drawing.Size(31, 13);
		label4.Size = size;
		this.Label3.TabIndex = 6;
		this.Label3.Text = "Tipo:";
		this.Label2.AutoSize = true;
		System.Windows.Forms.Label label5 = this.Label2;
		location = new System.Drawing.Point(15, 34);
		label5.Location = location;
		this.Label2.Name = "Label2";
		System.Windows.Forms.Label label6 = this.Label2;
		size = new System.Drawing.Size(32, 13);
		label6.Size = size;
		this.Label2.TabIndex = 6;
		this.Label2.Text = "Area:";
		this.DefaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins";
		this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.Label4.AutoSize = true;
		System.Windows.Forms.Label label7 = this.Label4;
		location = new System.Drawing.Point(12, 616);
		label7.Location = location;
		this.Label4.Name = "Label4";
		System.Windows.Forms.Label label8 = this.Label4;
		size = new System.Drawing.Size(65, 13);
		label8.Size = size;
		this.Label4.TabIndex = 8;
		this.Label4.Text = "Total Faltas:";
		this.Lbl_Faltas.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.Lbl_Faltas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Lbl_Faltas.ForeColor = System.Drawing.Color.Maroon;
		System.Windows.Forms.Label lbl_Faltas = this.Lbl_Faltas;
		location = new System.Drawing.Point(83, 616);
		lbl_Faltas.Location = location;
		this.Lbl_Faltas.Name = "Lbl_Faltas";
		System.Windows.Forms.Label lbl_Faltas2 = this.Lbl_Faltas;
		size = new System.Drawing.Size(129, 13);
		lbl_Faltas2.Size = size;
		this.Lbl_Faltas.TabIndex = 8;
		this.BtnExportar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.BtnExportar.AutoSize = true;
		this.BtnExportar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.BtnExportar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BtnExportar.FlatAppearance.BorderSize = 0;
		this.BtnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BtnExportar.Image = RecursosHumanos.My.Resources.Resources.document_out;
		System.Windows.Forms.Button btnExportar = this.BtnExportar;
		location = new System.Drawing.Point(12, 651);
		btnExportar.Location = location;
		this.BtnExportar.Name = "BtnExportar";
		System.Windows.Forms.Button btnExportar2 = this.BtnExportar;
		size = new System.Drawing.Size(110, 23);
		btnExportar2.Size = size;
		toolTipTitleItem2.Appearance.Image = RecursosHumanos.My.Resources.Resources.help2;
		toolTipTitleItem2.Appearance.Options.UseImage = true;
		toolTipTitleItem2.Image = RecursosHumanos.My.Resources.Resources.help2;
		toolTipTitleItem2.Text = "Ayuda";
		toolTipItem2.LeftIndent = 6;
		toolTipItem2.Text = "Envia la Informacion generada a una Hoja Excel.";
		superToolTip2.Items.Add(toolTipTitleItem2);
		superToolTip2.Items.Add(toolTipItem2);
		this.ToolTipController1.SetSuperTip(this.BtnExportar, superToolTip2);
		this.BtnExportar.TabIndex = 9;
		this.BtnExportar.Text = "&Exportar a Excel";
		this.BtnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.BtnExportar.UseVisualStyleBackColor = true;
		this.ToolTipController1.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip;
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		size = new System.Drawing.Size(615, 707);
		this.ClientSize = size;
		this.Controls.Add(this.GridControl1);
		this.Controls.Add(this.GroupControl1);
		this.Controls.Add(this.Label4);
		this.Controls.Add(this.Lbl_Faltas);
		this.Controls.Add(this.BtnExportar);
		this.MessageShow = true;
		this.Name = "FrmConsultaFaltas";
		this.TitleMsg = "FrmConsulta";
		this.Titulo = "Consulta de Faltas";
		this.VerCmdCerrar = true;
		this.Controls.SetChildIndex(this.BtnExportar, 0);
		this.Controls.SetChildIndex(this.Lbl_Faltas, 0);
		this.Controls.SetChildIndex(this.Label4, 0);
		this.Controls.SetChildIndex(this.GroupControl1, 0);
		this.Controls.SetChildIndex(this.GridControl1, 0);
		this.Controls.SetChildIndex(this.cmdCerrar, 0);
		this.Controls.SetChildIndex(this.PanelSup, 0);
		this.Controls.SetChildIndex(this.PanelInf, 0);
		((System.ComponentModel.ISupportInitialize)this.GridControl1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GridView1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GroupControl1).EndInit();
		this.GroupControl1.ResumeLayout(false);
		this.GroupControl1.PerformLayout();
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	private void FrmConsultaFaltas_Load(object sender, EventArgs e)
	{
		UcCBArea.ValueMember = "idAreaOrganiz";
		UcCBArea.DisplayMember = "AreaOrganizacional";
		DataTable dataTable = (DataTable)objClassRRHH.llena_Area();
		DataRow dataRow = dataTable.NewRow();
		dataRow["idAreaOrganiz"] = 0;
		dataRow["AreaOrganizacional"] = "--TODOS--";
		dataTable.Rows.InsertAt(dataRow, 0);
		UcCBArea.DataSource = dataTable;
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

	private void BtnConsultar_Click(object sender, EventArgs e)
	{
		int? num = default(int?);
		if (Operators.ConditionalCompareObjectEqual(UcCBArea.SelectedValue, 0, TextCompare: false))
		{
			area = null;
		}
		else
		{
			object selectedValue = UcCBArea.SelectedValue;
			area = ((selectedValue != null) ? ((int?)selectedValue) : num);
		}
		if (Operators.ConditionalCompareObjectEqual(UcCBPartidaPresupuestal.SelectedValue, 0, TextCompare: false))
		{
			tipo = null;
		}
		else
		{
			object selectedValue2 = UcCBPartidaPresupuestal.SelectedValue;
			tipo = ((selectedValue2 != null) ? ((int?)selectedValue2) : num);
		}
		fecha = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Interaction.IIf(UcDateTime1.Value.Day.ToString().Length == 1, "0" + UcDateTime1.Value.Day, UcDateTime1.Value.Day.ToString()), "/"), Interaction.IIf(UcDateTime1.Value.Month.ToString().Length == 1, "0" + UcDateTime1.Value.Month, UcDateTime1.Value.Month.ToString())), "/"), UcDateTime1.Value.Year.ToString()));
		GridControl1.DataSource = Module1.DcGrll.spRRHH_Faltas(fecha, tipo, area, 2008);
		if (area.HasValue)
		{
			GridView1.Columns["AreaOrganizacional"].Visible = false;
		}
		Lbl_Faltas.Text = Conversions.ToString(GridView1.RowCount);
	}

	private void BtnExportar_Click(object sender, EventArgs e)
	{
		if (GridView1.RowCount == 0)
		{
			MessageBox.Show("Debe existir como minimo, un registro para exportar", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		XlsExportOptions xlsExportOptions = new XlsExportOptions();
		string text = MyProject.Computer.FileSystem.SpecialDirectories.MyDocuments.ToString();
		string text2 = text + "\\Reporte_AutoGenerado_Faltas" + Conversions.ToString(DateAndTime.Today.Date.Day) + Conversions.ToString(DateAndTime.Today.Date.Month) + Conversions.ToString(DateAndTime.Today.Date.Year) + DateAndTime.Now.Hour + Conversions.ToString(DateAndTime.Now.Minute) + DateAndTime.Now.Second + Conversions.ToString(DateAndTime.Now.Millisecond) + ".xls";
		xlsExportOptions.SheetName = "Reporte_AutoGenerado_Faltas";
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
		object instance2 = NewLateBinding.LateGet(objectValue3, null, "Shapes", new object[0], null, null, null);
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
		array4 = new object[2] { "A2", null };
		object[] array5 = array4;
		object obj2 = objectValue3;
		object instance3 = obj2;
		array = new object[2];
		object[] array6 = array;
		int num = 2;
		array6[0] = num;
		object[] array7 = array;
		checked
		{
			int num2 = GridView1.Columns.Count - 1;
			array7[1] = num2;
			array5[1] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(instance3, null, "Cells", array, null, null, null));
			object[] array8 = array4;
			object[] arguments3 = array8;
			array2 = new bool[2] { false, true };
			object instance4 = NewLateBinding.LateGet(objectValue3, null, "Range", arguments3, null, null, array2);
			if (array2[1])
			{
				NewLateBinding.LateSetComplex(obj2, null, "Cells", new object[3]
				{
					num,
					num2,
					RuntimeHelpers.GetObjectValue(array8[1])
				}, null, null, OptimisticSet: true, RValueBase: false);
			}
			NewLateBinding.LateCall(instance4, null, "Merge", new object[0], null, null, null, IgnoreReturn: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue3, null, "Cells", new object[2] { 2, 1 }, null, null, null), null, "FormulaR1C1", new object[1] { "Reporte de Faltas" }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue3, null, "Cells", new object[2] { 2, 1 }, null, null, null), null, "HorizontalAlignment", new object[1] { -4108 }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, null, "Rows", new object[1] { "2:2" }, null, null, null), null, "Font", new object[0], null, null, null), null, "Size", new object[1] { 16 }, null, null, OptimisticSet: false, RValueBase: true);
			array8 = new object[2] { "A3", null };
			object[] array9 = array8;
			obj2 = objectValue3;
			object instance5 = obj2;
			object[] array10 = new object[2];
			object[] array11 = array10;
			num = 3;
			array11[0] = num;
			object[] array12 = array10;
			num2 = GridView1.Columns.Count - 1;
			array12[1] = num2;
			array9[1] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(instance5, null, "Cells", array10, null, null, null));
			array = array8;
			object[] arguments4 = array;
			array2 = new bool[2] { false, true };
			object instance6 = NewLateBinding.LateGet(objectValue3, null, "Range", arguments4, null, null, array2);
			if (array2[1])
			{
				NewLateBinding.LateSetComplex(obj2, null, "Cells", new object[3]
				{
					num,
					num2,
					RuntimeHelpers.GetObjectValue(array[1])
				}, null, null, OptimisticSet: true, RValueBase: false);
			}
			NewLateBinding.LateCall(instance6, null, "Merge", new object[0], null, null, null, IgnoreReturn: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue3, null, "Cells", new object[2] { 3, 1 }, null, null, null), null, "FormulaR1C1", new object[1] { "Del: " + UcDateTime1.Value.ToLongDateString() }, null, null, OptimisticSet: false, RValueBase: true);
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
