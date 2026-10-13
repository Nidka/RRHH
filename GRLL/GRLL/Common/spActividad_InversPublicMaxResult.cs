using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spActividad_InversPublicMaxResult
{
	private decimal? _IPPRog;

	private decimal? _IPAsig;

	[Column(Storage = "_IPPRog", DbType = "Decimal(0,0)")]
	public decimal? IPPRog
	{
		get
		{
			return _IPPRog;
		}
		set
		{
			if (!_IPPRog.Equals(value))
			{
				_IPPRog = value;
			}
		}
	}

	[Column(Storage = "_IPAsig", DbType = "Decimal(0,0)")]
	public decimal? IPAsig
	{
		get
		{
			return _IPAsig;
		}
		set
		{
			if (!_IPAsig.Equals(value))
			{
				_IPAsig = value;
			}
		}
	}
}
