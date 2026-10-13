using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.vs_ABA_UnidadEquivalencia")]
public class vs_ABA_UnidadEquivalencia
{
	private string _idbien;

	private string _idunidadmedida;

	private string _desunidadmedida;

	private string _desabrev;

	private decimal? _Equivalencia;

	private decimal? _PrecioRef;

	private decimal? _Precio;

	[Column(Storage = "_idbien", DbType = "Char(13) NOT NULL", CanBeNull = false)]
	public string idbien
	{
		get
		{
			return _idbien;
		}
		set
		{
			if (!string.Equals(_idbien, value))
			{
				_idbien = value;
			}
		}
	}

	[Column(Storage = "_idunidadmedida", DbType = "Char(4) NOT NULL", CanBeNull = false)]
	public string idunidadmedida
	{
		get
		{
			return _idunidadmedida;
		}
		set
		{
			if (!string.Equals(_idunidadmedida, value))
			{
				_idunidadmedida = value;
			}
		}
	}

	[Column(Storage = "_desunidadmedida", DbType = "VarChar(30)")]
	public string desunidadmedida
	{
		get
		{
			return _desunidadmedida;
		}
		set
		{
			if (!string.Equals(_desunidadmedida, value))
			{
				_desunidadmedida = value;
			}
		}
	}

	[Column(Storage = "_desabrev", DbType = "Char(4)")]
	public string desabrev
	{
		get
		{
			return _desabrev;
		}
		set
		{
			if (!string.Equals(_desabrev, value))
			{
				_desabrev = value;
			}
		}
	}

	[Column(Storage = "_Equivalencia", DbType = "Decimal(18,2)")]
	public decimal? Equivalencia
	{
		get
		{
			return _Equivalencia;
		}
		set
		{
			if (!_Equivalencia.Equals(value))
			{
				_Equivalencia = value;
			}
		}
	}

	[Column(Storage = "_PrecioRef", DbType = "Decimal(9,2)")]
	public decimal? PrecioRef
	{
		get
		{
			return _PrecioRef;
		}
		set
		{
			if (!_PrecioRef.Equals(value))
			{
				_PrecioRef = value;
			}
		}
	}

	[Column(Storage = "_Precio", DbType = "Decimal(11,4)")]
	public decimal? Precio
	{
		get
		{
			return _Precio;
		}
		set
		{
			if (!_Precio.Equals(value))
			{
				_Precio = value;
			}
		}
	}
}
