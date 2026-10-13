using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.vs_SEG_usuario")]
public class vs_SEG_usuario
{
	private int _Idusuario;

	private string _Login;

	private string _numdocid;

	private string _nombresC;

	private bool? _estado;

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

	[Column(Storage = "_estado", DbType = "Bit")]
	public bool? estado
	{
		get
		{
			return _estado;
		}
		set
		{
			if (!_estado.Equals(value))
			{
				_estado = value;
			}
		}
	}
}
