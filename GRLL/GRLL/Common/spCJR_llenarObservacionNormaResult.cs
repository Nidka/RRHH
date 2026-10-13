using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spCJR_llenarObservacionNormaResult
{
	private string _NumProyecto;

	private string _NumOficioN;

	private DateTime? _FechaemisionN;

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

	[Column(Storage = "_NumOficioN", DbType = "VarChar(120) NOT NULL", CanBeNull = false)]
	public string NumOficioN
	{
		get
		{
			return _NumOficioN;
		}
		set
		{
			if (!string.Equals(_NumOficioN, value))
			{
				_NumOficioN = value;
			}
		}
	}

	[Column(Storage = "_FechaemisionN", DbType = "DateTime")]
	public DateTime? FechaemisionN
	{
		get
		{
			return _FechaemisionN;
		}
		set
		{
			if (!_FechaemisionN.Equals(value))
			{
				_FechaemisionN = value;
			}
		}
	}
}
