using System.Diagnostics;

namespace GRLL.Common;

public class TipoDocIDMapper : GenericMapper<TipoDocID, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public TipoDocIDMapper()
	{
	}

	public static GenericMapper<TipoDocID, dcGRLLDataContext> Instance()
	{
		GenericMapper<TipoDocID, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<TipoDocID, dcGRLLDataContext>.InstanceBase();
	}
}
