using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spObjetivo_SelectResult
{
	private int? _idAreaOrganiz;

	private int? _Year;

	private int? _IdEstrategia;

	private int _IdObjetivo;

	private string _Objetivo;

	private DateTime _FechaInicio;

	private DateTime _FechaFin;

	private int _IdPresupuesto;

	private string _Estrategia;

	private DateTime _FI_E;

	private DateTime _FF_E;

	private decimal _AvanceAnual;

	private decimal _AvanceGlobal;

	private decimal _Meta;

	private int _Importancia;

	private int _IdUnidMed;

	private string _UnidadMedida;

	private string _UM;

	private int _NroActividad;

	private decimal? _TotalAvanceObjetivo;

	private decimal _TotalAvanceObjetivoP;

	[Column(Storage = "_idAreaOrganiz", DbType = "Int")]
	public int? idAreaOrganiz
	{
		get
		{
			return _idAreaOrganiz;
		}
		set
		{
			if (!_idAreaOrganiz.Equals(value))
			{
				_idAreaOrganiz = value;
			}
		}
	}

	[Column(Storage = "_Year", DbType = "Int")]
	public int? Year
	{
		get
		{
			return _Year;
		}
		set
		{
			if (!_Year.Equals(value))
			{
				_Year = value;
			}
		}
	}

	[Column(Storage = "_IdEstrategia", DbType = "Int")]
	public int? IdEstrategia
	{
		get
		{
			return _IdEstrategia;
		}
		set
		{
			if (!_IdEstrategia.Equals(value))
			{
				_IdEstrategia = value;
			}
		}
	}

	[Column(Storage = "_IdObjetivo", DbType = "Int NOT NULL")]
	public int IdObjetivo
	{
		get
		{
			return _IdObjetivo;
		}
		set
		{
			if (_IdObjetivo != value)
			{
				_IdObjetivo = value;
			}
		}
	}

	[Column(Storage = "_Objetivo", DbType = "VarChar(500) NOT NULL", CanBeNull = false)]
	public string Objetivo
	{
		get
		{
			return _Objetivo;
		}
		set
		{
			if (!string.Equals(_Objetivo, value))
			{
				_Objetivo = value;
			}
		}
	}

	[Column(Storage = "_FechaInicio", DbType = "SmallDateTime NOT NULL")]
	public DateTime FechaInicio
	{
		get
		{
			return _FechaInicio;
		}
		set
		{
			if (DateTime.Compare(_FechaInicio, value) != 0)
			{
				_FechaInicio = value;
			}
		}
	}

	[Column(Storage = "_FechaFin", DbType = "SmallDateTime NOT NULL")]
	public DateTime FechaFin
	{
		get
		{
			return _FechaFin;
		}
		set
		{
			if (DateTime.Compare(_FechaFin, value) != 0)
			{
				_FechaFin = value;
			}
		}
	}

	[Column(Storage = "_IdPresupuesto", DbType = "Int NOT NULL")]
	public int IdPresupuesto
	{
		get
		{
			return _IdPresupuesto;
		}
		set
		{
			if (_IdPresupuesto != value)
			{
				_IdPresupuesto = value;
			}
		}
	}

	[Column(Storage = "_Estrategia", DbType = "VarChar(500) NOT NULL", CanBeNull = false)]
	public string Estrategia
	{
		get
		{
			return _Estrategia;
		}
		set
		{
			if (!string.Equals(_Estrategia, value))
			{
				_Estrategia = value;
			}
		}
	}

	[Column(Storage = "_FI_E", DbType = "SmallDateTime NOT NULL")]
	public DateTime FI_E
	{
		get
		{
			return _FI_E;
		}
		set
		{
			if (DateTime.Compare(_FI_E, value) != 0)
			{
				_FI_E = value;
			}
		}
	}

	[Column(Storage = "_FF_E", DbType = "SmallDateTime NOT NULL")]
	public DateTime FF_E
	{
		get
		{
			return _FF_E;
		}
		set
		{
			if (DateTime.Compare(_FF_E, value) != 0)
			{
				_FF_E = value;
			}
		}
	}

	[Column(Storage = "_AvanceAnual", DbType = "Decimal(0,0) NOT NULL")]
	public decimal AvanceAnual
	{
		get
		{
			return _AvanceAnual;
		}
		set
		{
			if (decimal.Compare(_AvanceAnual, value) != 0)
			{
				_AvanceAnual = value;
			}
		}
	}

	[Column(Storage = "_AvanceGlobal", DbType = "Decimal(0,0) NOT NULL")]
	public decimal AvanceGlobal
	{
		get
		{
			return _AvanceGlobal;
		}
		set
		{
			if (decimal.Compare(_AvanceGlobal, value) != 0)
			{
				_AvanceGlobal = value;
			}
		}
	}

	[Column(Storage = "_Meta", DbType = "Decimal(0,0) NOT NULL")]
	public decimal Meta
	{
		get
		{
			return _Meta;
		}
		set
		{
			if (decimal.Compare(_Meta, value) != 0)
			{
				_Meta = value;
			}
		}
	}

	[Column(Storage = "_Importancia", DbType = "Int NOT NULL")]
	public int Importancia
	{
		get
		{
			return _Importancia;
		}
		set
		{
			if (_Importancia != value)
			{
				_Importancia = value;
			}
		}
	}

	[Column(Storage = "_IdUnidMed", DbType = "Int NOT NULL")]
	public int IdUnidMed
	{
		get
		{
			return _IdUnidMed;
		}
		set
		{
			if (_IdUnidMed != value)
			{
				_IdUnidMed = value;
			}
		}
	}

	[Column(Storage = "_UnidadMedida", DbType = "VarChar(100) NOT NULL", CanBeNull = false)]
	public string UnidadMedida
	{
		get
		{
			return _UnidadMedida;
		}
		set
		{
			if (!string.Equals(_UnidadMedida, value))
			{
				_UnidadMedida = value;
			}
		}
	}

	[Column(Storage = "_UM", DbType = "VarChar(6) NOT NULL", CanBeNull = false)]
	public string UM
	{
		get
		{
			return _UM;
		}
		set
		{
			if (!string.Equals(_UM, value))
			{
				_UM = value;
			}
		}
	}

	[Column(Storage = "_NroActividad", DbType = "Int NOT NULL")]
	public int NroActividad
	{
		get
		{
			return _NroActividad;
		}
		set
		{
			if (_NroActividad != value)
			{
				_NroActividad = value;
			}
		}
	}

	[Column(Storage = "_TotalAvanceObjetivo", DbType = "Decimal(0,0)")]
	public decimal? TotalAvanceObjetivo
	{
		get
		{
			return _TotalAvanceObjetivo;
		}
		set
		{
			if (!_TotalAvanceObjetivo.Equals(value))
			{
				_TotalAvanceObjetivo = value;
			}
		}
	}

	[Column(Storage = "_TotalAvanceObjetivoP", DbType = "Decimal(0,0) NOT NULL")]
	public decimal TotalAvanceObjetivoP
	{
		get
		{
			return _TotalAvanceObjetivoP;
		}
		set
		{
			if (decimal.Compare(_TotalAvanceObjetivoP, value) != 0)
			{
				_TotalAvanceObjetivoP = value;
			}
		}
	}
}
