using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.AlumbradoViv")]
public class AlumbradoViv : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdAlumbrado;

	private string _DescripAlumbrado;

	private EntitySet<Vivienda> _Vivienda;

	[Column(Storage = "_IdAlumbrado", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdAlumbrado
	{
		get
		{
			return _IdAlumbrado;
		}
		set
		{
			if (_IdAlumbrado != value)
			{
				SendPropertyChanging();
				_IdAlumbrado = value;
				SendPropertyChanged("IdAlumbrado");
			}
		}
	}

	[Column(Storage = "_DescripAlumbrado", DbType = "VarChar(20)")]
	public string DescripAlumbrado
	{
		get
		{
			return _DescripAlumbrado;
		}
		set
		{
			if (!string.Equals(_DescripAlumbrado, value))
			{
				SendPropertyChanging();
				_DescripAlumbrado = value;
				SendPropertyChanged("DescripAlumbrado");
			}
		}
	}

	[Association(Name = "AlumbradoViv_Vivienda", Storage = "_Vivienda", ThisKey = "IdAlumbrado", OtherKey = "IdAlumbrado")]
	public EntitySet<Vivienda> Vivienda
	{
		get
		{
			return _Vivienda;
		}
		set
		{
			_Vivienda.Assign(value);
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public AlumbradoViv()
	{
		_Vivienda = new EntitySet<Vivienda>(attach_Vivienda, detach_Vivienda);
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

	private void attach_Vivienda(Vivienda entity)
	{
		SendPropertyChanging();
		entity.AlumbradoViv = this;
	}

	private void detach_Vivienda(Vivienda entity)
	{
		SendPropertyChanging();
		entity.AlumbradoViv = null;
	}
}
