using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spCJ_NroCuenta_SelectResult
{
	private int _IdBanco;

	private string _Nombre;

	private string _Abreviatura;

	private string _NroCta;

	private int _IdTipoMoneda;

	private string _TipoMoneda;

	private string _Moneda;

	private char? _Estado;

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

	[Column(Storage = "_NroCta", DbType = "VarChar(12) NOT NULL", CanBeNull = false)]
	public string NroCta
	{
		get
		{
			return _NroCta;
		}
		set
		{
			if (!string.Equals(_NroCta, value))
			{
				_NroCta = value;
			}
		}
	}

	[Column(Storage = "_IdTipoMoneda", DbType = "Int NOT NULL")]
	public int IdTipoMoneda
	{
		get
		{
			return _IdTipoMoneda;
		}
		set
		{
			if (_IdTipoMoneda != value)
			{
				_IdTipoMoneda = value;
			}
		}
	}

	[Column(Storage = "_TipoMoneda", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
	public string TipoMoneda
	{
		get
		{
			return _TipoMoneda;
		}
		set
		{
			if (!string.Equals(_TipoMoneda, value))
			{
				_TipoMoneda = value;
			}
		}
	}

	[Column(Storage = "_Moneda", DbType = "VarChar(5) NOT NULL", CanBeNull = false)]
	public string Moneda
	{
		get
		{
			return _Moneda;
		}
		set
		{
			if (!string.Equals(_Moneda, value))
			{
				_Moneda = value;
			}
		}
	}

	[Column(Storage = "_Estado", DbType = "VarChar(1)")]
	public char? Estado
	{
		get
		{
			return _Estado;
		}
		set
		{
			if (!_Estado.Equals(value))
			{
				_Estado = value;
			}
		}
	}
}
