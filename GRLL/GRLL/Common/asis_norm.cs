using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.asis_norm")]
public class asis_norm
{
	private DateTime _Fec_Asi;

	private string _Hor_Ent;

	private string _Hor_Sal;

	private int _pers_cod;

	private char? _flag_ent;

	private char? _flag_sal;

	private string _alm_sal;

	private string _alm_ent;

	[Column(Storage = "_Fec_Asi", DbType = "DateTime NOT NULL")]
	public DateTime Fec_Asi
	{
		get
		{
			return _Fec_Asi;
		}
		set
		{
			if (DateTime.Compare(_Fec_Asi, value) != 0)
			{
				_Fec_Asi = value;
			}
		}
	}

	[Column(Storage = "_Hor_Ent", DbType = "NChar(8) NOT NULL", CanBeNull = false)]
	public string Hor_Ent
	{
		get
		{
			return _Hor_Ent;
		}
		set
		{
			if (!string.Equals(_Hor_Ent, value))
			{
				_Hor_Ent = value;
			}
		}
	}

	[Column(Storage = "_Hor_Sal", DbType = "NChar(8) NOT NULL", CanBeNull = false)]
	public string Hor_Sal
	{
		get
		{
			return _Hor_Sal;
		}
		set
		{
			if (!string.Equals(_Hor_Sal, value))
			{
				_Hor_Sal = value;
			}
		}
	}

	[Column(Storage = "_pers_cod", DbType = "Int NOT NULL")]
	public int pers_cod
	{
		get
		{
			return _pers_cod;
		}
		set
		{
			if (_pers_cod != value)
			{
				_pers_cod = value;
			}
		}
	}

	[Column(Storage = "_flag_ent", DbType = "Char(1)")]
	public char? flag_ent
	{
		get
		{
			return _flag_ent;
		}
		set
		{
			if (!_flag_ent.Equals(value))
			{
				_flag_ent = value;
			}
		}
	}

	[Column(Storage = "_flag_sal", DbType = "Char(1)")]
	public char? flag_sal
	{
		get
		{
			return _flag_sal;
		}
		set
		{
			if (!_flag_sal.Equals(value))
			{
				_flag_sal = value;
			}
		}
	}

	[Column(Storage = "_alm_sal", DbType = "Char(8)")]
	public string alm_sal
	{
		get
		{
			return _alm_sal;
		}
		set
		{
			if (!string.Equals(_alm_sal, value))
			{
				_alm_sal = value;
			}
		}
	}

	[Column(Storage = "_alm_ent", DbType = "Char(8)")]
	public string alm_ent
	{
		get
		{
			return _alm_ent;
		}
		set
		{
			if (!string.Equals(_alm_ent, value))
			{
				_alm_ent = value;
			}
		}
	}
}
