using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class Aba_Almacen_ListarResult
{
	private string _idalmacen;

	private string _descripcion;

	private string _direccion;

	private int? _responsable;

	private string _desresponsable;

	[Column(Storage = "_idalmacen", DbType = "Char(2) NOT NULL", CanBeNull = false)]
	public string idalmacen
	{
		get
		{
			return _idalmacen;
		}
		set
		{
			if (!string.Equals(_idalmacen, value))
			{
				_idalmacen = value;
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

	[Column(Storage = "_direccion", DbType = "VarChar(80)")]
	public string direccion
	{
		get
		{
			return _direccion;
		}
		set
		{
			if (!string.Equals(_direccion, value))
			{
				_direccion = value;
			}
		}
	}

	[Column(Storage = "_responsable", DbType = "Int")]
	public int? responsable
	{
		get
		{
			return _responsable;
		}
		set
		{
			if (!_responsable.Equals(value))
			{
				_responsable = value;
			}
		}
	}

	[Column(Storage = "_desresponsable", DbType = "VarChar(162)")]
	public string desresponsable
	{
		get
		{
			return _desresponsable;
		}
		set
		{
			if (!string.Equals(_desresponsable, value))
			{
				_desresponsable = value;
			}
		}
	}
}
