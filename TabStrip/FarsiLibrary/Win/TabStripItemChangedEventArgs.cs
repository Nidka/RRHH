using System;

namespace FarsiLibrary.Win;

public class TabStripItemChangedEventArgs : EventArgs
{
	private FATabStripItem itm;

	private FATabStripItemChangeTypes changeType;

	public FATabStripItemChangeTypes ChangeType => changeType;

	public FATabStripItem Item => itm;

	public TabStripItemChangedEventArgs(FATabStripItem item, FATabStripItemChangeTypes type)
	{
		changeType = type;
		itm = item;
	}
}
