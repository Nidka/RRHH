using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spRRHH_Rep_cargosResult
{
	private string _Apellido_Paterno;

	private string _Apellido_Materno;

	private string _nombres;

	private string _AreaOrganizacional;

	private string _cargo;

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

	[Column(Storage = "_nombres", DbType = "VarChar(100)")]
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

	[Column(Storage = "_cargo", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
	public string cargo
	{
		get
		{
			return _cargo;
		}
		set
		{
			if (!string.Equals(_cargo, value))
			{
				_cargo = value;
			}
		}
	}
}
