using System;

namespace GRLL.Common;

public class AutoCompleteEventArgs : EventArgs
{
	public string Text;

	public AutoCompleteEventArgs(string Text)
	{
		this.Text = Text;
	}
}
