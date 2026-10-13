using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class Aba_Deta_Distribucion_PorOrdenCompraResult
{
	private int _item;

	private string _idmeta;

	private string _desmeta;

	private string _idgasto;

	private string _desgasto;

	private string _idbien;

	private string _descripcion;

	private string _unimed;

	private int? _idarea;

	private string _desarea;

	private decimal? _cantidad;

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

	[Column(Storage = "_idmeta", DbType = "Char(6) NOT NULL", CanBeNull = false)]
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

	[Column(Storage = "_idgasto", DbType = "Char(20) NOT NULL", CanBeNull = false)]
	public string idgasto
	{
		get
		{
			return _idgasto;
		}
		set
		{
			if (!string.Equals(_idgasto, value))
			{
				_idgasto = value;
			}
		}
	}

	[Column(Storage = "_desgasto", DbType = "VarChar(80)")]
	public string desgasto
	{
		get
		{
			return _desgasto;
		}
		set
		{
			if (!string.Equals(_desgasto, value))
			{
				_desgasto = value;
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
}
