using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Asistencia")]
public class Asistencia : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private DateTime _Fecha;

	private int _IdEmpleado;

	private string _Hor_Ent;

	private string _Hor_Sal;

	private string _Alm_Sal;

	private string _Alm_Ent;

	private bool? _Flag_Ent;

	private bool? _Flag_Sal;

	private bool? _Estado;

	private int? _idHorario;

	private string _Usuario;

	private string _PC;

	private EntityRef<Empleado> _Empleado;

	[Column(Storage = "_Fecha", DbType = "DateTime NOT NULL", IsPrimaryKey = true)]
	public DateTime Fecha
	{
		get
		{
			return _Fecha;
		}
		set
		{
			if (DateTime.Compare(_Fecha, value) != 0)
			{
				SendPropertyChanging();
				_Fecha = value;
				SendPropertyChanged("Fecha");
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

	[Column(Storage = "_Hor_Ent", DbType = "Char(8)")]
	public string Hor_Ent
	{
		get
		{
			return _Hor_Ent;
		}
		set
		{
			if (!string.Equals(_Hor_Ent, value))
			{
				SendPropertyChanging();
				_Hor_Ent = value;
				SendPropertyChanged("Hor_Ent");
			}
		}
	}

	[Column(Storage = "_Hor_Sal", DbType = "Char(8)")]
	public string Hor_Sal
	{
		get
		{
			return _Hor_Sal;
		}
		set
		{
			if (!string.Equals(_Hor_Sal, value))
			{
				SendPropertyChanging();
				_Hor_Sal = value;
				SendPropertyChanged("Hor_Sal");
			}
		}
	}

	[Column(Storage = "_Alm_Sal", DbType = "Char(8)")]
	public string Alm_Sal
	{
		get
		{
			return _Alm_Sal;
		}
		set
		{
			if (!string.Equals(_Alm_Sal, value))
			{
				SendPropertyChanging();
				_Alm_Sal = value;
				SendPropertyChanged("Alm_Sal");
			}
		}
	}

	[Column(Storage = "_Alm_Ent", DbType = "Char(8)")]
	public string Alm_Ent
	{
		get
		{
			return _Alm_Ent;
		}
		set
		{
			if (!string.Equals(_Alm_Ent, value))
			{
				SendPropertyChanging();
				_Alm_Ent = value;
				SendPropertyChanged("Alm_Ent");
			}
		}
	}

	[Column(Storage = "_Flag_Ent", DbType = "Bit")]
	public bool? Flag_Ent
	{
		get
		{
			return _Flag_Ent;
		}
		set
		{
			if (!_Flag_Ent.Equals(value))
			{
				SendPropertyChanging();
				_Flag_Ent = value;
				SendPropertyChanged("Flag_Ent");
			}
		}
	}

	[Column(Storage = "_Flag_Sal", DbType = "Bit")]
	public bool? Flag_Sal
	{
		get
		{
			return _Flag_Sal;
		}
		set
		{
			if (!_Flag_Sal.Equals(value))
			{
				SendPropertyChanging();
				_Flag_Sal = value;
				SendPropertyChanged("Flag_Sal");
			}
		}
	}

	[Column(Storage = "_Estado", DbType = "Bit")]
	public bool? Estado
	{
		get
		{
			return _Estado;
		}
		set
		{
			if (!_Estado.Equals(value))
			{
				SendPropertyChanging();
				_Estado = value;
				SendPropertyChanged("Estado");
			}
		}
	}

	[Column(Storage = "_idHorario", DbType = "Int")]
	public int? idHorario
	{
		get
		{
			return _idHorario;
		}
		set
		{
			if (!_idHorario.Equals(value))
			{
				SendPropertyChanging();
				_idHorario = value;
				SendPropertyChanged("idHorario");
			}
		}
	}

	[Column(Storage = "_Usuario", DbType = "NVarChar(50)")]
	public string Usuario
	{
		get
		{
			return _Usuario;
		}
		set
		{
			if (!string.Equals(_Usuario, value))
			{
				SendPropertyChanging();
				_Usuario = value;
				SendPropertyChanged("Usuario");
			}
		}
	}

	[Column(Storage = "_PC", DbType = "NVarChar(50)")]
	public string PC
	{
		get
		{
			return _PC;
		}
		set
		{
			if (!string.Equals(_PC, value))
			{
				SendPropertyChanging();
				_PC = value;
				SendPropertyChanged("PC");
			}
		}
	}

	[Association(Name = "Empleado_Asistencia", Storage = "_Empleado", ThisKey = "IdEmpleado", OtherKey = "IdEmpleado", IsForeignKey = true)]
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
					previousValue.Asistencias.Remove(this);
				}
				_Empleado.Entity = value;
				if (value != null)
				{
					value.Asistencias.Add(this);
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

	public Asistencia()
	{
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
