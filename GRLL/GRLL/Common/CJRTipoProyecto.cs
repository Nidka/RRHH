using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.CJRTipoProyecto")]
public class CJRTipoProyecto : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _idTipoProyec;

	private string _DescripTipoProyec;

	private EntitySet<CJRProyectoNormativo> _CJRProyectoNormativo;

	[Column(Storage = "_idTipoProyec", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int idTipoProyec
	{
		get
		{
			return _idTipoProyec;
		}
		set
		{
			if (_idTipoProyec != value)
			{
				SendPropertyChanging();
				_idTipoProyec = value;
				SendPropertyChanged("idTipoProyec");
			}
		}
	}

	[Column(Storage = "_DescripTipoProyec", DbType = "VarChar(50)")]
	public string DescripTipoProyec
	{
		get
		{
			return _DescripTipoProyec;
		}
		set
		{
			if (!string.Equals(_DescripTipoProyec, value))
			{
				SendPropertyChanging();
				_DescripTipoProyec = value;
				SendPropertyChanged("DescripTipoProyec");
			}
		}
	}

	[Association(Name = "CJRTipoProyecto_CJRProyectoNormativo", Storage = "_CJRProyectoNormativo", ThisKey = "idTipoProyec", OtherKey = "idTipoProyec")]
	public EntitySet<CJRProyectoNormativo> CJRProyectoNormativo
	{
		get
		{
			return _CJRProyectoNormativo;
		}
		set
		{
			_CJRProyectoNormativo.Assign(value);
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public CJRTipoProyecto()
	{
		_CJRProyectoNormativo = new EntitySet<CJRProyectoNormativo>(attach_CJRProyectoNormativo, detach_CJRProyectoNormativo);
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

	private void attach_CJRProyectoNormativo(CJRProyectoNormativo entity)
	{
		SendPropertyChanging();
		entity.CJRTipoProyecto = this;
	}

	private void detach_CJRProyectoNormativo(CJRProyectoNormativo entity)
	{
		SendPropertyChanging();
		entity.CJRTipoProyecto = null;
	}
}
