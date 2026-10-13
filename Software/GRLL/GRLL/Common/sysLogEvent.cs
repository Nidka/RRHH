using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.sysLogEvent")]
public class sysLogEvent
{
	private DateTime? _fecha;

	private string _Aplicacion;

	private string _PC;

	private string _Login;

	private string _usuario;

	private string _Evento;

	private string _Sentencia;

	[Column(Storage = "_fecha", DbType = "DateTime")]
	public DateTime? fecha
	{
		get
		{
			return _fecha;
		}
		set
		{
			if (!_fecha.Equals(value))
			{
				_fecha = value;
			}
		}
	}

	[Column(Storage = "_Aplicacion", DbType = "NVarChar(100)")]
	public string Aplicacion
	{
		get
		{
			return _Aplicacion;
		}
		set
		{
			if (!string.Equals(_Aplicacion, value))
			{
				_Aplicacion = value;
			}
		}
	}

	[Column(Storage = "_PC", DbType = "NVarChar(30)")]
	public string PC
	{
		get
		{
			return _PC;
		}
		set
		{
			if (!string.Equals(_PC, value))
			{
				_PC = value;
			}
		}
	}

	[Column(Storage = "_Login", DbType = "NVarChar(100)")]
	public string Login
	{
		get
		{
			return _Login;
		}
		set
		{
			if (!string.Equals(_Login, value))
			{
				_Login = value;
			}
		}
	}

	[Column(Storage = "_usuario", DbType = "NVarChar(100)")]
	public string usuario
	{
		get
		{
			return _usuario;
		}
		set
		{
			if (!string.Equals(_usuario, value))
			{
				_usuario = value;
			}
		}
	}

	[Column(Storage = "_Evento", DbType = "NVarChar(100)")]
	public string Evento
	{
		get
		{
			return _Evento;
		}
		set
		{
			if (!string.Equals(_Evento, value))
			{
				_Evento = value;
			}
		}
	}

	[Column(Storage = "_Sentencia", DbType = "NVarChar(2000)")]
	public string Sentencia
	{
		get
		{
			return _Sentencia;
		}
		set
		{
			if (!string.Equals(_Sentencia, value))
			{
				_Sentencia = value;
			}
		}
	}
}
