using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spParametrosTrabResult
{
	private int? _IdParametros;

	private int? _Year;

	[Column(Storage = "_IdParametros", DbType = "Int")]
	public int? IdParametros
	{
		get
		{
			return _IdParametros;
		}
		set
		{
			if (!_IdParametros.Equals(value))
			{
				_IdParametros = value;
			}
		}
	}

	[Column(Storage = "_Year", DbType = "Int")]
	public int? Year
	{
		get
		{
			return _Year;
		}
		set
		{
			if (!_Year.Equals(value))
			{
				_Year = value;
			}
		}
	}
}
