using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using GRLL.Common.My.Resources;
using Microsoft.VisualBasic.CompilerServices;

namespace GRLL.Common;

[DesignerGenerated]
public class ucNavButton : UserControl
{
	public delegate void ClickPrimeroEventHandler();

	public delegate void ClickAnteriorEventHandler();

	public delegate void ClickSgteEventHandler();

	public delegate void ClickUltimoEventHandler();

	private IContainer components;

	[AccessedThroughProperty("cmdPrimero")]
	private Button _cmdPrimero;

	[AccessedThroughProperty("cmdAnterior")]
	private Button _cmdAnterior;

	[AccessedThroughProperty("cmdSgte")]
	private Button _cmdSgte;

	[AccessedThroughProperty("cmdUltimo")]
	private Button _cmdUltimo;

	private ToolTip oToolTip;

	internal Button cmdPrimero
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdPrimero;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = cmdPrimero_Click;
			if (_cmdPrimero != null)
			{
				_cmdPrimero.Click -= value2;
			}
			_cmdPrimero = value;
			if (_cmdPrimero != null)
			{
				_cmdPrimero.Click += value2;
			}
		}
	}

	internal Button cmdAnterior
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdAnterior;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = cmdAnterior_Click;
			if (_cmdAnterior != null)
			{
				_cmdAnterior.Click -= value2;
			}
			_cmdAnterior = value;
			if (_cmdAnterior != null)
			{
				_cmdAnterior.Click += value2;
			}
		}
	}

	internal Button cmdSgte
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdSgte;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = cmdSgte_Click;
			if (_cmdSgte != null)
			{
				_cmdSgte.Click -= value2;
			}
			_cmdSgte = value;
			if (_cmdSgte != null)
			{
				_cmdSgte.Click += value2;
			}
		}
	}

	internal Button cmdUltimo
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdUltimo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = cmdUltimo_Click;
			if (_cmdUltimo != null)
			{
				_cmdUltimo.Click -= value2;
			}
			_cmdUltimo = value;
			if (_cmdUltimo != null)
			{
				_cmdUltimo.Click += value2;
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event ClickPrimeroEventHandler ClickPrimero;

	[method: DebuggerNonUserCode]
	public event ClickAnteriorEventHandler ClickAnterior;

	[method: DebuggerNonUserCode]
	public event ClickSgteEventHandler ClickSgte;

	[method: DebuggerNonUserCode]
	public event ClickUltimoEventHandler ClickUltimo;

	public ucNavButton()
	{
		base.Load += ucNavButton_Load;
		base.Resize += ucNavButton_Resize;
		oToolTip = new ToolTip();
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
		this.cmdAnterior = new System.Windows.Forms.Button();
		this.cmdPrimero = new System.Windows.Forms.Button();
		this.cmdSgte = new System.Windows.Forms.Button();
		this.cmdUltimo = new System.Windows.Forms.Button();
		this.SuspendLayout();
		this.cmdAnterior.Image = GRLL.Common.My.Resources.Resources.resultset_previous;
		System.Windows.Forms.Button button = this.cmdAnterior;
		System.Drawing.Point location = new System.Drawing.Point(27, 0);
		button.Location = location;
		this.cmdAnterior.Name = "cmdAnterior";
		System.Windows.Forms.Button button2 = this.cmdAnterior;
		System.Drawing.Size size = new System.Drawing.Size(28, 27);
		button2.Size = size;
		this.cmdAnterior.TabIndex = 1;
		this.cmdAnterior.UseVisualStyleBackColor = true;
		this.cmdPrimero.Image = GRLL.Common.My.Resources.Resources.resultset_first;
		System.Windows.Forms.Button button3 = this.cmdPrimero;
		location = new System.Drawing.Point(0, 0);
		button3.Location = location;
		this.cmdPrimero.Name = "cmdPrimero";
		System.Windows.Forms.Button button4 = this.cmdPrimero;
		size = new System.Drawing.Size(28, 27);
		button4.Size = size;
		this.cmdPrimero.TabIndex = 0;
		this.cmdPrimero.UseVisualStyleBackColor = true;
		this.cmdSgte.Image = GRLL.Common.My.Resources.Resources.resultset_next;
		System.Windows.Forms.Button button5 = this.cmdSgte;
		location = new System.Drawing.Point(68, 0);
		button5.Location = location;
		this.cmdSgte.Name = "cmdSgte";
		System.Windows.Forms.Button button6 = this.cmdSgte;
		size = new System.Drawing.Size(28, 27);
		button6.Size = size;
		this.cmdSgte.TabIndex = 2;
		this.cmdSgte.UseVisualStyleBackColor = true;
		this.cmdUltimo.Image = GRLL.Common.My.Resources.Resources.resultset_last;
		System.Windows.Forms.Button button7 = this.cmdUltimo;
		location = new System.Drawing.Point(102, 0);
		button7.Location = location;
		this.cmdUltimo.Name = "cmdUltimo";
		System.Windows.Forms.Button button8 = this.cmdUltimo;
		size = new System.Drawing.Size(28, 27);
		button8.Size = size;
		this.cmdUltimo.TabIndex = 3;
		this.cmdUltimo.UseVisualStyleBackColor = true;
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.Controls.Add(this.cmdUltimo);
		this.Controls.Add(this.cmdSgte);
		this.Controls.Add(this.cmdAnterior);
		this.Controls.Add(this.cmdPrimero);
		this.Name = "ucNavButton";
		size = new System.Drawing.Size(150, 31);
		this.Size = size;
		this.ResumeLayout(false);
	}

	private void ucNavButton_Load(object sender, EventArgs e)
	{
		oToolTip.SetToolTip(cmdPrimero, "Primero");
		oToolTip.SetToolTip(cmdAnterior, "Anterior");
		oToolTip.SetToolTip(cmdSgte, "Siguiente");
		oToolTip.SetToolTip(cmdUltimo, "Ultimo");
		Button button = cmdPrimero;
		Point location = new Point(0, 0);
		button.Location = location;
		Button button2 = cmdAnterior;
		location = new Point(cmdPrimero.Width, 0);
		button2.Location = location;
		Button button3 = cmdSgte;
		checked
		{
			location = new Point(cmdAnterior.Left + cmdAnterior.Width, 0);
			button3.Location = location;
			Button button4 = cmdUltimo;
			location = new Point(cmdSgte.Left + cmdSgte.Width, 0);
			button4.Location = location;
		}
	}

	private void ucNavButton_Resize(object sender, EventArgs e)
	{
		Size size = new Size(checked(cmdPrimero.Width * 4), cmdPrimero.Height);
		Size = size;
	}

	private void cmdPrimero_Click(object sender, EventArgs e)
	{
		ClickPrimero?.Invoke();
	}

	private void cmdAnterior_Click(object sender, EventArgs e)
	{
		ClickAnterior?.Invoke();
	}

	private void cmdSgte_Click(object sender, EventArgs e)
	{
		ClickSgte?.Invoke();
	}

	private void cmdUltimo_Click(object sender, EventArgs e)
	{
		ClickUltimo?.Invoke();
	}
}
