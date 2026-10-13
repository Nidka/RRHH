using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spSEG_ListarUsuariosResult
{
	private int _idUsuario;

	private string _login;

	private string _nombresC;

	private string _numDocID;

	[Column(Storage = "_idUsuario", DbType = "Int NOT NULL")]
	public int idUsuario
	{
		get
		{
			return _idUsuario;
		}
		set
		{
			if (_idUsuario != value)
			{
				_idUsuario = value;
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

	[Column(Storage = "_numDocID", DbType = "Char(12)")]
	public string numDocID
	{
		get
		{
			return _numDocID;
		}
		set
		{
			if (!string.Equals(_numDocID, value))
			{
				_numDocID = value;
			}
		}
	}
}
