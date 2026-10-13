using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.ViveCon")]
public class ViveCon : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdViveCon;

	private string _DescripViveCon;

	private EntitySet<Empleado> _Empleados;

	[Column(Storage = "_IdViveCon", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdViveCon
	{
		get
		{
			return _IdViveCon;
		}
		set
		{
			if (_IdViveCon != value)
			{
				SendPropertyChanging();
				_IdViveCon = value;
				SendPropertyChanged("IdViveCon");
			}
		}
	}

	[Column(Storage = "_DescripViveCon", DbType = "VarChar(27)")]
	public string DescripViveCon
	{
		get
		{
			return _DescripViveCon;
		}
		set
		{
			if (!string.Equals(_DescripViveCon, value))
			{
				SendPropertyChanging();
				_DescripViveCon = value;
				SendPropertyChanged("DescripViveCon");
			}
		}
	}

	[Association(Name = "ViveCon_Empleado", Storage = "_Empleados", ThisKey = "IdViveCon", OtherKey = "IdViveCon")]
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

	public ViveCon()
	{
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

	private void attach_Empleados(Empleado entity)
	{
		SendPropertyChanging();
		entity.ViveCon = this;
	}

	private void detach_Empleados(Empleado entity)
	{
		SendPropertyChanging();
		entity.ViveCon = null;
	}
}
