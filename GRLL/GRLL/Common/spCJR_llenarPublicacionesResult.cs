using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spCJR_llenarPublicacionesResult
{
	private int _idtiponorma;

	private string _descriptiponorma;

	private string _NumOrdenanza;

	private int _idtipomedio;

	private string _TipoMedioDescrip;

	private string _NombreMedio;

	private DateTime? _FechaPublicacion;

	private string _Paginas;

	[Column(Storage = "_idtiponorma", DbType = "Int NOT NULL")]
	public int idtiponorma
	{
		get
		{
			return _idtiponorma;
		}
		set
		{
			if (_idtiponorma != value)
			{
				_idtiponorma = value;
			}
		}
	}

	[Column(Storage = "_descriptiponorma", DbType = "VarChar(50)")]
	public string descriptiponorma
	{
		get
		{
			return _descriptiponorma;
		}
		set
		{
			if (!string.Equals(_descriptiponorma, value))
			{
				_descriptiponorma = value;
			}
		}
	}

	[Column(Storage = "_NumOrdenanza", DbType = "VarChar(120) NOT NULL", CanBeNull = false)]
	public string NumOrdenanza
	{
		get
		{
			return _NumOrdenanza;
		}
		set
		{
			if (!string.Equals(_NumOrdenanza, value))
			{
				_NumOrdenanza = value;
			}
		}
	}

	[Column(Storage = "_idtipomedio", DbType = "Int NOT NULL")]
	public int idtipomedio
	{
		get
		{
			return _idtipomedio;
		}
		set
		{
			if (_idtipomedio != value)
			{
				_idtipomedio = value;
			}
		}
	}

	[Column(Storage = "_TipoMedioDescrip", DbType = "VarChar(20)")]
	public string TipoMedioDescrip
	{
		get
		{
			return _TipoMedioDescrip;
		}
		set
		{
			if (!string.Equals(_TipoMedioDescrip, value))
			{
				_TipoMedioDescrip = value;
			}
		}
	}

	[Column(Storage = "_NombreMedio", DbType = "VarChar(80)")]
	public string NombreMedio
	{
		get
		{
			return _NombreMedio;
		}
		set
		{
			if (!string.Equals(_NombreMedio, value))
			{
				_NombreMedio = value;
			}
		}
	}

	[Column(Storage = "_FechaPublicacion", DbType = "DateTime")]
	public DateTime? FechaPublicacion
	{
		get
		{
			return _FechaPublicacion;
		}
		set
		{
			if (!_FechaPublicacion.Equals(value))
			{
				_FechaPublicacion = value;
			}
		}
	}

	[Column(Storage = "_Paginas", DbType = "VarChar(30)")]
	public string Paginas
	{
		get
		{
			return _Paginas;
		}
		set
		{
			if (!string.Equals(_Paginas, value))
			{
				_Paginas = value;
			}
		}
	}
}
