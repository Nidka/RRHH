using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.UnidadMedida")]
public class UnidadMedida : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _IdUnidadMedida;

	private string _Descripcion;

	private string _Abreviado;

	private EntitySet<Bien> _Bien;

	private EntitySet<Meta> _Metas;

	[Column(Storage = "_IdUnidadMedida", DbType = "Char(4) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdUnidadMedida
	{
		get
		{
			return _IdUnidadMedida;
		}
		set
		{
			if (!string.Equals(_IdUnidadMedida, value))
			{
				SendPropertyChanging();
				_IdUnidadMedida = value;
				SendPropertyChanged("IdUnidadMedida");
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

	[Column(Storage = "_Abreviado", DbType = "Char(4)")]
	public string Abreviado
	{
		get
		{
			return _Abreviado;
		}
		set
		{
			if (!string.Equals(_Abreviado, value))
			{
				SendPropertyChanging();
				_Abreviado = value;
				SendPropertyChanged("Abreviado");
			}
		}
	}

	[Association(Name = "UnidadMedida_Bien", Storage = "_Bien", ThisKey = "IdUnidadMedida", OtherKey = "IdUnidadMedida")]
	public EntitySet<Bien> Bien
	{
		get
		{
			return _Bien;
		}
		set
		{
			_Bien.Assign(value);
		}
	}

	[Association(Name = "UnidadMedida_Meta", Storage = "_Metas", ThisKey = "IdUnidadMedida", OtherKey = "IdUnidadMedida")]
	public EntitySet<Meta> Metas
	{
		get
		{
			return _Metas;
		}
		set
		{
			_Metas.Assign(value);
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public UnidadMedida()
	{
		_Bien = new EntitySet<Bien>(attach_Bien, detach_Bien);
		_Metas = new EntitySet<Meta>(attach_Metas, detach_Metas);
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

	private void attach_Bien(Bien entity)
	{
		SendPropertyChanging();
		entity.UnidadMedida = this;
	}

	private void detach_Bien(Bien entity)
	{
		SendPropertyChanging();
		entity.UnidadMedida = null;
	}

	private void attach_Metas(Meta entity)
	{
		SendPropertyChanging();
		entity.UnidadMedida = this;
	}

	private void detach_Metas(Meta entity)
	{
		SendPropertyChanging();
		entity.UnidadMedida = null;
	}
}
