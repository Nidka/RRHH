using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.vs_tra_Puntualidad_Tramite")]
public class vs_tra_Puntualidad_Tramite
{
	private string _idtramite;

	private string _idprocedimiento;

	private DateTime? _f_inicial;

	private DateTime? _f_salida_oficial;

	private DateTime? _f_final;

	private string _Puntualidad;

	private string _T_Excedido_Restante;

	[Column(Storage = "_idtramite", DbType = "Char(8)")]
	public string idtramite
	{
		get
		{
			return _idtramite;
		}
		set
		{
			if (!string.Equals(_idtramite, value))
			{
				_idtramite = value;
			}
		}
	}

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

	[Column(Storage = "_f_inicial", DbType = "DateTime")]
	public DateTime? f_inicial
	{
		get
		{
			return _f_inicial;
		}
		set
		{
			if (!_f_inicial.Equals(value))
			{
				_f_inicial = value;
			}
		}
	}

	[Column(Storage = "_f_salida_oficial", DbType = "DateTime")]
	public DateTime? f_salida_oficial
	{
		get
		{
			return _f_salida_oficial;
		}
		set
		{
			if (!_f_salida_oficial.Equals(value))
			{
				_f_salida_oficial = value;
			}
		}
	}

	[Column(Storage = "_f_final", DbType = "DateTime")]
	public DateTime? f_final
	{
		get
		{
			return _f_final;
		}
		set
		{
			if (!_f_final.Equals(value))
			{
				_f_final = value;
			}
		}
	}

	[Column(Storage = "_Puntualidad", DbType = "VarChar(8) NOT NULL", CanBeNull = false)]
	public string Puntualidad
	{
		get
		{
			return _Puntualidad;
		}
		set
		{
			if (!string.Equals(_Puntualidad, value))
			{
				_Puntualidad = value;
			}
		}
	}

	[Column(Storage = "_T_Excedido_Restante", DbType = "NVarChar(55)")]
	public string T_Excedido_Restante
	{
		get
		{
			return _T_Excedido_Restante;
		}
		set
		{
			if (!string.Equals(_T_Excedido_Restante, value))
			{
				_T_Excedido_Restante = value;
			}
		}
	}
}
