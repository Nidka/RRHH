using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spRRHH_BuscarFamiliaresResult
{
	private int _Idpersona;

	private string _NombresCompletos;

	private DateTime? _fechaNacimiento;

	private char? _famSexo;

	private string _DescripTipoFam;

	private string _famgradoInstruc;

	private string _descripestcivil;

	private bool? _vivecasa;

	private bool? _laborainstitucion;

	[Column(Storage = "_Idpersona", DbType = "Int NOT NULL")]
	public int Idpersona
	{
		get
		{
			return _Idpersona;
		}
		set
		{
			if (_Idpersona != value)
			{
				_Idpersona = value;
			}
		}
	}

	[Column(Storage = "_NombresCompletos", DbType = "VarChar(162)")]
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

	[Column(Storage = "_fechaNacimiento", DbType = "DateTime")]
	public DateTime? fechaNacimiento
	{
		get
		{
			return _fechaNacimiento;
		}
		set
		{
			if (!_fechaNacimiento.Equals(value))
			{
				_fechaNacimiento = value;
			}
		}
	}

	[Column(Storage = "_famSexo", DbType = "Char(1)")]
	public char? famSexo
	{
		get
		{
			return _famSexo;
		}
		set
		{
			if (!_famSexo.Equals(value))
			{
				_famSexo = value;
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

	[Column(Storage = "_famgradoInstruc", DbType = "VarChar(15)")]
	public string famgradoInstruc
	{
		get
		{
			return _famgradoInstruc;
		}
		set
		{
			if (!string.Equals(_famgradoInstruc, value))
			{
				_famgradoInstruc = value;
			}
		}
	}

	[Column(Storage = "_descripestcivil", DbType = "VarChar(11)")]
	public string descripestcivil
	{
		get
		{
			return _descripestcivil;
		}
		set
		{
			if (!string.Equals(_descripestcivil, value))
			{
				_descripestcivil = value;
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

	[Column(Storage = "_laborainstitucion", DbType = "Bit")]
	public bool? laborainstitucion
	{
		get
		{
			return _laborainstitucion;
		}
		set
		{
			if (!_laborainstitucion.Equals(value))
			{
				_laborainstitucion = value;
			}
		}
	}
}
