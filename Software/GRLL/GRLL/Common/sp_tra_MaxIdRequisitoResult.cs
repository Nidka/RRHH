using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class sp_tra_MaxIdRequisitoResult
{
	private int _corre;

	[Column(Storage = "_corre", DbType = "Int NOT NULL")]
	public int corre
	{
		get
		{
			return _corre;
		}
		set
		{
			if (_corre != value)
			{
				_corre = value;
			}
		}
	}
}
