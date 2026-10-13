using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.CAP_Visitante")]
public class CAP_Visitante : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdVisitante;

	private Binary _Foto;

	private byte? _Atendido;

	[Column(Storage = "_IdVisitante", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdVisitante
	{
		get
		{
			return _IdVisitante;
		}
		set
		{
			if (_IdVisitante != value)
			{
				SendPropertyChanging();
				_IdVisitante = value;
				SendPropertyChanged("IdVisitante");
			}
		}
	}

	[Column(Storage = "_Foto", DbType = "Image", UpdateCheck = UpdateCheck.Never)]
	public Binary Foto
	{
		get
		{
			return _Foto;
		}
		set
		{
			if (!object.Equals(_Foto, value))
			{
				SendPropertyChanging();
				_Foto = value;
				SendPropertyChanged("Foto");
			}
		}
	}

	[Column(Storage = "_Atendido", DbType = "TinyInt")]
	public byte? Atendido
	{
		get
		{
			return _Atendido;
		}
		set
		{
			if (!_Atendido.Equals(value))
			{
				SendPropertyChanging();
				_Atendido = value;
				SendPropertyChanged("Atendido");
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
