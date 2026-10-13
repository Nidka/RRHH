using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spRRHH_Report_FechaIngresoResult
{
	private string _NombresCompletos;

	private DateTime? _Fechaingreso;

	private int? _años;

	private int? _meses;

	private int? _dias;

	private string _AreaOrganizacional;

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

	[Column(Storage = "_Fechaingreso", DbType = "SmallDateTime")]
	public DateTime? Fechaingreso
	{
		get
		{
			return _Fechaingreso;
		}
		set
		{
			if (!_Fechaingreso.Equals(value))
			{
				_Fechaingreso = value;
			}
		}
	}

	[Column(Storage = "_años", DbType = "Int")]
	public int? años
	{
		get
		{
			return _años;
		}
		set
		{
			if (!_años.Equals(value))
			{
				_años = value;
			}
		}
	}

	[Column(Storage = "_meses", DbType = "Int")]
	public int? meses
	{
		get
		{
			return _meses;
		}
		set
		{
			if (!_meses.Equals(value))
			{
				_meses = value;
			}
		}
	}

	[Column(Storage = "_dias", DbType = "Int")]
	public int? dias
	{
		get
		{
			return _dias;
		}
		set
		{
			if (!_dias.Equals(value))
			{
				_dias = value;
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
