using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spRRHH_ListarRotacionesResult
{
	private int _idRotacion;

	private DateTime? _FechaMemo;

	private string _NroMemo;

	private string _AreaOrganizacional;

	[Column(Storage = "_idRotacion", DbType = "Int NOT NULL")]
	public int idRotacion
	{
		get
		{
			return _idRotacion;
		}
		set
		{
			if (_idRotacion != value)
			{
				_idRotacion = value;
			}
		}
	}

	[Column(Storage = "_FechaMemo", DbType = "Date")]
	public DateTime? FechaMemo
	{
		get
		{
			return _FechaMemo;
		}
		set
		{
			if (!_FechaMemo.Equals(value))
			{
				_FechaMemo = value;
			}
		}
	}

	[Column(Storage = "_NroMemo", DbType = "NVarChar(50)")]
	public string NroMemo
	{
		get
		{
			return _NroMemo;
		}
		set
		{
			if (!string.Equals(_NroMemo, value))
			{
				_NroMemo = value;
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
}
