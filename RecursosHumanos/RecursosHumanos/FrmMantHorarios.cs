using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ClassRRHH;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask;
using GRLL.Common;
using Microsoft.VisualBasic.CompilerServices;
using RecursosHumanos.My.Resources;

namespace RecursosHumanos;

[DesignerGenerated]
public class FrmMantHorarios : FrmConsulta
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("UcTxtDescripcion")]
	private ucTextBox _UcTxtDescripcion;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("CheckEdit1")]
	private CheckEdit _CheckEdit1;

	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("btnGrabar")]
	private Button _btnGrabar;

	[AccessedThroughProperty("Txt_HE")]
	private TextEdit _Txt_HE;

	[AccessedThroughProperty("Txt_SR")]
	private TextEdit _Txt_SR;

	[AccessedThroughProperty("Txt_ER")]
	private TextEdit _Txt_ER;

	[AccessedThroughProperty("Txt_HS")]
	private TextEdit _Txt_HS;

	[AccessedThroughProperty("CheckEquipoMarcacion")]
	private CheckEdit _CheckEquipoMarcacion;

	public int CodHorario;

	internal ucTextBox UcTxtDescripcion
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtDescripcion;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtDescripcion = value;
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

	internal Label Label12
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label12 = value;
		}
	}

	internal Label Label11
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label11 = value;
		}
	}

	internal Label Label10
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label10 = value;
		}
	}

	internal Label Label9
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label9 = value;
		}
	}

	internal Button btnGrabar
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnGrabar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = btnGrabar_Click;
			if (_btnGrabar != null)
			{
				_btnGrabar.Click -= value2;
			}
			_btnGrabar = value;
			if (_btnGrabar != null)
			{
				_btnGrabar.Click += value2;
			}
		}
	}

	internal TextEdit Txt_HE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Txt_HE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Txt_HE = value;
		}
	}

	internal TextEdit Txt_SR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Txt_SR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Txt_SR = value;
		}
	}

	internal TextEdit Txt_ER
	{
		[DebuggerNonUserCode]
		get
		{
			return _Txt_ER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Txt_ER = value;
		}
	}

	internal TextEdit Txt_HS
	{
		[DebuggerNonUserCode]
		get
		{
			return _Txt_HS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Txt_HS = value;
		}
	}

	internal CheckEdit CheckEquipoMarcacion
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckEquipoMarcacion;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CheckEquipoMarcacion = value;
		}
	}

	[DebuggerNonUserCode]
	public FrmMantHorarios()
	{
		base.Load += FrmMantHorarios_Load;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecursosHumanos.FrmMantHorarios));
		this.UcTxtDescripcion = new GRLL.Common.ucTextBox(this.components);
		this.Label1 = new System.Windows.Forms.Label();
		this.CheckEdit1 = new DevExpress.XtraEditors.CheckEdit();
		this.Label12 = new System.Windows.Forms.Label();
		this.Label11 = new System.Windows.Forms.Label();
		this.Label10 = new System.Windows.Forms.Label();
		this.Label9 = new System.Windows.Forms.Label();
		this.btnGrabar = new System.Windows.Forms.Button();
		this.Txt_HE = new DevExpress.XtraEditors.TextEdit();
		this.Txt_SR = new DevExpress.XtraEditors.TextEdit();
		this.Txt_ER = new DevExpress.XtraEditors.TextEdit();
		this.Txt_HS = new DevExpress.XtraEditors.TextEdit();
		this.CheckEquipoMarcacion = new DevExpress.XtraEditors.CheckEdit();
		((System.ComponentModel.ISupportInitialize)this.CheckEdit1.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.Txt_HE.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.Txt_SR.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.Txt_ER.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.Txt_HS.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.CheckEquipoMarcacion.Properties).BeginInit();
		this.SuspendLayout();
		this.cmdCerrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.cmdCerrar.AutoSize = true;
		this.cmdCerrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.cmdCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cmdCerrar.FlatAppearance.BorderSize = 0;
		this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.cmdCerrar.Image = RecursosHumanos.My.Resources.Resources._exit;
		System.Windows.Forms.Button button = this.cmdCerrar;
		System.Drawing.Point location = new System.Drawing.Point(230, 202);
		button.Location = location;
		System.Windows.Forms.Button button2 = this.cmdCerrar;
		System.Drawing.Size size = new System.Drawing.Size(61, 23);
		button2.Size = size;
		this.cmdCerrar.TabIndex = 8;
		this.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		System.Windows.Forms.Panel panelSup = this.PanelSup;
		size = new System.Drawing.Size(303, 29);
		panelSup.Size = size;
		System.Windows.Forms.Panel panelInf = this.PanelInf;
		location = new System.Drawing.Point(0, 231);
		panelInf.Location = location;
		System.Windows.Forms.Panel panelInf2 = this.PanelInf;
		size = new System.Drawing.Size(303, 27);
		panelInf2.Size = size;
		this.UcTxtDescripcion.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtDescripcion.Formato = null;
		this.UcTxtDescripcion.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtDescripcion = this.UcTxtDescripcion;
		location = new System.Drawing.Point(95, 41);
		ucTxtDescripcion.Location = location;
		this.UcTxtDescripcion.Name = "UcTxtDescripcion";
		this.UcTxtDescripcion.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtDescripcion.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtDescripcion.OnErrorBlankText = "";
		this.UcTxtDescripcion.PadLeftLenght = 0;
		this.UcTxtDescripcion.RegularExpression = "^[A-Z,a-z,\\s]+$";
		this.UcTxtDescripcion.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtDescripcion.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtDescripcion2 = this.UcTxtDescripcion;
		size = new System.Drawing.Size(193, 20);
		ucTxtDescripcion2.Size = size;
		this.UcTxtDescripcion.TabIndex = 1;
		this.UcTxtDescripcion.TabNextControl = false;
		this.UcTxtDescripcion.Tipo = GRLL.Common.ucTextBox.TipoDato.SoloLetras;
		this.Label1.AutoSize = true;
		System.Windows.Forms.Label label = this.Label1;
		location = new System.Drawing.Point(23, 44);
		label.Location = location;
		this.Label1.Name = "Label1";
		System.Windows.Forms.Label label2 = this.Label1;
		size = new System.Drawing.Size(66, 13);
		label2.Size = size;
		this.Label1.TabIndex = 0;
		this.Label1.Text = "Descripción:";
		DevExpress.XtraEditors.CheckEdit checkEdit = this.CheckEdit1;
		location = new System.Drawing.Point(229, 145);
		checkEdit.Location = location;
		this.CheckEdit1.Name = "CheckEdit1";
		this.CheckEdit1.Properties.Caption = "Activo";
		DevExpress.XtraEditors.CheckEdit checkEdit2 = this.CheckEdit1;
		size = new System.Drawing.Size(59, 18);
		checkEdit2.Size = size;
		this.CheckEdit1.TabIndex = 6;
		this.Label12.AutoSize = true;
		System.Windows.Forms.Label label3 = this.Label12;
		location = new System.Drawing.Point(16, 96);
		label3.Location = location;
		this.Label12.Name = "Label12";
		System.Windows.Forms.Label label4 = this.Label12;
		size = new System.Drawing.Size(73, 13);
		label4.Size = size;
		this.Label12.TabIndex = 10;
		this.Label12.Text = "Salida Refrig.:";
		this.Label11.AutoSize = true;
		System.Windows.Forms.Label label5 = this.Label11;
		location = new System.Drawing.Point(8, 122);
		label5.Location = location;
		this.Label11.Name = "Label11";
		System.Windows.Forms.Label label6 = this.Label11;
		size = new System.Drawing.Size(81, 13);
		label6.Size = size;
		this.Label11.TabIndex = 11;
		this.Label11.Text = "Entrada Refrig::";
		this.Label10.AutoSize = true;
		System.Windows.Forms.Label label7 = this.Label10;
		location = new System.Drawing.Point(24, 148);
		label7.Location = location;
		this.Label10.Name = "Label10";
		System.Windows.Forms.Label label8 = this.Label10;
		size = new System.Drawing.Size(65, 13);
		label8.Size = size;
		this.Label10.TabIndex = 12;
		this.Label10.Text = "Hora Salida:";
		this.Label9.AutoSize = true;
		System.Windows.Forms.Label label9 = this.Label9;
		location = new System.Drawing.Point(16, 70);
		label9.Location = location;
		this.Label9.Name = "Label9";
		System.Windows.Forms.Label label10 = this.Label9;
		size = new System.Drawing.Size(73, 13);
		label10.Size = size;
		this.Label9.TabIndex = 9;
		this.Label9.Text = "Hora Entrada:";
		this.btnGrabar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.btnGrabar.AutoSize = true;
		this.btnGrabar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.btnGrabar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnGrabar.FlatAppearance.BorderSize = 0;
		this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnGrabar.Image = (System.Drawing.Image)resources.GetObject("btnGrabar.Image");
		System.Windows.Forms.Button button3 = this.btnGrabar;
		location = new System.Drawing.Point(12, 202);
		button3.Location = location;
		this.btnGrabar.Name = "btnGrabar";
		System.Windows.Forms.Button button4 = this.btnGrabar;
		size = new System.Drawing.Size(65, 23);
		button4.Size = size;
		this.btnGrabar.TabIndex = 7;
		this.btnGrabar.Text = "Grabar";
		this.btnGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.btnGrabar.UseVisualStyleBackColor = true;
		DevExpress.XtraEditors.TextEdit txt_HE = this.Txt_HE;
		location = new System.Drawing.Point(95, 67);
		txt_HE.Location = location;
		this.Txt_HE.Name = "Txt_HE";
		this.Txt_HE.Properties.Mask.BeepOnError = true;
		this.Txt_HE.Properties.Mask.EditMask = "90:00:00";
		this.Txt_HE.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
		DevExpress.XtraEditors.TextEdit txt_HE2 = this.Txt_HE;
		size = new System.Drawing.Size(66, 20);
		txt_HE2.Size = size;
		this.Txt_HE.TabIndex = 2;
		DevExpress.XtraEditors.TextEdit txt_SR = this.Txt_SR;
		location = new System.Drawing.Point(95, 93);
		txt_SR.Location = location;
		this.Txt_SR.Name = "Txt_SR";
		this.Txt_SR.Properties.Mask.BeepOnError = true;
		this.Txt_SR.Properties.Mask.EditMask = "90:00:00";
		this.Txt_SR.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
		DevExpress.XtraEditors.TextEdit txt_SR2 = this.Txt_SR;
		size = new System.Drawing.Size(66, 20);
		txt_SR2.Size = size;
		this.Txt_SR.TabIndex = 3;
		DevExpress.XtraEditors.TextEdit txt_ER = this.Txt_ER;
		location = new System.Drawing.Point(95, 119);
		txt_ER.Location = location;
		this.Txt_ER.Name = "Txt_ER";
		this.Txt_ER.Properties.Mask.BeepOnError = true;
		this.Txt_ER.Properties.Mask.EditMask = "90:00:00";
		this.Txt_ER.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
		DevExpress.XtraEditors.TextEdit txt_ER2 = this.Txt_ER;
		size = new System.Drawing.Size(66, 20);
		txt_ER2.Size = size;
		this.Txt_ER.TabIndex = 4;
		DevExpress.XtraEditors.TextEdit txt_HS = this.Txt_HS;
		location = new System.Drawing.Point(95, 145);
		txt_HS.Location = location;
		this.Txt_HS.Name = "Txt_HS";
		this.Txt_HS.Properties.Mask.BeepOnError = true;
		this.Txt_HS.Properties.Mask.EditMask = "90:00:00";
		this.Txt_HS.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
		DevExpress.XtraEditors.TextEdit txt_HS2 = this.Txt_HS;
		size = new System.Drawing.Size(66, 20);
		txt_HS2.Size = size;
		this.Txt_HS.TabIndex = 5;
		this.CheckEquipoMarcacion.EditValue = true;
		DevExpress.XtraEditors.CheckEdit checkEquipoMarcacion = this.CheckEquipoMarcacion;
		location = new System.Drawing.Point(12, 176);
		checkEquipoMarcacion.Location = location;
		this.CheckEquipoMarcacion.Name = "CheckEquipoMarcacion";
		this.CheckEquipoMarcacion.Properties.Caption = "Actualizar Equipo Marcacion";
		DevExpress.XtraEditors.CheckEdit checkEquipoMarcacion2 = this.CheckEquipoMarcacion;
		size = new System.Drawing.Size(169, 18);
		checkEquipoMarcacion2.Size = size;
		this.CheckEquipoMarcacion.TabIndex = 13;
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.Calculadora = false;
		size = new System.Drawing.Size(303, 258);
		this.ClientSize = size;
		this.Controls.Add(this.CheckEquipoMarcacion);
		this.Controls.Add(this.Txt_HS);
		this.Controls.Add(this.Txt_ER);
		this.Controls.Add(this.Txt_SR);
		this.Controls.Add(this.Txt_HE);
		this.Controls.Add(this.btnGrabar);
		this.Controls.Add(this.Label12);
		this.Controls.Add(this.Label11);
		this.Controls.Add(this.Label10);
		this.Controls.Add(this.Label9);
		this.Controls.Add(this.CheckEdit1);
		this.Controls.Add(this.Label1);
		this.Controls.Add(this.UcTxtDescripcion);
		this.MessageShow = true;
		this.Name = "FrmMantHorarios";
		this.TitleMsg = "FrmConsulta";
		this.Titulo = "Horarios";
		this.VerCmdCerrar = true;
		this.Controls.SetChildIndex(this.UcTxtDescripcion, 0);
		this.Controls.SetChildIndex(this.Label1, 0);
		this.Controls.SetChildIndex(this.CheckEdit1, 0);
		this.Controls.SetChildIndex(this.cmdCerrar, 0);
		this.Controls.SetChildIndex(this.Label9, 0);
		this.Controls.SetChildIndex(this.PanelSup, 0);
		this.Controls.SetChildIndex(this.Label10, 0);
		this.Controls.SetChildIndex(this.PanelInf, 0);
		this.Controls.SetChildIndex(this.Label11, 0);
		this.Controls.SetChildIndex(this.Label12, 0);
		this.Controls.SetChildIndex(this.btnGrabar, 0);
		this.Controls.SetChildIndex(this.Txt_HE, 0);
		this.Controls.SetChildIndex(this.Txt_SR, 0);
		this.Controls.SetChildIndex(this.Txt_ER, 0);
		this.Controls.SetChildIndex(this.Txt_HS, 0);
		this.Controls.SetChildIndex(this.CheckEquipoMarcacion, 0);
		((System.ComponentModel.ISupportInitialize)this.CheckEdit1.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.Txt_HE.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.Txt_SR.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.Txt_ER.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.Txt_HS.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.CheckEquipoMarcacion.Properties).EndInit();
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	private void FrmMantHorarios_Load(object sender, EventArgs e)
	{
		if (CodHorario != 0)
		{
			Horario horario = HorarioMapper.Instance().SelectBy([SpecialName] (Horario h) => h.idHorario == CodHorario).First();
			UcTxtDescripcion.Text = horario.Descrip_Horario;
			CheckEdit1.EditValue = horario.Estado;
			Txt_HE.Text = horario.Ingreso1;
			Txt_HS.Text = horario.Salida2;
			Txt_SR.Text = horario.Salida1;
			Txt_ER.Text = horario.Ingreso2;
		}
	}

	private void btnGrabar_Click(object sender, EventArgs e)
	{
		if ((Txt_HE.Text.Length == 0) | (Txt_HS.Text.Length == 0) | (Txt_SR.Text.Length == 0) | (Txt_ER.Text.Length == 0))
		{
			MessageBox.Show("Debe Ingresar un Horario Válido", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		Horario horario = new Horario();
		horario.Descrip_Horario = UcTxtDescripcion.Text.Trim();
		object editValue = CheckEdit1.EditValue;
		bool? flag = default(bool?);
		horario.Estado = ((editValue != null) ? ((bool?)editValue) : flag);
		horario.Ingreso1 = Txt_HE.Text.Trim();
		horario.Salida2 = Txt_HS.Text.Trim();
		horario.Salida1 = Txt_SR.Text.Trim();
		horario.Ingreso2 = Txt_ER.Text.Trim();
		if (CodHorario == 0)
		{
			int idHorario;
			if (HorarioMapper.Instance().SelectAll().Count == 0)
			{
				idHorario = 1;
			}
			else
			{
				idHorario = HorarioMapper.Instance().SelectAll().Max([SpecialName] (Horario v) => v.idHorario);
				idHorario = checked(idHorario + 1);
			}
			horario.idHorario = idHorario;
			HorarioMapper.Instance().Insert(horario);
			if (CheckEquipoMarcacion.CheckState == CheckState.Checked)
			{
				AsistenciaAccess asistenciaAccess = new AsistenciaAccess();
			}
		}
		else
		{
			horario.idHorario = CodHorario;
			HorarioMapper.Instance().Update(horario);
		}
		DialogResult = DialogResult.OK;
	}
}
