using System;
using System.Windows.Forms;

namespace Custom_Featured_MessageBox;

public class XTextBox : TextBox
{
	public int LinesCount()
	{
		Message m = Message.Create(base.Handle, 186, IntPtr.Zero, IntPtr.Zero);
		base.DefWndProc(ref m);
		return m.Result.ToInt32();
	}
}
