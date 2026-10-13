using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class TRA_GET_IP_USUARIOResult
{
	private string _IP_ADDRESS;

	[Column(Storage = "_IP_ADDRESS", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
	public string IP_ADDRESS
	{
		get
		{
			return _IP_ADDRESS;
		}
		set
		{
			if (!string.Equals(_IP_ADDRESS, value))
			{
				_IP_ADDRESS = value;
			}
		}
	}
}
