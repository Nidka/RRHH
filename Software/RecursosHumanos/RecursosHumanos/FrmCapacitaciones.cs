using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using GRLL.Common;
using Microsoft.VisualBasic.CompilerServices;

namespace RecursosHumanos;

[DesignerGenerated]
public class FrmCapacitaciones : FrmConsulta
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("UcTxtCurso")]
	private ucTextBox _UcTxtCurso;

	[AccessedThroughProperty("UcDTInicio")]
	private ucDateTime _UcDTInicio;

	[AccessedThroughProperty("UcDTTermino")]
	private ucDateTime _UcDTTermino;

	[AccessedThroughProperty("UcTxtHoras")]
	private ucTextBox _UcTxtHoras;

	[AccessedThroughProperty("UcTxtInstOrganiz")]
	private ucTextBox _UcTxtInstOrganiz;

	[AccessedThroughProperty("btnGrabar")]
	private Button _btnGrabar;

	public int codemple;

	private Capacitacion capacitacion;

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

	internal Label Label3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label3 = value;
		}
	}

	internal Label Label4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label4 = value;
		}
	}

	internal Label Label5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label5 = value;
		}
	}

	internal ucTextBox UcTxtCurso
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtCurso;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtCurso = value;
		}
	}

	internal ucDateTime UcDTInicio
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcDTInicio;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcDTInicio = value;
		}
	}

	internal ucDateTime UcDTTermino
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcDTTermino;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcDTTermino = value;
		}
	}

	internal ucTextBox UcTxtHoras
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtHoras;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtHoras = value;
		}
	}

	internal ucTextBox UcTxtInstOrganiz
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtInstOrganiz;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtInstOrganiz = value;
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

	public FrmCapacitaciones()
	{
		base.Load += FrmCapacitaciones_Load;
		__ENCAddToList(this);
		capacitacion = new Capacitacion();
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecursosHumanos.FrmCapacitaciones));
		this.Label1 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label5 = new System.Windows.Forms.Label();
		this.UcTxtCurso = new GRLL.Common.ucTextBox(this.components);
		this.UcDTInicio = new GRLL.Common.ucDateTime();
		this.UcDTTermino = new GRLL.Common.ucDateTime();
		this.UcTxtHoras = new GRLL.Common.ucTextBox(this.components);
		this.UcTxtInstOrganiz = new GRLL.Common.ucTextBox(this.components);
		this.btnGrabar = new System.Windows.Forms.Button();
		this.SuspendLayout();
		this.cmdCerrar.AutoSize = true;
		this.cmdCerrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.cmdCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cmdCerrar.FlatAppearance.BorderSize = 0;
		this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.cmdCerrar.Image = (System.Drawing.Image)resources.GetObject("cmdCerrar.Image");
		System.Windows.Forms.Button button = this.cmdCerrar;
		System.Drawing.Point location = new System.Drawing.Point(285, 178);
		button.Location = location;
		System.Windows.Forms.Button button2 = this.cmdCerrar;
		System.Drawing.Size size = new System.Drawing.Size(61, 23);
		button2.Size = size;
		this.cmdCerrar.TabIndex = 7;
		this.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.cmdCerrar.Visible = true;
		System.Windows.Forms.Panel panelSup = this.PanelSup;
		size = new System.Drawing.Size(358, 24);
		panelSup.Size = size;
		System.Windows.Forms.Panel panelInf = this.PanelInf;
		location = new System.Drawing.Point(0, 211);
		panelInf.Location = location;
		System.Windows.Forms.Panel panelInf2 = this.PanelInf;
		size = new System.Drawing.Size(358, 27);
		panelInf2.Size = size;
		this.Label1.AutoSize = true;
		System.Windows.Forms.Label label = this.Label1;
		location = new System.Drawing.Point(18, 42);
		label.Location = location;
		this.Label1.Name = "Label1";
		System.Windows.Forms.Label label2 = this.Label1;
		size = new System.Drawing.Size(94, 13);
		label2.Size = size;
		this.Label1.TabIndex = 3;
		this.Label1.Text = "Nombre del Curso:";
		this.Label2.AutoSize = true;
		System.Windows.Forms.Label label3 = this.Label2;
		location = new System.Drawing.Point(29, 95);
		label3.Location = location;
		this.Label2.Name = "Label2";
		System.Windows.Forms.Label label4 = this.Label2;
		size = new System.Drawing.Size(83, 13);
		label4.Size = size;
		this.Label2.TabIndex = 4;
		this.Label2.Text = "Fecha de Inicio:";
		this.Label3.AutoSize = true;
		System.Windows.Forms.Label label5 = this.Label3;
		location = new System.Drawing.Point(16, 122);
		label5.Location = location;
		this.Label3.Name = "Label3";
		System.Windows.Forms.Label label6 = this.Label3;
		size = new System.Drawing.Size(96, 13);
		label6.Size = size;
		this.Label3.TabIndex = 4;
		this.Label3.Text = "Fecha de Termino:";
		this.Label4.AutoSize = true;
		System.Windows.Forms.Label label7 = this.Label4;
		location = new System.Drawing.Point(14, 150);
		label7.Location = location;
		this.Label4.Name = "Label4";
		System.Windows.Forms.Label label8 = this.Label4;
		size = new System.Drawing.Size(98, 13);
		label8.Size = size;
		this.Label4.TabIndex = 5;
		this.Label4.Text = "Cantidad de Horas:";
		this.Label5.AutoSize = true;
		System.Windows.Forms.Label label9 = this.Label5;
		location = new System.Drawing.Point(16, 68);
		label9.Location = location;
		this.Label5.Name = "Label5";
		System.Windows.Forms.Label label10 = this.Label5;
		size = new System.Drawing.Size(96, 13);
		label10.Size = size;
		this.Label5.TabIndex = 6;
		this.Label5.Text = "Inst. Organizadora:";
		this.UcTxtCurso.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtCurso.Formato = null;
		this.UcTxtCurso.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtCurso = this.UcTxtCurso;
		location = new System.Drawing.Point(118, 39);
		ucTxtCurso.Location = location;
		this.UcTxtCurso.Name = "UcTxtCurso";
		this.UcTxtCurso.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtCurso.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtCurso.OnErrorBlankText = "";
		this.UcTxtCurso.PadLeftLenght = 0;
		this.UcTxtCurso.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtCurso.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtCurso2 = this.UcTxtCurso;
		size = new System.Drawing.Size(221, 20);
		ucTxtCurso2.Size = size;
		this.UcTxtCurso.TabIndex = 1;
		this.UcTxtCurso.TabNextControl = false;
		this.UcTxtCurso.Tipo = GRLL.Common.ucTextBox.TipoDato.Todos;
		this.UcDTInicio.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcDTInicio.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucDateTime ucDTInicio = this.UcDTInicio;
		location = new System.Drawing.Point(118, 91);
		ucDTInicio.Location = location;
		this.UcDTInicio.Name = "UcDTInicio";
		GRLL.Common.ucDateTime ucDTInicio2 = this.UcDTInicio;
		size = new System.Drawing.Size(200, 20);
		ucDTInicio2.Size = size;
		this.UcDTInicio.TabIndex = 3;
		this.UcDTTermino.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcDTTermino.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucDateTime ucDTTermino = this.UcDTTermino;
		location = new System.Drawing.Point(118, 117);
		ucDTTermino.Location = location;
		this.UcDTTermino.Name = "UcDTTermino";
		GRLL.Common.ucDateTime ucDTTermino2 = this.UcDTTermino;
		size = new System.Drawing.Size(200, 20);
		ucDTTermino2.Size = size;
		this.UcDTTermino.TabIndex = 4;
		this.UcTxtHoras.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtHoras.Formato = null;
		this.UcTxtHoras.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtHoras = this.UcTxtHoras;
		location = new System.Drawing.Point(118, 147);
		ucTxtHoras.Location = location;
		this.UcTxtHoras.Name = "UcTxtHoras";
		this.UcTxtHoras.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtHoras.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtHoras.OnErrorBlankText = "";
		this.UcTxtHoras.PadLeftLenght = 0;
		this.UcTxtHoras.RegularExpression = "(^\\d*\\.?\\d*[0-9]+\\d*$)|(^[0-9]+\\d*\\.\\d*$)";
		this.UcTxtHoras.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtHoras.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtHoras2 = this.UcTxtHoras;
		size = new System.Drawing.Size(46, 20);
		ucTxtHoras2.Size = size;
		this.UcTxtHoras.TabIndex = 5;
		this.UcTxtHoras.TabNextControl = false;
		this.UcTxtHoras.Tipo = GRLL.Common.ucTextBox.TipoDato.Decimales;
		this.UcTxtInstOrganiz.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtInstOrganiz.Formato = null;
		this.UcTxtInstOrganiz.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtInstOrganiz = this.UcTxtInstOrganiz;
		location = new System.Drawing.Point(118, 65);
		ucTxtInstOrganiz.Location = location;
		this.UcTxtInstOrganiz.Name = "UcTxtInstOrganiz";
		this.UcTxtInstOrganiz.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtInstOrganiz.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtInstOrganiz.OnErrorBlankText = "";
		this.UcTxtInstOrganiz.PadLeftLenght = 0;
		this.UcTxtInstOrganiz.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtInstOrganiz.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtInstOrganiz2 = this.UcTxtInstOrganiz;
		size = new System.Drawing.Size(221, 20);
		ucTxtInstOrganiz2.Size = size;
		this.UcTxtInstOrganiz.TabIndex = 2;
		this.UcTxtInstOrganiz.TabNextControl = false;
		this.UcTxtInstOrganiz.Tipo = GRLL.Common.ucTextBox.TipoDato.Todos;
		this.btnGrabar.AutoSize = true;
		this.btnGrabar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.btnGrabar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnGrabar.FlatAppearance.BorderSize = 0;
		this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnGrabar.Image = (System.Drawing.Image)resources.GetObject("btnGrabar.Image");
		System.Windows.Forms.Button button3 = this.btnGrabar;
		location = new System.Drawing.Point(12, 178);
		button3.Location = location;
		this.btnGrabar.Name = "btnGrabar";
		System.Windows.Forms.Button button4 = this.btnGrabar;
		size = new System.Drawing.Size(65, 23);
		button4.Size = size;
		this.btnGrabar.TabIndex = 6;
		this.btnGrabar.Text = "Grabar";
		this.btnGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.btnGrabar.UseVisualStyleBackColor = true;
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.Calculadora = false;
		size = new System.Drawing.Size(358, 238);
		this.ClientSize = size;
		this.Controls.Add(this.btnGrabar);
		this.Controls.Add(this.Label1);
		this.Controls.Add(this.UcTxtCurso);
		this.Controls.Add(this.UcDTInicio);
		this.Controls.Add(this.UcDTTermino);
		this.Controls.Add(this.UcTxtInstOrganiz);
		this.Controls.Add(this.UcTxtHoras);
		this.Controls.Add(this.Label3);
		this.Controls.Add(this.Label2);
		this.Controls.Add(this.Label4);
		this.Controls.Add(this.Label5);
		this.MessageShow = true;
		this.Name = "FrmCapacitaciones";
		this.TitleMsg = "FrmConsulta";
		this.Titulo = "Capacitaciones";
		this.VerCmdCerrar = true;
		this.Controls.SetChildIndex(this.cmdCerrar, 0);
		this.Controls.SetChildIndex(this.Label5, 0);
		this.Controls.SetChildIndex(this.Label4, 0);
		this.Controls.SetChildIndex(this.Label2, 0);
		this.Controls.SetChildIndex(this.Label3, 0);
		this.Controls.SetChildIndex(this.UcTxtHoras, 0);
		this.Controls.SetChildIndex(this.UcTxtInstOrganiz, 0);
		this.Controls.SetChildIndex(this.UcDTTermino, 0);
		this.Controls.SetChildIndex(this.UcDTInicio, 0);
		this.Controls.SetChildIndex(this.UcTxtCurso, 0);
		this.Controls.SetChildIndex(this.Label1, 0);
		this.Controls.SetChildIndex(this.PanelSup, 0);
		this.Controls.SetChildIndex(this.PanelInf, 0);
		this.Controls.SetChildIndex(this.btnGrabar, 0);
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	private void FrmCapacitaciones_Load(object sender, EventArgs e)
	{
	}

	private void btnGrabar_Click(object sender, EventArgs e)
	{
		int idCapacitacion;
		if (CapacitacionMapper.Instance().SelectAll().Count == 0)
		{
			idCapacitacion = 1;
		}
		else
		{
			idCapacitacion = CapacitacionMapper.Instance().SelectAll().Max([SpecialName] (Capacitacion v) => v.IdCapacitacion);
			idCapacitacion = checked(idCapacitacion + 1);
		}
		capacitacion.FechaFin = UcDTTermino.Value;
		capacitacion.FechaInicio = UcDTInicio.Value;
		capacitacion.IdEmpleado = codemple;
		capacitacion.IdCapacitacion = idCapacitacion;
		if (UcTxtCurso.TextLength == 0)
		{
			MessageBox.Show("Debe Ingresar el Nombre del Curso y/o Capacitación", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			UcTxtCurso.Focus();
			return;
		}
		capacitacion.NombreCurso = UcTxtCurso.Text;
		if (UcTxtInstOrganiz.TextLength == 0)
		{
			MessageBox.Show("Debe Ingresar el Nombre de la Institucion Organizadora", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			UcTxtInstOrganiz.Focus();
			return;
		}
		capacitacion.InstitucionOrganizadora = UcTxtInstOrganiz.Text;
		if (UcTxtHoras.TextLength == 0)
		{
			MessageBox.Show("Debe Ingresar el Número total de horas", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			UcTxtHoras.Focus();
		}
		else
		{
			capacitacion.NumHoras = UcTxtHoras.Text;
			CapacitacionMapper.Instance().Insert(capacitacion);
			DialogResult = DialogResult.OK;
		}
	}

	private void BtnCerrar_Click(object sender, EventArgs e)
	{
		Close();
	}
}
