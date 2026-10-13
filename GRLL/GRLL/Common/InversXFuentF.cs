using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.InversXFuentF")]
public class InversXFuentF : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdInverPublica;

	private string _IdFinanciamiento;

	private decimal? _Inversion;

	private EntityRef<Financiamiento> _Financiamiento;

	private EntityRef<InversPublica> _InversPublica;

	[Column(Storage = "_IdInverPublica", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdInverPublica
	{
		get
		{
			return _IdInverPublica;
		}
		set
		{
			if (_IdInverPublica != value)
			{
				if (_InversPublica.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdInverPublica = value;
				SendPropertyChanged("IdInverPublica");
			}
		}
	}

	[Column(Storage = "_IdFinanciamiento", DbType = "Char(2) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdFinanciamiento
	{
		get
		{
			return _IdFinanciamiento;
		}
		set
		{
			if (!string.Equals(_IdFinanciamiento, value))
			{
				if (_Financiamiento.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdFinanciamiento = value;
				SendPropertyChanged("IdFinanciamiento");
			}
		}
	}

	[Column(Storage = "_Inversion", DbType = "Decimal(11,2)")]
	public decimal? Inversion
	{
		get
		{
			return _Inversion;
		}
		set
		{
			if (!_Inversion.Equals(value))
			{
				SendPropertyChanging();
				_Inversion = value;
				SendPropertyChanged("Inversion");
			}
		}
	}

	[Association(Name = "Financiamiento_InversXFuentF", Storage = "_Financiamiento", ThisKey = "IdFinanciamiento", OtherKey = "IdFinanciamiento", IsForeignKey = true)]
	public Financiamiento Financiamiento
	{
		get
		{
			return _Financiamiento.Entity;
		}
		set
		{
			Financiamiento previousValue = _Financiamiento.Entity;
			if (!object.Equals(previousValue, value) || !_Financiamiento.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_Financiamiento.Entity = null;
					previousValue.InversXFuentF.Remove(this);
				}
				_Financiamiento.Entity = value;
				if (value != null)
				{
					value.InversXFuentF.Add(this);
					_IdFinanciamiento = value.IdFinanciamiento;
				}
				else
				{
					_IdFinanciamiento = null;
				}
				SendPropertyChanged("Financiamiento");
			}
		}
	}

	[Association(Name = "InversPublica_InversXFuentF", Storage = "_InversPublica", ThisKey = "IdInverPublica", OtherKey = "IdInverPublica", IsForeignKey = true)]
	public InversPublica InversPublica
	{
		get
		{
			return _InversPublica.Entity;
		}
		set
		{
			InversPublica previousValue = _InversPublica.Entity;
			if (!object.Equals(previousValue, value) || !_InversPublica.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_InversPublica.Entity = null;
					previousValue.InversXFuentF.Remove(this);
				}
				_InversPublica.Entity = value;
				if (value != null)
				{
					value.InversXFuentF.Add(this);
					_IdInverPublica = value.IdInverPublica;
				}
				else
				{
					_IdInverPublica = 0;
				}
				SendPropertyChanged("InversPublica");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public InversXFuentF()
	{
		_Financiamiento = default(EntityRef<Financiamiento>);
		_InversPublica = default(EntityRef<InversPublica>);
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
}
