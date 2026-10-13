using System.Diagnostics;

namespace GRLL.Common;

public class TRAEtapa_ProcedimientoMapper : GenericMapper<TRAEtapa_Procedimiento, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public TRAEtapa_ProcedimientoMapper()
	{
	}

	public static GenericMapper<TRAEtapa_Procedimiento, dcGRLLDataContext> Instance()
	{
		GenericMapper<TRAEtapa_Procedimiento, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<TRAEtapa_Procedimiento, dcGRLLDataContext>.InstanceBase();
	}
}
