using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spRRHH_Report_Oficina_UnicoResult
{
	private string _NombresCompletos;

	private string _AreaOrganizacional;

	private char? _Estado;

	private int _idAreaOrganiz;

	private int? _iddependede;

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

	[Column(Storage = "_Estado", DbType = "Char(1)")]
	public char? Estado
	{
		get
		{
			return _Estado;
		}
		set
		{
			if (!_Estado.Equals(value))
			{
				_Estado = value;
			}
		}
	}

	[Column(Storage = "_idAreaOrganiz", DbType = "Int NOT NULL")]
	public int idAreaOrganiz
	{
		get
		{
			return _idAreaOrganiz;
		}
		set
		{
			if (_idAreaOrganiz != value)
			{
				_idAreaOrganiz = value;
			}
		}
	}

	[Column(Storage = "_iddependede", DbType = "Int")]
	public int? iddependede
	{
		get
		{
			return _iddependede;
		}
		set
		{
			if (!_iddependede.Equals(value))
			{
				_iddependede = value;
			}
		}
	}
}
