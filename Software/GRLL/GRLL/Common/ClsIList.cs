using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace GRLL.Common;

public class ClsIList : IList
{
	private object[] _contents;

	private int _count;

	public bool IsFixedSize => true;

	public bool IsReadOnly => false;

	public object this[int index]
	{
		get
		{
			return _contents[index];
		}
		set
		{
			_contents[index] = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public int Count => _count;

	public bool IsSynchronized => false;

	public object SyncRoot => this;

	public ClsIList()
	{
		_contents = new object[1];
		_count = 0;
	}

	public int Add(object value)
	{
		checked
		{
			_contents = (object[])Utils.CopyArray(_contents, new object[_contents.Length + 1]);
			if (_count < _contents.Length - 1)
			{
				_contents[_count] = RuntimeHelpers.GetObjectValue(value);
				_count++;
				return _count - 1;
			}
			return -1;
		}
	}

	int IList.Add(object value)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Add
		return this.Add(value);
	}

	public void Clear()
	{
		_count = 0;
	}

	void IList.Clear()
	{
		//ILSpy generated this explicit interface implementation from .override directive in Clear
		this.Clear();
	}

	public bool Contains(object value)
	{
		bool inList = false;
		int count = Count;
		for (int I = 0; I <= count; I = checked(I + 1))
		{
			if (Operators.ConditionalCompareObjectEqual(_contents[I], value, TextCompare: false))
			{
				inList = true;
				break;
			}
		}
		return inList;
	}

	bool IList.Contains(object value)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Contains
		return this.Contains(value);
	}

	public int IndexOf(object value)
	{
		int itemIndex = -1;
		int count = Count;
		for (int I = 0; I <= count; I = checked(I + 1))
		{
			if (Operators.ConditionalCompareObjectEqual(_contents[I], value, TextCompare: false))
			{
				itemIndex = I;
				break;
			}
		}
		return itemIndex;
	}

	int IList.IndexOf(object value)
	{
		//ILSpy generated this explicit interface implementation from .override directive in IndexOf
		return this.IndexOf(value);
	}

	public void Insert(int index, object value)
	{
		if ((checked(_count + 1 <= _contents.Length - 1) & (index < Count)) && index >= 0)
		{
			checked
			{
				_count++;
				for (int I = Count - 1; I <= index; I++)
				{
					_contents[I] = RuntimeHelpers.GetObjectValue(_contents[I - 1]);
				}
				_contents[index] = RuntimeHelpers.GetObjectValue(value);
			}
		}
	}

	void IList.Insert(int index, object value)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Insert
		this.Insert(index, value);
	}

	public void Remove(object value)
	{
		RemoveAt(IndexOf(RuntimeHelpers.GetObjectValue(value)));
	}

	void IList.Remove(object value)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Remove
		this.Remove(value);
	}

	public void RemoveAt(int index)
	{
		checked
		{
			if ((index >= 0) & (index < Count))
			{
				int num = Count - 1;
				for (int I = index; I <= num; I++)
				{
					_contents[I] = RuntimeHelpers.GetObjectValue(_contents[I + 1]);
				}
				_count--;
			}
		}
	}

	void IList.RemoveAt(int index)
	{
		//ILSpy generated this explicit interface implementation from .override directive in RemoveAt
		this.RemoveAt(index);
	}

	public void CopyTo(Array array, int index)
	{
		int j = index;
		int count = Count;
		checked
		{
			for (int I = 0; I <= count; I++)
			{
				array.SetValue(RuntimeHelpers.GetObjectValue(_contents[I]), j);
				j++;
			}
		}
	}

	void ICollection.CopyTo(Array array, int index)
	{
		//ILSpy generated this explicit interface implementation from .override directive in CopyTo
		this.CopyTo(array, index);
	}

	public IEnumerator GetEnumerator()
	{
		throw new Exception("The method or operation is not implemented.");
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetEnumerator
		return this.GetEnumerator();
	}

	public void PrintContents()
	{
		checked
		{
			Console.WriteLine("List has a capacity of {0} and currently has {1} elements.", _contents.Length - 1, _count);
			Console.Write("List contents:");
			int count = Count;
			for (int I = 0; I <= count; I++)
			{
				Console.Write(" {0}", RuntimeHelpers.GetObjectValue(_contents[I]));
			}
			Console.WriteLine();
		}
	}
}
