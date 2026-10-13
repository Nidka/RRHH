using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.TipoComportamiento")]
public class TipoComportamiento : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _idTipoComportamiento;

	private string _TipoCompDescrip;

	private EntitySet<Comportamiento> _Comportamiento;

	[Column(Storage = "_idTipoComportamiento", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int idTipoComportamiento
	{
		get
		{
			return _idTipoComportamiento;
		}
		set
		{
			if (_idTipoComportamiento != value)
			{
				SendPropertyChanging();
				_idTipoComportamiento = value;
				SendPropertyChanged("idTipoComportamiento");
			}
		}
	}

	[Column(Storage = "_TipoCompDescrip", DbType = "VarChar(8)")]
	public string TipoCompDescrip
	{
		get
		{
			return _TipoCompDescrip;
		}
		set
		{
			if (!string.Equals(_TipoCompDescrip, value))
			{
				SendPropertyChanging();
				_TipoCompDescrip = value;
				SendPropertyChanged("TipoCompDescrip");
			}
		}
	}

	[Association(Name = "TipoComportamiento_Comportamiento", Storage = "_Comportamiento", ThisKey = "idTipoComportamiento", OtherKey = "idTipoComportamiento")]
	public EntitySet<Comportamiento> Comportamiento
	{
		get
		{
			return _Comportamiento;
		}
		set
		{
			_Comportamiento.Assign(value);
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public TipoComportamiento()
	{
		_Comportamiento = new EntitySet<Comportamiento>(attach_Comportamiento, detach_Comportamiento);
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

	private void attach_Comportamiento(Comportamiento entity)
	{
		SendPropertyChanging();
		entity.TipoComportamiento = this;
	}

	private void detach_Comportamiento(Comportamiento entity)
	{
		SendPropertyChanging();
		entity.TipoComportamiento = null;
	}
}
