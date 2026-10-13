using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spSEG_llenarUsuariosResult
{
	private int _IdEmpleado;

	private int _idareaOrganiz;

	private string _nombresC;

	private string _AreaOrganizacional;

	private string _Apellido_Paterno;

	private string _Apellido_Materno;

	private string _Nombres;

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

	[Column(Storage = "_idareaOrganiz", DbType = "Int NOT NULL")]
	public int idareaOrganiz
	{
		get
		{
			return _idareaOrganiz;
		}
		set
		{
			if (_idareaOrganiz != value)
			{
				_idareaOrganiz = value;
			}
		}
	}

	[Column(Storage = "_nombresC", DbType = "VarChar(162)")]
	public string nombresC
	{
		get
		{
			return _nombresC;
		}
		set
		{
			if (!string.Equals(_nombresC, value))
			{
				_nombresC = value;
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
}
