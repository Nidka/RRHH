using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.EstadoCivil")]
public class EstadoCivil : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdEstadoCivil;

	private string _DescripEstCivil;

	private string _AbrevEstCiv;

	private EntitySet<Familiar> _Familiar;

	private EntitySet<RRHH_Asegurado> _RRHH_Asegurados;

	private EntitySet<Empleado> _Empleados;

	[Column(Storage = "_IdEstadoCivil", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdEstadoCivil
	{
		get
		{
			return _IdEstadoCivil;
		}
		set
		{
			if (_IdEstadoCivil != value)
			{
				SendPropertyChanging();
				_IdEstadoCivil = value;
				SendPropertyChanged("IdEstadoCivil");
			}
		}
	}

	[Column(Storage = "_DescripEstCivil", DbType = "VarChar(11)")]
	public string DescripEstCivil
	{
		get
		{
			return _DescripEstCivil;
		}
		set
		{
			if (!string.Equals(_DescripEstCivil, value))
			{
				SendPropertyChanging();
				_DescripEstCivil = value;
				SendPropertyChanged("DescripEstCivil");
			}
		}
	}

	[Column(Storage = "_AbrevEstCiv", DbType = "VarChar(3)")]
	public string AbrevEstCiv
	{
		get
		{
			return _AbrevEstCiv;
		}
		set
		{
			if (!string.Equals(_AbrevEstCiv, value))
			{
				SendPropertyChanging();
				_AbrevEstCiv = value;
				SendPropertyChanged("AbrevEstCiv");
			}
		}
	}

	[Association(Name = "EstadoCivil_Familiar", Storage = "_Familiar", ThisKey = "IdEstadoCivil", OtherKey = "IdEstadoCivil")]
	public EntitySet<Familiar> Familiar
	{
		get
		{
			return _Familiar;
		}
		set
		{
			_Familiar.Assign(value);
		}
	}

	[Association(Name = "EstadoCivil_RRHH_Asegurado", Storage = "_RRHH_Asegurados", ThisKey = "IdEstadoCivil", OtherKey = "idEstadoCivil")]
	public EntitySet<RRHH_Asegurado> RRHH_Asegurados
	{
		get
		{
			return _RRHH_Asegurados;
		}
		set
		{
			_RRHH_Asegurados.Assign(value);
		}
	}

	[Association(Name = "EstadoCivil_Empleado", Storage = "_Empleados", ThisKey = "IdEstadoCivil", OtherKey = "IdEstadoCivil")]
	public EntitySet<Empleado> Empleados
	{
		get
		{
			return _Empleados;
		}
		set
		{
			_Empleados.Assign(value);
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public EstadoCivil()
	{
		_Familiar = new EntitySet<Familiar>(attach_Familiar, detach_Familiar);
		_RRHH_Asegurados = new EntitySet<RRHH_Asegurado>(attach_RRHH_Asegurados, detach_RRHH_Asegurados);
		_Empleados = new EntitySet<Empleado>(attach_Empleados, detach_Empleados);
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

	private void attach_Familiar(Familiar entity)
	{
		SendPropertyChanging();
		entity.EstadoCivil = this;
	}

	private void detach_Familiar(Familiar entity)
	{
		SendPropertyChanging();
		entity.EstadoCivil = null;
	}

	private void attach_RRHH_Asegurados(RRHH_Asegurado entity)
	{
		SendPropertyChanging();
		entity.EstadoCivil = this;
	}

	private void detach_RRHH_Asegurados(RRHH_Asegurado entity)
	{
		SendPropertyChanging();
		entity.EstadoCivil = null;
	}

	private void attach_Empleados(Empleado entity)
	{
		SendPropertyChanging();
		entity.EstadoCivil = this;
	}

	private void detach_Empleados(Empleado entity)
	{
		SendPropertyChanging();
		entity.EstadoCivil = null;
	}
}
