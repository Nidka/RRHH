using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ClassRRHH;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using GRLL.Common;
using Microsoft.Office.Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using RecursosHumanos.My;
using RecursosHumanos.My.Resources;

namespace RecursosHumanos;

[DesignerGenerated]
public class FrmSobreTiempo : FrmConsulta
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("GroupControl1")]
	private GroupControl _GroupControl1;

	[AccessedThroughProperty("BtnGenerar")]
	private Button _BtnGenerar;

	[AccessedThroughProperty("UcFechas1")]
	private ucFechas _UcFechas1;

	[AccessedThroughProperty("GridControl1")]
	private GridControl _GridControl1;

	[AccessedThroughProperty("GridView1")]
	private GridView _GridView1;

	[AccessedThroughProperty("BtnExportarExcel")]
	private Button _BtnExportarExcel;

	[AccessedThroughProperty("DefaultLookAndFeel1")]
	private DefaultLookAndFeel _DefaultLookAndFeel1;

	[AccessedThroughProperty("UcCBPartidaPresupuestal")]
	private ucComboBox _UcCBPartidaPresupuestal;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("GridColumn1")]
	private GridColumn _GridColumn1;

	[AccessedThroughProperty("GridColumn2")]
	private GridColumn _GridColumn2;

	[AccessedThroughProperty("GridColumn3")]
	private GridColumn _GridColumn3;

	private RRHHClass obj;

	private string fi;

	private string ff;

	private object m_Excel;

	private object objLibroExcel;

	private object objHojaExcel;

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

	internal Button BtnExportarExcel
	{
		[DebuggerNonUserCode]
		get
		{
			return _BtnExportarExcel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = BtnExportarExcel_Click;
			if (_BtnExportarExcel != null)
			{
				_BtnExportarExcel.Click -= value2;
			}
			_BtnExportarExcel = value;
			if (_BtnExportarExcel != null)
			{
				_BtnExportarExcel.Click += value2;
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

	public FrmSobreTiempo()
	{
		base.CloseForm += FrmSobreTiempo_CloseForm;
		base.Load += FrmSobreTiempo_Load;
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
		this.GroupControl1 = new DevExpress.XtraEditors.GroupControl();
		this.UcCBPartidaPresupuestal = new GRLL.Common.ucComboBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.BtnGenerar = new System.Windows.Forms.Button();
		this.UcFechas1 = new GRLL.Common.ucFechas();
		this.GridControl1 = new DevExpress.XtraGrid.GridControl();
		this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.GridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.BtnExportarExcel = new System.Windows.Forms.Button();
		this.DefaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
		((System.ComponentModel.ISupportInitialize)this.GroupControl1).BeginInit();
		this.GroupControl1.SuspendLayout();
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
		System.Drawing.Point location = new System.Drawing.Point(558, 337);
		button.Location = location;
		System.Windows.Forms.Button button2 = this.cmdCerrar;
		System.Drawing.Size size = new System.Drawing.Size(61, 23);
		button2.Size = size;
		this.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		System.Windows.Forms.Panel panelSup = this.PanelSup;
		size = new System.Drawing.Size(631, 29);
		panelSup.Size = size;
		System.Windows.Forms.Panel panelInf = this.PanelInf;
		location = new System.Drawing.Point(0, 366);
		panelInf.Location = location;
		System.Windows.Forms.Panel panelInf2 = this.PanelInf;
		size = new System.Drawing.Size(631, 27);
		panelInf2.Size = size;
		this.GroupControl1.Controls.Add(this.UcCBPartidaPresupuestal);
		this.GroupControl1.Controls.Add(this.Label1);
		this.GroupControl1.Controls.Add(this.BtnGenerar);
		this.GroupControl1.Controls.Add(this.UcFechas1);
		DevExpress.XtraEditors.GroupControl groupControl = this.GroupControl1;
		location = new System.Drawing.Point(12, 35);
		groupControl.Location = location;
		this.GroupControl1.Name = "GroupControl1";
		DevExpress.XtraEditors.GroupControl groupControl2 = this.GroupControl1;
		size = new System.Drawing.Size(404, 78);
		groupControl2.Size = size;
		this.GroupControl1.TabIndex = 3;
		this.GroupControl1.Text = "Parámetros";
		this.UcCBPartidaPresupuestal.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCBPartidaPresupuestal.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCBPartidaPresupuestal.FormattingEnabled = true;
		this.UcCBPartidaPresupuestal.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucCBPartidaPresupuestal = this.UcCBPartidaPresupuestal;
		location = new System.Drawing.Point(45, 24);
		ucCBPartidaPresupuestal.Location = location;
		this.UcCBPartidaPresupuestal.Name = "UcCBPartidaPresupuestal";
		GRLL.Common.ucComboBox ucCBPartidaPresupuestal2 = this.UcCBPartidaPresupuestal;
		size = new System.Drawing.Size(150, 21);
		ucCBPartidaPresupuestal2.Size = size;
		this.UcCBPartidaPresupuestal.TabIndex = 9;
		this.Label1.AutoSize = true;
		System.Windows.Forms.Label label = this.Label1;
		location = new System.Drawing.Point(8, 27);
		label.Location = location;
		this.Label1.Name = "Label1";
		System.Windows.Forms.Label label2 = this.Label1;
		size = new System.Drawing.Size(31, 13);
		label2.Size = size;
		this.Label1.TabIndex = 10;
		this.Label1.Text = "Tipo:";
		this.BtnGenerar.AutoSize = true;
		this.BtnGenerar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.BtnGenerar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BtnGenerar.FlatAppearance.BorderSize = 0;
		this.BtnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BtnGenerar.Image = RecursosHumanos.My.Resources.Resources.document_out;
		System.Windows.Forms.Button btnGenerar = this.BtnGenerar;
		location = new System.Drawing.Point(314, 50);
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
		location = new System.Drawing.Point(5, 51);
		ucFechas.Location = location;
		this.UcFechas1.Name = "UcFechas1";
		GRLL.Common.ucFechas ucFechas2 = this.UcFechas1;
		size = new System.Drawing.Size(302, 22);
		ucFechas2.Size = size;
		this.UcFechas1.TabIndex = 2;
		this.GridControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		DevExpress.XtraGrid.GridControl gridControl = this.GridControl1;
		location = new System.Drawing.Point(12, 131);
		gridControl.Location = location;
		this.GridControl1.MainView = this.GridView1;
		this.GridControl1.Name = "GridControl1";
		DevExpress.XtraGrid.GridControl gridControl2 = this.GridControl1;
		size = new System.Drawing.Size(607, 200);
		gridControl2.Size = size;
		this.GridControl1.TabIndex = 4;
		this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[1] { this.GridView1 });
		this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[3] { this.GridColumn1, this.GridColumn2, this.GridColumn3 });
		this.GridView1.GridControl = this.GridControl1;
		this.GridView1.Name = "GridView1";
		this.GridView1.OptionsBehavior.Editable = false;
		this.GridView1.OptionsView.ShowGroupPanel = false;
		this.GridColumn1.Caption = "idempleado";
		this.GridColumn1.FieldName = "idempleado";
		this.GridColumn1.Name = "GridColumn1";
		this.GridColumn2.Caption = "Nombres Completos";
		this.GridColumn2.FieldName = "NombreCompleto";
		this.GridColumn2.Name = "GridColumn2";
		this.GridColumn2.Visible = true;
		this.GridColumn2.VisibleIndex = 0;
		this.GridColumn3.Caption = "Cant. Horas Sobre Tiempo";
		this.GridColumn3.FieldName = "Sobretiempo";
		this.GridColumn3.Name = "GridColumn3";
		this.GridColumn3.Visible = true;
		this.GridColumn3.VisibleIndex = 1;
		this.BtnExportarExcel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.BtnExportarExcel.AutoSize = true;
		this.BtnExportarExcel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BtnExportarExcel.FlatAppearance.BorderSize = 0;
		this.BtnExportarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BtnExportarExcel.Image = RecursosHumanos.My.Resources.Resources.document_out;
		System.Windows.Forms.Button btnExportarExcel = this.BtnExportarExcel;
		location = new System.Drawing.Point(12, 337);
		btnExportarExcel.Location = location;
		this.BtnExportarExcel.Name = "BtnExportarExcel";
		System.Windows.Forms.Button btnExportarExcel2 = this.BtnExportarExcel;
		size = new System.Drawing.Size(112, 23);
		btnExportarExcel2.Size = size;
		this.BtnExportarExcel.TabIndex = 5;
		this.BtnExportarExcel.Text = "Exportar a Excel";
		this.BtnExportarExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.BtnExportarExcel.UseVisualStyleBackColor = true;
		this.DefaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins";
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		size = new System.Drawing.Size(631, 393);
		this.ClientSize = size;
		this.Controls.Add(this.BtnExportarExcel);
		this.Controls.Add(this.GridControl1);
		this.Controls.Add(this.GroupControl1);
		this.MessageShow = true;
		this.Name = "FrmSobreTiempo";
		this.TitleMsg = "FrmConsulta";
		this.Titulo = "Sobre Tiempo";
		this.VerCmdCerrar = true;
		this.Controls.SetChildIndex(this.PanelSup, 0);
		this.Controls.SetChildIndex(this.PanelInf, 0);
		this.Controls.SetChildIndex(this.cmdCerrar, 0);
		this.Controls.SetChildIndex(this.GroupControl1, 0);
		this.Controls.SetChildIndex(this.GridControl1, 0);
		this.Controls.SetChildIndex(this.BtnExportarExcel, 0);
		((System.ComponentModel.ISupportInitialize)this.GroupControl1).EndInit();
		this.GroupControl1.ResumeLayout(false);
		this.GroupControl1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.GridControl1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GridView1).EndInit();
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	private void BtnGenerar_Click(object sender, EventArgs e)
	{
		if (DateTime.Compare(UcFechas1.Rango.Desde, UcFechas1.Rango.Hasta) > 0)
		{
			MessageBox.Show("La Fecha de Inicio no puede ser Mayor a la de Término", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		WindowState = FormWindowState.Maximized;
		fi = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(UcFechas1.Rango.Desde.Year.ToString(), Interaction.IIf(UcFechas1.Rango.Desde.Month.ToString().Length == 1, "0" + UcFechas1.Rango.Desde.Month, UcFechas1.Rango.Desde.Month.ToString())), Interaction.IIf(UcFechas1.Rango.Desde.Day.ToString().Length == 1, "0" + UcFechas1.Rango.Desde.Day, UcFechas1.Rango.Desde.Day.ToString())));
		ff = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(UcFechas1.Rango.Hasta.Year.ToString(), Interaction.IIf(UcFechas1.Rango.Hasta.Month.ToString().Length == 1, "0" + UcFechas1.Rango.Hasta.Month, UcFechas1.Rango.Hasta.Month.ToString())), Interaction.IIf(UcFechas1.Rango.Hasta.Day.ToString().Length == 1, "0" + UcFechas1.Rango.Hasta.Day, UcFechas1.Rango.Hasta.Day.ToString())));
		GridControl1.DataSource = RuntimeHelpers.GetObjectValue(obj.spRRHH_ObtenerHorasExtras(fi, ff, Conversions.ToInteger(UcCBPartidaPresupuestal.SelectedValue.ToString())));
	}

	private void FrmSobreTiempo_CloseForm(ref bool Cancelar)
	{
		if (objLibroExcel != null)
		{
			EiminaReferencias(ref objHojaExcel);
			EiminaReferencias(ref objLibroExcel);
			EiminaReferencias(ref m_Excel);
		}
		GC.WaitForPendingFinalizers();
		GC.Collect();
	}

	private void FrmSobreTiempo_Load(object sender, EventArgs e)
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

	private void EiminaReferencias(ref object Referencias)
	{
		try
		{
			Marshal.ReleaseComObject(RuntimeHelpers.GetObjectValue(Referencias));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		finally
		{
			Referencias = null;
		}
	}

	private void BtnExportarExcel_Click(object sender, EventArgs e)
	{
		if (GridView1.RowCount == 0)
		{
			MessageBox.Show("Debe existir como minimo, un registro para exportar", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		XlsExportOptions xlsExportOptions = new XlsExportOptions();
		string text = MyProject.Computer.FileSystem.SpecialDirectories.MyDocuments.ToString();
		string text2 = text + "\\Reporte_AutoGenerado_SobreTiempo" + Conversions.ToString(DateAndTime.Today.Date.Day) + Conversions.ToString(DateAndTime.Today.Date.Month) + Conversions.ToString(DateAndTime.Today.Date.Year) + DateAndTime.Now.Hour + Conversions.ToString(DateAndTime.Now.Minute) + DateAndTime.Now.Second + Conversions.ToString(DateAndTime.Now.Millisecond) + ".xls";
		xlsExportOptions.SheetName = "Reporte_AutoGenerado_SobreTiempo_" + fi + "_" + ff;
		GridControl1.ExportToXls(text2, xlsExportOptions);
		if (!MyProject.Computer.FileSystem.FileExists(text2))
		{
			Interaction.MsgBox(text2 + " No Existe");
			return;
		}
		m_Excel = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Excel.Application"));
		object instance = NewLateBinding.LateGet(m_Excel, null, "Workbooks", new object[0], null, null, null);
		object[] array = new object[1] { text2 };
		object[] arguments = array;
		bool[] array2 = new bool[1] { true };
		object obj = NewLateBinding.LateGet(instance, null, "Open", arguments, null, null, array2);
		if (array2[0])
		{
			text2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
		}
		objLibroExcel = RuntimeHelpers.GetObjectValue(obj);
		objHojaExcel = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objLibroExcel, null, "Worksheets", new object[1] { 1 }, null, null, null));
		NewLateBinding.LateCall(NewLateBinding.LateGet(objHojaExcel, null, "Rows", new object[1] { "1:5" }, null, null, null), null, "insert", new object[0], null, null, null, IgnoreReturn: true);
		NewLateBinding.LateCall(objHojaExcel, null, "Select", new object[0], null, null, null, IgnoreReturn: true);
		if (MyProject.Computer.FileSystem.FileExists(MySettingsProperty.Settings.RutaLogo))
		{
			object instance2 = NewLateBinding.LateGet(objHojaExcel, null, "Shapes", new object[0], null, null, null);
			array = new object[7];
			object[] array3 = array;
			MySettings settings = MySettingsProperty.Settings;
			array3[0] = settings.RutaLogo;
			array[1] = MsoTriState.msoFalse;
			array[2] = MsoTriState.msoCTrue;
			array[3] = 5;
			array[4] = 5;
			array[5] = 50;
			array[6] = 50;
			object[] array4 = array;
			object[] arguments2 = array4;
			array2 = new bool[7] { true, false, false, false, false, false, false };
			NewLateBinding.LateCall(instance2, null, "AddPicture", arguments2, null, null, array2, IgnoreReturn: true);
			if (array2[0])
			{
				settings.RutaLogo = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string));
			}
		}
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Rows", new object[1] { "6:6" }, null, null, null), null, "RowHeight", new object[1] { 48 }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Rows", new object[1] { "6:6" }, null, null, null), null, "Orientation", new object[1] { 90 }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2] { 6, 1 }, null, null, null), null, "Orientation", new object[1] { 0 }, null, null, OptimisticSet: false, RValueBase: true);
		checked
		{
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2]
			{
				6,
				GridView1.Columns.Count - 1
			}, null, null, null), null, "Orientation", new object[1] { 0 }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2]
			{
				6,
				GridView1.Columns.Count - 1
			}, null, null, null), null, "VerticalAlignment", new object[1] { -4108 }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2] { 6, 1 }, null, null, null), null, "VerticalAlignment", new object[1] { -4108 }, null, null, OptimisticSet: false, RValueBase: true);
			object instance3 = objHojaExcel;
			object[] array4 = new object[2] { "A2", null };
			object[] array5 = array4;
			object obj2 = objHojaExcel;
			object instance4 = obj2;
			array = new object[2];
			object[] array6 = array;
			int num = 2;
			array6[0] = num;
			object[] array7 = array;
			int num2 = GridView1.Columns.Count - 1;
			array7[1] = num2;
			array5[1] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(instance4, null, "Cells", array, null, null, null));
			object[] array8 = array4;
			object[] arguments3 = array8;
			array2 = new bool[2] { false, true };
			object instance5 = NewLateBinding.LateGet(instance3, null, "Range", arguments3, null, null, array2);
			if (array2[1])
			{
				NewLateBinding.LateSetComplex(obj2, null, "Cells", new object[3]
				{
					num,
					num2,
					RuntimeHelpers.GetObjectValue(array8[1])
				}, null, null, OptimisticSet: true, RValueBase: false);
			}
			NewLateBinding.LateCall(instance5, null, "Merge", new object[0], null, null, null, IgnoreReturn: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2] { 2, 1 }, null, null, null), null, "FormulaR1C1", new object[1] { "Reporte de SobreTiempo" }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2] { 2, 1 }, null, null, null), null, "HorizontalAlignment", new object[1] { -4108 }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objHojaExcel, null, "Rows", new object[1] { "2:2" }, null, null, null), null, "Font", new object[0], null, null, null), null, "Size", new object[1] { 16 }, null, null, OptimisticSet: false, RValueBase: true);
			object instance6 = objHojaExcel;
			array8 = new object[2] { "A3", null };
			object[] array9 = array8;
			obj2 = objHojaExcel;
			object instance7 = obj2;
			object[] array10 = new object[2];
			object[] array11 = array10;
			num = 3;
			array11[0] = num;
			object[] array12 = array10;
			num2 = GridView1.Columns.Count - 1;
			array12[1] = num2;
			array9[1] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(instance7, null, "Cells", array10, null, null, null));
			array = array8;
			object[] arguments4 = array;
			array2 = new bool[2] { false, true };
			object instance8 = NewLateBinding.LateGet(instance6, null, "Range", arguments4, null, null, array2);
			if (array2[1])
			{
				NewLateBinding.LateSetComplex(obj2, null, "Cells", new object[3]
				{
					num,
					num2,
					RuntimeHelpers.GetObjectValue(array[1])
				}, null, null, OptimisticSet: true, RValueBase: false);
			}
			NewLateBinding.LateCall(instance8, null, "Merge", new object[0], null, null, null, IgnoreReturn: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2] { 3, 1 }, null, null, null), null, "FormulaR1C1", new object[1] { "Del: " + Conversions.ToString(UcFechas1.Rango.Desde) + " al " + Conversions.ToString(UcFechas1.Rango.Hasta) }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2] { 3, 1 }, null, null, null), null, "HorizontalAlignment", new object[1] { -4108 }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(objHojaExcel, null, "Columns", new object[1] { "A:Z" }, null, null, null), null, "EntireColumn", new object[0], null, null, null), null, "AutoFit", new object[0], null, null, null, IgnoreReturn: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "PageSetup", new object[0], null, null, null), null, "Orientation", new object[1] { 2 }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "PageSetup", new object[0], null, null, null), null, "PrintTitleRows", new object[1] { "$1:$6" }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSet(m_Excel, null, "Visible", new object[1] { true }, null, null);
		}
	}
}
