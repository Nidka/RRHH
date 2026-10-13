using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spRRHH_GetRecordAsistenciasSemanalesResult
{
	private int _IdEmpleado;

	private string _NombresCompletos;

	private int? _Semana;

	private string _HorasTrabajadas;

	private string _InicioSemana;

	private string _FinSemana;

	[Column(Storage = "_IdEmpleado", DbType = "Int NOT NULL")]
	public int IdEmpleado
	{
		get
		{
			return _IdEmpleado;
		}
		set
		{
			if (_IdEmpleado != value)
			{
				_IdEmpleado = value;
			}
		}
	}

	[Column(Storage = "_NombresCompletos", DbType = "VarChar(164)")]
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

	[Column(Storage = "_Semana", DbType = "Int")]
	public int? Semana
	{
		get
		{
			return _Semana;
		}
		set
		{
			if (!_Semana.Equals(value))
			{
				_Semana = value;
			}
		}
	}

	[Column(Storage = "_HorasTrabajadas", DbType = "VarChar(5)")]
	public string HorasTrabajadas
	{
		get
		{
			return _HorasTrabajadas;
		}
		set
		{
			if (!string.Equals(_HorasTrabajadas, value))
			{
				_HorasTrabajadas = value;
			}
		}
	}

	[Column(Storage = "_InicioSemana", DbType = "Char(10)")]
	public string InicioSemana
	{
		get
		{
			return _InicioSemana;
		}
		set
		{
			if (!string.Equals(_InicioSemana, value))
			{
				_InicioSemana = value;
			}
		}
	}

	[Column(Storage = "_FinSemana", DbType = "Char(10)")]
	public string FinSemana
	{
		get
		{
			return _FinSemana;
		}
		set
		{
			if (!string.Equals(_FinSemana, value))
			{
				_FinSemana = value;
			}
		}
	}
}
