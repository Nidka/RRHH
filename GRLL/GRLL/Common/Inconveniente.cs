using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Inconveniente")]
public class Inconveniente : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdObjetivo;

	private int _Id_Actividad;

	private int _IdInconveniente;

	private string _Inconveniente;

	private int _Importancia;

	private string _Desventaja;

	private string _Observacion;

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

	[Column(Storage = "_Id_Actividad", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int Id_Actividad
	{
		get
		{
			return _Id_Actividad;
		}
		set
		{
			if (_Id_Actividad != value)
			{
				if (_Actividad.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_Id_Actividad = value;
				SendPropertyChanged("Id_Actividad");
			}
		}
	}

	[Column(Storage = "_IdInconveniente", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdInconveniente
	{
		get
		{
			return _IdInconveniente;
		}
		set
		{
			if (_IdInconveniente != value)
			{
				SendPropertyChanging();
				_IdInconveniente = value;
				SendPropertyChanged("IdInconveniente");
			}
		}
	}

	[Column(Name = "Inconveniente", Storage = "_Inconveniente", DbType = "VarChar(70) NOT NULL", CanBeNull = false)]
	public string InconvenienteValue
	{
		get
		{
			return _Inconveniente;
		}
		set
		{
			if (!string.Equals(_Inconveniente, value))
			{
				SendPropertyChanging();
				_Inconveniente = value;
				SendPropertyChanged("Inconveniente");
			}
		}
	}

	[Column(Storage = "_Importancia", DbType = "Int NOT NULL")]
	public int Importancia
	{
		get
		{
			return _Importancia;
		}
		set
		{
			if (_Importancia != value)
			{
				SendPropertyChanging();
				_Importancia = value;
				SendPropertyChanged("Importancia");
			}
		}
	}

	[Column(Storage = "_Desventaja", DbType = "VarChar(70)")]
	public string Desventaja
	{
		get
		{
			return _Desventaja;
		}
		set
		{
			if (!string.Equals(_Desventaja, value))
			{
				SendPropertyChanging();
				_Desventaja = value;
				SendPropertyChanged("Desventaja");
			}
		}
	}

	[Column(Storage = "_Observacion", DbType = "VarChar(300)")]
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

	[Association(Name = "Actividad_Inconveniente", Storage = "_Actividad", ThisKey = "IdObjetivo,Id_Actividad", OtherKey = "IdObjetivo,IdActividad", IsForeignKey = true)]
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
					previousValue.Inconveniente.Remove(this);
				}
				_Actividad.Entity = value;
				if (value != null)
				{
					value.Inconveniente.Add(this);
					_IdObjetivo = value.IdObjetivo;
					_Id_Actividad = value.IdActividad;
				}
				else
				{
					_IdObjetivo = 0;
					_Id_Actividad = 0;
				}
				SendPropertyChanged("Actividad");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Inconveniente()
	{
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
}
