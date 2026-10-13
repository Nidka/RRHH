using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.TRATramite_Requisito")]
public class TRATramite_Requisito : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _IdTramite;

	private int _IdRequisito;

	private bool? _Estado;

	private EntityRef<TRARequisito> _TRARequisito;

	private EntityRef<TRATramite> _TRATramite;

	[Column(Storage = "_IdTramite", DbType = "Char(10) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdTramite
	{
		get
		{
			return _IdTramite;
		}
		set
		{
			if (!string.Equals(_IdTramite, value))
			{
				if (_TRATramite.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdTramite = value;
				SendPropertyChanged("IdTramite");
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

	[Column(Storage = "_Estado", DbType = "Bit")]
	public bool? Estado
	{
		get
		{
			return _Estado;
		}
		set
		{
			if (!_Estado.Equals(value))
			{
				SendPropertyChanging();
				_Estado = value;
				SendPropertyChanged("Estado");
			}
		}
	}

	[Association(Name = "TRARequisito_TRATramite_Requisito", Storage = "_TRARequisito", ThisKey = "IdRequisito", OtherKey = "IdRequisito", IsForeignKey = true)]
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
					previousValue.TRATramite_Requisito.Remove(this);
				}
				_TRARequisito.Entity = value;
				if (value != null)
				{
					value.TRATramite_Requisito.Add(this);
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

	[Association(Name = "TRATramite_TRATramite_Requisito", Storage = "_TRATramite", ThisKey = "IdTramite", OtherKey = "IdTramite", IsForeignKey = true)]
	public TRATramite TRATramite
	{
		get
		{
			return _TRATramite.Entity;
		}
		set
		{
			TRATramite previousValue = _TRATramite.Entity;
			if (!object.Equals(previousValue, value) || !_TRATramite.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_TRATramite.Entity = null;
					previousValue.TRATramite_Requisito.Remove(this);
				}
				_TRATramite.Entity = value;
				if (value != null)
				{
					value.TRATramite_Requisito.Add(this);
					_IdTramite = value.IdTramite;
				}
				else
				{
					_IdTramite = null;
				}
				SendPropertyChanged("TRATramite");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public TRATramite_Requisito()
	{
		_TRARequisito = default(EntityRef<TRARequisito>);
		_TRATramite = default(EntityRef<TRATramite>);
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
