using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spRRHH_GetMinTardeResult
{
	private int _IdEmpleado;

	private string _Tarde;

	private int? _DiasTarde;

	[Column(Storage = "_IdEmpleado", DbType = "Int NOT NULL")]
	public int IdEmpleado
	{
		get
		{
			return _IdEmpleado;
		}
		set
		{
			if (_IdEmpleado != value)
			{
				_IdEmpleado = value;
			}
		}
	}

	[Column(Storage = "_Tarde", DbType = "VarChar(5)")]
	public string Tarde
	{
		get
		{
			return _Tarde;
		}
		set
		{
			if (!string.Equals(_Tarde, value))
			{
				_Tarde = value;
			}
		}
	}

	[Column(Storage = "_DiasTarde", DbType = "Int")]
	public int? DiasTarde
	{
		get
		{
			return _DiasTarde;
		}
		set
		{
			if (!_DiasTarde.Equals(value))
			{
				_DiasTarde = value;
			}
		}
	}
}
