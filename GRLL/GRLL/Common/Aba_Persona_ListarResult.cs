using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class Aba_Persona_ListarResult
{
	private int _idpersona;

	private string _despersona;

	private string _destipodocid;

	private string _numdocid;

	private string _direccion;

	private DateTime? _fechanacimiento;

	private string _idubigeo;

	[Column(Storage = "_idpersona", DbType = "Int NOT NULL")]
	public int idpersona
	{
		get
		{
			return _idpersona;
		}
		set
		{
			if (_idpersona != value)
			{
				_idpersona = value;
			}
		}
	}

	[Column(Storage = "_despersona", DbType = "VarChar(162)")]
	public string despersona
	{
		get
		{
			return _despersona;
		}
		set
		{
			if (!string.Equals(_despersona, value))
			{
				_despersona = value;
			}
		}
	}

	[Column(Storage = "_destipodocid", DbType = "VarChar(40)")]
	public string destipodocid
	{
		get
		{
			return _destipodocid;
		}
		set
		{
			if (!string.Equals(_destipodocid, value))
			{
				_destipodocid = value;
			}
		}
	}

	[Column(Storage = "_numdocid", DbType = "Char(12)")]
	public string numdocid
	{
		get
		{
			return _numdocid;
		}
		set
		{
			if (!string.Equals(_numdocid, value))
			{
				_numdocid = value;
			}
		}
	}

	[Column(Storage = "_direccion", DbType = "VarChar(100)")]
	public string direccion
	{
		get
		{
			return _direccion;
		}
		set
		{
			if (!string.Equals(_direccion, value))
			{
				_direccion = value;
			}
		}
	}

	[Column(Storage = "_fechanacimiento", DbType = "DateTime")]
	public DateTime? fechanacimiento
	{
		get
		{
			return _fechanacimiento;
		}
		set
		{
			if (!_fechanacimiento.Equals(value))
			{
				_fechanacimiento = value;
			}
		}
	}

	[Column(Storage = "_idubigeo", DbType = "Char(6)")]
	public string idubigeo
	{
		get
		{
			return _idubigeo;
		}
		set
		{
			if (!string.Equals(_idubigeo, value))
			{
				_idubigeo = value;
			}
		}
	}
}
