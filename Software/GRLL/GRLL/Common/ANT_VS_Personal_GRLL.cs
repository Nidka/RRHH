using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.ANT_VS_Personal_GRLL")]
public class ANT_VS_Personal_GRLL
{
	private int _idpersona;

	private string _apellido_Paterno;

	private string _apellido_Materno;

	private string _Persona;

	[Column(Storage = "_idpersona", DbType = "Int NOT NULL")]
	public int idpersona
	{
		get
		{
			return _idpersona;
		}
		set
		{
			if (_idpersona != value)
			{
				_idpersona = value;
			}
		}
	}

	[Column(Storage = "_apellido_Paterno", DbType = "VarChar(30)")]
	public string apellido_Paterno
	{
		get
		{
			return _apellido_Paterno;
		}
		set
		{
			if (!string.Equals(_apellido_Paterno, value))
			{
				_apellido_Paterno = value;
			}
		}
	}

	[Column(Storage = "_apellido_Materno", DbType = "VarChar(30)")]
	public string apellido_Materno
	{
		get
		{
			return _apellido_Materno;
		}
		set
		{
			if (!string.Equals(_apellido_Materno, value))
			{
				_apellido_Materno = value;
			}
		}
	}

	[Column(Storage = "_Persona", DbType = "VarChar(162)")]
	public string Persona
	{
		get
		{
			return _Persona;
		}
		set
		{
			if (!string.Equals(_Persona, value))
			{
				_Persona = value;
			}
		}
	}
}
