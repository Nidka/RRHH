using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.TipoAdjudicacion")]
public class TipoAdjudicacion : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _TipoAdjudicacion;

	private string _Descripcion;

	private EntitySet<Consolidado> _Consolidado;

	[Column(Name = "TipoAdjudicacion", Storage = "_TipoAdjudicacion", DbType = "Char(6) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string TipoAdjudicacionValue
	{
		get
		{
			return _TipoAdjudicacion;
		}
		set
		{
			if (!string.Equals(_TipoAdjudicacion, value))
			{
				SendPropertyChanging();
				_TipoAdjudicacion = value;
				SendPropertyChanged("TipoAdjudicacion");
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

	[Association(Name = "TipoAdjudicacion_Consolidado", Storage = "_Consolidado", ThisKey = "TipoAdjudicacion", OtherKey = "TipoAdjudicacion")]
	public EntitySet<Consolidado> Consolidado
	{
		get
		{
			return _Consolidado;
		}
		set
		{
			_Consolidado.Assign(value);
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public TipoAdjudicacion()
	{
		_Consolidado = new EntitySet<Consolidado>(attach_Consolidado, detach_Consolidado);
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

	private void attach_Consolidado(Consolidado entity)
	{
		SendPropertyChanging();
		entity.TipoAdjudicacion1 = this;
	}

	private void detach_Consolidado(Consolidado entity)
	{
		SendPropertyChanging();
		entity.TipoAdjudicacion1 = null;
	}
}
