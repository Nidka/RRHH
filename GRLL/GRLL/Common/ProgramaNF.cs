using System.ComponentModel;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.ProgramaNF")]
public class ProgramaNF : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _IdFuncion;

	private string _IdPrograma;

	private string _IdSubPrograma;

	private string _IdProgramaNF;

	private string _Anio;

	private string _Descripcion;

	[Column(Storage = "_IdFuncion", DbType = "Char(2) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdFuncion
	{
		get
		{
			return _IdFuncion;
		}
		set
		{
			if (!string.Equals(_IdFuncion, value))
			{
				SendPropertyChanging();
				_IdFuncion = value;
				SendPropertyChanged("IdFuncion");
			}
		}
	}

	[Column(Storage = "_IdPrograma", DbType = "Char(3) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdPrograma
	{
		get
		{
			return _IdPrograma;
		}
		set
		{
			if (!string.Equals(_IdPrograma, value))
			{
				SendPropertyChanging();
				_IdPrograma = value;
				SendPropertyChanged("IdPrograma");
			}
		}
	}

	[Column(Storage = "_IdSubPrograma", DbType = "NChar(4) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdSubPrograma
	{
		get
		{
			return _IdSubPrograma;
		}
		set
		{
			if (!string.Equals(_IdSubPrograma, value))
			{
				SendPropertyChanging();
				_IdSubPrograma = value;
				SendPropertyChanged("IdSubPrograma");
			}
		}
	}

	[Column(Storage = "_IdProgramaNF", DbType = "NChar(4) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdProgramaNF
	{
		get
		{
			return _IdProgramaNF;
		}
		set
		{
			if (!string.Equals(_IdProgramaNF, value))
			{
				SendPropertyChanging();
				_IdProgramaNF = value;
				SendPropertyChanged("IdProgramaNF");
			}
		}
	}

	[Column(Storage = "_Anio", DbType = "Char(4) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string Anio
	{
		get
		{
			return _Anio;
		}
		set
		{
			if (!string.Equals(_Anio, value))
			{
				SendPropertyChanging();
				_Anio = value;
				SendPropertyChanged("Anio");
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "NChar(255)")]
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
				SendPropertyChanging();
				_Descripcion = value;
				SendPropertyChanged("Descripcion");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	protected virtual void SendPropertyChanging()
	{
		if (PropertyChanging != null)
		{
			PropertyChanging?.Invoke(this, emptyChangingEventArgs);
		}
	}

	protected virtual void SendPropertyChanged(string propertyName)
	{
		if (PropertyChanged != null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
