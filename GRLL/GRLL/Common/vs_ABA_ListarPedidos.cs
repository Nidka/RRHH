using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.vs_ABA_ListarPedidos")]
public class vs_ABA_ListarPedidos
{
	private string _IdPedido;

	private DateTime? _fecha;

	private string _desarea;

	private string _responsable;

	private string _Observaciones;

	private string _Estado;

	private DateTime? _FechaAprobacion;

	private DateTime? _fechaautorizacion;

	private char? _Tipo;

	private string _Anio;

	private int? _IdAreaOrganiz;

	private decimal? _MontoPedido;

	private decimal? _MontoAprobado;

	private int? _idareaubicacion;

	private int? _idareaautorizacion;

	private string _especificaciones;

	[Column(Storage = "_IdPedido", DbType = "Char(6) NOT NULL", CanBeNull = false)]
	public string IdPedido
	{
		get
		{
			return _IdPedido;
		}
		set
		{
			if (!string.Equals(_IdPedido, value))
			{
				_IdPedido = value;
			}
		}
	}

	[Column(Storage = "_fecha", DbType = "DateTime")]
	public DateTime? fecha
	{
		get
		{
			return _fecha;
		}
		set
		{
			if (!_fecha.Equals(value))
			{
				_fecha = value;
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

	[Column(Storage = "_responsable", DbType = "VarChar(162)")]
	public string responsable
	{
		get
		{
			return _responsable;
		}
		set
		{
			if (!string.Equals(_responsable, value))
			{
				_responsable = value;
			}
		}
	}

	[Column(Storage = "_Observaciones", DbType = "VarChar(120)")]
	public string Observaciones
	{
		get
		{
			return _Observaciones;
		}
		set
		{
			if (!string.Equals(_Observaciones, value))
			{
				_Observaciones = value;
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

	[Column(Storage = "_fechaautorizacion", DbType = "DateTime")]
	public DateTime? fechaautorizacion
	{
		get
		{
			return _fechaautorizacion;
		}
		set
		{
			if (!_fechaautorizacion.Equals(value))
			{
				_fechaautorizacion = value;
			}
		}
	}

	[Column(Storage = "_Tipo", DbType = "Char(1)")]
	public char? Tipo
	{
		get
		{
			return _Tipo;
		}
		set
		{
			if (!_Tipo.Equals(value))
			{
				_Tipo = value;
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

	[Column(Storage = "_MontoPedido", DbType = "Decimal(18,2)")]
	public decimal? MontoPedido
	{
		get
		{
			return _MontoPedido;
		}
		set
		{
			if (!_MontoPedido.Equals(value))
			{
				_MontoPedido = value;
			}
		}
	}

	[Column(Storage = "_MontoAprobado", DbType = "Decimal(18,2)")]
	public decimal? MontoAprobado
	{
		get
		{
			return _MontoAprobado;
		}
		set
		{
			if (!_MontoAprobado.Equals(value))
			{
				_MontoAprobado = value;
			}
		}
	}

	[Column(Storage = "_idareaubicacion", DbType = "Int")]
	public int? idareaubicacion
	{
		get
		{
			return _idareaubicacion;
		}
		set
		{
			if (!_idareaubicacion.Equals(value))
			{
				_idareaubicacion = value;
			}
		}
	}

	[Column(Storage = "_idareaautorizacion", DbType = "Int")]
	public int? idareaautorizacion
	{
		get
		{
			return _idareaautorizacion;
		}
		set
		{
			if (!_idareaautorizacion.Equals(value))
			{
				_idareaautorizacion = value;
			}
		}
	}

	[Column(Storage = "_especificaciones", DbType = "VarChar(80)")]
	public string especificaciones
	{
		get
		{
			return _especificaciones;
		}
		set
		{
			if (!string.Equals(_especificaciones, value))
			{
				_especificaciones = value;
			}
		}
	}
}
