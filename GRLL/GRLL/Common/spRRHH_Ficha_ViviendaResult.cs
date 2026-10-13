using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spRRHH_Ficha_ViviendaResult
{
	private string _DescripTenencia;

	private string _DescripTipo;

	private string _DescripMaterial;

	private string _DescripConserva;

	private string _NumDormitorio;

	private string _NumServHig;

	private string _DescripUbicacion;

	private string _DescripAlumbrado;

	private string _otroalumbrado;

	private string _descripAgua;

	private string _OtroAgua;

	private string _DescripExcretas;

	private string _OtroExcreta;

	private bool? _telefono;

	private bool? _cable;

	private bool? _internet;

	private bool? _otros;

	private string _NumCompart;

	private string _NumPerDorm;

	private string _observacion;

	[Column(Storage = "_DescripTenencia", DbType = "VarChar(30)")]
	public string DescripTenencia
	{
		get
		{
			return _DescripTenencia;
		}
		set
		{
			if (!string.Equals(_DescripTenencia, value))
			{
				_DescripTenencia = value;
			}
		}
	}

	[Column(Storage = "_DescripTipo", DbType = "VarChar(20)")]
	public string DescripTipo
	{
		get
		{
			return _DescripTipo;
		}
		set
		{
			if (!string.Equals(_DescripTipo, value))
			{
				_DescripTipo = value;
			}
		}
	}

	[Column(Storage = "_DescripMaterial", DbType = "VarChar(12)")]
	public string DescripMaterial
	{
		get
		{
			return _DescripMaterial;
		}
		set
		{
			if (!string.Equals(_DescripMaterial, value))
			{
				_DescripMaterial = value;
			}
		}
	}

	[Column(Storage = "_DescripConserva", DbType = "VarChar(17)")]
	public string DescripConserva
	{
		get
		{
			return _DescripConserva;
		}
		set
		{
			if (!string.Equals(_DescripConserva, value))
			{
				_DescripConserva = value;
			}
		}
	}

	[Column(Storage = "_NumDormitorio", DbType = "VarChar(2)")]
	public string NumDormitorio
	{
		get
		{
			return _NumDormitorio;
		}
		set
		{
			if (!string.Equals(_NumDormitorio, value))
			{
				_NumDormitorio = value;
			}
		}
	}

	[Column(Storage = "_NumServHig", DbType = "VarChar(2)")]
	public string NumServHig
	{
		get
		{
			return _NumServHig;
		}
		set
		{
			if (!string.Equals(_NumServHig, value))
			{
				_NumServHig = value;
			}
		}
	}

	[Column(Storage = "_DescripUbicacion", DbType = "VarChar(22)")]
	public string DescripUbicacion
	{
		get
		{
			return _DescripUbicacion;
		}
		set
		{
			if (!string.Equals(_DescripUbicacion, value))
			{
				_DescripUbicacion = value;
			}
		}
	}

	[Column(Storage = "_DescripAlumbrado", DbType = "VarChar(20)")]
	public string DescripAlumbrado
	{
		get
		{
			return _DescripAlumbrado;
		}
		set
		{
			if (!string.Equals(_DescripAlumbrado, value))
			{
				_DescripAlumbrado = value;
			}
		}
	}

	[Column(Storage = "_otroalumbrado", DbType = "VarChar(50)")]
	public string otroalumbrado
	{
		get
		{
			return _otroalumbrado;
		}
		set
		{
			if (!string.Equals(_otroalumbrado, value))
			{
				_otroalumbrado = value;
			}
		}
	}

	[Column(Storage = "_descripAgua", DbType = "VarChar(33)")]
	public string descripAgua
	{
		get
		{
			return _descripAgua;
		}
		set
		{
			if (!string.Equals(_descripAgua, value))
			{
				_descripAgua = value;
			}
		}
	}

	[Column(Storage = "_OtroAgua", DbType = "VarChar(50)")]
	public string OtroAgua
	{
		get
		{
			return _OtroAgua;
		}
		set
		{
			if (!string.Equals(_OtroAgua, value))
			{
				_OtroAgua = value;
			}
		}
	}

	[Column(Storage = "_DescripExcretas", DbType = "VarChar(33)")]
	public string DescripExcretas
	{
		get
		{
			return _DescripExcretas;
		}
		set
		{
			if (!string.Equals(_DescripExcretas, value))
			{
				_DescripExcretas = value;
			}
		}
	}

	[Column(Storage = "_OtroExcreta", DbType = "VarChar(50)")]
	public string OtroExcreta
	{
		get
		{
			return _OtroExcreta;
		}
		set
		{
			if (!string.Equals(_OtroExcreta, value))
			{
				_OtroExcreta = value;
			}
		}
	}

	[Column(Storage = "_telefono", DbType = "Bit")]
	public bool? telefono
	{
		get
		{
			return _telefono;
		}
		set
		{
			if (!_telefono.Equals(value))
			{
				_telefono = value;
			}
		}
	}

	[Column(Storage = "_cable", DbType = "Bit")]
	public bool? cable
	{
		get
		{
			return _cable;
		}
		set
		{
			if (!_cable.Equals(value))
			{
				_cable = value;
			}
		}
	}

	[Column(Storage = "_internet", DbType = "Bit")]
	public bool? internet
	{
		get
		{
			return _internet;
		}
		set
		{
			if (!_internet.Equals(value))
			{
				_internet = value;
			}
		}
	}

	[Column(Storage = "_otros", DbType = "Bit")]
	public bool? otros
	{
		get
		{
			return _otros;
		}
		set
		{
			if (!_otros.Equals(value))
			{
				_otros = value;
			}
		}
	}

	[Column(Storage = "_NumCompart", DbType = "VarChar(2)")]
	public string NumCompart
	{
		get
		{
			return _NumCompart;
		}
		set
		{
			if (!string.Equals(_NumCompart, value))
			{
				_NumCompart = value;
			}
		}
	}

	[Column(Storage = "_NumPerDorm", DbType = "VarChar(2)")]
	public string NumPerDorm
	{
		get
		{
			return _NumPerDorm;
		}
		set
		{
			if (!string.Equals(_NumPerDorm, value))
			{
				_NumPerDorm = value;
			}
		}
	}

	[Column(Storage = "_observacion", DbType = "VarChar(200)")]
	public string observacion
	{
		get
		{
			return _observacion;
		}
		set
		{
			if (!string.Equals(_observacion, value))
			{
				_observacion = value;
			}
		}
	}
}
