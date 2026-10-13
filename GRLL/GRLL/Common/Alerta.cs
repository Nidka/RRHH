using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Alerta")]
public class Alerta : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _IdAlerta;

	private DateTime? _FechaHora;

	private string _Sistema;

	private int? _IdUsuario1;

	private int? _IdUsuario2;

	private string _Motivo;

	private DateTime? _FechaMostrada;

	private char? _Estado;

	private int? _IdTipoAlerta;

	private int? _Year;

	private int? _idAreaOrganiz;

	private EntityRef<EstructOrganiz> _EstructOrganiz;

	private EntityRef<TipoAlerta> _TipoAlerta;

	private EntityRef<Usuario> _Usuario;

	private EntityRef<Usuario> _Usuario1;

	[Column(Storage = "_IdAlerta", DbType = "VarChar(10) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdAlerta
	{
		get
		{
			return _IdAlerta;
		}
		set
		{
			if (!string.Equals(_IdAlerta, value))
			{
				SendPropertyChanging();
				_IdAlerta = value;
				SendPropertyChanged("IdAlerta");
			}
		}
	}

	[Column(Storage = "_FechaHora", DbType = "DateTime")]
	public DateTime? FechaHora
	{
		get
		{
			return _FechaHora;
		}
		set
		{
			if (!_FechaHora.Equals(value))
			{
				SendPropertyChanging();
				_FechaHora = value;
				SendPropertyChanged("FechaHora");
			}
		}
	}

	[Column(Storage = "_Sistema", DbType = "VarChar(10)")]
	public string Sistema
	{
		get
		{
			return _Sistema;
		}
		set
		{
			if (!string.Equals(_Sistema, value))
			{
				SendPropertyChanging();
				_Sistema = value;
				SendPropertyChanged("Sistema");
			}
		}
	}

	[Column(Storage = "_IdUsuario1", DbType = "Int")]
	public int? IdUsuario1
	{
		get
		{
			return _IdUsuario1;
		}
		set
		{
			if (!_IdUsuario1.Equals(value))
			{
				if (_Usuario1.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdUsuario1 = value;
				SendPropertyChanged("IdUsuario1");
			}
		}
	}

	[Column(Storage = "_IdUsuario2", DbType = "Int")]
	public int? IdUsuario2
	{
		get
		{
			return _IdUsuario2;
		}
		set
		{
			if (!_IdUsuario2.Equals(value))
			{
				if (_Usuario.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdUsuario2 = value;
				SendPropertyChanged("IdUsuario2");
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

	[Column(Storage = "_FechaMostrada", DbType = "DateTime")]
	public DateTime? FechaMostrada
	{
		get
		{
			return _FechaMostrada;
		}
		set
		{
			if (!_FechaMostrada.Equals(value))
			{
				SendPropertyChanging();
				_FechaMostrada = value;
				SendPropertyChanged("FechaMostrada");
			}
		}
	}

	[Column(Storage = "_Estado", DbType = "VarChar(1)")]
	public char? Estado
	{
		get
		{
			return _Estado;
		}
		set
		{
			if (!_Estado.Equals(value))
			{
				SendPropertyChanging();
				_Estado = value;
				SendPropertyChanged("Estado");
			}
		}
	}

	[Column(Storage = "_IdTipoAlerta", DbType = "Int")]
	public int? IdTipoAlerta
	{
		get
		{
			return _IdTipoAlerta;
		}
		set
		{
			if (!_IdTipoAlerta.Equals(value))
			{
				if (_TipoAlerta.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdTipoAlerta = value;
				SendPropertyChanged("IdTipoAlerta");
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

	[Column(Storage = "_idAreaOrganiz", DbType = "Int")]
	public int? idAreaOrganiz
	{
		get
		{
			return _idAreaOrganiz;
		}
		set
		{
			if (!_idAreaOrganiz.Equals(value))
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

	[Association(Name = "EstructOrganiz_Alerta", Storage = "_EstructOrganiz", ThisKey = "Year,idAreaOrganiz", OtherKey = "Year,idAreaOrganiz", IsForeignKey = true)]
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
					previousValue.Alerta.Remove(this);
				}
				_EstructOrganiz.Entity = value;
				if (value != null)
				{
					value.Alerta.Add(this);
					_Year = value.Year;
					_idAreaOrganiz = value.idAreaOrganiz;
				}
				else
				{
					_Year = null;
					_idAreaOrganiz = null;
				}
				SendPropertyChanged("EstructOrganiz");
			}
		}
	}

	[Association(Name = "TipoAlerta_Alerta", Storage = "_TipoAlerta", ThisKey = "IdTipoAlerta", OtherKey = "IdTipoAlerta", IsForeignKey = true)]
	public TipoAlerta TipoAlerta
	{
		get
		{
			return _TipoAlerta.Entity;
		}
		set
		{
			TipoAlerta previousValue = _TipoAlerta.Entity;
			if (!object.Equals(previousValue, value) || !_TipoAlerta.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_TipoAlerta.Entity = null;
					previousValue.Alerta.Remove(this);
				}
				_TipoAlerta.Entity = value;
				if (value != null)
				{
					value.Alerta.Add(this);
					_IdTipoAlerta = value.IdTipoAlerta;
				}
				else
				{
					_IdTipoAlerta = null;
				}
				SendPropertyChanged("TipoAlerta");
			}
		}
	}

	[Association(Name = "Usuario_Alerta", Storage = "_Usuario", ThisKey = "IdUsuario2", OtherKey = "IdUsuario", IsForeignKey = true)]
	public Usuario Usuario
	{
		get
		{
			return _Usuario.Entity;
		}
		set
		{
			Usuario previousValue = _Usuario.Entity;
			if (!object.Equals(previousValue, value) || !_Usuario.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_Usuario.Entity = null;
					previousValue.Alerta.Remove(this);
				}
				_Usuario.Entity = value;
				if (value != null)
				{
					value.Alerta.Add(this);
					_IdUsuario2 = value.IdUsuario;
				}
				else
				{
					_IdUsuario2 = null;
				}
				SendPropertyChanged("Usuario");
			}
		}
	}

	[Association(Name = "Usuario_Alerta1", Storage = "_Usuario1", ThisKey = "IdUsuario1", OtherKey = "IdUsuario", IsForeignKey = true)]
	public Usuario Usuario1
	{
		get
		{
			return _Usuario1.Entity;
		}
		set
		{
			Usuario previousValue = _Usuario1.Entity;
			if (!object.Equals(previousValue, value) || !_Usuario1.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_Usuario1.Entity = null;
					previousValue.Alerta1.Remove(this);
				}
				_Usuario1.Entity = value;
				if (value != null)
				{
					value.Alerta1.Add(this);
					_IdUsuario1 = value.IdUsuario;
				}
				else
				{
					_IdUsuario1 = null;
				}
				SendPropertyChanged("Usuario1");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Alerta()
	{
		_EstructOrganiz = default(EntityRef<EstructOrganiz>);
		_TipoAlerta = default(EntityRef<TipoAlerta>);
		_Usuario = default(EntityRef<Usuario>);
		_Usuario1 = default(EntityRef<Usuario>);
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
