using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.vs_ABA_Distritos")]
public class vs_ABA_Distritos
{
	private string _IdUbigeo;

	private string _departamento;

	private string _desdepartamento;

	private string _provincia;

	private string _desprovincia;

	private string _distrito;

	private string _desdistrito;

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

	[Column(Storage = "_departamento", DbType = "Char(2) NOT NULL", CanBeNull = false)]
	public string departamento
	{
		get
		{
			return _departamento;
		}
		set
		{
			if (!string.Equals(_departamento, value))
			{
				_departamento = value;
			}
		}
	}

	[Column(Storage = "_desdepartamento", DbType = "VarChar(120)")]
	public string desdepartamento
	{
		get
		{
			return _desdepartamento;
		}
		set
		{
			if (!string.Equals(_desdepartamento, value))
			{
				_desdepartamento = value;
			}
		}
	}

	[Column(Storage = "_provincia", DbType = "Char(2) NOT NULL", CanBeNull = false)]
	public string provincia
	{
		get
		{
			return _provincia;
		}
		set
		{
			if (!string.Equals(_provincia, value))
			{
				_provincia = value;
			}
		}
	}

	[Column(Storage = "_desprovincia", DbType = "VarChar(120)")]
	public string desprovincia
	{
		get
		{
			return _desprovincia;
		}
		set
		{
			if (!string.Equals(_desprovincia, value))
			{
				_desprovincia = value;
			}
		}
	}

	[Column(Storage = "_distrito", DbType = "Char(2) NOT NULL", CanBeNull = false)]
	public string distrito
	{
		get
		{
			return _distrito;
		}
		set
		{
			if (!string.Equals(_distrito, value))
			{
				_distrito = value;
			}
		}
	}

	[Column(Storage = "_desdistrito", DbType = "VarChar(120)")]
	public string desdistrito
	{
		get
		{
			return _desdistrito;
		}
		set
		{
			if (!string.Equals(_desdistrito, value))
			{
				_desdistrito = value;
			}
		}
	}
}
