using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.EstadoEstudio")]
public class EstadoEstudio : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdEstadoEstudio;

	private string _DescripEstadoEstudio;

	private EntitySet<EstudiosRealizado> _EstudiosRealizados;

	[Column(Storage = "_IdEstadoEstudio", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdEstadoEstudio
	{
		get
		{
			return _IdEstadoEstudio;
		}
		set
		{
			if (_IdEstadoEstudio != value)
			{
				SendPropertyChanging();
				_IdEstadoEstudio = value;
				SendPropertyChanged("IdEstadoEstudio");
			}
		}
	}

	[Column(Storage = "_DescripEstadoEstudio", DbType = "VarChar(10)")]
	public string DescripEstadoEstudio
	{
		get
		{
			return _DescripEstadoEstudio;
		}
		set
		{
			if (!string.Equals(_DescripEstadoEstudio, value))
			{
				SendPropertyChanging();
				_DescripEstadoEstudio = value;
				SendPropertyChanged("DescripEstadoEstudio");
			}
		}
	}

	[Association(Name = "EstadoEstudio_EstudiosRealizado", Storage = "_EstudiosRealizados", ThisKey = "IdEstadoEstudio", OtherKey = "IdEstadoEstudio")]
	public EntitySet<EstudiosRealizado> EstudiosRealizados
	{
		get
		{
			return _EstudiosRealizados;
		}
		set
		{
			_EstudiosRealizados.Assign(value);
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public EstadoEstudio()
	{
		_EstudiosRealizados = new EntitySet<EstudiosRealizado>(attach_EstudiosRealizados, detach_EstudiosRealizados);
	}

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

	private void attach_EstudiosRealizados(EstudiosRealizado entity)
	{
		SendPropertyChanging();
		entity.EstadoEstudio = this;
	}

	private void detach_EstudiosRealizados(EstudiosRealizado entity)
	{
		SendPropertyChanging();
		entity.EstadoEstudio = null;
	}
}
