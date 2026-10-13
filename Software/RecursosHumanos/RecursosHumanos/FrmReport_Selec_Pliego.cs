using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using GRLL.Common;
using Microsoft.VisualBasic.CompilerServices;
using RecursosHumanos.My;
using RecursosHumanos.My.Resources;

namespace RecursosHumanos;

[DesignerGenerated]
public class FrmReport_Selec_Pliego : FrmConsulta
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("UcCmBPresupuestal")]
	private ucComboBox _UcCmBPresupuestal;

	[AccessedThroughProperty("BtnGenerar")]
	private Button _BtnGenerar;

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

	internal ucComboBox UcCmBPresupuestal
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcCmBPresupuestal;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcCmBPresupuestal = value;
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

	[DebuggerNonUserCode]
	public FrmReport_Selec_Pliego()
	{
		base.Load += FrmReport_Selec_Pliego_Load;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecursosHumanos.FrmReport_Selec_Pliego));
		this.Label1 = new System.Windows.Forms.Label();
		this.UcCmBPresupuestal = new GRLL.Common.ucComboBox();
		this.BtnGenerar = new System.Windows.Forms.Button();
		this.SuspendLayout();
		this.cmdCerrar.AutoSize = true;
		this.cmdCerrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.cmdCerrar.FlatAppearance.BorderSize = 0;
		this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.cmdCerrar.Image = (System.Drawing.Image)resources.GetObject("cmdCerrar.Image");
		System.Windows.Forms.Button button = this.cmdCerrar;
		System.Drawing.Point location = new System.Drawing.Point(275, 75);
		button.Location = location;
		System.Windows.Forms.Button button2 = this.cmdCerrar;
		System.Drawing.Size size = new System.Drawing.Size(61, 23);
		button2.Size = size;
		this.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.cmdCerrar.Visible = true;
		System.Windows.Forms.Panel panelSup = this.PanelSup;
		size = new System.Drawing.Size(348, 24);
		panelSup.Size = size;
		System.Windows.Forms.Panel panelInf = this.PanelInf;
		location = new System.Drawing.Point(0, 104);
		panelInf.Location = location;
		System.Windows.Forms.Panel panelInf2 = this.PanelInf;
		size = new System.Drawing.Size(348, 27);
		panelInf2.Size = size;
		this.Label1.AutoSize = true;
		System.Windows.Forms.Label label = this.Label1;
		location = new System.Drawing.Point(12, 41);
		label.Location = location;
		this.Label1.Name = "Label1";
		System.Windows.Forms.Label label2 = this.Label1;
		size = new System.Drawing.Size(107, 13);
		label2.Size = size;
		this.Label1.TabIndex = 3;
		this.Label1.Text = "Partida Presupuestal:";
		this.UcCmBPresupuestal.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCmBPresupuestal.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCmBPresupuestal.FormattingEnabled = true;
		this.UcCmBPresupuestal.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucCmBPresupuestal = this.UcCmBPresupuestal;
		location = new System.Drawing.Point(125, 38);
		ucCmBPresupuestal.Location = location;
		this.UcCmBPresupuestal.Name = "UcCmBPresupuestal";
		GRLL.Common.ucComboBox ucCmBPresupuestal2 = this.UcCmBPresupuestal;
		size = new System.Drawing.Size(139, 21);
		ucCmBPresupuestal2.Size = size;
		this.UcCmBPresupuestal.TabIndex = 4;
		this.BtnGenerar.AutoSize = true;
		this.BtnGenerar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.BtnGenerar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BtnGenerar.FlatAppearance.BorderSize = 0;
		this.BtnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BtnGenerar.Image = RecursosHumanos.My.Resources.Resources.document_out;
		System.Windows.Forms.Button btnGenerar = this.BtnGenerar;
		location = new System.Drawing.Point(270, 36);
		btnGenerar.Location = location;
		this.BtnGenerar.Name = "BtnGenerar";
		System.Windows.Forms.Button btnGenerar2 = this.BtnGenerar;
		size = new System.Drawing.Size(71, 23);
		btnGenerar2.Size = size;
		this.BtnGenerar.TabIndex = 5;
		this.BtnGenerar.Text = "Generar";
		this.BtnGenerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.BtnGenerar.UseVisualStyleBackColor = true;
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.Calculadora = false;
		size = new System.Drawing.Size(348, 131);
		this.ClientSize = size;
		this.Controls.Add(this.BtnGenerar);
		this.Controls.Add(this.Label1);
		this.Controls.Add(this.UcCmBPresupuestal);
		this.MessageShow = true;
		this.Name = "FrmReport_Selec_Pliego";
		this.TitleMsg = "FrmConsulta";
		this.Titulo = "Partida Presupuestal";
		this.VerCmdCerrar = true;
		this.Controls.SetChildIndex(this.cmdCerrar, 0);
		this.Controls.SetChildIndex(this.UcCmBPresupuestal, 0);
		this.Controls.SetChildIndex(this.Label1, 0);
		this.Controls.SetChildIndex(this.PanelSup, 0);
		this.Controls.SetChildIndex(this.PanelInf, 0);
		this.Controls.SetChildIndex(this.BtnGenerar, 0);
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	private void FrmReport_Selec_Pliego_Load(object sender, EventArgs e)
	{
		UcCmBPresupuestal.ValueMember = "IdTipoTrabajador";
		UcCmBPresupuestal.DisplayMember = "Descripcion";
		List<TipoTrabajador> list = TipoTrabajadorMapper.Instance().SelectAll();
		list.Insert(0, new TipoTrabajador
		{
			IdTipoTrabajador = 0,
			Descripcion = "Todos"
		});
		UcCmBPresupuestal.DataSource = list;
	}

	private void BtnGenerar_Click(object sender, EventArgs e)
	{
		int codPre = Conversions.ToInteger(UcCmBPresupuestal.SelectedValue);
		FrmReportCuadro frmReportCuadro = new FrmReportCuadro();
		frmReportCuadro.CodPre = codPre;
		frmReportCuadro.MdiParent = MyProject.Forms.MainMDI;
		frmReportCuadro.WindowState = FormWindowState.Maximized;
		frmReportCuadro.Show();
		Close();
	}

	private void BtnCerrar_Click(object sender, EventArgs e)
	{
		Close();
	}
}
