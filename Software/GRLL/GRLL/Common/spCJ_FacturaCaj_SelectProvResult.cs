using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spCJ_FacturaCaj_SelectProvResult
{
	private string _Serie;

	private string _Factura;

	private string _Persona;

	private string _Direccion;

	private string _NumDocID;

	private decimal? _Total;

	private decimal? _IGV;

	private decimal? _SubTotal;

	private int? _Years;

	private int? _IdTipoMoneda;

	private string _TipoMoneda;

	private string _Moneda;

	private string _Fecha;

	private decimal? _Cantidad;

	private string _UnidMedida;

	private string _Descripcion;

	private decimal? _PrecioUnit;

	private decimal? _ValorVenta;

	[Column(Storage = "_Serie", DbType = "VarChar(4) NOT NULL", CanBeNull = false)]
	public string Serie
	{
		get
		{
			return _Serie;
		}
		set
		{
			if (!string.Equals(_Serie, value))
			{
				_Serie = value;
			}
		}
	}

	[Column(Storage = "_Factura", DbType = "VarChar(6) NOT NULL", CanBeNull = false)]
	public string Factura
	{
		get
		{
			return _Factura;
		}
		set
		{
			if (!string.Equals(_Factura, value))
			{
				_Factura = value;
			}
		}
	}

	[Column(Storage = "_Persona", DbType = "VarChar(163)")]
	public string Persona
	{
		get
		{
			return _Persona;
		}
		set
		{
			if (!string.Equals(_Persona, value))
			{
				_Persona = value;
			}
		}
	}

	[Column(Storage = "_Direccion", DbType = "VarChar(100) NOT NULL", CanBeNull = false)]
	public string Direccion
	{
		get
		{
			return _Direccion;
		}
		set
		{
			if (!string.Equals(_Direccion, value))
			{
				_Direccion = value;
			}
		}
	}

	[Column(Storage = "_NumDocID", DbType = "Char(12) NOT NULL", CanBeNull = false)]
	public string NumDocID
	{
		get
		{
			return _NumDocID;
		}
		set
		{
			if (!string.Equals(_NumDocID, value))
			{
				_NumDocID = value;
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

	[Column(Storage = "_IGV", DbType = "Decimal(0,0)")]
	public decimal? IGV
	{
		get
		{
			return _IGV;
		}
		set
		{
			if (!_IGV.Equals(value))
			{
				_IGV = value;
			}
		}
	}

	[Column(Storage = "_SubTotal", DbType = "Decimal(0,0)")]
	public decimal? SubTotal
	{
		get
		{
			return _SubTotal;
		}
		set
		{
			if (!_SubTotal.Equals(value))
			{
				_SubTotal = value;
			}
		}
	}

	[Column(Storage = "_Years", DbType = "Int")]
	public int? Years
	{
		get
		{
			return _Years;
		}
		set
		{
			if (!_Years.Equals(value))
			{
				_Years = value;
			}
		}
	}

	[Column(Storage = "_IdTipoMoneda", DbType = "Int")]
	public int? IdTipoMoneda
	{
		get
		{
			return _IdTipoMoneda;
		}
		set
		{
			if (!_IdTipoMoneda.Equals(value))
			{
				_IdTipoMoneda = value;
			}
		}
	}

	[Column(Storage = "_TipoMoneda", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
	public string TipoMoneda
	{
		get
		{
			return _TipoMoneda;
		}
		set
		{
			if (!string.Equals(_TipoMoneda, value))
			{
				_TipoMoneda = value;
			}
		}
	}

	[Column(Storage = "_Moneda", DbType = "VarChar(5) NOT NULL", CanBeNull = false)]
	public string Moneda
	{
		get
		{
			return _Moneda;
		}
		set
		{
			if (!string.Equals(_Moneda, value))
			{
				_Moneda = value;
			}
		}
	}

	[Column(Storage = "_Fecha", DbType = "VarChar(20)")]
	public string Fecha
	{
		get
		{
			return _Fecha;
		}
		set
		{
			if (!string.Equals(_Fecha, value))
			{
				_Fecha = value;
			}
		}
	}

	[Column(Storage = "_Cantidad", DbType = "Decimal(0,0)")]
	public decimal? Cantidad
	{
		get
		{
			return _Cantidad;
		}
		set
		{
			if (!_Cantidad.Equals(value))
			{
				_Cantidad = value;
			}
		}
	}

	[Column(Storage = "_UnidMedida", DbType = "VarChar(5) NOT NULL", CanBeNull = false)]
	public string UnidMedida
	{
		get
		{
			return _UnidMedida;
		}
		set
		{
			if (!string.Equals(_UnidMedida, value))
			{
				_UnidMedida = value;
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(500)")]
	public string Descripcion
	{
		get
		{
			return _Descripcion;
		}
		set
		{
			if (!string.Equals(_Descripcion, value))
			{
				_Descripcion = value;
			}
		}
	}

	[Column(Storage = "_PrecioUnit", DbType = "Decimal(0,0)")]
	public decimal? PrecioUnit
	{
		get
		{
			return _PrecioUnit;
		}
		set
		{
			if (!_PrecioUnit.Equals(value))
			{
				_PrecioUnit = value;
			}
		}
	}

	[Column(Storage = "_ValorVenta", DbType = "Decimal(0,0)")]
	public decimal? ValorVenta
	{
		get
		{
			return _ValorVenta;
		}
		set
		{
			if (!_ValorVenta.Equals(value))
			{
				_ValorVenta = value;
			}
		}
	}
}
