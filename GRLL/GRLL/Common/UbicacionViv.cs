using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.UbicacionViv")]
public class UbicacionViv : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdUbicacion;

	private string _DescripUbicacion;

	private EntitySet<Vivienda> _Vivienda;

	[Column(Storage = "_IdUbicacion", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdUbicacion
	{
		get
		{
			return _IdUbicacion;
		}
		set
		{
			if (_IdUbicacion != value)
			{
				SendPropertyChanging();
				_IdUbicacion = value;
				SendPropertyChanged("IdUbicacion");
			}
		}
	}

	[Column(Storage = "_DescripUbicacion", DbType = "VarChar(22)")]
	public string DescripUbicacion
	{
		get
		{
			return _DescripUbicacion;
		}
		set
		{
			if (!string.Equals(_DescripUbicacion, value))
			{
				SendPropertyChanging();
				_DescripUbicacion = value;
				SendPropertyChanged("DescripUbicacion");
			}
		}
	}

	[Association(Name = "UbicacionViv_Vivienda", Storage = "_Vivienda", ThisKey = "IdUbicacion", OtherKey = "IdUbicacion")]
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

	public UbicacionViv()
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
		entity.UbicacionViv = this;
	}

	private void detach_Vivienda(Vivienda entity)
	{
		SendPropertyChanging();
		entity.UbicacionViv = null;
	}
}
