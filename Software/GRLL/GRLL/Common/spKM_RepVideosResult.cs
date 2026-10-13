using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spKM_RepVideosResult
{
	private DateTime _Fecha;

	private string _HoraInicio;

	private string _Descripcion;

	private string _Duracion;

	[Column(Storage = "_Fecha", DbType = "DateTime NOT NULL")]
	public DateTime Fecha
	{
		get
		{
			return _Fecha;
		}
		set
		{
			if (DateTime.Compare(_Fecha, value) != 0)
			{
				_Fecha = value;
			}
		}
	}

	[Column(Storage = "_HoraInicio", DbType = "VarChar(20)")]
	public string HoraInicio
	{
		get
		{
			return _HoraInicio;
		}
		set
		{
			if (!string.Equals(_HoraInicio, value))
			{
				_HoraInicio = value;
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(100)")]
	public string Descripcion
	{
		get
		{
			return _Descripcion;
		}
		set
		{
			if (!string.Equals(_Descripcion, value))
			{
				_Descripcion = value;
			}
		}
	}

	[Column(Storage = "_Duracion", DbType = "VarChar(8)")]
	public string Duracion
	{
		get
		{
			return _Duracion;
		}
		set
		{
			if (!string.Equals(_Duracion, value))
			{
				_Duracion = value;
			}
		}
	}
}
