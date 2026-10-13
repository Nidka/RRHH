using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spRRHH_Ficha_Det_Familiar_SaludResult
{
	private string _numdocid;

	private string _DescripTipoFam;

	private string _enfermedad;

	private string _tiempoenfermedad;

	private string _numautogensalud;

	private string _descripts;

	[Column(Storage = "_numdocid", DbType = "Char(12)")]
	public string numdocid
	{
		get
		{
			return _numdocid;
		}
		set
		{
			if (!string.Equals(_numdocid, value))
			{
				_numdocid = value;
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

	[Column(Storage = "_enfermedad", DbType = "VarChar(200)")]
	public string enfermedad
	{
		get
		{
			return _enfermedad;
		}
		set
		{
			if (!string.Equals(_enfermedad, value))
			{
				_enfermedad = value;
			}
		}
	}

	[Column(Storage = "_tiempoenfermedad", DbType = "VarChar(200)")]
	public string tiempoenfermedad
	{
		get
		{
			return _tiempoenfermedad;
		}
		set
		{
			if (!string.Equals(_tiempoenfermedad, value))
			{
				_tiempoenfermedad = value;
			}
		}
	}

	[Column(Storage = "_numautogensalud", DbType = "VarChar(15)")]
	public string numautogensalud
	{
		get
		{
			return _numautogensalud;
		}
		set
		{
			if (!string.Equals(_numautogensalud, value))
			{
				_numautogensalud = value;
			}
		}
	}

	[Column(Storage = "_descripts", DbType = "VarChar(5)")]
	public string descripts
	{
		get
		{
			return _descripts;
		}
		set
		{
			if (!string.Equals(_descripts, value))
			{
				_descripts = value;
			}
		}
	}
}
