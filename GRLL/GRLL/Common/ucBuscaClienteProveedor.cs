using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace GRLL.Common;

[DesignerGenerated]
public class ucBuscaClienteProveedor : UserControl
{
	public delegate void ValidatedRUCEventHandler(bool cancel);

	private IContainer components;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("LBL_NAME")]
	private Label _LBL_NAME;

	[AccessedThroughProperty("LBL_DIR")]
	private Label _LBL_DIR;

	[AccessedThroughProperty("TXT_RUC")]
	private ucText _TXT_RUC;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("TXT_GR")]
	private ucText _TXT_GR;

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

	internal Label LBL_NAME
	{
		[DebuggerNonUserCode]
		get
		{
			return _LBL_NAME;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LBL_NAME = value;
		}
	}

	internal Label LBL_DIR
	{
		[DebuggerNonUserCode]
		get
		{
			return _LBL_DIR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LBL_DIR = value;
		}
	}

	internal ucText TXT_RUC
	{
		[DebuggerNonUserCode]
		get
		{
			return _TXT_RUC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = TXT_RUC_Validated;
			EventHandler value3 = TXT_RUC_TextChanged;
			if (_TXT_RUC != null)
			{
				_TXT_RUC.Validated -= value2;
				_TXT_RUC.TextChanged -= value3;
			}
			_TXT_RUC = value;
			if (_TXT_RUC != null)
			{
				_TXT_RUC.Validated += value2;
				_TXT_RUC.TextChanged += value3;
			}
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

	internal ucText TXT_GR
	{
		[DebuggerNonUserCode]
		get
		{
			return _TXT_GR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TXT_GR = value;
		}
	}

	[method: DebuggerNonUserCode]
	public event ValidatedRUCEventHandler ValidatedRUC;

	[DebuggerNonUserCode]
	public ucBuscaClienteProveedor()
	{
		base.Load += ucBuscaClienteProveedor_Load;
		base.Resize += ucBuscaClienteProveedor_Resize;
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
		this.Label1 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.LBL_NAME = new System.Windows.Forms.Label();
		this.LBL_DIR = new System.Windows.Forms.Label();
		this.TXT_RUC = new GRLL.Common.ucText();
		this.Label4 = new System.Windows.Forms.Label();
		this.TXT_GR = new GRLL.Common.ucText();
		this.SuspendLayout();
		this.Label1.AutoSize = true;
		System.Windows.Forms.Label label = this.Label1;
		System.Drawing.Point location = new System.Drawing.Point(3, 0);
		label.Location = location;
		this.Label1.Name = "Label1";
		System.Windows.Forms.Label label2 = this.Label1;
		System.Drawing.Size size = new System.Drawing.Size(58, 13);
		label2.Size = size;
		this.Label1.TabIndex = 0;
		this.Label1.Text = "Señor(es) :";
		this.Label2.AutoSize = true;
		System.Windows.Forms.Label label3 = this.Label2;
		location = new System.Drawing.Point(3, 24);
		label3.Location = location;
		this.Label2.Name = "Label2";
		System.Windows.Forms.Label label4 = this.Label2;
		size = new System.Drawing.Size(58, 13);
		label4.Size = size;
		this.Label2.TabIndex = 0;
		this.Label2.Text = "Dirección :";
		this.Label3.AutoSize = true;
		System.Windows.Forms.Label label5 = this.Label3;
		location = new System.Drawing.Point(14, 48);
		label5.Location = location;
		this.Label3.Name = "Label3";
		System.Windows.Forms.Label label6 = this.Label3;
		size = new System.Drawing.Size(42, 13);
		label6.Size = size;
		this.Label3.TabIndex = 0;
		this.Label3.Text = "R U C :";
		this.LBL_NAME.AutoSize = true;
		System.Windows.Forms.Label lBL_NAME = this.LBL_NAME;
		location = new System.Drawing.Point(62, 0);
		lBL_NAME.Location = location;
		this.LBL_NAME.Name = "LBL_NAME";
		System.Windows.Forms.Label lBL_NAME2 = this.LBL_NAME;
		size = new System.Drawing.Size(0, 13);
		lBL_NAME2.Size = size;
		this.LBL_NAME.TabIndex = 1;
		this.LBL_DIR.AutoSize = true;
		System.Windows.Forms.Label lBL_DIR = this.LBL_DIR;
		location = new System.Drawing.Point(62, 24);
		lBL_DIR.Location = location;
		this.LBL_DIR.Name = "LBL_DIR";
		System.Windows.Forms.Label lBL_DIR2 = this.LBL_DIR;
		size = new System.Drawing.Size(0, 13);
		lBL_DIR2.Size = size;
		this.LBL_DIR.TabIndex = 1;
		this.TXT_RUC.ActiveBorderColor = System.Drawing.SystemColors.ControlDarkDark;
		this.TXT_RUC.BackColorFocus = System.Drawing.Color.FromArgb(255, 192, 255);
		this.TXT_RUC.ExitOnEnter = true;
		this.TXT_RUC.ExitOnMaxLength = true;
		this.TXT_RUC.ForeColorFocus = System.Drawing.Color.Blue;
		this.TXT_RUC.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucText tXT_RUC = this.TXT_RUC;
		location = new System.Drawing.Point(60, 45);
		tXT_RUC.Location = location;
		this.TXT_RUC.MaxLength = 11;
		this.TXT_RUC.MsgError = "";
		this.TXT_RUC.Name = "TXT_RUC";
		this.TXT_RUC.SelectOnEnter = true;
		GRLL.Common.ucText tXT_RUC2 = this.TXT_RUC;
		size = new System.Drawing.Size(66, 20);
		tXT_RUC2.Size = size;
		this.TXT_RUC.TabIndex = 2;
		this.TXT_RUC.TipoDato = GRLL.Common.clsVariables.TipoDato.NumeroEntero;
		this.TXT_RUC.Valida = false;
		this.Label4.AutoSize = true;
		System.Windows.Forms.Label label7 = this.Label4;
		location = new System.Drawing.Point(145, 48);
		label7.Location = location;
		this.Label4.Name = "Label4";
		System.Windows.Forms.Label label8 = this.Label4;
		size = new System.Drawing.Size(96, 13);
		label8.Size = size;
		this.Label4.TabIndex = 0;
		this.Label4.Text = "Guia de Remisión :";
		this.TXT_GR.ActiveBorderColor = System.Drawing.SystemColors.ControlDarkDark;
		this.TXT_GR.BackColorFocus = System.Drawing.Color.FromArgb(255, 192, 255);
		this.TXT_GR.ExitOnEnter = true;
		this.TXT_GR.ExitOnMaxLength = true;
		this.TXT_GR.ForeColorFocus = System.Drawing.Color.Blue;
		this.TXT_GR.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucText tXT_GR = this.TXT_GR;
		location = new System.Drawing.Point(247, 45);
		tXT_GR.Location = location;
		this.TXT_GR.MaxLength = 11;
		this.TXT_GR.MsgError = "";
		this.TXT_GR.Name = "TXT_GR";
		this.TXT_GR.SelectOnEnter = true;
		GRLL.Common.ucText tXT_GR2 = this.TXT_GR;
		size = new System.Drawing.Size(120, 20);
		tXT_GR2.Size = size;
		this.TXT_GR.TabIndex = 2;
		this.TXT_GR.TipoDato = GRLL.Common.clsVariables.TipoDato.Fecha;
		this.TXT_GR.Valida = false;
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.White;
		this.Controls.Add(this.TXT_GR);
		this.Controls.Add(this.TXT_RUC);
		this.Controls.Add(this.LBL_DIR);
		this.Controls.Add(this.Label4);
		this.Controls.Add(this.LBL_NAME);
		this.Controls.Add(this.Label3);
		this.Controls.Add(this.Label2);
		this.Controls.Add(this.Label1);
		this.Name = "ucBuscaClienteProveedor";
		size = new System.Drawing.Size(370, 67);
		this.Size = size;
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	private void ucBuscaClienteProveedor_Load(object sender, EventArgs e)
	{
	}

	private void ucBuscaClienteProveedor_Resize(object sender, EventArgs e)
	{
		if (Height != 67)
		{
			Height = 67;
		}
		if (Width < 370)
		{
			Width = 370;
		}
		if (Width > Parent.Width)
		{
			Width = Parent.Width;
		}
	}

	private void TXT_RUC_TextChanged(object sender, EventArgs e)
	{
		LBL_NAME.Text = "";
		LBL_DIR.Text = "";
		TXT_GR.Text = "";
	}

	private void TXT_RUC_Validated(object sender, EventArgs e)
	{
		bool Cancel = false;
		ValidatedRUC?.Invoke(Cancel);
		if (!Cancel)
		{
		}
	}
}
