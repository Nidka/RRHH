using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.RRHH_AcudeEnferm")]
public class RRHH_AcudeEnferm : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _idAcudeEnferm;

	private string _AcudeEnfermDescrip;

	private EntitySet<RRHH_Salud> _RRHH_Salud;

	[Column(Storage = "_idAcudeEnferm", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int idAcudeEnferm
	{
		get
		{
			return _idAcudeEnferm;
		}
		set
		{
			if (_idAcudeEnferm != value)
			{
				SendPropertyChanging();
				_idAcudeEnferm = value;
				SendPropertyChanged("idAcudeEnferm");
			}
		}
	}

	[Column(Storage = "_AcudeEnfermDescrip", DbType = "VarChar(16)")]
	public string AcudeEnfermDescrip
	{
		get
		{
			return _AcudeEnfermDescrip;
		}
		set
		{
			if (!string.Equals(_AcudeEnfermDescrip, value))
			{
				SendPropertyChanging();
				_AcudeEnfermDescrip = value;
				SendPropertyChanged("AcudeEnfermDescrip");
			}
		}
	}

	[Association(Name = "RRHH_AcudeEnferm_RRHH_Salud", Storage = "_RRHH_Salud", ThisKey = "idAcudeEnferm", OtherKey = "idAcudeEnferm")]
	public EntitySet<RRHH_Salud> RRHH_Salud
	{
		get
		{
			return _RRHH_Salud;
		}
		set
		{
			_RRHH_Salud.Assign(value);
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public RRHH_AcudeEnferm()
	{
		_RRHH_Salud = new EntitySet<RRHH_Salud>(attach_RRHH_Salud, detach_RRHH_Salud);
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

	private void attach_RRHH_Salud(RRHH_Salud entity)
	{
		SendPropertyChanging();
		entity.RRHH_AcudeEnferm = this;
	}

	private void detach_RRHH_Salud(RRHH_Salud entity)
	{
		SendPropertyChanging();
		entity.RRHH_AcudeEnferm = null;
	}
}
