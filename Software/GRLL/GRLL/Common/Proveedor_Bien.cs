using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Proveedor_Bien")]
public class Proveedor_Bien : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _IdProveedor;

	private string _IdBien;

	private decimal? _CostoSoles;

	private decimal? _CostoDolares;

	private EntityRef<Bien> _Bien;

	private EntityRef<Proveedor> _Proveedor;

	[Column(Storage = "_IdProveedor", DbType = "Char(11) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdProveedor
	{
		get
		{
			return _IdProveedor;
		}
		set
		{
			if (!string.Equals(_IdProveedor, value))
			{
				if (_Proveedor.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdProveedor = value;
				SendPropertyChanged("IdProveedor");
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

	[Column(Storage = "_CostoSoles", DbType = "Decimal(18,2)")]
	public decimal? CostoSoles
	{
		get
		{
			return _CostoSoles;
		}
		set
		{
			if (!_CostoSoles.Equals(value))
			{
				SendPropertyChanging();
				_CostoSoles = value;
				SendPropertyChanged("CostoSoles");
			}
		}
	}

	[Column(Storage = "_CostoDolares", DbType = "Decimal(18,2)")]
	public decimal? CostoDolares
	{
		get
		{
			return _CostoDolares;
		}
		set
		{
			if (!_CostoDolares.Equals(value))
			{
				SendPropertyChanging();
				_CostoDolares = value;
				SendPropertyChanged("CostoDolares");
			}
		}
	}

	[Association(Name = "Bien_Proveedor_Bien", Storage = "_Bien", ThisKey = "IdBien", OtherKey = "IdBien", IsForeignKey = true, DeleteOnNull = true, DeleteRule = "CASCADE")]
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
					previousValue.Proveedor_Bien.Remove(this);
				}
				_Bien.Entity = value;
				if (value != null)
				{
					value.Proveedor_Bien.Add(this);
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

	[Association(Name = "Proveedor_Proveedor_Bien", Storage = "_Proveedor", ThisKey = "IdProveedor", OtherKey = "IdProveedor", IsForeignKey = true)]
	public Proveedor Proveedor
	{
		get
		{
			return _Proveedor.Entity;
		}
		set
		{
			Proveedor previousValue = _Proveedor.Entity;
			if (!object.Equals(previousValue, value) || !_Proveedor.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_Proveedor.Entity = null;
					previousValue.Proveedor_Bien.Remove(this);
				}
				_Proveedor.Entity = value;
				if (value != null)
				{
					value.Proveedor_Bien.Add(this);
					_IdProveedor = value.IdProveedor;
				}
				else
				{
					_IdProveedor = null;
				}
				SendPropertyChanged("Proveedor");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Proveedor_Bien()
	{
		_Bien = default(EntityRef<Bien>);
		_Proveedor = default(EntityRef<Proveedor>);
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
