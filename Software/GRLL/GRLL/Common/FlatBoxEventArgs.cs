using System;
using System.Drawing;

namespace GRLL.Common;

public class FlatBoxEventArgs : EventArgs
{
	public Color BorderColor;

	public bool GotFocus;

	public FlatBoxEventArgs(Color Bordercolor, bool GotFocus)
	{
		BorderColor = Bordercolor;
		this.GotFocus = GotFocus;
	}
}
