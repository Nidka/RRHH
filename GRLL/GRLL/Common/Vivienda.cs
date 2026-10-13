using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Vivienda")]
public class Vivienda : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int? _IdEmpleado;

	private int _IdVivienda;

	private int? _IdTenencia;

	private int? _IdTipo;

	private int? _IdMaterial;

	private int? _IdConservacion;

	private string _NumDormitorio;

	private string _NumServHig;

	private int? _IdUbicacion;

	private int? _IdAlumbrado;

	private string _OtroAlumbrado;

	private int? _IdAgua;

	private string _OtroAgua;

	private int? _IdExcretas;

	private string _OtroExcreta;

	private string _NumCompart;

	private string _Observacion;

	private string _NumPerDorm;

	private bool? _Telefono;

	private bool? _Cable;

	private bool? _Internet;

	private bool? _Otros;

	private EntityRef<AguaViv> _AguaViv;

	private EntityRef<AlumbradoViv> _AlumbradoViv;

	private EntityRef<ConservacionViv> _ConservacionViv;

	private EntityRef<ExcretasViv> _ExcretasViv;

	private EntityRef<MaterialViv> _MaterialViv;

	private EntityRef<TenenciaViv> _TenenciaViv;

	private EntityRef<TipoViv> _TipoViv;

	private EntityRef<UbicacionViv> _UbicacionViv;

	private EntityRef<Empleado> _Empleado;

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
				if (_Empleado.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdEmpleado = value;
				SendPropertyChanged("IdEmpleado");
			}
		}
	}

	[Column(Storage = "_IdVivienda", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdVivienda
	{
		get
		{
			return _IdVivienda;
		}
		set
		{
			if (_IdVivienda != value)
			{
				SendPropertyChanging();
				_IdVivienda = value;
				SendPropertyChanged("IdVivienda");
			}
		}
	}

	[Column(Storage = "_IdTenencia", DbType = "Int")]
	public int? IdTenencia
	{
		get
		{
			return _IdTenencia;
		}
		set
		{
			if (!_IdTenencia.Equals(value))
			{
				if (_TenenciaViv.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdTenencia = value;
				SendPropertyChanged("IdTenencia");
			}
		}
	}

	[Column(Storage = "_IdTipo", DbType = "Int")]
	public int? IdTipo
	{
		get
		{
			return _IdTipo;
		}
		set
		{
			if (!_IdTipo.Equals(value))
			{
				if (_TipoViv.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdTipo = value;
				SendPropertyChanged("IdTipo");
			}
		}
	}

	[Column(Storage = "_IdMaterial", DbType = "Int")]
	public int? IdMaterial
	{
		get
		{
			return _IdMaterial;
		}
		set
		{
			if (!_IdMaterial.Equals(value))
			{
				if (_MaterialViv.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdMaterial = value;
				SendPropertyChanged("IdMaterial");
			}
		}
	}

	[Column(Storage = "_IdConservacion", DbType = "Int")]
	public int? IdConservacion
	{
		get
		{
			return _IdConservacion;
		}
		set
		{
			if (!_IdConservacion.Equals(value))
			{
				if (_ConservacionViv.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdConservacion = value;
				SendPropertyChanged("IdConservacion");
			}
		}
	}

	[Column(Storage = "_NumDormitorio", DbType = "VarChar(2)")]
	public string NumDormitorio
	{
		get
		{
			return _NumDormitorio;
		}
		set
		{
			if (!string.Equals(_NumDormitorio, value))
			{
				SendPropertyChanging();
				_NumDormitorio = value;
				SendPropertyChanged("NumDormitorio");
			}
		}
	}

	[Column(Storage = "_NumServHig", DbType = "VarChar(2)")]
	public string NumServHig
	{
		get
		{
			return _NumServHig;
		}
		set
		{
			if (!string.Equals(_NumServHig, value))
			{
				SendPropertyChanging();
				_NumServHig = value;
				SendPropertyChanged("NumServHig");
			}
		}
	}

	[Column(Storage = "_IdUbicacion", DbType = "Int")]
	public int? IdUbicacion
	{
		get
		{
			return _IdUbicacion;
		}
		set
		{
			if (!_IdUbicacion.Equals(value))
			{
				if (_UbicacionViv.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdUbicacion = value;
				SendPropertyChanged("IdUbicacion");
			}
		}
	}

	[Column(Storage = "_IdAlumbrado", DbType = "Int")]
	public int? IdAlumbrado
	{
		get
		{
			return _IdAlumbrado;
		}
		set
		{
			if (!_IdAlumbrado.Equals(value))
			{
				if (_AlumbradoViv.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdAlumbrado = value;
				SendPropertyChanged("IdAlumbrado");
			}
		}
	}

	[Column(Storage = "_OtroAlumbrado", DbType = "VarChar(50)")]
	public string OtroAlumbrado
	{
		get
		{
			return _OtroAlumbrado;
		}
		set
		{
			if (!string.Equals(_OtroAlumbrado, value))
			{
				SendPropertyChanging();
				_OtroAlumbrado = value;
				SendPropertyChanged("OtroAlumbrado");
			}
		}
	}

	[Column(Storage = "_IdAgua", DbType = "Int")]
	public int? IdAgua
	{
		get
		{
			return _IdAgua;
		}
		set
		{
			if (!_IdAgua.Equals(value))
			{
				if (_AguaViv.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdAgua = value;
				SendPropertyChanged("IdAgua");
			}
		}
	}

	[Column(Storage = "_OtroAgua", DbType = "VarChar(50)")]
	public string OtroAgua
	{
		get
		{
			return _OtroAgua;
		}
		set
		{
			if (!string.Equals(_OtroAgua, value))
			{
				SendPropertyChanging();
				_OtroAgua = value;
				SendPropertyChanged("OtroAgua");
			}
		}
	}

	[Column(Storage = "_IdExcretas", DbType = "Int")]
	public int? IdExcretas
	{
		get
		{
			return _IdExcretas;
		}
		set
		{
			if (!_IdExcretas.Equals(value))
			{
				if (_ExcretasViv.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdExcretas = value;
				SendPropertyChanged("IdExcretas");
			}
		}
	}

	[Column(Storage = "_OtroExcreta", DbType = "VarChar(50)")]
	public string OtroExcreta
	{
		get
		{
			return _OtroExcreta;
		}
		set
		{
			if (!string.Equals(_OtroExcreta, value))
			{
				SendPropertyChanging();
				_OtroExcreta = value;
				SendPropertyChanged("OtroExcreta");
			}
		}
	}

	[Column(Storage = "_NumCompart", DbType = "VarChar(2)")]
	public string NumCompart
	{
		get
		{
			return _NumCompart;
		}
		set
		{
			if (!string.Equals(_NumCompart, value))
			{
				SendPropertyChanging();
				_NumCompart = value;
				SendPropertyChanged("NumCompart");
			}
		}
	}

	[Column(Storage = "_Observacion", DbType = "VarChar(200)")]
	public string Observacion
	{
		get
		{
			return _Observacion;
		}
		set
		{
			if (!string.Equals(_Observacion, value))
			{
				SendPropertyChanging();
				_Observacion = value;
				SendPropertyChanged("Observacion");
			}
		}
	}

	[Column(Storage = "_NumPerDorm", DbType = "VarChar(2)")]
	public string NumPerDorm
	{
		get
		{
			return _NumPerDorm;
		}
		set
		{
			if (!string.Equals(_NumPerDorm, value))
			{
				SendPropertyChanging();
				_NumPerDorm = value;
				SendPropertyChanged("NumPerDorm");
			}
		}
	}

	[Column(Storage = "_Telefono", DbType = "Bit")]
	public bool? Telefono
	{
		get
		{
			return _Telefono;
		}
		set
		{
			if (!_Telefono.Equals(value))
			{
				SendPropertyChanging();
				_Telefono = value;
				SendPropertyChanged("Telefono");
			}
		}
	}

	[Column(Storage = "_Cable", DbType = "Bit")]
	public bool? Cable
	{
		get
		{
			return _Cable;
		}
		set
		{
			if (!_Cable.Equals(value))
			{
				SendPropertyChanging();
				_Cable = value;
				SendPropertyChanged("Cable");
			}
		}
	}

	[Column(Storage = "_Internet", DbType = "Bit")]
	public bool? Internet
	{
		get
		{
			return _Internet;
		}
		set
		{
			if (!_Internet.Equals(value))
			{
				SendPropertyChanging();
				_Internet = value;
				SendPropertyChanged("Internet");
			}
		}
	}

	[Column(Storage = "_Otros", DbType = "Bit")]
	public bool? Otros
	{
		get
		{
			return _Otros;
		}
		set
		{
			if (!_Otros.Equals(value))
			{
				SendPropertyChanging();
				_Otros = value;
				SendPropertyChanged("Otros");
			}
		}
	}

	[Association(Name = "AguaViv_Vivienda", Storage = "_AguaViv", ThisKey = "IdAgua", OtherKey = "IdAgua", IsForeignKey = true)]
	public AguaViv AguaViv
	{
		get
		{
			return _AguaViv.Entity;
		}
		set
		{
			AguaViv previousValue = _AguaViv.Entity;
			if (!object.Equals(previousValue, value) || !_AguaViv.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_AguaViv.Entity = null;
					previousValue.Vivienda.Remove(this);
				}
				_AguaViv.Entity = value;
				if (value != null)
				{
					value.Vivienda.Add(this);
					_IdAgua = value.IdAgua;
				}
				else
				{
					_IdAgua = null;
				}
				SendPropertyChanged("AguaViv");
			}
		}
	}

	[Association(Name = "AlumbradoViv_Vivienda", Storage = "_AlumbradoViv", ThisKey = "IdAlumbrado", OtherKey = "IdAlumbrado", IsForeignKey = true)]
	public AlumbradoViv AlumbradoViv
	{
		get
		{
			return _AlumbradoViv.Entity;
		}
		set
		{
			AlumbradoViv previousValue = _AlumbradoViv.Entity;
			if (!object.Equals(previousValue, value) || !_AlumbradoViv.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_AlumbradoViv.Entity = null;
					previousValue.Vivienda.Remove(this);
				}
				_AlumbradoViv.Entity = value;
				if (value != null)
				{
					value.Vivienda.Add(this);
					_IdAlumbrado = value.IdAlumbrado;
				}
				else
				{
					_IdAlumbrado = null;
				}
				SendPropertyChanged("AlumbradoViv");
			}
		}
	}

	[Association(Name = "ConservacionViv_Vivienda", Storage = "_ConservacionViv", ThisKey = "IdConservacion", OtherKey = "IdConservacion", IsForeignKey = true)]
	public ConservacionViv ConservacionViv
	{
		get
		{
			return _ConservacionViv.Entity;
		}
		set
		{
			ConservacionViv previousValue = _ConservacionViv.Entity;
			if (!object.Equals(previousValue, value) || !_ConservacionViv.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_ConservacionViv.Entity = null;
					previousValue.Vivienda.Remove(this);
				}
				_ConservacionViv.Entity = value;
				if (value != null)
				{
					value.Vivienda.Add(this);
					_IdConservacion = value.IdConservacion;
				}
				else
				{
					_IdConservacion = null;
				}
				SendPropertyChanged("ConservacionViv");
			}
		}
	}

	[Association(Name = "ExcretasViv_Vivienda", Storage = "_ExcretasViv", ThisKey = "IdExcretas", OtherKey = "IdExcretas", IsForeignKey = true)]
	public ExcretasViv ExcretasViv
	{
		get
		{
			return _ExcretasViv.Entity;
		}
		set
		{
			ExcretasViv previousValue = _ExcretasViv.Entity;
			if (!object.Equals(previousValue, value) || !_ExcretasViv.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_ExcretasViv.Entity = null;
					previousValue.Vivienda.Remove(this);
				}
				_ExcretasViv.Entity = value;
				if (value != null)
				{
					value.Vivienda.Add(this);
					_IdExcretas = value.IdExcretas;
				}
				else
				{
					_IdExcretas = null;
				}
				SendPropertyChanged("ExcretasViv");
			}
		}
	}

	[Association(Name = "MaterialViv_Vivienda", Storage = "_MaterialViv", ThisKey = "IdMaterial", OtherKey = "IdMaterial", IsForeignKey = true)]
	public MaterialViv MaterialViv
	{
		get
		{
			return _MaterialViv.Entity;
		}
		set
		{
			MaterialViv previousValue = _MaterialViv.Entity;
			if (!object.Equals(previousValue, value) || !_MaterialViv.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_MaterialViv.Entity = null;
					previousValue.Vivienda.Remove(this);
				}
				_MaterialViv.Entity = value;
				if (value != null)
				{
					value.Vivienda.Add(this);
					_IdMaterial = value.IdMaterial;
				}
				else
				{
					_IdMaterial = null;
				}
				SendPropertyChanged("MaterialViv");
			}
		}
	}

	[Association(Name = "TenenciaViv_Vivienda", Storage = "_TenenciaViv", ThisKey = "IdTenencia", OtherKey = "IdTenencia", IsForeignKey = true)]
	public TenenciaViv TenenciaViv
	{
		get
		{
			return _TenenciaViv.Entity;
		}
		set
		{
			TenenciaViv previousValue = _TenenciaViv.Entity;
			if (!object.Equals(previousValue, value) || !_TenenciaViv.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_TenenciaViv.Entity = null;
					previousValue.Vivienda.Remove(this);
				}
				_TenenciaViv.Entity = value;
				if (value != null)
				{
					value.Vivienda.Add(this);
					_IdTenencia = value.IdTenencia;
				}
				else
				{
					_IdTenencia = null;
				}
				SendPropertyChanged("TenenciaViv");
			}
		}
	}

	[Association(Name = "TipoViv_Vivienda", Storage = "_TipoViv", ThisKey = "IdTipo", OtherKey = "IdTipo", IsForeignKey = true)]
	public TipoViv TipoViv
	{
		get
		{
			return _TipoViv.Entity;
		}
		set
		{
			TipoViv previousValue = _TipoViv.Entity;
			if (!object.Equals(previousValue, value) || !_TipoViv.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_TipoViv.Entity = null;
					previousValue.Vivienda.Remove(this);
				}
				_TipoViv.Entity = value;
				if (value != null)
				{
					value.Vivienda.Add(this);
					_IdTipo = value.IdTipo;
				}
				else
				{
					_IdTipo = null;
				}
				SendPropertyChanged("TipoViv");
			}
		}
	}

	[Association(Name = "UbicacionViv_Vivienda", Storage = "_UbicacionViv", ThisKey = "IdUbicacion", OtherKey = "IdUbicacion", IsForeignKey = true)]
	public UbicacionViv UbicacionViv
	{
		get
		{
			return _UbicacionViv.Entity;
		}
		set
		{
			UbicacionViv previousValue = _UbicacionViv.Entity;
			if (!object.Equals(previousValue, value) || !_UbicacionViv.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_UbicacionViv.Entity = null;
					previousValue.Vivienda.Remove(this);
				}
				_UbicacionViv.Entity = value;
				if (value != null)
				{
					value.Vivienda.Add(this);
					_IdUbicacion = value.IdUbicacion;
				}
				else
				{
					_IdUbicacion = null;
				}
				SendPropertyChanged("UbicacionViv");
			}
		}
	}

	[Association(Name = "Empleado_Vivienda", Storage = "_Empleado", ThisKey = "IdEmpleado", OtherKey = "IdEmpleado", IsForeignKey = true)]
	public Empleado Empleado
	{
		get
		{
			return _Empleado.Entity;
		}
		set
		{
			Empleado previousValue = _Empleado.Entity;
			if (!object.Equals(previousValue, value) || !_Empleado.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_Empleado.Entity = null;
					previousValue.Viviendas.Remove(this);
				}
				_Empleado.Entity = value;
				if (value != null)
				{
					value.Viviendas.Add(this);
					_IdEmpleado = value.IdEmpleado;
				}
				else
				{
					_IdEmpleado = null;
				}
				SendPropertyChanged("Empleado");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Vivienda()
	{
		_AguaViv = default(EntityRef<AguaViv>);
		_AlumbradoViv = default(EntityRef<AlumbradoViv>);
		_ConservacionViv = default(EntityRef<ConservacionViv>);
		_ExcretasViv = default(EntityRef<ExcretasViv>);
		_MaterialViv = default(EntityRef<MaterialViv>);
		_TenenciaViv = default(EntityRef<TenenciaViv>);
		_TipoViv = default(EntityRef<TipoViv>);
		_UbicacionViv = default(EntityRef<UbicacionViv>);
		_Empleado = default(EntityRef<Empleado>);
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
