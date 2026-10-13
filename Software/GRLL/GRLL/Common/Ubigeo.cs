using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Ubigeo")]
public class Ubigeo : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _IdUbigeo;

	private string _Departamento;

	private string _Provincia;

	private string _Distrito;

	private string _Descripcion;

	private EntitySet<Meta> _Metas;

	[Column(Storage = "_IdUbigeo", DbType = "Char(6) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdUbigeo
	{
		get
		{
			return _IdUbigeo;
		}
		set
		{
			if (!string.Equals(_IdUbigeo, value))
			{
				SendPropertyChanging();
				_IdUbigeo = value;
				SendPropertyChanged("IdUbigeo");
			}
		}
	}

	[Column(Storage = "_Departamento", DbType = "Char(2) NOT NULL", CanBeNull = false)]
	public string Departamento
	{
		get
		{
			return _Departamento;
		}
		set
		{
			if (!string.Equals(_Departamento, value))
			{
				SendPropertyChanging();
				_Departamento = value;
				SendPropertyChanged("Departamento");
			}
		}
	}

	[Column(Storage = "_Provincia", DbType = "Char(2) NOT NULL", CanBeNull = false)]
	public string Provincia
	{
		get
		{
			return _Provincia;
		}
		set
		{
			if (!string.Equals(_Provincia, value))
			{
				SendPropertyChanging();
				_Provincia = value;
				SendPropertyChanged("Provincia");
			}
		}
	}

	[Column(Storage = "_Distrito", DbType = "Char(2) NOT NULL", CanBeNull = false)]
	public string Distrito
	{
		get
		{
			return _Distrito;
		}
		set
		{
			if (!string.Equals(_Distrito, value))
			{
				SendPropertyChanging();
				_Distrito = value;
				SendPropertyChanged("Distrito");
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(120)")]
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

	[Association(Name = "Ubigeo_Meta", Storage = "_Metas", ThisKey = "IdUbigeo", OtherKey = "IdUbigeo")]
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

	public Ubigeo()
	{
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

	private void attach_Metas(Meta entity)
	{
		SendPropertyChanging();
		entity.Ubigeo = this;
	}

	private void detach_Metas(Meta entity)
	{
		SendPropertyChanging();
		entity.Ubigeo = null;
	}
}
