using System.ComponentModel;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.TipoMoneda")]
public class TipoMoneda : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdTipoMoneda;

	private string _Descripcion;

	private string _Abreviatura;

	[Column(Storage = "_IdTipoMoneda", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdTipoMoneda
	{
		get
		{
			return _IdTipoMoneda;
		}
		set
		{
			if (_IdTipoMoneda != value)
			{
				SendPropertyChanging();
				_IdTipoMoneda = value;
				SendPropertyChanged("IdTipoMoneda");
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(50)")]
	public string Descripcion
	{
		get
		{
			return _Descripcion;
		}
		set
		{
			if (!string.Equals(_Descripcion, value))
			{
				SendPropertyChanging();
				_Descripcion = value;
				SendPropertyChanged("Descripcion");
			}
		}
	}

	[Column(Storage = "_Abreviatura", DbType = "VarChar(5)")]
	public string Abreviatura
	{
		get
		{
			return _Abreviatura;
		}
		set
		{
			if (!string.Equals(_Abreviatura, value))
			{
				SendPropertyChanging();
				_Abreviatura = value;
				SendPropertyChanged("Abreviatura");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

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
}
