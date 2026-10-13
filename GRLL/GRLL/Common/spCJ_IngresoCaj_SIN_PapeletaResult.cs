using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spCJ_IngresoCaj_SIN_PapeletaResult
{
	private int _CHCK;

	private int _NroIngreso;

	private int _IdPersona;

	private string _Persona;

	private string _Detalle;

	private decimal? _Importe;

	private string _Fecha;

	private int _Years;

	private string _Serie;

	private string _Factura;

	private string _sFactura;

	private int _Fact;

	private int? _IdTipoMoneda;

	private string _TipoMoneda;

	private string _Moneda;

	[Column(Storage = "_CHCK", DbType = "Int NOT NULL")]
	public int CHCK
	{
		get
		{
			return _CHCK;
		}
		set
		{
			if (_CHCK != value)
			{
				_CHCK = value;
			}
		}
	}

	[Column(Storage = "_NroIngreso", DbType = "Int NOT NULL")]
	public int NroIngreso
	{
		get
		{
			return _NroIngreso;
		}
		set
		{
			if (_NroIngreso != value)
			{
				_NroIngreso = value;
			}
		}
	}

	[Column(Storage = "_IdPersona", DbType = "Int NOT NULL")]
	public int IdPersona
	{
		get
		{
			return _IdPersona;
		}
		set
		{
			if (_IdPersona != value)
			{
				_IdPersona = value;
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

	[Column(Storage = "_Detalle", DbType = "VarChar(701) NOT NULL", CanBeNull = false)]
	public string Detalle
	{
		get
		{
			return _Detalle;
		}
		set
		{
			if (!string.Equals(_Detalle, value))
			{
				_Detalle = value;
			}
		}
	}

	[Column(Storage = "_Importe", DbType = "Decimal(0,0)")]
	public decimal? Importe
	{
		get
		{
			return _Importe;
		}
		set
		{
			if (!_Importe.Equals(value))
			{
				_Importe = value;
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

	[Column(Storage = "_Years", DbType = "Int NOT NULL")]
	public int Years
	{
		get
		{
			return _Years;
		}
		set
		{
			if (_Years != value)
			{
				_Years = value;
			}
		}
	}

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

	[Column(Storage = "_sFactura", DbType = "VarChar(13)")]
	public string sFactura
	{
		get
		{
			return _sFactura;
		}
		set
		{
			if (!string.Equals(_sFactura, value))
			{
				_sFactura = value;
			}
		}
	}

	[Column(Storage = "_Fact", DbType = "Int NOT NULL")]
	public int Fact
	{
		get
		{
			return _Fact;
		}
		set
		{
			if (_Fact != value)
			{
				_Fact = value;
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
}
