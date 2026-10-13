using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.vs_ABA_ListarBienes")]
public class vs_ABA_ListarBienes
{
	private string _idbien;

	private string _descripcion;

	private string _observaciones;

	private char? _estado;

	private string _idunidadmedida;

	private string _desunidad;

	private string _desunidadcorta;

	private decimal _precioref;

	private string _idfamilia;

	private string _desfamilia;

	private string _idclase;

	private string _desclase;

	private string _idgrupo;

	private string _desgrupo;

	private char? _tipo;

	private DateTime? _fecharef;

	private char? _esactivofijo;

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

	[Column(Storage = "_observaciones", DbType = "VarChar(120) NOT NULL", CanBeNull = false)]
	public string observaciones
	{
		get
		{
			return _observaciones;
		}
		set
		{
			if (!string.Equals(_observaciones, value))
			{
				_observaciones = value;
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

	[Column(Storage = "_desunidadcorta", DbType = "Char(4)")]
	public string desunidadcorta
	{
		get
		{
			return _desunidadcorta;
		}
		set
		{
			if (!string.Equals(_desunidadcorta, value))
			{
				_desunidadcorta = value;
			}
		}
	}

	[Column(Storage = "_precioref", DbType = "Decimal(9,2) NOT NULL")]
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

	[Column(Storage = "_idfamilia", DbType = "Char(4)")]
	public string idfamilia
	{
		get
		{
			return _idfamilia;
		}
		set
		{
			if (!string.Equals(_idfamilia, value))
			{
				_idfamilia = value;
			}
		}
	}

	[Column(Storage = "_desfamilia", DbType = "VarChar(140)")]
	public string desfamilia
	{
		get
		{
			return _desfamilia;
		}
		set
		{
			if (!string.Equals(_desfamilia, value))
			{
				_desfamilia = value;
			}
		}
	}

	[Column(Storage = "_idclase", DbType = "Char(2)")]
	public string idclase
	{
		get
		{
			return _idclase;
		}
		set
		{
			if (!string.Equals(_idclase, value))
			{
				_idclase = value;
			}
		}
	}

	[Column(Storage = "_desclase", DbType = "VarChar(120)")]
	public string desclase
	{
		get
		{
			return _desclase;
		}
		set
		{
			if (!string.Equals(_desclase, value))
			{
				_desclase = value;
			}
		}
	}

	[Column(Storage = "_idgrupo", DbType = "Char(3)")]
	public string idgrupo
	{
		get
		{
			return _idgrupo;
		}
		set
		{
			if (!string.Equals(_idgrupo, value))
			{
				_idgrupo = value;
			}
		}
	}

	[Column(Storage = "_desgrupo", DbType = "VarChar(120)")]
	public string desgrupo
	{
		get
		{
			return _desgrupo;
		}
		set
		{
			if (!string.Equals(_desgrupo, value))
			{
				_desgrupo = value;
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

	[Column(Storage = "_fecharef", DbType = "DateTime")]
	public DateTime? fecharef
	{
		get
		{
			return _fecharef;
		}
		set
		{
			if (!_fecharef.Equals(value))
			{
				_fecharef = value;
			}
		}
	}

	[Column(Storage = "_esactivofijo", DbType = "Char(1)")]
	public char? esactivofijo
	{
		get
		{
			return _esactivofijo;
		}
		set
		{
			if (!_esactivofijo.Equals(value))
			{
				_esactivofijo = value;
			}
		}
	}
}
