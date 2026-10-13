using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.EspecificaGasto")]
public class EspecificaGasto : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _IdEspecificaGasto;

	private string _Descripcion;

	private EntitySet<GastoPublico> _GastoPublico;

	[Column(Storage = "_IdEspecificaGasto", DbType = "Char(2) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdEspecificaGasto
	{
		get
		{
			return _IdEspecificaGasto;
		}
		set
		{
			if (!string.Equals(_IdEspecificaGasto, value))
			{
				SendPropertyChanging();
				_IdEspecificaGasto = value;
				SendPropertyChanged("IdEspecificaGasto");
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(80)")]
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

	[Association(Name = "EspecificaGasto_GastoPublico", Storage = "_GastoPublico", ThisKey = "IdEspecificaGasto", OtherKey = "IdEspecificaGasto")]
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

	public EspecificaGasto()
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
		entity.EspecificaGasto = this;
	}

	private void detach_GastoPublico(GastoPublico entity)
	{
		SendPropertyChanging();
		entity.EspecificaGasto = null;
	}
}
