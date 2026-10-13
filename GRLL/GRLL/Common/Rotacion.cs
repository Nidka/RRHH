using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Rotacion")]
public class Rotacion : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _idEmpleado;

	private int _idRotacion;

	private DateTime? _FechaMemo;

	private string _NroMemo;

	private int? _idAreaOrganiz;

	private int _Year;

	private EntityRef<Empleado> _Empleado;

	private EntityRef<EstructOrganiz> _EstructOrganiz;

	[Column(Storage = "_idEmpleado", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int idEmpleado
	{
		get
		{
			return _idEmpleado;
		}
		set
		{
			if (_idEmpleado != value)
			{
				if (_Empleado.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_idEmpleado = value;
				SendPropertyChanged("idEmpleado");
			}
		}
	}

	[Column(Storage = "_idRotacion", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int idRotacion
	{
		get
		{
			return _idRotacion;
		}
		set
		{
			if (_idRotacion != value)
			{
				SendPropertyChanging();
				_idRotacion = value;
				SendPropertyChanged("idRotacion");
			}
		}
	}

	[Column(Storage = "_FechaMemo", DbType = "Date")]
	public DateTime? FechaMemo
	{
		get
		{
			return _FechaMemo;
		}
		set
		{
			if (!_FechaMemo.Equals(value))
			{
				SendPropertyChanging();
				_FechaMemo = value;
				SendPropertyChanged("FechaMemo");
			}
		}
	}

	[Column(Storage = "_NroMemo", DbType = "NVarChar(50)")]
	public string NroMemo
	{
		get
		{
			return _NroMemo;
		}
		set
		{
			if (!string.Equals(_NroMemo, value))
			{
				SendPropertyChanging();
				_NroMemo = value;
				SendPropertyChanged("NroMemo");
			}
		}
	}

	[Column(Storage = "_idAreaOrganiz", DbType = "Int")]
	public int? idAreaOrganiz
	{
		get
		{
			return _idAreaOrganiz;
		}
		set
		{
			if (!_idAreaOrganiz.Equals(value))
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

	[Column(Storage = "_Year", DbType = "Int NOT NULL")]
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

	[Association(Name = "Empleado_Rotacion", Storage = "_Empleado", ThisKey = "idEmpleado", OtherKey = "IdEmpleado", IsForeignKey = true)]
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
					previousValue.Rotacions.Remove(this);
				}
				_Empleado.Entity = value;
				if (value != null)
				{
					value.Rotacions.Add(this);
					_idEmpleado = value.IdEmpleado;
				}
				else
				{
					_idEmpleado = 0;
				}
				SendPropertyChanged("Empleado");
			}
		}
	}

	[Association(Name = "EstructOrganiz_Rotacion", Storage = "_EstructOrganiz", ThisKey = "Year,idAreaOrganiz", OtherKey = "Year,idAreaOrganiz", IsForeignKey = true)]
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
					previousValue.Rotacions.Remove(this);
				}
				_EstructOrganiz.Entity = value;
				if (value != null)
				{
					value.Rotacions.Add(this);
					_Year = value.Year;
					_idAreaOrganiz = value.idAreaOrganiz;
				}
				else
				{
					_Year = 0;
					_idAreaOrganiz = null;
				}
				SendPropertyChanged("EstructOrganiz");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Rotacion()
	{
		_Empleado = default(EntityRef<Empleado>);
		_EstructOrganiz = default(EntityRef<EstructOrganiz>);
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
