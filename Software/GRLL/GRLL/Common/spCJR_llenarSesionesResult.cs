using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spCJR_llenarSesionesResult
{
	private int _idtipoproyec;

	private string _Numproyecto;

	private int _NumSesion;

	private DateTime? _FechaSesion;

	private string _sesionDescrip;

	[Column(Storage = "_idtipoproyec", DbType = "Int NOT NULL")]
	public int idtipoproyec
	{
		get
		{
			return _idtipoproyec;
		}
		set
		{
			if (_idtipoproyec != value)
			{
				_idtipoproyec = value;
			}
		}
	}

	[Column(Storage = "_Numproyecto", DbType = "VarChar(120) NOT NULL", CanBeNull = false)]
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

	[Column(Storage = "_NumSesion", DbType = "Int NOT NULL")]
	public int NumSesion
	{
		get
		{
			return _NumSesion;
		}
		set
		{
			if (_NumSesion != value)
			{
				_NumSesion = value;
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

	[Column(Storage = "_sesionDescrip", DbType = "VarChar(25)")]
	public string sesionDescrip
	{
		get
		{
			return _sesionDescrip;
		}
		set
		{
			if (!string.Equals(_sesionDescrip, value))
			{
				_sesionDescrip = value;
			}
		}
	}
}
