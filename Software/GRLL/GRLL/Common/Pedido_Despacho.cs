using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Pedido_Despacho")]
public class Pedido_Despacho : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _IdPedido;

	private string _IdDocumento;

	private EntityRef<Movimiento> _Movimiento;

	private EntityRef<Pedido> _Pedido;

	[Column(Storage = "_IdPedido", DbType = "Char(6) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdPedido
	{
		get
		{
			return _IdPedido;
		}
		set
		{
			if (!string.Equals(_IdPedido, value))
			{
				if (_Pedido.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdPedido = value;
				SendPropertyChanged("IdPedido");
			}
		}
	}

	[Column(Storage = "_IdDocumento", DbType = "Char(8) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdDocumento
	{
		get
		{
			return _IdDocumento;
		}
		set
		{
			if (!string.Equals(_IdDocumento, value))
			{
				if (_Movimiento.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdDocumento = value;
				SendPropertyChanged("IdDocumento");
			}
		}
	}

	[Association(Name = "Movimiento_Pedido_Despacho", Storage = "_Movimiento", ThisKey = "IdDocumento", OtherKey = "IdMovimiento", IsForeignKey = true)]
	public Movimiento Movimiento
	{
		get
		{
			return _Movimiento.Entity;
		}
		set
		{
			Movimiento previousValue = _Movimiento.Entity;
			if (!object.Equals(previousValue, value) || !_Movimiento.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_Movimiento.Entity = null;
					previousValue.Pedido_Despacho.Remove(this);
				}
				_Movimiento.Entity = value;
				if (value != null)
				{
					value.Pedido_Despacho.Add(this);
					_IdDocumento = value.IdMovimiento;
				}
				else
				{
					_IdDocumento = null;
				}
				SendPropertyChanged("Movimiento");
			}
		}
	}

	[Association(Name = "Pedido_Pedido_Despacho", Storage = "_Pedido", ThisKey = "IdPedido", OtherKey = "IdPedido", IsForeignKey = true)]
	public Pedido Pedido
	{
		get
		{
			return _Pedido.Entity;
		}
		set
		{
			Pedido previousValue = _Pedido.Entity;
			if (!object.Equals(previousValue, value) || !_Pedido.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_Pedido.Entity = null;
					previousValue.Pedido_Despacho.Remove(this);
				}
				_Pedido.Entity = value;
				if (value != null)
				{
					value.Pedido_Despacho.Add(this);
					_IdPedido = value.IdPedido;
				}
				else
				{
					_IdPedido = null;
				}
				SendPropertyChanged("Pedido");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Pedido_Despacho()
	{
		_Movimiento = default(EntityRef<Movimiento>);
		_Pedido = default(EntityRef<Pedido>);
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
