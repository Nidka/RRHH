using System.Diagnostics;

namespace GRLL.Common;

public class TRARequisitoMapper : GenericMapper<TRARequisito, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public TRARequisitoMapper()
	{
	}

	public static GenericMapper<TRARequisito, dcGRLLDataContext> Instance()
	{
		GenericMapper<TRARequisito, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<TRARequisito, dcGRLLDataContext>.InstanceBase();
	}
}
