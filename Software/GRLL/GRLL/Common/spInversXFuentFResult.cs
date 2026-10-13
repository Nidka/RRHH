using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spInversXFuentFResult
{
	private string _IdFinanciamiento;

	[Column(Storage = "_IdFinanciamiento", DbType = "Char(2)")]
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
}
