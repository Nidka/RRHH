using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using GRLL.Common;
using Microsoft.VisualBasic.CompilerServices;
using RecursosHumanos.My.Resources;

namespace RecursosHumanos;

[DesignerGenerated]
public class FrmResoluciones : FrmConsulta
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("UcCBTipoResolucion")]
	private ucComboBox _UcCBTipoResolucion;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("DateTimePicker1")]
	private DateTimePicker _DateTimePicker1;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("UcTextBox1")]
	private ucTextBox _UcTextBox1;

	[AccessedThroughProperty("BtnGrabar")]
	private Button _BtnGrabar;

	public int codemple;

	public int idResolucion;

	private Resolucion oResolucion;

	protected override Button cmdCerrar
	{
		[DebuggerNonUserCode]
		get
		{
			return base.cmdCerrar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = cmdCerrar_Click;
			if (base.cmdCerrar != null)
			{
				base.cmdCerrar.Click -= value2;
			}
			base.cmdCerrar = value;
			if (base.cmdCerrar != null)
			{
				base.cmdCerrar.Click += value2;
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

	internal ucComboBox UcCBTipoResolucion
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcCBTipoResolucion;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcCBTipoResolucion = value;
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

	internal DateTimePicker DateTimePicker1
	{
		[DebuggerNonUserCode]
		get
		{
			return _DateTimePicker1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DateTimePicker1 = value;
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

	public FrmResoluciones()
	{
		base.Load += FrmResoluciones_Load;
		__ENCAddToList(this);
		oResolucion = new Resolucion();
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecursosHumanos.FrmResoluciones));
		this.Label1 = new System.Windows.Forms.Label();
		this.UcCBTipoResolucion = new GRLL.Common.ucComboBox();
		this.Label2 = new System.Windows.Forms.Label();
		this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
		this.Label3 = new System.Windows.Forms.Label();
		this.UcTextBox1 = new GRLL.Common.ucTextBox(this.components);
		this.BtnGrabar = new System.Windows.Forms.Button();
		this.SuspendLayout();
		this.cmdCerrar.AutoSize = true;
		this.cmdCerrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.cmdCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cmdCerrar.FlatAppearance.BorderSize = 0;
		this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.cmdCerrar.Image = RecursosHumanos.My.Resources.Resources._exit;
		System.Windows.Forms.Button button = this.cmdCerrar;
		System.Drawing.Point location = new System.Drawing.Point(276, 143);
		button.Location = location;
		System.Windows.Forms.Button button2 = this.cmdCerrar;
		System.Drawing.Size size = new System.Drawing.Size(61, 23);
		button2.Size = size;
		this.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		System.Windows.Forms.Panel panelSup = this.PanelSup;
		size = new System.Drawing.Size(349, 29);
		panelSup.Size = size;
		System.Windows.Forms.Panel panelInf = this.PanelInf;
		location = new System.Drawing.Point(0, 172);
		panelInf.Location = location;
		System.Windows.Forms.Panel panelInf2 = this.PanelInf;
		size = new System.Drawing.Size(349, 27);
		panelInf2.Size = size;
		this.Label1.AutoSize = true;
		System.Windows.Forms.Label label = this.Label1;
		location = new System.Drawing.Point(14, 49);
		label.Location = location;
		this.Label1.Name = "Label1";
		System.Windows.Forms.Label label2 = this.Label1;
		size = new System.Drawing.Size(87, 13);
		label2.Size = size;
		this.Label1.TabIndex = 3;
		this.Label1.Text = "Tipo Resolucion:";
		this.UcCBTipoResolucion.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCBTipoResolucion.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCBTipoResolucion.FormattingEnabled = true;
		this.UcCBTipoResolucion.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucCBTipoResolucion = this.UcCBTipoResolucion;
		location = new System.Drawing.Point(107, 46);
		ucCBTipoResolucion.Location = location;
		this.UcCBTipoResolucion.Name = "UcCBTipoResolucion";
		GRLL.Common.ucComboBox ucCBTipoResolucion2 = this.UcCBTipoResolucion;
		size = new System.Drawing.Size(146, 21);
		ucCBTipoResolucion2.Size = size;
		this.UcCBTipoResolucion.TabIndex = 4;
		this.Label2.AutoSize = true;
		System.Windows.Forms.Label label3 = this.Label2;
		location = new System.Drawing.Point(28, 79);
		label3.Location = location;
		this.Label2.Name = "Label2";
		System.Windows.Forms.Label label4 = this.Label2;
		size = new System.Drawing.Size(73, 13);
		label4.Size = size;
		this.Label2.TabIndex = 3;
		this.Label2.Text = "Fecha Resol.:";
		System.Windows.Forms.DateTimePicker dateTimePicker = this.DateTimePicker1;
		location = new System.Drawing.Point(107, 73);
		dateTimePicker.Location = location;
		this.DateTimePicker1.Name = "DateTimePicker1";
		System.Windows.Forms.DateTimePicker dateTimePicker2 = this.DateTimePicker1;
		size = new System.Drawing.Size(200, 20);
		dateTimePicker2.Size = size;
		this.DateTimePicker1.TabIndex = 5;
		this.Label3.AutoSize = true;
		System.Windows.Forms.Label label5 = this.Label3;
		location = new System.Drawing.Point(21, 102);
		label5.Location = location;
		this.Label3.Name = "Label3";
		System.Windows.Forms.Label label6 = this.Label3;
		size = new System.Drawing.Size(80, 13);
		label6.Size = size;
		this.Label3.TabIndex = 3;
		this.Label3.Text = "Numero Resol.:";
		this.UcTextBox1.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTextBox1.Formato = null;
		this.UcTextBox1.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTextBox = this.UcTextBox1;
		location = new System.Drawing.Point(107, 99);
		ucTextBox.Location = location;
		this.UcTextBox1.Name = "UcTextBox1";
		this.UcTextBox1.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTextBox1.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTextBox1.OnErrorBlankText = "";
		this.UcTextBox1.PadLeftLenght = 0;
		this.UcTextBox1.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTextBox1.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTextBox2 = this.UcTextBox1;
		size = new System.Drawing.Size(200, 20);
		ucTextBox2.Size = size;
		this.UcTextBox1.TabIndex = 6;
		this.UcTextBox1.TabNextControl = false;
		this.UcTextBox1.Tipo = GRLL.Common.ucTextBox.TipoDato.Todos;
		this.BtnGrabar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.BtnGrabar.AutoSize = true;
		this.BtnGrabar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.BtnGrabar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BtnGrabar.FlatAppearance.BorderSize = 0;
		this.BtnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BtnGrabar.Image = (System.Drawing.Image)resources.GetObject("BtnGrabar.Image");
		System.Windows.Forms.Button btnGrabar = this.BtnGrabar;
		location = new System.Drawing.Point(12, 143);
		btnGrabar.Location = location;
		this.BtnGrabar.Name = "BtnGrabar";
		System.Windows.Forms.Button btnGrabar2 = this.BtnGrabar;
		size = new System.Drawing.Size(65, 23);
		btnGrabar2.Size = size;
		this.BtnGrabar.TabIndex = 8;
		this.BtnGrabar.Text = "Grabar";
		this.BtnGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.BtnGrabar.UseVisualStyleBackColor = true;
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		size = new System.Drawing.Size(349, 199);
		this.ClientSize = size;
		this.Controls.Add(this.BtnGrabar);
		this.Controls.Add(this.UcCBTipoResolucion);
		this.Controls.Add(this.Label2);
		this.Controls.Add(this.Label3);
		this.Controls.Add(this.UcTextBox1);
		this.Controls.Add(this.DateTimePicker1);
		this.Controls.Add(this.Label1);
		this.MessageShow = true;
		this.Name = "FrmResoluciones";
		this.TitleMsg = "FrmConsulta";
		this.Titulo = "Resoluciones";
		this.TituloFrm = "Resoluciones";
		this.VerCmdCerrar = true;
		this.Controls.SetChildIndex(this.cmdCerrar, 0);
		this.Controls.SetChildIndex(this.Label1, 0);
		this.Controls.SetChildIndex(this.DateTimePicker1, 0);
		this.Controls.SetChildIndex(this.UcTextBox1, 0);
		this.Controls.SetChildIndex(this.Label3, 0);
		this.Controls.SetChildIndex(this.Label2, 0);
		this.Controls.SetChildIndex(this.UcCBTipoResolucion, 0);
		this.Controls.SetChildIndex(this.PanelSup, 0);
		this.Controls.SetChildIndex(this.PanelInf, 0);
		this.Controls.SetChildIndex(this.BtnGrabar, 0);
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	private void cmdCerrar_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void FrmResoluciones_Load(object sender, EventArgs e)
	{
		UcCBTipoResolucion.ValueMember = "IdTipoResolucion";
		UcCBTipoResolucion.DisplayMember = "DescripTipoResolucion";
		UcCBTipoResolucion.DataSource = TipoResolucionMapper.Instance().SelectAll();
		if (idResolucion != 0)
		{
			Resolucion resolucion = ResolucionMapper.Instance().SelectOneBy([SpecialName] (Resolucion V) => (V.idEmpleado == codemple) & (V.idResolucion == idResolucion));
			UcCBTipoResolucion.SelectedValue = resolucion.idTipoResolucion;
			DateTimePicker1.Value = (DateTime)resolucion.FechaResolucion;
			UcTextBox1.Text = resolucion.NumeroResolucion;
		}
	}

	private void BtnGrabar_Click(object sender, EventArgs e)
	{
		oResolucion.FechaResolucion = DateTimePicker1.Value;
		Resolucion resolucion = oResolucion;
		object selectedValue = UcCBTipoResolucion.SelectedValue;
		int? num = default(int?);
		resolucion.idTipoResolucion = ((selectedValue != null) ? ((int?)selectedValue) : num);
		if (UcTextBox1.TextLength == 0)
		{
			MessageBox.Show("Debe ingresar un Número de Resolución", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		oResolucion.NumeroResolucion = UcTextBox1.Text;
		oResolucion.idEmpleado = codemple;
		if (idResolucion == 0)
		{
			int count = ResolucionMapper.Instance().SelectBy([SpecialName] (Resolucion v) => v.idEmpleado == codemple).Count;
			int num2 = ((count == 0) ? 1 : checked(count + 1));
			oResolucion.idResolucion = num2;
			ResolucionMapper.Instance().Insert(oResolucion);
		}
		else
		{
			oResolucion.idResolucion = idResolucion;
			ResolucionMapper.Instance().Update(oResolucion);
		}
		DialogResult = DialogResult.OK;
	}
}
