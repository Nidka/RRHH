using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Componente")]
public class Componente : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _IdFuncion;

	private string _Anio;

	private string _IdPrograma;

	private string _IdSubPrograma;

	private string _IdProgramaProp;

	private string _IdActividad;

	private string _IdComponente;

	private string _Descripcion;

	private EntitySet<Meta> _Metas;

	private EntityRef<Aba_Actividad> _Aba_Actividad;

	[Column(Storage = "_IdFuncion", DbType = "Char(2) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
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
				if (_Aba_Actividad.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdFuncion = value;
				SendPropertyChanged("IdFuncion");
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
				if (_Aba_Actividad.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_Anio = value;
				SendPropertyChanged("Anio");
			}
		}
	}

	[Column(Storage = "_IdPrograma", DbType = "Char(3) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
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
				if (_Aba_Actividad.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdPrograma = value;
				SendPropertyChanged("IdPrograma");
			}
		}
	}

	[Column(Storage = "_IdSubPrograma", DbType = "Char(4) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
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
				if (_Aba_Actividad.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdSubPrograma = value;
				SendPropertyChanged("IdSubPrograma");
			}
		}
	}

	[Column(Storage = "_IdProgramaProp", DbType = "Char(4) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
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
				if (_Aba_Actividad.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdProgramaProp = value;
				SendPropertyChanged("IdProgramaProp");
			}
		}
	}

	[Column(Storage = "_IdActividad", DbType = "Char(8) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
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
				if (_Aba_Actividad.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdActividad = value;
				SendPropertyChanged("IdActividad");
			}
		}
	}

	[Column(Storage = "_IdComponente", DbType = "Char(8) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
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
				SendPropertyChanging();
				_IdComponente = value;
				SendPropertyChanged("IdComponente");
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

	[Association(Name = "Componente_Meta", Storage = "_Metas", ThisKey = "IdFuncion,Anio,IdPrograma,IdSubPrograma,IdProgramaProp,IdActividad,IdComponente", OtherKey = "IdFuncion,Anio,IdPrograma,IdSubPrograma,IdProgramaProp,IdActividad,IdComponente")]
	public EntitySet<Meta> Metas
	{
		get
		{
			return _Metas;
		}
		set
		{
			_Metas.Assign(value);
		}
	}

	[Association(Name = "Aba_Actividad_Componente", Storage = "_Aba_Actividad", ThisKey = "IdFuncion,Anio,IdPrograma,IdSubPrograma,IdProgramaProp,IdActividad", OtherKey = "IdFuncion,Anio,IdPrograma,IdSubPrograma,IdProgramaProp,IdActividad", IsForeignKey = true)]
	public Aba_Actividad Aba_Actividad
	{
		get
		{
			return _Aba_Actividad.Entity;
		}
		set
		{
			Aba_Actividad previousValue = _Aba_Actividad.Entity;
			if (!object.Equals(previousValue, value) || !_Aba_Actividad.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_Aba_Actividad.Entity = null;
					previousValue.Componente.Remove(this);
				}
				_Aba_Actividad.Entity = value;
				if (value != null)
				{
					value.Componente.Add(this);
					_IdFuncion = value.IdFuncion;
					_Anio = value.Anio;
					_IdPrograma = value.IdPrograma;
					_IdSubPrograma = value.IdSubPrograma;
					_IdProgramaProp = value.IdProgramaProp;
					_IdActividad = value.IdActividad;
				}
				else
				{
					_IdFuncion = null;
					_Anio = null;
					_IdPrograma = null;
					_IdSubPrograma = null;
					_IdProgramaProp = null;
					_IdActividad = null;
				}
				SendPropertyChanged("Aba_Actividad");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Componente()
	{
		_Metas = new EntitySet<Meta>(attach_Metas, detach_Metas);
		_Aba_Actividad = default(EntityRef<Aba_Actividad>);
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

	private void attach_Metas(Meta entity)
	{
		SendPropertyChanging();
		entity.Componente = this;
	}

	private void detach_Metas(Meta entity)
	{
		SendPropertyChanging();
		entity.Componente = null;
	}
}
