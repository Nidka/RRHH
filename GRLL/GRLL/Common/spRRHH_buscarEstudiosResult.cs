using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spRRHH_buscarEstudiosResult
{
	private string _DescripTipoEst;

	private string _CentroEstudios;

	private DateTime? _Añoinicio;

	private DateTime? _Añotermino;

	private string _DescripEstadoEstudio;

	private int _IdEmpleado;

	private int _IdTipoEstudios;

	[Column(Storage = "_DescripTipoEst", DbType = "VarChar(15)")]
	public string DescripTipoEst
	{
		get
		{
			return _DescripTipoEst;
		}
		set
		{
			if (!string.Equals(_DescripTipoEst, value))
			{
				_DescripTipoEst = value;
			}
		}
	}

	[Column(Storage = "_CentroEstudios", DbType = "VarChar(150)")]
	public string CentroEstudios
	{
		get
		{
			return _CentroEstudios;
		}
		set
		{
			if (!string.Equals(_CentroEstudios, value))
			{
				_CentroEstudios = value;
			}
		}
	}

	[Column(Storage = "_Añoinicio", DbType = "DateTime")]
	public DateTime? Añoinicio
	{
		get
		{
			return _Añoinicio;
		}
		set
		{
			if (!_Añoinicio.Equals(value))
			{
				_Añoinicio = value;
			}
		}
	}

	[Column(Storage = "_Añotermino", DbType = "DateTime")]
	public DateTime? Añotermino
	{
		get
		{
			return _Añotermino;
		}
		set
		{
			if (!_Añotermino.Equals(value))
			{
				_Añotermino = value;
			}
		}
	}

	[Column(Storage = "_DescripEstadoEstudio", DbType = "VarChar(10)")]
	public string DescripEstadoEstudio
	{
		get
		{
			return _DescripEstadoEstudio;
		}
		set
		{
			if (!string.Equals(_DescripEstadoEstudio, value))
			{
				_DescripEstadoEstudio = value;
			}
		}
	}

	[Column(Storage = "_IdEmpleado", DbType = "Int NOT NULL")]
	public int IdEmpleado
	{
		get
		{
			return _IdEmpleado;
		}
		set
		{
			if (_IdEmpleado != value)
			{
				_IdEmpleado = value;
			}
		}
	}

	[Column(Storage = "_IdTipoEstudios", DbType = "Int NOT NULL")]
	public int IdTipoEstudios
	{
		get
		{
			return _IdTipoEstudios;
		}
		set
		{
			if (_IdTipoEstudios != value)
			{
				_IdTipoEstudios = value;
			}
		}
	}
}
