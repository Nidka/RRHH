using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spRRHH_Ficha_Det_FamiliarResult
{
	private int? _edadFamiliar;

	private string _NombresFamilia;

	private char? _FamSexo;

	private string _DescripTipoFam;

	private string _FamGradoInstruc;

	private string _DescripEstCivil;

	private bool? _ViveCasa;

	private bool? _LaboraInstitucion;

	[Column(Storage = "_edadFamiliar", DbType = "Int")]
	public int? edadFamiliar
	{
		get
		{
			return _edadFamiliar;
		}
		set
		{
			if (!_edadFamiliar.Equals(value))
			{
				_edadFamiliar = value;
			}
		}
	}

	[Column(Storage = "_NombresFamilia", DbType = "VarChar(162)")]
	public string NombresFamilia
	{
		get
		{
			return _NombresFamilia;
		}
		set
		{
			if (!string.Equals(_NombresFamilia, value))
			{
				_NombresFamilia = value;
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

	[Column(Storage = "_ViveCasa", DbType = "Bit")]
	public bool? ViveCasa
	{
		get
		{
			return _ViveCasa;
		}
		set
		{
			if (!_ViveCasa.Equals(value))
			{
				_ViveCasa = value;
			}
		}
	}

	[Column(Storage = "_LaboraInstitucion", DbType = "Bit")]
	public bool? LaboraInstitucion
	{
		get
		{
			return _LaboraInstitucion;
		}
		set
		{
			if (!_LaboraInstitucion.Equals(value))
			{
				_LaboraInstitucion = value;
			}
		}
	}
}
