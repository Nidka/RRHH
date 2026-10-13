using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spKM_ReportPersAtendxCajResult
{
	private string _Fecha;

	private string _atendidopor;

	private int? _cantidad;

	[Column(Storage = "_Fecha", DbType = "VarChar(10)")]
	public string Fecha
	{
		get
		{
			return _Fecha;
		}
		set
		{
			if (!string.Equals(_Fecha, value))
			{
				_Fecha = value;
			}
		}
	}

	[Column(Storage = "_atendidopor", DbType = "VarChar(20)")]
	public string atendidopor
	{
		get
		{
			return _atendidopor;
		}
		set
		{
			if (!string.Equals(_atendidopor, value))
			{
				_atendidopor = value;
			}
		}
	}

	[Column(Storage = "_cantidad", DbType = "Int")]
	public int? cantidad
	{
		get
		{
			return _cantidad;
		}
		set
		{
			if (!_cantidad.Equals(value))
			{
				_cantidad = value;
			}
		}
	}
}
