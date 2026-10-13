using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.vs_aba_NroBien")]
public class vs_aba_NroBien
{
	private string _IDFAMILIA;

	private string _IDGRUPO;

	private string _IDCLASE;

	private int _NUMERO;

	[Column(Storage = "_IDFAMILIA", DbType = "Char(4) NOT NULL", CanBeNull = false)]
	public string IDFAMILIA
	{
		get
		{
			return _IDFAMILIA;
		}
		set
		{
			if (!string.Equals(_IDFAMILIA, value))
			{
				_IDFAMILIA = value;
			}
		}
	}

	[Column(Storage = "_IDGRUPO", DbType = "Char(3) NOT NULL", CanBeNull = false)]
	public string IDGRUPO
	{
		get
		{
			return _IDGRUPO;
		}
		set
		{
			if (!string.Equals(_IDGRUPO, value))
			{
				_IDGRUPO = value;
			}
		}
	}

	[Column(Storage = "_IDCLASE", DbType = "Char(2) NOT NULL", CanBeNull = false)]
	public string IDCLASE
	{
		get
		{
			return _IDCLASE;
		}
		set
		{
			if (!string.Equals(_IDCLASE, value))
			{
				_IDCLASE = value;
			}
		}
	}

	[Column(Storage = "_NUMERO", DbType = "Int NOT NULL")]
	public int NUMERO
	{
		get
		{
			return _NUMERO;
		}
		set
		{
			if (_NUMERO != value)
			{
				_NUMERO = value;
			}
		}
	}
}
