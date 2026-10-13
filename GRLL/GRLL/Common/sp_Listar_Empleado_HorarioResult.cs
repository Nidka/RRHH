using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class sp_Listar_Empleado_HorarioResult
{
	private int _idEmpleado;

	private string _NumDocID;

	private string _Nombres;

	private string _Apellido_Paterno;

	private string _Apellido_Materno;

	private int? _idHorario;

	[Column(Storage = "_idEmpleado", DbType = "Int NOT NULL")]
	public int idEmpleado
	{
		get
		{
			return _idEmpleado;
		}
		set
		{
			if (_idEmpleado != value)
			{
				_idEmpleado = value;
			}
		}
	}

	[Column(Storage = "_NumDocID", DbType = "Char(12)")]
	public string NumDocID
	{
		get
		{
			return _NumDocID;
		}
		set
		{
			if (!string.Equals(_NumDocID, value))
			{
				_NumDocID = value;
			}
		}
	}

	[Column(Storage = "_Nombres", DbType = "VarChar(100)")]
	public string Nombres
	{
		get
		{
			return _Nombres;
		}
		set
		{
			if (!string.Equals(_Nombres, value))
			{
				_Nombres = value;
			}
		}
	}

	[Column(Storage = "_Apellido_Paterno", DbType = "VarChar(30)")]
	public string Apellido_Paterno
	{
		get
		{
			return _Apellido_Paterno;
		}
		set
		{
			if (!string.Equals(_Apellido_Paterno, value))
			{
				_Apellido_Paterno = value;
			}
		}
	}

	[Column(Storage = "_Apellido_Materno", DbType = "VarChar(30)")]
	public string Apellido_Materno
	{
		get
		{
			return _Apellido_Materno;
		}
		set
		{
			if (!string.Equals(_Apellido_Materno, value))
			{
				_Apellido_Materno = value;
			}
		}
	}

	[Column(Storage = "_idHorario", DbType = "Int")]
	public int? idHorario
	{
		get
		{
			return _idHorario;
		}
		set
		{
			if (!_idHorario.Equals(value))
			{
				_idHorario = value;
			}
		}
	}
}
