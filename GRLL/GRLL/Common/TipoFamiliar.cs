using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.TipoFamiliar")]
public class TipoFamiliar : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdTipoFam;

	private string _DescripTipoFam;

	private EntitySet<Familiar> _Familiar;

	[Column(Storage = "_IdTipoFam", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdTipoFam
	{
		get
		{
			return _IdTipoFam;
		}
		set
		{
			if (_IdTipoFam != value)
			{
				SendPropertyChanging();
				_IdTipoFam = value;
				SendPropertyChanged("IdTipoFam");
			}
		}
	}

	[Column(Storage = "_DescripTipoFam", DbType = "VarChar(10)")]
	public string DescripTipoFam
	{
		get
		{
			return _DescripTipoFam;
		}
		set
		{
			if (!string.Equals(_DescripTipoFam, value))
			{
				SendPropertyChanging();
				_DescripTipoFam = value;
				SendPropertyChanged("DescripTipoFam");
			}
		}
	}

	[Association(Name = "TipoFamiliar_Familiar", Storage = "_Familiar", ThisKey = "IdTipoFam", OtherKey = "IdTipoFam")]
	public EntitySet<Familiar> Familiar
	{
		get
		{
			return _Familiar;
		}
		set
		{
			_Familiar.Assign(value);
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public TipoFamiliar()
	{
		_Familiar = new EntitySet<Familiar>(attach_Familiar, detach_Familiar);
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

	private void attach_Familiar(Familiar entity)
	{
		SendPropertyChanging();
		entity.TipoFamiliar = this;
	}

	private void detach_Familiar(Familiar entity)
	{
		SendPropertyChanging();
		entity.TipoFamiliar = null;
	}
}
