using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spCJ_PapeletDepositCajSelectFFResult
{
	private int _IdBanco;

	private string _Banco;

	private string _NroCta;

	private string _TipoMoneda;

	private string _Moneda;

	private string _NroPapeleta;

	private string _FechaPapelDep;

	private string _FechaDeposito;

	private decimal? _Total;

	private string _DNIDepositante;

	private string _Persona;

	private string _TipoDeposito;

	private char? _Plaza;

	private string _ReferSIAF;

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

	[Column(Storage = "_Banco", DbType = "VarChar(10)")]
	public string Banco
	{
		get
		{
			return _Banco;
		}
		set
		{
			if (!string.Equals(_Banco, value))
			{
				_Banco = value;
			}
		}
	}

	[Column(Storage = "_NroCta", DbType = "VarChar(12)")]
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

	[Column(Storage = "_Moneda", DbType = "VarChar(5)")]
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

	[Column(Storage = "_NroPapeleta", DbType = "VarChar(10) NOT NULL", CanBeNull = false)]
	public string NroPapeleta
	{
		get
		{
			return _NroPapeleta;
		}
		set
		{
			if (!string.Equals(_NroPapeleta, value))
			{
				_NroPapeleta = value;
			}
		}
	}

	[Column(Storage = "_FechaPapelDep", DbType = "VarChar(20)")]
	public string FechaPapelDep
	{
		get
		{
			return _FechaPapelDep;
		}
		set
		{
			if (!string.Equals(_FechaPapelDep, value))
			{
				_FechaPapelDep = value;
			}
		}
	}

	[Column(Storage = "_FechaDeposito", DbType = "VarChar(20)")]
	public string FechaDeposito
	{
		get
		{
			return _FechaDeposito;
		}
		set
		{
			if (!string.Equals(_FechaDeposito, value))
			{
				_FechaDeposito = value;
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

	[Column(Storage = "_DNIDepositante", DbType = "VarChar(8) NOT NULL", CanBeNull = false)]
	public string DNIDepositante
	{
		get
		{
			return _DNIDepositante;
		}
		set
		{
			if (!string.Equals(_DNIDepositante, value))
			{
				_DNIDepositante = value;
			}
		}
	}

	[Column(Storage = "_Persona", DbType = "VarChar(174)")]
	public string Persona
	{
		get
		{
			return _Persona;
		}
		set
		{
			if (!string.Equals(_Persona, value))
			{
				_Persona = value;
			}
		}
	}

	[Column(Storage = "_TipoDeposito", DbType = "VarChar(16) NOT NULL", CanBeNull = false)]
	public string TipoDeposito
	{
		get
		{
			return _TipoDeposito;
		}
		set
		{
			if (!string.Equals(_TipoDeposito, value))
			{
				_TipoDeposito = value;
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

	[Column(Storage = "_ReferSIAF", DbType = "VarChar(6) NOT NULL", CanBeNull = false)]
	public string ReferSIAF
	{
		get
		{
			return _ReferSIAF;
		}
		set
		{
			if (!string.Equals(_ReferSIAF, value))
			{
				_ReferSIAF = value;
			}
		}
	}
}
