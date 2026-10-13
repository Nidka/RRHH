using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spEstrategia_ExpResult
{
	private int _idAreaOrganiz;

	private int _Year;

	private int _IdEstrategia;

	private string _Estrategia;

	private string _FechaInicio;

	private string _FechaCulminacion;

	private int? _IdPresupuesto;

	[Column(Storage = "_idAreaOrganiz", DbType = "Int NOT NULL")]
	public int idAreaOrganiz
	{
		get
		{
			return _idAreaOrganiz;
		}
		set
		{
			if (_idAreaOrganiz != value)
			{
				_idAreaOrganiz = value;
			}
		}
	}

	[Column(Storage = "_Year", DbType = "Int NOT NULL")]
	public int Year
	{
		get
		{
			return _Year;
		}
		set
		{
			if (_Year != value)
			{
				_Year = value;
			}
		}
	}

	[Column(Storage = "_IdEstrategia", DbType = "Int NOT NULL")]
	public int IdEstrategia
	{
		get
		{
			return _IdEstrategia;
		}
		set
		{
			if (_IdEstrategia != value)
			{
				_IdEstrategia = value;
			}
		}
	}

	[Column(Storage = "_Estrategia", DbType = "VarChar(500) NOT NULL", CanBeNull = false)]
	public string Estrategia
	{
		get
		{
			return _Estrategia;
		}
		set
		{
			if (!string.Equals(_Estrategia, value))
			{
				_Estrategia = value;
			}
		}
	}

	[Column(Storage = "_FechaInicio", DbType = "VarChar(8)")]
	public string FechaInicio
	{
		get
		{
			return _FechaInicio;
		}
		set
		{
			if (!string.Equals(_FechaInicio, value))
			{
				_FechaInicio = value;
			}
		}
	}

	[Column(Storage = "_FechaCulminacion", DbType = "VarChar(8)")]
	public string FechaCulminacion
	{
		get
		{
			return _FechaCulminacion;
		}
		set
		{
			if (!string.Equals(_FechaCulminacion, value))
			{
				_FechaCulminacion = value;
			}
		}
	}

	[Column(Storage = "_IdPresupuesto", DbType = "Int")]
	public int? IdPresupuesto
	{
		get
		{
			return _IdPresupuesto;
		}
		set
		{
			if (!_IdPresupuesto.Equals(value))
			{
				_IdPresupuesto = value;
			}
		}
	}
}
