using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.ExcretasViv")]
public class ExcretasViv : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdExcretas;

	private string _DescripExcretas;

	private EntitySet<Vivienda> _Vivienda;

	[Column(Storage = "_IdExcretas", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdExcretas
	{
		get
		{
			return _IdExcretas;
		}
		set
		{
			if (_IdExcretas != value)
			{
				SendPropertyChanging();
				_IdExcretas = value;
				SendPropertyChanged("IdExcretas");
			}
		}
	}

	[Column(Storage = "_DescripExcretas", DbType = "VarChar(33)")]
	public string DescripExcretas
	{
		get
		{
			return _DescripExcretas;
		}
		set
		{
			if (!string.Equals(_DescripExcretas, value))
			{
				SendPropertyChanging();
				_DescripExcretas = value;
				SendPropertyChanged("DescripExcretas");
			}
		}
	}

	[Association(Name = "ExcretasViv_Vivienda", Storage = "_Vivienda", ThisKey = "IdExcretas", OtherKey = "IdExcretas")]
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

	public ExcretasViv()
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
		entity.ExcretasViv = this;
	}

	private void detach_Vivienda(Vivienda entity)
	{
		SendPropertyChanging();
		entity.ExcretasViv = null;
	}
}
