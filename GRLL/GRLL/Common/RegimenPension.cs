using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.RegimenPension")]
public class RegimenPension : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdRegimenPen;

	private string _LeyRegimen;

	private EntitySet<Empleado> _Empleados;

	[Column(Storage = "_IdRegimenPen", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdRegimenPen
	{
		get
		{
			return _IdRegimenPen;
		}
		set
		{
			if (_IdRegimenPen != value)
			{
				SendPropertyChanging();
				_IdRegimenPen = value;
				SendPropertyChanged("IdRegimenPen");
			}
		}
	}

	[Column(Storage = "_LeyRegimen", DbType = "VarChar(5)")]
	public string LeyRegimen
	{
		get
		{
			return _LeyRegimen;
		}
		set
		{
			if (!string.Equals(_LeyRegimen, value))
			{
				SendPropertyChanging();
				_LeyRegimen = value;
				SendPropertyChanged("LeyRegimen");
			}
		}
	}

	[Association(Name = "RegimenPension_Empleado", Storage = "_Empleados", ThisKey = "IdRegimenPen", OtherKey = "IdRegimenPen")]
	public EntitySet<Empleado> Empleados
	{
		get
		{
			return _Empleados;
		}
		set
		{
			_Empleados.Assign(value);
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public RegimenPension()
	{
		_Empleados = new EntitySet<Empleado>(attach_Empleados, detach_Empleados);
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

	private void attach_Empleados(Empleado entity)
	{
		SendPropertyChanging();
		entity.RegimenPension = this;
	}

	private void detach_Empleados(Empleado entity)
	{
		SendPropertyChanging();
		entity.RegimenPension = null;
	}
}
