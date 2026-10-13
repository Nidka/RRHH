using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spRRHH_RepPermisosResult
{
	private string _Nombres;

	private string _Descrip_Motivo;

	private DateTime? _FechaInicio;

	private DateTime? _FEchaFin;

	private string _Hora_Sal;

	private string _Hora_ret;

	private string _Lugar;

	private string _Observaciones;

	[Column(Storage = "_Nombres", DbType = "VarChar(162)")]
	public string Nombres
	{
		get
		{
			return _Nombres;
		}
		set
		{
			if (!string.Equals(_Nombres, value))
			{
				_Nombres = value;
			}
		}
	}

	[Column(Storage = "_Descrip_Motivo", DbType = "VarChar(50)")]
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

	[Column(Storage = "_FechaInicio", DbType = "DateTime")]
	public DateTime? FechaInicio
	{
		get
		{
			return _FechaInicio;
		}
		set
		{
			if (!_FechaInicio.Equals(value))
			{
				_FechaInicio = value;
			}
		}
	}

	[Column(Storage = "_FEchaFin", DbType = "DateTime")]
	public DateTime? FEchaFin
	{
		get
		{
			return _FEchaFin;
		}
		set
		{
			if (!_FEchaFin.Equals(value))
			{
				_FEchaFin = value;
			}
		}
	}

	[Column(Storage = "_Hora_Sal", DbType = "Char(8) NOT NULL", CanBeNull = false)]
	public string Hora_Sal
	{
		get
		{
			return _Hora_Sal;
		}
		set
		{
			if (!string.Equals(_Hora_Sal, value))
			{
				_Hora_Sal = value;
			}
		}
	}

	[Column(Storage = "_Hora_ret", DbType = "Char(8) NOT NULL", CanBeNull = false)]
	public string Hora_ret
	{
		get
		{
			return _Hora_ret;
		}
		set
		{
			if (!string.Equals(_Hora_ret, value))
			{
				_Hora_ret = value;
			}
		}
	}

	[Column(Storage = "_Lugar", DbType = "VarChar(20) NOT NULL", CanBeNull = false)]
	public string Lugar
	{
		get
		{
			return _Lugar;
		}
		set
		{
			if (!string.Equals(_Lugar, value))
			{
				_Lugar = value;
			}
		}
	}

	[Column(Storage = "_Observaciones", DbType = "VarChar(200) NOT NULL", CanBeNull = false)]
	public string Observaciones
	{
		get
		{
			return _Observaciones;
		}
		set
		{
			if (!string.Equals(_Observaciones, value))
			{
				_Observaciones = value;
			}
		}
	}
}
