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
public class FrmExpLaboral : FrmConsulta
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

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("UcTxtInstitucion")]
	private ucTextBox _UcTxtInstitucion;

	[AccessedThroughProperty("UcDTIngreso")]
	private ucDateTime _UcDTIngreso;

	[AccessedThroughProperty("UcDTEgreso")]
	private ucDateTime _UcDTEgreso;

	[AccessedThroughProperty("UcCBTipoInstitucion")]
	private ucComboBox _UcCBTipoInstitucion;

	[AccessedThroughProperty("UcTxtCargo")]
	private ucTextBox _UcTxtCargo;

	[AccessedThroughProperty("UcTxtUnidadOrganica")]
	private ucTextBox _UcTxtUnidadOrganica;

	[AccessedThroughProperty("BtnGrabar")]
	private Button _BtnGrabar;

	public int codemple;

	public int codExpLab;

	private ExpLaboral ExpLaboral;

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

	internal ucDateTime UcDTIngreso
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcDTIngreso;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcDTIngreso = value;
		}
	}

	internal ucDateTime UcDTEgreso
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcDTEgreso;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcDTEgreso = value;
		}
	}

	internal ucComboBox UcCBTipoInstitucion
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcCBTipoInstitucion;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcCBTipoInstitucion = value;
		}
	}

	internal ucTextBox UcTxtCargo
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtCargo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtCargo = value;
		}
	}

	internal ucTextBox UcTxtUnidadOrganica
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtUnidadOrganica;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtUnidadOrganica = value;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecursosHumanos.FrmExpLaboral));
		this.Label1 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label5 = new System.Windows.Forms.Label();
		this.Label6 = new System.Windows.Forms.Label();
		this.UcTxtInstitucion = new GRLL.Common.ucTextBox(this.components);
		this.UcDTIngreso = new GRLL.Common.ucDateTime();
		this.UcDTEgreso = new GRLL.Common.ucDateTime();
		this.UcCBTipoInstitucion = new GRLL.Common.ucComboBox();
		this.UcTxtCargo = new GRLL.Common.ucTextBox(this.components);
		this.UcTxtUnidadOrganica = new GRLL.Common.ucTextBox(this.components);
		this.BtnGrabar = new System.Windows.Forms.Button();
		this.SuspendLayout();
		this.cmdCerrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.cmdCerrar.AutoSize = true;
		this.cmdCerrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.cmdCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cmdCerrar.FlatAppearance.BorderSize = 0;
		this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.cmdCerrar.Image = (System.Drawing.Image)resources.GetObject("cmdCerrar.Image");
		System.Windows.Forms.Button button = this.cmdCerrar;
		System.Drawing.Point location = new System.Drawing.Point(265, 217);
		button.Location = location;
		System.Windows.Forms.Button button2 = this.cmdCerrar;
		System.Drawing.Size size = new System.Drawing.Size(61, 23);
		button2.Size = size;
		this.cmdCerrar.TabIndex = 8;
		this.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.cmdCerrar.Visible = true;
		System.Windows.Forms.Panel panelSup = this.PanelSup;
		size = new System.Drawing.Size(336, 24);
		panelSup.Size = size;
		System.Windows.Forms.Panel panelInf = this.PanelInf;
		location = new System.Drawing.Point(0, 249);
		panelInf.Location = location;
		System.Windows.Forms.Panel panelInf2 = this.PanelInf;
		size = new System.Drawing.Size(336, 27);
		panelInf2.Size = size;
		this.Label1.AutoSize = true;
		System.Windows.Forms.Label label = this.Label1;
		location = new System.Drawing.Point(12, 64);
		label.Location = location;
		this.Label1.Name = "Label1";
		System.Windows.Forms.Label label2 = this.Label1;
		size = new System.Drawing.Size(124, 13);
		label2.Size = size;
		this.Label1.TabIndex = 3;
		this.Label1.Text = "Nombre de la Institución:";
		this.Label2.AutoSize = true;
		System.Windows.Forms.Label label3 = this.Label2;
		location = new System.Drawing.Point(6, 162);
		label3.Location = location;
		this.Label2.Name = "Label2";
		System.Windows.Forms.Label label4 = this.Label2;
		size = new System.Drawing.Size(93, 13);
		label4.Size = size;
		this.Label2.TabIndex = 4;
		this.Label2.Text = "Fecha de Ingreso:";
		this.Label3.AutoSize = true;
		System.Windows.Forms.Label label5 = this.Label3;
		location = new System.Drawing.Point(8, 188);
		label5.Location = location;
		this.Label3.Name = "Label3";
		System.Windows.Forms.Label label6 = this.Label3;
		size = new System.Drawing.Size(91, 13);
		label6.Size = size;
		this.Label3.TabIndex = 5;
		this.Label3.Text = "Fecha de Egreso:";
		this.Label4.AutoSize = true;
		System.Windows.Forms.Label label7 = this.Label4;
		location = new System.Drawing.Point(61, 135);
		label7.Location = location;
		this.Label4.Name = "Label4";
		System.Windows.Forms.Label label8 = this.Label4;
		size = new System.Drawing.Size(38, 13);
		label8.Size = size;
		this.Label4.TabIndex = 6;
		this.Label4.Text = "Cargo:";
		this.Label5.AutoSize = true;
		System.Windows.Forms.Label label9 = this.Label5;
		location = new System.Drawing.Point(11, 109);
		label9.Location = location;
		this.Label5.Name = "Label5";
		System.Windows.Forms.Label label10 = this.Label5;
		size = new System.Drawing.Size(90, 13);
		label10.Size = size;
		this.Label5.TabIndex = 7;
		this.Label5.Text = "Unidad Orgánica:";
		this.Label6.AutoSize = true;
		System.Windows.Forms.Label label11 = this.Label6;
		location = new System.Drawing.Point(12, 33);
		label11.Location = location;
		this.Label6.Name = "Label6";
		System.Windows.Forms.Label label12 = this.Label6;
		size = new System.Drawing.Size(97, 13);
		label12.Size = size;
		this.Label6.TabIndex = 8;
		this.Label6.Text = "Tipo de Institución:";
		this.UcTxtInstitucion.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtInstitucion.Formato = null;
		this.UcTxtInstitucion.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtInstitucion = this.UcTxtInstitucion;
		location = new System.Drawing.Point(15, 80);
		ucTxtInstitucion.Location = location;
		this.UcTxtInstitucion.MaxLength = 120;
		this.UcTxtInstitucion.Name = "UcTxtInstitucion";
		this.UcTxtInstitucion.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtInstitucion.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtInstitucion.OnErrorBlankText = "";
		this.UcTxtInstitucion.PadLeftLenght = 0;
		this.UcTxtInstitucion.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtInstitucion.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtInstitucion2 = this.UcTxtInstitucion;
		size = new System.Drawing.Size(311, 20);
		ucTxtInstitucion2.Size = size;
		this.UcTxtInstitucion.TabIndex = 2;
		this.UcTxtInstitucion.TabNextControl = false;
		this.UcTxtInstitucion.Tipo = GRLL.Common.ucTextBox.TipoDato.Todos;
		this.UcDTIngreso.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcDTIngreso.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucDateTime ucDTIngreso = this.UcDTIngreso;
		location = new System.Drawing.Point(105, 158);
		ucDTIngreso.Location = location;
		this.UcDTIngreso.Name = "UcDTIngreso";
		GRLL.Common.ucDateTime ucDTIngreso2 = this.UcDTIngreso;
		size = new System.Drawing.Size(221, 20);
		ucDTIngreso2.Size = size;
		this.UcDTIngreso.TabIndex = 5;
		this.UcDTEgreso.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcDTEgreso.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucDateTime ucDTEgreso = this.UcDTEgreso;
		location = new System.Drawing.Point(105, 184);
		ucDTEgreso.Location = location;
		this.UcDTEgreso.Name = "UcDTEgreso";
		GRLL.Common.ucDateTime ucDTEgreso2 = this.UcDTEgreso;
		size = new System.Drawing.Size(221, 20);
		ucDTEgreso2.Size = size;
		this.UcDTEgreso.TabIndex = 6;
		this.UcCBTipoInstitucion.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCBTipoInstitucion.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCBTipoInstitucion.FormattingEnabled = true;
		this.UcCBTipoInstitucion.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucCBTipoInstitucion = this.UcCBTipoInstitucion;
		location = new System.Drawing.Point(115, 30);
		ucCBTipoInstitucion.Location = location;
		this.UcCBTipoInstitucion.Name = "UcCBTipoInstitucion";
		GRLL.Common.ucComboBox ucCBTipoInstitucion2 = this.UcCBTipoInstitucion;
		size = new System.Drawing.Size(145, 21);
		ucCBTipoInstitucion2.Size = size;
		this.UcCBTipoInstitucion.TabIndex = 1;
		this.UcTxtCargo.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtCargo.Formato = null;
		this.UcTxtCargo.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtCargo = this.UcTxtCargo;
		location = new System.Drawing.Point(105, 132);
		ucTxtCargo.Location = location;
		this.UcTxtCargo.MaxLength = 40;
		this.UcTxtCargo.Name = "UcTxtCargo";
		this.UcTxtCargo.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtCargo.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtCargo.OnErrorBlankText = "";
		this.UcTxtCargo.PadLeftLenght = 0;
		this.UcTxtCargo.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtCargo.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtCargo2 = this.UcTxtCargo;
		size = new System.Drawing.Size(221, 20);
		ucTxtCargo2.Size = size;
		this.UcTxtCargo.TabIndex = 4;
		this.UcTxtCargo.TabNextControl = false;
		this.UcTxtCargo.Tipo = GRLL.Common.ucTextBox.TipoDato.Todos;
		this.UcTxtUnidadOrganica.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtUnidadOrganica.Formato = null;
		this.UcTxtUnidadOrganica.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtUnidadOrganica = this.UcTxtUnidadOrganica;
		location = new System.Drawing.Point(105, 106);
		ucTxtUnidadOrganica.Location = location;
		this.UcTxtUnidadOrganica.MaxLength = 100;
		this.UcTxtUnidadOrganica.Name = "UcTxtUnidadOrganica";
		this.UcTxtUnidadOrganica.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtUnidadOrganica.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtUnidadOrganica.OnErrorBlankText = "";
		this.UcTxtUnidadOrganica.PadLeftLenght = 0;
		this.UcTxtUnidadOrganica.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtUnidadOrganica.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtUnidadOrganica2 = this.UcTxtUnidadOrganica;
		size = new System.Drawing.Size(221, 20);
		ucTxtUnidadOrganica2.Size = size;
		this.UcTxtUnidadOrganica.TabIndex = 3;
		this.UcTxtUnidadOrganica.TabNextControl = false;
		this.UcTxtUnidadOrganica.Tipo = GRLL.Common.ucTextBox.TipoDato.Todos;
		this.BtnGrabar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.BtnGrabar.AutoSize = true;
		this.BtnGrabar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.BtnGrabar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BtnGrabar.FlatAppearance.BorderSize = 0;
		this.BtnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BtnGrabar.Image = (System.Drawing.Image)resources.GetObject("BtnGrabar.Image");
		System.Windows.Forms.Button btnGrabar = this.BtnGrabar;
		location = new System.Drawing.Point(9, 217);
		btnGrabar.Location = location;
		this.BtnGrabar.Name = "BtnGrabar";
		System.Windows.Forms.Button btnGrabar2 = this.BtnGrabar;
		size = new System.Drawing.Size(65, 23);
		btnGrabar2.Size = size;
		this.BtnGrabar.TabIndex = 7;
		this.BtnGrabar.Text = "Grabar";
		this.BtnGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.BtnGrabar.UseVisualStyleBackColor = true;
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.Calculadora = false;
		size = new System.Drawing.Size(336, 276);
		this.ClientSize = size;
		this.Controls.Add(this.BtnGrabar);
		this.Controls.Add(this.Label6);
		this.Controls.Add(this.Label1);
		this.Controls.Add(this.UcTxtUnidadOrganica);
		this.Controls.Add(this.UcDTIngreso);
		this.Controls.Add(this.UcCBTipoInstitucion);
		this.Controls.Add(this.UcTxtCargo);
		this.Controls.Add(this.Label3);
		this.Controls.Add(this.UcTxtInstitucion);
		this.Controls.Add(this.UcDTEgreso);
		this.Controls.Add(this.Label2);
		this.Controls.Add(this.Label4);
		this.Controls.Add(this.Label5);
		this.MessageShow = true;
		this.Name = "FrmExpLaboral";
		this.TitleMsg = "FrmConsulta";
		this.Titulo = "Experiencia Laboral";
		this.VerCmdCerrar = true;
		this.Controls.SetChildIndex(this.Label5, 0);
		this.Controls.SetChildIndex(this.Label4, 0);
		this.Controls.SetChildIndex(this.Label2, 0);
		this.Controls.SetChildIndex(this.UcDTEgreso, 0);
		this.Controls.SetChildIndex(this.UcTxtInstitucion, 0);
		this.Controls.SetChildIndex(this.Label3, 0);
		this.Controls.SetChildIndex(this.cmdCerrar, 0);
		this.Controls.SetChildIndex(this.UcTxtCargo, 0);
		this.Controls.SetChildIndex(this.UcCBTipoInstitucion, 0);
		this.Controls.SetChildIndex(this.UcDTIngreso, 0);
		this.Controls.SetChildIndex(this.UcTxtUnidadOrganica, 0);
		this.Controls.SetChildIndex(this.Label1, 0);
		this.Controls.SetChildIndex(this.Label6, 0);
		this.Controls.SetChildIndex(this.PanelSup, 0);
		this.Controls.SetChildIndex(this.PanelInf, 0);
		this.Controls.SetChildIndex(this.BtnGrabar, 0);
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	public FrmExpLaboral()
	{
		base.Load += FrmExpLaboral_Load;
		__ENCAddToList(this);
		ExpLaboral = new ExpLaboral();
		InitializeComponent();
		Button button = cmdCerrar;
		Point location = new Point(255, 224);
		button.Location = location;
	}

	private void FrmExpLaboral_Load(object sender, EventArgs e)
	{
		UcCBTipoInstitucion.ValueMember = "IdTipoInstitucion";
		UcCBTipoInstitucion.DisplayMember = "DescripTipoInstitucion";
		UcCBTipoInstitucion.DataSource = TipoInstitucionMapper.Instance().SelectAll();
		if (codExpLab != 0)
		{
			ExpLaboral expLaboral = ExpLaboralMapper.Instance().SelectOneBy([SpecialName] (ExpLaboral V) => (V.IdEmpleado == codemple) & (V.IdExpLab == codExpLab));
			UcCBTipoInstitucion.SelectedValue = expLaboral.IdTipoInstitucion;
			UcDTIngreso.Value = (DateTime)expLaboral.FechaIngreso;
			UcDTEgreso.Value = (DateTime)expLaboral.FechaEgreso;
			UcTxtCargo.Text = expLaboral.Cargo;
			UcTxtUnidadOrganica.Text = expLaboral.UnidadOrganica;
			UcTxtInstitucion.Text = expLaboral.NomInstitucion;
			UcCBTipoInstitucion.Enabled = false;
		}
	}

	private void BtnGrabar_Click(object sender, EventArgs e)
	{
		List<ExpLaboral> list = ExpLaboralMapper.Instance().SelectBy([SpecialName] (ExpLaboral v) => v.IdEmpleado == codemple);
		if (list.Count > 0)
		{
			foreach (ExpLaboral item in list)
			{
				DateTime value = UcDTIngreso.Value;
				DateTime? fechaIngreso = item.FechaIngreso;
				bool? obj;
				bool? flag;
				if (!fechaIngreso.HasValue)
				{
					obj = null;
				}
				else
				{
					flag = DateTime.Compare(value, fechaIngreso.GetValueOrDefault()) >= 0;
					obj = flag;
				}
				bool? flag2 = obj;
				DateTime value2 = UcDTIngreso.Value;
				DateTime? fechaEgreso = item.FechaEgreso;
				bool? obj2;
				bool? flag3;
				if (!fechaEgreso.HasValue)
				{
					obj2 = null;
				}
				else
				{
					flag3 = DateTime.Compare(value2, fechaEgreso.GetValueOrDefault()) <= 0;
					obj2 = flag3;
				}
				bool? flag4 = obj2;
				bool? obj3;
				bool? flag6;
				if (flag2 ?? true)
				{
					if (!flag4.HasValue)
					{
						obj3 = null;
					}
					else if (flag4 != true)
					{
						bool? flag5 = false;
						obj3 = flag5;
					}
					else
					{
						obj3 = flag2;
					}
				}
				else
				{
					flag6 = false;
					obj3 = flag6;
				}
				bool? flag7 = obj3;
				if (flag7 == true && MessageBox.Show("El usuario en la fecha: " + Conversions.ToString(UcDTIngreso.Value.Date) + " a estado laborando en:" + item.NomInstitucion + " Desea continuar?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Cancel)
				{
					return;
				}
				value2 = UcDTEgreso.Value;
				fechaEgreso = item.FechaIngreso;
				bool? obj4;
				if (!fechaEgreso.HasValue)
				{
					obj4 = null;
				}
				else
				{
					flag2 = DateTime.Compare(value2, fechaEgreso.GetValueOrDefault()) >= 0;
					obj4 = flag2;
				}
				flag = obj4;
				value = UcDTEgreso.Value;
				fechaIngreso = item.FechaEgreso;
				bool? obj5;
				if (!fechaIngreso.HasValue)
				{
					obj5 = null;
				}
				else
				{
					flag7 = DateTime.Compare(value, fechaIngreso.GetValueOrDefault()) <= 0;
					obj5 = flag7;
				}
				flag6 = obj5;
				bool? obj6;
				if (flag ?? true)
				{
					if (!flag6.HasValue)
					{
						obj6 = null;
					}
					else if (flag6 != true)
					{
						bool? flag5 = false;
						obj6 = flag5;
					}
					else
					{
						obj6 = flag;
					}
				}
				else
				{
					flag4 = false;
					obj6 = flag4;
				}
				flag3 = obj6;
				if (flag3 == true && MessageBox.Show("El usuario en la fecha: " + Conversions.ToString(UcDTIngreso.Value.Date) + " a estado laborando en:" + item.NomInstitucion + " Desea continuar?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Cancel)
				{
					return;
				}
			}
		}
		ExpLaboral.FechaIngreso = UcDTIngreso.Value;
		ExpLaboral.FechaEgreso = UcDTEgreso.Value;
		ExpLaboral expLaboral = ExpLaboral;
		object selectedValue = UcCBTipoInstitucion.SelectedValue;
		int? num = default(int?);
		expLaboral.IdTipoInstitucion = ((selectedValue != null) ? ((int?)selectedValue) : num);
		ExpLaboral.Cargo = UcTxtCargo.Text;
		ExpLaboral.UnidadOrganica = UcTxtUnidadOrganica.Text;
		if (UcTxtInstitucion.TextLength == 0)
		{
			MessageBox.Show("Debe ingresar un nombre para la institucion", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		ExpLaboral.NomInstitucion = UcTxtInstitucion.Text;
		ExpLaboral.IdEmpleado = codemple;
		if (codExpLab == 0)
		{
			int count = ExpLaboralMapper.Instance().SelectBy([SpecialName] (ExpLaboral v) => v.IdEmpleado == codemple).Count;
			int idExpLab = ((count == 0) ? 1 : checked(count + 1));
			ExpLaboral.IdExpLab = idExpLab;
			ExpLaboralMapper.Instance().Insert(ExpLaboral);
		}
		else
		{
			ExpLaboral.IdExpLab = codExpLab;
			ExpLaboralMapper.Instance().Update(ExpLaboral);
		}
		DialogResult = DialogResult.OK;
	}

	private void BtnCerrar_Click(object sender, EventArgs e)
	{
		Close();
	}
}
