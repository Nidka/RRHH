using System.ComponentModel;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.TipoDoc")]
public class TipoDoc : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _IdTipodoc;

	private string _Descripcion;

	private int? _Numero;

	private byte? _Serie;

	private string _Anio;

	[Column(Storage = "_IdTipodoc", DbType = "Char(2) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdTipodoc
	{
		get
		{
			return _IdTipodoc;
		}
		set
		{
			if (!string.Equals(_IdTipodoc, value))
			{
				SendPropertyChanging();
				_IdTipodoc = value;
				SendPropertyChanged("IdTipodoc");
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

	[Column(Storage = "_Numero", DbType = "Int")]
	public int? Numero
	{
		get
		{
			return _Numero;
		}
		set
		{
			if (!_Numero.Equals(value))
			{
				SendPropertyChanging();
				_Numero = value;
				SendPropertyChanged("Numero");
			}
		}
	}

	[Column(Storage = "_Serie", DbType = "TinyInt")]
	public byte? Serie
	{
		get
		{
			return _Serie;
		}
		set
		{
			if (!_Serie.Equals(value))
			{
				SendPropertyChanging();
				_Serie = value;
				SendPropertyChanged("Serie");
			}
		}
	}

	[Column(Storage = "_Anio", DbType = "Char(4) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string Anio
	{
		get
		{
			return _Anio;
		}
		set
		{
			if (!string.Equals(_Anio, value))
			{
				SendPropertyChanging();
				_Anio = value;
				SendPropertyChanged("Anio");
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
