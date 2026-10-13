using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spSEG_listarUserRolResult
{
	private int _Idusuario;

	private string _Login;

	private string _numdocid;

	private string _nombresC;

	private int _chec;

	[Column(Storage = "_Idusuario", DbType = "Int NOT NULL")]
	public int Idusuario
	{
		get
		{
			return _Idusuario;
		}
		set
		{
			if (_Idusuario != value)
			{
				_Idusuario = value;
			}
		}
	}

	[Column(Storage = "_Login", DbType = "Char(20)")]
	public string Login
	{
		get
		{
			return _Login;
		}
		set
		{
			if (!string.Equals(_Login, value))
			{
				_Login = value;
			}
		}
	}

	[Column(Storage = "_numdocid", DbType = "Char(12)")]
	public string numdocid
	{
		get
		{
			return _numdocid;
		}
		set
		{
			if (!string.Equals(_numdocid, value))
			{
				_numdocid = value;
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

	[Column(Storage = "_chec", DbType = "Int NOT NULL")]
	public int chec
	{
		get
		{
			return _chec;
		}
		set
		{
			if (_chec != value)
			{
				_chec = value;
			}
		}
	}
}
