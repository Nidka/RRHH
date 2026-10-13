using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spRRHH_ListarResolucionResult
{
	private string _DescripTipoResolucion;

	private DateTime? _FechaResolucion;

	private string _NumeroResolucion;

	private int _idResolucion;

	[Column(Storage = "_DescripTipoResolucion", DbType = "NVarChar(50)")]
	public string DescripTipoResolucion
	{
		get
		{
			return _DescripTipoResolucion;
		}
		set
		{
			if (!string.Equals(_DescripTipoResolucion, value))
			{
				_DescripTipoResolucion = value;
			}
		}
	}

	[Column(Storage = "_FechaResolucion", DbType = "Date")]
	public DateTime? FechaResolucion
	{
		get
		{
			return _FechaResolucion;
		}
		set
		{
			if (!_FechaResolucion.Equals(value))
			{
				_FechaResolucion = value;
			}
		}
	}

	[Column(Storage = "_NumeroResolucion", DbType = "NVarChar(50)")]
	public string NumeroResolucion
	{
		get
		{
			return _NumeroResolucion;
		}
		set
		{
			if (!string.Equals(_NumeroResolucion, value))
			{
				_NumeroResolucion = value;
			}
		}
	}

	[Column(Storage = "_idResolucion", DbType = "Int NOT NULL")]
	public int idResolucion
	{
		get
		{
			return _idResolucion;
		}
		set
		{
			if (_idResolucion != value)
			{
				_idResolucion = value;
			}
		}
	}
}
