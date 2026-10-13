using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Proveedor")]
public class Proveedor : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _IdProveedor;

	private int? _IdPersona;

	private string _RazonSocial;

	private string _NombreComercial;

	private string _RepresentanteLegal;

	private string _Estado;

	private string _CodigoCIU;

	private string _Rubro;

	private int? _EstadoSunat;

	private bool? _Factura;

	private bool? _Boleta;

	private bool? _ReciboHon;

	private string _Observaciones;

	private EntitySet<Cotizacion> _Cotizacion;

	private EntitySet<OrdenCompra> _OrdenCompra;

	private EntitySet<Proveedor_Bien> _Proveedor_Bien;

	private EntityRef<Persona> _Persona;

	private EntityRef<EstadoSunat> _EstadoSunat1;

	private EntityRef<PersonaSunat> _PersonaSunat;

	[Column(Storage = "_IdProveedor", DbType = "Char(11) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
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
				SendPropertyChanging();
				_IdProveedor = value;
				SendPropertyChanged("IdProveedor");
			}
		}
	}

	[Column(Storage = "_IdPersona", DbType = "Int")]
	public int? IdPersona
	{
		get
		{
			return _IdPersona;
		}
		set
		{
			if (!_IdPersona.Equals(value))
			{
				if (_Persona.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdPersona = value;
				SendPropertyChanged("IdPersona");
			}
		}
	}

	[Column(Storage = "_RazonSocial", DbType = "VarChar(100)")]
	public string RazonSocial
	{
		get
		{
			return _RazonSocial;
		}
		set
		{
			if (!string.Equals(_RazonSocial, value))
			{
				SendPropertyChanging();
				_RazonSocial = value;
				SendPropertyChanged("RazonSocial");
			}
		}
	}

	[Column(Storage = "_NombreComercial", DbType = "VarChar(60)")]
	public string NombreComercial
	{
		get
		{
			return _NombreComercial;
		}
		set
		{
			if (!string.Equals(_NombreComercial, value))
			{
				SendPropertyChanging();
				_NombreComercial = value;
				SendPropertyChanged("NombreComercial");
			}
		}
	}

	[Column(Storage = "_RepresentanteLegal", DbType = "VarChar(60)")]
	public string RepresentanteLegal
	{
		get
		{
			return _RepresentanteLegal;
		}
		set
		{
			if (!string.Equals(_RepresentanteLegal, value))
			{
				SendPropertyChanging();
				_RepresentanteLegal = value;
				SendPropertyChanged("RepresentanteLegal");
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

	[Column(Storage = "_CodigoCIU", DbType = "Char(10)")]
	public string CodigoCIU
	{
		get
		{
			return _CodigoCIU;
		}
		set
		{
			if (!string.Equals(_CodigoCIU, value))
			{
				SendPropertyChanging();
				_CodigoCIU = value;
				SendPropertyChanged("CodigoCIU");
			}
		}
	}

	[Column(Storage = "_Rubro", DbType = "Char(9)")]
	public string Rubro
	{
		get
		{
			return _Rubro;
		}
		set
		{
			if (!string.Equals(_Rubro, value))
			{
				SendPropertyChanging();
				_Rubro = value;
				SendPropertyChanged("Rubro");
			}
		}
	}

	[Column(Storage = "_EstadoSunat", DbType = "Int")]
	public int? EstadoSunat
	{
		get
		{
			return _EstadoSunat;
		}
		set
		{
			if (!_EstadoSunat.Equals(value))
			{
				if (_EstadoSunat1.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_EstadoSunat = value;
				SendPropertyChanged("EstadoSunat");
			}
		}
	}

	[Column(Storage = "_Factura", DbType = "Bit")]
	public bool? Factura
	{
		get
		{
			return _Factura;
		}
		set
		{
			if (!_Factura.Equals(value))
			{
				SendPropertyChanging();
				_Factura = value;
				SendPropertyChanged("Factura");
			}
		}
	}

	[Column(Storage = "_Boleta", DbType = "Bit")]
	public bool? Boleta
	{
		get
		{
			return _Boleta;
		}
		set
		{
			if (!_Boleta.Equals(value))
			{
				SendPropertyChanging();
				_Boleta = value;
				SendPropertyChanged("Boleta");
			}
		}
	}

	[Column(Storage = "_ReciboHon", DbType = "Bit")]
	public bool? ReciboHon
	{
		get
		{
			return _ReciboHon;
		}
		set
		{
			if (!_ReciboHon.Equals(value))
			{
				SendPropertyChanging();
				_ReciboHon = value;
				SendPropertyChanged("ReciboHon");
			}
		}
	}

	[Column(Storage = "_Observaciones", DbType = "VarChar(100)")]
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

	[Association(Name = "Proveedor_Cotizacion", Storage = "_Cotizacion", ThisKey = "IdProveedor", OtherKey = "IdProveedor")]
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

	[Association(Name = "Proveedor_OrdenCompra", Storage = "_OrdenCompra", ThisKey = "IdProveedor", OtherKey = "IdProveedor")]
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

	[Association(Name = "Proveedor_Proveedor_Bien", Storage = "_Proveedor_Bien", ThisKey = "IdProveedor", OtherKey = "IdProveedor")]
	public EntitySet<Proveedor_Bien> Proveedor_Bien
	{
		get
		{
			return _Proveedor_Bien;
		}
		set
		{
			_Proveedor_Bien.Assign(value);
		}
	}

	[Association(Name = "Persona_Proveedor", Storage = "_Persona", ThisKey = "IdPersona", OtherKey = "IdPersona", IsForeignKey = true)]
	public Persona Persona
	{
		get
		{
			return _Persona.Entity;
		}
		set
		{
			Persona previousValue = _Persona.Entity;
			if (!object.Equals(previousValue, value) || !_Persona.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_Persona.Entity = null;
					previousValue.Proveedor.Remove(this);
				}
				_Persona.Entity = value;
				if (value != null)
				{
					value.Proveedor.Add(this);
					_IdPersona = value.IdPersona;
				}
				else
				{
					_IdPersona = null;
				}
				SendPropertyChanged("Persona");
			}
		}
	}

	[Association(Name = "EstadoSunat_Proveedor", Storage = "_EstadoSunat1", ThisKey = "EstadoSunat", OtherKey = "EstadoSunat", IsForeignKey = true)]
	public EstadoSunat EstadoSunat1
	{
		get
		{
			return _EstadoSunat1.Entity;
		}
		set
		{
			EstadoSunat previousValue = _EstadoSunat1.Entity;
			if (!object.Equals(previousValue, value) || !_EstadoSunat1.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_EstadoSunat1.Entity = null;
					previousValue.Proveedor.Remove(this);
				}
				_EstadoSunat1.Entity = value;
				if (value != null)
				{
					value.Proveedor.Add(this);
					_EstadoSunat = value.EstadoSunatValue;
				}
				else
				{
					_EstadoSunat = null;
				}
				SendPropertyChanged("EstadoSunat1");
			}
		}
	}

	[Association(Name = "PersonaSunat_Proveedor", Storage = "_PersonaSunat", ThisKey = "EstadoSunat", OtherKey = "IdPersonaSunat", IsForeignKey = true)]
	public PersonaSunat PersonaSunat
	{
		get
		{
			return _PersonaSunat.Entity;
		}
		set
		{
			PersonaSunat previousValue = _PersonaSunat.Entity;
			if (!object.Equals(previousValue, value) || !_PersonaSunat.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_PersonaSunat.Entity = null;
					previousValue.Proveedor.Remove(this);
				}
				_PersonaSunat.Entity = value;
				if (value != null)
				{
					value.Proveedor.Add(this);
					_EstadoSunat = value.IdPersonaSunat;
				}
				else
				{
					_EstadoSunat = null;
				}
				SendPropertyChanged("PersonaSunat");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Proveedor()
	{
		_Cotizacion = new EntitySet<Cotizacion>(attach_Cotizacion, detach_Cotizacion);
		_OrdenCompra = new EntitySet<OrdenCompra>(attach_OrdenCompra, detach_OrdenCompra);
		_Proveedor_Bien = new EntitySet<Proveedor_Bien>(attach_Proveedor_Bien, detach_Proveedor_Bien);
		_Persona = default(EntityRef<Persona>);
		_EstadoSunat1 = default(EntityRef<EstadoSunat>);
		_PersonaSunat = default(EntityRef<PersonaSunat>);
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
		entity.Proveedor = this;
	}

	private void detach_Cotizacion(Cotizacion entity)
	{
		SendPropertyChanging();
		entity.Proveedor = null;
	}

	private void attach_OrdenCompra(OrdenCompra entity)
	{
		SendPropertyChanging();
		entity.Proveedor = this;
	}

	private void detach_OrdenCompra(OrdenCompra entity)
	{
		SendPropertyChanging();
		entity.Proveedor = null;
	}

	private void attach_Proveedor_Bien(Proveedor_Bien entity)
	{
		SendPropertyChanging();
		entity.Proveedor = this;
	}

	private void detach_Proveedor_Bien(Proveedor_Bien entity)
	{
		SendPropertyChanging();
		entity.Proveedor = null;
	}
}
