using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using GRLL.Common;
using Microsoft.VisualBasic.CompilerServices;
using RecursosHumanos.My.Resources;

namespace RecursosHumanos;

[DesignerGenerated]
public class FrmHorarios : FrmConsulta
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("GroupControl12")]
	private GroupControl _GroupControl12;

	[AccessedThroughProperty("DGVHorarios")]
	private GridControl _DGVHorarios;

	[AccessedThroughProperty("GridViewHorarios")]
	private GridView _GridViewHorarios;

	[AccessedThroughProperty("BtnMod")]
	private Button _BtnMod;

	[AccessedThroughProperty("BtnAgregar")]
	private Button _BtnAgregar;

	[AccessedThroughProperty("BtnEliminar")]
	private Button _BtnEliminar;

	[AccessedThroughProperty("GridColumn1")]
	private GridColumn _GridColumn1;

	[AccessedThroughProperty("GridColumn6")]
	private GridColumn _GridColumn6;

	[AccessedThroughProperty("GridColumn2")]
	private GridColumn _GridColumn2;

	[AccessedThroughProperty("GridColumn4")]
	private GridColumn _GridColumn4;

	[AccessedThroughProperty("GridColumn5")]
	private GridColumn _GridColumn5;

	[AccessedThroughProperty("GridColumn3")]
	private GridColumn _GridColumn3;

	[AccessedThroughProperty("GridColumn7")]
	private GridColumn _GridColumn7;

	internal GroupControl GroupControl12
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupControl12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupControl12 = value;
		}
	}

	internal GridControl DGVHorarios
	{
		[DebuggerNonUserCode]
		get
		{
			return _DGVHorarios;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DGVHorarios = value;
		}
	}

	internal GridView GridViewHorarios
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridViewHorarios;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridViewHorarios = value;
		}
	}

	internal Button BtnMod
	{
		[DebuggerNonUserCode]
		get
		{
			return _BtnMod;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = BtnMod_Click;
			if (_BtnMod != null)
			{
				_BtnMod.Click -= value2;
			}
			_BtnMod = value;
			if (_BtnMod != null)
			{
				_BtnMod.Click += value2;
			}
		}
	}

	internal Button BtnAgregar
	{
		[DebuggerNonUserCode]
		get
		{
			return _BtnAgregar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = BtnAgregar_Click;
			if (_BtnAgregar != null)
			{
				_BtnAgregar.Click -= value2;
			}
			_BtnAgregar = value;
			if (_BtnAgregar != null)
			{
				_BtnAgregar.Click += value2;
			}
		}
	}

	internal Button BtnEliminar
	{
		[DebuggerNonUserCode]
		get
		{
			return _BtnEliminar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = BtnEliminar_Click;
			if (_BtnEliminar != null)
			{
				_BtnEliminar.Click -= value2;
			}
			_BtnEliminar = value;
			if (_BtnEliminar != null)
			{
				_BtnEliminar.Click += value2;
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

	[DebuggerNonUserCode]
	public FrmHorarios()
	{
		base.Load += FrmHorarios_Load;
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
		this.GroupControl12 = new DevExpress.XtraEditors.GroupControl();
		this.DGVHorarios = new DevExpress.XtraGrid.GridControl();
		this.GridViewHorarios = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.GridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.BtnMod = new System.Windows.Forms.Button();
		this.BtnAgregar = new System.Windows.Forms.Button();
		this.BtnEliminar = new System.Windows.Forms.Button();
		((System.ComponentModel.ISupportInitialize)this.GroupControl12).BeginInit();
		this.GroupControl12.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.DGVHorarios).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GridViewHorarios).BeginInit();
		this.SuspendLayout();
		this.cmdCerrar.AutoSize = true;
		this.cmdCerrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.cmdCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cmdCerrar.FlatAppearance.BorderSize = 0;
		this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.cmdCerrar.Image = RecursosHumanos.My.Resources.Resources._exit;
		System.Windows.Forms.Button button = this.cmdCerrar;
		System.Drawing.Point location = new System.Drawing.Point(590, 204);
		button.Location = location;
		System.Windows.Forms.Button button2 = this.cmdCerrar;
		System.Drawing.Size size = new System.Drawing.Size(61, 23);
		button2.Size = size;
		this.cmdCerrar.TabIndex = 1;
		this.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		System.Windows.Forms.Panel panelSup = this.PanelSup;
		size = new System.Drawing.Size(659, 29);
		panelSup.Size = size;
		System.Windows.Forms.Panel panelInf = this.PanelInf;
		location = new System.Drawing.Point(0, 233);
		panelInf.Location = location;
		System.Windows.Forms.Panel panelInf2 = this.PanelInf;
		size = new System.Drawing.Size(659, 27);
		panelInf2.Size = size;
		this.GroupControl12.Controls.Add(this.DGVHorarios);
		this.GroupControl12.Controls.Add(this.BtnMod);
		this.GroupControl12.Controls.Add(this.BtnAgregar);
		this.GroupControl12.Controls.Add(this.BtnEliminar);
		DevExpress.XtraEditors.GroupControl groupControl = this.GroupControl12;
		location = new System.Drawing.Point(12, 35);
		groupControl.Location = location;
		this.GroupControl12.LookAndFeel.SkinName = "Money Twins";
		this.GroupControl12.LookAndFeel.UseDefaultLookAndFeel = false;
		this.GroupControl12.Name = "GroupControl12";
		DevExpress.XtraEditors.GroupControl groupControl2 = this.GroupControl12;
		size = new System.Drawing.Size(639, 159);
		groupControl2.Size = size;
		this.GroupControl12.TabIndex = 0;
		this.GroupControl12.Text = "Información de Horarios";
		DevExpress.XtraGrid.GridControl dGVHorarios = this.DGVHorarios;
		location = new System.Drawing.Point(1, 19);
		dGVHorarios.Location = location;
		this.DGVHorarios.LookAndFeel.SkinName = "Blue";
		this.DGVHorarios.LookAndFeel.UseDefaultLookAndFeel = false;
		this.DGVHorarios.MainView = this.GridViewHorarios;
		this.DGVHorarios.Name = "DGVHorarios";
		DevExpress.XtraGrid.GridControl dGVHorarios2 = this.DGVHorarios;
		size = new System.Drawing.Size(562, 135);
		dGVHorarios2.Size = size;
		this.DGVHorarios.TabIndex = 1;
		this.DGVHorarios.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[1] { this.GridViewHorarios });
		this.GridViewHorarios.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[7] { this.GridColumn1, this.GridColumn6, this.GridColumn2, this.GridColumn4, this.GridColumn5, this.GridColumn3, this.GridColumn7 });
		this.GridViewHorarios.GridControl = this.DGVHorarios;
		this.GridViewHorarios.Name = "GridViewHorarios";
		this.GridViewHorarios.OptionsBehavior.Editable = false;
		this.GridViewHorarios.OptionsCustomization.AllowColumnMoving = false;
		this.GridViewHorarios.OptionsCustomization.AllowColumnResizing = false;
		this.GridViewHorarios.OptionsCustomization.AllowFilter = false;
		this.GridViewHorarios.OptionsCustomization.AllowGroup = false;
		this.GridViewHorarios.OptionsDetail.EnableMasterViewMode = false;
		this.GridViewHorarios.OptionsDetail.ShowDetailTabs = false;
		this.GridViewHorarios.OptionsDetail.SmartDetailExpand = false;
		this.GridViewHorarios.OptionsPrint.ExpandAllGroups = false;
		this.GridViewHorarios.OptionsView.ColumnAutoWidth = false;
		this.GridViewHorarios.OptionsView.ShowGroupPanel = false;
		this.GridViewHorarios.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
		this.GridColumn1.Caption = "idHorario";
		this.GridColumn1.FieldName = "idHorario";
		this.GridColumn1.Name = "GridColumn1";
		this.GridColumn6.Caption = "Descripción";
		this.GridColumn6.FieldName = "Descrip_Horario";
		this.GridColumn6.Name = "GridColumn6";
		this.GridColumn6.Visible = true;
		this.GridColumn6.VisibleIndex = 0;
		this.GridColumn6.Width = 120;
		this.GridColumn2.Caption = "Hora Entrada";
		this.GridColumn2.FieldName = "Ingreso1";
		this.GridColumn2.Name = "GridColumn2";
		this.GridColumn2.Visible = true;
		this.GridColumn2.VisibleIndex = 1;
		this.GridColumn2.Width = 90;
		this.GridColumn4.Caption = "Salida Almuerzo";
		this.GridColumn4.FieldName = "Salida1";
		this.GridColumn4.Name = "GridColumn4";
		this.GridColumn4.Visible = true;
		this.GridColumn4.VisibleIndex = 2;
		this.GridColumn4.Width = 90;
		this.GridColumn5.Caption = "Entrada Almuerzo";
		this.GridColumn5.FieldName = "Ingreso2";
		this.GridColumn5.Name = "GridColumn5";
		this.GridColumn5.Visible = true;
		this.GridColumn5.VisibleIndex = 3;
		this.GridColumn5.Width = 90;
		this.GridColumn3.Caption = "Hora Salida";
		this.GridColumn3.FieldName = "Salida2";
		this.GridColumn3.Name = "GridColumn3";
		this.GridColumn3.Visible = true;
		this.GridColumn3.VisibleIndex = 4;
		this.GridColumn3.Width = 90;
		this.GridColumn7.Caption = "Activo";
		this.GridColumn7.FieldName = "Estado";
		this.GridColumn7.Name = "GridColumn7";
		this.GridColumn7.Visible = true;
		this.GridColumn7.VisibleIndex = 5;
		this.GridColumn7.Width = 50;
		this.BtnMod.AutoSize = true;
		this.BtnMod.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.BtnMod.FlatAppearance.BorderSize = 0;
		this.BtnMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BtnMod.Image = RecursosHumanos.My.Resources.Resources.document_edit;
		System.Windows.Forms.Button btnMod = this.BtnMod;
		location = new System.Drawing.Point(569, 65);
		btnMod.Location = location;
		this.BtnMod.Name = "BtnMod";
		System.Windows.Forms.Button btnMod2 = this.BtnMod;
		size = new System.Drawing.Size(60, 39);
		btnMod2.Size = size;
		this.BtnMod.TabIndex = 2;
		this.BtnMod.Text = "Modificar";
		this.BtnMod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.BtnMod.UseVisualStyleBackColor = true;
		this.BtnAgregar.AutoSize = true;
		this.BtnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BtnAgregar.FlatAppearance.BorderSize = 0;
		this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BtnAgregar.Image = RecursosHumanos.My.Resources.Resources.add2;
		System.Windows.Forms.Button btnAgregar = this.BtnAgregar;
		location = new System.Drawing.Point(572, 23);
		btnAgregar.Location = location;
		this.BtnAgregar.Name = "BtnAgregar";
		System.Windows.Forms.Button btnAgregar2 = this.BtnAgregar;
		size = new System.Drawing.Size(54, 39);
		btnAgregar2.Size = size;
		this.BtnAgregar.TabIndex = 1;
		this.BtnAgregar.Text = "Agregar";
		this.BtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.BtnAgregar.UseVisualStyleBackColor = true;
		this.BtnEliminar.AutoSize = true;
		this.BtnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BtnEliminar.FlatAppearance.BorderSize = 0;
		this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BtnEliminar.Image = RecursosHumanos.My.Resources.Resources.delete2;
		System.Windows.Forms.Button btnEliminar = this.BtnEliminar;
		location = new System.Drawing.Point(571, 110);
		btnEliminar.Location = location;
		this.BtnEliminar.Name = "BtnEliminar";
		System.Windows.Forms.Button btnEliminar2 = this.BtnEliminar;
		size = new System.Drawing.Size(53, 39);
		btnEliminar2.Size = size;
		this.BtnEliminar.TabIndex = 3;
		this.BtnEliminar.Text = "Eliminar";
		this.BtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.BtnEliminar.UseVisualStyleBackColor = true;
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.Calculadora = false;
		size = new System.Drawing.Size(659, 260);
		this.ClientSize = size;
		this.Controls.Add(this.GroupControl12);
		this.MessageShow = true;
		this.Name = "FrmHorarios";
		this.TitleMsg = "FrmConsulta";
		this.Titulo = "Horarios";
		this.VerCmdCerrar = true;
		this.Controls.SetChildIndex(this.cmdCerrar, 0);
		this.Controls.SetChildIndex(this.PanelSup, 0);
		this.Controls.SetChildIndex(this.PanelInf, 0);
		this.Controls.SetChildIndex(this.GroupControl12, 0);
		((System.ComponentModel.ISupportInitialize)this.GroupControl12).EndInit();
		this.GroupControl12.ResumeLayout(false);
		this.GroupControl12.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.DGVHorarios).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GridViewHorarios).EndInit();
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	private void FrmHorarios_Load(object sender, EventArgs e)
	{
		LlenaHorario();
	}

	private void BtnAgregar_Click(object sender, EventArgs e)
	{
		FrmMantHorarios frmMantHorarios = new FrmMantHorarios();
		frmMantHorarios.ShowDialog();
		if (frmMantHorarios.DialogResult == DialogResult.OK)
		{
			LlenaHorario();
		}
	}

	private void LlenaHorario()
	{
		List<Horario> dataSource = HorarioMapper.Instance().SelectAll().ToList();
		DGVHorarios.DataSource = dataSource;
	}

	private void BtnMod_Click(object sender, EventArgs e)
	{
		FrmMantHorarios frmMantHorarios = new FrmMantHorarios();
		int focusedRowHandle = GridViewHorarios.FocusedRowHandle;
		frmMantHorarios.CodHorario = Conversions.ToInteger(GridViewHorarios.GetRowCellValue(focusedRowHandle, "idHorario"));
		frmMantHorarios.ShowDialog();
		if (frmMantHorarios.DialogResult == DialogResult.OK)
		{
			LlenaHorario();
		}
	}

	private void BtnEliminar_Click(object sender, EventArgs e)
	{
		int focusedRowHandle = GridViewHorarios.FocusedRowHandle;
		if (focusedRowHandle < 0)
		{
			MessageBox.Show("Primero debe Seleccionar un Registro");
		}
		else if (MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject("Desea eliminar el Horario: ", GridViewHorarios.GetRowCellValue(focusedRowHandle, "Descrip_Horario"))), "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
		{
			int count = EmpleadoMapper.Instance().SelectBy([SpecialName] (Empleado em) => Operators.ConditionalCompareObjectEqual(em.idHorario, GridViewHorarios.GetRowCellValue(focusedRowHandle, "idHorario"), TextCompare: false)).Count;
			if (count > 0)
			{
				MessageBox.Show("No se puede Eliminar el Horario, porque existen Empleados en ese Horario", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			Horario horario = new Horario();
			horario.idHorario = Conversions.ToInteger(GridViewHorarios.GetRowCellValue(focusedRowHandle, "idHorario"));
			HorarioMapper.Instance().Delete(horario);
			LlenaHorario();
		}
	}
}
