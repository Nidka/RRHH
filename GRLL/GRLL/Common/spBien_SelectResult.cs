using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spBien_SelectResult
{
	private string _IdBien;

	private string _Descripcion;

	private string _Observaciones;

	private char _Estado;

	private string _IdUnidadMedida;

	private decimal _PrecioRef;

	private string _FechaRef;

	private string _IdFamilia;

	private string _IdClase;

	private string _IdGrupo;

	private char _Tipo;

	private string _Unidad;

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

	[Column(Storage = "_Descripcion", DbType = "VarChar(120) NOT NULL", CanBeNull = false)]
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

	[Column(Storage = "_Observaciones", DbType = "VarChar(120) NOT NULL", CanBeNull = false)]
	public string Observaciones
	{
		get
		{
			return _Observaciones;
		}
		set
		{
			if (!string.Equals(_Observaciones, value))
			{
				_Observaciones = value;
			}
		}
	}

	[Column(Storage = "_Estado", DbType = "Char(1) NOT NULL")]
	public char Estado
	{
		get
		{
			return _Estado;
		}
		set
		{
			if (_Estado != value)
			{
				_Estado = value;
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

	[Column(Storage = "_PrecioRef", DbType = "Decimal(0,0) NOT NULL")]
	public decimal PrecioRef
	{
		get
		{
			return _PrecioRef;
		}
		set
		{
			if (decimal.Compare(_PrecioRef, value) != 0)
			{
				_PrecioRef = value;
			}
		}
	}

	[Column(Storage = "_FechaRef", DbType = "VarChar(8)")]
	public string FechaRef
	{
		get
		{
			return _FechaRef;
		}
		set
		{
			if (!string.Equals(_FechaRef, value))
			{
				_FechaRef = value;
			}
		}
	}

	[Column(Storage = "_IdFamilia", DbType = "Char(4) NOT NULL", CanBeNull = false)]
	public string IdFamilia
	{
		get
		{
			return _IdFamilia;
		}
		set
		{
			if (!string.Equals(_IdFamilia, value))
			{
				_IdFamilia = value;
			}
		}
	}

	[Column(Storage = "_IdClase", DbType = "Char(2) NOT NULL", CanBeNull = false)]
	public string IdClase
	{
		get
		{
			return _IdClase;
		}
		set
		{
			if (!string.Equals(_IdClase, value))
			{
				_IdClase = value;
			}
		}
	}

	[Column(Storage = "_IdGrupo", DbType = "Char(3) NOT NULL", CanBeNull = false)]
	public string IdGrupo
	{
		get
		{
			return _IdGrupo;
		}
		set
		{
			if (!string.Equals(_IdGrupo, value))
			{
				_IdGrupo = value;
			}
		}
	}

	[Column(Storage = "_Tipo", DbType = "Char(1) NOT NULL")]
	public char Tipo
	{
		get
		{
			return _Tipo;
		}
		set
		{
			if (_Tipo != value)
			{
				_Tipo = value;
			}
		}
	}

	[Column(Storage = "_Unidad", DbType = "Char(4) NOT NULL", CanBeNull = false)]
	public string Unidad
	{
		get
		{
			return _Unidad;
		}
		set
		{
			if (!string.Equals(_Unidad, value))
			{
				_Unidad = value;
			}
		}
	}
}
