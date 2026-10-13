using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.CJRTipoNorma")]
public class CJRTipoNorma : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _idTipoNorma;

	private string _DescripTipoNorma;

	private EntitySet<CJRNormaRegional> _CJRNormaRegional;

	[Column(Storage = "_idTipoNorma", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int idTipoNorma
	{
		get
		{
			return _idTipoNorma;
		}
		set
		{
			if (_idTipoNorma != value)
			{
				SendPropertyChanging();
				_idTipoNorma = value;
				SendPropertyChanged("idTipoNorma");
			}
		}
	}

	[Column(Storage = "_DescripTipoNorma", DbType = "VarChar(50)")]
	public string DescripTipoNorma
	{
		get
		{
			return _DescripTipoNorma;
		}
		set
		{
			if (!string.Equals(_DescripTipoNorma, value))
			{
				SendPropertyChanging();
				_DescripTipoNorma = value;
				SendPropertyChanged("DescripTipoNorma");
			}
		}
	}

	[Association(Name = "CJRTipoNorma_CJRNormaRegional", Storage = "_CJRNormaRegional", ThisKey = "idTipoNorma", OtherKey = "idTipoNorma")]
	public EntitySet<CJRNormaRegional> CJRNormaRegional
	{
		get
		{
			return _CJRNormaRegional;
		}
		set
		{
			_CJRNormaRegional.Assign(value);
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public CJRTipoNorma()
	{
		_CJRNormaRegional = new EntitySet<CJRNormaRegional>(attach_CJRNormaRegional, detach_CJRNormaRegional);
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

	private void attach_CJRNormaRegional(CJRNormaRegional entity)
	{
		SendPropertyChanging();
		entity.CJRTipoNorma = this;
	}

	private void detach_CJRNormaRegional(CJRNormaRegional entity)
	{
		SendPropertyChanging();
		entity.CJRTipoNorma = null;
	}
}
