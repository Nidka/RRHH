using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ClassRRHH;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using GRLL.Common;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using RecursosHumanos.My.Resources;

namespace RecursosHumanos;

[DesignerGenerated]
public class FrmFeriado : FrmConsulta
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("UcDateTime1")]
	private ucDateTime _UcDateTime1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("BtnAgregar")]
	private Button _BtnAgregar;

	[AccessedThroughProperty("GridControlFeriado")]
	private GridControl _GridControlFeriado;

	[AccessedThroughProperty("GridView1")]
	private GridView _GridView1;

	[AccessedThroughProperty("GroupControl1")]
	private GroupControl _GroupControl1;

	[AccessedThroughProperty("btnEliminar")]
	private Button _btnEliminar;

	[AccessedThroughProperty("DefaultLookAndFeel1")]
	private DefaultLookAndFeel _DefaultLookAndFeel1;

	[AccessedThroughProperty("GroupControl2")]
	private GroupControl _GroupControl2;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("UcTxtMotivo")]
	private ucTextBox _UcTxtMotivo;

	[AccessedThroughProperty("PopupContainerControl1")]
	private PopupContainerControl _PopupContainerControl1;

	private RRHHClass objRRHHClass;

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

	internal GridControl GridControlFeriado
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridControlFeriado;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridControlFeriado = value;
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

	internal ucTextBox UcTxtMotivo
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtMotivo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtMotivo = value;
		}
	}

	internal PopupContainerControl PopupContainerControl1
	{
		[DebuggerNonUserCode]
		get
		{
			return _PopupContainerControl1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PopupContainerControl1 = value;
		}
	}

	public FrmFeriado()
	{
		base.Load += FrmFeriado_Load;
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
		this.UcDateTime1 = new GRLL.Common.ucDateTime();
		this.Label1 = new System.Windows.Forms.Label();
		this.BtnAgregar = new System.Windows.Forms.Button();
		this.GridControlFeriado = new DevExpress.XtraGrid.GridControl();
		this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.GroupControl1 = new DevExpress.XtraEditors.GroupControl();
		this.btnEliminar = new System.Windows.Forms.Button();
		this.PopupContainerControl1 = new DevExpress.XtraEditors.PopupContainerControl();
		this.DefaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
		this.GroupControl2 = new DevExpress.XtraEditors.GroupControl();
		this.UcTxtMotivo = new GRLL.Common.ucTextBox(this.components);
		this.Label2 = new System.Windows.Forms.Label();
		((System.ComponentModel.ISupportInitialize)this.GridControlFeriado).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GridView1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GroupControl1).BeginInit();
		this.GroupControl1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.PopupContainerControl1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GroupControl2).BeginInit();
		this.GroupControl2.SuspendLayout();
		this.SuspendLayout();
		this.cmdCerrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.cmdCerrar.AutoSize = true;
		this.cmdCerrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.cmdCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cmdCerrar.FlatAppearance.BorderSize = 0;
		this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.cmdCerrar.Image = RecursosHumanos.My.Resources.Resources._exit;
		System.Windows.Forms.Button button = this.cmdCerrar;
		System.Drawing.Point location = new System.Drawing.Point(337, 360);
		button.Location = location;
		System.Windows.Forms.Button button2 = this.cmdCerrar;
		System.Drawing.Size size = new System.Drawing.Size(61, 23);
		button2.Size = size;
		this.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		System.Windows.Forms.Panel panelSup = this.PanelSup;
		size = new System.Drawing.Size(410, 29);
		panelSup.Size = size;
		System.Windows.Forms.Panel panelInf = this.PanelInf;
		location = new System.Drawing.Point(0, 392);
		panelInf.Location = location;
		System.Windows.Forms.Panel panelInf2 = this.PanelInf;
		size = new System.Drawing.Size(410, 27);
		panelInf2.Size = size;
		this.UcDateTime1.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcDateTime1.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucDateTime ucDateTime = this.UcDateTime1;
		location = new System.Drawing.Point(53, 23);
		ucDateTime.Location = location;
		this.UcDateTime1.Name = "UcDateTime1";
		GRLL.Common.ucDateTime ucDateTime2 = this.UcDateTime1;
		size = new System.Drawing.Size(216, 20);
		ucDateTime2.Size = size;
		this.UcDateTime1.TabIndex = 1;
		this.Label1.AutoSize = true;
		System.Windows.Forms.Label label = this.Label1;
		location = new System.Drawing.Point(7, 27);
		label.Location = location;
		this.Label1.Name = "Label1";
		System.Windows.Forms.Label label2 = this.Label1;
		size = new System.Drawing.Size(40, 13);
		label2.Size = size;
		this.Label1.TabIndex = 4;
		this.Label1.Text = "Fecha:";
		this.BtnAgregar.AutoSize = true;
		this.BtnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BtnAgregar.FlatAppearance.BorderSize = 0;
		this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BtnAgregar.Image = RecursosHumanos.My.Resources.Resources.check2;
		System.Windows.Forms.Button btnAgregar = this.BtnAgregar;
		location = new System.Drawing.Point(311, 70);
		btnAgregar.Location = location;
		this.BtnAgregar.Name = "BtnAgregar";
		System.Windows.Forms.Button btnAgregar2 = this.BtnAgregar;
		size = new System.Drawing.Size(70, 23);
		btnAgregar2.Size = size;
		this.BtnAgregar.TabIndex = 3;
		this.BtnAgregar.Text = "Agregar";
		this.BtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.BtnAgregar.UseVisualStyleBackColor = true;
		this.GridControlFeriado.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		DevExpress.XtraGrid.GridControl gridControlFeriado = this.GridControlFeriado;
		location = new System.Drawing.Point(5, 23);
		gridControlFeriado.Location = location;
		this.GridControlFeriado.MainView = this.GridView1;
		this.GridControlFeriado.Name = "GridControlFeriado";
		DevExpress.XtraGrid.GridControl gridControlFeriado2 = this.GridControlFeriado;
		size = new System.Drawing.Size(295, 183);
		gridControlFeriado2.Size = size;
		this.GridControlFeriado.TabIndex = 1;
		this.GridControlFeriado.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[1] { this.GridView1 });
		this.GridView1.GridControl = this.GridControlFeriado;
		this.GridView1.Name = "GridView1";
		this.GridView1.OptionsBehavior.Editable = false;
		this.GridView1.OptionsCustomization.AllowColumnMoving = false;
		this.GridView1.OptionsCustomization.AllowFilter = false;
		this.GridView1.OptionsCustomization.AllowGroup = false;
		this.GridView1.OptionsFilter.AllowFilterEditor = false;
		this.GridView1.OptionsView.ShowGroupPanel = false;
		this.GroupControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.GroupControl1.Controls.Add(this.btnEliminar);
		this.GroupControl1.Controls.Add(this.GridControlFeriado);
		this.GroupControl1.Controls.Add(this.PopupContainerControl1);
		DevExpress.XtraEditors.GroupControl groupControl = this.GroupControl1;
		location = new System.Drawing.Point(12, 143);
		groupControl.Location = location;
		this.GroupControl1.Name = "GroupControl1";
		DevExpress.XtraEditors.GroupControl groupControl2 = this.GroupControl1;
		size = new System.Drawing.Size(386, 211);
		groupControl2.Size = size;
		this.GroupControl1.TabIndex = 1;
		this.GroupControl1.Text = "Detalle Feriados";
		this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.btnEliminar.AutoSize = true;
		this.btnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnEliminar.FlatAppearance.BorderSize = 0;
		this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnEliminar.Image = RecursosHumanos.My.Resources.Resources.delete2;
		System.Windows.Forms.Button button3 = this.btnEliminar;
		location = new System.Drawing.Point(311, 47);
		button3.Location = location;
		this.btnEliminar.Name = "btnEliminar";
		System.Windows.Forms.Button button4 = this.btnEliminar;
		size = new System.Drawing.Size(69, 23);
		button4.Size = size;
		this.btnEliminar.TabIndex = 2;
		this.btnEliminar.Text = "Eliminar";
		this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.btnEliminar.UseVisualStyleBackColor = true;
		DevExpress.XtraEditors.PopupContainerControl popupContainerControl = this.PopupContainerControl1;
		location = new System.Drawing.Point(129, 212);
		popupContainerControl.Location = location;
		this.PopupContainerControl1.Name = "PopupContainerControl1";
		DevExpress.XtraEditors.PopupContainerControl popupContainerControl2 = this.PopupContainerControl1;
		size = new System.Drawing.Size(200, 31);
		popupContainerControl2.Size = size;
		this.PopupContainerControl1.TabIndex = 1;
		this.DefaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins";
		this.GroupControl2.Controls.Add(this.UcTxtMotivo);
		this.GroupControl2.Controls.Add(this.UcDateTime1);
		this.GroupControl2.Controls.Add(this.BtnAgregar);
		this.GroupControl2.Controls.Add(this.Label2);
		this.GroupControl2.Controls.Add(this.Label1);
		DevExpress.XtraEditors.GroupControl groupControl3 = this.GroupControl2;
		location = new System.Drawing.Point(12, 35);
		groupControl3.Location = location;
		this.GroupControl2.Name = "GroupControl2";
		DevExpress.XtraEditors.GroupControl groupControl4 = this.GroupControl2;
		size = new System.Drawing.Size(386, 102);
		groupControl4.Size = size;
		this.GroupControl2.TabIndex = 0;
		this.GroupControl2.Text = "Datos Feriado";
		this.UcTxtMotivo.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtMotivo.Formato = null;
		this.UcTxtMotivo.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtMotivo = this.UcTxtMotivo;
		location = new System.Drawing.Point(53, 52);
		ucTxtMotivo.Location = location;
		this.UcTxtMotivo.Multiline = true;
		this.UcTxtMotivo.Name = "UcTxtMotivo";
		this.UcTxtMotivo.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtMotivo.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtMotivo.OnErrorBlankText = "";
		this.UcTxtMotivo.PadLeftLenght = 0;
		this.UcTxtMotivo.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtMotivo.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtMotivo2 = this.UcTxtMotivo;
		size = new System.Drawing.Size(252, 41);
		ucTxtMotivo2.Size = size;
		this.UcTxtMotivo.TabIndex = 2;
		this.UcTxtMotivo.TabNextControl = false;
		this.UcTxtMotivo.Tipo = GRLL.Common.ucTextBox.TipoDato.Todos;
		this.Label2.AutoSize = true;
		System.Windows.Forms.Label label3 = this.Label2;
		location = new System.Drawing.Point(5, 55);
		label3.Location = location;
		this.Label2.Name = "Label2";
		System.Windows.Forms.Label label4 = this.Label2;
		size = new System.Drawing.Size(42, 13);
		label4.Size = size;
		this.Label2.TabIndex = 4;
		this.Label2.Text = "Motivo:";
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		size = new System.Drawing.Size(410, 419);
		this.ClientSize = size;
		this.Controls.Add(this.GroupControl2);
		this.Controls.Add(this.GroupControl1);
		this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
		this.MaximizeBox = false;
		this.MessageShow = true;
		this.Name = "FrmFeriado";
		this.TitleMsg = "FrmConsulta";
		this.Titulo = "Feriados";
		this.TituloFrm = "Feriados";
		this.VerCmdCerrar = true;
		this.Controls.SetChildIndex(this.cmdCerrar, 0);
		this.Controls.SetChildIndex(this.GroupControl1, 0);
		this.Controls.SetChildIndex(this.GroupControl2, 0);
		this.Controls.SetChildIndex(this.PanelSup, 0);
		this.Controls.SetChildIndex(this.PanelInf, 0);
		((System.ComponentModel.ISupportInitialize)this.GridControlFeriado).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GridView1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GroupControl1).EndInit();
		this.GroupControl1.ResumeLayout(false);
		this.GroupControl1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.PopupContainerControl1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GroupControl2).EndInit();
		this.GroupControl2.ResumeLayout(false);
		this.GroupControl2.PerformLayout();
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	private void BtnAgregar_Click(object sender, EventArgs e)
	{
		if (objRRHHClass.GetFeriado(UcDateTime1.Value.ToShortDateString()).Rows.Count >= 1)
		{
			MessageBox.Show("Ya a Agregado esa Fecha", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		RRHH_Feriado rRHH_Feriado = new RRHH_Feriado();
		rRHH_Feriado.Fecha = UcDateTime1.Value;
		rRHH_Feriado.Motivo = UcTxtMotivo.Text.Trim();
		int idFeriado;
		if (RRHH_FeriadoMapper.Instance().SelectAll().Count == 0)
		{
			idFeriado = 1;
		}
		else
		{
			idFeriado = RRHH_FeriadoMapper.Instance().SelectAll().Max([SpecialName] (RRHH_Feriado v) => v.idFeriado);
			idFeriado = checked(idFeriado + 1);
		}
		rRHH_Feriado.idFeriado = idFeriado;
		RRHH_FeriadoMapper.Instance().Insert(rRHH_Feriado);
		llena_leriado();
		UcTxtMotivo.Text = "";
		UcDateTime1.Value = DateAndTime.Today;
	}

	private void FrmFeriado_Load(object sender, EventArgs e)
	{
		llena_leriado();
		GridView1.Columns["idFeriado"].Visible = false;
	}

	private void btnEliminar_Click(object sender, EventArgs e)
	{
		int focusedRowHandle = GridView1.FocusedRowHandle;
		if (focusedRowHandle < 0)
		{
			MessageBox.Show("Primero debe Seleccionar un Feriado No Laborable.");
		}
		else if (MessageBox.Show("Desea eliminar el Feriado con Fecha: " + Strings.FormatDateTime(Conversions.ToDate(GridView1.GetRowCellValue(focusedRowHandle, "Fecha")), DateFormat.ShortDate), "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
		{
			int idFeriado = Conversions.ToInteger(GridView1.GetRowCellValue(focusedRowHandle, "idFeriado"));
			RRHH_Feriado rRHH_Feriado = new RRHH_Feriado();
			rRHH_Feriado.idFeriado = idFeriado;
			RRHH_FeriadoMapper.Instance().Delete(rRHH_Feriado);
			llena_leriado();
		}
	}

	private void llena_leriado()
	{
		GridControlFeriado.DataSource = RRHH_FeriadoMapper.Instance().SelectAll();
	}
}
