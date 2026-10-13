using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Institucion")]
public class Institucion : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdInstitucion;

	private string _Descripcion;

	private string _Direccion;

	private EntitySet<Almacen> _Almacen;

	[Column(Storage = "_IdInstitucion", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdInstitucion
	{
		get
		{
			return _IdInstitucion;
		}
		set
		{
			if (_IdInstitucion != value)
			{
				SendPropertyChanging();
				_IdInstitucion = value;
				SendPropertyChanged("IdInstitucion");
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(120)")]
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

	[Column(Storage = "_Direccion", DbType = "VarChar(120)")]
	public string Direccion
	{
		get
		{
			return _Direccion;
		}
		set
		{
			if (!string.Equals(_Direccion, value))
			{
				SendPropertyChanging();
				_Direccion = value;
				SendPropertyChanged("Direccion");
			}
		}
	}

	[Association(Name = "Institucion_Almacen", Storage = "_Almacen", ThisKey = "IdInstitucion", OtherKey = "IdInstitucion")]
	public EntitySet<Almacen> Almacen
	{
		get
		{
			return _Almacen;
		}
		set
		{
			_Almacen.Assign(value);
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Institucion()
	{
		_Almacen = new EntitySet<Almacen>(attach_Almacen, detach_Almacen);
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

	private void attach_Almacen(Almacen entity)
	{
		SendPropertyChanging();
		entity.Institucion = this;
	}

	private void detach_Almacen(Almacen entity)
	{
		SendPropertyChanging();
		entity.Institucion = null;
	}
}
