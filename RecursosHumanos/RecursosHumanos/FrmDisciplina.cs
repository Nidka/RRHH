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
public class FrmDisciplina : FrmConsulta
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("UcCBTipoCompor")]
	private ucComboBox _UcCBTipoCompor;

	[AccessedThroughProperty("UcDTFecha")]
	private ucDateTime _UcDTFecha;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("UcTxtNumDocumento")]
	private ucTextBox _UcTxtNumDocumento;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("UcTxtTitulo")]
	private ucTextBox _UcTxtTitulo;

	[AccessedThroughProperty("UcTxtDescrip")]
	private ucTextBox _UcTxtDescrip;

	[AccessedThroughProperty("btnGrabar")]
	private Button _btnGrabar;

	public int CodEmple;

	public int CodDisci;

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

	internal ucComboBox UcCBTipoCompor
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcCBTipoCompor;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcCBTipoCompor = value;
		}
	}

	internal ucDateTime UcDTFecha
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcDTFecha;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcDTFecha = value;
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

	internal ucTextBox UcTxtNumDocumento
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtNumDocumento;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtNumDocumento = value;
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

	internal ucTextBox UcTxtTitulo
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtTitulo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtTitulo = value;
		}
	}

	internal ucTextBox UcTxtDescrip
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtDescrip;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtDescrip = value;
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

	[DebuggerNonUserCode]
	public FrmDisciplina()
	{
		base.Load += FrmDisciplina_Load;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecursosHumanos.FrmDisciplina));
		this.Label1 = new System.Windows.Forms.Label();
		this.UcCBTipoCompor = new GRLL.Common.ucComboBox();
		this.UcDTFecha = new GRLL.Common.ucDateTime();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.UcTxtNumDocumento = new GRLL.Common.ucTextBox(this.components);
		this.Label4 = new System.Windows.Forms.Label();
		this.Label5 = new System.Windows.Forms.Label();
		this.UcTxtTitulo = new GRLL.Common.ucTextBox(this.components);
		this.UcTxtDescrip = new GRLL.Common.ucTextBox(this.components);
		this.btnGrabar = new System.Windows.Forms.Button();
		this.SuspendLayout();
		this.cmdCerrar.AutoSize = true;
		this.cmdCerrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.cmdCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cmdCerrar.FlatAppearance.BorderSize = 0;
		this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.cmdCerrar.Image = (System.Drawing.Image)resources.GetObject("cmdCerrar.Image");
		System.Windows.Forms.Button button = this.cmdCerrar;
		System.Drawing.Point location = new System.Drawing.Point(371, 232);
		button.Location = location;
		System.Windows.Forms.Button button2 = this.cmdCerrar;
		System.Drawing.Size size = new System.Drawing.Size(61, 23);
		button2.Size = size;
		this.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		System.Windows.Forms.Panel panelSup = this.PanelSup;
		size = new System.Drawing.Size(444, 29);
		panelSup.Size = size;
		System.Windows.Forms.Panel panelInf = this.PanelInf;
		location = new System.Drawing.Point(0, 271);
		panelInf.Location = location;
		System.Windows.Forms.Panel panelInf2 = this.PanelInf;
		size = new System.Drawing.Size(444, 27);
		panelInf2.Size = size;
		this.Label1.AutoSize = true;
		System.Windows.Forms.Label label = this.Label1;
		location = new System.Drawing.Point(0, 49);
		label.Location = location;
		this.Label1.Name = "Label1";
		System.Windows.Forms.Label label2 = this.Label1;
		size = new System.Drawing.Size(110, 13);
		label2.Size = size;
		this.Label1.TabIndex = 3;
		this.Label1.Text = "Tipo Comportamiento:";
		this.UcCBTipoCompor.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCBTipoCompor.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCBTipoCompor.FormattingEnabled = true;
		this.UcCBTipoCompor.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucCBTipoCompor = this.UcCBTipoCompor;
		location = new System.Drawing.Point(113, 46);
		ucCBTipoCompor.Location = location;
		this.UcCBTipoCompor.Name = "UcCBTipoCompor";
		GRLL.Common.ucComboBox ucCBTipoCompor2 = this.UcCBTipoCompor;
		size = new System.Drawing.Size(121, 21);
		ucCBTipoCompor2.Size = size;
		this.UcCBTipoCompor.TabIndex = 1;
		this.UcDTFecha.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcDTFecha.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucDateTime ucDTFecha = this.UcDTFecha;
		location = new System.Drawing.Point(113, 77);
		ucDTFecha.Location = location;
		this.UcDTFecha.Name = "UcDTFecha";
		GRLL.Common.ucDateTime ucDTFecha2 = this.UcDTFecha;
		size = new System.Drawing.Size(200, 20);
		ucDTFecha2.Size = size;
		this.UcDTFecha.TabIndex = 2;
		this.Label2.AutoSize = true;
		System.Windows.Forms.Label label3 = this.Label2;
		location = new System.Drawing.Point(67, 81);
		label3.Location = location;
		this.Label2.Name = "Label2";
		System.Windows.Forms.Label label4 = this.Label2;
		size = new System.Drawing.Size(40, 13);
		label4.Size = size;
		this.Label2.TabIndex = 3;
		this.Label2.Text = "Fecha:";
		this.Label3.AutoSize = true;
		System.Windows.Forms.Label label5 = this.Label3;
		location = new System.Drawing.Point(14, 106);
		label5.Location = location;
		this.Label3.Name = "Label3";
		System.Windows.Forms.Label label6 = this.Label3;
		size = new System.Drawing.Size(93, 13);
		label6.Size = size;
		this.Label3.TabIndex = 3;
		this.Label3.Text = "Num. Documento:";
		this.UcTxtNumDocumento.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtNumDocumento.Formato = null;
		this.UcTxtNumDocumento.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtNumDocumento = this.UcTxtNumDocumento;
		location = new System.Drawing.Point(113, 103);
		ucTxtNumDocumento.Location = location;
		this.UcTxtNumDocumento.MaxLength = 200;
		this.UcTxtNumDocumento.Name = "UcTxtNumDocumento";
		this.UcTxtNumDocumento.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtNumDocumento.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtNumDocumento.OnErrorBlankText = "";
		this.UcTxtNumDocumento.PadLeftLenght = 0;
		this.UcTxtNumDocumento.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtNumDocumento.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtNumDocumento2 = this.UcTxtNumDocumento;
		size = new System.Drawing.Size(248, 20);
		ucTxtNumDocumento2.Size = size;
		this.UcTxtNumDocumento.TabIndex = 3;
		this.UcTxtNumDocumento.TabNextControl = false;
		this.UcTxtNumDocumento.Tipo = GRLL.Common.ucTextBox.TipoDato.Todos;
		this.Label4.AutoSize = true;
		System.Windows.Forms.Label label7 = this.Label4;
		location = new System.Drawing.Point(64, 132);
		label7.Location = location;
		this.Label4.Name = "Label4";
		System.Windows.Forms.Label label8 = this.Label4;
		size = new System.Drawing.Size(43, 13);
		label8.Size = size;
		this.Label4.TabIndex = 3;
		this.Label4.Text = "Asunto:";
		this.Label5.AutoSize = true;
		System.Windows.Forms.Label label9 = this.Label5;
		location = new System.Drawing.Point(41, 158);
		label9.Location = location;
		this.Label5.Name = "Label5";
		System.Windows.Forms.Label label10 = this.Label5;
		size = new System.Drawing.Size(66, 13);
		label10.Size = size;
		this.Label5.TabIndex = 3;
		this.Label5.Text = "Descripción:";
		this.UcTxtTitulo.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtTitulo.Formato = null;
		this.UcTxtTitulo.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtTitulo = this.UcTxtTitulo;
		location = new System.Drawing.Point(113, 129);
		ucTxtTitulo.Location = location;
		this.UcTxtTitulo.MaxLength = 1000;
		this.UcTxtTitulo.Name = "UcTxtTitulo";
		this.UcTxtTitulo.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtTitulo.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtTitulo.OnErrorBlankText = "";
		this.UcTxtTitulo.PadLeftLenght = 0;
		this.UcTxtTitulo.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtTitulo.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtTitulo2 = this.UcTxtTitulo;
		size = new System.Drawing.Size(248, 20);
		ucTxtTitulo2.Size = size;
		this.UcTxtTitulo.TabIndex = 4;
		this.UcTxtTitulo.TabNextControl = false;
		this.UcTxtTitulo.Tipo = GRLL.Common.ucTextBox.TipoDato.Todos;
		this.UcTxtDescrip.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtDescrip.Formato = null;
		this.UcTxtDescrip.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtDescrip = this.UcTxtDescrip;
		location = new System.Drawing.Point(113, 155);
		ucTxtDescrip.Location = location;
		this.UcTxtDescrip.MaxLength = 2000;
		this.UcTxtDescrip.Multiline = true;
		this.UcTxtDescrip.Name = "UcTxtDescrip";
		this.UcTxtDescrip.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtDescrip.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtDescrip.OnErrorBlankText = "";
		this.UcTxtDescrip.PadLeftLenght = 0;
		this.UcTxtDescrip.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtDescrip.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtDescrip2 = this.UcTxtDescrip;
		size = new System.Drawing.Size(322, 71);
		ucTxtDescrip2.Size = size;
		this.UcTxtDescrip.TabIndex = 5;
		this.UcTxtDescrip.TabNextControl = false;
		this.UcTxtDescrip.Tipo = GRLL.Common.ucTextBox.TipoDato.Todos;
		this.btnGrabar.AutoSize = true;
		this.btnGrabar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.btnGrabar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnGrabar.FlatAppearance.BorderSize = 0;
		this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnGrabar.Image = (System.Drawing.Image)resources.GetObject("btnGrabar.Image");
		System.Windows.Forms.Button button3 = this.btnGrabar;
		location = new System.Drawing.Point(12, 232);
		button3.Location = location;
		this.btnGrabar.Name = "btnGrabar";
		System.Windows.Forms.Button button4 = this.btnGrabar;
		size = new System.Drawing.Size(65, 23);
		button4.Size = size;
		this.btnGrabar.TabIndex = 7;
		this.btnGrabar.Text = "Grabar";
		this.btnGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.btnGrabar.UseVisualStyleBackColor = true;
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		size = new System.Drawing.Size(444, 298);
		this.ClientSize = size;
		this.Controls.Add(this.btnGrabar);
		this.Controls.Add(this.UcCBTipoCompor);
		this.Controls.Add(this.UcDTFecha);
		this.Controls.Add(this.Label3);
		this.Controls.Add(this.Label2);
		this.Controls.Add(this.UcTxtTitulo);
		this.Controls.Add(this.UcTxtNumDocumento);
		this.Controls.Add(this.Label1);
		this.Controls.Add(this.Label4);
		this.Controls.Add(this.UcTxtDescrip);
		this.Controls.Add(this.Label5);
		this.MessageShow = true;
		this.Name = "FrmDisciplina";
		this.TitleMsg = "FrmConsulta";
		this.Titulo = "Disciplina";
		this.VerCmdCerrar = true;
		this.Controls.SetChildIndex(this.Label5, 0);
		this.Controls.SetChildIndex(this.UcTxtDescrip, 0);
		this.Controls.SetChildIndex(this.Label4, 0);
		this.Controls.SetChildIndex(this.Label1, 0);
		this.Controls.SetChildIndex(this.UcTxtNumDocumento, 0);
		this.Controls.SetChildIndex(this.cmdCerrar, 0);
		this.Controls.SetChildIndex(this.UcTxtTitulo, 0);
		this.Controls.SetChildIndex(this.Label2, 0);
		this.Controls.SetChildIndex(this.Label3, 0);
		this.Controls.SetChildIndex(this.UcDTFecha, 0);
		this.Controls.SetChildIndex(this.UcCBTipoCompor, 0);
		this.Controls.SetChildIndex(this.PanelSup, 0);
		this.Controls.SetChildIndex(this.PanelInf, 0);
		this.Controls.SetChildIndex(this.btnGrabar, 0);
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	private void btnGrabar_Click(object sender, EventArgs e)
	{
		Comportamiento comportamiento = new Comportamiento();
		if (UcTxtNumDocumento.TextLength < 0)
		{
			MessageBox.Show("Debe Ingresar una Resolución Válida", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
			return;
		}
		comportamiento.NumResol = UcTxtNumDocumento.Text.Trim();
		if (UcTxtTitulo.TextLength < 0)
		{
			MessageBox.Show("Debe Ingresar un Título Válido", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
			return;
		}
		comportamiento.Titulo = UcTxtTitulo.Text.Trim();
		if (UcTxtDescrip.TextLength < 0)
		{
			MessageBox.Show("Debe Ingresar una Descripción Válida", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
			return;
		}
		comportamiento.Descripcion = UcTxtDescrip.Text.Trim();
		comportamiento.Fecha = UcDTFecha.Value;
		comportamiento.IdEmpleado = CodEmple;
		if (CodDisci == 0)
		{
			int idComportamiento;
			if (ComportamientoMapper.Instance().SelectAll().Count == 0)
			{
				idComportamiento = 1;
			}
			else
			{
				idComportamiento = ComportamientoMapper.Instance().SelectAll().Max([SpecialName] (Comportamiento v) => v.idComportamiento);
				idComportamiento = checked(idComportamiento + 1);
			}
			comportamiento.idComportamiento = idComportamiento;
		}
		else
		{
			comportamiento.idComportamiento = CodDisci;
		}
		object selectedValue = UcCBTipoCompor.SelectedValue;
		int? num = default(int?);
		comportamiento.idTipoComportamiento = ((selectedValue != null) ? ((int?)selectedValue) : num);
		if (CodDisci == 0)
		{
			ComportamientoMapper.Instance().Insert(comportamiento);
		}
		else
		{
			ComportamientoMapper.Instance().Update(comportamiento);
		}
		DialogResult = DialogResult.OK;
	}

	private void FrmDisciplina_Load(object sender, EventArgs e)
	{
		UcCBTipoCompor.DisplayMember = "TipoCompDescrip";
		UcCBTipoCompor.ValueMember = "idTipoComportamiento";
		UcCBTipoCompor.DataSource = TipoComportamientoMapper.Instance().SelectAll();
		if (CodDisci != 0)
		{
			Comportamiento comportamiento = ComportamientoMapper.Instance().SelectOneBy([SpecialName] (Comportamiento v) => v.idComportamiento == CodDisci);
			UcCBTipoCompor.SelectedValue = comportamiento.idTipoComportamiento;
			UcCBTipoCompor.Enabled = false;
			UcTxtNumDocumento.Text = comportamiento.NumResol;
			UcDTFecha.Value = (DateTime)comportamiento.Fecha;
			UcTxtTitulo.Text = comportamiento.Titulo;
			UcTxtDescrip.Text = comportamiento.Descripcion;
		}
	}
}
