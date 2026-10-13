using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.TipoTransaccion")]
public class TipoTransaccion : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _Anio;

	private string _IdTipoTransaccion;

	private string _Descripcion;

	private EntitySet<Generica> _Generica;

	[Column(Storage = "_Anio", DbType = "Char(5) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string Anio
	{
		get
		{
			return _Anio;
		}
		set
		{
			if (!string.Equals(_Anio, value))
			{
				SendPropertyChanging();
				_Anio = value;
				SendPropertyChanged("Anio");
			}
		}
	}

	[Column(Storage = "_IdTipoTransaccion", DbType = "Char(2) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdTipoTransaccion
	{
		get
		{
			return _IdTipoTransaccion;
		}
		set
		{
			if (!string.Equals(_IdTipoTransaccion, value))
			{
				SendPropertyChanging();
				_IdTipoTransaccion = value;
				SendPropertyChanged("IdTipoTransaccion");
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

	[Association(Name = "TipoTransaccion_Generica", Storage = "_Generica", ThisKey = "Anio,IdTipoTransaccion", OtherKey = "idTipoTransaccion,Anio")]
	public EntitySet<Generica> Generica
	{
		get
		{
			return _Generica;
		}
		set
		{
			_Generica.Assign(value);
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public TipoTransaccion()
	{
		_Generica = new EntitySet<Generica>(attach_Generica, detach_Generica);
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

	private void attach_Generica(Generica entity)
	{
		SendPropertyChanging();
		entity.TipoTransaccion = this;
	}

	private void detach_Generica(Generica entity)
	{
		SendPropertyChanging();
		entity.TipoTransaccion = null;
	}
}
