using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spCJ_Banco_SelectResult
{
	private int _IdBanco;

	private string _Nombre;

	private string _Abreviatura;

	private string _IdUbigeo;

	private string _Direccion;

	[Column(Storage = "_IdBanco", DbType = "Int NOT NULL")]
	public int IdBanco
	{
		get
		{
			return _IdBanco;
		}
		set
		{
			if (_IdBanco != value)
			{
				_IdBanco = value;
			}
		}
	}

	[Column(Storage = "_Nombre", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
	public string Nombre
	{
		get
		{
			return _Nombre;
		}
		set
		{
			if (!string.Equals(_Nombre, value))
			{
				_Nombre = value;
			}
		}
	}

	[Column(Storage = "_Abreviatura", DbType = "VarChar(10) NOT NULL", CanBeNull = false)]
	public string Abreviatura
	{
		get
		{
			return _Abreviatura;
		}
		set
		{
			if (!string.Equals(_Abreviatura, value))
			{
				_Abreviatura = value;
			}
		}
	}

	[Column(Storage = "_IdUbigeo", DbType = "VarChar(6) NOT NULL", CanBeNull = false)]
	public string IdUbigeo
	{
		get
		{
			return _IdUbigeo;
		}
		set
		{
			if (!string.Equals(_IdUbigeo, value))
			{
				_IdUbigeo = value;
			}
		}
	}

	[Column(Storage = "_Direccion", DbType = "VarChar(80) NOT NULL", CanBeNull = false)]
	public string Direccion
	{
		get
		{
			return _Direccion;
		}
		set
		{
			if (!string.Equals(_Direccion, value))
			{
				_Direccion = value;
			}
		}
	}
}
