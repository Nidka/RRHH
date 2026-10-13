using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spRRHH_getMotivo_permResult
{
	private int _idMotivo;

	private string _Descrip_Motivo;

	private bool? _Salario;

	private string _Abrev;

	private int? _idTipoPermiso;

	private string _DescripTipoPermiso;

	[Column(Storage = "_idMotivo", DbType = "Int NOT NULL")]
	public int idMotivo
	{
		get
		{
			return _idMotivo;
		}
		set
		{
			if (_idMotivo != value)
			{
				_idMotivo = value;
			}
		}
	}

	[Column(Storage = "_Descrip_Motivo", DbType = "VarChar(50)")]
	public string Descrip_Motivo
	{
		get
		{
			return _Descrip_Motivo;
		}
		set
		{
			if (!string.Equals(_Descrip_Motivo, value))
			{
				_Descrip_Motivo = value;
			}
		}
	}

	[Column(Storage = "_Salario", DbType = "Bit")]
	public bool? Salario
	{
		get
		{
			return _Salario;
		}
		set
		{
			if (!_Salario.Equals(value))
			{
				_Salario = value;
			}
		}
	}

	[Column(Storage = "_Abrev", DbType = "Char(2)")]
	public string Abrev
	{
		get
		{
			return _Abrev;
		}
		set
		{
			if (!string.Equals(_Abrev, value))
			{
				_Abrev = value;
			}
		}
	}

	[Column(Storage = "_idTipoPermiso", DbType = "Int")]
	public int? idTipoPermiso
	{
		get
		{
			return _idTipoPermiso;
		}
		set
		{
			if (!_idTipoPermiso.Equals(value))
			{
				_idTipoPermiso = value;
			}
		}
	}

	[Column(Storage = "_DescripTipoPermiso", DbType = "VarChar(50)")]
	public string DescripTipoPermiso
	{
		get
		{
			return _DescripTipoPermiso;
		}
		set
		{
			if (!string.Equals(_DescripTipoPermiso, value))
			{
				_DescripTipoPermiso = value;
			}
		}
	}
}
