using System.ComponentModel;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.PeriodoTrimestral")]
public class PeriodoTrimestral : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private byte _IdPeriodoT;

	private int? _Year;

	private short? _Trimestre;

	private string _Periodo;

	[Column(Storage = "_IdPeriodoT", DbType = "TinyInt NOT NULL", IsPrimaryKey = true)]
	public byte IdPeriodoT
	{
		get
		{
			return _IdPeriodoT;
		}
		set
		{
			if (_IdPeriodoT != value)
			{
				SendPropertyChanging();
				_IdPeriodoT = value;
				SendPropertyChanged("IdPeriodoT");
			}
		}
	}

	[Column(Storage = "_Year", DbType = "Int")]
	public int? Year
	{
		get
		{
			return _Year;
		}
		set
		{
			if (!_Year.Equals(value))
			{
				SendPropertyChanging();
				_Year = value;
				SendPropertyChanged("Year");
			}
		}
	}

	[Column(Storage = "_Trimestre", DbType = "SmallInt")]
	public short? Trimestre
	{
		get
		{
			return _Trimestre;
		}
		set
		{
			if (!_Trimestre.Equals(value))
			{
				SendPropertyChanging();
				_Trimestre = value;
				SendPropertyChanged("Trimestre");
			}
		}
	}

	[Column(Storage = "_Periodo", DbType = "VarChar(6)")]
	public string Periodo
	{
		get
		{
			return _Periodo;
		}
		set
		{
			if (!string.Equals(_Periodo, value))
			{
				SendPropertyChanging();
				_Periodo = value;
				SendPropertyChanged("Periodo");
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
