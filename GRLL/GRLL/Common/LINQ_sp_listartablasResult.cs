using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class LINQ_sp_listartablasResult
{
	private string _tablename;

	private int _tableID;

	private string _type;

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

	[Column(Storage = "_type", DbType = "Char(2)")]
	public string type
	{
		get
		{
			return _type;
		}
		set
		{
			if (!string.Equals(_type, value))
			{
				_type = value;
			}
		}
	}
}
