using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.vs_PTI_ListarOrganigrama")]
public class vs_PTI_ListarOrganigrama
{
	private int _anio;

	private string _Codigo;

	private int _idareaorganiz;

	private string _areaorganizacional;

	private string _Padre;

	private decimal? _MontoAprobacion;

	private bool? _Aprueba;

	[Column(Storage = "_anio", DbType = "Int NOT NULL")]
	public int anio
	{
		get
		{
			return _anio;
		}
		set
		{
			if (_anio != value)
			{
				_anio = value;
			}
		}
	}

	[Column(Storage = "_Codigo", DbType = "VarChar(8)")]
	public string Codigo
	{
		get
		{
			return _Codigo;
		}
		set
		{
			if (!string.Equals(_Codigo, value))
			{
				_Codigo = value;
			}
		}
	}

	[Column(Storage = "_idareaorganiz", DbType = "Int NOT NULL")]
	public int idareaorganiz
	{
		get
		{
			return _idareaorganiz;
		}
		set
		{
			if (_idareaorganiz != value)
			{
				_idareaorganiz = value;
			}
		}
	}

	[Column(Storage = "_areaorganizacional", DbType = "VarChar(200) NOT NULL", CanBeNull = false)]
	public string areaorganizacional
	{
		get
		{
			return _areaorganizacional;
		}
		set
		{
			if (!string.Equals(_areaorganizacional, value))
			{
				_areaorganizacional = value;
			}
		}
	}

	[Column(Storage = "_Padre", DbType = "VarChar(8)")]
	public string Padre
	{
		get
		{
			return _Padre;
		}
		set
		{
			if (!string.Equals(_Padre, value))
			{
				_Padre = value;
			}
		}
	}

	[Column(Storage = "_MontoAprobacion", DbType = "Decimal(18,2)")]
	public decimal? MontoAprobacion
	{
		get
		{
			return _MontoAprobacion;
		}
		set
		{
			if (!_MontoAprobacion.Equals(value))
			{
				_MontoAprobacion = value;
			}
		}
	}

	[Column(Storage = "_Aprueba", DbType = "Bit")]
	public bool? Aprueba
	{
		get
		{
			return _Aprueba;
		}
		set
		{
			if (!_Aprueba.Equals(value))
			{
				_Aprueba = value;
			}
		}
	}
}
