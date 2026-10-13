using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.vs_RRHH_FamFicha")]
public class vs_RRHH_FamFicha
{
	private int? _edadFam;

	private string _NombresFam;

	private char? _FamSexo;

	private string _DescripEstCivil;

	private string _DescripTipoFam;

	private string _FamGradoInstruc;

	private bool? _vivecasa;

	private int _CodEmpleFAm;

	[Column(Storage = "_edadFam", DbType = "Int")]
	public int? edadFam
	{
		get
		{
			return _edadFam;
		}
		set
		{
			if (!_edadFam.Equals(value))
			{
				_edadFam = value;
			}
		}
	}

	[Column(Storage = "_NombresFam", DbType = "VarChar(162)")]
	public string NombresFam
	{
		get
		{
			return _NombresFam;
		}
		set
		{
			if (!string.Equals(_NombresFam, value))
			{
				_NombresFam = value;
			}
		}
	}

	[Column(Storage = "_FamSexo", DbType = "Char(1)")]
	public char? FamSexo
	{
		get
		{
			return _FamSexo;
		}
		set
		{
			if (!_FamSexo.Equals(value))
			{
				_FamSexo = value;
			}
		}
	}

	[Column(Storage = "_DescripEstCivil", DbType = "VarChar(11)")]
	public string DescripEstCivil
	{
		get
		{
			return _DescripEstCivil;
		}
		set
		{
			if (!string.Equals(_DescripEstCivil, value))
			{
				_DescripEstCivil = value;
			}
		}
	}

	[Column(Storage = "_DescripTipoFam", DbType = "VarChar(10)")]
	public string DescripTipoFam
	{
		get
		{
			return _DescripTipoFam;
		}
		set
		{
			if (!string.Equals(_DescripTipoFam, value))
			{
				_DescripTipoFam = value;
			}
		}
	}

	[Column(Storage = "_FamGradoInstruc", DbType = "VarChar(15)")]
	public string FamGradoInstruc
	{
		get
		{
			return _FamGradoInstruc;
		}
		set
		{
			if (!string.Equals(_FamGradoInstruc, value))
			{
				_FamGradoInstruc = value;
			}
		}
	}

	[Column(Storage = "_vivecasa", DbType = "Bit")]
	public bool? vivecasa
	{
		get
		{
			return _vivecasa;
		}
		set
		{
			if (!_vivecasa.Equals(value))
			{
				_vivecasa = value;
			}
		}
	}

	[Column(Storage = "_CodEmpleFAm", DbType = "Int NOT NULL")]
	public int CodEmpleFAm
	{
		get
		{
			return _CodEmpleFAm;
		}
		set
		{
			if (_CodEmpleFAm != value)
			{
				_CodEmpleFAm = value;
			}
		}
	}
}
