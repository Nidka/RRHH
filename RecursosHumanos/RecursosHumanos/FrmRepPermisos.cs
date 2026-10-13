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
public class FrmRepPermisos : FrmConsulta
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("GroupControl1")]
	private GroupControl _GroupControl1;

	[AccessedThroughProperty("UcFechas1")]
	private ucFechas _UcFechas1;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("UcCmbMotivo")]
	private ucComboBox _UcCmbMotivo;

	[AccessedThroughProperty("UcCmbTipoPermiso")]
	private ucComboBox _UcCmbTipoPermiso;

	[AccessedThroughProperty("DefaultLookAndFeel1")]
	private DefaultLookAndFeel _DefaultLookAndFeel1;

	[AccessedThroughProperty("GridControl1")]
	private GridControl _GridControl1;

	[AccessedThroughProperty("GridView1")]
	private GridView _GridView1;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("GridColumn1")]
	private GridColumn _GridColumn1;

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

	[AccessedThroughProperty("GridColumn7")]
	private GridColumn _GridColumn7;

	[AccessedThroughProperty("GridColumn8")]
	private GridColumn _GridColumn8;

	[AccessedThroughProperty("ToolTipController1")]
	private ToolTipController _ToolTipController1;

	private RRHHClass objRRHHClass;

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

	public FrmRepPermisos()
	{
		base.Load += FrmRepPermisos_Load;
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
		DevExpress.Utils.SuperToolTip superToolTip = new DevExpress.Utils.SuperToolTip();
		DevExpress.Utils.ToolTipTitleItem toolTipTitleItem = new DevExpress.Utils.ToolTipTitleItem();
		DevExpress.Utils.ToolTipItem toolTipItem = new DevExpress.Utils.ToolTipItem();
		DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
		DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
		DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
		this.GroupControl1 = new DevExpress.XtraEditors.GroupControl();
		this.Button1 = new System.Windows.Forms.Button();
		this.Label6 = new System.Windows.Forms.Label();
		this.UcFechas1 = new GRLL.Common.ucFechas();
		this.Label2 = new System.Windows.Forms.Label();
		this.UcCmbMotivo = new GRLL.Common.ucComboBox();
		this.UcCmbTipoPermiso = new GRLL.Common.ucComboBox();
		this.DefaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
		this.GridControl1 = new DevExpress.XtraGrid.GridControl();
		this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.GridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.Button2 = new System.Windows.Forms.Button();
		this.ToolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
		((System.ComponentModel.ISupportInitialize)this.GroupControl1).BeginInit();
		this.GroupControl1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.GridControl1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GridView1).BeginInit();
		this.SuspendLayout();
		this.cmdCerrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.cmdCerrar.AutoSize = true;
		this.cmdCerrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.cmdCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cmdCerrar.FlatAppearance.BorderSize = 0;
		this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.cmdCerrar.Image = RecursosHumanos.My.Resources.Resources._exit;
		System.Windows.Forms.Button button = this.cmdCerrar;
		System.Drawing.Point location = new System.Drawing.Point(835, 404);
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
		this.cmdCerrar.Text = "&Cerrar";
		this.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		System.Windows.Forms.Panel panelSup = this.PanelSup;
		size = new System.Drawing.Size(908, 29);
		panelSup.Size = size;
		System.Windows.Forms.Panel panelInf = this.PanelInf;
		location = new System.Drawing.Point(0, 433);
		panelInf.Location = location;
		System.Windows.Forms.Panel panelInf2 = this.PanelInf;
		size = new System.Drawing.Size(908, 27);
		panelInf2.Size = size;
		this.GroupControl1.Controls.Add(this.Button1);
		this.GroupControl1.Controls.Add(this.Label6);
		this.GroupControl1.Controls.Add(this.UcFechas1);
		this.GroupControl1.Controls.Add(this.Label2);
		this.GroupControl1.Controls.Add(this.UcCmbMotivo);
		this.GroupControl1.Controls.Add(this.UcCmbTipoPermiso);
		DevExpress.XtraEditors.GroupControl groupControl = this.GroupControl1;
		location = new System.Drawing.Point(12, 35);
		groupControl.Location = location;
		this.GroupControl1.Name = "GroupControl1";
		DevExpress.XtraEditors.GroupControl groupControl2 = this.GroupControl1;
		size = new System.Drawing.Size(509, 94);
		groupControl2.Size = size;
		this.GroupControl1.TabIndex = 3;
		this.GroupControl1.Text = "Parámetros";
		this.Button1.AutoSize = true;
		this.Button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.Button1.FlatAppearance.BorderSize = 0;
		this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button1.Image = RecursosHumanos.My.Resources.Resources.document_out;
		System.Windows.Forms.Button button3 = this.Button1;
		location = new System.Drawing.Point(429, 55);
		button3.Location = location;
		this.Button1.Name = "Button1";
		System.Windows.Forms.Button button4 = this.Button1;
		size = new System.Drawing.Size(75, 25);
		button4.Size = size;
		this.Button1.TabIndex = 4;
		this.Button1.Text = "&Generar";
		this.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.Button1.UseVisualStyleBackColor = true;
		this.Label6.AutoSize = true;
		System.Windows.Forms.Label label = this.Label6;
		location = new System.Drawing.Point(202, 61);
		label.Location = location;
		this.Label6.Name = "Label6";
		System.Windows.Forms.Label label2 = this.Label6;
		size = new System.Drawing.Size(42, 13);
		label2.Size = size;
		this.Label6.TabIndex = 3;
		this.Label6.Text = "Motivo:";
		GRLL.Common.ucFechas ucFechas = this.UcFechas1;
		location = new System.Drawing.Point(7, 26);
		ucFechas.Location = location;
		this.UcFechas1.Name = "UcFechas1";
		GRLL.Common.ucFechas ucFechas2 = this.UcFechas1;
		size = new System.Drawing.Size(302, 22);
		ucFechas2.Size = size;
		this.UcFechas1.TabIndex = 0;
		this.Label2.AutoSize = true;
		System.Windows.Forms.Label label3 = this.Label2;
		location = new System.Drawing.Point(11, 61);
		label3.Location = location;
		this.Label2.Name = "Label2";
		System.Windows.Forms.Label label4 = this.Label2;
		size = new System.Drawing.Size(31, 13);
		label4.Size = size;
		this.Label2.TabIndex = 2;
		this.Label2.Text = "Tipo:";
		this.UcCmbMotivo.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCmbMotivo.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCmbMotivo.FormattingEnabled = true;
		this.UcCmbMotivo.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucCmbMotivo = this.UcCmbMotivo;
		location = new System.Drawing.Point(250, 58);
		ucCmbMotivo.Location = location;
		this.UcCmbMotivo.Name = "UcCmbMotivo";
		GRLL.Common.ucComboBox ucCmbMotivo2 = this.UcCmbMotivo;
		size = new System.Drawing.Size(161, 21);
		ucCmbMotivo2.Size = size;
		this.UcCmbMotivo.TabIndex = 1;
		this.UcCmbTipoPermiso.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCmbTipoPermiso.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCmbTipoPermiso.FormattingEnabled = true;
		this.UcCmbTipoPermiso.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucCmbTipoPermiso = this.UcCmbTipoPermiso;
		location = new System.Drawing.Point(48, 58);
		ucCmbTipoPermiso.Location = location;
		this.UcCmbTipoPermiso.Name = "UcCmbTipoPermiso";
		GRLL.Common.ucComboBox ucCmbTipoPermiso2 = this.UcCmbTipoPermiso;
		size = new System.Drawing.Size(121, 21);
		ucCmbTipoPermiso2.Size = size;
		this.UcCmbTipoPermiso.TabIndex = 0;
		this.DefaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins";
		this.GridControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		DevExpress.XtraGrid.GridControl gridControl = this.GridControl1;
		location = new System.Drawing.Point(12, 135);
		gridControl.Location = location;
		this.GridControl1.MainView = this.GridView1;
		this.GridControl1.Name = "GridControl1";
		DevExpress.XtraGrid.GridControl gridControl2 = this.GridControl1;
		size = new System.Drawing.Size(884, 245);
		gridControl2.Size = size;
		this.GridControl1.TabIndex = 4;
		this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[1] { this.GridView1 });
		this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[8] { this.GridColumn1, this.GridColumn2, this.GridColumn3, this.GridColumn4, this.GridColumn5, this.GridColumn6, this.GridColumn7, this.GridColumn8 });
		this.GridView1.GridControl = this.GridControl1;
		this.GridView1.Name = "GridView1";
		this.GridView1.OptionsBehavior.Editable = false;
		this.GridView1.OptionsCustomization.AllowColumnMoving = false;
		this.GridView1.OptionsPrint.AutoWidth = false;
		this.GridView1.OptionsView.ColumnAutoWidth = false;
		this.GridView1.OptionsView.ShowGroupPanel = false;
		this.GridColumn1.Caption = "Nombres Completos";
		this.GridColumn1.FieldName = "Nombres";
		this.GridColumn1.Name = "GridColumn1";
		this.GridColumn1.Visible = true;
		this.GridColumn1.VisibleIndex = 0;
		this.GridColumn1.Width = 250;
		this.GridColumn2.Caption = "Motivo del Permiso y/o Licencia";
		this.GridColumn2.FieldName = "Descrip_Motivo";
		this.GridColumn2.Name = "GridColumn2";
		this.GridColumn2.Visible = true;
		this.GridColumn2.VisibleIndex = 1;
		this.GridColumn2.Width = 159;
		this.GridColumn3.Caption = "Fecha de Inicio";
		this.GridColumn3.FieldName = "FechaInicio";
		this.GridColumn3.Name = "GridColumn3";
		this.GridColumn3.Visible = true;
		this.GridColumn3.VisibleIndex = 2;
		this.GridColumn3.Width = 83;
		this.GridColumn4.Caption = "Fecha de Fin";
		this.GridColumn4.FieldName = "FEchaFin";
		this.GridColumn4.Name = "GridColumn4";
		this.GridColumn4.Visible = true;
		this.GridColumn4.VisibleIndex = 3;
		this.GridColumn4.Width = 71;
		this.GridColumn5.Caption = "Hora de Salida";
		this.GridColumn5.FieldName = "Hora_Sal";
		this.GridColumn5.Name = "GridColumn5";
		this.GridColumn5.Visible = true;
		this.GridColumn5.VisibleIndex = 4;
		this.GridColumn5.Width = 83;
		this.GridColumn6.Caption = "Hora de Ret.";
		this.GridColumn6.FieldName = "Hora_ret";
		this.GridColumn6.Name = "GridColumn6";
		this.GridColumn6.Visible = true;
		this.GridColumn6.VisibleIndex = 5;
		this.GridColumn6.Width = 60;
		this.GridColumn7.Caption = "Lugar";
		this.GridColumn7.FieldName = "Lugar";
		this.GridColumn7.Name = "GridColumn7";
		this.GridColumn7.Visible = true;
		this.GridColumn7.VisibleIndex = 6;
		this.GridColumn7.Width = 180;
		this.GridColumn8.Caption = "Observaciones";
		this.GridColumn8.FieldName = "Observaciones";
		this.GridColumn8.Name = "GridColumn8";
		this.GridColumn8.Visible = true;
		this.GridColumn8.VisibleIndex = 7;
		this.GridColumn8.Width = 120;
		this.Button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.Button2.AutoSize = true;
		this.Button2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.Button2.FlatAppearance.BorderSize = 0;
		this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button2.Image = RecursosHumanos.My.Resources.Resources.document_out;
		System.Windows.Forms.Button button5 = this.Button2;
		location = new System.Drawing.Point(12, 404);
		button5.Location = location;
		this.Button2.Name = "Button2";
		System.Windows.Forms.Button button6 = this.Button2;
		size = new System.Drawing.Size(110, 23);
		button6.Size = size;
		toolTipTitleItem2.Appearance.Image = RecursosHumanos.My.Resources.Resources.help2;
		toolTipTitleItem2.Appearance.Options.UseImage = true;
		toolTipTitleItem2.Image = RecursosHumanos.My.Resources.Resources.help2;
		toolTipTitleItem2.Text = "Ayuda";
		toolTipItem2.LeftIndent = 6;
		toolTipItem2.Text = "Envia la Informacion generada a una Hoja Excel.";
		superToolTip2.Items.Add(toolTipTitleItem2);
		superToolTip2.Items.Add(toolTipItem2);
		this.ToolTipController1.SetSuperTip(this.Button2, superToolTip2);
		this.Button2.TabIndex = 14;
		this.Button2.Text = "Exportar a Excel";
		this.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.Button2.UseVisualStyleBackColor = true;
		this.ToolTipController1.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip;
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		size = new System.Drawing.Size(908, 460);
		this.ClientSize = size;
		this.Controls.Add(this.Button2);
		this.Controls.Add(this.GroupControl1);
		this.Controls.Add(this.GridControl1);
		this.MessageShow = true;
		this.Name = "FrmRepPermisos";
		this.TitleMsg = "FrmConsulta";
		this.Titulo = "Reporte Permisos";
		this.VerCmdCerrar = true;
		this.Controls.SetChildIndex(this.GridControl1, 0);
		this.Controls.SetChildIndex(this.cmdCerrar, 0);
		this.Controls.SetChildIndex(this.GroupControl1, 0);
		this.Controls.SetChildIndex(this.PanelSup, 0);
		this.Controls.SetChildIndex(this.PanelInf, 0);
		this.Controls.SetChildIndex(this.Button2, 0);
		((System.ComponentModel.ISupportInitialize)this.GroupControl1).EndInit();
		this.GroupControl1.ResumeLayout(false);
		this.GroupControl1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.GridControl1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GridView1).EndInit();
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		int? tipopermiso;
		int? num = default(int?);
		if (Operators.ConditionalCompareObjectEqual(UcCmbTipoPermiso.SelectedValue, 0, TextCompare: false))
		{
			tipopermiso = null;
		}
		else
		{
			object selectedValue = UcCmbTipoPermiso.SelectedValue;
			tipopermiso = ((selectedValue != null) ? ((int?)selectedValue) : num);
		}
		int? motivo;
		if (Operators.ConditionalCompareObjectEqual(UcCmbMotivo.SelectedValue, 0, TextCompare: false))
		{
			motivo = null;
		}
		else
		{
			object selectedValue2 = UcCmbMotivo.SelectedValue;
			motivo = ((selectedValue2 != null) ? ((int?)selectedValue2) : num);
		}
		string fechaI = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(UcFechas1.Rango.Desde.Year, Interaction.IIf(UcFechas1.Rango.Desde.Month.ToString().Length == 1, "0" + UcFechas1.Rango.Desde.Month, UcFechas1.Rango.Desde.Month.ToString())), Interaction.IIf(UcFechas1.Rango.Desde.Day.ToString().Length == 1, "0" + UcFechas1.Rango.Desde.Day, UcFechas1.Rango.Desde.Day.ToString())));
		string fechaF = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(UcFechas1.Rango.Hasta.Year, Interaction.IIf(UcFechas1.Rango.Hasta.Month.ToString().Length == 1, "0" + UcFechas1.Rango.Hasta.Month, UcFechas1.Rango.Hasta.Month.ToString())), Interaction.IIf(UcFechas1.Rango.Hasta.Day.ToString().Length == 1, "0" + UcFechas1.Rango.Hasta.Day, UcFechas1.Rango.Hasta.Day.ToString())));
		if (Conversions.ToDouble(RRHH.IdROl) == 10.0)
		{
			GridControl1.DataSource = objRRHHClass.spRRHH_RepPermisos(fechaI, fechaF, tipopermiso, motivo, 1);
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 14.0)
		{
			GridControl1.DataSource = objRRHHClass.spRRHH_RepPermisos(fechaI, fechaF, tipopermiso, motivo, 2);
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 13.0)
		{
			GridControl1.DataSource = objRRHHClass.spRRHH_RepPermisos(fechaI, fechaF, tipopermiso, motivo, num);
		}
	}

	private void FrmRepPermisos_Load(object sender, EventArgs e)
	{
		UcCmbTipoPermiso.ValueMember = "idTipoPermiso";
		UcCmbTipoPermiso.DisplayMember = "DescripTipoPermiso";
		List<TipoPermiso> list = TipoPermisoMapper.Instance().SelectAll();
		list.Insert(0, new TipoPermiso
		{
			idTipoPermiso = 0,
			DescripTipoPermiso = "-- SELECCIONAR --"
		});
		UcCmbTipoPermiso.DataSource = list;
	}

	private void UcCmbTipoPermiso_SelectedIndexChanged(object sender, EventArgs e)
	{
		UcCmbMotivo.ValueMember = "idMotivo";
		UcCmbMotivo.DisplayMember = "Descrip_Motivo";
		if (Conversions.ToDouble(RRHH.IdROl) == 10.0)
		{
			List<Motivo_Perm> list = Motivo_PermMapper.Instance().SelectBy([SpecialName] (Motivo_Perm m) => Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(m.idTipoPermiso, UcCmbTipoPermiso.SelectedValue, TextCompare: false), Operators.CompareString(Conversions.ToString((char)m.TipoModalidad), "P", TextCompare: false) == 0)));
			list.Insert(0, new Motivo_Perm
			{
				idMotivo = 0,
				Descrip_Motivo = "-- SELECCIONAR --"
			});
			UcCmbMotivo.DataSource = list;
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 14.0)
		{
			List<Motivo_Perm> list2 = Motivo_PermMapper.Instance().SelectBy([SpecialName] (Motivo_Perm m) => Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(m.idTipoPermiso, UcCmbTipoPermiso.SelectedValue, TextCompare: false), Operators.CompareString(Conversions.ToString((char)m.TipoModalidad), "C", TextCompare: false) == 0)));
			list2.Insert(0, new Motivo_Perm
			{
				idMotivo = 0,
				Descrip_Motivo = "-- SELECCIONAR --"
			});
			UcCmbMotivo.DataSource = list2;
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 13.0)
		{
			List<Motivo_Perm> list3 = Motivo_PermMapper.Instance().SelectBy([SpecialName] (Motivo_Perm m) => Operators.ConditionalCompareObjectEqual(m.idTipoPermiso, UcCmbTipoPermiso.SelectedValue, TextCompare: false));
			list3.Insert(0, new Motivo_Perm
			{
				idMotivo = 0,
				Descrip_Motivo = "-- SELECCIONAR --"
			});
			UcCmbMotivo.DataSource = list3;
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
		string text2 = text + "\\Reporte_AutoGenerado_Permisos" + Conversions.ToString(DateAndTime.Today.Date.Day) + Conversions.ToString(DateAndTime.Today.Date.Month) + Conversions.ToString(DateAndTime.Today.Date.Year) + DateAndTime.Now.Hour + Conversions.ToString(DateAndTime.Now.Minute) + DateAndTime.Now.Second + Conversions.ToString(DateAndTime.Now.Millisecond) + ".xls";
		xlsExportOptions.SheetName = "Reporte_AutoGenerado_Permisos";
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
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue3, null, "Cells", new object[2] { 2, 1 }, null, null, null), null, "FormulaR1C1", new object[1] { "Reporte de Permisos" }, null, null, OptimisticSet: false, RValueBase: true);
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
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue3, null, "Cells", new object[2] { 3, 1 }, null, null, null), null, "FormulaR1C1", new object[1] { "Del: " + Conversions.ToString(UcFechas1.Rango.Desde) + " al " + Conversions.ToString(UcFechas1.Rango.Hasta) }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue3, null, "Cells", new object[2] { 3, 1 }, null, null, null), null, "HorizontalAlignment", new object[1] { -4108 }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateCall(objectValue3, null, "Protect", new object[16]
			{
				"sgti2009", false, true, false, false, true, true, true, false, false,
				false, false, false, true, true, true
			}, null, null, null, IgnoreReturn: true);
			NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, null, "Columns", new object[1] { "A:Z" }, null, null, null), null, "EntireColumn", new object[0], null, null, null), null, "AutoFit", new object[0], null, null, null, IgnoreReturn: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue3, null, "PageSetup", new object[0], null, null, null), null, "Orientation", new object[1] { 2 }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSet(objectValue, null, "Visible", new object[1] { true }, null, null);
		}
	}
}
