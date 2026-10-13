using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using GRLL.Common;
using Microsoft.VisualBasic.CompilerServices;
using RecursosHumanos.My.Resources;

namespace RecursosHumanos;

[DesignerGenerated]
public class FrmPeriodoLaboral : FrmConsulta
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("btnGrabar")]
	private Button _btnGrabar;

	[AccessedThroughProperty("UcTxtResoIngreInsti")]
	private ucTextBox _UcTxtResoIngreInsti;

	[AccessedThroughProperty("Label56")]
	private Label _Label56;

	[AccessedThroughProperty("UcDTFechaResolIngreInsti")]
	private ucDateTime _UcDTFechaResolIngreInsti;

	[AccessedThroughProperty("UcDTIngresoInst")]
	private ucDateTime _UcDTIngresoInst;

	[AccessedThroughProperty("Label59")]
	private Label _Label59;

	[AccessedThroughProperty("Label29")]
	private Label _Label29;

	[AccessedThroughProperty("CheckEdit1")]
	private CheckEdit _CheckEdit1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("UcDateTime1")]
	private ucDateTime _UcDateTime1;

	[AccessedThroughProperty("CheckEdit2")]
	private CheckEdit _CheckEdit2;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("UcTextBox1")]
	private ucTextBox _UcTextBox1;

	public int CodEmple;

	public int nro;

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

	internal ucTextBox UcTxtResoIngreInsti
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtResoIngreInsti;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtResoIngreInsti = value;
		}
	}

	internal Label Label56
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label56;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label56 = value;
		}
	}

	internal ucDateTime UcDTFechaResolIngreInsti
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcDTFechaResolIngreInsti;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcDTFechaResolIngreInsti = value;
		}
	}

	internal ucDateTime UcDTIngresoInst
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcDTIngresoInst;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcDTIngresoInst = value;
		}
	}

	internal Label Label59
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label59;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label59 = value;
		}
	}

	internal Label Label29
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label29;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label29 = value;
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
			EventHandler value2 = CheckEdit1_CheckedChanged;
			if (_CheckEdit1 != null)
			{
				_CheckEdit1.CheckedChanged -= value2;
			}
			_CheckEdit1 = value;
			if (_CheckEdit1 != null)
			{
				_CheckEdit1.CheckedChanged += value2;
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

	internal CheckEdit CheckEdit2
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckEdit2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CheckEdit2 = value;
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

	[DebuggerNonUserCode]
	public FrmPeriodoLaboral()
	{
		base.Load += FrmPeriodoLaboral_Load;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecursosHumanos.FrmPeriodoLaboral));
		this.btnGrabar = new System.Windows.Forms.Button();
		this.UcTxtResoIngreInsti = new GRLL.Common.ucTextBox(this.components);
		this.Label56 = new System.Windows.Forms.Label();
		this.UcDTFechaResolIngreInsti = new GRLL.Common.ucDateTime();
		this.UcDTIngresoInst = new GRLL.Common.ucDateTime();
		this.Label59 = new System.Windows.Forms.Label();
		this.Label29 = new System.Windows.Forms.Label();
		this.CheckEdit1 = new DevExpress.XtraEditors.CheckEdit();
		this.Label1 = new System.Windows.Forms.Label();
		this.UcDateTime1 = new GRLL.Common.ucDateTime();
		this.CheckEdit2 = new DevExpress.XtraEditors.CheckEdit();
		this.Label2 = new System.Windows.Forms.Label();
		this.UcTextBox1 = new GRLL.Common.ucTextBox(this.components);
		((System.ComponentModel.ISupportInitialize)this.CheckEdit1.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.CheckEdit2.Properties).BeginInit();
		this.SuspendLayout();
		this.cmdCerrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.cmdCerrar.AutoSize = true;
		this.cmdCerrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.cmdCerrar.FlatAppearance.BorderSize = 0;
		this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.cmdCerrar.Image = RecursosHumanos.My.Resources.Resources._exit;
		System.Windows.Forms.Button button = this.cmdCerrar;
		System.Drawing.Point location = new System.Drawing.Point(426, 202);
		button.Location = location;
		System.Windows.Forms.Button button2 = this.cmdCerrar;
		System.Drawing.Size size = new System.Drawing.Size(61, 23);
		button2.Size = size;
		this.cmdCerrar.TabIndex = 9;
		this.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		System.Windows.Forms.Panel panelSup = this.PanelSup;
		size = new System.Drawing.Size(499, 29);
		panelSup.Size = size;
		System.Windows.Forms.Panel panelInf = this.PanelInf;
		location = new System.Drawing.Point(0, 231);
		panelInf.Location = location;
		System.Windows.Forms.Panel panelInf2 = this.PanelInf;
		size = new System.Drawing.Size(499, 27);
		panelInf2.Size = size;
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
		this.btnGrabar.TabIndex = 8;
		this.btnGrabar.Text = "Grabar";
		this.btnGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.btnGrabar.UseVisualStyleBackColor = true;
		this.UcTxtResoIngreInsti.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtResoIngreInsti.Formato = null;
		this.UcTxtResoIngreInsti.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtResoIngreInsti = this.UcTxtResoIngreInsti;
		location = new System.Drawing.Point(204, 69);
		ucTxtResoIngreInsti.Location = location;
		this.UcTxtResoIngreInsti.MaxLength = 30;
		this.UcTxtResoIngreInsti.Name = "UcTxtResoIngreInsti";
		this.UcTxtResoIngreInsti.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtResoIngreInsti.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtResoIngreInsti.OnErrorBlankText = "";
		this.UcTxtResoIngreInsti.PadLeftLenght = 0;
		this.UcTxtResoIngreInsti.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtResoIngreInsti.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtResoIngreInsti2 = this.UcTxtResoIngreInsti;
		size = new System.Drawing.Size(205, 20);
		ucTxtResoIngreInsti2.Size = size;
		this.UcTxtResoIngreInsti.TabIndex = 2;
		this.UcTxtResoIngreInsti.TabNextControl = true;
		this.UcTxtResoIngreInsti.Tipo = GRLL.Common.ucTextBox.TipoDato.Todos;
		this.Label56.AutoSize = true;
		System.Windows.Forms.Label label = this.Label56;
		location = new System.Drawing.Point(11, 72);
		label.Location = location;
		this.Label56.Name = "Label56";
		System.Windows.Forms.Label label2 = this.Label56;
		size = new System.Drawing.Size(187, 13);
		label2.Size = size;
		this.Label56.TabIndex = 31;
		this.Label56.Text = "N° Resolución Ingreso a la Institución:";
		this.UcDTFechaResolIngreInsti.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcDTFechaResolIngreInsti.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucDateTime ucDTFechaResolIngreInsti = this.UcDTFechaResolIngreInsti;
		location = new System.Drawing.Point(204, 95);
		ucDTFechaResolIngreInsti.Location = location;
		this.UcDTFechaResolIngreInsti.Name = "UcDTFechaResolIngreInsti";
		GRLL.Common.ucDateTime ucDTFechaResolIngreInsti2 = this.UcDTFechaResolIngreInsti;
		size = new System.Drawing.Size(205, 20);
		ucDTFechaResolIngreInsti2.Size = size;
		this.UcDTFechaResolIngreInsti.TabIndex = 4;
		this.UcDTIngresoInst.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcDTIngresoInst.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucDateTime ucDTIngresoInst = this.UcDTIngresoInst;
		location = new System.Drawing.Point(204, 43);
		ucDTIngresoInst.Location = location;
		this.UcDTIngresoInst.Name = "UcDTIngresoInst";
		GRLL.Common.ucDateTime ucDTIngresoInst2 = this.UcDTIngresoInst;
		size = new System.Drawing.Size(205, 20);
		ucDTIngresoInst2.Size = size;
		this.UcDTIngresoInst.TabIndex = 1;
		this.Label59.AutoSize = true;
		System.Windows.Forms.Label label3 = this.Label59;
		location = new System.Drawing.Point(16, 99);
		label3.Location = location;
		this.Label59.Name = "Label59";
		System.Windows.Forms.Label label4 = this.Label59;
		size = new System.Drawing.Size(182, 13);
		label4.Size = size;
		this.Label59.TabIndex = 36;
		this.Label59.Text = "Fecha Resol. Ingreso a la Institución:";
		this.Label29.AutoSize = true;
		System.Windows.Forms.Label label5 = this.Label29;
		location = new System.Drawing.Point(49, 47);
		label5.Location = location;
		this.Label29.Name = "Label29";
		System.Windows.Forms.Label label6 = this.Label29;
		size = new System.Drawing.Size(149, 13);
		label6.Size = size;
		this.Label29.TabIndex = 35;
		this.Label29.Text = "Fecha Ingreso a la Institución:";
		DevExpress.XtraEditors.CheckEdit checkEdit = this.CheckEdit1;
		location = new System.Drawing.Point(415, 125);
		checkEdit.Location = location;
		this.CheckEdit1.Name = "CheckEdit1";
		this.CheckEdit1.Properties.AutoWidth = true;
		this.CheckEdit1.Properties.Caption = "Activar";
		DevExpress.XtraEditors.CheckEdit checkEdit2 = this.CheckEdit1;
		size = new System.Drawing.Size(54, 18);
		checkEdit2.Size = size;
		this.CheckEdit1.TabIndex = 6;
		this.Label1.AutoSize = true;
		System.Windows.Forms.Label label7 = this.Label1;
		location = new System.Drawing.Point(43, 128);
		label7.Location = location;
		this.Label1.Name = "Label1";
		System.Windows.Forms.Label label8 = this.Label1;
		size = new System.Drawing.Size(155, 13);
		label8.Size = size;
		this.Label1.TabIndex = 35;
		this.Label1.Text = "Fin de Periodo en la Institución:";
		this.UcDateTime1.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcDateTime1.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcDateTime1.Enabled = false;
		GRLL.Common.ucDateTime ucDateTime = this.UcDateTime1;
		location = new System.Drawing.Point(204, 124);
		ucDateTime.Location = location;
		this.UcDateTime1.Name = "UcDateTime1";
		GRLL.Common.ucDateTime ucDateTime2 = this.UcDateTime1;
		size = new System.Drawing.Size(205, 20);
		ucDateTime2.Size = size;
		this.UcDateTime1.TabIndex = 5;
		DevExpress.XtraEditors.CheckEdit checkEdit3 = this.CheckEdit2;
		location = new System.Drawing.Point(415, 69);
		checkEdit3.Location = location;
		this.CheckEdit2.Name = "CheckEdit2";
		this.CheckEdit2.Properties.Caption = "Es Judicial?";
		DevExpress.XtraEditors.CheckEdit checkEdit4 = this.CheckEdit2;
		size = new System.Drawing.Size(75, 18);
		checkEdit4.Size = size;
		this.CheckEdit2.TabIndex = 3;
		this.Label2.AutoSize = true;
		System.Windows.Forms.Label label9 = this.Label2;
		location = new System.Drawing.Point(12, 153);
		label9.Location = location;
		this.Label2.Name = "Label2";
		System.Windows.Forms.Label label10 = this.Label2;
		size = new System.Drawing.Size(70, 13);
		label10.Size = size;
		this.Label2.TabIndex = 35;
		this.Label2.Text = "Observación:";
		this.UcTextBox1.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTextBox1.Formato = null;
		this.UcTextBox1.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTextBox = this.UcTextBox1;
		location = new System.Drawing.Point(88, 150);
		ucTextBox.Location = location;
		this.UcTextBox1.MaxLength = 2000;
		this.UcTextBox1.Multiline = true;
		this.UcTextBox1.Name = "UcTextBox1";
		this.UcTextBox1.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTextBox1.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTextBox1.OnErrorBlankText = "";
		this.UcTextBox1.PadLeftLenght = 0;
		this.UcTextBox1.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTextBox1.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTextBox2 = this.UcTextBox1;
		size = new System.Drawing.Size(399, 38);
		ucTextBox2.Size = size;
		this.UcTextBox1.TabIndex = 7;
		this.UcTextBox1.TabNextControl = false;
		this.UcTextBox1.Tipo = GRLL.Common.ucTextBox.TipoDato.Todos;
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		size = new System.Drawing.Size(499, 258);
		this.ClientSize = size;
		this.Controls.Add(this.UcTextBox1);
		this.Controls.Add(this.CheckEdit2);
		this.Controls.Add(this.CheckEdit1);
		this.Controls.Add(this.UcTxtResoIngreInsti);
		this.Controls.Add(this.Label56);
		this.Controls.Add(this.UcDTFechaResolIngreInsti);
		this.Controls.Add(this.UcDateTime1);
		this.Controls.Add(this.UcDTIngresoInst);
		this.Controls.Add(this.Label59);
		this.Controls.Add(this.Label2);
		this.Controls.Add(this.Label1);
		this.Controls.Add(this.Label29);
		this.Controls.Add(this.btnGrabar);
		this.MessageShow = true;
		this.Name = "FrmPeriodoLaboral";
		this.TitleMsg = "FrmConsulta";
		this.Titulo = "Periodo Laboral";
		this.VerCmdCerrar = true;
		this.Controls.SetChildIndex(this.cmdCerrar, 0);
		this.Controls.SetChildIndex(this.PanelSup, 0);
		this.Controls.SetChildIndex(this.PanelInf, 0);
		this.Controls.SetChildIndex(this.btnGrabar, 0);
		this.Controls.SetChildIndex(this.Label29, 0);
		this.Controls.SetChildIndex(this.Label1, 0);
		this.Controls.SetChildIndex(this.Label2, 0);
		this.Controls.SetChildIndex(this.Label59, 0);
		this.Controls.SetChildIndex(this.UcDTIngresoInst, 0);
		this.Controls.SetChildIndex(this.UcDateTime1, 0);
		this.Controls.SetChildIndex(this.UcDTFechaResolIngreInsti, 0);
		this.Controls.SetChildIndex(this.Label56, 0);
		this.Controls.SetChildIndex(this.UcTxtResoIngreInsti, 0);
		this.Controls.SetChildIndex(this.CheckEdit1, 0);
		this.Controls.SetChildIndex(this.CheckEdit2, 0);
		this.Controls.SetChildIndex(this.UcTextBox1, 0);
		((System.ComponentModel.ISupportInitialize)this.CheckEdit1.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.CheckEdit2.Properties).EndInit();
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	private void btnGrabar_Click(object sender, EventArgs e)
	{
		PeriodoLaboral periodoLaboral = new PeriodoLaboral();
		periodoLaboral.IdEmpleado = CodEmple;
		periodoLaboral.FechaIngreso = UcDTIngresoInst.Value;
		periodoLaboral.FechaResoIngreInstitu = UcDTFechaResolIngreInsti.Value;
		periodoLaboral.FechaSalida = UcDateTime1.Value;
		object editValue = CheckEdit2.EditValue;
		bool? flag = default(bool?);
		periodoLaboral.Judicial = ((editValue != null) ? ((bool?)editValue) : flag);
		periodoLaboral.NumResoIngreInstitu = UcTxtResoIngreInsti.Text.Trim();
		periodoLaboral.Obs = UcTextBox1.Text.Trim();
		if (nro == 0)
		{
			List<PeriodoLaboral> list = PeriodoLaboralMapper.Instance().SelectBy([SpecialName] (PeriodoLaboral p) => p.IdEmpleado == CodEmple);
			int nroPeriodo = ((list.Count == 0) ? 1 : checked(((IEnumerable<PeriodoLaboral>)list).Max<PeriodoLaboral, int>((Func<PeriodoLaboral, int>)([SpecialName] (PeriodoLaboral y) => y.NroPeriodo)) + 1));
			periodoLaboral.NroPeriodo = nroPeriodo;
			PeriodoLaboralMapper.Instance().Insert(periodoLaboral);
		}
		else
		{
			periodoLaboral.NroPeriodo = nro;
			PeriodoLaboralMapper.Instance().Update(periodoLaboral);
		}
		DialogResult = DialogResult.OK;
	}

	private void FrmPeriodoLaboral_Load(object sender, EventArgs e)
	{
		if (nro != 0)
		{
			PeriodoLaboral periodoLaboral = PeriodoLaboralMapper.Instance().SelectBy([SpecialName] (PeriodoLaboral p) => (p.IdEmpleado == CodEmple) & (p.NroPeriodo == nro)).First();
			UcDTIngresoInst.Value = (DateTime)periodoLaboral.FechaIngreso;
			UcTxtResoIngreInsti.Text = periodoLaboral.NumResoIngreInstitu.ToString().Trim();
			if (!periodoLaboral.FechaResoIngreInstitu.HasValue)
			{
				UcDTFechaResolIngreInsti.Value = (DateTime)periodoLaboral.FechaResoIngreInstitu;
			}
			UcDTFechaResolIngreInsti.Value = (DateTime)periodoLaboral.FechaResoIngreInstitu;
			if (!periodoLaboral.FechaSalida.HasValue)
			{
				CheckEdit1.EditValue = false;
			}
			else
			{
				CheckEdit1.EditValue = true;
			}
			if (periodoLaboral.Judicial.HasValue)
			{
				CheckEdit2.EditValue = periodoLaboral.Judicial;
			}
			if (periodoLaboral.Obs != null)
			{
				UcTextBox1.Text = periodoLaboral.Obs.ToString().Trim();
			}
		}
	}

	private void CheckEdit1_CheckedChanged(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(CheckEdit1.EditValue, true, TextCompare: false))
		{
			UcDateTime1.Enabled = true;
		}
		else
		{
			UcDateTime1.Enabled = false;
		}
	}
}
