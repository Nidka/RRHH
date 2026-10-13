using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class GRLL_Usuario_AccesoResult
{
	private int _idusuario;

	private string _login;

	private int? _idempleado;

	private int _idareaorganiz;

	private int _idrol;

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

	[Column(Storage = "_idrol", DbType = "Int NOT NULL")]
	public int idrol
	{
		get
		{
			return _idrol;
		}
		set
		{
			if (_idrol != value)
			{
				_idrol = value;
			}
		}
	}
}
