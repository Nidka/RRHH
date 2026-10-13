using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spActividad_SelectResult
{
	private int _IdObjetivo;

	private int _IdActividad;

	private int? _NroActividad;

	private string _Actividad;

	private int _IdEmpleado;

	private string _Empleado;

	private int? _IdTipoTrabajador;

	private int _IdUnidMed;

	private string _UnidadMedida;

	private string _UM;

	private decimal _Meta;

	private string _IsMeta;

	private decimal _MetaMin;

	private int _TrabXActiv;

	private decimal? _HH;

	private decimal? _BienServ;

	private int _Importancia;

	private decimal? _Avance;

	private decimal _AvanceAnual;

	private DateTime _FechaInicio;

	private string _Fecha_Inicio;

	private DateTime _FechaFin;

	private string _Fecha_Fin;

	private string _UnidsOrgs;

	private int _IdPresupuesto;

	private string _IdsA;

	private DateTime _FI_O;

	private string _F_I_O;

	private DateTime _FF_O;

	private string _F_F_O;

	private string _Objetivo;

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

	[Column(Storage = "_IdEmpleado", DbType = "Int NOT NULL")]
	public int IdEmpleado
	{
		get
		{
			return _IdEmpleado;
		}
		set
		{
			if (_IdEmpleado != value)
			{
				_IdEmpleado = value;
			}
		}
	}

	[Column(Storage = "_Empleado", DbType = "VarChar(163) NOT NULL", CanBeNull = false)]
	public string Empleado
	{
		get
		{
			return _Empleado;
		}
		set
		{
			if (!string.Equals(_Empleado, value))
			{
				_Empleado = value;
			}
		}
	}

	[Column(Storage = "_IdTipoTrabajador", DbType = "Int")]
	public int? IdTipoTrabajador
	{
		get
		{
			return _IdTipoTrabajador;
		}
		set
		{
			if (!_IdTipoTrabajador.Equals(value))
			{
				_IdTipoTrabajador = value;
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

	[Column(Storage = "_IsMeta", DbType = "VarChar(14) NOT NULL", CanBeNull = false)]
	public string IsMeta
	{
		get
		{
			return _IsMeta;
		}
		set
		{
			if (!string.Equals(_IsMeta, value))
			{
				_IsMeta = value;
			}
		}
	}

	[Column(Storage = "_MetaMin", DbType = "Decimal(0,0) NOT NULL")]
	public decimal MetaMin
	{
		get
		{
			return _MetaMin;
		}
		set
		{
			if (decimal.Compare(_MetaMin, value) != 0)
			{
				_MetaMin = value;
			}
		}
	}

	[Column(Storage = "_TrabXActiv", DbType = "Int NOT NULL")]
	public int TrabXActiv
	{
		get
		{
			return _TrabXActiv;
		}
		set
		{
			if (_TrabXActiv != value)
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

	[Column(Storage = "_Fecha_Inicio", DbType = "VarChar(10)")]
	public string Fecha_Inicio
	{
		get
		{
			return _Fecha_Inicio;
		}
		set
		{
			if (!string.Equals(_Fecha_Inicio, value))
			{
				_Fecha_Inicio = value;
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

	[Column(Storage = "_Fecha_Fin", DbType = "VarChar(10)")]
	public string Fecha_Fin
	{
		get
		{
			return _Fecha_Fin;
		}
		set
		{
			if (!string.Equals(_Fecha_Fin, value))
			{
				_Fecha_Fin = value;
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

	[Column(Storage = "_IdsA", DbType = "VarChar(21)")]
	public string IdsA
	{
		get
		{
			return _IdsA;
		}
		set
		{
			if (!string.Equals(_IdsA, value))
			{
				_IdsA = value;
			}
		}
	}

	[Column(Storage = "_FI_O", DbType = "SmallDateTime NOT NULL")]
	public DateTime FI_O
	{
		get
		{
			return _FI_O;
		}
		set
		{
			if (DateTime.Compare(_FI_O, value) != 0)
			{
				_FI_O = value;
			}
		}
	}

	[Column(Storage = "_F_I_O", DbType = "VarChar(10)")]
	public string F_I_O
	{
		get
		{
			return _F_I_O;
		}
		set
		{
			if (!string.Equals(_F_I_O, value))
			{
				_F_I_O = value;
			}
		}
	}

	[Column(Storage = "_FF_O", DbType = "SmallDateTime NOT NULL")]
	public DateTime FF_O
	{
		get
		{
			return _FF_O;
		}
		set
		{
			if (DateTime.Compare(_FF_O, value) != 0)
			{
				_FF_O = value;
			}
		}
	}

	[Column(Storage = "_F_F_O", DbType = "VarChar(10)")]
	public string F_F_O
	{
		get
		{
			return _F_F_O;
		}
		set
		{
			if (!string.Equals(_F_F_O, value))
			{
				_F_F_O = value;
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
}
