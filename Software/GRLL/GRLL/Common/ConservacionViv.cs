using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.ConservacionViv")]
public class ConservacionViv : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdConservacion;

	private string _DescripConserva;

	private EntitySet<Vivienda> _Vivienda;

	[Column(Storage = "_IdConservacion", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdConservacion
	{
		get
		{
			return _IdConservacion;
		}
		set
		{
			if (_IdConservacion != value)
			{
				SendPropertyChanging();
				_IdConservacion = value;
				SendPropertyChanged("IdConservacion");
			}
		}
	}

	[Column(Storage = "_DescripConserva", DbType = "VarChar(17)")]
	public string DescripConserva
	{
		get
		{
			return _DescripConserva;
		}
		set
		{
			if (!string.Equals(_DescripConserva, value))
			{
				SendPropertyChanging();
				_DescripConserva = value;
				SendPropertyChanged("DescripConserva");
			}
		}
	}

	[Association(Name = "ConservacionViv_Vivienda", Storage = "_Vivienda", ThisKey = "IdConservacion", OtherKey = "IdConservacion")]
	public EntitySet<Vivienda> Vivienda
	{
		get
		{
			return _Vivienda;
		}
		set
		{
			_Vivienda.Assign(value);
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public ConservacionViv()
	{
		_Vivienda = new EntitySet<Vivienda>(attach_Vivienda, detach_Vivienda);
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

	private void attach_Vivienda(Vivienda entity)
	{
		SendPropertyChanging();
		entity.ConservacionViv = this;
	}

	private void detach_Vivienda(Vivienda entity)
	{
		SendPropertyChanging();
		entity.ConservacionViv = null;
	}
}
