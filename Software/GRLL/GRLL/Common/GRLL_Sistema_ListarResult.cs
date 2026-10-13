using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class GRLL_Sistema_ListarResult
{
	private string _idsistemaopcion;

	private string _descripcion;

	[Column(Storage = "_idsistemaopcion", DbType = "Char(7) NOT NULL", CanBeNull = false)]
	public string idsistemaopcion
	{
		get
		{
			return _idsistemaopcion;
		}
		set
		{
			if (!string.Equals(_idsistemaopcion, value))
			{
				_idsistemaopcion = value;
			}
		}
	}

	[Column(Storage = "_descripcion", DbType = "VarChar(150)")]
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
