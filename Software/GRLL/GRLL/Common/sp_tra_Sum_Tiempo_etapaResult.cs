using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class sp_tra_Sum_Tiempo_etapaResult
{
	private int? _tiempoDias;

	private int? _tiempoHrs;

	private int? _TiempoMin;

	[Column(Storage = "_tiempoDias", DbType = "Int")]
	public int? tiempoDias
	{
		get
		{
			return _tiempoDias;
		}
		set
		{
			if (!_tiempoDias.Equals(value))
			{
				_tiempoDias = value;
			}
		}
	}

	[Column(Storage = "_tiempoHrs", DbType = "Int")]
	public int? tiempoHrs
	{
		get
		{
			return _tiempoHrs;
		}
		set
		{
			if (!_tiempoHrs.Equals(value))
			{
				_tiempoHrs = value;
			}
		}
	}

	[Column(Storage = "_TiempoMin", DbType = "Int")]
	public int? TiempoMin
	{
		get
		{
			return _TiempoMin;
		}
		set
		{
			if (!_TiempoMin.Equals(value))
			{
				_TiempoMin = value;
			}
		}
	}
}
