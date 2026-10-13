using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class sp_aba_NroMaxPerResult
{
	private int? _Column1;

	[Column(Storage = "_Column1", DbType = "Int")]
	public int? Column1
	{
		get
		{
			return _Column1;
		}
		set
		{
			if (!_Column1.Equals(value))
			{
				_Column1 = value;
			}
		}
	}
}
