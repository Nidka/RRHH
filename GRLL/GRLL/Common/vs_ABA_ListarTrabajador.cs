using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.vs_ABA_ListarTrabajador")]
public class vs_ABA_ListarTrabajador
{
	private int _idempleado;

	private string _desempleado;

	private string _dni;

	[Column(Storage = "_idempleado", DbType = "Int NOT NULL")]
	public int idempleado
	{
		get
		{
			return _idempleado;
		}
		set
		{
			if (_idempleado != value)
			{
				_idempleado = value;
			}
		}
	}

	[Column(Storage = "_desempleado", DbType = "VarChar(162)")]
	public string desempleado
	{
		get
		{
			return _desempleado;
		}
		set
		{
			if (!string.Equals(_desempleado, value))
			{
				_desempleado = value;
			}
		}
	}

	[Column(Storage = "_dni", DbType = "Char(12)")]
	public string dni
	{
		get
		{
			return _dni;
		}
		set
		{
			if (!string.Equals(_dni, value))
			{
				_dni = value;
			}
		}
	}
}
