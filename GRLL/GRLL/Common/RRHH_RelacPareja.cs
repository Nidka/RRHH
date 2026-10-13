using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.RRHH_RelacPareja")]
public class RRHH_RelacPareja : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _idRelacPareja;

	private string _RelacParejaDescrip;

	private EntitySet<RRHH_DinamicaFamiliar> _RRHH_DinamicaFamiliar;

	[Column(Storage = "_idRelacPareja", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int idRelacPareja
	{
		get
		{
			return _idRelacPareja;
		}
		set
		{
			if (_idRelacPareja != value)
			{
				SendPropertyChanging();
				_idRelacPareja = value;
				SendPropertyChanged("idRelacPareja");
			}
		}
	}

	[Column(Storage = "_RelacParejaDescrip", DbType = "VarChar(12)")]
	public string RelacParejaDescrip
	{
		get
		{
			return _RelacParejaDescrip;
		}
		set
		{
			if (!string.Equals(_RelacParejaDescrip, value))
			{
				SendPropertyChanging();
				_RelacParejaDescrip = value;
				SendPropertyChanged("RelacParejaDescrip");
			}
		}
	}

	[Association(Name = "RRHH_RelacPareja_RRHH_DinamicaFamiliar", Storage = "_RRHH_DinamicaFamiliar", ThisKey = "idRelacPareja", OtherKey = "idRelaPareja")]
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

	public RRHH_RelacPareja()
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
		entity.RRHH_RelacPareja = this;
	}

	private void detach_RRHH_DinamicaFamiliar(RRHH_DinamicaFamiliar entity)
	{
		SendPropertyChanging();
		entity.RRHH_RelacPareja = null;
	}
}
