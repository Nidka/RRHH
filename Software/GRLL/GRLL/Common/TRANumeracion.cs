using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.TRANumeracion")]
public class TRANumeracion : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _IdTipoDoc;

	private int _Year;

	private int _IdAreaOrganiz;

	private decimal? _Numero;

	private EntityRef<EstructOrganiz> _EstructOrganiz;

	private EntityRef<TRATipoDoc> _TRATipoDoc;

	[Column(Storage = "_IdTipoDoc", DbType = "Char(2) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdTipoDoc
	{
		get
		{
			return _IdTipoDoc;
		}
		set
		{
			if (!string.Equals(_IdTipoDoc, value))
			{
				if (_TRATipoDoc.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdTipoDoc = value;
				SendPropertyChanged("IdTipoDoc");
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

	[Column(Storage = "_Numero", DbType = "Decimal(18,0)")]
	public decimal? Numero
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

	[Association(Name = "EstructOrganiz_TRANumeracion", Storage = "_EstructOrganiz", ThisKey = "Year,IdAreaOrganiz", OtherKey = "Year,idAreaOrganiz", IsForeignKey = true)]
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
					previousValue.TRANumeracion.Remove(this);
				}
				_EstructOrganiz.Entity = value;
				if (value != null)
				{
					value.TRANumeracion.Add(this);
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

	[Association(Name = "TRATipoDoc_TRANumeracion", Storage = "_TRATipoDoc", ThisKey = "IdTipoDoc", OtherKey = "IdTipoDoc", IsForeignKey = true)]
	public TRATipoDoc TRATipoDoc
	{
		get
		{
			return _TRATipoDoc.Entity;
		}
		set
		{
			TRATipoDoc previousValue = _TRATipoDoc.Entity;
			if (!object.Equals(previousValue, value) || !_TRATipoDoc.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_TRATipoDoc.Entity = null;
					previousValue.TRANumeracion.Remove(this);
				}
				_TRATipoDoc.Entity = value;
				if (value != null)
				{
					value.TRANumeracion.Add(this);
					_IdTipoDoc = value.IdTipoDoc;
				}
				else
				{
					_IdTipoDoc = null;
				}
				SendPropertyChanged("TRATipoDoc");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public TRANumeracion()
	{
		_EstructOrganiz = default(EntityRef<EstructOrganiz>);
		_TRATipoDoc = default(EntityRef<TRATipoDoc>);
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
