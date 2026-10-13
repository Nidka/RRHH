using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class Aba_Contrato_ListarPorConsolidadoResult
{
	private string _ruc;

	private string _idcontrato;

	private string _desproveedor;

	private string _idconsolidado;

	[Column(Storage = "_ruc", DbType = "Char(11)")]
	public string ruc
	{
		get
		{
			return _ruc;
		}
		set
		{
			if (!string.Equals(_ruc, value))
			{
				_ruc = value;
			}
		}
	}

	[Column(Storage = "_idcontrato", DbType = "Char(8) NOT NULL", CanBeNull = false)]
	public string idcontrato
	{
		get
		{
			return _idcontrato;
		}
		set
		{
			if (!string.Equals(_idcontrato, value))
			{
				_idcontrato = value;
			}
		}
	}

	[Column(Storage = "_desproveedor", DbType = "VarChar(100)")]
	public string desproveedor
	{
		get
		{
			return _desproveedor;
		}
		set
		{
			if (!string.Equals(_desproveedor, value))
			{
				_desproveedor = value;
			}
		}
	}

	[Column(Storage = "_idconsolidado", DbType = "Char(6) NOT NULL", CanBeNull = false)]
	public string idconsolidado
	{
		get
		{
			return _idconsolidado;
		}
		set
		{
			if (!string.Equals(_idconsolidado, value))
			{
				_idconsolidado = value;
			}
		}
	}
}
