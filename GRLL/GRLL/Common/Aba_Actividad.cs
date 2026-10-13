using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Aba_Actividad")]
public class Aba_Actividad : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _IdFuncion;

	private string _Anio;

	private string _IdPrograma;

	private string _IdSubPrograma;

	private string _IdProgramaProp;

	private string _IdActividad;

	private string _Descripcion;

	private EntitySet<Componente> _Componente;

	private EntityRef<ProgramaProp> _ProgramaProp;

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
				if (_ProgramaProp.HasLoadedOrAssignedValue)
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
				if (_ProgramaProp.HasLoadedOrAssignedValue)
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
				if (_ProgramaProp.HasLoadedOrAssignedValue)
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
				if (_ProgramaProp.HasLoadedOrAssignedValue)
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
				if (_ProgramaProp.HasLoadedOrAssignedValue)
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
				SendPropertyChanging();
				_IdActividad = value;
				SendPropertyChanged("IdActividad");
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

	[Association(Name = "Aba_Actividad_Componente", Storage = "_Componente", ThisKey = "IdFuncion,Anio,IdPrograma,IdSubPrograma,IdProgramaProp,IdActividad", OtherKey = "IdFuncion,Anio,IdPrograma,IdSubPrograma,IdProgramaProp,IdActividad")]
	public EntitySet<Componente> Componente
	{
		get
		{
			return _Componente;
		}
		set
		{
			_Componente.Assign(value);
		}
	}

	[Association(Name = "ProgramaProp_Aba_Actividad", Storage = "_ProgramaProp", ThisKey = "IdFuncion,Anio,IdPrograma,IdSubPrograma,IdProgramaProp", OtherKey = "IdFuncion,Anio,IdPrograma,IdSubPrograma,IdProgramaProp", IsForeignKey = true)]
	public ProgramaProp ProgramaProp
	{
		get
		{
			return _ProgramaProp.Entity;
		}
		set
		{
			ProgramaProp previousValue = _ProgramaProp.Entity;
			if (!object.Equals(previousValue, value) || !_ProgramaProp.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_ProgramaProp.Entity = null;
					previousValue.Aba_Actividad.Remove(this);
				}
				_ProgramaProp.Entity = value;
				if (value != null)
				{
					value.Aba_Actividad.Add(this);
					_IdFuncion = value.IdFuncion;
					_Anio = value.Anio;
					_IdPrograma = value.IdPrograma;
					_IdSubPrograma = value.IdSubPrograma;
					_IdProgramaProp = value.IdProgramaProp;
				}
				else
				{
					_IdFuncion = null;
					_Anio = null;
					_IdPrograma = null;
					_IdSubPrograma = null;
					_IdProgramaProp = null;
				}
				SendPropertyChanged("ProgramaProp");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Aba_Actividad()
	{
		_Componente = new EntitySet<Componente>(attach_Componente, detach_Componente);
		_ProgramaProp = default(EntityRef<ProgramaProp>);
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

	private void attach_Componente(Componente entity)
	{
		SendPropertyChanging();
		entity.Aba_Actividad = this;
	}

	private void detach_Componente(Componente entity)
	{
		SendPropertyChanging();
		entity.Aba_Actividad = null;
	}
}
