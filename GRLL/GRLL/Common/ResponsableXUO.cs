using System;
using System.ComponentModel;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.ResponsableXUO")]
public class ResponsableXUO : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdResponsable;

	private int? _Year;

	private int? _idAreaOrganiz;

	private string _AreaOrganizacional;

	private int? _idDependeDe;

	private int? _IdEmpleado;

	private DateTime? _F_Inicio;

	private DateTime? _F_Termino;

	[Column(Storage = "_IdResponsable", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdResponsable
	{
		get
		{
			return _IdResponsable;
		}
		set
		{
			if (_IdResponsable != value)
			{
				SendPropertyChanging();
				_IdResponsable = value;
				SendPropertyChanged("IdResponsable");
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
				SendPropertyChanging();
				_idAreaOrganiz = value;
				SendPropertyChanged("idAreaOrganiz");
			}
		}
	}

	[Column(Storage = "_AreaOrganizacional", DbType = "VarChar(80)")]
	public string AreaOrganizacional
	{
		get
		{
			return _AreaOrganizacional;
		}
		set
		{
			if (!string.Equals(_AreaOrganizacional, value))
			{
				SendPropertyChanging();
				_AreaOrganizacional = value;
				SendPropertyChanged("AreaOrganizacional");
			}
		}
	}

	[Column(Storage = "_idDependeDe", DbType = "Int")]
	public int? idDependeDe
	{
		get
		{
			return _idDependeDe;
		}
		set
		{
			if (!_idDependeDe.Equals(value))
			{
				SendPropertyChanging();
				_idDependeDe = value;
				SendPropertyChanged("idDependeDe");
			}
		}
	}

	[Column(Storage = "_IdEmpleado", DbType = "Int")]
	public int? IdEmpleado
	{
		get
		{
			return _IdEmpleado;
		}
		set
		{
			if (!_IdEmpleado.Equals(value))
			{
				SendPropertyChanging();
				_IdEmpleado = value;
				SendPropertyChanged("IdEmpleado");
			}
		}
	}

	[Column(Storage = "_F_Inicio", DbType = "SmallDateTime")]
	public DateTime? F_Inicio
	{
		get
		{
			return _F_Inicio;
		}
		set
		{
			if (!_F_Inicio.Equals(value))
			{
				SendPropertyChanging();
				_F_Inicio = value;
				SendPropertyChanged("F_Inicio");
			}
		}
	}

	[Column(Storage = "_F_Termino", DbType = "SmallDateTime")]
	public DateTime? F_Termino
	{
		get
		{
			return _F_Termino;
		}
		set
		{
			if (!_F_Termino.Equals(value))
			{
				SendPropertyChanging();
				_F_Termino = value;
				SendPropertyChanged("F_Termino");
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
