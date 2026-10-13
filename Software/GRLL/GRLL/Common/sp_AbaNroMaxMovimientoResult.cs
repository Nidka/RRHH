using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class sp_AbaNroMaxMovimientoResult
{
	private string _Anio;

	private int? _Numero;

	[Column(Storage = "_Anio", DbType = "VarChar(2)")]
	public string Anio
	{
		get
		{
			return _Anio;
		}
		set
		{
			if (!string.Equals(_Anio, value))
			{
				_Anio = value;
			}
		}
	}

	[Column(Storage = "_Numero", DbType = "Int")]
	public int? Numero
	{
		get
		{
			return _Numero;
		}
		set
		{
			if (!_Numero.Equals(value))
			{
				_Numero = value;
			}
		}
	}
}
