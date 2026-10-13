using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.VS_ABA_NROMAXPERJ")]
public class VS_ABA_NROMAXPERJ
{
	private int? _NROMAX_PJ;

	[Column(Storage = "_NROMAX_PJ", DbType = "Int")]
	public int? NROMAX_PJ
	{
		get
		{
			return _NROMAX_PJ;
		}
		set
		{
			if (!_NROMAX_PJ.Equals(value))
			{
				_NROMAX_PJ = value;
			}
		}
	}
}
