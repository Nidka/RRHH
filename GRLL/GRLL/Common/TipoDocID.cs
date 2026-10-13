using System.ComponentModel;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.TipoDocID")]
public class TipoDocID : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _TipoDocID;

	private string _Descripcion;

	[Column(Name = "TipoDocID", Storage = "_TipoDocID", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int TipoDocIDValue
	{
		get
		{
			return _TipoDocID;
		}
		set
		{
			if (_TipoDocID != value)
			{
				SendPropertyChanging();
				_TipoDocID = value;
				SendPropertyChanged("TipoDocID");
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(40)")]
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
