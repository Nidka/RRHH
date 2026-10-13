using System;
using System.ComponentModel;
using FarsiLibrary.Win.Helpers;

namespace FarsiLibrary.Win;

public class FATabStripItemCollection : CollectionWithEvents
{
	private int lockUpdate;

	public FATabStripItem this[int index]
	{
		get
		{
			if (index < 0 || base.List.Count - 1 < index)
			{
				return null;
			}
			return (FATabStripItem)base.List[index];
		}
		set
		{
			base.List[index] = value;
		}
	}

	[Browsable(false)]
	public virtual int DrawnCount
	{
		get
		{
			int count = base.Count;
			int num = 0;
			if (count == 0)
			{
				return 0;
			}
			for (int i = 0; i < count; i++)
			{
				if (this[i].IsDrawn)
				{
					num++;
				}
			}
			return num;
		}
	}

	public virtual FATabStripItem LastVisible
	{
		get
		{
			for (int num = base.Count - 1; num > 0; num--)
			{
				if (this[num].Visible)
				{
					return this[num];
				}
			}
			return null;
		}
	}

	public virtual FATabStripItem FirstVisible
	{
		get
		{
			for (int i = 0; i < base.Count; i++)
			{
				if (this[i].Visible)
				{
					return this[i];
				}
			}
			return null;
		}
	}

	[Browsable(false)]
	public virtual int VisibleCount
	{
		get
		{
			int count = base.Count;
			int num = 0;
			if (count == 0)
			{
				return 0;
			}
			for (int i = 0; i < count; i++)
			{
				if (this[i].Visible)
				{
					num++;
				}
			}
			return num;
		}
	}

	[Browsable(false)]
	public event CollectionChangeEventHandler CollectionChanged;

	public FATabStripItemCollection()
	{
		lockUpdate = 0;
	}

	protected virtual void OnCollectionChanged(CollectionChangeEventArgs e)
	{
		if (this.CollectionChanged != null)
		{
			this.CollectionChanged(this, e);
		}
	}

	protected virtual void BeginUpdate()
	{
		lockUpdate++;
	}

	protected virtual void EndUpdate()
	{
		if (--lockUpdate == 0)
		{
			OnCollectionChanged(new CollectionChangeEventArgs(CollectionChangeAction.Refresh, null));
		}
	}

	public virtual void AddRange(FATabStripItem[] items)
	{
		BeginUpdate();
		try
		{
			foreach (FATabStripItem value in items)
			{
				base.List.Add(value);
			}
		}
		finally
		{
			EndUpdate();
		}
	}

	public virtual void Assign(FATabStripItemCollection collection)
	{
		BeginUpdate();
		try
		{
			Clear();
			for (int i = 0; i < collection.Count; i++)
			{
				FATabStripItem item = collection[i];
				FATabStripItem fATabStripItem = new FATabStripItem();
				fATabStripItem.Assign(item);
				Add(fATabStripItem);
			}
		}
		finally
		{
			EndUpdate();
		}
	}

	public virtual int Add(FATabStripItem item)
	{
		int num = IndexOf(item);
		if (num == -1)
		{
			num = base.List.Add(item);
		}
		return num;
	}

	public virtual void Remove(FATabStripItem item)
	{
		if (base.List.Contains(item))
		{
			base.List.Remove(item);
		}
	}

	public virtual FATabStripItem MoveTo(int newIndex, FATabStripItem item)
	{
		int num = base.List.IndexOf(item);
		if (num >= 0)
		{
			RemoveAt(num);
			Insert(0, item);
			return item;
		}
		return null;
	}

	public virtual int IndexOf(FATabStripItem item)
	{
		return base.List.IndexOf(item);
	}

	public virtual bool Contains(FATabStripItem item)
	{
		return base.List.Contains(item);
	}

	public virtual void Insert(int index, FATabStripItem item)
	{
		if (!Contains(item))
		{
			base.List.Insert(index, item);
		}
	}

	protected override void OnInsertComplete(int index, object item)
	{
		FATabStripItem fATabStripItem = item as FATabStripItem;
		fATabStripItem.Changed += OnItem_Changed;
		OnCollectionChanged(new CollectionChangeEventArgs(CollectionChangeAction.Add, item));
	}

	protected override void OnRemove(int index, object item)
	{
		base.OnRemove(index, item);
		FATabStripItem fATabStripItem = item as FATabStripItem;
		fATabStripItem.Changed -= OnItem_Changed;
		OnCollectionChanged(new CollectionChangeEventArgs(CollectionChangeAction.Remove, item));
	}

	protected override void OnClear()
	{
		if (base.Count == 0)
		{
			return;
		}
		BeginUpdate();
		try
		{
			for (int num = base.Count - 1; num >= 0; num--)
			{
				RemoveAt(num);
			}
		}
		finally
		{
			EndUpdate();
		}
	}

	protected virtual void OnItem_Changed(object sender, EventArgs e)
	{
		OnCollectionChanged(new CollectionChangeEventArgs(CollectionChangeAction.Refresh, sender));
	}
}
