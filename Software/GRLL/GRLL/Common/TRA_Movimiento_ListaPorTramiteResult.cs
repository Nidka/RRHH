using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class TRA_Movimiento_ListaPorTramiteResult
{
	private string _desetapa;

	private string _desareaingreso;

	private string _estado;

	private DateTime? _fechaingreso;

	private DateTime? _fechasalida;

	private string _cargo;

	[Column(Storage = "_desetapa", DbType = "VarChar(400)")]
	public string desetapa
	{
		get
		{
			return _desetapa;
		}
		set
		{
			if (!string.Equals(_desetapa, value))
			{
				_desetapa = value;
			}
		}
	}

	[Column(Storage = "_desareaingreso", DbType = "VarChar(200) NOT NULL", CanBeNull = false)]
	public string desareaingreso
	{
		get
		{
			return _desareaingreso;
		}
		set
		{
			if (!string.Equals(_desareaingreso, value))
			{
				_desareaingreso = value;
			}
		}
	}

	[Column(Storage = "_estado", DbType = "Char(2)")]
	public string estado
	{
		get
		{
			return _estado;
		}
		set
		{
			if (!string.Equals(_estado, value))
			{
				_estado = value;
			}
		}
	}

	[Column(Storage = "_fechaingreso", DbType = "DateTime")]
	public DateTime? fechaingreso
	{
		get
		{
			return _fechaingreso;
		}
		set
		{
			if (!_fechaingreso.Equals(value))
			{
				_fechaingreso = value;
			}
		}
	}

	[Column(Storage = "_fechasalida", DbType = "DateTime")]
	public DateTime? fechasalida
	{
		get
		{
			return _fechasalida;
		}
		set
		{
			if (!_fechasalida.Equals(value))
			{
				_fechasalida = value;
			}
		}
	}

	[Column(Storage = "_cargo", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
	public string cargo
	{
		get
		{
			return _cargo;
		}
		set
		{
			if (!string.Equals(_cargo, value))
			{
				_cargo = value;
			}
		}
	}
}
