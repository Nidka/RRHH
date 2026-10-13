using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.CJROperador")]
public class CJROperador : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int? _IdEmpleado;

	private int _idOperador;

	private EntitySet<CJRIniciativa> _CJRIniciativa;

	private EntityRef<Empleado> _Empleado;

	[Column(Storage = "_IdEmpleado", DbType = "Int")]
	public int? IdEmpleado
	{
		get
		{
			return _IdEmpleado;
		}
		set
		{
			if (!_IdEmpleado.Equals(value))
			{
				if (_Empleado.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdEmpleado = value;
				SendPropertyChanged("IdEmpleado");
			}
		}
	}

	[Column(Storage = "_idOperador", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int idOperador
	{
		get
		{
			return _idOperador;
		}
		set
		{
			if (_idOperador != value)
			{
				SendPropertyChanging();
				_idOperador = value;
				SendPropertyChanged("idOperador");
			}
		}
	}

	[Association(Name = "CJROperador_CJRIniciativa", Storage = "_CJRIniciativa", ThisKey = "idOperador", OtherKey = "idOperador")]
	public EntitySet<CJRIniciativa> CJRIniciativa
	{
		get
		{
			return _CJRIniciativa;
		}
		set
		{
			_CJRIniciativa.Assign(value);
		}
	}

	[Association(Name = "Empleado_CJROperador", Storage = "_Empleado", ThisKey = "IdEmpleado", OtherKey = "IdEmpleado", IsForeignKey = true)]
	public Empleado Empleado
	{
		get
		{
			return _Empleado.Entity;
		}
		set
		{
			Empleado previousValue = _Empleado.Entity;
			if (!object.Equals(previousValue, value) || !_Empleado.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_Empleado.Entity = null;
					previousValue.CJROperadors.Remove(this);
				}
				_Empleado.Entity = value;
				if (value != null)
				{
					value.CJROperadors.Add(this);
					_IdEmpleado = value.IdEmpleado;
				}
				else
				{
					_IdEmpleado = null;
				}
				SendPropertyChanged("Empleado");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public CJROperador()
	{
		_CJRIniciativa = new EntitySet<CJRIniciativa>(attach_CJRIniciativa, detach_CJRIniciativa);
		_Empleado = default(EntityRef<Empleado>);
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

	private void attach_CJRIniciativa(CJRIniciativa entity)
	{
		SendPropertyChanging();
		entity.CJROperador = this;
	}

	private void detach_CJRIniciativa(CJRIniciativa entity)
	{
		SendPropertyChanging();
		entity.CJROperador = null;
	}
}
