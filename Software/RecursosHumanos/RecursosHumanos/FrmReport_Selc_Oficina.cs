using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ClassRRHH;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using GRLL.Common;
using Microsoft.VisualBasic.CompilerServices;
using RecursosHumanos.My;
using RecursosHumanos.My.Resources;

namespace RecursosHumanos;

[DesignerGenerated]
public class FrmReport_Selc_Oficina : FrmConsulta
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("TreeList1")]
	private TreeList _TreeList1;

	[AccessedThroughProperty("TreeListColumn1")]
	private TreeListColumn _TreeListColumn1;

	[AccessedThroughProperty("TreeListColumn2")]
	private TreeListColumn _TreeListColumn2;

	[AccessedThroughProperty("CheckEdit1")]
	private CheckEdit _CheckEdit1;

	[AccessedThroughProperty("BtnCerrar")]
	private Button _BtnCerrar;

	[AccessedThroughProperty("BtnGenerar")]
	private Button _BtnGenerar;

	[AccessedThroughProperty("DefaultLookAndFeel1")]
	private DefaultLookAndFeel _DefaultLookAndFeel1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("lbl_area")]
	private Label _lbl_area;

	private RRHHClass objClassRRHH;

	internal TreeList TreeList1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TreeList1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			FocusedNodeChangedEventHandler value2 = TreeList1_FocusedNodeChanged;
			if (_TreeList1 != null)
			{
				_TreeList1.FocusedNodeChanged -= value2;
			}
			_TreeList1 = value;
			if (_TreeList1 != null)
			{
				_TreeList1.FocusedNodeChanged += value2;
			}
		}
	}

	internal TreeListColumn TreeListColumn1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TreeListColumn1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TreeListColumn1 = value;
		}
	}

	internal TreeListColumn TreeListColumn2
	{
		[DebuggerNonUserCode]
		get
		{
			return _TreeListColumn2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TreeListColumn2 = value;
		}
	}

	internal CheckEdit CheckEdit1
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckEdit1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CheckEdit1 = value;
		}
	}

	internal Button BtnCerrar
	{
		[DebuggerNonUserCode]
		get
		{
			return _BtnCerrar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = BtnCerrar_Click;
			if (_BtnCerrar != null)
			{
				_BtnCerrar.Click -= value2;
			}
			_BtnCerrar = value;
			if (_BtnCerrar != null)
			{
				_BtnCerrar.Click += value2;
			}
		}
	}

	internal Button BtnGenerar
	{
		[DebuggerNonUserCode]
		get
		{
			return _BtnGenerar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = BtnGenerar_Click;
			if (_BtnGenerar != null)
			{
				_BtnGenerar.Click -= value2;
			}
			_BtnGenerar = value;
			if (_BtnGenerar != null)
			{
				_BtnGenerar.Click += value2;
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

	internal Label lbl_area
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbl_area;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbl_area = value;
		}
	}

	public FrmReport_Selc_Oficina()
	{
		base.Load += FrmReport_Selc_Oficina_Load;
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
		this.TreeList1 = new DevExpress.XtraTreeList.TreeList();
		this.TreeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
		this.TreeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
		this.CheckEdit1 = new DevExpress.XtraEditors.CheckEdit();
		this.BtnCerrar = new System.Windows.Forms.Button();
		this.BtnGenerar = new System.Windows.Forms.Button();
		this.DefaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
		this.Label1 = new System.Windows.Forms.Label();
		this.lbl_area = new System.Windows.Forms.Label();
		((System.ComponentModel.ISupportInitialize)this.TreeList1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.CheckEdit1.Properties).BeginInit();
		this.SuspendLayout();
		System.Windows.Forms.Panel panelSup = this.PanelSup;
		System.Drawing.Size size = new System.Drawing.Size(518, 29);
		panelSup.Size = size;
		System.Windows.Forms.Panel panelInf = this.PanelInf;
		System.Drawing.Point location = new System.Drawing.Point(0, 332);
		panelInf.Location = location;
		System.Windows.Forms.Panel panelInf2 = this.PanelInf;
		size = new System.Drawing.Size(518, 27);
		panelInf2.Size = size;
		this.TreeList1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.TreeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[2] { this.TreeListColumn1, this.TreeListColumn2 });
		DevExpress.XtraTreeList.TreeList treeList = this.TreeList1;
		location = new System.Drawing.Point(11, 35);
		treeList.Location = location;
		this.TreeList1.Name = "TreeList1";
		this.TreeList1.OptionsBehavior.Editable = false;
		this.TreeList1.OptionsSelection.UseIndicatorForSelection = true;
		DevExpress.XtraTreeList.TreeList treeList2 = this.TreeList1;
		size = new System.Drawing.Size(495, 200);
		treeList2.Size = size;
		this.TreeList1.TabIndex = 0;
		this.TreeListColumn1.Caption = "Area";
		this.TreeListColumn1.FieldName = "AreaOrganizacional";
		this.TreeListColumn1.Name = "TreeListColumn1";
		this.TreeListColumn1.OptionsColumn.AllowSort = false;
		this.TreeListColumn1.Visible = true;
		this.TreeListColumn1.VisibleIndex = 0;
		this.TreeListColumn2.Caption = "TreeListColumn2";
		this.TreeListColumn2.FieldName = "siglafull";
		this.TreeListColumn2.Name = "TreeListColumn2";
		this.CheckEdit1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		DevExpress.XtraEditors.CheckEdit checkEdit = this.CheckEdit1;
		location = new System.Drawing.Point(11, 264);
		checkEdit.Location = location;
		this.CheckEdit1.Name = "CheckEdit1";
		this.CheckEdit1.Properties.Caption = "Incluir Dependencias";
		DevExpress.XtraEditors.CheckEdit checkEdit2 = this.CheckEdit1;
		size = new System.Drawing.Size(134, 18);
		checkEdit2.Size = size;
		this.CheckEdit1.TabIndex = 1;
		this.BtnCerrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.BtnCerrar.AutoSize = true;
		this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BtnCerrar.FlatAppearance.BorderSize = 0;
		this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BtnCerrar.Image = RecursosHumanos.My.Resources.Resources._exit;
		System.Windows.Forms.Button btnCerrar = this.BtnCerrar;
		location = new System.Drawing.Point(430, 296);
		btnCerrar.Location = location;
		this.BtnCerrar.Name = "BtnCerrar";
		System.Windows.Forms.Button btnCerrar2 = this.BtnCerrar;
		size = new System.Drawing.Size(75, 30);
		btnCerrar2.Size = size;
		this.BtnCerrar.TabIndex = 19;
		this.BtnCerrar.Text = "Cerrar";
		this.BtnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.BtnCerrar.UseVisualStyleBackColor = true;
		this.BtnGenerar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.BtnGenerar.AutoSize = true;
		this.BtnGenerar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BtnGenerar.FlatAppearance.BorderSize = 0;
		this.BtnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BtnGenerar.Image = RecursosHumanos.My.Resources.Resources.document_out;
		System.Windows.Forms.Button btnGenerar = this.BtnGenerar;
		location = new System.Drawing.Point(430, 264);
		btnGenerar.Location = location;
		this.BtnGenerar.Name = "BtnGenerar";
		System.Windows.Forms.Button btnGenerar2 = this.BtnGenerar;
		size = new System.Drawing.Size(75, 23);
		btnGenerar2.Size = size;
		this.BtnGenerar.TabIndex = 18;
		this.BtnGenerar.Text = "Generar";
		this.BtnGenerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.BtnGenerar.UseVisualStyleBackColor = true;
		this.DefaultLookAndFeel1.LookAndFeel.SkinName = "Blue";
		this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.Label1.AutoSize = true;
		System.Windows.Forms.Label label = this.Label1;
		location = new System.Drawing.Point(8, 243);
		label.Location = location;
		this.Label1.Name = "Label1";
		System.Windows.Forms.Label label2 = this.Label1;
		size = new System.Drawing.Size(86, 13);
		label2.Size = size;
		this.Label1.TabIndex = 20;
		this.Label1.Text = "PERSONAL DE:";
		this.lbl_area.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.lbl_area.AutoSize = true;
		System.Windows.Forms.Label label3 = this.lbl_area;
		location = new System.Drawing.Point(100, 243);
		label3.Location = location;
		this.lbl_area.Name = "lbl_area";
		System.Windows.Forms.Label label4 = this.lbl_area;
		size = new System.Drawing.Size(14, 13);
		label4.Size = size;
		this.lbl_area.TabIndex = 21;
		this.lbl_area.Text = "X";
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.Calculadora = false;
		size = new System.Drawing.Size(518, 359);
		this.ClientSize = size;
		this.Controls.Add(this.TreeList1);
		this.Controls.Add(this.CheckEdit1);
		this.Controls.Add(this.BtnGenerar);
		this.Controls.Add(this.lbl_area);
		this.Controls.Add(this.Label1);
		this.Controls.Add(this.BtnCerrar);
		this.MessageShow = true;
		this.Name = "FrmReport_Selc_Oficina";
		this.TitleMsg = "FrmConsulta";
		this.Titulo = "Selección Oficina";
		this.Controls.SetChildIndex(this.BtnCerrar, 0);
		this.Controls.SetChildIndex(this.Label1, 0);
		this.Controls.SetChildIndex(this.lbl_area, 0);
		this.Controls.SetChildIndex(this.BtnGenerar, 0);
		this.Controls.SetChildIndex(this.CheckEdit1, 0);
		this.Controls.SetChildIndex(this.TreeList1, 0);
		this.Controls.SetChildIndex(this.PanelSup, 0);
		this.Controls.SetChildIndex(this.PanelInf, 0);
		this.Controls.SetChildIndex(this.cmdCerrar, 0);
		((System.ComponentModel.ISupportInitialize)this.TreeList1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.CheckEdit1.Properties).EndInit();
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	private void FrmReport_Selc_Oficina_Load(object sender, EventArgs e)
	{
		StartPosition = FormStartPosition.CenterParent;
		TreeList1.DataSource = RuntimeHelpers.GetObjectValue(objClassRRHH.llena_tree_reporte());
		TreeList1.ParentFieldName = "Hijo";
		TreeList1.KeyFieldName = "Padre";
	}

	private void BtnGenerar_Click(object sender, EventArgs e)
	{
		string text;
		int opcion;
		if (CheckEdit1.Checked)
		{
			text = Conversions.ToString(TreeList1.FocusedNode.GetValue("siglafull"));
			opcion = 1;
		}
		else
		{
			text = Conversions.ToString(TreeList1.FocusedNode.GetValue("Padre"));
			opcion = 2;
			List<Empleado> list = EmpleadoMapper.Instance().SelectBy([SpecialName] (Empleado v) => (double)v.idAreaOrganiz == Conversions.ToDouble(text));
			if (list.Count <= 0)
			{
				MessageBox.Show("No existen Trabajadores Registrados para esta Area", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
		}
		if (Operators.CompareString(text, "0", TextCompare: false) == 0 || text == null)
		{
			MessageBox.Show("Debe seleccionar una Oficina por lo menos", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		FrmReport_Selec_Oficina frmReport_Selec_Oficina = new FrmReport_Selec_Oficina();
		frmReport_Selec_Oficina.opcion = opcion;
		frmReport_Selec_Oficina.Var = text;
		frmReport_Selec_Oficina.WindowState = FormWindowState.Maximized;
		frmReport_Selec_Oficina.MdiParent = MyProject.Forms.MainMDI;
		frmReport_Selec_Oficina.Show();
		Close();
	}

	private void BtnCerrar_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void TreeList1_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
	{
		lbl_area.Text = TreeList1.FocusedNode.GetValue("AreaOrganizacional").ToString();
	}
}
