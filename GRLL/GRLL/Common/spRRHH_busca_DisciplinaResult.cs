using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spRRHH_busca_DisciplinaResult
{
	private int _idComportamiento;

	private DateTime? _Fecha;

	private int? _idEmpleado;

	private string _NumResol;

	private string _Titulo;

	private string _Descripcion;

	private string _TipoCompDescrip;

	[Column(Storage = "_idComportamiento", DbType = "Int NOT NULL")]
	public int idComportamiento
	{
		get
		{
			return _idComportamiento;
		}
		set
		{
			if (_idComportamiento != value)
			{
				_idComportamiento = value;
			}
		}
	}

	[Column(Storage = "_Fecha", DbType = "DateTime")]
	public DateTime? Fecha
	{
		get
		{
			return _Fecha;
		}
		set
		{
			if (!_Fecha.Equals(value))
			{
				_Fecha = value;
			}
		}
	}

	[Column(Storage = "_idEmpleado", DbType = "Int")]
	public int? idEmpleado
	{
		get
		{
			return _idEmpleado;
		}
		set
		{
			if (!_idEmpleado.Equals(value))
			{
				_idEmpleado = value;
			}
		}
	}

	[Column(Storage = "_NumResol", DbType = "VarChar(200)")]
	public string NumResol
	{
		get
		{
			return _NumResol;
		}
		set
		{
			if (!string.Equals(_NumResol, value))
			{
				_NumResol = value;
			}
		}
	}

	[Column(Storage = "_Titulo", DbType = "VarChar(1000)")]
	public string Titulo
	{
		get
		{
			return _Titulo;
		}
		set
		{
			if (!string.Equals(_Titulo, value))
			{
				_Titulo = value;
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(2000)")]
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

	[Column(Storage = "_TipoCompDescrip", DbType = "VarChar(8)")]
	public string TipoCompDescrip
	{
		get
		{
			return _TipoCompDescrip;
		}
		set
		{
			if (!string.Equals(_TipoCompDescrip, value))
			{
				_TipoCompDescrip = value;
			}
		}
	}
}
