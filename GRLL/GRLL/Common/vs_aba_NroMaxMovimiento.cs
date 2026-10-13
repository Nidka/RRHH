using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.vs_aba_NroMaxMovimiento")]
public class vs_aba_NroMaxMovimiento
{
	private string _idmovimiento;

	private string _anio;

	private int? _numero;

	[Column(Storage = "_idmovimiento", DbType = "Char(8) NOT NULL", CanBeNull = false)]
	public string idmovimiento
	{
		get
		{
			return _idmovimiento;
		}
		set
		{
			if (!string.Equals(_idmovimiento, value))
			{
				_idmovimiento = value;
			}
		}
	}

	[Column(Storage = "_anio", DbType = "VarChar(2)")]
	public string anio
	{
		get
		{
			return _anio;
		}
		set
		{
			if (!string.Equals(_anio, value))
			{
				_anio = value;
			}
		}
	}

	[Column(Storage = "_numero", DbType = "Int")]
	public int? numero
	{
		get
		{
			return _numero;
		}
		set
		{
			if (!_numero.Equals(value))
			{
				_numero = value;
			}
		}
	}
}
