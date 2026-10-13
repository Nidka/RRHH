using System.ComponentModel;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.CJRTipoSolicitud")]
public class CJRTipoSolicitud : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _idTipoSolicitud;

	private string _DescripTipoSolicitud;

	[Column(Storage = "_idTipoSolicitud", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int idTipoSolicitud
	{
		get
		{
			return _idTipoSolicitud;
		}
		set
		{
			if (_idTipoSolicitud != value)
			{
				SendPropertyChanging();
				_idTipoSolicitud = value;
				SendPropertyChanged("idTipoSolicitud");
			}
		}
	}

	[Column(Storage = "_DescripTipoSolicitud", DbType = "VarChar(20)")]
	public string DescripTipoSolicitud
	{
		get
		{
			return _DescripTipoSolicitud;
		}
		set
		{
			if (!string.Equals(_DescripTipoSolicitud, value))
			{
				SendPropertyChanging();
				_DescripTipoSolicitud = value;
				SendPropertyChanged("DescripTipoSolicitud");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

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
}
