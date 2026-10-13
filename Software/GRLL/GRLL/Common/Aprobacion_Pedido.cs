using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Aprobacion_Pedido")]
public class Aprobacion_Pedido : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _IdPedido;

	private string _IdAreaOrganiz;

	private int _Anio;

	private char? _Estado;

	private string _Observaciones;

	private int? _IdTrabajador;

	private DateTime? _Fecha;

	private DateTime? _FechaAprobacion;

	private int? _IdAreaDestino;

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

	[Column(Storage = "_IdAreaOrganiz", DbType = "Char(6) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdAreaOrganiz
	{
		get
		{
			return _IdAreaOrganiz;
		}
		set
		{
			if (!string.Equals(_IdAreaOrganiz, value))
			{
				SendPropertyChanging();
				_IdAreaOrganiz = value;
				SendPropertyChanged("IdAreaOrganiz");
			}
		}
	}

	[Column(Storage = "_Anio", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int Anio
	{
		get
		{
			return _Anio;
		}
		set
		{
			if (_Anio != value)
			{
				SendPropertyChanging();
				_Anio = value;
				SendPropertyChanged("Anio");
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

	[Column(Storage = "_IdTrabajador", DbType = "Int")]
	public int? IdTrabajador
	{
		get
		{
			return _IdTrabajador;
		}
		set
		{
			if (!_IdTrabajador.Equals(value))
			{
				SendPropertyChanging();
				_IdTrabajador = value;
				SendPropertyChanged("IdTrabajador");
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

	[Column(Storage = "_FechaAprobacion", DbType = "DateTime")]
	public DateTime? FechaAprobacion
	{
		get
		{
			return _FechaAprobacion;
		}
		set
		{
			if (!_FechaAprobacion.Equals(value))
			{
				SendPropertyChanging();
				_FechaAprobacion = value;
				SendPropertyChanged("FechaAprobacion");
			}
		}
	}

	[Column(Storage = "_IdAreaDestino", DbType = "Int")]
	public int? IdAreaDestino
	{
		get
		{
			return _IdAreaDestino;
		}
		set
		{
			if (!_IdAreaDestino.Equals(value))
			{
				SendPropertyChanging();
				_IdAreaDestino = value;
				SendPropertyChanged("IdAreaDestino");
			}
		}
	}

	[Association(Name = "Pedido_Aprobacion_Pedido", Storage = "_Pedido", ThisKey = "IdPedido", OtherKey = "IdPedido", IsForeignKey = true)]
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
					previousValue.Aprobacion_Pedido.Remove(this);
				}
				_Pedido.Entity = value;
				if (value != null)
				{
					value.Aprobacion_Pedido.Add(this);
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

	public Aprobacion_Pedido()
	{
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
