using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.RRHH_Preg2")]
public class RRHH_Preg2 : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _idPregunta2;

	private string _Respues2;

	private EntitySet<RRHH_AspSocio> _RRHH_AspSocio;

	[Column(Storage = "_idPregunta2", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int idPregunta2
	{
		get
		{
			return _idPregunta2;
		}
		set
		{
			if (_idPregunta2 != value)
			{
				SendPropertyChanging();
				_idPregunta2 = value;
				SendPropertyChanged("idPregunta2");
			}
		}
	}

	[Column(Storage = "_Respues2", DbType = "VarChar(22)")]
	public string Respues2
	{
		get
		{
			return _Respues2;
		}
		set
		{
			if (!string.Equals(_Respues2, value))
			{
				SendPropertyChanging();
				_Respues2 = value;
				SendPropertyChanged("Respues2");
			}
		}
	}

	[Association(Name = "RRHH_Preg2_RRHH_AspSocio", Storage = "_RRHH_AspSocio", ThisKey = "idPregunta2", OtherKey = "idPregunta2")]
	public EntitySet<RRHH_AspSocio> RRHH_AspSocio
	{
		get
		{
			return _RRHH_AspSocio;
		}
		set
		{
			_RRHH_AspSocio.Assign(value);
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public RRHH_Preg2()
	{
		_RRHH_AspSocio = new EntitySet<RRHH_AspSocio>(attach_RRHH_AspSocio, detach_RRHH_AspSocio);
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

	private void attach_RRHH_AspSocio(RRHH_AspSocio entity)
	{
		SendPropertyChanging();
		entity.RRHH_Preg2 = this;
	}

	private void detach_RRHH_AspSocio(RRHH_AspSocio entity)
	{
		SendPropertyChanging();
		entity.RRHH_Preg2 = null;
	}
}
