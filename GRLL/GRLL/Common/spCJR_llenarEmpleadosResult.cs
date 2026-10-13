using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spCJR_llenarEmpleadosResult
{
	private int _IdEmpleado;

	private string _nombres;

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

	[Column(Storage = "_nombres", DbType = "VarChar(162)")]
	public string nombres
	{
		get
		{
			return _nombres;
		}
		set
		{
			if (!string.Equals(_nombres, value))
			{
				_nombres = value;
			}
		}
	}
}
