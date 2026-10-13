using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.vs_CJr_ProyectoNor")]
public class vs_CJr_ProyectoNor
{
	private string _NumOficioIniciativa;

	private int? _numtema;

	private string _DescripTipoProyec;

	private string _numproyecto;

	private int _idTipoProyec;

	private string _OfTrasComision;

	private DateTime? _FechaOfTrasComision;

	private string _numdictamen;

	private DateTime? _fechadictamen;

	private bool? _aprobado;

	private string _AprobacionDescrip;

	private string _SesionDescrip;

	private DateTime? _FechaSesion;

	private string _OfPromulNorma;

	private DateTime? _FechaOfPromulNorma;

	private string _OfDevolucion;

	private DateTime? _FechaOfDevolucion;

	[Column(Storage = "_NumOficioIniciativa", DbType = "VarChar(120)")]
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

	[Column(Storage = "_numtema", DbType = "Int")]
	public int? numtema
	{
		get
		{
			return _numtema;
		}
		set
		{
			if (!_numtema.Equals(value))
			{
				_numtema = value;
			}
		}
	}

	[Column(Storage = "_DescripTipoProyec", DbType = "VarChar(50)")]
	public string DescripTipoProyec
	{
		get
		{
			return _DescripTipoProyec;
		}
		set
		{
			if (!string.Equals(_DescripTipoProyec, value))
			{
				_DescripTipoProyec = value;
			}
		}
	}

	[Column(Storage = "_numproyecto", DbType = "VarChar(120) NOT NULL", CanBeNull = false)]
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

	[Column(Storage = "_idTipoProyec", DbType = "Int NOT NULL")]
	public int idTipoProyec
	{
		get
		{
			return _idTipoProyec;
		}
		set
		{
			if (_idTipoProyec != value)
			{
				_idTipoProyec = value;
			}
		}
	}

	[Column(Storage = "_OfTrasComision", DbType = "VarChar(120)")]
	public string OfTrasComision
	{
		get
		{
			return _OfTrasComision;
		}
		set
		{
			if (!string.Equals(_OfTrasComision, value))
			{
				_OfTrasComision = value;
			}
		}
	}

	[Column(Storage = "_FechaOfTrasComision", DbType = "DateTime")]
	public DateTime? FechaOfTrasComision
	{
		get
		{
			return _FechaOfTrasComision;
		}
		set
		{
			if (!_FechaOfTrasComision.Equals(value))
			{
				_FechaOfTrasComision = value;
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

	[Column(Storage = "_fechadictamen", DbType = "DateTime")]
	public DateTime? fechadictamen
	{
		get
		{
			return _fechadictamen;
		}
		set
		{
			if (!_fechadictamen.Equals(value))
			{
				_fechadictamen = value;
			}
		}
	}

	[Column(Storage = "_aprobado", DbType = "Bit")]
	public bool? aprobado
	{
		get
		{
			return _aprobado;
		}
		set
		{
			if (!_aprobado.Equals(value))
			{
				_aprobado = value;
			}
		}
	}

	[Column(Storage = "_AprobacionDescrip", DbType = "VarChar(20)")]
	public string AprobacionDescrip
	{
		get
		{
			return _AprobacionDescrip;
		}
		set
		{
			if (!string.Equals(_AprobacionDescrip, value))
			{
				_AprobacionDescrip = value;
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

	[Column(Storage = "_FechaSesion", DbType = "DateTime")]
	public DateTime? FechaSesion
	{
		get
		{
			return _FechaSesion;
		}
		set
		{
			if (!_FechaSesion.Equals(value))
			{
				_FechaSesion = value;
			}
		}
	}

	[Column(Storage = "_OfPromulNorma", DbType = "VarChar(120)")]
	public string OfPromulNorma
	{
		get
		{
			return _OfPromulNorma;
		}
		set
		{
			if (!string.Equals(_OfPromulNorma, value))
			{
				_OfPromulNorma = value;
			}
		}
	}

	[Column(Storage = "_FechaOfPromulNorma", DbType = "DateTime")]
	public DateTime? FechaOfPromulNorma
	{
		get
		{
			return _FechaOfPromulNorma;
		}
		set
		{
			if (!_FechaOfPromulNorma.Equals(value))
			{
				_FechaOfPromulNorma = value;
			}
		}
	}

	[Column(Storage = "_OfDevolucion", DbType = "VarChar(120)")]
	public string OfDevolucion
	{
		get
		{
			return _OfDevolucion;
		}
		set
		{
			if (!string.Equals(_OfDevolucion, value))
			{
				_OfDevolucion = value;
			}
		}
	}

	[Column(Storage = "_FechaOfDevolucion", DbType = "DateTime")]
	public DateTime? FechaOfDevolucion
	{
		get
		{
			return _FechaOfDevolucion;
		}
		set
		{
			if (!_FechaOfDevolucion.Equals(value))
			{
				_FechaOfDevolucion = value;
			}
		}
	}
}
