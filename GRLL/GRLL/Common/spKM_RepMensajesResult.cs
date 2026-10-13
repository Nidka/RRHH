using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spKM_RepMensajesResult
{
	private DateTime _Fecha;

	private int _idOrden;

	private string _horaInicio;

	private string _descripMensaje;

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

	[Column(Storage = "_idOrden", DbType = "Int NOT NULL")]
	public int idOrden
	{
		get
		{
			return _idOrden;
		}
		set
		{
			if (_idOrden != value)
			{
				_idOrden = value;
			}
		}
	}

	[Column(Storage = "_horaInicio", DbType = "VarChar(20)")]
	public string horaInicio
	{
		get
		{
			return _horaInicio;
		}
		set
		{
			if (!string.Equals(_horaInicio, value))
			{
				_horaInicio = value;
			}
		}
	}

	[Column(Storage = "_descripMensaje", DbType = "NVarChar(2000)")]
	public string descripMensaje
	{
		get
		{
			return _descripMensaje;
		}
		set
		{
			if (!string.Equals(_descripMensaje, value))
			{
				_descripMensaje = value;
			}
		}
	}
}
