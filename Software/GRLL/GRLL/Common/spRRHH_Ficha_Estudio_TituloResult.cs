using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spRRHH_Ficha_Estudio_TituloResult
{
	private string _NumColegiatura;

	private string _DenominacionGrado;

	private string _Institucion;

	private DateTime? _Fecha;

	private int? _IdEmpleado;

	[Column(Storage = "_NumColegiatura", DbType = "VarChar(20) NOT NULL", CanBeNull = false)]
	public string NumColegiatura
	{
		get
		{
			return _NumColegiatura;
		}
		set
		{
			if (!string.Equals(_NumColegiatura, value))
			{
				_NumColegiatura = value;
			}
		}
	}

	[Column(Storage = "_DenominacionGrado", DbType = "VarChar(100)")]
	public string DenominacionGrado
	{
		get
		{
			return _DenominacionGrado;
		}
		set
		{
			if (!string.Equals(_DenominacionGrado, value))
			{
				_DenominacionGrado = value;
			}
		}
	}

	[Column(Storage = "_Institucion", DbType = "VarChar(60)")]
	public string Institucion
	{
		get
		{
			return _Institucion;
		}
		set
		{
			if (!string.Equals(_Institucion, value))
			{
				_Institucion = value;
			}
		}
	}

	[Column(Storage = "_Fecha", DbType = "DateTime")]
	public DateTime? Fecha
	{
		get
		{
			return _Fecha;
		}
		set
		{
			if (!_Fecha.Equals(value))
			{
				_Fecha = value;
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
