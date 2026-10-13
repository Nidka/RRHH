using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spRRHH_busca_empleadoResult
{
	private int? _IdTipoTrabajador;

	private int _Codigo;

	private string _DNI;

	private string _NombresCompletos;

	private string _AreaOrganizacional;

	private int? _cargo;

	[Column(Storage = "_IdTipoTrabajador", DbType = "Int")]
	public int? IdTipoTrabajador
	{
		get
		{
			return _IdTipoTrabajador;
		}
		set
		{
			if (!_IdTipoTrabajador.Equals(value))
			{
				_IdTipoTrabajador = value;
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

	[Column(Storage = "_AreaOrganizacional", DbType = "VarChar(200) NOT NULL", CanBeNull = false)]
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
}
