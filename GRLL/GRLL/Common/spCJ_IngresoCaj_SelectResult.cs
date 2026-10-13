using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spCJ_IngresoCaj_SelectResult
{
	private int _NroIngreso;

	private string _Persona;

	private string _Direccion;

	private string _Detalle;

	private decimal? _Importe;

	private int? _IdTipoMoneda;

	private string _TipoMoneda;

	private string _Moneda;

	private string _NroRef;

	private string _CPNro;

	private decimal _TotalCP;

	private string _NroCheque;

	private string _Bco;

	private decimal? _Efectivo;

	private string _BcoDe;

	private string _NroCtaDe;

	private string _BcoA;

	private string _NroCtaA;

	private string _Observacion;

	private string _PMD;

	private string _N1D;

	private string _N2D;

	private string _N3D;

	private decimal? _TotalDebe;

	private string _PMH;

	private string _N1H;

	private string _N2H;

	private string _N3H;

	private decimal? _TotalHaber;

	private string _Fecha;

	private int _Years;

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

	[Column(Storage = "_NroRef", DbType = "VarChar(25) NOT NULL", CanBeNull = false)]
	public string NroRef
	{
		get
		{
			return _NroRef;
		}
		set
		{
			if (!string.Equals(_NroRef, value))
			{
				_NroRef = value;
			}
		}
	}

	[Column(Storage = "_CPNro", DbType = "VarChar(25) NOT NULL", CanBeNull = false)]
	public string CPNro
	{
		get
		{
			return _CPNro;
		}
		set
		{
			if (!string.Equals(_CPNro, value))
			{
				_CPNro = value;
			}
		}
	}

	[Column(Storage = "_TotalCP", DbType = "Decimal(0,0) NOT NULL")]
	public decimal TotalCP
	{
		get
		{
			return _TotalCP;
		}
		set
		{
			if (decimal.Compare(_TotalCP, value) != 0)
			{
				_TotalCP = value;
			}
		}
	}

	[Column(Storage = "_NroCheque", DbType = "VarChar(15) NOT NULL", CanBeNull = false)]
	public string NroCheque
	{
		get
		{
			return _NroCheque;
		}
		set
		{
			if (!string.Equals(_NroCheque, value))
			{
				_NroCheque = value;
			}
		}
	}

	[Column(Storage = "_Bco", DbType = "VarChar(10) NOT NULL", CanBeNull = false)]
	public string Bco
	{
		get
		{
			return _Bco;
		}
		set
		{
			if (!string.Equals(_Bco, value))
			{
				_Bco = value;
			}
		}
	}

	[Column(Storage = "_Efectivo", DbType = "Decimal(0,0)")]
	public decimal? Efectivo
	{
		get
		{
			return _Efectivo;
		}
		set
		{
			if (!_Efectivo.Equals(value))
			{
				_Efectivo = value;
			}
		}
	}

	[Column(Storage = "_BcoDe", DbType = "VarChar(10) NOT NULL", CanBeNull = false)]
	public string BcoDe
	{
		get
		{
			return _BcoDe;
		}
		set
		{
			if (!string.Equals(_BcoDe, value))
			{
				_BcoDe = value;
			}
		}
	}

	[Column(Storage = "_NroCtaDe", DbType = "VarChar(12) NOT NULL", CanBeNull = false)]
	public string NroCtaDe
	{
		get
		{
			return _NroCtaDe;
		}
		set
		{
			if (!string.Equals(_NroCtaDe, value))
			{
				_NroCtaDe = value;
			}
		}
	}

	[Column(Storage = "_BcoA", DbType = "VarChar(10) NOT NULL", CanBeNull = false)]
	public string BcoA
	{
		get
		{
			return _BcoA;
		}
		set
		{
			if (!string.Equals(_BcoA, value))
			{
				_BcoA = value;
			}
		}
	}

	[Column(Storage = "_NroCtaA", DbType = "VarChar(12) NOT NULL", CanBeNull = false)]
	public string NroCtaA
	{
		get
		{
			return _NroCtaA;
		}
		set
		{
			if (!string.Equals(_NroCtaA, value))
			{
				_NroCtaA = value;
			}
		}
	}

	[Column(Storage = "_Observacion", DbType = "VarChar(500) NOT NULL", CanBeNull = false)]
	public string Observacion
	{
		get
		{
			return _Observacion;
		}
		set
		{
			if (!string.Equals(_Observacion, value))
			{
				_Observacion = value;
			}
		}
	}

	[Column(Storage = "_PMD", DbType = "VarChar(20)")]
	public string PMD
	{
		get
		{
			return _PMD;
		}
		set
		{
			if (!string.Equals(_PMD, value))
			{
				_PMD = value;
			}
		}
	}

	[Column(Storage = "_N1D", DbType = "VarChar(20)")]
	public string N1D
	{
		get
		{
			return _N1D;
		}
		set
		{
			if (!string.Equals(_N1D, value))
			{
				_N1D = value;
			}
		}
	}

	[Column(Storage = "_N2D", DbType = "VarChar(20)")]
	public string N2D
	{
		get
		{
			return _N2D;
		}
		set
		{
			if (!string.Equals(_N2D, value))
			{
				_N2D = value;
			}
		}
	}

	[Column(Storage = "_N3D", DbType = "VarChar(20)")]
	public string N3D
	{
		get
		{
			return _N3D;
		}
		set
		{
			if (!string.Equals(_N3D, value))
			{
				_N3D = value;
			}
		}
	}

	[Column(Storage = "_TotalDebe", DbType = "Decimal(0,0)")]
	public decimal? TotalDebe
	{
		get
		{
			return _TotalDebe;
		}
		set
		{
			if (!_TotalDebe.Equals(value))
			{
				_TotalDebe = value;
			}
		}
	}

	[Column(Storage = "_PMH", DbType = "VarChar(20)")]
	public string PMH
	{
		get
		{
			return _PMH;
		}
		set
		{
			if (!string.Equals(_PMH, value))
			{
				_PMH = value;
			}
		}
	}

	[Column(Storage = "_N1H", DbType = "VarChar(20)")]
	public string N1H
	{
		get
		{
			return _N1H;
		}
		set
		{
			if (!string.Equals(_N1H, value))
			{
				_N1H = value;
			}
		}
	}

	[Column(Storage = "_N2H", DbType = "VarChar(20)")]
	public string N2H
	{
		get
		{
			return _N2H;
		}
		set
		{
			if (!string.Equals(_N2H, value))
			{
				_N2H = value;
			}
		}
	}

	[Column(Storage = "_N3H", DbType = "VarChar(20)")]
	public string N3H
	{
		get
		{
			return _N3H;
		}
		set
		{
			if (!string.Equals(_N3H, value))
			{
				_N3H = value;
			}
		}
	}

	[Column(Storage = "_TotalHaber", DbType = "Decimal(0,0)")]
	public decimal? TotalHaber
	{
		get
		{
			return _TotalHaber;
		}
		set
		{
			if (!_TotalHaber.Equals(value))
			{
				_TotalHaber = value;
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
}
