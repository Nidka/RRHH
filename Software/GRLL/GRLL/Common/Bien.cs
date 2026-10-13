using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Bien")]
public class Bien : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _IdBien;

	private string _Descripcion;

	private string _Observaciones;

	private char? _Estado;

	private string _IdUnidadMedida;

	private decimal? _PrecioRef;

	private DateTime? _FechaRef;

	private string _IdFamilia;

	private string _IdClase;

	private string _IdGrupo;

	private char? _Tipo;

	private string _Unidad;

	private char? _EsActivoFijo;

	private EntitySet<Almacen_Bien> _Almacen_Bien;

	private EntitySet<Deta_Cotizacion> _Deta_Cotizacion;

	private EntitySet<Proveedor_Bien> _Proveedor_Bien;

	private EntitySet<ReqXProgMes> _ReqXProgMes;

	private EntitySet<Deta_Movimiento> _Deta_Movimiento;

	private EntitySet<Deta_Pedido> _Deta_Pedido;

	private EntityRef<Familia> _Familia;

	private EntityRef<UnidadMedida> _UnidadMedida;

	[Column(Storage = "_IdBien", DbType = "Char(13) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdBien
	{
		get
		{
			return _IdBien;
		}
		set
		{
			if (!string.Equals(_IdBien, value))
			{
				SendPropertyChanging();
				_IdBien = value;
				SendPropertyChanged("IdBien");
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

	[Column(Storage = "_Estado", DbType = "Char(1)")]
	public char? Estado
	{
		get
		{
			return _Estado;
		}
		set
		{
			if (!_Estado.Equals(value))
			{
				SendPropertyChanging();
				_Estado = value;
				SendPropertyChanged("Estado");
			}
		}
	}

	[Column(Storage = "_IdUnidadMedida", DbType = "Char(4)")]
	public string IdUnidadMedida
	{
		get
		{
			return _IdUnidadMedida;
		}
		set
		{
			if (!string.Equals(_IdUnidadMedida, value))
			{
				if (_UnidadMedida.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdUnidadMedida = value;
				SendPropertyChanged("IdUnidadMedida");
			}
		}
	}

	[Column(Storage = "_PrecioRef", DbType = "Decimal(9,2)")]
	public decimal? PrecioRef
	{
		get
		{
			return _PrecioRef;
		}
		set
		{
			if (!_PrecioRef.Equals(value))
			{
				SendPropertyChanging();
				_PrecioRef = value;
				SendPropertyChanged("PrecioRef");
			}
		}
	}

	[Column(Storage = "_FechaRef", DbType = "DateTime")]
	public DateTime? FechaRef
	{
		get
		{
			return _FechaRef;
		}
		set
		{
			if (!_FechaRef.Equals(value))
			{
				SendPropertyChanging();
				_FechaRef = value;
				SendPropertyChanged("FechaRef");
			}
		}
	}

	[Column(Storage = "_IdFamilia", DbType = "Char(4)")]
	public string IdFamilia
	{
		get
		{
			return _IdFamilia;
		}
		set
		{
			if (!string.Equals(_IdFamilia, value))
			{
				if (_Familia.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdFamilia = value;
				SendPropertyChanged("IdFamilia");
			}
		}
	}

	[Column(Storage = "_IdClase", DbType = "Char(2)")]
	public string IdClase
	{
		get
		{
			return _IdClase;
		}
		set
		{
			if (!string.Equals(_IdClase, value))
			{
				if (_Familia.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdClase = value;
				SendPropertyChanged("IdClase");
			}
		}
	}

	[Column(Storage = "_IdGrupo", DbType = "Char(3)")]
	public string IdGrupo
	{
		get
		{
			return _IdGrupo;
		}
		set
		{
			if (!string.Equals(_IdGrupo, value))
			{
				if (_Familia.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdGrupo = value;
				SendPropertyChanged("IdGrupo");
			}
		}
	}

	[Column(Storage = "_Tipo", DbType = "Char(1)")]
	public char? Tipo
	{
		get
		{
			return _Tipo;
		}
		set
		{
			if (!_Tipo.Equals(value))
			{
				SendPropertyChanging();
				_Tipo = value;
				SendPropertyChanged("Tipo");
			}
		}
	}

	[Column(Storage = "_Unidad", DbType = "Char(4)")]
	public string Unidad
	{
		get
		{
			return _Unidad;
		}
		set
		{
			if (!string.Equals(_Unidad, value))
			{
				SendPropertyChanging();
				_Unidad = value;
				SendPropertyChanged("Unidad");
			}
		}
	}

	[Column(Storage = "_EsActivoFijo", DbType = "Char(1)")]
	public char? EsActivoFijo
	{
		get
		{
			return _EsActivoFijo;
		}
		set
		{
			if (!_EsActivoFijo.Equals(value))
			{
				SendPropertyChanging();
				_EsActivoFijo = value;
				SendPropertyChanged("EsActivoFijo");
			}
		}
	}

	[Association(Name = "Bien_Almacen_Bien", Storage = "_Almacen_Bien", ThisKey = "IdBien", OtherKey = "IdBien")]
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

	[Association(Name = "Bien_Deta_Cotizacion", Storage = "_Deta_Cotizacion", ThisKey = "IdBien", OtherKey = "IdBien")]
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

	[Association(Name = "Bien_Proveedor_Bien", Storage = "_Proveedor_Bien", ThisKey = "IdBien", OtherKey = "IdBien")]
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

	[Association(Name = "Bien_ReqXProgMes", Storage = "_ReqXProgMes", ThisKey = "IdBien", OtherKey = "IdBien")]
	public EntitySet<ReqXProgMes> ReqXProgMes
	{
		get
		{
			return _ReqXProgMes;
		}
		set
		{
			_ReqXProgMes.Assign(value);
		}
	}

	[Association(Name = "Bien_Deta_Movimiento", Storage = "_Deta_Movimiento", ThisKey = "IdBien", OtherKey = "IdBien")]
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

	[Association(Name = "Bien_Deta_Pedido", Storage = "_Deta_Pedido", ThisKey = "IdBien", OtherKey = "IdBien")]
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

	[Association(Name = "Familia_Bien", Storage = "_Familia", ThisKey = "IdFamilia,IdClase,IdGrupo", OtherKey = "IdFamilia,IdClase,IdGrupo", IsForeignKey = true, DeleteRule = "CASCADE")]
	public Familia Familia
	{
		get
		{
			return _Familia.Entity;
		}
		set
		{
			Familia previousValue = _Familia.Entity;
			if (!object.Equals(previousValue, value) || !_Familia.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_Familia.Entity = null;
					previousValue.Bien.Remove(this);
				}
				_Familia.Entity = value;
				if (value != null)
				{
					value.Bien.Add(this);
					_IdFamilia = value.IdFamilia;
					_IdClase = value.IdClase;
					_IdGrupo = value.IdGrupo;
				}
				else
				{
					_IdFamilia = null;
					_IdClase = null;
					_IdGrupo = null;
				}
				SendPropertyChanged("Familia");
			}
		}
	}

	[Association(Name = "UnidadMedida_Bien", Storage = "_UnidadMedida", ThisKey = "IdUnidadMedida", OtherKey = "IdUnidadMedida", IsForeignKey = true, DeleteRule = "CASCADE")]
	public UnidadMedida UnidadMedida
	{
		get
		{
			return _UnidadMedida.Entity;
		}
		set
		{
			UnidadMedida previousValue = _UnidadMedida.Entity;
			if (!object.Equals(previousValue, value) || !_UnidadMedida.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_UnidadMedida.Entity = null;
					previousValue.Bien.Remove(this);
				}
				_UnidadMedida.Entity = value;
				if (value != null)
				{
					value.Bien.Add(this);
					_IdUnidadMedida = value.IdUnidadMedida;
				}
				else
				{
					_IdUnidadMedida = null;
				}
				SendPropertyChanged("UnidadMedida");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Bien()
	{
		_Almacen_Bien = new EntitySet<Almacen_Bien>(attach_Almacen_Bien, detach_Almacen_Bien);
		_Deta_Cotizacion = new EntitySet<Deta_Cotizacion>(attach_Deta_Cotizacion, detach_Deta_Cotizacion);
		_Proveedor_Bien = new EntitySet<Proveedor_Bien>(attach_Proveedor_Bien, detach_Proveedor_Bien);
		_ReqXProgMes = new EntitySet<ReqXProgMes>(attach_ReqXProgMes, detach_ReqXProgMes);
		_Deta_Movimiento = new EntitySet<Deta_Movimiento>(attach_Deta_Movimiento, detach_Deta_Movimiento);
		_Deta_Pedido = new EntitySet<Deta_Pedido>(attach_Deta_Pedido, detach_Deta_Pedido);
		_Familia = default(EntityRef<Familia>);
		_UnidadMedida = default(EntityRef<UnidadMedida>);
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
		entity.Bien = this;
	}

	private void detach_Almacen_Bien(Almacen_Bien entity)
	{
		SendPropertyChanging();
		entity.Bien = null;
	}

	private void attach_Deta_Cotizacion(Deta_Cotizacion entity)
	{
		SendPropertyChanging();
		entity.Bien = this;
	}

	private void detach_Deta_Cotizacion(Deta_Cotizacion entity)
	{
		SendPropertyChanging();
		entity.Bien = null;
	}

	private void attach_Proveedor_Bien(Proveedor_Bien entity)
	{
		SendPropertyChanging();
		entity.Bien = this;
	}

	private void detach_Proveedor_Bien(Proveedor_Bien entity)
	{
		SendPropertyChanging();
		entity.Bien = null;
	}

	private void attach_ReqXProgMes(ReqXProgMes entity)
	{
		SendPropertyChanging();
		entity.Bien = this;
	}

	private void detach_ReqXProgMes(ReqXProgMes entity)
	{
		SendPropertyChanging();
		entity.Bien = null;
	}

	private void attach_Deta_Movimiento(Deta_Movimiento entity)
	{
		SendPropertyChanging();
		entity.Bien = this;
	}

	private void detach_Deta_Movimiento(Deta_Movimiento entity)
	{
		SendPropertyChanging();
		entity.Bien = null;
	}

	private void attach_Deta_Pedido(Deta_Pedido entity)
	{
		SendPropertyChanging();
		entity.Bien = this;
	}

	private void detach_Deta_Pedido(Deta_Pedido entity)
	{
		SendPropertyChanging();
		entity.Bien = null;
	}
}
