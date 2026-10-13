using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.KM_TipoOperacion")]
public class KM_TipoOperacion : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdTipoOperacion;

	private string _TipoOperacion;

	private int? _OrdenAtencion;

	private EntitySet<KM_Orden> _KM_Orden;

	[Column(Storage = "_IdTipoOperacion", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdTipoOperacion
	{
		get
		{
			return _IdTipoOperacion;
		}
		set
		{
			if (_IdTipoOperacion != value)
			{
				SendPropertyChanging();
				_IdTipoOperacion = value;
				SendPropertyChanged("IdTipoOperacion");
			}
		}
	}

	[Column(Storage = "_TipoOperacion", DbType = "VarChar(100)")]
	public string TipoOperacion
	{
		get
		{
			return _TipoOperacion;
		}
		set
		{
			if (!string.Equals(_TipoOperacion, value))
			{
				SendPropertyChanging();
				_TipoOperacion = value;
				SendPropertyChanged("TipoOperacion");
			}
		}
	}

	[Column(Storage = "_OrdenAtencion", DbType = "Int")]
	public int? OrdenAtencion
	{
		get
		{
			return _OrdenAtencion;
		}
		set
		{
			if (!_OrdenAtencion.Equals(value))
			{
				SendPropertyChanging();
				_OrdenAtencion = value;
				SendPropertyChanged("OrdenAtencion");
			}
		}
	}

	[Association(Name = "KM_TipoOperacion_KM_Orden", Storage = "_KM_Orden", ThisKey = "IdTipoOperacion", OtherKey = "IdTipoOperacion")]
	public EntitySet<KM_Orden> KM_Orden
	{
		get
		{
			return _KM_Orden;
		}
		set
		{
			_KM_Orden.Assign(value);
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public KM_TipoOperacion()
	{
		_KM_Orden = new EntitySet<KM_Orden>(attach_KM_Orden, detach_KM_Orden);
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

	private void attach_KM_Orden(KM_Orden entity)
	{
		SendPropertyChanging();
		entity.KM_TipoOperacion = this;
	}

	private void detach_KM_Orden(KM_Orden entity)
	{
		SendPropertyChanging();
		entity.KM_TipoOperacion = null;
	}
}
