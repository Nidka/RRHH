using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spRRHH_llenarPermisoResult
{
	private string _DescripTipoPermiso;

	private string _Descrip_Motivo;

	private int _NPermiso;

	private DateTime? _FechaInicio;

	private DateTime? _FechaFin;

	private string _Hora_Sal;

	private string _Hora_Ret;

	private bool? _dia;

	private bool? _Retorno;

	private string _Lugar;

	private string _Referencia;

	private string _Autorizacion;

	private int _IdEmpleado;

	[Column(Storage = "_DescripTipoPermiso", DbType = "VarChar(50)")]
	public string DescripTipoPermiso
	{
		get
		{
			return _DescripTipoPermiso;
		}
		set
		{
			if (!string.Equals(_DescripTipoPermiso, value))
			{
				_DescripTipoPermiso = value;
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

	[Column(Storage = "_NPermiso", DbType = "Int NOT NULL")]
	public int NPermiso
	{
		get
		{
			return _NPermiso;
		}
		set
		{
			if (_NPermiso != value)
			{
				_NPermiso = value;
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

	[Column(Storage = "_FechaFin", DbType = "DateTime")]
	public DateTime? FechaFin
	{
		get
		{
			return _FechaFin;
		}
		set
		{
			if (!_FechaFin.Equals(value))
			{
				_FechaFin = value;
			}
		}
	}

	[Column(Storage = "_Hora_Sal", DbType = "Char(8)")]
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

	[Column(Storage = "_Hora_Ret", DbType = "Char(8)")]
	public string Hora_Ret
	{
		get
		{
			return _Hora_Ret;
		}
		set
		{
			if (!string.Equals(_Hora_Ret, value))
			{
				_Hora_Ret = value;
			}
		}
	}

	[Column(Storage = "_dia", DbType = "Bit")]
	public bool? dia
	{
		get
		{
			return _dia;
		}
		set
		{
			if (!_dia.Equals(value))
			{
				_dia = value;
			}
		}
	}

	[Column(Storage = "_Retorno", DbType = "Bit")]
	public bool? Retorno
	{
		get
		{
			return _Retorno;
		}
		set
		{
			if (!_Retorno.Equals(value))
			{
				_Retorno = value;
			}
		}
	}

	[Column(Storage = "_Lugar", DbType = "VarChar(20)")]
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

	[Column(Storage = "_Referencia", DbType = "VarChar(50)")]
	public string Referencia
	{
		get
		{
			return _Referencia;
		}
		set
		{
			if (!string.Equals(_Referencia, value))
			{
				_Referencia = value;
			}
		}
	}

	[Column(Storage = "_Autorizacion", DbType = "VarChar(50)")]
	public string Autorizacion
	{
		get
		{
			return _Autorizacion;
		}
		set
		{
			if (!string.Equals(_Autorizacion, value))
			{
				_Autorizacion = value;
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
}
