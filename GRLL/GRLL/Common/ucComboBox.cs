using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace GRLL.Common;

public class ucComboBox : ComboBox
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

	private ComboBoxStyle _DropDownStyle;

	private bool _IsReadOnly;

	private bool vCLick;

	private bool isLoad;

	private bool _PreSeleccionar;

	[DefaultValue(false)]
	public bool IsReadOnly
	{
		get
		{
			return _IsReadOnly;
		}
		set
		{
			_IsReadOnly = value;
			_ = _IsReadOnly;
		}
	}

	[DefaultValue(false)]
	public bool ListOnFocused
	{
		get
		{
			return _ListOnFocused;
		}
		set
		{
			_ListOnFocused = value;
		}
	}

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

	[DefaultValue(true)]
	public bool IncluirNinguno
	{
		get
		{
			return _PreSeleccionar;
		}
		set
		{
			_PreSeleccionar = value;
		}
	}

	[method: DebuggerNonUserCode]
	public event BorderChangedEventHandler BorderChanged;

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

	protected override void OnMouseClick(MouseEventArgs e)
	{
		base.OnMouseClick(e);
	}

	protected override void OnSelectedIndexChanged(EventArgs e)
	{
		if (_PreSeleccionar)
		{
			if (!isLoad)
			{
				base.OnSelectedIndexChanged(e);
			}
			else
			{
				isLoad = false;
			}
		}
		else
		{
			base.OnSelectedIndexChanged(e);
		}
	}

	protected override void OnDataSourceChanged(EventArgs e)
	{
		isLoad = true;
		base.OnDataSourceChanged(e);
		if (_PreSeleccionar)
		{
			isLoad = true;
			SelectedIndex = -1;
		}
		limpiar();
	}

	private void limpiar()
	{
		if (Items.Count == 0)
		{
			Text = "";
		}
	}

	protected override void OnTextChanged(EventArgs e)
	{
		SelectionLength = 0;
		base.OnTextChanged(e);
	}

	protected override bool ProcessDialogKey(Keys keyData)
	{
		if (_IsReadOnly && keyData != Keys.Return && keyData != Keys.Down && keyData != Keys.Up && keyData != Keys.Tab && keyData != Keys.End && keyData != Keys.Home)
		{
			keyData = Keys.None;
		}
		return base.ProcessDialogKey(keyData);
	}

	protected override void OnKeyDown(KeyEventArgs e)
	{
		if (_IsReadOnly)
		{
			if ((e.KeyValue != 13) & (e.KeyValue != 37) & (e.KeyValue != 39) & (e.KeyValue != 40) & (e.KeyValue != 38) & (e.KeyValue != 9) & (e.KeyValue != 35) & (e.KeyValue != 36))
			{
				e.Handled = true;
			}
			else
			{
				base.OnKeyDown(e);
			}
		}
		else
		{
			base.OnKeyDown(e);
		}
	}

	protected override void OnKeyPress(KeyPressEventArgs e)
	{
		if (e.KeyChar == ' ')
		{
			DroppedDown = true;
		}
		if (_IsReadOnly)
		{
			e.Handled = true;
		}
		base.OnKeyPress(e);
	}

	protected override void OnClick(EventArgs e)
	{
		base.OnClick(e);
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		base.OnMouseDown(e);
	}

	protected override void OnEnter(EventArgs e)
	{
		base.OnEnter(e);
	}

	protected override void OnGotFocus(EventArgs e)
	{
		IamON = true;
		base.OnGotFocus(e);
		Invalidate();
		if (IsReadOnly)
		{
			SelectionLength = 0;
		}
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
				if (_IsReadOnly)
				{
					_BorderColor = _BorderColorInactive;
				}
				if (Enabled && FlatStyle == FlatStyle.Flat)
				{
					g.DrawRectangle(new Pen(_BorderColor), 0, 0, cliente.Width - 1, cliente.Height - 1);
					g.Dispose();
				}
				BorderChanged?.Invoke(this, new FlatBoxEventArgs(_BorderColor, IamON));
			}
		}
	}

	private void ucComboBox_KeyUp(object sender, KeyEventArgs e)
	{
		if ((e.KeyValue == 13) & _TabNextControl & Focused)
		{
			SendKeys.Send("{TAB}");
		}
	}

	public ucComboBox()
	{
		base.KeyUp += ucComboBox_KeyUp;
		_TabNextControl = false;
		_BorderColorActive = Color.FromArgb(130, 165, 210);
		_BorderColorInactive = SystemColors.ControlDark;
		_DropDownStyle = ComboBoxStyle.DropDownList;
		vCLick = false;
	}
}
