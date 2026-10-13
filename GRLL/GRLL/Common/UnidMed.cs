using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.UnidMed")]
public class UnidMed : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdUnidMed;

	private string _Descripcion;

	private string _Abreviatura;

	private EntitySet<Actividad> _Actividad;

	private EntitySet<Objetivo> _Objetivo;

	[Column(Storage = "_IdUnidMed", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdUnidMed
	{
		get
		{
			return _IdUnidMed;
		}
		set
		{
			if (_IdUnidMed != value)
			{
				SendPropertyChanging();
				_IdUnidMed = value;
				SendPropertyChanged("IdUnidMed");
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(100)")]
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

	[Column(Storage = "_Abreviatura", DbType = "VarChar(6)")]
	public string Abreviatura
	{
		get
		{
			return _Abreviatura;
		}
		set
		{
			if (!string.Equals(_Abreviatura, value))
			{
				SendPropertyChanging();
				_Abreviatura = value;
				SendPropertyChanged("Abreviatura");
			}
		}
	}

	[Association(Name = "UnidMed_Actividad", Storage = "_Actividad", ThisKey = "IdUnidMed", OtherKey = "IdUnidMed")]
	public EntitySet<Actividad> Actividad
	{
		get
		{
			return _Actividad;
		}
		set
		{
			_Actividad.Assign(value);
		}
	}

	[Association(Name = "UnidMed_Objetivo", Storage = "_Objetivo", ThisKey = "IdUnidMed", OtherKey = "IdUnidMed")]
	public EntitySet<Objetivo> Objetivo
	{
		get
		{
			return _Objetivo;
		}
		set
		{
			_Objetivo.Assign(value);
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public UnidMed()
	{
		_Actividad = new EntitySet<Actividad>(attach_Actividad, detach_Actividad);
		_Objetivo = new EntitySet<Objetivo>(attach_Objetivo, detach_Objetivo);
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

	private void attach_Actividad(Actividad entity)
	{
		SendPropertyChanging();
		entity.UnidMed = this;
	}

	private void detach_Actividad(Actividad entity)
	{
		SendPropertyChanging();
		entity.UnidMed = null;
	}

	private void attach_Objetivo(Objetivo entity)
	{
		SendPropertyChanging();
		entity.UnidMed = this;
	}

	private void detach_Objetivo(Objetivo entity)
	{
		SendPropertyChanging();
		entity.UnidMed = null;
	}
}
