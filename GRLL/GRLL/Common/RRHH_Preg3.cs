using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.RRHH_Preg3")]
public class RRHH_Preg3 : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _idPregunta3;

	private string _Respues3;

	private EntitySet<RRHH_AspSocio> _RRHH_AspSocio;

	[Column(Storage = "_idPregunta3", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int idPregunta3
	{
		get
		{
			return _idPregunta3;
		}
		set
		{
			if (_idPregunta3 != value)
			{
				SendPropertyChanging();
				_idPregunta3 = value;
				SendPropertyChanged("idPregunta3");
			}
		}
	}

	[Column(Storage = "_Respues3", DbType = "VarChar(23)")]
	public string Respues3
	{
		get
		{
			return _Respues3;
		}
		set
		{
			if (!string.Equals(_Respues3, value))
			{
				SendPropertyChanging();
				_Respues3 = value;
				SendPropertyChanged("Respues3");
			}
		}
	}

	[Association(Name = "RRHH_Preg3_RRHH_AspSocio", Storage = "_RRHH_AspSocio", ThisKey = "idPregunta3", OtherKey = "idPregunta3")]
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

	public RRHH_Preg3()
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
		entity.RRHH_Preg3 = this;
	}

	private void detach_RRHH_AspSocio(RRHH_AspSocio entity)
	{
		SendPropertyChanging();
		entity.RRHH_Preg3 = null;
	}
}
