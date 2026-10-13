using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.TipoInstitucion")]
public class TipoInstitucion : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdTipoInstitucion;

	private string _DescripTipoInstitucion;

	private EntitySet<ExpLaboral> _ExpLaboral;

	[Column(Storage = "_IdTipoInstitucion", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdTipoInstitucion
	{
		get
		{
			return _IdTipoInstitucion;
		}
		set
		{
			if (_IdTipoInstitucion != value)
			{
				SendPropertyChanging();
				_IdTipoInstitucion = value;
				SendPropertyChanged("IdTipoInstitucion");
			}
		}
	}

	[Column(Storage = "_DescripTipoInstitucion", DbType = "VarChar(15)")]
	public string DescripTipoInstitucion
	{
		get
		{
			return _DescripTipoInstitucion;
		}
		set
		{
			if (!string.Equals(_DescripTipoInstitucion, value))
			{
				SendPropertyChanging();
				_DescripTipoInstitucion = value;
				SendPropertyChanged("DescripTipoInstitucion");
			}
		}
	}

	[Association(Name = "TipoInstitucion_ExpLaboral", Storage = "_ExpLaboral", ThisKey = "IdTipoInstitucion", OtherKey = "IdTipoInstitucion")]
	public EntitySet<ExpLaboral> ExpLaboral
	{
		get
		{
			return _ExpLaboral;
		}
		set
		{
			_ExpLaboral.Assign(value);
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public TipoInstitucion()
	{
		_ExpLaboral = new EntitySet<ExpLaboral>(attach_ExpLaboral, detach_ExpLaboral);
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

	private void attach_ExpLaboral(ExpLaboral entity)
	{
		SendPropertyChanging();
		entity.TipoInstitucion = this;
	}

	private void detach_ExpLaboral(ExpLaboral entity)
	{
		SendPropertyChanging();
		entity.TipoInstitucion = null;
	}
}
