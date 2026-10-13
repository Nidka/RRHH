using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class Aba_Parametro_Periodo_ListarResult
{
	private string _idParametro;

	private string _Descripcion;

	private string _Valor;

	private string _periodo;

	[Column(Storage = "_idParametro", DbType = "Char(10) NOT NULL", CanBeNull = false)]
	public string idParametro
	{
		get
		{
			return _idParametro;
		}
		set
		{
			if (!string.Equals(_idParametro, value))
			{
				_idParametro = value;
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(50)")]
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

	[Column(Storage = "_Valor", DbType = "VarChar(120)")]
	public string Valor
	{
		get
		{
			return _Valor;
		}
		set
		{
			if (!string.Equals(_Valor, value))
			{
				_Valor = value;
			}
		}
	}

	[Column(Storage = "_periodo", DbType = "Char(6)")]
	public string periodo
	{
		get
		{
			return _periodo;
		}
		set
		{
			if (!string.Equals(_periodo, value))
			{
				_periodo = value;
			}
		}
	}
}
