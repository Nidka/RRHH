using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class p_ObjetivoActividadResult
{
	private string _Objetivo;

	private string _actividad;

	private int? _importancia;

	[Column(Storage = "_Objetivo", DbType = "VarChar(500)")]
	public string Objetivo
	{
		get
		{
			return _Objetivo;
		}
		set
		{
			if (!string.Equals(_Objetivo, value))
			{
				_Objetivo = value;
			}
		}
	}

	[Column(Storage = "_actividad", DbType = "VarChar(300)")]
	public string actividad
	{
		get
		{
			return _actividad;
		}
		set
		{
			if (!string.Equals(_actividad, value))
			{
				_actividad = value;
			}
		}
	}

	[Column(Storage = "_importancia", DbType = "Int")]
	public int? importancia
	{
		get
		{
			return _importancia;
		}
		set
		{
			if (!_importancia.Equals(value))
			{
				_importancia = value;
			}
		}
	}
}
