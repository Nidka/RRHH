using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spRRHH_Ficha_Ingreso_EgresoResult
{
	private decimal? _Remuneracion;

	private decimal? _honorarios;

	private decimal? _AlqPredio;

	private decimal? _AlqBienes;

	private decimal? _CapitalesColocados;

	private decimal? _Dietas;

	private decimal? _Negocios;

	private decimal? _OtrosIngresos;

	private decimal? _IngresoMiembros;

	private string _NumPersonaAportan;

	private decimal? _TotalIngreso;

	private decimal? _Alimentacion;

	private decimal? _vivienda;

	private decimal? _educacion;

	private decimal? _salud;

	private decimal? _vestido;

	private decimal? _recreacion;

	private decimal? _prestamos;

	private decimal? _transporte;

	private decimal? _energiaelec;

	private decimal? _agua;

	private decimal? _bajapolicia;

	private decimal? _telefono;

	private decimal? _seguropriv;

	private decimal? _tarjcredito;

	private decimal? _OtrosEgresos;

	private decimal? _TotalEgreso;

	[Column(Storage = "_Remuneracion", DbType = "Decimal(0,0)")]
	public decimal? Remuneracion
	{
		get
		{
			return _Remuneracion;
		}
		set
		{
			if (!_Remuneracion.Equals(value))
			{
				_Remuneracion = value;
			}
		}
	}

	[Column(Storage = "_honorarios", DbType = "Decimal(0,0)")]
	public decimal? honorarios
	{
		get
		{
			return _honorarios;
		}
		set
		{
			if (!_honorarios.Equals(value))
			{
				_honorarios = value;
			}
		}
	}

	[Column(Storage = "_AlqPredio", DbType = "Decimal(0,0)")]
	public decimal? AlqPredio
	{
		get
		{
			return _AlqPredio;
		}
		set
		{
			if (!_AlqPredio.Equals(value))
			{
				_AlqPredio = value;
			}
		}
	}

	[Column(Storage = "_AlqBienes", DbType = "Decimal(0,0)")]
	public decimal? AlqBienes
	{
		get
		{
			return _AlqBienes;
		}
		set
		{
			if (!_AlqBienes.Equals(value))
			{
				_AlqBienes = value;
			}
		}
	}

	[Column(Storage = "_CapitalesColocados", DbType = "Decimal(0,0)")]
	public decimal? CapitalesColocados
	{
		get
		{
			return _CapitalesColocados;
		}
		set
		{
			if (!_CapitalesColocados.Equals(value))
			{
				_CapitalesColocados = value;
			}
		}
	}

	[Column(Storage = "_Dietas", DbType = "Decimal(0,0)")]
	public decimal? Dietas
	{
		get
		{
			return _Dietas;
		}
		set
		{
			if (!_Dietas.Equals(value))
			{
				_Dietas = value;
			}
		}
	}

	[Column(Storage = "_Negocios", DbType = "Decimal(0,0)")]
	public decimal? Negocios
	{
		get
		{
			return _Negocios;
		}
		set
		{
			if (!_Negocios.Equals(value))
			{
				_Negocios = value;
			}
		}
	}

	[Column(Storage = "_OtrosIngresos", DbType = "Decimal(0,0)")]
	public decimal? OtrosIngresos
	{
		get
		{
			return _OtrosIngresos;
		}
		set
		{
			if (!_OtrosIngresos.Equals(value))
			{
				_OtrosIngresos = value;
			}
		}
	}

	[Column(Storage = "_IngresoMiembros", DbType = "Decimal(0,0)")]
	public decimal? IngresoMiembros
	{
		get
		{
			return _IngresoMiembros;
		}
		set
		{
			if (!_IngresoMiembros.Equals(value))
			{
				_IngresoMiembros = value;
			}
		}
	}

	[Column(Storage = "_NumPersonaAportan", DbType = "VarChar(2)")]
	public string NumPersonaAportan
	{
		get
		{
			return _NumPersonaAportan;
		}
		set
		{
			if (!string.Equals(_NumPersonaAportan, value))
			{
				_NumPersonaAportan = value;
			}
		}
	}

	[Column(Storage = "_TotalIngreso", DbType = "Decimal(0,0)")]
	public decimal? TotalIngreso
	{
		get
		{
			return _TotalIngreso;
		}
		set
		{
			if (!_TotalIngreso.Equals(value))
			{
				_TotalIngreso = value;
			}
		}
	}

	[Column(Storage = "_Alimentacion", DbType = "Decimal(0,0)")]
	public decimal? Alimentacion
	{
		get
		{
			return _Alimentacion;
		}
		set
		{
			if (!_Alimentacion.Equals(value))
			{
				_Alimentacion = value;
			}
		}
	}

	[Column(Storage = "_vivienda", DbType = "Decimal(0,0)")]
	public decimal? vivienda
	{
		get
		{
			return _vivienda;
		}
		set
		{
			if (!_vivienda.Equals(value))
			{
				_vivienda = value;
			}
		}
	}

	[Column(Storage = "_educacion", DbType = "Decimal(0,0)")]
	public decimal? educacion
	{
		get
		{
			return _educacion;
		}
		set
		{
			if (!_educacion.Equals(value))
			{
				_educacion = value;
			}
		}
	}

	[Column(Storage = "_salud", DbType = "Decimal(0,0)")]
	public decimal? salud
	{
		get
		{
			return _salud;
		}
		set
		{
			if (!_salud.Equals(value))
			{
				_salud = value;
			}
		}
	}

	[Column(Storage = "_vestido", DbType = "Decimal(0,0)")]
	public decimal? vestido
	{
		get
		{
			return _vestido;
		}
		set
		{
			if (!_vestido.Equals(value))
			{
				_vestido = value;
			}
		}
	}

	[Column(Storage = "_recreacion", DbType = "Decimal(0,0)")]
	public decimal? recreacion
	{
		get
		{
			return _recreacion;
		}
		set
		{
			if (!_recreacion.Equals(value))
			{
				_recreacion = value;
			}
		}
	}

	[Column(Storage = "_prestamos", DbType = "Decimal(0,0)")]
	public decimal? prestamos
	{
		get
		{
			return _prestamos;
		}
		set
		{
			if (!_prestamos.Equals(value))
			{
				_prestamos = value;
			}
		}
	}

	[Column(Storage = "_transporte", DbType = "Decimal(0,0)")]
	public decimal? transporte
	{
		get
		{
			return _transporte;
		}
		set
		{
			if (!_transporte.Equals(value))
			{
				_transporte = value;
			}
		}
	}

	[Column(Storage = "_energiaelec", DbType = "Decimal(0,0)")]
	public decimal? energiaelec
	{
		get
		{
			return _energiaelec;
		}
		set
		{
			if (!_energiaelec.Equals(value))
			{
				_energiaelec = value;
			}
		}
	}

	[Column(Storage = "_agua", DbType = "Decimal(0,0)")]
	public decimal? agua
	{
		get
		{
			return _agua;
		}
		set
		{
			if (!_agua.Equals(value))
			{
				_agua = value;
			}
		}
	}

	[Column(Storage = "_bajapolicia", DbType = "Decimal(0,0)")]
	public decimal? bajapolicia
	{
		get
		{
			return _bajapolicia;
		}
		set
		{
			if (!_bajapolicia.Equals(value))
			{
				_bajapolicia = value;
			}
		}
	}

	[Column(Storage = "_telefono", DbType = "Decimal(0,0)")]
	public decimal? telefono
	{
		get
		{
			return _telefono;
		}
		set
		{
			if (!_telefono.Equals(value))
			{
				_telefono = value;
			}
		}
	}

	[Column(Storage = "_seguropriv", DbType = "Decimal(0,0)")]
	public decimal? seguropriv
	{
		get
		{
			return _seguropriv;
		}
		set
		{
			if (!_seguropriv.Equals(value))
			{
				_seguropriv = value;
			}
		}
	}

	[Column(Storage = "_tarjcredito", DbType = "Decimal(0,0)")]
	public decimal? tarjcredito
	{
		get
		{
			return _tarjcredito;
		}
		set
		{
			if (!_tarjcredito.Equals(value))
			{
				_tarjcredito = value;
			}
		}
	}

	[Column(Storage = "_OtrosEgresos", DbType = "Decimal(0,0)")]
	public decimal? OtrosEgresos
	{
		get
		{
			return _OtrosEgresos;
		}
		set
		{
			if (!_OtrosEgresos.Equals(value))
			{
				_OtrosEgresos = value;
			}
		}
	}

	[Column(Storage = "_TotalEgreso", DbType = "Decimal(0,0)")]
	public decimal? TotalEgreso
	{
		get
		{
			return _TotalEgreso;
		}
		set
		{
			if (!_TotalEgreso.Equals(value))
			{
				_TotalEgreso = value;
			}
		}
	}
}
