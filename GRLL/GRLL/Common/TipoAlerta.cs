using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.TipoAlerta")]
public class TipoAlerta : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdTipoAlerta;

	private string _Descripcion;

	private EntitySet<Alerta> _Alerta;

	[Column(Storage = "_IdTipoAlerta", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdTipoAlerta
	{
		get
		{
			return _IdTipoAlerta;
		}
		set
		{
			if (_IdTipoAlerta != value)
			{
				SendPropertyChanging();
				_IdTipoAlerta = value;
				SendPropertyChanged("IdTipoAlerta");
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

	[Association(Name = "TipoAlerta_Alerta", Storage = "_Alerta", ThisKey = "IdTipoAlerta", OtherKey = "IdTipoAlerta")]
	public EntitySet<Alerta> Alerta
	{
		get
		{
			return _Alerta;
		}
		set
		{
			_Alerta.Assign(value);
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public TipoAlerta()
	{
		_Alerta = new EntitySet<Alerta>(attach_Alerta, detach_Alerta);
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

	private void attach_Alerta(Alerta entity)
	{
		SendPropertyChanging();
		entity.TipoAlerta = this;
	}

	private void detach_Alerta(Alerta entity)
	{
		SendPropertyChanging();
		entity.TipoAlerta = null;
	}
}
