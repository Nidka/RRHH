using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using GRLL.Common;
using Microsoft.VisualBasic.CompilerServices;

namespace RecursosHumanos;

[DesignerGenerated]
public class FrmTitulos : FrmConsulta
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("BtnGrabar")]
	private Button _BtnGrabar;

	[AccessedThroughProperty("UcTxtColegiatura")]
	private ucTextBox _UcTxtColegiatura;

	[AccessedThroughProperty("UcTxtDenoTitulo")]
	private ucTextBox _UcTxtDenoTitulo;

	[AccessedThroughProperty("UcDTFecha")]
	private ucDateTime _UcDTFecha;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("UcTxtInstitucion")]
	private ucTextBox _UcTxtInstitucion;

	[AccessedThroughProperty("BtnCerrar")]
	private Button _BtnCerrar;

	public int CodEmple;

	private TitulosEmpleado TituloEmpleado;

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

	internal Button BtnGrabar
	{
		[DebuggerNonUserCode]
		get
		{
			return _BtnGrabar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = BtnGrabar_Click;
			if (_BtnGrabar != null)
			{
				_BtnGrabar.Click -= value2;
			}
			_BtnGrabar = value;
			if (_BtnGrabar != null)
			{
				_BtnGrabar.Click += value2;
			}
		}
	}

	internal ucTextBox UcTxtColegiatura
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtColegiatura;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtColegiatura = value;
		}
	}

	internal ucTextBox UcTxtDenoTitulo
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtDenoTitulo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtDenoTitulo = value;
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

	internal ucTextBox UcTxtInstitucion
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtInstitucion;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtInstitucion = value;
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

	public FrmTitulos()
	{
		base.Load += FrmTitulos_Load;
		__ENCAddToList(this);
		TituloEmpleado = new TitulosEmpleado();
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecursosHumanos.FrmTitulos));
		this.Label1 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.BtnGrabar = new System.Windows.Forms.Button();
		this.UcTxtColegiatura = new GRLL.Common.ucTextBox(this.components);
		this.UcTxtDenoTitulo = new GRLL.Common.ucTextBox(this.components);
		this.UcDTFecha = new GRLL.Common.ucDateTime();
		this.Label4 = new System.Windows.Forms.Label();
		this.UcTxtInstitucion = new GRLL.Common.ucTextBox(this.components);
		this.BtnCerrar = new System.Windows.Forms.Button();
		this.SuspendLayout();
		this.cmdCerrar.AutoSize = true;
		this.cmdCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cmdCerrar.FlatAppearance.BorderSize = 0;
		this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.cmdCerrar.Image = (System.Drawing.Image)resources.GetObject("cmdCerrar.Image");
		System.Windows.Forms.Button button = this.cmdCerrar;
		System.Drawing.Point location = new System.Drawing.Point(208, 204);
		button.Location = location;
		System.Windows.Forms.Button button2 = this.cmdCerrar;
		System.Drawing.Size size = new System.Drawing.Size(69, 30);
		button2.Size = size;
		this.cmdCerrar.TabIndex = 6;
		this.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		System.Windows.Forms.Panel panelSup = this.PanelSup;
		size = new System.Drawing.Size(289, 24);
		panelSup.Size = size;
		System.Windows.Forms.Panel panelInf = this.PanelInf;
		location = new System.Drawing.Point(0, 240);
		panelInf.Location = location;
		System.Windows.Forms.Panel panelInf2 = this.PanelInf;
		size = new System.Drawing.Size(289, 30);
		panelInf2.Size = size;
		this.Label1.AutoSize = true;
		System.Windows.Forms.Label label = this.Label1;
		location = new System.Drawing.Point(12, 39);
		label.Location = location;
		this.Label1.Name = "Label1";
		System.Windows.Forms.Label label2 = this.Label1;
		size = new System.Drawing.Size(106, 13);
		label2.Size = size;
		this.Label1.TabIndex = 3;
		this.Label1.Text = "Num. de Colegiatura:";
		this.Label2.AutoSize = true;
		System.Windows.Forms.Label label3 = this.Label2;
		location = new System.Drawing.Point(12, 80);
		label3.Location = location;
		this.Label2.Name = "Label2";
		System.Windows.Forms.Label label4 = this.Label2;
		size = new System.Drawing.Size(175, 13);
		label4.Size = size;
		this.Label2.TabIndex = 4;
		this.Label2.Text = "Denominación del Grado y/o Titulo:";
		this.Label3.AutoSize = true;
		System.Windows.Forms.Label label5 = this.Label3;
		location = new System.Drawing.Point(12, 162);
		label5.Location = location;
		this.Label3.Name = "Label3";
		System.Windows.Forms.Label label6 = this.Label3;
		size = new System.Drawing.Size(40, 13);
		label6.Size = size;
		this.Label3.TabIndex = 5;
		this.Label3.Text = "Fecha:";
		this.BtnGrabar.AutoSize = true;
		this.BtnGrabar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.BtnGrabar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BtnGrabar.FlatAppearance.BorderSize = 0;
		this.BtnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BtnGrabar.Image = (System.Drawing.Image)resources.GetObject("BtnGrabar.Image");
		System.Windows.Forms.Button btnGrabar = this.BtnGrabar;
		location = new System.Drawing.Point(12, 211);
		btnGrabar.Location = location;
		this.BtnGrabar.Name = "BtnGrabar";
		System.Windows.Forms.Button btnGrabar2 = this.BtnGrabar;
		size = new System.Drawing.Size(65, 23);
		btnGrabar2.Size = size;
		this.BtnGrabar.TabIndex = 5;
		this.BtnGrabar.Text = "Grabar";
		this.BtnGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.BtnGrabar.UseVisualStyleBackColor = true;
		this.UcTxtColegiatura.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtColegiatura.Formato = null;
		this.UcTxtColegiatura.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtColegiatura = this.UcTxtColegiatura;
		location = new System.Drawing.Point(15, 55);
		ucTxtColegiatura.Location = location;
		this.UcTxtColegiatura.MaxLength = 20;
		this.UcTxtColegiatura.Name = "UcTxtColegiatura";
		this.UcTxtColegiatura.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtColegiatura.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtColegiatura.OnErrorBlankText = "";
		this.UcTxtColegiatura.PadLeftLenght = 0;
		this.UcTxtColegiatura.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtColegiatura.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtColegiatura2 = this.UcTxtColegiatura;
		size = new System.Drawing.Size(172, 20);
		ucTxtColegiatura2.Size = size;
		this.UcTxtColegiatura.TabIndex = 1;
		this.UcTxtColegiatura.TabNextControl = false;
		this.UcTxtColegiatura.Tipo = GRLL.Common.ucTextBox.TipoDato.Todos;
		this.UcTxtDenoTitulo.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtDenoTitulo.Formato = null;
		this.UcTxtDenoTitulo.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtDenoTitulo = this.UcTxtDenoTitulo;
		location = new System.Drawing.Point(15, 96);
		ucTxtDenoTitulo.Location = location;
		this.UcTxtDenoTitulo.MaxLength = 100;
		this.UcTxtDenoTitulo.Name = "UcTxtDenoTitulo";
		this.UcTxtDenoTitulo.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtDenoTitulo.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtDenoTitulo.OnErrorBlankText = "";
		this.UcTxtDenoTitulo.PadLeftLenght = 0;
		this.UcTxtDenoTitulo.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtDenoTitulo.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtDenoTitulo2 = this.UcTxtDenoTitulo;
		size = new System.Drawing.Size(263, 20);
		ucTxtDenoTitulo2.Size = size;
		this.UcTxtDenoTitulo.TabIndex = 2;
		this.UcTxtDenoTitulo.TabNextControl = false;
		this.UcTxtDenoTitulo.Tipo = GRLL.Common.ucTextBox.TipoDato.Todos;
		this.UcDTFecha.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcDTFecha.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucDateTime ucDTFecha = this.UcDTFecha;
		location = new System.Drawing.Point(15, 178);
		ucDTFecha.Location = location;
		this.UcDTFecha.Name = "UcDTFecha";
		GRLL.Common.ucDateTime ucDTFecha2 = this.UcDTFecha;
		size = new System.Drawing.Size(220, 20);
		ucDTFecha2.Size = size;
		this.UcDTFecha.TabIndex = 4;
		this.Label4.AutoSize = true;
		System.Windows.Forms.Label label7 = this.Label4;
		location = new System.Drawing.Point(12, 119);
		label7.Location = location;
		this.Label4.Name = "Label4";
		System.Windows.Forms.Label label8 = this.Label4;
		size = new System.Drawing.Size(106, 13);
		label8.Size = size;
		this.Label4.TabIndex = 4;
		this.Label4.Text = "Institución o Entidad:";
		this.UcTxtInstitucion.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtInstitucion.Formato = null;
		this.UcTxtInstitucion.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtInstitucion = this.UcTxtInstitucion;
		location = new System.Drawing.Point(15, 135);
		ucTxtInstitucion.Location = location;
		this.UcTxtInstitucion.MaxLength = 60;
		this.UcTxtInstitucion.Name = "UcTxtInstitucion";
		this.UcTxtInstitucion.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtInstitucion.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtInstitucion.OnErrorBlankText = "";
		this.UcTxtInstitucion.PadLeftLenght = 0;
		this.UcTxtInstitucion.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtInstitucion.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtInstitucion2 = this.UcTxtInstitucion;
		size = new System.Drawing.Size(263, 20);
		ucTxtInstitucion2.Size = size;
		this.UcTxtInstitucion.TabIndex = 3;
		this.UcTxtInstitucion.TabNextControl = false;
		this.UcTxtInstitucion.Tipo = GRLL.Common.ucTextBox.TipoDato.Todos;
		this.BtnCerrar.AutoSize = true;
		this.BtnCerrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BtnCerrar.FlatAppearance.BorderSize = 0;
		this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BtnCerrar.Image = (System.Drawing.Image)resources.GetObject("BtnCerrar.Image");
		System.Windows.Forms.Button btnCerrar = this.BtnCerrar;
		location = new System.Drawing.Point(216, 211);
		btnCerrar.Location = location;
		this.BtnCerrar.Name = "BtnCerrar";
		System.Windows.Forms.Button btnCerrar2 = this.BtnCerrar;
		size = new System.Drawing.Size(61, 23);
		btnCerrar2.Size = size;
		this.BtnCerrar.TabIndex = 9;
		this.BtnCerrar.Text = "Cerrar";
		this.BtnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.BtnCerrar.UseVisualStyleBackColor = true;
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.Calculadora = false;
		size = new System.Drawing.Size(289, 270);
		this.ClientSize = size;
		this.Controls.Add(this.BtnCerrar);
		this.Controls.Add(this.UcDTFecha);
		this.Controls.Add(this.UcTxtInstitucion);
		this.Controls.Add(this.UcTxtDenoTitulo);
		this.Controls.Add(this.UcTxtColegiatura);
		this.Controls.Add(this.BtnGrabar);
		this.Controls.Add(this.Label1);
		this.Controls.Add(this.Label4);
		this.Controls.Add(this.Label2);
		this.Controls.Add(this.Label3);
		this.MessageShow = true;
		this.Name = "FrmTitulos";
		this.TitleMsg = "FrmConsulta";
		this.Titulo = "Titulos y/o Grados";
		this.Controls.SetChildIndex(this.cmdCerrar, 0);
		this.Controls.SetChildIndex(this.Label3, 0);
		this.Controls.SetChildIndex(this.Label2, 0);
		this.Controls.SetChildIndex(this.Label4, 0);
		this.Controls.SetChildIndex(this.Label1, 0);
		this.Controls.SetChildIndex(this.PanelSup, 0);
		this.Controls.SetChildIndex(this.PanelInf, 0);
		this.Controls.SetChildIndex(this.BtnGrabar, 0);
		this.Controls.SetChildIndex(this.UcTxtColegiatura, 0);
		this.Controls.SetChildIndex(this.UcTxtDenoTitulo, 0);
		this.Controls.SetChildIndex(this.UcTxtInstitucion, 0);
		this.Controls.SetChildIndex(this.UcDTFecha, 0);
		this.Controls.SetChildIndex(this.BtnCerrar, 0);
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	private void BtnGrabar_Click(object sender, EventArgs e)
	{
		TituloEmpleado.IdEmpleado = CodEmple;
		TituloEmpleado.Fecha = UcDTFecha.Value;
		List<TitulosEmpleado> list = TitulosEmpleadoMapper.Instance().SelectAll();
		if (list.Count > 0)
		{
			foreach (TitulosEmpleado item in list)
			{
				if (Operators.CompareString(UcTxtColegiatura.Text, item.NumColegiatura, TextCompare: false) == 0)
				{
					MessageBox.Show("Ya esta registrado ese Nº de Colegiatura en el Empleado: " + item.Empleado.Persona.Apellido_Paterno + " " + item.Empleado.Persona.Apellido_Materno + " " + item.Empleado.Persona.Nombres + " , Por favor Verifique ", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
			}
		}
		if (UcTxtColegiatura.TextLength == 0)
		{
			MessageBox.Show("Debe Ingresar Un numero de Colegiatura", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		TituloEmpleado.NumColegiatura = UcTxtColegiatura.Text;
		if (UcTxtDenoTitulo.TextLength == 0)
		{
			MessageBox.Show("Debe Ingresar una Denominación del Grado y/o Titulo", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		TituloEmpleado.DenominacionGrado = UcTxtDenoTitulo.Text;
		if (UcTxtInstitucion.TextLength == 0)
		{
			MessageBox.Show("Debe Ingresar el Nombre de la Institución", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		TituloEmpleado.Institucion = UcTxtInstitucion.Text;
		TitulosEmpleadoMapper.Instance().Insert(TituloEmpleado);
		DialogResult = DialogResult.OK;
	}

	private void BtnCerrar_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void FrmTitulos_Load(object sender, EventArgs e)
	{
	}
}
