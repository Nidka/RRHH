using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.vEstructOrganizCmbObj")]
public class vEstructOrganizCmbObj
{
	private int _Year;

	private int _idAreaOrganiz;

	private string _AreaOrganizacional;

	private string _Abrev;

	private string _Sigla;

	private int? _idDependeDe;

	private int? _YearDe;

	private string _YearId;

	[Column(Storage = "_Year", DbType = "Int NOT NULL")]
	public int Year
	{
		get
		{
			return _Year;
		}
		set
		{
			if (_Year != value)
			{
				_Year = value;
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

	[Column(Storage = "_AreaOrganizacional", DbType = "VarChar(80) NOT NULL", CanBeNull = false)]
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

	[Column(Storage = "_Abrev", DbType = "VarChar(10) NOT NULL", CanBeNull = false)]
	public string Abrev
	{
		get
		{
			return _Abrev;
		}
		set
		{
			if (!string.Equals(_Abrev, value))
			{
				_Abrev = value;
			}
		}
	}

	[Column(Storage = "_Sigla", DbType = "VarChar(6) NOT NULL", CanBeNull = false)]
	public string Sigla
	{
		get
		{
			return _Sigla;
		}
		set
		{
			if (!string.Equals(_Sigla, value))
			{
				_Sigla = value;
			}
		}
	}

	[Column(Storage = "_idDependeDe", DbType = "Int")]
	public int? idDependeDe
	{
		get
		{
			return _idDependeDe;
		}
		set
		{
			if (!_idDependeDe.Equals(value))
			{
				_idDependeDe = value;
			}
		}
	}

	[Column(Storage = "_YearDe", DbType = "Int")]
	public int? YearDe
	{
		get
		{
			return _YearDe;
		}
		set
		{
			if (!_YearDe.Equals(value))
			{
				_YearDe = value;
			}
		}
	}

	[Column(Storage = "_YearId", DbType = "VarChar(11)")]
	public string YearId
	{
		get
		{
			return _YearId;
		}
		set
		{
			if (!string.Equals(_YearId, value))
			{
				_YearId = value;
			}
		}
	}
}
