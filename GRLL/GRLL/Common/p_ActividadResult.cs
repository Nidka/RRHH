using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class p_ActividadResult
{
	private int _IdActividad;

	private string _Actividad;

	[Column(Storage = "_IdActividad", DbType = "Int NOT NULL")]
	public int IdActividad
	{
		get
		{
			return _IdActividad;
		}
		set
		{
			if (_IdActividad != value)
			{
				_IdActividad = value;
			}
		}
	}

	[Column(Storage = "_Actividad", DbType = "VarChar(300) NOT NULL", CanBeNull = false)]
	public string Actividad
	{
		get
		{
			return _Actividad;
		}
		set
		{
			if (!string.Equals(_Actividad, value))
			{
				_Actividad = value;
			}
		}
	}
}
