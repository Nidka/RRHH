using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.ReqXProgMes")]
public class ReqXProgMes : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdObjetivo;

	private int _IdActividad;

	private int _IdMes;

	private string _IdBien;

	private decimal? _Cantidad;

	private string _IdUnidadMedida;

	private decimal? _CostoEstimado;

	private decimal? _CantidadConsumida;

	private decimal? _CostoReal;

	private EntityRef<Bien> _Bien;

	private EntityRef<ProgramMes> _ProgramMes;

	[Column(Storage = "_IdObjetivo", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdObjetivo
	{
		get
		{
			return _IdObjetivo;
		}
		set
		{
			if (_IdObjetivo != value)
			{
				if (_ProgramMes.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdObjetivo = value;
				SendPropertyChanged("IdObjetivo");
			}
		}
	}

	[Column(Storage = "_IdActividad", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdActividad
	{
		get
		{
			return _IdActividad;
		}
		set
		{
			if (_IdActividad != value)
			{
				if (_ProgramMes.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdActividad = value;
				SendPropertyChanged("IdActividad");
			}
		}
	}

	[Column(Storage = "_IdMes", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdMes
	{
		get
		{
			return _IdMes;
		}
		set
		{
			if (_IdMes != value)
			{
				if (_ProgramMes.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdMes = value;
				SendPropertyChanged("IdMes");
			}
		}
	}

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
				if (_Bien.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdBien = value;
				SendPropertyChanged("IdBien");
			}
		}
	}

	[Column(Storage = "_Cantidad", DbType = "Decimal(11,2)")]
	public decimal? Cantidad
	{
		get
		{
			return _Cantidad;
		}
		set
		{
			if (!_Cantidad.Equals(value))
			{
				SendPropertyChanging();
				_Cantidad = value;
				SendPropertyChanged("Cantidad");
			}
		}
	}

	[Column(Storage = "_IdUnidadMedida", DbType = "Char(4)")]
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

	[Column(Storage = "_CostoEstimado", DbType = "Decimal(11,2)")]
	public decimal? CostoEstimado
	{
		get
		{
			return _CostoEstimado;
		}
		set
		{
			if (!_CostoEstimado.Equals(value))
			{
				SendPropertyChanging();
				_CostoEstimado = value;
				SendPropertyChanged("CostoEstimado");
			}
		}
	}

	[Column(Storage = "_CantidadConsumida", DbType = "Decimal(11,2)")]
	public decimal? CantidadConsumida
	{
		get
		{
			return _CantidadConsumida;
		}
		set
		{
			if (!_CantidadConsumida.Equals(value))
			{
				SendPropertyChanging();
				_CantidadConsumida = value;
				SendPropertyChanged("CantidadConsumida");
			}
		}
	}

	[Column(Storage = "_CostoReal", DbType = "Decimal(11,2)")]
	public decimal? CostoReal
	{
		get
		{
			return _CostoReal;
		}
		set
		{
			if (!_CostoReal.Equals(value))
			{
				SendPropertyChanging();
				_CostoReal = value;
				SendPropertyChanged("CostoReal");
			}
		}
	}

	[Association(Name = "Bien_ReqXProgMes", Storage = "_Bien", ThisKey = "IdBien", OtherKey = "IdBien", IsForeignKey = true, DeleteOnNull = true, DeleteRule = "CASCADE")]
	public Bien Bien
	{
		get
		{
			return _Bien.Entity;
		}
		set
		{
			Bien previousValue = _Bien.Entity;
			if (!object.Equals(previousValue, value) || !_Bien.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_Bien.Entity = null;
					previousValue.ReqXProgMes.Remove(this);
				}
				_Bien.Entity = value;
				if (value != null)
				{
					value.ReqXProgMes.Add(this);
					_IdBien = value.IdBien;
				}
				else
				{
					_IdBien = null;
				}
				SendPropertyChanged("Bien");
			}
		}
	}

	[Association(Name = "ProgramMes_ReqXProgMes", Storage = "_ProgramMes", ThisKey = "IdObjetivo,IdActividad,IdMes", OtherKey = "IdObjetivo,IdActividad,IdMes", IsForeignKey = true)]
	public ProgramMes ProgramMes
	{
		get
		{
			return _ProgramMes.Entity;
		}
		set
		{
			ProgramMes previousValue = _ProgramMes.Entity;
			if (!object.Equals(previousValue, value) || !_ProgramMes.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_ProgramMes.Entity = null;
					previousValue.ReqXProgMes.Remove(this);
				}
				_ProgramMes.Entity = value;
				if (value != null)
				{
					value.ReqXProgMes.Add(this);
					_IdObjetivo = value.IdObjetivo;
					_IdActividad = value.IdActividad;
					_IdMes = value.IdMes;
				}
				else
				{
					_IdObjetivo = 0;
					_IdActividad = 0;
					_IdMes = 0;
				}
				SendPropertyChanged("ProgramMes");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public ReqXProgMes()
	{
		_Bien = default(EntityRef<Bien>);
		_ProgramMes = default(EntityRef<ProgramMes>);
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
