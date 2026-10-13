using System;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.Empleado_old")]
public class Empleado_old
{
	private string _emp_dni;

	private string _emp_nombre;

	private string _emp_ape_paterno;

	private string _emp_ape_materno;

	private DateTime? _emp_fecha_nacimiento;

	private char _emp_sexo;

	private string _emp_estado_civil;

	private string _emp_nacionalidad;

	private string _emp_num_brevete;

	private string _emp_num_autogener_salud;

	private string _emp_telefono;

	private string _emp_celular;

	private string _emp_direccion;

	private string _emp_libreta_militar;

	private string _emp_ruc;

	private string _emp_grupo_sanguineo;

	private DateTime? _emp_fecha_afiliacion_afp;

	private int? _emp_num_per_dependientes;

	private string _emp_nivel_educativo;

	private DateTime? _emp_fecha_ingreso;

	private Binary _emp_foto;

	private string _emp_estado;

	private string _emp_cuspp;

	private int? _emp_itecat_id;

	private int? _emp_nom_codigo;

	private char? _emp_conlab_codigo;

	private int? _emp_reglab_codigo;

	private int? _emp_viv_codigo;

	private int? _emp_unicar_codigo;

	private string _emp_num_rescargo;

	private int? _emp_ces_codigo;

	private string _emp_cadfun_cadena;

	private int? _emp_afp_codigo;

	private string _emp_depa_codigo;

	private string _emp_prov_codigo;

	private string _emp_dist_codigo;

	private int? _emp_codigo;

	[Column(Storage = "_emp_dni", DbType = "Char(8) NOT NULL", CanBeNull = false)]
	public string emp_dni
	{
		get
		{
			return _emp_dni;
		}
		set
		{
			if (!string.Equals(_emp_dni, value))
			{
				_emp_dni = value;
			}
		}
	}

	[Column(Storage = "_emp_nombre", DbType = "VarChar(30)")]
	public string emp_nombre
	{
		get
		{
			return _emp_nombre;
		}
		set
		{
			if (!string.Equals(_emp_nombre, value))
			{
				_emp_nombre = value;
			}
		}
	}

	[Column(Storage = "_emp_ape_paterno", DbType = "VarChar(30)")]
	public string emp_ape_paterno
	{
		get
		{
			return _emp_ape_paterno;
		}
		set
		{
			if (!string.Equals(_emp_ape_paterno, value))
			{
				_emp_ape_paterno = value;
			}
		}
	}

	[Column(Storage = "_emp_ape_materno", DbType = "VarChar(30)")]
	public string emp_ape_materno
	{
		get
		{
			return _emp_ape_materno;
		}
		set
		{
			if (!string.Equals(_emp_ape_materno, value))
			{
				_emp_ape_materno = value;
			}
		}
	}

	[Column(Storage = "_emp_fecha_nacimiento", DbType = "DateTime")]
	public DateTime? emp_fecha_nacimiento
	{
		get
		{
			return _emp_fecha_nacimiento;
		}
		set
		{
			if (!_emp_fecha_nacimiento.Equals(value))
			{
				_emp_fecha_nacimiento = value;
			}
		}
	}

	[Column(Storage = "_emp_sexo", DbType = "Char(1) NOT NULL")]
	public char emp_sexo
	{
		get
		{
			return _emp_sexo;
		}
		set
		{
			if (_emp_sexo != value)
			{
				_emp_sexo = value;
			}
		}
	}

	[Column(Storage = "_emp_estado_civil", DbType = "VarChar(15)")]
	public string emp_estado_civil
	{
		get
		{
			return _emp_estado_civil;
		}
		set
		{
			if (!string.Equals(_emp_estado_civil, value))
			{
				_emp_estado_civil = value;
			}
		}
	}

	[Column(Storage = "_emp_nacionalidad", DbType = "VarChar(15)")]
	public string emp_nacionalidad
	{
		get
		{
			return _emp_nacionalidad;
		}
		set
		{
			if (!string.Equals(_emp_nacionalidad, value))
			{
				_emp_nacionalidad = value;
			}
		}
	}

	[Column(Storage = "_emp_num_brevete", DbType = "VarChar(10)")]
	public string emp_num_brevete
	{
		get
		{
			return _emp_num_brevete;
		}
		set
		{
			if (!string.Equals(_emp_num_brevete, value))
			{
				_emp_num_brevete = value;
			}
		}
	}

	[Column(Storage = "_emp_num_autogener_salud", DbType = "VarChar(15)")]
	public string emp_num_autogener_salud
	{
		get
		{
			return _emp_num_autogener_salud;
		}
		set
		{
			if (!string.Equals(_emp_num_autogener_salud, value))
			{
				_emp_num_autogener_salud = value;
			}
		}
	}

	[Column(Storage = "_emp_telefono", DbType = "VarChar(10)")]
	public string emp_telefono
	{
		get
		{
			return _emp_telefono;
		}
		set
		{
			if (!string.Equals(_emp_telefono, value))
			{
				_emp_telefono = value;
			}
		}
	}

	[Column(Storage = "_emp_celular", DbType = "VarChar(10)")]
	public string emp_celular
	{
		get
		{
			return _emp_celular;
		}
		set
		{
			if (!string.Equals(_emp_celular, value))
			{
				_emp_celular = value;
			}
		}
	}

	[Column(Storage = "_emp_direccion", DbType = "VarChar(200)")]
	public string emp_direccion
	{
		get
		{
			return _emp_direccion;
		}
		set
		{
			if (!string.Equals(_emp_direccion, value))
			{
				_emp_direccion = value;
			}
		}
	}

	[Column(Storage = "_emp_libreta_militar", DbType = "VarChar(10)")]
	public string emp_libreta_militar
	{
		get
		{
			return _emp_libreta_militar;
		}
		set
		{
			if (!string.Equals(_emp_libreta_militar, value))
			{
				_emp_libreta_militar = value;
			}
		}
	}

	[Column(Storage = "_emp_ruc", DbType = "VarChar(12)")]
	public string emp_ruc
	{
		get
		{
			return _emp_ruc;
		}
		set
		{
			if (!string.Equals(_emp_ruc, value))
			{
				_emp_ruc = value;
			}
		}
	}

	[Column(Storage = "_emp_grupo_sanguineo", DbType = "VarChar(4)")]
	public string emp_grupo_sanguineo
	{
		get
		{
			return _emp_grupo_sanguineo;
		}
		set
		{
			if (!string.Equals(_emp_grupo_sanguineo, value))
			{
				_emp_grupo_sanguineo = value;
			}
		}
	}

	[Column(Storage = "_emp_fecha_afiliacion_afp", DbType = "DateTime")]
	public DateTime? emp_fecha_afiliacion_afp
	{
		get
		{
			return _emp_fecha_afiliacion_afp;
		}
		set
		{
			if (!_emp_fecha_afiliacion_afp.Equals(value))
			{
				_emp_fecha_afiliacion_afp = value;
			}
		}
	}

	[Column(Storage = "_emp_num_per_dependientes", DbType = "Int")]
	public int? emp_num_per_dependientes
	{
		get
		{
			return _emp_num_per_dependientes;
		}
		set
		{
			if (!_emp_num_per_dependientes.Equals(value))
			{
				_emp_num_per_dependientes = value;
			}
		}
	}

	[Column(Storage = "_emp_nivel_educativo", DbType = "VarChar(20)")]
	public string emp_nivel_educativo
	{
		get
		{
			return _emp_nivel_educativo;
		}
		set
		{
			if (!string.Equals(_emp_nivel_educativo, value))
			{
				_emp_nivel_educativo = value;
			}
		}
	}

	[Column(Storage = "_emp_fecha_ingreso", DbType = "DateTime")]
	public DateTime? emp_fecha_ingreso
	{
		get
		{
			return _emp_fecha_ingreso;
		}
		set
		{
			if (!_emp_fecha_ingreso.Equals(value))
			{
				_emp_fecha_ingreso = value;
			}
		}
	}

	[Column(Storage = "_emp_foto", DbType = "Image", UpdateCheck = UpdateCheck.Never)]
	public Binary emp_foto
	{
		get
		{
			return _emp_foto;
		}
		set
		{
			if (!object.Equals(_emp_foto, value))
			{
				_emp_foto = value;
			}
		}
	}

	[Column(Storage = "_emp_estado", DbType = "VarChar(20)")]
	public string emp_estado
	{
		get
		{
			return _emp_estado;
		}
		set
		{
			if (!string.Equals(_emp_estado, value))
			{
				_emp_estado = value;
			}
		}
	}

	[Column(Storage = "_emp_cuspp", DbType = "VarChar(15)")]
	public string emp_cuspp
	{
		get
		{
			return _emp_cuspp;
		}
		set
		{
			if (!string.Equals(_emp_cuspp, value))
			{
				_emp_cuspp = value;
			}
		}
	}

	[Column(Storage = "_emp_itecat_id", DbType = "Int")]
	public int? emp_itecat_id
	{
		get
		{
			return _emp_itecat_id;
		}
		set
		{
			if (!_emp_itecat_id.Equals(value))
			{
				_emp_itecat_id = value;
			}
		}
	}

	[Column(Storage = "_emp_nom_codigo", DbType = "Int")]
	public int? emp_nom_codigo
	{
		get
		{
			return _emp_nom_codigo;
		}
		set
		{
			if (!_emp_nom_codigo.Equals(value))
			{
				_emp_nom_codigo = value;
			}
		}
	}

	[Column(Storage = "_emp_conlab_codigo", DbType = "Char(1)")]
	public char? emp_conlab_codigo
	{
		get
		{
			return _emp_conlab_codigo;
		}
		set
		{
			if (!_emp_conlab_codigo.Equals(value))
			{
				_emp_conlab_codigo = value;
			}
		}
	}

	[Column(Storage = "_emp_reglab_codigo", DbType = "Int")]
	public int? emp_reglab_codigo
	{
		get
		{
			return _emp_reglab_codigo;
		}
		set
		{
			if (!_emp_reglab_codigo.Equals(value))
			{
				_emp_reglab_codigo = value;
			}
		}
	}

	[Column(Storage = "_emp_viv_codigo", DbType = "Int")]
	public int? emp_viv_codigo
	{
		get
		{
			return _emp_viv_codigo;
		}
		set
		{
			if (!_emp_viv_codigo.Equals(value))
			{
				_emp_viv_codigo = value;
			}
		}
	}

	[Column(Storage = "_emp_unicar_codigo", DbType = "Int")]
	public int? emp_unicar_codigo
	{
		get
		{
			return _emp_unicar_codigo;
		}
		set
		{
			if (!_emp_unicar_codigo.Equals(value))
			{
				_emp_unicar_codigo = value;
			}
		}
	}

	[Column(Storage = "_emp_num_rescargo", DbType = "NVarChar(30)")]
	public string emp_num_rescargo
	{
		get
		{
			return _emp_num_rescargo;
		}
		set
		{
			if (!string.Equals(_emp_num_rescargo, value))
			{
				_emp_num_rescargo = value;
			}
		}
	}

	[Column(Storage = "_emp_ces_codigo", DbType = "Int")]
	public int? emp_ces_codigo
	{
		get
		{
			return _emp_ces_codigo;
		}
		set
		{
			if (!_emp_ces_codigo.Equals(value))
			{
				_emp_ces_codigo = value;
			}
		}
	}

	[Column(Storage = "_emp_cadfun_cadena", DbType = "VarChar(50)")]
	public string emp_cadfun_cadena
	{
		get
		{
			return _emp_cadfun_cadena;
		}
		set
		{
			if (!string.Equals(_emp_cadfun_cadena, value))
			{
				_emp_cadfun_cadena = value;
			}
		}
	}

	[Column(Storage = "_emp_afp_codigo", DbType = "Int")]
	public int? emp_afp_codigo
	{
		get
		{
			return _emp_afp_codigo;
		}
		set
		{
			if (!_emp_afp_codigo.Equals(value))
			{
				_emp_afp_codigo = value;
			}
		}
	}

	[Column(Storage = "_emp_depa_codigo", DbType = "NVarChar(2)")]
	public string emp_depa_codigo
	{
		get
		{
			return _emp_depa_codigo;
		}
		set
		{
			if (!string.Equals(_emp_depa_codigo, value))
			{
				_emp_depa_codigo = value;
			}
		}
	}

	[Column(Storage = "_emp_prov_codigo", DbType = "NVarChar(2)")]
	public string emp_prov_codigo
	{
		get
		{
			return _emp_prov_codigo;
		}
		set
		{
			if (!string.Equals(_emp_prov_codigo, value))
			{
				_emp_prov_codigo = value;
			}
		}
	}

	[Column(Storage = "_emp_dist_codigo", DbType = "NVarChar(2)")]
	public string emp_dist_codigo
	{
		get
		{
			return _emp_dist_codigo;
		}
		set
		{
			if (!string.Equals(_emp_dist_codigo, value))
			{
				_emp_dist_codigo = value;
			}
		}
	}

	[Column(Storage = "_emp_codigo", DbType = "Int")]
	public int? emp_codigo
	{
		get
		{
			return _emp_codigo;
		}
		set
		{
			if (!_emp_codigo.Equals(value))
			{
				_emp_codigo = value;
			}
		}
	}
}
