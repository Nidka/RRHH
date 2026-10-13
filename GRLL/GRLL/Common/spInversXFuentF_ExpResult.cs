using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spInversXFuentF_ExpResult
{
	private int _IdInverPublica;

	private string _IdFinanciamiento;

	private decimal? _Inversion;

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

	[Column(Storage = "_Inversion", DbType = "Decimal(0,0)")]
	public decimal? Inversion
	{
		get
		{
			return _Inversion;
		}
		set
		{
			if (!_Inversion.Equals(value))
			{
				_Inversion = value;
			}
		}
	}
}
