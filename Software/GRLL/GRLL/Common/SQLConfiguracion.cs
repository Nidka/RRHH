using System.Diagnostics;

namespace GRLL.Common;

public class SQLConfiguracion
{
	public delegate void ValueChangedEventHandler();

	private string _Servidor;

	private string _BaseDatos;

	private bool _AutenticacionIntegrada;

	private string _Usuario;

	private string _Password;

	private int _TiempoConexion;

	public string Servidor
	{
		get
		{
			return _Servidor;
		}
		set
		{
			_Servidor = value;
			ValueChanged?.Invoke();
		}
	}

	public string BaseDatos
	{
		get
		{
			return _BaseDatos;
		}
		set
		{
			_BaseDatos = value;
			ValueChanged?.Invoke();
		}
	}

	public bool AutenticacionIntegrada
	{
		get
		{
			return _AutenticacionIntegrada;
		}
		set
		{
			_AutenticacionIntegrada = value;
			ValueChanged?.Invoke();
		}
	}

	public string Usuario
	{
		get
		{
			return _Usuario;
		}
		set
		{
			_Usuario = value;
			ValueChanged?.Invoke();
		}
	}

	public string Password
	{
		get
		{
			return _Password;
		}
		set
		{
			_Password = value;
			ValueChanged?.Invoke();
		}
	}

	public int TiempoConexion
	{
		get
		{
			return _TiempoConexion;
		}
		set
		{
			_TiempoConexion = value;
			ValueChanged?.Invoke();
		}
	}

	[method: DebuggerNonUserCode]
	public event ValueChangedEventHandler ValueChanged;

	[DebuggerNonUserCode]
	public SQLConfiguracion()
	{
	}
}
