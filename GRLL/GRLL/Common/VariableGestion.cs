using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.VariableGestion")]
public class VariableGestion : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdVariable;

	private string _Descripcion;

	private short? _MaxPuntaje;

	private short? _MinPuntaje;

	private EntitySet<EvaluacionGestion> _EvaluacionGestion;

	[Column(Storage = "_IdVariable", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdVariable
	{
		get
		{
			return _IdVariable;
		}
		set
		{
			if (_IdVariable != value)
			{
				SendPropertyChanging();
				_IdVariable = value;
				SendPropertyChanged("IdVariable");
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(250)")]
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

	[Column(Storage = "_MaxPuntaje", DbType = "SmallInt")]
	public short? MaxPuntaje
	{
		get
		{
			return _MaxPuntaje;
		}
		set
		{
			if (!_MaxPuntaje.Equals(value))
			{
				SendPropertyChanging();
				_MaxPuntaje = value;
				SendPropertyChanged("MaxPuntaje");
			}
		}
	}

	[Column(Storage = "_MinPuntaje", DbType = "SmallInt")]
	public short? MinPuntaje
	{
		get
		{
			return _MinPuntaje;
		}
		set
		{
			if (!_MinPuntaje.Equals(value))
			{
				SendPropertyChanging();
				_MinPuntaje = value;
				SendPropertyChanged("MinPuntaje");
			}
		}
	}

	[Association(Name = "VariableGestion_EvaluacionGestion", Storage = "_EvaluacionGestion", ThisKey = "IdVariable", OtherKey = "IdVariable")]
	public EntitySet<EvaluacionGestion> EvaluacionGestion
	{
		get
		{
			return _EvaluacionGestion;
		}
		set
		{
			_EvaluacionGestion.Assign(value);
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public VariableGestion()
	{
		_EvaluacionGestion = new EntitySet<EvaluacionGestion>(attach_EvaluacionGestion, detach_EvaluacionGestion);
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

	private void attach_EvaluacionGestion(EvaluacionGestion entity)
	{
		SendPropertyChanging();
		entity.VariableGestion = this;
	}

	private void detach_EvaluacionGestion(EvaluacionGestion entity)
	{
		SendPropertyChanging();
		entity.VariableGestion = null;
	}
}
