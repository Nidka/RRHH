using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class ABa_Meta_Area_ListarResult
{
	private int _anio;

	private int _idareaorganiz;

	private string _areaorganizacional;

	private bool? _valido;

	private int? _iddependede;

	[Column(Storage = "_anio", DbType = "Int NOT NULL")]
	public int anio
	{
		get
		{
			return _anio;
		}
		set
		{
			if (_anio != value)
			{
				_anio = value;
			}
		}
	}

	[Column(Storage = "_idareaorganiz", DbType = "Int NOT NULL")]
	public int idareaorganiz
	{
		get
		{
			return _idareaorganiz;
		}
		set
		{
			if (_idareaorganiz != value)
			{
				_idareaorganiz = value;
			}
		}
	}

	[Column(Storage = "_areaorganizacional", DbType = "VarChar(200)")]
	public string areaorganizacional
	{
		get
		{
			return _areaorganizacional;
		}
		set
		{
			if (!string.Equals(_areaorganizacional, value))
			{
				_areaorganizacional = value;
			}
		}
	}

	[Column(Storage = "_valido", DbType = "Bit")]
	public bool? valido
	{
		get
		{
			return _valido;
		}
		set
		{
			if (!_valido.Equals(value))
			{
				_valido = value;
			}
		}
	}

	[Column(Storage = "_iddependede", DbType = "Int")]
	public int? iddependede
	{
		get
		{
			return _iddependede;
		}
		set
		{
			if (!_iddependede.Equals(value))
			{
				_iddependede = value;
			}
		}
	}
}
