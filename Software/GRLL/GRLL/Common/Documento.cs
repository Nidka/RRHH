using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Documento")]
public class Documento : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _idDocumento;

	private string _DescripDocumento;

	private EntitySet<Archivo> _Archivo;

	[Column(Storage = "_idDocumento", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int idDocumento
	{
		get
		{
			return _idDocumento;
		}
		set
		{
			if (_idDocumento != value)
			{
				SendPropertyChanging();
				_idDocumento = value;
				SendPropertyChanged("idDocumento");
			}
		}
	}

	[Column(Storage = "_DescripDocumento", DbType = "VarChar(50)")]
	public string DescripDocumento
	{
		get
		{
			return _DescripDocumento;
		}
		set
		{
			if (!string.Equals(_DescripDocumento, value))
			{
				SendPropertyChanging();
				_DescripDocumento = value;
				SendPropertyChanged("DescripDocumento");
			}
		}
	}

	[Association(Name = "Documento_Archivo", Storage = "_Archivo", ThisKey = "idDocumento", OtherKey = "idDocumento")]
	public EntitySet<Archivo> Archivo
	{
		get
		{
			return _Archivo;
		}
		set
		{
			_Archivo.Assign(value);
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Documento()
	{
		_Archivo = new EntitySet<Archivo>(attach_Archivo, detach_Archivo);
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

	private void attach_Archivo(Archivo entity)
	{
		SendPropertyChanging();
		entity.Documento = this;
	}

	private void detach_Archivo(Archivo entity)
	{
		SendPropertyChanging();
		entity.Documento = null;
	}
}
