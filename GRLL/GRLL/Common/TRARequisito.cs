using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.TRARequisito")]
public class TRARequisito : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdRequisito;

	private string _Descripcion;

	private EntitySet<TRAProcedimiento_Requisito> _TRAProcedimiento_Requisito;

	private EntitySet<TRATramite_Requisito> _TRATramite_Requisito;

	[Column(Storage = "_IdRequisito", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdRequisito
	{
		get
		{
			return _IdRequisito;
		}
		set
		{
			if (_IdRequisito != value)
			{
				SendPropertyChanging();
				_IdRequisito = value;
				SendPropertyChanged("IdRequisito");
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(100)")]
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

	[Association(Name = "TRARequisito_TRAProcedimiento_Requisito", Storage = "_TRAProcedimiento_Requisito", ThisKey = "IdRequisito", OtherKey = "IdRequisito")]
	public EntitySet<TRAProcedimiento_Requisito> TRAProcedimiento_Requisito
	{
		get
		{
			return _TRAProcedimiento_Requisito;
		}
		set
		{
			_TRAProcedimiento_Requisito.Assign(value);
		}
	}

	[Association(Name = "TRARequisito_TRATramite_Requisito", Storage = "_TRATramite_Requisito", ThisKey = "IdRequisito", OtherKey = "IdRequisito")]
	public EntitySet<TRATramite_Requisito> TRATramite_Requisito
	{
		get
		{
			return _TRATramite_Requisito;
		}
		set
		{
			_TRATramite_Requisito.Assign(value);
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public TRARequisito()
	{
		_TRAProcedimiento_Requisito = new EntitySet<TRAProcedimiento_Requisito>(attach_TRAProcedimiento_Requisito, detach_TRAProcedimiento_Requisito);
		_TRATramite_Requisito = new EntitySet<TRATramite_Requisito>(attach_TRATramite_Requisito, detach_TRATramite_Requisito);
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

	private void attach_TRAProcedimiento_Requisito(TRAProcedimiento_Requisito entity)
	{
		SendPropertyChanging();
		entity.TRARequisito = this;
	}

	private void detach_TRAProcedimiento_Requisito(TRAProcedimiento_Requisito entity)
	{
		SendPropertyChanging();
		entity.TRARequisito = null;
	}

	private void attach_TRATramite_Requisito(TRATramite_Requisito entity)
	{
		SendPropertyChanging();
		entity.TRARequisito = this;
	}

	private void detach_TRATramite_Requisito(TRATramite_Requisito entity)
	{
		SendPropertyChanging();
		entity.TRARequisito = null;
	}
}
