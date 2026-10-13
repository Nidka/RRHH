using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.vs_ABA_Ubigeo")]
public class vs_ABA_Ubigeo
{
	private string _IdUbigeo;

	private string _departamento;

	private string _provincia;

	private string _distrito;

	private string _descripcion;

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
}
