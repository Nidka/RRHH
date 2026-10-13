using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spInversXFuentF_SelectResult
{
	private string _IdFinanciamiento;

	private string _Financiadora;

	private decimal _Sub_Total;

	[Column(Storage = "_IdFinanciamiento", DbType = "Char(2) NOT NULL", CanBeNull = false)]
	public string IdFinanciamiento
	{
		get
		{
			return _IdFinanciamiento;
		}
		set
		{
			if (!string.Equals(_IdFinanciamiento, value))
			{
				_IdFinanciamiento = value;
			}
		}
	}

	[Column(Storage = "_Financiadora", DbType = "VarChar(120)")]
	public string Financiadora
	{
		get
		{
			return _Financiadora;
		}
		set
		{
			if (!string.Equals(_Financiadora, value))
			{
				_Financiadora = value;
			}
		}
	}

	[Column(Storage = "_Sub_Total", DbType = "Decimal(0,0) NOT NULL")]
	public decimal Sub_Total
	{
		get
		{
			return _Sub_Total;
		}
		set
		{
			if (decimal.Compare(_Sub_Total, value) != 0)
			{
				_Sub_Total = value;
			}
		}
	}
}
