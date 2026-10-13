using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace GRLL.Common;

[DesignerGenerated]
public class ucFechas : UserControl
{
	private IContainer components;

	[AccessedThroughProperty("dtpFechaDe")]
	private DateTimePicker _dtpFechaDe;

	[AccessedThroughProperty("dtpFechaA")]
	private DateTimePicker _dtpFechaA;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	private RangoFecha _rango;

	internal DateTimePicker dtpFechaDe
	{
		[DebuggerNonUserCode]
		get
		{
			return _dtpFechaDe;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dtpFechaDe = value;
		}
	}

	internal DateTimePicker dtpFechaA
	{
		[DebuggerNonUserCode]
		get
		{
			return _dtpFechaA;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dtpFechaA = value;
		}
	}

	internal Label Label9
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label9 = value;
		}
	}

	internal Label Label10
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label10 = value;
		}
	}

	public RangoFecha Rango
	{
		get
		{
			_rango = new RangoFecha(dtpFechaDe.Value.Date, dtpFechaA.Value.Date);
			return _rango;
		}
		set
		{
			_rango = value;
			if (_rango != null)
			{
				dtpFechaDe.Value = _rango.Desde;
				dtpFechaA.Value = _rango.Hasta;
			}
		}
	}

	[DebuggerNonUserCode]
	public ucFechas()
	{
		base.Resize += ucFechas_Resize;
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
		this.dtpFechaDe = new System.Windows.Forms.DateTimePicker();
		this.dtpFechaA = new System.Windows.Forms.DateTimePicker();
		this.Label9 = new System.Windows.Forms.Label();
		this.Label10 = new System.Windows.Forms.Label();
		this.SuspendLayout();
		this.dtpFechaDe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		System.Windows.Forms.DateTimePicker dateTimePicker = this.dtpFechaDe;
		System.Drawing.Point location = new System.Drawing.Point(40, 0);
		dateTimePicker.Location = location;
		this.dtpFechaDe.Name = "dtpFechaDe";
		System.Windows.Forms.DateTimePicker dateTimePicker2 = this.dtpFechaDe;
		System.Drawing.Size size = new System.Drawing.Size(112, 20);
		dateTimePicker2.Size = size;
		this.dtpFechaDe.TabIndex = 8;
		this.dtpFechaA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		System.Windows.Forms.DateTimePicker dateTimePicker3 = this.dtpFechaA;
		location = new System.Drawing.Point(190, 0);
		dateTimePicker3.Location = location;
		this.dtpFechaA.Name = "dtpFechaA";
		System.Windows.Forms.DateTimePicker dateTimePicker4 = this.dtpFechaA;
		size = new System.Drawing.Size(112, 20);
		dateTimePicker4.Size = size;
		this.dtpFechaA.TabIndex = 7;
		this.Label9.AutoSize = true;
		System.Windows.Forms.Label label = this.Label9;
		location = new System.Drawing.Point(3, 4);
		label.Location = location;
		this.Label9.Name = "Label9";
		System.Windows.Forms.Label label2 = this.Label9;
		size = new System.Drawing.Size(38, 13);
		label2.Size = size;
		this.Label9.TabIndex = 10;
		this.Label9.Text = "Desde";
		this.Label10.AutoSize = true;
		System.Windows.Forms.Label label3 = this.Label10;
		location = new System.Drawing.Point(150, 4);
		label3.Location = location;
		this.Label10.Name = "Label10";
		System.Windows.Forms.Label label4 = this.Label10;
		size = new System.Drawing.Size(35, 13);
		label4.Size = size;
		this.Label10.TabIndex = 9;
		this.Label10.Text = "Hasta";
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.Controls.Add(this.dtpFechaDe);
		this.Controls.Add(this.dtpFechaA);
		this.Controls.Add(this.Label9);
		this.Controls.Add(this.Label10);
		this.Name = "ucFechas";
		size = new System.Drawing.Size(302, 22);
		this.Size = size;
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	private void ucFechas_Resize(object sender, EventArgs e)
	{
		Size size = new Size(302, 22);
		Size = size;
	}
}
