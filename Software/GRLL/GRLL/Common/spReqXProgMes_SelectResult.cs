using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spReqXProgMes_SelectResult
{
	private int _IdObjetivo;

	private int _IdActividad;

	private int _IdMes;

	private string _IdBien;

	private string _Descripcion;

	private decimal _Cantidad;

	private decimal _CostoEstimado;

	private decimal _CantidadConsumida;

	private decimal _CostoReal;

	private string _IdUnidMed;

	private string _UM;

	private string _IdUnidadMedida;

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

	[Column(Storage = "_Descripcion", DbType = "VarChar(120)")]
	public string Descripcion
	{
		get
		{
			return _Descripcion;
		}
		set
		{
			if (!string.Equals(_Descripcion, value))
			{
				_Descripcion = value;
			}
		}
	}

	[Column(Storage = "_Cantidad", DbType = "Decimal(0,0) NOT NULL")]
	public decimal Cantidad
	{
		get
		{
			return _Cantidad;
		}
		set
		{
			if (decimal.Compare(_Cantidad, value) != 0)
			{
				_Cantidad = value;
			}
		}
	}

	[Column(Storage = "_CostoEstimado", DbType = "Decimal(0,0) NOT NULL")]
	public decimal CostoEstimado
	{
		get
		{
			return _CostoEstimado;
		}
		set
		{
			if (decimal.Compare(_CostoEstimado, value) != 0)
			{
				_CostoEstimado = value;
			}
		}
	}

	[Column(Storage = "_CantidadConsumida", DbType = "Decimal(0,0) NOT NULL")]
	public decimal CantidadConsumida
	{
		get
		{
			return _CantidadConsumida;
		}
		set
		{
			if (decimal.Compare(_CantidadConsumida, value) != 0)
			{
				_CantidadConsumida = value;
			}
		}
	}

	[Column(Storage = "_CostoReal", DbType = "Decimal(0,0) NOT NULL")]
	public decimal CostoReal
	{
		get
		{
			return _CostoReal;
		}
		set
		{
			if (decimal.Compare(_CostoReal, value) != 0)
			{
				_CostoReal = value;
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

	[Column(Storage = "_IdUnidadMedida", DbType = "Char(4) NOT NULL", CanBeNull = false)]
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
}
