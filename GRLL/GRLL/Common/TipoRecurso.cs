using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.TipoRecurso")]
public class TipoRecurso : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _IdTipoRecurso;

	private string _Descripcion;

	private EntitySet<Pedido> _Pedido;

	[Column(Storage = "_IdTipoRecurso", DbType = "Char(3) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdTipoRecurso
	{
		get
		{
			return _IdTipoRecurso;
		}
		set
		{
			if (!string.Equals(_IdTipoRecurso, value))
			{
				SendPropertyChanging();
				_IdTipoRecurso = value;
				SendPropertyChanged("IdTipoRecurso");
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

	[Association(Name = "TipoRecurso_Pedido", Storage = "_Pedido", ThisKey = "IdTipoRecurso", OtherKey = "IdTipoRecurso")]
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

	public TipoRecurso()
	{
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

	private void attach_Pedido(Pedido entity)
	{
		SendPropertyChanging();
		entity.TipoRecurso = this;
	}

	private void detach_Pedido(Pedido entity)
	{
		SendPropertyChanging();
		entity.TipoRecurso = null;
	}
}
