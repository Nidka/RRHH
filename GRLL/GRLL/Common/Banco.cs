using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Banco")]
public class Banco : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdBanco;

	private string _Nombre;

	private string _Abreviatura;

	private string _IdUbigeo;

	private string _Direccion;

	private EntitySet<TransferenciaBco> _TransferenciaBco;

	[Column(Storage = "_IdBanco", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdBanco
	{
		get
		{
			return _IdBanco;
		}
		set
		{
			if (_IdBanco != value)
			{
				SendPropertyChanging();
				_IdBanco = value;
				SendPropertyChanged("IdBanco");
			}
		}
	}

	[Column(Storage = "_Nombre", DbType = "VarChar(50)")]
	public string Nombre
	{
		get
		{
			return _Nombre;
		}
		set
		{
			if (!string.Equals(_Nombre, value))
			{
				SendPropertyChanging();
				_Nombre = value;
				SendPropertyChanged("Nombre");
			}
		}
	}

	[Column(Storage = "_Abreviatura", DbType = "VarChar(10)")]
	public string Abreviatura
	{
		get
		{
			return _Abreviatura;
		}
		set
		{
			if (!string.Equals(_Abreviatura, value))
			{
				SendPropertyChanging();
				_Abreviatura = value;
				SendPropertyChanged("Abreviatura");
			}
		}
	}

	[Column(Storage = "_IdUbigeo", DbType = "VarChar(6)")]
	public string IdUbigeo
	{
		get
		{
			return _IdUbigeo;
		}
		set
		{
			if (!string.Equals(_IdUbigeo, value))
			{
				SendPropertyChanging();
				_IdUbigeo = value;
				SendPropertyChanged("IdUbigeo");
			}
		}
	}

	[Column(Storage = "_Direccion", DbType = "VarChar(80)")]
	public string Direccion
	{
		get
		{
			return _Direccion;
		}
		set
		{
			if (!string.Equals(_Direccion, value))
			{
				SendPropertyChanging();
				_Direccion = value;
				SendPropertyChanged("Direccion");
			}
		}
	}

	[Association(Name = "Banco_TransferenciaBco", Storage = "_TransferenciaBco", ThisKey = "IdBanco", OtherKey = "IdBancoDe")]
	public EntitySet<TransferenciaBco> TransferenciaBco
	{
		get
		{
			return _TransferenciaBco;
		}
		set
		{
			_TransferenciaBco.Assign(value);
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Banco()
	{
		_TransferenciaBco = new EntitySet<TransferenciaBco>(attach_TransferenciaBco, detach_TransferenciaBco);
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

	private void attach_TransferenciaBco(TransferenciaBco entity)
	{
		SendPropertyChanging();
		entity.Banco = this;
	}

	private void detach_TransferenciaBco(TransferenciaBco entity)
	{
		SendPropertyChanging();
		entity.Banco = null;
	}
}
