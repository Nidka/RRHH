using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class Aba_Movimiento_ListarResult
{
	private string _idmovimiento;

	private string _nro;

	private DateTime? _fecha;

	private string _destipomov;

	private string _estado;

	private string _desestado;

	private string _idorden;

	private string _nroorden;

	private string _recibidopor;

	private string _desempleado;

	[Column(Storage = "_idmovimiento", DbType = "Char(8) NOT NULL", CanBeNull = false)]
	public string idmovimiento
	{
		get
		{
			return _idmovimiento;
		}
		set
		{
			if (!string.Equals(_idmovimiento, value))
			{
				_idmovimiento = value;
			}
		}
	}

	[Column(Storage = "_nro", DbType = "VarChar(4)")]
	public string nro
	{
		get
		{
			return _nro;
		}
		set
		{
			if (!string.Equals(_nro, value))
			{
				_nro = value;
			}
		}
	}

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

	[Column(Storage = "_destipomov", DbType = "VarChar(40)")]
	public string destipomov
	{
		get
		{
			return _destipomov;
		}
		set
		{
			if (!string.Equals(_destipomov, value))
			{
				_destipomov = value;
			}
		}
	}

	[Column(Storage = "_estado", DbType = "Char(18)")]
	public string estado
	{
		get
		{
			return _estado;
		}
		set
		{
			if (!string.Equals(_estado, value))
			{
				_estado = value;
			}
		}
	}

	[Column(Storage = "_desestado", DbType = "VarChar(13)")]
	public string desestado
	{
		get
		{
			return _desestado;
		}
		set
		{
			if (!string.Equals(_desestado, value))
			{
				_desestado = value;
			}
		}
	}

	[Column(Storage = "_idorden", DbType = "Char(8)")]
	public string idorden
	{
		get
		{
			return _idorden;
		}
		set
		{
			if (!string.Equals(_idorden, value))
			{
				_idorden = value;
			}
		}
	}

	[Column(Storage = "_nroorden", DbType = "VarChar(4)")]
	public string nroorden
	{
		get
		{
			return _nroorden;
		}
		set
		{
			if (!string.Equals(_nroorden, value))
			{
				_nroorden = value;
			}
		}
	}

	[Column(Storage = "_recibidopor", DbType = "VarChar(80)")]
	public string recibidopor
	{
		get
		{
			return _recibidopor;
		}
		set
		{
			if (!string.Equals(_recibidopor, value))
			{
				_recibidopor = value;
			}
		}
	}

	[Column(Storage = "_desempleado", DbType = "VarChar(162)")]
	public string desempleado
	{
		get
		{
			return _desempleado;
		}
		set
		{
			if (!string.Equals(_desempleado, value))
			{
				_desempleado = value;
			}
		}
	}
}
