using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ClassRRHH;
using GRLL.Common;
using Microsoft.VisualBasic.CompilerServices;
using RecursosHumanos.My.Resources;

namespace RecursosHumanos;

[DesignerGenerated]
public class FrmRotaciones : FrmConsulta
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("DateTimePicker1")]
	private DateTimePicker _DateTimePicker1;

	[AccessedThroughProperty("UcTextBox1")]
	private ucTextBox _UcTextBox1;

	[AccessedThroughProperty("UcCBArea")]
	private ucComboBox _UcCBArea;

	[AccessedThroughProperty("btnGrabar")]
	private Button _btnGrabar;

	private RRHHClass objClassRRHH;

	public int idEmpleado;

	public int idRotacion;

	private Rotacion oRotaciones;

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

	internal ucComboBox UcCBArea
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcCBArea;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcCBArea = value;
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

	public FrmRotaciones()
	{
		base.Load += FrmRotaciones_Load;
		__ENCAddToList(this);
		objClassRRHH = new RRHHClass();
		oRotaciones = new Rotacion();
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecursosHumanos.FrmRotaciones));
		this.Label1 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
		this.UcTextBox1 = new GRLL.Common.ucTextBox(this.components);
		this.UcCBArea = new GRLL.Common.ucComboBox();
		this.btnGrabar = new System.Windows.Forms.Button();
		this.SuspendLayout();
		this.cmdCerrar.AutoSize = true;
		this.cmdCerrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.cmdCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cmdCerrar.FlatAppearance.BorderSize = 0;
		this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.cmdCerrar.Image = RecursosHumanos.My.Resources.Resources._exit;
		System.Windows.Forms.Button button = this.cmdCerrar;
		System.Drawing.Point location = new System.Drawing.Point(256, 162);
		button.Location = location;
		System.Windows.Forms.Button button2 = this.cmdCerrar;
		System.Drawing.Size size = new System.Drawing.Size(61, 23);
		button2.Size = size;
		this.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		System.Windows.Forms.Panel panelSup = this.PanelSup;
		size = new System.Drawing.Size(329, 29);
		panelSup.Size = size;
		System.Windows.Forms.Panel panelInf = this.PanelInf;
		location = new System.Drawing.Point(0, 191);
		panelInf.Location = location;
		System.Windows.Forms.Panel panelInf2 = this.PanelInf;
		size = new System.Drawing.Size(329, 27);
		panelInf2.Size = size;
		this.Label1.AutoSize = true;
		System.Windows.Forms.Label label = this.Label1;
		location = new System.Drawing.Point(19, 62);
		label.Location = location;
		this.Label1.Name = "Label1";
		System.Windows.Forms.Label label2 = this.Label1;
		size = new System.Drawing.Size(75, 13);
		label2.Size = size;
		this.Label1.TabIndex = 3;
		this.Label1.Text = "Fecha Memo.:";
		this.Label2.AutoSize = true;
		System.Windows.Forms.Label label3 = this.Label2;
		location = new System.Drawing.Point(12, 93);
		label3.Location = location;
		this.Label2.Name = "Label2";
		System.Windows.Forms.Label label4 = this.Label2;
		size = new System.Drawing.Size(82, 13);
		label4.Size = size;
		this.Label2.TabIndex = 3;
		this.Label2.Text = "Numero Memo.:";
		this.Label3.AutoSize = true;
		System.Windows.Forms.Label label5 = this.Label3;
		location = new System.Drawing.Point(12, 126);
		label5.Location = location;
		this.Label3.Name = "Label3";
		System.Windows.Forms.Label label6 = this.Label3;
		size = new System.Drawing.Size(82, 13);
		label6.Size = size;
		this.Label3.TabIndex = 3;
		this.Label3.Text = "Oficina Destino:";
		System.Windows.Forms.DateTimePicker dateTimePicker = this.DateTimePicker1;
		location = new System.Drawing.Point(100, 56);
		dateTimePicker.Location = location;
		this.DateTimePicker1.Name = "DateTimePicker1";
		System.Windows.Forms.DateTimePicker dateTimePicker2 = this.DateTimePicker1;
		size = new System.Drawing.Size(200, 20);
		dateTimePicker2.Size = size;
		this.DateTimePicker1.TabIndex = 4;
		this.UcTextBox1.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTextBox1.Formato = null;
		this.UcTextBox1.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTextBox = this.UcTextBox1;
		location = new System.Drawing.Point(100, 90);
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
		this.UcTextBox1.TabIndex = 5;
		this.UcTextBox1.TabNextControl = false;
		this.UcTextBox1.Tipo = GRLL.Common.ucTextBox.TipoDato.Todos;
		this.UcCBArea.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCBArea.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCBArea.FormattingEnabled = true;
		this.UcCBArea.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucCBArea = this.UcCBArea;
		location = new System.Drawing.Point(100, 123);
		ucCBArea.Location = location;
		this.UcCBArea.Name = "UcCBArea";
		GRLL.Common.ucComboBox ucCBArea2 = this.UcCBArea;
		size = new System.Drawing.Size(200, 21);
		ucCBArea2.Size = size;
		this.UcCBArea.TabIndex = 6;
		this.btnGrabar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.btnGrabar.AutoSize = true;
		this.btnGrabar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.btnGrabar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnGrabar.FlatAppearance.BorderSize = 0;
		this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnGrabar.Image = (System.Drawing.Image)resources.GetObject("btnGrabar.Image");
		System.Windows.Forms.Button button3 = this.btnGrabar;
		location = new System.Drawing.Point(12, 162);
		button3.Location = location;
		this.btnGrabar.Name = "btnGrabar";
		System.Windows.Forms.Button button4 = this.btnGrabar;
		size = new System.Drawing.Size(65, 23);
		button4.Size = size;
		this.btnGrabar.TabIndex = 18;
		this.btnGrabar.Text = "Grabar";
		this.btnGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.btnGrabar.UseVisualStyleBackColor = true;
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		size = new System.Drawing.Size(329, 218);
		this.ClientSize = size;
		this.Controls.Add(this.btnGrabar);
		this.Controls.Add(this.Label1);
		this.Controls.Add(this.Label2);
		this.Controls.Add(this.Label3);
		this.Controls.Add(this.UcCBArea);
		this.Controls.Add(this.UcTextBox1);
		this.Controls.Add(this.DateTimePicker1);
		this.MessageShow = true;
		this.Name = "FrmRotaciones";
		this.TitleMsg = "FrmConsulta";
		this.Titulo = "Rotaciones";
		this.TituloFrm = "Rotaciones";
		this.VerCmdCerrar = true;
		this.Controls.SetChildIndex(this.DateTimePicker1, 0);
		this.Controls.SetChildIndex(this.UcTextBox1, 0);
		this.Controls.SetChildIndex(this.UcCBArea, 0);
		this.Controls.SetChildIndex(this.Label3, 0);
		this.Controls.SetChildIndex(this.Label2, 0);
		this.Controls.SetChildIndex(this.Label1, 0);
		this.Controls.SetChildIndex(this.PanelSup, 0);
		this.Controls.SetChildIndex(this.PanelInf, 0);
		this.Controls.SetChildIndex(this.cmdCerrar, 0);
		this.Controls.SetChildIndex(this.btnGrabar, 0);
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	private void FrmRotaciones_Load(object sender, EventArgs e)
	{
		UcCBArea.ValueMember = "idAreaOrganiz";
		UcCBArea.DisplayMember = "AreaOrganizacional";
		DataTable dataTable = (DataTable)objClassRRHH.llena_Area();
		DataRow dataRow = dataTable.NewRow();
		dataRow["idAreaOrganiz"] = 0;
		dataRow["AreaOrganizacional"] = "(Seleccionar)";
		dataTable.Rows.InsertAt(dataRow, 0);
		UcCBArea.DataSource = dataTable;
		if (idRotacion != 0)
		{
			Rotacion rotacion = RotacionMapper.Instance().SelectOneBy([SpecialName] (Rotacion V) => (V.idEmpleado == idEmpleado) & (V.idRotacion == idRotacion));
			DateTimePicker1.Value = (DateTime)rotacion.FechaMemo;
			UcTextBox1.Text = rotacion.NroMemo;
			UcCBArea.SelectedValue = rotacion.idAreaOrganiz;
		}
	}

	private void btnGrabar_Click(object sender, EventArgs e)
	{
		oRotaciones.FechaMemo = DateTimePicker1.Value;
		if (UcTextBox1.TextLength == 0)
		{
			MessageBox.Show("Debe ingresar un numero de Memorandum ", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		oRotaciones.NroMemo = UcTextBox1.Text.Trim();
		Rotacion rotacion = oRotaciones;
		object selectedValue = UcCBArea.SelectedValue;
		int? num = default(int?);
		rotacion.idAreaOrganiz = ((selectedValue != null) ? ((int?)selectedValue) : num);
		oRotaciones.Year = DateTime.Today.Year;
		oRotaciones.idEmpleado = idEmpleado;
		if (idRotacion == 0)
		{
			int count = RotacionMapper.Instance().SelectBy([SpecialName] (Rotacion v) => v.idEmpleado == idEmpleado).Count;
			int num2 = ((count == 0) ? 1 : checked(count + 1));
			oRotaciones.idRotacion = num2;
			RotacionMapper.Instance().Insert(oRotaciones);
		}
		else
		{
			oRotaciones.idRotacion = idRotacion;
			RotacionMapper.Instance().Update(oRotaciones);
		}
		DialogResult = DialogResult.OK;
	}

	private void cmdCerrar_Click(object sender, EventArgs e)
	{
		Close();
	}
}
