using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.KM_Orden")]
public class KM_Orden : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

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

	private EntityRef<KM_Motivo> _KM_Motivo;

	private EntityRef<KM_TipoOperacion> _KM_TipoOperacion;

	[Column(Storage = "_IdOrden", DbType = "Int NOT NULL", IsPrimaryKey = true)]
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
				SendPropertyChanging();
				_IdOrden = value;
				SendPropertyChanged("IdOrden");
			}
		}
	}

	[Column(Storage = "_Fecha", DbType = "DateTime NOT NULL", IsPrimaryKey = true)]
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
				SendPropertyChanging();
				_Fecha = value;
				SendPropertyChanged("Fecha");
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
				if (_KM_TipoOperacion.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdTipoOperacion = value;
				SendPropertyChanged("IdTipoOperacion");
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
				SendPropertyChanging();
				_Atendido = value;
				SendPropertyChanged("Atendido");
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
				SendPropertyChanging();
				_NoAtendido = value;
				SendPropertyChanged("NoAtendido");
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
				SendPropertyChanging();
				_Llamado = value;
				SendPropertyChanged("Llamado");
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
				SendPropertyChanging();
				_OrdenDescrip = value;
				SendPropertyChanged("OrdenDescrip");
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
				SendPropertyChanging();
				_AtendidoPor = value;
				SendPropertyChanged("AtendidoPor");
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
				if (_KM_Motivo.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_idMotivo = value;
				SendPropertyChanged("idMotivo");
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
				SendPropertyChanging();
				_HoraLlegada = value;
				SendPropertyChanged("HoraLlegada");
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
				SendPropertyChanging();
				_HoraAtencion = value;
				SendPropertyChanged("HoraAtencion");
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
				SendPropertyChanging();
				_TiempoAtencion = value;
				SendPropertyChanged("TiempoAtencion");
			}
		}
	}

	[Association(Name = "KM_Motivo_KM_Orden", Storage = "_KM_Motivo", ThisKey = "idMotivo", OtherKey = "idMotivo", IsForeignKey = true)]
	public KM_Motivo KM_Motivo
	{
		get
		{
			return _KM_Motivo.Entity;
		}
		set
		{
			KM_Motivo previousValue = _KM_Motivo.Entity;
			if (!object.Equals(previousValue, value) || !_KM_Motivo.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_KM_Motivo.Entity = null;
					previousValue.KM_Orden.Remove(this);
				}
				_KM_Motivo.Entity = value;
				if (value != null)
				{
					value.KM_Orden.Add(this);
					_idMotivo = value.idMotivo;
				}
				else
				{
					_idMotivo = null;
				}
				SendPropertyChanged("KM_Motivo");
			}
		}
	}

	[Association(Name = "KM_TipoOperacion_KM_Orden", Storage = "_KM_TipoOperacion", ThisKey = "IdTipoOperacion", OtherKey = "IdTipoOperacion", IsForeignKey = true)]
	public KM_TipoOperacion KM_TipoOperacion
	{
		get
		{
			return _KM_TipoOperacion.Entity;
		}
		set
		{
			KM_TipoOperacion previousValue = _KM_TipoOperacion.Entity;
			if (!object.Equals(previousValue, value) || !_KM_TipoOperacion.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_KM_TipoOperacion.Entity = null;
					previousValue.KM_Orden.Remove(this);
				}
				_KM_TipoOperacion.Entity = value;
				if (value != null)
				{
					value.KM_Orden.Add(this);
					_IdTipoOperacion = value.IdTipoOperacion;
				}
				else
				{
					_IdTipoOperacion = null;
				}
				SendPropertyChanged("KM_TipoOperacion");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public KM_Orden()
	{
		_KM_Motivo = default(EntityRef<KM_Motivo>);
		_KM_TipoOperacion = default(EntityRef<KM_TipoOperacion>);
	}

	protected virtual void SendPropertyChanging()
	{
		if (PropertyChanging != null)
		{
			PropertyChanging?.Invoke(this, emptyChangingEventArgs);
		}
	}

	protected virtual void SendPropertyChanged(string propertyName)
	{
		if (PropertyChanged != null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
