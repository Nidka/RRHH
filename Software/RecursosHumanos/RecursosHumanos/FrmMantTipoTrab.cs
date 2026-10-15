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
public class FrmMantTipoTrab : FrmConsulta, IFormularioCatalogo
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

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

	[AccessedThroughProperty("UcTxtCampoBusca")]
	private ucTextBox _UcTxtCampoBusca;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("DefaultLookAndFeel1")]
	private DefaultLookAndFeel _DefaultLookAndFeel1;

	[AccessedThroughProperty("ImageList1")]
	private ImageList _ImageList1;

	[AccessedThroughProperty("DataNavigator1")]
	private DataNavigator _DataNavigator1;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox _PictureBox2;

	[AccessedThroughProperty("PictureBox3")]
	private PictureBox _PictureBox3;

	[AccessedThroughProperty("PictureBox4")]
	private PictureBox _PictureBox4;

	private VistaCatalogoGrid _vista;

	ICatalogoView IFormularioCatalogo.Vista => _vista;

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

	internal ImageList ImageList1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ImageList1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ImageList1 = value;
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

	internal PictureBox PictureBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox1 = value;
		}
	}

	internal PictureBox PictureBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox2 = value;
		}
	}

	internal PictureBox PictureBox3
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox3 = value;
		}
	}

	internal PictureBox PictureBox4
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox4 = value;
		}
	}

	public FrmMantTipoTrab()
	{
		base.Load += FrmMantTipoTrab_Load;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecursosHumanos.FrmMantTipoTrab));
		this.GridControl1 = new DevExpress.XtraGrid.GridControl();
		this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.GridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.UcTxtCampoBusca = new GRLL.Common.ucTextBox(this.components);
		this.Button1 = new System.Windows.Forms.Button();
		this.DefaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
		this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
		this.DataNavigator1 = new DevExpress.XtraEditors.DataNavigator();
		this.PictureBox1 = new System.Windows.Forms.PictureBox();
		this.PictureBox2 = new System.Windows.Forms.PictureBox();
		this.PictureBox3 = new System.Windows.Forms.PictureBox();
		this.PictureBox4 = new System.Windows.Forms.PictureBox();
		((System.ComponentModel.ISupportInitialize)this.GridControl1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GridView1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox3).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox4).BeginInit();
		this.SuspendLayout();
		this.cmdCerrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.cmdCerrar.AutoSize = true;
		this.cmdCerrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.cmdCerrar.FlatAppearance.BorderSize = 0;
		this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.cmdCerrar.Image = (System.Drawing.Image)resources.GetObject("cmdCerrar.Image");
		System.Windows.Forms.Button button = this.cmdCerrar;
		System.Drawing.Point location = new System.Drawing.Point(385, 376);
		button.Location = location;
		System.Windows.Forms.Button button2 = this.cmdCerrar;
		System.Drawing.Size size = new System.Drawing.Size(61, 23);
		button2.Size = size;
		this.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.cmdCerrar.Visible = true;
		System.Windows.Forms.Panel panelSup = this.PanelSup;
		size = new System.Drawing.Size(458, 24);
		panelSup.Size = size;
		System.Windows.Forms.Panel panelInf = this.PanelInf;
		location = new System.Drawing.Point(0, 405);
		panelInf.Location = location;
		System.Windows.Forms.Panel panelInf2 = this.PanelInf;
		size = new System.Drawing.Size(458, 27);
		panelInf2.Size = size;
		this.GridControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.GridControl1.EmbeddedNavigator.Name = "";
		DevExpress.XtraGrid.GridControl gridControl = this.GridControl1;
		location = new System.Drawing.Point(1, 59);
		gridControl.Location = location;
		this.GridControl1.MainView = this.GridView1;
		this.GridControl1.Name = "GridControl1";
		DevExpress.XtraGrid.GridControl gridControl2 = this.GridControl1;
		size = new System.Drawing.Size(453, 286);
		gridControl2.Size = size;
		this.GridControl1.TabIndex = 12;
		this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[1] { this.GridView1 });
		this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[3] { this.GridColumn1, this.GridColumn2, this.GridColumn3 });
		this.GridView1.GridControl = this.GridControl1;
		this.GridView1.Name = "GridView1";
		this.GridView1.OptionsDetail.AllowZoomDetail = false;
		this.GridView1.OptionsDetail.EnableMasterViewMode = false;
		this.GridView1.OptionsDetail.ShowDetailTabs = false;
		this.GridView1.OptionsFilter.AllowColumnMRUFilterList = false;
		this.GridView1.OptionsFilter.AllowFilterEditor = false;
		this.GridView1.OptionsMenu.EnableFooterMenu = false;
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
		this.GridColumn2.Width = 186;
		this.GridColumn3.Caption = "Observaciones";
		this.GridColumn3.FieldName = "Extra";
		this.GridColumn3.Name = "GridColumn3";
		this.GridColumn3.Visible = true;
		this.GridColumn3.VisibleIndex = 2;
		this.GridColumn3.Width = 186;
		this.UcTxtCampoBusca.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtCampoBusca.Formato = null;
		this.UcTxtCampoBusca.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtCampoBusca = this.UcTxtCampoBusca;
		location = new System.Drawing.Point(13, 32);
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
		this.UcTxtCampoBusca.TabIndex = 11;
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
		location = new System.Drawing.Point(370, 25);
		button3.Location = location;
		this.Button1.Name = "Button1";
		System.Windows.Forms.Button button4 = this.Button1;
		size = new System.Drawing.Size(74, 30);
		button4.Size = size;
		this.Button1.TabIndex = 13;
		this.Button1.Text = "Buscar";
		this.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.Button1.UseVisualStyleBackColor = true;
		this.DefaultLookAndFeel1.LookAndFeel.SkinName = "Blue";
		this.ImageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("ImageList1.ImageStream");
		this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
		this.ImageList1.Images.SetKeyName(0, "disk_blue.png");
		this.ImageList1.Images.SetKeyName(1, "delete.png");
		this.ImageList1.Images.SetKeyName(2, "document_new.png");
		this.ImageList1.Images.SetKeyName(3, "stop.png");
		this.DataNavigator1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.DataNavigator1.Buttons.Append.ImageIndex = 2;
		this.DataNavigator1.Buttons.CancelEdit.ImageIndex = 3;
		this.DataNavigator1.Buttons.EndEdit.ImageIndex = 0;
		this.DataNavigator1.Buttons.ImageList = this.ImageList1;
		this.DataNavigator1.Buttons.Remove.ImageIndex = 1;
		this.DataNavigator1.CustomButtons.AddRange(new DevExpress.XtraEditors.NavigatorCustomButton[1]
		{
			new DevExpress.XtraEditors.NavigatorCustomButton()
		});
		DevExpress.XtraEditors.DataNavigator dataNavigator = this.DataNavigator1;
		location = new System.Drawing.Point(-2, 345);
		dataNavigator.Location = location;
		this.DataNavigator1.Name = "DataNavigator1";
		DevExpress.XtraEditors.DataNavigator dataNavigator2 = this.DataNavigator1;
		size = new System.Drawing.Size(456, 23);
		dataNavigator2.Size = size;
		this.DataNavigator1.TabIndex = 15;
		this.DataNavigator1.Text = "DataNavigator1";
		this.DataNavigator1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center;
		this.DataNavigator1.TextStringFormat = "Registro {0} de {1}";
		this.PictureBox1.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.PictureBox pictureBox = this.PictureBox1;
		location = new System.Drawing.Point(288, 348);
		pictureBox.Location = location;
		this.PictureBox1.Name = "PictureBox1";
		System.Windows.Forms.PictureBox pictureBox2 = this.PictureBox1;
		size = new System.Drawing.Size(20, 23);
		pictureBox2.Size = size;
		this.PictureBox1.TabIndex = 24;
		this.PictureBox1.TabStop = false;
		this.PictureBox2.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.PictureBox pictureBox3 = this.PictureBox2;
		location = new System.Drawing.Point(325, 348);
		pictureBox3.Location = location;
		this.PictureBox2.Name = "PictureBox2";
		System.Windows.Forms.PictureBox pictureBox4 = this.PictureBox2;
		size = new System.Drawing.Size(20, 23);
		pictureBox4.Size = size;
		this.PictureBox2.TabIndex = 25;
		this.PictureBox2.TabStop = false;
		this.PictureBox3.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.PictureBox pictureBox5 = this.PictureBox3;
		location = new System.Drawing.Point(362, 348);
		pictureBox5.Location = location;
		this.PictureBox3.Name = "PictureBox3";
		System.Windows.Forms.PictureBox pictureBox6 = this.PictureBox3;
		size = new System.Drawing.Size(20, 23);
		pictureBox6.Size = size;
		this.PictureBox3.TabIndex = 26;
		this.PictureBox3.TabStop = false;
		this.PictureBox4.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.PictureBox pictureBox7 = this.PictureBox4;
		location = new System.Drawing.Point(400, 348);
		pictureBox7.Location = location;
		this.PictureBox4.Name = "PictureBox4";
		System.Windows.Forms.PictureBox pictureBox8 = this.PictureBox4;
		size = new System.Drawing.Size(20, 23);
		pictureBox8.Size = size;
		this.PictureBox4.TabIndex = 27;
		this.PictureBox4.TabStop = false;
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.Calculadora = false;
		size = new System.Drawing.Size(458, 432);
		this.ClientSize = size;
		this.Controls.Add(this.DataNavigator1);
		this.Controls.Add(this.GridControl1);
		this.Controls.Add(this.UcTxtCampoBusca);
		this.Controls.Add(this.Button1);
		this.Controls.Add(this.PictureBox1);
		this.Controls.Add(this.PictureBox2);
		this.Controls.Add(this.PictureBox3);
		this.Controls.Add(this.PictureBox4);
		this.MessageShow = true;
		this.Name = "FrmMantTipoTrab";
		this.TitleMsg = "FrmConsulta";
		this.Titulo = "Condicion Laboral";
		this.VerCmdCerrar = true;
		this.Controls.SetChildIndex(this.cmdCerrar, 0);
		this.Controls.SetChildIndex(this.PictureBox4, 0);
		this.Controls.SetChildIndex(this.PictureBox3, 0);
		this.Controls.SetChildIndex(this.PictureBox2, 0);
		this.Controls.SetChildIndex(this.PictureBox1, 0);
		this.Controls.SetChildIndex(this.Button1, 0);
		this.Controls.SetChildIndex(this.UcTxtCampoBusca, 0);
		this.Controls.SetChildIndex(this.GridControl1, 0);
		this.Controls.SetChildIndex(this.DataNavigator1, 0);
		this.Controls.SetChildIndex(this.PanelSup, 0);
		this.Controls.SetChildIndex(this.PanelInf, 0);
		((System.ComponentModel.ISupportInitialize)this.GridControl1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GridView1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox3).EndInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox4).EndInit();
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	// La lógica está en CatalogoPresenter; estos manejadores solo reenvían
	// los eventos de los controles a VistaCatalogoGrid.
	private void FrmMantTipoTrab_Load(object sender, EventArgs e)
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
