using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.MaterialViv")]
public class MaterialViv : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdMaterial;

	private string _DescripMaterial;

	private EntitySet<Vivienda> _Vivienda;

	[Column(Storage = "_IdMaterial", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdMaterial
	{
		get
		{
			return _IdMaterial;
		}
		set
		{
			if (_IdMaterial != value)
			{
				SendPropertyChanging();
				_IdMaterial = value;
				SendPropertyChanged("IdMaterial");
			}
		}
	}

	[Column(Storage = "_DescripMaterial", DbType = "VarChar(12)")]
	public string DescripMaterial
	{
		get
		{
			return _DescripMaterial;
		}
		set
		{
			if (!string.Equals(_DescripMaterial, value))
			{
				SendPropertyChanging();
				_DescripMaterial = value;
				SendPropertyChanged("DescripMaterial");
			}
		}
	}

	[Association(Name = "MaterialViv_Vivienda", Storage = "_Vivienda", ThisKey = "IdMaterial", OtherKey = "IdMaterial")]
	public EntitySet<Vivienda> Vivienda
	{
		get
		{
			return _Vivienda;
		}
		set
		{
			_Vivienda.Assign(value);
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public MaterialViv()
	{
		_Vivienda = new EntitySet<Vivienda>(attach_Vivienda, detach_Vivienda);
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

	private void attach_Vivienda(Vivienda entity)
	{
		SendPropertyChanging();
		entity.MaterialViv = this;
	}

	private void detach_Vivienda(Vivienda entity)
	{
		SendPropertyChanging();
		entity.MaterialViv = null;
	}
}
