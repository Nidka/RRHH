using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spKM_GetPlayAvisoResult
{
	private string _Descripcion;

	private string _Duracion;

	private string _Formato;

	private int? _idVideo;

	private int _idReprod;

	private int? _OrdenReprod;

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

	[Column(Storage = "_idVideo", DbType = "Int")]
	public int? idVideo
	{
		get
		{
			return _idVideo;
		}
		set
		{
			if (!_idVideo.Equals(value))
			{
				_idVideo = value;
			}
		}
	}

	[Column(Storage = "_idReprod", DbType = "Int NOT NULL")]
	public int idReprod
	{
		get
		{
			return _idReprod;
		}
		set
		{
			if (_idReprod != value)
			{
				_idReprod = value;
			}
		}
	}

	[Column(Storage = "_OrdenReprod", DbType = "Int")]
	public int? OrdenReprod
	{
		get
		{
			return _OrdenReprod;
		}
		set
		{
			if (!_OrdenReprod.Equals(value))
			{
				_OrdenReprod = value;
			}
		}
	}
}
