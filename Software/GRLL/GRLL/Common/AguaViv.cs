using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.AguaViv")]
public class AguaViv : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdAgua;

	private string _DescripAgua;

	private EntitySet<Vivienda> _Vivienda;

	[Column(Storage = "_IdAgua", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdAgua
	{
		get
		{
			return _IdAgua;
		}
		set
		{
			if (_IdAgua != value)
			{
				SendPropertyChanging();
				_IdAgua = value;
				SendPropertyChanged("IdAgua");
			}
		}
	}

	[Column(Storage = "_DescripAgua", DbType = "VarChar(33)")]
	public string DescripAgua
	{
		get
		{
			return _DescripAgua;
		}
		set
		{
			if (!string.Equals(_DescripAgua, value))
			{
				SendPropertyChanging();
				_DescripAgua = value;
				SendPropertyChanged("DescripAgua");
			}
		}
	}

	[Association(Name = "AguaViv_Vivienda", Storage = "_Vivienda", ThisKey = "IdAgua", OtherKey = "IdAgua")]
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

	public AguaViv()
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
		entity.AguaViv = this;
	}

	private void detach_Vivienda(Vivienda entity)
	{
		SendPropertyChanging();
		entity.AguaViv = null;
	}
}
