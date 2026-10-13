using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Despacho")]
public class Despacho : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _IdContrato;

	private int _Item;

	private DateTime? _Fecha;

	private string _IdOrden;

	private char? _Estado;

	private int? _Mes;

	private EntitySet<Deta_Despacho> _Deta_Despacho;

	private EntityRef<Contrato> _Contrato;

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
				if (_Contrato.HasLoadedOrAssignedValue)
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
				SendPropertyChanging();
				_Item = value;
				SendPropertyChanged("Item");
			}
		}
	}

	[Column(Storage = "_Fecha", DbType = "DateTime")]
	public DateTime? Fecha
	{
		get
		{
			return _Fecha;
		}
		set
		{
			if (!_Fecha.Equals(value))
			{
				SendPropertyChanging();
				_Fecha = value;
				SendPropertyChanged("Fecha");
			}
		}
	}

	[Column(Storage = "_IdOrden", DbType = "Char(8)")]
	public string IdOrden
	{
		get
		{
			return _IdOrden;
		}
		set
		{
			if (!string.Equals(_IdOrden, value))
			{
				SendPropertyChanging();
				_IdOrden = value;
				SendPropertyChanged("IdOrden");
			}
		}
	}

	[Column(Storage = "_Estado", DbType = "Char(1)")]
	public char? Estado
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

	[Column(Storage = "_Mes", DbType = "Int")]
	public int? Mes
	{
		get
		{
			return _Mes;
		}
		set
		{
			if (!_Mes.Equals(value))
			{
				SendPropertyChanging();
				_Mes = value;
				SendPropertyChanged("Mes");
			}
		}
	}

	[Association(Name = "Despacho_Deta_Despacho", Storage = "_Deta_Despacho", ThisKey = "IdContrato,Item", OtherKey = "IdContrato,Item")]
	public EntitySet<Deta_Despacho> Deta_Despacho
	{
		get
		{
			return _Deta_Despacho;
		}
		set
		{
			_Deta_Despacho.Assign(value);
		}
	}

	[Association(Name = "Contrato_Despacho", Storage = "_Contrato", ThisKey = "IdContrato", OtherKey = "IdContrato", IsForeignKey = true)]
	public Contrato Contrato
	{
		get
		{
			return _Contrato.Entity;
		}
		set
		{
			Contrato previousValue = _Contrato.Entity;
			if (!object.Equals(previousValue, value) || !_Contrato.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_Contrato.Entity = null;
					previousValue.Despacho.Remove(this);
				}
				_Contrato.Entity = value;
				if (value != null)
				{
					value.Despacho.Add(this);
					_IdContrato = value.IdContrato;
				}
				else
				{
					_IdContrato = null;
				}
				SendPropertyChanged("Contrato");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Despacho()
	{
		_Deta_Despacho = new EntitySet<Deta_Despacho>(attach_Deta_Despacho, detach_Deta_Despacho);
		_Contrato = default(EntityRef<Contrato>);
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

	private void attach_Deta_Despacho(Deta_Despacho entity)
	{
		SendPropertyChanging();
		entity.Despacho = this;
	}

	private void detach_Deta_Despacho(Deta_Despacho entity)
	{
		SendPropertyChanging();
		entity.Despacho = null;
	}
}
