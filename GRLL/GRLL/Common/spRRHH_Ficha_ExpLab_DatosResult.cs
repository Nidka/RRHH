using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spRRHH_Ficha_ExpLab_DatosResult
{
	private string _AreaOrganizacional;

	private string _CondicionLab;

	private DateTime? _Fechaingreso;

	private DateTime? _FechaIngreEstado;

	private string _NumResoIngreEsta;

	private string _NumResoIngreInstitu;

	private string _NumResolCese;

	private DateTime? _FechaResolCese;

	private string _NumResol20530;

	private DateTime? _FechaResol20530;

	private string _NumResolPenMen;

	private DateTime? _FechaResolPenMen;

	private string _NumAutogenSalud;

	private string _LeyRegimen;

	private string _profesion;

	private string _cargo;

	private string _DescripAFP;

	private DateTime? _FechaAFP;

	private string _NroAFP;

	[Column(Storage = "_AreaOrganizacional", DbType = "VarChar(200) NOT NULL", CanBeNull = false)]
	public string AreaOrganizacional
	{
		get
		{
			return _AreaOrganizacional;
		}
		set
		{
			if (!string.Equals(_AreaOrganizacional, value))
			{
				_AreaOrganizacional = value;
			}
		}
	}

	[Column(Storage = "_CondicionLab", DbType = "VarChar(30)")]
	public string CondicionLab
	{
		get
		{
			return _CondicionLab;
		}
		set
		{
			if (!string.Equals(_CondicionLab, value))
			{
				_CondicionLab = value;
			}
		}
	}

	[Column(Storage = "_Fechaingreso", DbType = "SmallDateTime")]
	public DateTime? Fechaingreso
	{
		get
		{
			return _Fechaingreso;
		}
		set
		{
			if (!_Fechaingreso.Equals(value))
			{
				_Fechaingreso = value;
			}
		}
	}

	[Column(Storage = "_FechaIngreEstado", DbType = "DateTime")]
	public DateTime? FechaIngreEstado
	{
		get
		{
			return _FechaIngreEstado;
		}
		set
		{
			if (!_FechaIngreEstado.Equals(value))
			{
				_FechaIngreEstado = value;
			}
		}
	}

	[Column(Storage = "_NumResoIngreEsta", DbType = "VarChar(30)")]
	public string NumResoIngreEsta
	{
		get
		{
			return _NumResoIngreEsta;
		}
		set
		{
			if (!string.Equals(_NumResoIngreEsta, value))
			{
				_NumResoIngreEsta = value;
			}
		}
	}

	[Column(Storage = "_NumResoIngreInstitu", DbType = "VarChar(30)")]
	public string NumResoIngreInstitu
	{
		get
		{
			return _NumResoIngreInstitu;
		}
		set
		{
			if (!string.Equals(_NumResoIngreInstitu, value))
			{
				_NumResoIngreInstitu = value;
			}
		}
	}

	[Column(Storage = "_NumResolCese", DbType = "VarChar(20)")]
	public string NumResolCese
	{
		get
		{
			return _NumResolCese;
		}
		set
		{
			if (!string.Equals(_NumResolCese, value))
			{
				_NumResolCese = value;
			}
		}
	}

	[Column(Storage = "_FechaResolCese", DbType = "DateTime")]
	public DateTime? FechaResolCese
	{
		get
		{
			return _FechaResolCese;
		}
		set
		{
			if (!_FechaResolCese.Equals(value))
			{
				_FechaResolCese = value;
			}
		}
	}

	[Column(Storage = "_NumResol20530", DbType = "VarChar(20)")]
	public string NumResol20530
	{
		get
		{
			return _NumResol20530;
		}
		set
		{
			if (!string.Equals(_NumResol20530, value))
			{
				_NumResol20530 = value;
			}
		}
	}

	[Column(Storage = "_FechaResol20530", DbType = "DateTime")]
	public DateTime? FechaResol20530
	{
		get
		{
			return _FechaResol20530;
		}
		set
		{
			if (!_FechaResol20530.Equals(value))
			{
				_FechaResol20530 = value;
			}
		}
	}

	[Column(Storage = "_NumResolPenMen", DbType = "VarChar(20)")]
	public string NumResolPenMen
	{
		get
		{
			return _NumResolPenMen;
		}
		set
		{
			if (!string.Equals(_NumResolPenMen, value))
			{
				_NumResolPenMen = value;
			}
		}
	}

	[Column(Storage = "_FechaResolPenMen", DbType = "DateTime")]
	public DateTime? FechaResolPenMen
	{
		get
		{
			return _FechaResolPenMen;
		}
		set
		{
			if (!_FechaResolPenMen.Equals(value))
			{
				_FechaResolPenMen = value;
			}
		}
	}

	[Column(Storage = "_NumAutogenSalud", DbType = "VarChar(15)")]
	public string NumAutogenSalud
	{
		get
		{
			return _NumAutogenSalud;
		}
		set
		{
			if (!string.Equals(_NumAutogenSalud, value))
			{
				_NumAutogenSalud = value;
			}
		}
	}

	[Column(Storage = "_LeyRegimen", DbType = "VarChar(5)")]
	public string LeyRegimen
	{
		get
		{
			return _LeyRegimen;
		}
		set
		{
			if (!string.Equals(_LeyRegimen, value))
			{
				_LeyRegimen = value;
			}
		}
	}

	[Column(Storage = "_profesion", DbType = "VarChar(80)")]
	public string profesion
	{
		get
		{
			return _profesion;
		}
		set
		{
			if (!string.Equals(_profesion, value))
			{
				_profesion = value;
			}
		}
	}

	[Column(Storage = "_cargo", DbType = "VarChar(50)")]
	public string cargo
	{
		get
		{
			return _cargo;
		}
		set
		{
			if (!string.Equals(_cargo, value))
			{
				_cargo = value;
			}
		}
	}

	[Column(Storage = "_DescripAFP", DbType = "VarChar(50)")]
	public string DescripAFP
	{
		get
		{
			return _DescripAFP;
		}
		set
		{
			if (!string.Equals(_DescripAFP, value))
			{
				_DescripAFP = value;
			}
		}
	}

	[Column(Storage = "_FechaAFP", DbType = "DateTime")]
	public DateTime? FechaAFP
	{
		get
		{
			return _FechaAFP;
		}
		set
		{
			if (!_FechaAFP.Equals(value))
			{
				_FechaAFP = value;
			}
		}
	}

	[Column(Storage = "_NroAFP", DbType = "VarChar(20)")]
	public string NroAFP
	{
		get
		{
			return _NroAFP;
		}
		set
		{
			if (!string.Equals(_NroAFP, value))
			{
				_NroAFP = value;
			}
		}
	}
}
