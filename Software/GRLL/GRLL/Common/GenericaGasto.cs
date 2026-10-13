using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.GenericaGasto")]
public class GenericaGasto : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private char _IdGenericaGasto;

	private string _Descripcion;

	private EntitySet<GastoPublico> _GastoPublico;

	[Column(Storage = "_IdGenericaGasto", DbType = "Char(1) NOT NULL", IsPrimaryKey = true)]
	public char IdGenericaGasto
	{
		get
		{
			return _IdGenericaGasto;
		}
		set
		{
			if (_IdGenericaGasto != value)
			{
				SendPropertyChanging();
				_IdGenericaGasto = value;
				SendPropertyChanged("IdGenericaGasto");
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

	[Association(Name = "GenericaGasto_GastoPublico", Storage = "_GastoPublico", ThisKey = "IdGenericaGasto", OtherKey = "IdGenericaGasto")]
	public EntitySet<GastoPublico> GastoPublico
	{
		get
		{
			return _GastoPublico;
		}
		set
		{
			_GastoPublico.Assign(value);
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public GenericaGasto()
	{
		_GastoPublico = new EntitySet<GastoPublico>(attach_GastoPublico, detach_GastoPublico);
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

	private void attach_GastoPublico(GastoPublico entity)
	{
		SendPropertyChanging();
		entity.GenericaGasto = this;
	}

	private void detach_GastoPublico(GastoPublico entity)
	{
		SendPropertyChanging();
		entity.GenericaGasto = null;
	}
}
