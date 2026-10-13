using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spRRHH_Ficha_Estudio_CapacitacionResult
{
	private int _IdCapacitacion;

	private string _NombreCurso;

	private DateTime? _FechaInicio;

	private DateTime? _FechaFin;

	private string _NumHoras;

	private string _InstitucionOrganizadora;

	private int? _IdEmpleado;

	[Column(Storage = "_IdCapacitacion", DbType = "Int NOT NULL")]
	public int IdCapacitacion
	{
		get
		{
			return _IdCapacitacion;
		}
		set
		{
			if (_IdCapacitacion != value)
			{
				_IdCapacitacion = value;
			}
		}
	}

	[Column(Storage = "_NombreCurso", DbType = "VarChar(300)")]
	public string NombreCurso
	{
		get
		{
			return _NombreCurso;
		}
		set
		{
			if (!string.Equals(_NombreCurso, value))
			{
				_NombreCurso = value;
			}
		}
	}

	[Column(Storage = "_FechaInicio", DbType = "DateTime")]
	public DateTime? FechaInicio
	{
		get
		{
			return _FechaInicio;
		}
		set
		{
			if (!_FechaInicio.Equals(value))
			{
				_FechaInicio = value;
			}
		}
	}

	[Column(Storage = "_FechaFin", DbType = "DateTime")]
	public DateTime? FechaFin
	{
		get
		{
			return _FechaFin;
		}
		set
		{
			if (!_FechaFin.Equals(value))
			{
				_FechaFin = value;
			}
		}
	}

	[Column(Storage = "_NumHoras", DbType = "VarChar(5)")]
	public string NumHoras
	{
		get
		{
			return _NumHoras;
		}
		set
		{
			if (!string.Equals(_NumHoras, value))
			{
				_NumHoras = value;
			}
		}
	}

	[Column(Storage = "_InstitucionOrganizadora", DbType = "VarChar(300)")]
	public string InstitucionOrganizadora
	{
		get
		{
			return _InstitucionOrganizadora;
		}
		set
		{
			if (!string.Equals(_InstitucionOrganizadora, value))
			{
				_InstitucionOrganizadora = value;
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
}
