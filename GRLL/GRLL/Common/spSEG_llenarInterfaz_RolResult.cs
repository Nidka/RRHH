using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spSEG_llenarInterfaz_RolResult
{
	private string _Cod;

	private string _descripcion;

	private string _idparent;

	private bool? _conclave;

	private string _clave;

	private int _sel;

	[Column(Storage = "_Cod", DbType = "Char(11)")]
	public string Cod
	{
		get
		{
			return _Cod;
		}
		set
		{
			if (!string.Equals(_Cod, value))
			{
				_Cod = value;
			}
		}
	}

	[Column(Storage = "_descripcion", DbType = "VarChar(150)")]
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

	[Column(Storage = "_idparent", DbType = "Char(11)")]
	public string idparent
	{
		get
		{
			return _idparent;
		}
		set
		{
			if (!string.Equals(_idparent, value))
			{
				_idparent = value;
			}
		}
	}

	[Column(Storage = "_conclave", DbType = "Bit")]
	public bool? conclave
	{
		get
		{
			return _conclave;
		}
		set
		{
			if (!_conclave.Equals(value))
			{
				_conclave = value;
			}
		}
	}

	[Column(Storage = "_clave", DbType = "VarChar(30)")]
	public string clave
	{
		get
		{
			return _clave;
		}
		set
		{
			if (!string.Equals(_clave, value))
			{
				_clave = value;
			}
		}
	}

	[Column(Storage = "_sel", DbType = "Int NOT NULL")]
	public int sel
	{
		get
		{
			return _sel;
		}
		set
		{
			if (_sel != value)
			{
				_sel = value;
			}
		}
	}
}
