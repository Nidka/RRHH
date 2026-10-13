using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.AFP")]
public class AFP : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdAFP;

	private string _DescripAFP;

	private string _DireccAFP;

	private string _TelefAFP;

	private string _NomContAFP;

	private EntitySet<Empleado> _Empleados;

	[Column(Storage = "_IdAFP", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdAFP
	{
		get
		{
			return _IdAFP;
		}
		set
		{
			if (_IdAFP != value)
			{
				SendPropertyChanging();
				_IdAFP = value;
				SendPropertyChanged("IdAFP");
			}
		}
	}

	[Column(Storage = "_DescripAFP", DbType = "VarChar(50)")]
	public string DescripAFP
	{
		get
		{
			return _DescripAFP;
		}
		set
		{
			if (!string.Equals(_DescripAFP, value))
			{
				SendPropertyChanging();
				_DescripAFP = value;
				SendPropertyChanged("DescripAFP");
			}
		}
	}

	[Column(Storage = "_DireccAFP", DbType = "VarChar(200)")]
	public string DireccAFP
	{
		get
		{
			return _DireccAFP;
		}
		set
		{
			if (!string.Equals(_DireccAFP, value))
			{
				SendPropertyChanging();
				_DireccAFP = value;
				SendPropertyChanged("DireccAFP");
			}
		}
	}

	[Column(Storage = "_TelefAFP", DbType = "VarChar(12)")]
	public string TelefAFP
	{
		get
		{
			return _TelefAFP;
		}
		set
		{
			if (!string.Equals(_TelefAFP, value))
			{
				SendPropertyChanging();
				_TelefAFP = value;
				SendPropertyChanged("TelefAFP");
			}
		}
	}

	[Column(Storage = "_NomContAFP", DbType = "VarChar(100)")]
	public string NomContAFP
	{
		get
		{
			return _NomContAFP;
		}
		set
		{
			if (!string.Equals(_NomContAFP, value))
			{
				SendPropertyChanging();
				_NomContAFP = value;
				SendPropertyChanged("NomContAFP");
			}
		}
	}

	[Association(Name = "AFP_Empleado", Storage = "_Empleados", ThisKey = "IdAFP", OtherKey = "IdAFP")]
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

	public AFP()
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
		entity.AFP = this;
	}

	private void detach_Empleados(Empleado entity)
	{
		SendPropertyChanging();
		entity.AFP = null;
	}
}
