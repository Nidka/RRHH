using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Empleado_Area")]
public class Empleado_Area : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _Year;

	private int _idAreaOrganiz;

	private int _IdEmpleado;

	private EntityRef<EstructOrganiz> _EstructOrganiz;

	private EntityRef<Empleado> _Empleado;

	[Column(Storage = "_Year", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int Year
	{
		get
		{
			return _Year;
		}
		set
		{
			if (_Year != value)
			{
				if (_EstructOrganiz.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_Year = value;
				SendPropertyChanged("Year");
			}
		}
	}

	[Column(Storage = "_idAreaOrganiz", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int idAreaOrganiz
	{
		get
		{
			return _idAreaOrganiz;
		}
		set
		{
			if (_idAreaOrganiz != value)
			{
				if (_EstructOrganiz.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_idAreaOrganiz = value;
				SendPropertyChanged("idAreaOrganiz");
			}
		}
	}

	[Column(Storage = "_IdEmpleado", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdEmpleado
	{
		get
		{
			return _IdEmpleado;
		}
		set
		{
			if (_IdEmpleado != value)
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

	[Association(Name = "EstructOrganiz_Empleado_Area", Storage = "_EstructOrganiz", ThisKey = "Year,idAreaOrganiz", OtherKey = "Year,idAreaOrganiz", IsForeignKey = true)]
	public EstructOrganiz EstructOrganiz
	{
		get
		{
			return _EstructOrganiz.Entity;
		}
		set
		{
			EstructOrganiz previousValue = _EstructOrganiz.Entity;
			if (!object.Equals(previousValue, value) || !_EstructOrganiz.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_EstructOrganiz.Entity = null;
					previousValue.Empleado_Area.Remove(this);
				}
				_EstructOrganiz.Entity = value;
				if (value != null)
				{
					value.Empleado_Area.Add(this);
					_Year = value.Year;
					_idAreaOrganiz = value.idAreaOrganiz;
				}
				else
				{
					_Year = 0;
					_idAreaOrganiz = 0;
				}
				SendPropertyChanged("EstructOrganiz");
			}
		}
	}

	[Association(Name = "Empleado_Empleado_Area", Storage = "_Empleado", ThisKey = "IdEmpleado", OtherKey = "IdEmpleado", IsForeignKey = true)]
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
					previousValue.Empleado_Areas.Remove(this);
				}
				_Empleado.Entity = value;
				if (value != null)
				{
					value.Empleado_Areas.Add(this);
					_IdEmpleado = value.IdEmpleado;
				}
				else
				{
					_IdEmpleado = 0;
				}
				SendPropertyChanged("Empleado");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Empleado_Area()
	{
		_EstructOrganiz = default(EntityRef<EstructOrganiz>);
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
