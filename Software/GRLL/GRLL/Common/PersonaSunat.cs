using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.PersonaSunat")]
public class PersonaSunat : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdPersonaSunat;

	private string _Descripcion;

	private EntitySet<Proveedor> _Proveedor;

	[Column(Storage = "_IdPersonaSunat", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdPersonaSunat
	{
		get
		{
			return _IdPersonaSunat;
		}
		set
		{
			if (_IdPersonaSunat != value)
			{
				SendPropertyChanging();
				_IdPersonaSunat = value;
				SendPropertyChanged("IdPersonaSunat");
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(30)")]
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

	[Association(Name = "PersonaSunat_Proveedor", Storage = "_Proveedor", ThisKey = "IdPersonaSunat", OtherKey = "EstadoSunat")]
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

	public PersonaSunat()
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
		entity.PersonaSunat = this;
	}

	private void detach_Proveedor(Proveedor entity)
	{
		SendPropertyChanging();
		entity.PersonaSunat = null;
	}
}
