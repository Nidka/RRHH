using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.ModalidadAplicacion")]
public class ModalidadAplicacion : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _IdModalidadAplicacion;

	private string _Descripcion;

	private EntitySet<GastoPublico> _GastoPublico;

	[Column(Storage = "_IdModalidadAplicacion", DbType = "Char(2) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdModalidadAplicacion
	{
		get
		{
			return _IdModalidadAplicacion;
		}
		set
		{
			if (!string.Equals(_IdModalidadAplicacion, value))
			{
				SendPropertyChanging();
				_IdModalidadAplicacion = value;
				SendPropertyChanged("IdModalidadAplicacion");
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(80)")]
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

	[Association(Name = "ModalidadAplicacion_GastoPublico", Storage = "_GastoPublico", ThisKey = "IdModalidadAplicacion", OtherKey = "IdModalidadAplicacion")]
	public EntitySet<GastoPublico> GastoPublico
	{
		get
		{
			return _GastoPublico;
		}
		set
		{
			_GastoPublico.Assign(value);
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public ModalidadAplicacion()
	{
		_GastoPublico = new EntitySet<GastoPublico>(attach_GastoPublico, detach_GastoPublico);
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

	private void attach_GastoPublico(GastoPublico entity)
	{
		SendPropertyChanging();
		entity.ModalidadAplicacion = this;
	}

	private void detach_GastoPublico(GastoPublico entity)
	{
		SendPropertyChanging();
		entity.ModalidadAplicacion = null;
	}
}
