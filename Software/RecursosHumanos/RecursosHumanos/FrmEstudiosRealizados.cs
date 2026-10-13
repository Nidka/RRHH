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
public class FrmEstudiosRealizados : FrmConsulta
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

	[AccessedThroughProperty("UcCBTipoEstudio")]
	private ucComboBox _UcCBTipoEstudio;

	[AccessedThroughProperty("UcTxtCentro")]
	private ucTextBox _UcTxtCentro;

	[AccessedThroughProperty("UcDTInicio")]
	private ucDateTime _UcDTInicio;

	[AccessedThroughProperty("UcDTFin")]
	private ucDateTime _UcDTFin;

	[AccessedThroughProperty("UcCBEstadoEstudio")]
	private ucComboBox _UcCBEstadoEstudio;

	[AccessedThroughProperty("BtnGrabar")]
	private Button _BtnGrabar;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("UcTxt_Especialidad")]
	private ucTextBox _UcTxt_Especialidad;

	public int CodEmple;

	public int codEstudio;

	public int Nrocorre;

	private EstudiosRealizado estudiorealizado;

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

	internal ucComboBox UcCBTipoEstudio
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcCBTipoEstudio;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = UcCBTipoEstudio_SelectedIndexChanged;
			if (_UcCBTipoEstudio != null)
			{
				_UcCBTipoEstudio.SelectedIndexChanged -= value2;
			}
			_UcCBTipoEstudio = value;
			if (_UcCBTipoEstudio != null)
			{
				_UcCBTipoEstudio.SelectedIndexChanged += value2;
			}
		}
	}

	internal ucTextBox UcTxtCentro
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtCentro;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtCentro = value;
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

	internal ucDateTime UcDTFin
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcDTFin;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcDTFin = value;
		}
	}

	internal ucComboBox UcCBEstadoEstudio
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcCBEstadoEstudio;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcCBEstadoEstudio = value;
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
			EventHandler value2 = Button1_Click;
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

	internal Label Label6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label6 = value;
		}
	}

	internal ucTextBox UcTxt_Especialidad
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxt_Especialidad;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxt_Especialidad = value;
		}
	}

	public FrmEstudiosRealizados()
	{
		base.Load += FrmEstudiosRealizados_Load;
		__ENCAddToList(this);
		estudiorealizado = new EstudiosRealizado();
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecursosHumanos.FrmEstudiosRealizados));
		this.Label1 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label5 = new System.Windows.Forms.Label();
		this.UcCBTipoEstudio = new GRLL.Common.ucComboBox();
		this.UcTxtCentro = new GRLL.Common.ucTextBox(this.components);
		this.UcDTInicio = new GRLL.Common.ucDateTime();
		this.UcDTFin = new GRLL.Common.ucDateTime();
		this.UcCBEstadoEstudio = new GRLL.Common.ucComboBox();
		this.BtnGrabar = new System.Windows.Forms.Button();
		this.Label6 = new System.Windows.Forms.Label();
		this.UcTxt_Especialidad = new GRLL.Common.ucTextBox(this.components);
		this.SuspendLayout();
		this.cmdCerrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.cmdCerrar.AutoSize = true;
		this.cmdCerrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.cmdCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cmdCerrar.FlatAppearance.BorderSize = 0;
		this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.cmdCerrar.Image = (System.Drawing.Image)resources.GetObject("cmdCerrar.Image");
		System.Windows.Forms.Button button = this.cmdCerrar;
		System.Drawing.Point location = new System.Drawing.Point(258, 208);
		button.Location = location;
		System.Windows.Forms.Button button2 = this.cmdCerrar;
		System.Drawing.Size size = new System.Drawing.Size(61, 23);
		button2.Size = size;
		this.cmdCerrar.TabIndex = 8;
		this.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.cmdCerrar.Visible = true;
		System.Windows.Forms.Panel panelSup = this.PanelSup;
		size = new System.Drawing.Size(331, 24);
		panelSup.Size = size;
		System.Windows.Forms.Panel panelInf = this.PanelInf;
		location = new System.Drawing.Point(0, 237);
		panelInf.Location = location;
		System.Windows.Forms.Panel panelInf2 = this.PanelInf;
		size = new System.Drawing.Size(331, 27);
		panelInf2.Size = size;
		this.Label1.AutoSize = true;
		System.Windows.Forms.Label label = this.Label1;
		location = new System.Drawing.Point(2, 70);
		label.Location = location;
		this.Label1.Name = "Label1";
		System.Windows.Forms.Label label2 = this.Label1;
		size = new System.Drawing.Size(99, 13);
		label2.Size = size;
		this.Label1.TabIndex = 0;
		this.Label1.Text = "Centro de Estudios:";
		this.Label2.AutoSize = true;
		System.Windows.Forms.Label label3 = this.Label2;
		location = new System.Drawing.Point(18, 123);
		label3.Location = location;
		this.Label2.Name = "Label2";
		System.Windows.Forms.Label label4 = this.Label2;
		size = new System.Drawing.Size(83, 13);
		label4.Size = size;
		this.Label2.TabIndex = 0;
		this.Label2.Text = "Fecha de Inicio:";
		this.Label3.AutoSize = true;
		System.Windows.Forms.Label label5 = this.Label3;
		location = new System.Drawing.Point(5, 149);
		label5.Location = location;
		this.Label3.Name = "Label3";
		System.Windows.Forms.Label label6 = this.Label3;
		size = new System.Drawing.Size(96, 13);
		label6.Size = size;
		this.Label3.TabIndex = 0;
		this.Label3.Text = "Fecha de Termino:";
		this.Label4.AutoSize = true;
		System.Windows.Forms.Label label7 = this.Label4;
		location = new System.Drawing.Point(58, 174);
		label7.Location = location;
		this.Label4.Name = "Label4";
		System.Windows.Forms.Label label8 = this.Label4;
		size = new System.Drawing.Size(43, 13);
		label8.Size = size;
		this.Label4.TabIndex = 0;
		this.Label4.Text = "Estado:";
		this.Label5.AutoSize = true;
		System.Windows.Forms.Label label9 = this.Label5;
		location = new System.Drawing.Point(12, 43);
		label9.Location = location;
		this.Label5.Name = "Label5";
		System.Windows.Forms.Label label10 = this.Label5;
		size = new System.Drawing.Size(89, 13);
		label10.Size = size;
		this.Label5.TabIndex = 0;
		this.Label5.Text = "Tipo de Estudios:";
		this.UcCBTipoEstudio.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCBTipoEstudio.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCBTipoEstudio.FormattingEnabled = true;
		this.UcCBTipoEstudio.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucCBTipoEstudio = this.UcCBTipoEstudio;
		location = new System.Drawing.Point(107, 40);
		ucCBTipoEstudio.Location = location;
		this.UcCBTipoEstudio.Name = "UcCBTipoEstudio";
		GRLL.Common.ucComboBox ucCBTipoEstudio2 = this.UcCBTipoEstudio;
		size = new System.Drawing.Size(123, 21);
		ucCBTipoEstudio2.Size = size;
		this.UcCBTipoEstudio.TabIndex = 1;
		this.UcTxtCentro.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtCentro.Formato = null;
		this.UcTxtCentro.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtCentro = this.UcTxtCentro;
		location = new System.Drawing.Point(107, 67);
		ucTxtCentro.Location = location;
		this.UcTxtCentro.MaxLength = 50;
		this.UcTxtCentro.Name = "UcTxtCentro";
		this.UcTxtCentro.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtCentro.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtCentro.OnErrorBlankText = "";
		this.UcTxtCentro.PadLeftLenght = 0;
		this.UcTxtCentro.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtCentro.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtCentro2 = this.UcTxtCentro;
		size = new System.Drawing.Size(204, 20);
		ucTxtCentro2.Size = size;
		this.UcTxtCentro.TabIndex = 2;
		this.UcTxtCentro.TabNextControl = false;
		this.UcTxtCentro.Tipo = GRLL.Common.ucTextBox.TipoDato.Todos;
		this.UcDTInicio.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcDTInicio.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucDateTime ucDTInicio = this.UcDTInicio;
		location = new System.Drawing.Point(107, 119);
		ucDTInicio.Location = location;
		this.UcDTInicio.Name = "UcDTInicio";
		GRLL.Common.ucDateTime ucDTInicio2 = this.UcDTInicio;
		size = new System.Drawing.Size(204, 20);
		ucDTInicio2.Size = size;
		this.UcDTInicio.TabIndex = 4;
		this.UcDTFin.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcDTFin.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucDateTime ucDTFin = this.UcDTFin;
		location = new System.Drawing.Point(107, 145);
		ucDTFin.Location = location;
		this.UcDTFin.Name = "UcDTFin";
		GRLL.Common.ucDateTime ucDTFin2 = this.UcDTFin;
		size = new System.Drawing.Size(204, 20);
		ucDTFin2.Size = size;
		this.UcDTFin.TabIndex = 5;
		this.UcCBEstadoEstudio.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCBEstadoEstudio.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCBEstadoEstudio.FormattingEnabled = true;
		this.UcCBEstadoEstudio.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucCBEstadoEstudio = this.UcCBEstadoEstudio;
		location = new System.Drawing.Point(107, 171);
		ucCBEstadoEstudio.Location = location;
		this.UcCBEstadoEstudio.Name = "UcCBEstadoEstudio";
		GRLL.Common.ucComboBox ucCBEstadoEstudio2 = this.UcCBEstadoEstudio;
		size = new System.Drawing.Size(123, 21);
		ucCBEstadoEstudio2.Size = size;
		this.UcCBEstadoEstudio.TabIndex = 6;
		this.BtnGrabar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.BtnGrabar.AutoSize = true;
		this.BtnGrabar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.BtnGrabar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BtnGrabar.FlatAppearance.BorderSize = 0;
		this.BtnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BtnGrabar.Image = (System.Drawing.Image)resources.GetObject("BtnGrabar.Image");
		System.Windows.Forms.Button btnGrabar = this.BtnGrabar;
		location = new System.Drawing.Point(12, 208);
		btnGrabar.Location = location;
		this.BtnGrabar.Name = "BtnGrabar";
		System.Windows.Forms.Button btnGrabar2 = this.BtnGrabar;
		size = new System.Drawing.Size(65, 23);
		btnGrabar2.Size = size;
		this.BtnGrabar.TabIndex = 7;
		this.BtnGrabar.Text = "Grabar";
		this.BtnGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.BtnGrabar.UseVisualStyleBackColor = true;
		this.Label6.AutoSize = true;
		System.Windows.Forms.Label label11 = this.Label6;
		location = new System.Drawing.Point(31, 96);
		label11.Location = location;
		this.Label6.Name = "Label6";
		System.Windows.Forms.Label label12 = this.Label6;
		size = new System.Drawing.Size(70, 13);
		label12.Size = size;
		this.Label6.TabIndex = 0;
		this.Label6.Text = "Especialidad:";
		this.UcTxt_Especialidad.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxt_Especialidad.Formato = null;
		this.UcTxt_Especialidad.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxt_Especialidad = this.UcTxt_Especialidad;
		location = new System.Drawing.Point(107, 93);
		ucTxt_Especialidad.Location = location;
		this.UcTxt_Especialidad.MaxLength = 100;
		this.UcTxt_Especialidad.Name = "UcTxt_Especialidad";
		this.UcTxt_Especialidad.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxt_Especialidad.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxt_Especialidad.OnErrorBlankText = "";
		this.UcTxt_Especialidad.PadLeftLenght = 0;
		this.UcTxt_Especialidad.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxt_Especialidad.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxt_Especialidad2 = this.UcTxt_Especialidad;
		size = new System.Drawing.Size(204, 20);
		ucTxt_Especialidad2.Size = size;
		this.UcTxt_Especialidad.TabIndex = 3;
		this.UcTxt_Especialidad.TabNextControl = false;
		this.UcTxt_Especialidad.Tipo = GRLL.Common.ucTextBox.TipoDato.Todos;
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.Calculadora = false;
		size = new System.Drawing.Size(331, 264);
		this.ClientSize = size;
		this.Controls.Add(this.BtnGrabar);
		this.Controls.Add(this.UcDTFin);
		this.Controls.Add(this.UcDTInicio);
		this.Controls.Add(this.UcTxt_Especialidad);
		this.Controls.Add(this.UcTxtCentro);
		this.Controls.Add(this.UcCBEstadoEstudio);
		this.Controls.Add(this.UcCBTipoEstudio);
		this.Controls.Add(this.Label6);
		this.Controls.Add(this.Label1);
		this.Controls.Add(this.Label3);
		this.Controls.Add(this.Label2);
		this.Controls.Add(this.Label5);
		this.Controls.Add(this.Label4);
		this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		this.MessageShow = true;
		this.Name = "FrmEstudiosRealizados";
		this.TitleMsg = "FrmConsulta";
		this.Titulo = "Estudios Realizados";
		this.VerCmdCerrar = true;
		this.Controls.SetChildIndex(this.Label4, 0);
		this.Controls.SetChildIndex(this.Label5, 0);
		this.Controls.SetChildIndex(this.Label2, 0);
		this.Controls.SetChildIndex(this.Label3, 0);
		this.Controls.SetChildIndex(this.Label1, 0);
		this.Controls.SetChildIndex(this.Label6, 0);
		this.Controls.SetChildIndex(this.PanelSup, 0);
		this.Controls.SetChildIndex(this.PanelInf, 0);
		this.Controls.SetChildIndex(this.cmdCerrar, 0);
		this.Controls.SetChildIndex(this.UcCBTipoEstudio, 0);
		this.Controls.SetChildIndex(this.UcCBEstadoEstudio, 0);
		this.Controls.SetChildIndex(this.UcTxtCentro, 0);
		this.Controls.SetChildIndex(this.UcTxt_Especialidad, 0);
		this.Controls.SetChildIndex(this.UcDTInicio, 0);
		this.Controls.SetChildIndex(this.UcDTFin, 0);
		this.Controls.SetChildIndex(this.BtnGrabar, 0);
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	private void FrmEstudiosRealizados_Load(object sender, EventArgs e)
	{
		UcCBTipoEstudio.ValueMember = "IdTipoEstudios";
		UcCBTipoEstudio.DisplayMember = "DescripTipoEst";
		UcCBTipoEstudio.DataSource = TipoEstudioMapper.Instance().SelectAll();
		UcCBEstadoEstudio.ValueMember = "IdEstadoEstudio";
		UcCBEstadoEstudio.DisplayMember = "DescripEstadoEstudio";
		UcCBEstadoEstudio.DataSource = EstadoEstudioMapper.Instance().SelectAll();
		if (codEstudio != 0)
		{
			EstudiosRealizado estudiosRealizado = EstudiosRealizadoMapper.Instance().SelectOneBy([SpecialName] (EstudiosRealizado v) => (v.IdEmpleado == CodEmple) & (v.IdTipoEstudios == codEstudio));
			UcCBTipoEstudio.SelectedValue = estudiosRealizado.IdTipoEstudios;
			UcCBTipoEstudio.Enabled = false;
			UcTxtCentro.Text = estudiosRealizado.CentroEstudios;
			UcDTInicio.Value = (DateTime)estudiosRealizado.AñoInicio;
			UcDTFin.Value = (DateTime)estudiosRealizado.AñoTermino;
			UcCBEstadoEstudio.SelectedValue = estudiosRealizado.IdEstadoEstudio;
			UcTxt_Especialidad.Text = estudiosRealizado.Especialidad;
			Nrocorre = estudiosRealizado.Correlativo;
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		estudiorealizado.AñoInicio = UcDTInicio.Value;
		estudiorealizado.AñoTermino = UcDTFin.Value;
		EstudiosRealizado estudiosRealizado = estudiorealizado;
		object selectedValue = UcCBEstadoEstudio.SelectedValue;
		int? num = default(int?);
		estudiosRealizado.IdEstadoEstudio = ((selectedValue != null) ? ((int?)selectedValue) : num);
		estudiorealizado.IdEmpleado = CodEmple;
		estudiorealizado.IdTipoEstudios = Conversions.ToInteger(UcCBTipoEstudio.SelectedValue);
		if (UcTxtCentro.TextLength == 0)
		{
			MessageBox.Show("Debe Ingresar un Centro de Estudios", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			return;
		}
		estudiorealizado.CentroEstudios = UcTxtCentro.Text;
		estudiorealizado.Especialidad = UcTxt_Especialidad.Text.Trim();
		estudiorealizado.Correlativo = Nrocorre;
		if ((codEstudio == 0) & (Nrocorre == 0))
		{
			int correlativo = ((EstudiosRealizadoMapper.Instance().SelectBy([SpecialName] (EstudiosRealizado x) => x.IdEmpleado == CodEmple).Count == 0) ? 1 : checked(((IEnumerable<EstudiosRealizado>)EstudiosRealizadoMapper.Instance().SelectBy([SpecialName] (EstudiosRealizado x) => x.IdEmpleado == CodEmple)).Max<EstudiosRealizado, int>((Func<EstudiosRealizado, int>)([SpecialName] (EstudiosRealizado b) => b.Correlativo)) + 1));
			estudiorealizado.Correlativo = correlativo;
			EstudiosRealizadoMapper.Instance().Insert(estudiorealizado);
		}
		else
		{
			EstudiosRealizadoMapper.Instance().Update(estudiorealizado);
		}
		DialogResult = DialogResult.OK;
	}

	private void BtnCerrar_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void UcCBTipoEstudio_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectGreaterEqual(UcCBTipoEstudio.SelectedValue, 3, TextCompare: false))
		{
			Size size = new Size(339, 298);
			Size = size;
			Label6.Visible = true;
			UcTxt_Especialidad.Visible = true;
			ucDateTime ucDTInicio = UcDTInicio;
			Point location = new Point(107, 119);
			ucDTInicio.Location = location;
			Label label = Label2;
			location = new Point(18, 123);
			label.Location = location;
			ucDateTime ucDTFin = UcDTFin;
			location = new Point(107, 145);
			ucDTFin.Location = location;
			Label label2 = Label3;
			location = new Point(5, 149);
			label2.Location = location;
			ucComboBox ucCBEstadoEstudio = UcCBEstadoEstudio;
			location = new Point(107, 171);
			ucCBEstadoEstudio.Location = location;
			Label label3 = Label4;
			location = new Point(58, 174);
			label3.Location = location;
		}
		else
		{
			Size size = new Size(339, 279);
			Size = size;
			Label6.Visible = false;
			UcTxt_Especialidad.Visible = false;
			ucDateTime ucDTInicio2 = UcDTInicio;
			Point location = new Point(107, 93);
			ucDTInicio2.Location = location;
			Label label4 = Label2;
			location = new Point(18, 96);
			label4.Location = location;
			ucDateTime ucDTFin2 = UcDTFin;
			location = new Point(107, 119);
			ucDTFin2.Location = location;
			Label label5 = Label3;
			location = new Point(5, 123);
			label5.Location = location;
			ucComboBox ucCBEstadoEstudio2 = UcCBEstadoEstudio;
			location = new Point(107, 145);
			ucCBEstadoEstudio2.Location = location;
			Label label6 = Label4;
			location = new Point(58, 149);
			label6.Location = location;
		}
	}
}
