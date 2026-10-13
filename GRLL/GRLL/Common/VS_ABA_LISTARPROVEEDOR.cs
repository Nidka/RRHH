using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.VS_ABA_LISTARPROVEEDOR")]
public class VS_ABA_LISTARPROVEEDOR
{
	private string _IDPROVEEDOR;

	private string _RAZONSOCIAL;

	private string _DIRECCION;

	private string _ESTADO;

	private int _idpersona;

	[Column(Storage = "_IDPROVEEDOR", DbType = "Char(11) NOT NULL", CanBeNull = false)]
	public string IDPROVEEDOR
	{
		get
		{
			return _IDPROVEEDOR;
		}
		set
		{
			if (!string.Equals(_IDPROVEEDOR, value))
			{
				_IDPROVEEDOR = value;
			}
		}
	}

	[Column(Storage = "_RAZONSOCIAL", DbType = "VarChar(100)")]
	public string RAZONSOCIAL
	{
		get
		{
			return _RAZONSOCIAL;
		}
		set
		{
			if (!string.Equals(_RAZONSOCIAL, value))
			{
				_RAZONSOCIAL = value;
			}
		}
	}

	[Column(Storage = "_DIRECCION", DbType = "VarChar(100)")]
	public string DIRECCION
	{
		get
		{
			return _DIRECCION;
		}
		set
		{
			if (!string.Equals(_DIRECCION, value))
			{
				_DIRECCION = value;
			}
		}
	}

	[Column(Storage = "_ESTADO", DbType = "Char(2)")]
	public string ESTADO
	{
		get
		{
			return _ESTADO;
		}
		set
		{
			if (!string.Equals(_ESTADO, value))
			{
				_ESTADO = value;
			}
		}
	}

	[Column(Storage = "_idpersona", DbType = "Int NOT NULL")]
	public int idpersona
	{
		get
		{
			return _idpersona;
		}
		set
		{
			if (_idpersona != value)
			{
				_idpersona = value;
			}
		}
	}
}
