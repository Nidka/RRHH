using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.GastoPublico")]
public class GastoPublico : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private char? _IdCategoriaGasto;

	private char? _IdGenericaGasto;

	private string _IdModalidadAplicacion;

	private string _IdEspecificaGasto;

	private string _IdGasto;

	private string _Descripcion;

	private EntityRef<CategoriaGasto> _CategoriaGasto;

	private EntityRef<EspecificaGasto> _EspecificaGasto;

	private EntityRef<GenericaGasto> _GenericaGasto;

	private EntityRef<ModalidadAplicacion> _ModalidadAplicacion;

	[Column(Storage = "_IdCategoriaGasto", DbType = "Char(1)")]
	public char? IdCategoriaGasto
	{
		get
		{
			return _IdCategoriaGasto;
		}
		set
		{
			if (!_IdCategoriaGasto.Equals(value))
			{
				if (_CategoriaGasto.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdCategoriaGasto = value;
				SendPropertyChanged("IdCategoriaGasto");
			}
		}
	}

	[Column(Storage = "_IdGenericaGasto", DbType = "Char(1)")]
	public char? IdGenericaGasto
	{
		get
		{
			return _IdGenericaGasto;
		}
		set
		{
			if (!_IdGenericaGasto.Equals(value))
			{
				if (_GenericaGasto.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdGenericaGasto = value;
				SendPropertyChanged("IdGenericaGasto");
			}
		}
	}

	[Column(Storage = "_IdModalidadAplicacion", DbType = "Char(2)")]
	public string IdModalidadAplicacion
	{
		get
		{
			return _IdModalidadAplicacion;
		}
		set
		{
			if (!string.Equals(_IdModalidadAplicacion, value))
			{
				if (_ModalidadAplicacion.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdModalidadAplicacion = value;
				SendPropertyChanged("IdModalidadAplicacion");
			}
		}
	}

	[Column(Storage = "_IdEspecificaGasto", DbType = "Char(2)")]
	public string IdEspecificaGasto
	{
		get
		{
			return _IdEspecificaGasto;
		}
		set
		{
			if (!string.Equals(_IdEspecificaGasto, value))
			{
				if (_EspecificaGasto.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdEspecificaGasto = value;
				SendPropertyChanged("IdEspecificaGasto");
			}
		}
	}

	[Column(Storage = "_IdGasto", DbType = "Char(20) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdGasto
	{
		get
		{
			return _IdGasto;
		}
		set
		{
			if (!string.Equals(_IdGasto, value))
			{
				SendPropertyChanging();
				_IdGasto = value;
				SendPropertyChanged("IdGasto");
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(80)")]
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

	[Association(Name = "CategoriaGasto_GastoPublico", Storage = "_CategoriaGasto", ThisKey = "IdCategoriaGasto", OtherKey = "idCategoriaGasto", IsForeignKey = true)]
	public CategoriaGasto CategoriaGasto
	{
		get
		{
			return _CategoriaGasto.Entity;
		}
		set
		{
			CategoriaGasto previousValue = _CategoriaGasto.Entity;
			if (!object.Equals(previousValue, value) || !_CategoriaGasto.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_CategoriaGasto.Entity = null;
					previousValue.GastoPublico.Remove(this);
				}
				_CategoriaGasto.Entity = value;
				if (value != null)
				{
					value.GastoPublico.Add(this);
					_IdCategoriaGasto = value.idCategoriaGasto;
				}
				else
				{
					_IdCategoriaGasto = null;
				}
				SendPropertyChanged("CategoriaGasto");
			}
		}
	}

	[Association(Name = "EspecificaGasto_GastoPublico", Storage = "_EspecificaGasto", ThisKey = "IdEspecificaGasto", OtherKey = "IdEspecificaGasto", IsForeignKey = true)]
	public EspecificaGasto EspecificaGasto
	{
		get
		{
			return _EspecificaGasto.Entity;
		}
		set
		{
			EspecificaGasto previousValue = _EspecificaGasto.Entity;
			if (!object.Equals(previousValue, value) || !_EspecificaGasto.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_EspecificaGasto.Entity = null;
					previousValue.GastoPublico.Remove(this);
				}
				_EspecificaGasto.Entity = value;
				if (value != null)
				{
					value.GastoPublico.Add(this);
					_IdEspecificaGasto = value.IdEspecificaGasto;
				}
				else
				{
					_IdEspecificaGasto = null;
				}
				SendPropertyChanged("EspecificaGasto");
			}
		}
	}

	[Association(Name = "GenericaGasto_GastoPublico", Storage = "_GenericaGasto", ThisKey = "IdGenericaGasto", OtherKey = "IdGenericaGasto", IsForeignKey = true)]
	public GenericaGasto GenericaGasto
	{
		get
		{
			return _GenericaGasto.Entity;
		}
		set
		{
			GenericaGasto previousValue = _GenericaGasto.Entity;
			if (!object.Equals(previousValue, value) || !_GenericaGasto.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_GenericaGasto.Entity = null;
					previousValue.GastoPublico.Remove(this);
				}
				_GenericaGasto.Entity = value;
				if (value != null)
				{
					value.GastoPublico.Add(this);
					_IdGenericaGasto = value.IdGenericaGasto;
				}
				else
				{
					_IdGenericaGasto = null;
				}
				SendPropertyChanged("GenericaGasto");
			}
		}
	}

	[Association(Name = "ModalidadAplicacion_GastoPublico", Storage = "_ModalidadAplicacion", ThisKey = "IdModalidadAplicacion", OtherKey = "IdModalidadAplicacion", IsForeignKey = true)]
	public ModalidadAplicacion ModalidadAplicacion
	{
		get
		{
			return _ModalidadAplicacion.Entity;
		}
		set
		{
			ModalidadAplicacion previousValue = _ModalidadAplicacion.Entity;
			if (!object.Equals(previousValue, value) || !_ModalidadAplicacion.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_ModalidadAplicacion.Entity = null;
					previousValue.GastoPublico.Remove(this);
				}
				_ModalidadAplicacion.Entity = value;
				if (value != null)
				{
					value.GastoPublico.Add(this);
					_IdModalidadAplicacion = value.IdModalidadAplicacion;
				}
				else
				{
					_IdModalidadAplicacion = null;
				}
				SendPropertyChanged("ModalidadAplicacion");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public GastoPublico()
	{
		_CategoriaGasto = default(EntityRef<CategoriaGasto>);
		_EspecificaGasto = default(EntityRef<EspecificaGasto>);
		_GenericaGasto = default(EntityRef<GenericaGasto>);
		_ModalidadAplicacion = default(EntityRef<ModalidadAplicacion>);
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
