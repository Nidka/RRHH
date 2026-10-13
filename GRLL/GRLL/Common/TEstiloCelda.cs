using System.Drawing;

namespace GRLL.Common;

public class TEstiloCelda
{
	private Color cBackColor;

	private Color cSelectionBackColor;

	private Color cSelectionForeColor;

	private object cAlternatingBackColor;

	private object cColumnBackColor;

	public Color BackColor
	{
		get
		{
			return cBackColor;
		}
		set
		{
			cBackColor = value;
		}
	}

	public Color SelectionBackColor
	{
		get
		{
			return cSelectionBackColor;
		}
		set
		{
			cSelectionBackColor = value;
		}
	}

	public Color SelectionForeColor
	{
		get
		{
			return cSelectionForeColor;
		}
		set
		{
			cSelectionForeColor = value;
		}
	}

	public Color AlternatingBackColor
	{
		get
		{
			object obj = cAlternatingBackColor;
			Color result = default(Color);
			if (obj == null)
			{
				return result;
			}
			return (Color)obj;
		}
		set
		{
			cAlternatingBackColor = value;
		}
	}

	public Color ColumnBackColor
	{
		get
		{
			object obj = cColumnBackColor;
			Color result = default(Color);
			if (obj == null)
			{
				return result;
			}
			return (Color)obj;
		}
		set
		{
			cColumnBackColor = value;
		}
	}

	public TEstiloCelda()
	{
		cBackColor = Color.FromArgb(227, 239, 240);
		cSelectionBackColor = Color.FromArgb(130, 165, 210);
		cSelectionForeColor = Color.White;
		cAlternatingBackColor = Color.FromArgb(247, 247, 247);
		cColumnBackColor = Color.FromArgb(219, 217, 206);
	}
}
