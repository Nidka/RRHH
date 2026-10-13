using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class sp_aba_BuscarGastoResult
{
	private string _descripcion;

	[Column(Storage = "_descripcion", DbType = "VarChar(100)")]
	public string descripcion
	{
		get
		{
			return _descripcion;
		}
		set
		{
			if (!string.Equals(_descripcion, value))
			{
				_descripcion = value;
			}
		}
	}
}
