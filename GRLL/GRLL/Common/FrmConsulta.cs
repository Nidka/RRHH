using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace GRLL.Common;

[DesignerGenerated]
public class FrmConsulta : frmBase
{
	private IContainer components;

	[AccessedThroughProperty("lbl_titulo")]
	private ucLabel _lbl_titulo;

	[AccessedThroughProperty("lbl_titulo1")]
	private Label _lbl_titulo1;

	internal ucLabel lbl_titulo
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbl_titulo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbl_titulo = value;
		}
	}

	internal Label lbl_titulo1
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbl_titulo1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbl_titulo1 = value;
		}
	}

	public string Titulo
	{
		get
		{
			return lbl_titulo.Text;
		}
		set
		{
			lbl_titulo.Text = value;
			lbl_titulo1.Text = value;
		}
	}

	[DebuggerNonUserCode]
	public FrmConsulta()
	{
		base.Load += FrmConsulta_Load;
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
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
		this.lbl_titulo = new GRLL.Common.ucLabel();
		this.lbl_titulo1 = new System.Windows.Forms.Label();
		this.PanelSup.SuspendLayout();
		this.SuspendLayout();
		System.Windows.Forms.Button button = this.cmdCerrar;
		System.Drawing.Point location = new System.Drawing.Point(12, 490);
		button.Location = location;
		this.PanelSup.Controls.Add(this.lbl_titulo);
		this.PanelSup.Controls.Add(this.lbl_titulo1);
		System.Windows.Forms.Panel panelSup = this.PanelSup;
		System.Drawing.Size size = new System.Drawing.Size(644, 29);
		panelSup.Size = size;
		this.PanelSup.Controls.SetChildIndex(this.lbl_titulo1, 0);
		this.PanelSup.Controls.SetChildIndex(this.lbl_titulo, 0);
		System.Windows.Forms.Panel panelInf = this.PanelInf;
		location = new System.Drawing.Point(0, 520);
		panelInf.Location = location;
		System.Windows.Forms.Panel panelInf2 = this.PanelInf;
		size = new System.Drawing.Size(644, 27);
		panelInf2.Size = size;
		this.lbl_titulo.Font = new System.Drawing.Font("Arial Narrow", 15.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.lbl_titulo.ForeColor = System.Drawing.Color.CornflowerBlue;
		GRLL.Common.ucLabel obj = this.lbl_titulo;
		location = new System.Drawing.Point(28, 1);
		obj.Location = location;
		this.lbl_titulo.Name = "lbl_titulo";
		GRLL.Common.ucLabel obj2 = this.lbl_titulo;
		size = new System.Drawing.Size(135, 28);
		obj2.Size = size;
		this.lbl_titulo.TabIndex = 27;
		this.lbl_titulo.Text = "Título principal";
		this.lbl_titulo1.AutoSize = true;
		this.lbl_titulo1.Font = new System.Drawing.Font("Arial Narrow", 15.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.lbl_titulo1.ForeColor = System.Drawing.Color.Navy;
		System.Windows.Forms.Label label = this.lbl_titulo1;
		location = new System.Drawing.Point(29, -1);
		label.Location = location;
		this.lbl_titulo1.Name = "lbl_titulo1";
		System.Windows.Forms.Label label2 = this.lbl_titulo1;
		size = new System.Drawing.Size(141, 25);
		label2.Size = size;
		this.lbl_titulo1.TabIndex = 26;
		this.lbl_titulo1.Text = "Título principal";
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		size = new System.Drawing.Size(644, 547);
		this.ClientSize = size;
		this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
		this.MaximizeBox = true;
		this.MessageShow = true;
		this.MinimizeBox = true;
		this.Name = "FrmConsulta";
		this.Text = "";
		this.TitleMsg = "frmBase";
		this.PanelSup.ResumeLayout(false);
		this.PanelSup.PerformLayout();
		this.ResumeLayout(false);
	}

	protected void Limpiar(Control control)
	{
		bool Retorno = true;
		if (!Validate())
		{
			return;
		}
		foreach (Control var in control.Controls)
		{
			if (var.GetType() == typeof(ucTextBox))
			{
				ucTextBox texto = (ucTextBox)var;
				texto.Clear();
			}
		}
	}

	protected bool Validar(Control Control)
	{
		bool Retorno = true;
		if (!Validate())
		{
			return false;
		}
		foreach (Control var in Control.Controls)
		{
			if (var.GetType() == typeof(ucTextBox) && var.Text.Trim().Length == 0)
			{
				ucTextBox texto = (ucTextBox)var;
				if (texto.IsRequired && !texto.Validar())
				{
					Retorno = false;
				}
			}
		}
		return Retorno;
	}

	private void FrmConsulta_Load(object sender, EventArgs e)
	{
	}
}
