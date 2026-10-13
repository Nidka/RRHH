using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.VS_ABA_NROMAXPN")]
public class VS_ABA_NROMAXPN
{
	private int? _NROMAX_PN;

	[Column(Storage = "_NROMAX_PN", DbType = "Int")]
	public int? NROMAX_PN
	{
		get
		{
			return _NROMAX_PN;
		}
		set
		{
			if (!_NROMAX_PN.Equals(value))
			{
				_NROMAX_PN = value;
			}
		}
	}
}
