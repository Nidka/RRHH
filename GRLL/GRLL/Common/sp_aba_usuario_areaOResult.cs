using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class sp_aba_usuario_areaOResult
{
	private string _login;

	private int? _idempleado;

	private int _idareaorganiz;

	private string _areaorganizacional;

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

	[Column(Storage = "_idempleado", DbType = "Int")]
	public int? idempleado
	{
		get
		{
			return _idempleado;
		}
		set
		{
			if (!_idempleado.Equals(value))
			{
				_idempleado = value;
			}
		}
	}

	[Column(Storage = "_idareaorganiz", DbType = "Int NOT NULL")]
	public int idareaorganiz
	{
		get
		{
			return _idareaorganiz;
		}
		set
		{
			if (_idareaorganiz != value)
			{
				_idareaorganiz = value;
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
}
