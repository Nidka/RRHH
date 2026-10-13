using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.ExpLaboral")]
public class ExpLaboral : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdEmpleado;

	private int _IdExpLab;

	private string _NomInstitucion;

	private string _Cargo;

	private DateTime? _FechaIngreso;

	private DateTime? _FechaEgreso;

	private string _UnidadOrganica;

	private int? _IdTipoInstitucion;

	private EntityRef<TipoInstitucion> _TipoInstitucion;

	private EntityRef<Empleado> _Empleado;

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

	[Column(Storage = "_IdExpLab", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdExpLab
	{
		get
		{
			return _IdExpLab;
		}
		set
		{
			if (_IdExpLab != value)
			{
				SendPropertyChanging();
				_IdExpLab = value;
				SendPropertyChanged("IdExpLab");
			}
		}
	}

	[Column(Storage = "_NomInstitucion", DbType = "VarChar(120)")]
	public string NomInstitucion
	{
		get
		{
			return _NomInstitucion;
		}
		set
		{
			if (!string.Equals(_NomInstitucion, value))
			{
				SendPropertyChanging();
				_NomInstitucion = value;
				SendPropertyChanged("NomInstitucion");
			}
		}
	}

	[Column(Storage = "_Cargo", DbType = "VarChar(40)")]
	public string Cargo
	{
		get
		{
			return _Cargo;
		}
		set
		{
			if (!string.Equals(_Cargo, value))
			{
				SendPropertyChanging();
				_Cargo = value;
				SendPropertyChanged("Cargo");
			}
		}
	}

	[Column(Storage = "_FechaIngreso", DbType = "DateTime")]
	public DateTime? FechaIngreso
	{
		get
		{
			return _FechaIngreso;
		}
		set
		{
			if (!_FechaIngreso.Equals(value))
			{
				SendPropertyChanging();
				_FechaIngreso = value;
				SendPropertyChanged("FechaIngreso");
			}
		}
	}

	[Column(Storage = "_FechaEgreso", DbType = "DateTime")]
	public DateTime? FechaEgreso
	{
		get
		{
			return _FechaEgreso;
		}
		set
		{
			if (!_FechaEgreso.Equals(value))
			{
				SendPropertyChanging();
				_FechaEgreso = value;
				SendPropertyChanged("FechaEgreso");
			}
		}
	}

	[Column(Storage = "_UnidadOrganica", DbType = "VarChar(100)")]
	public string UnidadOrganica
	{
		get
		{
			return _UnidadOrganica;
		}
		set
		{
			if (!string.Equals(_UnidadOrganica, value))
			{
				SendPropertyChanging();
				_UnidadOrganica = value;
				SendPropertyChanged("UnidadOrganica");
			}
		}
	}

	[Column(Storage = "_IdTipoInstitucion", DbType = "Int")]
	public int? IdTipoInstitucion
	{
		get
		{
			return _IdTipoInstitucion;
		}
		set
		{
			if (!_IdTipoInstitucion.Equals(value))
			{
				if (_TipoInstitucion.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdTipoInstitucion = value;
				SendPropertyChanged("IdTipoInstitucion");
			}
		}
	}

	[Association(Name = "TipoInstitucion_ExpLaboral", Storage = "_TipoInstitucion", ThisKey = "IdTipoInstitucion", OtherKey = "IdTipoInstitucion", IsForeignKey = true)]
	public TipoInstitucion TipoInstitucion
	{
		get
		{
			return _TipoInstitucion.Entity;
		}
		set
		{
			TipoInstitucion previousValue = _TipoInstitucion.Entity;
			if (!object.Equals(previousValue, value) || !_TipoInstitucion.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_TipoInstitucion.Entity = null;
					previousValue.ExpLaboral.Remove(this);
				}
				_TipoInstitucion.Entity = value;
				if (value != null)
				{
					value.ExpLaboral.Add(this);
					_IdTipoInstitucion = value.IdTipoInstitucion;
				}
				else
				{
					_IdTipoInstitucion = null;
				}
				SendPropertyChanged("TipoInstitucion");
			}
		}
	}

	[Association(Name = "Empleado_ExpLaboral", Storage = "_Empleado", ThisKey = "IdEmpleado", OtherKey = "IdEmpleado", IsForeignKey = true)]
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
					previousValue.ExpLaborals.Remove(this);
				}
				_Empleado.Entity = value;
				if (value != null)
				{
					value.ExpLaborals.Add(this);
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

	public ExpLaboral()
	{
		_TipoInstitucion = default(EntityRef<TipoInstitucion>);
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
