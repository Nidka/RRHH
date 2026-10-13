using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spSEG_VerfUsuarioResult
{
	private string _name;

	[Column(Storage = "_name", DbType = "NVarChar(128) NOT NULL", CanBeNull = false)]
	public string name
	{
		get
		{
			return _name;
		}
		set
		{
			if (!string.Equals(_name, value))
			{
				_name = value;
			}
		}
	}
}
