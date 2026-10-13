using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Financiamiento")]
public class Financiamiento : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _IdFinanciamiento;

	private string _Descripcion;

	private EntitySet<InversXFuentF> _InversXFuentF;

	private EntitySet<OrdenCompra> _OrdenCompra;

	private EntitySet<Pedido> _Pedido;

	[Column(Storage = "_IdFinanciamiento", DbType = "Char(2) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdFinanciamiento
	{
		get
		{
			return _IdFinanciamiento;
		}
		set
		{
			if (!string.Equals(_IdFinanciamiento, value))
			{
				SendPropertyChanging();
				_IdFinanciamiento = value;
				SendPropertyChanged("IdFinanciamiento");
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(120)")]
	public string Descripcion
	{
		get
		{
			return _Descripcion;
		}
		set
		{
			if (!string.Equals(_Descripcion, value))
			{
				SendPropertyChanging();
				_Descripcion = value;
				SendPropertyChanged("Descripcion");
			}
		}
	}

	[Association(Name = "Financiamiento_InversXFuentF", Storage = "_InversXFuentF", ThisKey = "IdFinanciamiento", OtherKey = "IdFinanciamiento")]
	public EntitySet<InversXFuentF> InversXFuentF
	{
		get
		{
			return _InversXFuentF;
		}
		set
		{
			_InversXFuentF.Assign(value);
		}
	}

	[Association(Name = "Financiamiento_OrdenCompra", Storage = "_OrdenCompra", ThisKey = "IdFinanciamiento", OtherKey = "IdFinanciamiento")]
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

	[Association(Name = "Financiamiento_Pedido", Storage = "_Pedido", ThisKey = "IdFinanciamiento", OtherKey = "IdFinanciamiento")]
	public EntitySet<Pedido> Pedido
	{
		get
		{
			return _Pedido;
		}
		set
		{
			_Pedido.Assign(value);
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Financiamiento()
	{
		_InversXFuentF = new EntitySet<InversXFuentF>(attach_InversXFuentF, detach_InversXFuentF);
		_OrdenCompra = new EntitySet<OrdenCompra>(attach_OrdenCompra, detach_OrdenCompra);
		_Pedido = new EntitySet<Pedido>(attach_Pedido, detach_Pedido);
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

	private void attach_InversXFuentF(InversXFuentF entity)
	{
		SendPropertyChanging();
		entity.Financiamiento = this;
	}

	private void detach_InversXFuentF(InversXFuentF entity)
	{
		SendPropertyChanging();
		entity.Financiamiento = null;
	}

	private void attach_OrdenCompra(OrdenCompra entity)
	{
		SendPropertyChanging();
		entity.Financiamiento = this;
	}

	private void detach_OrdenCompra(OrdenCompra entity)
	{
		SendPropertyChanging();
		entity.Financiamiento = null;
	}

	private void attach_Pedido(Pedido entity)
	{
		SendPropertyChanging();
		entity.Financiamiento = this;
	}

	private void detach_Pedido(Pedido entity)
	{
		SendPropertyChanging();
		entity.Financiamiento = null;
	}
}
