using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.KM_Mensaje")]
public class KM_Mensaje : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _idMensaje;

	private string _DescripMensaje;

	private bool? _Reproduc;

	private EntitySet<KM_LogMensaje> _KM_LogMensaje;

	[Column(Storage = "_idMensaje", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int idMensaje
	{
		get
		{
			return _idMensaje;
		}
		set
		{
			if (_idMensaje != value)
			{
				SendPropertyChanging();
				_idMensaje = value;
				SendPropertyChanged("idMensaje");
			}
		}
	}

	[Column(Storage = "_DescripMensaje", DbType = "NVarChar(2000)")]
	public string DescripMensaje
	{
		get
		{
			return _DescripMensaje;
		}
		set
		{
			if (!string.Equals(_DescripMensaje, value))
			{
				SendPropertyChanging();
				_DescripMensaje = value;
				SendPropertyChanged("DescripMensaje");
			}
		}
	}

	[Column(Storage = "_Reproduc", DbType = "Bit")]
	public bool? Reproduc
	{
		get
		{
			return _Reproduc;
		}
		set
		{
			if (!_Reproduc.Equals(value))
			{
				SendPropertyChanging();
				_Reproduc = value;
				SendPropertyChanged("Reproduc");
			}
		}
	}

	[Association(Name = "KM_Mensaje_KM_LogMensaje", Storage = "_KM_LogMensaje", ThisKey = "idMensaje", OtherKey = "idMensaje")]
	public EntitySet<KM_LogMensaje> KM_LogMensaje
	{
		get
		{
			return _KM_LogMensaje;
		}
		set
		{
			_KM_LogMensaje.Assign(value);
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public KM_Mensaje()
	{
		_KM_LogMensaje = new EntitySet<KM_LogMensaje>(attach_KM_LogMensaje, detach_KM_LogMensaje);
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

	private void attach_KM_LogMensaje(KM_LogMensaje entity)
	{
		SendPropertyChanging();
		entity.KM_Mensaje = this;
	}

	private void detach_KM_LogMensaje(KM_LogMensaje entity)
	{
		SendPropertyChanging();
		entity.KM_Mensaje = null;
	}
}
