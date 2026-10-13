using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Seguro")]
public class Seguro : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdSeguro;

	private string _DescripSeg;

	private string _DireccSeg;

	private string _TelefSeg;

	private EntitySet<Empleado> _Empleados;

	[Column(Storage = "_IdSeguro", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdSeguro
	{
		get
		{
			return _IdSeguro;
		}
		set
		{
			if (_IdSeguro != value)
			{
				SendPropertyChanging();
				_IdSeguro = value;
				SendPropertyChanged("IdSeguro");
			}
		}
	}

	[Column(Storage = "_DescripSeg", DbType = "VarChar(150)")]
	public string DescripSeg
	{
		get
		{
			return _DescripSeg;
		}
		set
		{
			if (!string.Equals(_DescripSeg, value))
			{
				SendPropertyChanging();
				_DescripSeg = value;
				SendPropertyChanged("DescripSeg");
			}
		}
	}

	[Column(Storage = "_DireccSeg", DbType = "VarChar(200)")]
	public string DireccSeg
	{
		get
		{
			return _DireccSeg;
		}
		set
		{
			if (!string.Equals(_DireccSeg, value))
			{
				SendPropertyChanging();
				_DireccSeg = value;
				SendPropertyChanged("DireccSeg");
			}
		}
	}

	[Column(Storage = "_TelefSeg", DbType = "VarChar(12)")]
	public string TelefSeg
	{
		get
		{
			return _TelefSeg;
		}
		set
		{
			if (!string.Equals(_TelefSeg, value))
			{
				SendPropertyChanging();
				_TelefSeg = value;
				SendPropertyChanged("TelefSeg");
			}
		}
	}

	[Association(Name = "Seguro_Empleado", Storage = "_Empleados", ThisKey = "IdSeguro", OtherKey = "IdSeguro")]
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

	public Seguro()
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
		entity.Seguro = this;
	}

	private void detach_Empleados(Empleado entity)
	{
		SendPropertyChanging();
		entity.Seguro = null;
	}
}
