using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.vs_ABA_ListarOrdenCompra")]
public class vs_ABA_ListarOrdenCompra
{
	private string _nroorden;

	private string _anio;

	private string _idorden;

	private DateTime? _fecha;

	private DateTime? _fechaentrega;

	private string _idproveedor;

	private string _desproveedor;

	private string _desestado;

	private string _idalmacen;

	private string _desalmacen;

	[Column(Storage = "_nroorden", DbType = "VarChar(6)")]
	public string nroorden
	{
		get
		{
			return _nroorden;
		}
		set
		{
			if (!string.Equals(_nroorden, value))
			{
				_nroorden = value;
			}
		}
	}

	[Column(Storage = "_anio", DbType = "VarChar(4)")]
	public string anio
	{
		get
		{
			return _anio;
		}
		set
		{
			if (!string.Equals(_anio, value))
			{
				_anio = value;
			}
		}
	}

	[Column(Storage = "_idorden", DbType = "Char(8) NOT NULL", CanBeNull = false)]
	public string idorden
	{
		get
		{
			return _idorden;
		}
		set
		{
			if (!string.Equals(_idorden, value))
			{
				_idorden = value;
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

	[Column(Storage = "_fechaentrega", DbType = "DateTime")]
	public DateTime? fechaentrega
	{
		get
		{
			return _fechaentrega;
		}
		set
		{
			if (!_fechaentrega.Equals(value))
			{
				_fechaentrega = value;
			}
		}
	}

	[Column(Storage = "_idproveedor", DbType = "Char(11)")]
	public string idproveedor
	{
		get
		{
			return _idproveedor;
		}
		set
		{
			if (!string.Equals(_idproveedor, value))
			{
				_idproveedor = value;
			}
		}
	}

	[Column(Storage = "_desproveedor", DbType = "VarChar(100)")]
	public string desproveedor
	{
		get
		{
			return _desproveedor;
		}
		set
		{
			if (!string.Equals(_desproveedor, value))
			{
				_desproveedor = value;
			}
		}
	}

	[Column(Storage = "_desestado", DbType = "VarChar(20)")]
	public string desestado
	{
		get
		{
			return _desestado;
		}
		set
		{
			if (!string.Equals(_desestado, value))
			{
				_desestado = value;
			}
		}
	}

	[Column(Storage = "_idalmacen", DbType = "Char(2)")]
	public string idalmacen
	{
		get
		{
			return _idalmacen;
		}
		set
		{
			if (!string.Equals(_idalmacen, value))
			{
				_idalmacen = value;
			}
		}
	}

	[Column(Storage = "_desalmacen", DbType = "VarChar(120)")]
	public string desalmacen
	{
		get
		{
			return _desalmacen;
		}
		set
		{
			if (!string.Equals(_desalmacen, value))
			{
				_desalmacen = value;
			}
		}
	}
}
