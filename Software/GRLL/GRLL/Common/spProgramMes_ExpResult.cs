using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spProgramMes_ExpResult
{
	private int _IdObjetivo;

	private int _IdActividad;

	private int _IdMes;

	private decimal? _Programada;

	private decimal? _Ejecutada;

	private decimal? _Acumulada;

	[Column(Storage = "_IdObjetivo", DbType = "Int NOT NULL")]
	public int IdObjetivo
	{
		get
		{
			return _IdObjetivo;
		}
		set
		{
			if (_IdObjetivo != value)
			{
				_IdObjetivo = value;
			}
		}
	}

	[Column(Storage = "_IdActividad", DbType = "Int NOT NULL")]
	public int IdActividad
	{
		get
		{
			return _IdActividad;
		}
		set
		{
			if (_IdActividad != value)
			{
				_IdActividad = value;
			}
		}
	}

	[Column(Storage = "_IdMes", DbType = "Int NOT NULL")]
	public int IdMes
	{
		get
		{
			return _IdMes;
		}
		set
		{
			if (_IdMes != value)
			{
				_IdMes = value;
			}
		}
	}

	[Column(Storage = "_Programada", DbType = "Decimal(0,0)")]
	public decimal? Programada
	{
		get
		{
			return _Programada;
		}
		set
		{
			if (!_Programada.Equals(value))
			{
				_Programada = value;
			}
		}
	}

	[Column(Storage = "_Ejecutada", DbType = "Decimal(0,0)")]
	public decimal? Ejecutada
	{
		get
		{
			return _Ejecutada;
		}
		set
		{
			if (!_Ejecutada.Equals(value))
			{
				_Ejecutada = value;
			}
		}
	}

	[Column(Storage = "_Acumulada", DbType = "Decimal(0,0)")]
	public decimal? Acumulada
	{
		get
		{
			return _Acumulada;
		}
		set
		{
			if (!_Acumulada.Equals(value))
			{
				_Acumulada = value;
			}
		}
	}
}
