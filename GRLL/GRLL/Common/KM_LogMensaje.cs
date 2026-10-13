using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.KM_LogMensaje")]
public class KM_LogMensaje : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private DateTime _Fecha;

	private int _idOrden;

	private int? _idMensaje;

	private string _HoraInicio;

	private EntityRef<KM_Mensaje> _KM_Mensaje;

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

	[Column(Storage = "_idOrden", DbType = "Int NOT NULL", IsPrimaryKey = true)]
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
				SendPropertyChanging();
				_idOrden = value;
				SendPropertyChanged("idOrden");
			}
		}
	}

	[Column(Storage = "_idMensaje", DbType = "Int")]
	public int? idMensaje
	{
		get
		{
			return _idMensaje;
		}
		set
		{
			if (!_idMensaje.Equals(value))
			{
				if (_KM_Mensaje.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_idMensaje = value;
				SendPropertyChanged("idMensaje");
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
				SendPropertyChanging();
				_HoraInicio = value;
				SendPropertyChanged("HoraInicio");
			}
		}
	}

	[Association(Name = "KM_Mensaje_KM_LogMensaje", Storage = "_KM_Mensaje", ThisKey = "idMensaje", OtherKey = "idMensaje", IsForeignKey = true)]
	public KM_Mensaje KM_Mensaje
	{
		get
		{
			return _KM_Mensaje.Entity;
		}
		set
		{
			KM_Mensaje previousValue = _KM_Mensaje.Entity;
			if (!object.Equals(previousValue, value) || !_KM_Mensaje.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_KM_Mensaje.Entity = null;
					previousValue.KM_LogMensaje.Remove(this);
				}
				_KM_Mensaje.Entity = value;
				if (value != null)
				{
					value.KM_LogMensaje.Add(this);
					_idMensaje = value.idMensaje;
				}
				else
				{
					_idMensaje = null;
				}
				SendPropertyChanged("KM_Mensaje");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public KM_LogMensaje()
	{
		_KM_Mensaje = default(EntityRef<KM_Mensaje>);
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
