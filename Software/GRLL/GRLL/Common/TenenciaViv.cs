using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.TenenciaViv")]
public class TenenciaViv : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdTenencia;

	private string _DescripTenencia;

	private EntitySet<Vivienda> _Vivienda;

	[Column(Storage = "_IdTenencia", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdTenencia
	{
		get
		{
			return _IdTenencia;
		}
		set
		{
			if (_IdTenencia != value)
			{
				SendPropertyChanging();
				_IdTenencia = value;
				SendPropertyChanged("IdTenencia");
			}
		}
	}

	[Column(Storage = "_DescripTenencia", DbType = "VarChar(30)")]
	public string DescripTenencia
	{
		get
		{
			return _DescripTenencia;
		}
		set
		{
			if (!string.Equals(_DescripTenencia, value))
			{
				SendPropertyChanging();
				_DescripTenencia = value;
				SendPropertyChanged("DescripTenencia");
			}
		}
	}

	[Association(Name = "TenenciaViv_Vivienda", Storage = "_Vivienda", ThisKey = "IdTenencia", OtherKey = "IdTenencia")]
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

	public TenenciaViv()
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
		entity.TenenciaViv = this;
	}

	private void detach_Vivienda(Vivienda entity)
	{
		SendPropertyChanging();
		entity.TenenciaViv = null;
	}
}
