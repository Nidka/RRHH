using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spRRHH_RepAsisdiarriaResult
{
	private string _nombres;

	private string _HoraE;

	private string _HoraS;

	private string _FechaAsistencia;

	[Column(Storage = "_nombres", DbType = "VarChar(162)")]
	public string nombres
	{
		get
		{
			return _nombres;
		}
		set
		{
			if (!string.Equals(_nombres, value))
			{
				_nombres = value;
			}
		}
	}

	[Column(Storage = "_HoraE", DbType = "NVarChar(8) NOT NULL", CanBeNull = false)]
	public string HoraE
	{
		get
		{
			return _HoraE;
		}
		set
		{
			if (!string.Equals(_HoraE, value))
			{
				_HoraE = value;
			}
		}
	}

	[Column(Storage = "_HoraS", DbType = "NVarChar(8) NOT NULL", CanBeNull = false)]
	public string HoraS
	{
		get
		{
			return _HoraS;
		}
		set
		{
			if (!string.Equals(_HoraS, value))
			{
				_HoraS = value;
			}
		}
	}

	[Column(Storage = "_FechaAsistencia", DbType = "NVarChar(10)")]
	public string FechaAsistencia
	{
		get
		{
			return _FechaAsistencia;
		}
		set
		{
			if (!string.Equals(_FechaAsistencia, value))
			{
				_FechaAsistencia = value;
			}
		}
	}
}
