using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spCJ_TransferenciaBco_SelectResult
{
	private int _IdTransferencia;

	private int? _IdBancoDe;

	private string _BancoDe;

	private string _AbreviaturaBd;

	private string _NroCtaDe;

	private int? _IdBancoA;

	private string _BancoDa;

	private string _AbreviaturaBa;

	private string _NroCtaA;

	private string _MonedaDa;

	private string _AbrevMonedaDa;

	private decimal? _Total;

	[Column(Storage = "_IdTransferencia", DbType = "Int NOT NULL")]
	public int IdTransferencia
	{
		get
		{
			return _IdTransferencia;
		}
		set
		{
			if (_IdTransferencia != value)
			{
				_IdTransferencia = value;
			}
		}
	}

	[Column(Storage = "_IdBancoDe", DbType = "Int")]
	public int? IdBancoDe
	{
		get
		{
			return _IdBancoDe;
		}
		set
		{
			if (!_IdBancoDe.Equals(value))
			{
				_IdBancoDe = value;
			}
		}
	}

	[Column(Storage = "_BancoDe", DbType = "VarChar(50)")]
	public string BancoDe
	{
		get
		{
			return _BancoDe;
		}
		set
		{
			if (!string.Equals(_BancoDe, value))
			{
				_BancoDe = value;
			}
		}
	}

	[Column(Storage = "_AbreviaturaBd", DbType = "VarChar(10)")]
	public string AbreviaturaBd
	{
		get
		{
			return _AbreviaturaBd;
		}
		set
		{
			if (!string.Equals(_AbreviaturaBd, value))
			{
				_AbreviaturaBd = value;
			}
		}
	}

	[Column(Storage = "_NroCtaDe", DbType = "VarChar(12)")]
	public string NroCtaDe
	{
		get
		{
			return _NroCtaDe;
		}
		set
		{
			if (!string.Equals(_NroCtaDe, value))
			{
				_NroCtaDe = value;
			}
		}
	}

	[Column(Storage = "_IdBancoA", DbType = "Int")]
	public int? IdBancoA
	{
		get
		{
			return _IdBancoA;
		}
		set
		{
			if (!_IdBancoA.Equals(value))
			{
				_IdBancoA = value;
			}
		}
	}

	[Column(Storage = "_BancoDa", DbType = "VarChar(50)")]
	public string BancoDa
	{
		get
		{
			return _BancoDa;
		}
		set
		{
			if (!string.Equals(_BancoDa, value))
			{
				_BancoDa = value;
			}
		}
	}

	[Column(Storage = "_AbreviaturaBa", DbType = "VarChar(10)")]
	public string AbreviaturaBa
	{
		get
		{
			return _AbreviaturaBa;
		}
		set
		{
			if (!string.Equals(_AbreviaturaBa, value))
			{
				_AbreviaturaBa = value;
			}
		}
	}

	[Column(Storage = "_NroCtaA", DbType = "VarChar(12)")]
	public string NroCtaA
	{
		get
		{
			return _NroCtaA;
		}
		set
		{
			if (!string.Equals(_NroCtaA, value))
			{
				_NroCtaA = value;
			}
		}
	}

	[Column(Storage = "_MonedaDa", DbType = "VarChar(50)")]
	public string MonedaDa
	{
		get
		{
			return _MonedaDa;
		}
		set
		{
			if (!string.Equals(_MonedaDa, value))
			{
				_MonedaDa = value;
			}
		}
	}

	[Column(Storage = "_AbrevMonedaDa", DbType = "VarChar(5)")]
	public string AbrevMonedaDa
	{
		get
		{
			return _AbrevMonedaDa;
		}
		set
		{
			if (!string.Equals(_AbrevMonedaDa, value))
			{
				_AbrevMonedaDa = value;
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
}
