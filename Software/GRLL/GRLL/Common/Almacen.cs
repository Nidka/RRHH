using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Almacen")]
public class Almacen : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _IdAlmacen;

	private string _Descripcion;

	private int? _IdInstitucion;

	private string _Direccion;

	private int? _Responsable;

	private EntitySet<Almacen_Bien> _Almacen_Bien;

	private EntitySet<Movimiento> _Movimiento;

	private EntitySet<OrdenCompra> _OrdenCompra;

	private EntityRef<Institucion> _Institucion;

	[Column(Storage = "_IdAlmacen", DbType = "Char(2) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdAlmacen
	{
		get
		{
			return _IdAlmacen;
		}
		set
		{
			if (!string.Equals(_IdAlmacen, value))
			{
				SendPropertyChanging();
				_IdAlmacen = value;
				SendPropertyChanged("IdAlmacen");
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

	[Column(Storage = "_IdInstitucion", DbType = "Int")]
	public int? IdInstitucion
	{
		get
		{
			return _IdInstitucion;
		}
		set
		{
			if (!_IdInstitucion.Equals(value))
			{
				if (_Institucion.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdInstitucion = value;
				SendPropertyChanged("IdInstitucion");
			}
		}
	}

	[Column(Storage = "_Direccion", DbType = "VarChar(80)")]
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

	[Column(Storage = "_Responsable", DbType = "Int")]
	public int? Responsable
	{
		get
		{
			return _Responsable;
		}
		set
		{
			if (!_Responsable.Equals(value))
			{
				SendPropertyChanging();
				_Responsable = value;
				SendPropertyChanged("Responsable");
			}
		}
	}

	[Association(Name = "Almacen_Almacen_Bien", Storage = "_Almacen_Bien", ThisKey = "IdAlmacen", OtherKey = "IdAlmacen")]
	public EntitySet<Almacen_Bien> Almacen_Bien
	{
		get
		{
			return _Almacen_Bien;
		}
		set
		{
			_Almacen_Bien.Assign(value);
		}
	}

	[Association(Name = "Almacen_Movimiento", Storage = "_Movimiento", ThisKey = "IdAlmacen", OtherKey = "IdAlmacen")]
	public EntitySet<Movimiento> Movimiento
	{
		get
		{
			return _Movimiento;
		}
		set
		{
			_Movimiento.Assign(value);
		}
	}

	[Association(Name = "Almacen_OrdenCompra", Storage = "_OrdenCompra", ThisKey = "IdAlmacen", OtherKey = "IdAlmacen")]
	public EntitySet<OrdenCompra> OrdenCompra
	{
		get
		{
			return _OrdenCompra;
		}
		set
		{
			_OrdenCompra.Assign(value);
		}
	}

	[Association(Name = "Institucion_Almacen", Storage = "_Institucion", ThisKey = "IdInstitucion", OtherKey = "IdInstitucion", IsForeignKey = true)]
	public Institucion Institucion
	{
		get
		{
			return _Institucion.Entity;
		}
		set
		{
			Institucion previousValue = _Institucion.Entity;
			if (!object.Equals(previousValue, value) || !_Institucion.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_Institucion.Entity = null;
					previousValue.Almacen.Remove(this);
				}
				_Institucion.Entity = value;
				if (value != null)
				{
					value.Almacen.Add(this);
					_IdInstitucion = value.IdInstitucion;
				}
				else
				{
					_IdInstitucion = null;
				}
				SendPropertyChanged("Institucion");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Almacen()
	{
		_Almacen_Bien = new EntitySet<Almacen_Bien>(attach_Almacen_Bien, detach_Almacen_Bien);
		_Movimiento = new EntitySet<Movimiento>(attach_Movimiento, detach_Movimiento);
		_OrdenCompra = new EntitySet<OrdenCompra>(attach_OrdenCompra, detach_OrdenCompra);
		_Institucion = default(EntityRef<Institucion>);
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

	private void attach_Almacen_Bien(Almacen_Bien entity)
	{
		SendPropertyChanging();
		entity.Almacen = this;
	}

	private void detach_Almacen_Bien(Almacen_Bien entity)
	{
		SendPropertyChanging();
		entity.Almacen = null;
	}

	private void attach_Movimiento(Movimiento entity)
	{
		SendPropertyChanging();
		entity.Almacen = this;
	}

	private void detach_Movimiento(Movimiento entity)
	{
		SendPropertyChanging();
		entity.Almacen = null;
	}

	private void attach_OrdenCompra(OrdenCompra entity)
	{
		SendPropertyChanging();
		entity.Almacen = this;
	}

	private void detach_OrdenCompra(OrdenCompra entity)
	{
		SendPropertyChanging();
		entity.Almacen = null;
	}
}
