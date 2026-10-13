using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spRRHH_Ficha_ExpLabResult
{
	private string _NomInstitucion;

	private string _CargoExp;

	private DateTime? _FechaIngresoExp;

	private DateTime? _FEchaEgresoExp;

	private string _UnidadOrgaExp;

	private string _DescriptipoInstitucion;

	[Column(Storage = "_NomInstitucion", DbType = "VarChar(120)")]
	public string NomInstitucion
	{
		get
		{
			return _NomInstitucion;
		}
		set
		{
			if (!string.Equals(_NomInstitucion, value))
			{
				_NomInstitucion = value;
			}
		}
	}

	[Column(Storage = "_CargoExp", DbType = "VarChar(40)")]
	public string CargoExp
	{
		get
		{
			return _CargoExp;
		}
		set
		{
			if (!string.Equals(_CargoExp, value))
			{
				_CargoExp = value;
			}
		}
	}

	[Column(Storage = "_FechaIngresoExp", DbType = "DateTime")]
	public DateTime? FechaIngresoExp
	{
		get
		{
			return _FechaIngresoExp;
		}
		set
		{
			if (!_FechaIngresoExp.Equals(value))
			{
				_FechaIngresoExp = value;
			}
		}
	}

	[Column(Storage = "_FEchaEgresoExp", DbType = "DateTime")]
	public DateTime? FEchaEgresoExp
	{
		get
		{
			return _FEchaEgresoExp;
		}
		set
		{
			if (!_FEchaEgresoExp.Equals(value))
			{
				_FEchaEgresoExp = value;
			}
		}
	}

	[Column(Storage = "_UnidadOrgaExp", DbType = "VarChar(100)")]
	public string UnidadOrgaExp
	{
		get
		{
			return _UnidadOrgaExp;
		}
		set
		{
			if (!string.Equals(_UnidadOrgaExp, value))
			{
				_UnidadOrgaExp = value;
			}
		}
	}

	[Column(Storage = "_DescriptipoInstitucion", DbType = "VarChar(15)")]
	public string DescriptipoInstitucion
	{
		get
		{
			return _DescriptipoInstitucion;
		}
		set
		{
			if (!string.Equals(_DescriptipoInstitucion, value))
			{
				_DescriptipoInstitucion = value;
			}
		}
	}
}
