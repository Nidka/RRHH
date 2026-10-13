using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.TipoEstudio")]
public class TipoEstudio : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdTipoEstudios;

	private string _DescripTipoEst;

	private EntitySet<EstudiosRealizado> _EstudiosRealizados;

	[Column(Storage = "_IdTipoEstudios", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdTipoEstudios
	{
		get
		{
			return _IdTipoEstudios;
		}
		set
		{
			if (_IdTipoEstudios != value)
			{
				SendPropertyChanging();
				_IdTipoEstudios = value;
				SendPropertyChanged("IdTipoEstudios");
			}
		}
	}

	[Column(Storage = "_DescripTipoEst", DbType = "VarChar(15)")]
	public string DescripTipoEst
	{
		get
		{
			return _DescripTipoEst;
		}
		set
		{
			if (!string.Equals(_DescripTipoEst, value))
			{
				SendPropertyChanging();
				_DescripTipoEst = value;
				SendPropertyChanged("DescripTipoEst");
			}
		}
	}

	[Association(Name = "TipoEstudio_EstudiosRealizado", Storage = "_EstudiosRealizados", ThisKey = "IdTipoEstudios", OtherKey = "IdTipoEstudios")]
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

	public TipoEstudio()
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
		entity.TipoEstudio = this;
	}

	private void detach_EstudiosRealizados(EstudiosRealizado entity)
	{
		SendPropertyChanging();
		entity.TipoEstudio = null;
	}
}
