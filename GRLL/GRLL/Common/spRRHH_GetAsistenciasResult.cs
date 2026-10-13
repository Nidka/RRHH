using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spRRHH_GetAsistenciasResult
{
	private DateTime? _Fecha;

	private int _IdEmpleado;

	private char _Estado;

	[Column(Storage = "_Fecha", DbType = "DateTime")]
	public DateTime? Fecha
	{
		get
		{
			return _Fecha;
		}
		set
		{
			if (!_Fecha.Equals(value))
			{
				_Fecha = value;
			}
		}
	}

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

	[Column(Storage = "_Estado", DbType = "VarChar(1) NOT NULL")]
	public char Estado
	{
		get
		{
			return _Estado;
		}
		set
		{
			if (_Estado != value)
			{
				_Estado = value;
			}
		}
	}
}
