using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.CJRIniciativa")]
public class CJRIniciativa : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _NumOficioIniciativa;

	private string _NombreResponsable;

	private int? _idOperador;

	private bool? _AdjuntaOT;

	private bool? _AdjuntaOL;

	private EntitySet<CJRTemaIniciativa> _CJRTemaIniciativa;

	private EntitySet<CJRTemaIniciativa> _CJRTemaIniciativa1;

	private EntitySet<CJRTemaIniciativa> _CJRTemaIniciativa2;

	private EntityRef<CJROficio> _CJROficio;

	private EntityRef<CJROperador> _CJROperador;

	[Column(Storage = "_NumOficioIniciativa", DbType = "VarChar(120) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string NumOficioIniciativa
	{
		get
		{
			return _NumOficioIniciativa;
		}
		set
		{
			if (!string.Equals(_NumOficioIniciativa, value))
			{
				if (_CJROficio.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_NumOficioIniciativa = value;
				SendPropertyChanged("NumOficioIniciativa");
			}
		}
	}

	[Column(Storage = "_NombreResponsable", DbType = "VarChar(200)")]
	public string NombreResponsable
	{
		get
		{
			return _NombreResponsable;
		}
		set
		{
			if (!string.Equals(_NombreResponsable, value))
			{
				SendPropertyChanging();
				_NombreResponsable = value;
				SendPropertyChanged("NombreResponsable");
			}
		}
	}

	[Column(Storage = "_idOperador", DbType = "Int")]
	public int? idOperador
	{
		get
		{
			return _idOperador;
		}
		set
		{
			if (!_idOperador.Equals(value))
			{
				if (_CJROperador.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_idOperador = value;
				SendPropertyChanged("idOperador");
			}
		}
	}

	[Column(Storage = "_AdjuntaOT", DbType = "Bit")]
	public bool? AdjuntaOT
	{
		get
		{
			return _AdjuntaOT;
		}
		set
		{
			if (!_AdjuntaOT.Equals(value))
			{
				SendPropertyChanging();
				_AdjuntaOT = value;
				SendPropertyChanged("AdjuntaOT");
			}
		}
	}

	[Column(Storage = "_AdjuntaOL", DbType = "Bit")]
	public bool? AdjuntaOL
	{
		get
		{
			return _AdjuntaOL;
		}
		set
		{
			if (!_AdjuntaOL.Equals(value))
			{
				SendPropertyChanging();
				_AdjuntaOL = value;
				SendPropertyChanged("AdjuntaOL");
			}
		}
	}

	[Association(Name = "CJRIniciativa_CJRTemaIniciativa", Storage = "_CJRTemaIniciativa", ThisKey = "NumOficioIniciativa", OtherKey = "NumOficioIniciativa")]
	public EntitySet<CJRTemaIniciativa> CJRTemaIniciativa
	{
		get
		{
			return _CJRTemaIniciativa;
		}
		set
		{
			_CJRTemaIniciativa.Assign(value);
		}
	}

	[Association(Name = "CJRIniciativa_CJRTemaIniciativa1", Storage = "_CJRTemaIniciativa1", ThisKey = "NumOficioIniciativa", OtherKey = "NumOficioIniciativa")]
	public EntitySet<CJRTemaIniciativa> CJRTemaIniciativa1
	{
		get
		{
			return _CJRTemaIniciativa1;
		}
		set
		{
			_CJRTemaIniciativa1.Assign(value);
		}
	}

	[Association(Name = "CJRIniciativa_CJRTemaIniciativa2", Storage = "_CJRTemaIniciativa2", ThisKey = "NumOficioIniciativa", OtherKey = "NumOficioIniciativa")]
	public EntitySet<CJRTemaIniciativa> CJRTemaIniciativa2
	{
		get
		{
			return _CJRTemaIniciativa2;
		}
		set
		{
			_CJRTemaIniciativa2.Assign(value);
		}
	}

	[Association(Name = "CJROficio_CJRIniciativa", Storage = "_CJROficio", ThisKey = "NumOficioIniciativa", OtherKey = "NumOficio", IsForeignKey = true)]
	public CJROficio CJROficio
	{
		get
		{
			return _CJROficio.Entity;
		}
		set
		{
			CJROficio previousValue = _CJROficio.Entity;
			if (!object.Equals(previousValue, value) || !_CJROficio.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_CJROficio.Entity = null;
					previousValue.CJRIniciativa = null;
				}
				_CJROficio.Entity = value;
				if (value != null)
				{
					value.CJRIniciativa = this;
					_NumOficioIniciativa = value.NumOficio;
				}
				else
				{
					_NumOficioIniciativa = null;
				}
				SendPropertyChanged("CJROficio");
			}
		}
	}

	[Association(Name = "CJROperador_CJRIniciativa", Storage = "_CJROperador", ThisKey = "idOperador", OtherKey = "idOperador", IsForeignKey = true)]
	public CJROperador CJROperador
	{
		get
		{
			return _CJROperador.Entity;
		}
		set
		{
			CJROperador previousValue = _CJROperador.Entity;
			if (!object.Equals(previousValue, value) || !_CJROperador.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_CJROperador.Entity = null;
					previousValue.CJRIniciativa.Remove(this);
				}
				_CJROperador.Entity = value;
				if (value != null)
				{
					value.CJRIniciativa.Add(this);
					_idOperador = value.idOperador;
				}
				else
				{
					_idOperador = null;
				}
				SendPropertyChanged("CJROperador");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public CJRIniciativa()
	{
		_CJRTemaIniciativa = new EntitySet<CJRTemaIniciativa>(attach_CJRTemaIniciativa, detach_CJRTemaIniciativa);
		_CJRTemaIniciativa1 = new EntitySet<CJRTemaIniciativa>(attach_CJRTemaIniciativa1, detach_CJRTemaIniciativa1);
		_CJRTemaIniciativa2 = new EntitySet<CJRTemaIniciativa>(attach_CJRTemaIniciativa2, detach_CJRTemaIniciativa2);
		_CJROficio = default(EntityRef<CJROficio>);
		_CJROperador = default(EntityRef<CJROperador>);
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

	private void attach_CJRTemaIniciativa(CJRTemaIniciativa entity)
	{
		SendPropertyChanging();
		entity.CJRIniciativa = this;
	}

	private void detach_CJRTemaIniciativa(CJRTemaIniciativa entity)
	{
		SendPropertyChanging();
		entity.CJRIniciativa = null;
	}

	private void attach_CJRTemaIniciativa1(CJRTemaIniciativa entity)
	{
		SendPropertyChanging();
		entity.CJRIniciativa1 = this;
	}

	private void detach_CJRTemaIniciativa1(CJRTemaIniciativa entity)
	{
		SendPropertyChanging();
		entity.CJRIniciativa1 = null;
	}

	private void attach_CJRTemaIniciativa2(CJRTemaIniciativa entity)
	{
		SendPropertyChanging();
		entity.CJRIniciativa2 = this;
	}

	private void detach_CJRTemaIniciativa2(CJRTemaIniciativa entity)
	{
		SendPropertyChanging();
		entity.CJRIniciativa2 = null;
	}
}
