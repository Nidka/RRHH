using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.OrdenCompra")]
public class OrdenCompra : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private char _TipoOrden;

	private string _IdOrden;

	private DateTime? _Fecha;

	private DateTime? _FechaRecepcion;

	private DateTime? _FechaEntrega;

	private int? _PlazoEntrega;

	private string _IdFinanciamiento;

	private string _IdTipoRecurso;

	private string _CodigoSIAF;

	private string _IdContrato;

	private DateTime? _FechaContrato;

	private string _NumSeleccion;

	private DateTime? _FechaSeleccion;

	private string _IdProveedor;

	private string _IdFormaPago;

	private char? _IdMoneda;

	private decimal? _TipoCambio;

	private string _Asunto;

	private string _Uso;

	private decimal? _Monto;

	private string _Estado;

	private string _Observaciones;

	private string _IdConsolidado;

	private string _IdAlmacen;

	private string _Referencia;

	private DateTime? _FechaAnulacion;

	private string _TREG;

	private string _TipoDocAdj;

	private string _NroDocAdj;

	private EntitySet<Movimiento> _Movimiento;

	private EntitySet<Deta_Orden> _Deta_Orden;

	private EntityRef<Almacen> _Almacen;

	private EntityRef<Consolidado> _Consolidado;

	private EntityRef<Contrato> _Contrato;

	private EntityRef<Financiamiento> _Financiamiento;

	private EntityRef<Proveedor> _Proveedor;

	[Column(Storage = "_TipoOrden", DbType = "Char(1) NOT NULL", IsPrimaryKey = true)]
	public char TipoOrden
	{
		get
		{
			return _TipoOrden;
		}
		set
		{
			if (_TipoOrden != value)
			{
				SendPropertyChanging();
				_TipoOrden = value;
				SendPropertyChanged("TipoOrden");
			}
		}
	}

	[Column(Storage = "_IdOrden", DbType = "Char(8) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
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
				SendPropertyChanging();
				_IdOrden = value;
				SendPropertyChanged("IdOrden");
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

	[Column(Storage = "_FechaRecepcion", DbType = "DateTime")]
	public DateTime? FechaRecepcion
	{
		get
		{
			return _FechaRecepcion;
		}
		set
		{
			if (!_FechaRecepcion.Equals(value))
			{
				SendPropertyChanging();
				_FechaRecepcion = value;
				SendPropertyChanged("FechaRecepcion");
			}
		}
	}

	[Column(Storage = "_FechaEntrega", DbType = "DateTime")]
	public DateTime? FechaEntrega
	{
		get
		{
			return _FechaEntrega;
		}
		set
		{
			if (!_FechaEntrega.Equals(value))
			{
				SendPropertyChanging();
				_FechaEntrega = value;
				SendPropertyChanged("FechaEntrega");
			}
		}
	}

	[Column(Storage = "_PlazoEntrega", DbType = "Int")]
	public int? PlazoEntrega
	{
		get
		{
			return _PlazoEntrega;
		}
		set
		{
			if (!_PlazoEntrega.Equals(value))
			{
				SendPropertyChanging();
				_PlazoEntrega = value;
				SendPropertyChanged("PlazoEntrega");
			}
		}
	}

	[Column(Storage = "_IdFinanciamiento", DbType = "Char(2)")]
	public string IdFinanciamiento
	{
		get
		{
			return _IdFinanciamiento;
		}
		set
		{
			if (!string.Equals(_IdFinanciamiento, value))
			{
				if (_Financiamiento.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdFinanciamiento = value;
				SendPropertyChanged("IdFinanciamiento");
			}
		}
	}

	[Column(Storage = "_IdTipoRecurso", DbType = "Char(3)")]
	public string IdTipoRecurso
	{
		get
		{
			return _IdTipoRecurso;
		}
		set
		{
			if (!string.Equals(_IdTipoRecurso, value))
			{
				SendPropertyChanging();
				_IdTipoRecurso = value;
				SendPropertyChanged("IdTipoRecurso");
			}
		}
	}

	[Column(Storage = "_CodigoSIAF", DbType = "Char(6)")]
	public string CodigoSIAF
	{
		get
		{
			return _CodigoSIAF;
		}
		set
		{
			if (!string.Equals(_CodigoSIAF, value))
			{
				SendPropertyChanging();
				_CodigoSIAF = value;
				SendPropertyChanged("CodigoSIAF");
			}
		}
	}

	[Column(Storage = "_IdContrato", DbType = "Char(8)")]
	public string IdContrato
	{
		get
		{
			return _IdContrato;
		}
		set
		{
			if (!string.Equals(_IdContrato, value))
			{
				if (_Contrato.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdContrato = value;
				SendPropertyChanged("IdContrato");
			}
		}
	}

	[Column(Storage = "_FechaContrato", DbType = "DateTime")]
	public DateTime? FechaContrato
	{
		get
		{
			return _FechaContrato;
		}
		set
		{
			if (!_FechaContrato.Equals(value))
			{
				SendPropertyChanging();
				_FechaContrato = value;
				SendPropertyChanged("FechaContrato");
			}
		}
	}

	[Column(Storage = "_NumSeleccion", DbType = "Char(12)")]
	public string NumSeleccion
	{
		get
		{
			return _NumSeleccion;
		}
		set
		{
			if (!string.Equals(_NumSeleccion, value))
			{
				SendPropertyChanging();
				_NumSeleccion = value;
				SendPropertyChanged("NumSeleccion");
			}
		}
	}

	[Column(Storage = "_FechaSeleccion", DbType = "DateTime")]
	public DateTime? FechaSeleccion
	{
		get
		{
			return _FechaSeleccion;
		}
		set
		{
			if (!_FechaSeleccion.Equals(value))
			{
				SendPropertyChanging();
				_FechaSeleccion = value;
				SendPropertyChanged("FechaSeleccion");
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

	[Column(Storage = "_IdFormaPago", DbType = "Char(3)")]
	public string IdFormaPago
	{
		get
		{
			return _IdFormaPago;
		}
		set
		{
			if (!string.Equals(_IdFormaPago, value))
			{
				SendPropertyChanging();
				_IdFormaPago = value;
				SendPropertyChanged("IdFormaPago");
			}
		}
	}

	[Column(Storage = "_IdMoneda", DbType = "Char(1)")]
	public char? IdMoneda
	{
		get
		{
			return _IdMoneda;
		}
		set
		{
			if (!_IdMoneda.Equals(value))
			{
				SendPropertyChanging();
				_IdMoneda = value;
				SendPropertyChanged("IdMoneda");
			}
		}
	}

	[Column(Storage = "_TipoCambio", DbType = "Decimal(9,4)")]
	public decimal? TipoCambio
	{
		get
		{
			return _TipoCambio;
		}
		set
		{
			if (!_TipoCambio.Equals(value))
			{
				SendPropertyChanging();
				_TipoCambio = value;
				SendPropertyChanged("TipoCambio");
			}
		}
	}

	[Column(Storage = "_Asunto", DbType = "VarChar(120)")]
	public string Asunto
	{
		get
		{
			return _Asunto;
		}
		set
		{
			if (!string.Equals(_Asunto, value))
			{
				SendPropertyChanging();
				_Asunto = value;
				SendPropertyChanged("Asunto");
			}
		}
	}

	[Column(Storage = "_Uso", DbType = "VarChar(180)")]
	public string Uso
	{
		get
		{
			return _Uso;
		}
		set
		{
			if (!string.Equals(_Uso, value))
			{
				SendPropertyChanging();
				_Uso = value;
				SendPropertyChanged("Uso");
			}
		}
	}

	[Column(Storage = "_Monto", DbType = "Decimal(11,2)")]
	public decimal? Monto
	{
		get
		{
			return _Monto;
		}
		set
		{
			if (!_Monto.Equals(value))
			{
				SendPropertyChanging();
				_Monto = value;
				SendPropertyChanged("Monto");
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

	[Column(Storage = "_Observaciones", DbType = "VarChar(600)")]
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

	[Column(Storage = "_Referencia", DbType = "VarChar(150)")]
	public string Referencia
	{
		get
		{
			return _Referencia;
		}
		set
		{
			if (!string.Equals(_Referencia, value))
			{
				SendPropertyChanging();
				_Referencia = value;
				SendPropertyChanged("Referencia");
			}
		}
	}

	[Column(Storage = "_FechaAnulacion", DbType = "DateTime")]
	public DateTime? FechaAnulacion
	{
		get
		{
			return _FechaAnulacion;
		}
		set
		{
			if (!_FechaAnulacion.Equals(value))
			{
				SendPropertyChanging();
				_FechaAnulacion = value;
				SendPropertyChanged("FechaAnulacion");
			}
		}
	}

	[Column(Storage = "_TREG", DbType = "Char(8)")]
	public string TREG
	{
		get
		{
			return _TREG;
		}
		set
		{
			if (!string.Equals(_TREG, value))
			{
				SendPropertyChanging();
				_TREG = value;
				SendPropertyChanged("TREG");
			}
		}
	}

	[Column(Storage = "_TipoDocAdj", DbType = "VarChar(20)")]
	public string TipoDocAdj
	{
		get
		{
			return _TipoDocAdj;
		}
		set
		{
			if (!string.Equals(_TipoDocAdj, value))
			{
				SendPropertyChanging();
				_TipoDocAdj = value;
				SendPropertyChanged("TipoDocAdj");
			}
		}
	}

	[Column(Storage = "_NroDocAdj", DbType = "VarChar(20)")]
	public string NroDocAdj
	{
		get
		{
			return _NroDocAdj;
		}
		set
		{
			if (!string.Equals(_NroDocAdj, value))
			{
				SendPropertyChanging();
				_NroDocAdj = value;
				SendPropertyChanged("NroDocAdj");
			}
		}
	}

	[Association(Name = "OrdenCompra_Movimiento", Storage = "_Movimiento", ThisKey = "TipoOrden,IdOrden", OtherKey = "TipoOrden,IdOrden")]
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

	[Association(Name = "OrdenCompra_Deta_Orden", Storage = "_Deta_Orden", ThisKey = "TipoOrden,IdOrden", OtherKey = "TipoOrden,IdOrden")]
	public EntitySet<Deta_Orden> Deta_Orden
	{
		get
		{
			return _Deta_Orden;
		}
		set
		{
			_Deta_Orden.Assign(value);
		}
	}

	[Association(Name = "Almacen_OrdenCompra", Storage = "_Almacen", ThisKey = "IdAlmacen", OtherKey = "IdAlmacen", IsForeignKey = true)]
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
					previousValue.OrdenCompra.Remove(this);
				}
				_Almacen.Entity = value;
				if (value != null)
				{
					value.OrdenCompra.Add(this);
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

	[Association(Name = "Consolidado_OrdenCompra", Storage = "_Consolidado", ThisKey = "IdConsolidado", OtherKey = "IdConsolidado", IsForeignKey = true)]
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
					previousValue.OrdenCompra.Remove(this);
				}
				_Consolidado.Entity = value;
				if (value != null)
				{
					value.OrdenCompra.Add(this);
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

	[Association(Name = "Contrato_OrdenCompra", Storage = "_Contrato", ThisKey = "IdContrato", OtherKey = "IdContrato", IsForeignKey = true)]
	public Contrato Contrato
	{
		get
		{
			return _Contrato.Entity;
		}
		set
		{
			Contrato previousValue = _Contrato.Entity;
			if (!object.Equals(previousValue, value) || !_Contrato.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_Contrato.Entity = null;
					previousValue.OrdenCompra.Remove(this);
				}
				_Contrato.Entity = value;
				if (value != null)
				{
					value.OrdenCompra.Add(this);
					_IdContrato = value.IdContrato;
				}
				else
				{
					_IdContrato = null;
				}
				SendPropertyChanged("Contrato");
			}
		}
	}

	[Association(Name = "Financiamiento_OrdenCompra", Storage = "_Financiamiento", ThisKey = "IdFinanciamiento", OtherKey = "IdFinanciamiento", IsForeignKey = true)]
	public Financiamiento Financiamiento
	{
		get
		{
			return _Financiamiento.Entity;
		}
		set
		{
			Financiamiento previousValue = _Financiamiento.Entity;
			if (!object.Equals(previousValue, value) || !_Financiamiento.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_Financiamiento.Entity = null;
					previousValue.OrdenCompra.Remove(this);
				}
				_Financiamiento.Entity = value;
				if (value != null)
				{
					value.OrdenCompra.Add(this);
					_IdFinanciamiento = value.IdFinanciamiento;
				}
				else
				{
					_IdFinanciamiento = null;
				}
				SendPropertyChanged("Financiamiento");
			}
		}
	}

	[Association(Name = "Proveedor_OrdenCompra", Storage = "_Proveedor", ThisKey = "IdProveedor", OtherKey = "IdProveedor", IsForeignKey = true)]
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
					previousValue.OrdenCompra.Remove(this);
				}
				_Proveedor.Entity = value;
				if (value != null)
				{
					value.OrdenCompra.Add(this);
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

	public OrdenCompra()
	{
		_Movimiento = new EntitySet<Movimiento>(attach_Movimiento, detach_Movimiento);
		_Deta_Orden = new EntitySet<Deta_Orden>(attach_Deta_Orden, detach_Deta_Orden);
		_Almacen = default(EntityRef<Almacen>);
		_Consolidado = default(EntityRef<Consolidado>);
		_Contrato = default(EntityRef<Contrato>);
		_Financiamiento = default(EntityRef<Financiamiento>);
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

	private void attach_Movimiento(Movimiento entity)
	{
		SendPropertyChanging();
		entity.OrdenCompra = this;
	}

	private void detach_Movimiento(Movimiento entity)
	{
		SendPropertyChanging();
		entity.OrdenCompra = null;
	}

	private void attach_Deta_Orden(Deta_Orden entity)
	{
		SendPropertyChanging();
		entity.OrdenCompra = this;
	}

	private void detach_Deta_Orden(Deta_Orden entity)
	{
		SendPropertyChanging();
		entity.OrdenCompra = null;
	}
}
