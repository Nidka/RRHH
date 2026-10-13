using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.CJRTipoAprobacion")]
public class CJRTipoAprobacion : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _idAprobacion;

	private string _AprobacionDescrip;

	private EntitySet<CJRDictamenComision> _CJRDictamenComision;

	[Column(Storage = "_idAprobacion", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int idAprobacion
	{
		get
		{
			return _idAprobacion;
		}
		set
		{
			if (_idAprobacion != value)
			{
				SendPropertyChanging();
				_idAprobacion = value;
				SendPropertyChanged("idAprobacion");
			}
		}
	}

	[Column(Storage = "_AprobacionDescrip", DbType = "VarChar(20)")]
	public string AprobacionDescrip
	{
		get
		{
			return _AprobacionDescrip;
		}
		set
		{
			if (!string.Equals(_AprobacionDescrip, value))
			{
				SendPropertyChanging();
				_AprobacionDescrip = value;
				SendPropertyChanged("AprobacionDescrip");
			}
		}
	}

	[Association(Name = "CJRTipoAprobacion_CJRDictamenComision", Storage = "_CJRDictamenComision", ThisKey = "idAprobacion", OtherKey = "idAprobacion")]
	public EntitySet<CJRDictamenComision> CJRDictamenComision
	{
		get
		{
			return _CJRDictamenComision;
		}
		set
		{
			_CJRDictamenComision.Assign(value);
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public CJRTipoAprobacion()
	{
		_CJRDictamenComision = new EntitySet<CJRDictamenComision>(attach_CJRDictamenComision, detach_CJRDictamenComision);
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

	private void attach_CJRDictamenComision(CJRDictamenComision entity)
	{
		SendPropertyChanging();
		entity.CJRTipoAprobacion = this;
	}

	private void detach_CJRDictamenComision(CJRDictamenComision entity)
	{
		SendPropertyChanging();
		entity.CJRTipoAprobacion = null;
	}
}
