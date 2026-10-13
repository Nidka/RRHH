using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.KM_VideoList")]
public class KM_VideoList : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _idVideo;

	private string _Ruta;

	private string _Descripcion;

	private string _Duracion;

	private string _Formato;

	private EntitySet<KM_LogReprod> _KM_LogReprod;

	private EntitySet<KM_PlayListAviso> _KM_PlayListAviso;

	private EntitySet<KM_PlayListPrincipal> _KM_PlayListPrincipal;

	[Column(Storage = "_idVideo", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int idVideo
	{
		get
		{
			return _idVideo;
		}
		set
		{
			if (_idVideo != value)
			{
				SendPropertyChanging();
				_idVideo = value;
				SendPropertyChanged("idVideo");
			}
		}
	}

	[Column(Storage = "_Ruta", DbType = "VarChar(2000)")]
	public string Ruta
	{
		get
		{
			return _Ruta;
		}
		set
		{
			if (!string.Equals(_Ruta, value))
			{
				SendPropertyChanging();
				_Ruta = value;
				SendPropertyChanged("Ruta");
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(100)")]
	public string Descripcion
	{
		get
		{
			return _Descripcion;
		}
		set
		{
			if (!string.Equals(_Descripcion, value))
			{
				SendPropertyChanging();
				_Descripcion = value;
				SendPropertyChanged("Descripcion");
			}
		}
	}

	[Column(Storage = "_Duracion", DbType = "VarChar(8)")]
	public string Duracion
	{
		get
		{
			return _Duracion;
		}
		set
		{
			if (!string.Equals(_Duracion, value))
			{
				SendPropertyChanging();
				_Duracion = value;
				SendPropertyChanged("Duracion");
			}
		}
	}

	[Column(Storage = "_Formato", DbType = "VarChar(5)")]
	public string Formato
	{
		get
		{
			return _Formato;
		}
		set
		{
			if (!string.Equals(_Formato, value))
			{
				SendPropertyChanging();
				_Formato = value;
				SendPropertyChanged("Formato");
			}
		}
	}

	[Association(Name = "KM_VideoList_KM_LogReprod", Storage = "_KM_LogReprod", ThisKey = "idVideo", OtherKey = "idVideo")]
	public EntitySet<KM_LogReprod> KM_LogReprod
	{
		get
		{
			return _KM_LogReprod;
		}
		set
		{
			_KM_LogReprod.Assign(value);
		}
	}

	[Association(Name = "KM_VideoList_KM_PlayListAviso", Storage = "_KM_PlayListAviso", ThisKey = "idVideo", OtherKey = "idVideo")]
	public EntitySet<KM_PlayListAviso> KM_PlayListAviso
	{
		get
		{
			return _KM_PlayListAviso;
		}
		set
		{
			_KM_PlayListAviso.Assign(value);
		}
	}

	[Association(Name = "KM_VideoList_KM_PlayListPrincipal", Storage = "_KM_PlayListPrincipal", ThisKey = "idVideo", OtherKey = "idVideo")]
	public EntitySet<KM_PlayListPrincipal> KM_PlayListPrincipal
	{
		get
		{
			return _KM_PlayListPrincipal;
		}
		set
		{
			_KM_PlayListPrincipal.Assign(value);
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public KM_VideoList()
	{
		_KM_LogReprod = new EntitySet<KM_LogReprod>(attach_KM_LogReprod, detach_KM_LogReprod);
		_KM_PlayListAviso = new EntitySet<KM_PlayListAviso>(attach_KM_PlayListAviso, detach_KM_PlayListAviso);
		_KM_PlayListPrincipal = new EntitySet<KM_PlayListPrincipal>(attach_KM_PlayListPrincipal, detach_KM_PlayListPrincipal);
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

	private void attach_KM_LogReprod(KM_LogReprod entity)
	{
		SendPropertyChanging();
		entity.KM_VideoList = this;
	}

	private void detach_KM_LogReprod(KM_LogReprod entity)
	{
		SendPropertyChanging();
		entity.KM_VideoList = null;
	}

	private void attach_KM_PlayListAviso(KM_PlayListAviso entity)
	{
		SendPropertyChanging();
		entity.KM_VideoList = this;
	}

	private void detach_KM_PlayListAviso(KM_PlayListAviso entity)
	{
		SendPropertyChanging();
		entity.KM_VideoList = null;
	}

	private void attach_KM_PlayListPrincipal(KM_PlayListPrincipal entity)
	{
		SendPropertyChanging();
		entity.KM_VideoList = this;
	}

	private void detach_KM_PlayListPrincipal(KM_PlayListPrincipal entity)
	{
		SendPropertyChanging();
		entity.KM_VideoList = null;
	}
}
