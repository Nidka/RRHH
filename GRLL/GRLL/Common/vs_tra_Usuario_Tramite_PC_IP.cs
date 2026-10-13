using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.vs_tra_Usuario_Tramite_PC_IP")]
public class vs_tra_Usuario_Tramite_PC_IP
{
	private int _idusuario;

	private string _login;

	private string _areaorganizacional;

	private string _cargo;

	[Column(Storage = "_idusuario", DbType = "Int NOT NULL")]
	public int idusuario
	{
		get
		{
			return _idusuario;
		}
		set
		{
			if (_idusuario != value)
			{
				_idusuario = value;
			}
		}
	}

	[Column(Storage = "_login", DbType = "Char(20)")]
	public string login
	{
		get
		{
			return _login;
		}
		set
		{
			if (!string.Equals(_login, value))
			{
				_login = value;
			}
		}
	}

	[Column(Storage = "_areaorganizacional", DbType = "VarChar(200) NOT NULL", CanBeNull = false)]
	public string areaorganizacional
	{
		get
		{
			return _areaorganizacional;
		}
		set
		{
			if (!string.Equals(_areaorganizacional, value))
			{
				_areaorganizacional = value;
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
