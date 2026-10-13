using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spMeses_SelectResult
{
	private int _IdMes;

	private string _Mes;

	[Column(Storage = "_IdMes", DbType = "Int NOT NULL")]
	public int IdMes
	{
		get
		{
			return _IdMes;
		}
		set
		{
			if (_IdMes != value)
			{
				_IdMes = value;
			}
		}
	}

	[Column(Storage = "_Mes", DbType = "VarChar(9) NOT NULL", CanBeNull = false)]
	public string Mes
	{
		get
		{
			return _Mes;
		}
		set
		{
			if (!string.Equals(_Mes, value))
			{
				_Mes = value;
			}
		}
	}
}
