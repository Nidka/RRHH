using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spRRHH_Report_CuadroPerResult
{
	private int _idTipoTrabajador;

	private string _Descripcion;

	private int _Codigo;

	private string _DNI;

	private string _NombresCompletos;

	private string _AreaOrganizacional;

	private int? _cargo;

	private char? _Estado;

	[Column(Storage = "_idTipoTrabajador", DbType = "Int NOT NULL")]
	public int idTipoTrabajador
	{
		get
		{
			return _idTipoTrabajador;
		}
		set
		{
			if (_idTipoTrabajador != value)
			{
				_idTipoTrabajador = value;
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(30)")]
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

	[Column(Storage = "_AreaOrganizacional", DbType = "VarChar(200)")]
	public string AreaOrganizacional
	{
		get
		{
			return _AreaOrganizacional;
		}
		set
		{
			if (!string.Equals(_AreaOrganizacional, value))
			{
				_AreaOrganizacional = value;
			}
		}
	}

	[Column(Storage = "_cargo", DbType = "Int")]
	public int? cargo
	{
		get
		{
			return _cargo;
		}
		set
		{
			if (!_cargo.Equals(value))
			{
				_cargo = value;
			}
		}
	}

	[Column(Storage = "_Estado", DbType = "Char(1)")]
	public char? Estado
	{
		get
		{
			return _Estado;
		}
		set
		{
			if (!_Estado.Equals(value))
			{
				_Estado = value;
			}
		}
	}
}
