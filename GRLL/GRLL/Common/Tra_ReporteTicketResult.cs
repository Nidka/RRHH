using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class Tra_ReporteTicketResult
{
	private string _idtramite;

	private string _numtramite;

	private DateTime? _f_emision_tramite;

	private string _descripcion;

	private string _Doc_Codigo;

	private string _Estado;

	private string _iddocumento;

	private string _asunto;

	private string _referencia;

	private string _suscritopor;

	private string _idprocedimiento;

	private string _idetapaproc;

	private string _desetapa;

	[Column(Storage = "_idtramite", DbType = "Char(10)")]
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

	[Column(Storage = "_descripcion", DbType = "VarChar(300)")]
	public string descripcion
	{
		get
		{
			return _descripcion;
		}
		set
		{
			if (!string.Equals(_descripcion, value))
			{
				_descripcion = value;
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

	[Column(Storage = "_Estado", DbType = "VarChar(15)")]
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

	[Column(Storage = "_idetapaproc", DbType = "Char(8)")]
	public string idetapaproc
	{
		get
		{
			return _idetapaproc;
		}
		set
		{
			if (!string.Equals(_idetapaproc, value))
			{
				_idetapaproc = value;
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
}
