using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Deta_Cotizacion")]
public class Deta_Cotizacion : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _IdCotizacion;

	private string _IdBien;

	private decimal? _Cantidad;

	private decimal? _Precio;

	private decimal? _Importe;

	private string _Observaciones;

	private EntityRef<Bien> _Bien;

	private EntityRef<Cotizacion> _Cotizacion;

	[Column(Storage = "_IdCotizacion", DbType = "Char(6) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdCotizacion
	{
		get
		{
			return _IdCotizacion;
		}
		set
		{
			if (!string.Equals(_IdCotizacion, value))
			{
				if (_Cotizacion.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdCotizacion = value;
				SendPropertyChanged("IdCotizacion");
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

	[Column(Storage = "_Cantidad", DbType = "Decimal(18,2)")]
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

	[Column(Storage = "_Observaciones", DbType = "VarChar(50)")]
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

	[Association(Name = "Bien_Deta_Cotizacion", Storage = "_Bien", ThisKey = "IdBien", OtherKey = "IdBien", IsForeignKey = true, DeleteOnNull = true, DeleteRule = "CASCADE")]
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
					previousValue.Deta_Cotizacion.Remove(this);
				}
				_Bien.Entity = value;
				if (value != null)
				{
					value.Deta_Cotizacion.Add(this);
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

	[Association(Name = "Cotizacion_Deta_Cotizacion", Storage = "_Cotizacion", ThisKey = "IdCotizacion", OtherKey = "IdCotizacion", IsForeignKey = true, DeleteOnNull = true, DeleteRule = "CASCADE")]
	public Cotizacion Cotizacion
	{
		get
		{
			return _Cotizacion.Entity;
		}
		set
		{
			Cotizacion previousValue = _Cotizacion.Entity;
			if (!object.Equals(previousValue, value) || !_Cotizacion.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_Cotizacion.Entity = null;
					previousValue.Deta_Cotizacion.Remove(this);
				}
				_Cotizacion.Entity = value;
				if (value != null)
				{
					value.Deta_Cotizacion.Add(this);
					_IdCotizacion = value.IdCotizacion;
				}
				else
				{
					_IdCotizacion = null;
				}
				SendPropertyChanged("Cotizacion");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Deta_Cotizacion()
	{
		_Bien = default(EntityRef<Bien>);
		_Cotizacion = default(EntityRef<Cotizacion>);
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
