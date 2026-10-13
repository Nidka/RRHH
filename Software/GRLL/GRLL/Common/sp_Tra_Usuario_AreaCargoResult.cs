using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class sp_Tra_Usuario_AreaCargoResult
{
	private int _idareaorganiz;

	private int? _idcargo;

	[Column(Storage = "_idareaorganiz", DbType = "Int NOT NULL")]
	public int idareaorganiz
	{
		get
		{
			return _idareaorganiz;
		}
		set
		{
			if (_idareaorganiz != value)
			{
				_idareaorganiz = value;
			}
		}
	}

	[Column(Storage = "_idcargo", DbType = "Int")]
	public int? idcargo
	{
		get
		{
			return _idcargo;
		}
		set
		{
			if (!_idcargo.Equals(value))
			{
				_idcargo = value;
			}
		}
	}
}
