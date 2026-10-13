using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spRRHH_busca_archivosResult
{
	private string _DescripDocumento;

	private int _idEmpleado;

	private int _idDocumento;

	private DateTime? _FechaIngreDoc;

	private DateTime? _FechaVenDoc;

	private string _NumRef;

	private string _Obs;

	[Column(Storage = "_DescripDocumento", DbType = "VarChar(50)")]
	public string DescripDocumento
	{
		get
		{
			return _DescripDocumento;
		}
		set
		{
			if (!string.Equals(_DescripDocumento, value))
			{
				_DescripDocumento = value;
			}
		}
	}

	[Column(Storage = "_idEmpleado", DbType = "Int NOT NULL")]
	public int idEmpleado
	{
		get
		{
			return _idEmpleado;
		}
		set
		{
			if (_idEmpleado != value)
			{
				_idEmpleado = value;
			}
		}
	}

	[Column(Storage = "_idDocumento", DbType = "Int NOT NULL")]
	public int idDocumento
	{
		get
		{
			return _idDocumento;
		}
		set
		{
			if (_idDocumento != value)
			{
				_idDocumento = value;
			}
		}
	}

	[Column(Storage = "_FechaIngreDoc", DbType = "DateTime")]
	public DateTime? FechaIngreDoc
	{
		get
		{
			return _FechaIngreDoc;
		}
		set
		{
			if (!_FechaIngreDoc.Equals(value))
			{
				_FechaIngreDoc = value;
			}
		}
	}

	[Column(Storage = "_FechaVenDoc", DbType = "DateTime")]
	public DateTime? FechaVenDoc
	{
		get
		{
			return _FechaVenDoc;
		}
		set
		{
			if (!_FechaVenDoc.Equals(value))
			{
				_FechaVenDoc = value;
			}
		}
	}

	[Column(Storage = "_NumRef", DbType = "VarChar(20)")]
	public string NumRef
	{
		get
		{
			return _NumRef;
		}
		set
		{
			if (!string.Equals(_NumRef, value))
			{
				_NumRef = value;
			}
		}
	}

	[Column(Storage = "_Obs", DbType = "VarChar(120)")]
	public string Obs
	{
		get
		{
			return _Obs;
		}
		set
		{
			if (!string.Equals(_Obs, value))
			{
				_Obs = value;
			}
		}
	}
}
