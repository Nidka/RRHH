using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Deta_Despacho")]
public class Deta_Despacho : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _IdContrato;

	private int _Item;

	private string _IdBien;

	private decimal? _Cantidad;

	private EntityRef<Despacho> _Despacho;

	[Column(Storage = "_IdContrato", DbType = "Char(8) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdContrato
	{
		get
		{
			return _IdContrato;
		}
		set
		{
			if (!string.Equals(_IdContrato, value))
			{
				if (_Despacho.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdContrato = value;
				SendPropertyChanged("IdContrato");
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
				if (_Despacho.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_Item = value;
				SendPropertyChanged("Item");
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
				SendPropertyChanging();
				_IdBien = value;
				SendPropertyChanged("IdBien");
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

	[Association(Name = "Despacho_Deta_Despacho", Storage = "_Despacho", ThisKey = "IdContrato,Item", OtherKey = "IdContrato,Item", IsForeignKey = true, DeleteOnNull = true, DeleteRule = "CASCADE")]
	public Despacho Despacho
	{
		get
		{
			return _Despacho.Entity;
		}
		set
		{
			Despacho previousValue = _Despacho.Entity;
			if (!object.Equals(previousValue, value) || !_Despacho.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_Despacho.Entity = null;
					previousValue.Deta_Despacho.Remove(this);
				}
				_Despacho.Entity = value;
				if (value != null)
				{
					value.Deta_Despacho.Add(this);
					_IdContrato = value.IdContrato;
					_Item = value.Item;
				}
				else
				{
					_IdContrato = null;
					_Item = 0;
				}
				SendPropertyChanged("Despacho");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Deta_Despacho()
	{
		_Despacho = default(EntityRef<Despacho>);
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
