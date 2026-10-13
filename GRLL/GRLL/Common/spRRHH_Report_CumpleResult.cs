using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spRRHH_Report_CumpleResult
{
	private int? _edadEmpleado;

	private string _NombresCompletos;

	private string _AreaOrganizacional;

	private char? _Estado;

	private int? _Dia;

	private int? _mes;

	private string _MESletras;

	[Column(Storage = "_edadEmpleado", DbType = "Int")]
	public int? edadEmpleado
	{
		get
		{
			return _edadEmpleado;
		}
		set
		{
			if (!_edadEmpleado.Equals(value))
			{
				_edadEmpleado = value;
			}
		}
	}

	[Column(Storage = "_NombresCompletos", DbType = "VarChar(162)")]
	public string NombresCompletos
	{
		get
		{
			return _NombresCompletos;
		}
		set
		{
			if (!string.Equals(_NombresCompletos, value))
			{
				_NombresCompletos = value;
			}
		}
	}

	[Column(Storage = "_AreaOrganizacional", DbType = "VarChar(200) NOT NULL", CanBeNull = false)]
	public string AreaOrganizacional
	{
		get
		{
			return _AreaOrganizacional;
		}
		set
		{
			if (!string.Equals(_AreaOrganizacional, value))
			{
				_AreaOrganizacional = value;
			}
		}
	}

	[Column(Storage = "_Estado", DbType = "Char(1)")]
	public char? Estado
	{
		get
		{
			return _Estado;
		}
		set
		{
			if (!_Estado.Equals(value))
			{
				_Estado = value;
			}
		}
	}

	[Column(Storage = "_Dia", DbType = "Int")]
	public int? Dia
	{
		get
		{
			return _Dia;
		}
		set
		{
			if (!_Dia.Equals(value))
			{
				_Dia = value;
			}
		}
	}

	[Column(Storage = "_mes", DbType = "Int")]
	public int? mes
	{
		get
		{
			return _mes;
		}
		set
		{
			if (!_mes.Equals(value))
			{
				_mes = value;
			}
		}
	}

	[Column(Storage = "_MESletras", DbType = "VarChar(10)")]
	public string MESletras
	{
		get
		{
			return _MESletras;
		}
		set
		{
			if (!string.Equals(_MESletras, value))
			{
				_MESletras = value;
			}
		}
	}
}
