using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.CJRTipoSesion")]
public class CJRTipoSesion : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _idTipoSesion;

	private string _SesionDescrip;

	private EntitySet<CJRSesion> _CJRSesion;

	[Column(Storage = "_idTipoSesion", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int idTipoSesion
	{
		get
		{
			return _idTipoSesion;
		}
		set
		{
			if (_idTipoSesion != value)
			{
				SendPropertyChanging();
				_idTipoSesion = value;
				SendPropertyChanged("idTipoSesion");
			}
		}
	}

	[Column(Storage = "_SesionDescrip", DbType = "VarChar(25)")]
	public string SesionDescrip
	{
		get
		{
			return _SesionDescrip;
		}
		set
		{
			if (!string.Equals(_SesionDescrip, value))
			{
				SendPropertyChanging();
				_SesionDescrip = value;
				SendPropertyChanged("SesionDescrip");
			}
		}
	}

	[Association(Name = "CJRTipoSesion_CJRSesion", Storage = "_CJRSesion", ThisKey = "idTipoSesion", OtherKey = "idTipoSesion")]
	public EntitySet<CJRSesion> CJRSesion
	{
		get
		{
			return _CJRSesion;
		}
		set
		{
			_CJRSesion.Assign(value);
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public CJRTipoSesion()
	{
		_CJRSesion = new EntitySet<CJRSesion>(attach_CJRSesion, detach_CJRSesion);
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

	private void attach_CJRSesion(CJRSesion entity)
	{
		SendPropertyChanging();
		entity.CJRTipoSesion = this;
	}

	private void detach_CJRSesion(CJRSesion entity)
	{
		SendPropertyChanging();
		entity.CJRTipoSesion = null;
	}
}
