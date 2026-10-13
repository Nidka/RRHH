using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using GRLL.Common;
using Microsoft.VisualBasic.CompilerServices;
using RecursosHumanos.My.Resources;

namespace RecursosHumanos;

[DesignerGenerated]
public class FrmLocalAsignado : FrmConsulta
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("GroupControl1")]
	private GroupControl _GroupControl1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("BtnBuscar")]
	private Button _BtnBuscar;

	[AccessedThroughProperty("UcTextBox1")]
	private ucTextBox _UcTextBox1;

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

	[AccessedThroughProperty("GridColumn5")]
	private GridColumn _GridColumn5;

	[AccessedThroughProperty("GridColumn6")]
	private GridColumn _GridColumn6;

	[AccessedThroughProperty("GridColumn4")]
	private GridColumn _GridColumn4;

	[AccessedThroughProperty("RepositoryItemLookUpEdit1")]
	private RepositoryItemLookUpEdit _RepositoryItemLookUpEdit1;

	[AccessedThroughProperty("RepositoryItemComboBox1")]
	private RepositoryItemComboBox _RepositoryItemComboBox1;

	[AccessedThroughProperty("RepositoryItemComboBox2")]
	private RepositoryItemComboBox _RepositoryItemComboBox2;

	[AccessedThroughProperty("RepositoryItemImageComboBox1")]
	private RepositoryItemImageComboBox _RepositoryItemImageComboBox1;

	[AccessedThroughProperty("DefaultLookAndFeel1")]
	private DefaultLookAndFeel _DefaultLookAndFeel1;

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
			EventHandler value2 = BtnBuscar_Click;
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

	internal ucTextBox UcTextBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTextBox1 = value;
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

	internal RepositoryItemLookUpEdit RepositoryItemLookUpEdit1
	{
		[DebuggerNonUserCode]
		get
		{
			return _RepositoryItemLookUpEdit1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			ChangingEventHandler value2 = LookUpEditEditValueChanging;
			if (_RepositoryItemLookUpEdit1 != null)
			{
				_RepositoryItemLookUpEdit1.EditValueChanging -= value2;
			}
			_RepositoryItemLookUpEdit1 = value;
			if (_RepositoryItemLookUpEdit1 != null)
			{
				_RepositoryItemLookUpEdit1.EditValueChanging += value2;
			}
		}
	}

	internal RepositoryItemComboBox RepositoryItemComboBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _RepositoryItemComboBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RepositoryItemComboBox1 = value;
		}
	}

	internal RepositoryItemComboBox RepositoryItemComboBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _RepositoryItemComboBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RepositoryItemComboBox2 = value;
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

	[DebuggerNonUserCode]
	public FrmLocalAsignado()
	{
		base.Load += FrmLocalAsignado_Load;
		__ENCAddToList(this);
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
		this.GridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.RepositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
		this.GroupControl1 = new DevExpress.XtraEditors.GroupControl();
		this.Label1 = new System.Windows.Forms.Label();
		this.BtnBuscar = new System.Windows.Forms.Button();
		this.UcTextBox1 = new GRLL.Common.ucTextBox(this.components);
		this.GridControl1 = new DevExpress.XtraGrid.GridControl();
		this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.GridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.RepositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
		this.RepositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
		this.RepositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
		this.DefaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
		((System.ComponentModel.ISupportInitialize)this.RepositoryItemLookUpEdit1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GroupControl1).BeginInit();
		this.GroupControl1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.GridControl1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GridView1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.RepositoryItemComboBox1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.RepositoryItemComboBox2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.RepositoryItemImageComboBox1).BeginInit();
		this.SuspendLayout();
		this.cmdCerrar.AutoSize = true;
		this.cmdCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cmdCerrar.FlatAppearance.BorderSize = 0;
		this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.cmdCerrar.Image = RecursosHumanos.My.Resources.Resources._exit;
		System.Windows.Forms.Button button = this.cmdCerrar;
		System.Drawing.Point location = new System.Drawing.Point(721, 412);
		button.Location = location;
		System.Windows.Forms.Button button2 = this.cmdCerrar;
		System.Drawing.Size size = new System.Drawing.Size(63, 25);
		button2.Size = size;
		this.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		System.Windows.Forms.Panel panelSup = this.PanelSup;
		size = new System.Drawing.Size(798, 29);
		panelSup.Size = size;
		System.Windows.Forms.Panel panelInf = this.PanelInf;
		location = new System.Drawing.Point(0, 446);
		panelInf.Location = location;
		System.Windows.Forms.Panel panelInf2 = this.PanelInf;
		size = new System.Drawing.Size(798, 27);
		panelInf2.Size = size;
		this.GridColumn4.Caption = "Local Asignado";
		this.GridColumn4.ColumnEdit = this.RepositoryItemLookUpEdit1;
		this.GridColumn4.FieldName = "idLocal";
		this.GridColumn4.Name = "GridColumn4";
		this.GridColumn4.Visible = true;
		this.GridColumn4.VisibleIndex = 4;
		this.GridColumn4.Width = 162;
		this.RepositoryItemLookUpEdit1.AutoHeight = false;
		this.RepositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
		});
		this.RepositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[2]
		{
			new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idLocal", "Name9", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
			new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NombreLocal", "Descripcion")
		});
		this.RepositoryItemLookUpEdit1.DisplayMember = "Descrip_Horario";
		this.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1";
		this.RepositoryItemLookUpEdit1.ValueMember = "idHorario";
		this.GroupControl1.Controls.Add(this.Label1);
		this.GroupControl1.Controls.Add(this.BtnBuscar);
		this.GroupControl1.Controls.Add(this.UcTextBox1);
		DevExpress.XtraEditors.GroupControl groupControl = this.GroupControl1;
		location = new System.Drawing.Point(12, 35);
		groupControl.Location = location;
		this.GroupControl1.Name = "GroupControl1";
		DevExpress.XtraEditors.GroupControl groupControl2 = this.GroupControl1;
		size = new System.Drawing.Size(478, 72);
		groupControl2.Size = size;
		this.GroupControl1.TabIndex = 10;
		this.GroupControl1.Text = "Parametros de Busqueda";
		this.Label1.AutoSize = true;
		System.Windows.Forms.Label label = this.Label1;
		location = new System.Drawing.Point(10, 37);
		label.Location = location;
		this.Label1.Name = "Label1";
		System.Windows.Forms.Label label2 = this.Label1;
		size = new System.Drawing.Size(87, 13);
		label2.Size = size;
		this.Label1.TabIndex = 7;
		this.Label1.Text = "Apellido Paterno:";
		this.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
		this.BtnBuscar.AutoSize = true;
		this.BtnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BtnBuscar.FlatAppearance.BorderSize = 0;
		this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BtnBuscar.Image = RecursosHumanos.My.Resources.Resources.view1;
		System.Windows.Forms.Button btnBuscar = this.BtnBuscar;
		location = new System.Drawing.Point(394, 32);
		btnBuscar.Location = location;
		this.BtnBuscar.Name = "BtnBuscar";
		System.Windows.Forms.Button btnBuscar2 = this.BtnBuscar;
		size = new System.Drawing.Size(66, 23);
		btnBuscar2.Size = size;
		this.BtnBuscar.TabIndex = 8;
		this.BtnBuscar.Text = "Buscar";
		this.BtnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.BtnBuscar.UseVisualStyleBackColor = true;
		this.UcTextBox1.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTextBox1.Formato = null;
		this.UcTextBox1.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTextBox = this.UcTextBox1;
		location = new System.Drawing.Point(103, 34);
		ucTextBox.Location = location;
		this.UcTextBox1.Name = "UcTextBox1";
		this.UcTextBox1.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTextBox1.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTextBox1.OnErrorBlankText = "";
		this.UcTextBox1.PadLeftLenght = 0;
		this.UcTextBox1.RegularExpression = "^[A-Z,a-z,\\s]+$";
		this.UcTextBox1.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTextBox1.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTextBox2 = this.UcTextBox1;
		size = new System.Drawing.Size(285, 20);
		ucTextBox2.Size = size;
		this.UcTextBox1.TabIndex = 6;
		this.UcTextBox1.TabNextControl = false;
		this.UcTextBox1.Tipo = GRLL.Common.ucTextBox.TipoDato.SoloLetras;
		DevExpress.XtraGrid.GridControl gridControl = this.GridControl1;
		location = new System.Drawing.Point(12, 113);
		gridControl.Location = location;
		this.GridControl1.MainView = this.GridView1;
		this.GridControl1.Name = "GridControl1";
		this.GridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[4] { this.RepositoryItemComboBox1, this.RepositoryItemComboBox2, this.RepositoryItemImageComboBox1, this.RepositoryItemLookUpEdit1 });
		DevExpress.XtraGrid.GridControl gridControl2 = this.GridControl1;
		size = new System.Drawing.Size(772, 293);
		gridControl2.Size = size;
		this.GridControl1.TabIndex = 11;
		this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[1] { this.GridView1 });
		this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[6] { this.GridColumn1, this.GridColumn2, this.GridColumn3, this.GridColumn5, this.GridColumn6, this.GridColumn4 });
		styleFormatCondition.Appearance.BackColor = System.Drawing.Color.Red;
		styleFormatCondition.Appearance.Options.UseBackColor = true;
		styleFormatCondition.ApplyToRow = true;
		styleFormatCondition.Column = this.GridColumn4;
		styleFormatCondition.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
		this.GridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[1] { styleFormatCondition });
		this.GridView1.GridControl = this.GridControl1;
		this.GridView1.Name = "GridView1";
		this.GridView1.OptionsView.ShowGroupPanel = false;
		this.GridColumn1.Caption = "idEmpleado";
		this.GridColumn1.FieldName = "idEmpleado";
		this.GridColumn1.Name = "GridColumn1";
		this.GridColumn2.Caption = "Numero DNI";
		this.GridColumn2.FieldName = "NumDocID";
		this.GridColumn2.Name = "GridColumn2";
		this.GridColumn2.OptionsColumn.AllowEdit = false;
		this.GridColumn2.Visible = true;
		this.GridColumn2.VisibleIndex = 0;
		this.GridColumn2.Width = 96;
		this.GridColumn3.Caption = "Nombres";
		this.GridColumn3.FieldName = "Nombres";
		this.GridColumn3.Name = "GridColumn3";
		this.GridColumn3.OptionsColumn.AllowEdit = false;
		this.GridColumn3.Visible = true;
		this.GridColumn3.VisibleIndex = 1;
		this.GridColumn3.Width = 159;
		this.GridColumn5.Caption = "Apellido Paterno";
		this.GridColumn5.FieldName = "Apellido_Paterno";
		this.GridColumn5.Name = "GridColumn5";
		this.GridColumn5.OptionsColumn.AllowEdit = false;
		this.GridColumn5.Visible = true;
		this.GridColumn5.VisibleIndex = 2;
		this.GridColumn5.Width = 159;
		this.GridColumn6.Caption = "Apellido Materno";
		this.GridColumn6.FieldName = "Apellido_Materno";
		this.GridColumn6.Name = "GridColumn6";
		this.GridColumn6.OptionsColumn.AllowEdit = false;
		this.GridColumn6.Visible = true;
		this.GridColumn6.VisibleIndex = 3;
		this.GridColumn6.Width = 159;
		this.RepositoryItemComboBox1.AutoHeight = false;
		this.RepositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
		});
		this.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1";
		this.RepositoryItemComboBox2.AutoHeight = false;
		this.RepositoryItemComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
		});
		this.RepositoryItemComboBox2.Name = "RepositoryItemComboBox2";
		this.RepositoryItemImageComboBox1.AutoHeight = false;
		this.RepositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
		});
		this.RepositoryItemImageComboBox1.Name = "RepositoryItemImageComboBox1";
		this.DefaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins";
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		size = new System.Drawing.Size(798, 473);
		this.ClientSize = size;
		this.Controls.Add(this.GridControl1);
		this.Controls.Add(this.GroupControl1);
		this.MessageShow = true;
		this.Name = "FrmLocalAsignado";
		this.TitleMsg = "FrmConsulta";
		this.Titulo = "Local Asignado";
		this.TituloFrm = "Local Asignado";
		this.VerCmdCerrar = true;
		this.Controls.SetChildIndex(this.PanelSup, 0);
		this.Controls.SetChildIndex(this.PanelInf, 0);
		this.Controls.SetChildIndex(this.cmdCerrar, 0);
		this.Controls.SetChildIndex(this.GroupControl1, 0);
		this.Controls.SetChildIndex(this.GridControl1, 0);
		((System.ComponentModel.ISupportInitialize)this.RepositoryItemLookUpEdit1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GroupControl1).EndInit();
		this.GroupControl1.ResumeLayout(false);
		this.GroupControl1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.GridControl1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GridView1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.RepositoryItemComboBox1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.RepositoryItemComboBox2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.RepositoryItemImageComboBox1).EndInit();
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	private void FrmLocalAsignado_Load(object sender, EventArgs e)
	{
		List<Local> dataSource = LocalMapper.Instance().SelectAll();
		RepositoryItemLookUpEdit1.ValueMember = "idLocal";
		RepositoryItemLookUpEdit1.DisplayMember = "NombreLocal";
		RepositoryItemLookUpEdit1.DataSource = dataSource;
		RepositoryItemLookUpEdit1.BestFitMode = BestFitMode.BestFitResizePopup;
		GridColumn4.ColumnEdit.NullText = "SIN LOCAL ASIGNADO";
		if (Conversions.ToDouble(RRHH.IdROl) == 10.0)
		{
			ISingleResult<sp_Listar_Empleado_LocalResult> dataSource2 = Module1.DcGrll.sp_Listar_Empleado_Local(1, null);
			GridControl1.DataSource = dataSource2;
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 14.0)
		{
			ISingleResult<sp_Listar_Empleado_LocalResult> dataSource3 = Module1.DcGrll.sp_Listar_Empleado_Local(2, null);
			GridControl1.DataSource = dataSource3;
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 13.0)
		{
			int? idTipoTrabajador = default(int?);
			ISingleResult<sp_Listar_Empleado_LocalResult> dataSource4 = Module1.DcGrll.sp_Listar_Empleado_Local(idTipoTrabajador, null);
			GridControl1.DataSource = dataSource4;
		}
	}

	private void cmdCerrar_Click(object sender, EventArgs e)
	{
		Close();
	}

	public void LookUpEditEditValueChanging(object sender, ChangingEventArgs e)
	{
		Module1.DcGrll.sp_Update_Empleado_idLocal_By_idEmpleado(Conversions.ToInteger(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "idEmpleado")), Conversions.ToInteger(e.NewValue));
	}

	private void BtnBuscar_Click(object sender, EventArgs e)
	{
		if (Conversions.ToDouble(RRHH.IdROl) == 10.0)
		{
			ISingleResult<sp_Listar_Empleado_LocalResult> dataSource = Module1.DcGrll.sp_Listar_Empleado_Local(1, UcTextBox1.Text.Trim());
			GridControl1.DataSource = dataSource;
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 14.0)
		{
			ISingleResult<sp_Listar_Empleado_LocalResult> dataSource2 = Module1.DcGrll.sp_Listar_Empleado_Local(2, UcTextBox1.Text.Trim());
			GridControl1.DataSource = dataSource2;
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 13.0)
		{
			int? idTipoTrabajador = default(int?);
			ISingleResult<sp_Listar_Empleado_LocalResult> dataSource3 = Module1.DcGrll.sp_Listar_Empleado_Local(idTipoTrabajador, UcTextBox1.Text.Trim());
			GridControl1.DataSource = dataSource3;
		}
	}
}
