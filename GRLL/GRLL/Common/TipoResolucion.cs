using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.TipoResolucion")]
public class TipoResolucion : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _idTipoResolucion;

	private string _DescripTipoResolucion;

	private EntitySet<Resolucion> _Resolucions;

	[Column(Storage = "_idTipoResolucion", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int idTipoResolucion
	{
		get
		{
			return _idTipoResolucion;
		}
		set
		{
			if (_idTipoResolucion != value)
			{
				SendPropertyChanging();
				_idTipoResolucion = value;
				SendPropertyChanged("idTipoResolucion");
			}
		}
	}

	[Column(Storage = "_DescripTipoResolucion", DbType = "NVarChar(50)")]
	public string DescripTipoResolucion
	{
		get
		{
			return _DescripTipoResolucion;
		}
		set
		{
			if (!string.Equals(_DescripTipoResolucion, value))
			{
				SendPropertyChanging();
				_DescripTipoResolucion = value;
				SendPropertyChanged("DescripTipoResolucion");
			}
		}
	}

	[Association(Name = "TipoResolucion_Resolucion", Storage = "_Resolucions", ThisKey = "idTipoResolucion", OtherKey = "idTipoResolucion")]
	public EntitySet<Resolucion> Resolucions
	{
		get
		{
			return _Resolucions;
		}
		set
		{
			_Resolucions.Assign(value);
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public TipoResolucion()
	{
		_Resolucions = new EntitySet<Resolucion>(attach_Resolucions, detach_Resolucions);
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

	private void attach_Resolucions(Resolucion entity)
	{
		SendPropertyChanging();
		entity.TipoResolucion = this;
	}

	private void detach_Resolucions(Resolucion entity)
	{
		SendPropertyChanging();
		entity.TipoResolucion = null;
	}
}
