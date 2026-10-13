using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using GRLL.Common;
using Microsoft.VisualBasic.CompilerServices;
using RecursosHumanos.My.Resources;

namespace RecursosHumanos;

[DesignerGenerated]
public class FrmReport_SelecMes : FrmConsulta
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("UcCboMes1")]
	private ucCboMes _UcCboMes1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("BtnGenerar")]
	private Button _BtnGenerar;

	[AccessedThroughProperty("CheckEdit1")]
	private CheckEdit _CheckEdit1;

	internal ucCboMes UcCboMes1
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcCboMes1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcCboMes1 = value;
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

	internal Button BtnGenerar
	{
		[DebuggerNonUserCode]
		get
		{
			return _BtnGenerar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = BtnGenerar_Click;
			if (_BtnGenerar != null)
			{
				_BtnGenerar.Click -= value2;
			}
			_BtnGenerar = value;
			if (_BtnGenerar != null)
			{
				_BtnGenerar.Click += value2;
			}
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

	[DebuggerNonUserCode]
	public FrmReport_SelecMes()
	{
		base.Load += FrmReport_SelecMes_Load;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecursosHumanos.FrmReport_SelecMes));
		this.UcCboMes1 = new GRLL.Common.ucCboMes(this.components);
		this.Label1 = new System.Windows.Forms.Label();
		this.BtnGenerar = new System.Windows.Forms.Button();
		this.CheckEdit1 = new DevExpress.XtraEditors.CheckEdit();
		((System.ComponentModel.ISupportInitialize)this.CheckEdit1.Properties).BeginInit();
		this.SuspendLayout();
		this.cmdCerrar.AutoSize = true;
		this.cmdCerrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.cmdCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cmdCerrar.FlatAppearance.BorderSize = 0;
		this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.cmdCerrar.Image = (System.Drawing.Image)resources.GetObject("cmdCerrar.Image");
		System.Windows.Forms.Button button = this.cmdCerrar;
		System.Drawing.Point location = new System.Drawing.Point(202, 79);
		button.Location = location;
		System.Windows.Forms.Button button2 = this.cmdCerrar;
		System.Drawing.Size size = new System.Drawing.Size(61, 23);
		button2.Size = size;
		this.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.cmdCerrar.Visible = true;
		System.Windows.Forms.Panel panelSup = this.PanelSup;
		size = new System.Drawing.Size(275, 24);
		panelSup.Size = size;
		System.Windows.Forms.Panel panelInf = this.PanelInf;
		location = new System.Drawing.Point(0, 108);
		panelInf.Location = location;
		System.Windows.Forms.Panel panelInf2 = this.PanelInf;
		size = new System.Drawing.Size(275, 27);
		panelInf2.Size = size;
		this.UcCboMes1.DisplayMember = "Mes";
		this.UcCboMes1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.UcCboMes1.FormattingEnabled = true;
		GRLL.Common.ucCboMes ucCboMes = this.UcCboMes1;
		location = new System.Drawing.Point(48, 39);
		ucCboMes.Location = location;
		this.UcCboMes1.Name = "UcCboMes1";
		GRLL.Common.ucCboMes ucCboMes2 = this.UcCboMes1;
		size = new System.Drawing.Size(121, 21);
		ucCboMes2.Size = size;
		this.UcCboMes1.TabIndex = 0;
		this.UcCboMes1.ValueMember = "IDMes";
		this.Label1.AutoSize = true;
		System.Windows.Forms.Label label = this.Label1;
		location = new System.Drawing.Point(12, 42);
		label.Location = location;
		this.Label1.Name = "Label1";
		System.Windows.Forms.Label label2 = this.Label1;
		size = new System.Drawing.Size(30, 13);
		label2.Size = size;
		this.Label1.TabIndex = 3;
		this.Label1.Text = "Mes:";
		this.BtnGenerar.AutoSize = true;
		this.BtnGenerar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.BtnGenerar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BtnGenerar.FlatAppearance.BorderSize = 0;
		this.BtnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BtnGenerar.Image = RecursosHumanos.My.Resources.Resources.document_out;
		System.Windows.Forms.Button btnGenerar = this.BtnGenerar;
		location = new System.Drawing.Point(12, 79);
		btnGenerar.Location = location;
		this.BtnGenerar.Name = "BtnGenerar";
		System.Windows.Forms.Button btnGenerar2 = this.BtnGenerar;
		size = new System.Drawing.Size(71, 23);
		btnGenerar2.Size = size;
		this.BtnGenerar.TabIndex = 4;
		this.BtnGenerar.Text = "Generar";
		this.BtnGenerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.BtnGenerar.UseVisualStyleBackColor = true;
		DevExpress.XtraEditors.CheckEdit checkEdit = this.CheckEdit1;
		location = new System.Drawing.Point(175, 42);
		checkEdit.Location = location;
		this.CheckEdit1.Name = "CheckEdit1";
		this.CheckEdit1.Properties.Caption = "Mostrar Edad";
		DevExpress.XtraEditors.CheckEdit checkEdit2 = this.CheckEdit1;
		size = new System.Drawing.Size(89, 18);
		checkEdit2.Size = size;
		this.CheckEdit1.TabIndex = 5;
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.Calculadora = false;
		size = new System.Drawing.Size(275, 135);
		this.ClientSize = size;
		this.Controls.Add(this.Label1);
		this.Controls.Add(this.UcCboMes1);
		this.Controls.Add(this.CheckEdit1);
		this.Controls.Add(this.BtnGenerar);
		this.MessageShow = true;
		this.Name = "FrmReport_SelecMes";
		this.TitleMsg = "FrmConsulta";
		this.Titulo = "Reporte de Cumpleaños";
		this.VerCmdCerrar = true;
		this.Controls.SetChildIndex(this.BtnGenerar, 0);
		this.Controls.SetChildIndex(this.cmdCerrar, 0);
		this.Controls.SetChildIndex(this.CheckEdit1, 0);
		this.Controls.SetChildIndex(this.UcCboMes1, 0);
		this.Controls.SetChildIndex(this.Label1, 0);
		this.Controls.SetChildIndex(this.PanelSup, 0);
		this.Controls.SetChildIndex(this.PanelInf, 0);
		((System.ComponentModel.ISupportInitialize)this.CheckEdit1.Properties).EndInit();
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	private void BtnGenerar_Click(object sender, EventArgs e)
	{
		FrmReportCumple frmReportCumple = new FrmReportCumple();
		frmReportCumple.mes = Conversions.ToInteger(UcCboMes1.SelectedValue);
		if (CheckEdit1.Checked)
		{
			frmReportCumple.mostedad = true;
		}
		else
		{
			frmReportCumple.mostedad = false;
		}
		frmReportCumple.WindowState = FormWindowState.Maximized;
		frmReportCumple.Show();
		Close();
	}

	private void FrmReport_SelecMes_Load(object sender, EventArgs e)
	{
		StartPosition = FormStartPosition.CenterParent;
	}
}
