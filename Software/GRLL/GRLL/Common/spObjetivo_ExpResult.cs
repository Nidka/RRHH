using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spObjetivo_ExpResult
{
	private int _IdObjetivo;

	private int? _Year;

	private int? _idAreaOrganiz;

	private int? _IdEstrategia;

	private string _Objetivo;

	private string _FechaInicio;

	private string _FechaFin;

	private int? _IdPresupuesto;

	private decimal? _AvanceAnual;

	private decimal? _AvanceGlobal;

	private decimal _Meta;

	private int _Importancia;

	private int? _IdUnidMed;

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

	[Column(Storage = "_FechaInicio", DbType = "VarChar(8)")]
	public string FechaInicio
	{
		get
		{
			return _FechaInicio;
		}
		set
		{
			if (!string.Equals(_FechaInicio, value))
			{
				_FechaInicio = value;
			}
		}
	}

	[Column(Storage = "_FechaFin", DbType = "VarChar(8)")]
	public string FechaFin
	{
		get
		{
			return _FechaFin;
		}
		set
		{
			if (!string.Equals(_FechaFin, value))
			{
				_FechaFin = value;
			}
		}
	}

	[Column(Storage = "_IdPresupuesto", DbType = "Int")]
	public int? IdPresupuesto
	{
		get
		{
			return _IdPresupuesto;
		}
		set
		{
			if (!_IdPresupuesto.Equals(value))
			{
				_IdPresupuesto = value;
			}
		}
	}

	[Column(Storage = "_AvanceAnual", DbType = "Decimal(0,0)")]
	public decimal? AvanceAnual
	{
		get
		{
			return _AvanceAnual;
		}
		set
		{
			if (!_AvanceAnual.Equals(value))
			{
				_AvanceAnual = value;
			}
		}
	}

	[Column(Storage = "_AvanceGlobal", DbType = "Decimal(0,0)")]
	public decimal? AvanceGlobal
	{
		get
		{
			return _AvanceGlobal;
		}
		set
		{
			if (!_AvanceGlobal.Equals(value))
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

	[Column(Storage = "_IdUnidMed", DbType = "Int")]
	public int? IdUnidMed
	{
		get
		{
			return _IdUnidMed;
		}
		set
		{
			if (!_IdUnidMed.Equals(value))
			{
				_IdUnidMed = value;
			}
		}
	}
}
