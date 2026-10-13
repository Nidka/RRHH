using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spCJR_Report_GeneralResult
{
	private string _NumOficioIniciativa;

	private DateTime? _FechaEmision;

	private string _temadescrip;

	private string _NombreResponsable;

	private string _Operador;

	private string _OficioSolTec;

	private string _DestinoSolTEc;

	private DateTime? _FechaSolTec;

	private string _tipo;

	private string _RespSolTec;

	private string _OrigenResSolTec;

	private DateTime? _FechaResSolTec;

	private string _numproyecto;

	private string _OficioTrasladoComision;

	private DateTime? _FechaTrasladoComison;

	private string _numdictamen;

	private DateTime? _fechaDictamen;

	private string _aprobado;

	private string _aprobacionDescrip;

	private string _SesionDescrip;

	private DateTime? _fechasesion;

	private string _OfSolPromulgacion;

	private DateTime? _FechaPromulgacion;

	private string _OficioDevolucion;

	private DateTime? _FechaDevolucion;

	private string _numOrdenanza;

	private DateTime? _FechaOrdenanza;

	private string _SolOfPublicacionNorma;

	private DateTime? _FechaOfPublicacionNorma;

	private string _TipoMedioDescrip;

	private DateTime? _FechaPubli;

	private string _Paginas;

	private string _NombreMedio;

	[Column(Storage = "_NumOficioIniciativa", DbType = "VarChar(120) NOT NULL", CanBeNull = false)]
	public string NumOficioIniciativa
	{
		get
		{
			return _NumOficioIniciativa;
		}
		set
		{
			if (!string.Equals(_NumOficioIniciativa, value))
			{
				_NumOficioIniciativa = value;
			}
		}
	}

	[Column(Storage = "_FechaEmision", DbType = "DateTime")]
	public DateTime? FechaEmision
	{
		get
		{
			return _FechaEmision;
		}
		set
		{
			if (!_FechaEmision.Equals(value))
			{
				_FechaEmision = value;
			}
		}
	}

	[Column(Storage = "_temadescrip", DbType = "VarChar(2000)")]
	public string temadescrip
	{
		get
		{
			return _temadescrip;
		}
		set
		{
			if (!string.Equals(_temadescrip, value))
			{
				_temadescrip = value;
			}
		}
	}

	[Column(Storage = "_NombreResponsable", DbType = "VarChar(200)")]
	public string NombreResponsable
	{
		get
		{
			return _NombreResponsable;
		}
		set
		{
			if (!string.Equals(_NombreResponsable, value))
			{
				_NombreResponsable = value;
			}
		}
	}

	[Column(Storage = "_Operador", DbType = "VarChar(162)")]
	public string Operador
	{
		get
		{
			return _Operador;
		}
		set
		{
			if (!string.Equals(_Operador, value))
			{
				_Operador = value;
			}
		}
	}

	[Column(Storage = "_OficioSolTec", DbType = "VarChar(120)")]
	public string OficioSolTec
	{
		get
		{
			return _OficioSolTec;
		}
		set
		{
			if (!string.Equals(_OficioSolTec, value))
			{
				_OficioSolTec = value;
			}
		}
	}

	[Column(Storage = "_DestinoSolTEc", DbType = "VarChar(200)")]
	public string DestinoSolTEc
	{
		get
		{
			return _DestinoSolTEc;
		}
		set
		{
			if (!string.Equals(_DestinoSolTEc, value))
			{
				_DestinoSolTEc = value;
			}
		}
	}

	[Column(Storage = "_FechaSolTec", DbType = "DateTime")]
	public DateTime? FechaSolTec
	{
		get
		{
			return _FechaSolTec;
		}
		set
		{
			if (!_FechaSolTec.Equals(value))
			{
				_FechaSolTec = value;
			}
		}
	}

	[Column(Storage = "_tipo", DbType = "VarChar(7)")]
	public string tipo
	{
		get
		{
			return _tipo;
		}
		set
		{
			if (!string.Equals(_tipo, value))
			{
				_tipo = value;
			}
		}
	}

	[Column(Storage = "_RespSolTec", DbType = "VarChar(120)")]
	public string RespSolTec
	{
		get
		{
			return _RespSolTec;
		}
		set
		{
			if (!string.Equals(_RespSolTec, value))
			{
				_RespSolTec = value;
			}
		}
	}

	[Column(Storage = "_OrigenResSolTec", DbType = "VarChar(200)")]
	public string OrigenResSolTec
	{
		get
		{
			return _OrigenResSolTec;
		}
		set
		{
			if (!string.Equals(_OrigenResSolTec, value))
			{
				_OrigenResSolTec = value;
			}
		}
	}

	[Column(Storage = "_FechaResSolTec", DbType = "DateTime")]
	public DateTime? FechaResSolTec
	{
		get
		{
			return _FechaResSolTec;
		}
		set
		{
			if (!_FechaResSolTec.Equals(value))
			{
				_FechaResSolTec = value;
			}
		}
	}

	[Column(Storage = "_numproyecto", DbType = "VarChar(120)")]
	public string numproyecto
	{
		get
		{
			return _numproyecto;
		}
		set
		{
			if (!string.Equals(_numproyecto, value))
			{
				_numproyecto = value;
			}
		}
	}

	[Column(Storage = "_OficioTrasladoComision", DbType = "VarChar(120)")]
	public string OficioTrasladoComision
	{
		get
		{
			return _OficioTrasladoComision;
		}
		set
		{
			if (!string.Equals(_OficioTrasladoComision, value))
			{
				_OficioTrasladoComision = value;
			}
		}
	}

	[Column(Storage = "_FechaTrasladoComison", DbType = "DateTime")]
	public DateTime? FechaTrasladoComison
	{
		get
		{
			return _FechaTrasladoComison;
		}
		set
		{
			if (!_FechaTrasladoComison.Equals(value))
			{
				_FechaTrasladoComison = value;
			}
		}
	}

	[Column(Storage = "_numdictamen", DbType = "VarChar(120)")]
	public string numdictamen
	{
		get
		{
			return _numdictamen;
		}
		set
		{
			if (!string.Equals(_numdictamen, value))
			{
				_numdictamen = value;
			}
		}
	}

	[Column(Storage = "_fechaDictamen", DbType = "DateTime")]
	public DateTime? fechaDictamen
	{
		get
		{
			return _fechaDictamen;
		}
		set
		{
			if (!_fechaDictamen.Equals(value))
			{
				_fechaDictamen = value;
			}
		}
	}

	[Column(Storage = "_aprobado", DbType = "VarChar(11)")]
	public string aprobado
	{
		get
		{
			return _aprobado;
		}
		set
		{
			if (!string.Equals(_aprobado, value))
			{
				_aprobado = value;
			}
		}
	}

	[Column(Storage = "_aprobacionDescrip", DbType = "VarChar(20)")]
	public string aprobacionDescrip
	{
		get
		{
			return _aprobacionDescrip;
		}
		set
		{
			if (!string.Equals(_aprobacionDescrip, value))
			{
				_aprobacionDescrip = value;
			}
		}
	}

	[Column(Storage = "_SesionDescrip", DbType = "VarChar(25)")]
	public string SesionDescrip
	{
		get
		{
			return _SesionDescrip;
		}
		set
		{
			if (!string.Equals(_SesionDescrip, value))
			{
				_SesionDescrip = value;
			}
		}
	}

	[Column(Storage = "_fechasesion", DbType = "DateTime")]
	public DateTime? fechasesion
	{
		get
		{
			return _fechasesion;
		}
		set
		{
			if (!_fechasesion.Equals(value))
			{
				_fechasesion = value;
			}
		}
	}

	[Column(Storage = "_OfSolPromulgacion", DbType = "VarChar(120)")]
	public string OfSolPromulgacion
	{
		get
		{
			return _OfSolPromulgacion;
		}
		set
		{
			if (!string.Equals(_OfSolPromulgacion, value))
			{
				_OfSolPromulgacion = value;
			}
		}
	}

	[Column(Storage = "_FechaPromulgacion", DbType = "DateTime")]
	public DateTime? FechaPromulgacion
	{
		get
		{
			return _FechaPromulgacion;
		}
		set
		{
			if (!_FechaPromulgacion.Equals(value))
			{
				_FechaPromulgacion = value;
			}
		}
	}

	[Column(Storage = "_OficioDevolucion", DbType = "VarChar(120)")]
	public string OficioDevolucion
	{
		get
		{
			return _OficioDevolucion;
		}
		set
		{
			if (!string.Equals(_OficioDevolucion, value))
			{
				_OficioDevolucion = value;
			}
		}
	}

	[Column(Storage = "_FechaDevolucion", DbType = "DateTime")]
	public DateTime? FechaDevolucion
	{
		get
		{
			return _FechaDevolucion;
		}
		set
		{
			if (!_FechaDevolucion.Equals(value))
			{
				_FechaDevolucion = value;
			}
		}
	}

	[Column(Storage = "_numOrdenanza", DbType = "VarChar(120)")]
	public string numOrdenanza
	{
		get
		{
			return _numOrdenanza;
		}
		set
		{
			if (!string.Equals(_numOrdenanza, value))
			{
				_numOrdenanza = value;
			}
		}
	}

	[Column(Storage = "_FechaOrdenanza", DbType = "DateTime")]
	public DateTime? FechaOrdenanza
	{
		get
		{
			return _FechaOrdenanza;
		}
		set
		{
			if (!_FechaOrdenanza.Equals(value))
			{
				_FechaOrdenanza = value;
			}
		}
	}

	[Column(Storage = "_SolOfPublicacionNorma", DbType = "VarChar(120)")]
	public string SolOfPublicacionNorma
	{
		get
		{
			return _SolOfPublicacionNorma;
		}
		set
		{
			if (!string.Equals(_SolOfPublicacionNorma, value))
			{
				_SolOfPublicacionNorma = value;
			}
		}
	}

	[Column(Storage = "_FechaOfPublicacionNorma", DbType = "DateTime")]
	public DateTime? FechaOfPublicacionNorma
	{
		get
		{
			return _FechaOfPublicacionNorma;
		}
		set
		{
			if (!_FechaOfPublicacionNorma.Equals(value))
			{
				_FechaOfPublicacionNorma = value;
			}
		}
	}

	[Column(Storage = "_TipoMedioDescrip", DbType = "VarChar(20)")]
	public string TipoMedioDescrip
	{
		get
		{
			return _TipoMedioDescrip;
		}
		set
		{
			if (!string.Equals(_TipoMedioDescrip, value))
			{
				_TipoMedioDescrip = value;
			}
		}
	}

	[Column(Storage = "_FechaPubli", DbType = "DateTime")]
	public DateTime? FechaPubli
	{
		get
		{
			return _FechaPubli;
		}
		set
		{
			if (!_FechaPubli.Equals(value))
			{
				_FechaPubli = value;
			}
		}
	}

	[Column(Storage = "_Paginas", DbType = "VarChar(30)")]
	public string Paginas
	{
		get
		{
			return _Paginas;
		}
		set
		{
			if (!string.Equals(_Paginas, value))
			{
				_Paginas = value;
			}
		}
	}

	[Column(Storage = "_NombreMedio", DbType = "VarChar(80)")]
	public string NombreMedio
	{
		get
		{
			return _NombreMedio;
		}
		set
		{
			if (!string.Equals(_NombreMedio, value))
			{
				_NombreMedio = value;
			}
		}
	}
}
