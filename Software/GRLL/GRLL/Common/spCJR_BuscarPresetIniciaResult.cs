using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spCJR_BuscarPresetIniciaResult
{
	private string _NumOficioIniciativa;

	private DateTime? _fechaemision;

	private string _nombreresponsable;

	private int? _idoperador;

	private int _numtema;

	private string _temadescrip;

	private string _Numproyecto;

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

	[Column(Storage = "_fechaemision", DbType = "DateTime")]
	public DateTime? fechaemision
	{
		get
		{
			return _fechaemision;
		}
		set
		{
			if (!_fechaemision.Equals(value))
			{
				_fechaemision = value;
			}
		}
	}

	[Column(Storage = "_nombreresponsable", DbType = "VarChar(200)")]
	public string nombreresponsable
	{
		get
		{
			return _nombreresponsable;
		}
		set
		{
			if (!string.Equals(_nombreresponsable, value))
			{
				_nombreresponsable = value;
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

	[Column(Storage = "_Numproyecto", DbType = "VarChar(120)")]
	public string Numproyecto
	{
		get
		{
			return _Numproyecto;
		}
		set
		{
			if (!string.Equals(_Numproyecto, value))
			{
				_Numproyecto = value;
			}
		}
	}
}
