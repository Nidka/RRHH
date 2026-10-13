using System.ComponentModel;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.UnidadEquivalencia")]
public class UnidadEquivalencia : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _IdBien;

	private string _IdUnidadMedida;

	private decimal? _Equivalencia;

	[Column(Storage = "_IdBien", DbType = "Char(13) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdBien
	{
		get
		{
			return _IdBien;
		}
		set
		{
			if (!string.Equals(_IdBien, value))
			{
				SendPropertyChanging();
				_IdBien = value;
				SendPropertyChanged("IdBien");
			}
		}
	}

	[Column(Storage = "_IdUnidadMedida", DbType = "Char(4) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdUnidadMedida
	{
		get
		{
			return _IdUnidadMedida;
		}
		set
		{
			if (!string.Equals(_IdUnidadMedida, value))
			{
				SendPropertyChanging();
				_IdUnidadMedida = value;
				SendPropertyChanged("IdUnidadMedida");
			}
		}
	}

	[Column(Storage = "_Equivalencia", DbType = "Decimal(18,2)")]
	public decimal? Equivalencia
	{
		get
		{
			return _Equivalencia;
		}
		set
		{
			if (!_Equivalencia.Equals(value))
			{
				SendPropertyChanging();
				_Equivalencia = value;
				SendPropertyChanged("Equivalencia");
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
