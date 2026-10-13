using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spCJR_llenarOperadoresResult
{
	private int _idOperador;

	private int? _idempleado;

	private string _NombresCompletos;

	[Column(Storage = "_idOperador", DbType = "Int NOT NULL")]
	public int idOperador
	{
		get
		{
			return _idOperador;
		}
		set
		{
			if (_idOperador != value)
			{
				_idOperador = value;
			}
		}
	}

	[Column(Storage = "_idempleado", DbType = "Int")]
	public int? idempleado
	{
		get
		{
			return _idempleado;
		}
		set
		{
			if (!_idempleado.Equals(value))
			{
				_idempleado = value;
			}
		}
	}

	[Column(Storage = "_NombresCompletos", DbType = "VarChar(162)")]
	public string NombresCompletos
	{
		get
		{
			return _NombresCompletos;
		}
		set
		{
			if (!string.Equals(_NombresCompletos, value))
			{
				_NombresCompletos = value;
			}
		}
	}
}
