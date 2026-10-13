using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.RRHH_Preg1")]
public class RRHH_Preg1 : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _idPregunta1;

	private string _Respues1;

	private EntitySet<RRHH_AspSocio> _RRHH_AspSocio;

	[Column(Storage = "_idPregunta1", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int idPregunta1
	{
		get
		{
			return _idPregunta1;
		}
		set
		{
			if (_idPregunta1 != value)
			{
				SendPropertyChanging();
				_idPregunta1 = value;
				SendPropertyChanged("idPregunta1");
			}
		}
	}

	[Column(Storage = "_Respues1", DbType = "VarChar(83)")]
	public string Respues1
	{
		get
		{
			return _Respues1;
		}
		set
		{
			if (!string.Equals(_Respues1, value))
			{
				SendPropertyChanging();
				_Respues1 = value;
				SendPropertyChanged("Respues1");
			}
		}
	}

	[Association(Name = "RRHH_Preg1_RRHH_AspSocio", Storage = "_RRHH_AspSocio", ThisKey = "idPregunta1", OtherKey = "idPregunta1")]
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

	public RRHH_Preg1()
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
		entity.RRHH_Preg1 = this;
	}

	private void detach_RRHH_AspSocio(RRHH_AspSocio entity)
	{
		SendPropertyChanging();
		entity.RRHH_Preg1 = null;
	}
}
