using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class Aba_Pedido_ListarPorEstadoResult
{
	private char? _tipo;

	private string _idpedido;

	private DateTime? _fecha;

	private string _Estado;

	private string _Anio;

	private string _desarea;

	private decimal? _montoaprobado;

	private string _IdBien;

	private string _Descripcion;

	private string _unimed;

	private decimal? _Cantidad;

	private string _Observaciones;

	private int _Item;

	private decimal? _Precio;

	private string _idmeta;

	private string _desmeta;

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

	[Column(Storage = "_montoaprobado", DbType = "Decimal(0,0)")]
	public decimal? montoaprobado
	{
		get
		{
			return _montoaprobado;
		}
		set
		{
			if (!_montoaprobado.Equals(value))
			{
				_montoaprobado = value;
			}
		}
	}

	[Column(Storage = "_IdBien", DbType = "Char(13) NOT NULL", CanBeNull = false)]
	public string IdBien
	{
		get
		{
			return _IdBien;
		}
		set
		{
			if (!string.Equals(_IdBien, value))
			{
				_IdBien = value;
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(120)")]
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

	[Column(Storage = "_unimed", DbType = "Char(4)")]
	public string unimed
	{
		get
		{
			return _unimed;
		}
		set
		{
			if (!string.Equals(_unimed, value))
			{
				_unimed = value;
			}
		}
	}

	[Column(Storage = "_Cantidad", DbType = "Decimal(0,0)")]
	public decimal? Cantidad
	{
		get
		{
			return _Cantidad;
		}
		set
		{
			if (!_Cantidad.Equals(value))
			{
				_Cantidad = value;
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

	[Column(Storage = "_Item", DbType = "Int NOT NULL")]
	public int Item
	{
		get
		{
			return _Item;
		}
		set
		{
			if (_Item != value)
			{
				_Item = value;
			}
		}
	}

	[Column(Storage = "_Precio", DbType = "Decimal(0,0)")]
	public decimal? Precio
	{
		get
		{
			return _Precio;
		}
		set
		{
			if (!_Precio.Equals(value))
			{
				_Precio = value;
			}
		}
	}

	[Column(Storage = "_idmeta", DbType = "Char(6)")]
	public string idmeta
	{
		get
		{
			return _idmeta;
		}
		set
		{
			if (!string.Equals(_idmeta, value))
			{
				_idmeta = value;
			}
		}
	}

	[Column(Storage = "_desmeta", DbType = "VarChar(255)")]
	public string desmeta
	{
		get
		{
			return _desmeta;
		}
		set
		{
			if (!string.Equals(_desmeta, value))
			{
				_desmeta = value;
			}
		}
	}
}
