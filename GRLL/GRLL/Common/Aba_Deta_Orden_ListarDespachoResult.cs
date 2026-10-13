using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class Aba_Deta_Orden_ListarDespachoResult
{
	private string _idorden;

	private int _item;

	private string _idbien;

	private string _desbien;

	private decimal? _cantidad;

	private decimal _cantidadrecibida;

	private decimal? _saldo;

	private decimal? _precio;

	private decimal? _igv;

	private decimal? _importe;

	private string _desunidad;

	private string _idalmacen;

	private decimal _stock;

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

	[Column(Storage = "_item", DbType = "Int NOT NULL")]
	public int item
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

	[Column(Storage = "_cantidad", DbType = "Decimal(0,0)")]
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

	[Column(Storage = "_cantidadrecibida", DbType = "Decimal(0,0) NOT NULL")]
	public decimal cantidadrecibida
	{
		get
		{
			return _cantidadrecibida;
		}
		set
		{
			if (decimal.Compare(_cantidadrecibida, value) != 0)
			{
				_cantidadrecibida = value;
			}
		}
	}

	[Column(Storage = "_saldo", DbType = "Decimal(0,0)")]
	public decimal? saldo
	{
		get
		{
			return _saldo;
		}
		set
		{
			if (!_saldo.Equals(value))
			{
				_saldo = value;
			}
		}
	}

	[Column(Storage = "_precio", DbType = "Decimal(0,0)")]
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

	[Column(Storage = "_igv", DbType = "Decimal(0,0)")]
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

	[Column(Storage = "_importe", DbType = "Decimal(0,0)")]
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

	[Column(Storage = "_idalmacen", DbType = "Char(2)")]
	public string idalmacen
	{
		get
		{
			return _idalmacen;
		}
		set
		{
			if (!string.Equals(_idalmacen, value))
			{
				_idalmacen = value;
			}
		}
	}

	[Column(Storage = "_stock", DbType = "Decimal(0,0) NOT NULL")]
	public decimal stock
	{
		get
		{
			return _stock;
		}
		set
		{
			if (decimal.Compare(_stock, value) != 0)
			{
				_stock = value;
			}
		}
	}
}
