using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.RRHH_RelacHermano")]
public class RRHH_RelacHermano : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _idRelacHermano;

	private string _RelacHermanoDescrip;

	private EntitySet<RRHH_DinamicaFamiliar> _RRHH_DinamicaFamiliar;

	[Column(Storage = "_idRelacHermano", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int idRelacHermano
	{
		get
		{
			return _idRelacHermano;
		}
		set
		{
			if (_idRelacHermano != value)
			{
				SendPropertyChanging();
				_idRelacHermano = value;
				SendPropertyChanged("idRelacHermano");
			}
		}
	}

	[Column(Storage = "_RelacHermanoDescrip", DbType = "VarChar(12)")]
	public string RelacHermanoDescrip
	{
		get
		{
			return _RelacHermanoDescrip;
		}
		set
		{
			if (!string.Equals(_RelacHermanoDescrip, value))
			{
				SendPropertyChanging();
				_RelacHermanoDescrip = value;
				SendPropertyChanged("RelacHermanoDescrip");
			}
		}
	}

	[Association(Name = "RRHH_RelacHermano_RRHH_DinamicaFamiliar", Storage = "_RRHH_DinamicaFamiliar", ThisKey = "idRelacHermano", OtherKey = "idRelacHermano")]
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

	public RRHH_RelacHermano()
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
		entity.RRHH_RelacHermano = this;
	}

	private void detach_RRHH_DinamicaFamiliar(RRHH_DinamicaFamiliar entity)
	{
		SendPropertyChanging();
		entity.RRHH_RelacHermano = null;
	}
}
