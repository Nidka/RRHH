using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spFinanciamiento_SelectResult
{
	private string _IdFinanciamiento;

	private string _Descripcion;

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

	[Column(Storage = "_Descripcion", DbType = "VarChar(120) NOT NULL", CanBeNull = false)]
	public string Descripcion
	{
		get
		{
			return _Descripcion;
		}
		set
		{
			if (!string.Equals(_Descripcion, value))
			{
				_Descripcion = value;
			}
		}
	}
}
