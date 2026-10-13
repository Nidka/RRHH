using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class sp_aba_Corre_CodMetaResult
{
	private string _Correlativo;

	[Column(Storage = "_Correlativo", DbType = "VarChar(10)")]
	public string Correlativo
	{
		get
		{
			return _Correlativo;
		}
		set
		{
			if (!string.Equals(_Correlativo, value))
			{
				_Correlativo = value;
			}
		}
	}
}
