using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class splistartablasResult
{
	private string _tablename;

	private int _tableID;

	[Column(Storage = "_tablename", DbType = "NVarChar(128) NOT NULL", CanBeNull = false)]
	public string tablename
	{
		get
		{
			return _tablename;
		}
		set
		{
			if (!string.Equals(_tablename, value))
			{
				_tablename = value;
			}
		}
	}

	[Column(Storage = "_tableID", DbType = "Int NOT NULL")]
	public int tableID
	{
		get
		{
			return _tableID;
		}
		set
		{
			if (_tableID != value)
			{
				_tableID = value;
			}
		}
	}
}
