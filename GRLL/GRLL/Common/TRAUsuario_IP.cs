using System.ComponentModel;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.TRAUsuario_IP")]
public class TRAUsuario_IP : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdUsuario;

	private string _PC_Name;

	private string _IP_Address;

	private bool _Estado;

	[Column(Storage = "_IdUsuario", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdUsuario
	{
		get
		{
			return _IdUsuario;
		}
		set
		{
			if (_IdUsuario != value)
			{
				SendPropertyChanging();
				_IdUsuario = value;
				SendPropertyChanged("IdUsuario");
			}
		}
	}

	[Column(Storage = "_PC_Name", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
	public string PC_Name
	{
		get
		{
			return _PC_Name;
		}
		set
		{
			if (!string.Equals(_PC_Name, value))
			{
				SendPropertyChanging();
				_PC_Name = value;
				SendPropertyChanged("PC_Name");
			}
		}
	}

	[Column(Storage = "_IP_Address", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
	public string IP_Address
	{
		get
		{
			return _IP_Address;
		}
		set
		{
			if (!string.Equals(_IP_Address, value))
			{
				SendPropertyChanging();
				_IP_Address = value;
				SendPropertyChanged("IP_Address");
			}
		}
	}

	[Column(Storage = "_Estado", DbType = "Bit NOT NULL")]
	public bool Estado
	{
		get
		{
			return _Estado;
		}
		set
		{
			if (_Estado != value)
			{
				SendPropertyChanging();
				_Estado = value;
				SendPropertyChanged("Estado");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

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
