using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Consolidado")]
public class Consolidado : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _IdConsolidado;

	private string _Anio;

	private DateTime? _Fecha;

	private DateTime? _FechaRemitido;

	private DateTime? _FechaAdjudicacion;

	private string _TipoAdjudicacion;

	private string _IdSeleccion;

	private string _Estado;

	private string _Observaciones;

	private int? _IdEmpleado;

	private string _ReferenciaAjudica;

	private EntitySet<Cotizacion> _Cotizacion;

	private EntitySet<Deta_Consolidado> _Deta_Consolidado;

	private EntitySet<OrdenCompra> _OrdenCompra;

	private EntitySet<Deta_Pedido> _Deta_Pedido;

	private EntityRef<TipoAdjudicacion> _TipoAdjudicacion1;

	[Column(Storage = "_IdConsolidado", DbType = "Char(6) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
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
				SendPropertyChanging();
				_IdConsolidado = value;
				SendPropertyChanged("IdConsolidado");
			}
		}
	}

	[Column(Storage = "_Anio", DbType = "Char(4)")]
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

	[Column(Storage = "_FechaRemitido", DbType = "DateTime")]
	public DateTime? FechaRemitido
	{
		get
		{
			return _FechaRemitido;
		}
		set
		{
			if (!_FechaRemitido.Equals(value))
			{
				SendPropertyChanging();
				_FechaRemitido = value;
				SendPropertyChanged("FechaRemitido");
			}
		}
	}

	[Column(Storage = "_FechaAdjudicacion", DbType = "DateTime")]
	public DateTime? FechaAdjudicacion
	{
		get
		{
			return _FechaAdjudicacion;
		}
		set
		{
			if (!_FechaAdjudicacion.Equals(value))
			{
				SendPropertyChanging();
				_FechaAdjudicacion = value;
				SendPropertyChanged("FechaAdjudicacion");
			}
		}
	}

	[Column(Storage = "_TipoAdjudicacion", DbType = "Char(6)")]
	public string TipoAdjudicacion
	{
		get
		{
			return _TipoAdjudicacion;
		}
		set
		{
			if (!string.Equals(_TipoAdjudicacion, value))
			{
				if (_TipoAdjudicacion1.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_TipoAdjudicacion = value;
				SendPropertyChanged("TipoAdjudicacion");
			}
		}
	}

	[Column(Storage = "_IdSeleccion", DbType = "Char(8)")]
	public string IdSeleccion
	{
		get
		{
			return _IdSeleccion;
		}
		set
		{
			if (!string.Equals(_IdSeleccion, value))
			{
				SendPropertyChanging();
				_IdSeleccion = value;
				SendPropertyChanged("IdSeleccion");
			}
		}
	}

	[Column(Storage = "_Estado", DbType = "Char(2)")]
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

	[Column(Storage = "_Observaciones", DbType = "VarChar(150)")]
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

	[Column(Storage = "_ReferenciaAjudica", DbType = "VarChar(100)")]
	public string ReferenciaAjudica
	{
		get
		{
			return _ReferenciaAjudica;
		}
		set
		{
			if (!string.Equals(_ReferenciaAjudica, value))
			{
				SendPropertyChanging();
				_ReferenciaAjudica = value;
				SendPropertyChanged("ReferenciaAjudica");
			}
		}
	}

	[Association(Name = "Consolidado_Cotizacion", Storage = "_Cotizacion", ThisKey = "IdConsolidado", OtherKey = "IdConsolidado")]
	public EntitySet<Cotizacion> Cotizacion
	{
		get
		{
			return _Cotizacion;
		}
		set
		{
			_Cotizacion.Assign(value);
		}
	}

	[Association(Name = "Consolidado_Deta_Consolidado", Storage = "_Deta_Consolidado", ThisKey = "IdConsolidado", OtherKey = "IdConsolidado")]
	public EntitySet<Deta_Consolidado> Deta_Consolidado
	{
		get
		{
			return _Deta_Consolidado;
		}
		set
		{
			_Deta_Consolidado.Assign(value);
		}
	}

	[Association(Name = "Consolidado_OrdenCompra", Storage = "_OrdenCompra", ThisKey = "IdConsolidado", OtherKey = "IdConsolidado")]
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

	[Association(Name = "Consolidado_Deta_Pedido", Storage = "_Deta_Pedido", ThisKey = "IdConsolidado", OtherKey = "IdConsolidado")]
	public EntitySet<Deta_Pedido> Deta_Pedido
	{
		get
		{
			return _Deta_Pedido;
		}
		set
		{
			_Deta_Pedido.Assign(value);
		}
	}

	[Association(Name = "TipoAdjudicacion_Consolidado", Storage = "_TipoAdjudicacion1", ThisKey = "TipoAdjudicacion", OtherKey = "TipoAdjudicacion", IsForeignKey = true)]
	public TipoAdjudicacion TipoAdjudicacion1
	{
		get
		{
			return _TipoAdjudicacion1.Entity;
		}
		set
		{
			TipoAdjudicacion previousValue = _TipoAdjudicacion1.Entity;
			if (!object.Equals(previousValue, value) || !_TipoAdjudicacion1.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_TipoAdjudicacion1.Entity = null;
					previousValue.Consolidado.Remove(this);
				}
				_TipoAdjudicacion1.Entity = value;
				if (value != null)
				{
					value.Consolidado.Add(this);
					_TipoAdjudicacion = value.TipoAdjudicacionValue;
				}
				else
				{
					_TipoAdjudicacion = null;
				}
				SendPropertyChanged("TipoAdjudicacion1");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Consolidado()
	{
		_Cotizacion = new EntitySet<Cotizacion>(attach_Cotizacion, detach_Cotizacion);
		_Deta_Consolidado = new EntitySet<Deta_Consolidado>(attach_Deta_Consolidado, detach_Deta_Consolidado);
		_OrdenCompra = new EntitySet<OrdenCompra>(attach_OrdenCompra, detach_OrdenCompra);
		_Deta_Pedido = new EntitySet<Deta_Pedido>(attach_Deta_Pedido, detach_Deta_Pedido);
		_TipoAdjudicacion1 = default(EntityRef<TipoAdjudicacion>);
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

	private void attach_Cotizacion(Cotizacion entity)
	{
		SendPropertyChanging();
		entity.Consolidado = this;
	}

	private void detach_Cotizacion(Cotizacion entity)
	{
		SendPropertyChanging();
		entity.Consolidado = null;
	}

	private void attach_Deta_Consolidado(Deta_Consolidado entity)
	{
		SendPropertyChanging();
		entity.Consolidado = this;
	}

	private void detach_Deta_Consolidado(Deta_Consolidado entity)
	{
		SendPropertyChanging();
		entity.Consolidado = null;
	}

	private void attach_OrdenCompra(OrdenCompra entity)
	{
		SendPropertyChanging();
		entity.Consolidado = this;
	}

	private void detach_OrdenCompra(OrdenCompra entity)
	{
		SendPropertyChanging();
		entity.Consolidado = null;
	}

	private void attach_Deta_Pedido(Deta_Pedido entity)
	{
		SendPropertyChanging();
		entity.Consolidado = this;
	}

	private void detach_Deta_Pedido(Deta_Pedido entity)
	{
		SendPropertyChanging();
		entity.Consolidado = null;
	}
}
