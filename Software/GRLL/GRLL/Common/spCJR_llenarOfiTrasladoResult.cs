using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spCJR_llenarOfiTrasladoResult
{
	private string _Numoficio;

	private DateTime? _FechaEmision;

	[Column(Storage = "_Numoficio", DbType = "VarChar(120) NOT NULL", CanBeNull = false)]
	public string Numoficio
	{
		get
		{
			return _Numoficio;
		}
		set
		{
			if (!string.Equals(_Numoficio, value))
			{
				_Numoficio = value;
			}
		}
	}

	[Column(Storage = "_FechaEmision", DbType = "DateTime")]
	public DateTime? FechaEmision
	{
		get
		{
			return _FechaEmision;
		}
		set
		{
			if (!_FechaEmision.Equals(value))
			{
				_FechaEmision = value;
			}
		}
	}
}
