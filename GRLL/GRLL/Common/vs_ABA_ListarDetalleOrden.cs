using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.vs_ABA_ListarDetalleOrden")]
public class vs_ABA_ListarDetalleOrden
{
	private string _idorden;

	private byte _item;

	private string _idbien;

	private string _desbien;

	private decimal? _cantidad;

	private decimal? _precio;

	private decimal? _igv;

	private decimal? _importe;

	private string _idgasto;

	private string _desgasto;

	private string _desunidad;

	[Column(Storage = "_idorden", DbType = "Char(8) NOT NULL", CanBeNull = false)]
	public string idorden
	{
		get
		{
			return _idorden;
		}
		set
		{
			if (!string.Equals(_idorden, value))
			{
				_idorden = value;
			}
		}
	}

	[Column(Storage = "_item", DbType = "TinyInt NOT NULL")]
	public byte item
	{
		get
		{
			return _item;
		}
		set
		{
			if (_item != value)
			{
				_item = value;
			}
		}
	}

	[Column(Storage = "_idbien", DbType = "Char(13) NOT NULL", CanBeNull = false)]
	public string idbien
	{
		get
		{
			return _idbien;
		}
		set
		{
			if (!string.Equals(_idbien, value))
			{
				_idbien = value;
			}
		}
	}

	[Column(Storage = "_desbien", DbType = "VarChar(120)")]
	public string desbien
	{
		get
		{
			return _desbien;
		}
		set
		{
			if (!string.Equals(_desbien, value))
			{
				_desbien = value;
			}
		}
	}

	[Column(Storage = "_cantidad", DbType = "Decimal(9,2)")]
	public decimal? cantidad
	{
		get
		{
			return _cantidad;
		}
		set
		{
			if (!_cantidad.Equals(value))
			{
				_cantidad = value;
			}
		}
	}

	[Column(Storage = "_precio", DbType = "Decimal(9,2)")]
	public decimal? precio
	{
		get
		{
			return _precio;
		}
		set
		{
			if (!_precio.Equals(value))
			{
				_precio = value;
			}
		}
	}

	[Column(Storage = "_igv", DbType = "Decimal(9,2)")]
	public decimal? igv
	{
		get
		{
			return _igv;
		}
		set
		{
			if (!_igv.Equals(value))
			{
				_igv = value;
			}
		}
	}

	[Column(Storage = "_importe", DbType = "Decimal(9,2)")]
	public decimal? importe
	{
		get
		{
			return _importe;
		}
		set
		{
			if (!_importe.Equals(value))
			{
				_importe = value;
			}
		}
	}

	[Column(Storage = "_idgasto", DbType = "Char(10)")]
	public string idgasto
	{
		get
		{
			return _idgasto;
		}
		set
		{
			if (!string.Equals(_idgasto, value))
			{
				_idgasto = value;
			}
		}
	}

	[Column(Storage = "_desgasto", DbType = "VarChar(80)")]
	public string desgasto
	{
		get
		{
			return _desgasto;
		}
		set
		{
			if (!string.Equals(_desgasto, value))
			{
				_desgasto = value;
			}
		}
	}

	[Column(Storage = "_desunidad", DbType = "VarChar(30)")]
	public string desunidad
	{
		get
		{
			return _desunidad;
		}
		set
		{
			if (!string.Equals(_desunidad, value))
			{
				_desunidad = value;
			}
		}
	}
}
