using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Discapacidad")]
public class Discapacidad : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdDiscapacidad;

	private string _Descrip_Discapacidad;

	private EntitySet<Familiar> _Familiar;

	private EntitySet<Empleado> _Empleados;

	[Column(Storage = "_IdDiscapacidad", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdDiscapacidad
	{
		get
		{
			return _IdDiscapacidad;
		}
		set
		{
			if (_IdDiscapacidad != value)
			{
				SendPropertyChanging();
				_IdDiscapacidad = value;
				SendPropertyChanged("IdDiscapacidad");
			}
		}
	}

	[Column(Storage = "_Descrip_Discapacidad", DbType = "VarChar(12)")]
	public string Descrip_Discapacidad
	{
		get
		{
			return _Descrip_Discapacidad;
		}
		set
		{
			if (!string.Equals(_Descrip_Discapacidad, value))
			{
				SendPropertyChanging();
				_Descrip_Discapacidad = value;
				SendPropertyChanged("Descrip_Discapacidad");
			}
		}
	}

	[Association(Name = "Discapacidad_Familiar", Storage = "_Familiar", ThisKey = "IdDiscapacidad", OtherKey = "IdDiscapacidad")]
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

	[Association(Name = "Discapacidad_Empleado", Storage = "_Empleados", ThisKey = "IdDiscapacidad", OtherKey = "IdDiscapacidad")]
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

	public Discapacidad()
	{
		_Familiar = new EntitySet<Familiar>(attach_Familiar, detach_Familiar);
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
		entity.Discapacidad = this;
	}

	private void detach_Familiar(Familiar entity)
	{
		SendPropertyChanging();
		entity.Discapacidad = null;
	}

	private void attach_Empleados(Empleado entity)
	{
		SendPropertyChanging();
		entity.Discapacidad = this;
	}

	private void detach_Empleados(Empleado entity)
	{
		SendPropertyChanging();
		entity.Discapacidad = null;
	}
}
