using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace GRLL.Common;

public class TransparentLabel : UserControl
{
	private IContainer components;

	private string Txt;

	private bool AutoSze;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[Category("Appearance")]
	[Browsable(true)]
	[Bindable(true)]
	public override string Text
	{
		get
		{
			return Txt;
		}
		set
		{
			Txt = value;
			Refresh();
		}
	}

	[Category("Behavior")]
	[DefaultValue(true)]
	public new bool AutoSize
	{
		get
		{
			return AutoSze;
		}
		set
		{
			AutoSze = value;
			Refresh();
		}
	}

	public TransparentLabel()
	{
		base.Paint += TransparentLabel_Paint;
		base.Load += TransparentLabel_Load;
		AutoSze = true;
		InitializeComponent();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	[System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		this.BackColor = System.Drawing.Color.DeepPink;
		this.Name = "TransparentLabel";
		System.Drawing.Size size = new System.Drawing.Size(256, 46);
		this.Size = size;
	}

	private void TransparentLabel_Paint(object sender, PaintEventArgs e)
	{
		checked
		{
			try
			{
				if (AutoSze)
				{
					SizeF Siz = e.Graphics.MeasureString(Txt, Font);
					Width = (int)Math.Round(Siz.Width + 1f);
					Height = (int)Math.Round(Siz.Height + 1f);
				}
				Bitmap B = new Bitmap(Width, Height);
				Graphics G = Graphics.FromImage(B);
				SolidBrush brush = new SolidBrush(Color.DeepPink);
				Rectangle rect = new Rectangle(0, 0, Width, Height);
				G.FillRectangle(brush, rect);
				G.DrawString(Txt, Font, new SolidBrush(ForeColor), 0f, 0f);
				GraphicsPath Pth = new GraphicsPath();
				short num = (short)(Width - 1);
				for (short X = 0; X <= num; X = (short)unchecked(X + 1))
				{
					short num2 = (short)(Height - 1);
					for (short Y = 0; Y <= num2; Y = (short)unchecked(Y + 1))
					{
						if (Operators.CompareString(B.GetPixel(X, Y).ToArgb().ToString(), Color.DeepPink.ToArgb().ToString(), TextCompare: false) == 0)
						{
							rect = new Rectangle(X, Y, 1, 1);
							Pth.AddRectangle(rect);
						}
					}
				}
				SolidBrush brush2 = new SolidBrush(ForeColor);
				rect = new Rectangle(0, 0, Width, Height);
				G.FillRectangle(brush2, rect);
				e.Graphics.DrawImage(B, 0, 0);
				rect = new Rectangle(0, 0, Width, Height);
				Region Rgn = new Region(rect);
				Rgn.Exclude(Pth);
				Region = Rgn;
				B.Dispose();
				G.Dispose();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	protected override void OnForeColorChanged(EventArgs e)
	{
		Refresh();
	}

	private void TransparentLabel_Load(object sender, EventArgs e)
	{
		SetStyle(ControlStyles.AllPaintingInWmPaint, value: true);
		SetStyle(ControlStyles.DoubleBuffer, value: true);
		SetStyle(ControlStyles.UserPaint, value: true);
	}
}
