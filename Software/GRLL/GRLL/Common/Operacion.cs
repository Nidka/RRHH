using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Operacion")]
public class Operacion : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _IdOperacion;

	private string _Descripcion;

	private string _IdSistemaOpcion;

	private EntityRef<SistemaOpcion> _SistemaOpcion;

	[Column(Storage = "_IdOperacion", DbType = "Char(8) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdOperacion
	{
		get
		{
			return _IdOperacion;
		}
		set
		{
			if (!string.Equals(_IdOperacion, value))
			{
				SendPropertyChanging();
				_IdOperacion = value;
				SendPropertyChanged("IdOperacion");
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(50)")]
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

	[Column(Storage = "_IdSistemaOpcion", DbType = "Char(7) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdSistemaOpcion
	{
		get
		{
			return _IdSistemaOpcion;
		}
		set
		{
			if (!string.Equals(_IdSistemaOpcion, value))
			{
				if (_SistemaOpcion.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdSistemaOpcion = value;
				SendPropertyChanged("IdSistemaOpcion");
			}
		}
	}

	[Association(Name = "SistemaOpcion_Operacion", Storage = "_SistemaOpcion", ThisKey = "IdSistemaOpcion", OtherKey = "IdSistemaOpcion", IsForeignKey = true)]
	public SistemaOpcion SistemaOpcion
	{
		get
		{
			return _SistemaOpcion.Entity;
		}
		set
		{
			SistemaOpcion previousValue = _SistemaOpcion.Entity;
			if (!object.Equals(previousValue, value) || !_SistemaOpcion.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_SistemaOpcion.Entity = null;
					previousValue.Operacion.Remove(this);
				}
				_SistemaOpcion.Entity = value;
				if (value != null)
				{
					value.Operacion.Add(this);
					_IdSistemaOpcion = value.IdSistemaOpcion;
				}
				else
				{
					_IdSistemaOpcion = null;
				}
				SendPropertyChanged("SistemaOpcion");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Operacion()
	{
		_SistemaOpcion = default(EntityRef<SistemaOpcion>);
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
