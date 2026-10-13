using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.vs_ABA_AprobacionPedido")]
public class vs_ABA_AprobacionPedido
{
	private string _idpedido;

	private int _idareapedido;

	private string _desareapedido;

	private int _idareaaprobacion;

	private string _desareaaprobacion;

	private int? _idareadestino;

	private string _desareadestino;

	private DateTime? _fechapedido;

	private DateTime? _fecharecepcion;

	private DateTime? _fechatramite;

	private char? _Estado;

	private int? _idtrabajador;

	private string _destrabajador;

	private int _anio;

	[Column(Storage = "_idpedido", DbType = "Char(6) NOT NULL", CanBeNull = false)]
	public string idpedido
	{
		get
		{
			return _idpedido;
		}
		set
		{
			if (!string.Equals(_idpedido, value))
			{
				_idpedido = value;
			}
		}
	}

	[Column(Storage = "_idareapedido", DbType = "Int NOT NULL")]
	public int idareapedido
	{
		get
		{
			return _idareapedido;
		}
		set
		{
			if (_idareapedido != value)
			{
				_idareapedido = value;
			}
		}
	}

	[Column(Storage = "_desareapedido", DbType = "VarChar(200) NOT NULL", CanBeNull = false)]
	public string desareapedido
	{
		get
		{
			return _desareapedido;
		}
		set
		{
			if (!string.Equals(_desareapedido, value))
			{
				_desareapedido = value;
			}
		}
	}

	[Column(Storage = "_idareaaprobacion", DbType = "Int NOT NULL")]
	public int idareaaprobacion
	{
		get
		{
			return _idareaaprobacion;
		}
		set
		{
			if (_idareaaprobacion != value)
			{
				_idareaaprobacion = value;
			}
		}
	}

	[Column(Storage = "_desareaaprobacion", DbType = "VarChar(200) NOT NULL", CanBeNull = false)]
	public string desareaaprobacion
	{
		get
		{
			return _desareaaprobacion;
		}
		set
		{
			if (!string.Equals(_desareaaprobacion, value))
			{
				_desareaaprobacion = value;
			}
		}
	}

	[Column(Storage = "_idareadestino", DbType = "Int")]
	public int? idareadestino
	{
		get
		{
			return _idareadestino;
		}
		set
		{
			if (!_idareadestino.Equals(value))
			{
				_idareadestino = value;
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

	[Column(Storage = "_fechapedido", DbType = "DateTime")]
	public DateTime? fechapedido
	{
		get
		{
			return _fechapedido;
		}
		set
		{
			if (!_fechapedido.Equals(value))
			{
				_fechapedido = value;
			}
		}
	}

	[Column(Storage = "_fecharecepcion", DbType = "DateTime")]
	public DateTime? fecharecepcion
	{
		get
		{
			return _fecharecepcion;
		}
		set
		{
			if (!_fecharecepcion.Equals(value))
			{
				_fecharecepcion = value;
			}
		}
	}

	[Column(Storage = "_fechatramite", DbType = "DateTime")]
	public DateTime? fechatramite
	{
		get
		{
			return _fechatramite;
		}
		set
		{
			if (!_fechatramite.Equals(value))
			{
				_fechatramite = value;
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

	[Column(Storage = "_destrabajador", DbType = "VarChar(162)")]
	public string destrabajador
	{
		get
		{
			return _destrabajador;
		}
		set
		{
			if (!string.Equals(_destrabajador, value))
			{
				_destrabajador = value;
			}
		}
	}

	[Column(Storage = "_anio", DbType = "Int NOT NULL")]
	public int anio
	{
		get
		{
			return _anio;
		}
		set
		{
			if (_anio != value)
			{
				_anio = value;
			}
		}
	}
}
