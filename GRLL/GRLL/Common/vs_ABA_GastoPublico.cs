using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.vs_ABA_GastoPublico")]
public class vs_ABA_GastoPublico
{
	private string _IdGastoPublico;

	private string _Anio;

	private string _Descripcion;

	[Column(Storage = "_IdGastoPublico", DbType = "VarChar(17)")]
	public string IdGastoPublico
	{
		get
		{
			return _IdGastoPublico;
		}
		set
		{
			if (!string.Equals(_IdGastoPublico, value))
			{
				_IdGastoPublico = value;
			}
		}
	}

	[Column(Storage = "_Anio", DbType = "Char(5) NOT NULL", CanBeNull = false)]
	public string Anio
	{
		get
		{
			return _Anio;
		}
		set
		{
			if (!string.Equals(_Anio, value))
			{
				_Anio = value;
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(100)")]
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
