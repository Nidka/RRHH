using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.TRAEtapa_Cargo")]
public class TRAEtapa_Cargo : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _IdEtapaProc;

	private int _IdCargo;

	private EntityRef<TRAEtapa_Procedimiento> _TRAEtapa_Procedimiento;

	[Column(Storage = "_IdEtapaProc", DbType = "Char(8) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdEtapaProc
	{
		get
		{
			return _IdEtapaProc;
		}
		set
		{
			if (!string.Equals(_IdEtapaProc, value))
			{
				if (_TRAEtapa_Procedimiento.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdEtapaProc = value;
				SendPropertyChanged("IdEtapaProc");
			}
		}
	}

	[Column(Storage = "_IdCargo", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdCargo
	{
		get
		{
			return _IdCargo;
		}
		set
		{
			if (_IdCargo != value)
			{
				SendPropertyChanging();
				_IdCargo = value;
				SendPropertyChanged("IdCargo");
			}
		}
	}

	[Association(Name = "TRAEtapa_Procedimiento_TRAEtapa_Cargo", Storage = "_TRAEtapa_Procedimiento", ThisKey = "IdEtapaProc", OtherKey = "IdEtapaProc", IsForeignKey = true)]
	public TRAEtapa_Procedimiento TRAEtapa_Procedimiento
	{
		get
		{
			return _TRAEtapa_Procedimiento.Entity;
		}
		set
		{
			TRAEtapa_Procedimiento previousValue = _TRAEtapa_Procedimiento.Entity;
			if (!object.Equals(previousValue, value) || !_TRAEtapa_Procedimiento.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_TRAEtapa_Procedimiento.Entity = null;
					previousValue.TRAEtapa_Cargo.Remove(this);
				}
				_TRAEtapa_Procedimiento.Entity = value;
				if (value != null)
				{
					value.TRAEtapa_Cargo.Add(this);
					_IdEtapaProc = value.IdEtapaProc;
				}
				else
				{
					_IdEtapaProc = null;
				}
				SendPropertyChanged("TRAEtapa_Procedimiento");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public TRAEtapa_Cargo()
	{
		_TRAEtapa_Procedimiento = default(EntityRef<TRAEtapa_Procedimiento>);
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
