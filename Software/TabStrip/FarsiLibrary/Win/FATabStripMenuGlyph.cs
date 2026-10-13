using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace FarsiLibrary.Win;

internal class FATabStripMenuGlyph
{
	private Rectangle glyphRect = Rectangle.Empty;

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
			return glyphRect;
		}
		set
		{
			glyphRect = value;
		}
	}

	internal FATabStripMenuGlyph(ToolStripProfessionalRenderer renderer)
	{
		this.renderer = renderer;
	}

	public void DrawGlyph(Graphics g)
	{
		if (isMouseOver)
		{
			Color buttonSelectedHighlight = renderer.ColorTable.ButtonSelectedHighlight;
			g.FillRectangle(new SolidBrush(buttonSelectedHighlight), glyphRect);
			Rectangle rect = glyphRect;
			rect.Width--;
			rect.Height--;
			g.DrawRectangle(SystemPens.Highlight, rect);
		}
		SmoothingMode smoothingMode = g.SmoothingMode;
		g.SmoothingMode = SmoothingMode.Default;
		using (Pen pen = new Pen(Color.Black))
		{
			pen.Width = 2f;
			g.DrawLine(pen, new Point(glyphRect.Left + glyphRect.Width / 3 - 2, glyphRect.Height / 2 - 1), new Point(glyphRect.Right - glyphRect.Width / 3, glyphRect.Height / 2 - 1));
		}
		g.FillPolygon(Brushes.Black, new Point[3]
		{
			new Point(glyphRect.Left + glyphRect.Width / 3 - 2, glyphRect.Height / 2 + 2),
			new Point(glyphRect.Right - glyphRect.Width / 3, glyphRect.Height / 2 + 2),
			new Point(glyphRect.Left + glyphRect.Width / 2 - 1, glyphRect.Bottom - 4)
		});
		g.SmoothingMode = smoothingMode;
	}
}
