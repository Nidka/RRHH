using System;
using System.Diagnostics;

namespace GRLL.Common;

[Serializable]
public class Alertita
{
	private int _IdTipoAlerta;

	private string _Descripcion;

	public int IdTipoAlerta
	{
		get
		{
			return _IdTipoAlerta;
		}
		set
		{
			if (_IdTipoAlerta != value)
			{
				_IdTipoAlerta = value;
			}
		}
	}

	public string Descripcion
	{
		get
		{
			return _Descripcion;
		}
		set
		{
			if (!string.Equals(_Descripcion, value))
			{
				_Descripcion = value;
			}
		}
	}

	[DebuggerNonUserCode]
	public Alertita()
	{
	}
}
