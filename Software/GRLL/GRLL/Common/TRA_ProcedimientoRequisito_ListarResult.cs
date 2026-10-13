using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class TRA_ProcedimientoRequisito_ListarResult
{
	private int _idrequisito;

	private string _descripcion;

	private string _idprocedimiento;

	private int _asignado;

	[Column(Storage = "_idrequisito", DbType = "Int NOT NULL")]
	public int idrequisito
	{
		get
		{
			return _idrequisito;
		}
		set
		{
			if (_idrequisito != value)
			{
				_idrequisito = value;
			}
		}
	}

	[Column(Storage = "_descripcion", DbType = "VarChar(100)")]
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

	[Column(Storage = "_idprocedimiento", DbType = "Char(20)")]
	public string idprocedimiento
	{
		get
		{
			return _idprocedimiento;
		}
		set
		{
			if (!string.Equals(_idprocedimiento, value))
			{
				_idprocedimiento = value;
			}
		}
	}

	[Column(Storage = "_asignado", DbType = "Int NOT NULL")]
	public int asignado
	{
		get
		{
			return _asignado;
		}
		set
		{
			if (_asignado != value)
			{
				_asignado = value;
			}
		}
	}
}
