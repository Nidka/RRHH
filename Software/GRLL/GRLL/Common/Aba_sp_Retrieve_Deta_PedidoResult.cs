using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class Aba_sp_Retrieve_Deta_PedidoResult
{
	private char? _Tipo;

	private string _IdBien;

	private string _Descripcion;

	private string _unimed;

	private decimal? _Cantidad;

	private string _metacor;

	private string _IdMeta;

	private string _desmeta;

	private string _Observaciones;

	private int _Item;

	private string _IdPedido;

	private decimal? _Precio;

	private decimal? _importe;

	private string _idconsolidado;

	private int? _idarea;

	private string _desarea;

	private string _abrev;

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

	[Column(Storage = "_metacor", DbType = "VarChar(4)")]
	public string metacor
	{
		get
		{
			return _metacor;
		}
		set
		{
			if (!string.Equals(_metacor, value))
			{
				_metacor = value;
			}
		}
	}

	[Column(Storage = "_IdMeta", DbType = "Char(6)")]
	public string IdMeta
	{
		get
		{
			return _IdMeta;
		}
		set
		{
			if (!string.Equals(_IdMeta, value))
			{
				_IdMeta = value;
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

	[Column(Storage = "_importe", DbType = "Decimal(0,0)")]
	public decimal? importe
	{
		get
		{
			return _importe;
		}
		set
		{
			if (!_importe.Equals(value))
			{
				_importe = value;
			}
		}
	}

	[Column(Storage = "_idconsolidado", DbType = "Char(6)")]
	public string idconsolidado
	{
		get
		{
			return _idconsolidado;
		}
		set
		{
			if (!string.Equals(_idconsolidado, value))
			{
				_idconsolidado = value;
			}
		}
	}

	[Column(Storage = "_idarea", DbType = "Int")]
	public int? idarea
	{
		get
		{
			return _idarea;
		}
		set
		{
			if (!_idarea.Equals(value))
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

	[Column(Storage = "_abrev", DbType = "VarChar(10) NOT NULL", CanBeNull = false)]
	public string abrev
	{
		get
		{
			return _abrev;
		}
		set
		{
			if (!string.Equals(_abrev, value))
			{
				_abrev = value;
			}
		}
	}
}
