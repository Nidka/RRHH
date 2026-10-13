using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spKM_repTiempoAtencionResult
{
	private int _IdOrden;

	private DateTime _Fecha;

	private int? _IdTipoOperacion;

	private bool? _Atendido;

	private bool? _NoAtendido;

	private bool? _Llamado;

	private string _OrdenDescrip;

	private string _AtendidoPor;

	private int? _idMotivo;

	private string _HoraLlegada;

	private string _HoraAtencion;

	private string _TiempoAtencion;

	private int _idMotivo1;

	private string _Descrip_Motivo;

	[Column(Storage = "_IdOrden", DbType = "Int NOT NULL")]
	public int IdOrden
	{
		get
		{
			return _IdOrden;
		}
		set
		{
			if (_IdOrden != value)
			{
				_IdOrden = value;
			}
		}
	}

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

	[Column(Storage = "_IdTipoOperacion", DbType = "Int")]
	public int? IdTipoOperacion
	{
		get
		{
			return _IdTipoOperacion;
		}
		set
		{
			if (!_IdTipoOperacion.Equals(value))
			{
				_IdTipoOperacion = value;
			}
		}
	}

	[Column(Storage = "_Atendido", DbType = "Bit")]
	public bool? Atendido
	{
		get
		{
			return _Atendido;
		}
		set
		{
			if (!_Atendido.Equals(value))
			{
				_Atendido = value;
			}
		}
	}

	[Column(Storage = "_NoAtendido", DbType = "Bit")]
	public bool? NoAtendido
	{
		get
		{
			return _NoAtendido;
		}
		set
		{
			if (!_NoAtendido.Equals(value))
			{
				_NoAtendido = value;
			}
		}
	}

	[Column(Storage = "_Llamado", DbType = "Bit")]
	public bool? Llamado
	{
		get
		{
			return _Llamado;
		}
		set
		{
			if (!_Llamado.Equals(value))
			{
				_Llamado = value;
			}
		}
	}

	[Column(Storage = "_OrdenDescrip", DbType = "VarChar(20)")]
	public string OrdenDescrip
	{
		get
		{
			return _OrdenDescrip;
		}
		set
		{
			if (!string.Equals(_OrdenDescrip, value))
			{
				_OrdenDescrip = value;
			}
		}
	}

	[Column(Storage = "_AtendidoPor", DbType = "VarChar(20)")]
	public string AtendidoPor
	{
		get
		{
			return _AtendidoPor;
		}
		set
		{
			if (!string.Equals(_AtendidoPor, value))
			{
				_AtendidoPor = value;
			}
		}
	}

	[Column(Storage = "_idMotivo", DbType = "Int")]
	public int? idMotivo
	{
		get
		{
			return _idMotivo;
		}
		set
		{
			if (!_idMotivo.Equals(value))
			{
				_idMotivo = value;
			}
		}
	}

	[Column(Storage = "_HoraLlegada", DbType = "NVarChar(8)")]
	public string HoraLlegada
	{
		get
		{
			return _HoraLlegada;
		}
		set
		{
			if (!string.Equals(_HoraLlegada, value))
			{
				_HoraLlegada = value;
			}
		}
	}

	[Column(Storage = "_HoraAtencion", DbType = "NVarChar(8)")]
	public string HoraAtencion
	{
		get
		{
			return _HoraAtencion;
		}
		set
		{
			if (!string.Equals(_HoraAtencion, value))
			{
				_HoraAtencion = value;
			}
		}
	}

	[Column(Storage = "_TiempoAtencion", DbType = "NVarChar(8)")]
	public string TiempoAtencion
	{
		get
		{
			return _TiempoAtencion;
		}
		set
		{
			if (!string.Equals(_TiempoAtencion, value))
			{
				_TiempoAtencion = value;
			}
		}
	}

	[Column(Storage = "_idMotivo1", DbType = "Int NOT NULL")]
	public int idMotivo1
	{
		get
		{
			return _idMotivo1;
		}
		set
		{
			if (_idMotivo1 != value)
			{
				_idMotivo1 = value;
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
}
