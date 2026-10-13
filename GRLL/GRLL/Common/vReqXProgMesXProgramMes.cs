using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.vReqXProgMesXProgramMes")]
public class vReqXProgMesXProgramMes
{
	private int _IdObjetivo;

	private int _IdActividad;

	private int _IdMes;

	private string _Mes;

	private string _IdBien;

	private string _Bien;

	private int? _Cantidad;

	private int? _CostoEstimado;

	private int? _CantidadConsumida;

	private int? _CostoReal;

	private string _IdsA;

	private string _IdsP;

	private string _IdUnidMed;

	private string _UM;

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

	[Column(Storage = "_IdBien", DbType = "Char(13) NOT NULL", CanBeNull = false)]
	public string IdBien
	{
		get
		{
			return _IdBien;
		}
		set
		{
			if (!string.Equals(_IdBien, value))
			{
				_IdBien = value;
			}
		}
	}

	[Column(Storage = "_Bien", DbType = "VarChar(120)")]
	public string Bien
	{
		get
		{
			return _Bien;
		}
		set
		{
			if (!string.Equals(_Bien, value))
			{
				_Bien = value;
			}
		}
	}

	[Column(Storage = "_Cantidad", DbType = "Int")]
	public int? Cantidad
	{
		get
		{
			return _Cantidad;
		}
		set
		{
			if (!_Cantidad.Equals(value))
			{
				_Cantidad = value;
			}
		}
	}

	[Column(Storage = "_CostoEstimado", DbType = "Int")]
	public int? CostoEstimado
	{
		get
		{
			return _CostoEstimado;
		}
		set
		{
			if (!_CostoEstimado.Equals(value))
			{
				_CostoEstimado = value;
			}
		}
	}

	[Column(Storage = "_CantidadConsumida", DbType = "Int")]
	public int? CantidadConsumida
	{
		get
		{
			return _CantidadConsumida;
		}
		set
		{
			if (!_CantidadConsumida.Equals(value))
			{
				_CantidadConsumida = value;
			}
		}
	}

	[Column(Storage = "_CostoReal", DbType = "Int")]
	public int? CostoReal
	{
		get
		{
			return _CostoReal;
		}
		set
		{
			if (!_CostoReal.Equals(value))
			{
				_CostoReal = value;
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

	[Column(Storage = "_IdUnidMed", DbType = "Char(4) NOT NULL", CanBeNull = false)]
	public string IdUnidMed
	{
		get
		{
			return _IdUnidMed;
		}
		set
		{
			if (!string.Equals(_IdUnidMed, value))
			{
				_IdUnidMed = value;
			}
		}
	}

	[Column(Storage = "_UM", DbType = "Char(4) NOT NULL", CanBeNull = false)]
	public string UM
	{
		get
		{
			return _UM;
		}
		set
		{
			if (!string.Equals(_UM, value))
			{
				_UM = value;
			}
		}
	}
}
