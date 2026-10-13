using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.vs_PER_ListarEmpleados")]
public class vs_PER_ListarEmpleados
{
	private int _idempleado;

	private string _numdocid;

	private string _nombre;

	private string _telefono;

	private string _direccion;

	private string _email;

	private char? _sexo;

	private int _year;

	private int _idareaorganiz;

	[Column(Storage = "_idempleado", DbType = "Int NOT NULL")]
	public int idempleado
	{
		get
		{
			return _idempleado;
		}
		set
		{
			if (_idempleado != value)
			{
				_idempleado = value;
			}
		}
	}

	[Column(Storage = "_numdocid", DbType = "Char(12)")]
	public string numdocid
	{
		get
		{
			return _numdocid;
		}
		set
		{
			if (!string.Equals(_numdocid, value))
			{
				_numdocid = value;
			}
		}
	}

	[Column(Storage = "_nombre", DbType = "VarChar(162)")]
	public string nombre
	{
		get
		{
			return _nombre;
		}
		set
		{
			if (!string.Equals(_nombre, value))
			{
				_nombre = value;
			}
		}
	}

	[Column(Storage = "_telefono", DbType = "VarChar(15)")]
	public string telefono
	{
		get
		{
			return _telefono;
		}
		set
		{
			if (!string.Equals(_telefono, value))
			{
				_telefono = value;
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

	[Column(Storage = "_sexo", DbType = "Char(1)")]
	public char? sexo
	{
		get
		{
			return _sexo;
		}
		set
		{
			if (!_sexo.Equals(value))
			{
				_sexo = value;
			}
		}
	}

	[Column(Storage = "_year", DbType = "Int NOT NULL")]
	public int year
	{
		get
		{
			return _year;
		}
		set
		{
			if (_year != value)
			{
				_year = value;
			}
		}
	}

	[Column(Storage = "_idareaorganiz", DbType = "Int NOT NULL")]
	public int idareaorganiz
	{
		get
		{
			return _idareaorganiz;
		}
		set
		{
			if (_idareaorganiz != value)
			{
				_idareaorganiz = value;
			}
		}
	}
}
