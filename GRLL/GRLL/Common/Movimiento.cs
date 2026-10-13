using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Movimiento")]
public class Movimiento : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _IdMovimiento;

	private DateTime? _Fecha;

	private string _RecibidoPor;

	private string _Dependencia;

	private int? _IdEmpleado;

	private string _Estado;

	private string _IdAlmacen;

	private char? _IdTipoMovimiento;

	private string _IdTipodoc;

	private string _IdOrden;

	private char? _TipoOrden;

	private string _Observaciones;

	private EntitySet<Pedido_Despacho> _Pedido_Despacho;

	private EntitySet<Deta_Movimiento> _Deta_Movimiento;

	private EntityRef<Almacen> _Almacen;

	private EntityRef<OrdenCompra> _OrdenCompra;

	private EntityRef<TipoMovimiento> _TipoMovimiento;

	[Column(Storage = "_IdMovimiento", DbType = "Char(8) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdMovimiento
	{
		get
		{
			return _IdMovimiento;
		}
		set
		{
			if (!string.Equals(_IdMovimiento, value))
			{
				SendPropertyChanging();
				_IdMovimiento = value;
				SendPropertyChanged("IdMovimiento");
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

	[Column(Storage = "_RecibidoPor", DbType = "VarChar(80)")]
	public string RecibidoPor
	{
		get
		{
			return _RecibidoPor;
		}
		set
		{
			if (!string.Equals(_RecibidoPor, value))
			{
				SendPropertyChanging();
				_RecibidoPor = value;
				SendPropertyChanged("RecibidoPor");
			}
		}
	}

	[Column(Storage = "_Dependencia", DbType = "VarChar(80)")]
	public string Dependencia
	{
		get
		{
			return _Dependencia;
		}
		set
		{
			if (!string.Equals(_Dependencia, value))
			{
				SendPropertyChanging();
				_Dependencia = value;
				SendPropertyChanged("Dependencia");
			}
		}
	}

	[Column(Storage = "_IdEmpleado", DbType = "Int")]
	public int? IdEmpleado
	{
		get
		{
			return _IdEmpleado;
		}
		set
		{
			if (!_IdEmpleado.Equals(value))
			{
				SendPropertyChanging();
				_IdEmpleado = value;
				SendPropertyChanged("IdEmpleado");
			}
		}
	}

	[Column(Storage = "_Estado", DbType = "Char(18)")]
	public string Estado
	{
		get
		{
			return _Estado;
		}
		set
		{
			if (!string.Equals(_Estado, value))
			{
				SendPropertyChanging();
				_Estado = value;
				SendPropertyChanged("Estado");
			}
		}
	}

	[Column(Storage = "_IdAlmacen", DbType = "Char(2)")]
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
				if (_Almacen.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdAlmacen = value;
				SendPropertyChanged("IdAlmacen");
			}
		}
	}

	[Column(Storage = "_IdTipoMovimiento", DbType = "Char(1)")]
	public char? IdTipoMovimiento
	{
		get
		{
			return _IdTipoMovimiento;
		}
		set
		{
			if (!_IdTipoMovimiento.Equals(value))
			{
				if (_TipoMovimiento.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdTipoMovimiento = value;
				SendPropertyChanged("IdTipoMovimiento");
			}
		}
	}

	[Column(Storage = "_IdTipodoc", DbType = "Char(2)")]
	public string IdTipodoc
	{
		get
		{
			return _IdTipodoc;
		}
		set
		{
			if (!string.Equals(_IdTipodoc, value))
			{
				if (_TipoMovimiento.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdTipodoc = value;
				SendPropertyChanged("IdTipodoc");
			}
		}
	}

	[Column(Storage = "_IdOrden", DbType = "Char(8)")]
	public string IdOrden
	{
		get
		{
			return _IdOrden;
		}
		set
		{
			if (!string.Equals(_IdOrden, value))
			{
				if (_OrdenCompra.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdOrden = value;
				SendPropertyChanged("IdOrden");
			}
		}
	}

	[Column(Storage = "_TipoOrden", DbType = "Char(1)")]
	public char? TipoOrden
	{
		get
		{
			return _TipoOrden;
		}
		set
		{
			if (!_TipoOrden.Equals(value))
			{
				if (_OrdenCompra.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_TipoOrden = value;
				SendPropertyChanged("TipoOrden");
			}
		}
	}

	[Column(Storage = "_Observaciones", DbType = "VarChar(120)")]
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

	[Association(Name = "Movimiento_Pedido_Despacho", Storage = "_Pedido_Despacho", ThisKey = "IdMovimiento", OtherKey = "IdDocumento")]
	public EntitySet<Pedido_Despacho> Pedido_Despacho
	{
		get
		{
			return _Pedido_Despacho;
		}
		set
		{
			_Pedido_Despacho.Assign(value);
		}
	}

	[Association(Name = "Movimiento_Deta_Movimiento", Storage = "_Deta_Movimiento", ThisKey = "IdMovimiento", OtherKey = "IdMovimiento")]
	public EntitySet<Deta_Movimiento> Deta_Movimiento
	{
		get
		{
			return _Deta_Movimiento;
		}
		set
		{
			_Deta_Movimiento.Assign(value);
		}
	}

	[Association(Name = "Almacen_Movimiento", Storage = "_Almacen", ThisKey = "IdAlmacen", OtherKey = "IdAlmacen", IsForeignKey = true)]
	public Almacen Almacen
	{
		get
		{
			return _Almacen.Entity;
		}
		set
		{
			Almacen previousValue = _Almacen.Entity;
			if (!object.Equals(previousValue, value) || !_Almacen.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_Almacen.Entity = null;
					previousValue.Movimiento.Remove(this);
				}
				_Almacen.Entity = value;
				if (value != null)
				{
					value.Movimiento.Add(this);
					_IdAlmacen = value.IdAlmacen;
				}
				else
				{
					_IdAlmacen = null;
				}
				SendPropertyChanged("Almacen");
			}
		}
	}

	[Association(Name = "OrdenCompra_Movimiento", Storage = "_OrdenCompra", ThisKey = "TipoOrden,IdOrden", OtherKey = "TipoOrden,IdOrden", IsForeignKey = true)]
	public OrdenCompra OrdenCompra
	{
		get
		{
			return _OrdenCompra.Entity;
		}
		set
		{
			OrdenCompra previousValue = _OrdenCompra.Entity;
			if (!object.Equals(previousValue, value) || !_OrdenCompra.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_OrdenCompra.Entity = null;
					previousValue.Movimiento.Remove(this);
				}
				_OrdenCompra.Entity = value;
				if (value != null)
				{
					value.Movimiento.Add(this);
					_TipoOrden = value.TipoOrden;
					_IdOrden = value.IdOrden;
				}
				else
				{
					_TipoOrden = null;
					_IdOrden = null;
				}
				SendPropertyChanged("OrdenCompra");
			}
		}
	}

	[Association(Name = "TipoMovimiento_Movimiento", Storage = "_TipoMovimiento", ThisKey = "IdTipoMovimiento,IdTipodoc", OtherKey = "IdTipoMovimiento,IdTipodoc", IsForeignKey = true)]
	public TipoMovimiento TipoMovimiento
	{
		get
		{
			return _TipoMovimiento.Entity;
		}
		set
		{
			TipoMovimiento previousValue = _TipoMovimiento.Entity;
			if (!object.Equals(previousValue, value) || !_TipoMovimiento.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_TipoMovimiento.Entity = null;
					previousValue.Movimiento.Remove(this);
				}
				_TipoMovimiento.Entity = value;
				if (value != null)
				{
					value.Movimiento.Add(this);
					_IdTipoMovimiento = value.IdTipoMovimiento;
					_IdTipodoc = value.IdTipodoc;
				}
				else
				{
					_IdTipoMovimiento = null;
					_IdTipodoc = null;
				}
				SendPropertyChanged("TipoMovimiento");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Movimiento()
	{
		_Pedido_Despacho = new EntitySet<Pedido_Despacho>(attach_Pedido_Despacho, detach_Pedido_Despacho);
		_Deta_Movimiento = new EntitySet<Deta_Movimiento>(attach_Deta_Movimiento, detach_Deta_Movimiento);
		_Almacen = default(EntityRef<Almacen>);
		_OrdenCompra = default(EntityRef<OrdenCompra>);
		_TipoMovimiento = default(EntityRef<TipoMovimiento>);
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

	private void attach_Pedido_Despacho(Pedido_Despacho entity)
	{
		SendPropertyChanging();
		entity.Movimiento = this;
	}

	private void detach_Pedido_Despacho(Pedido_Despacho entity)
	{
		SendPropertyChanging();
		entity.Movimiento = null;
	}

	private void attach_Deta_Movimiento(Deta_Movimiento entity)
	{
		SendPropertyChanging();
		entity.Movimiento = this;
	}

	private void detach_Deta_Movimiento(Deta_Movimiento entity)
	{
		SendPropertyChanging();
		entity.Movimiento = null;
	}
}
