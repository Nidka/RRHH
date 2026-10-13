using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spObjet_Avance_SelectResult
{
	private int? _NroActividad;

	private string _Actividad;

	private string _Empleado;

	private string _UM;

	private decimal? _Meta;

	private string _IsMeta;

	private decimal? _MetaMin;

	private int? _TrabXActiv;

	private decimal? _HH;

	private decimal? _BienServ;

	private decimal? _Importancia;

	private decimal? _Avance;

	private decimal? _AvanceAnual;

	private string _Fecha_Inicio;

	private string _Fecha_Fin;

	private string _UnidsOrgs;

	private string _Observacion;

	private decimal? _AvanceMeta;

	private decimal? _TotalAvanceObjetivo;

	private decimal? _MetaO;

	private decimal? _TotalAvanceObjetivoP;

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

	[Column(Storage = "_Actividad", DbType = "VarChar(300)")]
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

	[Column(Storage = "_Empleado", DbType = "VarChar(100)")]
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

	[Column(Storage = "_UM", DbType = "VarChar(10)")]
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

	[Column(Storage = "_Meta", DbType = "Decimal(0,0)")]
	public decimal? Meta
	{
		get
		{
			return _Meta;
		}
		set
		{
			if (!_Meta.Equals(value))
			{
				_Meta = value;
			}
		}
	}

	[Column(Storage = "_IsMeta", DbType = "VarChar(20)")]
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

	[Column(Storage = "_Importancia", DbType = "Decimal(0,0)")]
	public decimal? Importancia
	{
		get
		{
			return _Importancia;
		}
		set
		{
			if (!_Importancia.Equals(value))
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

	[Column(Storage = "_AvanceMeta", DbType = "Decimal(0,0)")]
	public decimal? AvanceMeta
	{
		get
		{
			return _AvanceMeta;
		}
		set
		{
			if (!_AvanceMeta.Equals(value))
			{
				_AvanceMeta = value;
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

	[Column(Storage = "_MetaO", DbType = "Decimal(0,0)")]
	public decimal? MetaO
	{
		get
		{
			return _MetaO;
		}
		set
		{
			if (!_MetaO.Equals(value))
			{
				_MetaO = value;
			}
		}
	}

	[Column(Storage = "_TotalAvanceObjetivoP", DbType = "Decimal(0,0)")]
	public decimal? TotalAvanceObjetivoP
	{
		get
		{
			return _TotalAvanceObjetivoP;
		}
		set
		{
			if (!_TotalAvanceObjetivoP.Equals(value))
			{
				_TotalAvanceObjetivoP = value;
			}
		}
	}
}
