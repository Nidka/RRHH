using System.Diagnostics;

namespace GRLL.Common;

public class TRADocumentoMapper : GenericMapper<TRADocumento, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public TRADocumentoMapper()
	{
	}

	public static GenericMapper<TRADocumento, dcGRLLDataContext> Instance()
	{
		GenericMapper<TRADocumento, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<TRADocumento, dcGRLLDataContext>.InstanceBase();
	}
}
