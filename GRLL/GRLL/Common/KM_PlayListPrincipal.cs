using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.KM_PlayListPrincipal")]
public class KM_PlayListPrincipal : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _idReprod;

	private int? _idVideo;

	private int? _OrdenReprod;

	private EntityRef<KM_VideoList> _KM_VideoList;

	[Column(Storage = "_idReprod", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int idReprod
	{
		get
		{
			return _idReprod;
		}
		set
		{
			if (_idReprod != value)
			{
				SendPropertyChanging();
				_idReprod = value;
				SendPropertyChanged("idReprod");
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

	[Column(Storage = "_OrdenReprod", DbType = "Int")]
	public int? OrdenReprod
	{
		get
		{
			return _OrdenReprod;
		}
		set
		{
			if (!_OrdenReprod.Equals(value))
			{
				SendPropertyChanging();
				_OrdenReprod = value;
				SendPropertyChanged("OrdenReprod");
			}
		}
	}

	[Association(Name = "KM_VideoList_KM_PlayListPrincipal", Storage = "_KM_VideoList", ThisKey = "idVideo", OtherKey = "idVideo", IsForeignKey = true)]
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
					previousValue.KM_PlayListPrincipal.Remove(this);
				}
				_KM_VideoList.Entity = value;
				if (value != null)
				{
					value.KM_PlayListPrincipal.Add(this);
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

	public KM_PlayListPrincipal()
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
