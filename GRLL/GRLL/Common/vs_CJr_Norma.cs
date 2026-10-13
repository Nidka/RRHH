using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.vs_CJr_Norma")]
public class vs_CJr_Norma
{
	private int? _idTipoProyec;

	private string _NumProyecto;

	private string _DescripTipoNorma;

	private int _idTipoNorma;

	private string _numOrdenanza;

	private DateTime? _FechaOrdenanza;

	private string _OfPubliNorma;

	private DateTime? _FechaOfPubliNorma;

	private string _TipoMedioDescrip;

	private string _nombremedio;

	private DateTime? _FechaPublicacion;

	private string _paginas;

	private string _OfcioNotificacion;

	private DateTime? _FEchaOfcioNotificacion;

	[Column(Storage = "_idTipoProyec", DbType = "Int")]
	public int? idTipoProyec
	{
		get
		{
			return _idTipoProyec;
		}
		set
		{
			if (!_idTipoProyec.Equals(value))
			{
				_idTipoProyec = value;
			}
		}
	}

	[Column(Storage = "_NumProyecto", DbType = "VarChar(120)")]
	public string NumProyecto
	{
		get
		{
			return _NumProyecto;
		}
		set
		{
			if (!string.Equals(_NumProyecto, value))
			{
				_NumProyecto = value;
			}
		}
	}

	[Column(Storage = "_DescripTipoNorma", DbType = "VarChar(50)")]
	public string DescripTipoNorma
	{
		get
		{
			return _DescripTipoNorma;
		}
		set
		{
			if (!string.Equals(_DescripTipoNorma, value))
			{
				_DescripTipoNorma = value;
			}
		}
	}

	[Column(Storage = "_idTipoNorma", DbType = "Int NOT NULL")]
	public int idTipoNorma
	{
		get
		{
			return _idTipoNorma;
		}
		set
		{
			if (_idTipoNorma != value)
			{
				_idTipoNorma = value;
			}
		}
	}

	[Column(Storage = "_numOrdenanza", DbType = "VarChar(120) NOT NULL", CanBeNull = false)]
	public string numOrdenanza
	{
		get
		{
			return _numOrdenanza;
		}
		set
		{
			if (!string.Equals(_numOrdenanza, value))
			{
				_numOrdenanza = value;
			}
		}
	}

	[Column(Storage = "_FechaOrdenanza", DbType = "DateTime")]
	public DateTime? FechaOrdenanza
	{
		get
		{
			return _FechaOrdenanza;
		}
		set
		{
			if (!_FechaOrdenanza.Equals(value))
			{
				_FechaOrdenanza = value;
			}
		}
	}

	[Column(Storage = "_OfPubliNorma", DbType = "VarChar(120)")]
	public string OfPubliNorma
	{
		get
		{
			return _OfPubliNorma;
		}
		set
		{
			if (!string.Equals(_OfPubliNorma, value))
			{
				_OfPubliNorma = value;
			}
		}
	}

	[Column(Storage = "_FechaOfPubliNorma", DbType = "DateTime")]
	public DateTime? FechaOfPubliNorma
	{
		get
		{
			return _FechaOfPubliNorma;
		}
		set
		{
			if (!_FechaOfPubliNorma.Equals(value))
			{
				_FechaOfPubliNorma = value;
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

	[Column(Storage = "_nombremedio", DbType = "VarChar(80)")]
	public string nombremedio
	{
		get
		{
			return _nombremedio;
		}
		set
		{
			if (!string.Equals(_nombremedio, value))
			{
				_nombremedio = value;
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

	[Column(Storage = "_paginas", DbType = "VarChar(10)")]
	public string paginas
	{
		get
		{
			return _paginas;
		}
		set
		{
			if (!string.Equals(_paginas, value))
			{
				_paginas = value;
			}
		}
	}

	[Column(Storage = "_OfcioNotificacion", DbType = "VarChar(120)")]
	public string OfcioNotificacion
	{
		get
		{
			return _OfcioNotificacion;
		}
		set
		{
			if (!string.Equals(_OfcioNotificacion, value))
			{
				_OfcioNotificacion = value;
			}
		}
	}

	[Column(Storage = "_FEchaOfcioNotificacion", DbType = "DateTime")]
	public DateTime? FEchaOfcioNotificacion
	{
		get
		{
			return _FEchaOfcioNotificacion;
		}
		set
		{
			if (!_FEchaOfcioNotificacion.Equals(value))
			{
				_FEchaOfcioNotificacion = value;
			}
		}
	}
}
