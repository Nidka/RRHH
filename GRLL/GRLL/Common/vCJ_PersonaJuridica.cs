using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.vCJ_PersonaJuridica")]
public class vCJ_PersonaJuridica
{
	private int _IdPersona;

	private string _NumDocID;

	private string _RazonSocial;

	private string _NombreComercial;

	private string _RepresentanteLegal;

	private string _IdUbigeo;

	private string _Direccion;

	private int? _TipoDocID;

	private string _Telefono;

	private string _Fax;

	private string _Email;

	private string _NumCelular;

	[Column(Storage = "_IdPersona", DbType = "Int NOT NULL")]
	public int IdPersona
	{
		get
		{
			return _IdPersona;
		}
		set
		{
			if (_IdPersona != value)
			{
				_IdPersona = value;
			}
		}
	}

	[Column(Storage = "_NumDocID", DbType = "Char(12)")]
	public string NumDocID
	{
		get
		{
			return _NumDocID;
		}
		set
		{
			if (!string.Equals(_NumDocID, value))
			{
				_NumDocID = value;
			}
		}
	}

	[Column(Storage = "_RazonSocial", DbType = "VarChar(100) NOT NULL", CanBeNull = false)]
	public string RazonSocial
	{
		get
		{
			return _RazonSocial;
		}
		set
		{
			if (!string.Equals(_RazonSocial, value))
			{
				_RazonSocial = value;
			}
		}
	}

	[Column(Storage = "_NombreComercial", DbType = "VarChar(60) NOT NULL", CanBeNull = false)]
	public string NombreComercial
	{
		get
		{
			return _NombreComercial;
		}
		set
		{
			if (!string.Equals(_NombreComercial, value))
			{
				_NombreComercial = value;
			}
		}
	}

	[Column(Storage = "_RepresentanteLegal", DbType = "VarChar(60) NOT NULL", CanBeNull = false)]
	public string RepresentanteLegal
	{
		get
		{
			return _RepresentanteLegal;
		}
		set
		{
			if (!string.Equals(_RepresentanteLegal, value))
			{
				_RepresentanteLegal = value;
			}
		}
	}

	[Column(Storage = "_IdUbigeo", DbType = "Char(6) NOT NULL", CanBeNull = false)]
	public string IdUbigeo
	{
		get
		{
			return _IdUbigeo;
		}
		set
		{
			if (!string.Equals(_IdUbigeo, value))
			{
				_IdUbigeo = value;
			}
		}
	}

	[Column(Storage = "_Direccion", DbType = "VarChar(100) NOT NULL", CanBeNull = false)]
	public string Direccion
	{
		get
		{
			return _Direccion;
		}
		set
		{
			if (!string.Equals(_Direccion, value))
			{
				_Direccion = value;
			}
		}
	}

	[Column(Storage = "_TipoDocID", DbType = "Int")]
	public int? TipoDocID
	{
		get
		{
			return _TipoDocID;
		}
		set
		{
			if (!_TipoDocID.Equals(value))
			{
				_TipoDocID = value;
			}
		}
	}

	[Column(Storage = "_Telefono", DbType = "VarChar(15) NOT NULL", CanBeNull = false)]
	public string Telefono
	{
		get
		{
			return _Telefono;
		}
		set
		{
			if (!string.Equals(_Telefono, value))
			{
				_Telefono = value;
			}
		}
	}

	[Column(Storage = "_Fax", DbType = "VarChar(15) NOT NULL", CanBeNull = false)]
	public string Fax
	{
		get
		{
			return _Fax;
		}
		set
		{
			if (!string.Equals(_Fax, value))
			{
				_Fax = value;
			}
		}
	}

	[Column(Storage = "_Email", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
	public string Email
	{
		get
		{
			return _Email;
		}
		set
		{
			if (!string.Equals(_Email, value))
			{
				_Email = value;
			}
		}
	}

	[Column(Storage = "_NumCelular", DbType = "VarChar(15) NOT NULL", CanBeNull = false)]
	public string NumCelular
	{
		get
		{
			return _NumCelular;
		}
		set
		{
			if (!string.Equals(_NumCelular, value))
			{
				_NumCelular = value;
			}
		}
	}
}
