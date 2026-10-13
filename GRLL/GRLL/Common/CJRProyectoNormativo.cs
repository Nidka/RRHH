using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.CJRProyectoNormativo")]
public class CJRProyectoNormativo : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _NumProyecto;

	private string _NumOficioIniciativa;

	private int? _NumTema;

	private int _idTipoProyec;

	private EntitySet<CJRDevolucionNorma> _CJRDevolucionNorma;

	private EntitySet<CJRDictamenComision> _CJRDictamenComision;

	private EntitySet<CJRNormaRegional> _CJRNormaRegional;

	private EntitySet<CJRPromulgacionNorma> _CJRPromulgacionNorma;

	private EntitySet<CJRSesion> _CJRSesion;

	private EntitySet<CJRTrasladoComision> _CJRTrasladoComision;

	private EntityRef<CJRTemaIniciativa> _CJRTemaIniciativa;

	private EntityRef<CJRTipoProyecto> _CJRTipoProyecto;

	[Column(Storage = "_NumProyecto", DbType = "VarChar(120) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string NumProyecto
	{
		get
		{
			return _NumProyecto;
		}
		set
		{
			if (!string.Equals(_NumProyecto, value))
			{
				SendPropertyChanging();
				_NumProyecto = value;
				SendPropertyChanged("NumProyecto");
			}
		}
	}

	[Column(Storage = "_NumOficioIniciativa", DbType = "VarChar(120)")]
	public string NumOficioIniciativa
	{
		get
		{
			return _NumOficioIniciativa;
		}
		set
		{
			if (!string.Equals(_NumOficioIniciativa, value))
			{
				if (_CJRTemaIniciativa.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_NumOficioIniciativa = value;
				SendPropertyChanged("NumOficioIniciativa");
			}
		}
	}

	[Column(Storage = "_NumTema", DbType = "Int")]
	public int? NumTema
	{
		get
		{
			return _NumTema;
		}
		set
		{
			if (!_NumTema.Equals(value))
			{
				if (_CJRTemaIniciativa.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_NumTema = value;
				SendPropertyChanged("NumTema");
			}
		}
	}

	[Column(Storage = "_idTipoProyec", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int idTipoProyec
	{
		get
		{
			return _idTipoProyec;
		}
		set
		{
			if (_idTipoProyec != value)
			{
				if (_CJRTipoProyecto.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_idTipoProyec = value;
				SendPropertyChanged("idTipoProyec");
			}
		}
	}

	[Association(Name = "CJRProyectoNormativo_CJRDevolucionNorma", Storage = "_CJRDevolucionNorma", ThisKey = "NumProyecto,idTipoProyec", OtherKey = "NumProyecto,idTipoProyec")]
	public EntitySet<CJRDevolucionNorma> CJRDevolucionNorma
	{
		get
		{
			return _CJRDevolucionNorma;
		}
		set
		{
			_CJRDevolucionNorma.Assign(value);
		}
	}

	[Association(Name = "CJRProyectoNormativo_CJRDictamenComision", Storage = "_CJRDictamenComision", ThisKey = "NumProyecto,idTipoProyec", OtherKey = "NumProyecto,idTipoProyec")]
	public EntitySet<CJRDictamenComision> CJRDictamenComision
	{
		get
		{
			return _CJRDictamenComision;
		}
		set
		{
			_CJRDictamenComision.Assign(value);
		}
	}

	[Association(Name = "CJRProyectoNormativo_CJRNormaRegional", Storage = "_CJRNormaRegional", ThisKey = "NumProyecto,idTipoProyec", OtherKey = "NumProyecto,idTipoProyec")]
	public EntitySet<CJRNormaRegional> CJRNormaRegional
	{
		get
		{
			return _CJRNormaRegional;
		}
		set
		{
			_CJRNormaRegional.Assign(value);
		}
	}

	[Association(Name = "CJRProyectoNormativo_CJRPromulgacionNorma", Storage = "_CJRPromulgacionNorma", ThisKey = "NumProyecto,idTipoProyec", OtherKey = "NumProyecto,idTipoProyec")]
	public EntitySet<CJRPromulgacionNorma> CJRPromulgacionNorma
	{
		get
		{
			return _CJRPromulgacionNorma;
		}
		set
		{
			_CJRPromulgacionNorma.Assign(value);
		}
	}

	[Association(Name = "CJRProyectoNormativo_CJRSesion", Storage = "_CJRSesion", ThisKey = "NumProyecto,idTipoProyec", OtherKey = "NumProyecto,idTipoProyec")]
	public EntitySet<CJRSesion> CJRSesion
	{
		get
		{
			return _CJRSesion;
		}
		set
		{
			_CJRSesion.Assign(value);
		}
	}

	[Association(Name = "CJRProyectoNormativo_CJRTrasladoComision", Storage = "_CJRTrasladoComision", ThisKey = "NumProyecto,idTipoProyec", OtherKey = "NumProyecto,idTipoProyec")]
	public EntitySet<CJRTrasladoComision> CJRTrasladoComision
	{
		get
		{
			return _CJRTrasladoComision;
		}
		set
		{
			_CJRTrasladoComision.Assign(value);
		}
	}

	[Association(Name = "CJRTemaIniciativa_CJRProyectoNormativo", Storage = "_CJRTemaIniciativa", ThisKey = "NumOficioIniciativa,NumTema", OtherKey = "NumOficioIniciativa,NumTema", IsForeignKey = true)]
	public CJRTemaIniciativa CJRTemaIniciativa
	{
		get
		{
			return _CJRTemaIniciativa.Entity;
		}
		set
		{
			CJRTemaIniciativa previousValue = _CJRTemaIniciativa.Entity;
			if (!object.Equals(previousValue, value) || !_CJRTemaIniciativa.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_CJRTemaIniciativa.Entity = null;
					previousValue.CJRProyectoNormativo.Remove(this);
				}
				_CJRTemaIniciativa.Entity = value;
				if (value != null)
				{
					value.CJRProyectoNormativo.Add(this);
					_NumOficioIniciativa = value.NumOficioIniciativa;
					_NumTema = value.NumTema;
				}
				else
				{
					_NumOficioIniciativa = null;
					_NumTema = null;
				}
				SendPropertyChanged("CJRTemaIniciativa");
			}
		}
	}

	[Association(Name = "CJRTipoProyecto_CJRProyectoNormativo", Storage = "_CJRTipoProyecto", ThisKey = "idTipoProyec", OtherKey = "idTipoProyec", IsForeignKey = true)]
	public CJRTipoProyecto CJRTipoProyecto
	{
		get
		{
			return _CJRTipoProyecto.Entity;
		}
		set
		{
			CJRTipoProyecto previousValue = _CJRTipoProyecto.Entity;
			if (!object.Equals(previousValue, value) || !_CJRTipoProyecto.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_CJRTipoProyecto.Entity = null;
					previousValue.CJRProyectoNormativo.Remove(this);
				}
				_CJRTipoProyecto.Entity = value;
				if (value != null)
				{
					value.CJRProyectoNormativo.Add(this);
					_idTipoProyec = value.idTipoProyec;
				}
				else
				{
					_idTipoProyec = 0;
				}
				SendPropertyChanged("CJRTipoProyecto");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public CJRProyectoNormativo()
	{
		_CJRDevolucionNorma = new EntitySet<CJRDevolucionNorma>(attach_CJRDevolucionNorma, detach_CJRDevolucionNorma);
		_CJRDictamenComision = new EntitySet<CJRDictamenComision>(attach_CJRDictamenComision, detach_CJRDictamenComision);
		_CJRNormaRegional = new EntitySet<CJRNormaRegional>(attach_CJRNormaRegional, detach_CJRNormaRegional);
		_CJRPromulgacionNorma = new EntitySet<CJRPromulgacionNorma>(attach_CJRPromulgacionNorma, detach_CJRPromulgacionNorma);
		_CJRSesion = new EntitySet<CJRSesion>(attach_CJRSesion, detach_CJRSesion);
		_CJRTrasladoComision = new EntitySet<CJRTrasladoComision>(attach_CJRTrasladoComision, detach_CJRTrasladoComision);
		_CJRTemaIniciativa = default(EntityRef<CJRTemaIniciativa>);
		_CJRTipoProyecto = default(EntityRef<CJRTipoProyecto>);
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

	private void attach_CJRDevolucionNorma(CJRDevolucionNorma entity)
	{
		SendPropertyChanging();
		entity.CJRProyectoNormativo = this;
	}

	private void detach_CJRDevolucionNorma(CJRDevolucionNorma entity)
	{
		SendPropertyChanging();
		entity.CJRProyectoNormativo = null;
	}

	private void attach_CJRDictamenComision(CJRDictamenComision entity)
	{
		SendPropertyChanging();
		entity.CJRProyectoNormativo = this;
	}

	private void detach_CJRDictamenComision(CJRDictamenComision entity)
	{
		SendPropertyChanging();
		entity.CJRProyectoNormativo = null;
	}

	private void attach_CJRNormaRegional(CJRNormaRegional entity)
	{
		SendPropertyChanging();
		entity.CJRProyectoNormativo = this;
	}

	private void detach_CJRNormaRegional(CJRNormaRegional entity)
	{
		SendPropertyChanging();
		entity.CJRProyectoNormativo = null;
	}

	private void attach_CJRPromulgacionNorma(CJRPromulgacionNorma entity)
	{
		SendPropertyChanging();
		entity.CJRProyectoNormativo = this;
	}

	private void detach_CJRPromulgacionNorma(CJRPromulgacionNorma entity)
	{
		SendPropertyChanging();
		entity.CJRProyectoNormativo = null;
	}

	private void attach_CJRSesion(CJRSesion entity)
	{
		SendPropertyChanging();
		entity.CJRProyectoNormativo = this;
	}

	private void detach_CJRSesion(CJRSesion entity)
	{
		SendPropertyChanging();
		entity.CJRProyectoNormativo = null;
	}

	private void attach_CJRTrasladoComision(CJRTrasladoComision entity)
	{
		SendPropertyChanging();
		entity.CJRProyectoNormativo = this;
	}

	private void detach_CJRTrasladoComision(CJRTrasladoComision entity)
	{
		SendPropertyChanging();
		entity.CJRProyectoNormativo = null;
	}
}
