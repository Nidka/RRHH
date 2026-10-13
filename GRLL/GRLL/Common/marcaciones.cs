using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.marcaciones")]
public class marcaciones
{
	private DateTime _Fecha;

	private string _Valor;

	private string _Estado;

	private char? _Proceso;

	[Column(Storage = "_Fecha", DbType = "DateTime NOT NULL")]
	public DateTime Fecha
	{
		get
		{
			return _Fecha;
		}
		set
		{
			if (DateTime.Compare(_Fecha, value) != 0)
			{
				_Fecha = value;
			}
		}
	}

	[Column(Storage = "_Valor", DbType = "VarChar(15) NOT NULL", CanBeNull = false)]
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

	[Column(Storage = "_Estado", DbType = "Char(2)")]
	public string Estado
	{
		get
		{
			return _Estado;
		}
		set
		{
			if (!string.Equals(_Estado, value))
			{
				_Estado = value;
			}
		}
	}

	[Column(Storage = "_Proceso", DbType = "Char(1)")]
	public char? Proceso
	{
		get
		{
			return _Proceso;
		}
		set
		{
			if (!_Proceso.Equals(value))
			{
				_Proceso = value;
			}
		}
	}
}
