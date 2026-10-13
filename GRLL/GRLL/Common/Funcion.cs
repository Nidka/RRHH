using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Funcion")]
public class Funcion : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _IdFuncion;

	private string _Anio;

	private string _Descripcion;

	private EntitySet<Programa> _Programa;

	[Column(Storage = "_IdFuncion", DbType = "Char(2) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdFuncion
	{
		get
		{
			return _IdFuncion;
		}
		set
		{
			if (!string.Equals(_IdFuncion, value))
			{
				SendPropertyChanging();
				_IdFuncion = value;
				SendPropertyChanged("IdFuncion");
			}
		}
	}

	[Column(Storage = "_Anio", DbType = "Char(4) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string Anio
	{
		get
		{
			return _Anio;
		}
		set
		{
			if (!string.Equals(_Anio, value))
			{
				SendPropertyChanging();
				_Anio = value;
				SendPropertyChanged("Anio");
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(50)")]
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

	[Association(Name = "Funcion_Programa", Storage = "_Programa", ThisKey = "IdFuncion,Anio", OtherKey = "IdFuncion,Anio")]
	public EntitySet<Programa> Programa
	{
		get
		{
			return _Programa;
		}
		set
		{
			_Programa.Assign(value);
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Funcion()
	{
		_Programa = new EntitySet<Programa>(attach_Programa, detach_Programa);
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

	private void attach_Programa(Programa entity)
	{
		SendPropertyChanging();
		entity.Funcion = this;
	}

	private void detach_Programa(Programa entity)
	{
		SendPropertyChanging();
		entity.Funcion = null;
	}
}
