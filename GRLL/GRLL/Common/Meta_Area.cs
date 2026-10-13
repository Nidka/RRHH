using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Meta_Area")]
public class Meta_Area : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _IdMeta;

	private int _IdAreaOrganiz;

	private int _Year;

	private EntityRef<EstructOrganiz> _EstructOrganiz;

	[Column(Storage = "_IdMeta", DbType = "Char(6) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdMeta
	{
		get
		{
			return _IdMeta;
		}
		set
		{
			if (!string.Equals(_IdMeta, value))
			{
				SendPropertyChanging();
				_IdMeta = value;
				SendPropertyChanged("IdMeta");
			}
		}
	}

	[Column(Storage = "_IdAreaOrganiz", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdAreaOrganiz
	{
		get
		{
			return _IdAreaOrganiz;
		}
		set
		{
			if (_IdAreaOrganiz != value)
			{
				if (_EstructOrganiz.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdAreaOrganiz = value;
				SendPropertyChanged("IdAreaOrganiz");
			}
		}
	}

	[Column(Storage = "_Year", DbType = "Int NOT NULL", IsPrimaryKey = true)]
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

	[Association(Name = "EstructOrganiz_Meta_Area", Storage = "_EstructOrganiz", ThisKey = "Year,IdAreaOrganiz", OtherKey = "Year,idAreaOrganiz", IsForeignKey = true)]
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
					previousValue.Meta_Area.Remove(this);
				}
				_EstructOrganiz.Entity = value;
				if (value != null)
				{
					value.Meta_Area.Add(this);
					_Year = value.Year;
					_IdAreaOrganiz = value.idAreaOrganiz;
				}
				else
				{
					_Year = 0;
					_IdAreaOrganiz = 0;
				}
				SendPropertyChanged("EstructOrganiz");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Meta_Area()
	{
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
}
