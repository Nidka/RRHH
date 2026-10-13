using System.ComponentModel;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.ParametrosCaja")]
public class ParametrosCaja : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _Years;

	private int _IdParametros;

	private int? _Mes;

	private string _Codigo;

	private string _Descripcion;

	private decimal? _Valor;

	[Column(Storage = "_Years", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int Years
	{
		get
		{
			return _Years;
		}
		set
		{
			if (_Years != value)
			{
				SendPropertyChanging();
				_Years = value;
				SendPropertyChanged("Years");
			}
		}
	}

	[Column(Storage = "_IdParametros", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdParametros
	{
		get
		{
			return _IdParametros;
		}
		set
		{
			if (_IdParametros != value)
			{
				SendPropertyChanging();
				_IdParametros = value;
				SendPropertyChanged("IdParametros");
			}
		}
	}

	[Column(Storage = "_Mes", DbType = "Int")]
	public int? Mes
	{
		get
		{
			return _Mes;
		}
		set
		{
			if (!_Mes.Equals(value))
			{
				SendPropertyChanging();
				_Mes = value;
				SendPropertyChanged("Mes");
			}
		}
	}

	[Column(Storage = "_Codigo", DbType = "VarChar(5)")]
	public string Codigo
	{
		get
		{
			return _Codigo;
		}
		set
		{
			if (!string.Equals(_Codigo, value))
			{
				SendPropertyChanging();
				_Codigo = value;
				SendPropertyChanged("Codigo");
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(100)")]
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

	[Column(Storage = "_Valor", DbType = "Decimal(11,2)")]
	public decimal? Valor
	{
		get
		{
			return _Valor;
		}
		set
		{
			if (!_Valor.Equals(value))
			{
				SendPropertyChanging();
				_Valor = value;
				SendPropertyChanged("Valor");
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
