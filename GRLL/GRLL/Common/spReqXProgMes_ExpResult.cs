using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spReqXProgMes_ExpResult
{
	private int _IdObjetivo;

	private int _IdActividad;

	private int _IdMes;

	private string _IdBien;

	private decimal? _Cantidad;

	private string _IdUnidadMedida;

	private decimal? _CostoEstimado;

	private decimal? _CantidadConsumida;

	private decimal? _CostoReal;

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

	[Column(Storage = "_Cantidad", DbType = "Decimal(0,0)")]
	public decimal? Cantidad
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

	[Column(Storage = "_IdUnidadMedida", DbType = "Char(4)")]
	public string IdUnidadMedida
	{
		get
		{
			return _IdUnidadMedida;
		}
		set
		{
			if (!string.Equals(_IdUnidadMedida, value))
			{
				_IdUnidadMedida = value;
			}
		}
	}

	[Column(Storage = "_CostoEstimado", DbType = "Decimal(0,0)")]
	public decimal? CostoEstimado
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

	[Column(Storage = "_CantidadConsumida", DbType = "Decimal(0,0)")]
	public decimal? CantidadConsumida
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

	[Column(Storage = "_CostoReal", DbType = "Decimal(0,0)")]
	public decimal? CostoReal
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
}
