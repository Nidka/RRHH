using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using GRLL.Common;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using RecursosHumanos.My.Resources;
using RRHH.Presentation.Catalogos;

namespace RecursosHumanos;

[DesignerGenerated]
public class FrmMantTipoPerm : FrmConsulta, IFormularioCatalogo
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("ImageList2")]
	private ImageList _ImageList2;

	[AccessedThroughProperty("DataNavigator1")]
	private DataNavigator _DataNavigator1;

	[AccessedThroughProperty("GridControl1")]
	private GridControl _GridControl1;

	[AccessedThroughProperty("GridView1")]
	private GridView _GridView1;

	[AccessedThroughProperty("GridColumn1")]
	private GridColumn _GridColumn1;

	[AccessedThroughProperty("GridColumn2")]
	private GridColumn _GridColumn2;

	[AccessedThroughProperty("UcTxtCampoBusca")]
	private ucTextBox _UcTxtCampoBusca;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("DefaultLookAndFeel1")]
	private DefaultLookAndFeel _DefaultLookAndFeel1;

	[AccessedThroughProperty("ToolTipController1")]
	private ToolTipController _ToolTipController1;

	private VistaCatalogoGrid _vista;

	ICatalogoView IFormularioCatalogo.Vista => _vista;

	internal ImageList ImageList2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ImageList2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ImageList2 = value;
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
			NavigatorButtonClickEventHandler value2 = DataNavigator1_ButtonClick;
			if (_DataNavigator1 != null)
			{
				_DataNavigator1.ButtonClick -= value2;
			}
			_DataNavigator1 = value;
			if (_DataNavigator1 != null)
			{
				_DataNavigator1.ButtonClick += value2;
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
			RowAllowEventHandler value2 = Vista1_BeforeLeaveRow;
			ValidateRowEventHandler value4 = Vista1_ValidateRow;
			RowObjectEventHandler value5 = Vista1_RowUpdated;
			if (_GridView1 != null)
			{
				_GridView1.BeforeLeaveRow -= value2;
				_GridView1.ValidateRow -= value4;
				_GridView1.RowUpdated -= value5;
			}
			_GridView1 = value;
			if (_GridView1 != null)
			{
				_GridView1.BeforeLeaveRow += value2;
				_GridView1.ValidateRow += value4;
				_GridView1.RowUpdated += value5;
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

	internal ucTextBox UcTxtCampoBusca
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtCampoBusca;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = UcTxtCampoBusca_TextChanged;
			if (_UcTxtCampoBusca != null)
			{
				_UcTxtCampoBusca.TextChanged -= value2;
			}
			_UcTxtCampoBusca = value;
			if (_UcTxtCampoBusca != null)
			{
				_UcTxtCampoBusca.TextChanged += value2;
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

	public FrmMantTipoPerm()
	{
		base.Load += FrmMantTipoPerm_Load;
		__ENCAddToList(this);
		InitializeComponent();
		_vista = new VistaCatalogoGrid(this, GridView1, DataNavigator1, () => UcTxtCampoBusca.Text);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecursosHumanos.FrmMantTipoPerm));
		this.ImageList2 = new System.Windows.Forms.ImageList(this.components);
		this.DataNavigator1 = new DevExpress.XtraEditors.DataNavigator();
		this.GridControl1 = new DevExpress.XtraGrid.GridControl();
		this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.GridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.UcTxtCampoBusca = new GRLL.Common.ucTextBox(this.components);
		this.Button1 = new System.Windows.Forms.Button();
		this.DefaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
		this.ToolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
		((System.ComponentModel.ISupportInitialize)this.GridControl1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GridView1).BeginInit();
		this.SuspendLayout();
		this.cmdCerrar.AutoSize = true;
		this.cmdCerrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.cmdCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cmdCerrar.FlatAppearance.BorderSize = 0;
		this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.cmdCerrar.Image = RecursosHumanos.My.Resources.Resources._exit;
		System.Windows.Forms.Button button = this.cmdCerrar;
		System.Drawing.Point location = new System.Drawing.Point(396, 376);
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
		this.cmdCerrar.TabIndex = 4;
		this.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		System.Windows.Forms.Panel panelSup = this.PanelSup;
		size = new System.Drawing.Size(467, 29);
		panelSup.Size = size;
		System.Windows.Forms.Panel panelInf = this.PanelInf;
		location = new System.Drawing.Point(0, 409);
		panelInf.Location = location;
		System.Windows.Forms.Panel panelInf2 = this.PanelInf;
		size = new System.Drawing.Size(467, 27);
		panelInf2.Size = size;
		this.ImageList2.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("ImageList2.ImageStream");
		this.ImageList2.TransparentColor = System.Drawing.Color.Transparent;
		this.ImageList2.Images.SetKeyName(0, "disk_blue.png");
		this.ImageList2.Images.SetKeyName(1, "delete.png");
		this.ImageList2.Images.SetKeyName(2, "document_new.png");
		this.ImageList2.Images.SetKeyName(3, "stop.png");
		this.DataNavigator1.Buttons.Append.ImageIndex = 2;
		this.DataNavigator1.Buttons.CancelEdit.ImageIndex = 3;
		this.DataNavigator1.Buttons.EndEdit.ImageIndex = 0;
		this.DataNavigator1.Buttons.ImageList = this.ImageList2;
		this.DataNavigator1.Buttons.Remove.Hint = "Eliminar";
		this.DataNavigator1.Buttons.Remove.ImageIndex = 1;
		this.DataNavigator1.CustomButtons.AddRange(new DevExpress.XtraEditors.NavigatorCustomButton[1]
		{
			new DevExpress.XtraEditors.NavigatorCustomButton()
		});
		DevExpress.XtraEditors.DataNavigator dataNavigator = this.DataNavigator1;
		location = new System.Drawing.Point(1, 347);
		dataNavigator.Location = location;
		this.DataNavigator1.Name = "DataNavigator1";
		DevExpress.XtraEditors.DataNavigator dataNavigator2 = this.DataNavigator1;
		size = new System.Drawing.Size(465, 23);
		dataNavigator2.Size = size;
		this.DataNavigator1.TabIndex = 3;
		this.DataNavigator1.Text = "DataNavigator1";
		this.DataNavigator1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center;
		this.DataNavigator1.TextStringFormat = "Registro {0} de {1}";
		DevExpress.XtraGrid.GridControl gridControl = this.GridControl1;
		location = new System.Drawing.Point(1, 62);
		gridControl.Location = location;
		this.GridControl1.MainView = this.GridView1;
		this.GridControl1.Name = "GridControl1";
		DevExpress.XtraGrid.GridControl gridControl2 = this.GridControl1;
		size = new System.Drawing.Size(465, 285);
		gridControl2.Size = size;
		this.GridControl1.TabIndex = 2;
		this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[1] { this.GridView1 });
		this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[2] { this.GridColumn1, this.GridColumn2 });
		this.GridView1.GridControl = this.GridControl1;
		this.GridView1.Name = "GridView1";
		this.GridView1.OptionsDetail.AllowZoomDetail = false;
		this.GridView1.OptionsDetail.EnableMasterViewMode = false;
		this.GridView1.OptionsDetail.ShowDetailTabs = false;
		this.GridView1.OptionsFilter.AllowColumnMRUFilterList = false;
		this.GridView1.OptionsFilter.AllowFilterEditor = false;
		this.GridView1.OptionsFilter.AllowMRUFilterList = false;
		this.GridView1.OptionsFilter.UseNewCustomFilterDialog = true;
		this.GridView1.OptionsMenu.EnableColumnMenu = false;
		this.GridView1.OptionsMenu.EnableGroupPanelMenu = false;
		this.GridView1.OptionsView.ShowGroupPanel = false;
		this.GridColumn1.Caption = "Codigo";
		this.GridColumn1.FieldName = "Id";
		this.GridColumn1.Name = "GridColumn1";
		this.GridColumn1.OptionsColumn.AllowEdit = false;
		this.GridColumn1.Visible = true;
		this.GridColumn1.VisibleIndex = 0;
		this.GridColumn1.Width = 60;
		this.GridColumn2.Caption = "Descripción";
		this.GridColumn2.FieldName = "Descripcion";
		this.GridColumn2.Name = "GridColumn2";
		this.GridColumn2.Visible = true;
		this.GridColumn2.VisibleIndex = 1;
		this.GridColumn2.Width = 187;
		this.UcTxtCampoBusca.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtCampoBusca.Formato = null;
		this.UcTxtCampoBusca.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtCampoBusca = this.UcTxtCampoBusca;
		location = new System.Drawing.Point(13, 35);
		ucTxtCampoBusca.Location = location;
		this.UcTxtCampoBusca.Name = "UcTxtCampoBusca";
		this.UcTxtCampoBusca.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtCampoBusca.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtCampoBusca.OnErrorBlankText = "";
		this.UcTxtCampoBusca.PadLeftLenght = 0;
		this.UcTxtCampoBusca.RegularExpression = "^[A-Z,a-z,\\s]+$";
		this.UcTxtCampoBusca.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtCampoBusca.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtCampoBusca2 = this.UcTxtCampoBusca;
		size = new System.Drawing.Size(351, 20);
		ucTxtCampoBusca2.Size = size;
		this.UcTxtCampoBusca.TabIndex = 0;
		this.UcTxtCampoBusca.TabNextControl = false;
		this.UcTxtCampoBusca.Tipo = GRLL.Common.ucTextBox.TipoDato.SoloLetras;
		this.Button1.AutoSize = true;
		this.Button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.Button1.FlatAppearance.BorderSize = 0;
		this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button1.Image = RecursosHumanos.My.Resources.Resources.view;
		System.Windows.Forms.Button button3 = this.Button1;
		location = new System.Drawing.Point(383, 29);
		button3.Location = location;
		this.Button1.Name = "Button1";
		System.Windows.Forms.Button button4 = this.Button1;
		size = new System.Drawing.Size(74, 30);
		button4.Size = size;
		this.Button1.TabIndex = 1;
		this.Button1.Text = "Buscar";
		this.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.Button1.UseVisualStyleBackColor = true;
		this.DefaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins";
		this.ToolTipController1.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip;
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		size = new System.Drawing.Size(467, 436);
		this.ClientSize = size;
		this.Controls.Add(this.Button1);
		this.Controls.Add(this.DataNavigator1);
		this.Controls.Add(this.GridControl1);
		this.Controls.Add(this.UcTxtCampoBusca);
		this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		this.MessageShow = true;
		this.Name = "FrmMantTipoPerm";
		this.TitleMsg = "FrmConsulta";
		this.Titulo = "Tipo de Permiso";
		this.VerCmdCerrar = true;
		this.Controls.SetChildIndex(this.PanelSup, 0);
		this.Controls.SetChildIndex(this.PanelInf, 0);
		this.Controls.SetChildIndex(this.cmdCerrar, 0);
		this.Controls.SetChildIndex(this.UcTxtCampoBusca, 0);
		this.Controls.SetChildIndex(this.GridControl1, 0);
		this.Controls.SetChildIndex(this.DataNavigator1, 0);
		this.Controls.SetChildIndex(this.Button1, 0);
		((System.ComponentModel.ISupportInitialize)this.GridControl1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GridView1).EndInit();
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	// La lógica está en CatalogoPresenter; estos manejadores solo reenvían
	// los eventos de los controles a VistaCatalogoGrid.
	private void FrmMantTipoPerm_Load(object sender, EventArgs e)
	{
		_vista.Buscar();
	}

	private void DataNavigator1_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
	{
		_vista.ClickNavegador(e);
	}

	private void Vista1_BeforeLeaveRow(object sender, RowAllowEventArgs e)
	{
		_vista.AntesDeSalirDeFila(e);
	}

	private void Vista1_ValidateRow(object sender, ValidateRowEventArgs e)
	{
		_vista.ValidarFila(e);
	}

	private void Vista1_RowUpdated(object sender, RowObjectEventArgs e)
	{
		_vista.FilaActualizada(e);
	}

	private void UcTxtCampoBusca_TextChanged(object sender, EventArgs e)
	{
		_vista.Buscar();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		_vista.Buscar();
	}

	private void BtnCerrar_Click(object sender, EventArgs e)
	{
		Close();
	}
}
