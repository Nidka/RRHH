using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ClassRRHH;
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
public class FrmBuscarDerechohabiente : FrmConsulta
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("GroupControl1")]
	private GroupControl _GroupControl1;

	[AccessedThroughProperty("btnSeleccionar")]
	private Button _btnSeleccionar;

	[AccessedThroughProperty("GCBusqeda")]
	private GridControl _GCBusqeda;

	[AccessedThroughProperty("GVBusqeda")]
	private GridView _GVBusqeda;

	[AccessedThroughProperty("btnBuscar")]
	private Button _btnBuscar;

	[AccessedThroughProperty("UcTxtApellido")]
	private ucTextBox _UcTxtApellido;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("GridColumn1")]
	private GridColumn _GridColumn1;

	[AccessedThroughProperty("GridColumn2")]
	private GridColumn _GridColumn2;

	[AccessedThroughProperty("GridColumn3")]
	private GridColumn _GridColumn3;

	[AccessedThroughProperty("GridColumn4")]
	private GridColumn _GridColumn4;

	public Persona oPersona;

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

	internal Button btnSeleccionar
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnSeleccionar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_btnSeleccionar = value;
		}
	}

	internal GridControl GCBusqeda
	{
		[DebuggerNonUserCode]
		get
		{
			return _GCBusqeda;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GCBusqeda = value;
		}
	}

	internal GridView GVBusqeda
	{
		[DebuggerNonUserCode]
		get
		{
			return _GVBusqeda;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = GVBusqeda_DoubleClick;
			if (_GVBusqeda != null)
			{
				_GVBusqeda.DoubleClick -= value2;
			}
			_GVBusqeda = value;
			if (_GVBusqeda != null)
			{
				_GVBusqeda.DoubleClick += value2;
			}
		}
	}

	internal Button btnBuscar
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnBuscar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = btnBuscar_Click;
			if (_btnBuscar != null)
			{
				_btnBuscar.Click -= value2;
			}
			_btnBuscar = value;
			if (_btnBuscar != null)
			{
				_btnBuscar.Click += value2;
			}
		}
	}

	internal ucTextBox UcTxtApellido
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtApellido;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtApellido = value;
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

	public FrmBuscarDerechohabiente()
	{
		base.Load += FrmBuscarDerechohabiente_Load;
		__ENCAddToList(this);
		oPersona = new Persona();
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
		this.GroupControl1 = new DevExpress.XtraEditors.GroupControl();
		this.GCBusqeda = new DevExpress.XtraGrid.GridControl();
		this.GVBusqeda = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.GridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.btnBuscar = new System.Windows.Forms.Button();
		this.UcTxtApellido = new GRLL.Common.ucTextBox(this.components);
		this.Label1 = new System.Windows.Forms.Label();
		this.btnSeleccionar = new System.Windows.Forms.Button();
		((System.ComponentModel.ISupportInitialize)this.GroupControl1).BeginInit();
		this.GroupControl1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.GCBusqeda).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GVBusqeda).BeginInit();
		this.SuspendLayout();
		this.cmdCerrar.AutoSize = true;
		this.cmdCerrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.cmdCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cmdCerrar.FlatAppearance.BorderSize = 0;
		this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.cmdCerrar.Image = RecursosHumanos.My.Resources.Resources._exit;
		System.Windows.Forms.Button button = this.cmdCerrar;
		System.Drawing.Point location = new System.Drawing.Point(569, 309);
		button.Location = location;
		System.Windows.Forms.Button button2 = this.cmdCerrar;
		System.Drawing.Size size = new System.Drawing.Size(61, 23);
		button2.Size = size;
		this.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		System.Windows.Forms.Panel panelInf = this.PanelInf;
		location = new System.Drawing.Point(0, 339);
		panelInf.Location = location;
		this.GroupControl1.Controls.Add(this.GCBusqeda);
		this.GroupControl1.Controls.Add(this.btnBuscar);
		this.GroupControl1.Controls.Add(this.UcTxtApellido);
		this.GroupControl1.Controls.Add(this.Label1);
		DevExpress.XtraEditors.GroupControl groupControl = this.GroupControl1;
		location = new System.Drawing.Point(3, 35);
		groupControl.Location = location;
		this.GroupControl1.Name = "GroupControl1";
		DevExpress.XtraEditors.GroupControl groupControl2 = this.GroupControl1;
		size = new System.Drawing.Size(633, 255);
		groupControl2.Size = size;
		this.GroupControl1.TabIndex = 8;
		this.GroupControl1.Text = "Busqueda de DerechoHabiente";
		DevExpress.XtraGrid.GridControl gCBusqeda = this.GCBusqeda;
		location = new System.Drawing.Point(9, 59);
		gCBusqeda.Location = location;
		this.GCBusqeda.MainView = this.GVBusqeda;
		this.GCBusqeda.Name = "GCBusqeda";
		DevExpress.XtraGrid.GridControl gCBusqeda2 = this.GCBusqeda;
		size = new System.Drawing.Size(619, 191);
		gCBusqeda2.Size = size;
		this.GCBusqeda.TabIndex = 3;
		this.GCBusqeda.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[1] { this.GVBusqeda });
		this.GVBusqeda.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[4] { this.GridColumn1, this.GridColumn2, this.GridColumn3, this.GridColumn4 });
		this.GVBusqeda.GridControl = this.GCBusqeda;
		this.GVBusqeda.Name = "GVBusqeda";
		this.GVBusqeda.OptionsBehavior.Editable = false;
		this.GVBusqeda.OptionsView.ShowGroupPanel = false;
		this.GridColumn1.Caption = "IdPersona";
		this.GridColumn1.FieldName = "IdPersona";
		this.GridColumn1.Name = "GridColumn1";
		this.GridColumn2.Caption = "Apellido Paterno";
		this.GridColumn2.FieldName = "Apellido_Paterno";
		this.GridColumn2.Name = "GridColumn2";
		this.GridColumn2.Visible = true;
		this.GridColumn2.VisibleIndex = 0;
		this.GridColumn3.Caption = "Apellido Materno";
		this.GridColumn3.FieldName = "Apellido_Materno";
		this.GridColumn3.Name = "GridColumn3";
		this.GridColumn3.Visible = true;
		this.GridColumn3.VisibleIndex = 1;
		this.GridColumn4.Caption = "Nombres";
		this.GridColumn4.FieldName = "Nombres";
		this.GridColumn4.Name = "GridColumn4";
		this.GridColumn4.Visible = true;
		this.GridColumn4.VisibleIndex = 2;
		this.btnBuscar.AutoSize = true;
		this.btnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnBuscar.FlatAppearance.BorderSize = 0;
		this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnBuscar.Image = RecursosHumanos.My.Resources.Resources.view1;
		System.Windows.Forms.Button button3 = this.btnBuscar;
		location = new System.Drawing.Point(387, 30);
		button3.Location = location;
		this.btnBuscar.Name = "btnBuscar";
		System.Windows.Forms.Button button4 = this.btnBuscar;
		size = new System.Drawing.Size(66, 23);
		button4.Size = size;
		this.btnBuscar.TabIndex = 2;
		this.btnBuscar.Text = "Buscar";
		this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.btnBuscar.UseVisualStyleBackColor = true;
		this.UcTxtApellido.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtApellido.Formato = null;
		this.UcTxtApellido.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtApellido = this.UcTxtApellido;
		location = new System.Drawing.Point(102, 32);
		ucTxtApellido.Location = location;
		this.UcTxtApellido.Name = "UcTxtApellido";
		this.UcTxtApellido.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtApellido.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtApellido.OnErrorBlankText = "";
		this.UcTxtApellido.PadLeftLenght = 0;
		this.UcTxtApellido.RegularExpression = "^[A-Z,a-z,\\s]+$";
		this.UcTxtApellido.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtApellido.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtApellido2 = this.UcTxtApellido;
		size = new System.Drawing.Size(279, 20);
		ucTxtApellido2.Size = size;
		this.UcTxtApellido.TabIndex = 1;
		this.UcTxtApellido.TabNextControl = false;
		this.UcTxtApellido.Tipo = GRLL.Common.ucTextBox.TipoDato.SoloLetras;
		this.Label1.AutoSize = true;
		System.Windows.Forms.Label label = this.Label1;
		location = new System.Drawing.Point(9, 35);
		label.Location = location;
		this.Label1.Name = "Label1";
		System.Windows.Forms.Label label2 = this.Label1;
		size = new System.Drawing.Size(87, 13);
		label2.Size = size;
		this.Label1.TabIndex = 0;
		this.Label1.Text = "Apellido Paterno:";
		this.btnSeleccionar.AutoSize = true;
		this.btnSeleccionar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.btnSeleccionar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnSeleccionar.FlatAppearance.BorderSize = 0;
		this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSeleccionar.Image = RecursosHumanos.My.Resources.Resources.check2;
		System.Windows.Forms.Button button5 = this.btnSeleccionar;
		location = new System.Drawing.Point(12, 310);
		button5.Location = location;
		this.btnSeleccionar.Name = "btnSeleccionar";
		System.Windows.Forms.Button button6 = this.btnSeleccionar;
		size = new System.Drawing.Size(89, 23);
		button6.Size = size;
		this.btnSeleccionar.TabIndex = 4;
		this.btnSeleccionar.Text = "Seleccionar";
		this.btnSeleccionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.btnSeleccionar.UseVisualStyleBackColor = true;
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		size = new System.Drawing.Size(644, 366);
		this.ClientSize = size;
		this.Controls.Add(this.btnSeleccionar);
		this.Controls.Add(this.GroupControl1);
		this.MessageShow = true;
		this.Name = "FrmBuscarDerechohabiente";
		this.TitleMsg = "FrmConsulta";
		this.Titulo = "Busqueda de DerechoHabiente";
		this.VerCmdCerrar = true;
		this.Controls.SetChildIndex(this.PanelSup, 0);
		this.Controls.SetChildIndex(this.PanelInf, 0);
		this.Controls.SetChildIndex(this.cmdCerrar, 0);
		this.Controls.SetChildIndex(this.GroupControl1, 0);
		this.Controls.SetChildIndex(this.btnSeleccionar, 0);
		((System.ComponentModel.ISupportInitialize)this.GroupControl1).EndInit();
		this.GroupControl1.ResumeLayout(false);
		this.GroupControl1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.GCBusqeda).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GVBusqeda).EndInit();
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	private void FrmBuscarDerechohabiente_Load(object sender, EventArgs e)
	{
	}

	private void btnBuscar_Click(object sender, EventArgs e)
	{
		RRHHClass rRHHClass = new RRHHClass();
		GCBusqeda.DataSource = RuntimeHelpers.GetObjectValue(rRHHClass.BuscarPersonas(UcTxtApellido.Text.Trim()));
	}

	private void GVBusqeda_DoubleClick(object sender, EventArgs e)
	{
		oPersona.IdPersona = Conversions.ToInteger(GVBusqeda.GetRowCellValue(GVBusqeda.FocusedRowHandle, "IdPersona"));
		DialogResult = DialogResult.OK;
	}
}
