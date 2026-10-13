using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Contrato")]
public class Contrato : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _IdContrato;

	private DateTime? _Fecha;

	private string _IdProveedor;

	private int? _PlazoDias;

	private decimal? _Monto;

	private string _Concepto;

	private string _Estado;

	private EntitySet<Despacho> _Despacho;

	private EntitySet<Deta_Consolidado> _Deta_Consolidado;

	private EntitySet<OrdenCompra> _OrdenCompra;

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
				SendPropertyChanging();
				_IdContrato = value;
				SendPropertyChanged("IdContrato");
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

	[Column(Storage = "_IdProveedor", DbType = "Char(11)")]
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
				SendPropertyChanging();
				_IdProveedor = value;
				SendPropertyChanged("IdProveedor");
			}
		}
	}

	[Column(Storage = "_PlazoDias", DbType = "Int")]
	public int? PlazoDias
	{
		get
		{
			return _PlazoDias;
		}
		set
		{
			if (!_PlazoDias.Equals(value))
			{
				SendPropertyChanging();
				_PlazoDias = value;
				SendPropertyChanged("PlazoDias");
			}
		}
	}

	[Column(Storage = "_Monto", DbType = "Decimal(9,2)")]
	public decimal? Monto
	{
		get
		{
			return _Monto;
		}
		set
		{
			if (!_Monto.Equals(value))
			{
				SendPropertyChanging();
				_Monto = value;
				SendPropertyChanged("Monto");
			}
		}
	}

	[Column(Storage = "_Concepto", DbType = "VarChar(120)")]
	public string Concepto
	{
		get
		{
			return _Concepto;
		}
		set
		{
			if (!string.Equals(_Concepto, value))
			{
				SendPropertyChanging();
				_Concepto = value;
				SendPropertyChanged("Concepto");
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

	[Association(Name = "Contrato_Despacho", Storage = "_Despacho", ThisKey = "IdContrato", OtherKey = "IdContrato")]
	public EntitySet<Despacho> Despacho
	{
		get
		{
			return _Despacho;
		}
		set
		{
			_Despacho.Assign(value);
		}
	}

	[Association(Name = "Contrato_Deta_Consolidado", Storage = "_Deta_Consolidado", ThisKey = "IdContrato", OtherKey = "IdContrato")]
	public EntitySet<Deta_Consolidado> Deta_Consolidado
	{
		get
		{
			return _Deta_Consolidado;
		}
		set
		{
			_Deta_Consolidado.Assign(value);
		}
	}

	[Association(Name = "Contrato_OrdenCompra", Storage = "_OrdenCompra", ThisKey = "IdContrato", OtherKey = "IdContrato")]
	public EntitySet<OrdenCompra> OrdenCompra
	{
		get
		{
			return _OrdenCompra;
		}
		set
		{
			_OrdenCompra.Assign(value);
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Contrato()
	{
		_Despacho = new EntitySet<Despacho>(attach_Despacho, detach_Despacho);
		_Deta_Consolidado = new EntitySet<Deta_Consolidado>(attach_Deta_Consolidado, detach_Deta_Consolidado);
		_OrdenCompra = new EntitySet<OrdenCompra>(attach_OrdenCompra, detach_OrdenCompra);
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

	private void attach_Despacho(Despacho entity)
	{
		SendPropertyChanging();
		entity.Contrato = this;
	}

	private void detach_Despacho(Despacho entity)
	{
		SendPropertyChanging();
		entity.Contrato = null;
	}

	private void attach_Deta_Consolidado(Deta_Consolidado entity)
	{
		SendPropertyChanging();
		entity.Contrato = this;
	}

	private void detach_Deta_Consolidado(Deta_Consolidado entity)
	{
		SendPropertyChanging();
		entity.Contrato = null;
	}

	private void attach_OrdenCompra(OrdenCompra entity)
	{
		SendPropertyChanging();
		entity.Contrato = this;
	}

	private void detach_OrdenCompra(OrdenCompra entity)
	{
		SendPropertyChanging();
		entity.Contrato = null;
	}
}
