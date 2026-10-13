using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.MotivoBaja")]
public class MotivoBaja : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _idMotivoBaja;

	private string _Descripcion;

	private EntitySet<RRHH_Asegurado> _RRHH_Asegurados;

	[Column(Storage = "_idMotivoBaja", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int idMotivoBaja
	{
		get
		{
			return _idMotivoBaja;
		}
		set
		{
			if (_idMotivoBaja != value)
			{
				SendPropertyChanging();
				_idMotivoBaja = value;
				SendPropertyChanged("idMotivoBaja");
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(50)")]
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

	[Association(Name = "MotivoBaja_RRHH_Asegurado", Storage = "_RRHH_Asegurados", ThisKey = "idMotivoBaja", OtherKey = "idMotivoBaja")]
	public EntitySet<RRHH_Asegurado> RRHH_Asegurados
	{
		get
		{
			return _RRHH_Asegurados;
		}
		set
		{
			_RRHH_Asegurados.Assign(value);
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public MotivoBaja()
	{
		_RRHH_Asegurados = new EntitySet<RRHH_Asegurado>(attach_RRHH_Asegurados, detach_RRHH_Asegurados);
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

	private void attach_RRHH_Asegurados(RRHH_Asegurado entity)
	{
		SendPropertyChanging();
		entity.MotivoBaja = this;
	}

	private void detach_RRHH_Asegurados(RRHH_Asegurado entity)
	{
		SendPropertyChanging();
		entity.MotivoBaja = null;
	}
}
