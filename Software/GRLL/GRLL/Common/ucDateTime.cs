using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace GRLL.Common;

public class ucDateTime : DateTimePicker
{
	public delegate void BorderChangedEventHandler(object sender, FlatBoxEventArgs e);

	private const int WM_PAINT = 15;

	private bool IamON;

	private bool IamFocus;

	private bool _TabNextControl;

	private Color _BorderColorActive;

	private Color _BorderColorInactive;

	private Color _BorderColor;

	private bool _ListOnFocused;

	[DefaultValue(false)]
	public bool TabNextControl
	{
		get
		{
			return _TabNextControl;
		}
		set
		{
			_TabNextControl = value;
		}
	}

	public Color BorderColorActive
	{
		get
		{
			return _BorderColorActive;
		}
		set
		{
			_BorderColorActive = value;
		}
	}

	public Color BorderColorInactive
	{
		get
		{
			return _BorderColorInactive;
		}
		set
		{
			_BorderColorInactive = value;
		}
	}

	[method: DebuggerNonUserCode]
	public event BorderChangedEventHandler BorderChanged;

	public ucDateTime()
	{
		_TabNextControl = false;
		_BorderColorActive = Color.FromArgb(130, 165, 210);
		_BorderColorInactive = SystemColors.ControlDark;
	}

	protected override void OnMouseEnter(EventArgs e)
	{
		base.OnMouseEnter(e);
		IamON = true;
		Invalidate();
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		base.OnMouseLeave(e);
		IamON = false;
		Invalidate();
	}

	protected override void OnLostFocus(EventArgs e)
	{
		IamON = false;
		Invalidate();
		base.OnLostFocus(e);
	}

	protected override void OnGotFocus(EventArgs e)
	{
		IamON = true;
		Cursor = Cursors.Default;
		base.OnGotFocus(e);
		Invalidate();
	}

	protected override void OnMouseHover(EventArgs e)
	{
		base.OnMouseHover(e);
		IamON = true;
		Invalidate();
	}

	protected override void WndProc(ref Message m)
	{
		base.WndProc(ref m);
		checked
		{
			if (m.Msg == 15)
			{
				Graphics g = CreateGraphics();
				Rectangle cliente = ClientRectangle;
				if (IamON)
				{
					_BorderColor = _BorderColorActive;
				}
				else
				{
					_BorderColor = _BorderColorInactive;
				}
				if (Enabled)
				{
					g.DrawRectangle(new Pen(_BorderColor), 0, 0, cliente.Width - 1, cliente.Height - 1);
					g.Dispose();
				}
				BorderChanged?.Invoke(this, new FlatBoxEventArgs(_BorderColor, IamON));
			}
		}
	}

	protected override void OnKeyUp(KeyEventArgs e)
	{
		if ((e.KeyValue == 13) & _TabNextControl & Focused)
		{
			SendKeys.Send("{TAB}");
		}
		base.OnKeyUp(e);
	}
}
