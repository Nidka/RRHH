using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.TipoViv")]
public class TipoViv : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdTipo;

	private string _DescripTipo;

	private EntitySet<Vivienda> _Vivienda;

	[Column(Storage = "_IdTipo", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdTipo
	{
		get
		{
			return _IdTipo;
		}
		set
		{
			if (_IdTipo != value)
			{
				SendPropertyChanging();
				_IdTipo = value;
				SendPropertyChanged("IdTipo");
			}
		}
	}

	[Column(Storage = "_DescripTipo", DbType = "VarChar(20)")]
	public string DescripTipo
	{
		get
		{
			return _DescripTipo;
		}
		set
		{
			if (!string.Equals(_DescripTipo, value))
			{
				SendPropertyChanging();
				_DescripTipo = value;
				SendPropertyChanged("DescripTipo");
			}
		}
	}

	[Association(Name = "TipoViv_Vivienda", Storage = "_Vivienda", ThisKey = "IdTipo", OtherKey = "IdTipo")]
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

	public TipoViv()
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
		entity.TipoViv = this;
	}

	private void detach_Vivienda(Vivienda entity)
	{
		SendPropertyChanging();
		entity.TipoViv = null;
	}
}
