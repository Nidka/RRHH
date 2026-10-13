using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spEstructOrganiz_Select_LstResult
{
	private int _idAreaOrganiz;

	private string _LstAreaO;

	[Column(Storage = "_idAreaOrganiz", DbType = "Int NOT NULL")]
	public int idAreaOrganiz
	{
		get
		{
			return _idAreaOrganiz;
		}
		set
		{
			if (_idAreaOrganiz != value)
			{
				_idAreaOrganiz = value;
			}
		}
	}

	[Column(Storage = "_LstAreaO", DbType = "VarChar(205)")]
	public string LstAreaO
	{
		get
		{
			return _LstAreaO;
		}
		set
		{
			if (!string.Equals(_LstAreaO, value))
			{
				_LstAreaO = value;
			}
		}
	}
}
