using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.TRATipoSilencio")]
public class TRATipoSilencio : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private byte _IdTipoSilencio;

	private string _Descripcion;

	private EntitySet<TRAProcedimiento> _TRAProcedimiento;

	[Column(Storage = "_IdTipoSilencio", DbType = "TinyInt NOT NULL", IsPrimaryKey = true)]
	public byte IdTipoSilencio
	{
		get
		{
			return _IdTipoSilencio;
		}
		set
		{
			if (_IdTipoSilencio != value)
			{
				SendPropertyChanging();
				_IdTipoSilencio = value;
				SendPropertyChanged("IdTipoSilencio");
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(200)")]
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

	[Association(Name = "TRATipoSilencio_TRAProcedimiento", Storage = "_TRAProcedimiento", ThisKey = "IdTipoSilencio", OtherKey = "IdTipoSilencio")]
	public EntitySet<TRAProcedimiento> TRAProcedimiento
	{
		get
		{
			return _TRAProcedimiento;
		}
		set
		{
			_TRAProcedimiento.Assign(value);
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public TRATipoSilencio()
	{
		_TRAProcedimiento = new EntitySet<TRAProcedimiento>(attach_TRAProcedimiento, detach_TRAProcedimiento);
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

	private void attach_TRAProcedimiento(TRAProcedimiento entity)
	{
		SendPropertyChanging();
		entity.TRATipoSilencio = this;
	}

	private void detach_TRAProcedimiento(TRAProcedimiento entity)
	{
		SendPropertyChanging();
		entity.TRATipoSilencio = null;
	}
}
