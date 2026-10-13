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
public class FrmMantMotivo : FrmConsulta
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("CheckEdit1")]
	private CheckEdit _CheckEdit1;

	[AccessedThroughProperty("UcTxtMotivo")]
	private ucTextBox _UcTxtMotivo;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("UcTxtAbreviatura")]
	private ucTextBox _UcTxtAbreviatura;

	public int idMotivo;

	public int idTipo;

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

	internal ucTextBox UcTxtMotivo
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtMotivo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtMotivo = value;
		}
	}

	internal Button Button1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = Button1_Click;
			if (_Button1 != null)
			{
				_Button1.Click -= value2;
			}
			_Button1 = value;
			if (_Button1 != null)
			{
				_Button1.Click += value2;
			}
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

	internal ucTextBox UcTxtAbreviatura
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtAbreviatura;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtAbreviatura = value;
		}
	}

	[DebuggerNonUserCode]
	public FrmMantMotivo()
	{
		base.Load += FrmMantMotivo_Load;
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
		this.Label1 = new System.Windows.Forms.Label();
		this.CheckEdit1 = new DevExpress.XtraEditors.CheckEdit();
		this.UcTxtMotivo = new GRLL.Common.ucTextBox(this.components);
		this.Button1 = new System.Windows.Forms.Button();
		this.Label2 = new System.Windows.Forms.Label();
		this.UcTxtAbreviatura = new GRLL.Common.ucTextBox(this.components);
		((System.ComponentModel.ISupportInitialize)this.CheckEdit1.Properties).BeginInit();
		this.SuspendLayout();
		this.cmdCerrar.AutoSize = true;
		this.cmdCerrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.cmdCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cmdCerrar.FlatAppearance.BorderSize = 0;
		this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.cmdCerrar.Image = RecursosHumanos.My.Resources.Resources._exit;
		System.Windows.Forms.Button button = this.cmdCerrar;
		System.Drawing.Point location = new System.Drawing.Point(247, 110);
		button.Location = location;
		System.Windows.Forms.Button button2 = this.cmdCerrar;
		System.Drawing.Size size = new System.Drawing.Size(61, 23);
		button2.Size = size;
		this.cmdCerrar.TabIndex = 5;
		this.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		System.Windows.Forms.Panel panelSup = this.PanelSup;
		size = new System.Drawing.Size(320, 29);
		panelSup.Size = size;
		System.Windows.Forms.Panel panelInf = this.PanelInf;
		location = new System.Drawing.Point(0, 139);
		panelInf.Location = location;
		System.Windows.Forms.Panel panelInf2 = this.PanelInf;
		size = new System.Drawing.Size(320, 26);
		panelInf2.Size = size;
		this.Label1.AutoSize = true;
		System.Windows.Forms.Label label = this.Label1;
		location = new System.Drawing.Point(7, 48);
		label.Location = location;
		this.Label1.Name = "Label1";
		System.Windows.Forms.Label label2 = this.Label1;
		size = new System.Drawing.Size(66, 13);
		label2.Size = size;
		this.Label1.TabIndex = 3;
		this.Label1.Text = "Descripción:";
		DevExpress.XtraEditors.CheckEdit checkEdit = this.CheckEdit1;
		location = new System.Drawing.Point(186, 70);
		checkEdit.Location = location;
		this.CheckEdit1.Name = "CheckEdit1";
		this.CheckEdit1.Properties.Caption = "Asalariado";
		DevExpress.XtraEditors.CheckEdit checkEdit2 = this.CheckEdit1;
		size = new System.Drawing.Size(75, 18);
		checkEdit2.Size = size;
		this.CheckEdit1.TabIndex = 3;
		this.UcTxtMotivo.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtMotivo.Formato = null;
		this.UcTxtMotivo.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtMotivo = this.UcTxtMotivo;
		location = new System.Drawing.Point(79, 41);
		ucTxtMotivo.Location = location;
		this.UcTxtMotivo.Name = "UcTxtMotivo";
		this.UcTxtMotivo.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtMotivo.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtMotivo.OnErrorBlankText = "";
		this.UcTxtMotivo.PadLeftLenght = 0;
		this.UcTxtMotivo.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtMotivo.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtMotivo2 = this.UcTxtMotivo;
		size = new System.Drawing.Size(235, 20);
		ucTxtMotivo2.Size = size;
		this.UcTxtMotivo.TabIndex = 1;
		this.UcTxtMotivo.TabNextControl = false;
		this.UcTxtMotivo.Tipo = GRLL.Common.ucTextBox.TipoDato.Todos;
		this.Button1.AutoSize = true;
		this.Button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.Button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.Button1.FlatAppearance.BorderSize = 0;
		this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button1.Image = RecursosHumanos.My.Resources.Resources.disk_blue1;
		System.Windows.Forms.Button button3 = this.Button1;
		location = new System.Drawing.Point(12, 110);
		button3.Location = location;
		this.Button1.Name = "Button1";
		System.Windows.Forms.Button button4 = this.Button1;
		size = new System.Drawing.Size(71, 23);
		button4.Size = size;
		this.Button1.TabIndex = 4;
		this.Button1.Text = "&Guardar";
		this.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.Button1.UseVisualStyleBackColor = true;
		this.Label2.AutoSize = true;
		System.Windows.Forms.Label label3 = this.Label2;
		location = new System.Drawing.Point(9, 73);
		label3.Location = location;
		this.Label2.Name = "Label2";
		System.Windows.Forms.Label label4 = this.Label2;
		size = new System.Drawing.Size(64, 13);
		label4.Size = size;
		this.Label2.TabIndex = 7;
		this.Label2.Text = "Abreviatura:";
		this.UcTxtAbreviatura.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtAbreviatura.Formato = null;
		this.UcTxtAbreviatura.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtAbreviatura = this.UcTxtAbreviatura;
		location = new System.Drawing.Point(79, 70);
		ucTxtAbreviatura.Location = location;
		this.UcTxtAbreviatura.Name = "UcTxtAbreviatura";
		this.UcTxtAbreviatura.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtAbreviatura.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtAbreviatura.OnErrorBlankText = "";
		this.UcTxtAbreviatura.PadLeftLenght = 0;
		this.UcTxtAbreviatura.RegularExpression = "^[A-Z,a-z,\\s]+$";
		this.UcTxtAbreviatura.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtAbreviatura.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtAbreviatura2 = this.UcTxtAbreviatura;
		size = new System.Drawing.Size(100, 20);
		ucTxtAbreviatura2.Size = size;
		this.UcTxtAbreviatura.TabIndex = 2;
		this.UcTxtAbreviatura.TabNextControl = false;
		this.UcTxtAbreviatura.Tipo = GRLL.Common.ucTextBox.TipoDato.SoloLetras;
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		size = new System.Drawing.Size(320, 165);
		this.ClientSize = size;
		this.Controls.Add(this.UcTxtMotivo);
		this.Controls.Add(this.Label1);
		this.Controls.Add(this.UcTxtAbreviatura);
		this.Controls.Add(this.Label2);
		this.Controls.Add(this.CheckEdit1);
		this.Controls.Add(this.Button1);
		this.MessageShow = true;
		this.Name = "FrmMantMotivo";
		this.TitleMsg = "FrmConsulta";
		this.Titulo = "Motivos";
		this.VerCmdCerrar = true;
		this.Controls.SetChildIndex(this.Button1, 0);
		this.Controls.SetChildIndex(this.cmdCerrar, 0);
		this.Controls.SetChildIndex(this.CheckEdit1, 0);
		this.Controls.SetChildIndex(this.Label2, 0);
		this.Controls.SetChildIndex(this.UcTxtAbreviatura, 0);
		this.Controls.SetChildIndex(this.Label1, 0);
		this.Controls.SetChildIndex(this.UcTxtMotivo, 0);
		this.Controls.SetChildIndex(this.PanelSup, 0);
		this.Controls.SetChildIndex(this.PanelInf, 0);
		((System.ComponentModel.ISupportInitialize)this.CheckEdit1.Properties).EndInit();
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	private void FrmMantMotivo_Load(object sender, EventArgs e)
	{
		if ((idMotivo != 0 && idTipo != 0) ? true : false)
		{
			Motivo_Perm motivo_Perm = Motivo_PermMapper.Instance().SelectBy([SpecialName] (Motivo_Perm V) => V.idMotivo == idMotivo).First();
			UcTxtMotivo.Text = motivo_Perm.Descrip_Motivo;
			CheckEdit1.EditValue = motivo_Perm.Salario;
			UcTxtAbreviatura.Text = motivo_Perm.Abrev;
			Motivo_PermMapper.Instance().Update(motivo_Perm);
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		Motivo_Perm motivo_Perm = new Motivo_Perm();
		motivo_Perm.Descrip_Motivo = UcTxtMotivo.Text;
		object editValue = CheckEdit1.EditValue;
		bool? flag = default(bool?);
		motivo_Perm.Salario = ((editValue != null) ? ((bool?)editValue) : flag);
		motivo_Perm.idTipoPermiso = idTipo;
		motivo_Perm.Abrev = UcTxtAbreviatura.Text.Trim();
		if (Conversions.ToDouble(RRHH.IdROl) == 10.0)
		{
			motivo_Perm.TipoModalidad = 'P';
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 14.0)
		{
			motivo_Perm.TipoModalidad = 'C';
		}
		motivo_Perm.Activo = true;
		if (idMotivo == 0)
		{
			int num = Motivo_PermMapper.Instance().SelectAll().Max([SpecialName] (Motivo_Perm v) => v.idMotivo);
			motivo_Perm.idMotivo = checked(num + 1);
			Motivo_PermMapper.Instance().Insert(motivo_Perm);
		}
		else
		{
			motivo_Perm.idMotivo = idMotivo;
			Motivo_PermMapper.Instance().Update(motivo_Perm);
		}
		DialogResult = DialogResult.OK;
	}
}
