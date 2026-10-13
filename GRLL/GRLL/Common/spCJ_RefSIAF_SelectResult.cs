using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spCJ_RefSIAF_SelectResult
{
	private int _IdReferencia;

	private string _NroRef;

	private string _CPNro;

	private decimal _TotalCP;

	private int? _IdTipoMoneda;

	private string _TipoMoneda;

	private string _Moneda;

	[Column(Storage = "_IdReferencia", DbType = "Int NOT NULL")]
	public int IdReferencia
	{
		get
		{
			return _IdReferencia;
		}
		set
		{
			if (_IdReferencia != value)
			{
				_IdReferencia = value;
			}
		}
	}

	[Column(Storage = "_NroRef", DbType = "VarChar(25) NOT NULL", CanBeNull = false)]
	public string NroRef
	{
		get
		{
			return _NroRef;
		}
		set
		{
			if (!string.Equals(_NroRef, value))
			{
				_NroRef = value;
			}
		}
	}

	[Column(Storage = "_CPNro", DbType = "VarChar(25) NOT NULL", CanBeNull = false)]
	public string CPNro
	{
		get
		{
			return _CPNro;
		}
		set
		{
			if (!string.Equals(_CPNro, value))
			{
				_CPNro = value;
			}
		}
	}

	[Column(Storage = "_TotalCP", DbType = "Decimal(0,0) NOT NULL")]
	public decimal TotalCP
	{
		get
		{
			return _TotalCP;
		}
		set
		{
			if (decimal.Compare(_TotalCP, value) != 0)
			{
				_TotalCP = value;
			}
		}
	}

	[Column(Storage = "_IdTipoMoneda", DbType = "Int")]
	public int? IdTipoMoneda
	{
		get
		{
			return _IdTipoMoneda;
		}
		set
		{
			if (!_IdTipoMoneda.Equals(value))
			{
				_IdTipoMoneda = value;
			}
		}
	}

	[Column(Storage = "_TipoMoneda", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
	public string TipoMoneda
	{
		get
		{
			return _TipoMoneda;
		}
		set
		{
			if (!string.Equals(_TipoMoneda, value))
			{
				_TipoMoneda = value;
			}
		}
	}

	[Column(Storage = "_Moneda", DbType = "VarChar(5) NOT NULL", CanBeNull = false)]
	public string Moneda
	{
		get
		{
			return _Moneda;
		}
		set
		{
			if (!string.Equals(_Moneda, value))
			{
				_Moneda = value;
			}
		}
	}
}
