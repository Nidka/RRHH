using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class sp_ABA_ImpDetOrdenCBienResult
{
	private string _idorden;

	private char _tipoorden;

	private int _ITEM;

	private string _idbien;

	private decimal? _cantidad;

	private string _unidadmedida;

	private string _articulo;

	private char? _tipo;

	private decimal? _Precio;

	private decimal? _Total;

	private string _ClasGasto;

	private string _CorrMeta;

	private string _observaciones;

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

	[Column(Storage = "_tipoorden", DbType = "Char(1) NOT NULL")]
	public char tipoorden
	{
		get
		{
			return _tipoorden;
		}
		set
		{
			if (_tipoorden != value)
			{
				_tipoorden = value;
			}
		}
	}

	[Column(Storage = "_ITEM", DbType = "Int NOT NULL")]
	public int ITEM
	{
		get
		{
			return _ITEM;
		}
		set
		{
			if (_ITEM != value)
			{
				_ITEM = value;
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

	[Column(Storage = "_unidadmedida", DbType = "VarChar(30)")]
	public string unidadmedida
	{
		get
		{
			return _unidadmedida;
		}
		set
		{
			if (!string.Equals(_unidadmedida, value))
			{
				_unidadmedida = value;
			}
		}
	}

	[Column(Storage = "_articulo", DbType = "VarChar(120)")]
	public string articulo
	{
		get
		{
			return _articulo;
		}
		set
		{
			if (!string.Equals(_articulo, value))
			{
				_articulo = value;
			}
		}
	}

	[Column(Storage = "_tipo", DbType = "Char(1)")]
	public char? tipo
	{
		get
		{
			return _tipo;
		}
		set
		{
			if (!_tipo.Equals(value))
			{
				_tipo = value;
			}
		}
	}

	[Column(Storage = "_Precio", DbType = "Decimal(0,0)")]
	public decimal? Precio
	{
		get
		{
			return _Precio;
		}
		set
		{
			if (!_Precio.Equals(value))
			{
				_Precio = value;
			}
		}
	}

	[Column(Storage = "_Total", DbType = "Decimal(0,0)")]
	public decimal? Total
	{
		get
		{
			return _Total;
		}
		set
		{
			if (!_Total.Equals(value))
			{
				_Total = value;
			}
		}
	}

	[Column(Storage = "_ClasGasto", DbType = "VarChar(17)")]
	public string ClasGasto
	{
		get
		{
			return _ClasGasto;
		}
		set
		{
			if (!string.Equals(_ClasGasto, value))
			{
				_ClasGasto = value;
			}
		}
	}

	[Column(Storage = "_CorrMeta", DbType = "Char(6)")]
	public string CorrMeta
	{
		get
		{
			return _CorrMeta;
		}
		set
		{
			if (!string.Equals(_CorrMeta, value))
			{
				_CorrMeta = value;
			}
		}
	}

	[Column(Storage = "_observaciones", DbType = "VarChar(400)")]
	public string observaciones
	{
		get
		{
			return _observaciones;
		}
		set
		{
			if (!string.Equals(_observaciones, value))
			{
				_observaciones = value;
			}
		}
	}
}
