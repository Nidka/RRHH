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
using DevExpress.XtraEditors.Controls;
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
public class FrmConsultaAsistDiaria : FrmConsulta
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("GroupControl1")]
	private GroupControl _GroupControl1;

	[AccessedThroughProperty("UcCBPartidaPresupuestal")]
	private ucComboBox _UcCBPartidaPresupuestal;

	[AccessedThroughProperty("UcCBArea")]
	private ucComboBox _UcCBArea;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("BtnConsultar")]
	private Button _BtnConsultar;

	[AccessedThroughProperty("GridControl1")]
	private GridControl _GridControl1;

	[AccessedThroughProperty("GridView1")]
	private GridView _GridView1;

	[AccessedThroughProperty("DefaultLookAndFeel1")]
	private DefaultLookAndFeel _DefaultLookAndFeel1;

	[AccessedThroughProperty("GridColumn1")]
	private GridColumn _GridColumn1;

	[AccessedThroughProperty("GridColumn2")]
	private GridColumn _GridColumn2;

	[AccessedThroughProperty("GridColumn3")]
	private GridColumn _GridColumn3;

	[AccessedThroughProperty("GridColumn4")]
	private GridColumn _GridColumn4;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("SaveFileDialog1")]
	private SaveFileDialog _SaveFileDialog1;

	[AccessedThroughProperty("RadioGroup1")]
	private RadioGroup _RadioGroup1;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("UcTxtDNI")]
	private ucTextBox _UcTxtDNI;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("UcFechas1")]
	private ucFechas _UcFechas1;

	[AccessedThroughProperty("GridColumn5")]
	private GridColumn _GridColumn5;

	[AccessedThroughProperty("ToolTipController1")]
	private ToolTipController _ToolTipController1;

	[AccessedThroughProperty("ChckListLocal")]
	private CheckedListBoxControl _ChckListLocal;

	private string fechaI;

	private string fechaF;

	private RRHHClass obj;

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

	internal RadioGroup RadioGroup1
	{
		[DebuggerNonUserCode]
		get
		{
			return _RadioGroup1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = RadioGroup1_SelectedIndexChanged;
			if (_RadioGroup1 != null)
			{
				_RadioGroup1.SelectedIndexChanged -= value2;
			}
			_RadioGroup1 = value;
			if (_RadioGroup1 != null)
			{
				_RadioGroup1.SelectedIndexChanged += value2;
			}
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

	internal ucTextBox UcTxtDNI
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtDNI;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtDNI = value;
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
			DevExpress.XtraEditors.Controls.ItemCheckEventHandler value2 = ChckListLocal_ItemCheck;
			EventHandler value3 = ChckListLocal_SelectedIndexChanged;
			if (_ChckListLocal != null)
			{
				_ChckListLocal.ItemCheck -= value2;
				_ChckListLocal.SelectedIndexChanged -= value3;
			}
			_ChckListLocal = value;
			if (_ChckListLocal != null)
			{
				_ChckListLocal.ItemCheck += value2;
				_ChckListLocal.SelectedIndexChanged += value3;
			}
		}
	}

	public FrmConsultaAsistDiaria()
	{
		base.Load += FrmConsultaAsistDiaria_Load;
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
		DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition = new DevExpress.XtraGrid.StyleFormatCondition();
		DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
		DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
		DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
		this.GridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GroupControl1 = new DevExpress.XtraEditors.GroupControl();
		this.ChckListLocal = new DevExpress.XtraEditors.CheckedListBoxControl();
		this.UcFechas1 = new GRLL.Common.ucFechas();
		this.Label5 = new System.Windows.Forms.Label();
		this.UcTxtDNI = new GRLL.Common.ucTextBox(this.components);
		this.Label4 = new System.Windows.Forms.Label();
		this.RadioGroup1 = new DevExpress.XtraEditors.RadioGroup();
		this.UcCBPartidaPresupuestal = new GRLL.Common.ucComboBox();
		this.UcCBArea = new GRLL.Common.ucComboBox();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.BtnConsultar = new System.Windows.Forms.Button();
		this.GridControl1 = new DevExpress.XtraGrid.GridControl();
		this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.GridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.DefaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
		this.Button2 = new System.Windows.Forms.Button();
		this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
		this.ToolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
		((System.ComponentModel.ISupportInitialize)this.GroupControl1).BeginInit();
		this.GroupControl1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.ChckListLocal).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.RadioGroup1.Properties).BeginInit();
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
		System.Drawing.Point location = new System.Drawing.Point(521, 607);
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
		size = new System.Drawing.Size(594, 29);
		panelSup.Size = size;
		System.Windows.Forms.Panel panelInf = this.PanelInf;
		location = new System.Drawing.Point(0, 636);
		panelInf.Location = location;
		System.Windows.Forms.Panel panelInf2 = this.PanelInf;
		size = new System.Drawing.Size(594, 27);
		panelInf2.Size = size;
		this.GridColumn5.Caption = "NombreDia";
		this.GridColumn5.FieldName = "NombreDia";
		this.GridColumn5.Name = "GridColumn5";
		this.GridColumn5.Visible = true;
		this.GridColumn5.VisibleIndex = 1;
		this.GroupControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
		this.GroupControl1.Controls.Add(this.ChckListLocal);
		this.GroupControl1.Controls.Add(this.UcFechas1);
		this.GroupControl1.Controls.Add(this.Label5);
		this.GroupControl1.Controls.Add(this.UcTxtDNI);
		this.GroupControl1.Controls.Add(this.Label4);
		this.GroupControl1.Controls.Add(this.RadioGroup1);
		this.GroupControl1.Controls.Add(this.UcCBPartidaPresupuestal);
		this.GroupControl1.Controls.Add(this.UcCBArea);
		this.GroupControl1.Controls.Add(this.Label3);
		this.GroupControl1.Controls.Add(this.Label2);
		this.GroupControl1.Controls.Add(this.BtnConsultar);
		DevExpress.XtraEditors.GroupControl groupControl = this.GroupControl1;
		location = new System.Drawing.Point(12, 35);
		groupControl.Location = location;
		this.GroupControl1.Name = "GroupControl1";
		DevExpress.XtraEditors.GroupControl groupControl2 = this.GroupControl1;
		size = new System.Drawing.Size(569, 169);
		groupControl2.Size = size;
		this.GroupControl1.TabIndex = 0;
		this.GroupControl1.Text = "Parámetros";
		DevExpress.XtraEditors.CheckedListBoxControl chckListLocal = this.ChckListLocal;
		location = new System.Drawing.Point(22, 121);
		chckListLocal.Location = location;
		this.ChckListLocal.MultiColumn = true;
		this.ChckListLocal.Name = "ChckListLocal";
		DevExpress.XtraEditors.CheckedListBoxControl chckListLocal2 = this.ChckListLocal;
		size = new System.Drawing.Size(419, 38);
		chckListLocal2.Size = size;
		this.ChckListLocal.TabIndex = 25;
		GRLL.Common.ucFechas ucFechas = this.UcFechas1;
		location = new System.Drawing.Point(237, 37);
		ucFechas.Location = location;
		this.UcFechas1.Name = "UcFechas1";
		GRLL.Common.ucFechas ucFechas2 = this.UcFechas1;
		size = new System.Drawing.Size(302, 22);
		ucFechas2.Size = size;
		this.UcFechas1.TabIndex = 2;
		this.Label5.AutoSize = true;
		System.Windows.Forms.Label label = this.Label5;
		location = new System.Drawing.Point(14, 41);
		label.Location = location;
		this.Label5.Name = "Label5";
		System.Windows.Forms.Label label2 = this.Label5;
		size = new System.Drawing.Size(75, 13);
		label2.Size = size;
		this.Label5.TabIndex = 24;
		this.Label5.Text = "Tipo Consulta:";
		this.UcTxtDNI.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtDNI.Formato = null;
		this.UcTxtDNI.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtDNI = this.UcTxtDNI;
		location = new System.Drawing.Point(95, 68);
		ucTxtDNI.Location = location;
		this.UcTxtDNI.MaxLength = 8;
		this.UcTxtDNI.Name = "UcTxtDNI";
		this.UcTxtDNI.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtDNI.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtDNI.OnErrorBlankText = "";
		this.UcTxtDNI.PadLeftLenght = 0;
		this.UcTxtDNI.RegularExpression = "^[0-9]*$";
		this.UcTxtDNI.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtDNI.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtDNI2 = this.UcTxtDNI;
		size = new System.Drawing.Size(150, 20);
		ucTxtDNI2.Size = size;
		this.UcTxtDNI.TabIndex = 5;
		this.UcTxtDNI.TabNextControl = false;
		this.UcTxtDNI.Tipo = GRLL.Common.ucTextBox.TipoDato.Enteros;
		this.UcTxtDNI.Visible = false;
		this.Label4.AutoSize = true;
		System.Windows.Forms.Label label3 = this.Label4;
		location = new System.Drawing.Point(60, 71);
		label3.Location = location;
		this.Label4.Name = "Label4";
		System.Windows.Forms.Label label4 = this.Label4;
		size = new System.Drawing.Size(29, 13);
		label4.Size = size;
		this.Label4.TabIndex = 22;
		this.Label4.Text = "DNI:";
		this.Label4.Visible = false;
		DevExpress.XtraEditors.RadioGroup radioGroup = this.RadioGroup1;
		location = new System.Drawing.Point(95, 32);
		radioGroup.Location = location;
		this.RadioGroup1.Name = "RadioGroup1";
		this.RadioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[2]
		{
			new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Area"),
			new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Persona")
		});
		DevExpress.XtraEditors.RadioGroup radioGroup2 = this.RadioGroup1;
		size = new System.Drawing.Size(135, 30);
		radioGroup2.Size = size;
		this.RadioGroup1.TabIndex = 1;
		this.UcCBPartidaPresupuestal.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCBPartidaPresupuestal.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCBPartidaPresupuestal.FormattingEnabled = true;
		this.UcCBPartidaPresupuestal.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucCBPartidaPresupuestal = this.UcCBPartidaPresupuestal;
		location = new System.Drawing.Point(95, 94);
		ucCBPartidaPresupuestal.Location = location;
		this.UcCBPartidaPresupuestal.Name = "UcCBPartidaPresupuestal";
		GRLL.Common.ucComboBox ucCBPartidaPresupuestal2 = this.UcCBPartidaPresupuestal;
		size = new System.Drawing.Size(133, 21);
		ucCBPartidaPresupuestal2.Size = size;
		this.UcCBPartidaPresupuestal.TabIndex = 6;
		this.UcCBArea.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCBArea.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCBArea.FormattingEnabled = true;
		this.UcCBArea.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucCBArea = this.UcCBArea;
		location = new System.Drawing.Point(95, 67);
		ucCBArea.Location = location;
		this.UcCBArea.Name = "UcCBArea";
		GRLL.Common.ucComboBox ucCBArea2 = this.UcCBArea;
		size = new System.Drawing.Size(281, 21);
		ucCBArea2.Size = size;
		this.UcCBArea.TabIndex = 4;
		this.Label3.AutoSize = true;
		System.Windows.Forms.Label label5 = this.Label3;
		location = new System.Drawing.Point(58, 97);
		label5.Location = location;
		this.Label3.Name = "Label3";
		System.Windows.Forms.Label label6 = this.Label3;
		size = new System.Drawing.Size(31, 13);
		label6.Size = size;
		this.Label3.TabIndex = 6;
		this.Label3.Text = "Tipo:";
		this.Label2.AutoSize = true;
		System.Windows.Forms.Label label7 = this.Label2;
		location = new System.Drawing.Point(57, 70);
		label7.Location = location;
		this.Label2.Name = "Label2";
		System.Windows.Forms.Label label8 = this.Label2;
		size = new System.Drawing.Size(32, 13);
		label8.Size = size;
		this.Label2.TabIndex = 6;
		this.Label2.Text = "Area:";
		this.BtnConsultar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.BtnConsultar.AutoSize = true;
		this.BtnConsultar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.BtnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BtnConsultar.FlatAppearance.BorderSize = 0;
		this.BtnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BtnConsultar.Image = RecursosHumanos.My.Resources.Resources.view1;
		System.Windows.Forms.Button btnConsultar = this.BtnConsultar;
		location = new System.Drawing.Point(487, 134);
		btnConsultar.Location = location;
		this.BtnConsultar.Name = "BtnConsultar";
		System.Windows.Forms.Button btnConsultar2 = this.BtnConsultar;
		size = new System.Drawing.Size(77, 23);
		btnConsultar2.Size = size;
		this.BtnConsultar.TabIndex = 7;
		this.BtnConsultar.Text = "&Consultar";
		this.BtnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.BtnConsultar.UseVisualStyleBackColor = true;
		this.GridControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.GridControl1.Cursor = System.Windows.Forms.Cursors.Default;
		DevExpress.XtraGrid.GridControl gridControl = this.GridControl1;
		location = new System.Drawing.Point(12, 210);
		gridControl.Location = location;
		this.GridControl1.MainView = this.GridView1;
		this.GridControl1.Name = "GridControl1";
		DevExpress.XtraGrid.GridControl gridControl2 = this.GridControl1;
		size = new System.Drawing.Size(569, 386);
		gridControl2.Size = size;
		this.GridControl1.TabIndex = 1;
		this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[1] { this.GridView1 });
		this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[5] { this.GridColumn1, this.GridColumn5, this.GridColumn4, this.GridColumn2, this.GridColumn3 });
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
		this.GridColumn1.FieldName = "nombres";
		this.GridColumn1.Name = "GridColumn1";
		this.GridColumn1.Visible = true;
		this.GridColumn1.VisibleIndex = 0;
		this.GridColumn4.Caption = "Fecha";
		this.GridColumn4.FieldName = "FechaAsistencia";
		this.GridColumn4.GroupFormat.FormatString = "dd/MM/yyyy";
		this.GridColumn4.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
		this.GridColumn4.Name = "GridColumn4";
		this.GridColumn4.Visible = true;
		this.GridColumn4.VisibleIndex = 2;
		this.GridColumn2.Caption = "Hora Entrada";
		this.GridColumn2.FieldName = "HoraE";
		this.GridColumn2.Name = "GridColumn2";
		this.GridColumn2.Visible = true;
		this.GridColumn2.VisibleIndex = 3;
		this.GridColumn3.Caption = "Hora Salida";
		this.GridColumn3.FieldName = "HoraS";
		this.GridColumn3.Name = "GridColumn3";
		this.GridColumn3.Visible = true;
		this.GridColumn3.VisibleIndex = 4;
		this.DefaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins";
		this.Button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.Button2.AutoSize = true;
		this.Button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.Button2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.Button2.FlatAppearance.BorderSize = 0;
		this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button2.Image = RecursosHumanos.My.Resources.Resources.document_out;
		System.Windows.Forms.Button button3 = this.Button2;
		location = new System.Drawing.Point(12, 607);
		button3.Location = location;
		this.Button2.Name = "Button2";
		System.Windows.Forms.Button button4 = this.Button2;
		size = new System.Drawing.Size(110, 23);
		button4.Size = size;
		toolTipTitleItem2.Appearance.Image = RecursosHumanos.My.Resources.Resources.help2;
		toolTipTitleItem2.Appearance.Options.UseImage = true;
		toolTipTitleItem2.Image = RecursosHumanos.My.Resources.Resources.help2;
		toolTipTitleItem2.Text = "Ayuda";
		toolTipItem2.LeftIndent = 6;
		toolTipItem2.Text = "Envia la Informacion generada a una Hoja Excel.";
		superToolTip2.Items.Add(toolTipTitleItem2);
		superToolTip2.Items.Add(toolTipItem2);
		this.ToolTipController1.SetSuperTip(this.Button2, superToolTip2);
		this.Button2.TabIndex = 2;
		this.Button2.Text = "Exportar a Excel";
		this.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.Button2.UseVisualStyleBackColor = true;
		this.ToolTipController1.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip;
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		size = new System.Drawing.Size(594, 663);
		this.ClientSize = size;
		this.Controls.Add(this.Button2);
		this.Controls.Add(this.GridControl1);
		this.Controls.Add(this.GroupControl1);
		this.MaximizeBox = false;
		this.MessageShow = true;
		this.Name = "FrmConsultaAsistDiaria";
		this.TitleMsg = "FrmConsulta";
		this.Titulo = "Consulta Asistencia Diaria";
		this.VerCmdCerrar = true;
		this.Controls.SetChildIndex(this.cmdCerrar, 0);
		this.Controls.SetChildIndex(this.PanelSup, 0);
		this.Controls.SetChildIndex(this.PanelInf, 0);
		this.Controls.SetChildIndex(this.GroupControl1, 0);
		this.Controls.SetChildIndex(this.GridControl1, 0);
		this.Controls.SetChildIndex(this.Button2, 0);
		((System.ComponentModel.ISupportInitialize)this.GroupControl1).EndInit();
		this.GroupControl1.ResumeLayout(false);
		this.GroupControl1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.ChckListLocal).EndInit();
		((System.ComponentModel.ISupportInitialize)this.RadioGroup1.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GridControl1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GridView1).EndInit();
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	private void BtnConsultar_Click(object sender, EventArgs e)
	{
		int? area;
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
		int? tipo;
		if (Operators.ConditionalCompareObjectEqual(UcCBPartidaPresupuestal.SelectedValue, 0, TextCompare: false))
		{
			tipo = null;
		}
		else
		{
			object selectedValue2 = UcCBPartidaPresupuestal.SelectedValue;
			tipo = ((selectedValue2 != null) ? ((int?)selectedValue2) : num);
		}
		fechaI = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(UcFechas1.Rango.Desde.Year.ToString(), Interaction.IIf(UcFechas1.Rango.Desde.Month.ToString().Length == 1, "0" + UcFechas1.Rango.Desde.Month, UcFechas1.Rango.Desde.Month.ToString())), Interaction.IIf(UcFechas1.Rango.Desde.Day.ToString().Length == 1, "0" + UcFechas1.Rango.Desde.Day, UcFechas1.Rango.Desde.Day.ToString())));
		fechaF = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(UcFechas1.Rango.Hasta.Year.ToString(), Interaction.IIf(UcFechas1.Rango.Hasta.Month.ToString().Length == 1, "0" + UcFechas1.Rango.Hasta.Month, UcFechas1.Rango.Hasta.Month.ToString())), Interaction.IIf(UcFechas1.Rango.Hasta.Day.ToString().Length == 1, "0" + UcFechas1.Rango.Hasta.Day, UcFechas1.Rango.Hasta.Day.ToString())));
		GridView1.Columns.Clear();
		string text = "";
		checked
		{
			int num2 = ChckListLocal.ItemCount - 1;
			int num3 = 1;
			while (true)
			{
				int num4 = num3;
				int num5 = num2;
				if (num4 > num5)
				{
					break;
				}
				if (ChckListLocal.GetItemCheckState(num3) == CheckState.Checked)
				{
					text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(ChckListLocal.GetItemValue(num3), ",")));
				}
				num3++;
			}
			if (RadioGroup1.SelectedIndex == 0)
			{
				if (text.Length > 0)
				{
					text = text.Substring(0, text.Length - 1);
					GridControl1.DataSource = obj.spRRHH_RepAsisdiarria(fechaI, fechaF, null, area, tipo, MySettingsProperty.Settings.AnioActual.ToString().Trim(), text);
				}
				else
				{
					MessageBox.Show("Debe Seleccionar un Lugar de Marcado", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
			else
			{
				GridControl1.DataSource = obj.spRRHH_RepAsisdiarria(fechaI, fechaF, UcTxtDNI.Text.Trim(), num, num, MySettingsProperty.Settings.AnioActual.ToString().Trim(), text);
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

	private void FrmConsultaAsistDiaria_Load(object sender, EventArgs e)
	{
		UcCBArea.ValueMember = "idAreaOrganiz";
		UcCBArea.DisplayMember = "AreaOrganizacional";
		DataTable dataTable = (DataTable)obj.llena_Area();
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
		List<Local> list2 = LocalMapper.Instance().SelectAll();
		list2.Insert(0, new Local
		{
			idLocal = 0,
			NombreLocal = "TODOS"
		});
		ChckListLocal.ValueMember = "idLocal";
		ChckListLocal.DisplayMember = "NombreLocal";
		ChckListLocal.DataSource = list2;
	}

	private void RadioGroup1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (RadioGroup1.SelectedIndex == 0)
		{
			Label2.Visible = true;
			UcCBArea.Visible = true;
			Label3.Visible = true;
			UcCBPartidaPresupuestal.Visible = true;
			Label4.Visible = false;
			UcTxtDNI.Visible = false;
		}
		else
		{
			Label2.Visible = false;
			UcCBArea.Visible = false;
			Label3.Visible = false;
			UcCBPartidaPresupuestal.Visible = false;
			Label4.Visible = true;
			UcTxtDNI.Visible = true;
		}
	}

	private void ChckListLocal_SelectedIndexChanged(object sender, EventArgs e)
	{
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
}
