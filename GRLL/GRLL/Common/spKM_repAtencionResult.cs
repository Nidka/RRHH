using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spKM_repAtencionResult
{
	private int _idOrden;

	private DateTime _fecha;

	private bool? _Atendido;

	private bool? _Noatendido;

	private bool? _llamado;

	private string _Atendidopor;

	private string _TipoOperacion;

	private string _descrip_Motivo;

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

	[Column(Storage = "_fecha", DbType = "DateTime NOT NULL")]
	public DateTime fecha
	{
		get
		{
			return _fecha;
		}
		set
		{
			if (DateTime.Compare(_fecha, value) != 0)
			{
				_fecha = value;
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

	[Column(Storage = "_Noatendido", DbType = "Bit")]
	public bool? Noatendido
	{
		get
		{
			return _Noatendido;
		}
		set
		{
			if (!_Noatendido.Equals(value))
			{
				_Noatendido = value;
			}
		}
	}

	[Column(Storage = "_llamado", DbType = "Bit")]
	public bool? llamado
	{
		get
		{
			return _llamado;
		}
		set
		{
			if (!_llamado.Equals(value))
			{
				_llamado = value;
			}
		}
	}

	[Column(Storage = "_Atendidopor", DbType = "VarChar(20)")]
	public string Atendidopor
	{
		get
		{
			return _Atendidopor;
		}
		set
		{
			if (!string.Equals(_Atendidopor, value))
			{
				_Atendidopor = value;
			}
		}
	}

	[Column(Storage = "_TipoOperacion", DbType = "VarChar(100)")]
	public string TipoOperacion
	{
		get
		{
			return _TipoOperacion;
		}
		set
		{
			if (!string.Equals(_TipoOperacion, value))
			{
				_TipoOperacion = value;
			}
		}
	}

	[Column(Storage = "_descrip_Motivo", DbType = "VarChar(40)")]
	public string descrip_Motivo
	{
		get
		{
			return _descrip_Motivo;
		}
		set
		{
			if (!string.Equals(_descrip_Motivo, value))
			{
				_descrip_Motivo = value;
			}
		}
	}
}
