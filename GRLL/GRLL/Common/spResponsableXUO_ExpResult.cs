using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spResponsableXUO_ExpResult
{
	private int _IdResponsable;

	private int? _Year;

	private int? _idAreaOrganiz;

	private string _AreaOrganizacional;

	private int? _idDependeDe;

	private int? _IdEmpleado;

	private string _F_Inicio;

	private string _F_Termino;

	[Column(Storage = "_IdResponsable", DbType = "Int NOT NULL")]
	public int IdResponsable
	{
		get
		{
			return _IdResponsable;
		}
		set
		{
			if (_IdResponsable != value)
			{
				_IdResponsable = value;
			}
		}
	}

	[Column(Storage = "_Year", DbType = "Int")]
	public int? Year
	{
		get
		{
			return _Year;
		}
		set
		{
			if (!_Year.Equals(value))
			{
				_Year = value;
			}
		}
	}

	[Column(Storage = "_idAreaOrganiz", DbType = "Int")]
	public int? idAreaOrganiz
	{
		get
		{
			return _idAreaOrganiz;
		}
		set
		{
			if (!_idAreaOrganiz.Equals(value))
			{
				_idAreaOrganiz = value;
			}
		}
	}

	[Column(Storage = "_AreaOrganizacional", DbType = "VarChar(80)")]
	public string AreaOrganizacional
	{
		get
		{
			return _AreaOrganizacional;
		}
		set
		{
			if (!string.Equals(_AreaOrganizacional, value))
			{
				_AreaOrganizacional = value;
			}
		}
	}

	[Column(Storage = "_idDependeDe", DbType = "Int")]
	public int? idDependeDe
	{
		get
		{
			return _idDependeDe;
		}
		set
		{
			if (!_idDependeDe.Equals(value))
			{
				_idDependeDe = value;
			}
		}
	}

	[Column(Storage = "_IdEmpleado", DbType = "Int")]
	public int? IdEmpleado
	{
		get
		{
			return _IdEmpleado;
		}
		set
		{
			if (!_IdEmpleado.Equals(value))
			{
				_IdEmpleado = value;
			}
		}
	}

	[Column(Storage = "_F_Inicio", DbType = "VarChar(8)")]
	public string F_Inicio
	{
		get
		{
			return _F_Inicio;
		}
		set
		{
			if (!string.Equals(_F_Inicio, value))
			{
				_F_Inicio = value;
			}
		}
	}

	[Column(Storage = "_F_Termino", DbType = "VarChar(8)")]
	public string F_Termino
	{
		get
		{
			return _F_Termino;
		}
		set
		{
			if (!string.Equals(_F_Termino, value))
			{
				_F_Termino = value;
			}
		}
	}
}
