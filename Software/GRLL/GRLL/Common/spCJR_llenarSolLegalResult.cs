using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spCJR_llenarSolLegalResult
{
	private string _Cod;

	private string _NumOficio;

	private string _c;

	private string _idparent;

	[Column(Storage = "_Cod", DbType = "VarChar(120) NOT NULL", CanBeNull = false)]
	public string Cod
	{
		get
		{
			return _Cod;
		}
		set
		{
			if (!string.Equals(_Cod, value))
			{
				_Cod = value;
			}
		}
	}

	[Column(Storage = "_NumOficio", DbType = "VarChar(120) NOT NULL", CanBeNull = false)]
	public string NumOficio
	{
		get
		{
			return _NumOficio;
		}
		set
		{
			if (!string.Equals(_NumOficio, value))
			{
				_NumOficio = value;
			}
		}
	}

	[Column(Storage = "_c", DbType = "VarChar(200)")]
	public string c
	{
		get
		{
			return _c;
		}
		set
		{
			if (!string.Equals(_c, value))
			{
				_c = value;
			}
		}
	}

	[Column(Storage = "_idparent", DbType = "VarChar(120)")]
	public string idparent
	{
		get
		{
			return _idparent;
		}
		set
		{
			if (!string.Equals(_idparent, value))
			{
				_idparent = value;
			}
		}
	}
}
