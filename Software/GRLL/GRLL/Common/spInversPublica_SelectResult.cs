using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spInversPublica_SelectResult
{
	private int _IdInverPublica;

	private int _Year;

	private int _idAreaOrganiz;

	private decimal _Total;

	[Column(Storage = "_IdInverPublica", DbType = "Int NOT NULL")]
	public int IdInverPublica
	{
		get
		{
			return _IdInverPublica;
		}
		set
		{
			if (_IdInverPublica != value)
			{
				_IdInverPublica = value;
			}
		}
	}

	[Column(Storage = "_Year", DbType = "Int NOT NULL")]
	public int Year
	{
		get
		{
			return _Year;
		}
		set
		{
			if (_Year != value)
			{
				_Year = value;
			}
		}
	}

	[Column(Storage = "_idAreaOrganiz", DbType = "Int NOT NULL")]
	public int idAreaOrganiz
	{
		get
		{
			return _idAreaOrganiz;
		}
		set
		{
			if (_idAreaOrganiz != value)
			{
				_idAreaOrganiz = value;
			}
		}
	}

	[Column(Storage = "_Total", DbType = "Decimal(0,0) NOT NULL")]
	public decimal Total
	{
		get
		{
			return _Total;
		}
		set
		{
			if (decimal.Compare(_Total, value) != 0)
			{
				_Total = value;
			}
		}
	}
}
