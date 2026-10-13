namespace GRLL.Common;

public class ClsTipoDatos
{
	public enum TipoDatosSql
	{
		Texto,
		Numerico,
		Fecha
	}

	private string _Campo;

	private string _CampoFill;

	private TipoDatosSql _TipoDato;

	private int _MaxLeng;

	private clsVariables.TipoDato _TipoText;

	public string Campo
	{
		get
		{
			return _Campo;
		}
		set
		{
			_Campo = value;
		}
	}

	public string CampoFill
	{
		get
		{
			return _CampoFill;
		}
		set
		{
			_CampoFill = value;
		}
	}

	public TipoDatosSql TipoDato
	{
		get
		{
			return _TipoDato;
		}
		set
		{
			_TipoDato = value;
		}
	}

	public int MaxLeng
	{
		get
		{
			return _MaxLeng;
		}
		set
		{
			_MaxLeng = value;
		}
	}

	public clsVariables.TipoDato TipoText
	{
		get
		{
			return _TipoText;
		}
		set
		{
			_TipoText = value;
		}
	}

	public ClsTipoDatos()
	{
		_Campo = "";
		_CampoFill = "";
		_TipoDato = TipoDatosSql.Texto;
		_MaxLeng = 25;
		_TipoText = clsVariables.TipoDato.LetrasConEspacio;
	}
}
