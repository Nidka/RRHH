using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spCJR_llenarNormaRegionalResult
{
	private int _idtiponorma;

	private string _descriptiponorma;

	private string _NumOrdenanza;

	private DateTime? _FechaOrdenanza;

	private int? _idtipoproyec;

	private string _descriptipoproyec;

	private string _NumProyecto;

	[Column(Storage = "_idtiponorma", DbType = "Int NOT NULL")]
	public int idtiponorma
	{
		get
		{
			return _idtiponorma;
		}
		set
		{
			if (_idtiponorma != value)
			{
				_idtiponorma = value;
			}
		}
	}

	[Column(Storage = "_descriptiponorma", DbType = "VarChar(50)")]
	public string descriptiponorma
	{
		get
		{
			return _descriptiponorma;
		}
		set
		{
			if (!string.Equals(_descriptiponorma, value))
			{
				_descriptiponorma = value;
			}
		}
	}

	[Column(Storage = "_NumOrdenanza", DbType = "VarChar(120) NOT NULL", CanBeNull = false)]
	public string NumOrdenanza
	{
		get
		{
			return _NumOrdenanza;
		}
		set
		{
			if (!string.Equals(_NumOrdenanza, value))
			{
				_NumOrdenanza = value;
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

	[Column(Storage = "_idtipoproyec", DbType = "Int")]
	public int? idtipoproyec
	{
		get
		{
			return _idtipoproyec;
		}
		set
		{
			if (!_idtipoproyec.Equals(value))
			{
				_idtipoproyec = value;
			}
		}
	}

	[Column(Storage = "_descriptipoproyec", DbType = "VarChar(50)")]
	public string descriptipoproyec
	{
		get
		{
			return _descriptipoproyec;
		}
		set
		{
			if (!string.Equals(_descriptipoproyec, value))
			{
				_descriptipoproyec = value;
			}
		}
	}

	[Column(Storage = "_NumProyecto", DbType = "VarChar(120)")]
	public string NumProyecto
	{
		get
		{
			return _NumProyecto;
		}
		set
		{
			if (!string.Equals(_NumProyecto, value))
			{
				_NumProyecto = value;
			}
		}
	}
}
