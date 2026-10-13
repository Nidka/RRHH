using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class Aba_Deta_Consolidado_ListarDetalleResult
{
	private string _parentid;

	private string _idconsolidado;

	private string _idbien;

	private string _descripcion;

	private string _unidad;

	private string _idunidadmedida;

	private decimal? _cantidad;

	private string _dependede;

	private string _idpedido;

	private string _desarea;

	private int _item;

	private decimal? _precio;

	[Column(Storage = "_parentid", DbType = "Char(19) NOT NULL", CanBeNull = false)]
	public string parentid
	{
		get
		{
			return _parentid;
		}
		set
		{
			if (!string.Equals(_parentid, value))
			{
				_parentid = value;
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

	[Column(Storage = "_idbien", DbType = "Char(13) NOT NULL", CanBeNull = false)]
	public string idbien
	{
		get
		{
			return _idbien;
		}
		set
		{
			if (!string.Equals(_idbien, value))
			{
				_idbien = value;
			}
		}
	}

	[Column(Storage = "_descripcion", DbType = "VarChar(120)")]
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

	[Column(Storage = "_unidad", DbType = "Char(4)")]
	public string unidad
	{
		get
		{
			return _unidad;
		}
		set
		{
			if (!string.Equals(_unidad, value))
			{
				_unidad = value;
			}
		}
	}

	[Column(Storage = "_idunidadmedida", DbType = "Char(4) NOT NULL", CanBeNull = false)]
	public string idunidadmedida
	{
		get
		{
			return _idunidadmedida;
		}
		set
		{
			if (!string.Equals(_idunidadmedida, value))
			{
				_idunidadmedida = value;
			}
		}
	}

	[Column(Storage = "_cantidad", DbType = "Decimal(0,0)")]
	public decimal? cantidad
	{
		get
		{
			return _cantidad;
		}
		set
		{
			if (!_cantidad.Equals(value))
			{
				_cantidad = value;
			}
		}
	}

	[Column(Storage = "_dependede", DbType = "Char(19)")]
	public string dependede
	{
		get
		{
			return _dependede;
		}
		set
		{
			if (!string.Equals(_dependede, value))
			{
				_dependede = value;
			}
		}
	}

	[Column(Storage = "_idpedido", DbType = "VarChar(19)")]
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

	[Column(Storage = "_item", DbType = "Int NOT NULL")]
	public int item
	{
		get
		{
			return _item;
		}
		set
		{
			if (_item != value)
			{
				_item = value;
			}
		}
	}

	[Column(Storage = "_precio", DbType = "Decimal(0,0)")]
	public decimal? precio
	{
		get
		{
			return _precio;
		}
		set
		{
			if (!_precio.Equals(value))
			{
				_precio = value;
			}
		}
	}
}
