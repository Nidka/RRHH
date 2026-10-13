using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spLimit_Recomen_Logro_PrintResult
{
	private long? _Nro;

	private string _Limitacion;

	private string _Recomendacion;

	[Column(Storage = "_Nro", DbType = "BigInt")]
	public long? Nro
	{
		get
		{
			return _Nro;
		}
		set
		{
			if (!_Nro.Equals(value))
			{
				_Nro = value;
			}
		}
	}

	[Column(Storage = "_Limitacion", DbType = "VarChar(500) NOT NULL", CanBeNull = false)]
	public string Limitacion
	{
		get
		{
			return _Limitacion;
		}
		set
		{
			if (!string.Equals(_Limitacion, value))
			{
				_Limitacion = value;
			}
		}
	}

	[Column(Storage = "_Recomendacion", DbType = "VarChar(500) NOT NULL", CanBeNull = false)]
	public string Recomendacion
	{
		get
		{
			return _Recomendacion;
		}
		set
		{
			if (!string.Equals(_Recomendacion, value))
			{
				_Recomendacion = value;
			}
		}
	}
}
