using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class aba_sp_Procedimiento_ReqResult
{
	private string _idprocedimiento;

	private int _idrequisito;

	private string _descripcion;

	private int _CheckReq;

	[Column(Storage = "_idprocedimiento", DbType = "Char(6)")]
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

	[Column(Storage = "_CheckReq", DbType = "Int NOT NULL")]
	public int CheckReq
	{
		get
		{
			return _CheckReq;
		}
		set
		{
			if (_CheckReq != value)
			{
				_CheckReq = value;
			}
		}
	}
}
