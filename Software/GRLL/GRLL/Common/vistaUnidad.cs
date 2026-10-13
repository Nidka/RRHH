using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.vistaUnidad")]
public class vistaUnidad
{
	private string _idunidadmedida;

	private string _unidad;

	[Column(Storage = "_idunidadmedida", DbType = "Char(4) NOT NULL", CanBeNull = false)]
	public string idunidadmedida
	{
		get
		{
			return _idunidadmedida;
		}
		set
		{
			if (!string.Equals(_idunidadmedida, value))
			{
				_idunidadmedida = value;
			}
		}
	}

	[Column(Storage = "_unidad", DbType = "Char(10)")]
	public string unidad
	{
		get
		{
			return _unidad;
		}
		set
		{
			if (!string.Equals(_unidad, value))
			{
				_unidad = value;
			}
		}
	}
}
