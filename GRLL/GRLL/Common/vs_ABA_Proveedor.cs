using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.vs_ABA_Proveedor")]
public class vs_ABA_Proveedor
{
	private int? _idpersona;

	private string _idproveedor;

	private string _razonsocial;

	private string _nombrecomercial;

	private string _representantelegal;

	private string _estado;

	private string _direccion;

	private string _email;

	private string _idubigeo;

	private DateTime? _fechanacimiento;

	private string _tipopersona;

	private string _desestado;

	[Column(Storage = "_idpersona", DbType = "Int")]
	public int? idpersona
	{
		get
		{
			return _idpersona;
		}
		set
		{
			if (!_idpersona.Equals(value))
			{
				_idpersona = value;
			}
		}
	}

	[Column(Storage = "_idproveedor", DbType = "Char(11) NOT NULL", CanBeNull = false)]
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

	[Column(Storage = "_razonsocial", DbType = "VarChar(100)")]
	public string razonsocial
	{
		get
		{
			return _razonsocial;
		}
		set
		{
			if (!string.Equals(_razonsocial, value))
			{
				_razonsocial = value;
			}
		}
	}

	[Column(Storage = "_nombrecomercial", DbType = "VarChar(60)")]
	public string nombrecomercial
	{
		get
		{
			return _nombrecomercial;
		}
		set
		{
			if (!string.Equals(_nombrecomercial, value))
			{
				_nombrecomercial = value;
			}
		}
	}

	[Column(Storage = "_representantelegal", DbType = "VarChar(60)")]
	public string representantelegal
	{
		get
		{
			return _representantelegal;
		}
		set
		{
			if (!string.Equals(_representantelegal, value))
			{
				_representantelegal = value;
			}
		}
	}

	[Column(Storage = "_estado", DbType = "Char(2)")]
	public string estado
	{
		get
		{
			return _estado;
		}
		set
		{
			if (!string.Equals(_estado, value))
			{
				_estado = value;
			}
		}
	}

	[Column(Storage = "_direccion", DbType = "VarChar(100)")]
	public string direccion
	{
		get
		{
			return _direccion;
		}
		set
		{
			if (!string.Equals(_direccion, value))
			{
				_direccion = value;
			}
		}
	}

	[Column(Storage = "_email", DbType = "VarChar(50)")]
	public string email
	{
		get
		{
			return _email;
		}
		set
		{
			if (!string.Equals(_email, value))
			{
				_email = value;
			}
		}
	}

	[Column(Storage = "_idubigeo", DbType = "Char(6)")]
	public string idubigeo
	{
		get
		{
			return _idubigeo;
		}
		set
		{
			if (!string.Equals(_idubigeo, value))
			{
				_idubigeo = value;
			}
		}
	}

	[Column(Storage = "_fechanacimiento", DbType = "DateTime")]
	public DateTime? fechanacimiento
	{
		get
		{
			return _fechanacimiento;
		}
		set
		{
			if (!_fechanacimiento.Equals(value))
			{
				_fechanacimiento = value;
			}
		}
	}

	[Column(Storage = "_tipopersona", DbType = "VarChar(8) NOT NULL", CanBeNull = false)]
	public string tipopersona
	{
		get
		{
			return _tipopersona;
		}
		set
		{
			if (!string.Equals(_tipopersona, value))
			{
				_tipopersona = value;
			}
		}
	}

	[Column(Storage = "_desestado", DbType = "VarChar(9) NOT NULL", CanBeNull = false)]
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
}
