using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spCJ_ChequeCaj_SelectResult
{
	private int _IdCheque;

	private int _IdBanco;

	private string _Nombre;

	private string _Abreviatura;

	private string _NroCheque;

	private string _GiradorNro;

	private char? _Plaza;

	private decimal? _Total;

	private char? _Estado;

	private int? _IdTipoMoneda;

	private string _Moneda;

	private string _AbreviaturaM;

	[Column(Storage = "_IdCheque", DbType = "Int NOT NULL")]
	public int IdCheque
	{
		get
		{
			return _IdCheque;
		}
		set
		{
			if (_IdCheque != value)
			{
				_IdCheque = value;
			}
		}
	}

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

	[Column(Storage = "_NroCheque", DbType = "VarChar(15) NOT NULL", CanBeNull = false)]
	public string NroCheque
	{
		get
		{
			return _NroCheque;
		}
		set
		{
			if (!string.Equals(_NroCheque, value))
			{
				_NroCheque = value;
			}
		}
	}

	[Column(Storage = "_GiradorNro", DbType = "VarChar(15) NOT NULL", CanBeNull = false)]
	public string GiradorNro
	{
		get
		{
			return _GiradorNro;
		}
		set
		{
			if (!string.Equals(_GiradorNro, value))
			{
				_GiradorNro = value;
			}
		}
	}

	[Column(Storage = "_Plaza", DbType = "VarChar(1)")]
	public char? Plaza
	{
		get
		{
			return _Plaza;
		}
		set
		{
			if (!_Plaza.Equals(value))
			{
				_Plaza = value;
			}
		}
	}

	[Column(Storage = "_Total", DbType = "Decimal(0,0)")]
	public decimal? Total
	{
		get
		{
			return _Total;
		}
		set
		{
			if (!_Total.Equals(value))
			{
				_Total = value;
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

	[Column(Storage = "_IdTipoMoneda", DbType = "Int")]
	public int? IdTipoMoneda
	{
		get
		{
			return _IdTipoMoneda;
		}
		set
		{
			if (!_IdTipoMoneda.Equals(value))
			{
				_IdTipoMoneda = value;
			}
		}
	}

	[Column(Storage = "_Moneda", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
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

	[Column(Storage = "_AbreviaturaM", DbType = "VarChar(5) NOT NULL", CanBeNull = false)]
	public string AbreviaturaM
	{
		get
		{
			return _AbreviaturaM;
		}
		set
		{
			if (!string.Equals(_AbreviaturaM, value))
			{
				_AbreviaturaM = value;
			}
		}
	}
}
