using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spCJR_llenarDictamenesResult
{
	private int? _idTipoProyec;

	private string _NumProyecto;

	private string _NumDictamen;

	private DateTime? _FechaDictamen;

	private bool? _Aprobado;

	private string _AprobacionDescrip;

	[Column(Storage = "_idTipoProyec", DbType = "Int")]
	public int? idTipoProyec
	{
		get
		{
			return _idTipoProyec;
		}
		set
		{
			if (!_idTipoProyec.Equals(value))
			{
				_idTipoProyec = value;
			}
		}
	}

	[Column(Storage = "_NumProyecto", DbType = "VarChar(120)")]
	public string NumProyecto
	{
		get
		{
			return _NumProyecto;
		}
		set
		{
			if (!string.Equals(_NumProyecto, value))
			{
				_NumProyecto = value;
			}
		}
	}

	[Column(Storage = "_NumDictamen", DbType = "VarChar(120) NOT NULL", CanBeNull = false)]
	public string NumDictamen
	{
		get
		{
			return _NumDictamen;
		}
		set
		{
			if (!string.Equals(_NumDictamen, value))
			{
				_NumDictamen = value;
			}
		}
	}

	[Column(Storage = "_FechaDictamen", DbType = "DateTime")]
	public DateTime? FechaDictamen
	{
		get
		{
			return _FechaDictamen;
		}
		set
		{
			if (!_FechaDictamen.Equals(value))
			{
				_FechaDictamen = value;
			}
		}
	}

	[Column(Storage = "_Aprobado", DbType = "Bit")]
	public bool? Aprobado
	{
		get
		{
			return _Aprobado;
		}
		set
		{
			if (!_Aprobado.Equals(value))
			{
				_Aprobado = value;
			}
		}
	}

	[Column(Storage = "_AprobacionDescrip", DbType = "VarChar(20)")]
	public string AprobacionDescrip
	{
		get
		{
			return _AprobacionDescrip;
		}
		set
		{
			if (!string.Equals(_AprobacionDescrip, value))
			{
				_AprobacionDescrip = value;
			}
		}
	}
}
