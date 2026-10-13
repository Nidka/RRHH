using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.TipoPermiso")]
public class TipoPermiso : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _idTipoPermiso;

	private string _DescripTipoPermiso;

	private EntitySet<Motivo_Perm> _Motivo_Perms;

	[Column(Storage = "_idTipoPermiso", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int idTipoPermiso
	{
		get
		{
			return _idTipoPermiso;
		}
		set
		{
			if (_idTipoPermiso != value)
			{
				SendPropertyChanging();
				_idTipoPermiso = value;
				SendPropertyChanged("idTipoPermiso");
			}
		}
	}

	[Column(Storage = "_DescripTipoPermiso", DbType = "VarChar(50)")]
	public string DescripTipoPermiso
	{
		get
		{
			return _DescripTipoPermiso;
		}
		set
		{
			if (!string.Equals(_DescripTipoPermiso, value))
			{
				SendPropertyChanging();
				_DescripTipoPermiso = value;
				SendPropertyChanged("DescripTipoPermiso");
			}
		}
	}

	[Association(Name = "TipoPermiso_Motivo_Perm", Storage = "_Motivo_Perms", ThisKey = "idTipoPermiso", OtherKey = "idTipoPermiso")]
	public EntitySet<Motivo_Perm> Motivo_Perms
	{
		get
		{
			return _Motivo_Perms;
		}
		set
		{
			_Motivo_Perms.Assign(value);
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public TipoPermiso()
	{
		_Motivo_Perms = new EntitySet<Motivo_Perm>(attach_Motivo_Perms, detach_Motivo_Perms);
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

	private void attach_Motivo_Perms(Motivo_Perm entity)
	{
		SendPropertyChanging();
		entity.TipoPermiso = this;
	}

	private void detach_Motivo_Perms(Motivo_Perm entity)
	{
		SendPropertyChanging();
		entity.TipoPermiso = null;
	}
}
