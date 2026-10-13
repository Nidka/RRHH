using System.Diagnostics;

namespace GRLL.Common;

public class TRAProcedimientoMapper : GenericMapper<TRAProcedimiento, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public TRAProcedimientoMapper()
	{
	}

	public static GenericMapper<TRAProcedimiento, dcGRLLDataContext> Instance()
	{
		GenericMapper<TRAProcedimiento, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<TRAProcedimiento, dcGRLLDataContext>.InstanceBase();
	}
}
