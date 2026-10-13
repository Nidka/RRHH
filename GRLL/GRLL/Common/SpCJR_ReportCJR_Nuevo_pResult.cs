using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class SpCJR_ReportCJR_Nuevo_pResult
{
	private string _NumOficioIniciativa;

	private string _temadescrip;

	private int _numtema;

	private int? _idoperador;

	private DateTime? _FechaEmision;

	private string _NombreResponsable;

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

	[Column(Storage = "_numtema", DbType = "Int NOT NULL")]
	public int numtema
	{
		get
		{
			return _numtema;
		}
		set
		{
			if (_numtema != value)
			{
				_numtema = value;
			}
		}
	}

	[Column(Storage = "_idoperador", DbType = "Int")]
	public int? idoperador
	{
		get
		{
			return _idoperador;
		}
		set
		{
			if (!_idoperador.Equals(value))
			{
				_idoperador = value;
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
}
