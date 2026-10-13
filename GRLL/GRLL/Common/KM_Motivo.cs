using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.KM_Motivo")]
public class KM_Motivo : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _idMotivo;

	private string _Descrip_Motivo;

	private EntitySet<KM_Orden> _KM_Orden;

	[Column(Storage = "_idMotivo", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int idMotivo
	{
		get
		{
			return _idMotivo;
		}
		set
		{
			if (_idMotivo != value)
			{
				SendPropertyChanging();
				_idMotivo = value;
				SendPropertyChanged("idMotivo");
			}
		}
	}

	[Column(Storage = "_Descrip_Motivo", DbType = "VarChar(40)")]
	public string Descrip_Motivo
	{
		get
		{
			return _Descrip_Motivo;
		}
		set
		{
			if (!string.Equals(_Descrip_Motivo, value))
			{
				SendPropertyChanging();
				_Descrip_Motivo = value;
				SendPropertyChanged("Descrip_Motivo");
			}
		}
	}

	[Association(Name = "KM_Motivo_KM_Orden", Storage = "_KM_Orden", ThisKey = "idMotivo", OtherKey = "idMotivo")]
	public EntitySet<KM_Orden> KM_Orden
	{
		get
		{
			return _KM_Orden;
		}
		set
		{
			_KM_Orden.Assign(value);
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public KM_Motivo()
	{
		_KM_Orden = new EntitySet<KM_Orden>(attach_KM_Orden, detach_KM_Orden);
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

	private void attach_KM_Orden(KM_Orden entity)
	{
		SendPropertyChanging();
		entity.KM_Motivo = this;
	}

	private void detach_KM_Orden(KM_Orden entity)
	{
		SendPropertyChanging();
		entity.KM_Motivo = null;
	}
}
