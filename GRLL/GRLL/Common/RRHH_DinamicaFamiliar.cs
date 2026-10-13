using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.RRHH_DinamicaFamiliar")]
public class RRHH_DinamicaFamiliar : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _idDinamica;

	private int? _IdEmpleado;

	private int? _idTipoFam;

	private int? _idRelaPareja;

	private int? _idRelaPH;

	private int? _idRelacHermano;

	private string _Observacion;

	private EntityRef<RRHH_RelacHermano> _RRHH_RelacHermano;

	private EntityRef<RRHH_RelacPareja> _RRHH_RelacPareja;

	private EntityRef<RRHH_RelacPH> _RRHH_RelacPH;

	private EntityRef<RRHH_TipoFamilia> _RRHH_TipoFamilia;

	private EntityRef<Empleado> _Empleado;

	[Column(Storage = "_idDinamica", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int idDinamica
	{
		get
		{
			return _idDinamica;
		}
		set
		{
			if (_idDinamica != value)
			{
				SendPropertyChanging();
				_idDinamica = value;
				SendPropertyChanged("idDinamica");
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
				if (_Empleado.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdEmpleado = value;
				SendPropertyChanged("IdEmpleado");
			}
		}
	}

	[Column(Storage = "_idTipoFam", DbType = "Int")]
	public int? idTipoFam
	{
		get
		{
			return _idTipoFam;
		}
		set
		{
			if (!_idTipoFam.Equals(value))
			{
				if (_RRHH_TipoFamilia.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_idTipoFam = value;
				SendPropertyChanged("idTipoFam");
			}
		}
	}

	[Column(Storage = "_idRelaPareja", DbType = "Int")]
	public int? idRelaPareja
	{
		get
		{
			return _idRelaPareja;
		}
		set
		{
			if (!_idRelaPareja.Equals(value))
			{
				if (_RRHH_RelacPareja.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_idRelaPareja = value;
				SendPropertyChanged("idRelaPareja");
			}
		}
	}

	[Column(Storage = "_idRelaPH", DbType = "Int")]
	public int? idRelaPH
	{
		get
		{
			return _idRelaPH;
		}
		set
		{
			if (!_idRelaPH.Equals(value))
			{
				if (_RRHH_RelacPH.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_idRelaPH = value;
				SendPropertyChanged("idRelaPH");
			}
		}
	}

	[Column(Storage = "_idRelacHermano", DbType = "Int")]
	public int? idRelacHermano
	{
		get
		{
			return _idRelacHermano;
		}
		set
		{
			if (!_idRelacHermano.Equals(value))
			{
				if (_RRHH_RelacHermano.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_idRelacHermano = value;
				SendPropertyChanged("idRelacHermano");
			}
		}
	}

	[Column(Storage = "_Observacion", DbType = "VarChar(200)")]
	public string Observacion
	{
		get
		{
			return _Observacion;
		}
		set
		{
			if (!string.Equals(_Observacion, value))
			{
				SendPropertyChanging();
				_Observacion = value;
				SendPropertyChanged("Observacion");
			}
		}
	}

	[Association(Name = "RRHH_RelacHermano_RRHH_DinamicaFamiliar", Storage = "_RRHH_RelacHermano", ThisKey = "idRelacHermano", OtherKey = "idRelacHermano", IsForeignKey = true)]
	public RRHH_RelacHermano RRHH_RelacHermano
	{
		get
		{
			return _RRHH_RelacHermano.Entity;
		}
		set
		{
			RRHH_RelacHermano previousValue = _RRHH_RelacHermano.Entity;
			if (!object.Equals(previousValue, value) || !_RRHH_RelacHermano.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_RRHH_RelacHermano.Entity = null;
					previousValue.RRHH_DinamicaFamiliar.Remove(this);
				}
				_RRHH_RelacHermano.Entity = value;
				if (value != null)
				{
					value.RRHH_DinamicaFamiliar.Add(this);
					_idRelacHermano = value.idRelacHermano;
				}
				else
				{
					_idRelacHermano = null;
				}
				SendPropertyChanged("RRHH_RelacHermano");
			}
		}
	}

	[Association(Name = "RRHH_RelacPareja_RRHH_DinamicaFamiliar", Storage = "_RRHH_RelacPareja", ThisKey = "idRelaPareja", OtherKey = "idRelacPareja", IsForeignKey = true)]
	public RRHH_RelacPareja RRHH_RelacPareja
	{
		get
		{
			return _RRHH_RelacPareja.Entity;
		}
		set
		{
			RRHH_RelacPareja previousValue = _RRHH_RelacPareja.Entity;
			if (!object.Equals(previousValue, value) || !_RRHH_RelacPareja.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_RRHH_RelacPareja.Entity = null;
					previousValue.RRHH_DinamicaFamiliar.Remove(this);
				}
				_RRHH_RelacPareja.Entity = value;
				if (value != null)
				{
					value.RRHH_DinamicaFamiliar.Add(this);
					_idRelaPareja = value.idRelacPareja;
				}
				else
				{
					_idRelaPareja = null;
				}
				SendPropertyChanged("RRHH_RelacPareja");
			}
		}
	}

	[Association(Name = "RRHH_RelacPH_RRHH_DinamicaFamiliar", Storage = "_RRHH_RelacPH", ThisKey = "idRelaPH", OtherKey = "idRelacPH", IsForeignKey = true)]
	public RRHH_RelacPH RRHH_RelacPH
	{
		get
		{
			return _RRHH_RelacPH.Entity;
		}
		set
		{
			RRHH_RelacPH previousValue = _RRHH_RelacPH.Entity;
			if (!object.Equals(previousValue, value) || !_RRHH_RelacPH.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_RRHH_RelacPH.Entity = null;
					previousValue.RRHH_DinamicaFamiliar.Remove(this);
				}
				_RRHH_RelacPH.Entity = value;
				if (value != null)
				{
					value.RRHH_DinamicaFamiliar.Add(this);
					_idRelaPH = value.idRelacPH;
				}
				else
				{
					_idRelaPH = null;
				}
				SendPropertyChanged("RRHH_RelacPH");
			}
		}
	}

	[Association(Name = "RRHH_TipoFamilia_RRHH_DinamicaFamiliar", Storage = "_RRHH_TipoFamilia", ThisKey = "idTipoFam", OtherKey = "idTipoFam", IsForeignKey = true)]
	public RRHH_TipoFamilia RRHH_TipoFamilia
	{
		get
		{
			return _RRHH_TipoFamilia.Entity;
		}
		set
		{
			RRHH_TipoFamilia previousValue = _RRHH_TipoFamilia.Entity;
			if (!object.Equals(previousValue, value) || !_RRHH_TipoFamilia.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_RRHH_TipoFamilia.Entity = null;
					previousValue.RRHH_DinamicaFamiliar.Remove(this);
				}
				_RRHH_TipoFamilia.Entity = value;
				if (value != null)
				{
					value.RRHH_DinamicaFamiliar.Add(this);
					_idTipoFam = value.idTipoFam;
				}
				else
				{
					_idTipoFam = null;
				}
				SendPropertyChanged("RRHH_TipoFamilia");
			}
		}
	}

	[Association(Name = "Empleado_RRHH_DinamicaFamiliar", Storage = "_Empleado", ThisKey = "IdEmpleado", OtherKey = "IdEmpleado", IsForeignKey = true)]
	public Empleado Empleado
	{
		get
		{
			return _Empleado.Entity;
		}
		set
		{
			Empleado previousValue = _Empleado.Entity;
			if (!object.Equals(previousValue, value) || !_Empleado.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_Empleado.Entity = null;
					previousValue.RRHH_DinamicaFamiliars.Remove(this);
				}
				_Empleado.Entity = value;
				if (value != null)
				{
					value.RRHH_DinamicaFamiliars.Add(this);
					_IdEmpleado = value.IdEmpleado;
				}
				else
				{
					_IdEmpleado = null;
				}
				SendPropertyChanged("Empleado");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public RRHH_DinamicaFamiliar()
	{
		_RRHH_RelacHermano = default(EntityRef<RRHH_RelacHermano>);
		_RRHH_RelacPareja = default(EntityRef<RRHH_RelacPareja>);
		_RRHH_RelacPH = default(EntityRef<RRHH_RelacPH>);
		_RRHH_TipoFamilia = default(EntityRef<RRHH_TipoFamilia>);
		_Empleado = default(EntityRef<Empleado>);
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
