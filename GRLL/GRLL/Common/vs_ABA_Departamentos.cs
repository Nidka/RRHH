using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.vs_ABA_Departamentos")]
public class vs_ABA_Departamentos
{
	private string _idUbigeo;

	private string _Departamento;

	private string _Descripcion;

	[Column(Storage = "_idUbigeo", DbType = "Char(6) NOT NULL", CanBeNull = false)]
	public string idUbigeo
	{
		get
		{
			return _idUbigeo;
		}
		set
		{
			if (!string.Equals(_idUbigeo, value))
			{
				_idUbigeo = value;
			}
		}
	}

	[Column(Storage = "_Departamento", DbType = "Char(2) NOT NULL", CanBeNull = false)]
	public string Departamento
	{
		get
		{
			return _Departamento;
		}
		set
		{
			if (!string.Equals(_Departamento, value))
			{
				_Departamento = value;
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(120)")]
	public string Descripcion
	{
		get
		{
			return _Descripcion;
		}
		set
		{
			if (!string.Equals(_Descripcion, value))
			{
				_Descripcion = value;
			}
		}
	}
}
