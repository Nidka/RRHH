using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Tra_Acuerdo")]
public class Tra_Acuerdo : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _Nro_Acuerdo;

	private string _Sumilla;

	private EntitySet<Tra_Articulo_Acuerdo> _Tra_Articulo_Acuerdo;

	[Column(Storage = "_Nro_Acuerdo", DbType = "Char(10) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string Nro_Acuerdo
	{
		get
		{
			return _Nro_Acuerdo;
		}
		set
		{
			if (!string.Equals(_Nro_Acuerdo, value))
			{
				SendPropertyChanging();
				_Nro_Acuerdo = value;
				SendPropertyChanged("Nro_Acuerdo");
			}
		}
	}

	[Column(Storage = "_Sumilla", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
	public string Sumilla
	{
		get
		{
			return _Sumilla;
		}
		set
		{
			if (!string.Equals(_Sumilla, value))
			{
				SendPropertyChanging();
				_Sumilla = value;
				SendPropertyChanged("Sumilla");
			}
		}
	}

	[Association(Name = "Tra_Acuerdo_Tra_Articulo_Acuerdo", Storage = "_Tra_Articulo_Acuerdo", ThisKey = "Nro_Acuerdo", OtherKey = "Nro_Acuerdo")]
	public EntitySet<Tra_Articulo_Acuerdo> Tra_Articulo_Acuerdo
	{
		get
		{
			return _Tra_Articulo_Acuerdo;
		}
		set
		{
			_Tra_Articulo_Acuerdo.Assign(value);
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Tra_Acuerdo()
	{
		_Tra_Articulo_Acuerdo = new EntitySet<Tra_Articulo_Acuerdo>(attach_Tra_Articulo_Acuerdo, detach_Tra_Articulo_Acuerdo);
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

	private void attach_Tra_Articulo_Acuerdo(Tra_Articulo_Acuerdo entity)
	{
		SendPropertyChanging();
		entity.Tra_Acuerdo = this;
	}

	private void detach_Tra_Articulo_Acuerdo(Tra_Articulo_Acuerdo entity)
	{
		SendPropertyChanging();
		entity.Tra_Acuerdo = null;
	}
}
