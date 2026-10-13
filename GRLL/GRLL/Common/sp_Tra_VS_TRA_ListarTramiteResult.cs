using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class sp_Tra_VS_TRA_ListarTramiteResult
{
	private string _idtramite;

	private string _numtramite;

	private string _anio;

	private string _idprocedimiento;

	private string _desprocedimiento;

	private string _estado;

	private string _desestado;

	private string _iddocumento;

	private DateTime? _fechaemision;

	private string _referencia;

	private int? _folio;

	private int? _idareaorganiz;

	private string _desareatramite;

	private string _desareadoc;

	private byte? _idtiposilencio;

	private string _destiposilencio;

	private string _asunto;

	private DateTime? _fechaaprobacion;

	private int? _personarechazo;

	private DateTime? _fecharechazo;

	private int? _arearechazo;

	private string _motivorechazo;

	private DateTime? _f_inicial;

	private DateTime? _f_final;

	private string _puntualidad;

	private string _t_excedido_restante;

	[Column(Storage = "_idtramite", DbType = "Char(10) NOT NULL", CanBeNull = false)]
	public string idtramite
	{
		get
		{
			return _idtramite;
		}
		set
		{
			if (!string.Equals(_idtramite, value))
			{
				_idtramite = value;
			}
		}
	}

	[Column(Storage = "_numtramite", DbType = "VarChar(6)")]
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

	[Column(Storage = "_anio", DbType = "Char(4)")]
	public string anio
	{
		get
		{
			return _anio;
		}
		set
		{
			if (!string.Equals(_anio, value))
			{
				_anio = value;
			}
		}
	}

	[Column(Storage = "_idprocedimiento", DbType = "Char(6)")]
	public string idprocedimiento
	{
		get
		{
			return _idprocedimiento;
		}
		set
		{
			if (!string.Equals(_idprocedimiento, value))
			{
				_idprocedimiento = value;
			}
		}
	}

	[Column(Storage = "_desprocedimiento", DbType = "VarChar(300)")]
	public string desprocedimiento
	{
		get
		{
			return _desprocedimiento;
		}
		set
		{
			if (!string.Equals(_desprocedimiento, value))
			{
				_desprocedimiento = value;
			}
		}
	}

	[Column(Storage = "_estado", DbType = "Char(2)")]
	public string estado
	{
		get
		{
			return _estado;
		}
		set
		{
			if (!string.Equals(_estado, value))
			{
				_estado = value;
			}
		}
	}

	[Column(Storage = "_desestado", DbType = "VarChar(15)")]
	public string desestado
	{
		get
		{
			return _desestado;
		}
		set
		{
			if (!string.Equals(_desestado, value))
			{
				_desestado = value;
			}
		}
	}

	[Column(Storage = "_iddocumento", DbType = "Char(13)")]
	public string iddocumento
	{
		get
		{
			return _iddocumento;
		}
		set
		{
			if (!string.Equals(_iddocumento, value))
			{
				_iddocumento = value;
			}
		}
	}

	[Column(Storage = "_fechaemision", DbType = "DateTime")]
	public DateTime? fechaemision
	{
		get
		{
			return _fechaemision;
		}
		set
		{
			if (!_fechaemision.Equals(value))
			{
				_fechaemision = value;
			}
		}
	}

	[Column(Storage = "_referencia", DbType = "VarChar(250)")]
	public string referencia
	{
		get
		{
			return _referencia;
		}
		set
		{
			if (!string.Equals(_referencia, value))
			{
				_referencia = value;
			}
		}
	}

	[Column(Storage = "_folio", DbType = "Int")]
	public int? folio
	{
		get
		{
			return _folio;
		}
		set
		{
			if (!_folio.Equals(value))
			{
				_folio = value;
			}
		}
	}

	[Column(Storage = "_idareaorganiz", DbType = "Int")]
	public int? idareaorganiz
	{
		get
		{
			return _idareaorganiz;
		}
		set
		{
			if (!_idareaorganiz.Equals(value))
			{
				_idareaorganiz = value;
			}
		}
	}

	[Column(Storage = "_desareatramite", DbType = "VarChar(200) NOT NULL", CanBeNull = false)]
	public string desareatramite
	{
		get
		{
			return _desareatramite;
		}
		set
		{
			if (!string.Equals(_desareatramite, value))
			{
				_desareatramite = value;
			}
		}
	}

	[Column(Storage = "_desareadoc", DbType = "VarChar(200) NOT NULL", CanBeNull = false)]
	public string desareadoc
	{
		get
		{
			return _desareadoc;
		}
		set
		{
			if (!string.Equals(_desareadoc, value))
			{
				_desareadoc = value;
			}
		}
	}

	[Column(Storage = "_idtiposilencio", DbType = "TinyInt")]
	public byte? idtiposilencio
	{
		get
		{
			return _idtiposilencio;
		}
		set
		{
			if (!_idtiposilencio.Equals(value))
			{
				_idtiposilencio = value;
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

	[Column(Storage = "_asunto", DbType = "VarChar(250)")]
	public string asunto
	{
		get
		{
			return _asunto;
		}
		set
		{
			if (!string.Equals(_asunto, value))
			{
				_asunto = value;
			}
		}
	}

	[Column(Storage = "_fechaaprobacion", DbType = "DateTime")]
	public DateTime? fechaaprobacion
	{
		get
		{
			return _fechaaprobacion;
		}
		set
		{
			if (!_fechaaprobacion.Equals(value))
			{
				_fechaaprobacion = value;
			}
		}
	}

	[Column(Storage = "_personarechazo", DbType = "Int")]
	public int? personarechazo
	{
		get
		{
			return _personarechazo;
		}
		set
		{
			if (!_personarechazo.Equals(value))
			{
				_personarechazo = value;
			}
		}
	}

	[Column(Storage = "_fecharechazo", DbType = "DateTime")]
	public DateTime? fecharechazo
	{
		get
		{
			return _fecharechazo;
		}
		set
		{
			if (!_fecharechazo.Equals(value))
			{
				_fecharechazo = value;
			}
		}
	}

	[Column(Storage = "_arearechazo", DbType = "Int")]
	public int? arearechazo
	{
		get
		{
			return _arearechazo;
		}
		set
		{
			if (!_arearechazo.Equals(value))
			{
				_arearechazo = value;
			}
		}
	}

	[Column(Storage = "_motivorechazo", DbType = "VarChar(200)")]
	public string motivorechazo
	{
		get
		{
			return _motivorechazo;
		}
		set
		{
			if (!string.Equals(_motivorechazo, value))
			{
				_motivorechazo = value;
			}
		}
	}

	[Column(Storage = "_f_inicial", DbType = "DateTime")]
	public DateTime? f_inicial
	{
		get
		{
			return _f_inicial;
		}
		set
		{
			if (!_f_inicial.Equals(value))
			{
				_f_inicial = value;
			}
		}
	}

	[Column(Storage = "_f_final", DbType = "DateTime")]
	public DateTime? f_final
	{
		get
		{
			return _f_final;
		}
		set
		{
			if (!_f_final.Equals(value))
			{
				_f_final = value;
			}
		}
	}

	[Column(Storage = "_puntualidad", DbType = "VarChar(8) NOT NULL", CanBeNull = false)]
	public string puntualidad
	{
		get
		{
			return _puntualidad;
		}
		set
		{
			if (!string.Equals(_puntualidad, value))
			{
				_puntualidad = value;
			}
		}
	}

	[Column(Storage = "_t_excedido_restante", DbType = "NVarChar(55)")]
	public string t_excedido_restante
	{
		get
		{
			return _t_excedido_restante;
		}
		set
		{
			if (!string.Equals(_t_excedido_restante, value))
			{
				_t_excedido_restante = value;
			}
		}
	}
}
