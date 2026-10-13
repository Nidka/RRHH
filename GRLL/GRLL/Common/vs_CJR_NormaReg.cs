using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.vs_CJR_NormaReg")]
public class vs_CJR_NormaReg
{
	private string _NumOficioIniciativa;

	private string _temadescrip;

	private string _numOrdenanza;

	private DateTime? _FechaOrdenanza;

	private string _SolOfPublicacionNorma;

	private DateTime? _FechaOfPublicacionNorma;

	private string _TipoMedioDescrip;

	private DateTime? _FechaPubli;

	private string _Paginas;

	private string _NombreMedio;

	[Column(Storage = "_NumOficioIniciativa", DbType = "VarChar(120) NOT NULL", CanBeNull = false)]
	public string NumOficioIniciativa
	{
		get
		{
			return _NumOficioIniciativa;
		}
		set
		{
			if (!string.Equals(_NumOficioIniciativa, value))
			{
				_NumOficioIniciativa = value;
			}
		}
	}

	[Column(Storage = "_temadescrip", DbType = "VarChar(2000)")]
	public string temadescrip
	{
		get
		{
			return _temadescrip;
		}
		set
		{
			if (!string.Equals(_temadescrip, value))
			{
				_temadescrip = value;
			}
		}
	}

	[Column(Storage = "_numOrdenanza", DbType = "VarChar(120)")]
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

	[Column(Storage = "_SolOfPublicacionNorma", DbType = "VarChar(120)")]
	public string SolOfPublicacionNorma
	{
		get
		{
			return _SolOfPublicacionNorma;
		}
		set
		{
			if (!string.Equals(_SolOfPublicacionNorma, value))
			{
				_SolOfPublicacionNorma = value;
			}
		}
	}

	[Column(Storage = "_FechaOfPublicacionNorma", DbType = "DateTime")]
	public DateTime? FechaOfPublicacionNorma
	{
		get
		{
			return _FechaOfPublicacionNorma;
		}
		set
		{
			if (!_FechaOfPublicacionNorma.Equals(value))
			{
				_FechaOfPublicacionNorma = value;
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

	[Column(Storage = "_FechaPubli", DbType = "DateTime")]
	public DateTime? FechaPubli
	{
		get
		{
			return _FechaPubli;
		}
		set
		{
			if (!_FechaPubli.Equals(value))
			{
				_FechaPubli = value;
			}
		}
	}

	[Column(Storage = "_Paginas", DbType = "VarChar(100)")]
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
}
