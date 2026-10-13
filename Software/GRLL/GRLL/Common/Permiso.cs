using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Permiso")]
public class Permiso : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdEmpleado;

	private int _NPermiso;

	private DateTime? _FechaInicio;

	private DateTime? _FechaFin;

	private string _Hora_Sal;

	private string _Hora_Ret;

	private bool? _Dia;

	private bool? _Retorno;

	private int? _idMotivo;

	private string _Lugar;

	private string _Referencia;

	private string _Autorizacion;

	private string _Obs;

	private EntityRef<Motivo_Perm> _Motivo_Perm;

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

	[Column(Storage = "_NPermiso", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int NPermiso
	{
		get
		{
			return _NPermiso;
		}
		set
		{
			if (_NPermiso != value)
			{
				SendPropertyChanging();
				_NPermiso = value;
				SendPropertyChanged("NPermiso");
			}
		}
	}

	[Column(Storage = "_FechaInicio", DbType = "DateTime")]
	public DateTime? FechaInicio
	{
		get
		{
			return _FechaInicio;
		}
		set
		{
			if (!_FechaInicio.Equals(value))
			{
				SendPropertyChanging();
				_FechaInicio = value;
				SendPropertyChanged("FechaInicio");
			}
		}
	}

	[Column(Storage = "_FechaFin", DbType = "DateTime")]
	public DateTime? FechaFin
	{
		get
		{
			return _FechaFin;
		}
		set
		{
			if (!_FechaFin.Equals(value))
			{
				SendPropertyChanging();
				_FechaFin = value;
				SendPropertyChanged("FechaFin");
			}
		}
	}

	[Column(Storage = "_Hora_Sal", DbType = "Char(8)")]
	public string Hora_Sal
	{
		get
		{
			return _Hora_Sal;
		}
		set
		{
			if (!string.Equals(_Hora_Sal, value))
			{
				SendPropertyChanging();
				_Hora_Sal = value;
				SendPropertyChanged("Hora_Sal");
			}
		}
	}

	[Column(Storage = "_Hora_Ret", DbType = "Char(8)")]
	public string Hora_Ret
	{
		get
		{
			return _Hora_Ret;
		}
		set
		{
			if (!string.Equals(_Hora_Ret, value))
			{
				SendPropertyChanging();
				_Hora_Ret = value;
				SendPropertyChanged("Hora_Ret");
			}
		}
	}

	[Column(Storage = "_Dia", DbType = "Bit")]
	public bool? Dia
	{
		get
		{
			return _Dia;
		}
		set
		{
			if (!_Dia.Equals(value))
			{
				SendPropertyChanging();
				_Dia = value;
				SendPropertyChanged("Dia");
			}
		}
	}

	[Column(Storage = "_Retorno", DbType = "Bit")]
	public bool? Retorno
	{
		get
		{
			return _Retorno;
		}
		set
		{
			if (!_Retorno.Equals(value))
			{
				SendPropertyChanging();
				_Retorno = value;
				SendPropertyChanged("Retorno");
			}
		}
	}

	[Column(Storage = "_idMotivo", DbType = "Int")]
	public int? idMotivo
	{
		get
		{
			return _idMotivo;
		}
		set
		{
			if (!_idMotivo.Equals(value))
			{
				if (_Motivo_Perm.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_idMotivo = value;
				SendPropertyChanged("idMotivo");
			}
		}
	}

	[Column(Storage = "_Lugar", DbType = "VarChar(20)")]
	public string Lugar
	{
		get
		{
			return _Lugar;
		}
		set
		{
			if (!string.Equals(_Lugar, value))
			{
				SendPropertyChanging();
				_Lugar = value;
				SendPropertyChanged("Lugar");
			}
		}
	}

	[Column(Storage = "_Referencia", DbType = "VarChar(50)")]
	public string Referencia
	{
		get
		{
			return _Referencia;
		}
		set
		{
			if (!string.Equals(_Referencia, value))
			{
				SendPropertyChanging();
				_Referencia = value;
				SendPropertyChanged("Referencia");
			}
		}
	}

	[Column(Storage = "_Autorizacion", DbType = "VarChar(50)")]
	public string Autorizacion
	{
		get
		{
			return _Autorizacion;
		}
		set
		{
			if (!string.Equals(_Autorizacion, value))
			{
				SendPropertyChanging();
				_Autorizacion = value;
				SendPropertyChanged("Autorizacion");
			}
		}
	}

	[Column(Storage = "_Obs", DbType = "VarChar(200)")]
	public string Obs
	{
		get
		{
			return _Obs;
		}
		set
		{
			if (!string.Equals(_Obs, value))
			{
				SendPropertyChanging();
				_Obs = value;
				SendPropertyChanged("Obs");
			}
		}
	}

	[Association(Name = "Motivo_Perm_Permiso", Storage = "_Motivo_Perm", ThisKey = "idMotivo", OtherKey = "idMotivo", IsForeignKey = true)]
	public Motivo_Perm Motivo_Perm
	{
		get
		{
			return _Motivo_Perm.Entity;
		}
		set
		{
			Motivo_Perm previousValue = _Motivo_Perm.Entity;
			if (!object.Equals(previousValue, value) || !_Motivo_Perm.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_Motivo_Perm.Entity = null;
					previousValue.Permisos.Remove(this);
				}
				_Motivo_Perm.Entity = value;
				if (value != null)
				{
					value.Permisos.Add(this);
					_idMotivo = value.idMotivo;
				}
				else
				{
					_idMotivo = null;
				}
				SendPropertyChanged("Motivo_Perm");
			}
		}
	}

	[Association(Name = "Empleado_Permiso", Storage = "_Empleado", ThisKey = "IdEmpleado", OtherKey = "IdEmpleado", IsForeignKey = true)]
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
					previousValue.Permisos.Remove(this);
				}
				_Empleado.Entity = value;
				if (value != null)
				{
					value.Permisos.Add(this);
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

	public Permiso()
	{
		_Motivo_Perm = default(EntityRef<Motivo_Perm>);
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
