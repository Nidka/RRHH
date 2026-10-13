using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.VS_TRA_ACUERDO_ARTICULO")]
public class VS_TRA_ACUERDO_ARTICULO
{
	private string _Nro_Acuerdo;

	private string _Nro_Articulo;

	private string _Sumilla_Articulo;

	private string _Tramite;

	private string _Nro_Tramite;

	[Column(Storage = "_Nro_Acuerdo", DbType = "VarChar(10) NOT NULL", CanBeNull = false)]
	public string Nro_Acuerdo
	{
		get
		{
			return _Nro_Acuerdo;
		}
		set
		{
			if (!string.Equals(_Nro_Acuerdo, value))
			{
				_Nro_Acuerdo = value;
			}
		}
	}

	[Column(Storage = "_Nro_Articulo", DbType = "Char(2) NOT NULL", CanBeNull = false)]
	public string Nro_Articulo
	{
		get
		{
			return _Nro_Articulo;
		}
		set
		{
			if (!string.Equals(_Nro_Articulo, value))
			{
				_Nro_Articulo = value;
			}
		}
	}

	[Column(Storage = "_Sumilla_Articulo", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
	public string Sumilla_Articulo
	{
		get
		{
			return _Sumilla_Articulo;
		}
		set
		{
			if (!string.Equals(_Sumilla_Articulo, value))
			{
				_Sumilla_Articulo = value;
			}
		}
	}

	[Column(Storage = "_Tramite", DbType = "VarChar(2) NOT NULL", CanBeNull = false)]
	public string Tramite
	{
		get
		{
			return _Tramite;
		}
		set
		{
			if (!string.Equals(_Tramite, value))
			{
				_Tramite = value;
			}
		}
	}

	[Column(Storage = "_Nro_Tramite", DbType = "VarChar(10) NOT NULL", CanBeNull = false)]
	public string Nro_Tramite
	{
		get
		{
			return _Nro_Tramite;
		}
		set
		{
			if (!string.Equals(_Nro_Tramite, value))
			{
				_Nro_Tramite = value;
			}
		}
	}
}
