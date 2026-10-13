using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spCJR_llenarNotificacionesResult
{
	private string _NumOrdenanza;

	private string _NumOficio;

	private DateTime? _FechaEmision;

	[Column(Storage = "_NumOrdenanza", DbType = "VarChar(120)")]
	public string NumOrdenanza
	{
		get
		{
			return _NumOrdenanza;
		}
		set
		{
			if (!string.Equals(_NumOrdenanza, value))
			{
				_NumOrdenanza = value;
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
