using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class sp_Tra_TraListarTramiteResult
{
	private string _IdTramite;

	private string _numtramite;

	private string _Anio;

	private string _IdProcedimiento;

	private string _desprocedimiento;

	private string _Estado;

	private string _desestado;

	private string _IdDocumento;

	private string _Doc_Codigo;

	private string _desc_TipoDoc;

	private DateTime? _FechaEmision;

	private string _Asunto;

	private string _Referencia;

	private int? _Folio;

	private string _suscritopor;

	private int? _IdAreaOrganiz;

	private string _desareatramite;

	private string _desareadoc;

	private byte? _IdTipoSilencio;

	private string _destiposilencio;

	private DateTime? _FechaAprobacion;

	private int? _PersonaRechazo;

	private DateTime? _FechaRechazo;

	private int? _AreaRechazo;

	private string _MotivoRechazo;

	[Column(Storage = "_IdTramite", DbType = "Char(10) NOT NULL", CanBeNull = false)]
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

	[Column(Storage = "_Anio", DbType = "Char(4)")]
	public string Anio
	{
		get
		{
			return _Anio;
		}
		set
		{
			if (!string.Equals(_Anio, value))
			{
				_Anio = value;
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

	[Column(Storage = "_Estado", DbType = "Char(2)")]
	public string Estado
	{
		get
		{
			return _Estado;
		}
		set
		{
			if (!string.Equals(_Estado, value))
			{
				_Estado = value;
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

	[Column(Storage = "_Doc_Codigo", DbType = "VarChar(30)")]
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

	[Column(Storage = "_desc_TipoDoc", DbType = "VarChar(200)")]
	public string desc_TipoDoc
	{
		get
		{
			return _desc_TipoDoc;
		}
		set
		{
			if (!string.Equals(_desc_TipoDoc, value))
			{
				_desc_TipoDoc = value;
			}
		}
	}

	[Column(Storage = "_FechaEmision", DbType = "DateTime")]
	public DateTime? FechaEmision
	{
		get
		{
			return _FechaEmision;
		}
		set
		{
			if (!_FechaEmision.Equals(value))
			{
				_FechaEmision = value;
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

	[Column(Storage = "_Folio", DbType = "Int")]
	public int? Folio
	{
		get
		{
			return _Folio;
		}
		set
		{
			if (!_Folio.Equals(value))
			{
				_Folio = value;
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

	[Column(Storage = "_IdAreaOrganiz", DbType = "Int")]
	public int? IdAreaOrganiz
	{
		get
		{
			return _IdAreaOrganiz;
		}
		set
		{
			if (!_IdAreaOrganiz.Equals(value))
			{
				_IdAreaOrganiz = value;
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
}
