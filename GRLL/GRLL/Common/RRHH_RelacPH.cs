using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.RRHH_RelacPH")]
public class RRHH_RelacPH : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _idRelacPH;

	private string _RelacPHDescrip;

	private EntitySet<RRHH_DinamicaFamiliar> _RRHH_DinamicaFamiliar;

	[Column(Storage = "_idRelacPH", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int idRelacPH
	{
		get
		{
			return _idRelacPH;
		}
		set
		{
			if (_idRelacPH != value)
			{
				SendPropertyChanging();
				_idRelacPH = value;
				SendPropertyChanged("idRelacPH");
			}
		}
	}

	[Column(Storage = "_RelacPHDescrip", DbType = "VarChar(14)")]
	public string RelacPHDescrip
	{
		get
		{
			return _RelacPHDescrip;
		}
		set
		{
			if (!string.Equals(_RelacPHDescrip, value))
			{
				SendPropertyChanging();
				_RelacPHDescrip = value;
				SendPropertyChanged("RelacPHDescrip");
			}
		}
	}

	[Association(Name = "RRHH_RelacPH_RRHH_DinamicaFamiliar", Storage = "_RRHH_DinamicaFamiliar", ThisKey = "idRelacPH", OtherKey = "idRelaPH")]
	public EntitySet<RRHH_DinamicaFamiliar> RRHH_DinamicaFamiliar
	{
		get
		{
			return _RRHH_DinamicaFamiliar;
		}
		set
		{
			_RRHH_DinamicaFamiliar.Assign(value);
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public RRHH_RelacPH()
	{
		_RRHH_DinamicaFamiliar = new EntitySet<RRHH_DinamicaFamiliar>(attach_RRHH_DinamicaFamiliar, detach_RRHH_DinamicaFamiliar);
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

	private void attach_RRHH_DinamicaFamiliar(RRHH_DinamicaFamiliar entity)
	{
		SendPropertyChanging();
		entity.RRHH_RelacPH = this;
	}

	private void detach_RRHH_DinamicaFamiliar(RRHH_DinamicaFamiliar entity)
	{
		SendPropertyChanging();
		entity.RRHH_RelacPH = null;
	}
}
