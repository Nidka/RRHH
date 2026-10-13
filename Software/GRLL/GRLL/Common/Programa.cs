using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Programa")]
public class Programa : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _IdFuncion;

	private string _Anio;

	private string _IdPrograma;

	private string _Descripcion;

	private EntitySet<SubPrograma> _SubPrograma;

	private EntityRef<Funcion> _Funcion;

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
				if (_Funcion.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
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
				if (_Funcion.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_Anio = value;
				SendPropertyChanged("Anio");
			}
		}
	}

	[Column(Storage = "_IdPrograma", DbType = "Char(3) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdPrograma
	{
		get
		{
			return _IdPrograma;
		}
		set
		{
			if (!string.Equals(_IdPrograma, value))
			{
				SendPropertyChanging();
				_IdPrograma = value;
				SendPropertyChanged("IdPrograma");
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(80)")]
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

	[Association(Name = "Programa_SubPrograma", Storage = "_SubPrograma", ThisKey = "IdFuncion,Anio,IdPrograma", OtherKey = "IdFuncion,Anio,IdPrograma")]
	public EntitySet<SubPrograma> SubPrograma
	{
		get
		{
			return _SubPrograma;
		}
		set
		{
			_SubPrograma.Assign(value);
		}
	}

	[Association(Name = "Funcion_Programa", Storage = "_Funcion", ThisKey = "IdFuncion,Anio", OtherKey = "IdFuncion,Anio", IsForeignKey = true, DeleteOnNull = true, DeleteRule = "CASCADE")]
	public Funcion Funcion
	{
		get
		{
			return _Funcion.Entity;
		}
		set
		{
			Funcion previousValue = _Funcion.Entity;
			if (!object.Equals(previousValue, value) || !_Funcion.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_Funcion.Entity = null;
					previousValue.Programa.Remove(this);
				}
				_Funcion.Entity = value;
				if (value != null)
				{
					value.Programa.Add(this);
					_IdFuncion = value.IdFuncion;
					_Anio = value.Anio;
				}
				else
				{
					_IdFuncion = null;
					_Anio = null;
				}
				SendPropertyChanged("Funcion");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Programa()
	{
		_SubPrograma = new EntitySet<SubPrograma>(attach_SubPrograma, detach_SubPrograma);
		_Funcion = default(EntityRef<Funcion>);
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

	private void attach_SubPrograma(SubPrograma entity)
	{
		SendPropertyChanging();
		entity.Programa = this;
	}

	private void detach_SubPrograma(SubPrograma entity)
	{
		SendPropertyChanging();
		entity.Programa = null;
	}
}
