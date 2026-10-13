using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.vs_ABA_ListarAprobacionesPedido")]
public class vs_ABA_ListarAprobacionesPedido
{
	private string _IdPedido;

	private int _idarea;

	private string _desarea;

	private char? _Estado;

	private string _Observaciones;

	private DateTime? _Fecha;

	private int? _idtrabajador;

	private bool? _EstadoBit;

	private DateTime? _FechaAprobacion;

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

	[Column(Storage = "_idarea", DbType = "Int NOT NULL")]
	public int idarea
	{
		get
		{
			return _idarea;
		}
		set
		{
			if (_idarea != value)
			{
				_idarea = value;
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

	[Column(Storage = "_Estado", DbType = "Char(1)")]
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
				_Estado = value;
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

	[Column(Storage = "_Fecha", DbType = "DateTime")]
	public DateTime? Fecha
	{
		get
		{
			return _Fecha;
		}
		set
		{
			if (!_Fecha.Equals(value))
			{
				_Fecha = value;
			}
		}
	}

	[Column(Storage = "_idtrabajador", DbType = "Int")]
	public int? idtrabajador
	{
		get
		{
			return _idtrabajador;
		}
		set
		{
			if (!_idtrabajador.Equals(value))
			{
				_idtrabajador = value;
			}
		}
	}

	[Column(Storage = "_EstadoBit", DbType = "Bit")]
	public bool? EstadoBit
	{
		get
		{
			return _EstadoBit;
		}
		set
		{
			if (!_EstadoBit.Equals(value))
			{
				_EstadoBit = value;
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
}
