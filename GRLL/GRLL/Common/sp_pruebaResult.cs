using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class sp_pruebaResult
{
	private string _Column1;

	private int? _Column2;

	private string _Column3;

	[Column(Storage = "_Column1", DbType = "VarChar(10)")]
	public string Column1
	{
		get
		{
			return _Column1;
		}
		set
		{
			if (!string.Equals(_Column1, value))
			{
				_Column1 = value;
			}
		}
	}

	[Column(Storage = "_Column2", DbType = "Int")]
	public int? Column2
	{
		get
		{
			return _Column2;
		}
		set
		{
			if (!_Column2.Equals(value))
			{
				_Column2 = value;
			}
		}
	}

	[Column(Storage = "_Column3", DbType = "Char(2)")]
	public string Column3
	{
		get
		{
			return _Column3;
		}
		set
		{
			if (!string.Equals(_Column3, value))
			{
				_Column3 = value;
			}
		}
	}
}
