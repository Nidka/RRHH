using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.ProgramMes")]
public class ProgramMes : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdObjetivo;

	private int _IdActividad;

	private int _IdMes;

	private decimal? _Programada;

	private decimal? _Ejecutada;

	private decimal? _Acumulada;

	private EntitySet<ReqXProgMes> _ReqXProgMes;

	private EntityRef<Actividad> _Actividad;

	[Column(Storage = "_IdObjetivo", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdObjetivo
	{
		get
		{
			return _IdObjetivo;
		}
		set
		{
			if (_IdObjetivo != value)
			{
				if (_Actividad.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdObjetivo = value;
				SendPropertyChanged("IdObjetivo");
			}
		}
	}

	[Column(Storage = "_IdActividad", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdActividad
	{
		get
		{
			return _IdActividad;
		}
		set
		{
			if (_IdActividad != value)
			{
				if (_Actividad.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdActividad = value;
				SendPropertyChanged("IdActividad");
			}
		}
	}

	[Column(Storage = "_IdMes", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdMes
	{
		get
		{
			return _IdMes;
		}
		set
		{
			if (_IdMes != value)
			{
				SendPropertyChanging();
				_IdMes = value;
				SendPropertyChanged("IdMes");
			}
		}
	}

	[Column(Storage = "_Programada", DbType = "Decimal(11,2)")]
	public decimal? Programada
	{
		get
		{
			return _Programada;
		}
		set
		{
			if (!_Programada.Equals(value))
			{
				SendPropertyChanging();
				_Programada = value;
				SendPropertyChanged("Programada");
			}
		}
	}

	[Column(Storage = "_Ejecutada", DbType = "Decimal(11,2)")]
	public decimal? Ejecutada
	{
		get
		{
			return _Ejecutada;
		}
		set
		{
			if (!_Ejecutada.Equals(value))
			{
				SendPropertyChanging();
				_Ejecutada = value;
				SendPropertyChanged("Ejecutada");
			}
		}
	}

	[Column(Storage = "_Acumulada", DbType = "Decimal(11,2)")]
	public decimal? Acumulada
	{
		get
		{
			return _Acumulada;
		}
		set
		{
			if (!_Acumulada.Equals(value))
			{
				SendPropertyChanging();
				_Acumulada = value;
				SendPropertyChanged("Acumulada");
			}
		}
	}

	[Association(Name = "ProgramMes_ReqXProgMes", Storage = "_ReqXProgMes", ThisKey = "IdObjetivo,IdActividad,IdMes", OtherKey = "IdObjetivo,IdActividad,IdMes")]
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

	[Association(Name = "Actividad_ProgramMes", Storage = "_Actividad", ThisKey = "IdObjetivo,IdActividad", OtherKey = "IdObjetivo,IdActividad", IsForeignKey = true)]
	public Actividad Actividad
	{
		get
		{
			return _Actividad.Entity;
		}
		set
		{
			Actividad previousValue = _Actividad.Entity;
			if (!object.Equals(previousValue, value) || !_Actividad.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_Actividad.Entity = null;
					previousValue.ProgramMes.Remove(this);
				}
				_Actividad.Entity = value;
				if (value != null)
				{
					value.ProgramMes.Add(this);
					_IdObjetivo = value.IdObjetivo;
					_IdActividad = value.IdActividad;
				}
				else
				{
					_IdObjetivo = 0;
					_IdActividad = 0;
				}
				SendPropertyChanged("Actividad");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public ProgramMes()
	{
		_ReqXProgMes = new EntitySet<ReqXProgMes>(attach_ReqXProgMes, detach_ReqXProgMes);
		_Actividad = default(EntityRef<Actividad>);
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

	private void attach_ReqXProgMes(ReqXProgMes entity)
	{
		SendPropertyChanging();
		entity.ProgramMes = this;
	}

	private void detach_ReqXProgMes(ReqXProgMes entity)
	{
		SendPropertyChanging();
		entity.ProgramMes = null;
	}
}
