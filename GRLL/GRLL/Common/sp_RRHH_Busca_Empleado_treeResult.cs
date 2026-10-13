using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class sp_RRHH_Busca_Empleado_treeResult
{
	private int? _idtipoTrabajador;

	private int _Codigo;

	private string _DNI;

	private string _NombresCompletos;

	private int? _Cargo;

	[Column(Storage = "_idtipoTrabajador", DbType = "Int")]
	public int? idtipoTrabajador
	{
		get
		{
			return _idtipoTrabajador;
		}
		set
		{
			if (!_idtipoTrabajador.Equals(value))
			{
				_idtipoTrabajador = value;
			}
		}
	}

	[Column(Storage = "_Codigo", DbType = "Int NOT NULL")]
	public int Codigo
	{
		get
		{
			return _Codigo;
		}
		set
		{
			if (_Codigo != value)
			{
				_Codigo = value;
			}
		}
	}

	[Column(Storage = "_DNI", DbType = "Char(12)")]
	public string DNI
	{
		get
		{
			return _DNI;
		}
		set
		{
			if (!string.Equals(_DNI, value))
			{
				_DNI = value;
			}
		}
	}

	[Column(Storage = "_NombresCompletos", DbType = "VarChar(162)")]
	public string NombresCompletos
	{
		get
		{
			return _NombresCompletos;
		}
		set
		{
			if (!string.Equals(_NombresCompletos, value))
			{
				_NombresCompletos = value;
			}
		}
	}

	[Column(Storage = "_Cargo", DbType = "Int")]
	public int? Cargo
	{
		get
		{
			return _Cargo;
		}
		set
		{
			if (!_Cargo.Equals(value))
			{
				_Cargo = value;
			}
		}
	}
}
