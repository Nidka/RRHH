using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spRRHH_Ficha_Estudio_RealizadoResult
{
	private string _DescripTipoEst;

	private string _CentroEstudios;

	private DateTime? _AñoInicio;

	private DateTime? _Añotermino;

	private string _DescripEstadoEstudio;

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

	[Column(Storage = "_AñoInicio", DbType = "DateTime")]
	public DateTime? AñoInicio
	{
		get
		{
			return _AñoInicio;
		}
		set
		{
			if (!_AñoInicio.Equals(value))
			{
				_AñoInicio = value;
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
}
