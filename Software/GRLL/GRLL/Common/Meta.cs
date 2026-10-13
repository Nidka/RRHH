using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Meta")]
public class Meta : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _IdFuncion;

	private string _IdPrograma;

	private string _IdSubPrograma;

	private string _IdProgramaProp;

	private string _IdActividad;

	private string _IdComponente;

	private string _CodigoMeta;

	private string _Anio;

	private string _IdMeta;

	private string _Descripcion;

	private string _IdFinalidad;

	private string _Localizacion;

	private decimal? _Cantidad;

	private string _IdUnidadMedida;

	private string _IdUbigeo;

	private int? _IdAreaOrganiz;

	private EntityRef<Ubigeo> _Ubigeo;

	private EntityRef<UnidadMedida> _UnidadMedida;

	private EntityRef<Componente> _Componente;

	[Column(Storage = "_IdFuncion", DbType = "Char(2)")]
	public string IdFuncion
	{
		get
		{
			return _IdFuncion;
		}
		set
		{
			if (!string.Equals(_IdFuncion, value))
			{
				if (_Componente.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdFuncion = value;
				SendPropertyChanged("IdFuncion");
			}
		}
	}

	[Column(Storage = "_IdPrograma", DbType = "Char(3)")]
	public string IdPrograma
	{
		get
		{
			return _IdPrograma;
		}
		set
		{
			if (!string.Equals(_IdPrograma, value))
			{
				if (_Componente.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdPrograma = value;
				SendPropertyChanged("IdPrograma");
			}
		}
	}

	[Column(Storage = "_IdSubPrograma", DbType = "Char(4)")]
	public string IdSubPrograma
	{
		get
		{
			return _IdSubPrograma;
		}
		set
		{
			if (!string.Equals(_IdSubPrograma, value))
			{
				if (_Componente.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdSubPrograma = value;
				SendPropertyChanged("IdSubPrograma");
			}
		}
	}

	[Column(Storage = "_IdProgramaProp", DbType = "Char(4)")]
	public string IdProgramaProp
	{
		get
		{
			return _IdProgramaProp;
		}
		set
		{
			if (!string.Equals(_IdProgramaProp, value))
			{
				if (_Componente.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdProgramaProp = value;
				SendPropertyChanged("IdProgramaProp");
			}
		}
	}

	[Column(Storage = "_IdActividad", DbType = "Char(8)")]
	public string IdActividad
	{
		get
		{
			return _IdActividad;
		}
		set
		{
			if (!string.Equals(_IdActividad, value))
			{
				if (_Componente.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdActividad = value;
				SendPropertyChanged("IdActividad");
			}
		}
	}

	[Column(Storage = "_IdComponente", DbType = "Char(8)")]
	public string IdComponente
	{
		get
		{
			return _IdComponente;
		}
		set
		{
			if (!string.Equals(_IdComponente, value))
			{
				if (_Componente.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdComponente = value;
				SendPropertyChanged("IdComponente");
			}
		}
	}

	[Column(Storage = "_CodigoMeta", DbType = "Char(6)")]
	public string CodigoMeta
	{
		get
		{
			return _CodigoMeta;
		}
		set
		{
			if (!string.Equals(_CodigoMeta, value))
			{
				SendPropertyChanging();
				_CodigoMeta = value;
				SendPropertyChanged("CodigoMeta");
			}
		}
	}

	[Column(Storage = "_Anio", DbType = "Char(4) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
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
				if (_Componente.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_Anio = value;
				SendPropertyChanged("Anio");
			}
		}
	}

	[Column(Storage = "_IdMeta", DbType = "Char(6) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdMeta
	{
		get
		{
			return _IdMeta;
		}
		set
		{
			if (!string.Equals(_IdMeta, value))
			{
				SendPropertyChanging();
				_IdMeta = value;
				SendPropertyChanged("IdMeta");
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(255)")]
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

	[Column(Storage = "_IdFinalidad", DbType = "Char(5)")]
	public string IdFinalidad
	{
		get
		{
			return _IdFinalidad;
		}
		set
		{
			if (!string.Equals(_IdFinalidad, value))
			{
				SendPropertyChanging();
				_IdFinalidad = value;
				SendPropertyChanged("IdFinalidad");
			}
		}
	}

	[Column(Storage = "_Localizacion", DbType = "VarChar(120)")]
	public string Localizacion
	{
		get
		{
			return _Localizacion;
		}
		set
		{
			if (!string.Equals(_Localizacion, value))
			{
				SendPropertyChanging();
				_Localizacion = value;
				SendPropertyChanged("Localizacion");
			}
		}
	}

	[Column(Storage = "_Cantidad", DbType = "Decimal(18,2)")]
	public decimal? Cantidad
	{
		get
		{
			return _Cantidad;
		}
		set
		{
			if (!_Cantidad.Equals(value))
			{
				SendPropertyChanging();
				_Cantidad = value;
				SendPropertyChanged("Cantidad");
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

	[Column(Storage = "_IdUbigeo", DbType = "Char(6)")]
	public string IdUbigeo
	{
		get
		{
			return _IdUbigeo;
		}
		set
		{
			if (!string.Equals(_IdUbigeo, value))
			{
				if (_Ubigeo.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdUbigeo = value;
				SendPropertyChanged("IdUbigeo");
			}
		}
	}

	[Column(Storage = "_IdAreaOrganiz", DbType = "Int")]
	public int? IdAreaOrganiz
	{
		get
		{
			return _IdAreaOrganiz;
		}
		set
		{
			if (!_IdAreaOrganiz.Equals(value))
			{
				SendPropertyChanging();
				_IdAreaOrganiz = value;
				SendPropertyChanged("IdAreaOrganiz");
			}
		}
	}

	[Association(Name = "Ubigeo_Meta", Storage = "_Ubigeo", ThisKey = "IdUbigeo", OtherKey = "IdUbigeo", IsForeignKey = true, DeleteRule = "CASCADE")]
	public Ubigeo Ubigeo
	{
		get
		{
			return _Ubigeo.Entity;
		}
		set
		{
			Ubigeo previousValue = _Ubigeo.Entity;
			if (!object.Equals(previousValue, value) || !_Ubigeo.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_Ubigeo.Entity = null;
					previousValue.Metas.Remove(this);
				}
				_Ubigeo.Entity = value;
				if (value != null)
				{
					value.Metas.Add(this);
					_IdUbigeo = value.IdUbigeo;
				}
				else
				{
					_IdUbigeo = null;
				}
				SendPropertyChanged("Ubigeo");
			}
		}
	}

	[Association(Name = "UnidadMedida_Meta", Storage = "_UnidadMedida", ThisKey = "IdUnidadMedida", OtherKey = "IdUnidadMedida", IsForeignKey = true, DeleteRule = "CASCADE")]
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
					previousValue.Metas.Remove(this);
				}
				_UnidadMedida.Entity = value;
				if (value != null)
				{
					value.Metas.Add(this);
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

	[Association(Name = "Componente_Meta", Storage = "_Componente", ThisKey = "IdFuncion,Anio,IdPrograma,IdSubPrograma,IdProgramaProp,IdActividad,IdComponente", OtherKey = "IdFuncion,Anio,IdPrograma,IdSubPrograma,IdProgramaProp,IdActividad,IdComponente", IsForeignKey = true)]
	public Componente Componente
	{
		get
		{
			return _Componente.Entity;
		}
		set
		{
			Componente previousValue = _Componente.Entity;
			if (!object.Equals(previousValue, value) || !_Componente.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_Componente.Entity = null;
					previousValue.Metas.Remove(this);
				}
				_Componente.Entity = value;
				if (value != null)
				{
					value.Metas.Add(this);
					_IdFuncion = value.IdFuncion;
					_Anio = value.Anio;
					_IdPrograma = value.IdPrograma;
					_IdSubPrograma = value.IdSubPrograma;
					_IdProgramaProp = value.IdProgramaProp;
					_IdActividad = value.IdActividad;
					_IdComponente = value.IdComponente;
				}
				else
				{
					_IdFuncion = null;
					_Anio = null;
					_IdPrograma = null;
					_IdSubPrograma = null;
					_IdProgramaProp = null;
					_IdActividad = null;
					_IdComponente = null;
				}
				SendPropertyChanged("Componente");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Meta()
	{
		_Ubigeo = default(EntityRef<Ubigeo>);
		_UnidadMedida = default(EntityRef<UnidadMedida>);
		_Componente = default(EntityRef<Componente>);
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
