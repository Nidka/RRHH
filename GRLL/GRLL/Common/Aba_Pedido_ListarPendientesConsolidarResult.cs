using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class Aba_Pedido_ListarPendientesConsolidarResult
{
	private char? _tipo;

	private string _idpedido;

	private DateTime? _fecha;

	private decimal? _montopedido;

	private string _desarea;

	private int? _idareaorganiz;

	[Column(Storage = "_tipo", DbType = "Char(1)")]
	public char? tipo
	{
		get
		{
			return _tipo;
		}
		set
		{
			if (!_tipo.Equals(value))
			{
				_tipo = value;
			}
		}
	}

	[Column(Storage = "_idpedido", DbType = "Char(6) NOT NULL", CanBeNull = false)]
	public string idpedido
	{
		get
		{
			return _idpedido;
		}
		set
		{
			if (!string.Equals(_idpedido, value))
			{
				_idpedido = value;
			}
		}
	}

	[Column(Storage = "_fecha", DbType = "DateTime")]
	public DateTime? fecha
	{
		get
		{
			return _fecha;
		}
		set
		{
			if (!_fecha.Equals(value))
			{
				_fecha = value;
			}
		}
	}

	[Column(Storage = "_montopedido", DbType = "Decimal(0,0)")]
	public decimal? montopedido
	{
		get
		{
			return _montopedido;
		}
		set
		{
			if (!_montopedido.Equals(value))
			{
				_montopedido = value;
			}
		}
	}

	[Column(Storage = "_desarea", DbType = "VarChar(200)")]
	public string desarea
	{
		get
		{
			return _desarea;
		}
		set
		{
			if (!string.Equals(_desarea, value))
			{
				_desarea = value;
			}
		}
	}

	[Column(Storage = "_idareaorganiz", DbType = "Int")]
	public int? idareaorganiz
	{
		get
		{
			return _idareaorganiz;
		}
		set
		{
			if (!_idareaorganiz.Equals(value))
			{
				_idareaorganiz = value;
			}
		}
	}
}
