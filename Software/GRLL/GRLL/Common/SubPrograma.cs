using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.SubPrograma")]
public class SubPrograma : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _IdFuncion;

	private string _Anio;

	private string _IdPrograma;

	private string _IdSubPrograma;

	private string _Descripcion;

	private EntitySet<ProgramaProp> _ProgramaProp;

	private EntityRef<Programa> _Programa;

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
				if (_Programa.HasLoadedOrAssignedValue)
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
				if (_Programa.HasLoadedOrAssignedValue)
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
				if (_Programa.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdPrograma = value;
				SendPropertyChanged("IdPrograma");
			}
		}
	}

	[Column(Storage = "_IdSubPrograma", DbType = "Char(4) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdSubPrograma
	{
		get
		{
			return _IdSubPrograma;
		}
		set
		{
			if (!string.Equals(_IdSubPrograma, value))
			{
				SendPropertyChanging();
				_IdSubPrograma = value;
				SendPropertyChanged("IdSubPrograma");
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

	[Association(Name = "SubPrograma_ProgramaProp", Storage = "_ProgramaProp", ThisKey = "IdFuncion,Anio,IdPrograma,IdSubPrograma", OtherKey = "IdFuncion,Anio,IdPrograma,IdSubPrograma")]
	public EntitySet<ProgramaProp> ProgramaProp
	{
		get
		{
			return _ProgramaProp;
		}
		set
		{
			_ProgramaProp.Assign(value);
		}
	}

	[Association(Name = "Programa_SubPrograma", Storage = "_Programa", ThisKey = "IdFuncion,Anio,IdPrograma", OtherKey = "IdFuncion,Anio,IdPrograma", IsForeignKey = true, DeleteOnNull = true, DeleteRule = "CASCADE")]
	public Programa Programa
	{
		get
		{
			return _Programa.Entity;
		}
		set
		{
			Programa previousValue = _Programa.Entity;
			if (!object.Equals(previousValue, value) || !_Programa.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_Programa.Entity = null;
					previousValue.SubPrograma.Remove(this);
				}
				_Programa.Entity = value;
				if (value != null)
				{
					value.SubPrograma.Add(this);
					_IdFuncion = value.IdFuncion;
					_Anio = value.Anio;
					_IdPrograma = value.IdPrograma;
				}
				else
				{
					_IdFuncion = null;
					_Anio = null;
					_IdPrograma = null;
				}
				SendPropertyChanged("Programa");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public SubPrograma()
	{
		_ProgramaProp = new EntitySet<ProgramaProp>(attach_ProgramaProp, detach_ProgramaProp);
		_Programa = default(EntityRef<Programa>);
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

	private void attach_ProgramaProp(ProgramaProp entity)
	{
		SendPropertyChanging();
		entity.SubPrograma = this;
	}

	private void detach_ProgramaProp(ProgramaProp entity)
	{
		SendPropertyChanging();
		entity.SubPrograma = null;
	}
}
