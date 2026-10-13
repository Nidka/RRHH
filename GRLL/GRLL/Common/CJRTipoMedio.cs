using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.CJRTipoMedio")]
public class CJRTipoMedio : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _idTipoMedio;

	private string _TipoMedioDescrip;

	private EntitySet<CJRPublicacion> _CJRPublicacion;

	[Column(Storage = "_idTipoMedio", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int idTipoMedio
	{
		get
		{
			return _idTipoMedio;
		}
		set
		{
			if (_idTipoMedio != value)
			{
				SendPropertyChanging();
				_idTipoMedio = value;
				SendPropertyChanged("idTipoMedio");
			}
		}
	}

	[Column(Storage = "_TipoMedioDescrip", DbType = "VarChar(20)")]
	public string TipoMedioDescrip
	{
		get
		{
			return _TipoMedioDescrip;
		}
		set
		{
			if (!string.Equals(_TipoMedioDescrip, value))
			{
				SendPropertyChanging();
				_TipoMedioDescrip = value;
				SendPropertyChanged("TipoMedioDescrip");
			}
		}
	}

	[Association(Name = "CJRTipoMedio_CJRPublicacion", Storage = "_CJRPublicacion", ThisKey = "idTipoMedio", OtherKey = "idTipoMedio")]
	public EntitySet<CJRPublicacion> CJRPublicacion
	{
		get
		{
			return _CJRPublicacion;
		}
		set
		{
			_CJRPublicacion.Assign(value);
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public CJRTipoMedio()
	{
		_CJRPublicacion = new EntitySet<CJRPublicacion>(attach_CJRPublicacion, detach_CJRPublicacion);
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

	private void attach_CJRPublicacion(CJRPublicacion entity)
	{
		SendPropertyChanging();
		entity.CJRTipoMedio = this;
	}

	private void detach_CJRPublicacion(CJRPublicacion entity)
	{
		SendPropertyChanging();
		entity.CJRTipoMedio = null;
	}
}
