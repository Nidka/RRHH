using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spKM_repTotalAtendidosResult
{
	private DateTime _fecha;

	private string _TipoOperacion;

	private int _Atendidos;

	private int _Noatendidos;

	[Column(Storage = "_fecha", DbType = "DateTime NOT NULL")]
	public DateTime fecha
	{
		get
		{
			return _fecha;
		}
		set
		{
			if (DateTime.Compare(_fecha, value) != 0)
			{
				_fecha = value;
			}
		}
	}

	[Column(Storage = "_TipoOperacion", DbType = "VarChar(100) NOT NULL", CanBeNull = false)]
	public string TipoOperacion
	{
		get
		{
			return _TipoOperacion;
		}
		set
		{
			if (!string.Equals(_TipoOperacion, value))
			{
				_TipoOperacion = value;
			}
		}
	}

	[Column(Storage = "_Atendidos", DbType = "Int NOT NULL")]
	public int Atendidos
	{
		get
		{
			return _Atendidos;
		}
		set
		{
			if (_Atendidos != value)
			{
				_Atendidos = value;
			}
		}
	}

	[Column(Storage = "_Noatendidos", DbType = "Int NOT NULL")]
	public int Noatendidos
	{
		get
		{
			return _Noatendidos;
		}
		set
		{
			if (_Noatendidos != value)
			{
				_Noatendidos = value;
			}
		}
	}
}
