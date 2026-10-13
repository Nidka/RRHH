using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.CJRResSolicitudOpinion")]
public class CJRResSolicitudOpinion : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _NumOficioSolicitud;

	private string _Origen;

	private string _NumOficio;

	private EntityRef<CJROficio> _CJROficio;

	private EntityRef<CJRSolicitudOpinion> _CJRSolicitudOpinion;

	[Column(Storage = "_NumOficioSolicitud", DbType = "VarChar(120)")]
	public string NumOficioSolicitud
	{
		get
		{
			return _NumOficioSolicitud;
		}
		set
		{
			if (!string.Equals(_NumOficioSolicitud, value))
			{
				if (_CJRSolicitudOpinion.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_NumOficioSolicitud = value;
				SendPropertyChanged("NumOficioSolicitud");
			}
		}
	}

	[Column(Storage = "_Origen", DbType = "VarChar(200)")]
	public string Origen
	{
		get
		{
			return _Origen;
		}
		set
		{
			if (!string.Equals(_Origen, value))
			{
				SendPropertyChanging();
				_Origen = value;
				SendPropertyChanged("Origen");
			}
		}
	}

	[Column(Storage = "_NumOficio", DbType = "VarChar(120) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string NumOficio
	{
		get
		{
			return _NumOficio;
		}
		set
		{
			if (!string.Equals(_NumOficio, value))
			{
				if (_CJROficio.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_NumOficio = value;
				SendPropertyChanged("NumOficio");
			}
		}
	}

	[Association(Name = "CJROficio_CJRResSolicitudOpinion", Storage = "_CJROficio", ThisKey = "NumOficio", OtherKey = "NumOficio", IsForeignKey = true)]
	public CJROficio CJROficio
	{
		get
		{
			return _CJROficio.Entity;
		}
		set
		{
			CJROficio previousValue = _CJROficio.Entity;
			if (!object.Equals(previousValue, value) || !_CJROficio.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_CJROficio.Entity = null;
					previousValue.CJRResSolicitudOpinion = null;
				}
				_CJROficio.Entity = value;
				if (value != null)
				{
					value.CJRResSolicitudOpinion = this;
					_NumOficio = value.NumOficio;
				}
				else
				{
					_NumOficio = null;
				}
				SendPropertyChanged("CJROficio");
			}
		}
	}

	[Association(Name = "CJRSolicitudOpinion_CJRResSolicitudOpinion", Storage = "_CJRSolicitudOpinion", ThisKey = "NumOficioSolicitud", OtherKey = "NumOficio", IsForeignKey = true)]
	public CJRSolicitudOpinion CJRSolicitudOpinion
	{
		get
		{
			return _CJRSolicitudOpinion.Entity;
		}
		set
		{
			CJRSolicitudOpinion previousValue = _CJRSolicitudOpinion.Entity;
			if (!object.Equals(previousValue, value) || !_CJRSolicitudOpinion.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_CJRSolicitudOpinion.Entity = null;
					previousValue.CJRResSolicitudOpinion.Remove(this);
				}
				_CJRSolicitudOpinion.Entity = value;
				if (value != null)
				{
					value.CJRResSolicitudOpinion.Add(this);
					_NumOficioSolicitud = value.NumOficio;
				}
				else
				{
					_NumOficioSolicitud = null;
				}
				SendPropertyChanged("CJRSolicitudOpinion");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public CJRResSolicitudOpinion()
	{
		_CJROficio = default(EntityRef<CJROficio>);
		_CJRSolicitudOpinion = default(EntityRef<CJRSolicitudOpinion>);
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
