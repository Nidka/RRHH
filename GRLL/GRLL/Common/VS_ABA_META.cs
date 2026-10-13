using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.VS_ABA_META")]
public class VS_ABA_META
{
	private string _IDMETA;

	private string _DESCRIPCION;

	[Column(Storage = "_IDMETA", DbType = "VarChar(6)")]
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

	[Column(Storage = "_DESCRIPCION", DbType = "VarChar(200)")]
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
