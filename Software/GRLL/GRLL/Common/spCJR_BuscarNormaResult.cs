using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spCJR_BuscarNormaResult
{
	private string _NumOrdenanza;

	private DateTime? _FechaOrdenanza;

	private string _NumProyecto;

	[Column(Storage = "_NumOrdenanza", DbType = "VarChar(120) NOT NULL", CanBeNull = false)]
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

	[Column(Storage = "_FechaOrdenanza", DbType = "DateTime")]
	public DateTime? FechaOrdenanza
	{
		get
		{
			return _FechaOrdenanza;
		}
		set
		{
			if (!_FechaOrdenanza.Equals(value))
			{
				_FechaOrdenanza = value;
			}
		}
	}

	[Column(Storage = "_NumProyecto", DbType = "VarChar(120)")]
	public string NumProyecto
	{
		get
		{
			return _NumProyecto;
		}
		set
		{
			if (!string.Equals(_NumProyecto, value))
			{
				_NumProyecto = value;
			}
		}
	}
}
