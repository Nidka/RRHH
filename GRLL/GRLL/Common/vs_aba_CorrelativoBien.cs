using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.vs_aba_CorrelativoBien")]
public class vs_aba_CorrelativoBien
{
	private string _idgrupo;

	private string _idclase;

	private string _idfamilia;

	private int? _numero;

	[Column(Storage = "_idgrupo", DbType = "Char(3)")]
	public string idgrupo
	{
		get
		{
			return _idgrupo;
		}
		set
		{
			if (!string.Equals(_idgrupo, value))
			{
				_idgrupo = value;
			}
		}
	}

	[Column(Storage = "_idclase", DbType = "Char(2)")]
	public string idclase
	{
		get
		{
			return _idclase;
		}
		set
		{
			if (!string.Equals(_idclase, value))
			{
				_idclase = value;
			}
		}
	}

	[Column(Storage = "_idfamilia", DbType = "Char(4)")]
	public string idfamilia
	{
		get
		{
			return _idfamilia;
		}
		set
		{
			if (!string.Equals(_idfamilia, value))
			{
				_idfamilia = value;
			}
		}
	}

	[Column(Storage = "_numero", DbType = "Int")]
	public int? numero
	{
		get
		{
			return _numero;
		}
		set
		{
			if (!_numero.Equals(value))
			{
				_numero = value;
			}
		}
	}
}
