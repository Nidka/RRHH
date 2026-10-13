using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spLogrosLimitacion_TVResult
{
	private string _Tipo;

	private string _Id;

	[Column(Storage = "_Tipo", DbType = "VarChar(12) NOT NULL", CanBeNull = false)]
	public string Tipo
	{
		get
		{
			return _Tipo;
		}
		set
		{
			if (!string.Equals(_Tipo, value))
			{
				_Tipo = value;
			}
		}
	}

	[Column(Storage = "_Id", DbType = "VarChar(23)")]
	public string Id
	{
		get
		{
			return _Id;
		}
		set
		{
			if (!string.Equals(_Id, value))
			{
				_Id = value;
			}
		}
	}
}
