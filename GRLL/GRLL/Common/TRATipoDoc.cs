using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.TRATipoDoc")]
public class TRATipoDoc : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _IdTipoDoc;

	private string _Descripcion;

	private EntitySet<TRANumeracion> _TRANumeracion;

	private EntitySet<TRATramite> _TRATramite;

	[Column(Storage = "_IdTipoDoc", DbType = "Char(2) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdTipoDoc
	{
		get
		{
			return _IdTipoDoc;
		}
		set
		{
			if (!string.Equals(_IdTipoDoc, value))
			{
				SendPropertyChanging();
				_IdTipoDoc = value;
				SendPropertyChanged("IdTipoDoc");
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(200)")]
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

	[Association(Name = "TRATipoDoc_TRANumeracion", Storage = "_TRANumeracion", ThisKey = "IdTipoDoc", OtherKey = "IdTipoDoc")]
	public EntitySet<TRANumeracion> TRANumeracion
	{
		get
		{
			return _TRANumeracion;
		}
		set
		{
			_TRANumeracion.Assign(value);
		}
	}

	[Association(Name = "TRATipoDoc_TRATramite", Storage = "_TRATramite", ThisKey = "IdTipoDoc", OtherKey = "IdTipoDoc")]
	public EntitySet<TRATramite> TRATramite
	{
		get
		{
			return _TRATramite;
		}
		set
		{
			_TRATramite.Assign(value);
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public TRATipoDoc()
	{
		_TRANumeracion = new EntitySet<TRANumeracion>(attach_TRANumeracion, detach_TRANumeracion);
		_TRATramite = new EntitySet<TRATramite>(attach_TRATramite, detach_TRATramite);
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

	private void attach_TRANumeracion(TRANumeracion entity)
	{
		SendPropertyChanging();
		entity.TRATipoDoc = this;
	}

	private void detach_TRANumeracion(TRANumeracion entity)
	{
		SendPropertyChanging();
		entity.TRATipoDoc = null;
	}

	private void attach_TRATramite(TRATramite entity)
	{
		SendPropertyChanging();
		entity.TRATipoDoc = this;
	}

	private void detach_TRATramite(TRATramite entity)
	{
		SendPropertyChanging();
		entity.TRATipoDoc = null;
	}
}
