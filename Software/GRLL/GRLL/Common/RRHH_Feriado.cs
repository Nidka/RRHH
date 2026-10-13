using System;
using System.ComponentModel;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.RRHH_Feriado")]
public class RRHH_Feriado : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _idFeriado;

	private DateTime? _Fecha;

	private string _Motivo;

	[Column(Storage = "_idFeriado", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int idFeriado
	{
		get
		{
			return _idFeriado;
		}
		set
		{
			if (_idFeriado != value)
			{
				SendPropertyChanging();
				_idFeriado = value;
				SendPropertyChanged("idFeriado");
			}
		}
	}

	[Column(Storage = "_Fecha", DbType = "DateTime")]
	public DateTime? Fecha
	{
		get
		{
			return _Fecha;
		}
		set
		{
			if (!_Fecha.Equals(value))
			{
				SendPropertyChanging();
				_Fecha = value;
				SendPropertyChanged("Fecha");
			}
		}
	}

	[Column(Storage = "_Motivo", DbType = "VarChar(200)")]
	public string Motivo
	{
		get
		{
			return _Motivo;
		}
		set
		{
			if (!string.Equals(_Motivo, value))
			{
				SendPropertyChanging();
				_Motivo = value;
				SendPropertyChanged("Motivo");
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
