using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.TRAProcedimiento_Requisito")]
public class TRAProcedimiento_Requisito : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _IdProcedimiento;

	private int _IdRequisito;

	private EntityRef<TRARequisito> _TRARequisito;

	private EntityRef<TRAProcedimiento> _TRAProcedimiento;

	[Column(Storage = "_IdProcedimiento", DbType = "Char(6) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdProcedimiento
	{
		get
		{
			return _IdProcedimiento;
		}
		set
		{
			if (!string.Equals(_IdProcedimiento, value))
			{
				if (_TRAProcedimiento.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdProcedimiento = value;
				SendPropertyChanged("IdProcedimiento");
			}
		}
	}

	[Column(Storage = "_IdRequisito", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdRequisito
	{
		get
		{
			return _IdRequisito;
		}
		set
		{
			if (_IdRequisito != value)
			{
				if (_TRARequisito.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdRequisito = value;
				SendPropertyChanged("IdRequisito");
			}
		}
	}

	[Association(Name = "TRARequisito_TRAProcedimiento_Requisito", Storage = "_TRARequisito", ThisKey = "IdRequisito", OtherKey = "IdRequisito", IsForeignKey = true)]
	public TRARequisito TRARequisito
	{
		get
		{
			return _TRARequisito.Entity;
		}
		set
		{
			TRARequisito previousValue = _TRARequisito.Entity;
			if (!object.Equals(previousValue, value) || !_TRARequisito.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_TRARequisito.Entity = null;
					previousValue.TRAProcedimiento_Requisito.Remove(this);
				}
				_TRARequisito.Entity = value;
				if (value != null)
				{
					value.TRAProcedimiento_Requisito.Add(this);
					_IdRequisito = value.IdRequisito;
				}
				else
				{
					_IdRequisito = 0;
				}
				SendPropertyChanged("TRARequisito");
			}
		}
	}

	[Association(Name = "TRAProcedimiento_TRAProcedimiento_Requisito", Storage = "_TRAProcedimiento", ThisKey = "IdProcedimiento", OtherKey = "IdProcedimiento", IsForeignKey = true)]
	public TRAProcedimiento TRAProcedimiento
	{
		get
		{
			return _TRAProcedimiento.Entity;
		}
		set
		{
			TRAProcedimiento previousValue = _TRAProcedimiento.Entity;
			if (!object.Equals(previousValue, value) || !_TRAProcedimiento.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_TRAProcedimiento.Entity = null;
					previousValue.TRAProcedimiento_Requisito.Remove(this);
				}
				_TRAProcedimiento.Entity = value;
				if (value != null)
				{
					value.TRAProcedimiento_Requisito.Add(this);
					_IdProcedimiento = value.IdProcedimiento;
				}
				else
				{
					_IdProcedimiento = null;
				}
				SendPropertyChanged("TRAProcedimiento");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public TRAProcedimiento_Requisito()
	{
		_TRARequisito = default(EntityRef<TRARequisito>);
		_TRAProcedimiento = default(EntityRef<TRAProcedimiento>);
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
