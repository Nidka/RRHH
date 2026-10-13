using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spActividad_ExpResult
{
	private int _IdObjetivo;

	private int _IdActividad;

	private int? _NroActividad;

	private string _Actividad;

	private int? _IdEmpleado;

	private int? _IdUnidMed;

	private decimal _Meta;

	private char? _IsMeta;

	private decimal? _MetaMin;

	private int? _TrabXActiv;

	private decimal? _HH;

	private decimal? _BienServ;

	private int _Importancia;

	private decimal? _Avance;

	private decimal? _AvanceAnual;

	private string _FechaInicio;

	private string _FechaFin;

	private string _UnidsOrgs;

	private int? _IdPresupuesto;

	private string _Observacion;

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

	[Column(Storage = "_IdActividad", DbType = "Int NOT NULL")]
	public int IdActividad
	{
		get
		{
			return _IdActividad;
		}
		set
		{
			if (_IdActividad != value)
			{
				_IdActividad = value;
			}
		}
	}

	[Column(Storage = "_NroActividad", DbType = "Int")]
	public int? NroActividad
	{
		get
		{
			return _NroActividad;
		}
		set
		{
			if (!_NroActividad.Equals(value))
			{
				_NroActividad = value;
			}
		}
	}

	[Column(Storage = "_Actividad", DbType = "VarChar(300) NOT NULL", CanBeNull = false)]
	public string Actividad
	{
		get
		{
			return _Actividad;
		}
		set
		{
			if (!string.Equals(_Actividad, value))
			{
				_Actividad = value;
			}
		}
	}

	[Column(Storage = "_IdEmpleado", DbType = "Int")]
	public int? IdEmpleado
	{
		get
		{
			return _IdEmpleado;
		}
		set
		{
			if (!_IdEmpleado.Equals(value))
			{
				_IdEmpleado = value;
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

	[Column(Storage = "_IsMeta", DbType = "VarChar(1)")]
	public char? IsMeta
	{
		get
		{
			return _IsMeta;
		}
		set
		{
			if (!_IsMeta.Equals(value))
			{
				_IsMeta = value;
			}
		}
	}

	[Column(Storage = "_MetaMin", DbType = "Decimal(0,0)")]
	public decimal? MetaMin
	{
		get
		{
			return _MetaMin;
		}
		set
		{
			if (!_MetaMin.Equals(value))
			{
				_MetaMin = value;
			}
		}
	}

	[Column(Storage = "_TrabXActiv", DbType = "Int")]
	public int? TrabXActiv
	{
		get
		{
			return _TrabXActiv;
		}
		set
		{
			if (!_TrabXActiv.Equals(value))
			{
				_TrabXActiv = value;
			}
		}
	}

	[Column(Storage = "_HH", DbType = "Decimal(0,0)")]
	public decimal? HH
	{
		get
		{
			return _HH;
		}
		set
		{
			if (!_HH.Equals(value))
			{
				_HH = value;
			}
		}
	}

	[Column(Storage = "_BienServ", DbType = "Decimal(0,0)")]
	public decimal? BienServ
	{
		get
		{
			return _BienServ;
		}
		set
		{
			if (!_BienServ.Equals(value))
			{
				_BienServ = value;
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

	[Column(Storage = "_Avance", DbType = "Decimal(0,0)")]
	public decimal? Avance
	{
		get
		{
			return _Avance;
		}
		set
		{
			if (!_Avance.Equals(value))
			{
				_Avance = value;
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

	[Column(Storage = "_UnidsOrgs", DbType = "VarChar(20)")]
	public string UnidsOrgs
	{
		get
		{
			return _UnidsOrgs;
		}
		set
		{
			if (!string.Equals(_UnidsOrgs, value))
			{
				_UnidsOrgs = value;
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

	[Column(Storage = "_Observacion", DbType = "VarChar(500)")]
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
}
