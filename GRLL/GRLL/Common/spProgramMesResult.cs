using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spProgramMesResult
{
	private int? _IdMes;

	[Column(Storage = "_IdMes", DbType = "Int")]
	public int? IdMes
	{
		get
		{
			return _IdMes;
		}
		set
		{
			if (!_IdMes.Equals(value))
			{
				_IdMes = value;
			}
		}
	}
}
