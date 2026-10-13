using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class sp_Tra_BuscarTramiteResult
{
	private string _IdTramite;

	private string _Anio;

	private string _IdProcedimiento;

	private string _Procedimiento;

	private string _Estado;

	private string _IdDocumento;

	private string _CODIGO;

	private string _ASUNTO;

	private string _REFEREBCIA;

	private string _IdTipoDoc;

	private int? _IdAreaOrganiz;

	private string _MotivoRechazo;

	private int? _PersonaRechazo;

	private DateTime? _FechaRechazo;

	private int? _AreaRechazo;

	private DateTime? _FechaAprobacion;

	private DateTime? _FechaTramite;

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

	[Column(Storage = "_Procedimiento", DbType = "VarChar(300)")]
	public string Procedimiento
	{
		get
		{
			return _Procedimiento;
		}
		set
		{
			if (!string.Equals(_Procedimiento, value))
			{
				_Procedimiento = value;
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

	[Column(Storage = "_CODIGO", DbType = "VarChar(30)")]
	public string CODIGO
	{
		get
		{
			return _CODIGO;
		}
		set
		{
			if (!string.Equals(_CODIGO, value))
			{
				_CODIGO = value;
			}
		}
	}

	[Column(Storage = "_ASUNTO", DbType = "VarChar(250)")]
	public string ASUNTO
	{
		get
		{
			return _ASUNTO;
		}
		set
		{
			if (!string.Equals(_ASUNTO, value))
			{
				_ASUNTO = value;
			}
		}
	}

	[Column(Storage = "_REFEREBCIA", DbType = "VarChar(250)")]
	public string REFEREBCIA
	{
		get
		{
			return _REFEREBCIA;
		}
		set
		{
			if (!string.Equals(_REFEREBCIA, value))
			{
				_REFEREBCIA = value;
			}
		}
	}

	[Column(Storage = "_IdTipoDoc", DbType = "Char(2)")]
	public string IdTipoDoc
	{
		get
		{
			return _IdTipoDoc;
		}
		set
		{
			if (!string.Equals(_IdTipoDoc, value))
			{
				_IdTipoDoc = value;
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

	[Column(Storage = "_FechaTramite", DbType = "DateTime")]
	public DateTime? FechaTramite
	{
		get
		{
			return _FechaTramite;
		}
		set
		{
			if (!_FechaTramite.Equals(value))
			{
				_FechaTramite = value;
			}
		}
	}
}
