using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ClassRRHH;
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

namespace RecursosHumanos;

[DesignerGenerated]
public class FrmReporteEstadistico : FrmConsulta
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("GroupControl1")]
	private GroupControl _GroupControl1;

	[AccessedThroughProperty("ChckListLocal")]
	private CheckedListBoxControl _ChckListLocal;

	[AccessedThroughProperty("UcCBPartidaPresupuestal")]
	private ucComboBox _UcCBPartidaPresupuestal;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("BtnGenerar")]
	private Button _BtnGenerar;

	[AccessedThroughProperty("UcFechas1")]
	private ucFechas _UcFechas1;

	[AccessedThroughProperty("ChckListUO")]
	private CheckedListBoxControl _ChckListUO;

	[AccessedThroughProperty("DefaultLookAndFeel1")]
	private DefaultLookAndFeel _DefaultLookAndFeel1;

	[AccessedThroughProperty("GridControl3")]
	private GridControl _GridControl3;

	[AccessedThroughProperty("GridView3")]
	private GridView _GridView3;

	[AccessedThroughProperty("GridControl1")]
	private GridControl _GridControl1;

	[AccessedThroughProperty("GridView1")]
	private GridView _GridView1;

	[AccessedThroughProperty("GridColumn1")]
	private GridColumn _GridColumn1;

	private RRHHClass oRRHHClass;

	private string fi;

	private string ff;

	private int TipoTrabjador;

	private object m_Excel;

	private object objLibroExcel;

	private object objHojaExcel;

	private List<Motivo_Perm> listaPermiso;

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
			if (_ChckListLocal != null)
			{
				_ChckListLocal.ItemCheck -= value2;
			}
			_ChckListLocal = value;
			if (_ChckListLocal != null)
			{
				_ChckListLocal.ItemCheck += value2;
			}
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
			EventHandler value2 = UcCBPartidaPresupuestal_SelectedIndexChanged;
			if (_UcCBPartidaPresupuestal != null)
			{
				_UcCBPartidaPresupuestal.SelectedIndexChanged -= value2;
			}
			_UcCBPartidaPresupuestal = value;
			if (_UcCBPartidaPresupuestal != null)
			{
				_UcCBPartidaPresupuestal.SelectedIndexChanged += value2;
			}
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

	internal CheckedListBoxControl ChckListUO
	{
		[DebuggerNonUserCode]
		get
		{
			return _ChckListUO;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			DevExpress.XtraEditors.Controls.ItemCheckEventHandler value2 = ChckListUO_ItemCheck;
			if (_ChckListUO != null)
			{
				_ChckListUO.ItemCheck -= value2;
			}
			_ChckListUO = value;
			if (_ChckListUO != null)
			{
				_ChckListUO.ItemCheck += value2;
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

	internal GridControl GridControl3
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridControl3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridControl3 = value;
		}
	}

	internal GridView GridView3
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridView3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridView3 = value;
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

	public FrmReporteEstadistico()
	{
		base.Load += FrmReporteEstadistico_Load;
		__ENCAddToList(this);
		oRRHHClass = new RRHHClass();
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
		this.ChckListUO = new DevExpress.XtraEditors.CheckedListBoxControl();
		this.ChckListLocal = new DevExpress.XtraEditors.CheckedListBoxControl();
		this.UcCBPartidaPresupuestal = new GRLL.Common.ucComboBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.BtnGenerar = new System.Windows.Forms.Button();
		this.UcFechas1 = new GRLL.Common.ucFechas();
		this.GridControl3 = new DevExpress.XtraGrid.GridControl();
		this.GridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.DefaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
		this.GridControl1 = new DevExpress.XtraGrid.GridControl();
		this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.GridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
		((System.ComponentModel.ISupportInitialize)this.GroupControl1).BeginInit();
		this.GroupControl1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.ChckListUO).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ChckListLocal).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GridControl3).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GridView3).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GridControl1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GridView1).BeginInit();
		this.SuspendLayout();
		System.Windows.Forms.Panel panelSup = this.PanelSup;
		System.Drawing.Size size = new System.Drawing.Size(1095, 29);
		panelSup.Size = size;
		System.Windows.Forms.Panel panelInf = this.PanelInf;
		System.Drawing.Point location = new System.Drawing.Point(0, 556);
		panelInf.Location = location;
		System.Windows.Forms.Panel panelInf2 = this.PanelInf;
		size = new System.Drawing.Size(1095, 27);
		panelInf2.Size = size;
		this.GroupControl1.AutoSize = true;
		this.GroupControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.GroupControl1.Controls.Add(this.GridControl1);
		this.GroupControl1.Controls.Add(this.ChckListUO);
		this.GroupControl1.Controls.Add(this.ChckListLocal);
		this.GroupControl1.Controls.Add(this.UcCBPartidaPresupuestal);
		this.GroupControl1.Controls.Add(this.Label1);
		this.GroupControl1.Controls.Add(this.BtnGenerar);
		this.GroupControl1.Controls.Add(this.UcFechas1);
		this.GroupControl1.Controls.Add(this.GridControl3);
		this.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
		DevExpress.XtraEditors.GroupControl groupControl = this.GroupControl1;
		location = new System.Drawing.Point(0, 29);
		groupControl.Location = location;
		this.GroupControl1.Name = "GroupControl1";
		DevExpress.XtraEditors.GroupControl groupControl2 = this.GroupControl1;
		size = new System.Drawing.Size(1095, 527);
		groupControl2.Size = size;
		this.GroupControl1.TabIndex = 3;
		this.GroupControl1.Text = "Parámetros";
		this.ChckListUO.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		DevExpress.XtraEditors.CheckedListBoxControl chckListUO = this.ChckListUO;
		location = new System.Drawing.Point(320, 96);
		chckListUO.Location = location;
		this.ChckListUO.MultiColumn = true;
		this.ChckListUO.Name = "ChckListUO";
		DevExpress.XtraEditors.CheckedListBoxControl chckListUO2 = this.ChckListUO;
		size = new System.Drawing.Size(674, 414);
		chckListUO2.Size = size;
		this.ChckListUO.TabIndex = 16;
		this.ChckListLocal.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		DevExpress.XtraEditors.CheckedListBoxControl chckListLocal = this.ChckListLocal;
		location = new System.Drawing.Point(16, 96);
		chckListLocal.Location = location;
		this.ChckListLocal.MultiColumn = true;
		this.ChckListLocal.Name = "ChckListLocal";
		DevExpress.XtraEditors.CheckedListBoxControl chckListLocal2 = this.ChckListLocal;
		size = new System.Drawing.Size(298, 414);
		chckListLocal2.Size = size;
		this.ChckListLocal.TabIndex = 16;
		this.UcCBPartidaPresupuestal.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCBPartidaPresupuestal.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCBPartidaPresupuestal.FormattingEnabled = true;
		this.UcCBPartidaPresupuestal.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucCBPartidaPresupuestal = this.UcCBPartidaPresupuestal;
		location = new System.Drawing.Point(56, 35);
		ucCBPartidaPresupuestal.Location = location;
		this.UcCBPartidaPresupuestal.Name = "UcCBPartidaPresupuestal";
		GRLL.Common.ucComboBox ucCBPartidaPresupuestal2 = this.UcCBPartidaPresupuestal;
		size = new System.Drawing.Size(150, 21);
		ucCBPartidaPresupuestal2.Size = size;
		this.UcCBPartidaPresupuestal.TabIndex = 1;
		this.Label1.AutoSize = true;
		System.Windows.Forms.Label label = this.Label1;
		location = new System.Drawing.Point(19, 38);
		label.Location = location;
		this.Label1.Name = "Label1";
		System.Windows.Forms.Label label2 = this.Label1;
		size = new System.Drawing.Size(31, 13);
		label2.Size = size;
		this.Label1.TabIndex = 8;
		this.Label1.Text = "Tipo:";
		this.BtnGenerar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.BtnGenerar.AutoSize = true;
		this.BtnGenerar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.BtnGenerar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BtnGenerar.FlatAppearance.BorderSize = 0;
		this.BtnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BtnGenerar.Image = RecursosHumanos.My.Resources.Resources.document_out;
		System.Windows.Forms.Button btnGenerar = this.BtnGenerar;
		location = new System.Drawing.Point(1000, 487);
		btnGenerar.Location = location;
		this.BtnGenerar.Name = "BtnGenerar";
		System.Windows.Forms.Button btnGenerar2 = this.BtnGenerar;
		size = new System.Drawing.Size(71, 23);
		btnGenerar2.Size = size;
		this.BtnGenerar.TabIndex = 3;
		this.BtnGenerar.Text = "Generar";
		this.BtnGenerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.BtnGenerar.UseVisualStyleBackColor = true;
		GRLL.Common.ucFechas ucFechas = this.UcFechas1;
		location = new System.Drawing.Point(12, 68);
		ucFechas.Location = location;
		this.UcFechas1.Name = "UcFechas1";
		GRLL.Common.ucFechas ucFechas2 = this.UcFechas1;
		size = new System.Drawing.Size(302, 22);
		ucFechas2.Size = size;
		this.UcFechas1.TabIndex = 2;
		DevExpress.XtraGrid.GridControl gridControl = this.GridControl3;
		location = new System.Drawing.Point(896, 23);
		gridControl.Location = location;
		this.GridControl3.MainView = this.GridView3;
		this.GridControl3.Name = "GridControl3";
		DevExpress.XtraGrid.GridControl gridControl2 = this.GridControl3;
		size = new System.Drawing.Size(187, 178);
		gridControl2.Size = size;
		this.GridControl3.TabIndex = 17;
		this.GridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[1] { this.GridView3 });
		this.GridControl3.Visible = false;
		this.GridView3.GridControl = this.GridControl3;
		this.GridView3.Name = "GridView3";
		this.GridView3.OptionsCustomization.AllowGroup = false;
		this.GridView3.OptionsView.ShowGroupPanel = false;
		this.DefaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins";
		DevExpress.XtraGrid.GridControl gridControl3 = this.GridControl1;
		location = new System.Drawing.Point(493, 35);
		gridControl3.Location = location;
		this.GridControl1.MainView = this.GridView1;
		this.GridControl1.Name = "GridControl1";
		DevExpress.XtraGrid.GridControl gridControl4 = this.GridControl1;
		size = new System.Drawing.Size(187, 178);
		gridControl4.Size = size;
		this.GridControl1.TabIndex = 18;
		this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[1] { this.GridView1 });
		this.GridControl1.Visible = false;
		this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[1] { this.GridColumn1 });
		this.GridView1.GridControl = this.GridControl1;
		this.GridView1.Name = "GridView1";
		this.GridView1.OptionsCustomization.AllowGroup = false;
		this.GridView1.OptionsView.ShowGroupPanel = false;
		this.GridColumn1.Caption = "GridColumn1";
		this.GridColumn1.Name = "GridColumn1";
		this.GridColumn1.Visible = true;
		this.GridColumn1.VisibleIndex = 0;
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		size = new System.Drawing.Size(1095, 583);
		this.ClientSize = size;
		this.Controls.Add(this.GroupControl1);
		this.MessageShow = true;
		this.Name = "FrmReporteEstadistico";
		this.TitleMsg = "FrmConsulta";
		this.Titulo = "Reporte Estadistico Permisos";
		this.TituloFrm = "Reporte Estadistico Permisos";
		this.Controls.SetChildIndex(this.PanelSup, 0);
		this.Controls.SetChildIndex(this.PanelInf, 0);
		this.Controls.SetChildIndex(this.cmdCerrar, 0);
		this.Controls.SetChildIndex(this.GroupControl1, 0);
		((System.ComponentModel.ISupportInitialize)this.GroupControl1).EndInit();
		this.GroupControl1.ResumeLayout(false);
		this.GroupControl1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.ChckListUO).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ChckListLocal).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GridControl3).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GridView3).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GridControl1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GridView1).EndInit();
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	private void FrmReporteEstadistico_Load(object sender, EventArgs e)
	{
		UcCBPartidaPresupuestal.ValueMember = "IdTipoTrabajador";
		UcCBPartidaPresupuestal.DisplayMember = "Descripcion";
		List<TipoTrabajador> list = TipoTrabajadorMapper.Instance().SelectAll();
		list.Insert(0, new TipoTrabajador
		{
			IdTipoTrabajador = 0,
			Descripcion = "--SELECCIONAR--"
		});
		UcCBPartidaPresupuestal.DataSource = list;
		listaPermiso = Motivo_PermMapper.Instance().SelectBy([SpecialName] (Motivo_Perm V) => Operators.CompareString(Conversions.ToString((char)V.TipoModalidad), "P", TextCompare: false) == 0);
		listaPermiso.Insert(0, new Motivo_Perm
		{
			idMotivo = 0,
			Descrip_Motivo = "TODOS"
		});
		ChckListLocal.ValueMember = "idMotivo";
		ChckListLocal.DisplayMember = "Descrip_Motivo";
		ChckListLocal.DataSource = listaPermiso;
		List<EstructOrganiz> list2 = EstructOrganizMapper.Instance().SelectBy([SpecialName] (EstructOrganiz V) => V.Year == DateAndTime.Today.Year);
		list2.Insert(0, new EstructOrganiz
		{
			idAreaOrganiz = 0,
			AreaOrganizacional = "TODOS"
		});
		ChckListUO.ValueMember = "idAreaOrganiz";
		ChckListUO.DisplayMember = "AreaOrganizacional";
		ChckListUO.DataSource = list2;
		if (Conversions.ToDouble(RRHH.IdROl) == 10.0)
		{
			UcCBPartidaPresupuestal.SelectedValue = 1;
			UcCBPartidaPresupuestal.Enabled = false;
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 14.0)
		{
			UcCBPartidaPresupuestal.SelectedValue = 2;
			UcCBPartidaPresupuestal.Enabled = false;
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 13.0)
		{
			UcCBPartidaPresupuestal.Enabled = true;
		}
	}

	private void llenarPermisos(string Tipo)
	{
		listaPermiso = Motivo_PermMapper.Instance().SelectBy([SpecialName] (Motivo_Perm V) => Operators.CompareString(Conversions.ToString((char)V.TipoModalidad), Tipo, TextCompare: false) == 0);
		listaPermiso.Insert(0, new Motivo_Perm
		{
			idMotivo = 0,
			Descrip_Motivo = "TODOS"
		});
		ChckListLocal.ValueMember = "idMotivo";
		ChckListLocal.DisplayMember = "Descrip_Motivo";
		ChckListLocal.DataSource = listaPermiso;
	}

	private void UcCBPartidaPresupuestal_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(UcCBPartidaPresupuestal.SelectedValue, 1, TextCompare: false))
		{
			TipoTrabjador = Conversions.ToInteger(UcCBPartidaPresupuestal.SelectedValue);
			llenarPermisos("P");
		}
		else if (Operators.ConditionalCompareObjectEqual(UcCBPartidaPresupuestal.SelectedValue, 2, TextCompare: false))
		{
			TipoTrabjador = Conversions.ToInteger(UcCBPartidaPresupuestal.SelectedValue);
			llenarPermisos("C");
		}
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

	private void ChckListUO_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
	{
		if (e.Index != 0)
		{
			return;
		}
		checked
		{
			if (ChckListUO.GetItemCheckState(0) == CheckState.Checked)
			{
				int num = ChckListUO.ItemCount - 1;
				int num2 = 1;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 <= num4)
					{
						ChckListUO.SetItemChecked(num2, value: true);
						num2++;
						continue;
					}
					break;
				}
			}
			else
			{
				if (ChckListUO.GetItemCheckState(0) != 0)
				{
					return;
				}
				int num5 = ChckListUO.ItemCount - 1;
				int num6 = 1;
				while (true)
				{
					int num7 = num6;
					int num4 = num5;
					if (num7 <= num4)
					{
						ChckListUO.SetItemChecked(num6, value: false);
						num6++;
						continue;
					}
					break;
				}
			}
		}
	}

	private void GroupControl1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void BtnGenerar_Click(object sender, EventArgs e)
	{
		string text = "";
		string text2 = "[";
		string text3 = "isnull([";
		List<int> list = new List<int>();
		checked
		{
			int num = ChckListLocal.ItemCount - 1;
			int num2 = 1;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				if (ChckListLocal.GetItemCheckState(num2) == CheckState.Checked)
				{
					text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(ChckListLocal.GetItemValue(num2), ",")));
					list.Add(Conversions.ToInteger(ChckListLocal.GetItemValue(num2)));
					int num5 = listaPermiso.Count - 1;
					int num6 = 0;
					while (true)
					{
						int num7 = num6;
						num4 = num5;
						if (num7 > num4)
						{
							break;
						}
						if (ChckListLocal.GetItemValue(num2).Equals(listaPermiso[num6].idMotivo))
						{
							text2 = text2 + listaPermiso[num6].Abrev.Trim() + "] , [";
							text3 = text3 + listaPermiso[num6].Abrev.Trim() + "],0) , isnull([";
						}
						num6++;
					}
				}
				num2++;
			}
			if (text.Length > 0)
			{
				text = text.Substring(0, text.Length - 1);
				text2 = text2.Substring(0, text2.Length - 3);
				text3 = text3.Substring(0, text3.Length - 10);
				string text4 = "";
				int num8 = ChckListUO.ItemCount - 1;
				int num9 = 1;
				while (true)
				{
					int num10 = num9;
					int num4 = num8;
					if (num10 > num4)
					{
						break;
					}
					if (ChckListUO.GetItemCheckState(num9) == CheckState.Checked)
					{
						text4 = Conversions.ToString(Operators.AddObject(text4, Operators.ConcatenateObject(ChckListUO.GetItemValue(num9), ",")));
					}
					num9++;
				}
				if (text4.Length > 0)
				{
					text4 = text4.Substring(0, text4.Length - 1);
					if (DateTime.Compare(UcFechas1.Rango.Desde, UcFechas1.Rango.Hasta) > 0)
					{
						MessageBox.Show("La Fecha de Inicio no puede ser Mayor a la de Término", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						return;
					}
					fi = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(UcFechas1.Rango.Desde.Year.ToString(), Interaction.IIf(UcFechas1.Rango.Desde.Month.ToString().Length == 1, "0" + UcFechas1.Rango.Desde.Month, UcFechas1.Rango.Desde.Month.ToString())), Interaction.IIf(UcFechas1.Rango.Desde.Day.ToString().Length == 1, "0" + UcFechas1.Rango.Desde.Day, UcFechas1.Rango.Desde.Day.ToString())));
					ff = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(UcFechas1.Rango.Hasta.Year.ToString(), Interaction.IIf(UcFechas1.Rango.Hasta.Month.ToString().Length == 1, "0" + UcFechas1.Rango.Hasta.Month, UcFechas1.Rango.Hasta.Month.ToString())), Interaction.IIf(UcFechas1.Rango.Hasta.Day.ToString().Length == 1, "0" + UcFechas1.Rango.Hasta.Day, UcFechas1.Rango.Hasta.Day.ToString())));
					Cursor = Cursors.WaitCursor;
					string text5 = "";
					object obj = null;
					try
					{
						text5 = "RPP" + Strings.Format(DateAndTime.Now, "ddMMyy") + Conversions.ToString(DateAndTime.Now.Hour) + Conversions.ToString(DateAndTime.Now.Minute) + Conversions.ToString(DateAndTime.Now.Second) + Conversions.ToString(DateAndTime.Now.Millisecond) + ".xls";
						text5 = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache) + "\\" + text5;
						FileStream fileStream = new FileStream(text5, FileMode.Create, FileAccess.Write);
						BinaryWriter binaryWriter = new BinaryWriter(fileStream);
						binaryWriter.Write(Resources.ReportePorcentaje, 0, Resources.ReportePorcentaje.Length);
						binaryWriter.Close();
						fileStream.Close();
						obj = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Excel.Application"));
						object obj2 = obj;
						object instance = NewLateBinding.LateGet(obj2, null, "Workbooks", new object[0], null, null, null);
						object[] array = new object[1] { text5 };
						object[] arguments = array;
						bool[] array2 = new bool[1] { true };
						object obj3 = NewLateBinding.LateGet(instance, null, "Open", arguments, null, null, array2);
						if (array2[0])
						{
							text5 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
						}
						object objectValue = RuntimeHelpers.GetObjectValue(obj3);
						object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "ActiveSheet", new object[0], null, null, null));
						int num11 = 1;
						int num12 = ChckListUO.ItemCount - 1;
						int num13 = 1;
						while (true)
						{
							int num14 = num13;
							int num4 = num12;
							if (num14 > num4)
							{
								break;
							}
							if (ChckListUO.GetItemCheckState(num13) == CheckState.Checked)
							{
								GridControl3.DataSource = oRRHHClass.spRRHH_EstadisticaPermiso(Conversions.ToString(TipoTrabjador), fi, ff, text, text2, text3, Conversions.ToString(ChckListUO.GetItemValue(num13)));
								object instance2 = objectValue;
								object[] array3 = new object[1] { num11 };
								object[] arguments2 = array3;
								array2 = new bool[1] { true };
								object obj4 = NewLateBinding.LateGet(instance2, null, "Sheets", arguments2, null, null, array2);
								if (array2[0])
								{
									num11 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[0]), typeof(int));
								}
								objectValue2 = RuntimeHelpers.GetObjectValue(obj4);
								objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "ActiveSheet", new object[0], null, null, null));
								if (ChckListUO.GetItemText(num13).Length >= 30)
								{
									NewLateBinding.LateSet(objectValue2, null, "Name", new object[1] { ChckListUO.GetItemText(num13).Substring(0, 30).Trim() }, null, null);
								}
								else
								{
									NewLateBinding.LateSet(objectValue2, null, "Name", new object[1] { ChckListUO.GetItemText(num13).Trim() }, null, null);
								}
								NewLateBinding.LateSet(objectValue2, null, "RANGE", new object[2]
								{
									"B2",
									"PORCENTAJES DE LAS TARDANZAS Y PERMISOS DEL: " + UcFechas1.Rango.Desde.ToShortDateString() + " AL " + UcFechas1.Rango.Hasta.ToShortDateString()
								}, null, null);
								NewLateBinding.LateSet(objectValue2, null, "RANGE", new object[2] { "B5", "Oficina: " }, null, null);
								NewLateBinding.LateSet(objectValue2, null, "RANGE", new object[2]
								{
									"C5",
									ChckListUO.GetItemText(num13).Trim()
								}, null, null);
								NewLateBinding.LateSet(objectValue2, null, "RANGE", new object[2] { "B7", "N°" }, null, null);
								NewLateBinding.LateSet(objectValue2, null, "RANGE", new object[2] { "C7", "Apellidos y Nombres" }, null, null);
								NewLateBinding.LateSet(objectValue2, null, "RANGE", new object[2] { "D7", "Minutos Tarde" }, null, null);
								int num15 = GridView3.Columns.Count - 1;
								int num16 = 6;
								while (true)
								{
									int num17 = num16;
									num4 = num15;
									if (num17 > num4)
									{
										break;
									}
									string text6 = GridView3.Columns[num16].Name.Trim();
									NewLateBinding.LateSet(objectValue2, null, "Cells", new object[3]
									{
										7,
										num16 - 1,
										text6.Substring(3, text6.Length - 3)
									}, null, null);
									num16++;
								}
								int num18 = 8;
								int num19 = GridView3.Columns.Count - 1;
								int num20 = 0;
								while (true)
								{
									int num21 = num20;
									num4 = num19;
									if (num21 > num4)
									{
										break;
									}
									if (num20 == 0)
									{
										int num22 = GridView3.RowCount - 1;
										int num23 = 0;
										while (true)
										{
											int num24 = num23;
											num4 = num22;
											if (num24 > num4)
											{
												break;
											}
											NewLateBinding.LateSet(objectValue2, null, "Cells", new object[3]
											{
												num18 + num23,
												2 + num20,
												num23 + 1
											}, null, null);
											object objectValue3 = RuntimeHelpers.GetObjectValue(GridView3.GetRowCellValue(num23, GridView3.Columns[num20]));
											if (unchecked(objectValue3 == DBNull.Value || objectValue3 == null) | (Operators.CompareString(objectValue3.ToString(), string.Empty, TextCompare: false) == 0))
											{
												NewLateBinding.LateSet(objectValue2, null, "Cells", new object[3]
												{
													num18 + num23,
													3 + num20,
													"0"
												}, null, null);
											}
											else
											{
												NewLateBinding.LateSet(objectValue2, null, "Cells", new object[3]
												{
													num18 + num23,
													3 + num20,
													objectValue3.ToString()
												}, null, null);
											}
											num23++;
										}
									}
									if (num20 == 3)
									{
										int num25 = GridView3.RowCount - 1;
										int num26 = 0;
										while (true)
										{
											int num27 = num26;
											num4 = num25;
											if (num27 > num4)
											{
												break;
											}
											object objectValue4 = RuntimeHelpers.GetObjectValue(GridView3.GetRowCellValue(num26, GridView3.Columns[num20]));
											if (unchecked(objectValue4 == DBNull.Value || objectValue4 == null) | (Operators.CompareString(objectValue4.ToString(), string.Empty, TextCompare: false) == 0))
											{
												NewLateBinding.LateSet(objectValue2, null, "Cells", new object[3]
												{
													num18 + num26,
													1 + num20,
													"0"
												}, null, null);
											}
											else
											{
												NewLateBinding.LateSet(objectValue2, null, "Cells", new object[3]
												{
													num18 + num26,
													1 + num20,
													objectValue4.ToString()
												}, null, null);
											}
											num26++;
										}
									}
									if (num20 >= 6)
									{
										int num28 = GridView3.RowCount - 1;
										int num29 = 0;
										while (true)
										{
											int num30 = num29;
											num4 = num28;
											if (num30 > num4)
											{
												break;
											}
											object objectValue5 = RuntimeHelpers.GetObjectValue(GridView3.GetRowCellValue(num29, GridView3.Columns[num20]));
											if (unchecked(objectValue5 == DBNull.Value || objectValue5 == null) | (Operators.CompareString(objectValue5.ToString(), string.Empty, TextCompare: false) == 0))
											{
												NewLateBinding.LateSet(objectValue2, null, "Cells", new object[3]
												{
													num18 + num29,
													num20 - 1,
													"0"
												}, null, null);
											}
											else
											{
												NewLateBinding.LateSet(objectValue2, null, "Cells", new object[3]
												{
													num18 + num29,
													num20 - 1,
													objectValue5.ToString()
												}, null, null);
											}
											num29++;
										}
									}
									num20++;
								}
								NewLateBinding.LateSet(objectValue2, null, "Cells", new object[3]
								{
									6,
									GridView3.Columns.Count + 1,
									"Leyenda: "
								}, null, null);
								NewLateBinding.LateSet(objectValue2, null, "Cells", new object[3]
								{
									7,
									GridView3.Columns.Count + 1,
									"Motivo"
								}, null, null);
								NewLateBinding.LateSet(objectValue2, null, "Cells", new object[3]
								{
									7,
									GridView3.Columns.Count + 2,
									"Cantidad"
								}, null, null);
								NewLateBinding.LateSet(objectValue2, null, "Cells", new object[3]
								{
									7,
									GridView3.Columns.Count + 3,
									"%"
								}, null, null);
								int num31 = list.Count - 1;
								int num32 = 0;
								while (true)
								{
									int num33 = num32;
									num4 = num31;
									if (num33 > num4)
									{
										break;
									}
									DataTable dataTable = new DataTable();
									dataTable = oRRHHClass.spRRHH_ResumenEstadisticaPermiso(fi, ff, list[num32], Convert.ToInt32(RuntimeHelpers.GetObjectValue(ChckListUO.GetItemValue(num13))));
									NewLateBinding.LateSet(objectValue2, null, "Cells", new object[3]
									{
										8 + num32,
										9,
										dataTable.Rows[0][1].ToString()
									}, null, null);
									NewLateBinding.LateSet(objectValue2, null, "Cells", new object[3]
									{
										8 + num32,
										10,
										dataTable.Rows[0][2].ToString()
									}, null, null);
									NewLateBinding.LateSet(objectValue2, null, "Cells", new object[3]
									{
										8 + num32,
										11,
										dataTable.Rows[0][3].ToString()
									}, null, null);
									dataTable = null;
									num32++;
								}
								int num34 = GridView3.Columns.Count - 1;
								int num35 = 6;
								while (true)
								{
									int num36 = num35;
									num4 = num34;
									if (num36 > num4)
									{
										break;
									}
									int num37 = ChckListLocal.ItemCount - 1;
									int num38 = 1;
									while (true)
									{
										int num39 = num38;
										num4 = num37;
										if (num39 > num4)
										{
											break;
										}
										if (ChckListLocal.GetItemCheckState(num38) == CheckState.Checked)
										{
										}
										num38++;
									}
									num35++;
								}
								num11++;
								object instance3 = NewLateBinding.LateGet(obj2, null, "Worksheets", new object[0], null, null, null);
								array3 = new object[1];
								object[] array4 = array3;
								object instance4 = obj2;
								array = new object[1];
								object[] array5 = array;
								int num40 = 1;
								array5[0] = num40;
								array4[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(instance4, null, "Worksheets", array, null, null, null));
								object[] array6 = array3;
								string[] argumentNames = new string[1] { "After" };
								array2 = new bool[1] { true };
								object obj5 = NewLateBinding.LateGet(instance3, null, "Add", array6, argumentNames, null, array2);
								if (array2[0])
								{
									NewLateBinding.LateSetComplex(instance4, null, "Worksheets", new object[2]
									{
										num40,
										RuntimeHelpers.GetObjectValue(array6[0])
									}, null, null, OptimisticSet: true, RValueBase: false);
								}
								objectValue2 = RuntimeHelpers.GetObjectValue(obj5);
							}
							num13++;
						}
						NewLateBinding.LateSet(obj, null, "Visible", new object[1] { true }, null, null);
						objectValue = null;
						objectValue2 = null;
						obj2 = null;
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ProjectData.ClearProjectError();
					}
					finally
					{
						obj = null;
						Cursor = Cursors.Default;
					}
					int num41 = ChckListUO.ItemCount - 1;
					int num42 = 1;
					while (true)
					{
						int num43 = num42;
						int num4 = num41;
						if (num43 <= num4)
						{
							if (ChckListUO.GetItemCheckState(num42) == CheckState.Checked)
							{
								GridControl3.DataSource = oRRHHClass.spRRHH_EstadisticaPermiso(Conversions.ToString(TipoTrabjador), fi, ff, text, text2, text3, Conversions.ToString(ChckListUO.GetItemValue(num42)));
							}
							num42++;
							continue;
						}
						break;
					}
				}
				else
				{
					MessageBox.Show("Debe Seleccionar un Lugar de Marcado", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
			else
			{
				MessageBox.Show("Debe Seleccionar un Lugar de Marcado", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
	}
}
