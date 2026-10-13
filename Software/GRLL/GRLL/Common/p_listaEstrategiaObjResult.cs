using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class p_listaEstrategiaObjResult
{
	private string _Estrategia;

	private string _Objetivo;

	[Column(Storage = "_Estrategia", DbType = "VarChar(500)")]
	public string Estrategia
	{
		get
		{
			return _Estrategia;
		}
		set
		{
			if (!string.Equals(_Estrategia, value))
			{
				_Estrategia = value;
			}
		}
	}

	[Column(Storage = "_Objetivo", DbType = "VarChar(500)")]
	public string Objetivo
	{
		get
		{
			return _Objetivo;
		}
		set
		{
			if (!string.Equals(_Objetivo, value))
			{
				_Objetivo = value;
			}
		}
	}
}
