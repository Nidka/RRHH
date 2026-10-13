using System.Diagnostics;

namespace GRLL.Common;

public class TRAAdjuntoMapper : GenericMapper<TRAAdjunto, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public TRAAdjuntoMapper()
	{
	}

	public static GenericMapper<TRAAdjunto, dcGRLLDataContext> Instance()
	{
		GenericMapper<TRAAdjunto, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<TRAAdjunto, dcGRLLDataContext>.InstanceBase();
	}
}
