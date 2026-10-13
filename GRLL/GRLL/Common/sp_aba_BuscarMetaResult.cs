using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class sp_aba_BuscarMetaResult
{
	private string _Descripcion;

	[Column(Storage = "_Descripcion", DbType = "VarChar(255)")]
	public string Descripcion
	{
		get
		{
			return _Descripcion;
		}
		set
		{
			if (!string.Equals(_Descripcion, value))
			{
				_Descripcion = value;
			}
		}
	}
}
