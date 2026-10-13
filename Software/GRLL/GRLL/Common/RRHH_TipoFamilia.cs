using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.RRHH_TipoFamilia")]
public class RRHH_TipoFamilia : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _idTipoFam;

	private string _TipoFamDescrip;

	private EntitySet<RRHH_DinamicaFamiliar> _RRHH_DinamicaFamiliar;

	[Column(Storage = "_idTipoFam", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int idTipoFam
	{
		get
		{
			return _idTipoFam;
		}
		set
		{
			if (_idTipoFam != value)
			{
				SendPropertyChanging();
				_idTipoFam = value;
				SendPropertyChanged("idTipoFam");
			}
		}
	}

	[Column(Storage = "_TipoFamDescrip", DbType = "VarChar(10)")]
	public string TipoFamDescrip
	{
		get
		{
			return _TipoFamDescrip;
		}
		set
		{
			if (!string.Equals(_TipoFamDescrip, value))
			{
				SendPropertyChanging();
				_TipoFamDescrip = value;
				SendPropertyChanged("TipoFamDescrip");
			}
		}
	}

	[Association(Name = "RRHH_TipoFamilia_RRHH_DinamicaFamiliar", Storage = "_RRHH_DinamicaFamiliar", ThisKey = "idTipoFam", OtherKey = "idTipoFam")]
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

	public RRHH_TipoFamilia()
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
		entity.RRHH_TipoFamilia = this;
	}

	private void detach_RRHH_DinamicaFamiliar(RRHH_DinamicaFamiliar entity)
	{
		SendPropertyChanging();
		entity.RRHH_TipoFamilia = null;
	}
}
