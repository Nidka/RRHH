using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spKM_repTipoTramiteResult
{
	private DateTime _Fecha;

	private string _Descrip_Motivo;

	private int? _Cantidad;

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

	[Column(Storage = "_Descrip_Motivo", DbType = "VarChar(40)")]
	public string Descrip_Motivo
	{
		get
		{
			return _Descrip_Motivo;
		}
		set
		{
			if (!string.Equals(_Descrip_Motivo, value))
			{
				_Descrip_Motivo = value;
			}
		}
	}

	[Column(Storage = "_Cantidad", DbType = "Int")]
	public int? Cantidad
	{
		get
		{
			return _Cantidad;
		}
		set
		{
			if (!_Cantidad.Equals(value))
			{
				_Cantidad = value;
			}
		}
	}
}
