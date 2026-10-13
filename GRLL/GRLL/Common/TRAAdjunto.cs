using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.TRAAdjunto")]
public class TRAAdjunto : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _IdMovimiento;

	private string _IdTramite;

	private string _Referencia;

	private string _ReferenciaTipo;

	private int? _ReferenciaArea;

	private EntityRef<TRATramite> _TRATramite;

	private EntityRef<TRADocumento> _TRADocumento;

	private EntityRef<TRAMovimiento> _TRAMovimiento;

	[Column(Storage = "_IdMovimiento", DbType = "Char(10) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdMovimiento
	{
		get
		{
			return _IdMovimiento;
		}
		set
		{
			if (!string.Equals(_IdMovimiento, value))
			{
				if (_TRAMovimiento.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdMovimiento = value;
				SendPropertyChanged("IdMovimiento");
			}
		}
	}

	[Column(Storage = "_IdTramite", DbType = "Char(10)")]
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

	[Column(Storage = "_Referencia", DbType = "Char(13) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string Referencia
	{
		get
		{
			return _Referencia;
		}
		set
		{
			if (!string.Equals(_Referencia, value))
			{
				if (_TRADocumento.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_Referencia = value;
				SendPropertyChanged("Referencia");
			}
		}
	}

	[Column(Storage = "_ReferenciaTipo", DbType = "Char(2) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string ReferenciaTipo
	{
		get
		{
			return _ReferenciaTipo;
		}
		set
		{
			if (!string.Equals(_ReferenciaTipo, value))
			{
				if (_TRADocumento.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_ReferenciaTipo = value;
				SendPropertyChanged("ReferenciaTipo");
			}
		}
	}

	[Column(Storage = "_ReferenciaArea", DbType = "Int")]
	public int? ReferenciaArea
	{
		get
		{
			return _ReferenciaArea;
		}
		set
		{
			if (!_ReferenciaArea.Equals(value))
			{
				if (_TRADocumento.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_ReferenciaArea = value;
				SendPropertyChanged("ReferenciaArea");
			}
		}
	}

	[Association(Name = "TRATramite_TRAAdjunto", Storage = "_TRATramite", ThisKey = "IdTramite", OtherKey = "IdTramite", IsForeignKey = true)]
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
					previousValue.TRAAdjunto.Remove(this);
				}
				_TRATramite.Entity = value;
				if (value != null)
				{
					value.TRAAdjunto.Add(this);
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

	[Association(Name = "TRADocumento_TRAAdjunto", Storage = "_TRADocumento", ThisKey = "Referencia,ReferenciaTipo,ReferenciaArea", OtherKey = "IdDocumento,IdTipoDoc,IdAreaOrganiz", IsForeignKey = true)]
	public TRADocumento TRADocumento
	{
		get
		{
			return _TRADocumento.Entity;
		}
		set
		{
			TRADocumento previousValue = _TRADocumento.Entity;
			if (!object.Equals(previousValue, value) || !_TRADocumento.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_TRADocumento.Entity = null;
					previousValue.TRAAdjunto.Remove(this);
				}
				_TRADocumento.Entity = value;
				if (value != null)
				{
					value.TRAAdjunto.Add(this);
					_Referencia = value.IdDocumento;
					_ReferenciaTipo = value.IdTipoDoc;
					_ReferenciaArea = value.IdAreaOrganiz;
				}
				else
				{
					_Referencia = null;
					_ReferenciaTipo = null;
					_ReferenciaArea = null;
				}
				SendPropertyChanged("TRADocumento");
			}
		}
	}

	[Association(Name = "TRAMovimiento_TRAAdjunto", Storage = "_TRAMovimiento", ThisKey = "IdMovimiento", OtherKey = "IdMovimiento", IsForeignKey = true, DeleteOnNull = true, DeleteRule = "CASCADE")]
	public TRAMovimiento TRAMovimiento
	{
		get
		{
			return _TRAMovimiento.Entity;
		}
		set
		{
			TRAMovimiento previousValue = _TRAMovimiento.Entity;
			if (!object.Equals(previousValue, value) || !_TRAMovimiento.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_TRAMovimiento.Entity = null;
					previousValue.TRAAdjunto.Remove(this);
				}
				_TRAMovimiento.Entity = value;
				if (value != null)
				{
					value.TRAAdjunto.Add(this);
					_IdMovimiento = value.IdMovimiento;
				}
				else
				{
					_IdMovimiento = null;
				}
				SendPropertyChanged("TRAMovimiento");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public TRAAdjunto()
	{
		_TRATramite = default(EntityRef<TRATramite>);
		_TRADocumento = default(EntityRef<TRADocumento>);
		_TRAMovimiento = default(EntityRef<TRAMovimiento>);
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
