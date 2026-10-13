using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.vs_tra_listar_movimiento_tramite_G")]
public class vs_tra_listar_movimiento_tramite_G
{
	private string _IdMovimiento;

	private string _nummovimiento;

	private string _IdTramite;

	private string _numtramite;

	private int? _idempleado_emisor;

	private string _desempleado_emisor;

	private int? _idcargo_emisor;

	private string _descargo_emisor;

	private int _idarea_emisor;

	private string _desarea_emisor;

	private DateTime? _f_emision_tramite;

	private string _estado_tramite;

	private string _Asunto;

	private decimal? _NumRecepcion;

	private int? _IdAreaProc;

	private string _DesAreaProc;

	private string _IdProcedimiento;

	private string _Descripcion;

	private char? _Ambito;

	private DateTime? _f_ingreso_etapa;

	private int? _AreaIngreso;

	private string _desareaingreso;

	private DateTime? _f_salida_etapa;

	private int? _AreaDestino;

	private string _desareadestino;

	private string _IdEtapaProc;

	private string _desetapa;

	private int _idcargo_responsable;

	private string _cargo_responsable;

	private int? _tiempodias_etapa;

	private int? _tiempohrs_etapa;

	private int _TiempoMin_etapa;

	private string _estado_etapa;

	private byte? _IdTipoSilencio;

	private string _destiposilencio;

	private DateTime? _FechaAprobacion;

	private int? _PersonaRechazo;

	private int? _cargorechazo;

	private DateTime? _FechaRechazo;

	private int? _AreaRechazo;

	private string _MotivoRechazo;

	private string _MovimientoDestino;

	private DateTime? _T_Salida_O_Etapa;

	private string _Puntualidad_Etapa;

	private string _T_Excedido_Restante_Etapa;

	private int _T_Dias_Tramite;

	private int _T_Hrs_Tramite;

	private int _T_Min_Tramite;

	private DateTime? _T_Salida_O_Tramite;

	private string _Puntualidad_Tramite;

	private string _T_Excedido_Restante_Tramite;

	private string _IdDocumento;

	private string _Referencia;

	private string _suscritopor;

	private string _Doc_Codigo;

	[Column(Storage = "_IdMovimiento", DbType = "Char(10) NOT NULL", CanBeNull = false)]
	public string IdMovimiento
	{
		get
		{
			return _IdMovimiento;
		}
		set
		{
			if (!string.Equals(_IdMovimiento, value))
			{
				_IdMovimiento = value;
			}
		}
	}

	[Column(Storage = "_nummovimiento", DbType = "VarChar(6)")]
	public string nummovimiento
	{
		get
		{
			return _nummovimiento;
		}
		set
		{
			if (!string.Equals(_nummovimiento, value))
			{
				_nummovimiento = value;
			}
		}
	}

	[Column(Storage = "_IdTramite", DbType = "Char(10)")]
	public string IdTramite
	{
		get
		{
			return _IdTramite;
		}
		set
		{
			if (!string.Equals(_IdTramite, value))
			{
				_IdTramite = value;
			}
		}
	}

	[Column(Storage = "_numtramite", DbType = "Char(10)")]
	public string numtramite
	{
		get
		{
			return _numtramite;
		}
		set
		{
			if (!string.Equals(_numtramite, value))
			{
				_numtramite = value;
			}
		}
	}

	[Column(Storage = "_idempleado_emisor", DbType = "Int")]
	public int? idempleado_emisor
	{
		get
		{
			return _idempleado_emisor;
		}
		set
		{
			if (!_idempleado_emisor.Equals(value))
			{
				_idempleado_emisor = value;
			}
		}
	}

	[Column(Storage = "_desempleado_emisor", DbType = "VarChar(162)")]
	public string desempleado_emisor
	{
		get
		{
			return _desempleado_emisor;
		}
		set
		{
			if (!string.Equals(_desempleado_emisor, value))
			{
				_desempleado_emisor = value;
			}
		}
	}

	[Column(Storage = "_idcargo_emisor", DbType = "Int")]
	public int? idcargo_emisor
	{
		get
		{
			return _idcargo_emisor;
		}
		set
		{
			if (!_idcargo_emisor.Equals(value))
			{
				_idcargo_emisor = value;
			}
		}
	}

	[Column(Storage = "_descargo_emisor", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
	public string descargo_emisor
	{
		get
		{
			return _descargo_emisor;
		}
		set
		{
			if (!string.Equals(_descargo_emisor, value))
			{
				_descargo_emisor = value;
			}
		}
	}

	[Column(Storage = "_idarea_emisor", DbType = "Int NOT NULL")]
	public int idarea_emisor
	{
		get
		{
			return _idarea_emisor;
		}
		set
		{
			if (_idarea_emisor != value)
			{
				_idarea_emisor = value;
			}
		}
	}

	[Column(Storage = "_desarea_emisor", DbType = "VarChar(200) NOT NULL", CanBeNull = false)]
	public string desarea_emisor
	{
		get
		{
			return _desarea_emisor;
		}
		set
		{
			if (!string.Equals(_desarea_emisor, value))
			{
				_desarea_emisor = value;
			}
		}
	}

	[Column(Storage = "_f_emision_tramite", DbType = "DateTime")]
	public DateTime? f_emision_tramite
	{
		get
		{
			return _f_emision_tramite;
		}
		set
		{
			if (!_f_emision_tramite.Equals(value))
			{
				_f_emision_tramite = value;
			}
		}
	}

	[Column(Storage = "_estado_tramite", DbType = "VarChar(15)")]
	public string estado_tramite
	{
		get
		{
			return _estado_tramite;
		}
		set
		{
			if (!string.Equals(_estado_tramite, value))
			{
				_estado_tramite = value;
			}
		}
	}

	[Column(Storage = "_Asunto", DbType = "VarChar(250)")]
	public string Asunto
	{
		get
		{
			return _Asunto;
		}
		set
		{
			if (!string.Equals(_Asunto, value))
			{
				_Asunto = value;
			}
		}
	}

	[Column(Storage = "_NumRecepcion", DbType = "Decimal(18,0)")]
	public decimal? NumRecepcion
	{
		get
		{
			return _NumRecepcion;
		}
		set
		{
			if (!_NumRecepcion.Equals(value))
			{
				_NumRecepcion = value;
			}
		}
	}

	[Column(Storage = "_IdAreaProc", DbType = "Int")]
	public int? IdAreaProc
	{
		get
		{
			return _IdAreaProc;
		}
		set
		{
			if (!_IdAreaProc.Equals(value))
			{
				_IdAreaProc = value;
			}
		}
	}

	[Column(Storage = "_DesAreaProc", DbType = "VarChar(200) NOT NULL", CanBeNull = false)]
	public string DesAreaProc
	{
		get
		{
			return _DesAreaProc;
		}
		set
		{
			if (!string.Equals(_DesAreaProc, value))
			{
				_DesAreaProc = value;
			}
		}
	}

	[Column(Storage = "_IdProcedimiento", DbType = "Char(6)")]
	public string IdProcedimiento
	{
		get
		{
			return _IdProcedimiento;
		}
		set
		{
			if (!string.Equals(_IdProcedimiento, value))
			{
				_IdProcedimiento = value;
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(300)")]
	public string Descripcion
	{
		get
		{
			return _Descripcion;
		}
		set
		{
			if (!string.Equals(_Descripcion, value))
			{
				_Descripcion = value;
			}
		}
	}

	[Column(Storage = "_Ambito", DbType = "Char(1)")]
	public char? Ambito
	{
		get
		{
			return _Ambito;
		}
		set
		{
			if (!_Ambito.Equals(value))
			{
				_Ambito = value;
			}
		}
	}

	[Column(Storage = "_f_ingreso_etapa", DbType = "DateTime")]
	public DateTime? f_ingreso_etapa
	{
		get
		{
			return _f_ingreso_etapa;
		}
		set
		{
			if (!_f_ingreso_etapa.Equals(value))
			{
				_f_ingreso_etapa = value;
			}
		}
	}

	[Column(Storage = "_AreaIngreso", DbType = "Int")]
	public int? AreaIngreso
	{
		get
		{
			return _AreaIngreso;
		}
		set
		{
			if (!_AreaIngreso.Equals(value))
			{
				_AreaIngreso = value;
			}
		}
	}

	[Column(Storage = "_desareaingreso", DbType = "VarChar(200) NOT NULL", CanBeNull = false)]
	public string desareaingreso
	{
		get
		{
			return _desareaingreso;
		}
		set
		{
			if (!string.Equals(_desareaingreso, value))
			{
				_desareaingreso = value;
			}
		}
	}

	[Column(Storage = "_f_salida_etapa", DbType = "DateTime")]
	public DateTime? f_salida_etapa
	{
		get
		{
			return _f_salida_etapa;
		}
		set
		{
			if (!_f_salida_etapa.Equals(value))
			{
				_f_salida_etapa = value;
			}
		}
	}

	[Column(Storage = "_AreaDestino", DbType = "Int")]
	public int? AreaDestino
	{
		get
		{
			return _AreaDestino;
		}
		set
		{
			if (!_AreaDestino.Equals(value))
			{
				_AreaDestino = value;
			}
		}
	}

	[Column(Storage = "_desareadestino", DbType = "VarChar(200)")]
	public string desareadestino
	{
		get
		{
			return _desareadestino;
		}
		set
		{
			if (!string.Equals(_desareadestino, value))
			{
				_desareadestino = value;
			}
		}
	}

	[Column(Storage = "_IdEtapaProc", DbType = "Char(8)")]
	public string IdEtapaProc
	{
		get
		{
			return _IdEtapaProc;
		}
		set
		{
			if (!string.Equals(_IdEtapaProc, value))
			{
				_IdEtapaProc = value;
			}
		}
	}

	[Column(Storage = "_desetapa", DbType = "VarChar(400)")]
	public string desetapa
	{
		get
		{
			return _desetapa;
		}
		set
		{
			if (!string.Equals(_desetapa, value))
			{
				_desetapa = value;
			}
		}
	}

	[Column(Storage = "_idcargo_responsable", DbType = "Int NOT NULL")]
	public int idcargo_responsable
	{
		get
		{
			return _idcargo_responsable;
		}
		set
		{
			if (_idcargo_responsable != value)
			{
				_idcargo_responsable = value;
			}
		}
	}

	[Column(Storage = "_cargo_responsable", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
	public string cargo_responsable
	{
		get
		{
			return _cargo_responsable;
		}
		set
		{
			if (!string.Equals(_cargo_responsable, value))
			{
				_cargo_responsable = value;
			}
		}
	}

	[Column(Storage = "_tiempodias_etapa", DbType = "Int")]
	public int? tiempodias_etapa
	{
		get
		{
			return _tiempodias_etapa;
		}
		set
		{
			if (!_tiempodias_etapa.Equals(value))
			{
				_tiempodias_etapa = value;
			}
		}
	}

	[Column(Storage = "_tiempohrs_etapa", DbType = "Int")]
	public int? tiempohrs_etapa
	{
		get
		{
			return _tiempohrs_etapa;
		}
		set
		{
			if (!_tiempohrs_etapa.Equals(value))
			{
				_tiempohrs_etapa = value;
			}
		}
	}

	[Column(Storage = "_TiempoMin_etapa", DbType = "Int NOT NULL")]
	public int TiempoMin_etapa
	{
		get
		{
			return _TiempoMin_etapa;
		}
		set
		{
			if (_TiempoMin_etapa != value)
			{
				_TiempoMin_etapa = value;
			}
		}
	}

	[Column(Storage = "_estado_etapa", DbType = "Char(2)")]
	public string estado_etapa
	{
		get
		{
			return _estado_etapa;
		}
		set
		{
			if (!string.Equals(_estado_etapa, value))
			{
				_estado_etapa = value;
			}
		}
	}

	[Column(Storage = "_IdTipoSilencio", DbType = "TinyInt")]
	public byte? IdTipoSilencio
	{
		get
		{
			return _IdTipoSilencio;
		}
		set
		{
			if (!_IdTipoSilencio.Equals(value))
			{
				_IdTipoSilencio = value;
			}
		}
	}

	[Column(Storage = "_destiposilencio", DbType = "VarChar(200)")]
	public string destiposilencio
	{
		get
		{
			return _destiposilencio;
		}
		set
		{
			if (!string.Equals(_destiposilencio, value))
			{
				_destiposilencio = value;
			}
		}
	}

	[Column(Storage = "_FechaAprobacion", DbType = "DateTime")]
	public DateTime? FechaAprobacion
	{
		get
		{
			return _FechaAprobacion;
		}
		set
		{
			if (!_FechaAprobacion.Equals(value))
			{
				_FechaAprobacion = value;
			}
		}
	}

	[Column(Storage = "_PersonaRechazo", DbType = "Int")]
	public int? PersonaRechazo
	{
		get
		{
			return _PersonaRechazo;
		}
		set
		{
			if (!_PersonaRechazo.Equals(value))
			{
				_PersonaRechazo = value;
			}
		}
	}

	[Column(Storage = "_cargorechazo", DbType = "Int")]
	public int? cargorechazo
	{
		get
		{
			return _cargorechazo;
		}
		set
		{
			if (!_cargorechazo.Equals(value))
			{
				_cargorechazo = value;
			}
		}
	}

	[Column(Storage = "_FechaRechazo", DbType = "DateTime")]
	public DateTime? FechaRechazo
	{
		get
		{
			return _FechaRechazo;
		}
		set
		{
			if (!_FechaRechazo.Equals(value))
			{
				_FechaRechazo = value;
			}
		}
	}

	[Column(Storage = "_AreaRechazo", DbType = "Int")]
	public int? AreaRechazo
	{
		get
		{
			return _AreaRechazo;
		}
		set
		{
			if (!_AreaRechazo.Equals(value))
			{
				_AreaRechazo = value;
			}
		}
	}

	[Column(Storage = "_MotivoRechazo", DbType = "VarChar(200)")]
	public string MotivoRechazo
	{
		get
		{
			return _MotivoRechazo;
		}
		set
		{
			if (!string.Equals(_MotivoRechazo, value))
			{
				_MotivoRechazo = value;
			}
		}
	}

	[Column(Storage = "_MovimientoDestino", DbType = "Char(10)")]
	public string MovimientoDestino
	{
		get
		{
			return _MovimientoDestino;
		}
		set
		{
			if (!string.Equals(_MovimientoDestino, value))
			{
				_MovimientoDestino = value;
			}
		}
	}

	[Column(Storage = "_T_Salida_O_Etapa", DbType = "DateTime")]
	public DateTime? T_Salida_O_Etapa
	{
		get
		{
			return _T_Salida_O_Etapa;
		}
		set
		{
			if (!_T_Salida_O_Etapa.Equals(value))
			{
				_T_Salida_O_Etapa = value;
			}
		}
	}

	[Column(Storage = "_Puntualidad_Etapa", DbType = "VarChar(8)")]
	public string Puntualidad_Etapa
	{
		get
		{
			return _Puntualidad_Etapa;
		}
		set
		{
			if (!string.Equals(_Puntualidad_Etapa, value))
			{
				_Puntualidad_Etapa = value;
			}
		}
	}

	[Column(Storage = "_T_Excedido_Restante_Etapa", DbType = "NVarChar(50)")]
	public string T_Excedido_Restante_Etapa
	{
		get
		{
			return _T_Excedido_Restante_Etapa;
		}
		set
		{
			if (!string.Equals(_T_Excedido_Restante_Etapa, value))
			{
				_T_Excedido_Restante_Etapa = value;
			}
		}
	}

	[Column(Storage = "_T_Dias_Tramite", DbType = "Int NOT NULL")]
	public int T_Dias_Tramite
	{
		get
		{
			return _T_Dias_Tramite;
		}
		set
		{
			if (_T_Dias_Tramite != value)
			{
				_T_Dias_Tramite = value;
			}
		}
	}

	[Column(Storage = "_T_Hrs_Tramite", DbType = "Int NOT NULL")]
	public int T_Hrs_Tramite
	{
		get
		{
			return _T_Hrs_Tramite;
		}
		set
		{
			if (_T_Hrs_Tramite != value)
			{
				_T_Hrs_Tramite = value;
			}
		}
	}

	[Column(Storage = "_T_Min_Tramite", DbType = "Int NOT NULL")]
	public int T_Min_Tramite
	{
		get
		{
			return _T_Min_Tramite;
		}
		set
		{
			if (_T_Min_Tramite != value)
			{
				_T_Min_Tramite = value;
			}
		}
	}

	[Column(Storage = "_T_Salida_O_Tramite", DbType = "DateTime")]
	public DateTime? T_Salida_O_Tramite
	{
		get
		{
			return _T_Salida_O_Tramite;
		}
		set
		{
			if (!_T_Salida_O_Tramite.Equals(value))
			{
				_T_Salida_O_Tramite = value;
			}
		}
	}

	[Column(Storage = "_Puntualidad_Tramite", DbType = "VarChar(8)")]
	public string Puntualidad_Tramite
	{
		get
		{
			return _Puntualidad_Tramite;
		}
		set
		{
			if (!string.Equals(_Puntualidad_Tramite, value))
			{
				_Puntualidad_Tramite = value;
			}
		}
	}

	[Column(Storage = "_T_Excedido_Restante_Tramite", DbType = "NVarChar(50)")]
	public string T_Excedido_Restante_Tramite
	{
		get
		{
			return _T_Excedido_Restante_Tramite;
		}
		set
		{
			if (!string.Equals(_T_Excedido_Restante_Tramite, value))
			{
				_T_Excedido_Restante_Tramite = value;
			}
		}
	}

	[Column(Storage = "_IdDocumento", DbType = "Char(13)")]
	public string IdDocumento
	{
		get
		{
			return _IdDocumento;
		}
		set
		{
			if (!string.Equals(_IdDocumento, value))
			{
				_IdDocumento = value;
			}
		}
	}

	[Column(Storage = "_Referencia", DbType = "VarChar(250)")]
	public string Referencia
	{
		get
		{
			return _Referencia;
		}
		set
		{
			if (!string.Equals(_Referencia, value))
			{
				_Referencia = value;
			}
		}
	}

	[Column(Storage = "_suscritopor", DbType = "VarChar(200)")]
	public string suscritopor
	{
		get
		{
			return _suscritopor;
		}
		set
		{
			if (!string.Equals(_suscritopor, value))
			{
				_suscritopor = value;
			}
		}
	}

	[Column(Storage = "_Doc_Codigo", DbType = "VarChar(60) NOT NULL", CanBeNull = false)]
	public string Doc_Codigo
	{
		get
		{
			return _Doc_Codigo;
		}
		set
		{
			if (!string.Equals(_Doc_Codigo, value))
			{
				_Doc_Codigo = value;
			}
		}
	}
}
