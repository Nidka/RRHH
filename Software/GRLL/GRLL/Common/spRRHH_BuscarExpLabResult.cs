using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spRRHH_BuscarExpLabResult
{
	private string _DescripTipoInstitucion;

	private string _NomInstitucion;

	private string _Cargo;

	private DateTime? _FechaIngreso;

	private DateTime? _FechaEgreso;

	private string _unidadOrganica;

	private int _idEmpleado;

	private int _idExpLab;

	[Column(Storage = "_DescripTipoInstitucion", DbType = "VarChar(15)")]
	public string DescripTipoInstitucion
	{
		get
		{
			return _DescripTipoInstitucion;
		}
		set
		{
			if (!string.Equals(_DescripTipoInstitucion, value))
			{
				_DescripTipoInstitucion = value;
			}
		}
	}

	[Column(Storage = "_NomInstitucion", DbType = "VarChar(120)")]
	public string NomInstitucion
	{
		get
		{
			return _NomInstitucion;
		}
		set
		{
			if (!string.Equals(_NomInstitucion, value))
			{
				_NomInstitucion = value;
			}
		}
	}

	[Column(Storage = "_Cargo", DbType = "VarChar(40)")]
	public string Cargo
	{
		get
		{
			return _Cargo;
		}
		set
		{
			if (!string.Equals(_Cargo, value))
			{
				_Cargo = value;
			}
		}
	}

	[Column(Storage = "_FechaIngreso", DbType = "DateTime")]
	public DateTime? FechaIngreso
	{
		get
		{
			return _FechaIngreso;
		}
		set
		{
			if (!_FechaIngreso.Equals(value))
			{
				_FechaIngreso = value;
			}
		}
	}

	[Column(Storage = "_FechaEgreso", DbType = "DateTime")]
	public DateTime? FechaEgreso
	{
		get
		{
			return _FechaEgreso;
		}
		set
		{
			if (!_FechaEgreso.Equals(value))
			{
				_FechaEgreso = value;
			}
		}
	}

	[Column(Storage = "_unidadOrganica", DbType = "VarChar(100)")]
	public string unidadOrganica
	{
		get
		{
			return _unidadOrganica;
		}
		set
		{
			if (!string.Equals(_unidadOrganica, value))
			{
				_unidadOrganica = value;
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

	[Column(Storage = "_idExpLab", DbType = "Int NOT NULL")]
	public int idExpLab
	{
		get
		{
			return _idExpLab;
		}
		set
		{
			if (_idExpLab != value)
			{
				_idExpLab = value;
			}
		}
	}
}
