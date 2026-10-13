using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.TipoMovimiento")]
public class TipoMovimiento : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private char _IdTipoMovimiento;

	private string _Descripcion;

	private string _IdTipodoc;

	private char? _TipoOperacion;

	private EntitySet<Movimiento> _Movimiento;

	[Column(Storage = "_IdTipoMovimiento", DbType = "Char(1) NOT NULL", IsPrimaryKey = true)]
	public char IdTipoMovimiento
	{
		get
		{
			return _IdTipoMovimiento;
		}
		set
		{
			if (_IdTipoMovimiento != value)
			{
				SendPropertyChanging();
				_IdTipoMovimiento = value;
				SendPropertyChanged("IdTipoMovimiento");
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(40)")]
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

	[Column(Storage = "_IdTipodoc", DbType = "Char(2) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdTipodoc
	{
		get
		{
			return _IdTipodoc;
		}
		set
		{
			if (!string.Equals(_IdTipodoc, value))
			{
				SendPropertyChanging();
				_IdTipodoc = value;
				SendPropertyChanged("IdTipodoc");
			}
		}
	}

	[Column(Storage = "_TipoOperacion", DbType = "Char(1)")]
	public char? TipoOperacion
	{
		get
		{
			return _TipoOperacion;
		}
		set
		{
			if (!_TipoOperacion.Equals(value))
			{
				SendPropertyChanging();
				_TipoOperacion = value;
				SendPropertyChanged("TipoOperacion");
			}
		}
	}

	[Association(Name = "TipoMovimiento_Movimiento", Storage = "_Movimiento", ThisKey = "IdTipoMovimiento,IdTipodoc", OtherKey = "IdTipoMovimiento,IdTipodoc")]
	public EntitySet<Movimiento> Movimiento
	{
		get
		{
			return _Movimiento;
		}
		set
		{
			_Movimiento.Assign(value);
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public TipoMovimiento()
	{
		_Movimiento = new EntitySet<Movimiento>(attach_Movimiento, detach_Movimiento);
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

	private void attach_Movimiento(Movimiento entity)
	{
		SendPropertyChanging();
		entity.TipoMovimiento = this;
	}

	private void detach_Movimiento(Movimiento entity)
	{
		SendPropertyChanging();
		entity.TipoMovimiento = null;
	}
}
