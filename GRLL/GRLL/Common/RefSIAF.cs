using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.RefSIAF")]
public class RefSIAF : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdReferencia;

	private string _NroRef;

	private string _CPNro;

	private int? _IdTipoMoneda;

	private decimal? _TotalCP;

	private EntitySet<IngresoCaj> _IngresoCaj;

	[Column(Storage = "_IdReferencia", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdReferencia
	{
		get
		{
			return _IdReferencia;
		}
		set
		{
			if (_IdReferencia != value)
			{
				SendPropertyChanging();
				_IdReferencia = value;
				SendPropertyChanged("IdReferencia");
			}
		}
	}

	[Column(Storage = "_NroRef", DbType = "VarChar(25)")]
	public string NroRef
	{
		get
		{
			return _NroRef;
		}
		set
		{
			if (!string.Equals(_NroRef, value))
			{
				SendPropertyChanging();
				_NroRef = value;
				SendPropertyChanged("NroRef");
			}
		}
	}

	[Column(Storage = "_CPNro", DbType = "VarChar(25)")]
	public string CPNro
	{
		get
		{
			return _CPNro;
		}
		set
		{
			if (!string.Equals(_CPNro, value))
			{
				SendPropertyChanging();
				_CPNro = value;
				SendPropertyChanged("CPNro");
			}
		}
	}

	[Column(Storage = "_IdTipoMoneda", DbType = "Int")]
	public int? IdTipoMoneda
	{
		get
		{
			return _IdTipoMoneda;
		}
		set
		{
			if (!_IdTipoMoneda.Equals(value))
			{
				SendPropertyChanging();
				_IdTipoMoneda = value;
				SendPropertyChanged("IdTipoMoneda");
			}
		}
	}

	[Column(Storage = "_TotalCP", DbType = "Decimal(11,2)")]
	public decimal? TotalCP
	{
		get
		{
			return _TotalCP;
		}
		set
		{
			if (!_TotalCP.Equals(value))
			{
				SendPropertyChanging();
				_TotalCP = value;
				SendPropertyChanged("TotalCP");
			}
		}
	}

	[Association(Name = "RefSIAF_IngresoCaj", Storage = "_IngresoCaj", ThisKey = "IdReferencia", OtherKey = "IdReferencia")]
	public EntitySet<IngresoCaj> IngresoCaj
	{
		get
		{
			return _IngresoCaj;
		}
		set
		{
			_IngresoCaj.Assign(value);
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public RefSIAF()
	{
		_IngresoCaj = new EntitySet<IngresoCaj>(attach_IngresoCaj, detach_IngresoCaj);
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

	private void attach_IngresoCaj(IngresoCaj entity)
	{
		SendPropertyChanging();
		entity.RefSIAF = this;
	}

	private void detach_IngresoCaj(IngresoCaj entity)
	{
		SendPropertyChanging();
		entity.RefSIAF = null;
	}
}
