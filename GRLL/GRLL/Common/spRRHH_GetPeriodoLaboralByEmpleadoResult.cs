using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spRRHH_GetPeriodoLaboralByEmpleadoResult
{
	private int _IdEmpleado;

	private int _NroPeriodo;

	private string _NumResoIngreInstitu;

	private DateTime? _FechaSalida;

	private DateTime? _FechaResoIngreInstitu;

	private DateTime? _FechaIngreso;

	private bool? _Judicial;

	private string _Obs;

	[Column(Storage = "_IdEmpleado", DbType = "Int NOT NULL")]
	public int IdEmpleado
	{
		get
		{
			return _IdEmpleado;
		}
		set
		{
			if (_IdEmpleado != value)
			{
				_IdEmpleado = value;
			}
		}
	}

	[Column(Storage = "_NroPeriodo", DbType = "Int NOT NULL")]
	public int NroPeriodo
	{
		get
		{
			return _NroPeriodo;
		}
		set
		{
			if (_NroPeriodo != value)
			{
				_NroPeriodo = value;
			}
		}
	}

	[Column(Storage = "_NumResoIngreInstitu", DbType = "VarChar(30)")]
	public string NumResoIngreInstitu
	{
		get
		{
			return _NumResoIngreInstitu;
		}
		set
		{
			if (!string.Equals(_NumResoIngreInstitu, value))
			{
				_NumResoIngreInstitu = value;
			}
		}
	}

	[Column(Storage = "_FechaSalida", DbType = "SmallDateTime")]
	public DateTime? FechaSalida
	{
		get
		{
			return _FechaSalida;
		}
		set
		{
			if (!_FechaSalida.Equals(value))
			{
				_FechaSalida = value;
			}
		}
	}

	[Column(Storage = "_FechaResoIngreInstitu", DbType = "DateTime")]
	public DateTime? FechaResoIngreInstitu
	{
		get
		{
			return _FechaResoIngreInstitu;
		}
		set
		{
			if (!_FechaResoIngreInstitu.Equals(value))
			{
				_FechaResoIngreInstitu = value;
			}
		}
	}

	[Column(Storage = "_FechaIngreso", DbType = "SmallDateTime")]
	public DateTime? FechaIngreso
	{
		get
		{
			return _FechaIngreso;
		}
		set
		{
			if (!_FechaIngreso.Equals(value))
			{
				_FechaIngreso = value;
			}
		}
	}

	[Column(Storage = "_Judicial", DbType = "Bit")]
	public bool? Judicial
	{
		get
		{
			return _Judicial;
		}
		set
		{
			if (!_Judicial.Equals(value))
			{
				_Judicial = value;
			}
		}
	}

	[Column(Storage = "_Obs", DbType = "VarChar(2000)")]
	public string Obs
	{
		get
		{
			return _Obs;
		}
		set
		{
			if (!string.Equals(_Obs, value))
			{
				_Obs = value;
			}
		}
	}
}
