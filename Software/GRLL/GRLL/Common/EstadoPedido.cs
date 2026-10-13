using System.ComponentModel;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.EstadoPedido")]
public class EstadoPedido : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _IdEstadoPedido;

	private string _Tabla;

	private string _Descripcion;

	[Column(Storage = "_IdEstadoPedido", DbType = "Char(2) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdEstadoPedido
	{
		get
		{
			return _IdEstadoPedido;
		}
		set
		{
			if (!string.Equals(_IdEstadoPedido, value))
			{
				SendPropertyChanging();
				_IdEstadoPedido = value;
				SendPropertyChanged("IdEstadoPedido");
			}
		}
	}

	[Column(Storage = "_Tabla", DbType = "Char(30) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string Tabla
	{
		get
		{
			return _Tabla;
		}
		set
		{
			if (!string.Equals(_Tabla, value))
			{
				SendPropertyChanging();
				_Tabla = value;
				SendPropertyChanged("Tabla");
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(20)")]
	public string Descripcion
	{
		get
		{
			return _Descripcion;
		}
		set
		{
			if (!string.Equals(_Descripcion, value))
			{
				SendPropertyChanging();
				_Descripcion = value;
				SendPropertyChanged("Descripcion");
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
