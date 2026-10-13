using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Parametro_Periodo")]
public class Parametro_Periodo : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _Periodo;

	private string _IdParametro;

	private string _Valor;

	private EntityRef<Parametros> _Parametros;

	[Column(Storage = "_Periodo", DbType = "Char(6) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string Periodo
	{
		get
		{
			return _Periodo;
		}
		set
		{
			if (!string.Equals(_Periodo, value))
			{
				SendPropertyChanging();
				_Periodo = value;
				SendPropertyChanged("Periodo");
			}
		}
	}

	[Column(Storage = "_IdParametro", DbType = "Char(10) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdParametro
	{
		get
		{
			return _IdParametro;
		}
		set
		{
			if (!string.Equals(_IdParametro, value))
			{
				if (_Parametros.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdParametro = value;
				SendPropertyChanged("IdParametro");
			}
		}
	}

	[Column(Storage = "_Valor", DbType = "VarChar(120)")]
	public string Valor
	{
		get
		{
			return _Valor;
		}
		set
		{
			if (!string.Equals(_Valor, value))
			{
				SendPropertyChanging();
				_Valor = value;
				SendPropertyChanged("Valor");
			}
		}
	}

	[Association(Name = "Parametros_Parametro_Periodo", Storage = "_Parametros", ThisKey = "IdParametro", OtherKey = "IdParametro", IsForeignKey = true)]
	public Parametros Parametros
	{
		get
		{
			return _Parametros.Entity;
		}
		set
		{
			Parametros previousValue = _Parametros.Entity;
			if (!object.Equals(previousValue, value) || !_Parametros.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_Parametros.Entity = null;
					previousValue.Parametro_Periodo.Remove(this);
				}
				_Parametros.Entity = value;
				if (value != null)
				{
					value.Parametro_Periodo.Add(this);
					_IdParametro = value.IdParametro;
				}
				else
				{
					_IdParametro = null;
				}
				SendPropertyChanged("Parametros");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Parametro_Periodo()
	{
		_Parametros = default(EntityRef<Parametros>);
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
}
