using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spEmpleaditoResult
{
	private int _idempleado;

	private string _alias;

	[Column(Storage = "_idempleado", DbType = "Int NOT NULL")]
	public int idempleado
	{
		get
		{
			return _idempleado;
		}
		set
		{
			if (_idempleado != value)
			{
				_idempleado = value;
			}
		}
	}

	[Column(Name = "alias", Storage = "_alias", DbType = "VarChar(162)")]
	public string alias
	{
		get
		{
			return _alias;
		}
		set
		{
			if (!string.Equals(_alias, value))
			{
				_alias = value;
			}
		}
	}
}
