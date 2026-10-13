using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class TRA_Adjunto_ListarPorTramiteResult
{
	private string _iddocumento;

	private string _codigo;

	private string _destipodoc;

	private DateTime? _fechaemision;

	private string _asunto;

	private string _idmovimiento;

	private string _idtramite;

	private string _idtipodoc;

	private int _idareaorganiz;

	private string _desarea;

	[Column(Storage = "_iddocumento", DbType = "Char(13) NOT NULL", CanBeNull = false)]
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

	[Column(Storage = "_codigo", DbType = "VarChar(30)")]
	public string codigo
	{
		get
		{
			return _codigo;
		}
		set
		{
			if (!string.Equals(_codigo, value))
			{
				_codigo = value;
			}
		}
	}

	[Column(Storage = "_destipodoc", DbType = "VarChar(200)")]
	public string destipodoc
	{
		get
		{
			return _destipodoc;
		}
		set
		{
			if (!string.Equals(_destipodoc, value))
			{
				_destipodoc = value;
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

	[Column(Storage = "_idmovimiento", DbType = "Char(10) NOT NULL", CanBeNull = false)]
	public string idmovimiento
	{
		get
		{
			return _idmovimiento;
		}
		set
		{
			if (!string.Equals(_idmovimiento, value))
			{
				_idmovimiento = value;
			}
		}
	}

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

	[Column(Storage = "_idtipodoc", DbType = "Char(2) NOT NULL", CanBeNull = false)]
	public string idtipodoc
	{
		get
		{
			return _idtipodoc;
		}
		set
		{
			if (!string.Equals(_idtipodoc, value))
			{
				_idtipodoc = value;
			}
		}
	}

	[Column(Storage = "_idareaorganiz", DbType = "Int NOT NULL")]
	public int idareaorganiz
	{
		get
		{
			return _idareaorganiz;
		}
		set
		{
			if (_idareaorganiz != value)
			{
				_idareaorganiz = value;
			}
		}
	}

	[Column(Storage = "_desarea", DbType = "VarChar(200) NOT NULL", CanBeNull = false)]
	public string desarea
	{
		get
		{
			return _desarea;
		}
		set
		{
			if (!string.Equals(_desarea, value))
			{
				_desarea = value;
			}
		}
	}
}
