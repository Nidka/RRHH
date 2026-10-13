using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spKM_GetVideoListResult
{
	private int _idVideo;

	private string _Ruta;

	private string _Descripcion;

	private string _Duracion;

	private string _Formato;

	[Column(Storage = "_idVideo", DbType = "Int NOT NULL")]
	public int idVideo
	{
		get
		{
			return _idVideo;
		}
		set
		{
			if (_idVideo != value)
			{
				_idVideo = value;
			}
		}
	}

	[Column(Storage = "_Ruta", DbType = "VarChar(2000)")]
	public string Ruta
	{
		get
		{
			return _Ruta;
		}
		set
		{
			if (!string.Equals(_Ruta, value))
			{
				_Ruta = value;
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

	[Column(Storage = "_Duracion", DbType = "VarChar(8)")]
	public string Duracion
	{
		get
		{
			return _Duracion;
		}
		set
		{
			if (!string.Equals(_Duracion, value))
			{
				_Duracion = value;
			}
		}
	}

	[Column(Storage = "_Formato", DbType = "VarChar(5)")]
	public string Formato
	{
		get
		{
			return _Formato;
		}
		set
		{
			if (!string.Equals(_Formato, value))
			{
				_Formato = value;
			}
		}
	}
}
