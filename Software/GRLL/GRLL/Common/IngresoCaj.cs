using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.IngresoCaj")]
public class IngresoCaj : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdPersona;

	private int _NroIngreso;

	private string _Detalle;

	private decimal? _Importe;

	private int? _IdTipoMoneda;

	private DateTime? _FechaIng;

	private char? _Estado;

	private decimal? _Efectivo;

	private string _Observacion;

	private int? _IdBanco;

	private string _NroPapeleta;

	private int? _Debe;

	private int _Years;

	private int? _Codigo;

	private int? _Haber;

	private decimal? _TotalDebe;

	private decimal? _TotalHaber;

	private int? _IdTransferencia;

	private int? _IdReferencia;

	private int? _IdCheque;

	private EntitySet<FacturaCaj> _FacturaCaj;

	private EntityRef<ChequeCaj> _ChequeCaj;

	private EntityRef<ClasificadorIngreso> _ClasificadorIngreso;

	private EntityRef<PapeletDepositCaj> _PapeletDepositCaj;

	private EntityRef<Persona> _Persona;

	private EntityRef<PlanMayor> _PlanMayor;

	private EntityRef<PlanMayor> _PlanMayor1;

	private EntityRef<RefSIAF> _RefSIAF;

	private EntityRef<TransferenciaBco> _TransferenciaBco;

	[Column(Storage = "_IdPersona", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdPersona
	{
		get
		{
			return _IdPersona;
		}
		set
		{
			if (_IdPersona != value)
			{
				if (_Persona.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdPersona = value;
				SendPropertyChanged("IdPersona");
			}
		}
	}

	[Column(Storage = "_NroIngreso", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int NroIngreso
	{
		get
		{
			return _NroIngreso;
		}
		set
		{
			if (_NroIngreso != value)
			{
				SendPropertyChanging();
				_NroIngreso = value;
				SendPropertyChanged("NroIngreso");
			}
		}
	}

	[Column(Storage = "_Detalle", DbType = "VarChar(500)")]
	public string Detalle
	{
		get
		{
			return _Detalle;
		}
		set
		{
			if (!string.Equals(_Detalle, value))
			{
				SendPropertyChanging();
				_Detalle = value;
				SendPropertyChanged("Detalle");
			}
		}
	}

	[Column(Storage = "_Importe", DbType = "Decimal(11,2)")]
	public decimal? Importe
	{
		get
		{
			return _Importe;
		}
		set
		{
			if (!_Importe.Equals(value))
			{
				SendPropertyChanging();
				_Importe = value;
				SendPropertyChanged("Importe");
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

	[Column(Storage = "_FechaIng", DbType = "SmallDateTime")]
	public DateTime? FechaIng
	{
		get
		{
			return _FechaIng;
		}
		set
		{
			if (!_FechaIng.Equals(value))
			{
				SendPropertyChanging();
				_FechaIng = value;
				SendPropertyChanged("FechaIng");
			}
		}
	}

	[Column(Storage = "_Estado", DbType = "VarChar(1)")]
	public char? Estado
	{
		get
		{
			return _Estado;
		}
		set
		{
			if (!_Estado.Equals(value))
			{
				SendPropertyChanging();
				_Estado = value;
				SendPropertyChanged("Estado");
			}
		}
	}

	[Column(Storage = "_Efectivo", DbType = "Decimal(11,2)")]
	public decimal? Efectivo
	{
		get
		{
			return _Efectivo;
		}
		set
		{
			if (!_Efectivo.Equals(value))
			{
				SendPropertyChanging();
				_Efectivo = value;
				SendPropertyChanged("Efectivo");
			}
		}
	}

	[Column(Storage = "_Observacion", DbType = "VarChar(500)")]
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

	[Column(Storage = "_IdBanco", DbType = "Int")]
	public int? IdBanco
	{
		get
		{
			return _IdBanco;
		}
		set
		{
			if (!_IdBanco.Equals(value))
			{
				if (_PapeletDepositCaj.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdBanco = value;
				SendPropertyChanged("IdBanco");
			}
		}
	}

	[Column(Storage = "_NroPapeleta", DbType = "VarChar(10)")]
	public string NroPapeleta
	{
		get
		{
			return _NroPapeleta;
		}
		set
		{
			if (!string.Equals(_NroPapeleta, value))
			{
				if (_PapeletDepositCaj.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_NroPapeleta = value;
				SendPropertyChanged("NroPapeleta");
			}
		}
	}

	[Column(Storage = "_Debe", DbType = "Int")]
	public int? Debe
	{
		get
		{
			return _Debe;
		}
		set
		{
			if (!_Debe.Equals(value))
			{
				if (_PlanMayor.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_Debe = value;
				SendPropertyChanged("Debe");
			}
		}
	}

	[Column(Storage = "_Years", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int Years
	{
		get
		{
			return _Years;
		}
		set
		{
			if (_Years != value)
			{
				if (_ClasificadorIngreso.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_Years = value;
				SendPropertyChanged("Years");
			}
		}
	}

	[Column(Storage = "_Codigo", DbType = "Int")]
	public int? Codigo
	{
		get
		{
			return _Codigo;
		}
		set
		{
			if (!_Codigo.Equals(value))
			{
				if (_ClasificadorIngreso.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_Codigo = value;
				SendPropertyChanged("Codigo");
			}
		}
	}

	[Column(Storage = "_Haber", DbType = "Int")]
	public int? Haber
	{
		get
		{
			return _Haber;
		}
		set
		{
			if (!_Haber.Equals(value))
			{
				if (_PlanMayor1.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_Haber = value;
				SendPropertyChanged("Haber");
			}
		}
	}

	[Column(Storage = "_TotalDebe", DbType = "Decimal(11,2)")]
	public decimal? TotalDebe
	{
		get
		{
			return _TotalDebe;
		}
		set
		{
			if (!_TotalDebe.Equals(value))
			{
				SendPropertyChanging();
				_TotalDebe = value;
				SendPropertyChanged("TotalDebe");
			}
		}
	}

	[Column(Storage = "_TotalHaber", DbType = "Decimal(11,2)")]
	public decimal? TotalHaber
	{
		get
		{
			return _TotalHaber;
		}
		set
		{
			if (!_TotalHaber.Equals(value))
			{
				SendPropertyChanging();
				_TotalHaber = value;
				SendPropertyChanged("TotalHaber");
			}
		}
	}

	[Column(Storage = "_IdTransferencia", DbType = "Int")]
	public int? IdTransferencia
	{
		get
		{
			return _IdTransferencia;
		}
		set
		{
			if (!_IdTransferencia.Equals(value))
			{
				if (_TransferenciaBco.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdTransferencia = value;
				SendPropertyChanged("IdTransferencia");
			}
		}
	}

	[Column(Storage = "_IdReferencia", DbType = "Int")]
	public int? IdReferencia
	{
		get
		{
			return _IdReferencia;
		}
		set
		{
			if (!_IdReferencia.Equals(value))
			{
				if (_RefSIAF.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdReferencia = value;
				SendPropertyChanged("IdReferencia");
			}
		}
	}

	[Column(Storage = "_IdCheque", DbType = "Int")]
	public int? IdCheque
	{
		get
		{
			return _IdCheque;
		}
		set
		{
			if (!_IdCheque.Equals(value))
			{
				if (_ChequeCaj.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdCheque = value;
				SendPropertyChanged("IdCheque");
			}
		}
	}

	[Association(Name = "IngresoCaj_FacturaCaj", Storage = "_FacturaCaj", ThisKey = "IdPersona,NroIngreso,Years", OtherKey = "IdPersona,Years,NroIngreso")]
	public EntitySet<FacturaCaj> FacturaCaj
	{
		get
		{
			return _FacturaCaj;
		}
		set
		{
			_FacturaCaj.Assign(value);
		}
	}

	[Association(Name = "ChequeCaj_IngresoCaj", Storage = "_ChequeCaj", ThisKey = "IdCheque", OtherKey = "IdCheque", IsForeignKey = true)]
	public ChequeCaj ChequeCaj
	{
		get
		{
			return _ChequeCaj.Entity;
		}
		set
		{
			ChequeCaj previousValue = _ChequeCaj.Entity;
			if (!object.Equals(previousValue, value) || !_ChequeCaj.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_ChequeCaj.Entity = null;
					previousValue.IngresoCaj.Remove(this);
				}
				_ChequeCaj.Entity = value;
				if (value != null)
				{
					value.IngresoCaj.Add(this);
					_IdCheque = value.IdCheque;
				}
				else
				{
					_IdCheque = null;
				}
				SendPropertyChanged("ChequeCaj");
			}
		}
	}

	[Association(Name = "ClasificadorIngreso_IngresoCaj", Storage = "_ClasificadorIngreso", ThisKey = "Years,Codigo", OtherKey = "Years,Codigo", IsForeignKey = true)]
	public ClasificadorIngreso ClasificadorIngreso
	{
		get
		{
			return _ClasificadorIngreso.Entity;
		}
		set
		{
			ClasificadorIngreso previousValue = _ClasificadorIngreso.Entity;
			if (!object.Equals(previousValue, value) || !_ClasificadorIngreso.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_ClasificadorIngreso.Entity = null;
					previousValue.IngresoCaj.Remove(this);
				}
				_ClasificadorIngreso.Entity = value;
				if (value != null)
				{
					value.IngresoCaj.Add(this);
					_Years = value.Years;
					_Codigo = value.Codigo;
				}
				else
				{
					_Years = 0;
					_Codigo = null;
				}
				SendPropertyChanged("ClasificadorIngreso");
			}
		}
	}

	[Association(Name = "PapeletDepositCaj_IngresoCaj", Storage = "_PapeletDepositCaj", ThisKey = "IdBanco,NroPapeleta", OtherKey = "IdBanco,NroPapeleta", IsForeignKey = true)]
	public PapeletDepositCaj PapeletDepositCaj
	{
		get
		{
			return _PapeletDepositCaj.Entity;
		}
		set
		{
			PapeletDepositCaj previousValue = _PapeletDepositCaj.Entity;
			if (!object.Equals(previousValue, value) || !_PapeletDepositCaj.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_PapeletDepositCaj.Entity = null;
					previousValue.IngresoCaj.Remove(this);
				}
				_PapeletDepositCaj.Entity = value;
				if (value != null)
				{
					value.IngresoCaj.Add(this);
					_IdBanco = value.IdBanco;
					_NroPapeleta = value.NroPapeleta;
				}
				else
				{
					_IdBanco = null;
					_NroPapeleta = null;
				}
				SendPropertyChanged("PapeletDepositCaj");
			}
		}
	}

	[Association(Name = "Persona_IngresoCaj", Storage = "_Persona", ThisKey = "IdPersona", OtherKey = "IdPersona", IsForeignKey = true)]
	public Persona Persona
	{
		get
		{
			return _Persona.Entity;
		}
		set
		{
			Persona previousValue = _Persona.Entity;
			if (!object.Equals(previousValue, value) || !_Persona.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_Persona.Entity = null;
					previousValue.IngresoCaj.Remove(this);
				}
				_Persona.Entity = value;
				if (value != null)
				{
					value.IngresoCaj.Add(this);
					_IdPersona = value.IdPersona;
				}
				else
				{
					_IdPersona = 0;
				}
				SendPropertyChanged("Persona");
			}
		}
	}

	[Association(Name = "PlanMayor_IngresoCaj", Storage = "_PlanMayor", ThisKey = "Years,Debe", OtherKey = "Years,Codigo", IsForeignKey = true)]
	public PlanMayor PlanMayor
	{
		get
		{
			return _PlanMayor.Entity;
		}
		set
		{
			PlanMayor previousValue = _PlanMayor.Entity;
			if (!object.Equals(previousValue, value) || !_PlanMayor.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_PlanMayor.Entity = null;
					previousValue.IngresoCaj.Remove(this);
				}
				_PlanMayor.Entity = value;
				if (value != null)
				{
					value.IngresoCaj.Add(this);
					_Years = value.Years;
					_Debe = value.Codigo;
				}
				else
				{
					_Years = 0;
					_Debe = null;
				}
				SendPropertyChanged("PlanMayor");
			}
		}
	}

	[Association(Name = "PlanMayor_IngresoCaj1", Storage = "_PlanMayor1", ThisKey = "Years,Haber", OtherKey = "Years,Codigo", IsForeignKey = true)]
	public PlanMayor PlanMayor1
	{
		get
		{
			return _PlanMayor1.Entity;
		}
		set
		{
			PlanMayor previousValue = _PlanMayor1.Entity;
			if (!object.Equals(previousValue, value) || !_PlanMayor1.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_PlanMayor1.Entity = null;
					previousValue.IngresoCaj1.Remove(this);
				}
				_PlanMayor1.Entity = value;
				if (value != null)
				{
					value.IngresoCaj1.Add(this);
					_Years = value.Years;
					_Haber = value.Codigo;
				}
				else
				{
					_Years = 0;
					_Haber = null;
				}
				SendPropertyChanged("PlanMayor1");
			}
		}
	}

	[Association(Name = "RefSIAF_IngresoCaj", Storage = "_RefSIAF", ThisKey = "IdReferencia", OtherKey = "IdReferencia", IsForeignKey = true)]
	public RefSIAF RefSIAF
	{
		get
		{
			return _RefSIAF.Entity;
		}
		set
		{
			RefSIAF previousValue = _RefSIAF.Entity;
			if (!object.Equals(previousValue, value) || !_RefSIAF.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_RefSIAF.Entity = null;
					previousValue.IngresoCaj.Remove(this);
				}
				_RefSIAF.Entity = value;
				if (value != null)
				{
					value.IngresoCaj.Add(this);
					_IdReferencia = value.IdReferencia;
				}
				else
				{
					_IdReferencia = null;
				}
				SendPropertyChanged("RefSIAF");
			}
		}
	}

	[Association(Name = "TransferenciaBco_IngresoCaj", Storage = "_TransferenciaBco", ThisKey = "IdTransferencia", OtherKey = "IdTransferencia", IsForeignKey = true)]
	public TransferenciaBco TransferenciaBco
	{
		get
		{
			return _TransferenciaBco.Entity;
		}
		set
		{
			TransferenciaBco previousValue = _TransferenciaBco.Entity;
			if (!object.Equals(previousValue, value) || !_TransferenciaBco.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_TransferenciaBco.Entity = null;
					previousValue.IngresoCaj.Remove(this);
				}
				_TransferenciaBco.Entity = value;
				if (value != null)
				{
					value.IngresoCaj.Add(this);
					_IdTransferencia = value.IdTransferencia;
				}
				else
				{
					_IdTransferencia = null;
				}
				SendPropertyChanged("TransferenciaBco");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public IngresoCaj()
	{
		_FacturaCaj = new EntitySet<FacturaCaj>(attach_FacturaCaj, detach_FacturaCaj);
		_ChequeCaj = default(EntityRef<ChequeCaj>);
		_ClasificadorIngreso = default(EntityRef<ClasificadorIngreso>);
		_PapeletDepositCaj = default(EntityRef<PapeletDepositCaj>);
		_Persona = default(EntityRef<Persona>);
		_PlanMayor = default(EntityRef<PlanMayor>);
		_PlanMayor1 = default(EntityRef<PlanMayor>);
		_RefSIAF = default(EntityRef<RefSIAF>);
		_TransferenciaBco = default(EntityRef<TransferenciaBco>);
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

	private void attach_FacturaCaj(FacturaCaj entity)
	{
		SendPropertyChanging();
		entity.IngresoCaj = this;
	}

	private void detach_FacturaCaj(FacturaCaj entity)
	{
		SendPropertyChanging();
		entity.IngresoCaj = null;
	}
}
