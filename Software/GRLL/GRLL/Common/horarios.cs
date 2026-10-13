using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.horarios")]
public class horarios
{
	private short _idHorario;

	private string _Ingreso1;

	private string _Salida1;

	private string _Ingreso2;

	private string _Salida2;

	private string _Descripcion;

	[Column(Storage = "_idHorario", DbType = "SmallInt NOT NULL")]
	public short idHorario
	{
		get
		{
			return _idHorario;
		}
		set
		{
			if (_idHorario != value)
			{
				_idHorario = value;
			}
		}
	}

	[Column(Storage = "_Ingreso1", DbType = "Char(5)")]
	public string Ingreso1
	{
		get
		{
			return _Ingreso1;
		}
		set
		{
			if (!string.Equals(_Ingreso1, value))
			{
				_Ingreso1 = value;
			}
		}
	}

	[Column(Storage = "_Salida1", DbType = "Char(5)")]
	public string Salida1
	{
		get
		{
			return _Salida1;
		}
		set
		{
			if (!string.Equals(_Salida1, value))
			{
				_Salida1 = value;
			}
		}
	}

	[Column(Storage = "_Ingreso2", DbType = "Char(5)")]
	public string Ingreso2
	{
		get
		{
			return _Ingreso2;
		}
		set
		{
			if (!string.Equals(_Ingreso2, value))
			{
				_Ingreso2 = value;
			}
		}
	}

	[Column(Storage = "_Salida2", DbType = "Char(5)")]
	public string Salida2
	{
		get
		{
			return _Salida2;
		}
		set
		{
			if (!string.Equals(_Salida2, value))
			{
				_Salida2 = value;
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(50)")]
	public string Descripcion
	{
		get
		{
			return _Descripcion;
		}
		set
		{
			if (!string.Equals(_Descripcion, value))
			{
				_Descripcion = value;
			}
		}
	}
}
