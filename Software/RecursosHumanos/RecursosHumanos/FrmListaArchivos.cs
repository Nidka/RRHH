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
public class FrmListaArchivos : FrmConsulta
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("GCArchivo")]
	private GridControl _GCArchivo;

	[AccessedThroughProperty("GridViewArchivo")]
	private GridView _GridViewArchivo;

	[AccessedThroughProperty("GroupControl1")]
	private GroupControl _GroupControl1;

	[AccessedThroughProperty("btnEliminar")]
	private Button _btnEliminar;

	[AccessedThroughProperty("btnModificar")]
	private Button _btnModificar;

	[AccessedThroughProperty("btnAgregar")]
	private Button _btnAgregar;

	[AccessedThroughProperty("UcTxtNombres")]
	private ucTextBox _UcTxtNombres;

	[AccessedThroughProperty("GridColumn1")]
	private GridColumn _GridColumn1;

	[AccessedThroughProperty("GridColumn2")]
	private GridColumn _GridColumn2;

	[AccessedThroughProperty("GridColumn3")]
	private GridColumn _GridColumn3;

	[AccessedThroughProperty("GridColumn4")]
	private GridColumn _GridColumn4;

	[AccessedThroughProperty("GridColumn5")]
	private GridColumn _GridColumn5;

	[AccessedThroughProperty("GridColumn6")]
	private GridColumn _GridColumn6;

	[AccessedThroughProperty("GridColumn7")]
	private GridColumn _GridColumn7;

	public int CodEmple;

	private Empleado empleado;

	private Persona persona;

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

	internal GridControl GCArchivo
	{
		[DebuggerNonUserCode]
		get
		{
			return _GCArchivo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GCArchivo = value;
		}
	}

	internal GridView GridViewArchivo
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridViewArchivo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridViewArchivo = value;
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

	internal ucTextBox UcTxtNombres
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtNombres;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtNombres = value;
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

	public FrmListaArchivos()
	{
		base.Load += FrmListaArchivos_Load;
		__ENCAddToList(this);
		empleado = new Empleado();
		persona = new Persona();
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecursosHumanos.FrmListaArchivos));
		this.Label1 = new System.Windows.Forms.Label();
		this.GCArchivo = new DevExpress.XtraGrid.GridControl();
		this.GridViewArchivo = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.GridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GroupControl1 = new DevExpress.XtraEditors.GroupControl();
		this.btnEliminar = new System.Windows.Forms.Button();
		this.btnModificar = new System.Windows.Forms.Button();
		this.btnAgregar = new System.Windows.Forms.Button();
		this.UcTxtNombres = new GRLL.Common.ucTextBox(this.components);
		((System.ComponentModel.ISupportInitialize)this.GCArchivo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GridViewArchivo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GroupControl1).BeginInit();
		this.GroupControl1.SuspendLayout();
		this.SuspendLayout();
		this.cmdCerrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.cmdCerrar.AutoSize = true;
		this.cmdCerrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.cmdCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cmdCerrar.FlatAppearance.BorderSize = 0;
		this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.cmdCerrar.Image = (System.Drawing.Image)resources.GetObject("cmdCerrar.Image");
		System.Windows.Forms.Button button = this.cmdCerrar;
		System.Drawing.Point location = new System.Drawing.Point(530, 350);
		button.Location = location;
		System.Windows.Forms.Button button2 = this.cmdCerrar;
		System.Drawing.Size size = new System.Drawing.Size(61, 23);
		button2.Size = size;
		this.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.cmdCerrar.Visible = true;
		System.Windows.Forms.Panel panelSup = this.PanelSup;
		size = new System.Drawing.Size(603, 24);
		panelSup.Size = size;
		System.Windows.Forms.Panel panelInf = this.PanelInf;
		location = new System.Drawing.Point(0, 379);
		panelInf.Location = location;
		System.Windows.Forms.Panel panelInf2 = this.PanelInf;
		size = new System.Drawing.Size(603, 27);
		panelInf2.Size = size;
		this.Label1.AutoSize = true;
		System.Windows.Forms.Label label = this.Label1;
		location = new System.Drawing.Point(12, 40);
		label.Location = location;
		this.Label1.Name = "Label1";
		System.Windows.Forms.Label label2 = this.Label1;
		size = new System.Drawing.Size(52, 13);
		label2.Size = size;
		this.Label1.TabIndex = 3;
		this.Label1.Text = "Nombres:";
		this.GCArchivo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.GCArchivo.EmbeddedNavigator.Name = "";
		DevExpress.XtraGrid.GridControl gCArchivo = this.GCArchivo;
		location = new System.Drawing.Point(1, 20);
		gCArchivo.Location = location;
		this.GCArchivo.LookAndFeel.SkinName = "Blue";
		this.GCArchivo.LookAndFeel.UseDefaultLookAndFeel = false;
		this.GCArchivo.MainView = this.GridViewArchivo;
		this.GCArchivo.Name = "GCArchivo";
		DevExpress.XtraGrid.GridControl gCArchivo2 = this.GCArchivo;
		size = new System.Drawing.Size(490, 248);
		gCArchivo2.Size = size;
		this.GCArchivo.TabIndex = 4;
		this.GCArchivo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[1] { this.GridViewArchivo });
		this.GridViewArchivo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[7] { this.GridColumn1, this.GridColumn2, this.GridColumn3, this.GridColumn4, this.GridColumn5, this.GridColumn6, this.GridColumn7 });
		this.GridViewArchivo.GridControl = this.GCArchivo;
		this.GridViewArchivo.Name = "GridViewArchivo";
		this.GridViewArchivo.OptionsBehavior.Editable = false;
		this.GridViewArchivo.OptionsCustomization.AllowColumnMoving = false;
		this.GridViewArchivo.OptionsCustomization.AllowFilter = false;
		this.GridViewArchivo.OptionsMenu.EnableColumnMenu = false;
		this.GridViewArchivo.OptionsPrint.AutoWidth = false;
		this.GridViewArchivo.OptionsView.ColumnAutoWidth = false;
		this.GridViewArchivo.OptionsView.ShowGroupPanel = false;
		this.GridColumn1.Caption = "Documento";
		this.GridColumn1.FieldName = "DescripDocumento";
		this.GridColumn1.Name = "GridColumn1";
		this.GridColumn1.Visible = true;
		this.GridColumn1.VisibleIndex = 0;
		this.GridColumn1.Width = 150;
		this.GridColumn2.Caption = "Fecha de Ingreso";
		this.GridColumn2.FieldName = "FechaIngreDoc";
		this.GridColumn2.Name = "GridColumn2";
		this.GridColumn2.Visible = true;
		this.GridColumn2.VisibleIndex = 1;
		this.GridColumn2.Width = 100;
		this.GridColumn3.Caption = "Fecha de Renovación";
		this.GridColumn3.FieldName = "FechaVenDoc";
		this.GridColumn3.Name = "GridColumn3";
		this.GridColumn3.Visible = true;
		this.GridColumn3.VisibleIndex = 2;
		this.GridColumn3.Width = 125;
		this.GridColumn4.Caption = "Num de Ref.";
		this.GridColumn4.FieldName = "NumRef";
		this.GridColumn4.Name = "GridColumn4";
		this.GridColumn4.Visible = true;
		this.GridColumn4.VisibleIndex = 3;
		this.GridColumn4.Width = 100;
		this.GridColumn5.Caption = "Observ.";
		this.GridColumn5.FieldName = "Obs";
		this.GridColumn5.Name = "GridColumn5";
		this.GridColumn5.Visible = true;
		this.GridColumn5.VisibleIndex = 4;
		this.GridColumn5.Width = 100;
		this.GridColumn6.Caption = "GridColumn6";
		this.GridColumn6.FieldName = "idEmpleado";
		this.GridColumn6.Name = "GridColumn6";
		this.GridColumn7.Caption = "GridColumn7";
		this.GridColumn7.FieldName = "idDocumento";
		this.GridColumn7.Name = "GridColumn7";
		this.GroupControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.GroupControl1.Controls.Add(this.btnEliminar);
		this.GroupControl1.Controls.Add(this.btnModificar);
		this.GroupControl1.Controls.Add(this.btnAgregar);
		this.GroupControl1.Controls.Add(this.GCArchivo);
		DevExpress.XtraEditors.GroupControl groupControl = this.GroupControl1;
		location = new System.Drawing.Point(12, 67);
		groupControl.Location = location;
		this.GroupControl1.LookAndFeel.SkinName = "Money Twins";
		this.GroupControl1.LookAndFeel.UseDefaultLookAndFeel = false;
		this.GroupControl1.Name = "GroupControl1";
		DevExpress.XtraEditors.GroupControl groupControl2 = this.GroupControl1;
		size = new System.Drawing.Size(577, 270);
		groupControl2.Size = size;
		this.GroupControl1.TabIndex = 5;
		this.GroupControl1.Text = "Documentos";
		this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Right;
		this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnEliminar.FlatAppearance.BorderSize = 0;
		this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnEliminar.Image = RecursosHumanos.My.Resources.Resources.delete2;
		System.Windows.Forms.Button button3 = this.btnEliminar;
		location = new System.Drawing.Point(497, 151);
		button3.Location = location;
		this.btnEliminar.Name = "btnEliminar";
		System.Windows.Forms.Button button4 = this.btnEliminar;
		size = new System.Drawing.Size(75, 36);
		button4.Size = size;
		this.btnEliminar.TabIndex = 14;
		this.btnEliminar.Text = "Eliminar";
		this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.btnEliminar.UseVisualStyleBackColor = true;
		this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Right;
		this.btnModificar.FlatAppearance.BorderSize = 0;
		this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnModificar.Image = RecursosHumanos.My.Resources.Resources.document_edit;
		System.Windows.Forms.Button button5 = this.btnModificar;
		location = new System.Drawing.Point(497, 108);
		button5.Location = location;
		this.btnModificar.Name = "btnModificar";
		System.Windows.Forms.Button button6 = this.btnModificar;
		size = new System.Drawing.Size(75, 37);
		button6.Size = size;
		this.btnModificar.TabIndex = 15;
		this.btnModificar.Text = "Modificar";
		this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.btnModificar.UseVisualStyleBackColor = true;
		this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Right;
		this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAgregar.FlatAppearance.BorderSize = 0;
		this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAgregar.Image = RecursosHumanos.My.Resources.Resources.add2;
		System.Windows.Forms.Button button7 = this.btnAgregar;
		location = new System.Drawing.Point(497, 67);
		button7.Location = location;
		this.btnAgregar.Name = "btnAgregar";
		System.Windows.Forms.Button button8 = this.btnAgregar;
		size = new System.Drawing.Size(75, 35);
		button8.Size = size;
		this.btnAgregar.TabIndex = 13;
		this.btnAgregar.Text = "Agregar";
		this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.btnAgregar.UseVisualStyleBackColor = true;
		this.UcTxtNombres.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtNombres.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.UcTxtNombres.Formato = null;
		this.UcTxtNombres.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtNombres = this.UcTxtNombres;
		location = new System.Drawing.Point(70, 37);
		ucTxtNombres.Location = location;
		this.UcTxtNombres.Name = "UcTxtNombres";
		this.UcTxtNombres.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtNombres.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtNombres.OnErrorBlankText = "";
		this.UcTxtNombres.PadLeftLenght = 0;
		this.UcTxtNombres.ReadOnly = true;
		this.UcTxtNombres.RegularExpression = "^[0-9]*$";
		this.UcTxtNombres.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtNombres.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtNombres2 = this.UcTxtNombres;
		size = new System.Drawing.Size(272, 20);
		ucTxtNombres2.Size = size;
		this.UcTxtNombres.TabIndex = 6;
		this.UcTxtNombres.TabNextControl = false;
		this.UcTxtNombres.Tipo = GRLL.Common.ucTextBox.TipoDato.Enteros;
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.Calculadora = false;
		size = new System.Drawing.Size(603, 406);
		this.ClientSize = size;
		this.Controls.Add(this.Label1);
		this.Controls.Add(this.UcTxtNombres);
		this.Controls.Add(this.GroupControl1);
		this.MessageShow = true;
		this.Name = "FrmListaArchivos";
		this.TitleMsg = "FrmConsulta";
		this.Titulo = "File Personal";
		this.VerCmdCerrar = true;
		this.Controls.SetChildIndex(this.cmdCerrar, 0);
		this.Controls.SetChildIndex(this.GroupControl1, 0);
		this.Controls.SetChildIndex(this.UcTxtNombres, 0);
		this.Controls.SetChildIndex(this.Label1, 0);
		this.Controls.SetChildIndex(this.PanelSup, 0);
		this.Controls.SetChildIndex(this.PanelInf, 0);
		((System.ComponentModel.ISupportInitialize)this.GCArchivo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GridViewArchivo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GroupControl1).EndInit();
		this.GroupControl1.ResumeLayout(false);
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	private void btnAgregar_Click(object sender, EventArgs e)
	{
		FrmDocumentos frmDocumentos = new FrmDocumentos();
		frmDocumentos.CodEmple = CodEmple;
		frmDocumentos.ShowDialog();
		if (frmDocumentos.DialogResult == DialogResult.OK)
		{
			llena_dgvDocumentos();
		}
	}

	public void llena_dgvDocumentos()
	{
		List<spRRHH_busca_archivosResult> dataSource = Module1.DcGrll.spRRHH_busca_archivos(CodEmple).ToList();
		GCArchivo.DataSource = dataSource;
	}

	private void FrmListaArchivos_Load(object sender, EventArgs e)
	{
		empleado = EmpleadoMapper.Instance().SelectBy([SpecialName] (Empleado c) => c.IdEmpleado == CodEmple).First();
		int num = (int)empleado.IdPersona;
		persona = PersonaMapper.Instance().SelectBy([SpecialName] (Persona p) => p.IdPersona == num).First();
		UcTxtNombres.Text = persona.Apellido_Paterno + " " + persona.Apellido_Materno + " " + persona.Nombres;
		llena_dgvDocumentos();
	}

	private void btnModificar_Click(object sender, EventArgs e)
	{
		int focusedRowHandle = GridViewArchivo.FocusedRowHandle;
		if (focusedRowHandle < 0)
		{
			MessageBox.Show("Debe Seleccionar un Documento", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		int codDocumento = Conversions.ToInteger(GridViewArchivo.GetRowCellValue(focusedRowHandle, "idDocumento"));
		FrmDocumentos frmDocumentos = new FrmDocumentos();
		frmDocumentos.CodEmple = CodEmple;
		frmDocumentos.CodDocumento = codDocumento;
		frmDocumentos.ShowDialog();
		if (frmDocumentos.DialogResult == DialogResult.OK)
		{
			llena_dgvDocumentos();
		}
	}

	private void btnEliminar_Click(object sender, EventArgs e)
	{
		int focusedRowHandle = GridViewArchivo.FocusedRowHandle;
		if (focusedRowHandle < 0)
		{
			MessageBox.Show("Debe Seleccionar un Documento", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		else if (MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject("Desea eliminar el Documento: ", GridViewArchivo.GetRowCellValue(focusedRowHandle, "DescripDocumento"))), "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
		{
			int idDocumento = Conversions.ToInteger(GridViewArchivo.GetRowCellValue(focusedRowHandle, "idDocumento"));
			Archivo archivo = new Archivo();
			archivo.idDocumento = idDocumento;
			archivo.IdEmpleado = CodEmple;
			ArchivoMapper.Instance().Delete(archivo);
			llena_dgvDocumentos();
		}
	}
}
