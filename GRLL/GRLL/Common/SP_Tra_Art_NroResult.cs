using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class SP_Tra_Art_NroResult
{
	private string _Nro_Articulo;

	[Column(Storage = "_Nro_Articulo", DbType = "Char(2)")]
	public string Nro_Articulo
	{
		get
		{
			return _Nro_Articulo;
		}
		set
		{
			if (!string.Equals(_Nro_Articulo, value))
			{
				_Nro_Articulo = value;
			}
		}
	}
}
