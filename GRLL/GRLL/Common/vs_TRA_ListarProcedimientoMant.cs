using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.vs_TRA_ListarProcedimientoMant")]
public class vs_TRA_ListarProcedimientoMant
{
	private string _idprocedimiento;

	private string _tracodigo;

	private string _descripcion;

	private byte? _idtiposilencio;

	private string _destiposilencio;

	private string _observaciones;

	private int? _anio;

	private char? _estado;

	private int? _idareaorganiz;

	private string _desarea;

	private char? _tipo;

	private char? _ambito;

	[Column(Storage = "_idprocedimiento", DbType = "Char(6) NOT NULL", CanBeNull = false)]
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

	[Column(Storage = "_tracodigo", DbType = "Char(20) NOT NULL", CanBeNull = false)]
	public string tracodigo
	{
		get
		{
			return _tracodigo;
		}
		set
		{
			if (!string.Equals(_tracodigo, value))
			{
				_tracodigo = value;
			}
		}
	}

	[Column(Storage = "_descripcion", DbType = "VarChar(100)")]
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

	[Column(Storage = "_observaciones", DbType = "VarChar(200)")]
	public string observaciones
	{
		get
		{
			return _observaciones;
		}
		set
		{
			if (!string.Equals(_observaciones, value))
			{
				_observaciones = value;
			}
		}
	}

	[Column(Storage = "_anio", DbType = "Int")]
	public int? anio
	{
		get
		{
			return _anio;
		}
		set
		{
			if (!_anio.Equals(value))
			{
				_anio = value;
			}
		}
	}

	[Column(Storage = "_estado", DbType = "VarChar(1)")]
	public char? estado
	{
		get
		{
			return _estado;
		}
		set
		{
			if (!_estado.Equals(value))
			{
				_estado = value;
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

	[Column(Storage = "_desarea", DbType = "VarChar(200)")]
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

	[Column(Storage = "_tipo", DbType = "Char(1)")]
	public char? tipo
	{
		get
		{
			return _tipo;
		}
		set
		{
			if (!_tipo.Equals(value))
			{
				_tipo = value;
			}
		}
	}

	[Column(Storage = "_ambito", DbType = "Char(1)")]
	public char? ambito
	{
		get
		{
			return _ambito;
		}
		set
		{
			if (!_ambito.Equals(value))
			{
				_ambito = value;
			}
		}
	}
}
