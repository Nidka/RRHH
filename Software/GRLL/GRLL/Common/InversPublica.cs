using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.InversPublica")]
public class InversPublica : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdInverPublica;

	private int _Year;

	private int _idAreaOrganiz;

	private decimal? _Total;

	private EntitySet<InversXFuentF> _InversXFuentF;

	private EntityRef<EstructOrganiz> _EstructOrganiz;

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
				SendPropertyChanging();
				_IdInverPublica = value;
				SendPropertyChanged("IdInverPublica");
			}
		}
	}

	[Column(Storage = "_Year", DbType = "Int NOT NULL")]
	public int Year
	{
		get
		{
			return _Year;
		}
		set
		{
			if (_Year != value)
			{
				if (_EstructOrganiz.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_Year = value;
				SendPropertyChanged("Year");
			}
		}
	}

	[Column(Storage = "_idAreaOrganiz", DbType = "Int NOT NULL")]
	public int idAreaOrganiz
	{
		get
		{
			return _idAreaOrganiz;
		}
		set
		{
			if (_idAreaOrganiz != value)
			{
				if (_EstructOrganiz.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_idAreaOrganiz = value;
				SendPropertyChanged("idAreaOrganiz");
			}
		}
	}

	[Column(Storage = "_Total", DbType = "Decimal(11,2)")]
	public decimal? Total
	{
		get
		{
			return _Total;
		}
		set
		{
			if (!_Total.Equals(value))
			{
				SendPropertyChanging();
				_Total = value;
				SendPropertyChanged("Total");
			}
		}
	}

	[Association(Name = "InversPublica_InversXFuentF", Storage = "_InversXFuentF", ThisKey = "IdInverPublica", OtherKey = "IdInverPublica")]
	public EntitySet<InversXFuentF> InversXFuentF
	{
		get
		{
			return _InversXFuentF;
		}
		set
		{
			_InversXFuentF.Assign(value);
		}
	}

	[Association(Name = "EstructOrganiz_InversPublica", Storage = "_EstructOrganiz", ThisKey = "Year,idAreaOrganiz", OtherKey = "Year,idAreaOrganiz", IsForeignKey = true)]
	public EstructOrganiz EstructOrganiz
	{
		get
		{
			return _EstructOrganiz.Entity;
		}
		set
		{
			EstructOrganiz previousValue = _EstructOrganiz.Entity;
			if (!object.Equals(previousValue, value) || !_EstructOrganiz.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_EstructOrganiz.Entity = null;
					previousValue.InversPublica.Remove(this);
				}
				_EstructOrganiz.Entity = value;
				if (value != null)
				{
					value.InversPublica.Add(this);
					_Year = value.Year;
					_idAreaOrganiz = value.idAreaOrganiz;
				}
				else
				{
					_Year = 0;
					_idAreaOrganiz = 0;
				}
				SendPropertyChanged("EstructOrganiz");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public InversPublica()
	{
		_InversXFuentF = new EntitySet<InversXFuentF>(attach_InversXFuentF, detach_InversXFuentF);
		_EstructOrganiz = default(EntityRef<EstructOrganiz>);
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

	private void attach_InversXFuentF(InversXFuentF entity)
	{
		SendPropertyChanging();
		entity.InversPublica = this;
	}

	private void detach_InversXFuentF(InversXFuentF entity)
	{
		SendPropertyChanging();
		entity.InversPublica = null;
	}
}
