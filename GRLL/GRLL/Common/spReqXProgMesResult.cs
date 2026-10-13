using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spReqXProgMesResult
{
	private string _IdBien;

	[Column(Storage = "_IdBien", DbType = "VarChar(13)")]
	public string IdBien
	{
		get
		{
			return _IdBien;
		}
		set
		{
			if (!string.Equals(_IdBien, value))
			{
				_IdBien = value;
			}
		}
	}
}
