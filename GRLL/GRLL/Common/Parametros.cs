using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Parametros")]
public class Parametros : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _IdParametro;

	private string _Descripcion;

	private EntitySet<Parametro_Periodo> _Parametro_Periodo;

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
				SendPropertyChanging();
				_IdParametro = value;
				SendPropertyChanged("IdParametro");
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

	[Association(Name = "Parametros_Parametro_Periodo", Storage = "_Parametro_Periodo", ThisKey = "IdParametro", OtherKey = "IdParametro")]
	public EntitySet<Parametro_Periodo> Parametro_Periodo
	{
		get
		{
			return _Parametro_Periodo;
		}
		set
		{
			_Parametro_Periodo.Assign(value);
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Parametros()
	{
		_Parametro_Periodo = new EntitySet<Parametro_Periodo>(attach_Parametro_Periodo, detach_Parametro_Periodo);
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

	private void attach_Parametro_Periodo(Parametro_Periodo entity)
	{
		SendPropertyChanging();
		entity.Parametros = this;
	}

	private void detach_Parametro_Periodo(Parametro_Periodo entity)
	{
		SendPropertyChanging();
		entity.Parametros = null;
	}
}
