using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.vs_tra_proc_etapa_area_cargo")]
public class vs_tra_proc_etapa_area_cargo
{
	private string _idprocedimiento;

	private string _Procedimiento;

	private string _idetapaproc;

	private string _Etapa;

	private int? _idareaorganiz;

	private string _Area;

	private int _idcargo;

	private string _cargo;

	[Column(Storage = "_idprocedimiento", DbType = "Char(6) NOT NULL", CanBeNull = false)]
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

	[Column(Storage = "_Procedimiento", DbType = "VarChar(300)")]
	public string Procedimiento
	{
		get
		{
			return _Procedimiento;
		}
		set
		{
			if (!string.Equals(_Procedimiento, value))
			{
				_Procedimiento = value;
			}
		}
	}

	[Column(Storage = "_idetapaproc", DbType = "Char(8) NOT NULL", CanBeNull = false)]
	public string idetapaproc
	{
		get
		{
			return _idetapaproc;
		}
		set
		{
			if (!string.Equals(_idetapaproc, value))
			{
				_idetapaproc = value;
			}
		}
	}

	[Column(Storage = "_Etapa", DbType = "VarChar(400)")]
	public string Etapa
	{
		get
		{
			return _Etapa;
		}
		set
		{
			if (!string.Equals(_Etapa, value))
			{
				_Etapa = value;
			}
		}
	}

	[Column(Storage = "_idareaorganiz", DbType = "Int")]
	public int? idareaorganiz
	{
		get
		{
			return _idareaorganiz;
		}
		set
		{
			if (!_idareaorganiz.Equals(value))
			{
				_idareaorganiz = value;
			}
		}
	}

	[Column(Storage = "_Area", DbType = "VarChar(200) NOT NULL", CanBeNull = false)]
	public string Area
	{
		get
		{
			return _Area;
		}
		set
		{
			if (!string.Equals(_Area, value))
			{
				_Area = value;
			}
		}
	}

	[Column(Storage = "_idcargo", DbType = "Int NOT NULL")]
	public int idcargo
	{
		get
		{
			return _idcargo;
		}
		set
		{
			if (_idcargo != value)
			{
				_idcargo = value;
			}
		}
	}

	[Column(Storage = "_cargo", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
	public string cargo
	{
		get
		{
			return _cargo;
		}
		set
		{
			if (!string.Equals(_cargo, value))
			{
				_cargo = value;
			}
		}
	}
}
