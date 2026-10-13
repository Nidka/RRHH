using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.ProgramaProp")]
public class ProgramaProp : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _IdFuncion;

	private string _Anio;

	private string _IdPrograma;

	private string _IdSubPrograma;

	private string _IdProgramaProp;

	private string _Descripcion;

	private EntitySet<Aba_Actividad> _Aba_Actividad;

	private EntityRef<SubPrograma> _SubPrograma;

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
				if (_SubPrograma.HasLoadedOrAssignedValue)
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
				if (_SubPrograma.HasLoadedOrAssignedValue)
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
				if (_SubPrograma.HasLoadedOrAssignedValue)
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
				if (_SubPrograma.HasLoadedOrAssignedValue)
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
				SendPropertyChanging();
				_IdProgramaProp = value;
				SendPropertyChanged("IdProgramaProp");
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

	[Association(Name = "ProgramaProp_Aba_Actividad", Storage = "_Aba_Actividad", ThisKey = "IdFuncion,Anio,IdPrograma,IdSubPrograma,IdProgramaProp", OtherKey = "IdFuncion,Anio,IdPrograma,IdSubPrograma,IdProgramaProp")]
	public EntitySet<Aba_Actividad> Aba_Actividad
	{
		get
		{
			return _Aba_Actividad;
		}
		set
		{
			_Aba_Actividad.Assign(value);
		}
	}

	[Association(Name = "SubPrograma_ProgramaProp", Storage = "_SubPrograma", ThisKey = "IdFuncion,Anio,IdPrograma,IdSubPrograma", OtherKey = "IdFuncion,Anio,IdPrograma,IdSubPrograma", IsForeignKey = true)]
	public SubPrograma SubPrograma
	{
		get
		{
			return _SubPrograma.Entity;
		}
		set
		{
			SubPrograma previousValue = _SubPrograma.Entity;
			if (!object.Equals(previousValue, value) || !_SubPrograma.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_SubPrograma.Entity = null;
					previousValue.ProgramaProp.Remove(this);
				}
				_SubPrograma.Entity = value;
				if (value != null)
				{
					value.ProgramaProp.Add(this);
					_IdFuncion = value.IdFuncion;
					_Anio = value.Anio;
					_IdPrograma = value.IdPrograma;
					_IdSubPrograma = value.IdSubPrograma;
				}
				else
				{
					_IdFuncion = null;
					_Anio = null;
					_IdPrograma = null;
					_IdSubPrograma = null;
				}
				SendPropertyChanged("SubPrograma");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public ProgramaProp()
	{
		_Aba_Actividad = new EntitySet<Aba_Actividad>(attach_Aba_Actividad, detach_Aba_Actividad);
		_SubPrograma = default(EntityRef<SubPrograma>);
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

	private void attach_Aba_Actividad(Aba_Actividad entity)
	{
		SendPropertyChanging();
		entity.ProgramaProp = this;
	}

	private void detach_Aba_Actividad(Aba_Actividad entity)
	{
		SendPropertyChanging();
		entity.ProgramaProp = null;
	}
}
