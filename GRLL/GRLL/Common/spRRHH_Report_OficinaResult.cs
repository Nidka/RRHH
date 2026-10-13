using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spRRHH_Report_OficinaResult
{
	private int _idempleado;

	private int? _idpersona;

	private string _AreaOrganizacional;

	private string _NombresCompletos;

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

	[Column(Storage = "_AreaOrganizacional", DbType = "VarChar(200)")]
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

	[Column(Storage = "_NombresCompletos", DbType = "VarChar(162)")]
	public string NombresCompletos
	{
		get
		{
			return _NombresCompletos;
		}
		set
		{
			if (!string.Equals(_NombresCompletos, value))
			{
				_NombresCompletos = value;
			}
		}
	}
}
