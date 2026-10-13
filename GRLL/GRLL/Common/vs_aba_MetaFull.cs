using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.vs_aba_MetaFull")]
public class vs_aba_MetaFull
{
	private string _Anio;

	private string _IdMeta;

	private string _Descripcion;

	[Column(Storage = "_Anio", DbType = "Char(4) NOT NULL", CanBeNull = false)]
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

	[Column(Storage = "_IdMeta", DbType = "Char(6) NOT NULL", CanBeNull = false)]
	public string IdMeta
	{
		get
		{
			return _IdMeta;
		}
		set
		{
			if (!string.Equals(_IdMeta, value))
			{
				_IdMeta = value;
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(255)")]
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
