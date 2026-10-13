using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.EstadoSunat")]
public class EstadoSunat : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _EstadoSunat;

	private string _Descripcion;

	private EntitySet<Proveedor> _Proveedor;

	[Column(Name = "EstadoSunat", Storage = "_EstadoSunat", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int EstadoSunatValue
	{
		get
		{
			return _EstadoSunat;
		}
		set
		{
			if (_EstadoSunat != value)
			{
				SendPropertyChanging();
				_EstadoSunat = value;
				SendPropertyChanged("EstadoSunat");
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(35)")]
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

	[Association(Name = "EstadoSunat_Proveedor", Storage = "_Proveedor", ThisKey = "EstadoSunat", OtherKey = "EstadoSunat")]
	public EntitySet<Proveedor> Proveedor
	{
		get
		{
			return _Proveedor;
		}
		set
		{
			_Proveedor.Assign(value);
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public EstadoSunat()
	{
		_Proveedor = new EntitySet<Proveedor>(attach_Proveedor, detach_Proveedor);
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

	private void attach_Proveedor(Proveedor entity)
	{
		SendPropertyChanging();
		entity.EstadoSunat1 = this;
	}

	private void detach_Proveedor(Proveedor entity)
	{
		SendPropertyChanging();
		entity.EstadoSunat1 = null;
	}
}
