using System.Drawing;
using System.Windows.Forms;

namespace FarsiLibrary.Win;

internal class FATabStripCloseButton
{
	private Rectangle crossRect = Rectangle.Empty;

	private bool isMouseOver;

	private ToolStripProfessionalRenderer renderer;

	public bool IsMouseOver
	{
		get
		{
			return isMouseOver;
		}
		set
		{
			isMouseOver = value;
		}
	}

	public Rectangle Bounds
	{
		get
		{
			return crossRect;
		}
		set
		{
			crossRect = value;
		}
	}

	internal FATabStripCloseButton(ToolStripProfessionalRenderer renderer)
	{
		this.renderer = renderer;
	}

	public void DrawCross(Graphics g)
	{
		if (isMouseOver)
		{
			Color buttonSelectedHighlight = renderer.ColorTable.ButtonSelectedHighlight;
			g.FillRectangle(new SolidBrush(buttonSelectedHighlight), crossRect);
			Rectangle rect = crossRect;
			rect.Width--;
			rect.Height--;
			g.DrawRectangle(SystemPens.Highlight, rect);
		}
		using Pen pen = new Pen(Color.Black, 1.6f);
		g.DrawLine(pen, crossRect.Left + 3, crossRect.Top + 3, crossRect.Right - 5, crossRect.Bottom - 4);
		g.DrawLine(pen, crossRect.Right - 5, crossRect.Top + 3, crossRect.Left + 3, crossRect.Bottom - 4);
	}
}
