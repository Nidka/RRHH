using System;

namespace FarsiLibrary.Win;

public class TabStripItemClosingEventArgs : EventArgs
{
	private bool _cancel;

	private FATabStripItem _item;

	public FATabStripItem Item
	{
		get
		{
			return _item;
		}
		set
		{
			_item = value;
		}
	}

	public bool Cancel
	{
		get
		{
			return _cancel;
		}
		set
		{
			_cancel = value;
		}
	}

	public TabStripItemClosingEventArgs(FATabStripItem item)
	{
		_item = item;
	}
}
