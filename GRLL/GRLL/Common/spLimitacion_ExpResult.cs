using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spLimitacion_ExpResult
{
	private int _IdLimitacion;

	private string _Descripcion;

	[Column(Storage = "_IdLimitacion", DbType = "Int NOT NULL")]
	public int IdLimitacion
	{
		get
		{
			return _IdLimitacion;
		}
		set
		{
			if (_IdLimitacion != value)
			{
				_IdLimitacion = value;
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(500)")]
	public string Descripcion
	{
		get
		{
			return _Descripcion;
		}
		set
		{
			if (!string.Equals(_Descripcion, value))
			{
				_Descripcion = value;
			}
		}
	}
}
