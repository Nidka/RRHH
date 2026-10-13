using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class SP_ABA_FILTRARMETAResult
{
	private string _IDMETA;

	private string _DESCRIPCION;

	[Column(Storage = "_IDMETA", DbType = "Char(6) NOT NULL", CanBeNull = false)]
	public string IDMETA
	{
		get
		{
			return _IDMETA;
		}
		set
		{
			if (!string.Equals(_IDMETA, value))
			{
				_IDMETA = value;
			}
		}
	}

	[Column(Storage = "_DESCRIPCION", DbType = "VarChar(255)")]
	public string DESCRIPCION
	{
		get
		{
			return _DESCRIPCION;
		}
		set
		{
			if (!string.Equals(_DESCRIPCION, value))
			{
				_DESCRIPCION = value;
			}
		}
	}
}
