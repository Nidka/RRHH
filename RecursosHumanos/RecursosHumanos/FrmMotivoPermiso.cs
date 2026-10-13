using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using GRLL.Common;
using Microsoft.VisualBasic.CompilerServices;
using RecursosHumanos.My.Resources;

namespace RecursosHumanos;

[DesignerGenerated]
public class FrmMotivoPermiso : FrmConsulta
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("UcComboBox1")]
	private ucComboBox _UcComboBox1;

	[AccessedThroughProperty("GroupControl1")]
	private GroupControl _GroupControl1;

	[AccessedThroughProperty("GridControl1")]
	private GridControl _GridControl1;

	[AccessedThroughProperty("GridView1")]
	private GridView _GridView1;

	[AccessedThroughProperty("btnEliminar")]
	private Button _btnEliminar;

	[AccessedThroughProperty("btnModificar")]
	private Button _btnModificar;

	[AccessedThroughProperty("btnAgregar")]
	private Button _btnAgregar;

	[AccessedThroughProperty("DefaultLookAndFeel1")]
	private DefaultLookAndFeel _DefaultLookAndFeel1;

	[AccessedThroughProperty("ToolTipController1")]
	private ToolTipController _ToolTipController1;

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

	internal ucComboBox UcComboBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcComboBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = UcComboBox1_SelectedIndexChanged;
			if (_UcComboBox1 != null)
			{
				_UcComboBox1.SelectedIndexChanged -= value2;
			}
			_UcComboBox1 = value;
			if (_UcComboBox1 != null)
			{
				_UcComboBox1.SelectedIndexChanged += value2;
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
			PaintEventHandler value2 = GroupControl1_Paint;
			if (_GroupControl1 != null)
			{
				_GroupControl1.Paint -= value2;
			}
			_GroupControl1 = value;
			if (_GroupControl1 != null)
			{
				_GroupControl1.Paint += value2;
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

	internal Button btnEliminar
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnEliminar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = btnEliminar_Click;
			if (_btnEliminar != null)
			{
				_btnEliminar.Click -= value2;
			}
			_btnEliminar = value;
			if (_btnEliminar != null)
			{
				_btnEliminar.Click += value2;
			}
		}
	}

	internal Button btnModificar
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnModificar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = btnModificar_Click;
			if (_btnModificar != null)
			{
				_btnModificar.Click -= value2;
			}
			_btnModificar = value;
			if (_btnModificar != null)
			{
				_btnModificar.Click += value2;
			}
		}
	}

	internal Button btnAgregar
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnAgregar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = btnAgregar_Click;
			if (_btnAgregar != null)
			{
				_btnAgregar.Click -= value2;
			}
			_btnAgregar = value;
			if (_btnAgregar != null)
			{
				_btnAgregar.Click += value2;
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

	[DebuggerNonUserCode]
	public FrmMotivoPermiso()
	{
		base.Load += FrmMotivoPermiso_Load;
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
		DevExpress.Utils.SuperToolTip superToolTip = new DevExpress.Utils.SuperToolTip();
		DevExpress.Utils.ToolTipTitleItem toolTipTitleItem = new DevExpress.Utils.ToolTipTitleItem();
		DevExpress.Utils.ToolTipItem toolTipItem = new DevExpress.Utils.ToolTipItem();
		this.Label1 = new System.Windows.Forms.Label();
		this.UcComboBox1 = new GRLL.Common.ucComboBox();
		this.GroupControl1 = new DevExpress.XtraEditors.GroupControl();
		this.btnEliminar = new System.Windows.Forms.Button();
		this.btnModificar = new System.Windows.Forms.Button();
		this.btnAgregar = new System.Windows.Forms.Button();
		this.GridControl1 = new DevExpress.XtraGrid.GridControl();
		this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.DefaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
		this.ToolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
		((System.ComponentModel.ISupportInitialize)this.GroupControl1).BeginInit();
		this.GroupControl1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.GridControl1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GridView1).BeginInit();
		this.SuspendLayout();
		this.cmdCerrar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.cmdCerrar.AutoSize = true;
		this.cmdCerrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.cmdCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cmdCerrar.FlatAppearance.BorderSize = 0;
		this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.cmdCerrar.Image = RecursosHumanos.My.Resources.Resources._exit;
		System.Windows.Forms.Button button = this.cmdCerrar;
		System.Drawing.Point location = new System.Drawing.Point(571, 293);
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
		System.Windows.Forms.Panel panelInf = this.PanelInf;
		location = new System.Drawing.Point(0, 323);
		panelInf.Location = location;
		this.Label1.AutoSize = true;
		System.Windows.Forms.Label label = this.Label1;
		location = new System.Drawing.Point(12, 45);
		label.Location = location;
		this.Label1.Name = "Label1";
		System.Windows.Forms.Label label2 = this.Label1;
		size = new System.Drawing.Size(71, 13);
		label2.Size = size;
		this.Label1.TabIndex = 3;
		this.Label1.Text = "Tipo Permiso:";
		this.UcComboBox1.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcComboBox1.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcComboBox1.FormattingEnabled = true;
		this.UcComboBox1.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucComboBox = this.UcComboBox1;
		location = new System.Drawing.Point(89, 42);
		ucComboBox.Location = location;
		this.UcComboBox1.Name = "UcComboBox1";
		GRLL.Common.ucComboBox ucComboBox2 = this.UcComboBox1;
		size = new System.Drawing.Size(225, 21);
		ucComboBox2.Size = size;
		this.UcComboBox1.TabIndex = 1;
		this.GroupControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.GroupControl1.Controls.Add(this.btnEliminar);
		this.GroupControl1.Controls.Add(this.btnModificar);
		this.GroupControl1.Controls.Add(this.btnAgregar);
		this.GroupControl1.Controls.Add(this.GridControl1);
		DevExpress.XtraEditors.GroupControl groupControl = this.GroupControl1;
		location = new System.Drawing.Point(12, 69);
		groupControl.Location = location;
		this.GroupControl1.Name = "GroupControl1";
		DevExpress.XtraEditors.GroupControl groupControl2 = this.GroupControl1;
		size = new System.Drawing.Size(620, 218);
		groupControl2.Size = size;
		this.GroupControl1.TabIndex = 2;
		this.GroupControl1.Text = "Motivo Permiso";
		this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnEliminar.FlatAppearance.BorderSize = 0;
		this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnEliminar.Image = RecursosHumanos.My.Resources.Resources.delete2;
		System.Windows.Forms.Button button3 = this.btnEliminar;
		location = new System.Drawing.Point(540, 141);
		button3.Location = location;
		this.btnEliminar.Name = "btnEliminar";
		System.Windows.Forms.Button button4 = this.btnEliminar;
		size = new System.Drawing.Size(75, 36);
		button4.Size = size;
		this.btnEliminar.TabIndex = 3;
		this.btnEliminar.Text = "Eliminar";
		this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.btnEliminar.UseVisualStyleBackColor = true;
		this.btnModificar.FlatAppearance.BorderSize = 0;
		this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnModificar.Image = RecursosHumanos.My.Resources.Resources.document_edit;
		System.Windows.Forms.Button button5 = this.btnModificar;
		location = new System.Drawing.Point(540, 98);
		button5.Location = location;
		this.btnModificar.Name = "btnModificar";
		System.Windows.Forms.Button button6 = this.btnModificar;
		size = new System.Drawing.Size(75, 37);
		button6.Size = size;
		this.btnModificar.TabIndex = 2;
		this.btnModificar.Text = "Modificar";
		this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.btnModificar.UseVisualStyleBackColor = true;
		this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAgregar.FlatAppearance.BorderSize = 0;
		this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAgregar.Image = RecursosHumanos.My.Resources.Resources.add2;
		System.Windows.Forms.Button button7 = this.btnAgregar;
		location = new System.Drawing.Point(540, 57);
		button7.Location = location;
		this.btnAgregar.Name = "btnAgregar";
		System.Windows.Forms.Button button8 = this.btnAgregar;
		size = new System.Drawing.Size(75, 35);
		button8.Size = size;
		this.btnAgregar.TabIndex = 1;
		this.btnAgregar.Text = "Agregar";
		this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.btnAgregar.UseVisualStyleBackColor = true;
		DevExpress.XtraGrid.GridControl gridControl = this.GridControl1;
		location = new System.Drawing.Point(5, 23);
		gridControl.Location = location;
		this.GridControl1.MainView = this.GridView1;
		this.GridControl1.Name = "GridControl1";
		DevExpress.XtraGrid.GridControl gridControl2 = this.GridControl1;
		size = new System.Drawing.Size(529, 184);
		gridControl2.Size = size;
		this.GridControl1.TabIndex = 0;
		this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[1] { this.GridView1 });
		this.GridView1.GridControl = this.GridControl1;
		this.GridView1.Name = "GridView1";
		this.GridView1.OptionsBehavior.Editable = false;
		this.GridView1.OptionsView.ShowGroupPanel = false;
		this.DefaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins";
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		size = new System.Drawing.Size(644, 350);
		this.ClientSize = size;
		this.Controls.Add(this.Label1);
		this.Controls.Add(this.GroupControl1);
		this.Controls.Add(this.UcComboBox1);
		this.MessageShow = true;
		this.Name = "FrmMotivoPermiso";
		this.TitleMsg = "FrmConsulta";
		this.Titulo = "Motivo Permiso";
		this.VerCmdCerrar = true;
		this.Controls.SetChildIndex(this.UcComboBox1, 0);
		this.Controls.SetChildIndex(this.cmdCerrar, 0);
		this.Controls.SetChildIndex(this.GroupControl1, 0);
		this.Controls.SetChildIndex(this.Label1, 0);
		this.Controls.SetChildIndex(this.PanelSup, 0);
		this.Controls.SetChildIndex(this.PanelInf, 0);
		((System.ComponentModel.ISupportInitialize)this.GroupControl1).EndInit();
		this.GroupControl1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.GridControl1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GridView1).EndInit();
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	private void GroupControl1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void FrmMotivoPermiso_Load(object sender, EventArgs e)
	{
		UcComboBox1.ValueMember = "idTipoPermiso";
		UcComboBox1.DisplayMember = "DescripTipoPermiso";
		List<TipoPermiso> list = TipoPermisoMapper.Instance().SelectAll();
		list.Insert(0, new TipoPermiso
		{
			idTipoPermiso = 0,
			DescripTipoPermiso = "(SELECCIONAR)"
		});
		UcComboBox1.DataSource = list;
	}

	private void UcComboBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		ucComboBox ucComboBox = UcComboBox1;
		int? num = default(int?);
		if (Conversions.ToDouble(RRHH.IdROl) == 10.0)
		{
			GridControl gridControl = GridControl1;
			dcGRLLDataContext dcGrll = Module1.DcGrll;
			object selectedValue = UcComboBox1.SelectedValue;
			gridControl.DataSource = dcGrll.spRRHH_getMotivo_perm((selectedValue != null) ? ((int?)selectedValue) : num, 'P');
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 14.0)
		{
			GridControl gridControl2 = GridControl1;
			dcGRLLDataContext dcGrll2 = Module1.DcGrll;
			object selectedValue2 = UcComboBox1.SelectedValue;
			gridControl2.DataSource = dcGrll2.spRRHH_getMotivo_perm((selectedValue2 != null) ? ((int?)selectedValue2) : num, 'C');
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 13.0)
		{
			GridControl gridControl3 = GridControl1;
			dcGRLLDataContext dcGrll3 = Module1.DcGrll;
			object selectedValue3 = UcComboBox1.SelectedValue;
			char? tipoModalidad = default(char?);
			gridControl3.DataSource = dcGrll3.spRRHH_getMotivo_perm((selectedValue3 != null) ? ((int?)selectedValue3) : num, tipoModalidad);
		}
		GridView1.Columns["idMotivo"].Visible = false;
		GridView1.Columns["Descrip_Motivo"].Caption = "Motivo";
		GridView1.Columns["idTipoPermiso"].Visible = false;
		GridView1.Columns["DescripTipoPermiso"].Visible = false;
		ucComboBox = null;
	}

	private void btnAgregar_Click(object sender, EventArgs e)
	{
		int focusedRowHandle = GridView1.FocusedRowHandle;
		FrmMantMotivo frmMantMotivo = new FrmMantMotivo();
		frmMantMotivo.idTipo = Conversions.ToInteger(UcComboBox1.SelectedValue);
		frmMantMotivo.ShowDialog();
		if (frmMantMotivo.DialogResult == DialogResult.OK)
		{
			int? num = default(int?);
			if (Conversions.ToDouble(RRHH.IdROl) == 10.0)
			{
				GridControl gridControl = GridControl1;
				dcGRLLDataContext dcGrll = Module1.DcGrll;
				object selectedValue = UcComboBox1.SelectedValue;
				gridControl.DataSource = dcGrll.spRRHH_getMotivo_perm((selectedValue != null) ? ((int?)selectedValue) : num, 'P');
			}
			else if (Conversions.ToDouble(RRHH.IdROl) == 14.0)
			{
				GridControl gridControl2 = GridControl1;
				dcGRLLDataContext dcGrll2 = Module1.DcGrll;
				object selectedValue2 = UcComboBox1.SelectedValue;
				gridControl2.DataSource = dcGrll2.spRRHH_getMotivo_perm((selectedValue2 != null) ? ((int?)selectedValue2) : num, 'C');
			}
			else if (Conversions.ToDouble(RRHH.IdROl) == 13.0)
			{
				GridControl gridControl3 = GridControl1;
				dcGRLLDataContext dcGrll3 = Module1.DcGrll;
				object selectedValue3 = UcComboBox1.SelectedValue;
				char? tipoModalidad = default(char?);
				gridControl3.DataSource = dcGrll3.spRRHH_getMotivo_perm((selectedValue3 != null) ? ((int?)selectedValue3) : num, tipoModalidad);
			}
		}
	}

	private void btnModificar_Click(object sender, EventArgs e)
	{
		int focusedRowHandle = GridView1.FocusedRowHandle;
		FrmMantMotivo frmMantMotivo = new FrmMantMotivo();
		frmMantMotivo.idTipo = Conversions.ToInteger(UcComboBox1.SelectedValue);
		frmMantMotivo.idMotivo = Conversions.ToInteger(GridView1.GetRowCellValue(focusedRowHandle, "idMotivo"));
		frmMantMotivo.ShowDialog();
		if (frmMantMotivo.DialogResult == DialogResult.OK)
		{
			int? num = default(int?);
			if (Conversions.ToDouble(RRHH.IdROl) == 10.0)
			{
				GridControl gridControl = GridControl1;
				dcGRLLDataContext dcGrll = Module1.DcGrll;
				object selectedValue = UcComboBox1.SelectedValue;
				gridControl.DataSource = dcGrll.spRRHH_getMotivo_perm((selectedValue != null) ? ((int?)selectedValue) : num, 'P');
			}
			else if (Conversions.ToDouble(RRHH.IdROl) == 14.0)
			{
				GridControl gridControl2 = GridControl1;
				dcGRLLDataContext dcGrll2 = Module1.DcGrll;
				object selectedValue2 = UcComboBox1.SelectedValue;
				gridControl2.DataSource = dcGrll2.spRRHH_getMotivo_perm((selectedValue2 != null) ? ((int?)selectedValue2) : num, 'C');
			}
			else if (Conversions.ToDouble(RRHH.IdROl) == 13.0)
			{
				GridControl gridControl3 = GridControl1;
				dcGRLLDataContext dcGrll3 = Module1.DcGrll;
				object selectedValue3 = UcComboBox1.SelectedValue;
				char? tipoModalidad = default(char?);
				gridControl3.DataSource = dcGrll3.spRRHH_getMotivo_perm((selectedValue3 != null) ? ((int?)selectedValue3) : num, tipoModalidad);
			}
		}
	}

	private void btnEliminar_Click(object sender, EventArgs e)
	{
		int focusedRowHandle = GridView1.FocusedRowHandle;
		if (focusedRowHandle < 0)
		{
			MessageBox.Show("Primero debe Seleccionar un Motivo.");
		}
		else if (MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject("Desea eliminar el Registro: ", GridView1.GetRowCellValue(focusedRowHandle, "Descrip_Motivo"))), "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
		{
			Motivo_Perm motivo_Perm = new Motivo_Perm();
			motivo_Perm.idMotivo = Conversions.ToInteger(GridView1.GetRowCellValue(focusedRowHandle, "idMotivo"));
			Motivo_PermMapper.Instance().Delete(motivo_Perm);
			int? num = default(int?);
			if (Conversions.ToDouble(RRHH.IdROl) == 10.0)
			{
				GridControl gridControl = GridControl1;
				dcGRLLDataContext dcGrll = Module1.DcGrll;
				object selectedValue = UcComboBox1.SelectedValue;
				gridControl.DataSource = dcGrll.spRRHH_getMotivo_perm((selectedValue != null) ? ((int?)selectedValue) : num, 'P');
			}
			else if (Conversions.ToDouble(RRHH.IdROl) == 14.0)
			{
				GridControl gridControl2 = GridControl1;
				dcGRLLDataContext dcGrll2 = Module1.DcGrll;
				object selectedValue2 = UcComboBox1.SelectedValue;
				gridControl2.DataSource = dcGrll2.spRRHH_getMotivo_perm((selectedValue2 != null) ? ((int?)selectedValue2) : num, 'C');
			}
			else if (Conversions.ToDouble(RRHH.IdROl) == 13.0)
			{
				GridControl gridControl3 = GridControl1;
				dcGRLLDataContext dcGrll3 = Module1.DcGrll;
				object selectedValue3 = UcComboBox1.SelectedValue;
				char? tipoModalidad = default(char?);
				gridControl3.DataSource = dcGrll3.spRRHH_getMotivo_perm((selectedValue3 != null) ? ((int?)selectedValue3) : num, tipoModalidad);
			}
		}
	}
}
