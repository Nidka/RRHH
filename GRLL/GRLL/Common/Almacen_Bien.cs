using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Almacen_Bien")]
public class Almacen_Bien : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _IdAlmacen;

	private string _IdBien;

	private decimal? _Stock;

	private EntityRef<Almacen> _Almacen;

	private EntityRef<Bien> _Bien;

	[Column(Storage = "_IdAlmacen", DbType = "Char(2) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdAlmacen
	{
		get
		{
			return _IdAlmacen;
		}
		set
		{
			if (!string.Equals(_IdAlmacen, value))
			{
				if (_Almacen.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdAlmacen = value;
				SendPropertyChanged("IdAlmacen");
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

	[Column(Storage = "_Stock", DbType = "Decimal(9,2)")]
	public decimal? Stock
	{
		get
		{
			return _Stock;
		}
		set
		{
			if (!_Stock.Equals(value))
			{
				SendPropertyChanging();
				_Stock = value;
				SendPropertyChanged("Stock");
			}
		}
	}

	[Association(Name = "Almacen_Almacen_Bien", Storage = "_Almacen", ThisKey = "IdAlmacen", OtherKey = "IdAlmacen", IsForeignKey = true)]
	public Almacen Almacen
	{
		get
		{
			return _Almacen.Entity;
		}
		set
		{
			Almacen previousValue = _Almacen.Entity;
			if (!object.Equals(previousValue, value) || !_Almacen.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_Almacen.Entity = null;
					previousValue.Almacen_Bien.Remove(this);
				}
				_Almacen.Entity = value;
				if (value != null)
				{
					value.Almacen_Bien.Add(this);
					_IdAlmacen = value.IdAlmacen;
				}
				else
				{
					_IdAlmacen = null;
				}
				SendPropertyChanged("Almacen");
			}
		}
	}

	[Association(Name = "Bien_Almacen_Bien", Storage = "_Bien", ThisKey = "IdBien", OtherKey = "IdBien", IsForeignKey = true, DeleteOnNull = true, DeleteRule = "CASCADE")]
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
					previousValue.Almacen_Bien.Remove(this);
				}
				_Bien.Entity = value;
				if (value != null)
				{
					value.Almacen_Bien.Add(this);
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

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Almacen_Bien()
	{
		_Almacen = default(EntityRef<Almacen>);
		_Bien = default(EntityRef<Bien>);
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
