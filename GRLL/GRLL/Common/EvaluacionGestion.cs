using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.EvaluacionGestion")]
public class EvaluacionGestion : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _Year;

	private int _idAreaOrganiz;

	private int _IdVariable;

	private int _IdEvalGestion;

	private short? _Puntaje;

	private int? _IdAreaOrgEval;

	private int? _YearEval;

	private short? _Trimestre;

	private EntityRef<EstructOrganiz> _EstructOrganiz;

	private EntityRef<VariableGestion> _VariableGestion;

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

	[Column(Storage = "_idAreaOrganiz", DbType = "Int NOT NULL", IsPrimaryKey = true)]
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

	[Column(Storage = "_IdVariable", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdVariable
	{
		get
		{
			return _IdVariable;
		}
		set
		{
			if (_IdVariable != value)
			{
				if (_VariableGestion.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdVariable = value;
				SendPropertyChanged("IdVariable");
			}
		}
	}

	[Column(Storage = "_IdEvalGestion", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdEvalGestion
	{
		get
		{
			return _IdEvalGestion;
		}
		set
		{
			if (_IdEvalGestion != value)
			{
				SendPropertyChanging();
				_IdEvalGestion = value;
				SendPropertyChanged("IdEvalGestion");
			}
		}
	}

	[Column(Storage = "_Puntaje", DbType = "SmallInt")]
	public short? Puntaje
	{
		get
		{
			return _Puntaje;
		}
		set
		{
			if (!_Puntaje.Equals(value))
			{
				SendPropertyChanging();
				_Puntaje = value;
				SendPropertyChanged("Puntaje");
			}
		}
	}

	[Column(Storage = "_IdAreaOrgEval", DbType = "Int")]
	public int? IdAreaOrgEval
	{
		get
		{
			return _IdAreaOrgEval;
		}
		set
		{
			if (!_IdAreaOrgEval.Equals(value))
			{
				SendPropertyChanging();
				_IdAreaOrgEval = value;
				SendPropertyChanged("IdAreaOrgEval");
			}
		}
	}

	[Column(Storage = "_YearEval", DbType = "Int")]
	public int? YearEval
	{
		get
		{
			return _YearEval;
		}
		set
		{
			if (!_YearEval.Equals(value))
			{
				SendPropertyChanging();
				_YearEval = value;
				SendPropertyChanged("YearEval");
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

	[Association(Name = "EstructOrganiz_EvaluacionGestion", Storage = "_EstructOrganiz", ThisKey = "Year,idAreaOrganiz", OtherKey = "Year,idAreaOrganiz", IsForeignKey = true)]
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
					previousValue.EvaluacionGestion.Remove(this);
				}
				_EstructOrganiz.Entity = value;
				if (value != null)
				{
					value.EvaluacionGestion.Add(this);
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

	[Association(Name = "VariableGestion_EvaluacionGestion", Storage = "_VariableGestion", ThisKey = "IdVariable", OtherKey = "IdVariable", IsForeignKey = true)]
	public VariableGestion VariableGestion
	{
		get
		{
			return _VariableGestion.Entity;
		}
		set
		{
			VariableGestion previousValue = _VariableGestion.Entity;
			if (!object.Equals(previousValue, value) || !_VariableGestion.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_VariableGestion.Entity = null;
					previousValue.EvaluacionGestion.Remove(this);
				}
				_VariableGestion.Entity = value;
				if (value != null)
				{
					value.EvaluacionGestion.Add(this);
					_IdVariable = value.IdVariable;
				}
				else
				{
					_IdVariable = 0;
				}
				SendPropertyChanged("VariableGestion");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public EvaluacionGestion()
	{
		_EstructOrganiz = default(EntityRef<EstructOrganiz>);
		_VariableGestion = default(EntityRef<VariableGestion>);
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
