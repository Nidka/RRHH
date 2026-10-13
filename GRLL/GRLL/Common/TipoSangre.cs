using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.TipoSangre")]
public class TipoSangre : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdTipoSangre;

	private string _DescripTS;

	private EntitySet<Familiar> _Familiar;

	private EntitySet<Empleado> _Empleados;

	[Column(Storage = "_IdTipoSangre", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdTipoSangre
	{
		get
		{
			return _IdTipoSangre;
		}
		set
		{
			if (_IdTipoSangre != value)
			{
				SendPropertyChanging();
				_IdTipoSangre = value;
				SendPropertyChanged("IdTipoSangre");
			}
		}
	}

	[Column(Storage = "_DescripTS", DbType = "VarChar(5)")]
	public string DescripTS
	{
		get
		{
			return _DescripTS;
		}
		set
		{
			if (!string.Equals(_DescripTS, value))
			{
				SendPropertyChanging();
				_DescripTS = value;
				SendPropertyChanged("DescripTS");
			}
		}
	}

	[Association(Name = "TipoSangre_Familiar", Storage = "_Familiar", ThisKey = "IdTipoSangre", OtherKey = "IdTipoSangre")]
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

	[Association(Name = "TipoSangre_Empleado", Storage = "_Empleados", ThisKey = "IdTipoSangre", OtherKey = "IdTipoSangre")]
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

	public TipoSangre()
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
		entity.TipoSangre = this;
	}

	private void detach_Familiar(Familiar entity)
	{
		SendPropertyChanging();
		entity.TipoSangre = null;
	}

	private void attach_Empleados(Empleado entity)
	{
		SendPropertyChanging();
		entity.TipoSangre = this;
	}

	private void detach_Empleados(Empleado entity)
	{
		SendPropertyChanging();
		entity.TipoSangre = null;
	}
}
