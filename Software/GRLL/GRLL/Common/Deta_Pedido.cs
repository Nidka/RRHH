using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Deta_Pedido")]
public class Deta_Pedido : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _IdMeta;

	private string _IdBien;

	private string _IdPedido;

	private decimal? _Cantidad;

	private string _Observaciones;

	private string _Estado;

	private decimal? _CantidadAprobada;

	private int _Item;

	private decimal? _Precio;

	private decimal? _Importe;

	private string _Tipo;

	private string _MotivoRechazo;

	private string _IdConsolidado;

	private EntityRef<Bien> _Bien;

	private EntityRef<Pedido> _Pedido;

	private EntityRef<Consolidado> _Consolidado;

	[Column(Storage = "_IdMeta", DbType = "Char(6)")]
	public string IdMeta
	{
		get
		{
			return _IdMeta;
		}
		set
		{
			if (!string.Equals(_IdMeta, value))
			{
				SendPropertyChanging();
				_IdMeta = value;
				SendPropertyChanged("IdMeta");
			}
		}
	}

	[Column(Storage = "_IdBien", DbType = "Char(13) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdBien
	{
		get
		{
			return _IdBien;
		}
		set
		{
			if (!string.Equals(_IdBien, value))
			{
				if (_Bien.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdBien = value;
				SendPropertyChanged("IdBien");
			}
		}
	}

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

	[Column(Storage = "_Cantidad", DbType = "Decimal(9,2)")]
	public decimal? Cantidad
	{
		get
		{
			return _Cantidad;
		}
		set
		{
			if (!_Cantidad.Equals(value))
			{
				SendPropertyChanging();
				_Cantidad = value;
				SendPropertyChanged("Cantidad");
			}
		}
	}

	[Column(Storage = "_Observaciones", DbType = "VarChar(120)")]
	public string Observaciones
	{
		get
		{
			return _Observaciones;
		}
		set
		{
			if (!string.Equals(_Observaciones, value))
			{
				SendPropertyChanging();
				_Observaciones = value;
				SendPropertyChanged("Observaciones");
			}
		}
	}

	[Column(Storage = "_Estado", DbType = "Char(2)")]
	public string Estado
	{
		get
		{
			return _Estado;
		}
		set
		{
			if (!string.Equals(_Estado, value))
			{
				SendPropertyChanging();
				_Estado = value;
				SendPropertyChanged("Estado");
			}
		}
	}

	[Column(Storage = "_CantidadAprobada", DbType = "Decimal(9,2)")]
	public decimal? CantidadAprobada
	{
		get
		{
			return _CantidadAprobada;
		}
		set
		{
			if (!_CantidadAprobada.Equals(value))
			{
				SendPropertyChanging();
				_CantidadAprobada = value;
				SendPropertyChanged("CantidadAprobada");
			}
		}
	}

	[Column(Storage = "_Item", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int Item
	{
		get
		{
			return _Item;
		}
		set
		{
			if (_Item != value)
			{
				SendPropertyChanging();
				_Item = value;
				SendPropertyChanged("Item");
			}
		}
	}

	[Column(Storage = "_Precio", DbType = "Decimal(18,2)")]
	public decimal? Precio
	{
		get
		{
			return _Precio;
		}
		set
		{
			if (!_Precio.Equals(value))
			{
				SendPropertyChanging();
				_Precio = value;
				SendPropertyChanged("Precio");
			}
		}
	}

	[Column(Storage = "_Importe", DbType = "Decimal(18,2)")]
	public decimal? Importe
	{
		get
		{
			return _Importe;
		}
		set
		{
			if (!_Importe.Equals(value))
			{
				SendPropertyChanging();
				_Importe = value;
				SendPropertyChanged("Importe");
			}
		}
	}

	[Column(Storage = "_Tipo", DbType = "Char(3)")]
	public string Tipo
	{
		get
		{
			return _Tipo;
		}
		set
		{
			if (!string.Equals(_Tipo, value))
			{
				SendPropertyChanging();
				_Tipo = value;
				SendPropertyChanged("Tipo");
			}
		}
	}

	[Column(Storage = "_MotivoRechazo", DbType = "VarChar(120)")]
	public string MotivoRechazo
	{
		get
		{
			return _MotivoRechazo;
		}
		set
		{
			if (!string.Equals(_MotivoRechazo, value))
			{
				SendPropertyChanging();
				_MotivoRechazo = value;
				SendPropertyChanged("MotivoRechazo");
			}
		}
	}

	[Column(Storage = "_IdConsolidado", DbType = "Char(6)")]
	public string IdConsolidado
	{
		get
		{
			return _IdConsolidado;
		}
		set
		{
			if (!string.Equals(_IdConsolidado, value))
			{
				if (_Consolidado.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdConsolidado = value;
				SendPropertyChanged("IdConsolidado");
			}
		}
	}

	[Association(Name = "Bien_Deta_Pedido", Storage = "_Bien", ThisKey = "IdBien", OtherKey = "IdBien", IsForeignKey = true, DeleteOnNull = true, DeleteRule = "CASCADE")]
	public Bien Bien
	{
		get
		{
			return _Bien.Entity;
		}
		set
		{
			Bien previousValue = _Bien.Entity;
			if (!object.Equals(previousValue, value) || !_Bien.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_Bien.Entity = null;
					previousValue.Deta_Pedido.Remove(this);
				}
				_Bien.Entity = value;
				if (value != null)
				{
					value.Deta_Pedido.Add(this);
					_IdBien = value.IdBien;
				}
				else
				{
					_IdBien = null;
				}
				SendPropertyChanged("Bien");
			}
		}
	}

	[Association(Name = "Pedido_Deta_Pedido", Storage = "_Pedido", ThisKey = "IdPedido", OtherKey = "IdPedido", IsForeignKey = true)]
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
					previousValue.Deta_Pedido.Remove(this);
				}
				_Pedido.Entity = value;
				if (value != null)
				{
					value.Deta_Pedido.Add(this);
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

	[Association(Name = "Consolidado_Deta_Pedido", Storage = "_Consolidado", ThisKey = "IdConsolidado", OtherKey = "IdConsolidado", IsForeignKey = true)]
	public Consolidado Consolidado
	{
		get
		{
			return _Consolidado.Entity;
		}
		set
		{
			Consolidado previousValue = _Consolidado.Entity;
			if (!object.Equals(previousValue, value) || !_Consolidado.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_Consolidado.Entity = null;
					previousValue.Deta_Pedido.Remove(this);
				}
				_Consolidado.Entity = value;
				if (value != null)
				{
					value.Deta_Pedido.Add(this);
					_IdConsolidado = value.IdConsolidado;
				}
				else
				{
					_IdConsolidado = null;
				}
				SendPropertyChanged("Consolidado");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Deta_Pedido()
	{
		_Bien = default(EntityRef<Bien>);
		_Pedido = default(EntityRef<Pedido>);
		_Consolidado = default(EntityRef<Consolidado>);
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
