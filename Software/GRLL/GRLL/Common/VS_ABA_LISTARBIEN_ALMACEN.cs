using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.VS_ABA_LISTARBIEN_ALMACEN")]
public class VS_ABA_LISTARBIEN_ALMACEN
{
	private string _IDALMACEN;

	private string _DESCRIPCION;

	private decimal? _STOCK;

	private string _IDBIEN;

	[Column(Storage = "_IDALMACEN", DbType = "Char(2) NOT NULL", CanBeNull = false)]
	public string IDALMACEN
	{
		get
		{
			return _IDALMACEN;
		}
		set
		{
			if (!string.Equals(_IDALMACEN, value))
			{
				_IDALMACEN = value;
			}
		}
	}

	[Column(Storage = "_DESCRIPCION", DbType = "VarChar(128)")]
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

	[Column(Storage = "_STOCK", DbType = "Decimal(9,2)")]
	public decimal? STOCK
	{
		get
		{
			return _STOCK;
		}
		set
		{
			if (!_STOCK.Equals(value))
			{
				_STOCK = value;
			}
		}
	}

	[Column(Storage = "_IDBIEN", DbType = "Char(13) NOT NULL", CanBeNull = false)]
	public string IDBIEN
	{
		get
		{
			return _IDBIEN;
		}
		set
		{
			if (!string.Equals(_IDBIEN, value))
			{
				_IDBIEN = value;
			}
		}
	}
}
