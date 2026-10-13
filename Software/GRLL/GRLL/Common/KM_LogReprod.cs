using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.KM_LogReprod")]
public class KM_LogReprod : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private DateTime _Fecha;

	private int _IdOrden;

	private string _HoraInicio;

	private int? _idVideo;

	private bool? _TipoAviso;

	private EntityRef<KM_VideoList> _KM_VideoList;

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

	[Column(Storage = "_idVideo", DbType = "Int")]
	public int? idVideo
	{
		get
		{
			return _idVideo;
		}
		set
		{
			if (!_idVideo.Equals(value))
			{
				if (_KM_VideoList.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_idVideo = value;
				SendPropertyChanged("idVideo");
			}
		}
	}

	[Column(Storage = "_TipoAviso", DbType = "Bit")]
	public bool? TipoAviso
	{
		get
		{
			return _TipoAviso;
		}
		set
		{
			if (!_TipoAviso.Equals(value))
			{
				SendPropertyChanging();
				_TipoAviso = value;
				SendPropertyChanged("TipoAviso");
			}
		}
	}

	[Association(Name = "KM_VideoList_KM_LogReprod", Storage = "_KM_VideoList", ThisKey = "idVideo", OtherKey = "idVideo", IsForeignKey = true)]
	public KM_VideoList KM_VideoList
	{
		get
		{
			return _KM_VideoList.Entity;
		}
		set
		{
			KM_VideoList previousValue = _KM_VideoList.Entity;
			if (!object.Equals(previousValue, value) || !_KM_VideoList.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_KM_VideoList.Entity = null;
					previousValue.KM_LogReprod.Remove(this);
				}
				_KM_VideoList.Entity = value;
				if (value != null)
				{
					value.KM_LogReprod.Add(this);
					_idVideo = value.idVideo;
				}
				else
				{
					_idVideo = null;
				}
				SendPropertyChanged("KM_VideoList");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public KM_LogReprod()
	{
		_KM_VideoList = default(EntityRef<KM_VideoList>);
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
