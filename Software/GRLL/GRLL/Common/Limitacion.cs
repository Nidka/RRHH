using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Limitacion")]
public class Limitacion : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdLimitacion;

	private string _Descripcion;

	private EntitySet<Recomendacion> _Recomendacion;

	[Column(Storage = "_IdLimitacion", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdLimitacion
	{
		get
		{
			return _IdLimitacion;
		}
		set
		{
			if (_IdLimitacion != value)
			{
				SendPropertyChanging();
				_IdLimitacion = value;
				SendPropertyChanged("IdLimitacion");
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(500)")]
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

	[Association(Name = "Limitacion_Recomendacion", Storage = "_Recomendacion", ThisKey = "IdLimitacion", OtherKey = "IdLimitacion")]
	public EntitySet<Recomendacion> Recomendacion
	{
		get
		{
			return _Recomendacion;
		}
		set
		{
			_Recomendacion.Assign(value);
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Limitacion()
	{
		_Recomendacion = new EntitySet<Recomendacion>(attach_Recomendacion, detach_Recomendacion);
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

	private void attach_Recomendacion(Recomendacion entity)
	{
		SendPropertyChanging();
		entity.Limitacion1 = this;
	}

	private void detach_Recomendacion(Recomendacion entity)
	{
		SendPropertyChanging();
		entity.Limitacion1 = null;
	}
}
