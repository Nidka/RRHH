using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spRRHH_GetDiasAsistidosResult
{
	private int _IdEmpleado;

	private int? _Dias_Asistidos;

	[Column(Storage = "_IdEmpleado", DbType = "Int NOT NULL")]
	public int IdEmpleado
	{
		get
		{
			return _IdEmpleado;
		}
		set
		{
			if (_IdEmpleado != value)
			{
				_IdEmpleado = value;
			}
		}
	}

	[Column(Storage = "_Dias_Asistidos", DbType = "Int")]
	public int? Dias_Asistidos
	{
		get
		{
			return _Dias_Asistidos;
		}
		set
		{
			if (!_Dias_Asistidos.Equals(value))
			{
				_Dias_Asistidos = value;
			}
		}
	}
}
