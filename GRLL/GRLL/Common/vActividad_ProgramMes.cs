using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.vActividad_ProgramMes")]
public class vActividad_ProgramMes
{
	private int _IdObjetivo;

	private int _IdActividad;

	private int _IdMes;

	private string _IdsA;

	private string _IdsP;

	private string _Mes;

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

	[Column(Storage = "_IdsA", DbType = "VarChar(21)")]
	public string IdsA
	{
		get
		{
			return _IdsA;
		}
		set
		{
			if (!string.Equals(_IdsA, value))
			{
				_IdsA = value;
			}
		}
	}

	[Column(Storage = "_IdsP", DbType = "VarChar(32)")]
	public string IdsP
	{
		get
		{
			return _IdsP;
		}
		set
		{
			if (!string.Equals(_IdsP, value))
			{
				_IdsP = value;
			}
		}
	}

	[Column(Storage = "_Mes", DbType = "VarChar(9)")]
	public string Mes
	{
		get
		{
			return _Mes;
		}
		set
		{
			if (!string.Equals(_Mes, value))
			{
				_Mes = value;
			}
		}
	}
}
