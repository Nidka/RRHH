using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Cotizacion")]
public class Cotizacion : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _IdCotizacion;

	private DateTime? _Fecha;

	private string _IdProveedor;

	private string _Especificaciones;

	private string _IdConsolidado;

	private string _Observaciones;

	private EntitySet<Deta_Cotizacion> _Deta_Cotizacion;

	private EntityRef<Consolidado> _Consolidado;

	private EntityRef<Proveedor> _Proveedor;

	[Column(Storage = "_IdCotizacion", DbType = "Char(6) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdCotizacion
	{
		get
		{
			return _IdCotizacion;
		}
		set
		{
			if (!string.Equals(_IdCotizacion, value))
			{
				SendPropertyChanging();
				_IdCotizacion = value;
				SendPropertyChanged("IdCotizacion");
			}
		}
	}

	[Column(Storage = "_Fecha", DbType = "DateTime")]
	public DateTime? Fecha
	{
		get
		{
			return _Fecha;
		}
		set
		{
			if (!_Fecha.Equals(value))
			{
				SendPropertyChanging();
				_Fecha = value;
				SendPropertyChanged("Fecha");
			}
		}
	}

	[Column(Storage = "_IdProveedor", DbType = "Char(11)")]
	public string IdProveedor
	{
		get
		{
			return _IdProveedor;
		}
		set
		{
			if (!string.Equals(_IdProveedor, value))
			{
				if (_Proveedor.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdProveedor = value;
				SendPropertyChanged("IdProveedor");
			}
		}
	}

	[Column(Storage = "_Especificaciones", DbType = "VarChar(30)")]
	public string Especificaciones
	{
		get
		{
			return _Especificaciones;
		}
		set
		{
			if (!string.Equals(_Especificaciones, value))
			{
				SendPropertyChanging();
				_Especificaciones = value;
				SendPropertyChanged("Especificaciones");
			}
		}
	}

	[Column(Storage = "_IdConsolidado", DbType = "Char(6)")]
	public string IdConsolidado
	{
		get
		{
			return _IdConsolidado;
		}
		set
		{
			if (!string.Equals(_IdConsolidado, value))
			{
				if (_Consolidado.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdConsolidado = value;
				SendPropertyChanged("IdConsolidado");
			}
		}
	}

	[Column(Storage = "_Observaciones", DbType = "VarChar(200)")]
	public string Observaciones
	{
		get
		{
			return _Observaciones;
		}
		set
		{
			if (!string.Equals(_Observaciones, value))
			{
				SendPropertyChanging();
				_Observaciones = value;
				SendPropertyChanged("Observaciones");
			}
		}
	}

	[Association(Name = "Cotizacion_Deta_Cotizacion", Storage = "_Deta_Cotizacion", ThisKey = "IdCotizacion", OtherKey = "IdCotizacion")]
	public EntitySet<Deta_Cotizacion> Deta_Cotizacion
	{
		get
		{
			return _Deta_Cotizacion;
		}
		set
		{
			_Deta_Cotizacion.Assign(value);
		}
	}

	[Association(Name = "Consolidado_Cotizacion", Storage = "_Consolidado", ThisKey = "IdConsolidado", OtherKey = "IdConsolidado", IsForeignKey = true)]
	public Consolidado Consolidado
	{
		get
		{
			return _Consolidado.Entity;
		}
		set
		{
			Consolidado previousValue = _Consolidado.Entity;
			if (!object.Equals(previousValue, value) || !_Consolidado.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_Consolidado.Entity = null;
					previousValue.Cotizacion.Remove(this);
				}
				_Consolidado.Entity = value;
				if (value != null)
				{
					value.Cotizacion.Add(this);
					_IdConsolidado = value.IdConsolidado;
				}
				else
				{
					_IdConsolidado = null;
				}
				SendPropertyChanged("Consolidado");
			}
		}
	}

	[Association(Name = "Proveedor_Cotizacion", Storage = "_Proveedor", ThisKey = "IdProveedor", OtherKey = "IdProveedor", IsForeignKey = true)]
	public Proveedor Proveedor
	{
		get
		{
			return _Proveedor.Entity;
		}
		set
		{
			Proveedor previousValue = _Proveedor.Entity;
			if (!object.Equals(previousValue, value) || !_Proveedor.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_Proveedor.Entity = null;
					previousValue.Cotizacion.Remove(this);
				}
				_Proveedor.Entity = value;
				if (value != null)
				{
					value.Cotizacion.Add(this);
					_IdProveedor = value.IdProveedor;
				}
				else
				{
					_IdProveedor = null;
				}
				SendPropertyChanged("Proveedor");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Cotizacion()
	{
		_Deta_Cotizacion = new EntitySet<Deta_Cotizacion>(attach_Deta_Cotizacion, detach_Deta_Cotizacion);
		_Consolidado = default(EntityRef<Consolidado>);
		_Proveedor = default(EntityRef<Proveedor>);
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

	private void attach_Deta_Cotizacion(Deta_Cotizacion entity)
	{
		SendPropertyChanging();
		entity.Cotizacion = this;
	}

	private void detach_Deta_Cotizacion(Deta_Cotizacion entity)
	{
		SendPropertyChanging();
		entity.Cotizacion = null;
	}
}
