using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class Aba_Bien_ListarNoAlmacenResult
{
	private string _idbien;

	private string _descripcion;

	private char? _estado;

	private string _idunidadmedida;

	private string _desunidad;

	private decimal _precioref;

	private char? _tipo;

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

	[Column(Storage = "_descripcion", DbType = "VarChar(120)")]
	public string descripcion
	{
		get
		{
			return _descripcion;
		}
		set
		{
			if (!string.Equals(_descripcion, value))
			{
				_descripcion = value;
			}
		}
	}

	[Column(Storage = "_estado", DbType = "Char(1)")]
	public char? estado
	{
		get
		{
			return _estado;
		}
		set
		{
			if (!_estado.Equals(value))
			{
				_estado = value;
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

	[Column(Storage = "_desunidad", DbType = "VarChar(30)")]
	public string desunidad
	{
		get
		{
			return _desunidad;
		}
		set
		{
			if (!string.Equals(_desunidad, value))
			{
				_desunidad = value;
			}
		}
	}

	[Column(Storage = "_precioref", DbType = "Decimal(0,0) NOT NULL")]
	public decimal precioref
	{
		get
		{
			return _precioref;
		}
		set
		{
			if (decimal.Compare(_precioref, value) != 0)
			{
				_precioref = value;
			}
		}
	}

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
}
